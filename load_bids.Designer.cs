namespace Freelance
{
    partial class load_bids
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(load_bids));
            this.load_bids_flow = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // load_bids_flow
            // 
            this.load_bids_flow.AutoScroll = true;
            this.load_bids_flow.AutoSize = true;
            this.load_bids_flow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.load_bids_flow.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.load_bids_flow.Location = new System.Drawing.Point(0, 0);
            this.load_bids_flow.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.load_bids_flow.Name = "load_bids_flow";
            this.load_bids_flow.Size = new System.Drawing.Size(816, 841);
            this.load_bids_flow.TabIndex = 0;
            // 
            // load_bids
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(816, 841);
            this.Controls.Add(this.load_bids_flow);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Name = "load_bids";
            this.Text = "Apex";
            this.Load += new System.EventHandler(this.load_bids_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel load_bids_flow;
    }
}