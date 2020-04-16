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
            this.delayEdit = new System.Windows.Forms.TextBox();
            this.fatalityRateEdit = new System.Windows.Forms.TextBox();
            this.illnessDurationEdit = new System.Windows.Forms.TextBox();
            this.infectedEdit = new System.Windows.Forms.TextBox();
            this.populationEdit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fatalityRateLabel = new System.Windows.Forms.Label();
            this.illnessDurationLabel = new System.Windows.Forms.Label();
            this.infectedLabel = new System.Windows.Forms.Label();
            this.populationLabel = new System.Windows.Forms.Label();
            this.transmissionRangeEdit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.transmissionProbabilityAt0Edit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.transmissionProbabilityAtRangeEdit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.minWalkEdit = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.maxWalkEdit = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.worldSizeEdit = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(365, 54);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 20;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(365, 17);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 19;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // delayEdit
            // 
            this.delayEdit.Location = new System.Drawing.Point(197, 369);
            this.delayEdit.Name = "delayEdit";
            this.delayEdit.Size = new System.Drawing.Size(100, 20);
            this.delayEdit.TabIndex = 17;
            // 
            // fatalityRateEdit
            // 
            this.fatalityRateEdit.Location = new System.Drawing.Point(197, 124);
            this.fatalityRateEdit.Name = "fatalityRateEdit";
            this.fatalityRateEdit.Size = new System.Drawing.Size(100, 20);
            this.fatalityRateEdit.TabIndex = 18;
            // 
            // illnessDurationEdit
            // 
            this.illnessDurationEdit.Location = new System.Drawing.Point(197, 89);
            this.illnessDurationEdit.Name = "illnessDurationEdit";
            this.illnessDurationEdit.Size = new System.Drawing.Size(100, 20);
            this.illnessDurationEdit.TabIndex = 16;
            // 
            // infectedEdit
            // 
            this.infectedEdit.Location = new System.Drawing.Point(197, 54);
            this.infectedEdit.Name = "infectedEdit";
            this.infectedEdit.Size = new System.Drawing.Size(100, 20);
            this.infectedEdit.TabIndex = 14;
            // 
            // populationEdit
            // 
            this.populationEdit.Location = new System.Drawing.Point(197, 19);
            this.populationEdit.Name = "populationEdit";
            this.populationEdit.Size = new System.Drawing.Size(100, 20);
            this.populationEdit.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 372);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Delay, ms";
            // 
            // fatalityRateLabel
            // 
            this.fatalityRateLabel.AutoSize = true;
            this.fatalityRateLabel.Location = new System.Drawing.Point(23, 127);
            this.fatalityRateLabel.Name = "fatalityRateLabel";
            this.fatalityRateLabel.Size = new System.Drawing.Size(66, 13);
            this.fatalityRateLabel.TabIndex = 9;
            this.fatalityRateLabel.Text = "Fatality Rate";
            // 
            // illnessDurationLabel
            // 
            this.illnessDurationLabel.AutoSize = true;
            this.illnessDurationLabel.Location = new System.Drawing.Point(23, 92);
            this.illnessDurationLabel.Name = "illnessDurationLabel";
            this.illnessDurationLabel.Size = new System.Drawing.Size(79, 13);
            this.illnessDurationLabel.TabIndex = 10;
            this.illnessDurationLabel.Text = "Illness Duration";
            // 
            // infectedLabel
            // 
            this.infectedLabel.AutoSize = true;
            this.infectedLabel.Location = new System.Drawing.Point(23, 57);
            this.infectedLabel.Name = "infectedLabel";
            this.infectedLabel.Size = new System.Drawing.Size(80, 13);
            this.infectedLabel.TabIndex = 11;
            this.infectedLabel.Text = "Infected Initially";
            // 
            // populationLabel
            // 
            this.populationLabel.AutoSize = true;
            this.populationLabel.Location = new System.Drawing.Point(23, 22);
            this.populationLabel.Name = "populationLabel";
            this.populationLabel.Size = new System.Drawing.Size(57, 13);
            this.populationLabel.TabIndex = 13;
            this.populationLabel.Text = "Population";
            // 
            // transmissionRangeEdit
            // 
            this.transmissionRangeEdit.Location = new System.Drawing.Point(197, 159);
            this.transmissionRangeEdit.Name = "transmissionRangeEdit";
            this.transmissionRangeEdit.Size = new System.Drawing.Size(100, 20);
            this.transmissionRangeEdit.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Transmission Range";
            // 
            // transmissionProbabilityAt0Edit
            // 
            this.transmissionProbabilityAt0Edit.Location = new System.Drawing.Point(197, 194);
            this.transmissionProbabilityAt0Edit.Name = "transmissionProbabilityAt0Edit";
            this.transmissionProbabilityAt0Edit.Size = new System.Drawing.Size(100, 20);
            this.transmissionProbabilityAt0Edit.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Transmission Probability at 0";
            // 
            // transmissionProbabilityAtRangeEdit
            // 
            this.transmissionProbabilityAtRangeEdit.Location = new System.Drawing.Point(197, 229);
            this.transmissionProbabilityAtRangeEdit.Name = "transmissionProbabilityAtRangeEdit";
            this.transmissionProbabilityAtRangeEdit.Size = new System.Drawing.Size(100, 20);
            this.transmissionProbabilityAtRangeEdit.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Transmission Probability at Range";
            // 
            // minWalkEdit
            // 
            this.minWalkEdit.Location = new System.Drawing.Point(197, 264);
            this.minWalkEdit.Name = "minWalkEdit";
            this.minWalkEdit.Size = new System.Drawing.Size(100, 20);
            this.minWalkEdit.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Minimum Walk";
            // 
            // maxWalkEdit
            // 
            this.maxWalkEdit.Location = new System.Drawing.Point(197, 299);
            this.maxWalkEdit.Name = "maxWalkEdit";
            this.maxWalkEdit.Size = new System.Drawing.Size(100, 20);
            this.maxWalkEdit.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Maximum Walk";
            // 
            // worldSizeEdit
            // 
            this.worldSizeEdit.Location = new System.Drawing.Point(197, 334);
            this.worldSizeEdit.Name = "worldSizeEdit";
            this.worldSizeEdit.Size = new System.Drawing.Size(100, 20);
            this.worldSizeEdit.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 337);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "World Size";
            // 
            // SettingsForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(476, 417);
            this.Controls.Add(this.worldSizeEdit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.maxWalkEdit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.minWalkEdit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.transmissionProbabilityAtRangeEdit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.transmissionProbabilityAt0Edit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.transmissionRangeEdit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.delayEdit);
            this.Controls.Add(this.fatalityRateEdit);
            this.Controls.Add(this.illnessDurationEdit);
            this.Controls.Add(this.infectedEdit);
            this.Controls.Add(this.populationEdit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fatalityRateLabel);
            this.Controls.Add(this.illnessDurationLabel);
            this.Controls.Add(this.infectedLabel);
            this.Controls.Add(this.populationLabel);
            this.Name = "SettingsForm";
            this.Text = "2D Model Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.TextBox delayEdit;
        private System.Windows.Forms.TextBox fatalityRateEdit;
        private System.Windows.Forms.TextBox illnessDurationEdit;
        private System.Windows.Forms.TextBox infectedEdit;
        private System.Windows.Forms.TextBox populationEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label fatalityRateLabel;
        private System.Windows.Forms.Label illnessDurationLabel;
        private System.Windows.Forms.Label infectedLabel;
        private System.Windows.Forms.Label populationLabel;
        private System.Windows.Forms.TextBox transmissionRangeEdit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox transmissionProbabilityAt0Edit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox transmissionProbabilityAtRangeEdit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox minWalkEdit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox maxWalkEdit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox worldSizeEdit;
        private System.Windows.Forms.Label label7;
    }
}