﻿using CovidSim.Model2D.Avoidance;
using CovidSim.Model2D.Walk;
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
        double transmissionProbabilityAt0 = 0.3;
        double transmissionProbabilityAtRange = 0;
        double reinfectionProbability = 0;
        double worldSize = 1000;
        int minIllnessDuration = 700;
        int maxIllnessDuration = 1300;
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

        public double ReinfectionProbability
        {
            get => reinfectionProbability;

            set
            {
                if (value < 0 || value > 1)
                    throw new ArgumentException("ReinfectionProbability");
                reinfectionProbability = value;
            }
        }

        public bool ReinfectionEnabled => reinfectionProbability > 0;

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

        public int MinIllnessDuration
        {
            get => minIllnessDuration;

            set
            {
                if (value <= 0)
                    throw new ArgumentException("MinIllnessDiration");
                minIllnessDuration = value;
            }
        }

        public int MaxIllnessDuration
        {
            get => maxIllnessDuration;

            set
            {
                if (value <= 0)
                    throw new ArgumentException("MaxIllnessDiration");
                maxIllnessDuration = value;
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

        public IWalkSettings Walk { get; set; } = new OneRangeWalkSettings();

        public AvoidanceStrategy.Settings Avoidance { get; set; } = new AvoidanceStrategy.Settings();

        public QuarantineSettings Quarantine { get; private set; } = new QuarantineSettings();

        public Settings()
        {
            Population = 10000;
            InitiallyInfected = 10;
        }

        public override void Validate()
        {
            if (Population < InitiallyInfected)
                throw new ValidationException("Population cannot be less than InitiallyInfected");

            if (Quarantine.StartTime >= maxIllnessDuration)
                throw new ValidationException("Quarantine start time should be less than maximum illness duration");

            if (minIllnessDuration > maxIllnessDuration)
                throw new ValidationException("Minimum illness duration cannot exceed maximum duration");

            Walk.Validate();
        }
    }
}
