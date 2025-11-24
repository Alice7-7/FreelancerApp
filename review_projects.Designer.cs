namespace Freelance
{
    partial class review_projects
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(review_projects));
            this.review_pjs_flow = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // review_pjs_flow
            // 
            this.review_pjs_flow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.review_pjs_flow.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.review_pjs_flow.Location = new System.Drawing.Point(0, 0);
            this.review_pjs_flow.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.review_pjs_flow.Name = "review_pjs_flow";
            this.review_pjs_flow.Size = new System.Drawing.Size(970, 733);
            this.review_pjs_flow.TabIndex = 0;
            this.review_pjs_flow.Paint += new System.Windows.Forms.PaintEventHandler(this.review_pjs_flow_Paint);
            // 
            // review_projects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 733);
            this.Controls.Add(this.review_pjs_flow);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Name = "review_projects";
            this.Text = "Apex";
            this.Load += new System.EventHandler(this.review_projects_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel review_pjs_flow;
    }
}