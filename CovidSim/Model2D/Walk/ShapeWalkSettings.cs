using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidSim.Model2D.Walk
{
    public class ShapeWalkSettings : RangeSettings
    {
        public Shape Shape { get; set; } = Shape.Circle;

        public ShapeWalkSettings() : base(0, 0.2) { }

        public ShapeWalkSettings(Shape type, double minWalk, double maxWalk) : base(minWalk, maxWalk) => Shape = type;

        public override IWalkStrategy CreateWalkStrategy()
        {
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
