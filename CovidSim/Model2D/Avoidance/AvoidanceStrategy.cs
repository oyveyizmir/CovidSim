using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidSim.Model2D.Avoidance
{
    public class AvoidanceStrategy
    {
        public class Settings
        {
            double range = 100;
            double factorAt0 = 0.03;
            double factorAtRange = 0;
            
            public bool Enabled { get; set; }

            public double Range
            {
                get => range;

                set
                {
                    if (value < 0)
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
                    UpdateFactorRange();
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
                    UpdateFactorRange();
                }
            }

            public AvoidanceStrategy CreateStrategy() => Enabled ? new AvoidanceStrategy(this) : null;

            internal double FactorRange { get; private set; }

            internal void UpdateFactorRange() => FactorRange = factorAtRange - factorAt0;
        }

        public Settings Config { get; private set; }

        public AvoidanceStrategy(Settings config)
        {
            Config = config;
            Config.UpdateFactorRange();
        }

        public Point GetMoveVector(Point subject, Point @object)
        {
            double distance = Point.Distance(subject, @object);
            if (distance > Config.Range)
                return Point.Null;

            double k = (Config.FactorAt0 + Config.FactorRange * distance / Config.Range) / distance;
            return new Point(k * (subject.X - @object.X), k * (subject.Y - @object.Y));
        }
    }
}
