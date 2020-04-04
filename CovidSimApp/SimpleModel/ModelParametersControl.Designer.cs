namespace CovidSimApp.SimpleModel
{
    partial class ModelParametersControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.transitionRateSlider = new System.Windows.Forms.TrackBar();
            this.transitionRateEdit = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.transitionRateSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Transition Rate";
            // 
            // transitionRateSlider
            // 
            this.transitionRateSlider.Location = new System.Drawing.Point(153, 6);
            this.transitionRateSlider.Maximum = 200;
            this.transitionRateSlider.Name = "transitionRateSlider";
            this.transitionRateSlider.Size = new System.Drawing.Size(161, 45);
            this.transitionRateSlider.TabIndex = 1;
            this.transitionRateSlider.TickFrequency = 10;
            this.transitionRateSlider.Scroll += new System.EventHandler(this.transitionRateSlider_Scroll);
            // 
            // transitionRateEdit
            // 
            this.transitionRateEdit.Location = new System.Drawing.Point(89, 6);
            this.transitionRateEdit.Name = "transitionRateEdit";
            this.transitionRateEdit.Size = new System.Drawing.Size(58, 20);
            this.transitionRateEdit.TabIndex = 2;
            this.transitionRateEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.transitionRateEdit_KeyPress);
            // 
            // ModelParametersControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.transitionRateEdit);
            this.Controls.Add(this.transitionRateSlider);
            this.Controls.Add(this.label1);
            this.Name = "ModelParametersControl";
            this.Size = new System.Drawing.Size(344, 103);
            ((System.ComponentModel.ISupportInitialize)(this.transitionRateSlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar transitionRateSlider;
        private System.Windows.Forms.TextBox transitionRateEdit;
    }
}
