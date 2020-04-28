﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidSim.Model2D.Walk
{
    public class WalkSettings : MinMaxSettings
    {
        public WalkArea Type { get; set; }

        public override IWalkStrategy CreateWalkStrategy()
        {
            switch (Type)
            {
                case WalkArea.Circle:
                    return new CircleWalk(this);
                case WalkArea.Square:
                    return new SquareWalk(this);
                default:
                    throw new InvalidOperationException("Invalid area type");
            }
        }
    }
}