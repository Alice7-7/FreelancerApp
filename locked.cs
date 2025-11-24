using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Freelance
{
    public partial class locked : Form
    {

        private int seconds = 30;

        public locked()
        {
            InitializeComponent();

            Start_Countdown();
        }

        private void Start_Countdown()
        {
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += (s, e) =>
            {
                seconds--;
                time_out.Text = $"Please wait {seconds} seconds";

                if (seconds <= 0)
                {
                    timer.Stop();
                    login_form login_form = new login_form();
                    login_form.Show();
                    this.Close();
                }
            };
            timer.Start();
        }
    }
}
