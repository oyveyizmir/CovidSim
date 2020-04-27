namespace CovidSimApp.Model2D
{
    partial class WalkSettingsControl
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
            this.walkCombo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.twoRangeWalkControl = new CovidSimApp.Model2D.TwoRangeWalkControl();
            this.simpleWalkControl = new CovidSimApp.Model2D.SimpleWalkControl();
            this.separator = new System.Windows.Forms.Panel();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // walkCombo
            // 
            this.walkCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.walkCombo.FormattingEnabled = true;
            this.walkCombo.Items.AddRange(new object[] {
            "Simple",
            "2 Ranges"});
            this.walkCombo.Location = new System.Drawing.Point(113, 19);
            this.walkCombo.Name = "walkCombo";
            this.walkCombo.Size = new System.Drawing.Size(100, 21);
            this.walkCombo.TabIndex = 51;
            this.walkCombo.SelectedIndexChanged += new System.EventHandler(this.walkCombo_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 50;
            this.label8.Text = "Walk Strategy";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.twoRangeWalkControl);
            this.panel.Controls.Add(this.simpleWalkControl);
            this.panel.Location = new System.Drawing.Point(0, 57);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(486, 426);
            this.panel.TabIndex = 54;
            // 
            // twoRangeWalkControl
            // 
            this.twoRangeWalkControl.Location = new System.Drawing.Point(23, 104);
            this.twoRangeWalkControl.Name = "twoRangeWalkControl";
            this.twoRangeWalkControl.Size = new System.Drawing.Size(246, 302);
            this.twoRangeWalkControl.TabIndex = 54;
            this.twoRangeWalkControl.Visible = false;
            // 
            // simpleWalkControl
            // 
            this.simpleWalkControl.Location = new System.Drawing.Point(34, 12);
            this.simpleWalkControl.Name = "simpleWalkControl";
            this.simpleWalkControl.Size = new System.Drawing.Size(247, 108);
            this.simpleWalkControl.TabIndex = 53;
            this.simpleWalkControl.Visible = false;
            // 
            // separator
            // 
            this.separator.BackColor = System.Drawing.SystemColors.ControlDark;
            this.separator.Location = new System.Drawing.Point(0, 57);
            this.separator.Name = "separator";
            this.separator.Size = new System.Drawing.Size(452, 1);
            this.separator.TabIndex = 55;
            // 
            // WalkSettingsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.separator);
            this.Controls.Add(this.walkCombo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel);
            this.Name = "WalkSettingsControl";
            this.Size = new System.Drawing.Size(486, 483);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox walkCombo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel;
        private TwoRangeWalkControl twoRangeWalkControl;
        private SimpleWalkControl simpleWalkControl;
        private System.Windows.Forms.Panel separator;
    }
}
