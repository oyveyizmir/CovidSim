using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidSim.Model2D
{
    public class Simulator
    {
        List<Human> humans = new List<Human>();

        public int Time { get; private set; }
        public Settings Settings = new Settings();
        public Statistics Stats { get; private set; } = new Statistics();

        public void Initialize()
        {
            if (Settings.Population < Settings.InitiallyInfected)
                throw new InvalidOperationException("Population cannot be less than InitiallyInfected");

            Stats.SusceptibleCount = Settings.Population;

            for (var i = 0; i < Settings.Population; i++)
            {
                var human = new Human();
                human.Position = new Point(RandomUtils.GetDouble(Settings.WorldSize), RandomUtils.GetDouble(Settings.WorldSize));
                humans.Add(human);
            }

            for (var i = 0; i < Settings.InitiallyInfected;)
            {
                var index = RandomUtils.GetInt(humans.Count);
                var human = humans[index];
                if (!human.IsInfected)
                {
                    Infect(human);
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

        void Move()
        {
            foreach (var human in humans)
            {
                double moveAngle = RandomUtils.GetDouble(0, 2 * Math.PI);
                double moveRange = RandomUtils.GetDouble(Settings.MinWalk, Settings.MaxWalk);
                Point randomWalkVector = new Point(moveRange * Math.Cos(moveAngle), moveRange * Math.Sin(moveAngle));
                human.Position += randomWalkVector; //TODO: wrap coordinates
            }
        }

        void Infect()
        {
            double transmissionProbabilityRange = Settings.TransmissionProbabilityAtRange - Settings.TransmissionProbabilityAt0;

            foreach (var human in humans)
            {
                if (!human.IsAlive || !human.IsInfected || human.InfectionTime >= Time)
                    continue;

                foreach (var humanToInfect in humans)
                {
                    if (!humanToInfect.IsAlive || humanToInfect.IsImmune || humanToInfect.IsInfected)
                        continue;

                    double distance = Point.Distance(human.Position, humanToInfect.Position);
                    if (distance <= Settings.TransmissionRange)
                    {
                        double transmissionProbability = Settings.TransmissionProbabilityAt0 + transmissionProbabilityRange * distance / Settings.TransmissionRange;
                        if (RandomUtils.LessThanThreshold(transmissionProbability))
                            Infect(humanToInfect);
                    }
                }
            }
        }

        void Infect(Human human)
        {
            human.IsInfected = true;
            human.InfectionTime = Time;
            Stats.InfectedTotalCount++;
            Stats.InfectedCount++;
            Stats.SusceptibleCount--;
        }

        void Remove()
        {

        }
    }
}
