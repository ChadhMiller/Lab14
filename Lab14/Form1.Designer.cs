namespace Lab14
{
    partial class Lab14
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.grpStartingInfo = new System.Windows.Forms.GroupBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.numTimerTime = new System.Windows.Forms.NumericUpDown();
            this.grpCounting = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pnlWinner = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.labelrst = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpStartingInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTimerTime)).BeginInit();
            this.grpCounting.SuspendLayout();
            this.pnlWinner.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Start Info";
            // 
            // grpStartingInfo
            // 
            this.grpStartingInfo.Controls.Add(this.btnStart);
            this.grpStartingInfo.Controls.Add(this.numTimerTime);
            this.grpStartingInfo.Controls.Add(this.label1);
            this.grpStartingInfo.Location = new System.Drawing.Point(324, 235);
            this.grpStartingInfo.Name = "grpStartingInfo";
            this.grpStartingInfo.Size = new System.Drawing.Size(170, 122);
            this.grpStartingInfo.TabIndex = 2;
            this.grpStartingInfo.TabStop = false;
            this.grpStartingInfo.Text = "StartInfo";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(24, 62);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(120, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start Timing";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // numTimerTime
            // 
            this.numTimerTime.AccessibleName = "";
            this.numTimerTime.Location = new System.Drawing.Point(24, 33);
            this.numTimerTime.Name = "numTimerTime";
            this.numTimerTime.Size = new System.Drawing.Size(120, 23);
            this.numTimerTime.TabIndex = 2;
            // 
            // grpCounting
            // 
            this.grpCounting.Controls.Add(this.button2);
            this.grpCounting.Controls.Add(this.progressBar1);
            this.grpCounting.Location = new System.Drawing.Point(85, 26);
            this.grpCounting.Name = "grpCounting";
            this.grpCounting.Size = new System.Drawing.Size(637, 147);
            this.grpCounting.TabIndex = 3;
            this.grpCounting.TabStop = false;
            this.grpCounting.Text = "Counting...";
            this.grpCounting.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(290, 100);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(18, 23);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(598, 55);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 0;
            // 
            // pnlWinner
            // 
            this.pnlWinner.Controls.Add(this.button1);
            this.pnlWinner.Controls.Add(this.labelrst);
            this.pnlWinner.Controls.Add(this.label2);
            this.pnlWinner.Location = new System.Drawing.Point(49, 203);
            this.pnlWinner.Name = "pnlWinner";
            this.pnlWinner.Size = new System.Drawing.Size(263, 184);
            this.pnlWinner.TabIndex = 4;
            this.pnlWinner.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(73, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Play Again";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelrst
            // 
            this.labelrst.AutoSize = true;
            this.labelrst.Location = new System.Drawing.Point(56, 42);
            this.labelrst.Name = "labelrst";
            this.labelrst.Size = new System.Drawing.Size(92, 15);
            this.labelrst.TabIndex = 1;
            this.labelrst.Text = "[results go here]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(85, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "You Win";
            // 
            // Lab14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlWinner);
            this.Controls.Add(this.grpCounting);
            this.Controls.Add(this.grpStartingInfo);
            this.Name = "Lab14";
            this.Text = "Lab14";
            this.grpStartingInfo.ResumeLayout(false);
            this.grpStartingInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTimerTime)).EndInit();
            this.grpCounting.ResumeLayout(false);
            this.pnlWinner.ResumeLayout(false);
            this.pnlWinner.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private GroupBox grpStartingInfo;
        private Button btnStart;
        private NumericUpDown numTimerTime;
        private GroupBox grpCounting;
        private Button button2;
        private ProgressBar progressBar1;
        private Panel pnlWinner;
        private Button button1;
        private Label labelrst;
        private Label label2;
    }
}