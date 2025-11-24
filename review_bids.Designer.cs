namespace Freelance
{
    partial class review_bids
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(review_bids));
            this.bids_layout = new System.Windows.Forms.FlowLayoutPanel();
            this.review_layout = new System.Windows.Forms.FlowLayoutPanel();
            this.bids_layout.SuspendLayout();
            this.SuspendLayout();
            // 
            // bids_layout
            // 
            this.bids_layout.Controls.Add(this.review_layout);
            this.bids_layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bids_layout.Location = new System.Drawing.Point(0, 0);
            this.bids_layout.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.bids_layout.Name = "bids_layout";
            this.bids_layout.Size = new System.Drawing.Size(1095, 741);
            this.bids_layout.TabIndex = 0;
            this.bids_layout.Paint += new System.Windows.Forms.PaintEventHandler(this.bids_layout_Paint);
            // 
            // review_layout
            // 
            this.review_layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.review_layout.Location = new System.Drawing.Point(1, 2);
            this.review_layout.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.review_layout.Name = "review_layout";
            this.review_layout.Size = new System.Drawing.Size(95, 0);
            this.review_layout.TabIndex = 0;
            // 
            // review_bids
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 741);
            this.Controls.Add(this.bids_layout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Name = "review_bids";
            this.Text = "Apex";
            this.Load += new System.EventHandler(this.review_bids_Load);
            this.bids_layout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel bids_layout;
        private System.Windows.Forms.FlowLayoutPanel review_layout;
    }
}