using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidSim.Model2D.Walk
{
    public class SquareWalk : SimpleWalk
    {
        new public class Settings : MinMaxSettings, ISettings
        {
            public Settings() => (MinWalk, MaxWalk) = (0, 0.2);

            public WalkStrategy CreateWalkStrategy() => new SquareWalk { Config = this };
        }

        new public Settings Config { get; set; } = new Settings();

        public override void Initialize()
        {
            Config.Validate();
        }

        public override Point GetMoveVector() => RandomUtils.GetPoint(Config.MinWalk, Config.MaxWalk);
    }
}
