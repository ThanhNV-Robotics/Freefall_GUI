namespace FreeFall_GUI
{
    partial class Main_Control
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Control));
            this.SpeedGraph = new ZedGraph.ZedGraphControl();
            this.btnMoveUp = new System.Windows.Forms.Button();
            this.btnMoveDown = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnResetAlarm = new System.Windows.Forms.Button();
            this.gbJogControl = new System.Windows.Forms.GroupBox();
            this.btnSetHome = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.lbEncoderPulses = new System.Windows.Forms.Label();
            this.lbPosition = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnSetJogSpeed = new System.Windows.Forms.Button();
            this.txtSetSpeed = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbMotorSpeed = new System.Windows.Forms.Label();
            this.btnScroll = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnResetGraph = new System.Windows.Forms.Button();
            this.btnGraphOn = new System.Windows.Forms.Button();
            this.btnStartDropping = new System.Windows.Forms.Button();
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.toggleControlMode = new FreeFall_GUI.RJControls.RJToggleButton();
            this.label13 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtTotalEpisodes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSetEpisode = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbCurrentEpisode = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listData = new System.Windows.Forms.ListView();
            this.Time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Speed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AccX = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AccY = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AccZ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lbPort = new System.Windows.Forms.Label();
            this.lbIP = new System.Windows.Forms.Label();
            this.lbAccel = new System.Windows.Forms.Label();
            this.cbServerOn = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cbSpeed = new System.Windows.Forms.CheckBox();
            this.cbSpdCmd = new System.Windows.Forms.CheckBox();
            this.gbDataView = new System.Windows.Forms.GroupBox();
            this.cbAccZ = new System.Windows.Forms.CheckBox();
            this.cbAccY = new System.Windows.Forms.CheckBox();
            this.cbAccX = new System.Windows.Forms.CheckBox();
            this.btnRstMcu = new System.Windows.Forms.Button();
            this.lbServoEnable = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toglPR = new FreeFall_GUI.RJControls.RJToggleButton();
            this.toglPF = new FreeFall_GUI.RJControls.RJToggleButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.togleDIR = new FreeFall_GUI.RJControls.RJToggleButton();
            this.toglePLSCLR = new FreeFall_GUI.RJControls.RJToggleButton();
            this.togleSPLIM = new FreeFall_GUI.RJControls.RJToggleButton();
            this.togleCCWLIM = new FreeFall_GUI.RJControls.RJToggleButton();
            this.togleCWLIM = new FreeFall_GUI.RJControls.RJToggleButton();
            this.toglePLSINH = new FreeFall_GUI.RJControls.RJToggleButton();
            this.label20 = new System.Windows.Forms.Label();
            this.btnStartPulling = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.toggleServoEnable = new FreeFall_GUI.RJControls.RJToggleButton();
            this.btnEstop = new FreeFall_GUI.ButtonEllipse();
            this.gbJogControl.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.gbDataView.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // SpeedGraph
            // 
            this.SpeedGraph.Location = new System.Drawing.Point(407, 30);
            this.SpeedGraph.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SpeedGraph.Name = "SpeedGraph";
            this.SpeedGraph.ScrollGrace = 0D;
            this.SpeedGraph.ScrollMaxX = 0D;
            this.SpeedGraph.ScrollMaxY = 0D;
            this.SpeedGraph.ScrollMaxY2 = 0D;
            this.SpeedGraph.ScrollMinX = 0D;
            this.SpeedGraph.ScrollMinY = 0D;
            this.SpeedGraph.ScrollMinY2 = 0D;
            this.SpeedGraph.Size = new System.Drawing.Size(1106, 798);
            this.SpeedGraph.TabIndex = 2;
            this.SpeedGraph.UseExtendedPrintDialog = true;
            // 
            // btnMoveUp
            // 
            this.btnMoveUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnMoveUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMoveUp.BackgroundImage")));
            this.btnMoveUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMoveUp.Font = new System.Drawing.Font("Gulim", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnMoveUp.Location = new System.Drawing.Point(313, 15);
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.Size = new System.Drawing.Size(63, 78);
            this.btnMoveUp.TabIndex = 4;
            this.btnMoveUp.UseVisualStyleBackColor = false;
            this.btnMoveUp.Click += new System.EventHandler(this.btnMoveUp_Click);
            this.btnMoveUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnMoveUp_MouseDown);
            this.btnMoveUp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnMoveUp_MouseUp);
            // 
            // btnMoveDown
            // 
            this.btnMoveDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnMoveDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMoveDown.BackgroundImage")));
            this.btnMoveDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMoveDown.Font = new System.Drawing.Font("Gulim", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnMoveDown.Location = new System.Drawing.Point(313, 99);
            this.btnMoveDown.Name = "btnMoveDown";
            this.btnMoveDown.Size = new System.Drawing.Size(63, 78);
            this.btnMoveDown.TabIndex = 5;
            this.btnMoveDown.UseVisualStyleBackColor = false;
            this.btnMoveDown.Click += new System.EventHandler(this.btnMoveDown_Click);
            this.btnMoveDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnMoveDown_MouseDown);
            this.btnMoveDown.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnMoveDown_MouseUp);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnStop.Font = new System.Drawing.Font("Gulim", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnStop.Location = new System.Drawing.Point(299, 729);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(101, 85);
            this.btnStop.TabIndex = 6;
            this.btnStop.Text = "STOP";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnResetAlarm
            // 
            this.btnResetAlarm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnResetAlarm.Font = new System.Drawing.Font("Gulim", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnResetAlarm.Location = new System.Drawing.Point(4, 730);
            this.btnResetAlarm.Name = "btnResetAlarm";
            this.btnResetAlarm.Size = new System.Drawing.Size(136, 74);
            this.btnResetAlarm.TabIndex = 7;
            this.btnResetAlarm.Text = "Arm Reset";
            this.btnResetAlarm.UseVisualStyleBackColor = false;
            this.btnResetAlarm.Click += new System.EventHandler(this.btnResetAlarm_Click);
            // 
            // gbJogControl
            // 
            this.gbJogControl.Controls.Add(this.btnSetHome);
            this.gbJogControl.Controls.Add(this.label25);
            this.gbJogControl.Controls.Add(this.lbEncoderPulses);
            this.gbJogControl.Controls.Add(this.lbPosition);
            this.gbJogControl.Controls.Add(this.label12);
            this.gbJogControl.Controls.Add(this.btnSetJogSpeed);
            this.gbJogControl.Controls.Add(this.txtSetSpeed);
            this.gbJogControl.Controls.Add(this.label5);
            this.gbJogControl.Controls.Add(this.label3);
            this.gbJogControl.Controls.Add(this.lbMotorSpeed);
            this.gbJogControl.Controls.Add(this.btnMoveDown);
            this.gbJogControl.Controls.Add(this.btnMoveUp);
            this.gbJogControl.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gbJogControl.ForeColor = System.Drawing.Color.Red;
            this.gbJogControl.Location = new System.Drawing.Point(12, 528);
            this.gbJogControl.Name = "gbJogControl";
            this.gbJogControl.Size = new System.Drawing.Size(382, 186);
            this.gbJogControl.TabIndex = 8;
            this.gbJogControl.TabStop = false;
            this.gbJogControl.Text = "JOG Control";
            // 
            // btnSetHome
            // 
            this.btnSetHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSetHome.Font = new System.Drawing.Font("Gulim", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSetHome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSetHome.Location = new System.Drawing.Point(204, 78);
            this.btnSetHome.Name = "btnSetHome";
            this.btnSetHome.Size = new System.Drawing.Size(100, 30);
            this.btnSetHome.TabIndex = 53;
            this.btnSetHome.Text = "Set Home";
            this.btnSetHome.UseVisualStyleBackColor = false;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Gulim", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label25.ForeColor = System.Drawing.Color.Red;
            this.label25.Location = new System.Drawing.Point(201, 111);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(109, 17);
            this.label25.TabIndex = 52;
            this.label25.Text = "Position (m)";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbEncoderPulses
            // 
            this.lbEncoderPulses.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbEncoderPulses.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbEncoderPulses.Location = new System.Drawing.Point(77, 140);
            this.lbEncoderPulses.Name = "lbEncoderPulses";
            this.lbEncoderPulses.Size = new System.Drawing.Size(111, 36);
            this.lbEncoderPulses.TabIndex = 17;
            this.lbEncoderPulses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbPosition
            // 
            this.lbPosition.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPosition.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbPosition.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbPosition.Font = new System.Drawing.Font("Gulim", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbPosition.Location = new System.Drawing.Point(204, 131);
            this.lbPosition.Name = "lbPosition";
            this.lbPosition.Size = new System.Drawing.Size(103, 46);
            this.lbPosition.TabIndex = 17;
            this.lbPosition.Text = "100";
            this.lbPosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(5, 143);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 32);
            this.label12.TabIndex = 16;
            this.label12.Text = "Encoder Pulses";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.btnSetJogSpeed.Click += new System.EventHandler(this.button1_Click);
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
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(7, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 32);
            this.label3.TabIndex = 12;
            this.label3.Text = "Speed \r\n(rpm)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbMotorSpeed
            // 
            this.lbMotorSpeed.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbMotorSpeed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbMotorSpeed.Location = new System.Drawing.Point(87, 84);
            this.lbMotorSpeed.Name = "lbMotorSpeed";
            this.lbMotorSpeed.Size = new System.Drawing.Size(79, 36);
            this.lbMotorSpeed.TabIndex = 11;
            this.lbMotorSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnScroll
            // 
            this.btnScroll.Location = new System.Drawing.Point(6, 295);
            this.btnScroll.Name = "btnScroll";
            this.btnScroll.Size = new System.Drawing.Size(116, 42);
            this.btnScroll.TabIndex = 19;
            this.btnScroll.Text = "SCROLL";
            this.btnScroll.UseVisualStyleBackColor = true;
            this.btnScroll.Click += new System.EventHandler(this.btnScroll_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(6, 421);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(116, 42);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save Data";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnResetGraph
            // 
            this.btnResetGraph.Location = new System.Drawing.Point(6, 354);
            this.btnResetGraph.Name = "btnResetGraph";
            this.btnResetGraph.Size = new System.Drawing.Size(116, 42);
            this.btnResetGraph.TabIndex = 17;
            this.btnResetGraph.Text = "ResetGrap";
            this.btnResetGraph.UseVisualStyleBackColor = true;
            this.btnResetGraph.Click += new System.EventHandler(this.btnResetGraph_Click);
            // 
            // btnGraphOn
            // 
            this.btnGraphOn.Location = new System.Drawing.Point(6, 236);
            this.btnGraphOn.Name = "btnGraphOn";
            this.btnGraphOn.Size = new System.Drawing.Size(116, 42);
            this.btnGraphOn.TabIndex = 16;
            this.btnGraphOn.Text = "Graph On";
            this.btnGraphOn.UseVisualStyleBackColor = true;
            this.btnGraphOn.Click += new System.EventHandler(this.btnGraphOn_Click);
            // 
            // btnStartDropping
            // 
            this.btnStartDropping.BackColor = System.Drawing.Color.Lime;
            this.btnStartDropping.BackgroundImage = global::FreeFall_GUI.Properties.Resources.Down_Arrow;
            this.btnStartDropping.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStartDropping.Font = new System.Drawing.Font("Gulim", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnStartDropping.Location = new System.Drawing.Point(160, 830);
            this.btnStartDropping.Name = "btnStartDropping";
            this.btnStartDropping.Size = new System.Drawing.Size(99, 92);
            this.btnStartDropping.TabIndex = 8;
            this.btnStartDropping.UseVisualStyleBackColor = false;
            this.btnStartDropping.Click += new System.EventHandler(this.btnStartDropping_Click);
            // 
            // groupBox2
            // 
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
            this.groupBox2.Location = new System.Drawing.Point(12, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(382, 411);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Driver Output";
            // 
            // cbReadOutputs
            // 
            this.cbReadOutputs.AutoSize = true;
            this.cbReadOutputs.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbReadOutputs.Location = new System.Drawing.Point(204, 33);
            this.cbReadOutputs.Name = "cbReadOutputs";
            this.cbReadOutputs.Size = new System.Drawing.Size(161, 24);
            this.cbReadOutputs.TabIndex = 26;
            this.cbReadOutputs.Text = "Read Outputs";
            this.cbReadOutputs.UseVisualStyleBackColor = true;
            this.cbReadOutputs.CheckedChanged += new System.EventHandler(this.cbReadOutputs_CheckedChanged);
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
            this.lbReady.BackColorChanged += new System.EventHandler(this.lbReady_BackColorChanged);
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.toggleControlMode);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox3.ForeColor = System.Drawing.Color.Red;
            this.groupBox3.Location = new System.Drawing.Point(12, 451);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(382, 67);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Control Mode";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Gulim", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label14.Location = new System.Drawing.Point(234, 32);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(138, 19);
            this.label14.TabIndex = 43;
            this.label14.Text = "Position Mode";
            // 
            // toggleControlMode
            // 
            this.toggleControlMode.Checked = true;
            this.toggleControlMode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toggleControlMode.Location = new System.Drawing.Point(135, 25);
            this.toggleControlMode.MinimumSize = new System.Drawing.Size(45, 22);
            this.toggleControlMode.Name = "toggleControlMode";
            this.toggleControlMode.OffBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.toggleControlMode.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.toggleControlMode.OnBackColor = System.Drawing.Color.CornflowerBlue;
            this.toggleControlMode.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.toggleControlMode.Size = new System.Drawing.Size(93, 36);
            this.toggleControlMode.TabIndex = 41;
            this.toggleControlMode.UseVisualStyleBackColor = true;
            this.toggleControlMode.CheckedChanged += new System.EventHandler(this.toggleControlMode_CheckedChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Gulim", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label13.Location = new System.Drawing.Point(6, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(122, 19);
            this.label13.TabIndex = 42;
            this.label13.Text = "Speed Mode";
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtTotalEpisodes
            // 
            this.txtTotalEpisodes.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtTotalEpisodes.Location = new System.Drawing.Point(26, 54);
            this.txtTotalEpisodes.Multiline = true;
            this.txtTotalEpisodes.Name = "txtTotalEpisodes";
            this.txtTotalEpisodes.Size = new System.Drawing.Size(83, 36);
            this.txtTotalEpisodes.TabIndex = 10;
            this.txtTotalEpisodes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(64, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Setting";
            // 
            // btnSetEpisode
            // 
            this.btnSetEpisode.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSetEpisode.Location = new System.Drawing.Point(125, 54);
            this.btnSetEpisode.Name = "btnSetEpisode";
            this.btnSetEpisode.Size = new System.Drawing.Size(89, 36);
            this.btnSetEpisode.TabIndex = 28;
            this.btnSetEpisode.Text = "SET";
            this.btnSetEpisode.UseVisualStyleBackColor = true;
            this.btnSetEpisode.Click += new System.EventHandler(this.btnSetEpisode_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(1133, 778);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(338, 36);
            this.progressBar.TabIndex = 29;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbCurrentEpisode);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.txtTotalEpisodes);
            this.groupBox4.Controls.Add(this.btnSetEpisode);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Font = new System.Drawing.Font("Gulim", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox4.Location = new System.Drawing.Point(429, 842);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(337, 98);
            this.groupBox4.TabIndex = 31;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Number of Episodes";
            // 
            // lbCurrentEpisode
            // 
            this.lbCurrentEpisode.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbCurrentEpisode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbCurrentEpisode.Location = new System.Drawing.Point(239, 54);
            this.lbCurrentEpisode.Name = "lbCurrentEpisode";
            this.lbCurrentEpisode.Size = new System.Drawing.Size(79, 36);
            this.lbCurrentEpisode.TabIndex = 20;
            this.lbCurrentEpisode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(221, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 20);
            this.label6.TabIndex = 29;
            this.label6.Text = "Completed";
            // 
            // listData
            // 
            this.listData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Time,
            this.Speed,
            this.AccX,
            this.AccY,
            this.AccZ});
            this.listData.Font = new System.Drawing.Font("Gulim", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listData.HideSelection = false;
            this.listData.Location = new System.Drawing.Point(1180, 842);
            this.listData.Name = "listData";
            this.listData.Size = new System.Drawing.Size(333, 111);
            this.listData.TabIndex = 32;
            this.listData.UseCompatibleStateImageBehavior = false;
            this.listData.View = System.Windows.Forms.View.Details;
            // 
            // Time
            // 
            this.Time.Text = "time (s)";
            this.Time.Width = 99;
            // 
            // Speed
            // 
            this.Speed.Text = "Spd (rpm)";
            this.Speed.Width = 122;
            // 
            // AccX
            // 
            this.AccX.Text = "AccX (m/s2)";
            this.AccX.Width = 124;
            // 
            // AccY
            // 
            this.AccY.Text = "AccY";
            // 
            // AccZ
            // 
            this.AccZ.Text = "AccZ";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lbPort);
            this.groupBox5.Controls.Add(this.lbIP);
            this.groupBox5.Controls.Add(this.lbAccel);
            this.groupBox5.Controls.Add(this.cbServerOn);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Font = new System.Drawing.Font("Gulim", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox5.Location = new System.Drawing.Point(772, 842);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(402, 111);
            this.groupBox5.TabIndex = 32;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Accelerometer Communication";
            // 
            // lbPort
            // 
            this.lbPort.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbPort.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbPort.Location = new System.Drawing.Point(285, 23);
            this.lbPort.Name = "lbPort";
            this.lbPort.Size = new System.Drawing.Size(111, 34);
            this.lbPort.TabIndex = 33;
            this.lbPort.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbIP
            // 
            this.lbIP.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbIP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbIP.Location = new System.Drawing.Point(37, 25);
            this.lbIP.Name = "lbIP";
            this.lbIP.Size = new System.Drawing.Size(175, 32);
            this.lbIP.TabIndex = 32;
            this.lbIP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbAccel
            // 
            this.lbAccel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbAccel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbAccel.Location = new System.Drawing.Point(285, 66);
            this.lbAccel.Name = "lbAccel";
            this.lbAccel.Size = new System.Drawing.Size(111, 39);
            this.lbAccel.TabIndex = 30;
            this.lbAccel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbServerOn
            // 
            this.cbServerOn.AutoSize = true;
            this.cbServerOn.Location = new System.Drawing.Point(10, 82);
            this.cbServerOn.Name = "cbServerOn";
            this.cbServerOn.Size = new System.Drawing.Size(124, 23);
            this.cbServerOn.TabIndex = 27;
            this.cbServerOn.Text = "Server ON";
            this.cbServerOn.UseVisualStyleBackColor = true;
            this.cbServerOn.CheckedChanged += new System.EventHandler(this.cbServerOn_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(233, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 19);
            this.label10.TabIndex = 30;
            this.label10.Text = "Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 19);
            this.label2.TabIndex = 29;
            this.label2.Text = "IP";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
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
            this.cbSpeed.CheckedChanged += new System.EventHandler(this.cbSpeed_CheckedChanged);
            // 
            // cbSpdCmd
            // 
            this.cbSpdCmd.AutoSize = true;
            this.cbSpdCmd.Font = new System.Drawing.Font("Gulim", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbSpdCmd.Location = new System.Drawing.Point(6, 77);
            this.cbSpdCmd.Name = "cbSpdCmd";
            this.cbSpdCmd.Size = new System.Drawing.Size(162, 23);
            this.cbSpdCmd.TabIndex = 34;
            this.cbSpdCmd.Text = "Spd Command";
            this.cbSpdCmd.UseVisualStyleBackColor = true;
            this.cbSpdCmd.CheckedChanged += new System.EventHandler(this.cbSpdCmd_CheckedChanged);
            // 
            // gbDataView
            // 
            this.gbDataView.Controls.Add(this.cbAccZ);
            this.gbDataView.Controls.Add(this.btnSave);
            this.gbDataView.Controls.Add(this.cbAccY);
            this.gbDataView.Controls.Add(this.btnResetGraph);
            this.gbDataView.Controls.Add(this.btnScroll);
            this.gbDataView.Controls.Add(this.cbAccX);
            this.gbDataView.Controls.Add(this.cbSpeed);
            this.gbDataView.Controls.Add(this.cbSpdCmd);
            this.gbDataView.Controls.Add(this.btnGraphOn);
            this.gbDataView.Font = new System.Drawing.Font("Gulim", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gbDataView.Location = new System.Drawing.Point(1522, 30);
            this.gbDataView.Name = "gbDataView";
            this.gbDataView.Size = new System.Drawing.Size(173, 469);
            this.gbDataView.TabIndex = 35;
            this.gbDataView.TabStop = false;
            this.gbDataView.Text = "Data View";
            // 
            // cbAccZ
            // 
            this.cbAccZ.AutoSize = true;
            this.cbAccZ.Font = new System.Drawing.Font("Gulim", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbAccZ.Location = new System.Drawing.Point(6, 196);
            this.cbAccZ.Name = "cbAccZ";
            this.cbAccZ.Size = new System.Drawing.Size(78, 23);
            this.cbAccZ.TabIndex = 37;
            this.cbAccZ.Text = "AccZ";
            this.cbAccZ.UseVisualStyleBackColor = true;
            this.cbAccZ.CheckedChanged += new System.EventHandler(this.cbAccZ_CheckedChanged);
            // 
            // cbAccY
            // 
            this.cbAccY.AutoSize = true;
            this.cbAccY.Font = new System.Drawing.Font("Gulim", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbAccY.Location = new System.Drawing.Point(6, 154);
            this.cbAccY.Name = "cbAccY";
            this.cbAccY.Size = new System.Drawing.Size(78, 23);
            this.cbAccY.TabIndex = 36;
            this.cbAccY.Text = "AccY";
            this.cbAccY.UseVisualStyleBackColor = true;
            this.cbAccY.CheckedChanged += new System.EventHandler(this.cbAccY_CheckedChanged);
            // 
            // cbAccX
            // 
            this.cbAccX.AutoSize = true;
            this.cbAccX.Font = new System.Drawing.Font("Gulim", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbAccX.Location = new System.Drawing.Point(6, 115);
            this.cbAccX.Name = "cbAccX";
            this.cbAccX.Size = new System.Drawing.Size(78, 23);
            this.cbAccX.TabIndex = 35;
            this.cbAccX.Text = "AccX";
            this.cbAccX.UseVisualStyleBackColor = true;
            this.cbAccX.CheckedChanged += new System.EventHandler(this.cbAccX_CheckedChanged);
            // 
            // btnRstMcu
            // 
            this.btnRstMcu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnRstMcu.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnRstMcu.Location = new System.Drawing.Point(1621, 924);
            this.btnRstMcu.Name = "btnRstMcu";
            this.btnRstMcu.Size = new System.Drawing.Size(82, 32);
            this.btnRstMcu.TabIndex = 37;
            this.btnRstMcu.Text = "MCU Rst";
            this.btnRstMcu.UseVisualStyleBackColor = false;
            this.btnRstMcu.Click += new System.EventHandler(this.btnRstMcu_Click);
            // 
            // lbServoEnable
            // 
            this.lbServoEnable.AutoSize = true;
            this.lbServoEnable.Font = new System.Drawing.Font("Gulim", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbServoEnable.Location = new System.Drawing.Point(146, 785);
            this.lbServoEnable.Name = "lbServoEnable";
            this.lbServoEnable.Size = new System.Drawing.Size(139, 19);
            this.lbServoEnable.TabIndex = 39;
            this.lbServoEnable.Text = "Servo OFF/ON";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Gulim", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label15.Location = new System.Drawing.Point(13, 23);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 19);
            this.label15.TabIndex = 41;
            this.label15.Text = "PE9-PF";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Gulim", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label16.Location = new System.Drawing.Point(13, 55);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(79, 19);
            this.label16.TabIndex = 42;
            this.label16.Text = "PC8-PR";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Gulim", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label17.Location = new System.Drawing.Point(15, 28);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(78, 19);
            this.label17.TabIndex = 45;
            this.label17.Text = "PLSCLR";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Gulim", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label18.Location = new System.Drawing.Point(5, 72);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(90, 19);
            this.label18.TabIndex = 45;
            this.label18.Text = "SP/T LIM";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Gulim", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label19.Location = new System.Drawing.Point(23, 110);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(72, 19);
            this.label19.TabIndex = 45;
            this.label19.Text = "PLSINH";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Gulim", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label21.Location = new System.Drawing.Point(26, 154);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(68, 19);
            this.label21.TabIndex = 45;
            this.label21.Text = "CWLIM";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Gulim", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label22.Location = new System.Drawing.Point(13, 199);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(81, 19);
            this.label22.TabIndex = 45;
            this.label22.Text = "CCWLIM";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.toglPR);
            this.groupBox1.Controls.Add(this.toglPF);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Location = new System.Drawing.Point(1522, 505);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(181, 89);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pulse Test";
            // 
            // toglPR
            // 
            this.toglPR.Location = new System.Drawing.Point(105, 53);
            this.toglPR.MinimumSize = new System.Drawing.Size(45, 22);
            this.toglPR.Name = "toglPR";
            this.toglPR.OffBackColor = System.Drawing.Color.Gray;
            this.toglPR.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.toglPR.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.toglPR.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.toglPR.Size = new System.Drawing.Size(68, 24);
            this.toglPR.TabIndex = 43;
            this.toglPR.UseVisualStyleBackColor = true;
            this.toglPR.CheckedChanged += new System.EventHandler(this.toglPR_CheckedChanged);
            // 
            // toglPF
            // 
            this.toglPF.Location = new System.Drawing.Point(105, 21);
            this.toglPF.MinimumSize = new System.Drawing.Size(45, 22);
            this.toglPF.Name = "toglPF";
            this.toglPF.OffBackColor = System.Drawing.Color.Gray;
            this.toglPF.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.toglPF.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.toglPF.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.toglPF.Size = new System.Drawing.Size(68, 24);
            this.toglPF.TabIndex = 40;
            this.toglPF.UseVisualStyleBackColor = true;
            this.toglPF.CheckedChanged += new System.EventHandler(this.toglPF_CheckedChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.togleDIR);
            this.groupBox6.Controls.Add(this.toglePLSCLR);
            this.groupBox6.Controls.Add(this.togleSPLIM);
            this.groupBox6.Controls.Add(this.togleCCWLIM);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Controls.Add(this.togleCWLIM);
            this.groupBox6.Controls.Add(this.label18);
            this.groupBox6.Controls.Add(this.label19);
            this.groupBox6.Controls.Add(this.toglePLSINH);
            this.groupBox6.Controls.Add(this.label20);
            this.groupBox6.Controls.Add(this.label22);
            this.groupBox6.Controls.Add(this.label21);
            this.groupBox6.Location = new System.Drawing.Point(1522, 601);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(181, 284);
            this.groupBox6.TabIndex = 48;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Driver Input Control";
            // 
            // togleDIR
            // 
            this.togleDIR.Location = new System.Drawing.Point(106, 244);
            this.togleDIR.MinimumSize = new System.Drawing.Size(45, 22);
            this.togleDIR.Name = "togleDIR";
            this.togleDIR.OffBackColor = System.Drawing.Color.Gray;
            this.togleDIR.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.togleDIR.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.togleDIR.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.togleDIR.Size = new System.Drawing.Size(66, 22);
            this.togleDIR.TabIndex = 47;
            this.togleDIR.UseVisualStyleBackColor = true;
            this.togleDIR.CheckedChanged += new System.EventHandler(this.rjToggleButton1_CheckedChanged_1);
            // 
            // toglePLSCLR
            // 
            this.toglePLSCLR.Location = new System.Drawing.Point(104, 24);
            this.toglePLSCLR.MinimumSize = new System.Drawing.Size(45, 22);
            this.toglePLSCLR.Name = "toglePLSCLR";
            this.toglePLSCLR.OffBackColor = System.Drawing.Color.Gray;
            this.toglePLSCLR.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.toglePLSCLR.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.toglePLSCLR.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.toglePLSCLR.Size = new System.Drawing.Size(68, 24);
            this.toglePLSCLR.TabIndex = 44;
            this.toglePLSCLR.UseVisualStyleBackColor = true;
            this.toglePLSCLR.CheckedChanged += new System.EventHandler(this.toglePLSCLR_CheckedChanged);
            // 
            // togleSPLIM
            // 
            this.togleSPLIM.Location = new System.Drawing.Point(105, 69);
            this.togleSPLIM.MinimumSize = new System.Drawing.Size(45, 22);
            this.togleSPLIM.Name = "togleSPLIM";
            this.togleSPLIM.OffBackColor = System.Drawing.Color.Gray;
            this.togleSPLIM.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.togleSPLIM.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.togleSPLIM.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.togleSPLIM.Size = new System.Drawing.Size(68, 24);
            this.togleSPLIM.TabIndex = 44;
            this.togleSPLIM.UseVisualStyleBackColor = true;
            this.togleSPLIM.CheckedChanged += new System.EventHandler(this.togleSPLIM_CheckedChanged);
            // 
            // togleCCWLIM
            // 
            this.togleCCWLIM.Location = new System.Drawing.Point(104, 197);
            this.togleCCWLIM.MinimumSize = new System.Drawing.Size(45, 22);
            this.togleCCWLIM.Name = "togleCCWLIM";
            this.togleCCWLIM.OffBackColor = System.Drawing.Color.Gray;
            this.togleCCWLIM.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.togleCCWLIM.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.togleCCWLIM.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.togleCCWLIM.Size = new System.Drawing.Size(68, 24);
            this.togleCCWLIM.TabIndex = 46;
            this.togleCCWLIM.UseVisualStyleBackColor = true;
            this.togleCCWLIM.CheckedChanged += new System.EventHandler(this.togleCCWLIM_CheckedChanged);
            // 
            // togleCWLIM
            // 
            this.togleCWLIM.Location = new System.Drawing.Point(105, 152);
            this.togleCWLIM.MinimumSize = new System.Drawing.Size(45, 22);
            this.togleCWLIM.Name = "togleCWLIM";
            this.togleCWLIM.OffBackColor = System.Drawing.Color.Gray;
            this.togleCWLIM.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.togleCWLIM.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.togleCWLIM.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.togleCWLIM.Size = new System.Drawing.Size(68, 24);
            this.togleCWLIM.TabIndex = 46;
            this.togleCWLIM.UseVisualStyleBackColor = true;
            this.togleCWLIM.CheckedChanged += new System.EventHandler(this.togleCWLIM_CheckedChanged);
            // 
            // toglePLSINH
            // 
            this.toglePLSINH.Location = new System.Drawing.Point(105, 110);
            this.toglePLSINH.MinimumSize = new System.Drawing.Size(45, 22);
            this.toglePLSINH.Name = "toglePLSINH";
            this.toglePLSINH.OffBackColor = System.Drawing.Color.Gray;
            this.toglePLSINH.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.toglePLSINH.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.toglePLSINH.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.toglePLSINH.Size = new System.Drawing.Size(68, 24);
            this.toglePLSINH.TabIndex = 46;
            this.toglePLSINH.UseVisualStyleBackColor = true;
            this.toglePLSINH.CheckedChanged += new System.EventHandler(this.toglePLSINH_CheckedChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Gulim", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label20.Location = new System.Drawing.Point(55, 246);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(37, 19);
            this.label20.TabIndex = 45;
            this.label20.Text = "DIR";
            // 
            // btnStartPulling
            // 
            this.btnStartPulling.BackColor = System.Drawing.Color.Lime;
            this.btnStartPulling.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStartPulling.BackgroundImage")));
            this.btnStartPulling.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStartPulling.Font = new System.Drawing.Font("Gulim", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnStartPulling.Location = new System.Drawing.Point(297, 830);
            this.btnStartPulling.Name = "btnStartPulling";
            this.btnStartPulling.Size = new System.Drawing.Size(101, 92);
            this.btnStartPulling.TabIndex = 49;
            this.btnStartPulling.UseVisualStyleBackColor = false;
            this.btnStartPulling.Click += new System.EventHandler(this.btnStartPulling_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label23.Location = new System.Drawing.Point(151, 933);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(114, 15);
            this.label23.TabIndex = 50;
            this.label23.Text = "Start Dropping";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label24.Location = new System.Drawing.Point(300, 933);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(98, 15);
            this.label24.TabIndex = 51;
            this.label24.Text = "Start Pulling";
            // 
            // toggleServoEnable
            // 
            this.toggleServoEnable.Location = new System.Drawing.Point(160, 730);
            this.toggleServoEnable.MinimumSize = new System.Drawing.Size(45, 22);
            this.toggleServoEnable.Name = "toggleServoEnable";
            this.toggleServoEnable.OffBackColor = System.Drawing.Color.Gray;
            this.toggleServoEnable.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.toggleServoEnable.OnBackColor = System.Drawing.Color.Lime;
            this.toggleServoEnable.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.toggleServoEnable.Size = new System.Drawing.Size(111, 47);
            this.toggleServoEnable.TabIndex = 38;
            this.toggleServoEnable.UseVisualStyleBackColor = true;
            this.toggleServoEnable.CheckedChanged += new System.EventHandler(this.rjToggleButton1_CheckedChanged);
            // 
            // btnEstop
            // 
            this.btnEstop.BackColor = System.Drawing.Color.White;
            this.btnEstop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEstop.BackgroundImage")));
            this.btnEstop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEstop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEstop.Font = new System.Drawing.Font("Gulim", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnEstop.Location = new System.Drawing.Point(4, 824);
            this.btnEstop.Name = "btnEstop";
            this.btnEstop.Size = new System.Drawing.Size(132, 123);
            this.btnEstop.TabIndex = 3;
            this.btnEstop.UseVisualStyleBackColor = false;
            this.btnEstop.Click += new System.EventHandler(this.btnEstop_Click);
            // 
            // Main_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1715, 962);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.btnStartPulling);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbServoEnable);
            this.Controls.Add(this.toggleServoEnable);
            this.Controls.Add(this.btnRstMcu);
            this.Controls.Add(this.gbDataView);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.listData);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnStartDropping);
            this.Controls.Add(this.gbJogControl);
            this.Controls.Add(this.btnEstop);
            this.Controls.Add(this.SpeedGraph);
            this.Controls.Add(this.btnResetAlarm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main_Control";
            this.Text = "Main_Control";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_Control_FormClosing);
            this.Load += new System.EventHandler(this.Main_Control_Load);
            this.gbJogControl.ResumeLayout(false);
            this.gbJogControl.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.gbDataView.ResumeLayout(false);
            this.gbDataView.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ZedGraph.ZedGraphControl SpeedGraph;
        private ButtonEllipse btnEstop;
        private System.Windows.Forms.Button btnMoveUp;
        private System.Windows.Forms.Button btnMoveDown;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnResetAlarm;
        private System.Windows.Forms.GroupBox gbJogControl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbMotorSpeed;
        private System.Windows.Forms.Button btnStartDropping;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbReach;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSetJogSpeed;
        private System.Windows.Forms.TextBox txtSetSpeed;
        private System.Windows.Forms.Button btnGraphOn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnResetGraph;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnScroll;
        private Elip_Label lbSpeedReach;
        private Elip_Label lbReady;
        private Elip_Label lbBrake;
        private Elip_Label lb_Type;
        private Elip_Label lbZeroSpeedReach;
        private Elip_Label lbCwTorqueLimit;
        private Elip_Label lbCcwTorqueLimit;
        private Elip_Label lbAlarm;
        private Elip_Label lbTorqueLimit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelCcwTorqueLim;
        private System.Windows.Forms.Label labelAlarm;
        private System.Windows.Forms.Label labelTorqueLimit;
        private System.Windows.Forms.CheckBox cbReadOutputs;
        private System.Windows.Forms.TextBox txtTotalEpisodes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSetEpisode;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lbCurrentEpisode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView listData;
        private System.Windows.Forms.ColumnHeader Time;
        private System.Windows.Forms.ColumnHeader Speed;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox cbServerOn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lbAccel;
        private System.Windows.Forms.Label lbPort;
        private System.Windows.Forms.Label lbIP;
        private System.Windows.Forms.ColumnHeader AccX;
        private System.Windows.Forms.CheckBox cbSpeed;
        private System.Windows.Forms.CheckBox cbSpdCmd;
        private System.Windows.Forms.GroupBox gbDataView;
        private System.Windows.Forms.CheckBox cbAccZ;
        private System.Windows.Forms.CheckBox cbAccY;
        private System.Windows.Forms.CheckBox cbAccX;
        private System.Windows.Forms.ColumnHeader AccY;
        private System.Windows.Forms.ColumnHeader AccZ;
        private System.Windows.Forms.Button btnRstMcu;
        private System.Windows.Forms.Label lbEncoderPulses;
        private System.Windows.Forms.Label label12;
        private RJControls.RJToggleButton toggleServoEnable;
        private System.Windows.Forms.Label lbServoEnable;
        private System.Windows.Forms.Label label14;
        private RJControls.RJToggleButton toggleControlMode;
        private System.Windows.Forms.Label label13;
        private RJControls.RJToggleButton toglPF;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private RJControls.RJToggleButton toglPR;
        private RJControls.RJToggleButton toglePLSCLR;
        private System.Windows.Forms.Label label17;
        private RJControls.RJToggleButton togleSPLIM;
        private System.Windows.Forms.Label label18;
        private RJControls.RJToggleButton toglePLSINH;
        private System.Windows.Forms.Label label19;
        private RJControls.RJToggleButton togleCWLIM;
        private System.Windows.Forms.Label label21;
        private RJControls.RJToggleButton togleCCWLIM;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label20;
        private RJControls.RJToggleButton togleDIR;
        private System.Windows.Forms.Button btnStartPulling;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label lbPosition;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button btnSetHome;
    }
}