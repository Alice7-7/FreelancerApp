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
    public partial class review_projects : Form
    {
        public review_projects()
        {
            InitializeComponent();

            LoadCompletedProjects();

        }

        private void review_projects_Load(object sender, EventArgs e)
        {
        }

        private void review_pjs_flow_Paint(object sender, PaintEventArgs e)
        {

        }

        
        private void LoadCompletedProjects()
        {
                review_pjs_flow.Controls.Clear();

                var projects = Project_control.GetCompletedProjectsByClient(Session_manage.Username);

                foreach (var proj in projects)
                {
                    int projectId = (int)proj["ProjectId"];
                    string title = proj["Title"].ToString();
                    string description = proj["Description"].ToString();
                    decimal budget = (decimal)proj["Budget"];
                    string imageUrl = proj["ImageUrl"].ToString();
                    string freelancer = proj["Freelancer"].ToString();

                    Panel card = new Panel
                    {
                        Width = 780,
                        Height = 590,
                        BorderStyle = BorderStyle.FixedSingle,
                        Margin = new Padding(10),
                        BackColor = Color.White
                    };

                    PictureBox icon = new PictureBox
                    {
                        Width = 140,
                        Height = 140,
                        Location = new Point(10, 10),
                        ImageLocation = imageUrl,
                        SizeMode = PictureBoxSizeMode.Zoom
                    };
                    card.Controls.Add(icon);

                    card.Controls.Add(new Label
                    {
                        Text = title,
                        Font = new Font("Segoe UI", 14, FontStyle.Bold),
                        Location = new Point(160, 10),
                        AutoSize = true
                    });

                    card.Controls.Add(new Label
                    {
                        Text = $"By: {freelancer}",
                        Font = new Font("Segoe UI", 10, FontStyle.Italic),
                        ForeColor = Color.DarkSlateGray,
                        Location = new Point(160, 60),
                        AutoSize = true
                    });

                    card.Controls.Add(new Label
                    {
                        Text = $"Description: {description}",
                        Font = new Font("Segoe UI", 10),
                        Location = new Point(160, 90),
                        Size = new Size(600, 50),
                        AutoEllipsis = true
                    });

                    card.Controls.Add(new Label
                    {
                        Text = $"💰 Budget: ${budget:0.00}",
                        Font = new Font("Segoe UI", 11, FontStyle.Bold),
                        Location = new Point(160, 160),
                        AutoSize = true
                    });

                 
                    NumericUpDown rating = new NumericUpDown
                    {
                        Minimum = 1,
                        Maximum = 5,
                        Value = 5,
                        Location = new Point(160, 230),
                        Width = 60
                    };
                    card.Controls.Add(rating);

                    TextBox commentBox = new TextBox
                    {
                        Multiline = true,
                        Size = new Size(400, 80),
                        Location = new Point(160, 300)
                    };
                    card.Controls.Add(commentBox);

                    Button submitBtn = new Button
                    {
                        Text = "Submit Review",
                        BackColor = Color.DarkCyan,
                        ForeColor = Color.White,
                        Font = new Font("Bell MT", 10, FontStyle.Bold),
                        Location = new Point(160, 400),
                        Width = 260,
                        Height = 70,

                        Tag = new { ProjectId = projectId, Freelancer = freelancer, RatingBox = rating, CommentBox = commentBox }
                    };

                submitBtn.Click += (s, ev) =>
                {
                    dynamic data = ((Button)s).Tag;
                    int stars = (int)data.RatingBox.Value;
                    string comment = data.CommentBox.Text;
                    string clientUsername = Session_manage.Username;

                    if (Project_control.SubmitReview(data.ProjectId, data.Freelancer, clientUsername, stars, comment))
                    {
                        MessageBox.Show("Review submitted!");
                        LoadCompletedProjects();
                    }
                    else
                    {
                        MessageBox.Show("Failed to submit review.");
                    }
                };


                card.Controls.Add(submitBtn);
                    review_pjs_flow.Controls.Add(card);
                }
            }

    }
}
