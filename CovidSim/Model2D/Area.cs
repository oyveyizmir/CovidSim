﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidSim.Model2D
{
    class Area
    {
        public List<Human> Susceptible { get; set; } = new List<Human>();

        public List<Human> Humans { get; set; } = new List<Human>();
    }
}
