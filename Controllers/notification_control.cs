using Freelance;
using Freelance.Class;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

public class NotificationController
{
    public static List<Notification> GetNotificationsForRole(string role)
    {
        List<Notification> notifications = new List<Notification>();

        string query = "SELECT * FROM notifications WHERE receiver_role = @Role ORDER BY created_at DESC";

        try
        {
            db_connection.Open_con();
            using (MySqlCommand cmd = new MySqlCommand(query, db_connection.cn))
            {
                cmd.Parameters.AddWithValue("@Role", role);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        notifications.Add(new Notification
                        {
                            Id = Convert.ToInt32(reader["id"]),
                            ReceiverRole = reader["receiver_role"].ToString(),
                            Message = reader["message"].ToString(),
                            CreatedAt = Convert.ToDateTime(reader["created_at"])
                        });
                    }
                }
            }
        }
        finally
        {
            db_connection.Close_con();
        }

        return notifications;
    }
}
