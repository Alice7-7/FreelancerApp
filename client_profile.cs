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
    public partial class client_profile : Form
    {


        public client_profile(string username)
        {
            InitializeComponent();
        
        }

       

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void client_profile_Load(object sender, EventArgs e)
        {
            try
            {
                db_connection.Open_con();

                string query = "SELECT full_name, org_name, b_email, location FROM client_info WHERE username = @Username";

                using (MySqlCommand cmd = new MySqlCommand(query, db_connection.cn))
                {
                    cmd.Parameters.AddWithValue("@Username", Session_manage.Username);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            client_name.Text = reader["full_name"].ToString();
                            org_name.Text = reader["org_name"].ToString();
                            client_email.Text = reader["b_email"].ToString();
                           
                            client_location.Text = reader["location"].ToString();

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

        private void go_client_pf_Click(object sender, EventArgs e)
        {
           
        }
    }
}
