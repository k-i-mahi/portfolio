using System;
using System.Data.SqlClient;
using System.Text;
using System.Configuration;
using System.Linq;
using System.Web.UI.WebControls;
using Portfolio.Data;

namespace Portfolio
{
    public partial class TestConnection : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnTestConnection_Click(object sender, EventArgs e)
        {
            StringBuilder result = new StringBuilder();
            
            try {
                string connectionString = ConfigurationManager.ConnectionStrings["PortfolioConnection"].ConnectionString;
                result.Append("<div class='info'><strong>Connection String:</strong> " + connectionString.Replace("Password=", "Password=***") + "</div>");
                
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    result.Append("<div class='success'><strong>? Database Connection Successful!</strong></div>");
                    
                    // Test if tables exist
                    string[] tables = { "Projects", "Skills", "Achievements", "Education", "Contacts" };
                    result.Append("<div class='info'><strong>Table Check:</strong><ul>");
                    
                    foreach (string table in tables)
                    {
                        SqlCommand cmd = new SqlCommand($"SELECT COUNT(*) FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = '{table}'", conn);
                        int exists = (int)cmd.ExecuteScalar();
                        
                        if (exists > 0)
                        {
                            result.Append($"<li style='color: green;'>? {table} table exists</li>");
                        }
                        else
                        {
                            result.Append($"<li style='color: red;'>? {table} table missing</li>");
                        }
                    }
                    result.Append("</ul></div>");
                }
            }
            catch (Exception ex)
            {
                result.Append("<div class='error'><strong>? Connection Failed:</strong><br/>" + ex.Message + "</div>");
                result.Append("<div class='info'><strong>Common Solutions:</strong><ul>");
                result.Append("<li>Make sure SQL Server is running</li>");
                result.Append("<li>Check if the database 'PortfolioDB' exists</li>");
                result.Append("<li>Verify the connection string in Web.config</li>");
                result.Append("<li>Run the setup.sql script first</li>");
                result.Append("</ul></div>");
            }
            
            var litResults = (Literal)FindControl("litResults");
            if (litResults != null)
            {
                litResults.Text = result.ToString();
            }
        }

        protected void btnTestData_Click(object sender, EventArgs e)
        {
            StringBuilder result = new StringBuilder();
            
            try
            {
                PortfolioDataAccess dataAccess = new PortfolioDataAccess();
                
                // Test Skills
                var skills = dataAccess.GetAllSkills();
                result.Append($"<div class='success'><strong>? Skills loaded:</strong> {skills.Count} records</div>");
                
                // Test Projects
                var projects = dataAccess.GetAllProjects();
                result.Append($"<div class='success'><strong>? Projects loaded:</strong> {projects.Count} records</div>");
                
                // Test Education
                var education = dataAccess.GetAllEducation();
                result.Append($"<div class='success'><strong>? Education loaded:</strong> {education.Count} records</div>");
                
                // Test Achievements
                var achievements = dataAccess.GetAllAchievements();
                result.Append($"<div class='success'><strong>? Achievements loaded:</strong> {achievements.Count} records</div>");

                // Show sample data
                if (skills.Count > 0)
                {
                    result.Append("<h3>Sample Skills Data:</h3><table>");
                    result.Append("<tr><th>Name</th><th>Category</th><th>Level</th></tr>");
                    foreach (var skill in skills.Take(5))
                    {
                        result.Append($"<tr><td>{skill.Name}</td><td>{skill.Category}</td><td>{skill.ProficiencyLevel}%</td></tr>");
                    }
                    result.Append("</table>");
                }

                if (projects.Count > 0)
                {
                    result.Append("<h3>Sample Projects Data:</h3><table>");
                    result.Append("<tr><th>Title</th><th>Technologies</th><th>Created</th></tr>");
                    foreach (var project in projects.Take(3))
                    {
                        result.Append($"<tr><td>{project.Title}</td><td>{project.Technologies}</td><td>{project.CreatedDate:MM/dd/yyyy}</td></tr>");
                    }
                    result.Append("</table>");
                }
            }
            catch (Exception ex)
            {
                result.Append("<div class='error'><strong>? Data Access Failed:</strong><br/>" + ex.Message + "</div>");
                result.Append("<div class='info'><strong>Troubleshooting:</strong><ul>");
                result.Append("<li>Ensure database setup script was run successfully</li>");
                result.Append("<li>Check that sample data was inserted</li>");
                result.Append("<li>Verify connection string is correct</li>");
                result.Append("</ul></div>");
            }
            
            var litResults = (Literal)FindControl("litResults");
            if (litResults != null)
            {
                litResults.Text = result.ToString();
            }
        }

        protected void btnGoToPortfolio_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}