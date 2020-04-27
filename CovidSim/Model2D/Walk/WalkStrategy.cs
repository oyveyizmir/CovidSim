using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidSim.Model2D.Walk
{
    public abstract class WalkStrategy
    {
        public interface ISettings : IValidatable
        {
            WalkStrategy CreateWalkStrategy();
        }

        public abstract class MinMaxSettings : IValidatable
        {
            double minWalk;
            double maxWalk;

            public double MinWalk
            {
                get => minWalk;
                set
                {
                    if (value < 0)
                        throw new ArgumentException("MinWalk");
                    minWalk = value;
                }
            }

            public double MaxWalk
            {
                get => maxWalk;
                set
                {
                    if (value < 0)
                        throw new ArgumentException("MaxWalk");
                    maxWalk = value;
                }
            }

            public void Validate()
            {
                if (minWalk > maxWalk)
                    throw new ValidationException("MinWalk cannot exceed MaxWalk");
            }
        }

        protected abstract double GetRange();

        public abstract void Initialize();

        public virtual Point GetMoveVector()
        {
            double moveAngle = RandomUtils.GetDouble(0, 2 * Math.PI);
            double moveRange = GetRange();
            var randomWalkVector = new Point(moveRange * Math.Cos(moveAngle), moveRange * Math.Sin(moveAngle));
            return randomWalkVector;
        }
    }
}
