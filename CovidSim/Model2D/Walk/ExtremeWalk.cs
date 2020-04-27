﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidSim.Model2D.Walk
{
    public class ExtremeWalk : WalkStrategy
    {
        const double minLinearity = -7;
        const double maxLinearity = 3;

        double range;
        double a;

        public class Settings : MinMaxSettings, ISettings
        {
            double linearity = -2;

            public double Linearity
            {
                get => linearity;

                set
                {
                    if (value < minLinearity || value > maxLinearity)
                        throw new ArgumentException($"Linearity should be in range from {minLinearity} to {maxLinearity} (inclusive)");
                    linearity = value;
                }
            }

            public WalkStrategy CreateWalkStrategy() => new ExtremeWalk { Config = this };
        }

        public Settings Config { get; set; } = new Settings();

        public override void Initialize()
        {
            Config.Validate();

            range = Config.MaxWalk - Config.MinWalk;
            a = 1 + Math.Pow(10, Config.Linearity);
        }

        protected override double GetRange()
        {
            double x = RandomUtils.GetDouble();
            double r = Config.MinWalk + range * (a - 1) * x / (a - x);
            return r;
        }
    }
}
