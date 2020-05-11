using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CovidSimApp.Controls
{
    public partial class RealTimeStats : UserControl
    {
        const string EmptyValue = "--";
        bool showExtraStats;

        public bool ShowExtraStats
        {
            get => showExtraStats;

            set
            {
                showExtraStats = value;
                OnShowExtraStatsChanged();
            }
        }

        public RealTimeStats()
        {
            InitializeComponent();
            ClearValues();
        }

        void SetValue<T>(Label label, T value)
        {
            label.Text = value.ToString();
        }

        public void ClearValues()
        {
            timeLabel.Text = EmptyValue;
            populationLabel.Text = EmptyValue;
            infectedTotalLabel.Text = EmptyValue;
            maxInfectedLabel.Text = EmptyValue;
            susceptibleLabel.Text = EmptyValue;
            infectedLabel.Text = EmptyValue;
            recoveredLabel.Text = EmptyValue;
            deadLabel.Text = EmptyValue;
            quarantinedValue.Text = EmptyValue;
        }

        public void SetTime(int time)
        {
            SetValue(timeLabel, time);
        }

        public void SetPopulation(double population)
        {
            SetValue(populationLabel, (int)Math.Round(population));
        }

        public void SetInfectedTotal(double infectedTotal)
        {
            SetValue(infectedTotalLabel, (int)Math.Round(infectedTotal));
        }

        public void SetMaxInfected(double maxInfected)
        {
            SetValue(maxInfectedLabel, (int)Math.Round(maxInfected));
        }

        public void SetSusceptible(double susceptible)
        {
            SetValue(susceptibleLabel, (int)Math.Round(susceptible));
        }

        public void SetInfected(double infected)
        {
            SetValue(infectedLabel, (int)Math.Round(infected));
        }

        public void SetRecovered(double recovered)
        {
            SetValue(recoveredLabel, (int)Math.Round(recovered));
        }

        public void SetDead(double dead)
        {
            SetValue(deadLabel, (int)Math.Round(dead));
        }

        public void SetQuarantined(int quarantined)
        {
            SetValue(quarantinedValue, quarantined);
        }

        void OnShowExtraStatsChanged()
        {
            quarantinedLabel.Visible = showExtraStats;
            quarantinedValue.Visible = showExtraStats;
        }
    }
}
