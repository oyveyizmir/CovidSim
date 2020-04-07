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
    public partial class SimpleModelSettingsForm : Form
    {
        public Settings Settings { get; set; }
        public int Delay { get; set; }

        public SimpleModelSettingsForm()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            ReadData();
        }

        void ReadData()
        {
            populationEdit.Text = Settings.Population.ToString();
            infectedEdit.Text = Settings.InitiallyInfected.ToString();
            transitionRateEdit.Text = Settings.TransitionRate.ToString();
            illnessDurationEdit.Text = Settings.IllnessDuration.ToString();
            fatalityRateEdit.Text = Settings.FatalityRate.ToString();
            delayEdit.Text = Delay.ToString();
        }

        bool ValidateAndSaveData()
        {
            try
            {
                int population = ValidateAndGet<int>(populationEdit, x => x >= 1,
                    "Expected an integer value greater than 1 for Population");
                int infected = ValidateAndGet<int>(infectedEdit, x => x >= 0,
                    "Expected an integer value greater than 0 for Infected Initially");
                ValidateAndGet<int>(infectedEdit, x => x <= population,
                    "Infected Initially cannot exceed Population");
                double transitionRate = ValidateAndGet<double>(transitionRateEdit, x => x >= 0,
                    "Transition Rate should be greater or equal to 0");
                double illnessDuration = ValidateAndGet<double>(illnessDurationEdit, x => x > 0,
                    "Illness Duration should be greater than 0");
                double fatalityRate = ValidateAndGet<double>(fatalityRateEdit, x => x >= 0 && x <= 1,
                    "Fatality Rate should be between 0 and 1 (including 0 and 1)");
                int delay = ValidateAndGet<int>(delayEdit, x => x >= 1,
                    "Delay should be greater or equal to 1");

                Settings.Population = population;
                Settings.InitiallyInfected = infected;
                Settings.TransitionRate = transitionRate;
                Settings.IllnessDuration = illnessDuration;
                Settings.FatalityRate = fatalityRate;
                Delay = delay;
            }
            catch (FormatException)
            {
                return false;
            }

            return true;
        }

        T ValidateAndGet<T>(TextBox edit, Func<T, bool> validationFunc, string message)
        {
            try
            {
                T value = (T)Convert.ChangeType(edit.Text, typeof(T));
                if (validationFunc(value))
                    return value;
                throw new FormatException(message);
            }
            catch (FormatException)
            {
                MessageBox.Show(message, "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                edit.Focus();
                throw;
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
                e.Cancel = !ValidateAndSaveData();

            base.OnClosing(e);
        }

    }
}
