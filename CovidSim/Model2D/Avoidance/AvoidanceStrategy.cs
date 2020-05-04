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
            double range = 50;
            double? maxStep;
            
            public bool Enabled { get; set; }

            public double Range
            {
                get => range;

                set
                {
                    if (value <= 0)
                        throw new ArgumentException("Range");
                    range = value;
                }
            }

            public double StepAt0 { get; set; } = 0.02;

            public double StepAtRange { get; set; } = -0.01;

            public double? MaxStep
            {
                get => maxStep;

                set
                {
                    if (value != null && value <= 0)
                        throw new ArgumentException("MaxStep");
                    maxStep = value;
                }
            }

            public AvoidanceStrategy CreateStrategy() => Enabled ? new AvoidanceStrategy(this) : null;

            public void Validate()
            {
                //TODO: check inf/nan
            }
        }

        internal double MaxStep { get; private set; }

        internal double MaxStepSquared { get; private set; }

        internal double FactorRangeDivRange { get; private set; }

        public Settings Config { get; private set; }

        public AvoidanceStrategy(Settings config)
        {
            Config = config;
            FactorRangeDivRange = (Config.StepAtRange - Config.StepAt0) / Config.Range;
            MaxStep = Config.MaxStep ?? 0;
            MaxStepSquared = Config.MaxStep != null ? Config.MaxStep.Value * Config.MaxStep.Value : 0;
        }

        public Point GetMoveVector(Point subject, Point @object)
        {
            double distance = Point.Distance(subject, @object);
            if (distance > Config.Range)
                return Point.Null;

            double k = (Config.StepAt0 / distance + FactorRangeDivRange);
            if (double.IsInfinity(k))
            {
                double moveAngle = RandomUtils.GetDouble(0, 2 * Math.PI);
                return new Point(Config.StepAt0 * Math.Cos(moveAngle), Config.StepAt0 * Math.Sin(moveAngle));
            }
            else if (double.IsNaN(k))
                return Point.Null;
            else
                return new Point(k * (subject.X - @object.X), k * (subject.Y - @object.Y));
        }
    }
}
