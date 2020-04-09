namespace CovidSimApp
{
    partial class MainForm
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
            this.simpleModelButton = new System.Windows.Forms.Button();
            this.buttonModel2D = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // simpleModelButton
            // 
            this.simpleModelButton.Location = new System.Drawing.Point(12, 12);
            this.simpleModelButton.Name = "simpleModelButton";
            this.simpleModelButton.Size = new System.Drawing.Size(268, 23);
            this.simpleModelButton.TabIndex = 0;
            this.simpleModelButton.Text = "Simple Model";
            this.simpleModelButton.UseVisualStyleBackColor = true;
            this.simpleModelButton.Click += new System.EventHandler(this.simpleModelButton_Click);
            // 
            // buttonModel2D
            // 
            this.buttonModel2D.Location = new System.Drawing.Point(12, 42);
            this.buttonModel2D.Name = "buttonModel2D";
            this.buttonModel2D.Size = new System.Drawing.Size(268, 23);
            this.buttonModel2D.TabIndex = 1;
            this.buttonModel2D.Text = "2D Model";
            this.buttonModel2D.UseVisualStyleBackColor = true;
            this.buttonModel2D.Click += new System.EventHandler(this.buttonModel2D_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 105);
            this.Controls.Add(this.buttonModel2D);
            this.Controls.Add(this.simpleModelButton);
            this.Name = "MainForm";
            this.Text = "Covid Simulator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button simpleModelButton;
        private System.Windows.Forms.Button buttonModel2D;
    }
}