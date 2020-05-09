using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CovidSim.Model2D;

using static CovidSimApp.ValidationUtils;

namespace CovidSimApp.Model2D
{
    public partial class QuarantineControl : UserControl
    {
        QuarantineSettings quarantine;

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public QuarantineSettings Quarantine
        {
            get => quarantine;

            set
            {
                quarantine = value ?? throw new ArgumentNullException("Quarantine cannot be null");
                DisplayData();
            }
        }

        public QuarantineControl()
        {
            InitializeComponent();
        }

        void DisplayData()
        {
            quarantineEnabledCheck.Checked = quarantine.Enabled;
            startTimeEdit.Text = quarantine.StartTime.ToString();
            probabilityEdit.Text = quarantine.Probability.ToString();
            maxCapacityEdit.Text = quarantine.MaxCapacity != null ? quarantine.MaxCapacity.ToString() : "";
            EnabledFlagChanged();
        }

        public void ValidateAndSave(bool save = true)
        {
            var enabled = quarantineEnabledCheck.Checked;
            var startTime = ValidateAndGet<int>(startTimeEdit, x => x >= 0, "Start time cannot be less than 0");
            var probability = ValidateAndGet<double>(probabilityEdit, x => x >= 0 && x <= 1, "Probability should be in range [0, 1] (inclusive)");
            var maxCapacity = ValidateAndGetNullable<int>(maxCapacityEdit, x => x >= 0, "Max capacity cannot be less than 0");

            if (save)
            {
                quarantine.Enabled = enabled;
                quarantine.StartTime = startTime;
                quarantine.Probability = probability;
                quarantine.MaxCapacity = maxCapacity;
            }
        }

        private void quarantineEnabledCheck_CheckedChanged(object sender, EventArgs e)
        {
            EnabledFlagChanged();
        }

        void EnabledFlagChanged()
        {
            bool enabled = quarantineEnabledCheck.Checked;
            startTimeEdit.Enabled = enabled;
            probabilityEdit.Enabled = enabled;
            maxCapacityEdit.Enabled = enabled;
        }
    }
}
