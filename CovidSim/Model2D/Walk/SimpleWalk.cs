using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidSim.Model2D.Walk
{
    public class SimpleWalk : WalkStrategy
    {
        public class Settings : MinMaxSettings, ISettings
        {
            public Settings() => (MinWalk, MaxWalk) = (0, 0.2);

            public WalkStrategy CreateWalkStrategy() => new SimpleWalk { Config = this };
        }

        public Settings Config { get; set; } = new Settings();

        public override void Initialize()
        {
            Config.Validate();
        }

        protected override double GetRange()
        {
            return RandomUtils.GetDouble(Config.MinWalk, Config.MaxWalk);
        }
    }
}
