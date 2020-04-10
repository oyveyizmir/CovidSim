using CovidSim;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CovidSimApp.Controls.Population2D
{
    public class PopulationControl : Control
    {
        double worldSize = 1000;
        Brush[] brushes = new Brush[] { Brushes.Blue, Brushes.Red, Brushes.Green, null };

        public List<Person> Persons { get; private set; } = new List<Person>();

        public double WorldSize
        {
            get => worldSize;

            set
            {
                if (value < 1)
                    throw new ArgumentException("WorldSize");
                worldSize = value;
            }
        }

        public PopulationControl()
        {
            ResizeRedraw = true;
        }

        public void ClearPersons()
        {
            Persons.Clear();
        }

        public void AddPerson(CovidSim.Point position, PersonState state)
        {
            Persons.Add(new Person(position, state));
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            double scaleX = Width / worldSize;
            double scaleY = Height / worldSize;

            foreach (var person in Persons)
            {
                Brush brush = brushes[(int)person.State];
                if (brush != null)
                {
                    int x = (int)(person.Position.X * scaleX + 0.5);
                    int y = (int)(person.Position.Y * scaleY + 0.5);
                    e.Graphics.FillRectangle(brush, x - 1, y - 1, 3, 3);
                }
            }
        }
    }
}
