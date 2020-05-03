using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidSim.Model2D.Avoidance
{
    public class AvoidanceStrategy
    {
        public class Settings : IValidatable
        {
            double range = 20;
            double factorAt0 = 0.03;
            double factorAtRange = 0;
            
            public bool Enabled { get; set; }

            public double Range
            {
                get => range;

                set
                {
                    if (value <= 0)
                        throw new ArgumentException("AvoidanceRange");
                    range = value;
                }
            }

            public double FactorAt0
            {
                get => factorAt0;

                set
                {
                    if (value < 0 || value > 1)
                        throw new ArgumentException("AvoidanceFactorAt0");
                    factorAt0 = value;
                    CalcConst();
                }
            }

            public double FactorAtRange
            {
                get => factorAtRange;

                set
                {
                    if (value < 0 || value > 1)
                        throw new ArgumentException("AvoidanceFactorAtRange");
                    factorAtRange = value;
                    CalcConst();
                }
            }

            public AvoidanceStrategy CreateStrategy() => Enabled ? new AvoidanceStrategy(this) : null;

            internal double FactorRangeDivRange { get; private set; }

            internal void CalcConst() => FactorRangeDivRange = (factorAtRange - factorAt0) / Range;

            public void Validate()
            {
                //TODO: check inf/nan
            }
        }

        public Settings Config { get; private set; }

        public AvoidanceStrategy(Settings config)
        {
            Config = config;
            Config.CalcConst();
        }

        public Point GetMoveVector(Point subject, Point @object)
        {
            double distance = Point.Distance(subject, @object);
            if (distance > Config.Range)
                return Point.Null;

            double k = (Config.FactorAt0 / distance + Config.FactorRangeDivRange);
            if (double.IsInfinity(k))
            {
                double moveAngle = RandomUtils.GetDouble(0, 2 * Math.PI);
                return new Point(Config.FactorAt0 * Math.Cos(moveAngle), Config.FactorAt0 * Math.Sin(moveAngle));
            }
            else if (double.IsNaN(k))
                return Point.Null;
            else
                return new Point(k * (subject.X - @object.X), k * (subject.Y - @object.Y));
        }
    }
}
