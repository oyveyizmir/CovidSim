namespace CovidSimApp.SimpleModel
{
    partial class SimpleModelSettingsForm
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
            this.populationLabel = new System.Windows.Forms.Label();
            this.populationEdit = new System.Windows.Forms.TextBox();
            this.transitionRateLabel = new System.Windows.Forms.Label();
            this.transitionRateEdit = new System.Windows.Forms.TextBox();
            this.illnessDurationLabel = new System.Windows.Forms.Label();
            this.illnessDurationEdit = new System.Windows.Forms.TextBox();
            this.infectedLabel = new System.Windows.Forms.Label();
            this.infectedEdit = new System.Windows.Forms.TextBox();
            this.fatalityRateLabel = new System.Windows.Forms.Label();
            this.fatalityRateEdit = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.delayEdit = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // populationLabel
            // 
            this.populationLabel.AutoSize = true;
            this.populationLabel.Location = new System.Drawing.Point(17, 29);
            this.populationLabel.Name = "populationLabel";
            this.populationLabel.Size = new System.Drawing.Size(57, 13);
            this.populationLabel.TabIndex = 0;
            this.populationLabel.Text = "Population";
            // 
            // populationEdit
            // 
            this.populationEdit.Location = new System.Drawing.Point(103, 26);
            this.populationEdit.Name = "populationEdit";
            this.populationEdit.Size = new System.Drawing.Size(100, 20);
            this.populationEdit.TabIndex = 0;
            // 
            // transitionRateLabel
            // 
            this.transitionRateLabel.AutoSize = true;
            this.transitionRateLabel.Location = new System.Drawing.Point(17, 99);
            this.transitionRateLabel.Name = "transitionRateLabel";
            this.transitionRateLabel.Size = new System.Drawing.Size(79, 13);
            this.transitionRateLabel.TabIndex = 0;
            this.transitionRateLabel.Text = "Transition Rate";
            // 
            // transitionRateEdit
            // 
            this.transitionRateEdit.Location = new System.Drawing.Point(103, 96);
            this.transitionRateEdit.Name = "transitionRateEdit";
            this.transitionRateEdit.Size = new System.Drawing.Size(100, 20);
            this.transitionRateEdit.TabIndex = 2;
            // 
            // illnessDurationLabel
            // 
            this.illnessDurationLabel.AutoSize = true;
            this.illnessDurationLabel.Location = new System.Drawing.Point(17, 134);
            this.illnessDurationLabel.Name = "illnessDurationLabel";
            this.illnessDurationLabel.Size = new System.Drawing.Size(79, 13);
            this.illnessDurationLabel.TabIndex = 0;
            this.illnessDurationLabel.Text = "Illness Duration";
            // 
            // illnessDurationEdit
            // 
            this.illnessDurationEdit.Location = new System.Drawing.Point(103, 131);
            this.illnessDurationEdit.Name = "illnessDurationEdit";
            this.illnessDurationEdit.Size = new System.Drawing.Size(100, 20);
            this.illnessDurationEdit.TabIndex = 3;
            // 
            // infectedLabel
            // 
            this.infectedLabel.AutoSize = true;
            this.infectedLabel.Location = new System.Drawing.Point(17, 64);
            this.infectedLabel.Name = "infectedLabel";
            this.infectedLabel.Size = new System.Drawing.Size(80, 13);
            this.infectedLabel.TabIndex = 0;
            this.infectedLabel.Text = "Infected Initially";
            // 
            // infectedEdit
            // 
            this.infectedEdit.Location = new System.Drawing.Point(103, 61);
            this.infectedEdit.Name = "infectedEdit";
            this.infectedEdit.Size = new System.Drawing.Size(100, 20);
            this.infectedEdit.TabIndex = 1;
            // 
            // fatalityRateLabel
            // 
            this.fatalityRateLabel.AutoSize = true;
            this.fatalityRateLabel.Location = new System.Drawing.Point(17, 169);
            this.fatalityRateLabel.Name = "fatalityRateLabel";
            this.fatalityRateLabel.Size = new System.Drawing.Size(66, 13);
            this.fatalityRateLabel.TabIndex = 0;
            this.fatalityRateLabel.Text = "Fatality Rate";
            // 
            // fatalityRateEdit
            // 
            this.fatalityRateEdit.Location = new System.Drawing.Point(103, 166);
            this.fatalityRateEdit.Name = "fatalityRateEdit";
            this.fatalityRateEdit.Size = new System.Drawing.Size(100, 20);
            this.fatalityRateEdit.TabIndex = 4;
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(266, 26);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 5;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(266, 58);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Delay";
            // 
            // delayEdit
            // 
            this.delayEdit.Location = new System.Drawing.Point(103, 201);
            this.delayEdit.Name = "delayEdit";
            this.delayEdit.Size = new System.Drawing.Size(100, 20);
            this.delayEdit.TabIndex = 4;
            // 
            // SimpleModelSettingsForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(364, 247);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.delayEdit);
            this.Controls.Add(this.fatalityRateEdit);
            this.Controls.Add(this.illnessDurationEdit);
            this.Controls.Add(this.infectedEdit);
            this.Controls.Add(this.transitionRateEdit);
            this.Controls.Add(this.populationEdit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fatalityRateLabel);
            this.Controls.Add(this.illnessDurationLabel);
            this.Controls.Add(this.infectedLabel);
            this.Controls.Add(this.transitionRateLabel);
            this.Controls.Add(this.populationLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SimpleModelSettingsForm";
            this.ShowIcon = false;
            this.Text = "Simple Model Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label populationLabel;
        private System.Windows.Forms.TextBox populationEdit;
        private System.Windows.Forms.Label transitionRateLabel;
        private System.Windows.Forms.TextBox transitionRateEdit;
        private System.Windows.Forms.Label illnessDurationLabel;
        private System.Windows.Forms.TextBox illnessDurationEdit;
        private System.Windows.Forms.Label infectedLabel;
        private System.Windows.Forms.TextBox infectedEdit;
        private System.Windows.Forms.Label fatalityRateLabel;
        private System.Windows.Forms.TextBox fatalityRateEdit;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox delayEdit;
    }
}