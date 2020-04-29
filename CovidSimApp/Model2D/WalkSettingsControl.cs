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
        public ShapeWalkSettings ShapeWalk
        {
            get => (ShapeWalkSettings)GetContainer(0).Walk;
            set => GetContainer(0).Walk = value;
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public TwoRangeWalk.Settings TwoRangeWalk
        {
            get => (TwoRangeWalk.Settings)GetContainer(1).Walk;
            set => GetContainer(1).Walk = value;
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IWalkSettings SelectedWalk
        {
            get => GetContainer(walkCombo.SelectedIndex).Walk;

            set
            {
                int index = walkControls.FindIndex(x => ((IWalkSettingsContainer)x).Walk == value);
                walkCombo.SelectedIndex = index;
            }
        }

        Control SelectedControl
        {
            get
            {
                int walkIndex = walkCombo.SelectedIndex;
                if (walkIndex < 0 || walkIndex >= walkControls.Count)
                    return null;

                return walkControls[walkIndex];
            }
        }

        List<Control> walkControls = new List<Control>();

        public WalkSettingsControl()
        {
            InitializeComponent();

            walkControls.Add(shapeWalkControl);
            walkControls.Add(twoRangeWalkControl);
        }

        IWalkSettingsContainer GetContainer(int index) => (IWalkSettingsContainer)walkControls[index];

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
