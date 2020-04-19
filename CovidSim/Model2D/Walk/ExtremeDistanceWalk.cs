using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidSim.Model2D.Walk
{
    public class ExtremeDistanceWalk : WalkStrategy
    {
        double range;
        double a;

        public class Settings : SettingsBase
        {
            double linearity;

            public double Linearity
            {
                get => linearity;

                set
                {
                    if (value < -3 || value > 3)
                        throw new ArgumentException("Linearity should be in range from -2 to 2 (inclusive)");
                    linearity = value;
                }
            }

            public override WalkStrategy Create()
            {
                var walk = new ExtremeDistanceWalk();
                walk.Config = this;
                return walk;
            }
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
            double x = RandomUtils.Random.NextDouble();
            return Config.MinWalk + range * (a - 1) * x / (a - x);
        }
    }
}
