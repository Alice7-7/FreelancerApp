using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Freelance.Class;

namespace Freelance
{
    public partial class review_bids : Form
    {
        

        public review_bids()
        {
            InitializeComponent();
        
            LoadBids();
        }


        private void review_bids_Load(object sender, EventArgs e)
        {
            
        }


        private void LoadBids()
        {
            bids_layout.Controls.Clear();
            bids_layout.AutoScroll = true;

            MessageBox.Show($"Loading all bids for client: {Session_manage.Username}", "Debug Info");

            string query = @"
                        SELECT b.id, b.freelancer_username, b.proposal, b.amount, b.status , b.days
                        FROM bids b
                        JOIN projects p ON b.project_id = p.id
                        WHERE p.created_by = @client";

            try
            {
                MySqlCommand cmd = new MySqlCommand(query, db_connection.cn);
                cmd.Parameters.AddWithValue("@client", Session_manage.Username);

                db_connection.Open_con();
                MySqlDataReader reader = cmd.ExecuteReader();

                bool hasData = false;

                while (reader.Read())
                {
                    hasData = true;

                    int id = reader.GetInt32("id");
                    string freelancer = reader.GetString("freelancer_username");
                    string proposal = reader.GetString("proposal");
                    decimal amount = reader.GetDecimal("amount");
                    string status = reader.GetString("status");
                    string days = reader.GetString("days");

                    Panel card = CreateBidCard(id, freelancer, proposal,days , amount, status);
                    bids_layout.Controls.Add(card);
                }

                reader.Close();
                db_connection.Close_con();

                MessageBox.Show(hasData
                    ? "All bids loaded successfully."
                    : "No bids found for your projects.", "Result");
            }
            catch (Exception ex)
            {
                db_connection.Close_con();
                MessageBox.Show("Error loading bids:\n" + ex.Message, "db Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private Panel CreateBidCard(int bidId, string freelancer, string proposal,string days, decimal amount, string status)
        {
            Panel card = new Panel
            {
                Width = 1150,
                Height = 500,
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(10),
                Padding = new Padding(10)
            };

            Label lblFreelancer = new Label
            {
                Text = $"👤 {freelancer}",
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(10, 20)
            };

            Label lblPro = new Label
            {
                Text = $"📄 Proposal: {proposal}",
                Font = new Font("Segoe UI", 10),
                AutoSize = false,
                Width = 350,
                Height = 100,
                Location = new Point(10, 100)
            };

            Label lbldays = new Label
            {
                Text = $"Propose Day: {days}",
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                AutoSize = true,
                Location = new Point(10, 200)
            };

            Label lblAmount = new Label
            {
                Text = $"💰 Bid Amount: {amount} USD",
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                AutoSize = true,
                Location = new Point(10, 240)
            };

            Label lblStatus = new Label
            {
                Text = $"📌 Status: {status}",
                ForeColor = status == "accepted" ? Color.Green : (status == "declined" ? Color.Red : Color.Orange),
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(10, 290)
            };

        
            Button btnAccept = new Button
            {
                Text = "Accept",
                Width = 210,
                Height = 70,
                BackColor = Color.DarkCyan,
                ForeColor = Color.White,
                Font = new Font("Bell MT", 10, FontStyle.Bold),
                Location = new Point(10, 350),
                Enabled = status == "Pending",
            
            };
            btnAccept.Click += (s, e) => UpdateBidStatus(bidId, "accepted");

       
            Button btnReject = new  Button
            {
                Text = "Reject",
                Width = 210,
                Height = 70,
                BackColor = Color.DarkRed,
                ForeColor = Color.White,
                Font = new Font("Bell MT", 10, FontStyle.Bold),
                Location = new Point(240, 350),
                Enabled = status == "Pending",
               
            };
            btnReject.Click += (s, e) => UpdateBidStatus(bidId, "declined");

          
            card.Controls.Add(lblFreelancer);
            card.Controls.Add(lblPro);
            card.Controls.Add(lbldays);
            card.Controls.Add(lblAmount);
            card.Controls.Add(lblStatus);
            card.Controls.Add(btnAccept);
            card.Controls.Add(btnReject);

      
            btnAccept.BringToFront();
            btnReject.BringToFront();

            return card;
        }




        private void UpdateBidStatus(int bidId, string newStatus)
        {
            string query = "UPDATE bids SET status = @status WHERE id = @id";

            MySqlCommand cmd = new MySqlCommand(query, db_connection.cn);
            cmd.Parameters.AddWithValue("@status", newStatus);
            cmd.Parameters.AddWithValue("@id", bidId);

            db_connection.Open_con();
            cmd.ExecuteNonQuery();
            db_connection.Close_con();

            MessageBox.Show($"Bid has been {newStatus}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadBids(); 
        }

        private void bids_layout_Paint(object sender, PaintEventArgs e)
        {
            //LoadBids();
        }
    }
}
