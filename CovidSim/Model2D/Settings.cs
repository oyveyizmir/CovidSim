﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidSim.Model2D
{
    public class Settings : BasicSettings
    {
        public Settings()
        {
            Population = 1000;
            InitiallyInfected = 1;
        }
    }
}
