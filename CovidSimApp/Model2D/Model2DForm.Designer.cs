namespace CovidSimApp.Model2D
{
    partial class Model2DForm
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
            this.components = new System.ComponentModel.Container();
            this.settingsButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.startStopButton = new System.Windows.Forms.Button();
            this.populationControl = new CovidSimApp.Controls.Population2D.PopulationControl();
            this.realTimeStats = new CovidSimApp.Controls.RealTimeStats();
            this.diagram = new CovidSimApp.Diagram.DiagramControl();
            this.SuspendLayout();
            // 
            // settingsButton
            // 
            this.settingsButton.Location = new System.Drawing.Point(175, 12);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(75, 23);
            this.settingsButton.TabIndex = 9;
            this.settingsButton.Text = "Settings...";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(93, 12);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 8;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // startStopButton
            // 
            this.startStopButton.Location = new System.Drawing.Point(12, 12);
            this.startStopButton.Name = "startStopButton";
            this.startStopButton.Size = new System.Drawing.Size(75, 23);
            this.startStopButton.TabIndex = 7;
            this.startStopButton.Text = "Start";
            this.startStopButton.UseVisualStyleBackColor = true;
            this.startStopButton.Click += new System.EventHandler(this.startStopButton_Click);
            // 
            // populationControl
            // 
            this.populationControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.populationControl.BackColor = System.Drawing.Color.White;
            this.populationControl.Location = new System.Drawing.Point(0, 268);
            this.populationControl.Name = "populationControl";
            this.populationControl.Size = new System.Drawing.Size(510, 503);
            this.populationControl.TabIndex = 11;
            this.populationControl.Text = "populationControl1";
            this.populationControl.WorldSize = 1000D;
            // 
            // realTimeStats
            // 
            this.realTimeStats.Location = new System.Drawing.Point(13, 42);
            this.realTimeStats.Name = "realTimeStats";
            this.realTimeStats.Size = new System.Drawing.Size(367, 103);
            this.realTimeStats.TabIndex = 10;
            // 
            // diagram
            // 
            this.diagram.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.diagram.BackColor = System.Drawing.Color.White;
            this.diagram.Location = new System.Drawing.Point(0, 151);
            this.diagram.Name = "diagram";
            this.diagram.Size = new System.Drawing.Size(510, 111);
            this.diagram.TabIndex = 6;
            this.diagram.Text = "diagram";
            // 
            // Model2DForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 771);
            this.Controls.Add(this.populationControl);
            this.Controls.Add(this.realTimeStats);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.startStopButton);
            this.Controls.Add(this.diagram);
            this.Name = "Model2DForm";
            this.Text = "2D Model";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.RealTimeStats realTimeStats;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button startStopButton;
        private Diagram.DiagramControl diagram;
        private Controls.Population2D.PopulationControl populationControl;
    }
}