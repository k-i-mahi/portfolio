using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace Portfolio
{
    public partial class DefaultSimple : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadSampleData();
            }
        }

        private void LoadSampleData()
        {
            // Load Skills
            LoadSkills();
            
            // Load Competitive Programming Platforms
            LoadCompetitiveProgrammingStats();
            
            // Load Projects
            LoadProjects();
            
            // Load Education
            LoadEducation();
            
            // Load Achievements
            LoadAchievements();
        }

        private void LoadSkills()
        {
            string skillsHtml = @"
                <div class='skill-category'>
                    <h3><i class='fas fa-code'></i> Programming Languages</h3>
                    <div class='skill-item'>
                        <div class='skill-name'><span>C++</span><span>95%</span></div>
                        <div class='skill-bar'><div class='skill-progress' data-width='95'></div></div>
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
                        <div class='skill-name'><span>Python</span><span>78%</span></div>
                        <div class='skill-bar'><div class='skill-progress' data-width='78'></div></div>
                    </div>
                    <div class='skill-item'>
                        <div class='skill-name'><span>JavaScript</span><span>75%</span></div>
                        <div class='skill-bar'><div class='skill-progress' data-width='75'></div></div>
                    </div>
                </div>
                
                <div class='skill-category'>
                    <h3><i class='fas fa-brain'></i> Algorithms & Data Structures</h3>
                    <div class='skill-item'>
                        <div class='skill-name'><span>Data Structures</span><span>92%</span></div>
                        <div class='skill-bar'><div class='skill-progress' data-width='92'></div></div>
                    </div>
                    <div class='skill-item'>
                        <div class='skill-name'><span>Dynamic Programming</span><span>88%</span></div>
                        <div class='skill-bar'><div class='skill-progress' data-width='88'></div></div>
                    </div>
                    <div class='skill-item'>
                        <div class='skill-name'><span>Graph Algorithms</span><span>85%</span></div>
                        <div class='skill-bar'><div class='skill-progress' data-width='85'></div></div>
                    </div>
                    <div class='skill-item'>
                        <div class='skill-name'><span>String Algorithms</span><span>82%</span></div>
                        <div class='skill-bar'><div class='skill-progress' data-width='82'></div></div>
                    </div>
                    <div class='skill-item'>
                        <div class='skill-name'><span>Number Theory</span><span>80%</span></div>
                        <div class='skill-bar'><div class='skill-progress' data-width='80'></div></div>
                    </div>
                </div>
                
                <div class='skill-category'>
                    <h3><i class='fas fa-globe-americas'></i> Web Development</h3>
                    <div class='skill-item'>
                        <div class='skill-name'><span>ASP.NET</span><span>85%</span></div>
                        <div class='skill-bar'><div class='skill-progress' data-width='85'></div></div>
                    </div>
                    <div class='skill-item'>
                        <div class='skill-name'><span>HTML/CSS</span><span>90%</span></div>
                        <div class='skill-bar'><div class='skill-progress' data-width='90'></div></div>
                    </div>
                    <div class='skill-item'>
                        <div class='skill-name'><span>React.js</span><span>75%</span></div>
                        <div class='skill-bar'><div class='skill-progress' data-width='75'></div></div>
                    </div>
                    <div class='skill-item'>
                        <div class='skill-name'><span>Node.js</span><span>70%</span></div>
                        <div class='skill-bar'><div class='skill-progress' data-width='70'></div></div>
                    </div>
                </div>
                
                <div class='skill-category'>
                    <h3><i class='fas fa-database'></i> Database & Tools</h3>
                    <div class='skill-item'>
                        <div class='skill-name'><span>SQL Server</span><span>82%</span></div>
                        <div class='skill-bar'><div class='skill-progress' data-width='82'></div></div>
                    </div>
                    <div class='skill-item'>
                        <div class='skill-name'><span>MySQL</span><span>78%</span></div>
                        <div class='skill-bar'><div class='skill-progress' data-width='78'></div></div>
                    </div>
                    <div class='skill-item'>
                        <div class='skill-name'><span>Git/GitHub</span><span>85%</span></div>
                        <div class='skill-bar'><div class='skill-progress' data-width='85'></div></div>
                    </div>
                    <div class='skill-item'>
                        <div class='skill-name'><span>Visual Studio</span><span>88%</span></div>
                        <div class='skill-bar'><div class='skill-progress' data-width='88'></div></div>
                    </div>
                </div>";

            var skillsGrid = (HtmlGenericControl)FindControl("skillsGrid");
            if (skillsGrid != null)
            {
                skillsGrid.InnerHtml = skillsHtml;
            }
        }

        private void LoadCompetitiveProgrammingStats()
        {
            string programmingStatsHtml = @"
                <div class='platform-card'>
                    <div class='platform-icon'>
                        <i class='fas fa-trophy'></i>
                    </div>
                    <div class='platform-name'>Codeforces</div>
                    <div class='platform-username'>@mahir_kuet</div>
                    <div class='platform-stats'>
                        <div class='stat-item'>
                            <span class='stats-counter'>1456</span>
                            <span class='stats-label'>Max Rating</span>
                        </div>
                        <div class='stat-item'>
                            <span class='stats-counter'>350</span>
                            <span class='stats-label'>Problems Solved</span>
                        </div>
                    </div>
                    <div class='platform-stats'>
                        <div class='stat-item'>
                            <span class='stats-counter'>45</span>
                            <span class='stats-label'>Contests</span>
                        </div>
                        <div class='stat-item'>
                            <span class='stats-counter'>Specialist</span>
                            <span class='stats-label'>Rank</span>
                        </div>
                    </div>
                    <a href='https://codeforces.com/profile/mahir_kuet' target='_blank' class='project-link' style='margin-top: 1rem; display: inline-block;'>
                        <i class='fas fa-external-link-alt'></i> View Profile
                    </a>
                </div>
                
                <div class='platform-card'>
                    <div class='platform-icon'>
                        <i class='fas fa-code'></i>
                    </div>
                    <div class='platform-name'>LeetCode</div>
                    <div class='platform-username'>@mahir_rahman</div>
                    <div class='platform-stats'>
                        <div class='stat-item'>
                            <span class='stats-counter'>1850</span>
                            <span class='stats-label'>Max Rating</span>
                        </div>
                        <div class='stat-item'>
                            <span class='stats-counter'>280</span>
                            <span class='stats-label'>Problems Solved</span>
                        </div>
                    </div>
                    <div class='platform-stats'>
                        <div class='stat-item'>
                            <span class='stats-counter'>15</span>
                            <span class='stats-label'>Contests</span>
                        </div>
                        <div class='stat-item'>
                            <span class='stats-counter'>Knight</span>
                            <span class='stats-label'>Badge</span>
                        </div>
                    </div>
                    <a href='https://leetcode.com/mahir_rahman' target='_blank' class='project-link' style='margin-top: 1rem; display: inline-block;'>
                        <i class='fas fa-external-link-alt'></i> View Profile
                    </a>
                </div>
                
                <div class='platform-card'>
                    <div class='platform-icon'>
                        <i class='fas fa-utensils'></i>
                    </div>
                    <div class='platform-name'>CodeChef</div>
                    <div class='platform-username'>@mahir_kuet</div>
                    <div class='platform-stats'>
                        <div class='stat-item'>
                            <span class='stats-counter'>1680</span>
                            <span class='stats-label'>Max Rating</span>
                        </div>
                        <div class='stat-item'>
                            <span class='stats-counter'>120</span>
                            <span class='stats-label'>Problems Solved</span>
                        </div>
                    </div>
                    <div class='platform-stats'>
                        <div class='stat-item'>
                            <span class='stats-counter'>25</span>
                            <span class='stats-label'>Contests</span>
                        </div>
                        <div class='stat-item'>
                            <span class='stats-counter'>4?</span>
                            <span class='stats-label'>Stars</span>
                        </div>
                    </div>
                    <a href='https://codechef.com/users/mahir_kuet' target='_blank' class='project-link' style='margin-top: 1rem; display: inline-block;'>
                        <i class='fas fa-external-link-alt'></i> View Profile
                    </a>
                </div>
                
                <div class='platform-card'>
                    <div class='platform-icon'>
                        <i class='fab fa-hackerrank'></i>
                    </div>
                    <div class='platform-name'>HackerRank</div>
                    <div class='platform-username'>@mahir_rahman</div>
                    <div class='platform-stats'>
                        <div class='stat-item'>
                            <span class='stats-counter'>2150</span>
                            <span class='stats-label'>Points</span>
                        </div>
                        <div class='stat-item'>
                            <span class='stats-counter'>95</span>
                            <span class='stats-label'>Problems Solved</span>
                        </div>
                    </div>
                    <div class='platform-stats'>
                        <div class='stat-item'>
                            <span class='stats-counter'>5?</span>
                            <span class='stats-label'>Problem Solving</span>
                        </div>
                        <div class='stat-item'>
                            <span class='stats-counter'>Gold</span>
                            <span class='stats-label'>Badge</span>
                        </div>
                    </div>
                    <a href='https://hackerrank.com/mahir_rahman' target='_blank' class='project-link' style='margin-top: 1rem; display: inline-block;'>
                        <i class='fas fa-external-link-alt'></i> View Profile
                    </a>
                </div>
                
                <div class='platform-card'>
                    <div class='platform-icon'>
                        <i class='fas fa-medal'></i>
                    </div>
                    <div class='platform-name'>AtCoder</div>
                    <div class='platform-username'>@mahir_kuet</div>
                    <div class='platform-stats'>
                        <div class='stat-item'>
                            <span class='stats-counter'>1245</span>
                            <span class='stats-label'>Max Rating</span>
                        </div>
                        <div class='stat-item'>
                            <span class='stats-counter'>85</span>
                            <span class='stats-label'>Problems Solved</span>
                        </div>
                    </div>
                    <div class='platform-stats'>
                        <div class='stat-item'>
                            <span class='stats-counter'>18</span>
                            <span class='stats-label'>Contests</span>
                        </div>
                        <div class='stat-item'>
                            <span class='stats-counter'>Brown</span>
                            <span class='stats-label'>Color</span>
                        </div>
                    </div>
                    <a href='https://atcoder.jp/users/mahir_kuet' target='_blank' class='project-link' style='margin-top: 1rem; display: inline-block;'>
                        <i class='fas fa-external-link-alt'></i> View Profile
                    </a>
                </div>
                
                <div class='platform-card'>
                    <div class='platform-icon'>
                        <i class='fab fa-github'></i>
                    </div>
                    <div class='platform-name'>GitHub</div>
                    <div class='platform-username'>@k-i-mahi</div>
                    <div class='platform-stats'>
                        <div class='stat-item'>
                            <span class='stats-counter'>25</span>
                            <span class='stats-label'>Repositories</span>
                        </div>
                        <div class='stat-item'>
                            <span class='stats-counter'>150</span>
                            <span class='stats-label'>Commits</span>
                        </div>
                    </div>
                    <div class='platform-stats'>
                        <div class='stat-item'>
                            <span class='stats-counter'>8</span>
                            <span class='stats-label'>Followers</span>
                        </div>
                        <div class='stat-item'>
                            <span class='stats-counter'>12</span>
                            <span class='stats-label'>Following</span>
                        </div>
                    </div>
                    <a href='https://github.com/k-i-mahi' target='_blank' class='project-link' style='margin-top: 1rem; display: inline-block;'>
                        <i class='fas fa-external-link-alt'></i> View Profile
                    </a>
                </div>";

            var programmingStats = (HtmlGenericControl)FindControl("programmingStats");
            if (programmingStats != null)
            {
                programmingStats.InnerHtml = programmingStatsHtml;
            }
        }

        private void LoadProjects()
        {
            var projects = new List<dynamic>
            {
                new {
                    Title = "Competitive Programming Platform",
                    Description = "A comprehensive online judge system similar to Codeforces with real-time judging capabilities",
                    DetailedDescription = "Built a full-stack competitive programming platform featuring automatic code compilation and execution, real-time contest rankings, problem management system, user authentication, and comprehensive analytics dashboard. Supports multiple programming languages including C++, Java, Python, and C#.",
                    Technologies = "C#, ASP.NET Core, SQL Server, SignalR, Docker",
                    GitHubLink = "https://github.com/k-i-mahi/online-judge-system",
                    LiveDemoLink = "https://cpplatform.mahirrahman.com",
                    ImageUrl = ""
                },
                new {
                    Title = "Algorithm Visualizer Pro",
                    Description = "Interactive educational tool for visualizing complex algorithms and data structures",
                    DetailedDescription = "Created an advanced algorithm visualization platform that helps students understand sorting algorithms, graph algorithms, tree operations, and dynamic programming solutions through interactive animations. Features step-by-step execution, complexity analysis, and code comparison.",
                    Technologies = "React.js, D3.js, Node.js, Express, MongoDB",
                    GitHubLink = "https://github.com/k-i-mahi/algorithm-visualizer",
                    LiveDemoLink = "https://algoviz.mahirrahman.com",
                    ImageUrl = ""
                },
                new {
                    Title = "Smart Contest Management System",
                    Description = "Complete solution for organizing and managing programming contests",
                    DetailedDescription = "Developed a comprehensive contest management system for educational institutions featuring contest creation, participant registration, real-time leaderboards, automatic plagiarism detection, and detailed performance analytics. Used by KUET Programming Club for organizing internal contests.",
                    Technologies = "ASP.NET Web Forms, C#, SQL Server, Bootstrap, Chart.js",
                    GitHubLink = "https://github.com/k-i-mahi/contest-management",
                    LiveDemoLink = "",
                    ImageUrl = ""
                },
                new {
                    Title = "University Academic Portal",
                    Description = "Digital transformation solution for academic administration",
                    DetailedDescription = "Built a comprehensive academic management system for university operations including student enrollment, course management, grade tracking, attendance monitoring, and automated report generation. Implemented role-based access control for students, faculty, and administrators.",
                    Technologies = "ASP.NET MVC, Entity Framework, SQL Server, jQuery",
                    GitHubLink = "https://github.com/k-i-mahi/academic-portal",
                    LiveDemoLink = "",
                    ImageUrl = ""
                },
                new {
                    Title = "Real-time Chat Application",
                    Description = "Modern messaging platform with advanced features",
                    DetailedDescription = "Developed a real-time chat application with features like group messaging, file sharing, emoji support, message encryption, and online status indicators. Implemented using modern web technologies with focus on performance and user experience.",
                    Technologies = "React.js, Socket.io, Node.js, Express, MongoDB",
                    GitHubLink = "https://github.com/k-i-mahi/realtime-chat",
                    LiveDemoLink = "https://chat.mahirrahman.com",
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

        private void LoadEducation()
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
                    Description = "Currently pursuing B.Sc. in Computer Science and Engineering with specialization in algorithms, software engineering, and competitive programming. Active member of KUET Programming Club and ACM Student Chapter. Relevant coursework: Data Structures, Algorithms, Database Systems, Software Engineering, Computer Networks, Operating Systems."
                },
                new {
                    Institution = "Bogura Cantonment Public School & College",
                    Degree = "Higher Secondary Certificate (HSC)",
                    Department = "Science Group",
                    CGPA = "5.00",
                    StartDate = new DateTime(2019, 6, 1),
                    EndDate = new DateTime(2021, 5, 31),
                    IsCurrent = false,
                    Description = "Completed HSC in Science group with perfect GPA 5.00. Concentrated on Mathematics, Physics, Chemistry, and ICT. Participated in various programming contests, mathematics olympiads, and science fairs. Awarded as the best student in ICT."
                },
                new {
                    Institution = "Bogura Cantonment Public School & College",
                    Degree = "Secondary School Certificate (SSC)",
                    Department = "Science Group",
                    CGPA = "5.00",
                    StartDate = new DateTime(2017, 1, 1),
                    EndDate = new DateTime(2019, 5, 31),
                    IsCurrent = false,
                    Description = "Completed SSC in Science group with perfect GPA 5.00. Strong foundation in Mathematics, Science, and ICT. Participated in district-level science olympiad and programming competitions."
                }
            };

            var rptEducation = (Repeater)FindControl("rptEducation");
            if (rptEducation != null)
            {
                rptEducation.DataSource = education;
                rptEducation.DataBind();
            }
        }

        private void LoadAchievements()
        {
            var achievements = new List<dynamic>
            {
                new {
                    Title = "ACM ICPC Asia Dhaka Regional 2024",
                    Platform = "ACM ICPC",
                    Description = "Successfully qualified for ACM ICPC Asia Dhaka Regional Contest 2024 representing Khulna University of Engineering & Technology",
                    Ranking = "Regional Qualifier - Team Rank: 25th",
                    AchievedDate = new DateTime(2024, 10, 15),
                    CertificateUrl = ""
                },
                new {
                    Title = "CodeChef Long Challenge Winner",
                    Platform = "CodeChef",
                    Description = "Secured 1st position in CodeChef October Long Challenge 2024 with perfect score in all problems",
                    Ranking = "1st Place - Division 2",
                    AchievedDate = new DateTime(2024, 10, 8),
                    CertificateUrl = ""
                },
                new {
                    Title = "Codeforces Specialist Achievement",
                    Platform = "Codeforces",
                    Description = "Achieved Specialist rating (1400+) in Codeforces competitive programming with consistent performance across multiple contests",
                    Ranking = "Max Rating: 1456 (Specialist)",
                    AchievedDate = new DateTime(2024, 9, 20),
                    CertificateUrl = ""
                },
                new {
                    Title = "KUET Intra-University Programming Contest",
                    Platform = "KUET Programming Club",
                    Description = "Won 2nd place in KUET Intra-University Programming Contest 2024 among 150+ participants",
                    Ranking = "2nd Place - Individual Category",
                    AchievedDate = new DateTime(2024, 8, 15),
                    CertificateUrl = ""
                },
                new {
                    Title = "LeetCode Contest Global Ranking",
                    Platform = "LeetCode",
                    Description = "Achieved top 5% global ranking in LeetCode Weekly Contest 367 with all problems solved correctly",
                    Ranking = "Global Rank: 485/12,000+",
                    AchievedDate = new DateTime(2024, 7, 28),
                    CertificateUrl = ""
                },
                new {
                    Title = "HackerRank Problem Solving Gold Badge",
                    Platform = "HackerRank",
                    Description = "Earned Gold badge in Problem Solving domain with 5-star rating by solving 90+ algorithmic challenges",
                    Ranking = "5 Stars - Gold Badge",
                    AchievedDate = new DateTime(2024, 6, 10),
                    CertificateUrl = ""
                },
                new {
                    Title = "National High School Programming Contest",
                    Platform = "Bangladesh Olympiad on Informatics",
                    Description = "Secured 3rd position in National High School Programming Contest 2021 representing Bogura district",
                    Ranking = "3rd Place - National Level",
                    AchievedDate = new DateTime(2021, 2, 15),
                    CertificateUrl = ""
                },
                new {
                    Title = "Perfect Academic Performance",
                    Platform = "Academic Excellence",
                    Description = "Maintained perfect GPA 5.00 in both SSC and HSC examinations with outstanding performance in Mathematics and ICT",
                    Ranking = "GPA 5.00/5.00",
                    AchievedDate = new DateTime(2021, 7, 30),
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

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                var txtName = (TextBox)FindControl("txtName");
                var txtEmail = (TextBox)FindControl("txtEmail");
                var txtMessage = (TextBox)FindControl("txtMessage");

                // For demo purposes, just show success message
                if (txtName != null && txtEmail != null && txtMessage != null &&
                    !string.IsNullOrEmpty(txtName.Text) && !string.IsNullOrEmpty(txtEmail.Text) && !string.IsNullOrEmpty(txtMessage.Text))
                {
                    ShowMessage($"Thank you {txtName.Text}! Your message has been received. I'll get back to you soon at {txtEmail.Text}. (This is a demo - in production, messages would be saved to database)", "success");
                    ClearContactForm();
                }
                else
                {
                    ShowMessage("Please fill in all required fields (Name, Email, and Message).", "error");
                }
            }
            catch (Exception ex)
            {
                ShowMessage("An unexpected error occurred while sending your message. Please try again later.", "error");
                // In production, log the exception: Logger.LogError(ex, "Contact form submission error");
            }
        }

        private void ShowMessage(string message, string type)
        {
            var pnlMessage = (Panel)FindControl("pnlMessage");
            var litMessage = (Literal)FindControl("litMessage");
            
            if (pnlMessage != null && litMessage != null)
            {
                pnlMessage.Visible = true;
                string iconClass = type == "success" ? "fas fa-check-circle" : "fas fa-exclamation-triangle";
                litMessage.Text = $"<div class='alert alert-{type}'><i class='{iconClass}'></i> {message}</div>";
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