namespace Freelance
{
    partial class client_profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(client_profile));
            this.wallpaper = new Guna.UI2.WinForms.Guna2Panel();
            this.go_client_pf = new Guna.UI2.WinForms.Guna2ImageButton();
            this.client_name = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.client_email = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.org_name = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.client_location = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();
            // 
            // wallpaper
            // 
            this.wallpaper.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("wallpaper.BackgroundImage")));
            this.wallpaper.Dock = System.Windows.Forms.DockStyle.Top;
            this.wallpaper.Location = new System.Drawing.Point(0, 0);
            this.wallpaper.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.wallpaper.Name = "wallpaper";
            this.wallpaper.Size = new System.Drawing.Size(895, 118);
            this.wallpaper.TabIndex = 19;
            this.wallpaper.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // go_client_pf
            // 
            this.go_client_pf.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.go_client_pf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.go_client_pf.HoverState.ImageSize = new System.Drawing.Size(110, 110);
            this.go_client_pf.Image = ((System.Drawing.Image)(resources.GetObject("go_client_pf.Image")));
            this.go_client_pf.ImageOffset = new System.Drawing.Point(0, 0);
            this.go_client_pf.ImageRotate = 0F;
            this.go_client_pf.ImageSize = new System.Drawing.Size(100, 100);
            this.go_client_pf.IndicateFocus = true;
            this.go_client_pf.Location = new System.Drawing.Point(33, 64);
            this.go_client_pf.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.go_client_pf.Name = "go_client_pf";
            this.go_client_pf.PressedState.ImageSize = new System.Drawing.Size(112, 112);
            this.go_client_pf.Size = new System.Drawing.Size(122, 121);
            this.go_client_pf.TabIndex = 20;
            this.go_client_pf.Click += new System.EventHandler(this.go_client_pf_Click);
            // 
            // client_name
            // 
            this.client_name.BackColor = System.Drawing.Color.Transparent;
            this.client_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.client_name.Location = new System.Drawing.Point(190, 141);
            this.client_name.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.client_name.Name = "client_name";
            this.client_name.Size = new System.Drawing.Size(159, 34);
            this.client_name.TabIndex = 21;
            this.client_name.Text = "Client Name";
            // 
            // client_email
            // 
            this.client_email.BackColor = System.Drawing.Color.Transparent;
            this.client_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.client_email.ForeColor = System.Drawing.Color.DimGray;
            this.client_email.Location = new System.Drawing.Point(190, 180);
            this.client_email.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.client_email.Name = "client_email";
            this.client_email.Size = new System.Drawing.Size(108, 27);
            this.client_email.TabIndex = 22;
            this.client_email.Text = "Email Name";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(190, 247);
            this.guna2HtmlLabel3.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(248, 34);
            this.guna2HtmlLabel3.TabIndex = 23;
            this.guna2HtmlLabel3.Text = "Organization Name";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(190, 341);
            this.guna2HtmlLabel4.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(112, 34);
            this.guna2HtmlLabel4.TabIndex = 24;
            this.guna2HtmlLabel4.Text = "Location";
            // 
            // org_name
            // 
            this.org_name.BackColor = System.Drawing.Color.Transparent;
            this.org_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.org_name.ForeColor = System.Drawing.Color.DimGray;
            this.org_name.Location = new System.Drawing.Point(190, 285);
            this.org_name.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.org_name.Name = "org_name";
            this.org_name.Size = new System.Drawing.Size(127, 27);
            this.org_name.TabIndex = 25;
            this.org_name.Text = "Coca Cola Inc";
            // 
            // client_location
            // 
            this.client_location.BackColor = System.Drawing.Color.Transparent;
            this.client_location.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.client_location.ForeColor = System.Drawing.Color.DimGray;
            this.client_location.Location = new System.Drawing.Point(190, 379);
            this.client_location.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.client_location.Name = "client_location";
            this.client_location.Size = new System.Drawing.Size(216, 27);
            this.client_location.TabIndex = 26;
            this.client_location.Text = "Oxford , United Kingdom";
            // 
            // client_profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(895, 483);
            this.Controls.Add(this.go_client_pf);
            this.Controls.Add(this.client_location);
            this.Controls.Add(this.org_name);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.client_email);
            this.Controls.Add(this.client_name);
            this.Controls.Add(this.wallpaper);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Name = "client_profile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Apex";
            this.Load += new System.EventHandler(this.client_profile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel wallpaper;
        private Guna.UI2.WinForms.Guna2ImageButton go_client_pf;
        private Guna.UI2.WinForms.Guna2HtmlLabel client_name;
        private Guna.UI2.WinForms.Guna2HtmlLabel client_email;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel org_name;
        private Guna.UI2.WinForms.Guna2HtmlLabel client_location;
    }
}