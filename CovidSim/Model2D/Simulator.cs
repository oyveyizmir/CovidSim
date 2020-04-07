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

            Stats.SusceptibleCount = Settings.Population - Settings.InitiallyInfected;
            Stats.InfectedCount = Settings.InitiallyInfected;
            Stats.InfectedTotalCount = Settings.InitiallyInfected;
            Stats.MaxInfectedCount = int.MinValue;

            for (var i = 0; i < Settings.Population; i++)
                humans.Add(new Human());

            for (var i = 0; i < Settings.InitiallyInfected; i++)
            {
                var index = Utils.Random.Next(humans.Count);
                var human = humans[index];
                //if (human.IsInfected)
                //    continue;
                //else
                //    human.Infect(this);
            }
        }

        public void Step()
        {

        }
    }
}
