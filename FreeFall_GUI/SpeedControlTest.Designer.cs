namespace FreeFall_GUI
{
    partial class SpeedControlTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpeedControlTest));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbParams = new System.Windows.Forms.GroupBox();
            this.btnSetDecelTime = new System.Windows.Forms.Button();
            this.btnSetAccelTime = new System.Windows.Forms.Button();
            this.btnSetMaxSpeed = new System.Windows.Forms.Button();
            this.txtDecelTime = new System.Windows.Forms.TextBox();
            this.txtAccelTime = new System.Windows.Forms.TextBox();
            this.txtMaxSpd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnStart = new FreeFall_GUI.ButtonEllipse();
            this.btnStop = new FreeFall_GUI.ButtonEllipse();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHoldOnTime = new System.Windows.Forms.TextBox();
            this.btnHoldOnTime = new System.Windows.Forms.Button();
            this.gbParams.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(56, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(549, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "Speed Control Mode\r\nRequire to use the Speed Mode of the Driver";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Max Speed (rpm)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbParams
            // 
            this.gbParams.Controls.Add(this.btnHoldOnTime);
            this.gbParams.Controls.Add(this.txtHoldOnTime);
            this.gbParams.Controls.Add(this.label5);
            this.gbParams.Controls.Add(this.btnSetDecelTime);
            this.gbParams.Controls.Add(this.btnSetAccelTime);
            this.gbParams.Controls.Add(this.btnSetMaxSpeed);
            this.gbParams.Controls.Add(this.txtDecelTime);
            this.gbParams.Controls.Add(this.txtAccelTime);
            this.gbParams.Controls.Add(this.txtMaxSpd);
            this.gbParams.Controls.Add(this.label4);
            this.gbParams.Controls.Add(this.label3);
            this.gbParams.Controls.Add(this.label2);
            this.gbParams.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gbParams.ForeColor = System.Drawing.Color.Red;
            this.gbParams.Location = new System.Drawing.Point(143, 78);
            this.gbParams.Name = "gbParams";
            this.gbParams.Size = new System.Drawing.Size(392, 285);
            this.gbParams.TabIndex = 2;
            this.gbParams.TabStop = false;
            this.gbParams.Text = "Settings";
            // 
            // btnSetDecelTime
            // 
            this.btnSetDecelTime.ForeColor = System.Drawing.Color.Black;
            this.btnSetDecelTime.Location = new System.Drawing.Point(292, 179);
            this.btnSetDecelTime.Name = "btnSetDecelTime";
            this.btnSetDecelTime.Size = new System.Drawing.Size(87, 37);
            this.btnSetDecelTime.TabIndex = 3;
            this.btnSetDecelTime.Text = "SET";
            this.btnSetDecelTime.UseVisualStyleBackColor = true;
            this.btnSetDecelTime.Click += new System.EventHandler(this.btnSetDecelTime_Click);
            // 
            // btnSetAccelTime
            // 
            this.btnSetAccelTime.ForeColor = System.Drawing.Color.Black;
            this.btnSetAccelTime.Location = new System.Drawing.Point(292, 113);
            this.btnSetAccelTime.Name = "btnSetAccelTime";
            this.btnSetAccelTime.Size = new System.Drawing.Size(87, 37);
            this.btnSetAccelTime.TabIndex = 3;
            this.btnSetAccelTime.Text = "SET";
            this.btnSetAccelTime.UseVisualStyleBackColor = true;
            this.btnSetAccelTime.Click += new System.EventHandler(this.btnSetAccelTime_Click);
            // 
            // btnSetMaxSpeed
            // 
            this.btnSetMaxSpeed.ForeColor = System.Drawing.Color.Black;
            this.btnSetMaxSpeed.Location = new System.Drawing.Point(292, 46);
            this.btnSetMaxSpeed.Name = "btnSetMaxSpeed";
            this.btnSetMaxSpeed.Size = new System.Drawing.Size(87, 37);
            this.btnSetMaxSpeed.TabIndex = 3;
            this.btnSetMaxSpeed.Text = "SET";
            this.btnSetMaxSpeed.UseVisualStyleBackColor = true;
            this.btnSetMaxSpeed.Click += new System.EventHandler(this.btnSetMaxSpeed_Click);
            // 
            // txtDecelTime
            // 
            this.txtDecelTime.Location = new System.Drawing.Point(177, 178);
            this.txtDecelTime.Multiline = true;
            this.txtDecelTime.Name = "txtDecelTime";
            this.txtDecelTime.Size = new System.Drawing.Size(93, 38);
            this.txtDecelTime.TabIndex = 2;
            this.txtDecelTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAccelTime
            // 
            this.txtAccelTime.Location = new System.Drawing.Point(177, 113);
            this.txtAccelTime.Multiline = true;
            this.txtAccelTime.Name = "txtAccelTime";
            this.txtAccelTime.Size = new System.Drawing.Size(93, 38);
            this.txtAccelTime.TabIndex = 2;
            this.txtAccelTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMaxSpd
            // 
            this.txtMaxSpd.Location = new System.Drawing.Point(177, 45);
            this.txtMaxSpd.Multiline = true;
            this.txtMaxSpd.Name = "txtMaxSpd";
            this.txtMaxSpd.Size = new System.Drawing.Size(93, 38);
            this.txtMaxSpd.TabIndex = 2;
            this.txtMaxSpd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(6, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Decel Time (s)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(6, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Accel Time (s)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Lime;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnStart.Location = new System.Drawing.Point(492, 369);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(123, 114);
            this.btnStart.TabIndex = 18;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStop.BackColor = System.Drawing.Color.White;
            this.btnStop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStop.BackgroundImage")));
            this.btnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStop.Font = new System.Drawing.Font("Gulim", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnStop.Location = new System.Drawing.Point(62, 368);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(120, 110);
            this.btnStop.TabIndex = 43;
            this.btnStop.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(6, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Hold On Time (s)";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtHoldOnTime
            // 
            this.txtHoldOnTime.Location = new System.Drawing.Point(177, 241);
            this.txtHoldOnTime.Multiline = true;
            this.txtHoldOnTime.Name = "txtHoldOnTime";
            this.txtHoldOnTime.Size = new System.Drawing.Size(93, 38);
            this.txtHoldOnTime.TabIndex = 5;
            this.txtHoldOnTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnHoldOnTime
            // 
            this.btnHoldOnTime.ForeColor = System.Drawing.Color.Black;
            this.btnHoldOnTime.Location = new System.Drawing.Point(292, 241);
            this.btnHoldOnTime.Name = "btnHoldOnTime";
            this.btnHoldOnTime.Size = new System.Drawing.Size(87, 37);
            this.btnHoldOnTime.TabIndex = 6;
            this.btnHoldOnTime.Text = "SET";
            this.btnHoldOnTime.UseVisualStyleBackColor = true;
            this.btnHoldOnTime.Click += new System.EventHandler(this.btnHoldOnTime_Click);
            // 
            // SpeedControlTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 484);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.gbParams);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SpeedControlTest";
            this.Text = "SpeedControlTest";
            this.Load += new System.EventHandler(this.SpeedControlTest_Load);
            this.gbParams.ResumeLayout(false);
            this.gbParams.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbParams;
        private System.Windows.Forms.Button btnSetMaxSpeed;
        private System.Windows.Forms.TextBox txtAccelTime;
        private System.Windows.Forms.TextBox txtMaxSpd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSetDecelTime;
        private System.Windows.Forms.Button btnSetAccelTime;
        private System.Windows.Forms.TextBox txtDecelTime;
        private System.Windows.Forms.Label label4;
        private ButtonEllipse btnStart;
        private ButtonEllipse btnStop;
        private System.Windows.Forms.Button btnHoldOnTime;
        private System.Windows.Forms.TextBox txtHoldOnTime;
        private System.Windows.Forms.Label label5;
    }
}