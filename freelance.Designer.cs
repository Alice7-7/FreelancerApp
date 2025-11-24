namespace Freelance
{
    partial class freelance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(freelance));
            this.panel2 = new System.Windows.Forms.Panel();
            this.name1_lbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.free_logout = new Guna.UI2.WinForms.Guna2GradientButton();
            this.feedback_pjs = new Guna.UI2.WinForms.Guna2GradientButton();
            this.projects = new Guna.UI2.WinForms.Guna2GradientButton();
            this.member = new Guna.UI2.WinForms.Guna2GradientButton();
            this.dashboard = new Guna.UI2.WinForms.Guna2GradientButton();
            this.skills_lbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.name_lbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pf_pic = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.name2_lbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.notibox = new System.Windows.Forms.ListBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.refresh_noti = new Guna.UI2.WinForms.Guna2GradientButton();
            this.project_feeds = new System.Windows.Forms.FlowLayoutPanel();
            this.refresh_btn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2ImageButton2 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.name1_lbl);
            this.panel2.Controls.Add(this.free_logout);
            this.panel2.Controls.Add(this.feedback_pjs);
            this.panel2.Controls.Add(this.projects);
            this.panel2.Controls.Add(this.member);
            this.panel2.Controls.Add(this.dashboard);
            this.panel2.Controls.Add(this.skills_lbl);
            this.panel2.Controls.Add(this.name_lbl);
            this.panel2.Controls.Add(this.pf_pic);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(246, 736);
            this.panel2.TabIndex = 1;
            // 
            // name1_lbl
            // 
            this.name1_lbl.BackColor = System.Drawing.Color.Transparent;
            this.name1_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name1_lbl.ForeColor = System.Drawing.Color.Gray;
            this.name1_lbl.Location = new System.Drawing.Point(38, 145);
            this.name1_lbl.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.name1_lbl.Name = "name1_lbl";
            this.name1_lbl.Size = new System.Drawing.Size(74, 22);
            this.name1_lbl.TabIndex = 12;
            this.name1_lbl.Text = "freelancer";
            // 
            // free_logout
            // 
            this.free_logout.Animated = true;
            this.free_logout.BorderColor = System.Drawing.Color.White;
            this.free_logout.BorderRadius = 10;
            this.free_logout.BorderThickness = 1;
            this.free_logout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.free_logout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.free_logout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.free_logout.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.free_logout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.free_logout.FillColor = System.Drawing.Color.White;
            this.free_logout.FillColor2 = System.Drawing.Color.White;
            this.free_logout.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.free_logout.ForeColor = System.Drawing.Color.Gray;
            this.free_logout.HoverState.FillColor = System.Drawing.Color.White;
            this.free_logout.HoverState.FillColor2 = System.Drawing.Color.White;
            this.free_logout.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.free_logout.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.free_logout.Image = ((System.Drawing.Image)(resources.GetObject("free_logout.Image")));
            this.free_logout.ImageSize = new System.Drawing.Size(40, 40);
            this.free_logout.IndicateFocus = true;
            this.free_logout.Location = new System.Drawing.Point(60, 654);
            this.free_logout.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.free_logout.Name = "free_logout";
            this.free_logout.Size = new System.Drawing.Size(119, 37);
            this.free_logout.TabIndex = 27;
            this.free_logout.Text = "Log Out";
            this.free_logout.Click += new System.EventHandler(this.free_logout_Click);
            // 
            // feedback_pjs
            // 
            this.feedback_pjs.Animated = true;
            this.feedback_pjs.BorderColor = System.Drawing.Color.White;
            this.feedback_pjs.BorderRadius = 10;
            this.feedback_pjs.BorderThickness = 1;
            this.feedback_pjs.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.feedback_pjs.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.feedback_pjs.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.feedback_pjs.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.feedback_pjs.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.feedback_pjs.FillColor = System.Drawing.Color.White;
            this.feedback_pjs.FillColor2 = System.Drawing.Color.White;
            this.feedback_pjs.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feedback_pjs.ForeColor = System.Drawing.Color.Gray;
            this.feedback_pjs.HoverState.FillColor = System.Drawing.Color.White;
            this.feedback_pjs.HoverState.FillColor2 = System.Drawing.Color.White;
            this.feedback_pjs.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.feedback_pjs.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.feedback_pjs.Image = ((System.Drawing.Image)(resources.GetObject("feedback_pjs.Image")));
            this.feedback_pjs.ImageSize = new System.Drawing.Size(40, 40);
            this.feedback_pjs.Location = new System.Drawing.Point(38, 446);
            this.feedback_pjs.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.feedback_pjs.Name = "feedback_pjs";
            this.feedback_pjs.Size = new System.Drawing.Size(155, 55);
            this.feedback_pjs.TabIndex = 10;
            this.feedback_pjs.Text = "Feedback";
            this.feedback_pjs.Click += new System.EventHandler(this.feedback_pjs_Click);
            // 
            // projects
            // 
            this.projects.Animated = true;
            this.projects.BorderColor = System.Drawing.Color.White;
            this.projects.BorderRadius = 10;
            this.projects.BorderThickness = 1;
            this.projects.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.projects.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.projects.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.projects.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.projects.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.projects.FillColor = System.Drawing.Color.White;
            this.projects.FillColor2 = System.Drawing.Color.White;
            this.projects.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projects.ForeColor = System.Drawing.Color.Gray;
            this.projects.HoverState.FillColor = System.Drawing.Color.White;
            this.projects.HoverState.FillColor2 = System.Drawing.Color.White;
            this.projects.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.projects.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.projects.Image = ((System.Drawing.Image)(resources.GetObject("projects.Image")));
            this.projects.ImageSize = new System.Drawing.Size(40, 40);
            this.projects.Location = new System.Drawing.Point(38, 364);
            this.projects.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.projects.Name = "projects";
            this.projects.Size = new System.Drawing.Size(155, 61);
            this.projects.TabIndex = 9;
            this.projects.Text = "Projects";
            this.projects.Click += new System.EventHandler(this.projects_Click);
            // 
            // member
            // 
            this.member.Animated = true;
            this.member.BorderColor = System.Drawing.Color.White;
            this.member.BorderRadius = 10;
            this.member.BorderThickness = 1;
            this.member.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.member.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.member.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.member.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.member.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.member.FillColor = System.Drawing.Color.White;
            this.member.FillColor2 = System.Drawing.Color.Transparent;
            this.member.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.member.ForeColor = System.Drawing.Color.Gray;
            this.member.HoverState.FillColor = System.Drawing.Color.White;
            this.member.HoverState.FillColor2 = System.Drawing.Color.White;
            this.member.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.member.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.member.Image = ((System.Drawing.Image)(resources.GetObject("member.Image")));
            this.member.ImageSize = new System.Drawing.Size(40, 40);
            this.member.Location = new System.Drawing.Point(38, 289);
            this.member.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.member.Name = "member";
            this.member.Size = new System.Drawing.Size(155, 61);
            this.member.TabIndex = 7;
            this.member.Text = "Project Posts";
            this.member.Click += new System.EventHandler(this.member_Click);
            // 
            // dashboard
            // 
            this.dashboard.Animated = true;
            this.dashboard.BorderColor = System.Drawing.Color.White;
            this.dashboard.BorderRadius = 10;
            this.dashboard.BorderThickness = 1;
            this.dashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.dashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.dashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.dashboard.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.dashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.dashboard.FillColor = System.Drawing.Color.White;
            this.dashboard.FillColor2 = System.Drawing.Color.White;
            this.dashboard.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard.ForeColor = System.Drawing.Color.Gray;
            this.dashboard.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dashboard.HoverState.BorderColor = System.Drawing.Color.White;
            this.dashboard.HoverState.FillColor = System.Drawing.Color.White;
            this.dashboard.HoverState.FillColor2 = System.Drawing.Color.White;
            this.dashboard.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dashboard.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image4")));
            this.dashboard.Image = ((System.Drawing.Image)(resources.GetObject("dashboard.Image")));
            this.dashboard.ImageSize = new System.Drawing.Size(40, 40);
            this.dashboard.Location = new System.Drawing.Point(38, 219);
            this.dashboard.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.dashboard.Name = "dashboard";
            this.dashboard.Size = new System.Drawing.Size(155, 51);
            this.dashboard.TabIndex = 6;
            this.dashboard.Text = "Dashboard";
            // 
            // skills_lbl
            // 
            this.skills_lbl.BackColor = System.Drawing.Color.Transparent;
            this.skills_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skills_lbl.ForeColor = System.Drawing.Color.Gray;
            this.skills_lbl.Location = new System.Drawing.Point(38, 171);
            this.skills_lbl.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.skills_lbl.Name = "skills_lbl";
            this.skills_lbl.Size = new System.Drawing.Size(128, 22);
            this.skills_lbl.TabIndex = 3;
            this.skills_lbl.Text = "Python Developer";
            // 
            // name_lbl
            // 
            this.name_lbl.BackColor = System.Drawing.Color.Transparent;
            this.name_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_lbl.Location = new System.Drawing.Point(119, 252);
            this.name_lbl.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(3, 2);
            this.name_lbl.TabIndex = 2;
            this.name_lbl.Text = null;
            // 
            // pf_pic
            // 
            this.pf_pic.BackColor = System.Drawing.Color.Transparent;
            this.pf_pic.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.pf_pic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pf_pic.HoverState.ImageSize = new System.Drawing.Size(110, 110);
            this.pf_pic.Image = ((System.Drawing.Image)(resources.GetObject("pf_pic.Image")));
            this.pf_pic.ImageOffset = new System.Drawing.Point(0, 0);
            this.pf_pic.ImageRotate = 0F;
            this.pf_pic.ImageSize = new System.Drawing.Size(100, 100);
            this.pf_pic.IndicateFocus = true;
            this.pf_pic.Location = new System.Drawing.Point(60, 25);
            this.pf_pic.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.pf_pic.Name = "pf_pic";
            this.pf_pic.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image5")));
            this.pf_pic.PressedState.ImageSize = new System.Drawing.Size(123, 123);
            this.pf_pic.Size = new System.Drawing.Size(119, 101);
            this.pf_pic.TabIndex = 2;
            this.pf_pic.Click += new System.EventHandler(this.pf_pic_Click);
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(266, 34);
            this.guna2HtmlLabel3.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(101, 28);
            this.guna2HtmlLabel3.TabIndex = 4;
            this.guna2HtmlLabel3.Text = "Welcome,";
            // 
            // name2_lbl
            // 
            this.name2_lbl.BackColor = System.Drawing.Color.Transparent;
            this.name2_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name2_lbl.ForeColor = System.Drawing.Color.Gray;
            this.name2_lbl.Location = new System.Drawing.Point(369, 35);
            this.name2_lbl.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.name2_lbl.Name = "name2_lbl";
            this.name2_lbl.Size = new System.Drawing.Size(44, 27);
            this.name2_lbl.TabIndex = 4;
            this.name2_lbl.Text = "User";
            // 
            // notibox
            // 
            this.notibox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.notibox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notibox.FormattingEnabled = true;
            this.notibox.ItemHeight = 25;
            this.notibox.Location = new System.Drawing.Point(1022, 85);
            this.notibox.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.notibox.Name = "notibox";
            this.notibox.Size = new System.Drawing.Size(344, 329);
            this.notibox.TabIndex = 0;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Panel1.BorderRadius = 67;
            this.guna2Panel1.Location = new System.Drawing.Point(1022, 418);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(344, 318);
            this.guna2Panel1.TabIndex = 8;
            // 
            // refresh_noti
            // 
            this.refresh_noti.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.refresh_noti.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.refresh_noti.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.refresh_noti.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.refresh_noti.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.refresh_noti.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.refresh_noti.FillColor2 = System.Drawing.Color.Teal;
            this.refresh_noti.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.refresh_noti.ForeColor = System.Drawing.Color.White;
            this.refresh_noti.Location = new System.Drawing.Point(1254, 46);
            this.refresh_noti.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.refresh_noti.Name = "refresh_noti";
            this.refresh_noti.Size = new System.Drawing.Size(112, 35);
            this.refresh_noti.TabIndex = 9;
            this.refresh_noti.Text = "Refresh Noti";
            this.refresh_noti.Click += new System.EventHandler(this.refresh_noti_Click);
            // 
            // project_feeds
            // 
            this.project_feeds.AutoScroll = true;
            this.project_feeds.BackColor = System.Drawing.Color.WhiteSmoke;
            this.project_feeds.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.project_feeds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.project_feeds.Location = new System.Drawing.Point(248, 85);
            this.project_feeds.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.project_feeds.Name = "project_feeds";
            this.project_feeds.Size = new System.Drawing.Size(772, 651);
            this.project_feeds.TabIndex = 10;
            this.project_feeds.WrapContents = false;
            // 
            // refresh_btn
            // 
            this.refresh_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.refresh_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.refresh_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.refresh_btn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.refresh_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.refresh_btn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.refresh_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.refresh_btn.ForeColor = System.Drawing.Color.White;
            this.refresh_btn.Location = new System.Drawing.Point(941, 46);
            this.refresh_btn.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Size = new System.Drawing.Size(106, 35);
            this.refresh_btn.TabIndex = 11;
            this.refresh_btn.Text = "Refresh Projects";
            this.refresh_btn.Click += new System.EventHandler(this.refresh_btn_Click);
            // 
            // guna2ImageButton2
            // 
            this.guna2ImageButton2.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton2.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton2.Image")));
            this.guna2ImageButton2.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton2.ImageRotate = 0F;
            this.guna2ImageButton2.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2ImageButton2.Location = new System.Drawing.Point(657, 25);
            this.guna2ImageButton2.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.guna2ImageButton2.Name = "guna2ImageButton2";
            this.guna2ImageButton2.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton2.Size = new System.Drawing.Size(62, 47);
            this.guna2ImageButton2.TabIndex = 5;
            // 
            // freelance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1376, 736);
            this.Controls.Add(this.notibox);
            this.Controls.Add(this.refresh_btn);
            this.Controls.Add(this.refresh_noti);
            this.Controls.Add(this.project_feeds);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2ImageButton2);
            this.Controls.Add(this.name2_lbl);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Name = "freelance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Apex";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2ImageButton pf_pic;
        private Guna.UI2.WinForms.Guna2HtmlLabel name_lbl;
        private Guna.UI2.WinForms.Guna2HtmlLabel skills_lbl;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel name2_lbl;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton2;
        private Guna.UI2.WinForms.Guna2GradientButton dashboard;
        private Guna.UI2.WinForms.Guna2GradientButton feedback_pjs;
        private Guna.UI2.WinForms.Guna2GradientButton projects;
        private Guna.UI2.WinForms.Guna2GradientButton member;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2GradientButton free_logout;
        private System.Windows.Forms.ListBox notibox;
        private Guna.UI2.WinForms.Guna2GradientButton refresh_noti;
        private System.Windows.Forms.FlowLayoutPanel project_feeds;
        private Guna.UI2.WinForms.Guna2GradientButton refresh_btn;
        private Guna.UI2.WinForms.Guna2HtmlLabel name1_lbl;
    }
}