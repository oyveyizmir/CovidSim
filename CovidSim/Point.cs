using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidSim
{
    public struct Point
    {
        public static Point Null = new Point();

        public double X { get; set; }
        public double Y { get; set; }

        public Point(double x, double y) => (X, Y) = (x, y);

        public static Point operator +(Point a, Point b) => new Point(a.X + b.X, a.Y + b.Y);

        public static double Distance(Point a, Point b) => Math.Sqrt(Square(a.X - b.X) + Square(a.Y - b.Y));

        static double Square(double x) => x * x;
    }
}
