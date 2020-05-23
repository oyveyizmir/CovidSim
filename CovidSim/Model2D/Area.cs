using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidSim.Model2D
{
    class Area
    {
        public List<Human> Susceptible { get; private set; } = new List<Human>();

        public List<Human> Humans { get; private set; } = new List<Human>();

        public void Add(Human human)
        {
            Humans.Add(human);
            if (human.CanBeInfected)
                Susceptible.Add(human);
        }

        public void Remove(Human human)
        {
            Humans.Remove(human);
            Susceptible.Remove(human);
        }
    }
}
