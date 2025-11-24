namespace Freelance
{
    partial class locked
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(locked));
            this.time_out = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.locked_wallpaper = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.locked_wallpaper.SuspendLayout();
            this.SuspendLayout();
            // 
            // time_out
            // 
            this.time_out.BackColor = System.Drawing.Color.Transparent;
            this.time_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_out.Location = new System.Drawing.Point(453, 374);
            this.time_out.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.time_out.Name = "time_out";
            this.time_out.Size = new System.Drawing.Size(3, 2);
            this.time_out.TabIndex = 0;
            this.time_out.Text = null;
            // 
            // locked_wallpaper
            // 
            this.locked_wallpaper.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("locked_wallpaper.BackgroundImage")));
            this.locked_wallpaper.Controls.Add(this.guna2HtmlLabel1);
            this.locked_wallpaper.Controls.Add(this.time_out);
            this.locked_wallpaper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.locked_wallpaper.Location = new System.Drawing.Point(0, 0);
            this.locked_wallpaper.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.locked_wallpaper.Name = "locked_wallpaper";
            this.locked_wallpaper.Size = new System.Drawing.Size(1268, 775);
            this.locked_wallpaper.TabIndex = 1;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(453, 304);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(436, 34);
            this.guna2HtmlLabel1.TabIndex = 1;
            this.guna2HtmlLabel1.Text = "Your account is temporarily locked";
            // 
            // locked
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1268, 775);
            this.Controls.Add(this.locked_wallpaper);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Name = "locked";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "locked";
            this.locked_wallpaper.ResumeLayout(false);
            this.locked_wallpaper.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel time_out;
        private Guna.UI2.WinForms.Guna2GradientPanel locked_wallpaper;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}