using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidSim.Model2D.Walk
{
    public abstract class SimpleWalk2 : IWalkStrategy
    {
        public MinMaxSettings Config { get; private set; }

        public SimpleWalk2(MinMaxSettings config) => Config = config;

        public virtual void Initialize() => Config.Validate();

        public abstract Point GetMoveVector();
    }
}
