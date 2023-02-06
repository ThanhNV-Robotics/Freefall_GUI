namespace FreeFall_GUI
{
    partial class _2ndDataGraph
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
            this.DataGraph = new ZedGraph.ZedGraphControl();
            this.SuspendLayout();
            // 
            // DataGraph
            // 
            this.DataGraph.Location = new System.Drawing.Point(22, 34);
            this.DataGraph.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DataGraph.Name = "DataGraph";
            this.DataGraph.ScrollGrace = 0D;
            this.DataGraph.ScrollMaxX = 0D;
            this.DataGraph.ScrollMaxY = 0D;
            this.DataGraph.ScrollMaxY2 = 0D;
            this.DataGraph.ScrollMinX = 0D;
            this.DataGraph.ScrollMinY = 0D;
            this.DataGraph.ScrollMinY2 = 0D;
            this.DataGraph.Size = new System.Drawing.Size(908, 607);
            this.DataGraph.TabIndex = 0;
            this.DataGraph.UseExtendedPrintDialog = true;
            // 
            // _2ndDataGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 668);
            this.Controls.Add(this.DataGraph);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "_2ndDataGraph";
            this.Text = "_2ndDataGraph";
            this.Load += new System.EventHandler(this._2ndDataGraph_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public ZedGraph.ZedGraphControl DataGraph;
    }
}