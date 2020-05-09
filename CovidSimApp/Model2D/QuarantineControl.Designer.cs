namespace CovidSimApp.Model2D
{
    partial class QuarantineControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.quarantineEnabledCheck = new System.Windows.Forms.CheckBox();
            this.maxCapacityEdit = new System.Windows.Forms.TextBox();
            this.maxStepLabel = new System.Windows.Forms.Label();
            this.probabilityEdit = new System.Windows.Forms.TextBox();
            this.startTimeEdit = new System.Windows.Forms.TextBox();
            this.stepAtRangeLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // quarantineEnabledCheck
            // 
            this.quarantineEnabledCheck.AutoSize = true;
            this.quarantineEnabledCheck.Location = new System.Drawing.Point(95, 16);
            this.quarantineEnabledCheck.Name = "quarantineEnabledCheck";
            this.quarantineEnabledCheck.Size = new System.Drawing.Size(65, 17);
            this.quarantineEnabledCheck.TabIndex = 65;
            this.quarantineEnabledCheck.Text = "Enabled";
            this.quarantineEnabledCheck.UseVisualStyleBackColor = true;
            this.quarantineEnabledCheck.CheckedChanged += new System.EventHandler(this.quarantineEnabledCheck_CheckedChanged);
            // 
            // maxCapacityEdit
            // 
            this.maxCapacityEdit.Location = new System.Drawing.Point(95, 121);
            this.maxCapacityEdit.Name = "maxCapacityEdit";
            this.maxCapacityEdit.Size = new System.Drawing.Size(100, 20);
            this.maxCapacityEdit.TabIndex = 60;
            // 
            // maxStepLabel
            // 
            this.maxStepLabel.AutoSize = true;
            this.maxStepLabel.Location = new System.Drawing.Point(13, 124);
            this.maxStepLabel.Name = "maxStepLabel";
            this.maxStepLabel.Size = new System.Drawing.Size(71, 13);
            this.maxStepLabel.TabIndex = 64;
            this.maxStepLabel.Text = "Max Capacity";
            // 
            // probabilityEdit
            // 
            this.probabilityEdit.Location = new System.Drawing.Point(95, 84);
            this.probabilityEdit.Name = "probabilityEdit";
            this.probabilityEdit.Size = new System.Drawing.Size(100, 20);
            this.probabilityEdit.TabIndex = 59;
            // 
            // startTimeEdit
            // 
            this.startTimeEdit.Location = new System.Drawing.Point(95, 49);
            this.startTimeEdit.Name = "startTimeEdit";
            this.startTimeEdit.Size = new System.Drawing.Size(100, 20);
            this.startTimeEdit.TabIndex = 58;
            // 
            // stepAtRangeLabel
            // 
            this.stepAtRangeLabel.AutoSize = true;
            this.stepAtRangeLabel.Location = new System.Drawing.Point(13, 87);
            this.stepAtRangeLabel.Name = "stepAtRangeLabel";
            this.stepAtRangeLabel.Size = new System.Drawing.Size(55, 13);
            this.stepAtRangeLabel.TabIndex = 61;
            this.stepAtRangeLabel.Text = "Probability";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 62;
            this.label9.Text = "Start Time";
            // 
            // QuarantineControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.quarantineEnabledCheck);
            this.Controls.Add(this.maxCapacityEdit);
            this.Controls.Add(this.maxStepLabel);
            this.Controls.Add(this.probabilityEdit);
            this.Controls.Add(this.startTimeEdit);
            this.Controls.Add(this.stepAtRangeLabel);
            this.Controls.Add(this.label9);
            this.Name = "QuarantineControl";
            this.Size = new System.Drawing.Size(286, 279);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox quarantineEnabledCheck;
        private System.Windows.Forms.TextBox maxCapacityEdit;
        private System.Windows.Forms.Label maxStepLabel;
        private System.Windows.Forms.TextBox probabilityEdit;
        private System.Windows.Forms.TextBox startTimeEdit;
        private System.Windows.Forms.Label stepAtRangeLabel;
        private System.Windows.Forms.Label label9;
    }
}
