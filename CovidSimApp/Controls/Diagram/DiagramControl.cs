using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CovidSimApp.Diagram
{
    class DiagramControl : Control
    {
        const int MinBarWidth = 10;

        List<BarDesciptor> bars = new List<BarDesciptor>();
        List<BarData> barData = new List<BarData>();

        public double MaxSum { get; private set; } = double.MinValue;

        public DiagramControl()
        {
            ResizeRedraw = true;

            ContextMenuStrip = new ContextMenuStrip();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && ContextMenuStrip != null)
                ContextMenuStrip.Dispose();

            base.Dispose(disposing);
        }

        public void AddBar(BarDesciptor desciptor)
        {
            bars.Add(desciptor);
        }

        public void AddBar(Color color, string text)
        {
            var bar = new BarDesciptor(color, text);
            bars.Add(bar);

            var menuItem = new ToolStripMenuItem(text);
            menuItem.Tag = bar;
            menuItem.CheckOnClick = true;
            menuItem.Checked = true;
            menuItem.CheckedChanged += MenuItem_CheckedChanged;
            ContextMenuStrip.Items.Add(menuItem);
        }

        void CalculateMaxSum()
        {
            //MaxSum = barData.Select(d => d.Values.Where(.Sum()).Max();
            MaxSum = double.MinValue;

            foreach (BarData data in barData)
                MaxSum = Math.Max(MaxSum, Sum(data));
        }

        double Sum(BarData data)
        {
            //TODO: optimize via storing indices of visible bars
            double sum = 0;
            for (int i = 0; i < bars.Count; i++)
                if (bars[i].IsVisible)
                    sum += data.Values[i];
            return sum;
        }

        private void MenuItem_CheckedChanged(object sender, EventArgs e)
        {
            var menuItem = (ToolStripMenuItem)sender;
            var bar = (BarDesciptor)menuItem.Tag;
            bar.IsVisible = menuItem.Checked;
            CalculateMaxSum();
            Invalidate();
        }

        public void AddData(double x, params double[] values)
        {
            var data = new BarData()
            {
                X = x,
                Values = new List<double>(values)
            };
            barData.Add(data);
            MaxSum = Math.Max(MaxSum, Sum(data));
            Invalidate();
        }

        public void ClearData()
        {
            barData.Clear();
            MaxSum = double.MinValue;
            Invalidate();
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            //e.Graphics.DrawString($"{Width} {Height}", Font, Brushes.Black, 0, 0);

            if (barData.Count == 0 || MaxSum <= 0)
                return;

            var brushes = bars.Select(d => new SolidBrush(d.Color)).ToList();

            //TODO: different algorithms for barWidth < 1 and >= 1
            double verticalScale = Height / MaxSum;
            double barWidth = Math.Min((double)Width / barData.Count, MinBarWidth);
            

            for (int i = 0; i < barData.Count; i++)
            {
                BarData data = barData[i];
                double sumValues = 0;

                for (int j = data.Values.Count - 1; j >= 0; j--)
                    if (bars[j].IsVisible)
                    {
                        float barHeight = (float)(data.Values[j] * verticalScale);
                        float barX = (float)(i * barWidth);
                        float barY = Height - (float)(sumValues * verticalScale) - barHeight;
                        e.Graphics.FillRectangle(brushes[j], barX, barY, (float)barWidth, barHeight);
                        sumValues += data.Values[j];
                    }
            }

            brushes.ForEach(b => b.Dispose());
        }
    }
}
