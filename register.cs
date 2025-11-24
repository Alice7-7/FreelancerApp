using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Freelance.Controllers;
using Freelance.Class;



namespace Freelance
{
    public partial class register_form : Form
    {
        public register_form()
        {
            InitializeComponent();
        }

        private void register_form_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Role on register form load: " + Session_manage.Role);
        }


        private void register_btn_Click(object sender, EventArgs e)
        {
            Controllers.Register_control.RegisterUser(username.Text, password.Text, c_password.Text, this);

        }



        private void Freelance_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            this.Hide();
            login_form Login = new login_form();
            Login.ShowDialog();
        }

        private void showpass1_CheckedChanged(object sender, EventArgs e)
        {
            bool show = showpass1.Checked;

            password.UseSystemPasswordChar = !show;
           
        }

        private void showpass2_CheckedChanged(object sender, EventArgs e)
        {
            bool show2 = showpass2.Checked;

            c_password.UseSystemPasswordChar = !show2;
        }
    }
}
