using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidSim.SimpleModel
{
    public class Simulator
    {
        public int Time { get; private set; }
        public Settings Settings = new Settings();
        public Statistics Stats { get; private set; } = new Statistics();

        public void Initialize()
        {
            if (Settings.Population < Settings.InitiallyInfected)
                throw new InvalidOperationException("Population cannot be less than InitiallyInfected");

            Stats.SusceptibleCount = Settings.Population - Settings.InitiallyInfected;
            Stats.InfectedCount = Settings.InitiallyInfected;
            Stats.InfectedTotalCount = Settings.InitiallyInfected;
        }

        public void Step()
        {
            double deltaSusceptible = -Settings.TransitionRate * Stats.InfectedCount * Stats.SusceptibleCount / Settings.Population;
            double deltaRemoved = Stats.InfectedCount / Settings.IllnessDuration;
            double deltaInfected = -deltaSusceptible - deltaRemoved;

            Stats.SusceptibleCount += deltaSusceptible;
            Stats.InfectedCount += deltaInfected;
            Stats.InfectedTotalCount += -deltaSusceptible;
            Stats.RecoveredCount += deltaRemoved * (1 - Settings.FatalityRate);
            Stats.DiedCount += deltaRemoved * Settings.FatalityRate;

            Time++;
        }
    }
}
