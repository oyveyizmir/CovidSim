using CovidSim;
using CovidSim.Model2D;
using CovidSim.Model2D.Walk;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidSimCon
{
    class Program
    {
        static void Main(string[] args)
        {
            var settings = new ExtremeWalk.Settings();
            settings.MinWalk = 0;
            settings.MaxWalk = 100;
            settings.Linearity = -7;
            var walk = settings.CreateWalkStrategy();
            walk.Initialize();

            var distr = new int[20];
            double range = settings.MaxWalk - settings.MinWalk;
            var sw = new Stopwatch();
            double sum = 0;
            sw.Start();
            int n = 1000000000;
            for (int i = 0; i < n; i++)
            {
                Point v = walk.GetMoveVector();
                double d = Math.Sqrt(v.X * v.X + v.Y * v.Y);
                sum += d;
                d = (d - settings.MinWalk) / range;
                int bucket = (int)(d * distr.Length);
                if (bucket >= distr.Length)
                    bucket = bucket = distr.Length - 1;
                distr[bucket]++;
            }
            sw.Stop();
            for (int i = 0; i < distr.Length; i++)
                Console.WriteLine($"{distr[i]}");
            Console.WriteLine("Avg: " + sum / n);
            Console.WriteLine("Duration: " + sw.ElapsedMilliseconds);
        }
    }
}
