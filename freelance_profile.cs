using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
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
    public partial class freelance_profile : Form
    {


        private string freelancerUsername;

        public freelance_profile(string username = null)
        {
            InitializeComponent();

           
            freelancerUsername = username ?? Session_manage.Username;
        }


        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel8_Click(object sender, EventArgs e)
        {

        }

        private void freelance_profile_Load(object sender, EventArgs e)
        {
            try
            {
                db_connection.Open_con();

                string query = "SELECT name, skills, expertise, past_work , bio ,location FROM freelancer_pf WHERE username = @Username";

                using (MySqlCommand cmd = new MySqlCommand(query, db_connection.cn))
                {
                    cmd.Parameters.AddWithValue("@Username", freelancerUsername);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            name_lbl.Text = reader["name"].ToString();
                            skills_lbl.Text = reader["skills"].ToString();
                            expertise_lbl.Text = reader["expertise"].ToString();
                            past_lbl.Text = reader["past_work"].ToString();
                            bio_lbl.Text = reader["bio"].ToString();
                            locate_lbl.Text = reader["location"].ToString();

                        }
                        else
                        {
                            MessageBox.Show("Profile not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            this.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db_connection.Close_con();
            }
        }
    }
}

