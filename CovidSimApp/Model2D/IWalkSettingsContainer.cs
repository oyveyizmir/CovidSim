using CovidSim;
using CovidSim.Model2D.Walk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidSimApp.Model2D
{
    interface IWalkSettingsContainer : ISavable
    {
        IWalkSettings Walk { get; set; }
    }
}
