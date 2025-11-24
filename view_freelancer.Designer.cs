namespace Freelance
{
    partial class view_freelancer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(view_freelancer));
            this.freelancer_flow = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // freelancer_flow
            // 
            this.freelancer_flow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.freelancer_flow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.freelancer_flow.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.freelancer_flow.Location = new System.Drawing.Point(0, 0);
            this.freelancer_flow.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.freelancer_flow.Name = "freelancer_flow";
            this.freelancer_flow.Size = new System.Drawing.Size(885, 718);
            this.freelancer_flow.TabIndex = 0;
            // 
            // view_freelancer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(885, 718);
            this.Controls.Add(this.freelancer_flow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Name = "view_freelancer";
            this.Text = "Apex";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel freelancer_flow;


    }
}