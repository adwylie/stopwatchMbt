namespace stopwatchImp
{
    partial class stopwatchUI
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
            this.display = new StopwatchDisplay();
            this.ResetLapButton = new System.Windows.Forms.Label();
            this.ModeButton = new System.Windows.Forms.Label();
            this.StartStopButton = new System.Windows.Forms.Label();
            this.displayTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // display
            // 
            this.display.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(226)))), ((int)(((byte)(164)))));
            this.display.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.display.Location = new System.Drawing.Point(91, 159);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(114, 40);
            this.display.TabIndex = 4;
            this.display.Paint += new System.Windows.Forms.PaintEventHandler(this.display_Paint);
            // 
            // ResetLapButton
            // 
            this.ResetLapButton.BackColor = System.Drawing.Color.Transparent;
            this.ResetLapButton.Location = new System.Drawing.Point(2, 2);
            this.ResetLapButton.Name = "ResetLapButton";
            this.ResetLapButton.Size = new System.Drawing.Size(71, 83);
            this.ResetLapButton.TabIndex = 5;
            this.ResetLapButton.Click += new System.EventHandler(this.ResetLapButton_Click);
            // 
            // ModeButton
            // 
            this.ModeButton.BackColor = System.Drawing.Color.Transparent;
            this.ModeButton.Location = new System.Drawing.Point(79, 2);
            this.ModeButton.Name = "ModeButton";
            this.ModeButton.Size = new System.Drawing.Size(130, 83);
            this.ModeButton.TabIndex = 6;
            this.ModeButton.Click += new System.EventHandler(this.ModeButton_Click);
            // 
            // StartStopButton
            // 
            this.StartStopButton.BackColor = System.Drawing.Color.Transparent;
            this.StartStopButton.Location = new System.Drawing.Point(215, 2);
            this.StartStopButton.Name = "StartStopButton";
            this.StartStopButton.Size = new System.Drawing.Size(76, 83);
            this.StartStopButton.TabIndex = 7;
            this.StartStopButton.Click += new System.EventHandler(this.StartStopButton_Click);
            // 
            // displayTimer
            // 
            this.displayTimer.Enabled = true;
            this.displayTimer.Interval = 1;
            this.displayTimer.Tick += new System.EventHandler(this.displayTimer_Tick);
            // 
            // stopwatchUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::stopwatchImp.Properties.Resources.stopwatch;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(293, 306);
            this.Controls.Add(this.StartStopButton);
            this.Controls.Add(this.ModeButton);
            this.Controls.Add(this.ResetLapButton);
            this.Controls.Add(this.display);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "stopwatchUI";
            this.Text = "Stopwatch";
            this.Load += new System.EventHandler(this.stopwatchUI_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private StopwatchDisplay display;
        private System.Windows.Forms.Label ResetLapButton;
        private System.Windows.Forms.Label ModeButton;
        private System.Windows.Forms.Label StartStopButton;
        private System.Windows.Forms.Timer displayTimer;

    }
}

