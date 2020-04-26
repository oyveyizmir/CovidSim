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
using CovidSim;

namespace CovidSimApp.Model2D
{
    public partial class WalkSettingsControl : UserControl, ISavable
    {
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public SimpleWalk.Settings SimpleWalk
        {
            get => (SimpleWalk.Settings)walks[0];

            set
            {
                walks[0] = value;
                ((IWalkSettingsContainer)walkControls[0]).Walk = value;
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public ComplexWalk.Settings ComplexWalk
        {
            get => (ComplexWalk.Settings)walks[1];

            set
            {
                walks[1] = value;
                ((IWalkSettingsContainer)walkControls[1]).Walk = value;
            }
        }

        public WalkStrategy.ISettings SelectedWalk
        {
            get => walks[walkCombo.SelectedIndex];

            set
            {
                int index = walks.FindIndex(x => x == value);
                walkCombo.SelectedIndex = index;
            }
        }

        Control SelectedControl
        {
            get
            {
                int walkIndex = walkCombo.SelectedIndex;
                if (walkIndex < 0 || walkIndex >= walks.Count)
                    return null;

                return walkControls[walkIndex];
            }
        }

        List<WalkStrategy.ISettings> walks = new List<WalkStrategy.ISettings> { null, null };
        List<Control> walkControls = new List<Control>();

        public WalkSettingsControl()
        {
            InitializeComponent();

            walkControls.Add(simpleWalkControl);
            walkControls.Add(twoRangeWalkControl);
        }

        private void walkCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplaySelectedWalk();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            panel.Height = Height - 30;
        }

        void DisplaySelectedWalk()
        {
            foreach (var walkControl in walkControls)
                walkControl.Visible = false;

            var control = SelectedControl;
            if (control == null)
                return;

            control.Dock = DockStyle.Fill;
            control.Visible = true;
        }

        public void ValidateAndSave(bool save = true)
        {
            var control = (IWalkSettingsContainer)SelectedControl;
            if (control == null)
                throw new FormatException("No walk strategy selected");

            control.ValidateAndSave(save);
        }
    }
}
