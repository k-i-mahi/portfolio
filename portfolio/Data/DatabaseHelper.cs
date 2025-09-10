using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Portfolio.Models;

namespace Portfolio.Data
{
    public class DatabaseHelper
    {
        private readonly string connectionString;

        public DatabaseHelper()
        {
            // In a real application, this would come from Web.config
            connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"]?.ConnectionString 
                ?? "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Portfolio.mdf;Integrated Security=True";
        }

        #region Projects CRUD Operations

        public List<ProjectModel> GetProjects()
        {
            var projects = new List<ProjectModel>();
            
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    var query = @"SELECT Id, Title, Description, DetailedDescription, Technologies, 
                                         GitHubLink, LiveDemoLink, ImageUrl, IsActive, CreatedDate 
                                  FROM Projects WHERE IsActive = 1 ORDER BY CreatedDate DESC";
                    
                    var command = new SqlCommand(query, connection);
                    connection.Open();
                    
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            projects.Add(new ProjectModel
                            {
                                Id = reader.GetInt32(0), // Id
                                Title = reader.GetString(1), // Title
                                Description = reader.GetString(2), // Description
                                DetailedDescription = reader.IsDBNull(3) ? "" : reader.GetString(3), // DetailedDescription
                                Technologies = reader.GetString(4), // Technologies
                                GitHubLink = reader.IsDBNull(5) ? "" : reader.GetString(5), // GitHubLink
                                LiveDemoLink = reader.IsDBNull(6) ? "" : reader.GetString(6), // LiveDemoLink
                                ImageUrl = reader.IsDBNull(7) ? "" : reader.GetString(7), // ImageUrl
                                IsActive = reader.GetBoolean(8), // IsActive
                                CreatedDate = reader.GetDateTime(9) // CreatedDate
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log error
                System.Diagnostics.Debug.WriteLine($"Error getting projects: {ex.Message}");
            }
            
            return projects;
        }

        public bool AddProject(ProjectModel project)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    var query = @"INSERT INTO Projects (Title, Description, DetailedDescription, Technologies, 
                                                       GitHubLink, LiveDemoLink, ImageUrl, IsActive, CreatedDate)
                                  VALUES (@Title, @Description, @DetailedDescription, @Technologies, 
                                         @GitHubLink, @LiveDemoLink, @ImageUrl, @IsActive, @CreatedDate)";
                    
                    var command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Title", project.Title);
                    command.Parameters.AddWithValue("@Description", project.Description);
                    command.Parameters.AddWithValue("@DetailedDescription", project.DetailedDescription ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@Technologies", project.Technologies);
                    command.Parameters.AddWithValue("@GitHubLink", project.GitHubLink ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@LiveDemoLink", project.LiveDemoLink ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@ImageUrl", project.ImageUrl ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@IsActive", project.IsActive);
                    command.Parameters.AddWithValue("@CreatedDate", DateTime.Now);
                    
                    connection.Open();
                    return command.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error adding project: {ex.Message}");
                return false;
            }
        }

        public bool UpdateProject(ProjectModel project)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    var query = @"UPDATE Projects SET Title = @Title, Description = @Description, 
                                                     DetailedDescription = @DetailedDescription, Technologies = @Technologies,
                                                     GitHubLink = @GitHubLink, LiveDemoLink = @LiveDemoLink, 
                                                     ImageUrl = @ImageUrl, IsActive = @IsActive
                                  WHERE Id = @Id";
                    
                    var command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Id", project.Id);
                    command.Parameters.AddWithValue("@Title", project.Title);
                    command.Parameters.AddWithValue("@Description", project.Description);
                    command.Parameters.AddWithValue("@DetailedDescription", project.DetailedDescription ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@Technologies", project.Technologies);
                    command.Parameters.AddWithValue("@GitHubLink", project.GitHubLink ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@LiveDemoLink", project.LiveDemoLink ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@ImageUrl", project.ImageUrl ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@IsActive", project.IsActive);
                    
                    connection.Open();
                    return command.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error updating project: {ex.Message}");
                return false;
            }
        }

        public bool DeleteProject(int id)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    // Soft delete - set IsActive to false
                    var query = "UPDATE Projects SET IsActive = 0 WHERE Id = @Id";
                    
                    var command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Id", id);
                    
