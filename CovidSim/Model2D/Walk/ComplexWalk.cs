using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidSim.Model2D.Walk
{
    public class ComplexWalk : WalkStrategy
    {
        public class RangeSettings : MinMaxSettings
        {
            double probability = 1;

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

        public class Settings : ISettings
        {
            public List<RangeSettings> Ranges { get; set; } = new List<RangeSettings>();

            public WalkStrategy CreateWalkStrategy() => new ComplexWalk { Config = this };

            public RangeSettings LastRange => Ranges[Ranges.Count - 1];

            public void AddRange(double probability, double minWalk, double maxWalk)
            {
                Ranges.Add(new RangeSettings()
                {
                    Probability = probability,
                    MinWalk = minWalk,
                    MaxWalk = maxWalk
                });
            }

            public void Validate()
            {
                if (Ranges.Count == 0)
                    throw new ValidationException("At lease one range is required");

                double prevProbability = double.MinValue;

                for (int i = 0; i < Ranges.Count; i++)
                {
                    var range = Ranges[i];
                    if (i < Ranges.Count - 1 && range.Probability <= prevProbability)
                        throw new ValidationException($"Probability {range.Probability} should be greater than previos value ({prevProbability})");
                    range.Validate();
                    prevProbability = range.Probability;
                }
            }
        }

        public Settings Config { get; set; } = new Settings();

        public override void Initialize()
        {
            Config.Validate();
            Config.LastRange.Probability = 1;
        }

        protected override double GetRange()
        {
            double random = RandomUtils.GetDouble();

            for (int i = 0; i < Config.Ranges.Count; i++)
                if (random < Config.Ranges[i].Probability)
                    return RandomUtils.GetDouble(Config.Ranges[i].MinWalk, Config.Ranges[i].MaxWalk);

            return RandomUtils.GetDouble(Config.LastRange.MinWalk, Config.LastRange.MaxWalk);
        }
    }
}
