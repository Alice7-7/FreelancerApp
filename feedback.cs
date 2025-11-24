using Freelance.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Freelance
{
    public partial class feedback : Form
    {
        public feedback()
        {
            InitializeComponent();

            
        }

        private void feedback_flow_Paint(object sender, PaintEventArgs e)
        {

        }

        private void feedback_Load(object sender, EventArgs e)
        {
            feedback_flow.Controls.Clear();
            string currentFreelancer = Session_manage.Username;

            var reviews = Project_control.GetReviewsForFreelancer(currentFreelancer); 

            foreach (var r in reviews)
            {
                Panel card = new Panel
                {
                    Width = 830,
                    Height = 400,
                    BackColor = Color.WhiteSmoke,
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(10)
                    
                };

                Label lblProject = new Label
                {
                    Text = "Project: " + r["project_title"].ToString(),
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    Location = new Point(10, 20),
                    AutoSize = true
                };

                Label lblClient = new Label
                {
                    Text = "Client: " + r["client_username"].ToString(),
                    Location = new Point(10, 120),
                    AutoSize = true
                };

                Label lblRating = new Label
                {
                    Text = "Rating: " + r["rating"].ToString() + " ⭐",
                    Location = new Point(10, 180),
                    AutoSize = true
                };

                Label lblComment = new Label
                {
                    Text = "Comment: " + r["comment"].ToString(),
                    Location = new Point(10, 280),
                    Size = new Size(260, 50),
                    MaximumSize = new Size(460, 0),
                    AutoSize = true
                };

                card.Controls.Add(lblProject);
                card.Controls.Add(lblClient);
                card.Controls.Add(lblRating);
                card.Controls.Add(lblComment);

                feedback_flow.Controls.Add(card);
            }
        }
    }
}

