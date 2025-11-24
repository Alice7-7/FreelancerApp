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
    public partial class splash : Form
    {

        //int move = 2;

        public splash()
        {
            InitializeComponent();
        }

        private void splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void splash_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;

            progressBar1.Increment(2);

            if (progressBar1.Value == 100)
            {
                timer1.Enabled = false;
                started form = new started();

                form.Show();
                this.Hide();
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
