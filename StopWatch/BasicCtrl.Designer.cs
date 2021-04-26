namespace StopWatch
{
    partial class StopWatch
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StopWatch));
            this.Display = new System.Windows.Forms.Label();
            this.Start_Stop = new System.Windows.Forms.Button();
            this.Lap_Reset = new System.Windows.Forms.Button();
            this.LapTimeList = new System.Windows.Forms.ComboBox();
            this.Alarm = new System.Windows.Forms.Label();
            this.FinMinute = new System.Windows.Forms.NumericUpDown();
            this.FinMinLabel = new System.Windows.Forms.Label();
            this.StartMinTime = new System.Windows.Forms.NumericUpDown();
            this.StartSecTime = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.StartMin = new System.Windows.Forms.Label();
            this.StartSec = new System.Windows.Forms.Label();
            this.StartTimeReset = new System.Windows.Forms.Button();
            this.FinSecond = new System.Windows.Forms.NumericUpDown();
            this.FinsecLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FinMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartMinTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartSecTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FinSecond)).BeginInit();
            this.SuspendLayout();
            // 
            // Display
            // 
            this.Display.AutoSize = true;
            this.Display.Font = new System.Drawing.Font("MS UI Gothic", 64F);
            this.Display.ForeColor = System.Drawing.Color.DarkOrange;
            this.Display.Location = new System.Drawing.Point(3, 35);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(372, 86);
            this.Display.TabIndex = 0;
            this.Display.Text = "00:00.000";
            // 
            // Start_Stop
            // 
            this.Start_Stop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.Start_Stop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Start_Stop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Start_Stop.Font = new System.Drawing.Font("游明朝 Demibold", 13F, System.Drawing.FontStyle.Bold);
            this.Start_Stop.Location = new System.Drawing.Point(28, 160);
            this.Start_Stop.Name = "Start_Stop";
            this.Start_Stop.Size = new System.Drawing.Size(96, 37);
            this.Start_Stop.TabIndex = 1;
            this.Start_Stop.Text = "Start";
            this.Start_Stop.UseVisualStyleBackColor = false;
            this.Start_Stop.Click += new System.EventHandler(this.Start_Stop_Click);
            // 
            // Lap_Reset
            // 
            this.Lap_Reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Lap_Reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Lap_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Lap_Reset.Font = new System.Drawing.Font("游明朝 Demibold", 13F, System.Drawing.FontStyle.Bold);
            this.Lap_Reset.Location = new System.Drawing.Point(143, 160);
            this.Lap_Reset.Name = "Lap_Reset";
            this.Lap_Reset.Size = new System.Drawing.Size(96, 37);
            this.Lap_Reset.TabIndex = 2;
            this.Lap_Reset.Text = "Lap";
            this.Lap_Reset.UseVisualStyleBackColor = false;
            this.Lap_Reset.Click += new System.EventHandler(this.Lap_Reset_Click);
            // 
            // LapTimeList
            // 
            this.LapTimeList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LapTimeList.Font = new System.Drawing.Font("HGS創英角ｺﾞｼｯｸUB", 10F);
            this.LapTimeList.FormattingEnabled = true;
            this.LapTimeList.Location = new System.Drawing.Point(260, 170);
            this.LapTimeList.Name = "LapTimeList";
            this.LapTimeList.Size = new System.Drawing.Size(86, 21);
            this.LapTimeList.TabIndex = 4;
            // 
            // Alarm
            // 
            this.Alarm.AutoSize = true;
            this.Alarm.Font = new System.Drawing.Font("游明朝 Demibold", 12F, System.Drawing.FontStyle.Bold);
            this.Alarm.ForeColor = System.Drawing.Color.OrangeRed;
            this.Alarm.Location = new System.Drawing.Point(50, 12);
            this.Alarm.Name = "Alarm";
            this.Alarm.Size = new System.Drawing.Size(53, 21);
            this.Alarm.TabIndex = 7;
            this.Alarm.Text = "Alarm";
            // 
            // FinMinute
            // 
            this.FinMinute.Font = new System.Drawing.Font("HGS創英角ｺﾞｼｯｸUB", 10F);
            this.FinMinute.ForeColor = System.Drawing.Color.Tomato;
            this.FinMinute.Location = new System.Drawing.Point(102, 13);
            this.FinMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.FinMinute.Name = "FinMinute";
            this.FinMinute.Size = new System.Drawing.Size(38, 21);
            this.FinMinute.TabIndex = 9;
            // 
            // FinMinLabel
            // 
            this.FinMinLabel.AutoSize = true;
            this.FinMinLabel.Font = new System.Drawing.Font("游明朝 Demibold", 10F, System.Drawing.FontStyle.Bold);
            this.FinMinLabel.ForeColor = System.Drawing.Color.Tomato;
            this.FinMinLabel.Location = new System.Drawing.Point(140, 14);
            this.FinMinLabel.Name = "FinMinLabel";
            this.FinMinLabel.Size = new System.Drawing.Size(36, 18);
            this.FinMinLabel.TabIndex = 11;
            this.FinMinLabel.Text = "min.";
            // 
            // StartMinTime
            // 
            this.StartMinTime.Font = new System.Drawing.Font("HGS創英角ｺﾞｼｯｸUB", 10F);
            this.StartMinTime.ForeColor = System.Drawing.Color.Blue;
            this.StartMinTime.Location = new System.Drawing.Point(92, 126);
            this.StartMinTime.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.StartMinTime.Name = "StartMinTime";
            this.StartMinTime.Size = new System.Drawing.Size(38, 21);
            this.StartMinTime.TabIndex = 13;
            // 
            // StartSecTime
            // 
            this.StartSecTime.Font = new System.Drawing.Font("HGS創英角ｺﾞｼｯｸUB", 10F);
            this.StartSecTime.ForeColor = System.Drawing.Color.Blue;
            this.StartSecTime.Location = new System.Drawing.Point(166, 126);
            this.StartSecTime.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.StartSecTime.Name = "StartSecTime";
            this.StartSecTime.Size = new System.Drawing.Size(38, 21);
            this.StartSecTime.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("游明朝 Demibold", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(7, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 21);
            this.label1.TabIndex = 15;
            this.label1.Text = "Start from";
            // 
            // StartMin
            // 
            this.StartMin.AutoSize = true;
            this.StartMin.Font = new System.Drawing.Font("游明朝 Demibold", 10F, System.Drawing.FontStyle.Bold);
            this.StartMin.ForeColor = System.Drawing.Color.Magenta;
            this.StartMin.Location = new System.Drawing.Point(130, 127);
            this.StartMin.Name = "StartMin";
            this.StartMin.Size = new System.Drawing.Size(36, 18);
            this.StartMin.TabIndex = 11;
            this.StartMin.Text = "min.";
            // 
            // StartSec
            // 
            this.StartSec.AutoSize = true;
            this.StartSec.Font = new System.Drawing.Font("游明朝 Demibold", 10F, System.Drawing.FontStyle.Bold);
            this.StartSec.ForeColor = System.Drawing.Color.Magenta;
            this.StartSec.Location = new System.Drawing.Point(204, 127);
            this.StartSec.Name = "StartSec";
            this.StartSec.Size = new System.Drawing.Size(31, 18);
            this.StartSec.TabIndex = 11;
            this.StartSec.Text = "sec.";
            // 
            // StartTimeReset
            // 
            this.StartTimeReset.BackColor = System.Drawing.Color.Bisque;
            this.StartTimeReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartTimeReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StartTimeReset.Font = new System.Drawing.Font("游明朝 Demibold", 10F, System.Drawing.FontStyle.Bold);
            this.StartTimeReset.ForeColor = System.Drawing.Color.Magenta;
            this.StartTimeReset.Location = new System.Drawing.Point(243, 124);
            this.StartTimeReset.Name = "StartTimeReset";
            this.StartTimeReset.Size = new System.Drawing.Size(114, 25);
            this.StartTimeReset.TabIndex = 16;
            this.StartTimeReset.Text = "StartTimeReset";
            this.StartTimeReset.UseVisualStyleBackColor = false;
            this.StartTimeReset.Click += new System.EventHandler(this.StartTimeReset_Click);
            // 
            // FinSecond
            // 
            this.FinSecond.Font = new System.Drawing.Font("HGS創英角ｺﾞｼｯｸUB", 10F);
            this.FinSecond.ForeColor = System.Drawing.Color.Tomato;
            this.FinSecond.Location = new System.Drawing.Point(177, 13);
            this.FinSecond.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.FinSecond.Name = "FinSecond";
            this.FinSecond.Size = new System.Drawing.Size(38, 21);
            this.FinSecond.TabIndex = 17;
            // 
            // FinsecLabel
            // 
            this.FinsecLabel.AutoSize = true;
            this.FinsecLabel.Font = new System.Drawing.Font("游明朝 Demibold", 10F, System.Drawing.FontStyle.Bold);
            this.FinsecLabel.ForeColor = System.Drawing.Color.Tomato;
            this.FinsecLabel.Location = new System.Drawing.Point(215, 14);
            this.FinsecLabel.Name = "FinsecLabel";
            this.FinsecLabel.Size = new System.Drawing.Size(31, 18);
            this.FinsecLabel.TabIndex = 11;
            this.FinsecLabel.Text = "sec.";
            // 
            // StopWatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(370, 218);
            this.Controls.Add(this.FinSecond);
            this.Controls.Add(this.StartTimeReset);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StartSecTime);
            this.Controls.Add(this.StartMinTime);
            this.Controls.Add(this.StartSec);
            this.Controls.Add(this.StartMin);
            this.Controls.Add(this.FinsecLabel);
            this.Controls.Add(this.FinMinLabel);
            this.Controls.Add(this.FinMinute);
            this.Controls.Add(this.Alarm);
            this.Controls.Add(this.LapTimeList);
            this.Controls.Add(this.Lap_Reset);
            this.Controls.Add(this.Start_Stop);
            this.Controls.Add(this.Display);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "StopWatch";
            this.Text = "StopWatch";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.StopWatch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FinMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartMinTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartSecTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FinSecond)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Display;
        private System.Windows.Forms.Button Start_Stop;
        private System.Windows.Forms.Button Lap_Reset;
        private System.Windows.Forms.ComboBox LapTimeList;
        private System.Windows.Forms.Label Alarm;
        private System.Windows.Forms.NumericUpDown FinMinute;
        private System.Windows.Forms.Label FinMinLabel;
        private System.Windows.Forms.NumericUpDown StartMinTime;
        private System.Windows.Forms.NumericUpDown StartSecTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label StartMin;
        private System.Windows.Forms.Label StartSec;
        private System.Windows.Forms.Button StartTimeReset;
        private System.Windows.Forms.NumericUpDown FinSecond;
        private System.Windows.Forms.Label FinsecLabel;
    }
}

