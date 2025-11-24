namespace Freelance
{
    partial class started
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(started));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.Get_Started = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Pic_1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Agree = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.label1.Location = new System.Drawing.Point(45, 178);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(443, 72);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ready to take your freelance career to the next level?\r\nJoin our community of tal" +
    "ented professionals and \r\nstart connecting with clients today!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Get_Started
            // 
            this.Get_Started.Animated = true;
            this.Get_Started.AutoRoundedCorners = true;
            this.Get_Started.BackColor = System.Drawing.Color.Transparent;
            this.Get_Started.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Get_Started.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Get_Started.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Get_Started.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Get_Started.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Get_Started.FillColor = System.Drawing.Color.Teal;
            this.Get_Started.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Get_Started.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.Get_Started.ForeColor = System.Drawing.Color.White;
            this.Get_Started.Location = new System.Drawing.Point(49, 400);
            this.Get_Started.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Get_Started.Name = "Get_Started";
            this.Get_Started.Size = new System.Drawing.Size(308, 67);
            this.Get_Started.TabIndex = 7;
            this.Get_Started.Text = "Get Started";
            this.Get_Started.UseTransparentBackground = true;
            this.Get_Started.Click += new System.EventHandler(this.Get_Started_Click);
            // 
            // Pic_1
            // 
            this.Pic_1.BackColor = System.Drawing.Color.Transparent;
            this.Pic_1.ErrorImage = null;
            this.Pic_1.FillColor = System.Drawing.Color.Empty;
            this.Pic_1.Image = ((System.Drawing.Image)(resources.GetObject("Pic_1.Image")));
            this.Pic_1.ImageRotate = 0F;
            this.Pic_1.Location = new System.Drawing.Point(570, 85);
            this.Pic_1.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Pic_1.Name = "Pic_1";
            this.Pic_1.Size = new System.Drawing.Size(372, 382);
            this.Pic_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_1.TabIndex = 3;
            this.Pic_1.TabStop = false;
            this.Pic_1.UseTransparentBackground = true;
            this.Pic_1.Click += new System.EventHandler(this.Pic_1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 116);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 37);
            this.label2.TabIndex = 8;
            this.label2.Text = "Welcome";
            // 
            // Agree
            // 
            this.Agree.AutoSize = true;
            this.Agree.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Agree.Location = new System.Drawing.Point(49, 351);
            this.Agree.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Agree.Name = "Agree";
            this.Agree.Size = new System.Drawing.Size(274, 24);
            this.Agree.TabIndex = 9;
            this.Agree.Text = "Agree to our terms and conditions";
            this.Agree.UseVisualStyleBackColor = true;
            this.Agree.CheckedChanged += new System.EventHandler(this.Agree_CheckedChanged_1);
            // 
            // started
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(961, 580);
            this.Controls.Add(this.Agree);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Get_Started);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Pic_1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Name = "started";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Apex";
            this.Load += new System.EventHandler(this.started_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2PictureBox Pic_1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GradientButton Get_Started;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox Agree;
    }


}