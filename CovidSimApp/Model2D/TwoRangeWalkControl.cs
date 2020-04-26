﻿using System;
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
using CovidSim;

namespace CovidSimApp.Model2D
{
    public partial class TwoRangeWalkControl : UserControl, IWalkSettingsContainer
    {
        private ComplexWalk.Settings walk;

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public ComplexWalk.Settings Walk
        {
            get => walk;

            set
            {
                if (value == null)
                    throw new ArgumentNullException("Walk cannot be null");

                if (value.Ranges.Count != 2)
                    throw new ArgumentException("The walk should contain 2 ranges");

                walk = value;
                DisplayData();
            }
        }

        WalkStrategy.ISettings IWalkSettingsContainer.Walk
        {
            get => Walk;
            set => Walk = (ComplexWalk.Settings)value;
        }

        ComplexWalk.RangeSettings Range1 => walk?.Ranges[0];

        ComplexWalk.RangeSettings Range2 => walk?.Ranges[1];

        double Probability2 => 1 - Range1.Probability;

        public TwoRangeWalkControl()
        {
            InitializeComponent();
        }

        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            if (Visible)
                DisplayData();
        }

        void DisplayRange(ComplexWalk.RangeSettings range, TextBox probability, TextBox minWalk, TextBox maxWalk)
        {
            if (range == null)
                return;

            probability.Text = (range == Range2 ? Probability2 : range.Probability).ToString();
            minWalk.Text = range.MinWalk.ToString();
            maxWalk.Text = range.MaxWalk.ToString();
        }

        void DisplayData()
        {
            DisplayRange(Range1, probability1Edit, minWalk1Edit, maxWalk1Edit);
            DisplayRange(Range2, probability2Edit, minWalk2Edit, maxWalk2Edit);
        }

        void ValidateAndSaveRange(ComplexWalk.RangeSettings range, TextBox probabilityEdit, TextBox minWalkEdit, TextBox maxWalkEdit, bool save)
        {
            var probability = ValidateAndGet<double>(probabilityEdit, x => x >= 0 && x <= 1, "Probability should be in range [0..1] (inclusive)");
            var minWalk = ValidateAndGet<double>(minWalkEdit, x => x >= 0, "Minimum Walk cannot be less than 0");
            var maxWalk = ValidateAndGet<double>(maxWalkEdit, x => x >= 0, "Maximum Walk cannot be less than 0");
            ValidateAndGet<double>(minWalkEdit, x => x <= maxWalk, "Minimum Walk cannot exceed Maximum Walk");

            if (save)
            {
                if (range == Range1)
                    range.Probability = probability;
                range.MinWalk = minWalk;
                range.MaxWalk = maxWalk;
            }
        }

        private void probability1Edit_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(((TextBox)sender).Text, out double probability1))
                probability2Edit.Text = (1 - probability1).ToString();
            else
                probability2Edit.Text = "";
        }

        public void ValidateAndSave(bool save = true)
        {
            ValidateAndSaveRange(Range1, probability1Edit, minWalk1Edit, maxWalk1Edit, save);
            ValidateAndSaveRange(Range2, probability2Edit, minWalk2Edit, maxWalk2Edit, save);
        }
    }
}