using Freelance.Class;
using MySql.Data.MySqlClient;
using System;

namespace Freelance.Controllers
{
    public class Freelance_control
    {
        public static Freelancer GetFreelancerShortProfile(string username)
        {
            Freelancer freelancer = null;

            string query = "SELECT name, expertise FROM freelancer_pf WHERE username = @Username";

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
                            freelancer = new Freelancer
                            {
                                Username = username,
                                Name = reader["name"].ToString(),
                                Expertise = reader["expertise"].ToString()
                            };
                        }
                    }
                }
            }
            finally
            {
                db_connection.Close_con();
            }

            return freelancer;
        }
    }
}
