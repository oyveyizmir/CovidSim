namespace CovidSimApp.Model2D
{
    partial class SimpleWalkControl
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
            this.SuspendLayout();
            // 
            // maxWalkEdit
            // 
            this.maxWalkEdit.Location = new System.Drawing.Point(113, 54);
            this.maxWalkEdit.Name = "maxWalkEdit";
            this.maxWalkEdit.Size = new System.Drawing.Size(100, 20);
            this.maxWalkEdit.TabIndex = 52;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 51;
            this.label6.Text = "Maximum Walk";
            // 
            // minWalkEdit
            // 
            this.minWalkEdit.Location = new System.Drawing.Point(113, 19);
            this.minWalkEdit.Name = "minWalkEdit";
            this.minWalkEdit.Size = new System.Drawing.Size(100, 20);
            this.minWalkEdit.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "Minimum Walk";
            // 
            // SimpleWalkControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.maxWalkEdit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.minWalkEdit);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "SimpleWalkControl";
            this.Size = new System.Drawing.Size(247, 108);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox maxWalkEdit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox minWalkEdit;
        private System.Windows.Forms.Label label5;
    }
}
