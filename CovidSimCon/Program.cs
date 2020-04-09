using CovidSim.Model2D;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidSimCon
{
    class Program
    {
        static void Main(string[] args)
        {
            var simulator = new Simulator();
            simulator.Settings.WorldSize = 500;
            simulator.Settings.MaxWalk = 5;
            simulator.Settings.TransmissionRange = 10;
            simulator.Initialize();
            
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine($"{i} {simulator.Stats}");
                simulator.Step();
            }
        }
    }
}
