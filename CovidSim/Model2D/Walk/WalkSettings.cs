using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidSim.Model2D.Walk
{
    public class WalkSettings : RangeSettings
    {
        public WalkArea Type { get; set; } = WalkArea.Circle;

        public WalkSettings() : base(0, 0.2) { }

        public WalkSettings(WalkArea type, double minWalk, double maxWalk) : base(minWalk, maxWalk) => Type = type;

        public override IWalkStrategy CreateWalkStrategy()
        {
            switch (Type)
            {
                case WalkArea.Circle:
                    return new CircleWalk(this);
                case WalkArea.Square:
                    return new SquareWalk(this);
                default:
                    throw new InvalidOperationException("Invalid area type");
            }
        }
    }
}
