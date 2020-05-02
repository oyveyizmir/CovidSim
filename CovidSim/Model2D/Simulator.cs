using CovidSim.Model2D.Avoidance;
using CovidSim.Model2D.Walk;
using System;
using System.Collections.Generic;
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

        public Simulator()
        {
            SegmentCount = 20;
        }

        public void Initialize()
        {
            Settings.Validate();

            walk = Settings.Walk.CreateWalkStrategy();
            walk.Initialize();

            Settings.Avoidance.Enabled = true;
            avoidance = Settings.Avoidance.CreateStrategy();

            segmentSize = Settings.WorldSize / segmentCount;
            areas = new Area[segmentCount, segmentCount];
            for (int i = 0; i < segmentCount; i++)
                for (int j = 0; j < segmentCount; j++)
                    areas[i, j] = new Area();

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
        }

        int GetSegment(double coord)
        {
            int segment = (int)(coord / segmentSize);
            if (segment == segmentCount)
                return segment - 1;
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

        void Move()
        {
            foreach (var human in Humans)
            {
                var randomWalkVector = walk.GetMoveVector();

                int segX = GetSegment(human.Position.X);
                int segY = GetSegment(human.Position.Y);
                var oldArea = areas[segX, segY];

                if (avoidance != null)
                {
                    int segRange = (int)Math.Floor(avoidance.Config.Range / segmentSize) + 1;
                    int segStartX = Limit(segX - segRange, maxSegment);
                    int segStartY = Limit(segY - segRange, maxSegment);
                    int segEndX = Limit(segX + segRange, maxSegment) + 1;
                    int segEndY = Limit(segY + segRange, maxSegment) + 1;

                    foreach (var @object in areas[segX, segY].Humans.Where(x => x != human))
                    {
                        var vector = avoidance.GetMoveVector(human.Position, @object.Position);
                        randomWalkVector += vector;
                    }
                }

                human.Position = Limit(human.Position + randomWalkVector, Settings.WorldSize);
                var newArea = GetArea(human.Position);
                if (oldArea != newArea)
                {
                    oldArea.Remove(human);
                    newArea.Add(human);
                }
            }
        }

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
        }

        void Recover(Human human)
        {
            human.IsImmune = true;
            human.IsInfected = false;
            Stats.InfectedCount--;
            Stats.RecoveredCount++;
        }

        void Remove()
        {
            foreach (var human in Humans.Where(x => x.CanInfect(Time)))
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
    }
}
