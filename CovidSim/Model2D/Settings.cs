using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidSim.Model2D
{
    public class Settings : BasicSettings
    {
        double transmissionRange = 10;
        double transmissionProbabilityAt0 = 1;
        double transmissionProbabilityAtRange = 0;
        double minWalk = 0;
        double maxWalk = 0.45;
        double worldSize = 1000;
        int illnessDuration = 300;
        double fatalityRate = 0.2;

        public double TransmissionRange
        {
            get => transmissionRange;

            set
            {
                if (value < 0)
                    throw new ArgumentException("TransmissionRange");
                transmissionRange = value;
            }
        }

        public double TransmissionProbabilityAt0
        {
            get => transmissionProbabilityAt0;

            set
            {
                if (value < 0 || value > 1)
                    throw new ArgumentException("TransmissionProbabilityAt0");
                transmissionProbabilityAt0 = value;
            }
        }

        public double TransmissionProbabilityAtRange
        {
            get => transmissionProbabilityAtRange;

            set
            {
                if (value < 0 || value > 1)
                    throw new ArgumentException("TransmissionProbabilityAtRange");
                transmissionProbabilityAtRange = value;
            }
        }

        public double MinWalk
        {
            get => minWalk;
            set
            {
                if (value < 0)
                    throw new ArgumentException("MinWalk");
                minWalk = value;
            }
        }

        public double MaxWalk
        {
            get => maxWalk;
            set
            {
                if (value < 0)
                    throw new ArgumentException("MaxWalk");
                maxWalk = value;
            }
        }

        public double WorldSize
        {
            get => worldSize;

            set
            {
                if (value <= 0)
                    throw new ArgumentException("WorldSize");
                worldSize = value;
            }
        }

        public int IllnessDuration
        {
            get => illnessDuration;

            set
            {
                if (value <= 0)
                    throw new ArgumentException("IllnessDiration");
                illnessDuration = value;
            }
        }

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
            Population = 10000;
            InitiallyInfected = 1;
        }
    }
}
