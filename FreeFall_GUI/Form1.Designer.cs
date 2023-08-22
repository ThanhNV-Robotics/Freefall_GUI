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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOMPortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tCPServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.selectFolderToSaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openAFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parameterSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.driverInputControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speedControlTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gyroAndDisGraphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbReadOutputs = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelCcwTorqueLim = new System.Windows.Forms.Label();
            this.labelAlarm = new System.Windows.Forms.Label();
            this.labelTorqueLimit = new System.Windows.Forms.Label();
            this.lbZeroSpeedReach = new FreeFall_GUI.Elip_Label();
            this.lbCwTorqueLimit = new FreeFall_GUI.Elip_Label();
            this.lbCcwTorqueLimit = new FreeFall_GUI.Elip_Label();
            this.lbAlarm = new FreeFall_GUI.Elip_Label();
            this.lbTorqueLimit = new FreeFall_GUI.Elip_Label();
            this.lbSpeedReach = new FreeFall_GUI.Elip_Label();
            this.lbReady = new FreeFall_GUI.Elip_Label();
            this.lbBrake = new FreeFall_GUI.Elip_Label();
            this.lb_Type = new FreeFall_GUI.Elip_Label();
            this.lbReach = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbJogControl = new System.Windows.Forms.GroupBox();
            this.btnSetJogSpeed = new System.Windows.Forms.Button();
            this.txtSetSpeed = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSimulate = new System.Windows.Forms.Button();
            this.btnHoming = new System.Windows.Forms.Button();
            this.lbMotorSpeed = new System.Windows.Forms.Label();
            this.btnResetAlarm = new System.Windows.Forms.Button();
            this.lbServoEnable = new System.Windows.Forms.Label();
            this.btnStartDropping = new System.Windows.Forms.Button();
            this.SpeedGraph = new ZedGraph.ZedGraphControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toggleServoEnable = new FreeFall_GUI.RJControls.RJToggleButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbAccZ = new System.Windows.Forms.Label();
            this.tongleDataOnOff = new FreeFall_GUI.RJControls.RJToggleButton();
            this.tongleSoftLimit = new FreeFall_GUI.RJControls.RJToggleButton();
            this.btnSetHome = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbObjectPosition = new System.Windows.Forms.Label();
            this.listData = new System.Windows.Forms.ListView();
            this.Time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Speed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RefSpeed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AccelX = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AccelY = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AccelZ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AccZRef = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Position = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listLocalTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.gbDataView = new System.Windows.Forms.GroupBox();
            this.cbAccRef = new System.Windows.Forms.CheckBox();
            this.cbAccZ = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnResetGraph = new System.Windows.Forms.Button();
            this.btnScroll = new System.Windows.Forms.Button();
            this.cbSpeed = new System.Windows.Forms.CheckBox();
            this.cbSpdCmd = new System.Windows.Forms.CheckBox();
            this.btnGraphOn = new System.Windows.Forms.Button();
            this.lb_com_status = new System.Windows.Forms.Label();
            this.btnRstMcu = new System.Windows.Forms.Button();
            this.cbExperimentMode = new System.Windows.Forms.ComboBox();
            this.cbDriverType = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lbPort = new System.Windows.Forms.Label();
            this.togServerOnOff = new FreeFall_GUI.RJControls.RJToggleButton();
            this.lbServerIP = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label15 = new System.Windows.Forms.Label();
            this.lbTemp = new System.Windows.Forms.Label();
            this.lbStartRecording = new FreeFall_GUI.Elip_Label();
            this.btnStop = new FreeFall_GUI.ButtonEllipse();
            this.btnEstop = new FreeFall_GUI.ButtonEllipse();
            this.btnMoveDown = new System.Windows.Forms.Button();
            this.btnMoveUp = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbJogControl.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gbDataView.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.fileToolStripMenuItem1,
            this.aboutToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1638, 28);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cOMPortToolStripMenuItem,
            this.tCPServerToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.fileToolStripMenuItem.Text = "Connection";
            // 
            // cOMPortToolStripMenuItem
            // 
            this.cOMPortToolStripMenuItem.Name = "cOMPortToolStripMenuItem";
            this.cOMPortToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.cOMPortToolStripMenuItem.Text = "COM Port";
            this.cOMPortToolStripMenuItem.Click += new System.EventHandler(this.cOMPortToolStripMenuItem_Click);
            // 
            // tCPServerToolStripMenuItem
            // 
            this.tCPServerToolStripMenuItem.Name = "tCPServerToolStripMenuItem";
            this.tCPServerToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.tCPServerToolStripMenuItem.Text = "TCP Server";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectFolderToSaveToolStripMenuItem,
            this.openAFileToolStripMenuItem});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem1.Text = "File";
            // 
            // selectFolderToSaveToolStripMenuItem
            // 
            this.selectFolderToSaveToolStripMenuItem.Name = "selectFolderToSaveToolStripMenuItem";
            this.selectFolderToSaveToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.selectFolderToSaveToolStripMenuItem.Text = "Select folder to save";
            // 
            // openAFileToolStripMenuItem
            // 
            this.openAFileToolStripMenuItem.Name = "openAFileToolStripMenuItem";
            this.openAFileToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.openAFileToolStripMenuItem.Text = "Open a File";
            this.openAFileToolStripMenuItem.Click += new System.EventHandler(this.openAFileToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parameterSettingToolStripMenuItem,
            this.driverInputControlToolStripMenuItem,
            this.speedControlTestToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.aboutToolStripMenuItem.Text = "Tool";
            // 
            // parameterSettingToolStripMenuItem
            // 
            this.parameterSettingToolStripMenuItem.Name = "parameterSettingToolStripMenuItem";
            this.parameterSettingToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.parameterSettingToolStripMenuItem.Text = "Parameter Setting";
            this.parameterSettingToolStripMenuItem.Click += new System.EventHandler(this.parameterSettingToolStripMenuItem_Click);
            // 
            // driverInputControlToolStripMenuItem
            // 
            this.driverInputControlToolStripMenuItem.Name = "driverInputControlToolStripMenuItem";
            this.driverInputControlToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.driverInputControlToolStripMenuItem.Text = "Driver Input Control";
            this.driverInputControlToolStripMenuItem.Click += new System.EventHandler(this.driverInputControlToolStripMenuItem_Click);
            // 
            // speedControlTestToolStripMenuItem
            // 
            this.speedControlTestToolStripMenuItem.Name = "speedControlTestToolStripMenuItem";
            this.speedControlTestToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.speedControlTestToolStripMenuItem.Text = "Speed Control Test";
            this.speedControlTestToolStripMenuItem.Click += new System.EventHandler(this.speedControlTestToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gyroAndDisGraphToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "View";
            // 
            // gyroAndDisGraphToolStripMenuItem
            // 
            this.gyroAndDisGraphToolStripMenuItem.Name = "gyroAndDisGraphToolStripMenuItem";
            this.gyroAndDisGraphToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.gyroAndDisGraphToolStripMenuItem.Text = "Gyro and Dis Graph";
            this.gyroAndDisGraphToolStripMenuItem.Click += new System.EventHandler(this.gyroAndDisGraphToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.BackColor = System.Drawing.Color.LemonChiffon;
            this.groupBox2.Controls.Add(this.cbReadOutputs);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.labelCcwTorqueLim);
            this.groupBox2.Controls.Add(this.labelAlarm);
            this.groupBox2.Controls.Add(this.labelTorqueLimit);
            this.groupBox2.Controls.Add(this.lbZeroSpeedReach);
            this.groupBox2.Controls.Add(this.lbCwTorqueLimit);
            this.groupBox2.Controls.Add(this.lbCcwTorqueLimit);
            this.groupBox2.Controls.Add(this.lbAlarm);
            this.groupBox2.Controls.Add(this.lbTorqueLimit);
            this.groupBox2.Controls.Add(this.lbSpeedReach);
            this.groupBox2.Controls.Add(this.lbReady);
            this.groupBox2.Controls.Add(this.lbBrake);
            this.groupBox2.Controls.Add(this.lb_Type);
            this.groupBox2.Controls.Add(this.lbReach);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(12, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(331, 453);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Driver State";
            // 
            // cbReadOutputs
            // 
            this.cbReadOutputs.AutoSize = true;
            this.cbReadOutputs.Checked = true;
            this.cbReadOutputs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbReadOutputs.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbReadOutputs.Location = new System.Drawing.Point(164, 39);
            this.cbReadOutputs.Name = "cbReadOutputs";
            this.cbReadOutputs.Size = new System.Drawing.Size(161, 24);
            this.cbReadOutputs.TabIndex = 26;
            this.cbReadOutputs.Text = "Read Outputs";
            this.cbReadOutputs.UseVisualStyleBackColor = true;
            this.cbReadOutputs.CheckedChanged += new System.EventHandler(this.cbReadOutputs_CheckedChanged_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(48, 405);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(188, 20);
            this.label11.TabIndex = 25;
            this.label11.Text = "Zero Speed Reach";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(48, 361);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "CW Torque Limit";
            // 
            // labelCcwTorqueLim
            // 
            this.labelCcwTorqueLim.AutoSize = true;
            this.labelCcwTorqueLim.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelCcwTorqueLim.Location = new System.Drawing.Point(48, 313);
            this.labelCcwTorqueLim.Name = "labelCcwTorqueLim";
            this.labelCcwTorqueLim.Size = new System.Drawing.Size(180, 20);
            this.labelCcwTorqueLim.TabIndex = 23;
            this.labelCcwTorqueLim.Text = "CCW Torque Limit";
            // 
            // labelAlarm
            // 
            this.labelAlarm.AutoSize = true;
            this.labelAlarm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelAlarm.Location = new System.Drawing.Point(48, 261);
            this.labelAlarm.Name = "labelAlarm";
            this.labelAlarm.Size = new System.Drawing.Size(76, 20);
            this.labelAlarm.TabIndex = 22;
            this.labelAlarm.Text = "ALARM";
            // 
            // labelTorqueLimit
            // 
            this.labelTorqueLimit.AutoSize = true;
            this.labelTorqueLimit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelTorqueLimit.Location = new System.Drawing.Point(46, 220);
            this.labelTorqueLimit.Name = "labelTorqueLimit";
            this.labelTorqueLimit.Size = new System.Drawing.Size(126, 20);
            this.labelTorqueLimit.TabIndex = 21;
            this.labelTorqueLimit.Text = "Torque Limit";
            // 
            // lbZeroSpeedReach
            // 
            this.lbZeroSpeedReach.AutoEllipsis = true;
            this.lbZeroSpeedReach.BackColor = System.Drawing.Color.Gray;
            this.lbZeroSpeedReach.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbZeroSpeedReach.Location = new System.Drawing.Point(9, 394);
            this.lbZeroSpeedReach.Name = "lbZeroSpeedReach";
            this.lbZeroSpeedReach.Size = new System.Drawing.Size(31, 33);
            this.lbZeroSpeedReach.TabIndex = 20;
            // 
            // lbCwTorqueLimit
            // 
            this.lbCwTorqueLimit.AutoEllipsis = true;
            this.lbCwTorqueLimit.BackColor = System.Drawing.Color.Gray;
            this.lbCwTorqueLimit.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbCwTorqueLimit.Location = new System.Drawing.Point(9, 349);
            this.lbCwTorqueLimit.Name = "lbCwTorqueLimit";
            this.lbCwTorqueLimit.Size = new System.Drawing.Size(31, 33);
            this.lbCwTorqueLimit.TabIndex = 19;
            // 
            // lbCcwTorqueLimit
            // 
            this.lbCcwTorqueLimit.AutoEllipsis = true;
            this.lbCcwTorqueLimit.BackColor = System.Drawing.Color.Gray;
            this.lbCcwTorqueLimit.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbCcwTorqueLimit.Location = new System.Drawing.Point(9, 301);
            this.lbCcwTorqueLimit.Name = "lbCcwTorqueLimit";
            this.lbCcwTorqueLimit.Size = new System.Drawing.Size(31, 33);
            this.lbCcwTorqueLimit.TabIndex = 18;
            // 
            // lbAlarm
            // 
            this.lbAlarm.AutoEllipsis = true;
            this.lbAlarm.BackColor = System.Drawing.Color.Gray;
            this.lbAlarm.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbAlarm.Location = new System.Drawing.Point(9, 253);
            this.lbAlarm.Name = "lbAlarm";
            this.lbAlarm.Size = new System.Drawing.Size(31, 33);
            this.lbAlarm.TabIndex = 17;
            // 
            // lbTorqueLimit
            // 
            this.lbTorqueLimit.AutoEllipsis = true;
            this.lbTorqueLimit.BackColor = System.Drawing.Color.Gray;
            this.lbTorqueLimit.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbTorqueLimit.Location = new System.Drawing.Point(9, 208);
            this.lbTorqueLimit.Name = "lbTorqueLimit";
            this.lbTorqueLimit.Size = new System.Drawing.Size(31, 33);
            this.lbTorqueLimit.TabIndex = 16;
            // 
            // lbSpeedReach
            // 
            this.lbSpeedReach.AutoEllipsis = true;
            this.lbSpeedReach.BackColor = System.Drawing.Color.Gray;
            this.lbSpeedReach.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbSpeedReach.Location = new System.Drawing.Point(9, 164);
            this.lbSpeedReach.Name = "lbSpeedReach";
            this.lbSpeedReach.Size = new System.Drawing.Size(31, 33);
            this.lbSpeedReach.TabIndex = 15;
            // 
            // lbReady
            // 
            this.lbReady.AutoEllipsis = true;
            this.lbReady.BackColor = System.Drawing.Color.Gray;
            this.lbReady.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbReady.Location = new System.Drawing.Point(9, 121);
            this.lbReady.Name = "lbReady";
            this.lbReady.Size = new System.Drawing.Size(31, 33);
            this.lbReady.TabIndex = 14;
            // 
            // lbBrake
            // 
            this.lbBrake.AutoEllipsis = true;
            this.lbBrake.BackColor = System.Drawing.Color.Gray;
            this.lbBrake.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbBrake.Location = new System.Drawing.Point(9, 74);
            this.lbBrake.Name = "lbBrake";
            this.lbBrake.Size = new System.Drawing.Size(31, 33);
            this.lbBrake.TabIndex = 13;
            // 
            // lb_Type
            // 
            this.lb_Type.AutoEllipsis = true;
            this.lb_Type.BackColor = System.Drawing.Color.Gray;
            this.lb_Type.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lb_Type.Location = new System.Drawing.Point(9, 28);
            this.lb_Type.Name = "lb_Type";
            this.lb_Type.Size = new System.Drawing.Size(31, 33);
            this.lb_Type.TabIndex = 12;
            // 
            // lbReach
            // 
            this.lbReach.AutoSize = true;
            this.lbReach.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbReach.Location = new System.Drawing.Point(46, 176);
            this.lbReach.Name = "lbReach";
            this.lbReach.Size = new System.Drawing.Size(221, 20);
            this.lbReach.TabIndex = 5;
            this.lbReach.Text = "SPDReach/POSReach\r\n";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(46, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "RDY";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(46, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "TYPE OUT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(46, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "BRAKE";
            // 
            // gbJogControl
            // 
            this.gbJogControl.AutoSize = true;
            this.gbJogControl.BackColor = System.Drawing.Color.PaleTurquoise;
            this.gbJogControl.Controls.Add(this.btnSetJogSpeed);
            this.gbJogControl.Controls.Add(this.txtSetSpeed);
            this.gbJogControl.Controls.Add(this.label5);
            this.gbJogControl.Controls.Add(this.btnMoveDown);
            this.gbJogControl.Controls.Add(this.btnMoveUp);
            this.gbJogControl.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gbJogControl.ForeColor = System.Drawing.Color.Red;
            this.gbJogControl.Location = new System.Drawing.Point(7, 511);
            this.gbJogControl.Name = "gbJogControl";
            this.gbJogControl.Size = new System.Drawing.Size(336, 126);
            this.gbJogControl.TabIndex = 16;
            this.gbJogControl.TabStop = false;
            this.gbJogControl.Text = "JOG Control";
            // 
            // btnSetJogSpeed
            // 
            this.btnSetJogSpeed.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSetJogSpeed.Location = new System.Drawing.Point(89, 65);
            this.btnSetJogSpeed.Name = "btnSetJogSpeed";
            this.btnSetJogSpeed.Size = new System.Drawing.Size(87, 32);
            this.btnSetJogSpeed.TabIndex = 15;
            this.btnSetJogSpeed.Text = "SET";
            this.btnSetJogSpeed.UseVisualStyleBackColor = true;
            this.btnSetJogSpeed.Click += new System.EventHandler(this.btnSetJogSpeed_Click);
            // 
            // txtSetSpeed
            // 
            this.txtSetSpeed.Location = new System.Drawing.Point(94, 29);
            this.txtSetSpeed.Name = "txtSetSpeed";
            this.txtSetSpeed.Size = new System.Drawing.Size(79, 30);
            this.txtSetSpeed.TabIndex = 14;
            this.txtSetSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(5, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 39);
            this.label5.TabIndex = 13;
            this.label5.Text = "Set Speed (rpm)";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSimulate
            // 
            this.btnSimulate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSimulate.Location = new System.Drawing.Point(180, 175);
            this.btnSimulate.Name = "btnSimulate";
            this.btnSimulate.Size = new System.Drawing.Size(112, 98);
            this.btnSimulate.TabIndex = 16;
            this.btnSimulate.Text = "Start Init";
            this.btnSimulate.UseVisualStyleBackColor = true;
            this.btnSimulate.Click += new System.EventHandler(this.btnSimulate_Click);
            // 
            // btnHoming
            // 
            this.btnHoming.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnHoming.Font = new System.Drawing.Font("Gulim", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnHoming.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnHoming.Location = new System.Drawing.Point(173, 318);
            this.btnHoming.Name = "btnHoming";
            this.btnHoming.Size = new System.Drawing.Size(107, 42);
            this.btnHoming.TabIndex = 53;
            this.btnHoming.Text = "Homing";
            this.btnHoming.UseVisualStyleBackColor = false;
            this.btnHoming.Click += new System.EventHandler(this.btnSetHome_Click);
            // 
            // lbMotorSpeed
            // 
            this.lbMotorSpeed.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbMotorSpeed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbMotorSpeed.Font = new System.Drawing.Font("Gulim", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbMotorSpeed.Location = new System.Drawing.Point(81, 124);
            this.lbMotorSpeed.Name = "lbMotorSpeed";
            this.lbMotorSpeed.Size = new System.Drawing.Size(198, 78);
            this.lbMotorSpeed.TabIndex = 11;
            this.lbMotorSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnResetAlarm
            // 
            this.btnResetAlarm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnResetAlarm.Font = new System.Drawing.Font("Gulim", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnResetAlarm.Location = new System.Drawing.Point(11, 36);
            this.btnResetAlarm.Name = "btnResetAlarm";
            this.btnResetAlarm.Size = new System.Drawing.Size(136, 79);
            this.btnResetAlarm.TabIndex = 17;
            this.btnResetAlarm.Text = "Arm Reset";
            this.btnResetAlarm.UseVisualStyleBackColor = false;
            this.btnResetAlarm.Click += new System.EventHandler(this.btnResetAlarm_Click_1);
            // 
            // lbServoEnable
            // 
            this.lbServoEnable.AutoSize = true;
            this.lbServoEnable.Font = new System.Drawing.Font("Gulim", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbServoEnable.ForeColor = System.Drawing.Color.Black;
            this.lbServoEnable.Location = new System.Drawing.Point(153, 109);
            this.lbServoEnable.Name = "lbServoEnable";
            this.lbServoEnable.Size = new System.Drawing.Size(139, 19);
            this.lbServoEnable.TabIndex = 40;
            this.lbServoEnable.Text = "Servo OFF/ON";
            // 
            // btnStartDropping
            // 
            this.btnStartDropping.BackColor = System.Drawing.Color.Lime;
            this.btnStartDropping.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStartDropping.Font = new System.Drawing.Font("Gulim", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnStartDropping.ForeColor = System.Drawing.Color.Black;
            this.btnStartDropping.Location = new System.Drawing.Point(306, 175);
            this.btnStartDropping.Name = "btnStartDropping";
            this.btnStartDropping.Size = new System.Drawing.Size(105, 98);
            this.btnStartDropping.TabIndex = 52;
            this.btnStartDropping.Text = "START";
            this.btnStartDropping.UseVisualStyleBackColor = false;
            this.btnStartDropping.Click += new System.EventHandler(this.btnStartDropping_Click_1);
            // 
            // SpeedGraph
            // 
            this.SpeedGraph.Location = new System.Drawing.Point(688, 45);
            this.SpeedGraph.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SpeedGraph.Name = "SpeedGraph";
            this.SpeedGraph.ScrollGrace = 0D;
            this.SpeedGraph.ScrollMaxX = 0D;
            this.SpeedGraph.ScrollMaxY = 0D;
            this.SpeedGraph.ScrollMaxY2 = 0D;
            this.SpeedGraph.ScrollMinX = 0D;
            this.SpeedGraph.ScrollMinY = 0D;
            this.SpeedGraph.ScrollMinY2 = 0D;
            this.SpeedGraph.Size = new System.Drawing.Size(927, 787);
            this.SpeedGraph.TabIndex = 56;
            this.SpeedGraph.UseExtendedPrintDialog = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox1.Controls.Add(this.btnSimulate);
            this.groupBox1.Controls.Add(this.btnStop);
            this.groupBox1.Controls.Add(this.btnEstop);
            this.groupBox1.Controls.Add(this.btnResetAlarm);
            this.groupBox1.Controls.Add(this.lbServoEnable);
            this.groupBox1.Controls.Add(this.toggleServoEnable);
            this.groupBox1.Controls.Add(this.btnStartDropping);
            this.groupBox1.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(7, 674);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(436, 283);
            this.groupBox1.TabIndex = 58;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General Control";
            // 
            // toggleServoEnable
            // 
            this.toggleServoEnable.Location = new System.Drawing.Point(167, 36);
            this.toggleServoEnable.MinimumSize = new System.Drawing.Size(45, 23);
            this.toggleServoEnable.Name = "toggleServoEnable";
            this.toggleServoEnable.OffBackColor = System.Drawing.Color.Gray;
            this.toggleServoEnable.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.toggleServoEnable.OnBackColor = System.Drawing.Color.Lime;
            this.toggleServoEnable.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.toggleServoEnable.Size = new System.Drawing.Size(111, 50);
            this.toggleServoEnable.TabIndex = 39;
            this.toggleServoEnable.UseVisualStyleBackColor = true;
            this.toggleServoEnable.CheckedChanged += new System.EventHandler(this.toggleServoEnable_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSize = true;
            this.groupBox3.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.lbAccZ);
            this.groupBox3.Controls.Add(this.tongleDataOnOff);
            this.groupBox3.Controls.Add(this.tongleSoftLimit);
            this.groupBox3.Controls.Add(this.btnSetHome);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.lbObjectPosition);
            this.groupBox3.Controls.Add(this.btnHoming);
            this.groupBox3.Controls.Add(this.lbMotorSpeed);
            this.groupBox3.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox3.ForeColor = System.Drawing.Color.Red;
            this.groupBox3.Location = new System.Drawing.Point(347, 51);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(291, 511);
            this.groupBox3.TabIndex = 59;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Motion Status";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(102, 448);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(137, 20);
            this.label16.TabIndex = 69;
            this.label16.Text = "Data OFF/ON";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(100, 393);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(185, 20);
            this.label12.TabIndex = 68;
            this.label12.Text = "Soft Limit OFF/ON";
            // 
            // lbAccZ
            // 
            this.lbAccZ.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbAccZ.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbAccZ.Font = new System.Drawing.Font("Gulim", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbAccZ.Location = new System.Drawing.Point(82, 215);
            this.lbAccZ.Name = "lbAccZ";
            this.lbAccZ.Size = new System.Drawing.Size(198, 85);
            this.lbAccZ.TabIndex = 67;
            this.lbAccZ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tongleDataOnOff
            // 
            this.tongleDataOnOff.Location = new System.Drawing.Point(6, 437);
            this.tongleDataOnOff.MinimumSize = new System.Drawing.Size(45, 23);
            this.tongleDataOnOff.Name = "tongleDataOnOff";
            this.tongleDataOnOff.OffBackColor = System.Drawing.Color.Gray;
            this.tongleDataOnOff.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.tongleDataOnOff.OnBackColor = System.Drawing.Color.Lime;
            this.tongleDataOnOff.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.tongleDataOnOff.Size = new System.Drawing.Size(95, 45);
            this.tongleDataOnOff.TabIndex = 57;
            this.tongleDataOnOff.UseVisualStyleBackColor = true;
            this.tongleDataOnOff.CheckedChanged += new System.EventHandler(this.tongleDataOnOff_CheckedChanged);
            // 
            // tongleSoftLimit
            // 
            this.tongleSoftLimit.Checked = true;
            this.tongleSoftLimit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tongleSoftLimit.Location = new System.Drawing.Point(5, 378);
            this.tongleSoftLimit.MinimumSize = new System.Drawing.Size(45, 23);
            this.tongleSoftLimit.Name = "tongleSoftLimit";
            this.tongleSoftLimit.OffBackColor = System.Drawing.Color.Gray;
            this.tongleSoftLimit.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.tongleSoftLimit.OnBackColor = System.Drawing.Color.Red;
            this.tongleSoftLimit.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.tongleSoftLimit.Size = new System.Drawing.Size(95, 45);
            this.tongleSoftLimit.TabIndex = 57;
            this.tongleSoftLimit.UseVisualStyleBackColor = true;
            this.tongleSoftLimit.CheckedChanged += new System.EventHandler(this.tongleSoftLimit_CheckedChanged);
            // 
            // btnSetHome
            // 
            this.btnSetHome.Font = new System.Drawing.Font("Gulim", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSetHome.Location = new System.Drawing.Point(6, 318);
            this.btnSetHome.Name = "btnSetHome";
            this.btnSetHome.Size = new System.Drawing.Size(107, 42);
            this.btnSetHome.TabIndex = 66;
            this.btnSetHome.Text = "Set Home";
            this.btnSetHome.UseVisualStyleBackColor = true;
            this.btnSetHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(6, 249);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 20);
            this.label10.TabIndex = 63;
            this.label10.Text = "AccZ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(2, 156);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 20);
            this.label14.TabIndex = 63;
            this.label14.Text = "Speed";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(5, 51);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 20);
            this.label13.TabIndex = 62;
            this.label13.Text = "Position";
            // 
            // lbObjectPosition
            // 
            this.lbObjectPosition.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbObjectPosition.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbObjectPosition.Font = new System.Drawing.Font("Gulim", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbObjectPosition.Location = new System.Drawing.Point(94, 29);
            this.lbObjectPosition.Name = "lbObjectPosition";
            this.lbObjectPosition.Size = new System.Drawing.Size(186, 80);
            this.lbObjectPosition.TabIndex = 53;
            this.lbObjectPosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listData
            // 
            this.listData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Time,
            this.Speed,
            this.RefSpeed,
            this.AccelX,
            this.AccelY,
            this.AccelZ,
            this.AccZRef,
            this.Position,
            this.listLocalTime});
            this.listData.Font = new System.Drawing.Font("Gulim", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listData.HideSelection = false;
            this.listData.Location = new System.Drawing.Point(810, 922);
            this.listData.Name = "listData";
            this.listData.Size = new System.Drawing.Size(824, 126);
            this.listData.TabIndex = 61;
            this.listData.UseCompatibleStateImageBehavior = false;
            this.listData.View = System.Windows.Forms.View.Details;
            // 
            // Time
            // 
            this.Time.Text = "time (s)";
            this.Time.Width = 90;
            // 
            // Speed
            // 
            this.Speed.Text = "Spd (rpm)";
            this.Speed.Width = 104;
            // 
            // RefSpeed
            // 
            this.RefSpeed.Text = "Ref Speed";
            this.RefSpeed.Width = 115;
            // 
            // AccelX
            // 
            this.AccelX.Text = "AccX";
            // 
            // AccelY
            // 
            this.AccelY.Text = "AccY";
            // 
            // AccelZ
            // 
            this.AccelZ.Text = "AccZ";
            // 
            // AccZRef
            // 
            this.AccZRef.Text = "AccRef";
            this.AccZRef.Width = 79;
            // 
            // Position
            // 
            this.Position.Text = "ObPosition";
            this.Position.Width = 125;
            // 
            // listLocalTime
            // 
            this.listLocalTime.Text = "LocalTime";
            this.listLocalTime.Width = 118;
            // 
            // timer2
            // 
            this.timer2.Interval = 50;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick_1);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(688, 791);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(298, 38);
            this.progressBar.TabIndex = 62;
            // 
            // gbDataView
            // 
            this.gbDataView.Controls.Add(this.cbAccRef);
            this.gbDataView.Controls.Add(this.cbAccZ);
            this.gbDataView.Controls.Add(this.btnSave);
            this.gbDataView.Controls.Add(this.btnResetGraph);
            this.gbDataView.Controls.Add(this.btnScroll);
            this.gbDataView.Controls.Add(this.cbSpeed);
            this.gbDataView.Controls.Add(this.cbSpdCmd);
            this.gbDataView.Controls.Add(this.btnGraphOn);
            this.gbDataView.Font = new System.Drawing.Font("Gulim", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gbDataView.Location = new System.Drawing.Point(688, 838);
            this.gbDataView.Name = "gbDataView";
            this.gbDataView.Size = new System.Drawing.Size(946, 75);
            this.gbDataView.TabIndex = 63;
            this.gbDataView.TabStop = false;
            this.gbDataView.Text = "Data View";
            // 
            // cbAccRef
            // 
            this.cbAccRef.AutoSize = true;
            this.cbAccRef.Font = new System.Drawing.Font("Gulim", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbAccRef.Location = new System.Drawing.Point(363, 32);
            this.cbAccRef.Name = "cbAccRef";
            this.cbAccRef.Size = new System.Drawing.Size(95, 23);
            this.cbAccRef.TabIndex = 36;
            this.cbAccRef.Text = "AccRef";
            this.cbAccRef.UseVisualStyleBackColor = true;
            this.cbAccRef.CheckedChanged += new System.EventHandler(this.cbAccRef_CheckedChanged);
            // 
            // cbAccZ
            // 
            this.cbAccZ.AutoSize = true;
            this.cbAccZ.Font = new System.Drawing.Font("Gulim", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbAccZ.Location = new System.Drawing.Point(278, 32);
            this.cbAccZ.Name = "cbAccZ";
            this.cbAccZ.Size = new System.Drawing.Size(78, 23);
            this.cbAccZ.TabIndex = 35;
            this.cbAccZ.Text = "AccZ";
            this.cbAccZ.UseVisualStyleBackColor = true;
            this.cbAccZ.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(827, 19);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(116, 45);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save Data";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // btnResetGraph
            // 
            this.btnResetGraph.Location = new System.Drawing.Point(705, 19);
            this.btnResetGraph.Name = "btnResetGraph";
            this.btnResetGraph.Size = new System.Drawing.Size(116, 45);
            this.btnResetGraph.TabIndex = 17;
            this.btnResetGraph.Text = "ResetGrap";
            this.btnResetGraph.UseVisualStyleBackColor = true;
            this.btnResetGraph.Click += new System.EventHandler(this.btnResetGraph_Click_1);
            // 
            // btnScroll
            // 
            this.btnScroll.Location = new System.Drawing.Point(583, 19);
            this.btnScroll.Name = "btnScroll";
            this.btnScroll.Size = new System.Drawing.Size(116, 45);
            this.btnScroll.TabIndex = 19;
            this.btnScroll.Text = "COMPACT";
            this.btnScroll.UseVisualStyleBackColor = true;
            this.btnScroll.Click += new System.EventHandler(this.btnScroll_Click_1);
            // 
            // cbSpeed
            // 
            this.cbSpeed.AutoSize = true;
            this.cbSpeed.Font = new System.Drawing.Font("Gulim", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbSpeed.Location = new System.Drawing.Point(6, 32);
            this.cbSpeed.Name = "cbSpeed";
            this.cbSpeed.Size = new System.Drawing.Size(147, 23);
            this.cbSpeed.TabIndex = 33;
            this.cbSpeed.Text = "Motor Speed";
            this.cbSpeed.UseVisualStyleBackColor = true;
            this.cbSpeed.CheckedChanged += new System.EventHandler(this.cbSpeed_CheckedChanged_1);
            // 
            // cbSpdCmd
            // 
            this.cbSpdCmd.AutoSize = true;
            this.cbSpdCmd.Font = new System.Drawing.Font("Gulim", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbSpdCmd.Location = new System.Drawing.Point(159, 32);
            this.cbSpdCmd.Name = "cbSpdCmd";
            this.cbSpdCmd.Size = new System.Drawing.Size(112, 23);
            this.cbSpdCmd.TabIndex = 34;
            this.cbSpdCmd.Text = "Spd Cmd";
            this.cbSpdCmd.UseVisualStyleBackColor = true;
            this.cbSpdCmd.CheckedChanged += new System.EventHandler(this.cbSpdCmd_CheckedChanged_1);
            // 
            // btnGraphOn
            // 
            this.btnGraphOn.Location = new System.Drawing.Point(461, 19);
            this.btnGraphOn.Name = "btnGraphOn";
            this.btnGraphOn.Size = new System.Drawing.Size(116, 45);
            this.btnGraphOn.TabIndex = 16;
            this.btnGraphOn.Text = "Graph On";
            this.btnGraphOn.UseVisualStyleBackColor = true;
            this.btnGraphOn.Click += new System.EventHandler(this.btnGraphOn_Click);
            // 
            // lb_com_status
            // 
            this.lb_com_status.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_com_status.Location = new System.Drawing.Point(785, 0);
            this.lb_com_status.Name = "lb_com_status";
            this.lb_com_status.Size = new System.Drawing.Size(228, 35);
            this.lb_com_status.TabIndex = 64;
            this.lb_com_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_com_status.Click += new System.EventHandler(this.lb_com_status_Click);
            // 
            // btnRstMcu
            // 
            this.btnRstMcu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnRstMcu.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnRstMcu.Location = new System.Drawing.Point(1533, -1);
            this.btnRstMcu.Name = "btnRstMcu";
            this.btnRstMcu.Size = new System.Drawing.Size(82, 34);
            this.btnRstMcu.TabIndex = 65;
            this.btnRstMcu.Text = "MCU Rst";
            this.btnRstMcu.UseVisualStyleBackColor = false;
            this.btnRstMcu.Click += new System.EventHandler(this.btnRstMcu_Click_1);
            // 
            // cbExperimentMode
            // 
            this.cbExperimentMode.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbExperimentMode.FormattingEnabled = true;
            this.cbExperimentMode.Items.AddRange(new object[] {
            "Dropping",
            "Pulling",
            "Pulling->Dropping"});
            this.cbExperimentMode.Location = new System.Drawing.Point(6, 29);
            this.cbExperimentMode.Name = "cbExperimentMode";
            this.cbExperimentMode.Size = new System.Drawing.Size(186, 28);
            this.cbExperimentMode.TabIndex = 69;
            this.cbExperimentMode.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cbDriverType
            // 
            this.cbDriverType.Font = new System.Drawing.Font("Gulim", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbDriverType.FormattingEnabled = true;
            this.cbDriverType.Items.AddRange(new object[] {
            "HIGEN - FDA7000 - 15kw",
            "DELTA - ASDA(A3) - 400w"});
            this.cbDriverType.Location = new System.Drawing.Point(14, 43);
            this.cbDriverType.Name = "cbDriverType";
            this.cbDriverType.Size = new System.Drawing.Size(314, 33);
            this.cbDriverType.TabIndex = 71;
            this.cbDriverType.SelectedIndexChanged += new System.EventHandler(this.cbDriverType_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbDriverType);
            this.groupBox4.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox4.ForeColor = System.Drawing.Color.Red;
            this.groupBox4.Location = new System.Drawing.Point(347, 561);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(334, 107);
            this.groupBox4.TabIndex = 72;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Motor Driver";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Text|*.txt";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cbExperimentMode);
            this.groupBox5.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox5.ForeColor = System.Drawing.Color.Red;
            this.groupBox5.Location = new System.Drawing.Point(449, 681);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(230, 63);
            this.groupBox5.TabIndex = 73;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Experiment Mode";
            // 
            // groupBox6
            // 
            this.groupBox6.AutoSize = true;
            this.groupBox6.BackColor = System.Drawing.Color.OldLace;
            this.groupBox6.Controls.Add(this.lbPort);
            this.groupBox6.Controls.Add(this.togServerOnOff);
            this.groupBox6.Controls.Add(this.lbServerIP);
            this.groupBox6.Controls.Add(this.label18);
            this.groupBox6.Controls.Add(this.label19);
            this.groupBox6.Font = new System.Drawing.Font("Gulim", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox6.ForeColor = System.Drawing.Color.Red;
            this.groupBox6.Location = new System.Drawing.Point(449, 761);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(231, 151);
            this.groupBox6.TabIndex = 75;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "UDP Com";
            // 
            // lbPort
            // 
            this.lbPort.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbPort.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbPort.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbPort.Location = new System.Drawing.Point(63, 78);
            this.lbPort.Name = "lbPort";
            this.lbPort.Size = new System.Drawing.Size(71, 36);
            this.lbPort.TabIndex = 33;
            this.lbPort.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // togServerOnOff
            // 
            this.togServerOnOff.Location = new System.Drawing.Point(135, 83);
            this.togServerOnOff.MinimumSize = new System.Drawing.Size(45, 23);
            this.togServerOnOff.Name = "togServerOnOff";
            this.togServerOnOff.OffBackColor = System.Drawing.Color.Gray;
            this.togServerOnOff.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.togServerOnOff.OnBackColor = System.Drawing.Color.Lime;
            this.togServerOnOff.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.togServerOnOff.Size = new System.Drawing.Size(83, 29);
            this.togServerOnOff.TabIndex = 34;
            this.togServerOnOff.UseVisualStyleBackColor = true;
            this.togServerOnOff.CheckedChanged += new System.EventHandler(this.togServerOnOff_CheckedChanged);
            // 
            // lbServerIP
            // 
            this.lbServerIP.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbServerIP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbServerIP.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbServerIP.ForeColor = System.Drawing.Color.Black;
            this.lbServerIP.Location = new System.Drawing.Point(38, 32);
            this.lbServerIP.Name = "lbServerIP";
            this.lbServerIP.Size = new System.Drawing.Size(136, 34);
            this.lbServerIP.TabIndex = 32;
            this.lbServerIP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(6, 88);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(47, 20);
            this.label18.TabIndex = 30;
            this.label18.Text = "Port";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(6, 38);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(26, 20);
            this.label19.TabIndex = 29;
            this.label19.Text = "IP";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // serialPort2
            // 
            this.serialPort2.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort2_DataReceived);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Text|*.txt";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label15.Location = new System.Drawing.Point(1334, 795);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(186, 20);
            this.label15.TabIndex = 73;
            this.label15.Text = "Recording Sensors";
            // 
            // lbTemp
            // 
            this.lbTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbTemp.Location = new System.Drawing.Point(1440, 655);
            this.lbTemp.Name = "lbTemp";
            this.lbTemp.Size = new System.Drawing.Size(120, 61);
            this.lbTemp.TabIndex = 76;
            this.lbTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbStartRecording
            // 
            this.lbStartRecording.AutoEllipsis = true;
            this.lbStartRecording.BackColor = System.Drawing.Color.Gray;
            this.lbStartRecording.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbStartRecording.Location = new System.Drawing.Point(1537, 781);
            this.lbStartRecording.Name = "lbStartRecording";
            this.lbStartRecording.Size = new System.Drawing.Size(42, 44);
            this.lbStartRecording.TabIndex = 20;
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStop.BackColor = System.Drawing.Color.White;
            this.btnStop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStop.BackgroundImage")));
            this.btnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStop.Font = new System.Drawing.Font("Gulim", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnStop.Location = new System.Drawing.Point(298, 36);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(113, 101);
            this.btnStop.TabIndex = 42;
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click_1);
            // 
            // btnEstop
            // 
            this.btnEstop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEstop.BackColor = System.Drawing.Color.White;
            this.btnEstop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEstop.BackgroundImage")));
            this.btnEstop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEstop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEstop.Font = new System.Drawing.Font("Gulim", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnEstop.Location = new System.Drawing.Point(6, 129);
            this.btnEstop.Name = "btnEstop";
            this.btnEstop.Size = new System.Drawing.Size(141, 139);
            this.btnEstop.TabIndex = 14;
            this.btnEstop.UseVisualStyleBackColor = false;
            this.btnEstop.Click += new System.EventHandler(this.btnEstop_Click_1);
            // 
            // btnMoveDown
            // 
            this.btnMoveDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnMoveDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMoveDown.BackgroundImage")));
            this.btnMoveDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMoveDown.Font = new System.Drawing.Font("Gulim", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnMoveDown.Location = new System.Drawing.Point(194, 25);
            this.btnMoveDown.Name = "btnMoveDown";
            this.btnMoveDown.Size = new System.Drawing.Size(63, 61);
            this.btnMoveDown.TabIndex = 5;
            this.btnMoveDown.UseVisualStyleBackColor = false;
            this.btnMoveDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnMoveDown_MouseDown_1);
            this.btnMoveDown.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnMoveDown_MouseUp_1);
            // 
            // btnMoveUp
            // 
            this.btnMoveUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnMoveUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMoveUp.BackgroundImage")));
            this.btnMoveUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMoveUp.Font = new System.Drawing.Font("Gulim", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnMoveUp.Location = new System.Drawing.Point(267, 25);
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.Size = new System.Drawing.Size(63, 61);
            this.btnMoveUp.TabIndex = 4;
            this.btnMoveUp.UseVisualStyleBackColor = false;
            this.btnMoveUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnMoveUp_MouseDown_1);
            this.btnMoveUp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnMoveUp_MouseUp_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1638, 1055);
            this.Controls.Add(this.lbTemp);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.lbStartRecording);
            this.Controls.Add(this.btnRstMcu);
            this.Controls.Add(this.lb_com_status);
            this.Controls.Add(this.gbDataView);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.listData);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SpeedGraph);
            this.Controls.Add(this.gbJogControl);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Black;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "FreeFall_GUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_Control_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbJogControl.ResumeLayout(false);
            this.gbJogControl.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gbDataView.ResumeLayout(false);
            this.gbDataView.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cOMPortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem selectFolderToSaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private ButtonEllipse btnEstop;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbReadOutputs;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelCcwTorqueLim;
        private System.Windows.Forms.Label labelAlarm;
        private System.Windows.Forms.Label labelTorqueLimit;
        private Elip_Label lbZeroSpeedReach;
        private Elip_Label lbCwTorqueLimit;
        private Elip_Label lbCcwTorqueLimit;
        private Elip_Label lbAlarm;
        private Elip_Label lbTorqueLimit;
        private Elip_Label lbSpeedReach;
        private Elip_Label lbReady;
        private Elip_Label lbBrake;
        private Elip_Label lb_Type;
        private System.Windows.Forms.Label lbReach;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbJogControl;
        private System.Windows.Forms.Button btnHoming;
        private System.Windows.Forms.Button btnSetJogSpeed;
        private System.Windows.Forms.TextBox txtSetSpeed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbMotorSpeed;
        private System.Windows.Forms.Button btnMoveDown;
        private System.Windows.Forms.Button btnMoveUp;
        private System.Windows.Forms.Button btnResetAlarm;
        private RJControls.RJToggleButton toggleServoEnable;
        private System.Windows.Forms.Label lbServoEnable;
        private System.Windows.Forms.Button btnStartDropping;
        private ZedGraph.ZedGraphControl SpeedGraph;
        private System.Windows.Forms.GroupBox groupBox1;
        private ButtonEllipse btnStop;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbObjectPosition;
        private System.Windows.Forms.ListView listData;
        private System.Windows.Forms.ColumnHeader Time;
        private System.Windows.Forms.ColumnHeader Speed;
        private System.Windows.Forms.ColumnHeader RefSpeed;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.GroupBox gbDataView;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnResetGraph;
        private System.Windows.Forms.Button btnScroll;
        private System.Windows.Forms.CheckBox cbSpeed;
        private System.Windows.Forms.CheckBox cbSpdCmd;
        private System.Windows.Forms.Button btnGraphOn;
        private System.Windows.Forms.Label lb_com_status;
        private System.Windows.Forms.Button btnRstMcu;
        private System.Windows.Forms.ToolStripMenuItem parameterSettingToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbExperimentMode;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ToolStripMenuItem driverInputControlToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbDriverType;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox cbAccZ;
        private System.Windows.Forms.ColumnHeader AccelZ;
        private System.Windows.Forms.ColumnHeader listLocalTime;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem tCPServerToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lbPort;
        private RJControls.RJToggleButton togServerOnOff;
        private System.Windows.Forms.Label lbServerIP;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.IO.Ports.SerialPort serialPort2;
        private System.Windows.Forms.ToolStripMenuItem openAFileToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.CheckBox cbAccRef;
        private System.Windows.Forms.Button btnSetHome;
        private Elip_Label lbStartRecording;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbAccZ;
        private RJControls.RJToggleButton tongleDataOnOff;
        private RJControls.RJToggleButton tongleSoftLimit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ColumnHeader AccZRef;
        private System.Windows.Forms.ColumnHeader AccelX;
        private System.Windows.Forms.ColumnHeader AccelY;
        private System.Windows.Forms.ColumnHeader Position;
        private System.Windows.Forms.ToolStripMenuItem gyroAndDisGraphToolStripMenuItem;
        private System.Windows.Forms.Button btnSimulate;
        private System.Windows.Forms.Label lbTemp;
        private System.Windows.Forms.ToolStripMenuItem speedControlTestToolStripMenuItem;
    }
}

