namespace FreeFall_GUI
{
    partial class COM_Config
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
            this.label1 = new System.Windows.Forms.Label();
            this.lb_com_name = new System.Windows.Forms.Label();
            this.lb_baud_rate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_baud_rate = new System.Windows.Forms.ComboBox();
            this.cb_data_bits = new System.Windows.Forms.ComboBox();
            this.cb_stop_bits = new System.Windows.Forms.ComboBox();
            this.cb_parity_bits = new System.Windows.Forms.ComboBox();
            this.btn_apply = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "COM port";
            // 
            // lb_com_name
            // 
            this.lb_com_name.AutoSize = true;
            this.lb_com_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_com_name.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_com_name.Location = new System.Drawing.Point(164, 34);
            this.lb_com_name.Name = "lb_com_name";
            this.lb_com_name.Size = new System.Drawing.Size(88, 24);
            this.lb_com_name.TabIndex = 1;
            this.lb_com_name.Text = "COM name";
            // 
            // lb_baud_rate
            // 
            this.lb_baud_rate.AutoSize = true;
            this.lb_baud_rate.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_baud_rate.Location = new System.Drawing.Point(12, 81);
            this.lb_baud_rate.Name = "lb_baud_rate";
            this.lb_baud_rate.Size = new System.Drawing.Size(96, 22);
            this.lb_baud_rate.TabIndex = 2;
            this.lb_baud_rate.Text = "BAUD RATE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "DATA BITS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "STOP BITS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "PARITY BITS";
            // 
            // cb_baud_rate
            // 
            this.cb_baud_rate.FormattingEnabled = true;
            this.cb_baud_rate.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "115200"});
            this.cb_baud_rate.Location = new System.Drawing.Point(145, 83);
            this.cb_baud_rate.Name = "cb_baud_rate";
            this.cb_baud_rate.Size = new System.Drawing.Size(121, 23);
            this.cb_baud_rate.TabIndex = 6;
            // 
            // cb_data_bits
            // 
            this.cb_data_bits.FormattingEnabled = true;
            this.cb_data_bits.Items.AddRange(new object[] {
            "6",
            "7",
            "8"});
            this.cb_data_bits.Location = new System.Drawing.Point(145, 130);
            this.cb_data_bits.Name = "cb_data_bits";
            this.cb_data_bits.Size = new System.Drawing.Size(121, 23);
            this.cb_data_bits.TabIndex = 7;
            // 
            // cb_stop_bits
            // 
            this.cb_stop_bits.FormattingEnabled = true;
            this.cb_stop_bits.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.cb_stop_bits.Location = new System.Drawing.Point(145, 175);
            this.cb_stop_bits.Name = "cb_stop_bits";
            this.cb_stop_bits.Size = new System.Drawing.Size(121, 23);
            this.cb_stop_bits.TabIndex = 8;
            this.cb_stop_bits.SelectedIndexChanged += new System.EventHandler(this.cb_stop_bits_SelectedIndexChanged);
            // 
            // cb_parity_bits
            // 
            this.cb_parity_bits.FormattingEnabled = true;
            this.cb_parity_bits.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.cb_parity_bits.Location = new System.Drawing.Point(145, 223);
            this.cb_parity_bits.Name = "cb_parity_bits";
            this.cb_parity_bits.Size = new System.Drawing.Size(121, 23);
            this.cb_parity_bits.TabIndex = 9;
            // 
            // btn_apply
            // 
            this.btn_apply.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_apply.Location = new System.Drawing.Point(12, 298);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(98, 32);
            this.btn_apply.TabIndex = 10;
            this.btn_apply.Text = "APPLY";
            this.btn_apply.UseVisualStyleBackColor = true;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ok.Location = new System.Drawing.Point(164, 298);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(98, 32);
            this.btn_ok.TabIndex = 11;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // COM_Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 342);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.btn_apply);
            this.Controls.Add(this.cb_parity_bits);
            this.Controls.Add(this.cb_stop_bits);
            this.Controls.Add(this.cb_data_bits);
            this.Controls.Add(this.cb_baud_rate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_baud_rate);
            this.Controls.Add(this.lb_com_name);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "COM_Config";
            this.Text = "COM Configurations";
            this.Load += new System.EventHandler(this.COM_Config_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_baud_rate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_baud_rate;
        private System.Windows.Forms.ComboBox cb_data_bits;
        private System.Windows.Forms.ComboBox cb_stop_bits;
        private System.Windows.Forms.ComboBox cb_parity_bits;
        private System.Windows.Forms.Button btn_apply;
        private System.Windows.Forms.Button btn_ok;
        public System.Windows.Forms.Label lb_com_name;
    }
}