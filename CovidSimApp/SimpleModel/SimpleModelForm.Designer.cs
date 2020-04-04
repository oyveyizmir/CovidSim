using CovidSimApp.Diagram;

namespace CovidSimApp.SimpleModel
{
    partial class SimpleModelForm
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
            this.startStopButton = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.resetButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.realTimeStats = new CovidSimApp.Controls.RealTimeStats();
            this.diagram = new CovidSimApp.Diagram.DiagramControl();
            this.modelParametersControl = new CovidSimApp.SimpleModel.ModelParametersControl();
            this.SuspendLayout();
            // 
            // startStopButton
            // 
            this.startStopButton.Location = new System.Drawing.Point(12, 12);
            this.startStopButton.Name = "startStopButton";
            this.startStopButton.Size = new System.Drawing.Size(75, 23);
            this.startStopButton.TabIndex = 1;
            this.startStopButton.Text = "Start";
            this.startStopButton.UseVisualStyleBackColor = true;
            this.startStopButton.Click += new System.EventHandler(this.startStopButton_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(93, 12);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 3;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.Location = new System.Drawing.Point(175, 13);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(75, 23);
            this.settingsButton.TabIndex = 4;
            this.settingsButton.Text = "Settings...";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // realTimeStats
            // 
            this.realTimeStats.Location = new System.Drawing.Point(13, 42);
            this.realTimeStats.Name = "realTimeStats";
            this.realTimeStats.Size = new System.Drawing.Size(367, 103);
            this.realTimeStats.TabIndex = 5;
            // 
            // diagram
            // 
            this.diagram.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.diagram.BackColor = System.Drawing.Color.White;
            this.diagram.Location = new System.Drawing.Point(0, 151);
            this.diagram.Name = "diagram";
            this.diagram.Size = new System.Drawing.Size(800, 299);
            this.diagram.TabIndex = 0;
            this.diagram.Text = "diagram";
            // 
            // modelParametersControl
            // 
            this.modelParametersControl.Location = new System.Drawing.Point(386, 42);
            this.modelParametersControl.Name = "modelParametersControl";
            this.modelParametersControl.Size = new System.Drawing.Size(344, 103);
            this.modelParametersControl.TabIndex = 6;
            // 
            // SimpleModelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.modelParametersControl);
            this.Controls.Add(this.realTimeStats);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.startStopButton);
            this.Controls.Add(this.diagram);
            this.Name = "SimpleModelForm";
            this.Text = "Simple Model";
            this.ResumeLayout(false);

        }

        #endregion

        private DiagramControl diagram;
        private System.Windows.Forms.Button startStopButton;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button settingsButton;
        private Controls.RealTimeStats realTimeStats;
        private ModelParametersControl modelParametersControl;
    }
}

