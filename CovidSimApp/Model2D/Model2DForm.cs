using CovidSim.Model2D;
using CovidSimApp.Controls.Population2D;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CovidSimApp.Model2D
{
    public partial class Model2DForm : Form
    {
        Simulator simulator;
        Settings settings;
        Task task;
        CancellationTokenSource cts;
        TaskScheduler uiScheduler;

        public Model2DForm()
        {
            InitializeComponent();
            InitForm();
        }

        void InitForm()
        {
            uiScheduler = TaskScheduler.FromCurrentSynchronizationContext();

            simulator = new Simulator();
            simulator.Settings.WorldSize = 500;
            simulator.Settings.MaxWalk = 1;
            simulator.Settings.IllnessDuration = 20;
            simulator.Settings.TransmissionRange = 20;
            simulator.Settings.TransmissionProbabilityAt0 = 0.2;
            simulator.Settings.FatalityRate = 0.2;
            simulator.Settings.Population = 10000;
            simulator.Settings.InitiallyInfected = 10;
            simulator.SegmentCount = 50;
            simulator.Initialize();
            settings = simulator.Settings;

            resetButton.Enabled = false;

            diagram.AddBar(Color.Blue, "Susceptible");
            diagram.AddBar(Color.DarkRed, "Infected");
            diagram.AddBar(Color.DarkGreen, "Recovered");
            diagram.AddBar(Color.DarkGray, "Dead");

            ResetSimulation();
        }

        private void startStopButton_Click(object sender, EventArgs e)
        {
            if (task != null)
                StopSimulation();
            else
                StartSimulation();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            ResetSimulation();
        }

        void StartSimulation()
        {
            startStopButton.Text = "Stop";
            settingsButton.Enabled = false;
            resetButton.Enabled = true;

            cts = new CancellationTokenSource();
            task = Task.Run(() => RunSimulation(cts.Token), cts.Token);
        }

        async void StopSimulation()
        {
            if (task != null)
            {
                cts.Cancel();
                await task;
                task = null;
            }

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
            ResetPopulation();

            resetButton.Enabled = false;

            AddDiagramData();
            UpdateUI(CancellationToken.None);
        }

        async void RunSimulation(CancellationToken token)
        {
            DateTime lastUIUpdate = DateTime.MinValue;
            while (!token.IsCancellationRequested)
            {
                simulator.Step();
                AddDiagramData();

                try
                {
                    DateTime timeStamp = DateTime.Now;
                    if ((timeStamp - lastUIUpdate).TotalMilliseconds > 20)
                    {
                        lastUIUpdate = timeStamp;
                        await Task.Factory.StartNew(() => UpdateUI(token), token, TaskCreationOptions.None, uiScheduler);
                    }
                }
                catch (TaskCanceledException) { }

                await Task.Delay(0);
            }
        }

        PersonState GetPersonState(Human human)
        {
            if (!human.IsAlive)
                return PersonState.Dead;
            else if (human.IsInfected)
                return PersonState.Infected;
            else if (human.IsImmune)
                return PersonState.Recovered;
            else
                return PersonState.Susceptible;
        }

        void ResetPopulation()
        {
            populationControl.WorldSize = settings.WorldSize;
            populationControl.ClearPersons();

            foreach (var human in simulator.Humans)
            {
                PersonState state = GetPersonState(human);
                populationControl.AddPerson(human.Position, state);
            }

            populationControl.Invalidate();
        }

        void UpdatePopulation()
        {
            for (int i = 0; i < simulator.Humans.Count; i++)
            {
                Human human = simulator.Humans[i];
                PersonState state = GetPersonState(human);
                populationControl.Persons[i].Position = human.Position;
                populationControl.Persons[i].State = state;
            }

            populationControl.Invalidate();
        }

        void UpdateDiagram()
        {
            diagram.Invalidate();
        }

        void AddDiagramData()
        {
            Statistics stats = simulator.Stats;
            diagram.AddData(simulator.Time, stats.SusceptibleCount, stats.InfectedCount, stats.RecoveredCount, stats.DiedCount);
        }

        void UpdateRealTimeStats()
        {
            Statistics stats = simulator.Stats;
            realTimeStats.SetTime(simulator.Time);
            realTimeStats.SetPopulation(stats.PopulationCount);
            realTimeStats.SetInfectedTotal(stats.InfectedTotalCount);
            realTimeStats.SetMaxInfected(stats.MaxInfectedCount);
            realTimeStats.SetSusceptible(stats.SusceptibleCount);
            realTimeStats.SetInfected(stats.InfectedCount);
            realTimeStats.SetRecovered(stats.RecoveredCount);
            realTimeStats.SetDead(stats.DiedCount);
        }

        void UpdateUI(CancellationToken token)
        {
            if (token.IsCancellationRequested)
                return;

            UpdateDiagram();
            UpdatePopulation();
            UpdateRealTimeStats();
        }
    }
}
