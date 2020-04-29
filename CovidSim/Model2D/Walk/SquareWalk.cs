using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidSim.Model2D.Walk
{
    public class SquareWalk : RangeWalk
    {
        public SquareWalk(RangeSettings config) : base(config) { }

        public override Point GetMoveVector() => RandomUtils.GetPoint(Config.MinWalk, Config.MaxWalk);
    }
}
