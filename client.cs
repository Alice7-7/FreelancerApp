using Freelance.Class;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Freelance
{
    public partial class client : Form
    {
        public client()
        {
            InitializeComponent();
            Load_client_pf();
        }

        private void client_Load(object sender, EventArgs e)
        {
            LoadClientProjects();
        }

        private void Load_client_pf()
        {
            try
            {
                db_connection.Open_con();

                string query = "SELECT full_name , org_name FROM client_info WHERE username = @Username";

                using (MySqlCommand cmd = new MySqlCommand(query, db_connection.cn))
                {
                    cmd.Parameters.AddWithValue("@Username", Session_manage.Username);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            client_name_lbl.Text = reader["full_name"].ToString();
                            org_name_lbl.Text = reader["org_name"].ToString();
                            client_name2.Text = reader["full_name"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Profile not found.", "Error");
                            this.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                db_connection.Close_con();
            }
        }

        private void LoadClientProjects()
        {
            created_pjs.Controls.Clear();

            string query = "SELECT * FROM projects WHERE created_by = @client";

            MySqlCommand cmd = new MySqlCommand(query, db_connection.cn);
            cmd.Parameters.AddWithValue("@client", Session_manage.Username);

            db_connection.Open_con();
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int projectId = reader.GetInt32("id");
                string title = reader.GetString("title");
                string description = reader.GetString("description");
                decimal budget = reader.GetDecimal("budget");
                string deadline = reader.GetString("pj_deadline");

                Panel card = CreateProjectCard(projectId, title, description, budget, deadline);
                created_pjs.Controls.Add(card);
            }

            db_connection.Close_con();
        }

        private Panel CreateProjectCard(int projectId, string title, string description, decimal budget, string deadline)
        {
            Panel card = new Panel
            {
                Width = 870,
                Height = 350,
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                Padding = new Padding(10),
                Margin = new Padding(10)
            };

            

            Label lblTitle = new Label
            {
                Text = $"📌 {title}",
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(10, 10)
            };

            Label lblDesc = new Label
            {
                Text = $"📝 {description}",
                Font = new Font("Segoe UI", 10),
                Width = 700,
                Height = 60,
                Location = new Point(10, 100)
            };

            Label lblBudget = new Label
            {
                Text = $"💰 Budget: {budget} USD",
                Font = new Font("Segoe UI", 10),
                AutoSize = true,
                Location = new Point(10, 170)
            };

            Label lblDeadline = new Label
            {
                Text = $"📅 Deadline: {deadline}",
                Font = new Font("Segoe UI", 10),
                AutoSize = true,
                Location = new Point(10, 240)
            };

           
            card.Controls.Add(lblTitle);
            card.Controls.Add(lblDesc);
            card.Controls.Add(lblBudget);
            card.Controls.Add(lblDeadline);
        

            return card;
        }

        private void create_pj_Click(object sender, EventArgs e)
        {
            create_project CreatePj = new create_project(Session_manage.Username);
            CreatePj.Show();
        }

        private void client_pf_Click(object sender, EventArgs e)
        {
            client_profile ClientPf = new client_profile(Session_manage.Username);
            ClientPf.Show();
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            LoadClientProjects();
        }

        private void logout_btn_Click(object sender, EventArgs e)
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

        // Freelancer Profile :::

        private void view_fl_Click(object sender, EventArgs e)
        {
            view_freelancer vf = new view_freelancer();
            vf.Show();
        }

        // Review Bids :::

        private void review_bids_Click(object sender, EventArgs e)
        {
            review_bids reBid = new review_bids();
            reBid.Show();
        }

        // Review Projects :::

        private void review_pjs_Click(object sender, EventArgs e)
        {
            review_projects reviewPj = new review_projects();
            reviewPj.Show();
        }

        private void client_dashboard_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }
    }
}
