using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidSim.Model2D.Walk
{
    public class OneRangeWalkSettings : RangeSettings
    {
        public Shape Shape { get; set; } = Shape.Circle;

        public OneRangeWalkSettings() : base(0, 0.2) { }

        public OneRangeWalkSettings(Shape type, double minWalk, double maxWalk) : base(minWalk, maxWalk) => Shape = type;

        public override IWalkStrategy CreateWalkStrategy()
        {
            if (MinWalk == 0 && MaxWalk == 0)
                return new NullWalk();

            switch (Shape)
            {
                case Shape.Circle:
                    return new CircleWalk(this);
                case Shape.Square:
                    return new SquareWalk(this);
                default:
                    throw new InvalidOperationException("Invalid area shape");
            }
        }
    }
}
