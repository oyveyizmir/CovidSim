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
        Brush[] brushes = new Brush[] { Brushes.Blue, Brushes.Red, Brushes.Green, null, new SolidBrush(Color.FromArgb(0x70, 0x00, 0x00)) };

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

        int GetDotSize()
        {
            int size = (int)Math.Sqrt(0.25 * Width * Height / Persons.Count);
            if (size < 1)
                return 1;
            else if (size > 5)
                return 5;
            else
                return size;
        }

        void DrawDot(Graphics g, Brush brush, int x, int y, int size)
        {
            int offset = size / 2;
            switch (size)
            {
                case 1:
                case 2:
                case 3:
                    g.FillRectangle(brush, x - offset, y - offset, size, size);
                    break;
                case 4:
                case 5:
                    g.FillRectangle(brush, x - offset, y - offset + 1, size, size - 2);
                    g.FillRectangle(brush, x - offset + 1, y - offset, size - 2, size);
                    break;
                default:
                    throw new ArgumentException("size");
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            double scaleX = Width / worldSize;
            double scaleY = Height / worldSize;
            int dotSize = GetDotSize();

            foreach (var person in Persons)
            {
                Brush brush = brushes[(int)person.State];
                if (brush != null)
                {
                    int x = (int)(person.Position.X * scaleX + 0.5);
                    int y = (int)(person.Position.Y * scaleY + 0.5);
                    DrawDot(e.Graphics, brush, x, y, dotSize);
                }
            }
        }
    }
}
