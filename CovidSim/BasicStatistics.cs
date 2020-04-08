using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidSim
{
    public abstract class BasicStatistics<T>
        where T : IComparable<T>
    {
        T infectedCount;

        public abstract T PopulationCount { get; }

        public T SusceptibleCount { get; set; }

        public T InfectedCount
        {
            get => infectedCount;

            set
            {
                if (value.CompareTo(MaxInfectedCount) > 0)
                    MaxInfectedCount = value;
                infectedCount = value;
            }
        }

        public T InfectedTotalCount { get; set; }

        public T MaxInfectedCount { get; set; }

        public T RecoveredCount { get; set; }

        public T DiedCount { get; set; }

        public override string ToString()
        {
            return $"PopulationCount: {PopulationCount}, Susceptible: {SusceptibleCount}, Infected Total: {InfectedTotalCount},"
                + $" Infected: {InfectedCount}, Max Infected: {MaxInfectedCount}, Recovered: {RecoveredCount}, Deaths: {DiedCount}";
        }
    }
}