                    connection.Open();
                    return command.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error deleting project: {ex.Message}");
                return false;
            }
        }

        #endregion

        #region Skills CRUD Operations

        public List<SkillModel> GetSkills()
        {
            var skills = new List<SkillModel>();
            
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    var query = @"SELECT Id, Name, Category, ProficiencyLevel, IsActive, CreatedDate 
                                  FROM Skills WHERE IsActive = 1 ORDER BY Category, Name";
                    
                    var command = new SqlCommand(query, connection);
                    connection.Open();
                    
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            skills.Add(new SkillModel
                            {
                                Id = reader.GetInt32(0), // Id
                                Name = reader.GetString(1), // Name
                                Category = reader.GetString(2), // Category
                                ProficiencyLevel = reader.GetInt32(3), // ProficiencyLevel
                                IsActive = reader.GetBoolean(4), // IsActive
                                CreatedDate = reader.GetDateTime(5) // CreatedDate
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error getting skills: {ex.Message}");
            }
            
            return skills;
        }

        public bool AddSkill(SkillModel skill)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    var query = @"INSERT INTO Skills (Name, Category, ProficiencyLevel, IsActive, CreatedDate)
                                  VALUES (@Name, @Category, @ProficiencyLevel, @IsActive, @CreatedDate)";
                    
                    var command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Name", skill.Name);
                    command.Parameters.AddWithValue("@Category", skill.Category);
                    command.Parameters.AddWithValue("@ProficiencyLevel", skill.ProficiencyLevel);
                    command.Parameters.AddWithValue("@IsActive", skill.IsActive);
                    command.Parameters.AddWithValue("@CreatedDate", DateTime.Now);
                    
                    connection.Open();
                    return command.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error adding skill: {ex.Message}");
                return false;
            }
        }

        public bool UpdateSkill(SkillModel skill)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    var query = @"UPDATE Skills SET Name = @Name, Category = @Category, 
                                                   ProficiencyLevel = @ProficiencyLevel, IsActive = @IsActive
                                  WHERE Id = @Id";
                    
                    var command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Id", skill.Id);
                    command.Parameters.AddWithValue("@Name", skill.Name);
                    command.Parameters.AddWithValue("@Category", skill.Category);
                    command.Parameters.AddWithValue("@ProficiencyLevel", skill.ProficiencyLevel);
                    command.Parameters.AddWithValue("@IsActive", skill.IsActive);
                    
                    connection.Open();
                    return command.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error updating skill: {ex.Message}");
                return false;
            }
        }

        public bool DeleteSkill(int id)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    var query = "UPDATE Skills SET IsActive = 0 WHERE Id = @Id";
                    
                    var command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Id", id);
                    
                    connection.Open();
                    return command.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error deleting skill: {ex.Message}");
                return false;
            }
        }

        #endregion

        #region Achievements CRUD Operations

        public List<AchievementModel> GetAchievements()
        {
            var achievements = new List<AchievementModel>();
            
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    var query = @"SELECT Id, Title, Platform, Description, Ranking, AchievedDate, 
                                         CertificateUrl, IsActive 
                                  FROM Achievements WHERE IsActive = 1 ORDER BY AchievedDate DESC";
                    
                    var command = new SqlCommand(query, connection);
                    connection.Open();
                    
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            achievements.Add(new AchievementModel
                            {
                                Id = reader.GetInt32(0), // Id
                                Title = reader.GetString(1), // Title
                                Platform = reader.GetString(2), // Platform
                                Description = reader.GetString(3), // Description
                                Ranking = reader.IsDBNull(4) ? "" : reader.GetString(4), // Ranking
                                AchievedDate = reader.GetDateTime(5), // AchievedDate
                                CertificateUrl = reader.IsDBNull(6) ? "" : reader.GetString(6), // CertificateUrl
                                IsActive = reader.GetBoolean(7) // IsActive
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error getting achievements: {ex.Message}");
            }
            
            return achievements;
        }

        public bool AddAchievement(AchievementModel achievement)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    var query = @"INSERT INTO Achievements (Title, Platform, Description, Ranking, 
                                                           AchievedDate, CertificateUrl, IsActive)
                                  VALUES (@Title, @Platform, @Description, @Ranking, 
                                         @AchievedDate, @CertificateUrl, @IsActive)";
                    
                    var command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Title", achievement.Title);
                    command.Parameters.AddWithValue("@Platform", achievement.Platform);
                    command.Parameters.AddWithValue("@Description", achievement.Description);
                    command.Parameters.AddWithValue("@Ranking", achievement.Ranking ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@AchievedDate", achievement.AchievedDate);
                    command.Parameters.AddWithValue("@CertificateUrl", achievement.CertificateUrl ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@IsActive", achievement.IsActive);
                    
                    connection.Open();
                    return command.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error adding achievement: {ex.Message}");
                return false;
            }
        }

        public bool UpdateAchievement(AchievementModel achievement)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    var query = @"UPDATE Achievements SET Title = @Title, Platform = @Platform, 
                                                        Description = @Description, Ranking = @Ranking,
                                                        AchievedDate = @AchievedDate, CertificateUrl = @CertificateUrl, 
                                                        IsActive = @IsActive
                                  WHERE Id = @Id";
                    
                    var command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Id", achievement.Id);
                    command.Parameters.AddWithValue("@Title", achievement.Title);
                    command.Parameters.AddWithValue("@Platform", achievement.Platform);
                    command.Parameters.AddWithValue("@Description", achievement.Description);
                    command.Parameters.AddWithValue("@Ranking", achievement.Ranking ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@AchievedDate", achievement.AchievedDate);
                    command.Parameters.AddWithValue("@CertificateUrl", achievement.CertificateUrl ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@IsActive", achievement.IsActive);
                    
                    connection.Open();
                    return command.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error updating achievement: {ex.Message}");
                return false;
            }
        }

        public bool DeleteAchievement(int id)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    var query = "UPDATE Achievements SET IsActive = 0 WHERE Id = @Id";
                    
                    var command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Id", id);
                    
                    connection.Open();
                    return command.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error deleting achievement: {ex.Message}");
                return false;
            }
        }

        #endregion

        #region Contact Messages CRUD Operations

        public List<ContactMessageModel> GetContactMessages()
        {
            var messages = new List<ContactMessageModel>();
            
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    var query = @"SELECT Id, Name, Email, Phone, Subject, Message, CreatedDate, IsRead 
                                  FROM ContactMessages ORDER BY CreatedDate DESC";
                    
                    var command = new SqlCommand(query, connection);
                    connection.Open();
                    
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            messages.Add(new ContactMessageModel
                            {
                                Id = reader.GetInt32(0), // Id
                                Name = reader.GetString(1), // Name
                                Email = reader.GetString(2), // Email
                                Phone = reader.IsDBNull(3) ? "" : reader.GetString(3), // Phone
                                Subject = reader.IsDBNull(4) ? "" : reader.GetString(4), // Subject
                                Message = reader.GetString(5), // Message
                                CreatedDate = reader.GetDateTime(6), // CreatedDate
                                IsRead = reader.GetBoolean(7) // IsRead
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error getting contact messages: {ex.Message}");
            }
            
            return messages;
        }

        public bool AddContactMessage(ContactMessageModel message)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    var query = @"INSERT INTO ContactMessages (Name, Email, Phone, Subject, Message, CreatedDate, IsRead)
                                  VALUES (@Name, @Email, @Phone, @Subject, @Message, @CreatedDate, @IsRead)";
                    
                    var command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Name", message.Name);
                    command.Parameters.AddWithValue("@Email", message.Email);
                    command.Parameters.AddWithValue("@Phone", message.Phone ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@Subject", message.Subject ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@Message", message.Message);
                    command.Parameters.AddWithValue("@CreatedDate", DateTime.Now);
                    command.Parameters.AddWithValue("@IsRead", false);
                    
                    connection.Open();
                    return command.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error adding contact message: {ex.Message}");
                return false;
            }
        }

        public bool MarkMessageAsRead(int id)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    var query = "UPDATE ContactMessages SET IsRead = 1 WHERE Id = @Id";
                    
                    var command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Id", id);
                    
                    connection.Open();
                    return command.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error marking message as read: {ex.Message}");
                return false;
            }
        }

        public bool DeleteContactMessage(int id)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    var query = "DELETE FROM ContactMessages WHERE Id = @Id";
                    
                    var command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Id", id);
                    
                    connection.Open();
                    return command.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error deleting contact message: {ex.Message}");
                return false;
            }
        }

        #endregion

        #region Database Initialization

        public bool InitializeDatabase()
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    
                    // Create tables if they don't exist
                    var createTablesScript = @"
                        IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Projects' AND xtype='U')
                        CREATE TABLE Projects (
                            Id int IDENTITY(1,1) PRIMARY KEY,
                            Title nvarchar(255) NOT NULL,
                            Description nvarchar(500),
                            DetailedDescription nvarchar(max),
                            Technologies nvarchar(500),
                            GitHubLink nvarchar(500),
                            LiveDemoLink nvarchar(500),
                            ImageUrl nvarchar(500),
                            IsActive bit DEFAULT 1,
                            CreatedDate datetime DEFAULT GETDATE()
                        );

                        IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Skills' AND xtype='U')
                        CREATE TABLE Skills (
                            Id int IDENTITY(1,1) PRIMARY KEY,
                            Name nvarchar(255) NOT NULL,
                            Category nvarchar(255),
                            ProficiencyLevel int,
                            IsActive bit DEFAULT 1,
                            CreatedDate datetime DEFAULT GETDATE()
                        );

                        IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Achievements' AND xtype='U')
                        CREATE TABLE Achievements (
                            Id int IDENTITY(1,1) PRIMARY KEY,
                            Title nvarchar(255) NOT NULL,
                            Platform nvarchar(255),
                            Description nvarchar(max),
                            Ranking nvarchar(255),
                            AchievedDate datetime,
                            CertificateUrl nvarchar(500),
                            IsActive bit DEFAULT 1
                        );

                        IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='ContactMessages' AND xtype='U')
                        CREATE TABLE ContactMessages (
                            Id int IDENTITY(1,1) PRIMARY KEY,
                            Name nvarchar(255) NOT NULL,
                            Email nvarchar(255) NOT NULL,
                            Phone nvarchar(50),
                            Subject nvarchar(255),
                            Message nvarchar(max) NOT NULL,
                            CreatedDate datetime DEFAULT GETDATE(),
                            IsRead bit DEFAULT 0
                        );
                    ";
                    
                    var command = new SqlCommand(createTablesScript, connection);
                    command.ExecuteNonQuery();
                }
                
                return true;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error initializing database: {ex.Message}");
                return false;
            }
        }

        #endregion
    }
}