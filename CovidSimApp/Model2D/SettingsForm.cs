using CovidSim;
using CovidSim.Model2D;
using CovidSim.Model2D.Avoidance;
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

        public OneRangeWalkSettings OneRangeWalk { get; set; }

        public TwoRangeWalk.Settings TwoRangeWalk { get; set; }

        public int Delay { get; set; }

        AvoidanceStrategy.Settings Avoidance => Settings.Avoidance;

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
            //General
            populationEdit.Text = Settings.Population.ToString();
            infectedEdit.Text = Settings.InitiallyInfected.ToString();
            minIllnessDurationEdit.Text = Settings.MinIllnessDuration.ToString();
            maxIllnessDurationEdit.Text = Settings.MaxIllnessDuration.ToString();
            fatalityRateEdit.Text = Settings.FatalityRate.ToString();
            worldSizeEdit.Text = Settings.WorldSize.ToString();
            delayEdit.Text = Delay.ToString();

            //Transmission
            transmissionRangeEdit.Text = Settings.TransmissionRange.ToString();
            transmissionProbabilityAt0Edit.Text = Settings.TransmissionProbabilityAt0.ToString();
            transmissionProbabilityAtRangeEdit.Text = Settings.TransmissionProbabilityAtRange.ToString();
            reinfectionProbabilityEdit.Text = Settings.ReinfectionProbability.ToString();

            //Avoidance
            avoidanceEnabledCheck.Checked = Avoidance.Enabled;
            avoidanceRangeEdit.Text = Avoidance.Range.ToString();
            avoidanceStepAt0Edit.Text = Avoidance.StepAt0.ToString();
            avoidanceStepAtRangeEdit.Text = Avoidance.StepAtRange.ToString();
            avoidanceMaxStepEdit.Text = Avoidance.MaxStep != null ? Avoidance.MaxStep.ToString() : "";
            EnabledFlagChanged();

            //Walk
            walkSettingsControl.OneRangeWalk = OneRangeWalk;
            walkSettingsControl.TwoRangeWalk = TwoRangeWalk;
            walkSettingsControl.SelectedWalk = Settings.Walk;

            //Quarantine
            quarantineControl.Quarantine = Settings.Quarantine;
        }

        bool ValidateAndSaveData()
        {
            try
            {
                //General
                var population = ValidateAndGet<int>(populationEdit, x => x >= 1,
                    "Expected an integer value greater than 1 for Population");

                var infected = ValidateAndGet<int>(infectedEdit, x => x >= 0,
                    "Expected an integer value greater than 0 for Infected Initially");

                if (infected > population)
                    throw new ValidationException("Infected Initially cannot exceed Population");

                var minIllnessDuration = ValidateAndGet<int>(minIllnessDurationEdit, x => x > 0,
                    "Mimimum Illness Duration should be greater than 0");

                var maxIllnessDuration = ValidateAndGet<int>(maxIllnessDurationEdit, x => x > 0,
                    "Maximum Illness Duration should be greater than 0");

                if (minIllnessDuration > maxIllnessDuration)
                    throw new ValidationException("Minimum illness duration should not exceed maximum duration");

                var fatalityRate = ValidateAndGet<double>(fatalityRateEdit, x => x >= 0 && x <= 1,
                    "Fatality Rate should be between 0 and 1 (including 0 and 1)");

                var worldSize = ValidateAndGet<double>(worldSizeEdit, x => x > 0, "World Size should be greater than 0");
                var delay = ValidateAndGet<int>(delayEdit, x => x >= 0, "Delay should be greater or equal to 0");

                //Transmission
                var transmissionRange = ValidateAndGet<double>(transmissionRangeEdit, x => x > 0,
                    "Transmission Range should be greater than 0");

                var transmissionProbabilityAt0 = ValidateAndGet<double>(transmissionProbabilityAt0Edit, x => x >= 0 && x <= 1,
                    "Transmission Probability should be between 0 and 1 (including 0 and 1)");

                var transmissionProbabilityAtRange = ValidateAndGet<double>(transmissionProbabilityAtRangeEdit, x => x >= 0 && x <= 1,
                    "Transmission Probability at Range should be between 0 and 1 (including 0 and 1)");

                var reinfectionProbability = ValidateAndGet<double>(reinfectionProbabilityEdit, x => x >= 0 && x <= 1,
                    "Reinfection Probability at Range should be between 0 and 1 (including 0 and 1)");

                //Avoidance
                var avoidanceEnabled = avoidanceEnabledCheck.Checked;
                var avoidanceRange = ValidateAndGet<double>(avoidanceRangeEdit, x => x > 0, "Avoidance Range should be greater than 0");
                var avoidanceStepAt0 = ValidateAndGet<double>(avoidanceStepAt0Edit, "Avoidance Step at 0 is required");
                var avoidanceStepAtRange = ValidateAndGet<double>(avoidanceStepAtRangeEdit, "Avoidance Step at Range is required");
                var avoidanceMaxStep = ValidateAndGetNullable<double>(avoidanceMaxStepEdit, x => x > 0, "Avoidance Step should be greater than 0");

                //Walk
                walkSettingsControl.ValidateAndSave(false);

                //Quarantine
                quarantineControl.ValidateAndSave(false);

                //TODO: FIX: Quarantine.StartTime should be available before saving
                //if (Quarantine.StartTime >= maxIllnessDuration)
                //    throw new ValidationException("Quarantine start time should be less than maximum illness duration");

                //Save data
                Settings.Population = population;
                Settings.InitiallyInfected = infected;
                Settings.MinIllnessDuration = minIllnessDuration;
                Settings.MaxIllnessDuration = maxIllnessDuration;
                Settings.FatalityRate = fatalityRate;
                Settings.TransmissionRange = transmissionRange;
                Settings.TransmissionProbabilityAt0 = transmissionProbabilityAt0;
                Settings.TransmissionProbabilityAtRange = transmissionProbabilityAtRange;
                Settings.ReinfectionProbability = reinfectionProbability;
                Settings.WorldSize = worldSize;
                Avoidance.Enabled = avoidanceEnabled;
                Avoidance.Range = avoidanceRange;
                Avoidance.StepAt0 = avoidanceStepAt0;
                Avoidance.StepAtRange = avoidanceStepAtRange;
                Avoidance.MaxStep = avoidanceMaxStep;

                Delay = delay;

                walkSettingsControl.ValidateAndSave();
                Settings.Walk = walkSettingsControl.SelectedWalk;

                quarantineControl.ValidateAndSave();
            }
            catch (ValidationException)
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

        private void avoidanceEnabledCombo_CheckedChanged(object sender, EventArgs e)
        {
            EnabledFlagChanged();
        }

        void EnabledFlagChanged()
        {
            bool enabled = avoidanceEnabledCheck.Checked;
            avoidanceRangeEdit.Enabled = enabled;
            avoidanceStepAt0Edit.Enabled = enabled;
            avoidanceStepAtRangeEdit.Enabled = enabled;
            avoidanceMaxStepEdit.Enabled = enabled;
        }
    }
}
