using Freelance.Controllers;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Freelance.Class;

namespace Freelance
{
    public partial class freelance : Form
    {

       
        public freelance()
        {
            InitializeComponent();

           


            Load_freelancer_pf();

            LoadNotifications();

            LoadProjects();
        }


        private void Load_freelancer_pf()
        {
            try
            {
                var freelancer = Freelance_control.GetFreelancerShortProfile(Session_manage.Username);

                if (freelancer != null)
                {
                    name1_lbl.Text = freelancer.Name;
                    skills_lbl.Text = freelancer.Expertise;
                    name2_lbl.Text = freelancer.Name;
                }
                else
                {
                    MessageBox.Show("Profile not found.", "Error");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        // Loading Notifications ...

        private void LoadNotifications()
        {
            List<Notification> notifs = NotificationController.GetNotificationsForRole("freelancer");

            notibox.Items.Clear(); 

            foreach (var notif in notifs)
            {
                notibox.Items.Add($"[{notif.CreatedAt:MM/dd HH:mm}] 📢 New project posted ");
                notibox.Items.Add($"{notif.Message}");
            }
        }

        // Refresh Noti...

        private void refresh_noti_Click(object sender, EventArgs e)
        {
            LoadNotifications();
        }



        private void pf_pic_Click(object sender, EventArgs e)
        {

            freelance_profile profileForm = new freelance_profile(Session_manage.Username);
            profileForm.Show();
        }

        private void LoadProjects()
        {
            project_feeds.Controls.Clear(); 



            List<Project> projects = Project_control.GetAllProjects();

            foreach (var project in projects)
            {
                bool buttonClicked = false; 

                Panel card = new Panel
                {
                    Width = 728,
                    Height = 260,
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(10),
                    BackColor = Color.White,
                    
                };

                PictureBox icon = new PictureBox
                {
                    Width = 110,
                    Height = 110,
                    Location = new Point(10, 10),
                    ImageLocation = project.ImageUrl,
                    SizeMode = PictureBoxSizeMode.Zoom
                };
                card.Controls.Add(icon);

                Label title = new Label
                {
                    Text = project.OrgName,
                    Font = new Font("Segoe UI", 14, FontStyle.Bold),
                    Location = new Point(150, 10),
                    AutoSize = true
                };
                card.Controls.Add(title);

                Label desc = new Label
                {
                    Text = $"{project.Title}",
                    Font = new Font("Segoe UI", 10),
                    Location = new Point(150, 100),
                    Size = new Size(200, 50),
                    AutoEllipsis = true
                };
                card.Controls.Add(desc);

                Label desc2 = new Label
                {
                    Text = $"Desc: {project.Description}",
                    Font = new Font("Bell MT", 10),
                    Location = new Point(150, 160),
                    Size = new Size(200, 50),
                    AutoEllipsis = true
                };
                card.Controls.Add(desc2);

                Label budget = new Label
                {
                    Text = $"💰 Budget: ${project.Budget:0.00}",
                    Font = new Font("Segoe UI", 11, FontStyle.Bold),
                    ForeColor = Color.Black,
                    Location = new Point(450, 10),
                    AutoSize = true
                };
                card.Controls.Add(budget);

              

                Button detailsBtn = new Button
                {
                    Text = "View",
                    Width = 180,
                    Height = 60,
                    BackColor = Color.DarkCyan,
                    ForeColor = Color.White,
                    Location = new Point(450, 130)
                };
                detailsBtn.Click += (s, ev) =>
                {
                    buttonClicked = true;
                    project_details detailsForm = new project_details(
                        project.Id,
                        project.Title,
                        project.Description,
                        project.OrgName,
                        project.Budget,
                        project.Prerequisites,
                        project.Deadline,
                        project.ImageUrl
                    );
                    detailsForm.Show();
                };
                card.Controls.Add(detailsBtn);

                // card pop up :::

                card.Click += (s, ev) =>
                {
                    if (!buttonClicked)
                    {
                        project_details detailsForm = new project_details(
                            project.Id,
                            project.Title,
                            project.Description,
                            project.OrgName,
                            project.Budget,
                            project.Prerequisites,
                            project.Deadline,
                            project.ImageUrl
                        );
                        detailsForm.Show();
                    }
                    buttonClicked = false; 
                };

                project_feeds.Controls.Add(card);
            }
        }



        private void refresh_btn_Click(object sender, EventArgs e)
        {
            LoadProjects();
        }

        private void free_logout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Session_manage.Session_Clear();

                login_form loginForm = new login_form();
                loginForm.Show();

                this.Close();
            }
        }

        private void projects_Click(object sender, EventArgs e)
        {
            load_bids loadbid = new load_bids();
            loadbid.Show();
        }

        private void feedback_pjs_Click(object sender, EventArgs e)
        {
            feedback fb = new feedback();
            fb.Show();
        }

        private void member_Click(object sender, EventArgs e)
        {

        }
    }
}
