using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidSim
{
    public class Statistics
    {
        public int SusceptibleCount { get; set; }
        public int InfectedCount { get; set; }
        public int InfectedTotalCount { get; set; }
        public int RecoveredCount { get; set; }
        public int DiedCount { get; set; }

        public override string ToString()
        {
            return $"Infected Total: {InfectedTotalCount}, Infected: {InfectedCount} Recovered: {RecoveredCount}, Deaths: {DiedCount}";
        }
    }
}
