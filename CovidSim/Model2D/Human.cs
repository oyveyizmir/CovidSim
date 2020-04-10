using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidSim.Model2D
{
    public class Human
    {
        public Point Position { get; set; }

        public bool IsAlive { get; set; } = true;

        public bool IsImmune { get; set; }

        public bool IsInfected { get; set; }

        public int TimeToRemoval { get; set; }

        public int InfectionTime { get; set; }

        public bool CanInfect(int time) => IsAlive && IsInfected && InfectionTime < time;

        public bool CanBeInfected => IsAlive && !IsImmune && !IsInfected;
    }
}
