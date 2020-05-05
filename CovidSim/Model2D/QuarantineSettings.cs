using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidSim.Model2D
{
    public class QuarantineSettings
    {
        int startTime = 100;
        double probability;

        public bool Enabled => probability != 0;

        public int StartTime {
            get => startTime;

            set
            {
                if (value < 0)
                    throw new ArgumentException("StartTime");
                startTime = value;
            }
        }

        public double Probability
        {
            get => probability;

            set
            {
                if (value < 0 || value > 1)
                    throw new ArgumentException("Probability");
                probability = value;
            }
        }
    }
}
