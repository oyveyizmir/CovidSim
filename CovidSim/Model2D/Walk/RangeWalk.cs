using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidSim.Model2D.Walk
{
    public abstract class RangeWalk : IWalkStrategy
    {
        public RangeSettings Config { get; private set; }

        public RangeWalk(RangeSettings config) => Config = config;

        public virtual void Initialize() => Config.Validate();

        public abstract Point GetMoveVector();
    }
}
