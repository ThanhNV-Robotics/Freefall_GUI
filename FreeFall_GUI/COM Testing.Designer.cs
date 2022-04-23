namespace FreeFall_GUI
{
    partial class COM_Testing
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
            this.btnSend = new System.Windows.Forms.Button();
            this.tbText = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.gb_testCOM = new System.Windows.Forms.GroupBox();
            this.lbReceive = new System.Windows.Forms.Label();
            this.txtDataReceive = new System.Windows.Forms.TextBox();
            this.gb_testCOM.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(100, 176);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(88, 29);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // tbText
            // 
            this.tbText.Font = new System.Drawing.Font("Gulim", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbText.Location = new System.Drawing.Point(6, 24);
            this.tbText.Multiline = true;
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(182, 128);
            this.tbText.TabIndex = 7;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(6, 176);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(88, 29);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Data received";
            // 
            // gb_testCOM
            // 
            this.gb_testCOM.Controls.Add(this.label2);
            this.gb_testCOM.Controls.Add(this.lbReceive);
            this.gb_testCOM.Controls.Add(this.btnClear);
            this.gb_testCOM.Controls.Add(this.tbText);
            this.gb_testCOM.Controls.Add(this.btnSend);
            this.gb_testCOM.Location = new System.Drawing.Point(28, 29);
            this.gb_testCOM.Name = "gb_testCOM";
            this.gb_testCOM.Size = new System.Drawing.Size(463, 214);
            this.gb_testCOM.TabIndex = 9;
            this.gb_testCOM.TabStop = false;
            this.gb_testCOM.Text = "groupBox2";
            // 
            // lbReceive
            // 
            this.lbReceive.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbReceive.Font = new System.Drawing.Font("Gulim", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbReceive.Location = new System.Drawing.Point(238, 25);
            this.lbReceive.Name = "lbReceive";
            this.lbReceive.Size = new System.Drawing.Size(209, 127);
            this.lbReceive.TabIndex = 9;
            // 
            // txtDataReceive
            // 
            this.txtDataReceive.Font = new System.Drawing.Font("Gulim", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtDataReceive.Location = new System.Drawing.Point(525, 54);
            this.txtDataReceive.Multiline = true;
            this.txtDataReceive.Name = "txtDataReceive";
            this.txtDataReceive.Size = new System.Drawing.Size(182, 128);
            this.txtDataReceive.TabIndex = 11;
            // 
            // COM_Testing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 282);
            this.Controls.Add(this.txtDataReceive);
            this.Controls.Add(this.gb_testCOM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "COM_Testing";
            this.Text = "COM_Testing";
            this.gb_testCOM.ResumeLayout(false);
            this.gb_testCOM.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gb_testCOM;
        private System.Windows.Forms.Label lbReceive;
        private System.Windows.Forms.TextBox txtDataReceive;
    }
}