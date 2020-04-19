using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidSim.Model2D.Walk
{
    public class SimpleWalk : WalkStrategy
    {
        public class Settings : SettingsBase
        {
            public Settings() => (MinWalk, MaxWalk) = (0, 0.45);

            public override WalkStrategy Create()
            {
                var walk = new SimpleWalk();
                walk.Config = this;
                return walk;
            }
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
