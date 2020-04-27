using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CovidSim
{
    public static class RandomUtils
    {
        static ThreadLocal<Random> random = new ThreadLocal<Random>(() => new Random());

        public static bool LessThanThreshold(double threshold) => GetDouble() < threshold;

        public static double GetDouble(double from, double to) => from + (to - from) * GetDouble();

        public static double GetDouble(double max) => max * GetDouble();

        public static int GetInt(int max) => random.Value.Next(max);

        public static double GetDouble() => random.Value.NextDouble();

        public static int Sign() => (GetInt(2) << 1) - 1;

        public static Point GetPoint(double min, double max)
        {
            Random r = random.Value;

            int sign = r.Next(4);
            double signX = (sign & 1 << 1) - 1;
            double signY = (sign & 2) - 1;

            double d = max - min;
            double x = min + d * r.NextDouble();
            double y = min + d * r.NextDouble();

            return new Point(signX * x, signY * y);
        }
    }
}
