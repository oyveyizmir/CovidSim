namespace CovidSimApp.Model2D
{
    partial class OneRangeWalkControl
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
            this.maxWalkEdit = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.minWalkEdit = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.areaCombo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // maxWalkEdit
            // 
            this.maxWalkEdit.Location = new System.Drawing.Point(113, 90);
            this.maxWalkEdit.Name = "maxWalkEdit";
            this.maxWalkEdit.Size = new System.Drawing.Size(100, 20);
            this.maxWalkEdit.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 51;
            this.label6.Text = "Maximum Walk";
            // 
            // minWalkEdit
            // 
            this.minWalkEdit.Location = new System.Drawing.Point(113, 55);
            this.minWalkEdit.Name = "minWalkEdit";
            this.minWalkEdit.Size = new System.Drawing.Size(100, 20);
            this.minWalkEdit.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "Minimum Walk";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "Area";
            // 
            // areaCombo
            // 
            this.areaCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.areaCombo.FormattingEnabled = true;
            this.areaCombo.Items.AddRange(new object[] {
            "Circle",
            "Square"});
            this.areaCombo.Location = new System.Drawing.Point(113, 18);
            this.areaCombo.Name = "areaCombo";
            this.areaCombo.Size = new System.Drawing.Size(100, 21);
            this.areaCombo.TabIndex = 0;
            // 
            // OneRangeWalkControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.areaCombo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maxWalkEdit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.minWalkEdit);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "OneRangeWalkControl";
            this.Size = new System.Drawing.Size(247, 156);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox maxWalkEdit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox minWalkEdit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox areaCombo;
    }
}
