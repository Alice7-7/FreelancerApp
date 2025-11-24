using Freelance.Class;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Freelance.Controllers
{
    public class ClientInfoController
    {
        public static void SaveClientInfo(ClientInfo client)
        {
            string insertQuery = @"INSERT INTO client_info (username, full_name, org_name, b_email, location)
                           VALUES (@Username, @FullName, @OrgName, @BEmail, @Location)";

            try
            {
                db_connection.Open_con();

             
                if (!UserExists(client.Username))
                {
                    MessageBox.Show($"Username '{client.Username}' does not exist in the users table.");
                    return;
                }

                using (MySqlCommand cmd = new MySqlCommand(insertQuery, db_connection.cn))
                {
                    cmd.Parameters.AddWithValue("@Username", client.Username ?? string.Empty);
                    cmd.Parameters.AddWithValue("@FullName", client.FullName ?? string.Empty);
                    cmd.Parameters.AddWithValue("@OrgName", client.OrgName ?? string.Empty);
                    cmd.Parameters.AddWithValue("@BEmail", client.BEmail ?? string.Empty);
                    cmd.Parameters.AddWithValue("@Location", client.Location ?? string.Empty);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Database error occurred: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message);
            }
            finally
            {
                db_connection.Close_con();
            }
        }

        private static bool UserExists(string username)
        {
            string query = "SELECT COUNT(*) FROM users WHERE username = @Username";
            using (MySqlCommand cmd = new MySqlCommand(query, db_connection.cn))
            {
                cmd.Parameters.AddWithValue("@Username", username);
                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
        }



        // Getting Client Info :::

        public static ClientInfo GetClientInfo(string username)
        {
            string query = "SELECT * FROM client_info WHERE username = @Username LIMIT 1";

            try
            {
                db_connection.Open_con();
                using (MySqlCommand cmd = new MySqlCommand(query, db_connection.cn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new ClientInfo
                            {
                                Id = Convert.ToInt32(reader["id"]),
                                Username = reader["username"].ToString(),
                                FullName = reader["full_name"].ToString(),
                                OrgName = reader["org_name"].ToString(),
                                BEmail = reader["b_email"].ToString(),
                                Location = reader["location"].ToString()
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching client info: " + ex.Message);
            }
            finally
            {
                db_connection.Close_con();
            }

            return null;
        }
    }
}
