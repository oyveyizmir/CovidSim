using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidSim.SimpleModel
{
    public class Settings : BasicSettings
    {
        double transitionRate = 0.2;
        double fatalityRate = 0.2;
        double illnessDuration = 21;

        /// <summary>
        /// Transition rate is the number of contacts per person per time,
        /// multiplied by the probability of disease transmission in a contact.
        /// In other words it is the number of persons infected by an infectios person per time.
        /// </summary>
        public double TransitionRate
        {
            get => transitionRate;

            set
            {
                if (value < 0)
                    throw new ArgumentException("TransitionRate");
                transitionRate = value;
            }
        }

        public double IllnessDuration
        {
            get => illnessDuration;

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
            get => fatalityRate;

            set
            {
                if (value < 0 || value > 1)
                    throw new ArgumentException("FatalityRate");
                fatalityRate = value;
            }
        }

        public Settings()
        {
            Population = 1000000;
            InitiallyInfected = 1;
        }

        public override void Validate()
        {
            if (Population < InitiallyInfected)
                throw new InvalidOperationException("Population cannot be less than InitiallyInfected");
        }
    }
}
