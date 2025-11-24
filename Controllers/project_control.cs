using Freelance;
using Freelance.Class;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

public class Project_control
{
    public static void SaveProject(Project project)
    {
        string query = @"INSERT INTO projects (title, org_name, description,pj_deadline, budget, prerequisites, image, created_by)
                     VALUES (@Title, @OrgName, @Description, @Deadline, @Budget, @Prerequisites, @ImageUrl, @CreatedBy)";

        try
        {
            db_connection.Open_con();
            using (MySqlCommand cmd = new MySqlCommand(query, db_connection.cn))
            {
                cmd.Parameters.AddWithValue("@Title", project.Title);
                cmd.Parameters.AddWithValue("@OrgName", project.OrgName);
                cmd.Parameters.AddWithValue("@Description", project.Description);
                cmd.Parameters.AddWithValue("@Deadline", project.Deadline);
                cmd.Parameters.AddWithValue("@Budget", project.Budget);
                cmd.Parameters.AddWithValue("@Prerequisites", project.Prerequisites);
                cmd.Parameters.AddWithValue("@ImageUrl", project.ImageUrl);
                cmd.Parameters.AddWithValue("@CreatedBy", project.CreatedBy);

                cmd.ExecuteNonQuery();
            }

            // Notification :::

            string notifQuery = "INSERT INTO notifications (receiver_role, message, created_at) VALUES (@role, @msg, NOW())";
            using (MySqlCommand notifCmd = new MySqlCommand(notifQuery, db_connection.cn))
            {
                notifCmd.Parameters.AddWithValue("@role", "freelancer");
                notifCmd.Parameters.AddWithValue("@msg", $"{project.Title} \n from {project.OrgName}");
                notifCmd.ExecuteNonQuery();
            }
        }
        finally
        {
            db_connection.Close_con();
        }


    }



    // Retrieving All Projects Data :::

    public static List<Project> GetAllProjects()
    {
        List<Project> list = new List<Project>();
        string query = @"SELECT * FROM projects WHERE  id NOT IN (
                            SELECT project_id FROM bids WHERE status = 'accepted' OR completed_ = 1
                        ) 
                        ORDER BY created_at DESC";

