namespace FreeFall_GUI
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTestCOM = new System.Windows.Forms.Button();
            this.lb_com_status = new System.Windows.Forms.Label();
            this.btn_com_disconnect = new System.Windows.Forms.Button();
            this.btn_com_connect = new System.Windows.Forms.Button();
            this.btn_com_refresh = new System.Windows.Forms.Button();
            this.btn_com_config = new System.Windows.Forms.Button();
            this.cb_com_comport = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gb_System_Check = new System.Windows.Forms.GroupBox();
            this.btn_Setting = new System.Windows.Forms.Button();
            this.btnMainControl = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnConsole = new System.Windows.Forms.Button();
            this.btnHideConsole = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gb_System_Check.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTestCOM);
            this.groupBox1.Controls.Add(this.lb_com_status);
            this.groupBox1.Controls.Add(this.btn_com_disconnect);
            this.groupBox1.Controls.Add(this.btn_com_connect);
            this.groupBox1.Controls.Add(this.btn_com_refresh);
            this.groupBox1.Controls.Add(this.btn_com_config);
            this.groupBox1.Controls.Add(this.cb_com_comport);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(34, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 154);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COM set up";
            // 
            // btnTestCOM
            // 
            this.btnTestCOM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnTestCOM.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestCOM.Location = new System.Drawing.Point(6, 59);
            this.btnTestCOM.Name = "btnTestCOM";
            this.btnTestCOM.Size = new System.Drawing.Size(88, 29);
            this.btnTestCOM.TabIndex = 6;
            this.btnTestCOM.Text = "Test";
            this.btnTestCOM.UseVisualStyleBackColor = false;
            this.btnTestCOM.Click += new System.EventHandler(this.btnTestCOM_Click);
            // 
            // lb_com_status
            // 
            this.lb_com_status.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_com_status.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_com_status.Location = new System.Drawing.Point(6, 101);
            this.lb_com_status.Name = "lb_com_status";
            this.lb_com_status.Size = new System.Drawing.Size(335, 34);
            this.lb_com_status.TabIndex = 1;
            this.lb_com_status.Text = "status";
            this.lb_com_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_com_disconnect
            // 
            this.btn_com_disconnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_com_disconnect.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_com_disconnect.Location = new System.Drawing.Point(227, 62);
            this.btn_com_disconnect.Name = "btn_com_disconnect";
            this.btn_com_disconnect.Size = new System.Drawing.Size(114, 29);
            this.btn_com_disconnect.TabIndex = 5;
            this.btn_com_disconnect.Text = "Disconnect";
            this.btn_com_disconnect.UseVisualStyleBackColor = false;
            this.btn_com_disconnect.Click += new System.EventHandler(this.btn_com_disconnect_Click);
            // 
            // btn_com_connect
            // 
            this.btn_com_connect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_com_connect.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_com_connect.Location = new System.Drawing.Point(133, 62);
            this.btn_com_connect.Name = "btn_com_connect";
            this.btn_com_connect.Size = new System.Drawing.Size(88, 29);
            this.btn_com_connect.TabIndex = 4;
            this.btn_com_connect.Text = "Connect";
            this.btn_com_connect.UseVisualStyleBackColor = false;
            this.btn_com_connect.Click += new System.EventHandler(this.btn_connect);
            // 
            // btn_com_refresh
            // 
            this.btn_com_refresh.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_com_refresh.Location = new System.Drawing.Point(133, 27);
            this.btn_com_refresh.Name = "btn_com_refresh";
            this.btn_com_refresh.Size = new System.Drawing.Size(88, 29);
            this.btn_com_refresh.TabIndex = 3;
            this.btn_com_refresh.Text = "Reresh";
            this.btn_com_refresh.UseVisualStyleBackColor = true;
            this.btn_com_refresh.Click += new System.EventHandler(this.btn_com_refresh_Click);
            // 
            // btn_com_config
            // 
            this.btn_com_config.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_com_config.Location = new System.Drawing.Point(241, 27);
            this.btn_com_config.Name = "btn_com_config";
            this.btn_com_config.Size = new System.Drawing.Size(88, 29);
            this.btn_com_config.TabIndex = 2;
            this.btn_com_config.Text = "Config";
            this.btn_com_config.UseVisualStyleBackColor = true;
            this.btn_com_config.Click += new System.EventHandler(this.btn_com_config_Click);
            // 
            // cb_com_comport
            // 
            this.cb_com_comport.FormattingEnabled = true;
            this.cb_com_comport.Location = new System.Drawing.Point(6, 27);
            this.cb_com_comport.Name = "cb_com_comport";
            this.cb_com_comport.Size = new System.Drawing.Size(121, 29);
            this.cb_com_comport.TabIndex = 1;
            this.cb_com_comport.SelectedIndexChanged += new System.EventHandler(this.cb_com_comport_SelectedIndexChanged);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gulim", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(174, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Step 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gulim", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(496, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Step 2";
            // 
            // gb_System_Check
            // 
            this.gb_System_Check.Controls.Add(this.btn_Setting);
            this.gb_System_Check.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_System_Check.Location = new System.Drawing.Point(409, 50);
            this.gb_System_Check.Name = "gb_System_Check";
            this.gb_System_Check.Size = new System.Drawing.Size(267, 154);
            this.gb_System_Check.TabIndex = 6;
            this.gb_System_Check.TabStop = false;
            this.gb_System_Check.Text = "Parameter Settings";
            // 
            // btn_Setting
            // 
            this.btn_Setting.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Setting.Location = new System.Drawing.Point(61, 51);
            this.btn_Setting.Name = "btn_Setting";
            this.btn_Setting.Size = new System.Drawing.Size(158, 61);
            this.btn_Setting.TabIndex = 3;
            this.btn_Setting.Text = "Go to Setting";
            this.btn_Setting.UseVisualStyleBackColor = true;
            this.btn_Setting.Click += new System.EventHandler(this.btn_check_start_Click);
            // 
            // btnMainControl
            // 
            this.btnMainControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnMainControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnMainControl.Location = new System.Drawing.Point(722, 90);
            this.btnMainControl.Name = "btnMainControl";
            this.btnMainControl.Size = new System.Drawing.Size(156, 83);
            this.btnMainControl.TabIndex = 7;
            this.btnMainControl.Text = "Main Control";
            this.btnMainControl.UseVisualStyleBackColor = false;
            this.btnMainControl.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gulim", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(763, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Step 3";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(261, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(367, 63);
            this.label4.TabIndex = 9;
            this.label4.Text = "Liintech Corp";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConsole
            // 
            this.btnConsole.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsole.Location = new System.Drawing.Point(34, 210);
            this.btnConsole.Name = "btnConsole";
            this.btnConsole.Size = new System.Drawing.Size(136, 43);
            this.btnConsole.TabIndex = 4;
            this.btnConsole.Text = "Open Console";
            this.btnConsole.UseVisualStyleBackColor = true;
            this.btnConsole.Click += new System.EventHandler(this.btnConsole_Click);
            // 
            // btnHideConsole
            // 
            this.btnHideConsole.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHideConsole.Location = new System.Drawing.Point(178, 210);
            this.btnHideConsole.Name = "btnHideConsole";
            this.btnHideConsole.Size = new System.Drawing.Size(136, 43);
            this.btnHideConsole.TabIndex = 10;
            this.btnHideConsole.Text = "Hide Console";
            this.btnHideConsole.UseVisualStyleBackColor = true;
            this.btnHideConsole.Click += new System.EventHandler(this.btnHideConsole_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 307);
            this.Controls.Add(this.btnHideConsole);
            this.Controls.Add(this.btnConsole);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnMainControl);
            this.Controls.Add(this.gb_System_Check);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "FreeFall_GUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.gb_System_Check.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_com_status;
        private System.Windows.Forms.Button btn_com_disconnect;
        private System.Windows.Forms.Button btn_com_connect;
        private System.Windows.Forms.Button btn_com_refresh;
        private System.Windows.Forms.Button btn_com_config;
        private System.Windows.Forms.ComboBox cb_com_comport;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gb_System_Check;
        private System.Windows.Forms.Button btn_Setting;
        private System.Windows.Forms.Button btnTestCOM;
        private System.Windows.Forms.Button btnMainControl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnConsole;
        private System.Windows.Forms.Button btnHideConsole;
    }
}

