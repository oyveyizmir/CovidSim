using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidSim.Model2D
{
    struct AreaPosition
    {
        double segmentSize;

        public int X { get; set; }

        public int Y { get; set; }

        public AreaPosition(double segmentSize) => (this.segmentSize, X, Y) = (segmentSize, 0, 0);

        public AreaPosition(int x, int y) => (X, Y, segmentSize) = (x, y, 0);

        public Point TopLeft => new Point(X * segmentSize, Y * segmentSize);

        public Point TopRight => new Point((X + 1) * segmentSize, Y * segmentSize);

        public Point BottomLeft => new Point(X * segmentSize, (Y + 1) * segmentSize);

        public Point BottomRight => new Point((X + 1) * segmentSize, (Y + 1) * segmentSize);

        
    }
}
