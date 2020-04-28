using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidSim.Model2D.Walk
{
    public class TwoRangeWalk : IWalkStrategy
    {
        public class Settings : IWalkSettings
        {
            double probability;

            public double Probability1
            {
                get => probability;

                set
                {
                    if (value < 0 || value > 1)
                        throw new ArgumentException("Probability");
                    probability = value;
                }
            }

            public WalkSettings Range1 { get; set; }

            public WalkSettings Range2 { get; set; }

            public void Validate()
            {
                Range1.Validate();
                Range2.Validate();
            }

            public IWalkStrategy CreateWalkStrategy() => new TwoRangeWalk(this);
        }

        public Settings Config { get; private set; } = new Settings();

        IWalkStrategy walk1;
        IWalkStrategy walk2;

        public TwoRangeWalk(Settings config)
        {
            Config = config;
        }

        public void Initialize()
        {
            Config.Validate();
            walk1 = Config.Range1.CreateWalkStrategy();
            walk2 = Config.Range2.CreateWalkStrategy();
        }

        public Point GetMoveVector() => (RandomUtils.GetDouble() < Config.Probability1 ? walk1 : walk2).GetMoveVector();
    }
}
