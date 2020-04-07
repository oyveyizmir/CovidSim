using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidSim
{
    public class BasicSettings
    {
        int population;
        int initiallyInfected;

        public int Population
        {
            get { return population; }

            set
            {
                if (value < 1)
                    throw new ArgumentException("Population");
                population = value;
            }
        }

        public int InitiallyInfected
        {
            get { return initiallyInfected; }

            set
            {
                if (value < 0)
                    throw new ArgumentException("InitiallyInfected");
                initiallyInfected = value;
            }
        }
    }
}
