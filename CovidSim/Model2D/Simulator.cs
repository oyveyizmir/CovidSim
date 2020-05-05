using CovidSim.Model2D.Avoidance;
using CovidSim.Model2D.Walk;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidSim.Model2D
{
    public class Simulator
    {
        public List<Human> Humans { get; private set; } = new List<Human>();

        public int Time { get; private set; }

        public Settings Settings { get; set; } = new Settings();

        public Statistics Stats { get; private set; } = new Statistics();

        public int SegmentCount
        {
            get => segmentCount;

            set
            {
                if (value < 1)
                    throw new ArgumentException("SegmentCount");
                segmentCount = value;
                maxSegment = value - 1;
            }
        }
        
        int segmentCount;
        int maxSegment;
        Area[,] areas;
        double segmentSize;
        IWalkStrategy walk;
        AvoidanceStrategy avoidance;
        Point[] newPositions;

        public Simulator()
        {
            SegmentCount = 50;
        }

        public void Initialize()
        {
            Settings.Validate();

            walk = Settings.Walk.CreateWalkStrategy();
            walk.Initialize();

            avoidance = Settings.Avoidance.CreateStrategy();

            segmentSize = Settings.WorldSize / segmentCount;
            areas = new Area[segmentCount, segmentCount];
            for (int i = 0; i < segmentCount; i++)
                for (int j = 0; j < segmentCount; j++)
                    areas[i, j] = new Area();

            newPositions = new Point[Settings.Population];

            Stats.SusceptibleCount = Settings.Population;

            for (var i = 0; i < Settings.Population; i++)
            {
                var human = new Human();
                human.Position = new Point(RandomUtils.GetDouble(Settings.WorldSize), RandomUtils.GetDouble(Settings.WorldSize));
                AddHuman(human);
            }

            for (var i = 0; i < Settings.InitiallyInfected;)
            {
                var index = RandomUtils.GetInt(Humans.Count);
                var human = Humans[index];
                if (!human.IsInfected)
                {
                    Infect(human, GetArea(human.Position));
                    i++;
                }
            }
        }

        public void Step()
        {
            Time++;
            Move();
            Infect();
            Remove();
            Quarantine();
        }

        int GetSegment(double coord)
        {
            int segment = (int)Math.Floor(coord / segmentSize);
            if (segment == segmentCount)
                return segment - 1; //TODO: change in toroidal world
            else
                return segment;
        }

        void AddHuman(Human human)
        {
            Humans.Add(human);
            GetArea(human.Position).Add(human);
        }

        Area GetArea(Point point)
        {
            return areas[GetSegment(point.X), GetSegment(point.Y)];
        }

        Area GetArea(AreaPosition position)
        {
            return areas[position.X, position.Y];
        }

        void Move()
        {
            for (int i = 0; i < Humans.Count; i++)
            {
                var human = Humans[i];
                if (!human.IsAlive || human.IsQuarantined)
                    continue;

                var moveVector = walk.GetMoveVector();

                if (avoidance != null)
                {
                    //Own area
                    var position = human.Position;
                    int segX = GetSegment(position.X);
                    int segY = GetSegment(position.Y);
                    Point avoidanceVector = AvoidOwnArea(areas[segX, segY], human);

                    //Left
                    int startX = LimitSegment(GetSegment(position.X - avoidance.Config.Range));
                    for (int x = startX; x < segX; x++)
                        avoidanceVector += AvoidArea(areas[x, segY], position);

                    //Right
                    int endX = LimitSegment(GetSegment(position.X + avoidance.Config.Range));
                    for (int x = endX; x > segX; x--)
                        avoidanceVector += AvoidArea(areas[x, segY], position);

                    //Top
                    int startY = LimitSegment(GetSegment(position.Y - avoidance.Config.Range));
                    for (int y = startY; y < segY; y++)
                        avoidanceVector += AvoidArea(areas[segX, y], position);

                    //Bottom
                    int endY = LimitSegment(GetSegment(position.Y + avoidance.Config.Range));
                    for (int y = endY; y > segY; y--)
                        avoidanceVector += AvoidArea(areas[segX, y], position);

                    //Top left
                    for (int y = startY; y < segY; y++)
                    {
                        bool skipCheck = false;
                        for (int x = startX; x < segX; x++)
                            if (skipCheck || position.DistanceTo(new Point((x + 1) * segmentSize, (y + 1) * segmentSize)) < avoidance.Config.Range)
                            {
                                avoidanceVector += AvoidArea(areas[x, y], position);
                                skipCheck = true;
                            }
                    }

                    /*AreaPosition ap = new AreaPosition(segmentSize);
                    for (ap.Y = startY; ap.Y < segY; ap.Y++)
                    {
                        for (ap.X = startX; ap.X < segX; ap.X++)
                            if (position.DistanceTo(ap.BottomRight) < avoidance.Config.Range)
                            {
                                moveVector += AvoidArea(ap, position);
                                break;
                            }

                        for (; ap.X < segX; ap.X++)
                            moveVector += AvoidArea(ap, position);
                    }*/

                    //Top right
                    for (int y = startY; y < segY; y++)
                    {
                        bool skipCheck = false;
                        for (int x = endX; x > segX; x--)
                            if (skipCheck || position.DistanceTo(new Point(x * segmentSize, (y + 1) * segmentSize)) < avoidance.Config.Range)
                            {
                                avoidanceVector += AvoidArea(areas[x, y], position);
                                skipCheck = true;
                            }
                    }

                    //Bottom left
                    for (int y = endY; y > segY; y--)
                    {
                        bool skipCheck = false;
                        for (int x = startX; x < segX; x++)
                            if (skipCheck || position.DistanceTo(new Point((x + 1) * segmentSize, y * segmentSize)) < avoidance.Config.Range)
                            {
                                avoidanceVector += AvoidArea(areas[x, y], position);
                                skipCheck = true;
                            }
                    }

                    //Bottom right
                    for (int y = endY; y > segY; y--)
                    {
                        bool skipCheck = false;
                        for (int x = endX; x > segX; x--)
                            if (skipCheck || position.DistanceTo(new Point(x * segmentSize, y * segmentSize)) < avoidance.Config.Range)
                            {
                                avoidanceVector += AvoidArea(areas[x, y], position);
                                skipCheck = true;
                            }
                    }

                    if (avoidance.Config.MaxStep != null)
                    {
                        double lengthSquared = avoidanceVector.LengthSquared;
                        if (lengthSquared > avoidance.MaxStepSquared)
                        {
                            double length = Math.Sqrt(lengthSquared);
                            double scaleFactor = avoidance.MaxStep / length;
                            avoidanceVector = avoidanceVector.Scale(scaleFactor);
                        }
                    }

                    moveVector += avoidanceVector;
                }

                newPositions[i] = LimitPosition(human.Position + moveVector);
            }

            for (int i = 0; i < Humans.Count; i++)
            {
                var human = Humans[i];
                if (!human.IsAlive || human.IsQuarantined)
                    continue;

                var oldArea = GetArea(human.Position);
                human.Position = newPositions[i];
                var newArea = GetArea(human.Position);
                if (oldArea != newArea)
                {
                    oldArea.Remove(human);
                    newArea.Add(human);
                }
            }
        }

        Point AvoidArea(AreaPosition areaPosition, Point humanPosition) => AvoidArea(GetArea(areaPosition), humanPosition);

        Point AvoidArea(Area area, Point position)
        {
            Point moveVector = Point.Null;
            for (int i = 0; i < area.Humans.Count; i++)
            {
                var @object = area.Humans[i];
                if (@object.IsAlive)
                    moveVector += avoidance.GetMoveVector(position, @object.Position);
            }
            return moveVector;
        }

        Point AvoidOwnArea(Area area, Human human)
        {
            Point moveVector = Point.Null;
            for (int i = 0; i < area.Humans.Count; i++)
            {
                var @object = area.Humans[i];
                if (@object != human && @object.IsAlive)
                    moveVector += avoidance.GetMoveVector(human.Position, @object.Position);
            }
            return moveVector;
        }

        int LimitSegment(int segment) => Limit(segment, maxSegment);

        Point LimitPosition(Point point) => Limit(point, Settings.WorldSize);

        static Point Limit(Point point, double max)
        {
            return new Point(Limit(point.X, max), Limit(point.Y, max));
        }

        static T Limit<T>(T value, T max) where T : IComparable<T>
        {
            if (value.CompareTo(default(T)) < 0)
                return default(T);
            if (value.CompareTo(max) > 0)
                return max;
            return value;
        }

        static double Wrap(double value, double max)
        {
            if (value < 0 || value >= max)
            {
                double relativeValue = value / max;
                double fraction = relativeValue - Math.Floor(relativeValue);
                return fraction * max;
            }
            else
                return value;
        }

        static Point Wrap(Point point, double max)
        {
            return new Point(Wrap(point.X, max), Wrap(point.Y, max));
        }

        void Infect()
        {
            double transmissionProbabilityRange = Settings.TransmissionProbabilityAtRange - Settings.TransmissionProbabilityAt0;

            for (int segX = 0; segX < segmentCount; segX++)
                for (int segY = 0; segY < segmentCount; segY++)
                {
                    int segRange = (int)Math.Floor(Settings.TransmissionRange / segmentSize) + 1;
                    int segStartX = Limit(segX - segRange, maxSegment);
                    int segStartY = Limit(segY - segRange, maxSegment);
                    int segEndX = Limit(segX + segRange, maxSegment) + 1;
                    int segEndY = Limit(segY + segRange, maxSegment) + 1;

                    foreach (var subject in areas[segX, segY].Humans.Where(x => x.CanInfect(Time)))
                        for (int x = segStartX; x < segEndX; x++)
                            for (int y = segStartY; y < segEndY; y++)
                                InfectArea(areas[x, y], subject, transmissionProbabilityRange);
                }
        }

        void InfectArea(Area area, Human subject, double transmissionProbabilityRange)
        {
            for (int i = 0; i < area.Susceptible.Count; i++)
            {
                var @object = area.Susceptible[i];
                if (@object.CanBeInfected)
                {
                    double distance = Point.Distance(subject.Position, @object.Position);
                    if (distance <= Settings.TransmissionRange)
                    {
                        double transmissionProbability = Settings.TransmissionProbabilityAt0
                            + transmissionProbabilityRange * distance / Settings.TransmissionRange;
                        if (RandomUtils.LessThanThreshold(transmissionProbability))
                        {
                            Infect(@object, area);
                            i--;
                        }
                    }
                }
            }
        }

        IEnumerable<Human> GetHumansWithinRange(Point point, double range)
        {
            int segX = GetSegment(point.X);
            int segY = GetSegment(point.Y);
            int segRange = (int)Math.Floor(range / segmentSize) + 1;
            int segStartX = Limit(segX - segRange, maxSegment);
            int segStartY = Limit(segY - segRange, maxSegment);
            int segEndX = Limit(segX + segRange, maxSegment) + 1;
            int segEndY = Limit(segY + segRange, maxSegment) + 1;

            for (int x = segStartX; x < segEndX; x++)
                for (int y = segStartY; y < segEndY; y++)
                    foreach (var human in areas[x, y].Humans)
                        yield return human;
        }

        List<Area> GetAreasWithinRange(int segX, int segY, double range)
        {
            int segRange = (int)Math.Floor(range / segmentSize) + 1;
            int segStartX = Limit(segX - segRange, maxSegment);
            int segStartY = Limit(segY - segRange, maxSegment);
            int segEndX = Limit(segX + segRange, maxSegment) + 1;
            int segEndY = Limit(segY + segRange, maxSegment) + 1;

            int squareSide = 2 * segRange + 1;
            var result = new List<Area>(squareSide * squareSide);

            for (int x = segStartX; x < segEndX; x++)
                for (int y = segStartY; y < segEndY; y++)
                    result.Add(areas[x, y]);

            return result;
        }

        void Infect(Human human, Area area)
        {
            human.IsInfected = true;
            human.InfectionTime = Time;
            human.TimeToRemoval = Settings.IllnessDuration;

            Stats.InfectedTotalCount++;
            Stats.InfectedCount++;
            Stats.SusceptibleCount--;

            area.Susceptible.Remove(human);
        }

        void Die(Human human)
        {
            human.IsAlive = false;

            Stats.InfectedCount--;
            Stats.DiedCount++;

            if (human.IsQuarantined)
                Stats.Quarantined--;
        }

        void Recover(Human human)
        {
            human.IsImmune = true;
            human.IsInfected = false;
            
            Stats.InfectedCount--;
            Stats.RecoveredCount++;

            if (human.IsQuarantined)
            {
                human.IsQuarantined = false;
                Stats.Quarantined--;
            }
        }

        void Remove()
        {
            foreach (var human in Humans.Where(x => x.CanBeRemoved(Time)))
            {
                if (--human.TimeToRemoval <= 0)
                {
                    if (RandomUtils.LessThanThreshold(Settings.FatalityRate))
                        Die(human);
                    else
                        Recover(human);
                }
            }
        }

        void Quarantine()
        {
            if (!Settings.Quarantine.Enabled)
                return;

            for (int i = 0; i < Humans.Count; i++)
            {
                var human = Humans[i];
                if (!human.IsAlive || !human.IsInfected || human.IsQuarantined)
                    continue;

                if (Time - human.InfectionTime < Settings.Quarantine.StartTime)
                    continue;

                if (RandomUtils.LessThanThreshold(Settings.Quarantine.Probability))
                {
                    human.IsQuarantined = true;
                    Stats.Quarantined++;
                }
            }
        }
    }
}