        try
        {
            db_connection.Open_con();
            using (MySqlCommand cmd = new MySqlCommand(query, db_connection.cn))
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    list.Add(new Project
                    {
                        Id = Convert.ToInt32(reader["id"]),
                        Title = reader["title"].ToString(),
                        OrgName = reader["org_name"].ToString(),
                        Description = reader["description"].ToString(),
                        Deadline = reader["pj_deadline"].ToString(),
                        Budget = Convert.ToDecimal(reader["budget"]),
                        Prerequisites = reader["prerequisites"].ToString(),
                        ImageUrl = reader["image"].ToString()
                    });
                }
            }
        }
        finally
        {
            db_connection.Close_con();
        }

        return list;
    }


    // Upload image & Save Project :::

    public static void UploadAndSaveProject(Project project, string sourceImagePath)
    {
        if (string.IsNullOrEmpty(sourceImagePath) || !File.Exists(sourceImagePath))
        {
            MessageBox.Show("Invalid image path.");
            return;
        }

        string fileName = Path.GetFileName(sourceImagePath);
        string imagesFolder = Path.Combine(Application.StartupPath, "images");

        if (!Directory.Exists(imagesFolder))
            Directory.CreateDirectory(imagesFolder);

        string uniqueName = Guid.NewGuid().ToString() + Path.GetExtension(fileName);
        string destinationPath = Path.Combine(imagesFolder, uniqueName);

        File.Copy(sourceImagePath, destinationPath, true);

       
        project.ImageUrl = "images/" + uniqueName;
  
        SaveProject(project);

        MessageBox.Show("Project uploaded and saved successfully!");
    }


    // Retrieve all bids projects :::

    public static List<Dictionary<string, object>> GetBidProjectsByFreelancer(string username)
    {
        var projects = new List<Dictionary<string, object>>();

        string query = @"SELECT p.id, p.title, p.description, p.budget, p.image, b.status, b.completed_
                     FROM bids b
                     JOIN projects p ON b.project_id = p.id
                     WHERE b.freelancer_username = @username";

        using (MySqlCommand cmd = new MySqlCommand(query, db_connection.cn))
        {
            cmd.Parameters.AddWithValue("@username", username);

            db_connection.Open_con();
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    var record = new Dictionary<string, object>
                {
                    { "ProjectId", reader.GetInt32("id") },
                    { "Title", reader.GetString("title") },
                    { "Description", reader.GetString("description") },
                    { "Budget", reader.GetDecimal("budget") },
                    { "ImageUrl", reader.GetString("image") },
                    { "Status", reader.GetString("status") },
                        
                    { "IsCompleted", reader.GetBoolean("completed_") }
                };

                    projects.Add(record);
                }
            }
            db_connection.Close_con();
        }

        return projects;
    }


    // Mark as complete button >> :::

    public static bool MarkAsComplete(int projectId)
    {
        string query = "UPDATE bids SET completed_ = 1, status = 'completed' WHERE project_id = @id";

        using (MySqlCommand cmd = new MySqlCommand(query, db_connection.cn))
        {
            cmd.Parameters.AddWithValue("@id", projectId);
            db_connection.Open_con();
            int result = cmd.ExecuteNonQuery();
            db_connection.Close_con();

            return result > 0;
        }
    }


    // Loads completed Projects :::

    public static List<Dictionary<string, object>> GetCompletedProjectsByClient(string clientUsername)
    {
        List<Dictionary<string, object>> completedProjects = new List<Dictionary<string, object>>();

        string query = @"SELECT p.id, p.title, p.description, p.budget, p.image, b.freelancer_username
                     FROM bids b
                     JOIN projects p ON b.project_id = p.id
                     WHERE p.created_by = @client
                       AND b.completed_ = 1
                       AND p.reviewed = 0";

        using (MySqlCommand cmd = new MySqlCommand(query, db_connection.cn))
        {
            cmd.Parameters.AddWithValue("@client", clientUsername);

            db_connection.Open_con();
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    completedProjects.Add(new Dictionary<string, object>
                {
                    { "ProjectId", reader.GetInt32("id") },
                    { "Title", reader.GetString("title") },
                    { "Description", reader.GetString("description") },
                    { "Budget", reader.GetDecimal("budget") },
                    { "ImageUrl", reader.GetString("image") },
                    { "Freelancer", reader.GetString("freelancer_username") }
                });
                }
            }
            db_connection.Close_con();
        }

        return completedProjects;
    }



    // Submit Review :::

    public static bool SubmitReview(int projectId, string freelancer, string client, int stars, string comment)
    {
        string query = @"INSERT INTO reviews (project_id, freelancer_username, client_username, rating, comment)
                     VALUES (@id, @freelancer, @client, @stars, @comment);
                     UPDATE projects SET reviewed = 1 WHERE id = @id;";

        using (MySqlCommand cmd = new MySqlCommand(query, db_connection.cn))
        {
            cmd.Parameters.AddWithValue("@id", projectId);
            cmd.Parameters.AddWithValue("@freelancer", freelancer);
            cmd.Parameters.AddWithValue("@client", client);
            cmd.Parameters.AddWithValue("@stars", stars);
            cmd.Parameters.AddWithValue("@comment", comment);

            db_connection.Open_con();
            int rows = cmd.ExecuteNonQuery();
            db_connection.Close_con();

            return rows > 0;
        }
    }


    // Loads Feedback data :::

    public static List<Dictionary<string, object>> GetReviewsForFreelancer(string freelancerUsername)
    {
        List<Dictionary<string, object>> reviews = new List<Dictionary<string, object>>();

        string query = @"
                        SELECT p.title AS project_title, r.client_username, r.rating, r.comment
                        FROM reviews r
                        INNER JOIN projects p ON r.project_id = p.id
                        WHERE r.freelancer_username = @username";

        using (MySqlCommand cmd = new MySqlCommand(query, db_connection.cn))
        {
            cmd.Parameters.AddWithValue("@username", freelancerUsername);
            db_connection.Open_con();

            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    var review = new Dictionary<string, object>
                    {
                        ["project_title"] = reader["project_title"].ToString(),
                        ["client_username"] = reader["client_username"].ToString(),
                        ["rating"] = Convert.ToInt32(reader["rating"]),
                        ["comment"] = reader["comment"].ToString()
                    };

                    reviews.Add(review);
                }
            }

            db_connection.Close_con();
        }

        return reviews;
    }



}
