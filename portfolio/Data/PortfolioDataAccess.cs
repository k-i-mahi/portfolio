using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Portfolio.Models;

namespace Portfolio.Data
{
    public class PortfolioDataAccess
    {
        private readonly string connectionString;

        public PortfolioDataAccess()
        {
            connectionString = ConfigurationManager.ConnectionStrings["PortfolioConnection"].ConnectionString;
        }

        #region Project Methods
        public List<Project> GetAllProjects()
        {
            List<Project> projects = new List<Project>();
            
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"SELECT Id, Title, Description, DetailedDescription, Technologies, 
                               GitHubLink, LiveDemoLink, ImageUrl, CreatedDate, IsActive, DisplayOrder 
                               FROM Projects WHERE IsActive = 1 ORDER BY DisplayOrder, CreatedDate DESC";
                
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    projects.Add(new Project
                    {
                        Id = reader.GetInt32("Id"),
                        Title = reader.GetString("Title"),
                        Description = reader.GetString("Description"),
                        DetailedDescription = reader.IsDBNull("DetailedDescription") ? "" : reader.GetString("DetailedDescription"),
                        Technologies = reader.IsDBNull("Technologies") ? "" : reader.GetString("Technologies"),
                        GitHubLink = reader.IsDBNull("GitHubLink") ? "" : reader.GetString("GitHubLink"),
                        LiveDemoLink = reader.IsDBNull("LiveDemoLink") ? "" : reader.GetString("LiveDemoLink"),
                        ImageUrl = reader.IsDBNull("ImageUrl") ? "" : reader.GetString("ImageUrl"),
                        CreatedDate = reader.GetDateTime("CreatedDate"),
                        IsActive = reader.GetBoolean("IsActive"),
                        DisplayOrder = reader.GetInt32("DisplayOrder")
                    });
                }
            }
            
            return projects;
        }
        #endregion

        #region Skill Methods
        public List<Skill> GetAllSkills()
        {
            List<Skill> skills = new List<Skill>();
            
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"SELECT Id, Name, Category, ProficiencyLevel, IconClass, IsActive, DisplayOrder 
                               FROM Skills WHERE IsActive = 1 ORDER BY Category, DisplayOrder";
                
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    skills.Add(new Skill
                    {
                        Id = reader.GetInt32("Id"),
                        Name = reader.GetString("Name"),
                        Category = reader.IsDBNull("Category") ? "" : reader.GetString("Category"),
                        ProficiencyLevel = reader.GetInt32("ProficiencyLevel"),
                        IconClass = reader.IsDBNull("IconClass") ? "" : reader.GetString("IconClass"),
                        IsActive = reader.GetBoolean("IsActive"),
                        DisplayOrder = reader.GetInt32("DisplayOrder")
                    });
                }
            }
            
            return skills;
        }
        #endregion

        #region Achievement Methods
        public List<Achievement> GetAllAchievements()
        {
            List<Achievement> achievements = new List<Achievement>();
            
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"SELECT Id, Title, Platform, Description, Ranking, CertificateUrl, 
                               AchievedDate, IsActive, DisplayOrder 
                               FROM Achievements WHERE IsActive = 1 ORDER BY DisplayOrder, AchievedDate DESC";
                
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    achievements.Add(new Achievement
                    {
                        Id = reader.GetInt32("Id"),
                        Title = reader.GetString("Title"),
                        Platform = reader.IsDBNull("Platform") ? "" : reader.GetString("Platform"),
                        Description = reader.IsDBNull("Description") ? "" : reader.GetString("Description"),
                        Ranking = reader.IsDBNull("Ranking") ? "" : reader.GetString("Ranking"),
                        CertificateUrl = reader.IsDBNull("CertificateUrl") ? "" : reader.GetString("CertificateUrl"),
                        AchievedDate = reader.GetDateTime("AchievedDate"),
                        IsActive = reader.GetBoolean("IsActive"),
                        DisplayOrder = reader.GetInt32("DisplayOrder")
                    });
                }
            }
            
            return achievements;
        }
        #endregion

        #region Education Methods
        public List<Education> GetAllEducation()
        {
            List<Education> educations = new List<Education>();
            
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"SELECT Id, Institution, Degree, Department, CGPA, StartDate, EndDate, 
                               IsCurrent, Description, IsActive, DisplayOrder 
                               FROM Education WHERE IsActive = 1 ORDER BY DisplayOrder, StartDate DESC";
                
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    educations.Add(new Education
                    {
                        Id = reader.GetInt32("Id"),
                        Institution = reader.GetString("Institution"),
                        Degree = reader.GetString("Degree"),
                        Department = reader.IsDBNull("Department") ? "" : reader.GetString("Department"),
                        CGPA = reader.IsDBNull("CGPA") ? "" : reader.GetString("CGPA"),
                        StartDate = reader.GetDateTime("StartDate"),
                        EndDate = reader.IsDBNull("EndDate") ? (DateTime?)null : reader.GetDateTime("EndDate"),
                        IsCurrent = reader.GetBoolean("IsCurrent"),
                        Description = reader.IsDBNull("Description") ? "" : reader.GetString("Description"),
                        IsActive = reader.GetBoolean("IsActive"),
                        DisplayOrder = reader.GetInt32("DisplayOrder")
                    });
                }
            }
            
            return educations;
        }
        #endregion

        #region Contact Methods
        public bool SaveContact(Contact contact)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"INSERT INTO Contacts (Name, Email, Phone, Subject, Message, CreatedDate, IsRead) 
                                   VALUES (@Name, @Email, @Phone, @Subject, @Message, @CreatedDate, @IsRead)";
                    
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Name", contact.Name);
                    cmd.Parameters.AddWithValue("@Email", contact.Email);
                    cmd.Parameters.AddWithValue("@Phone", contact.Phone ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Subject", contact.Subject ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Message", contact.Message);
                    cmd.Parameters.AddWithValue("@CreatedDate", contact.CreatedDate);
                    cmd.Parameters.AddWithValue("@IsRead", contact.IsRead);
                    
                    conn.Open();
                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        #endregion
    }
}