namespace NguyenTaDinhDuy_2122110456
{
    partial class Timer
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
            this.tmStopwatch = new System.Windows.Forms.Timer(this.components);
            this.lbDisplay = new System.Windows.Forms.Label();
            this.btStart = new System.Windows.Forms.Button();
            this.btStop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tmStopwatch
            // 
            this.tmStopwatch.Enabled = true;
            // 
            // lbDisplay
            // 
            this.lbDisplay.AutoSize = true;
            this.lbDisplay.Location = new System.Drawing.Point(466, 156);
            this.lbDisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDisplay.Name = "lbDisplay";
            this.lbDisplay.Size = new System.Drawing.Size(49, 20);
            this.lbDisplay.TabIndex = 0;
            this.lbDisplay.Text = "00:00";
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(381, 203);
            this.btStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(112, 35);
            this.btStart.TabIndex = 1;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // btStop
            // 
            this.btStop.Location = new System.Drawing.Point(502, 203);
            this.btStop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(112, 35);
            this.btStop.TabIndex = 2;
            this.btStop.Text = "Stop";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // Timer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btStop);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.lbDisplay);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Timer";
            this.Text = "Timer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmStopwatch;
        private System.Windows.Forms.Label lbDisplay;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Button btStop;
    }
}