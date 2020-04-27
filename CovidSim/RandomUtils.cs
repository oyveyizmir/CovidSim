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

        public static bool LessThanThreshold(double threshold) => NextDouble() < threshold;

        public static double GetDouble(double from, double to) => from + (to - from) * NextDouble();

        public static double GetDouble(double max) => max * NextDouble();

        public static int GetInt(int max) => Next(max);

        public static double NextDouble() => random.Value.NextDouble();

        public static int Next(int max) => random.Value.Next(max);
    }
}
