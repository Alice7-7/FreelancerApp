using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Freelance
{
    public partial class started : Form
    {

        public started()
        {
           

            InitializeComponent();
            Get_Started.Enabled = false;
        }

        private int count = 1;


        private void slider()
        {
            
            if(count == 4)
            {
                count = 1;
            }
            Pic_1.ImageLocation = string.Format(@"Img\{0}.png", count);
            count++;

        }

        private void started_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            slider();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox2_Click(object sender, EventArgs e)
        {

        }

        private void Get_Started_Click(object sender, EventArgs e)
        {
            if (!Agree.Checked)
            {
                MessageBox.Show("Please agree to the terms before continuing.", "Agreement Required");
                return;
            }

            this.Hide();
            role roleForm = new role();
            roleForm.Show();
        }


        private void Agree_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void Agree_CheckedChanged_1(object sender, EventArgs e)
        {
            Get_Started.Enabled = Agree.Checked;
        }

        private void Pic_1_Click(object sender, EventArgs e)
        {

        }
    }
}
