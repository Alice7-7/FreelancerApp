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
using Freelance.Class;

namespace Freelance
{
    public partial class create_freelance_pf : Form
    {

     
        public create_freelance_pf(string username)
        {
            InitializeComponent(); 
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pf_submit_Click(object sender, EventArgs e)
        {
            string name = name_txt.Text.Trim();
            string skills = skills_txt.Text.Trim();
            string expertise = expertise_txt.Text.Trim();
            string pastWork = past_work_txt.Text.Trim();
            string location = location_txt.Text.Trim();
            string bio = bio_txt.Text.Trim();

            if (string.IsNullOrEmpty(skills) || string.IsNullOrEmpty(expertise) ||
                string.IsNullOrEmpty(pastWork) || string.IsNullOrEmpty(location) ||
                string.IsNullOrEmpty(bio))
            {
                MessageBox.Show("Please fill out all required fields.");
                return;
            }

            try
            {
                db_connection.Open_con();

                string query = "INSERT INTO freelancer_pf (username, name , skills, expertise, past_work, location, bio) " +
                               "VALUES (@Username,@Name , @Skills, @Expertise, @PastWork, @Location , @Bio)";

                using (MySqlCommand cmd = new MySqlCommand(query, db_connection.cn))
                {
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Username", Session_manage.Username);
                    cmd.Parameters.AddWithValue("@Skills", skills);
                    cmd.Parameters.AddWithValue("@Expertise", expertise);
                    cmd.Parameters.AddWithValue("@PastWork", pastWork);
                    cmd.Parameters.AddWithValue("@Location", location);
                    cmd.Parameters.AddWithValue("@Bio", bio);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Profile created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                freelance dashboardForm = new freelance(); 
                dashboardForm.Show();
                this.Close();


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

        private void skills_TextChanged(object sender, EventArgs e)
        {

        }

        private void create_freelance_pf_Load(object sender, EventArgs e)
        {

        }

        private void past_work_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
