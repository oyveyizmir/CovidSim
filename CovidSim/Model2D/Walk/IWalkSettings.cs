﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidSim.Model2D.Walk
{
    public interface IWalkSettings : IValidatable
    {
        IWalkStrategy CreateWalkStrategy();
    }
}
