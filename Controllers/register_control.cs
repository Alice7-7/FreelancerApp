using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Freelance.Class;

namespace Freelance.Controllers
{
    public class Register_control
    {
        public static void RegisterUser(string usernameInput, string passwordInput, string confirmPasswordInput, Form formToHide)
        {
            string usernamePattern = "^[a-zA-Z0-9]*$";
            string passwordPattern = "^(?=.*[a-z])(?=.*[A-Z]).{12,}$";

            if (string.IsNullOrEmpty(usernameInput) || string.IsNullOrEmpty(passwordInput) || string.IsNullOrEmpty(confirmPasswordInput))
            {
                MessageBox.Show("Please fill all the input fields");
                return;
            }

            if (!Regex.IsMatch(usernameInput, usernamePattern))
            {
                MessageBox.Show("Username contains invalid characters. Only letters and numbers are allowed.");
                return;
            }

            if (!Regex.IsMatch(passwordInput, passwordPattern))
            {
                MessageBox.Show("Password must be at least 12 characters long and contain at least one lowercase letter and one uppercase letter.");
                return;
            }

            if (passwordInput != confirmPasswordInput)
            {
                MessageBox.Show("Password and re-type password do not match");
                return;
            }

            try
            {
                string checkQuery = "SELECT username FROM users WHERE username = @Username";
                var checkParams = new Dictionary<string, object> { { "@Username", usernameInput } };

                using (var reader = db_connection.ExecuteReader(checkQuery, checkParams))
                {
                    if (reader.Read())
                    {
                        MessageBox.Show("Username is already taken", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }

                string selectedRole = Session_manage.Role;
                if (string.IsNullOrEmpty(selectedRole))
                {
                    MessageBox.Show("Role not selected. Please go back and choose your role.");
                    return;
                }

                User newUser = User.CreateNewUser(usernameInput, passwordInput, selectedRole);

                string insertQuery = "INSERT INTO users (username, password, salt, role) VALUES (@Username, @PasswordHash, @Salt, @Role)";
                var insertParams = new Dictionary<string, object>
                {
                    { "@Username", newUser.Username },
                    { "@PasswordHash", newUser.PasswordHash },
                    { "@Salt", newUser.Salt },
                    { "@Role", newUser.Role }
                };

                db_connection.ExecuteQuery(insertQuery, insertParams);

                MessageBox.Show("User Account Created Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Session_manage.Username = newUser.Username;
                formToHide.Hide();

                if (newUser.Role == "Freelancer")
                {
                    create_freelance_pf freelancePf = new create_freelance_pf(Session_manage.Username);
                    freelancePf.Show();
                }
                else
                {
                    create_client_pf clientPf = new create_client_pf(Session_manage.Username);
                    clientPf.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db_connection.Close_con();
                Cursor.Show();
            }
        }
    }
}
