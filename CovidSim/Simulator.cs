using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidSim
{
    public class Simulator
    {
        public int Time { get; set; }

        public Settings Settings = new Settings();
        public IList<Human> Humans = new List<Human>();
        public Statistics Statistics = new Statistics();

        public Simulator()
        {
        }

        public void Initialize()
        {
            for (var i = 0; i < Settings.PopulaceCount; i++)
                Humans.Add(new Human());

            for (var i = 0; i < Settings.InitiallyInfected; i++)
            {
                var index = Utils.Random.Next(Humans.Count);
                var human = Humans[index];
                if (human.IsInfected)
                    continue;
                else
                    human.Infect(this);
            }

            Statistics.SusceptibleCount = Settings.PopulaceCount;
        }

        public void Step()
        {
            for (var i = 0; i < Humans.Count; i++)
            {
                var human = Humans[i];
                human.Act(i, this);
                if (!human.IsAlive)
                    Humans.RemoveAt(i);
            }

            for (var i = 0; i < Humans.Count; i++)
            {
                if (Utils.LessThanThreshold(Settings.SwapProbability))
                {
                    var index = Utils.Random.Next(Humans.Count);
                    var tmp = Humans[index];
                    Humans[index] = Humans[i];
                    Humans[i] = tmp;
                }
            }

            Time++;
        }
    }
}
