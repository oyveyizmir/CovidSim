using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidSim
{
    public static class RandomUtils
    {
        public static Random Random = new Random();

        public static bool LessThanThreshold(double threshold) => Random.NextDouble() < threshold;

        public static double GetDouble(double from, double to) => from + (to - from) * Random.NextDouble();

        public static double GetDouble(double max) => max * Random.NextDouble();

        public static int GetInt(int max) => Random.Next(max);
    }
}
