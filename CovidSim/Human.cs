using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidSim
{
    public class Human
    {
        public bool IsAlive { get; set; } = true;
        public bool IsImmune { get; set; }
        public bool IsInfected
        {
            get { return TimeToRecovery > 0 || IsMortallyIll; }
        }

        public bool IsMortallyIll
        {
            get { return TimeToDeath > 0; }
        }

        public int TimeToDeath { get; set; }
        public int TimeToRecovery { get; set; }
        public int InfectionTime { get; set; }

        void TryToInfect(Simulator simulator)
        {
            if (Utils.LessThanThreshold(simulator.Settings.InfectionProbability))
                Infect(simulator);
        }

        public void Infect(Simulator simulator)
        {
            if (!IsAlive || IsImmune || IsInfected)
                return;

            Settings settings = simulator.Settings;

            if (Utils.LessThanThreshold(settings.FatalityRate))
                TimeToDeath = settings.MortallyInfectedLifeSpan;
            else
                TimeToRecovery = settings.IllnessDuration;

            simulator.Statistics.InfectedTotalCount++;
            simulator.Statistics.InfectedCount++;
            simulator.Statistics.SusceptibleCount--;
            InfectionTime = simulator.Time;
        }

        public void Act(int index, Simulator simulator)
        {
            if (!IsAlive || IsImmune || !IsInfected || InfectionTime >= simulator.Time)
                return;

            for (var i = 1; i <= simulator.Settings.TransmissionRange; i++)
            {
                var humanToInfect = simulator.Humans[(index + i) % simulator.Humans.Count];
                humanToInfect.TryToInfect(simulator);
            }

            if (IsMortallyIll)
            {
                if (--TimeToDeath == 0)
                {
                    IsAlive = false;
                    simulator.Statistics.InfectedCount--;
                    simulator.Statistics.DiedCount++;
                }
            }
            else
            {
                if (--TimeToRecovery == 0)
                {
                    IsImmune = true;
                    simulator.Statistics.InfectedCount--;
                    simulator.Statistics.RecoveredCount++;
                }
            }
        }
    }
}
