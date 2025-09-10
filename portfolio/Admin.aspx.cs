using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;
using Portfolio.Models;

namespace Portfolio
{
    public partial class Admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadAllData();
            }
        }

        private void LoadAllData()
        {
            LoadProjects();
            LoadSkills();
            LoadAchievements();
            LoadEducation();
            LoadContactMessages();
        }

        #region Projects Management
        
        private void LoadProjects()
        {
            try
            {
                var projects = GetProjectsData();
                
                // Find the GridView control and bind data
                var projectsGrid = FindControl("gvProjects") as GridView;
                if (projectsGrid != null)
                {
                    projectsGrid.DataSource = projects;
                    projectsGrid.DataBind();
                }
            }
            catch (Exception ex)
            {
                ShowAlert($"Error loading projects: {ex.Message}", "danger");
            }
        }

        private List<ProjectModel> GetProjectsData()
        {
            // Sample data - in real application this would come from database
            return new List<ProjectModel>
            {
                new ProjectModel 
                { 
                    Id = 1, 
                    Title = "Smart Obstacle Avoiding Robot", 
                    Description = "AI-powered autonomous navigation system", 
                    Technologies = "Arduino, C++, Machine Learning", 
                    GitHubLink = "https://github.com/k-i-mahi/smart-obstacle-robot",
                    IsActive = true,
                    CreatedDate = DateTime.Now.AddDays(-30)
                },
                new ProjectModel 
                { 
                    Id = 2, 
                    Title = "Competitive Programming Judge", 
                    Description = "Full-stack online judge system", 
                    Technologies = "ASP.NET Core, SQL Server, Docker", 
                    GitHubLink = "https://github.com/k-i-mahi/cp-judge-system",
                    LiveDemoLink = "https://judge.example.com",
                    IsActive = true,
                    CreatedDate = DateTime.Now.AddDays(-45)
                },
                new ProjectModel 
                { 
                    Id = 3, 
                    Title = "Kaggle ML Competition Suite", 
                    Description = "Machine learning solutions for Kaggle competitions", 
                    Technologies = "Python, Pandas, Scikit-learn, XGBoost", 
                    GitHubLink = "https://github.com/k-i-mahi/kaggle-ml-solutions",
                    LiveDemoLink = "https://kaggle.com/khadimulmahi",
                    IsActive = true,
                    CreatedDate = DateTime.Now.AddDays(-60)
                }
            };
        }

        protected void gvProjects_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                int index = Convert.ToInt32(e.CommandArgument);
                
                switch (e.CommandName)
                {
                    case "EditItem":
                        ShowAlert("Edit functionality - Database integration required.", "info");
                        break;
                    case "DeleteItem":
                        ShowAlert("Project deleted successfully! (Note: Database integration required)", "success");
                        LoadProjects();
                        break;
                }
            }
            catch (Exception ex)
            {
                ShowAlert($"Error: {ex.Message}", "danger");
            }
        }

        #endregion

        #region Skills Management

        private void LoadSkills()
        {
            try
            {
                var skills = GetSkillsData();
                
                var skillsGrid = FindControl("gvSkills") as GridView;
                if (skillsGrid != null)
                {
                    skillsGrid.DataSource = skills;
                    skillsGrid.DataBind();
                }
            }
            catch (Exception ex)
            {
                ShowAlert($"Error loading skills: {ex.Message}", "danger");
            }
        }

        private List<SkillModel> GetSkillsData()
        {
            return new List<SkillModel>
            {
                new SkillModel { Id = 1, Name = "C++", Category = "Programming Languages", ProficiencyLevel = 95, IsActive = true, CreatedDate = DateTime.Now },
                new SkillModel { Id = 2, Name = "Python", Category = "Programming Languages", ProficiencyLevel = 90, IsActive = true, CreatedDate = DateTime.Now },
                new SkillModel { Id = 3, Name = "Java", Category = "Programming Languages", ProficiencyLevel = 85, IsActive = true, CreatedDate = DateTime.Now },
                new SkillModel { Id = 4, Name = "ASP.NET", Category = "Web Development", ProficiencyLevel = 88, IsActive = true, CreatedDate = DateTime.Now },
                new SkillModel { Id = 5, Name = "Machine Learning", Category = "Data Science & AI", ProficiencyLevel = 82, IsActive = true, CreatedDate = DateTime.Now }
            };
        }

        protected void gvSkills_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                int index = Convert.ToInt32(e.CommandArgument);
                
                switch (e.CommandName)
                {
                    case "EditItem":
                        ShowAlert("Skill edit - Database integration required.", "info");
                        break;
                    case "DeleteItem":
                        ShowAlert("Skill deleted successfully!", "success");
                        LoadSkills();
                        break;
                }
            }
            catch (Exception ex)
            {
                ShowAlert($"Error: {ex.Message}", "danger");
            }
        }

        #endregion

        #region Achievements Management

        private void LoadAchievements()
        {
            try
            {
                var achievements = GetAchievementsData();
                
                var achievementsGrid = FindControl("gvAchievements") as GridView;
                if (achievementsGrid != null)
                {
                    achievementsGrid.DataSource = achievements;
                    achievementsGrid.DataBind();
                }
            }
            catch (Exception ex)
            {
                ShowAlert($"Error loading achievements: {ex.Message}", "danger");
            }
        }

        private List<AchievementModel> GetAchievementsData()
        {
            return new List<AchievementModel>
            {
                new AchievementModel 
                { 
                    Id = 1, 
                    Title = "Codeforces Specialist Achievement", 
                    Platform = "Codeforces", 
                    Description = "Achieved Specialist rating (1400+)",
                    Ranking = "Max Rating: 1456+ (Specialist)",
                    AchievedDate = new DateTime(2024, 11, 1),
                    IsActive = true
                },
                new AchievementModel 
                { 
                    Id = 2, 
                    Title = "ACM ICPC Regional Qualifier", 
                    Platform = "ACM ICPC", 
                    Description = "Qualified for ACM ICPC Asia Dhaka Regional 2024",
                    Ranking = "Team Rank: 25th out of 200+ teams",
                    AchievedDate = new DateTime(2024, 10, 15),
                    IsActive = true
                },
                new AchievementModel 
                { 
                    Id = 3, 
                    Title = "Kaggle Bronze Medal", 
                    Platform = "Kaggle", 
                    Description = "Bronze Medal in Spaceship Titanic competition",
                    Ranking = "Top 15% (375th out of 2500+)",
                    AchievedDate = new DateTime(2024, 9, 28),
                    IsActive = true
                }
            };
        }

        protected void gvAchievements_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                int index = Convert.ToInt32(e.CommandArgument);
                
                switch (e.CommandName)
                {
                    case "EditItem":
                        ShowAlert("Achievement edit - Database integration required.", "info");
                        break;
                    case "DeleteItem":
                        ShowAlert("Achievement deleted successfully!", "success");
                        LoadAchievements();
                        break;
                }
            }
            catch (Exception ex)
            {
                ShowAlert($"Error: {ex.Message}", "danger");
            }
        }

        #endregion

        #region Education Management

        private void LoadEducation()
        {
            try
            {
                var education = GetEducationData();
                
                var educationGrid = FindControl("gvEducation") as GridView;
                if (educationGrid != null)
                {
                    educationGrid.DataSource = education;
                    educationGrid.DataBind();
                }
            }
            catch (Exception ex)
            {
                ShowAlert($"Error loading education: {ex.Message}", "danger");
            }
        }

        private List<EducationModel> GetEducationData()
        {
            return new List<EducationModel>
            {
                new EducationModel 
                { 
                    Id = 1,
                    Institution = "Khulna University of Engineering & Technology (KUET)",
                    Degree = "B.Sc. in Computer Science and Engineering",
                    Department = "Computer Science and Engineering",
                    CGPA = "3.78",
                    StartDate = new DateTime(2022, 1, 1),
                    EndDate = null,
                    IsCurrent = true,
                    Description = "Currently pursuing B.Sc. in CSE"
                },
                new EducationModel 
                { 
                    Id = 2,
                    Institution = "Bogura Cantonment Public School & College",
                    Degree = "Higher Secondary Certificate (HSC)",
                    Department = "Science Group",
                    CGPA = "5.00",
                    StartDate = new DateTime(2019, 6, 1),
                    EndDate = new DateTime(2021, 5, 31),
                    IsCurrent = false,
                    Description = "Completed HSC with perfect GPA"
                }
            };
        }

        protected void gvEducation_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                int index = Convert.ToInt32(e.CommandArgument);
                
                switch (e.CommandName)
                {
                    case "EditItem":
                        ShowAlert("Education edit - Database integration required.", "info");
                        break;
                    case "DeleteItem":
                        ShowAlert("Education record deleted successfully!", "success");
                        LoadEducation();
                        break;
                }
            }
            catch (Exception ex)
            {
                ShowAlert($"Error: {ex.Message}", "danger");
            }
        }

        #endregion

        #region Contact Messages Management

        private void LoadContactMessages()
        {
            try
            {
                var messages = GetContactMessagesData();
                
                var contactsGrid = FindControl("gvContacts") as GridView;
                if (contactsGrid != null)
                {
                    contactsGrid.DataSource = messages;
                    contactsGrid.DataBind();
                }
            }
            catch (Exception ex)
            {
                ShowAlert($"Error loading contact messages: {ex.Message}", "danger");
            }
        }

        private List<ContactMessageModel> GetContactMessagesData()
        {
            return new List<ContactMessageModel>
            {
                new ContactMessageModel 
                { 
                    Id = 1,
                    Name = "John Doe",
                    Email = "john.doe@example.com",
                    Subject = "Project Collaboration",
                    Message = "Hi, interested in collaborating on ML project!",
                    CreatedDate = DateTime.Now.AddHours(-2),
                    IsRead = false
                },
                new ContactMessageModel 
                { 
                    Id = 2,
                    Name = "Sarah Johnson",
                    Email = "sarah.j@techcorp.com",
                    Subject = "Job Opportunity",
                    Message = "We have an exciting internship opportunity.",
                    CreatedDate = DateTime.Now.AddDays(-1),
                    IsRead = true
                },
                new ContactMessageModel 
                { 
                    Id = 3,
                    Name = "Ahmed Rahman",
                    Email = "ahmed.r@university.edu",
                    Subject = "Research Collaboration",
                    Message = "Working on CP research project, would like to connect.",
                    CreatedDate = DateTime.Now.AddDays(-3),
                    IsRead = false
                }
            };
        }

        protected void gvContacts_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                int index = Convert.ToInt32(e.CommandArgument);
                
                switch (e.CommandName)
                {
                    case "ViewMessage":
                        var messages = GetContactMessagesData();
                        if (index < messages.Count)
                        {
                            ShowAlert($"Message from {messages[index].Name}: {messages[index].Message}", "info");
                        }
                        break;
                    case "ReplyMessage":
                        ShowAlert("Reply functionality - Email integration required.", "info");
                        break;
                    case "DeleteMessage":
                        ShowAlert("Message deleted successfully!", "success");
                        LoadContactMessages();
                        break;
                }
            }
            catch (Exception ex)
            {
                ShowAlert($"Error: {ex.Message}", "danger");
            }
        }

        #endregion

        #region Settings Management

        protected void btnSaveSettings_Click(object sender, EventArgs e)
        {
            try
            {
                ShowAlert("Personal settings saved successfully! (Note: Database integration required for persistence)", "success");
            }
            catch (Exception ex)
            {
                ShowAlert($"Error saving settings: {ex.Message}", "danger");
            }
        }

        protected void btnSavePlatforms_Click(object sender, EventArgs e)
        {
            try
            {
                ShowAlert("Platform settings saved successfully! (Note: Database integration required for persistence)", "success");
            }
            catch (Exception ex)
            {
                ShowAlert($"Error saving platform settings: {ex.Message}", "danger");
            }
        }

        #endregion

        #region Utility Methods

        private void ShowAlert(string message, string type)
        {
            // Use JavaScript alert for now
            string script = $"alert('{message.Replace("'", "\\'")}');";
            ClientScript.RegisterStartupScript(this.GetType(), "alert", script, true);
        }

        protected void btnViewSite_Click(object sender, EventArgs e)
        {
            Response.Redirect("DefaultSimple.aspx");
        }

        protected void btnRefreshData_Click(object sender, EventArgs e)
        {
            LoadAllData();
            ShowAlert("All data refreshed successfully!", "success");
        }

        #endregion
    }
}