using Freelance.Class;
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

namespace Freelance
{
    public partial class login_form : Form
    {
        public login_form()
        {
            InitializeComponent();
        }

        private void Sign_In_lbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            role select_role = new role();
            select_role.ShowDialog();
        }

        private void login_form_Load(object sender, EventArgs e)
        {
            
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            string usernameInput = username_inp.Text.Trim();
            string passwordInput = password_inp.Text;

            
            // Check user locked or not !

            if (loginattempt_control.IsLocked(usernameInput))
            {
                MessageBox.Show("Account is temporarily locked due to multiple failed attempts.\nTry again in 30 seconds.");
                new locked().Show();
                this.Hide();
                return;
            }

        
            string result = Login_control.Login(usernameInput, passwordInput, out string role);

            if (result == "Success")
            {
                loginattempt_control.ResetAttempts(usernameInput); 

                if (Session_manage.Role == "Freelancer")
                {
                    MessageBox.Show($"Logged in as: {Session_manage.Username} ({Session_manage.Role})");

                    freelance freelanceDash = new freelance();
                    freelanceDash.Show();
                    this.Hide();
                }
                else if (Session_manage.Role == "Client")
                {
                    MessageBox.Show($"Logged in as: {Session_manage.Username} ({Session_manage.Role})");

                    client clientDash = new client();
                    clientDash.Show();
                    this.Hide();
                }
            }
            else
            {
                loginattempt_control.RegisterFailure(usernameInput); 
                MessageBox.Show(result, "Login Failed");
            }
        }

        private void showpass_CheckedChanged(object sender, EventArgs e)
        {
            bool show = showpass.Checked;

            password_inp.UseSystemPasswordChar = !show;
        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
