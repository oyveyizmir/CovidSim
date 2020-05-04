namespace CovidSimApp.Model2D
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.worldSizeEdit = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.delayEdit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fatalityRateEdit = new System.Windows.Forms.TextBox();
            this.illnessDurationEdit = new System.Windows.Forms.TextBox();
            this.infectedEdit = new System.Windows.Forms.TextBox();
            this.populationEdit = new System.Windows.Forms.TextBox();
            this.fatalityRateLabel = new System.Windows.Forms.Label();
            this.illnessDurationLabel = new System.Windows.Forms.Label();
            this.infectedLabel = new System.Windows.Forms.Label();
            this.populationLabel = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabTransmission = new System.Windows.Forms.TabPage();
            this.transmissionProbabilityAtRangeEdit = new System.Windows.Forms.TextBox();
            this.transmissionProbabilityAt0Edit = new System.Windows.Forms.TextBox();
            this.transmissionRangeEdit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabWalk = new System.Windows.Forms.TabPage();
            this.tabAvoidance = new System.Windows.Forms.TabPage();
            this.avoidanceMaxStepEdit = new System.Windows.Forms.TextBox();
            this.maxStepLabel = new System.Windows.Forms.Label();
            this.avoidanceStepAtRangeEdit = new System.Windows.Forms.TextBox();
            this.avoidanceStepAt0Edit = new System.Windows.Forms.TextBox();
            this.avoidanceRangeEdit = new System.Windows.Forms.TextBox();
            this.stepAtRangeLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.rangeLabel = new System.Windows.Forms.Label();
            this.avoidanceEnabledCombo = new System.Windows.Forms.CheckBox();
            this.walkSettingsControl = new CovidSimApp.Model2D.WalkSettingsControl();
            this.tabGeneral.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabTransmission.SuspendLayout();
            this.tabWalk.SuspendLayout();
            this.tabAvoidance.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(253, 452);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 20;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(172, 452);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 19;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.worldSizeEdit);
            this.tabGeneral.Controls.Add(this.label7);
            this.tabGeneral.Controls.Add(this.delayEdit);
            this.tabGeneral.Controls.Add(this.label1);
            this.tabGeneral.Controls.Add(this.fatalityRateEdit);
            this.tabGeneral.Controls.Add(this.illnessDurationEdit);
            this.tabGeneral.Controls.Add(this.infectedEdit);
            this.tabGeneral.Controls.Add(this.populationEdit);
            this.tabGeneral.Controls.Add(this.fatalityRateLabel);
            this.tabGeneral.Controls.Add(this.illnessDurationLabel);
            this.tabGeneral.Controls.Add(this.infectedLabel);
            this.tabGeneral.Controls.Add(this.populationLabel);
            this.tabGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeneral.Size = new System.Drawing.Size(312, 399);
            this.tabGeneral.TabIndex = 0;
            this.tabGeneral.Text = "General";
            this.tabGeneral.UseVisualStyleBackColor = true;
            // 
            // worldSizeEdit
            // 
            this.worldSizeEdit.Location = new System.Drawing.Point(105, 161);
            this.worldSizeEdit.Name = "worldSizeEdit";
            this.worldSizeEdit.Size = new System.Drawing.Size(100, 20);
            this.worldSizeEdit.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 43;
            this.label7.Text = "World Size";
            // 
            // delayEdit
            // 
            this.delayEdit.Location = new System.Drawing.Point(105, 196);
            this.delayEdit.Name = "delayEdit";
            this.delayEdit.Size = new System.Drawing.Size(100, 20);
            this.delayEdit.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Delay, ms";
            // 
            // fatalityRateEdit
            // 
            this.fatalityRateEdit.Location = new System.Drawing.Point(105, 124);
            this.fatalityRateEdit.Name = "fatalityRateEdit";
            this.fatalityRateEdit.Size = new System.Drawing.Size(100, 20);
            this.fatalityRateEdit.TabIndex = 3;
            // 
            // illnessDurationEdit
            // 
            this.illnessDurationEdit.Location = new System.Drawing.Point(105, 89);
            this.illnessDurationEdit.Name = "illnessDurationEdit";
            this.illnessDurationEdit.Size = new System.Drawing.Size(100, 20);
            this.illnessDurationEdit.TabIndex = 2;
            // 
            // infectedEdit
            // 
            this.infectedEdit.Location = new System.Drawing.Point(105, 54);
            this.infectedEdit.Name = "infectedEdit";
            this.infectedEdit.Size = new System.Drawing.Size(100, 20);
            this.infectedEdit.TabIndex = 1;
            // 
            // populationEdit
            // 
            this.populationEdit.Location = new System.Drawing.Point(105, 19);
            this.populationEdit.Name = "populationEdit";
            this.populationEdit.Size = new System.Drawing.Size(100, 20);
            this.populationEdit.TabIndex = 0;
            // 
            // fatalityRateLabel
            // 
            this.fatalityRateLabel.AutoSize = true;
            this.fatalityRateLabel.Location = new System.Drawing.Point(16, 127);
            this.fatalityRateLabel.Name = "fatalityRateLabel";
            this.fatalityRateLabel.Size = new System.Drawing.Size(66, 13);
            this.fatalityRateLabel.TabIndex = 24;
            this.fatalityRateLabel.Text = "Fatality Rate";
            // 
            // illnessDurationLabel
            // 
            this.illnessDurationLabel.AutoSize = true;
            this.illnessDurationLabel.Location = new System.Drawing.Point(16, 92);
            this.illnessDurationLabel.Name = "illnessDurationLabel";
            this.illnessDurationLabel.Size = new System.Drawing.Size(79, 13);
            this.illnessDurationLabel.TabIndex = 25;
            this.illnessDurationLabel.Text = "Illness Duration";
            // 
            // infectedLabel
            // 
            this.infectedLabel.AutoSize = true;
            this.infectedLabel.Location = new System.Drawing.Point(16, 57);
            this.infectedLabel.Name = "infectedLabel";
            this.infectedLabel.Size = new System.Drawing.Size(80, 13);
            this.infectedLabel.TabIndex = 26;
            this.infectedLabel.Text = "Infected Initially";
            // 
            // populationLabel
            // 
            this.populationLabel.AutoSize = true;
            this.populationLabel.Location = new System.Drawing.Point(16, 22);
            this.populationLabel.Name = "populationLabel";
            this.populationLabel.Size = new System.Drawing.Size(57, 13);
            this.populationLabel.TabIndex = 27;
            this.populationLabel.Text = "Population";
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabGeneral);
            this.tabControl.Controls.Add(this.tabTransmission);
            this.tabControl.Controls.Add(this.tabWalk);
            this.tabControl.Controls.Add(this.tabAvoidance);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(320, 425);
            this.tabControl.TabIndex = 33;
            // 
            // tabTransmission
            // 
            this.tabTransmission.Controls.Add(this.transmissionProbabilityAtRangeEdit);
            this.tabTransmission.Controls.Add(this.transmissionProbabilityAt0Edit);
            this.tabTransmission.Controls.Add(this.transmissionRangeEdit);
            this.tabTransmission.Controls.Add(this.label4);
            this.tabTransmission.Controls.Add(this.label3);
            this.tabTransmission.Controls.Add(this.label2);
            this.tabTransmission.Location = new System.Drawing.Point(4, 22);
            this.tabTransmission.Name = "tabTransmission";
            this.tabTransmission.Size = new System.Drawing.Size(312, 399);
            this.tabTransmission.TabIndex = 2;
            this.tabTransmission.Text = "Transmission";
            this.tabTransmission.UseVisualStyleBackColor = true;
            // 
            // transmissionProbabilityAtRangeEdit
            // 
            this.transmissionProbabilityAtRangeEdit.Location = new System.Drawing.Point(190, 91);
            this.transmissionProbabilityAtRangeEdit.Name = "transmissionProbabilityAtRangeEdit";
            this.transmissionProbabilityAtRangeEdit.Size = new System.Drawing.Size(100, 20);
            this.transmissionProbabilityAtRangeEdit.TabIndex = 44;
            // 
            // transmissionProbabilityAt0Edit
            // 
            this.transmissionProbabilityAt0Edit.Location = new System.Drawing.Point(190, 56);
            this.transmissionProbabilityAt0Edit.Name = "transmissionProbabilityAt0Edit";
            this.transmissionProbabilityAt0Edit.Size = new System.Drawing.Size(100, 20);
            this.transmissionProbabilityAt0Edit.TabIndex = 42;
            // 
            // transmissionRangeEdit
            // 
            this.transmissionRangeEdit.Location = new System.Drawing.Point(190, 19);
            this.transmissionRangeEdit.Name = "transmissionRangeEdit";
            this.transmissionRangeEdit.Size = new System.Drawing.Size(100, 20);
            this.transmissionRangeEdit.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Transmission Probability at Range";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Transmission Probability at 0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Transmission Range";
            // 
            // tabWalk
            // 
            this.tabWalk.Controls.Add(this.walkSettingsControl);
            this.tabWalk.Location = new System.Drawing.Point(4, 22);
            this.tabWalk.Name = "tabWalk";
            this.tabWalk.Padding = new System.Windows.Forms.Padding(3);
            this.tabWalk.Size = new System.Drawing.Size(312, 399);
            this.tabWalk.TabIndex = 1;
            this.tabWalk.Text = "Walk";
            this.tabWalk.UseVisualStyleBackColor = true;
            // 
            // tabAvoidance
            // 
            this.tabAvoidance.Controls.Add(this.avoidanceEnabledCombo);
            this.tabAvoidance.Controls.Add(this.avoidanceMaxStepEdit);
            this.tabAvoidance.Controls.Add(this.maxStepLabel);
            this.tabAvoidance.Controls.Add(this.avoidanceStepAtRangeEdit);
            this.tabAvoidance.Controls.Add(this.avoidanceStepAt0Edit);
            this.tabAvoidance.Controls.Add(this.avoidanceRangeEdit);
            this.tabAvoidance.Controls.Add(this.stepAtRangeLabel);
            this.tabAvoidance.Controls.Add(this.label9);
            this.tabAvoidance.Controls.Add(this.rangeLabel);
            this.tabAvoidance.Location = new System.Drawing.Point(4, 22);
            this.tabAvoidance.Name = "tabAvoidance";
            this.tabAvoidance.Size = new System.Drawing.Size(312, 399);
            this.tabAvoidance.TabIndex = 3;
            this.tabAvoidance.Text = "Avoidance";
            this.tabAvoidance.UseVisualStyleBackColor = true;
            // 
            // avoidanceMaxStepEdit
            // 
            this.avoidanceMaxStepEdit.Location = new System.Drawing.Point(102, 155);
            this.avoidanceMaxStepEdit.Name = "avoidanceMaxStepEdit";
            this.avoidanceMaxStepEdit.Size = new System.Drawing.Size(100, 20);
            this.avoidanceMaxStepEdit.TabIndex = 48;
            // 
            // maxStepLabel
            // 
            this.maxStepLabel.AutoSize = true;
            this.maxStepLabel.Location = new System.Drawing.Point(16, 158);
            this.maxStepLabel.Name = "maxStepLabel";
            this.maxStepLabel.Size = new System.Drawing.Size(52, 13);
            this.maxStepLabel.TabIndex = 55;
            this.maxStepLabel.Text = "Max Step";
            // 
            // avoidanceStepAtRangeEdit
            // 
            this.avoidanceStepAtRangeEdit.Location = new System.Drawing.Point(102, 118);
            this.avoidanceStepAtRangeEdit.Name = "avoidanceStepAtRangeEdit";
            this.avoidanceStepAtRangeEdit.Size = new System.Drawing.Size(100, 20);
            this.avoidanceStepAtRangeEdit.TabIndex = 47;
            // 
            // avoidanceStepAt0Edit
            // 
            this.avoidanceStepAt0Edit.Location = new System.Drawing.Point(102, 83);
            this.avoidanceStepAt0Edit.Name = "avoidanceStepAt0Edit";
            this.avoidanceStepAt0Edit.Size = new System.Drawing.Size(100, 20);
            this.avoidanceStepAt0Edit.TabIndex = 46;
            // 
            // avoidanceRangeEdit
            // 
            this.avoidanceRangeEdit.Location = new System.Drawing.Point(102, 48);
            this.avoidanceRangeEdit.Name = "avoidanceRangeEdit";
            this.avoidanceRangeEdit.Size = new System.Drawing.Size(100, 20);
            this.avoidanceRangeEdit.TabIndex = 45;
            // 
            // stepAtRangeLabel
            // 
            this.stepAtRangeLabel.AutoSize = true;
            this.stepAtRangeLabel.Location = new System.Drawing.Point(16, 121);
            this.stepAtRangeLabel.Name = "stepAtRangeLabel";
            this.stepAtRangeLabel.Size = new System.Drawing.Size(76, 13);
            this.stepAtRangeLabel.TabIndex = 50;
            this.stepAtRangeLabel.Text = "Step at Range";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 51;
            this.label9.Text = "Step at 0";
            // 
            // rangeLabel
            // 
            this.rangeLabel.AutoSize = true;
            this.rangeLabel.Location = new System.Drawing.Point(16, 51);
            this.rangeLabel.Name = "rangeLabel";
            this.rangeLabel.Size = new System.Drawing.Size(39, 13);
            this.rangeLabel.TabIndex = 52;
            this.rangeLabel.Text = "Range";
            // 
            // avoidanceEnabledCombo
            // 
            this.avoidanceEnabledCombo.AutoSize = true;
            this.avoidanceEnabledCombo.Location = new System.Drawing.Point(102, 17);
            this.avoidanceEnabledCombo.Name = "avoidanceEnabledCombo";
            this.avoidanceEnabledCombo.Size = new System.Drawing.Size(65, 17);
            this.avoidanceEnabledCombo.TabIndex = 56;
            this.avoidanceEnabledCombo.Text = "Enabled";
            this.avoidanceEnabledCombo.UseVisualStyleBackColor = true;
            // 
            // walkSettingsControl
            // 
            this.walkSettingsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.walkSettingsControl.Location = new System.Drawing.Point(3, 3);
            this.walkSettingsControl.Name = "walkSettingsControl";
            this.walkSettingsControl.Size = new System.Drawing.Size(306, 393);
            this.walkSettingsControl.TabIndex = 0;
            // 
            // SettingsForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(344, 492);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "2D Model Settings";
            this.tabGeneral.ResumeLayout(false);
            this.tabGeneral.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabTransmission.ResumeLayout(false);
            this.tabTransmission.PerformLayout();
            this.tabWalk.ResumeLayout(false);
            this.tabAvoidance.ResumeLayout(false);
            this.tabAvoidance.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.TextBox worldSizeEdit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox delayEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fatalityRateEdit;
        private System.Windows.Forms.TextBox illnessDurationEdit;
        private System.Windows.Forms.TextBox infectedEdit;
        private System.Windows.Forms.TextBox populationEdit;
        private System.Windows.Forms.Label fatalityRateLabel;
        private System.Windows.Forms.Label illnessDurationLabel;
        private System.Windows.Forms.Label infectedLabel;
        private System.Windows.Forms.Label populationLabel;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabTransmission;
        private System.Windows.Forms.TextBox transmissionProbabilityAtRangeEdit;
        private System.Windows.Forms.TextBox transmissionProbabilityAt0Edit;
        private System.Windows.Forms.TextBox transmissionRangeEdit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabWalk;
        private WalkSettingsControl walkSettingsControl;
        private System.Windows.Forms.TabPage tabAvoidance;
        private System.Windows.Forms.CheckBox avoidanceEnabledCombo;
        private System.Windows.Forms.TextBox avoidanceMaxStepEdit;
        private System.Windows.Forms.Label maxStepLabel;
        private System.Windows.Forms.TextBox avoidanceStepAtRangeEdit;
        private System.Windows.Forms.TextBox avoidanceStepAt0Edit;
        private System.Windows.Forms.TextBox avoidanceRangeEdit;
        private System.Windows.Forms.Label stepAtRangeLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label rangeLabel;
    }
}