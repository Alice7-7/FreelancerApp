using Freelance.Class;
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


namespace Freelance
{
    public partial class role : Form
    {


        public role()
        {
            InitializeComponent();
        }

        private void client_role_Click(object sender, EventArgs e)
        {

            Session_manage.Role = "Client";
            OpenRegisterForm();

        }

        private void freelancer_Click(object sender, EventArgs e)
        {
            Session_manage.Role = "Freelancer";
            OpenRegisterForm();
        }

        private void OpenRegisterForm()
        {
            this.Hide();
            register_form registerForm = new register_form();
            registerForm.Show();
        }

        private void role_Load(object sender, EventArgs e)
        {

        }

        private void go_login_Click(object sender, EventArgs e)
        {
           
        }

        private void Sign_In_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            login_form Login = new login_form();
            Login.ShowDialog();
        }
    }
}
