using CovidSim.Model2D;
using CovidSim.Model2D.Walk;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static CovidSimApp.ValidationUtils;

namespace CovidSimApp.Model2D
{
    public partial class SettingsForm : Form
    {
        public Settings Settings { get; set; }

        public SimpleWalk.Settings SimpleWalk { get; set; }

        public ExtremeDistanceWalk.Settings ExtremeDistanceWalk { get; set; }

        public int Delay { get; set; }

        public SettingsForm()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            DisplayData();
        }

        void DisplayData()
        {
            populationEdit.Text = Settings.Population.ToString();
            infectedEdit.Text = Settings.InitiallyInfected.ToString();
            illnessDurationEdit.Text = Settings.IllnessDuration.ToString();
            fatalityRateEdit.Text = Settings.FatalityRate.ToString();
            transmissionRangeEdit.Text = Settings.TransmissionRange.ToString();
            transmissionProbabilityAt0Edit.Text = Settings.TransmissionProbabilityAt0.ToString();
            transmissionProbabilityAtRangeEdit.Text = Settings.TransmissionProbabilityAtRange.ToString();
            minWalkEdit.Text = SimpleWalk.MinWalk.ToString();
            maxWalkEdit.Text = SimpleWalk.MaxWalk.ToString();
            worldSizeEdit.Text = Settings.WorldSize.ToString();
            delayEdit.Text = Delay.ToString();
        }

        bool ValidateAndSaveData()
        {
            try
            {
                var population = ValidateAndGet<int>(populationEdit, x => x >= 1,
                    "Expected an integer value greater than 1 for Population");

                var infected = ValidateAndGet<int>(infectedEdit, x => x >= 0,
                    "Expected an integer value greater than 0 for Infected Initially");

                ValidateAndGet<int>(infectedEdit, x => x <= population,
                    "Infected Initially cannot exceed Population");

                var illnessDuration = ValidateAndGet<int>(illnessDurationEdit, x => x > 0,
                    "Illness Duration should be greater than 0");

                var fatalityRate = ValidateAndGet<double>(fatalityRateEdit, x => x >= 0 && x <= 1,
                    "Fatality Rate should be between 0 and 1 (including 0 and 1)");

                var transmissionRange = ValidateAndGet<double>(transmissionRangeEdit, x => x > 0,
                    "Transmission Range should be greater than 0");

                var transmissionProbabilityAt0 = ValidateAndGet<double>(transmissionProbabilityAt0Edit, x => x >= 0 && x <= 1,
                    "Transmission Probability should be between 0 and 1 (including 0 and 1)");

                var transmissionProbabilityAtRange = ValidateAndGet<double>(transmissionProbabilityAtRangeEdit, x => x >= 0 && x <= 1,
                    "Transmission Probability at Range should be between 0 and 1 (including 0 and 1)");

                var minWalk = ValidateAndGet<double>(minWalkEdit, x => x >= 0,
                    "Minimum Walk cannot be less than 0");

                var maxWalk = ValidateAndGet<double>(maxWalkEdit, x => x >= 0,
                    "Maximum Walk cannot be less than 0");

                ValidateAndGet<double>(minWalkEdit, x => x <= maxWalk,
                    "Minimum Walk cannot exceed Maximum Walk");

                var worldSize = ValidateAndGet<double>(worldSizeEdit, x => x > 0,
                    "World Size should be greater than 0");

                var delay = ValidateAndGet<int>(delayEdit, x => x >= 0,
                    "Delay should be greater or equal to 0");

                Settings.Population = population;
                Settings.InitiallyInfected = infected;
                Settings.IllnessDuration = illnessDuration;
                Settings.FatalityRate = fatalityRate;
                Settings.TransmissionRange = transmissionRange;
                Settings.TransmissionProbabilityAt0 = transmissionProbabilityAt0;
                Settings.TransmissionProbabilityAtRange = transmissionProbabilityAtRange;
                Settings.WorldSize = worldSize;

                SimpleWalk.MinWalk = minWalk;
                SimpleWalk.MaxWalk = maxWalk;

                Delay = delay;
            }
            catch (FormatException)
            {
                return false;
            }

            return true;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
                e.Cancel = !ValidateAndSaveData();

            base.OnClosing(e);
        }
    }
}
