using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidSim.Model2D
{
    public class QuarantineSettings
    {
        bool enabled;
        int startTime = 0;
        double probability = 0.01;
        int? maxCapacity = 100;

        public bool Enabled
        {
            get => enabled && probability != 0 && (maxCapacity != null ? maxCapacity.Value != 0 : true);
            set => enabled = value;
        }

        public int StartTime
        {
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

        public int? MaxCapacity
        {
            get => maxCapacity;

            set
            {
                if (value != null && value < 0)
                    throw new ArgumentException("MaxCapacity");
                maxCapacity = value;
            }
        }
    }
}
