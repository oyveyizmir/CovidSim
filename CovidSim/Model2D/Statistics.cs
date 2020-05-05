using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidSim.Model2D
{
    public class Statistics : BasicStatistics<int>
    {
        public override int PopulationCount => SusceptibleCount + InfectedCount + RecoveredCount;

        public int Quarantined { get; set; }
    }
}
