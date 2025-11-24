using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

public static class db_connection
{
        public static MySqlConnection cn = new MySqlConnection("Server=localhost;Database=freelance_app;Uid=root;Pwd=;");

        public static void Open_con()
        {
            if (cn.State == System.Data.ConnectionState.Closed)
            {
                cn.Open();
            }
        }

        public static void Close_con()
        {
            if (cn.State == System.Data.ConnectionState.Open)
            {
                cn.Close();
            }
        }


        // ExecuteQuery with SQL injection prevention :::

        public static void ExecuteQuery(string query, Dictionary<string, object> parameters)
        {
            Open_con();
            using (MySqlCommand cmd = new MySqlCommand(query, cn))
            {
                foreach (var param in parameters)
                {
                    cmd.Parameters.AddWithValue(param.Key, param.Value);
                }
                cmd.ExecuteNonQuery();
            }
            Close_con();
        }

 
        // ExecuteReader with parameters

        public static MySqlDataReader ExecuteReader(string query, Dictionary<string, object> parameters)
        {
            Open_con();
            MySqlCommand cmd = new MySqlCommand(query, cn);

            foreach (var param in parameters)
            {
                cmd.Parameters.AddWithValue(param.Key, param.Value);
            }

            return cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
        }
}
