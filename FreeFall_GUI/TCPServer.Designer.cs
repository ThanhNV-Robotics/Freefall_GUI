namespace FreeFall_GUI
{
    partial class TCPServer
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lbStatus = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.togServerOnOff = new FreeFall_GUI.RJControls.RJToggleButton();
            this.lbPort = new System.Windows.Forms.Label();
            this.lbServerIP = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.OldLace;
            this.groupBox5.Controls.Add(this.lbStatus);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.togServerOnOff);
            this.groupBox5.Controls.Add(this.lbPort);
            this.groupBox5.Controls.Add(this.lbServerIP);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Font = new System.Drawing.Font("Gulim", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox5.ForeColor = System.Drawing.Color.Red;
            this.groupBox5.Location = new System.Drawing.Point(12, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(402, 184);
            this.groupBox5.TabIndex = 33;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "TCP Server Communication";
            // 
            // lbStatus
            // 
            this.lbStatus.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbStatus.ForeColor = System.Drawing.Color.Black;
            this.lbStatus.Location = new System.Drawing.Point(10, 130);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(373, 51);
            this.lbStatus.TabIndex = 36;
            this.lbStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gulim", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(111, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 25);
            this.label4.TabIndex = 35;
            this.label4.Text = "Server ON/OFF";
            // 
            // togServerOnOff
            // 
            this.togServerOnOff.Location = new System.Drawing.Point(10, 75);
            this.togServerOnOff.MinimumSize = new System.Drawing.Size(45, 22);
            this.togServerOnOff.Name = "togServerOnOff";
            this.togServerOnOff.OffBackColor = System.Drawing.Color.Gray;
            this.togServerOnOff.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.togServerOnOff.OnBackColor = System.Drawing.Color.Lime;
            this.togServerOnOff.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.togServerOnOff.Size = new System.Drawing.Size(95, 44);
            this.togServerOnOff.TabIndex = 34;
            this.togServerOnOff.UseVisualStyleBackColor = true;
            // 
            // lbPort
            // 
            this.lbPort.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbPort.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbPort.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbPort.Location = new System.Drawing.Point(285, 32);
            this.lbPort.Name = "lbPort";
            this.lbPort.Size = new System.Drawing.Size(111, 34);
            this.lbPort.TabIndex = 33;
            this.lbPort.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbServerIP
            // 
            this.lbServerIP.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbServerIP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbServerIP.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbServerIP.ForeColor = System.Drawing.Color.Black;
            this.lbServerIP.Location = new System.Drawing.Point(38, 32);
            this.lbServerIP.Name = "lbServerIP";
            this.lbServerIP.Size = new System.Drawing.Size(175, 32);
            this.lbServerIP.TabIndex = 32;
            this.lbServerIP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(232, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 20);
            this.label10.TabIndex = 30;
            this.label10.Text = "Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "IP";
            // 
            // TCPServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 204);
            this.Controls.Add(this.groupBox5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TCPServer";
            this.RightToLeftLayout = true;
            this.Text = "TCPServer";
            this.Load += new System.EventHandler(this.TCPServer_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label label4;
        private RJControls.RJToggleButton togServerOnOff;
        private System.Windows.Forms.Label lbPort;
        private System.Windows.Forms.Label lbServerIP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
    }
}