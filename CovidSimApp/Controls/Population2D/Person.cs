using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CovidSim;

namespace CovidSimApp.Controls.Population2D
{
    public class Person
    {
        public Point Position { get; set; }

        public PersonState State { get; set; }

        public Person(Point position, PersonState state) => (Position, State) = (position, state);
    }
}
