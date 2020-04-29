using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CovidSim.Model2D.Walk;

using static CovidSimApp.ValidationUtils;

namespace CovidSimApp.Model2D
{
    public partial class ShapeWalkControl : UserControl, IWalkSettingsContainer
    {
        ShapeWalkSettings walk;

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public ShapeWalkSettings Walk
        {
            get => walk;

            set
            {
                walk = value ?? throw new ArgumentNullException("Walk cannot be null");
                DisplayData();
            }
        }

        IWalkSettings IWalkSettingsContainer.Walk
        {
            get => Walk;
            set => Walk = (ShapeWalkSettings)value;
        }

        public ShapeWalkControl()
        {
            InitializeComponent();
        }

        void DisplayData()
        {
            minWalkEdit.Text = Walk.MinWalk.ToString();
            maxWalkEdit.Text = Walk.MaxWalk.ToString();
        }

        public void ValidateAndSave(bool save = true)
        {
            var minWalk = ValidateAndGet<double>(minWalkEdit, x => x >= 0, "Minimum Walk cannot be less than 0");
            var maxWalk = ValidateAndGet<double>(maxWalkEdit, x => x >= 0, "Maximum Walk cannot be less than 0");
            ValidateAndGet<double>(minWalkEdit, x => x <= maxWalk, "Minimum Walk cannot exceed Maximum Walk");

            if (save)
            {
                Walk.MinWalk = minWalk;
                Walk.MaxWalk = maxWalk;
            }
        }
    }
}
