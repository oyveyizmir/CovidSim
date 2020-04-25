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
            this.tabWalk = new System.Windows.Forms.TabPage();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.fatalityRateEdit = new System.Windows.Forms.TextBox();
            this.illnessDurationEdit = new System.Windows.Forms.TextBox();
            this.infectedEdit = new System.Windows.Forms.TextBox();
            this.populationEdit = new System.Windows.Forms.TextBox();
            this.fatalityRateLabel = new System.Windows.Forms.Label();
            this.illnessDurationLabel = new System.Windows.Forms.Label();
            this.infectedLabel = new System.Windows.Forms.Label();
            this.populationLabel = new System.Windows.Forms.Label();
            this.worldSizeEdit = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.delayEdit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.maxWalkEdit = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.minWalkEdit = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.walkCombo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabTransmission = new System.Windows.Forms.TabPage();
            this.transmissionProbabilityAtRangeEdit = new System.Windows.Forms.TextBox();
            this.transmissionProbabilityAt0Edit = new System.Windows.Forms.TextBox();
            this.transmissionRangeEdit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabWalk.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabTransmission.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(253, 293);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 20;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(172, 293);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 19;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // tabWalk
            // 
            this.tabWalk.Controls.Add(this.walkCombo);
            this.tabWalk.Controls.Add(this.maxWalkEdit);
            this.tabWalk.Controls.Add(this.label8);
            this.tabWalk.Controls.Add(this.label6);
            this.tabWalk.Controls.Add(this.minWalkEdit);
            this.tabWalk.Controls.Add(this.label5);
            this.tabWalk.Location = new System.Drawing.Point(4, 22);
            this.tabWalk.Name = "tabWalk";
            this.tabWalk.Padding = new System.Windows.Forms.Padding(3);
            this.tabWalk.Size = new System.Drawing.Size(312, 240);
            this.tabWalk.TabIndex = 1;
            this.tabWalk.Text = "Walk";
            this.tabWalk.UseVisualStyleBackColor = true;
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
            this.tabGeneral.Size = new System.Drawing.Size(312, 240);
            this.tabGeneral.TabIndex = 0;
            this.tabGeneral.Text = "General";
            this.tabGeneral.UseVisualStyleBackColor = true;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabGeneral);
            this.tabControl.Controls.Add(this.tabTransmission);
            this.tabControl.Controls.Add(this.tabWalk);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(320, 266);
            this.tabControl.TabIndex = 33;
            // 
            // fatalityRateEdit
            // 
            this.fatalityRateEdit.Location = new System.Drawing.Point(105, 124);
            this.fatalityRateEdit.Name = "fatalityRateEdit";
            this.fatalityRateEdit.Size = new System.Drawing.Size(100, 20);
            this.fatalityRateEdit.TabIndex = 30;
            // 
            // illnessDurationEdit
            // 
            this.illnessDurationEdit.Location = new System.Drawing.Point(105, 89);
            this.illnessDurationEdit.Name = "illnessDurationEdit";
            this.illnessDurationEdit.Size = new System.Drawing.Size(100, 20);
            this.illnessDurationEdit.TabIndex = 29;
            // 
            // infectedEdit
            // 
            this.infectedEdit.Location = new System.Drawing.Point(105, 54);
            this.infectedEdit.Name = "infectedEdit";
            this.infectedEdit.Size = new System.Drawing.Size(100, 20);
            this.infectedEdit.TabIndex = 28;
            // 
            // populationEdit
            // 
            this.populationEdit.Location = new System.Drawing.Point(105, 19);
            this.populationEdit.Name = "populationEdit";
            this.populationEdit.Size = new System.Drawing.Size(100, 20);
            this.populationEdit.TabIndex = 23;
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
            // worldSizeEdit
            // 
            this.worldSizeEdit.Location = new System.Drawing.Point(105, 161);
            this.worldSizeEdit.Name = "worldSizeEdit";
            this.worldSizeEdit.Size = new System.Drawing.Size(100, 20);
            this.worldSizeEdit.TabIndex = 44;
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
            this.delayEdit.TabIndex = 34;
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
            // maxWalkEdit
            // 
            this.maxWalkEdit.Location = new System.Drawing.Point(101, 90);
            this.maxWalkEdit.Name = "maxWalkEdit";
            this.maxWalkEdit.Size = new System.Drawing.Size(100, 20);
            this.maxWalkEdit.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 45;
            this.label6.Text = "Maximum Walk";
            // 
            // minWalkEdit
            // 
            this.minWalkEdit.Location = new System.Drawing.Point(101, 55);
            this.minWalkEdit.Name = "minWalkEdit";
            this.minWalkEdit.Size = new System.Drawing.Size(100, 20);
            this.minWalkEdit.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Minimum Walk";
            // 
            // walkCombo
            // 
            this.walkCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.walkCombo.FormattingEnabled = true;
            this.walkCombo.Items.AddRange(new object[] {
            "Simple",
            "2 Ranges"});
            this.walkCombo.Location = new System.Drawing.Point(101, 20);
            this.walkCombo.Name = "walkCombo";
            this.walkCombo.Size = new System.Drawing.Size(100, 21);
            this.walkCombo.TabIndex = 47;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 45;
            this.label8.Text = "Walk Strategy";
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
            this.tabTransmission.Size = new System.Drawing.Size(312, 240);
            this.tabTransmission.TabIndex = 2;
            this.tabTransmission.Text = "Transmission";
            this.tabTransmission.UseVisualStyleBackColor = true;
            // 
            // transmissionProbabilityAtRangeEdit
            // 
            this.transmissionProbabilityAtRangeEdit.Location = new System.Drawing.Point(188, 91);
            this.transmissionProbabilityAtRangeEdit.Name = "transmissionProbabilityAtRangeEdit";
            this.transmissionProbabilityAtRangeEdit.Size = new System.Drawing.Size(100, 20);
            this.transmissionProbabilityAtRangeEdit.TabIndex = 44;
            // 
            // transmissionProbabilityAt0Edit
            // 
            this.transmissionProbabilityAt0Edit.Location = new System.Drawing.Point(188, 56);
            this.transmissionProbabilityAt0Edit.Name = "transmissionProbabilityAt0Edit";
            this.transmissionProbabilityAt0Edit.Size = new System.Drawing.Size(100, 20);
            this.transmissionProbabilityAt0Edit.TabIndex = 42;
            // 
            // transmissionRangeEdit
            // 
            this.transmissionRangeEdit.Location = new System.Drawing.Point(188, 19);
            this.transmissionRangeEdit.Name = "transmissionRangeEdit";
            this.transmissionRangeEdit.Size = new System.Drawing.Size(100, 20);
            this.transmissionRangeEdit.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Transmission Probability at Range";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Transmission Probability at 0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Transmission Range";
            // 
            // SettingsForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(344, 333);
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
            this.tabWalk.ResumeLayout(false);
            this.tabWalk.PerformLayout();
            this.tabGeneral.ResumeLayout(false);
            this.tabGeneral.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabTransmission.ResumeLayout(false);
            this.tabTransmission.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.TabPage tabWalk;
        private System.Windows.Forms.ComboBox walkCombo;
        private System.Windows.Forms.TextBox maxWalkEdit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox minWalkEdit;
        private System.Windows.Forms.Label label5;
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
    }
}