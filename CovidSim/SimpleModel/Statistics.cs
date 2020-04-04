using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidSim.SimpleModel
{
    public class Statistics
    {
        public double Population { get { return SusceptibleCount + InfectedCount + RecoveredCount; } }
        public double SusceptibleCount { get; set; }
        public double InfectedCount { get; set; }
        public double InfectedTotalCount { get; set; }
        public double MaxInfectedCount { get; set; }
        public double RecoveredCount { get; set; }
        public double DiedCount { get; set; }

        public override string ToString()
        {
            return $"Population: {Population}, Susceptible: {SusceptibleCount}, Infected Total: {InfectedTotalCount},"
                + $" Infected: {InfectedCount} Recovered: {RecoveredCount}, Deaths: {DiedCount}";
        }
    }
}
