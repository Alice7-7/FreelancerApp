using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Freelance.Class
{
    public class bid_control
    {
        public static bool SubmitBid(int projectId, string username, string amount, string proposal, string deadline)
        {
            try
            {
                string query = "INSERT INTO bids (project_id, freelancer_username, amount, days, proposal, status) " +
                               "VALUES (@projectId, @username, @amount, @deadline, @proposal,  'Pending')";

                using (MySqlCommand cmd = new MySqlCommand(query, db_connection.cn))
                {
                    cmd.Parameters.AddWithValue("@projectId", projectId);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@amount", amount);
                    cmd.Parameters.AddWithValue("@deadline", deadline);
                    cmd.Parameters.AddWithValue("@proposal", proposal);

                    db_connection.Open_con();
                    cmd.ExecuteNonQuery();
                    db_connection.Close_con();
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
                return false;
            }
        }
    }
}
