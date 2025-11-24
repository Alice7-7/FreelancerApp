public class User
{

            // Data Encapsulation :::

            private string _username;
            private string _passwordHash;
            private string _salt;
            private string _role;

            public string Username
            {
                get => _username;
                set
                {
                    if (!string.IsNullOrWhiteSpace(value))
                        _username = value;
                }
            }

            public string PasswordHash => _passwordHash;
            public string Salt => _salt;
            public string Role => _role;

            public void SetRole(string role)
            {
                if (role == "Client" || role == "Freelancer")
                    _role = role;
            }

            public User(string username, string passwordHash, string salt)
            {
                Username = username;
                _passwordHash = passwordHash;
                _salt = salt;
            }

            public User(string username, string passwordHash, string salt, string role)
                : this(username, passwordHash, salt)
            {
                SetRole(role);
            }



            // VerifyPassword :::

            public bool VerifyPassword(string passwordInput)
            {
                return PasswordHasher.VerifyPassword(passwordInput, _salt, _passwordHash);
            }


            // Create New User :::

            public static User CreateNewUser(string username, string rawPassword, string role = null)
            {
                string hash = PasswordHasher.HashPassword(rawPassword, out string salt);
                var user = new User(username, hash, salt);
                if (!string.IsNullOrEmpty(role))
                {
                    user.SetRole(role);
                }
                return user;
            }
}
