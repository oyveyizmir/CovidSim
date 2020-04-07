using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidSim.SimpleModel
{
    public class Statistics : BasicStatistics<double>
    {
        public override double PopulationCount => SusceptibleCount + InfectedCount + RecoveredCount;
    }
}
