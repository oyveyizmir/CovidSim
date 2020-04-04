using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidSim
{
    public class Settings
    {
        public int PopulaceCount { get; set; } = 1000000;
        public double InfectionProbability { get; set; } = 0.05;
        public double FatalityRate { get; set; } = 0.05;
        public int MortallyInfectedLifeSpan { get; set; } = 30;
        public int IllnessDuration { get; set; } = 30;
        public int TransmissionRange { get; set; } = 10;
        public int InitiallyInfected { get; set; } = 1;
        public double SwapProbability { get; set; } = 0.1;
    }
}
