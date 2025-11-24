namespace Freelance
{
    partial class role
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(role));
            this.client_role = new Guna.UI2.WinForms.Guna2ImageButton();
            this.freelancer = new Guna.UI2.WinForms.Guna2ImageButton();
            this.Sign_In = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // client_role
            // 
            this.client_role.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.client_role.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.client_role.HoverState.ImageSize = new System.Drawing.Size(260, 260);
            this.client_role.Image = ((System.Drawing.Image)(resources.GetObject("client_role.Image")));
            this.client_role.ImageOffset = new System.Drawing.Point(0, 0);
            this.client_role.ImageRotate = 0F;
            this.client_role.ImageSize = new System.Drawing.Size(230, 230);
            this.client_role.IndicateFocus = true;
            this.client_role.Location = new System.Drawing.Point(191, 218);
            this.client_role.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.client_role.Name = "client_role";
            this.client_role.PressedState.ImageSize = new System.Drawing.Size(240, 240);
            this.client_role.Size = new System.Drawing.Size(286, 255);
            this.client_role.TabIndex = 0;
            this.client_role.Click += new System.EventHandler(this.client_role_Click);
            // 
            // freelancer
            // 
            this.freelancer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.freelancer.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.freelancer.HoverState.ImageSize = new System.Drawing.Size(250, 250);
            this.freelancer.Image = ((System.Drawing.Image)(resources.GetObject("freelancer.Image")));
            this.freelancer.ImageOffset = new System.Drawing.Point(0, 0);
            this.freelancer.ImageRotate = 0F;
            this.freelancer.ImageSize = new System.Drawing.Size(230, 230);
            this.freelancer.IndicateFocus = true;
            this.freelancer.Location = new System.Drawing.Point(560, 218);
            this.freelancer.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.freelancer.Name = "freelancer";
            this.freelancer.PressedState.ImageSize = new System.Drawing.Size(240, 240);
            this.freelancer.Size = new System.Drawing.Size(292, 255);
            this.freelancer.TabIndex = 20;
            this.freelancer.Click += new System.EventHandler(this.freelancer_Click);
            // 
            // Sign_In
            // 
            this.Sign_In.ActiveLinkColor = System.Drawing.Color.Cyan;
            this.Sign_In.AutoSize = true;
            this.Sign_In.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sign_In.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Sign_In.Location = new System.Drawing.Point(580, 596);
            this.Sign_In.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Sign_In.Name = "Sign_In";
            this.Sign_In.Size = new System.Drawing.Size(73, 25);
            this.Sign_In.TabIndex = 22;
            this.Sign_In.TabStop = true;
            this.Sign_In.Text = "Sign In";
            this.Sign_In.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Sign_In_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(339, 119);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 29);
            this.label1.TabIndex = 23;
            this.label1.Text = "Please choose the account type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(635, 491);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "Freelancer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(289, 491);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 25);
            this.label4.TabIndex = 26;
            this.label4.Text = "Client";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(334, 596);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 25);
            this.label3.TabIndex = 27;
            this.label3.Text = "Already have an account ?";
            // 
            // role
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1029, 721);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Sign_In);
            this.Controls.Add(this.freelancer);
            this.Controls.Add(this.client_role);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Name = "role";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Apex";
            this.Load += new System.EventHandler(this.role_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ImageButton client_role;
        private Guna.UI2.WinForms.Guna2ImageButton freelancer;
        private System.Windows.Forms.LinkLabel Sign_In;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}