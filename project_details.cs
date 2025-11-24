using System;
using System.Drawing;
using System.Windows.Forms;
using Freelance.Class;

namespace Freelance
{
    public partial class project_details : Form
    {
        private int projectId;
        private string projectTitle;

        public project_details(int id, string title, string description, string orgName, decimal budget, string prerequisites,string Deadline, string imageUrl)
        {

            this.Cursor = Cursors.Default;



            this.projectId = id;
            this.projectTitle = title;

            this.Size = new Size(850, 790);
            
            

            // Project Image
            PictureBox pic = new PictureBox
            {
                Size = new Size(120, 120),
                Location = new Point(30, 30),
                ImageLocation = imageUrl,
                SizeMode = PictureBoxSizeMode.StretchImage,
                BorderStyle = BorderStyle.None
            };
            this.Controls.Add(pic);

            // Org Name
            Label lblOrg = new Label
            {
                Text = $"{orgName}",
                Font = new Font("Bell MT", 14, FontStyle.Bold),
                Location = new Point(250, 30),
                AutoSize = true
            };
            this.Controls.Add(lblOrg);

            // Title
            Label lblTitle = new Label
            {
                Text = $"{title}",
                Font = new Font("Bell MT", 13, FontStyle.Italic),
                Location = new Point(250, 100),
                AutoSize = true
            };
            this.Controls.Add(lblTitle);

            // Budget
            Label lblBudget = new Label
            {
                Text = $"Budget: ${budget:0.00}",
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                ForeColor = Color.Green,
                Location = new Point(250, 160),
                AutoSize = true
            };
            this.Controls.Add(lblBudget);

            // Description
            Label lblDesc = new Label
            {
                Text = $"📝 Description:\n{description}",
                Font = new Font("Segoe UI", 10),
                Location = new Point(250, 220),
                Size = new Size(240, 120)
            };
            this.Controls.Add(lblDesc);

            // Deadline 

            Label lblend = new Label
            {
                Text = $"Deadline :\n{Deadline}",
                Font = new Font("Segoe UI", 10),
                Location = new Point(250, 360),
                Size = new Size(320, 120)
            };
            this.Controls.Add(lblend);


            // Prerequisites
            Label lblPre = new Label
            {
                Text = $"Prerequisites:\n{prerequisites}",
                Font = new Font("Segoe UI", 10),
                Location = new Point(250, 490),
                Size = new Size(320, 140)
            };
            this.Controls.Add(lblPre);

     

            // Go to Bid 
            Button btnBid = new Button
            {
                Text = "Start Bid",
                BackColor = Color.Teal,
                ForeColor = Color.White,
                Font = new Font("Bell MT", 12, FontStyle.Bold),
                Size = new Size(220, 80),
                Location = new Point(250, 620),
                FlatStyle = FlatStyle.Flat
            };
            btnBid.FlatAppearance.BorderSize = 0;
            btnBid.Click += (s, e) =>
            {
                project_bid bidForm = new project_bid(projectId, projectTitle);
                bidForm.Show();
            };
            this.Controls.Add(btnBid);
        }

    }
}
