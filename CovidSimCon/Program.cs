using CovidSim.Model2D;
using CovidSim.Model2D.Walk;
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
            var walk = new SimpleWalk.Settings();
            simulator.Settings.Walk = walk;
            simulator.Settings.WorldSize = 300;
            simulator.Settings.TransmissionRange = 10;
            walk.MaxWalk = 5;
            simulator.Initialize();
            
            for (int i = 0; i < 200; i++)
            {
                Console.WriteLine($"{i} {simulator.Stats}");
                simulator.Step();
            }
        }
    }
}
