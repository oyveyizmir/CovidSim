using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidSim
{
    public static class Utils
    {
        public static Random Random = new Random();

        public static bool LessThanThreshold(double threshold)
        {
            return Random.NextDouble() < threshold;
        }
    }
}
