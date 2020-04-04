using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidSim.SimpleModel
{
    public class Settings
    {
        int population = 1000000;
        int initiallyInfected = 1;
        double transitionRate = 0.2;
        double fatalityRate = 0.2;
        double illnessDuration = 21;

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

        /// <summary>
        /// Transition rate is the number of contacts per person per time,
        /// multiplied by the probability of disease transmission in a contact.
        /// In other words it is the number of persons infected by an infectios person per time.
        /// </summary>
        public double TransitionRate
        {
            get { return transitionRate; }

            set
            {
                if (value < 0)
                    throw new ArgumentException("TransitionRate");
                transitionRate = value;
            }
        }

        public double IllnessDuration
        {
            get { return illnessDuration; }

            set
            {
                if (value <= 0)
                    throw new ArgumentException("IllnessDiration");
                illnessDuration = value;
            }
        }

        /// <summary>
        /// Died / (Recovered + Died)
        /// </summary>
        public double FatalityRate
        {
            get { return fatalityRate; }

            set
            {
                if (value < 0 || value > 1)
                    throw new ArgumentException("FatalityRate");
                fatalityRate = value;
            }
        }
    }
}
