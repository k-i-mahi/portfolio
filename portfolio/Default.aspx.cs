using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;
using Portfolio.Data;
using Portfolio.Models;

namespace Portfolio
{
    public partial class Default : System.Web.UI.Page
    {
        private PortfolioDataAccess dataAccess;
        private bool isDatabaseAvailable = true;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadPortfolioData();
            }
        }

        private void LoadPortfolioData()
        {
            try
            {
                dataAccess = new PortfolioDataAccess();
                LoadDatabaseData();
            }
            catch (Exception ex)
            {
                // Database not available, load sample data
                isDatabaseAvailable = false;
                LoadSampleData();
                ShowMessage("Portfolio is running with sample data. Configure database connection in Web.config for full functionality.", "info");
            }
        }

        private void LoadDatabaseData()
        {
            // Load Projects
            var projects = dataAccess.GetAllProjects();
            var rptProjects = (Repeater)FindControl("rptProjects");
            if (rptProjects != null)
            {
                rptProjects.DataSource = projects;
                rptProjects.DataBind();
            }

            // Load Education
            var education = dataAccess.GetAllEducation();
            var rptEducation = (Repeater)FindControl("rptEducation");
            if (rptEducation != null)
            {
                rptEducation.DataSource = education;
                rptEducation.DataBind();
            }

            // Load Achievements
            var achievements = dataAccess.GetAllAchievements();
            var rptAchievements = (Repeater)FindControl("rptAchievements");
            if (rptAchievements != null)
            {
                rptAchievements.DataSource = achievements;
                rptAchievements.DataBind();
            }

            // Load Skills
            LoadSkillsFromDatabase();
        }

        private void LoadSampleData()
        {
            // Load sample skills
            LoadSampleSkills();
            
            // Load sample projects
            LoadSampleProjects();
            
            // Load sample education
            LoadSampleEducation();
            
            // Load sample achievements
            LoadSampleAchievements();
        }

        private void LoadSampleSkills()
        {
            string skillsHtml = @"
                <div class='skill-category'>
                    <h3>Programming Languages</h3>
                    <div class='skill-item'>
                        <div class='skill-name'><span>C++</span><span>90%</span></div>
                        <div class='skill-bar'><div class='skill-progress' data-width='90'></div></div>
                    </div>
                    <div class='skill-item'>
                        <div class='skill-name'><span>Java</span><span>85%</span></div>
                        <div class='skill-bar'><div class='skill-progress' data-width='85'></div></div>
                    </div>
                    <div class='skill-item'>
                        <div class='skill-name'><span>C#</span><span>80%</span></div>
                        <div class='skill-bar'><div class='skill-progress' data-width='80'></div></div>
                    </div>
                    <div class='skill-item'>
                        <div class='skill-name'><span>Python</span><span>75%</span></div>
                        <div class='skill-bar'><div class='skill-progress' data-width='75'></div></div>
                    </div>
                </div>
                
                <div class='skill-category'>
                    <h3>Algorithms & Data Structures</h3>
                    <div class='skill-item'>
                        <div class='skill-name'><span>Data Structures</span><span>90%</span></div>
                        <div class='skill-bar'><div class='skill-progress' data-width='90'></div></div>
                    </div>
                    <div class='skill-item'>
                        <div class='skill-name'><span>Dynamic Programming</span><span>85%</span></div>
                        <div class='skill-bar'><div class='skill-progress' data-width='85'></div></div>
                    </div>
                    <div class='skill-item'>
                        <div class='skill-name'><span>Graph Algorithms</span><span>82%</span></div>
                        <div class='skill-bar'><div class='skill-progress' data-width='82'></div></div>
                    </div>
                </div>
                
                <div class='skill-category'>
                    <h3>Web Development</h3>
                    <div class='skill-item'>
                        <div class='skill-name'><span>ASP.NET</span><span>80%</span></div>
                        <div class='skill-bar'><div class='skill-progress' data-width='80'></div></div>
                    </div>
                    <div class='skill-item'>
                        <div class='skill-name'><span>JavaScript</span><span>70%</span></div>
                        <div class='skill-bar'><div class='skill-progress' data-width='70'></div></div>
                    </div>
                    <div class='skill-item'>
                        <div class='skill-name'><span>SQL Server</span><span>80%</span></div>
                        <div class='skill-bar'><div class='skill-progress' data-width='80'></div></div>
                    </div>
                </div>";

            var skillsGrid = FindControl("skills-grid");
            if (skillsGrid != null)
            {
                var literal = new Literal { Text = skillsHtml };
                skillsGrid.Controls.Add(literal);
            }
        }

        private void LoadSampleProjects()
        {
            var projects = new List<dynamic>
            {
                new {
                    Title = "Online Judge System",
                    Description = "A competitive programming platform similar to Codeforces with automatic judging",
                    DetailedDescription = "Built a comprehensive online judge system that allows users to submit solutions in multiple programming languages, automatic judging with test cases, real-time rankings, and contest management features.",
                    Technologies = "C#, ASP.NET, SQL Server, JavaScript",
                    GitHubLink = "https://github.com/yourusername/online-judge",
                    LiveDemoLink = "https://yourproject.com/judge",
                    ImageUrl = ""
                },
                new {
                    Title = "Algorithm Visualizer",
                    Description = "Interactive visualization tool for sorting and graph algorithms",
                    DetailedDescription = "Created an educational tool that visualizes various algorithms including sorting algorithms and graph algorithms. Helps students understand algorithm execution step by step.",
                    Technologies = "JavaScript, HTML5 Canvas, CSS3",
                    GitHubLink = "https://github.com/yourusername/algo-visualizer",
                    LiveDemoLink = "https://yourproject.com/visualizer",
                    ImageUrl = ""
                },
                new {
                    Title = "Student Management System",
                    Description = "Complete web application for managing student records and grades",
                    DetailedDescription = "Developed a full-stack web application for educational institutions to manage student information, course enrollment, grade tracking, and generate reports.",
                    Technologies = "ASP.NET Web Forms, C#, SQL Server, Bootstrap",
                    GitHubLink = "https://github.com/yourusername/student-management",
                    LiveDemoLink = "",
                    ImageUrl = ""
                }
            };

            var rptProjects = (Repeater)FindControl("rptProjects");
            if (rptProjects != null)
            {
                rptProjects.DataSource = projects;
                rptProjects.DataBind();
            }
        }

        private void LoadSampleEducation()
        {
            var education = new List<dynamic>
            {
                new {
                    Institution = "Khulna University of Engineering & Technology (KUET)",
                    Degree = "Bachelor of Science in Computer Science and Engineering",
                    Department = "Computer Science and Engineering",
                    CGPA = "3.75",
                    StartDate = new DateTime(2022, 1, 1),
                    EndDate = (DateTime?)null,
                    IsCurrent = true,
                    Description = "Currently pursuing B.Sc. in Computer Science and Engineering with focus on software engineering, algorithms, and competitive programming. Active member of KUET Programming Club."
                },
                new {
                    Institution = "Your College Name",
                    Degree = "Higher Secondary Certificate (HSC)",
                    Department = "Science Group",
                    CGPA = "5.00",
                    StartDate = new DateTime(2019, 6, 1),
                    EndDate = new DateTime(2021, 5, 31),
                    IsCurrent = false,
                    Description = "Completed HSC in Science group with GPA 5.00. Participated in various programming contests and mathematics olympiads."
                }
            };

            var rptEducation = (Repeater)FindControl("rptEducation");
            if (rptEducation != null)
            {
                rptEducation.DataSource = education;
                rptEducation.DataBind();
            }
        }

        private void LoadSampleAchievements()
        {
            var achievements = new List<dynamic>
            {
                new {
                    Title = "Monthly Contest Winner",
                    Platform = "CodeChef",
                    Description = "Won 1st place in CodeChef monthly long challenge with perfect score",
                    Ranking = "1st Place",
                    AchievedDate = new DateTime(2024, 8, 15),
                    CertificateUrl = ""
                },
                new {
                    Title = "Specialist Rating Achieved",
                    Platform = "Codeforces",
                    Description = "Achieved Specialist rating (1400+) in Codeforces competitive programming",
                    Ranking = "Max Rating: 1456",
                    AchievedDate = new DateTime(2024, 7, 20),
                    CertificateUrl = ""
                },
                new {
                    Title = "ACM ICPC Regional Qualifier",
                    Platform = "ACM ICPC",
                    Description = "Successfully qualified for ACM ICPC Asia Dhaka Regional Contest representing KUET",
                    Ranking = "Team Rank: 25th",
                    AchievedDate = new DateTime(2024, 6, 10),
                    CertificateUrl = ""
                },
                new {
                    Title = "HackerRank Problem Solving Gold",
                    Platform = "HackerRank",
                    Description = "Earned Gold badge in Problem Solving domain with 5-star rating",
                    Ranking = "Gold Badge",
                    AchievedDate = new DateTime(2024, 5, 15),
                    CertificateUrl = ""
                }
            };

            var rptAchievements = (Repeater)FindControl("rptAchievements");
            if (rptAchievements != null)
            {
                rptAchievements.DataSource = achievements;
                rptAchievements.DataBind();
            }
        }

        private void LoadSkillsFromDatabase()
        {
            try
            {
                var skills = dataAccess.GetAllSkills();
                var groupedSkills = skills.GroupBy(s => s.Category).ToList();

                string skillsHtml = "";
                
                foreach (var group in groupedSkills)
                {
                    skillsHtml += $"<div class='skill-category'><h3>{group.Key}</h3>";
                    foreach (var skill in group.OrderBy(s => s.DisplayOrder))
                    {
                        skillsHtml += $@"
                            <div class='skill-item'>
                                <div class='skill-name'>
                                    <span>{skill.Name}</span>
                                    <span>{skill.ProficiencyLevel}%</span>
                                </div>
                                <div class='skill-bar'>
                                    <div class='skill-progress' data-width='{skill.ProficiencyLevel}'></div>
                                </div>
                            </div>";
                    }
                    skillsHtml += "</div>";
                }

                var skillsGrid = FindControl("skills-grid");
                if (skillsGrid != null)
                {
                    var literal = new Literal { Text = skillsHtml };
                    skillsGrid.Controls.Add(literal);
                }
            }
            catch (Exception ex)
            {
                LoadSampleSkills();
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                var txtName = (TextBox)FindControl("txtName");
                var txtEmail = (TextBox)FindControl("txtEmail");
                var txtPhone = (TextBox)FindControl("txtPhone");
                var txtSubject = (TextBox)FindControl("txtSubject");
                var txtMessage = (TextBox)FindControl("txtMessage");

                if (isDatabaseAvailable && dataAccess != null)
                {
                    if (txtName != null && txtEmail != null && txtMessage != null)
                    {
                        var contact = new Contact
                        {
                            Name = txtName.Text.Trim(),
                            Email = txtEmail.Text.Trim(),
                            Phone = txtPhone?.Text.Trim() ?? "",
                            Subject = txtSubject?.Text.Trim() ?? "",
                            Message = txtMessage.Text.Trim(),
                            CreatedDate = DateTime.Now,
                            IsRead = false
                        };

                        if (dataAccess.SaveContact(contact))
                        {
                            ShowMessage("Thank you for your message! I'll get back to you soon.", "success");
                            ClearContactForm();
                        }
                        else
                        {
                            ShowMessage("Sorry, there was an error sending your message. Please try again.", "error");
                        }
                    }
                }
                else
                {
                    // Demo mode - just show success message
                    if (txtName != null && txtEmail != null && txtMessage != null &&
                        !string.IsNullOrEmpty(txtName.Text) && !string.IsNullOrEmpty(txtEmail.Text) && !string.IsNullOrEmpty(txtMessage.Text))
                    {
                        ShowMessage("Thank you for your message! (Demo mode - message not saved. Configure database for full functionality.)", "success");
                        ClearContactForm();
                    }
                    else
                    {
                        ShowMessage("Please fill in all required fields.", "error");
                    }
                }
            }
            catch (Exception ex)
            {
                ShowMessage("An error occurred while sending your message. Please try again later.", "error");
            }
        }

        private void ShowMessage(string message, string type)
        {
            var pnlMessage = (Panel)FindControl("pnlMessage");
            var litMessage = (Literal)FindControl("litMessage");
            
            if (pnlMessage != null && litMessage != null)
            {
                pnlMessage.Visible = true;
                litMessage.Text = $"<div class='alert alert-{type}'>{message}</div>";
            }
        }

        private void ClearContactForm()
        {
            var txtName = (TextBox)FindControl("txtName");
            var txtEmail = (TextBox)FindControl("txtEmail");
            var txtPhone = (TextBox)FindControl("txtPhone");
            var txtSubject = (TextBox)FindControl("txtSubject");
            var txtMessage = (TextBox)FindControl("txtMessage");

            if (txtName != null) txtName.Text = "";
            if (txtEmail != null) txtEmail.Text = "";
            if (txtPhone != null) txtPhone.Text = "";
            if (txtSubject != null) txtSubject.Text = "";
            if (txtMessage != null) txtMessage.Text = "";
        }
    }
}