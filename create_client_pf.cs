using Freelance.Class;
using Freelance.Controllers;
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

namespace Freelance
{
    public partial class create_client_pf : Form
    {


        public create_client_pf(string username)
        {
            InitializeComponent();
           

        }

        private void client_pic_Click(object sender, EventArgs e)
        {
           
        }

        private void client_submit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(client_name.Text) ||
                string.IsNullOrWhiteSpace(org_name.Text) ||
                string.IsNullOrWhiteSpace(b_email.Text) ||
                string.IsNullOrWhiteSpace(org_location.Text))
            {
                MessageBox.Show("Please fill in all the fields.");
                return;
            }

            ClientInfo client = new ClientInfo
            {
                Username = Session_manage.Username,
                FullName = client_name.Text,
                OrgName = org_name.Text,
                BEmail = b_email.Text,
                Location = org_location.Text
            };

            try
            {
                ClientInfoController.SaveClientInfo(client);
                MessageBox.Show("Information saved successfully!");

                client client_dash = new client();
                client_dash.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while saving info: " + ex.Message);
            }
        }

    }
}
