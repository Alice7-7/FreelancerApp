using Freelance;
using Freelance.Class;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace Freelance.Controllers
{
    public class Login_control
    {
        public static string Login(string username, string password, out string role)
        {
            role = string.Empty;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                return "Please enter both username and password.";

            try
            {
                string query = "SELECT password, salt, role FROM users WHERE username = @Username";
                var parameters = new Dictionary<string, object>
                {
                    { "@Username", username }
                };

                using (var reader = db_connection.ExecuteReader(query, parameters))
                {
                    if (reader.Read())
                    {
                        string storedHash = reader["password"].ToString();
                        string storedSalt = reader["salt"].ToString();
                        string storedRole = reader["role"].ToString();

                        User user = new User(username, storedHash, storedSalt, storedRole);

                        if (user.VerifyPassword(password))
                        {
                            Session_manage.Username = user.Username;
                            Session_manage.Role = user.Role;
                            role = user.Role;

                            return "Success";
                        }
                        else
                        {
                            return "Incorrect password.";
                        }
                    }
                    else
                    {
                        return "Username not found.";
                    }
                }
            }
            catch (Exception ex)
            {
                return "An error occurred: " + ex.Message;
            }
            finally
            {
                db_connection.Close_con();
            }
        }
    }
}
