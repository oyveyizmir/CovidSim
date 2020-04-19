using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidSim
{
    public abstract class BasicSettings : IValidatable
    {
        int population;
        int initiallyInfected;

        public int Population
        {
            get => population;

            set
            {
                if (value < 1)
                    throw new ArgumentException("Population");
                population = value;
            }
        }

        public int InitiallyInfected
        {
            get => initiallyInfected;

            set
            {
                if (value < 0)
                    throw new ArgumentException("InitiallyInfected");
                initiallyInfected = value;
            }
        }

        public abstract void Validate();
    }
}
