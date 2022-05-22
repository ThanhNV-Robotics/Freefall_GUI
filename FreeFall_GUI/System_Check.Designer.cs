namespace FreeFall_GUI
{
    partial class ParamSetting
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "P02-01",
            "Control Mode",
            "200",
            "Int",
            "-",
            "-"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "P02-03",
            "CCW TRQ LMT",
            "202",
            "Float",
            "-",
            "%"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "P02-04",
            "CW TRQ LMT",
            "203",
            "Float",
            "-",
            "%"}, -1);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "P02-05",
            "CW Speed LMT",
            "204",
            "Float",
            "-",
            "rpm"}, -1);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "P02-06",
            "CW Speed LMT",
            "205",
            "Float",
            "-",
            "rpm"}, -1);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "P02-07",
            "Brake Speed",
            "206",
            "Float",
            "-",
            "rpm"}, -1);
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem(new string[] {
            "P02-08",
            "Brake Time",
            "207",
            "Float",
            "-",
            "ms"}, -1);
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem(new string[] {
            "P02-09",
            "DB Mode",
            "208",
            "Int",
            "-",
            "-"}, -1);
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem(new string[] {
            "P02-19",
            "Inertial Ratio",
            "218",
            "Float",
            "-",
            "-"}, -1);
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem(new string[] {
            "P03-10",
            "ACCEL Time",
            "309",
            "Float",
            "-",
            "ms"}, -1);
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem(new string[] {
            "P03-11",
            "DECEL Time",
            "310",
            "FLoat",
            "-",
            "ms"}, -1);
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem(new string[] {
            "P05-02",
            "POS Pulse Type",
            "501",
            "Int",
            "-",
            "-"}, -1);
            System.Windows.Forms.ListViewItem listViewItem13 = new System.Windows.Forms.ListViewItem(new string[] {
            "P07-01",
            "CN1-Input Type",
            "700",
            "Int",
            "-",
            "-"}, -1);
            System.Windows.Forms.ListViewItem listViewItem14 = new System.Windows.Forms.ListViewItem(new string[] {
            "P08-01",
            "CN1-Output Type",
            "800",
            "Int",
            "-",
            "-"}, -1);
            this.Register = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RegisName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DataType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CurrentValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Unit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstParam = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSampleTimeSet = new System.Windows.Forms.Button();
            this.btnRefAccSet = new System.Windows.Forms.Button();
            this.btnKiSet = new System.Windows.Forms.Button();
            this.btnKpSet = new System.Windows.Forms.Button();
            this.btnMaxDistSet = new System.Windows.Forms.Button();
            this.btnDrumRadiusSet = new System.Windows.Forms.Button();
            this.txtSampleTime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAccRef = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKp = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtKi = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDrumRadius = new System.Windows.Forms.TextBox();
            this.txtMaxDistance = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Register
            // 
            this.Register.Text = "Register";
            this.Register.Width = 93;
            // 
            // RegisName
            // 
            this.RegisName.Text = "Name";
            this.RegisName.Width = 180;
            // 
            // Address
            // 
            this.Address.Text = "Address";
            this.Address.Width = 100;
            // 
            // DataType
            // 
            this.DataType.Text = "Data Type";
            this.DataType.Width = 114;
            // 
            // CurrentValue
            // 
            this.CurrentValue.Text = "Current Value";
            this.CurrentValue.Width = 140;
            // 
            // Unit
            // 
            this.Unit.Text = "Unit";
            this.Unit.Width = 56;
            // 
            // lstParam
            // 
            this.lstParam.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Register,
            this.RegisName,
            this.Address,
            this.DataType,
            this.CurrentValue,
            this.Unit});
            this.lstParam.Font = new System.Drawing.Font("Gulim", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lstParam.HideSelection = false;
            this.lstParam.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8,
            listViewItem9,
            listViewItem10,
            listViewItem11,
            listViewItem12,
            listViewItem13,
            listViewItem14});
            this.lstParam.Location = new System.Drawing.Point(12, 12);
            this.lstParam.Name = "lstParam";
            this.lstParam.Size = new System.Drawing.Size(817, 366);
            this.lstParam.TabIndex = 3;
            this.lstParam.UseCompatibleStateImageBehavior = false;
            this.lstParam.View = System.Windows.Forms.View.Details;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSampleTimeSet);
            this.groupBox1.Controls.Add(this.btnRefAccSet);
            this.groupBox1.Controls.Add(this.btnKiSet);
            this.groupBox1.Controls.Add(this.btnKpSet);
            this.groupBox1.Controls.Add(this.btnMaxDistSet);
            this.groupBox1.Controls.Add(this.btnDrumRadiusSet);
            this.groupBox1.Controls.Add(this.txtSampleTime);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnLoad);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Font = new System.Drawing.Font("Gulim", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(844, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 451);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Running Params";
            // 
            // btnSampleTimeSet
            // 
            this.btnSampleTimeSet.AllowDrop = true;
            this.btnSampleTimeSet.Location = new System.Drawing.Point(371, 344);
            this.btnSampleTimeSet.Name = "btnSampleTimeSet";
            this.btnSampleTimeSet.Size = new System.Drawing.Size(91, 29);
            this.btnSampleTimeSet.TabIndex = 16;
            this.btnSampleTimeSet.Text = "SET";
            this.btnSampleTimeSet.UseVisualStyleBackColor = true;
            this.btnSampleTimeSet.Click += new System.EventHandler(this.btnSampleTimeSet_Click);
            // 
            // btnRefAccSet
            // 
            this.btnRefAccSet.AllowDrop = true;
            this.btnRefAccSet.Location = new System.Drawing.Point(371, 279);
            this.btnRefAccSet.Name = "btnRefAccSet";
            this.btnRefAccSet.Size = new System.Drawing.Size(91, 29);
            this.btnRefAccSet.TabIndex = 15;
            this.btnRefAccSet.Text = "SET";
            this.btnRefAccSet.UseVisualStyleBackColor = true;
            this.btnRefAccSet.Click += new System.EventHandler(this.btnRefAccSet_Click);
            // 
            // btnKiSet
            // 
            this.btnKiSet.AllowDrop = true;
            this.btnKiSet.Location = new System.Drawing.Point(371, 205);
            this.btnKiSet.Name = "btnKiSet";
            this.btnKiSet.Size = new System.Drawing.Size(91, 29);
            this.btnKiSet.TabIndex = 14;
            this.btnKiSet.Text = "SET";
            this.btnKiSet.UseVisualStyleBackColor = true;
            this.btnKiSet.Click += new System.EventHandler(this.btnKiSet_Click);
            // 
            // btnKpSet
            // 
            this.btnKpSet.AllowDrop = true;
            this.btnKpSet.Location = new System.Drawing.Point(371, 167);
            this.btnKpSet.Name = "btnKpSet";
            this.btnKpSet.Size = new System.Drawing.Size(91, 29);
            this.btnKpSet.TabIndex = 13;
            this.btnKpSet.Text = "SET";
            this.btnKpSet.UseVisualStyleBackColor = true;
            this.btnKpSet.Click += new System.EventHandler(this.btnKpSet_Click);
            // 
            // btnMaxDistSet
            // 
            this.btnMaxDistSet.AllowDrop = true;
            this.btnMaxDistSet.Location = new System.Drawing.Point(371, 98);
            this.btnMaxDistSet.Name = "btnMaxDistSet";
            this.btnMaxDistSet.Size = new System.Drawing.Size(91, 29);
            this.btnMaxDistSet.TabIndex = 12;
            this.btnMaxDistSet.Text = "SET";
            this.btnMaxDistSet.UseVisualStyleBackColor = true;
            this.btnMaxDistSet.Click += new System.EventHandler(this.btnMaxDistSet_Click);
            // 
            // btnDrumRadiusSet
            // 
            this.btnDrumRadiusSet.AllowDrop = true;
            this.btnDrumRadiusSet.Location = new System.Drawing.Point(371, 63);
            this.btnDrumRadiusSet.Name = "btnDrumRadiusSet";
            this.btnDrumRadiusSet.Size = new System.Drawing.Size(91, 29);
            this.btnDrumRadiusSet.TabIndex = 11;
            this.btnDrumRadiusSet.Text = "SET";
            this.btnDrumRadiusSet.UseVisualStyleBackColor = true;
            this.btnDrumRadiusSet.Click += new System.EventHandler(this.btnDrumRadiusSet_Click);
            // 
            // txtSampleTime
            // 
            this.txtSampleTime.Location = new System.Drawing.Point(265, 344);
            this.txtSampleTime.Name = "txtSampleTime";
            this.txtSampleTime.Size = new System.Drawing.Size(100, 29);
            this.txtSampleTime.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(85, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Sample Time (ms)";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.txtAccRef);
            this.groupBox4.ForeColor = System.Drawing.Color.Red;
            this.groupBox4.Location = new System.Drawing.Point(10, 251);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(355, 72);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Reference Accel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(84, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ref Acc (m/s^2)";
            // 
            // txtAccRef
            // 
            this.txtAccRef.Location = new System.Drawing.Point(255, 28);
            this.txtAccRef.Name = "txtAccRef";
            this.txtAccRef.Size = new System.Drawing.Size(100, 29);
            this.txtAccRef.TabIndex = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtKp);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtKi);
            this.groupBox3.ForeColor = System.Drawing.Color.Red;
            this.groupBox3.Location = new System.Drawing.Point(10, 145);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(355, 100);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "PI Controller";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(75, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Kp (rpm/(m/s^2))";
            // 
            // txtKp
            // 
            this.txtKp.Location = new System.Drawing.Point(255, 22);
            this.txtKp.Name = "txtKp";
            this.txtKp.Size = new System.Drawing.Size(100, 29);
            this.txtKp.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(119, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 19);
            this.label6.TabIndex = 1;
            this.label6.Text = "Ki (rpm/m/s)";
            // 
            // txtKi
            // 
            this.txtKi.Location = new System.Drawing.Point(255, 60);
            this.txtKi.Name = "txtKi";
            this.txtKi.Size = new System.Drawing.Size(100, 29);
            this.txtKi.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtDrumRadius);
            this.groupBox2.Controls.Add(this.txtMaxDistance);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(10, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(355, 98);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Feed Forward Parameters";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(90, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Drum Radius (m)";
            // 
            // txtDrumRadius
            // 
            this.txtDrumRadius.Location = new System.Drawing.Point(255, 22);
            this.txtDrumRadius.Name = "txtDrumRadius";
            this.txtDrumRadius.Size = new System.Drawing.Size(100, 29);
            this.txtDrumRadius.TabIndex = 6;
            // 
            // txtMaxDistance
            // 
            this.txtMaxDistance.Location = new System.Drawing.Point(255, 57);
            this.txtMaxDistance.Name = "txtMaxDistance";
            this.txtMaxDistance.Size = new System.Drawing.Size(100, 29);
            this.txtMaxDistance.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(81, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dropping Distance (m)";
            // 
            // btnLoad
            // 
            this.btnLoad.AllowDrop = true;
            this.btnLoad.Location = new System.Drawing.Point(371, 409);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(91, 36);
            this.btnLoad.TabIndex = 9;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.AllowDrop = true;
            this.btnSave.Location = new System.Drawing.Point(10, 409);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(91, 36);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // ParamSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 662);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstParam);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ParamSetting";
            this.Text = "Parameter Setting";
            this.Load += new System.EventHandler(this.System_Check_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ColumnHeader Register;
        private System.Windows.Forms.ColumnHeader RegisName;
        private System.Windows.Forms.ColumnHeader Address;
        private System.Windows.Forms.ColumnHeader DataType;
        private System.Windows.Forms.ColumnHeader CurrentValue;
        private System.Windows.Forms.ColumnHeader Unit;
        private System.Windows.Forms.ListView lstParam;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMaxDistance;
        private System.Windows.Forms.TextBox txtDrumRadius;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtKi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAccRef;
        private System.Windows.Forms.TextBox txtSampleTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSampleTimeSet;
        private System.Windows.Forms.Button btnRefAccSet;
        private System.Windows.Forms.Button btnKiSet;
        private System.Windows.Forms.Button btnKpSet;
        private System.Windows.Forms.Button btnMaxDistSet;
        private System.Windows.Forms.Button btnDrumRadiusSet;
    }
}