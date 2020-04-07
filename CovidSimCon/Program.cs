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
            simulator.Initialize();
            for (int i = 0; i < 101; i++)
            {
                Console.WriteLine($"{i} {simulator.Stats}");
                simulator.Step();
            }
        }
    }
}
