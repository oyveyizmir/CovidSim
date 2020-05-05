using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidSimApp.Controls.Population2D
{
    public enum PersonState
    {
        Susceptible = 0,
        Infected = 1,
        Recovered = 2,
        Dead = 3,
        Quarantined = 4
    }
}
