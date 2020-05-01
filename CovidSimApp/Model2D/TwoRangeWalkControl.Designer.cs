namespace CovidSimApp.Model2D
{
    partial class TwoRangeWalkControl
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
            this.maxWalk2Edit = new System.Windows.Forms.TextBox();
            this.maxWalk1Edit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.probability1Edit = new System.Windows.Forms.TextBox();
            this.probability2Edit = new System.Windows.Forms.TextBox();
            this.minWalk2Edit = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.minWalk1Edit = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.areaCombo = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // maxWalk2Edit
            // 
            this.maxWalk2Edit.Location = new System.Drawing.Point(113, 294);
            this.maxWalk2Edit.Name = "maxWalk2Edit";
            this.maxWalk2Edit.Size = new System.Drawing.Size(100, 20);
            this.maxWalk2Edit.TabIndex = 5;
            // 
            // maxWalk1Edit
            // 
            this.maxWalk1Edit.Location = new System.Drawing.Point(113, 154);
            this.maxWalk1Edit.Name = "maxWalk1Edit";
            this.maxWalk1Edit.Size = new System.Drawing.Size(100, 20);
            this.maxWalk1Edit.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 63;
            this.label4.Text = "Maximum Walk";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 64;
            this.label6.Text = "Maximum Walk";
            // 
            // probability1Edit
            // 
            this.probability1Edit.Location = new System.Drawing.Point(113, 83);
            this.probability1Edit.Name = "probability1Edit";
            this.probability1Edit.Size = new System.Drawing.Size(100, 20);
            this.probability1Edit.TabIndex = 0;
            this.probability1Edit.TextChanged += new System.EventHandler(this.probability1Edit_TextChanged);
            // 
            // probability2Edit
            // 
            this.probability2Edit.Enabled = false;
            this.probability2Edit.Location = new System.Drawing.Point(113, 223);
            this.probability2Edit.Name = "probability2Edit";
            this.probability2Edit.Size = new System.Drawing.Size(100, 20);
            this.probability2Edit.TabIndex = 3;
            // 
            // minWalk2Edit
            // 
            this.minWalk2Edit.Location = new System.Drawing.Point(113, 259);
            this.minWalk2Edit.Name = "minWalk2Edit";
            this.minWalk2Edit.Size = new System.Drawing.Size(100, 20);
            this.minWalk2Edit.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 53;
            this.label8.Text = "Probability";
            // 
            // minWalk1Edit
            // 
            this.minWalk1Edit.Location = new System.Drawing.Point(113, 119);
            this.minWalk1Edit.Name = "minWalk1Edit";
            this.minWalk1Edit.Size = new System.Drawing.Size(100, 20);
            this.minWalk1Edit.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 54;
            this.label7.Text = "Probability";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 55;
            this.label3.Text = "Range 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 56;
            this.label2.Text = "Minimum Walk";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 57;
            this.label1.Text = "Range 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 58;
            this.label5.Text = "Minimum Walk";
            // 
            // areaCombo
            // 
            this.areaCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.areaCombo.FormattingEnabled = true;
            this.areaCombo.Items.AddRange(new object[] {
            "Circle",
            "Square"});
            this.areaCombo.Location = new System.Drawing.Point(113, 21);
            this.areaCombo.Name = "areaCombo";
            this.areaCombo.Size = new System.Drawing.Size(100, 21);
            this.areaCombo.TabIndex = 66;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 65;
            this.label9.Text = "Area";
            // 
            // TwoRangeWalkControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.areaCombo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.maxWalk2Edit);
            this.Controls.Add(this.maxWalk1Edit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.probability1Edit);
            this.Controls.Add(this.probability2Edit);
            this.Controls.Add(this.minWalk2Edit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.minWalk1Edit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "TwoRangeWalkControl";
            this.Size = new System.Drawing.Size(246, 349);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox maxWalk2Edit;
        private System.Windows.Forms.TextBox maxWalk1Edit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox probability1Edit;
        private System.Windows.Forms.TextBox probability2Edit;
        private System.Windows.Forms.TextBox minWalk2Edit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox minWalk1Edit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox areaCombo;
        private System.Windows.Forms.Label label9;
    }
}
