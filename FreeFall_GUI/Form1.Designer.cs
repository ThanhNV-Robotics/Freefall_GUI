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
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.selectFolderToSaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pulseTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parameterSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.driverInputControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbReadOutputs = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelCcwTorqueLim = new System.Windows.Forms.Label();
            this.labelAlarm = new System.Windows.Forms.Label();
            this.labelTorqueLimit = new System.Windows.Forms.Label();
            this.lbReach = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbJogControl = new System.Windows.Forms.GroupBox();
            this.btnSetJogSpeed = new System.Windows.Forms.Button();
            this.txtSetSpeed = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnMoveDown = new System.Windows.Forms.Button();
            this.btnMoveUp = new System.Windows.Forms.Button();
            this.btnSetHome = new System.Windows.Forms.Button();
            this.lbEncoderPulses = new System.Windows.Forms.Label();
            this.lbMotorSpeed = new System.Windows.Forms.Label();
            this.btnResetAlarm = new System.Windows.Forms.Button();
            this.lbServoEnable = new System.Windows.Forms.Label();
            this.btnStartDropping = new System.Windows.Forms.Button();
            this.SpeedGraph = new ZedGraph.ZedGraphControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbRunningMode = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.lbAccZ = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbPosCmd = new System.Windows.Forms.Label();
            this.lbPulseCmd = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbObjectPosition = new System.Windows.Forms.Label();
            this.cbDataON = new System.Windows.Forms.CheckBox();
            this.gbEpisode = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbCurrentEpisode = new System.Windows.Forms.Label();
            this.txtTotalEpisodes = new System.Windows.Forms.TextBox();
            this.btnSetEpisode = new System.Windows.Forms.Button();
            this.listData = new System.Windows.Forms.ListView();
            this.Time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Speed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RefSpeed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AccelZ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listLocalTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.gbDataView = new System.Windows.Forms.GroupBox();
            this.cbAccZ = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnResetGraph = new System.Windows.Forms.Button();
            this.btnScroll = new System.Windows.Forms.Button();
            this.cbSpeed = new System.Windows.Forms.CheckBox();
            this.cbSpdCmd = new System.Windows.Forms.CheckBox();
            this.btnGraphOn = new System.Windows.Forms.Button();
            this.lb_com_status = new System.Windows.Forms.Label();
            this.btnRstMcu = new System.Windows.Forms.Button();
            this.FolderToSaveDiag = new System.Windows.Forms.FolderBrowserDialog();
            this.rdSpeedMode = new System.Windows.Forms.RadioButton();
            this.rdPositionMode = new System.Windows.Forms.RadioButton();
            this.lbCmdOut = new System.Windows.Forms.Label();
            this.cbExperimentMode = new System.Windows.Forms.ComboBox();
            this.trackBar_Position = new System.Windows.Forms.TrackBar();
            this.cbDriverType = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStop = new FreeFall_GUI.ButtonEllipse();
            this.btnEstop = new FreeFall_GUI.ButtonEllipse();
            this.toggleServoEnable = new FreeFall_GUI.RJControls.RJToggleButton();
            this.tongleRunningMode = new FreeFall_GUI.RJControls.RJToggleButton();
            this.lbZeroSpeedReach = new FreeFall_GUI.Elip_Label();
            this.lbCwTorqueLimit = new FreeFall_GUI.Elip_Label();
            this.lbCcwTorqueLimit = new FreeFall_GUI.Elip_Label();
            this.lbAlarm = new FreeFall_GUI.Elip_Label();
            this.lbTorqueLimit = new FreeFall_GUI.Elip_Label();
            this.lbSpeedReach = new FreeFall_GUI.Elip_Label();
            this.lbReady = new FreeFall_GUI.Elip_Label();
            this.lbBrake = new FreeFall_GUI.Elip_Label();
            this.lb_Type = new FreeFall_GUI.Elip_Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbJogControl.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gbEpisode.SuspendLayout();
            this.gbDataView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Position)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(1643, 28);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cOMPortToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.fileToolStripMenuItem.Text = "Connection";
            // 
            // cOMPortToolStripMenuItem
            // 
            this.cOMPortToolStripMenuItem.Name = "cOMPortToolStripMenuItem";
            this.cOMPortToolStripMenuItem.Size = new System.Drawing.Size(155, 26);
            this.cOMPortToolStripMenuItem.Text = "COM Port";
            this.cOMPortToolStripMenuItem.Click += new System.EventHandler(this.cOMPortToolStripMenuItem_Click);
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectFolderToSaveToolStripMenuItem});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem1.Text = "File";
            // 
            // selectFolderToSaveToolStripMenuItem
            // 
            this.selectFolderToSaveToolStripMenuItem.Name = "selectFolderToSaveToolStripMenuItem";
            this.selectFolderToSaveToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.selectFolderToSaveToolStripMenuItem.Text = "Select folder to save";
            this.selectFolderToSaveToolStripMenuItem.Click += new System.EventHandler(this.selectFolderToSaveToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pulseTestToolStripMenuItem,
            this.parameterSettingToolStripMenuItem,
            this.driverInputControlToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.aboutToolStripMenuItem.Text = "Tool";
            // 
            // pulseTestToolStripMenuItem
            // 
            this.pulseTestToolStripMenuItem.Name = "pulseTestToolStripMenuItem";
            this.pulseTestToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.pulseTestToolStripMenuItem.Text = "Pulse Command Test";
            this.pulseTestToolStripMenuItem.Click += new System.EventHandler(this.pulseTestToolStripMenuItem_Click);
            // 
            // parameterSettingToolStripMenuItem
            // 
            this.parameterSettingToolStripMenuItem.Name = "parameterSettingToolStripMenuItem";
            this.parameterSettingToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.parameterSettingToolStripMenuItem.Text = "Parameter Setting";
            this.parameterSettingToolStripMenuItem.Click += new System.EventHandler(this.parameterSettingToolStripMenuItem_Click);
            // 
            // driverInputControlToolStripMenuItem
            // 
            this.driverInputControlToolStripMenuItem.Name = "driverInputControlToolStripMenuItem";
            this.driverInputControlToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.driverInputControlToolStripMenuItem.Text = "Driver Input Control";
            this.driverInputControlToolStripMenuItem.Click += new System.EventHandler(this.driverInputControlToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // groupBox2
            // 
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
            this.groupBox2.Location = new System.Drawing.Point(12, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(326, 411);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Driver Output";
            // 
            // cbReadOutputs
            // 
            this.cbReadOutputs.AutoSize = true;
            this.cbReadOutputs.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbReadOutputs.Location = new System.Drawing.Point(164, 37);
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
            this.label11.Location = new System.Drawing.Point(48, 380);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(188, 20);
            this.label11.TabIndex = 25;
            this.label11.Text = "Zero Speed Reach";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(48, 338);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "CW Torque Limit";
            // 
            // labelCcwTorqueLim
            // 
            this.labelCcwTorqueLim.AutoSize = true;
            this.labelCcwTorqueLim.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelCcwTorqueLim.Location = new System.Drawing.Point(48, 293);
            this.labelCcwTorqueLim.Name = "labelCcwTorqueLim";
            this.labelCcwTorqueLim.Size = new System.Drawing.Size(180, 20);
            this.labelCcwTorqueLim.TabIndex = 23;
            this.labelCcwTorqueLim.Text = "CCW Torque Limit";
            // 
            // labelAlarm
            // 
            this.labelAlarm.AutoSize = true;
            this.labelAlarm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelAlarm.Location = new System.Drawing.Point(48, 245);
            this.labelAlarm.Name = "labelAlarm";
            this.labelAlarm.Size = new System.Drawing.Size(76, 20);
            this.labelAlarm.TabIndex = 22;
            this.labelAlarm.Text = "ALARM";
            // 
            // labelTorqueLimit
            // 
            this.labelTorqueLimit.AutoSize = true;
            this.labelTorqueLimit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelTorqueLimit.Location = new System.Drawing.Point(46, 206);
            this.labelTorqueLimit.Name = "labelTorqueLimit";
            this.labelTorqueLimit.Size = new System.Drawing.Size(126, 20);
            this.labelTorqueLimit.TabIndex = 21;
            this.labelTorqueLimit.Text = "Torque Limit";
            // 
            // lbReach
            // 
            this.lbReach.AutoSize = true;
            this.lbReach.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbReach.Location = new System.Drawing.Point(46, 165);
            this.lbReach.Name = "lbReach";
            this.lbReach.Size = new System.Drawing.Size(221, 20);
            this.lbReach.TabIndex = 5;
            this.lbReach.Text = "SPDReach/POSReach\r\n";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(46, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "RDY";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(46, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "TYPE OUT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(46, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "BRAKE";
            // 
            // gbJogControl
            // 
            this.gbJogControl.BackColor = System.Drawing.Color.PaleTurquoise;
            this.gbJogControl.Controls.Add(this.btnSetJogSpeed);
            this.gbJogControl.Controls.Add(this.txtSetSpeed);
            this.gbJogControl.Controls.Add(this.label5);
            this.gbJogControl.Controls.Add(this.btnMoveDown);
            this.gbJogControl.Controls.Add(this.btnMoveUp);
            this.gbJogControl.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gbJogControl.ForeColor = System.Drawing.Color.Red;
            this.gbJogControl.Location = new System.Drawing.Point(11, 526);
            this.gbJogControl.Name = "gbJogControl";
            this.gbJogControl.Size = new System.Drawing.Size(326, 165);
            this.gbJogControl.TabIndex = 16;
            this.gbJogControl.TabStop = false;
            this.gbJogControl.Text = "JOG Control";
            // 
            // btnSetJogSpeed
            // 
            this.btnSetJogSpeed.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSetJogSpeed.Location = new System.Drawing.Point(220, 27);
            this.btnSetJogSpeed.Name = "btnSetJogSpeed";
            this.btnSetJogSpeed.Size = new System.Drawing.Size(87, 30);
            this.btnSetJogSpeed.TabIndex = 15;
            this.btnSetJogSpeed.Text = "SET";
            this.btnSetJogSpeed.UseVisualStyleBackColor = true;
            this.btnSetJogSpeed.Click += new System.EventHandler(this.btnSetJogSpeed_Click);
            // 
            // txtSetSpeed
            // 
            this.txtSetSpeed.Location = new System.Drawing.Point(123, 27);
            this.txtSetSpeed.Name = "txtSetSpeed";
            this.txtSetSpeed.Size = new System.Drawing.Size(79, 30);
            this.txtSetSpeed.TabIndex = 14;
            this.txtSetSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(5, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 37);
            this.label5.TabIndex = 13;
            this.label5.Text = "Setting Speed (rpm)";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnMoveDown
            // 
            this.btnMoveDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnMoveDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMoveDown.BackgroundImage")));
            this.btnMoveDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMoveDown.Font = new System.Drawing.Font("Gulim", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnMoveDown.Location = new System.Drawing.Point(6, 77);
            this.btnMoveDown.Name = "btnMoveDown";
            this.btnMoveDown.Size = new System.Drawing.Size(63, 78);
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
            this.btnMoveUp.Location = new System.Drawing.Point(84, 77);
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.Size = new System.Drawing.Size(63, 78);
            this.btnMoveUp.TabIndex = 4;
            this.btnMoveUp.UseVisualStyleBackColor = false;
            this.btnMoveUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnMoveUp_MouseDown_1);
            this.btnMoveUp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnMoveUp_MouseUp_1);
            // 
            // btnSetHome
            // 
            this.btnSetHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSetHome.Font = new System.Drawing.Font("Gulim", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSetHome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSetHome.Location = new System.Drawing.Point(179, 422);
            this.btnSetHome.Name = "btnSetHome";
            this.btnSetHome.Size = new System.Drawing.Size(100, 30);
            this.btnSetHome.TabIndex = 53;
            this.btnSetHome.Text = "Set Home";
            this.btnSetHome.UseVisualStyleBackColor = false;
            this.btnSetHome.Click += new System.EventHandler(this.btnSetHome_Click);
            // 
            // lbEncoderPulses
            // 
            this.lbEncoderPulses.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbEncoderPulses.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbEncoderPulses.Location = new System.Drawing.Point(164, 222);
            this.lbEncoderPulses.Name = "lbEncoderPulses";
            this.lbEncoderPulses.Size = new System.Drawing.Size(116, 38);
            this.lbEncoderPulses.TabIndex = 17;
            this.lbEncoderPulses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbMotorSpeed
            // 
            this.lbMotorSpeed.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbMotorSpeed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbMotorSpeed.Font = new System.Drawing.Font("Gulim", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbMotorSpeed.Location = new System.Drawing.Point(148, 155);
            this.lbMotorSpeed.Name = "lbMotorSpeed";
            this.lbMotorSpeed.Size = new System.Drawing.Size(131, 60);
            this.lbMotorSpeed.TabIndex = 11;
            this.lbMotorSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnResetAlarm
            // 
            this.btnResetAlarm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnResetAlarm.Font = new System.Drawing.Font("Gulim", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnResetAlarm.Location = new System.Drawing.Point(11, 45);
            this.btnResetAlarm.Name = "btnResetAlarm";
            this.btnResetAlarm.Size = new System.Drawing.Size(136, 74);
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
            this.lbServoEnable.Location = new System.Drawing.Point(153, 100);
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
            this.btnStartDropping.Location = new System.Drawing.Point(306, 172);
            this.btnStartDropping.Name = "btnStartDropping";
            this.btnStartDropping.Size = new System.Drawing.Size(105, 92);
            this.btnStartDropping.TabIndex = 52;
            this.btnStartDropping.Text = "START";
            this.btnStartDropping.UseVisualStyleBackColor = false;
            this.btnStartDropping.Click += new System.EventHandler(this.btnStartDropping_Click_1);
            // 
            // SpeedGraph
            // 
            this.SpeedGraph.Location = new System.Drawing.Point(688, 42);
            this.SpeedGraph.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SpeedGraph.Name = "SpeedGraph";
            this.SpeedGraph.ScrollGrace = 0D;
            this.SpeedGraph.ScrollMaxX = 0D;
            this.SpeedGraph.ScrollMaxY = 0D;
            this.SpeedGraph.ScrollMaxY2 = 0D;
            this.SpeedGraph.ScrollMinX = 0D;
            this.SpeedGraph.ScrollMinY = 0D;
            this.SpeedGraph.ScrollMinY2 = 0D;
            this.SpeedGraph.Size = new System.Drawing.Size(927, 738);
            this.SpeedGraph.TabIndex = 56;
            this.SpeedGraph.UseExtendedPrintDialog = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox1.Controls.Add(this.btnStop);
            this.groupBox1.Controls.Add(this.btnEstop);
            this.groupBox1.Controls.Add(this.btnResetAlarm);
            this.groupBox1.Controls.Add(this.lbServoEnable);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbRunningMode);
            this.groupBox1.Controls.Add(this.toggleServoEnable);
            this.groupBox1.Controls.Add(this.btnStartDropping);
            this.groupBox1.Controls.Add(this.tongleRunningMode);
            this.groupBox1.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(11, 697);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(436, 273);
            this.groupBox1.TabIndex = 58;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General Control";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gulim", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(157, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 19);
            this.label2.TabIndex = 56;
            this.label2.Text = "Running Mode";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbRunningMode
            // 
            this.lbRunningMode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbRunningMode.Font = new System.Drawing.Font("Gulim", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbRunningMode.ForeColor = System.Drawing.Color.Black;
            this.lbRunningMode.Location = new System.Drawing.Point(157, 172);
            this.lbRunningMode.Name = "lbRunningMode";
            this.lbRunningMode.Size = new System.Drawing.Size(137, 33);
            this.lbRunningMode.TabIndex = 56;
            this.lbRunningMode.Text = "Manual";
            this.lbRunningMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.lbAccZ);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.lbPosCmd);
            this.groupBox3.Controls.Add(this.lbPulseCmd);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.lbObjectPosition);
            this.groupBox3.Controls.Add(this.cbDataON);
            this.groupBox3.Controls.Add(this.btnSetHome);
            this.groupBox3.Controls.Add(this.lbEncoderPulses);
            this.groupBox3.Controls.Add(this.lbMotorSpeed);
            this.groupBox3.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox3.ForeColor = System.Drawing.Color.Red;
            this.groupBox3.Location = new System.Drawing.Point(347, 48);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(285, 458);
            this.groupBox3.TabIndex = 59;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Motion Status";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(5, 352);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(142, 20);
            this.label16.TabIndex = 65;
            this.label16.Text = "AccZ (m/s^2)";
            // 
            // lbAccZ
            // 
            this.lbAccZ.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbAccZ.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbAccZ.Font = new System.Drawing.Font("Gulim", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbAccZ.Location = new System.Drawing.Point(149, 323);
            this.lbAccZ.Name = "lbAccZ";
            this.lbAccZ.Size = new System.Drawing.Size(131, 65);
            this.lbAccZ.TabIndex = 64;
            this.lbAccZ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(5, 182);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(126, 20);
            this.label14.TabIndex = 63;
            this.label14.Text = "Speed (rpm)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(5, 48);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(121, 20);
            this.label13.TabIndex = 62;
            this.label13.Text = "Position (m)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(6, 233);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 20);
            this.label10.TabIndex = 61;
            this.label10.Text = "Encoder Pulse";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(5, 117);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(132, 20);
            this.label12.TabIndex = 60;
            this.label12.Text = "Pos Cmd (m)";
            // 
            // lbPosCmd
            // 
            this.lbPosCmd.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbPosCmd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbPosCmd.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbPosCmd.Location = new System.Drawing.Point(163, 102);
            this.lbPosCmd.Name = "lbPosCmd";
            this.lbPosCmd.Size = new System.Drawing.Size(116, 44);
            this.lbPosCmd.TabIndex = 59;
            this.lbPosCmd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbPulseCmd
            // 
            this.lbPulseCmd.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbPulseCmd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbPulseCmd.Location = new System.Drawing.Point(164, 270);
            this.lbPulseCmd.Name = "lbPulseCmd";
            this.lbPulseCmd.Size = new System.Drawing.Size(116, 38);
            this.lbPulseCmd.TabIndex = 58;
            this.lbPulseCmd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(5, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 20);
            this.label6.TabIndex = 57;
            this.label6.Text = "Pulse Cmd";
            // 
            // lbObjectPosition
            // 
            this.lbObjectPosition.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbObjectPosition.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbObjectPosition.Font = new System.Drawing.Font("Gulim", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbObjectPosition.Location = new System.Drawing.Point(149, 27);
            this.lbObjectPosition.Name = "lbObjectPosition";
            this.lbObjectPosition.Size = new System.Drawing.Size(131, 65);
            this.lbObjectPosition.TabIndex = 53;
            this.lbObjectPosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbDataON
            // 
            this.cbDataON.AutoSize = true;
            this.cbDataON.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbDataON.ForeColor = System.Drawing.Color.Black;
            this.cbDataON.Location = new System.Drawing.Point(6, 428);
            this.cbDataON.Name = "cbDataON";
            this.cbDataON.Size = new System.Drawing.Size(159, 24);
            this.cbDataON.TabIndex = 54;
            this.cbDataON.Text = "Data ON/OFF";
            this.cbDataON.UseVisualStyleBackColor = true;
            this.cbDataON.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // gbEpisode
            // 
            this.gbEpisode.Controls.Add(this.label3);
            this.gbEpisode.Controls.Add(this.lbCurrentEpisode);
            this.gbEpisode.Controls.Add(this.txtTotalEpisodes);
            this.gbEpisode.Controls.Add(this.btnSetEpisode);
            this.gbEpisode.Font = new System.Drawing.Font("Gulim", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gbEpisode.ForeColor = System.Drawing.Color.Red;
            this.gbEpisode.Location = new System.Drawing.Point(462, 837);
            this.gbEpisode.Name = "gbEpisode";
            this.gbEpisode.Size = new System.Drawing.Size(195, 127);
            this.gbEpisode.TabIndex = 60;
            this.gbEpisode.TabStop = false;
            this.gbEpisode.Text = "# of Episodes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gulim", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(98, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 19);
            this.label3.TabIndex = 70;
            this.label3.Text = "Done";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbCurrentEpisode
            // 
            this.lbCurrentEpisode.BackColor = System.Drawing.Color.White;
            this.lbCurrentEpisode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbCurrentEpisode.Location = new System.Drawing.Point(9, 83);
            this.lbCurrentEpisode.Name = "lbCurrentEpisode";
            this.lbCurrentEpisode.Size = new System.Drawing.Size(83, 36);
            this.lbCurrentEpisode.TabIndex = 20;
            this.lbCurrentEpisode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTotalEpisodes
            // 
            this.txtTotalEpisodes.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtTotalEpisodes.Location = new System.Drawing.Point(9, 28);
            this.txtTotalEpisodes.Multiline = true;
            this.txtTotalEpisodes.Name = "txtTotalEpisodes";
            this.txtTotalEpisodes.Size = new System.Drawing.Size(83, 36);
            this.txtTotalEpisodes.TabIndex = 10;
            this.txtTotalEpisodes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSetEpisode
            // 
            this.btnSetEpisode.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSetEpisode.ForeColor = System.Drawing.Color.Black;
            this.btnSetEpisode.Location = new System.Drawing.Point(98, 28);
            this.btnSetEpisode.Name = "btnSetEpisode";
            this.btnSetEpisode.Size = new System.Drawing.Size(81, 36);
            this.btnSetEpisode.TabIndex = 28;
            this.btnSetEpisode.Text = "SET";
            this.btnSetEpisode.UseVisualStyleBackColor = true;
            this.btnSetEpisode.Click += new System.EventHandler(this.btnSetEpisode_Click_1);
            // 
            // listData
            // 
            this.listData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Time,
            this.Speed,
            this.RefSpeed,
            this.AccelZ,
            this.listLocalTime});
            this.listData.Font = new System.Drawing.Font("Gulim", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listData.HideSelection = false;
            this.listData.Location = new System.Drawing.Point(1091, 867);
            this.listData.Name = "listData";
            this.listData.Size = new System.Drawing.Size(454, 101);
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
            this.RefSpeed.Width = 125;
            // 
            // AccelZ
            // 
            this.AccelZ.Text = "AccZ";
            // 
            // listLocalTime
            // 
            this.listLocalTime.Text = "LocalTime";
            // 
            // timer2
            // 
            this.timer2.Interval = 50;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick_1);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(688, 742);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(338, 36);
            this.progressBar.TabIndex = 62;
            // 
            // gbDataView
            // 
            this.gbDataView.Controls.Add(this.cbAccZ);
            this.gbDataView.Controls.Add(this.btnSave);
            this.gbDataView.Controls.Add(this.btnResetGraph);
            this.gbDataView.Controls.Add(this.btnScroll);
            this.gbDataView.Controls.Add(this.cbSpeed);
            this.gbDataView.Controls.Add(this.cbSpdCmd);
            this.gbDataView.Controls.Add(this.btnGraphOn);
            this.gbDataView.Font = new System.Drawing.Font("Gulim", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gbDataView.Location = new System.Drawing.Point(688, 786);
            this.gbDataView.Name = "gbDataView";
            this.gbDataView.Size = new System.Drawing.Size(927, 75);
            this.gbDataView.TabIndex = 63;
            this.gbDataView.TabStop = false;
            this.gbDataView.Text = "Data View";
            // 
            // cbAccZ
            // 
            this.cbAccZ.AutoSize = true;
            this.cbAccZ.Font = new System.Drawing.Font("Gulim", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbAccZ.Location = new System.Drawing.Point(287, 39);
            this.cbAccZ.Name = "cbAccZ";
            this.cbAccZ.Size = new System.Drawing.Size(78, 23);
            this.cbAccZ.TabIndex = 35;
            this.cbAccZ.Text = "AccZ";
            this.cbAccZ.UseVisualStyleBackColor = true;
            this.cbAccZ.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(805, 27);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(116, 42);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save Data";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // btnResetGraph
            // 
            this.btnResetGraph.Location = new System.Drawing.Point(683, 27);
            this.btnResetGraph.Name = "btnResetGraph";
            this.btnResetGraph.Size = new System.Drawing.Size(116, 42);
            this.btnResetGraph.TabIndex = 17;
            this.btnResetGraph.Text = "ResetGrap";
            this.btnResetGraph.UseVisualStyleBackColor = true;
            this.btnResetGraph.Click += new System.EventHandler(this.btnResetGraph_Click_1);
            // 
            // btnScroll
            // 
            this.btnScroll.Location = new System.Drawing.Point(561, 27);
            this.btnScroll.Name = "btnScroll";
            this.btnScroll.Size = new System.Drawing.Size(116, 42);
            this.btnScroll.TabIndex = 19;
            this.btnScroll.Text = "COMPACT";
            this.btnScroll.UseVisualStyleBackColor = true;
            this.btnScroll.Click += new System.EventHandler(this.btnScroll_Click_1);
            // 
            // cbSpeed
            // 
            this.cbSpeed.AutoSize = true;
            this.cbSpeed.Font = new System.Drawing.Font("Gulim", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbSpeed.Location = new System.Drawing.Point(6, 39);
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
            this.cbSpdCmd.Location = new System.Drawing.Point(159, 39);
            this.cbSpdCmd.Name = "cbSpdCmd";
            this.cbSpdCmd.Size = new System.Drawing.Size(112, 23);
            this.cbSpdCmd.TabIndex = 34;
            this.cbSpdCmd.Text = "Spd Cmd";
            this.cbSpdCmd.UseVisualStyleBackColor = true;
            this.cbSpdCmd.CheckedChanged += new System.EventHandler(this.cbSpdCmd_CheckedChanged_1);
            // 
            // btnGraphOn
            // 
            this.btnGraphOn.Location = new System.Drawing.Point(439, 27);
            this.btnGraphOn.Name = "btnGraphOn";
            this.btnGraphOn.Size = new System.Drawing.Size(116, 42);
            this.btnGraphOn.TabIndex = 16;
            this.btnGraphOn.Text = "Graph On";
            this.btnGraphOn.UseVisualStyleBackColor = true;
            this.btnGraphOn.Click += new System.EventHandler(this.btnGraphOn_Click);
            // 
            // lb_com_status
            // 
            this.lb_com_status.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_com_status.Location = new System.Drawing.Point(672, 0);
            this.lb_com_status.Name = "lb_com_status";
            this.lb_com_status.Size = new System.Drawing.Size(228, 33);
            this.lb_com_status.TabIndex = 64;
            this.lb_com_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_com_status.Click += new System.EventHandler(this.lb_com_status_Click);
            // 
            // btnRstMcu
            // 
            this.btnRstMcu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnRstMcu.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnRstMcu.Location = new System.Drawing.Point(1561, 941);
            this.btnRstMcu.Name = "btnRstMcu";
            this.btnRstMcu.Size = new System.Drawing.Size(82, 32);
            this.btnRstMcu.TabIndex = 65;
            this.btnRstMcu.Text = "MCU Rst";
            this.btnRstMcu.UseVisualStyleBackColor = false;
            this.btnRstMcu.Click += new System.EventHandler(this.btnRstMcu_Click_1);
            // 
            // rdSpeedMode
            // 
            this.rdSpeedMode.AutoSize = true;
            this.rdSpeedMode.Font = new System.Drawing.Font("Gulim", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rdSpeedMode.Location = new System.Drawing.Point(11, 483);
            this.rdSpeedMode.Name = "rdSpeedMode";
            this.rdSpeedMode.Size = new System.Drawing.Size(143, 23);
            this.rdSpeedMode.TabIndex = 66;
            this.rdSpeedMode.Text = "Speed Mode";
            this.rdSpeedMode.UseVisualStyleBackColor = true;
            this.rdSpeedMode.CheckedChanged += new System.EventHandler(this.rdSpeedMode_CheckedChanged);
            // 
            // rdPositionMode
            // 
            this.rdPositionMode.AutoSize = true;
            this.rdPositionMode.Checked = true;
            this.rdPositionMode.Font = new System.Drawing.Font("Gulim", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rdPositionMode.Location = new System.Drawing.Point(178, 483);
            this.rdPositionMode.Name = "rdPositionMode";
            this.rdPositionMode.Size = new System.Drawing.Size(159, 23);
            this.rdPositionMode.TabIndex = 67;
            this.rdPositionMode.TabStop = true;
            this.rdPositionMode.Text = "Position Mode";
            this.rdPositionMode.UseVisualStyleBackColor = true;
            this.rdPositionMode.CheckedChanged += new System.EventHandler(this.rdPositionMode_CheckedChanged);
            // 
            // lbCmdOut
            // 
            this.lbCmdOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbCmdOut.Font = new System.Drawing.Font("Gulim", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbCmdOut.Location = new System.Drawing.Point(688, 865);
            this.lbCmdOut.Name = "lbCmdOut";
            this.lbCmdOut.Size = new System.Drawing.Size(325, 101);
            this.lbCmdOut.TabIndex = 68;
            this.lbCmdOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbExperimentMode
            // 
            this.cbExperimentMode.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbExperimentMode.FormattingEnabled = true;
            this.cbExperimentMode.Items.AddRange(new object[] {
            "Dropping",
            "Pulling",
            "Pulling->Dropping"});
            this.cbExperimentMode.Location = new System.Drawing.Point(456, 775);
            this.cbExperimentMode.Name = "cbExperimentMode";
            this.cbExperimentMode.Size = new System.Drawing.Size(186, 28);
            this.cbExperimentMode.TabIndex = 69;
            this.cbExperimentMode.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // trackBar_Position
            // 
            this.trackBar_Position.AutoSize = false;
            this.trackBar_Position.BackColor = System.Drawing.SystemColors.ControlLight;
            this.trackBar_Position.Location = new System.Drawing.Point(638, 44);
            this.trackBar_Position.Maximum = 20;
            this.trackBar_Position.Minimum = -150;
            this.trackBar_Position.Name = "trackBar_Position";
            this.trackBar_Position.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar_Position.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBar_Position.Size = new System.Drawing.Size(43, 723);
            this.trackBar_Position.TabIndex = 70;
            this.trackBar_Position.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // cbDriverType
            // 
            this.cbDriverType.Font = new System.Drawing.Font("Gulim", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbDriverType.FormattingEnabled = true;
            this.cbDriverType.Items.AddRange(new object[] {
            "HIGEN - FDA7000 - 15kw",
            "DELTA - ASDA(A3) - 400w"});
            this.cbDriverType.Location = new System.Drawing.Point(14, 40);
            this.cbDriverType.Name = "cbDriverType";
            this.cbDriverType.Size = new System.Drawing.Size(258, 33);
            this.cbDriverType.TabIndex = 71;
            this.cbDriverType.SelectedIndexChanged += new System.EventHandler(this.cbDriverType_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbDriverType);
            this.groupBox4.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox4.ForeColor = System.Drawing.Color.Red;
            this.groupBox4.Location = new System.Drawing.Point(348, 526);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(279, 100);
            this.groupBox4.TabIndex = 72;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Motor Driver";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gulim", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(467, 748);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 19);
            this.label1.TabIndex = 57;
            this.label1.Text = "Experiment Mode";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStop.BackColor = System.Drawing.Color.White;
            this.btnStop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStop.BackgroundImage")));
            this.btnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStop.Font = new System.Drawing.Font("Gulim", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnStop.Location = new System.Drawing.Point(298, 29);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(113, 99);
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
            this.btnEstop.Location = new System.Drawing.Point(6, 137);
            this.btnEstop.Name = "btnEstop";
            this.btnEstop.Size = new System.Drawing.Size(141, 130);
            this.btnEstop.TabIndex = 14;
            this.btnEstop.UseVisualStyleBackColor = false;
            this.btnEstop.Click += new System.EventHandler(this.btnEstop_Click_1);
            // 
            // toggleServoEnable
            // 
            this.toggleServoEnable.Location = new System.Drawing.Point(167, 45);
            this.toggleServoEnable.MinimumSize = new System.Drawing.Size(45, 22);
            this.toggleServoEnable.Name = "toggleServoEnable";
            this.toggleServoEnable.OffBackColor = System.Drawing.Color.Gray;
            this.toggleServoEnable.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.toggleServoEnable.OnBackColor = System.Drawing.Color.Lime;
            this.toggleServoEnable.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.toggleServoEnable.Size = new System.Drawing.Size(111, 47);
            this.toggleServoEnable.TabIndex = 39;
            this.toggleServoEnable.UseVisualStyleBackColor = true;
            this.toggleServoEnable.CheckedChanged += new System.EventHandler(this.toggleServoEnable_CheckedChanged);
            // 
            // tongleRunningMode
            // 
            this.tongleRunningMode.Location = new System.Drawing.Point(165, 212);
            this.tongleRunningMode.MinimumSize = new System.Drawing.Size(45, 22);
            this.tongleRunningMode.Name = "tongleRunningMode";
            this.tongleRunningMode.OffBackColor = System.Drawing.Color.Gray;
            this.tongleRunningMode.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.tongleRunningMode.OnBackColor = System.Drawing.Color.Lime;
            this.tongleRunningMode.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.tongleRunningMode.Size = new System.Drawing.Size(111, 47);
            this.tongleRunningMode.TabIndex = 56;
            this.tongleRunningMode.UseVisualStyleBackColor = true;
            this.tongleRunningMode.CheckedChanged += new System.EventHandler(this.ToggleRunningMode_CheckedChanged);
            // 
            // lbZeroSpeedReach
            // 
            this.lbZeroSpeedReach.AutoEllipsis = true;
            this.lbZeroSpeedReach.BackColor = System.Drawing.Color.Gray;
            this.lbZeroSpeedReach.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbZeroSpeedReach.Location = new System.Drawing.Point(9, 369);
            this.lbZeroSpeedReach.Name = "lbZeroSpeedReach";
            this.lbZeroSpeedReach.Size = new System.Drawing.Size(31, 31);
            this.lbZeroSpeedReach.TabIndex = 20;
            // 
            // lbCwTorqueLimit
            // 
            this.lbCwTorqueLimit.AutoEllipsis = true;
            this.lbCwTorqueLimit.BackColor = System.Drawing.Color.Gray;
            this.lbCwTorqueLimit.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbCwTorqueLimit.Location = new System.Drawing.Point(9, 327);
            this.lbCwTorqueLimit.Name = "lbCwTorqueLimit";
            this.lbCwTorqueLimit.Size = new System.Drawing.Size(31, 31);
            this.lbCwTorqueLimit.TabIndex = 19;
            // 
            // lbCcwTorqueLimit
            // 
            this.lbCcwTorqueLimit.AutoEllipsis = true;
            this.lbCcwTorqueLimit.BackColor = System.Drawing.Color.Gray;
            this.lbCcwTorqueLimit.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbCcwTorqueLimit.Location = new System.Drawing.Point(9, 282);
            this.lbCcwTorqueLimit.Name = "lbCcwTorqueLimit";
            this.lbCcwTorqueLimit.Size = new System.Drawing.Size(31, 31);
            this.lbCcwTorqueLimit.TabIndex = 18;
            // 
            // lbAlarm
            // 
            this.lbAlarm.AutoEllipsis = true;
            this.lbAlarm.BackColor = System.Drawing.Color.Gray;
            this.lbAlarm.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbAlarm.Location = new System.Drawing.Point(9, 237);
            this.lbAlarm.Name = "lbAlarm";
            this.lbAlarm.Size = new System.Drawing.Size(31, 31);
            this.lbAlarm.TabIndex = 17;
            // 
            // lbTorqueLimit
            // 
            this.lbTorqueLimit.AutoEllipsis = true;
            this.lbTorqueLimit.BackColor = System.Drawing.Color.Gray;
            this.lbTorqueLimit.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbTorqueLimit.Location = new System.Drawing.Point(9, 195);
            this.lbTorqueLimit.Name = "lbTorqueLimit";
            this.lbTorqueLimit.Size = new System.Drawing.Size(31, 31);
            this.lbTorqueLimit.TabIndex = 16;
            // 
            // lbSpeedReach
            // 
            this.lbSpeedReach.AutoEllipsis = true;
            this.lbSpeedReach.BackColor = System.Drawing.Color.Gray;
            this.lbSpeedReach.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbSpeedReach.Location = new System.Drawing.Point(9, 154);
            this.lbSpeedReach.Name = "lbSpeedReach";
            this.lbSpeedReach.Size = new System.Drawing.Size(31, 31);
            this.lbSpeedReach.TabIndex = 15;
            // 
            // lbReady
            // 
            this.lbReady.AutoEllipsis = true;
            this.lbReady.BackColor = System.Drawing.Color.Gray;
            this.lbReady.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbReady.Location = new System.Drawing.Point(9, 113);
            this.lbReady.Name = "lbReady";
            this.lbReady.Size = new System.Drawing.Size(31, 31);
            this.lbReady.TabIndex = 14;
            // 
            // lbBrake
            // 
            this.lbBrake.AutoEllipsis = true;
            this.lbBrake.BackColor = System.Drawing.Color.Gray;
            this.lbBrake.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbBrake.Location = new System.Drawing.Point(9, 69);
            this.lbBrake.Name = "lbBrake";
            this.lbBrake.Size = new System.Drawing.Size(31, 31);
            this.lbBrake.TabIndex = 13;
            // 
            // lb_Type
            // 
            this.lb_Type.AutoEllipsis = true;
            this.lb_Type.BackColor = System.Drawing.Color.Gray;
            this.lb_Type.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lb_Type.Location = new System.Drawing.Point(9, 26);
            this.lb_Type.Name = "lb_Type";
            this.lb_Type.Size = new System.Drawing.Size(31, 31);
            this.lb_Type.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1643, 975);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.trackBar_Position);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbExperimentMode);
            this.Controls.Add(this.lbCmdOut);
            this.Controls.Add(this.rdPositionMode);
            this.Controls.Add(this.rdSpeedMode);
            this.Controls.Add(this.btnRstMcu);
            this.Controls.Add(this.lb_com_status);
            this.Controls.Add(this.gbDataView);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.listData);
            this.Controls.Add(this.gbEpisode);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SpeedGraph);
            this.Controls.Add(this.gbJogControl);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "FreeFall_GUI";
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
            this.gbEpisode.ResumeLayout(false);
            this.gbEpisode.PerformLayout();
            this.gbDataView.ResumeLayout(false);
            this.gbDataView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Position)).EndInit();
            this.groupBox4.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnSetHome;
        private System.Windows.Forms.Label lbEncoderPulses;
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
        private System.Windows.Forms.ToolStripMenuItem pulseTestToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbEpisode;
        private System.Windows.Forms.Label lbCurrentEpisode;
        private System.Windows.Forms.TextBox txtTotalEpisodes;
        private System.Windows.Forms.Button btnSetEpisode;
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
        private RJControls.RJToggleButton tongleRunningMode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbRunningMode;
        private System.Windows.Forms.CheckBox cbDataON;
        private System.Windows.Forms.FolderBrowserDialog FolderToSaveDiag;
        private System.Windows.Forms.RadioButton rdSpeedMode;
        private System.Windows.Forms.RadioButton rdPositionMode;
        private System.Windows.Forms.Label lbCmdOut;
        private System.Windows.Forms.ComboBox cbExperimentMode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbPulseCmd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbPosCmd;
        private System.Windows.Forms.TrackBar trackBar_Position;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolStripMenuItem driverInputControlToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbDriverType;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lbAccZ;
        private System.Windows.Forms.CheckBox cbAccZ;
        private System.Windows.Forms.ColumnHeader AccelZ;
        private System.Windows.Forms.ColumnHeader listLocalTime;
        private System.Windows.Forms.Label label1;
    }
}

