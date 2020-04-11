using CovidSim.SimpleModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CovidSimApp.SimpleModel
{
    public partial class SimpleModelForm : Form
    {
        Simulator simulator;
        Settings settings;

        public SimpleModelForm()
        {
            InitializeComponent();
            InitForm();
        }

        void InitForm()
        {
            simulator = new Simulator();
            simulator.Initialize();
            settings = simulator.Settings;
            modelParametersControl.TransitionRate = settings.TransitionRate;
            resetButton.Enabled = false;

            modelParametersControl.TransitionRateChanged += ModelParametersControl_TransitionRateChanged;

            diagram.AddBar(Color.Blue, "Susceptible");
            diagram.AddBar(Color.DarkRed, "Infected");
            diagram.AddBar(Color.DarkGreen, "Recovered");
            diagram.AddBar(Color.DarkGray, "Dead");
        }

        void StartSimulation()
        {
            timer.Start();
            startStopButton.Text = "Stop";
            settingsButton.Enabled = false;
            resetButton.Enabled = true;
        }

        void StopSimulation()
        {
            timer.Stop();
            startStopButton.Text = "Start";
            settingsButton.Enabled = true;
        }

        void ResetSimulation()
        {
            StopSimulation();

            simulator = new Simulator();
            simulator.Settings = settings;
            simulator.Initialize();

            diagram.ClearData();
            realTimeStats.ClearValues();
            modelParametersControl.TransitionRate = settings.TransitionRate;
            resetButton.Enabled = false;
        }

        private void ModelParametersControl_TransitionRateChanged(object sender, EventArgs e)
        {
            settings.TransitionRate = modelParametersControl.TransitionRate;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            simulator.Step();
            var stats = simulator.Stats;
            diagram.AddDataAndRedraw(simulator.Time, stats.SusceptibleCount, stats.InfectedCount, stats.RecoveredCount, stats.DiedCount);

            realTimeStats.SetTime(simulator.Time);
            realTimeStats.SetPopulation(stats.PopulationCount);
            realTimeStats.SetInfectedTotal(stats.InfectedTotalCount);
            realTimeStats.SetMaxInfected(stats.MaxInfectedCount);
            realTimeStats.SetSusceptible(stats.SusceptibleCount);
            realTimeStats.SetInfected(stats.InfectedCount);
            realTimeStats.SetRecovered(stats.RecoveredCount);
            realTimeStats.SetDead(stats.DiedCount);
        }

        private void startStopButton_Click(object sender, EventArgs e)
        {
            if (timer.Enabled)
                StopSimulation();
            else
                StartSimulation();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            ResetSimulation();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            var form = new SimpleModelSettingsForm();
            form.Settings = settings;
            form.Delay = timer.Interval;

            if (form.ShowDialog() == DialogResult.OK)
            {
                ResetSimulation();
                timer.Interval = form.Delay;
            }
        }
    }
}
