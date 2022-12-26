namespace FreeFall_GUI
{
    partial class DriverSetingParams
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
            this.gbSetDriverParam = new System.Windows.Forms.GroupBox();
            this.lbFeedbackValueFloat = new System.Windows.Forms.Label();
            this.lbFeedbackValueInt = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbFeedbackFrame = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbRegister = new System.Windows.Forms.ComboBox();
            this.btnSetDriverParam = new System.Windows.Forms.Button();
            this.txtSetingValue = new System.Windows.Forms.TextBox();
            this.lbSetingValue = new System.Windows.Forms.Label();
            this.gbSetDriverParam.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSetDriverParam
            // 
            this.gbSetDriverParam.BackColor = System.Drawing.Color.OldLace;
            this.gbSetDriverParam.Controls.Add(this.lbFeedbackValueFloat);
            this.gbSetDriverParam.Controls.Add(this.lbFeedbackValueInt);
            this.gbSetDriverParam.Controls.Add(this.label10);
            this.gbSetDriverParam.Controls.Add(this.lbFeedbackFrame);
            this.gbSetDriverParam.Controls.Add(this.label8);
            this.gbSetDriverParam.Controls.Add(this.cbRegister);
            this.gbSetDriverParam.Controls.Add(this.btnSetDriverParam);
            this.gbSetDriverParam.Controls.Add(this.txtSetingValue);
            this.gbSetDriverParam.Controls.Add(this.lbSetingValue);
            this.gbSetDriverParam.Font = new System.Drawing.Font("Gulim", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gbSetDriverParam.Location = new System.Drawing.Point(13, 13);
            this.gbSetDriverParam.Margin = new System.Windows.Forms.Padding(4);
            this.gbSetDriverParam.Name = "gbSetDriverParam";
            this.gbSetDriverParam.Padding = new System.Windows.Forms.Padding(4);
            this.gbSetDriverParam.Size = new System.Drawing.Size(394, 183);
            this.gbSetDriverParam.TabIndex = 19;
            this.gbSetDriverParam.TabStop = false;
            this.gbSetDriverParam.Text = "Driver Setting";
            // 
            // lbFeedbackValueFloat
            // 
            this.lbFeedbackValueFloat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbFeedbackValueFloat.Font = new System.Drawing.Font("Gulim", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbFeedbackValueFloat.ForeColor = System.Drawing.Color.Black;
            this.lbFeedbackValueFloat.Location = new System.Drawing.Point(261, 134);
            this.lbFeedbackValueFloat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFeedbackValueFloat.Name = "lbFeedbackValueFloat";
            this.lbFeedbackValueFloat.Size = new System.Drawing.Size(86, 28);
            this.lbFeedbackValueFloat.TabIndex = 23;
            // 
            // lbFeedbackValueInt
            // 
            this.lbFeedbackValueInt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbFeedbackValueInt.Font = new System.Drawing.Font("Gulim", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbFeedbackValueInt.ForeColor = System.Drawing.Color.Black;
            this.lbFeedbackValueInt.Location = new System.Drawing.Point(151, 134);
            this.lbFeedbackValueInt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFeedbackValueInt.Name = "lbFeedbackValueInt";
            this.lbFeedbackValueInt.Size = new System.Drawing.Size(86, 28);
            this.lbFeedbackValueInt.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Gulim", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(8, 143);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 19);
            this.label10.TabIndex = 20;
            this.label10.Text = "Value (Int/Float)";
            // 
            // lbFeedbackFrame
            // 
            this.lbFeedbackFrame.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbFeedbackFrame.Font = new System.Drawing.Font("Gulim", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbFeedbackFrame.ForeColor = System.Drawing.Color.Black;
            this.lbFeedbackFrame.Location = new System.Drawing.Point(150, 95);
            this.lbFeedbackFrame.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFeedbackFrame.Name = "lbFeedbackFrame";
            this.lbFeedbackFrame.Size = new System.Drawing.Size(197, 28);
            this.lbFeedbackFrame.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Gulim", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(4, 99);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 19);
            this.label8.TabIndex = 18;
            this.label8.Text = "Feedback Frame";
            // 
            // cbRegister
            // 
            this.cbRegister.FormattingEnabled = true;
            this.cbRegister.Items.AddRange(new object[] {
            "P201-Control Mode-200-Int-1-5",
            "P219-Inertia Ratio-218-Float-1-50",
            "P305-Speed PGain-304-Float-0-1000",
            "P306-Speed TscGain-305-Float-0-10000",
            "P402-Speed2-401-Float-0-2000",
            "P404-Speed4-403-Float-0-2000",
            "P701-CN1 Input Type-700-Int-0-30"});
            this.cbRegister.Location = new System.Drawing.Point(8, 24);
            this.cbRegister.Margin = new System.Windows.Forms.Padding(4);
            this.cbRegister.Name = "cbRegister";
            this.cbRegister.Size = new System.Drawing.Size(378, 26);
            this.cbRegister.TabIndex = 5;
            // 
            // btnSetDriverParam
            // 
            this.btnSetDriverParam.AllowDrop = true;
            this.btnSetDriverParam.Location = new System.Drawing.Point(231, 56);
            this.btnSetDriverParam.Margin = new System.Windows.Forms.Padding(4);
            this.btnSetDriverParam.Name = "btnSetDriverParam";
            this.btnSetDriverParam.Size = new System.Drawing.Size(89, 35);
            this.btnSetDriverParam.TabIndex = 17;
            this.btnSetDriverParam.Text = "SET";
            this.btnSetDriverParam.UseVisualStyleBackColor = true;
            // 
            // txtSetingValue
            // 
            this.txtSetingValue.Location = new System.Drawing.Point(120, 61);
            this.txtSetingValue.Margin = new System.Windows.Forms.Padding(4);
            this.txtSetingValue.Name = "txtSetingValue";
            this.txtSetingValue.Size = new System.Drawing.Size(85, 29);
            this.txtSetingValue.TabIndex = 7;
            // 
            // lbSetingValue
            // 
            this.lbSetingValue.AutoSize = true;
            this.lbSetingValue.Font = new System.Drawing.Font("Gulim", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbSetingValue.ForeColor = System.Drawing.Color.Black;
            this.lbSetingValue.Location = new System.Drawing.Point(4, 68);
            this.lbSetingValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSetingValue.Name = "lbSetingValue";
            this.lbSetingValue.Size = new System.Drawing.Size(113, 19);
            this.lbSetingValue.TabIndex = 7;
            this.lbSetingValue.Text = "Setting Value";
            // 
            // DriverSetingParams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 208);
            this.Controls.Add(this.gbSetDriverParam);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DriverSetingParams";
            this.Text = "DriverSetingParams";
            this.gbSetDriverParam.ResumeLayout(false);
            this.gbSetDriverParam.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSetDriverParam;
        private System.Windows.Forms.Label lbFeedbackValueFloat;
        private System.Windows.Forms.Label lbFeedbackValueInt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbFeedbackFrame;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbRegister;
        private System.Windows.Forms.Button btnSetDriverParam;
        private System.Windows.Forms.TextBox txtSetingValue;
        private System.Windows.Forms.Label lbSetingValue;
    }
}