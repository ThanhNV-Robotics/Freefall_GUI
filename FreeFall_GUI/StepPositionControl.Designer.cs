namespace FreeFall_GUI
{
    partial class StepPositionControl
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
            this.txtPulseCmd = new System.Windows.Forms.TextBox();
            this.btnSetPulseCmd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(11, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Setting Pulse Command";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPulseCmd
            // 
            this.txtPulseCmd.Font = new System.Drawing.Font("Gulim", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPulseCmd.Location = new System.Drawing.Point(262, 21);
            this.txtPulseCmd.Name = "txtPulseCmd";
            this.txtPulseCmd.Size = new System.Drawing.Size(116, 46);
            this.txtPulseCmd.TabIndex = 1;
            // 
            // btnSetPulseCmd
            // 
            this.btnSetPulseCmd.Font = new System.Drawing.Font("Gulim", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSetPulseCmd.Location = new System.Drawing.Point(409, 21);
            this.btnSetPulseCmd.Name = "btnSetPulseCmd";
            this.btnSetPulseCmd.Size = new System.Drawing.Size(109, 46);
            this.btnSetPulseCmd.TabIndex = 4;
            this.btnSetPulseCmd.Text = "SET";
            this.btnSetPulseCmd.UseVisualStyleBackColor = true;
            this.btnSetPulseCmd.Click += new System.EventHandler(this.btnSetPulseCmd_Click);
            // 
            // StepPositionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 90);
            this.Controls.Add(this.btnSetPulseCmd);
            this.Controls.Add(this.txtPulseCmd);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "StepPositionControl";
            this.Text = "StepPositionControl";
            this.Load += new System.EventHandler(this.StepPositionControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPulseCmd;
        private System.Windows.Forms.Button btnSetPulseCmd;
    }
}