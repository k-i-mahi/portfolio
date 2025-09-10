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
                        Id = Convert.ToInt32(reader["Id"]),
                        Title = reader["Title"].ToString(),
                        Description = reader["Description"].ToString(),
                        DetailedDescription = reader["DetailedDescription"] == DBNull.Value ? "" : reader["DetailedDescription"].ToString(),
                        Technologies = reader["Technologies"] == DBNull.Value ? "" : reader["Technologies"].ToString(),
                        GitHubLink = reader["GitHubLink"] == DBNull.Value ? "" : reader["GitHubLink"].ToString(),
                        LiveDemoLink = reader["LiveDemoLink"] == DBNull.Value ? "" : reader["LiveDemoLink"].ToString(),
                        ImageUrl = reader["ImageUrl"] == DBNull.Value ? "" : reader["ImageUrl"].ToString(),
                        CreatedDate = Convert.ToDateTime(reader["CreatedDate"]),
                        IsActive = Convert.ToBoolean(reader["IsActive"]),
                        DisplayOrder = Convert.ToInt32(reader["DisplayOrder"])
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
                        Id = Convert.ToInt32(reader["Id"]),
                        Name = reader["Name"].ToString(),
                        Category = reader["Category"] == DBNull.Value ? "" : reader["Category"].ToString(),
                        ProficiencyLevel = Convert.ToInt32(reader["ProficiencyLevel"]),
                        IconClass = reader["IconClass"] == DBNull.Value ? "" : reader["IconClass"].ToString(),
                        IsActive = Convert.ToBoolean(reader["IsActive"]),
                        DisplayOrder = Convert.ToInt32(reader["DisplayOrder"])
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
                        Title = reader["Title"].ToString(),
                        Platform = reader["Platform"] == DBNull.Value ? "" : reader["Platform"].ToString(),
                        Description = reader["Description"] == DBNull.Value ? "" : reader["Description"].ToString(),
                        Ranking = reader["Ranking"] == DBNull.Value ? "" : reader["Ranking"].ToString(),
                        CertificateUrl = reader["CertificateUrl"] == DBNull.Value ? "" : reader["CertificateUrl"].ToString(),
                        AchievedDate = Convert.ToDateTime(reader["AchievedDate"]),
                        IsActive = Convert.ToBoolean(reader["IsActive"]),
                        DisplayOrder = Convert.ToInt32(reader["DisplayOrder"])
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
                        Institution = reader["Institution"].ToString(),
                        Degree = reader["Degree"].ToString(),
                        Department = reader["Department"] == DBNull.Value ? "" : reader["Department"].ToString(),
                        CGPA = reader["CGPA"] == DBNull.Value ? "" : reader["CGPA"].ToString(),
                        StartDate = Convert.ToDateTime(reader["StartDate"]),
                        EndDate = reader["EndDate"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["EndDate"]),
                        IsCurrent = Convert.ToBoolean(reader["IsCurrent"]),
                        Description = reader["Description"] == DBNull.Value ? "" : reader["Description"].ToString(),
                        IsActive = Convert.ToBoolean(reader["IsActive"]),
                        DisplayOrder = Convert.ToInt32(reader["DisplayOrder"])
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

        public List<Contact> GetAllContacts()
        {
            List<Contact> contacts = new List<Contact>();
            
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"SELECT Id, Name, Email, Phone, Subject, Message, CreatedDate, IsRead 
                               FROM Contacts ORDER BY CreatedDate DESC";
                
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    contacts.Add(new Contact
                    {
                        Id = reader.GetInt32("Id"),
                        Name = reader["Name"].ToString(),
                        Email = reader["Email"].ToString(),
                        Phone = reader["Phone"] == DBNull.Value ? "" : reader["Phone"].ToString(),
                        Subject = reader["Subject"] == DBNull.Value ? "" : reader["Subject"].ToString(),
                        Message = reader["Message"].ToString(),
                        CreatedDate = Convert.ToDateTime(reader["CreatedDate"]),
                        IsRead = Convert.ToBoolean(reader["IsRead"])
                    });
                }
            }
            
            return contacts;
        }
        #endregion
    }
}