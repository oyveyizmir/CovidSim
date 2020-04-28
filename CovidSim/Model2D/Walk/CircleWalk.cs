using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidSim.Model2D.Walk
{
    public class CircleWalk : WalkStrategy
    {
        public CircleWalk(RangeSettings config) : base(config) { }

        protected virtual double GetRange() => RandomUtils.GetDouble(Config.MinWalk, Config.MaxWalk);

        public override Point GetMoveVector()
        {
            double moveAngle = RandomUtils.GetDouble(0, 2 * Math.PI);
            double moveRange = GetRange();
            return new Point(moveRange * Math.Cos(moveAngle), moveRange * Math.Sin(moveAngle));
        }
    }
}
