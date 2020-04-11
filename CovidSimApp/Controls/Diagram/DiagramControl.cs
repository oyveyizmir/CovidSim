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
        const int MaxBarWidth = 10;

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

        public void AddDataAndRedraw(double x, params double[] values)
        {
            AddData(x, values);
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

        void DrawBar(Graphics g, BarData data, int barX, int barWidth, double verticalScale, List<SolidBrush> brushes)
        {
            double sumValues = 0;

            for (int j = data.Values.Count - 1; j >= 0; j--)
                if (bars[j].IsVisible)
                {
                    int barHeight = (int)(data.Values[j] * verticalScale);
                    int barY = Height - (int)(sumValues * verticalScale) - barHeight;
                    g.FillRectangle(brushes[j], barX, barY, barWidth, barHeight);
                    sumValues += data.Values[j];
                }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (barData.Count == 0 || MaxSum <= 0)
                return;

            var brushes = bars.Select(d => new SolidBrush(d.Color)).ToList();

            double verticalScale = Height / MaxSum;
            double horizontalScale = Math.Min((double)Width / barData.Count, MaxBarWidth);


            if (horizontalScale > 1)
            {
                for (int i = 0; i < barData.Count; i++)
                {
                    BarData data = barData[i];
                    DrawBar(barData[i], (float)(i * horizontalScale), (float)horizontalScale);
                }
            }
            else
            {
                for (int x = 0; x < Width; x++)
                {
                    int i = (int)(x / horizontalScale);
                    DrawBar(barData[i], x, 1);
                }
            }

            brushes.ForEach(b => b.Dispose());

            void DrawBar(BarData data, float barX, float barWidth)
            {
                double sumValues = 0;

                for (int j = data.Values.Count - 1; j >= 0; j--)
                    if (bars[j].IsVisible)
                    {
                        float barHeight = (float)(data.Values[j] * verticalScale);
                        float barY = Height - (float)(sumValues * verticalScale) - barHeight;
                        e.Graphics.FillRectangle(brushes[j], barX, barY, barWidth, barHeight);
                        sumValues += data.Values[j];
                    }
            }
        }
    }
}
