using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidSim.Model2D.Walk
{
    class NullWalk : IWalkStrategy
    {
        public Point GetMoveVector()
        {
            return Point.Null;
        }

        public void Initialize()
        {
        }
    }
}
