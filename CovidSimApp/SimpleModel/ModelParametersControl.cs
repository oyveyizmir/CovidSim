using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CovidSimApp.SimpleModel
{
    public partial class ModelParametersControl : UserControl
    {
        double transitionRate;
        double refValue;
        const int refSliderValue = 100;

        public event EventHandler TransitionRateChanged;

        public double TransitionRate
        {
            get { return transitionRate; }

            set
            {
                transitionRate = value;
                transitionRateEdit.Text = value.ToString();
                refValue = value;
                transitionRateSlider.Value = refSliderValue;
            }
        }

        public ModelParametersControl()
        {
            InitializeComponent();
        }

        void OnTransitoinRateChanged()
        {
            TransitionRateChanged?.Invoke(this, EventArgs.Empty);
        }

        private void transitionRateSlider_Scroll(object sender, EventArgs e)
        {
            transitionRate = refValue * transitionRateSlider.Value / refSliderValue;
            transitionRateEdit.Text = transitionRate.ToString();
            OnTransitoinRateChanged();
        }

        private void transitionRateSlider_ValueChanged(object sender, EventArgs e)
        {
            //refValue = transitionRate;
            //transitionRateSlider.Value = refSliderValue;
        }

        private void transitionRateEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                UpdateTransitionRateFromTextBox();
                e.Handled = true;
            }
        }

        void UpdateTransitionRateFromTextBox()
        {
            double newValue;
            if (!double.TryParse(transitionRateEdit.Text, out newValue))
                return;
            if (newValue < 0)
                return;
            TransitionRate = newValue;
            OnTransitoinRateChanged();
        }
    }
}
