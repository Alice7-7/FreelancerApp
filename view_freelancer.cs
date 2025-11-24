using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Freelance.Class;
using Guna.UI2.WinForms;

namespace Freelance
{
    public partial class view_freelancer : Form
    {
        public view_freelancer()
        {
            InitializeComponent();
            SetupFlowPanel();
            LoadFreelancers();
        }

        private void SetupFlowPanel()
        {
            freelancer_flow.WrapContents = false;
            freelancer_flow.FlowDirection = FlowDirection.TopDown;
            freelancer_flow.AutoScroll = true;
            freelancer_flow.HorizontalScroll.Enabled = true;
            freelancer_flow.HorizontalScroll.Visible = true;
            freelancer_flow.VerticalScroll.Visible = false; 
            freelancer_flow.Dock = DockStyle.Fill; 

        }

        private void LoadFreelancers()
        {
            freelancer_flow.Controls.Clear();

            string query = "SELECT * FROM freelancer_pf ";
            using (MySqlCommand cmd = new MySqlCommand(query, db_connection.cn))
            {
                db_connection.Open_con();
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string username = reader["username"].ToString();
                        string fullname = reader["name"].ToString();
                        string expertise = reader["expertise"].ToString();
                        string skills = reader["skills"]?.ToString() ?? "N/A";

                   
                        Guna2Panel card = new Guna2Panel
                        {
                            Width = 820,
                            Height = 400,
                            BorderRadius = 15,
                            BorderThickness = 1,
                            BorderColor = Color.LightGray,
                            FillColor = Color.White,
                            Margin = new Padding(15),
                            Padding = new Padding(10)
                           
                        };

                  
                        Guna2HtmlLabel lblName = new Guna2HtmlLabel
                        {
                            Text = "Name: "+ fullname,
                            Font = new Font("Bell MT", 12, FontStyle.Bold),
                            Location = new Point(20, 20),
                            AutoSize = true
                        };

                   
                        Guna2HtmlLabel lblExpertise = new Guna2HtmlLabel
                        {
                            Text = "Expertise: " + expertise,
                            Font = new Font("Segoe UI", 10),
                            Location = new Point(20, 100),
                            AutoSize = true
                        };

                        Guna2HtmlLabel lblSkills = new Guna2HtmlLabel
                        {
                            Text = "Skills: " + skills,
                            Font = new Font("Segoe UI", 10),
                            Location = new Point(20, 200),
                            AutoSize = true
                        };

                      
                        Guna2Button btnViewProfile = new Guna2Button
                        {
                            Text = "View Profile",
                            Size = new Size(210, 80),
                            TextAlign = HorizontalAlignment.Center,
                            TextOffset = new Point(0, 0),
                            Location = new Point(20, 310),
                            BorderRadius = 10,
                            FillColor = Color.DarkCyan,
                            Font = new Font("Bell MT", 10, FontStyle.Bold),
                            Tag = username
                        };
                        btnViewProfile.Click += BtnViewProfile_Click;

                    

                     
                        card.Controls.Add(lblName);
                        card.Controls.Add(lblExpertise);
                        card.Controls.Add(lblSkills);
                        card.Controls.Add(btnViewProfile);
                      

                      
                        freelancer_flow.Controls.Add(card);
                    }
                }
                db_connection.Close_con();
            }
        }

        private void BtnViewProfile_Click(object sender, EventArgs e)
        {
            Guna2Button btn = (Guna2Button)sender;
            string freelancerUsername = btn.Tag.ToString();

            freelance_profile profileForm = new freelance_profile(freelancerUsername);
            profileForm.Show();
        }
    }
}
