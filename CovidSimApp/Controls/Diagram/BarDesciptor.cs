using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidSimApp.Diagram
{
    class BarDesciptor
    {
        public Color Color { get; set; }
        public string Text { get; set; }
        public bool IsVisible { get; set; }

        public BarDesciptor(Color color, string text)
        {
            Color = color;
            Text = text;
            IsVisible = true;
        }
    }
}
