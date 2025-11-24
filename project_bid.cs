using Freelance.Class;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Windows.Forms;

namespace Freelance
{
    public partial class project_bid : Form
    {
        private int projectId;
        private string projectTitle;

        public project_bid(int id, string title)
        {
            InitializeComponent();
            projectId = id;
            projectTitle = title;
            pj_title.Text = projectTitle;
            status.Text = "Pending...";
            freelance_username.Text = Session_manage.Username;
        }


        private void submit_bid_Click(object sender, EventArgs e)
        {
            string bidAmount = bid_amount.Text.Trim();
            string proposal = proposal_msg.Text.Trim();
            string deadline = complete_time.Value.ToString("yyyy-MM-dd");
            string freelancerUsername = freelance_username.Text;

            if (string.IsNullOrEmpty(bidAmount) || string.IsNullOrEmpty(proposal))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            bool success = bid_control.SubmitBid(projectId, freelancerUsername, bidAmount, proposal, deadline);
            if (success)
            {
                

                MessageBox.Show("Bid submitted successfully!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error submitting bid.");
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}
