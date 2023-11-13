namespace FreeFall_GUI
{
    partial class Setting
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
            this.TempGraph = new ZedGraph.ZedGraphControl();
            this.btnClearListData = new System.Windows.Forms.Button();
            this.btnPlotData = new System.Windows.Forms.Button();
            this.btnWriteData = new System.Windows.Forms.Button();
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.listData = new System.Windows.Forms.ListView();
            this.Time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PosiTion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Speed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pulse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.proSending = new System.Windows.Forms.ProgressBar();
            this.btnResetGraph = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDrumRadius = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.lbEncoderResolution = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSampleTime = new System.Windows.Forms.TextBox();
            this.btnSetDrumRadius = new System.Windows.Forms.Button();
            this.btnSetSampleTime = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtGoingSpeed = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSetGoingSpeed = new System.Windows.Forms.Button();
            this.gbParam = new System.Windows.Forms.GroupBox();
            this.btnSaveParam = new System.Windows.Forms.Button();
            this.cbModify = new System.Windows.Forms.CheckBox();
            this.btnSetStoppingTime = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStoppingTime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbExperimentMode = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbTotalPullingPulse = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbPullingDist = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbDroppingDist = new System.Windows.Forms.Label();
            this.Radius = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbParam.SuspendLayout();
            this.SuspendLayout();
            // 
            // TempGraph
            // 
            this.TempGraph.Location = new System.Drawing.Point(630, 13);
            this.TempGraph.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TempGraph.Name = "TempGraph";
            this.TempGraph.ScrollGrace = 0D;
            this.TempGraph.ScrollMaxX = 0D;
            this.TempGraph.ScrollMaxY = 0D;
            this.TempGraph.ScrollMaxY2 = 0D;
            this.TempGraph.ScrollMinX = 0D;
            this.TempGraph.ScrollMinY = 0D;
            this.TempGraph.ScrollMinY2 = 0D;
            this.TempGraph.Size = new System.Drawing.Size(829, 544);
            this.TempGraph.TabIndex = 3;
            this.TempGraph.UseExtendedPrintDialog = true;
            // 
            // btnClearListData
            // 
            this.btnClearListData.Location = new System.Drawing.Point(178, 386);
            this.btnClearListData.Name = "btnClearListData";
            this.btnClearListData.Size = new System.Drawing.Size(83, 38);
            this.btnClearListData.TabIndex = 72;
            this.btnClearListData.Text = "Clear";
            this.btnClearListData.UseVisualStyleBackColor = true;
            this.btnClearListData.Click += new System.EventHandler(this.btnClearListData_Click);
            // 
            // btnPlotData
            // 
            this.btnPlotData.Location = new System.Drawing.Point(346, 386);
            this.btnPlotData.Name = "btnPlotData";
            this.btnPlotData.Size = new System.Drawing.Size(83, 37);
            this.btnPlotData.TabIndex = 71;
            this.btnPlotData.Text = "Plot Data";
            this.btnPlotData.UseVisualStyleBackColor = true;
            this.btnPlotData.Click += new System.EventHandler(this.btnPlotData_Click);
            // 
            // btnWriteData
            // 
            this.btnWriteData.Location = new System.Drawing.Point(540, 386);
            this.btnWriteData.Name = "btnWriteData";
            this.btnWriteData.Size = new System.Drawing.Size(83, 38);
            this.btnWriteData.TabIndex = 70;
            this.btnWriteData.Text = "Write";
            this.btnWriteData.UseVisualStyleBackColor = true;
            this.btnWriteData.Click += new System.EventHandler(this.btnWriteData_Click);
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Location = new System.Drawing.Point(12, 386);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(83, 38);
            this.btnLoadFile.TabIndex = 69;
            this.btnLoadFile.Text = "Load File";
            this.btnLoadFile.UseVisualStyleBackColor = true;
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // listData
            // 
            this.listData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Time,
            this.PosiTion,
            this.Speed,
            this.Radius,
            this.Pulse});
            this.listData.Font = new System.Drawing.Font("Gulim", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listData.HideSelection = false;
            this.listData.Location = new System.Drawing.Point(12, 32);
            this.listData.Name = "listData";
            this.listData.Size = new System.Drawing.Size(611, 348);
            this.listData.TabIndex = 68;
            this.listData.UseCompatibleStateImageBehavior = false;
            this.listData.View = System.Windows.Forms.View.Details;
            // 
            // Time
            // 
            this.Time.Text = "time step";
            this.Time.Width = 107;
            // 
            // PosiTion
            // 
            this.PosiTion.Text = "PosValue (m)";
            this.PosiTion.Width = 134;
            // 
            // Speed
            // 
            this.Speed.Text = "Speed";
            this.Speed.Width = 94;
            // 
            // Pulse
            // 
            this.Pulse.Text = "DeltaPulse";
            this.Pulse.Width = 121;
            // 
            // proSending
            // 
            this.proSending.Location = new System.Drawing.Point(630, 564);
            this.proSending.Name = "proSending";
            this.proSending.Size = new System.Drawing.Size(252, 33);
            this.proSending.TabIndex = 78;
            // 
            // btnResetGraph
            // 
            this.btnResetGraph.Location = new System.Drawing.Point(1359, 564);
            this.btnResetGraph.Name = "btnResetGraph";
            this.btnResetGraph.Size = new System.Drawing.Size(100, 33);
            this.btnResetGraph.TabIndex = 75;
            this.btnResetGraph.Text = "Reset Grph";
            this.btnResetGraph.UseVisualStyleBackColor = true;
            this.btnResetGraph.Click += new System.EventHandler(this.btnResetGraph_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Encoder Relso";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(271, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "pulse";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 25);
            this.label7.TabIndex = 3;
            this.label7.Text = "Drum Radius";
            // 
            // txtDrumRadius
            // 
            this.txtDrumRadius.Location = new System.Drawing.Point(182, 91);
            this.txtDrumRadius.Name = "txtDrumRadius";
            this.txtDrumRadius.Size = new System.Drawing.Size(77, 30);
            this.txtDrumRadius.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(271, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 25);
            this.label8.TabIndex = 5;
            this.label8.Text = "m";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(506, 225);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(100, 40);
            this.btnLoad.TabIndex = 6;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoadParam_Click);
            // 
            // lbEncoderResolution
            // 
            this.lbEncoderResolution.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbEncoderResolution.Location = new System.Drawing.Point(184, 41);
            this.lbEncoderResolution.Name = "lbEncoderResolution";
            this.lbEncoderResolution.Size = new System.Drawing.Size(75, 33);
            this.lbEncoderResolution.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Sample Time";
            // 
            // txtSampleTime
            // 
            this.txtSampleTime.Location = new System.Drawing.Point(182, 139);
            this.txtSampleTime.Name = "txtSampleTime";
            this.txtSampleTime.Size = new System.Drawing.Size(77, 30);
            this.txtSampleTime.TabIndex = 10;
            // 
            // btnSetDrumRadius
            // 
            this.btnSetDrumRadius.Location = new System.Drawing.Point(316, 90);
            this.btnSetDrumRadius.Name = "btnSetDrumRadius";
            this.btnSetDrumRadius.Size = new System.Drawing.Size(74, 33);
            this.btnSetDrumRadius.TabIndex = 11;
            this.btnSetDrumRadius.Text = "Set";
            this.btnSetDrumRadius.UseVisualStyleBackColor = true;
            this.btnSetDrumRadius.Click += new System.EventHandler(this.btnSetDrumRadius_Click);
            // 
            // btnSetSampleTime
            // 
            this.btnSetSampleTime.Location = new System.Drawing.Point(316, 138);
            this.btnSetSampleTime.Name = "btnSetSampleTime";
            this.btnSetSampleTime.Size = new System.Drawing.Size(74, 33);
            this.btnSetSampleTime.TabIndex = 12;
            this.btnSetSampleTime.Text = "Set";
            this.btnSetSampleTime.UseVisualStyleBackColor = true;
            this.btnSetSampleTime.Click += new System.EventHandler(this.btnSetSampleTime_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(271, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 25);
            this.label9.TabIndex = 13;
            this.label9.Text = "ms";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 193);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 25);
            this.label10.TabIndex = 14;
            this.label10.Text = "Going Speed";
            // 
            // txtGoingSpeed
            // 
            this.txtGoingSpeed.Location = new System.Drawing.Point(182, 188);
            this.txtGoingSpeed.Name = "txtGoingSpeed";
            this.txtGoingSpeed.Size = new System.Drawing.Size(77, 30);
            this.txtGoingSpeed.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(271, 191);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 25);
            this.label11.TabIndex = 16;
            this.label11.Text = "rpm";
            // 
            // btnSetGoingSpeed
            // 
            this.btnSetGoingSpeed.Location = new System.Drawing.Point(316, 187);
            this.btnSetGoingSpeed.Name = "btnSetGoingSpeed";
            this.btnSetGoingSpeed.Size = new System.Drawing.Size(74, 33);
            this.btnSetGoingSpeed.TabIndex = 17;
            this.btnSetGoingSpeed.Text = "Set";
            this.btnSetGoingSpeed.UseVisualStyleBackColor = true;
            this.btnSetGoingSpeed.Click += new System.EventHandler(this.btnSetGoingSpeed_Click);
            // 
            // gbParam
            // 
            this.gbParam.Controls.Add(this.btnSaveParam);
            this.gbParam.Controls.Add(this.cbModify);
            this.gbParam.Controls.Add(this.btnSetStoppingTime);
            this.gbParam.Controls.Add(this.label3);
            this.gbParam.Controls.Add(this.txtStoppingTime);
            this.gbParam.Controls.Add(this.label1);
            this.gbParam.Controls.Add(this.btnSetGoingSpeed);
            this.gbParam.Controls.Add(this.label11);
            this.gbParam.Controls.Add(this.txtGoingSpeed);
            this.gbParam.Controls.Add(this.label10);
            this.gbParam.Controls.Add(this.label9);
            this.gbParam.Controls.Add(this.btnSetSampleTime);
            this.gbParam.Controls.Add(this.btnSetDrumRadius);
            this.gbParam.Controls.Add(this.txtSampleTime);
            this.gbParam.Controls.Add(this.label2);
            this.gbParam.Controls.Add(this.lbEncoderResolution);
            this.gbParam.Controls.Add(this.btnLoad);
            this.gbParam.Controls.Add(this.label8);
            this.gbParam.Controls.Add(this.txtDrumRadius);
            this.gbParam.Controls.Add(this.label7);
            this.gbParam.Controls.Add(this.label6);
            this.gbParam.Controls.Add(this.label4);
            this.gbParam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gbParam.Location = new System.Drawing.Point(12, 430);
            this.gbParam.Name = "gbParam";
            this.gbParam.Size = new System.Drawing.Size(612, 282);
            this.gbParam.TabIndex = 77;
            this.gbParam.TabStop = false;
            this.gbParam.Text = "Param Seting";
            // 
            // btnSaveParam
            // 
            this.btnSaveParam.Location = new System.Drawing.Point(506, 131);
            this.btnSaveParam.Name = "btnSaveParam";
            this.btnSaveParam.Size = new System.Drawing.Size(100, 40);
            this.btnSaveParam.TabIndex = 23;
            this.btnSaveParam.Text = "Save";
            this.btnSaveParam.UseVisualStyleBackColor = true;
            this.btnSaveParam.Click += new System.EventHandler(this.btnSaveParam_Click);
            // 
            // cbModify
            // 
            this.cbModify.AutoSize = true;
            this.cbModify.Location = new System.Drawing.Point(462, 42);
            this.cbModify.Name = "cbModify";
            this.cbModify.Size = new System.Drawing.Size(92, 29);
            this.cbModify.TabIndex = 22;
            this.cbModify.Text = "Modify";
            this.cbModify.UseVisualStyleBackColor = true;
            this.cbModify.CheckedChanged += new System.EventHandler(this.cbModify_CheckedChanged);
            // 
            // btnSetStoppingTime
            // 
            this.btnSetStoppingTime.Location = new System.Drawing.Point(316, 235);
            this.btnSetStoppingTime.Name = "btnSetStoppingTime";
            this.btnSetStoppingTime.Size = new System.Drawing.Size(74, 33);
            this.btnSetStoppingTime.TabIndex = 21;
            this.btnSetStoppingTime.Text = "Set";
            this.btnSetStoppingTime.UseVisualStyleBackColor = true;
            this.btnSetStoppingTime.Click += new System.EventHandler(this.btnSetStoppingTime_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(271, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "ms";
            // 
            // txtStoppingTime
            // 
            this.txtStoppingTime.Location = new System.Drawing.Point(182, 235);
            this.txtStoppingTime.Name = "txtStoppingTime";
            this.txtStoppingTime.Size = new System.Drawing.Size(77, 30);
            this.txtStoppingTime.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Stopping Time";
            // 
            // lbExperimentMode
            // 
            this.lbExperimentMode.AutoSize = true;
            this.lbExperimentMode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbExperimentMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbExperimentMode.Location = new System.Drawing.Point(1038, 601);
            this.lbExperimentMode.Name = "lbExperimentMode";
            this.lbExperimentMode.Size = new System.Drawing.Size(153, 27);
            this.lbExperimentMode.TabIndex = 13;
            this.lbExperimentMode.Text = "Running Mode";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(641, 663);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 20);
            this.label5.TabIndex = 79;
            this.label5.Text = "Total Pulling Pulse";
            // 
            // lbTotalPullingPulse
            // 
            this.lbTotalPullingPulse.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbTotalPullingPulse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbTotalPullingPulse.Location = new System.Drawing.Point(795, 654);
            this.lbTotalPullingPulse.Name = "lbTotalPullingPulse";
            this.lbTotalPullingPulse.Size = new System.Drawing.Size(103, 38);
            this.lbTotalPullingPulse.TabIndex = 80;
            this.lbTotalPullingPulse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.Location = new System.Drawing.Point(917, 663);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 20);
            this.label12.TabIndex = 81;
            this.label12.Text = "Pulling Dist";
            // 
            // lbPullingDist
            // 
            this.lbPullingDist.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbPullingDist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbPullingDist.Location = new System.Drawing.Point(1028, 654);
            this.lbPullingDist.Name = "lbPullingDist";
            this.lbPullingDist.Size = new System.Drawing.Size(103, 38);
            this.lbPullingDist.TabIndex = 82;
            this.lbPullingDist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.Location = new System.Drawing.Point(1180, 663);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(113, 20);
            this.label13.TabIndex = 83;
            this.label13.Text = "Dropping Dist";
            // 
            // lbDroppingDist
            // 
            this.lbDroppingDist.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbDroppingDist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbDroppingDist.Location = new System.Drawing.Point(1317, 654);
            this.lbDroppingDist.Name = "lbDroppingDist";
            this.lbDroppingDist.Size = new System.Drawing.Size(103, 38);
            this.lbDroppingDist.TabIndex = 84;
            this.lbDroppingDist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Radius
            // 
            this.Radius.Text = "Drum Radius";
            this.Radius.Width = 130;
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1472, 724);
            this.Controls.Add(this.lbDroppingDist);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lbPullingDist);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lbTotalPullingPulse);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.proSending);
            this.Controls.Add(this.gbParam);
            this.Controls.Add(this.btnResetGraph);
            this.Controls.Add(this.btnClearListData);
            this.Controls.Add(this.btnPlotData);
            this.Controls.Add(this.btnWriteData);
            this.Controls.Add(this.btnLoadFile);
            this.Controls.Add(this.listData);
            this.Controls.Add(this.lbExperimentMode);
            this.Controls.Add(this.TempGraph);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Setting";
            this.Text = "Setting";
            this.Load += new System.EventHandler(this.Setting_Load);
            this.gbParam.ResumeLayout(false);
            this.gbParam.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZedGraph.ZedGraphControl TempGraph;
        private System.Windows.Forms.Button btnClearListData;
        private System.Windows.Forms.Button btnPlotData;
        private System.Windows.Forms.Button btnWriteData;
        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.ListView listData;
        private System.Windows.Forms.ColumnHeader Time;
        private System.Windows.Forms.ColumnHeader PosiTion;
        private System.Windows.Forms.ColumnHeader Speed;
        private System.Windows.Forms.ColumnHeader Pulse;
        private System.Windows.Forms.ProgressBar proSending;
        private System.Windows.Forms.Button btnResetGraph;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDrumRadius;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label lbEncoderResolution;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSampleTime;
        private System.Windows.Forms.Button btnSetDrumRadius;
        private System.Windows.Forms.Button btnSetSampleTime;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtGoingSpeed;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSetGoingSpeed;
        private System.Windows.Forms.GroupBox gbParam;
        private System.Windows.Forms.Button btnSetStoppingTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStoppingTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbModify;
        private System.Windows.Forms.Label lbExperimentMode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbTotalPullingPulse;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbPullingDist;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbDroppingDist;
        private System.Windows.Forms.Button btnSaveParam;
        private System.Windows.Forms.ColumnHeader Radius;
    }
}