﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidSim.Model2D.Walk
{
    public abstract class RangeSettings : IWalkSettings
    {
        double minWalk;
        double maxWalk;

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

        public RangeSettings() { }

        public RangeSettings(double minWalk, double maxWalk) => (MinWalk, MaxWalk) = (minWalk, maxWalk);

        public abstract IWalkStrategy CreateWalkStrategy();

        public void Validate()
        {
            if (minWalk > maxWalk)
                throw new ValidationException("MinWalk cannot exceed MaxWalk");
        }
    }
}
