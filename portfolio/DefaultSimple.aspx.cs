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
            
            // Load Interests & Activities
            LoadInterests();
            
            // Load Clubs & Organizations
            LoadClubs();
            
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
                        <div class='skill-name'><span>Python</span><span>88%</span></div>
                        <div class='skill-bar'><div class='skill-progress' data-width='88'></div></div>
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
                    <h3><i class='fas fa-robot'></i> Hardware & Robotics</h3>
                    <div class='skill-item'>
                        <div class='skill-name'><span>Arduino Programming</span><span>85%</span></div>
                        <div class='skill-bar'><div class='skill-progress' data-width='85'></div></div>
                    </div>
                    <div class='skill-item'>
                        <div class='skill-name'><span>Sensor Integration</span><span>82%</span></div>
                        <div class='skill-bar'><div class='skill-progress' data-width='82'></div></div>
                    </div>
                    <div class='skill-item'>
                        <div class='skill-name'><span>Circuit Design</span><span>78%</span></div>
                        <div class='skill-bar'><div class='skill-progress' data-width='78'></div></div>
                    </div>
                    <div class='skill-item'>
                        <div class='skill-name'><span>Robotics</span><span>80%</span></div>
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
                    <h3><i class='fas fa-chart-line'></i> Data Science & ML</h3>
                    <div class='skill-item'>
                        <div class='skill-name'><span>Pandas</span><span>80%</span></div>
                        <div class='skill-bar'><div class='skill-progress' data-width='80'></div></div>
                    </div>
                    <div class='skill-item'>
                        <div class='skill-name'><span>NumPy</span><span>78%</span></div>
                        <div class='skill-bar'><div class='skill-progress' data-width='78'></div></div>
                    </div>
                    <div class='skill-item'>
                        <div class='skill-name'><span>Scikit-learn</span><span>75%</span></div>
                        <div class='skill-bar'><div class='skill-progress' data-width='75'></div></div>
                    </div>
                    <div class='skill-item'>
                        <div class='skill-name'><span>Data Visualization</span><span>72%</span></div>
                        <div class='skill-bar'><div class='skill-progress' data-width='72'></div></div>
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

        private void LoadInterests()
        {
            string interestsHtml = @"
                <div class='interest-card kaggle-card'>
                    <div class='interest-icon'>
                        <i class='fab fa-kaggle'></i>
                    </div>
                    <div class='interest-name'>Kaggle Competitions</div>
                    <div class='interest-description'>Participating in data science and machine learning competitions</div>
                    <div class='platform-stats'>
                        <div class='stat-item'>
                            <span class='stats-counter'>15</span>
                            <span class='stats-label'>Competitions</span>
                        </div>
                        <div class='stat-item'>
                            <span class='stats-counter'>Bronze</span>
                            <span class='stats-label'>Highest Medal</span>
                        </div>
                    </div>
                    <div class='platform-stats'>
                        <div class='stat-item'>
                            <span class='stats-counter'>1250</span>
                            <span class='stats-label'>Ranking Points</span>
                        </div>
                        <div class='stat-item'>
                            <span class='stats-counter'>Expert</span>
                            <span class='stats-label'>Tier</span>
                        </div>
                    </div>
                    <a href='https://kaggle.com/mahirrahman' target='_blank' class='project-link' style='margin-top: 1rem; display: inline-block;'>
                        <i class='fas fa-external-link-alt'></i> View Profile
                    </a>
                </div>

                <div class='interest-card hardware-card'>
                    <div class='interest-icon'>
                        <i class='fas fa-robot'></i>
                    </div>
                    <div class='interest-name'>Hardware Projects</div>
                    <div class='interest-description'>Building robots and embedded systems</div>
                    <div class='platform-stats'>
                        <div class='stat-item'>
                            <span class='stats-counter'>8</span>
                            <span class='stats-label'>Projects Built</span>
                        </div>
                        <div class='stat-item'>
                            <span class='stats-counter'>Arduino</span>
                            <span class='stats-label'>Primary Platform</span>
                        </div>
                    </div>
                    <div style='margin-top: 1rem; font-size: 0.9rem; color: var(--text-light);'>
                        <strong>Featured Projects:</strong><br>
                        • Obstacle Avoiding Robot<br>
                        • Line Following Robot (LFR)<br>
                        • Smart Home Automation<br>
                        • Sensor-based Monitoring System
                    </div>
                </div>

                <div class='interest-card chess-card'>
                    <div class='interest-icon'>
                        <i class='fas fa-chess'></i>
                    </div>
                    <div class='interest-name'>Chess</div>
                    <div class='interest-description'>Strategic gameplay on online platforms</div>
                    <div class='platform-stats'>
                        <div class='stat-item'>
                            <span class='stats-counter'>1650</span>
                            <span class='stats-label'>Chess.com Rating</span>
                        </div>
                        <div class='stat-item'>
                            <span class='stats-counter'>1580</span>
                            <span class='stats-label'>Lichess Rating</span>
                        </div>
                    </div>
                    <div class='platform-stats'>
                        <div class='stat-item'>
                            <span class='stats-counter'>500+</span>
                            <span class='stats-label'>Games Played</span>
                        </div>
                        <div class='stat-item'>
                            <span class='stats-counter'>72%</span>
                            <span class='stats-label'>Win Rate</span>
                        </div>
                    </div>
                    <div style='display: flex; gap: 0.5rem; margin-top: 1rem; justify-content: center;'>
                        <a href='https://chess.com/member/mahir_kuet' target='_blank' class='project-link'>
                            <i class='fas fa-external-link-alt'></i> Chess.com
                        </a>
                        <a href='https://lichess.org/@/mahir_kuet' target='_blank' class='project-link'>
                            <i class='fas fa-external-link-alt'></i> Lichess
                        </a>
                    </div>
                </div>

                <div class='interest-card photography-card'>
                    <div class='interest-icon'>
                        <i class='fas fa-camera'></i>
                    </div>
                    <div class='interest-name'>Photography</div>
                    <div class='interest-description'>Capturing moments and exploring creative visual storytelling</div>
                    <div class='platform-stats'>
                        <div class='stat-item'>
                            <span class='stats-counter'>Nature</span>
                            <span class='stats-label'>Favorite Genre</span>
                        </div>
                        <div class='stat-item'>
                            <span class='stats-counter'>Portrait</span>
                            <span class='stats-label'>Specialty</span>
                        </div>
                    </div>
                    <div style='margin-top: 1rem; font-size: 0.9rem; color: var(--text-light); text-align: center;'>
                        <strong>Focus Areas:</strong><br>
                        Landscape • Portrait • Street Photography<br>
                        Event Coverage • Technical Documentation
                    </div>
                    <div class='photo-gallery' style='margin-top: 1rem;'>
                        <div class='photo-item'><i class='fas fa-mountain'></i></div>
                        <div class='photo-item'><i class='fas fa-user'></i></div>
                        <div class='photo-item'><i class='fas fa-city'></i></div>
                        <div class='photo-item'><i class='fas fa-calendar-alt'></i></div>
                    </div>
                </div>";

            var interestsGrid = (HtmlGenericControl)FindControl("interestsGrid");
            if (interestsGrid != null)
            {
                interestsGrid.InnerHtml = interestsHtml;
            }
        }

        private void LoadClubs()
        {
            string clubsHtml = @"
                <div class='club-card club-sgipc'>
                    <div class='club-icon'>
                        <i class='fas fa-users-cog'></i>
                    </div>
                    <div class='club-name'>SGIPC</div>
                    <div class='club-description'>Special Group Interest in Competitive Programming</div>
                    <div style='margin: 1.5rem 0; padding: 1rem; background: var(--bg-color); border-radius: 8px; text-align: left;'>
                        <strong>Role:</strong> Active Member<br>
                        <strong>Duration:</strong> 2023 - Present<br>
                        <strong>Activities:</strong><br>
                        • Weekly competitive programming sessions<br>
                        • Problem-solving workshops<br>
                        • Contest organization and participation<br>
                        • Mentoring junior members<br>
                        • Algorithm study groups
                    </div>
                    <div class='platform-stats'>
                        <div class='stat-item'>
                            <span class='stats-counter'>50+</span>
                            <span class='stats-label'>Sessions Attended</span>
                        </div>
                        <div class='stat-item'>
                            <span class='stats-counter'>15+</span>
                            <span class='stats-label'>Problems Discussed</span>
                        </div>
                    </div>
                </div>

                <div class='club-card club-hack'>
                    <div class='club-icon'>
                        <i class='fas fa-microchip'></i>
                    </div>
                    <div class='club-name'>HACK</div>
                    <div class='club-description'>Hardware Acceleration Club of KUET</div>
                    <div style='margin: 1.5rem 0; padding: 1rem; background: var(--bg-color); border-radius: 8px; text-align: left;'>
                        <strong>Role:</strong> Project Member<br>
                        <strong>Duration:</strong> 2023 - Present<br>
                        <strong>Activities:</strong><br>
                        • Hardware project development<br>
                        • Arduino and microcontroller programming<br>
                        • Robot building workshops<br>
                        • IoT project implementations<br>
                        • Technical documentation
                    </div>
                    <div class='platform-stats'>
                        <div class='stat-item'>
                            <span class='stats-counter'>8</span>
                            <span class='stats-label'>Projects Completed</span>
                        </div>
                        <div class='stat-item'>
                            <span class='stats-counter'>25+</span>
                            <span class='stats-label'>Workshop Hours</span>
                        </div>
                    </div>
                </div>

                <div class='club-card'>
                    <div class='club-icon'>
                        <i class='fas fa-graduation-cap'></i>
                    </div>
                    <div class='club-name'>KUET Programming Club</div>
                    <div class='club-description'>Official Programming Club of KUET</div>
                    <div style='margin: 1.5rem 0; padding: 1rem; background: var(--bg-color); border-radius: 8px; text-align: left;'>
                        <strong>Role:</strong> Executive Member<br>
                        <strong>Duration:</strong> 2022 - Present<br>
                        <strong>Activities:</strong><br>
                        • Organizing intra-university contests<br>
                        • Training sessions for ICPC<br>
                        • Workshops on advanced algorithms<br>
                        • Coordination with other universities<br>
                        • Event management and logistics
                    </div>
                    <div class='platform-stats'>
                        <div class='stat-item'>
                            <span class='stats-counter'>12</span>
                            <span class='stats-label'>Events Organized</span>
                        </div>
                        <div class='stat-item'>
                            <span class='stats-counter'>300+</span>
                            <span class='stats-label'>Students Trained</span>
                        </div>
                    </div>
                </div>";

            var clubsGrid = (HtmlGenericControl)FindControl("clubsGrid");
            if (clubsGrid != null)
            {
                clubsGrid.InnerHtml = clubsHtml;
            }
        }

        private void LoadProjects()
        {
            var projects = new List<dynamic>
            {
                new {
                    Title = "Obstacle Avoiding Robot",
                    Description = "Autonomous robot using ultrasonic sensors for navigation and obstacle detection",
                    DetailedDescription = "Built an intelligent obstacle-avoiding robot using Arduino Uno, ultrasonic sensors (HC-SR04), servo motors, and custom pathfinding algorithms. The robot can navigate complex environments autonomously, detect obstacles in real-time, and choose optimal paths. Features include distance measurement, servo-controlled sensor scanning, motor control, and LED indicators for status feedback.",
                    Technologies = "Arduino, C++, Ultrasonic Sensors, Servo Motors, Motor Drivers",
                    GitHubLink = "https://github.com/k-i-mahi/obstacle-avoiding-robot",
                    LiveDemoLink = "",
                    ImageUrl = ""
                },
                new {
                    Title = "Line Following Robot (LFR)",
                    Description = "Precision line-following robot for competitive robotics with PID control",
                    DetailedDescription = "Developed a high-precision line-following robot for competitive robotics using IR sensors, PID control algorithm, and optimized motor control. The robot demonstrates excellent line-tracking capabilities, smooth turns, and adaptive speed control. Implemented advanced features like junction detection, path optimization, and real-time sensor calibration.",
                    Technologies = "Arduino, PID Control, IR Sensors, Motor Controllers, C++",
                    GitHubLink = "https://github.com/k-i-mahi/line-following-robot",
                    LiveDemoLink = "",
                    ImageUrl = ""
                },
                new {
                    Title = "Competitive Programming Platform",
                    Description = "A comprehensive online judge system similar to Codeforces with real-time judging capabilities",
                    DetailedDescription = "Built a full-stack competitive programming platform featuring automatic code compilation and execution, real-time contest rankings, problem management system, user authentication, and comprehensive analytics dashboard. Supports multiple programming languages including C++, Java, Python, and C#. Includes features like plagiarism detection, contest scheduling, and performance analytics.",
                    Technologies = "C#, ASP.NET Core, SQL Server, SignalR, Docker, Redis",
                    GitHubLink = "https://github.com/k-i-mahi/online-judge-system",
                    LiveDemoLink = "https://cpplatform.mahirrahman.com",
                    ImageUrl = ""
                },
                new {
                    Title = "Kaggle Competition Solutions",
                    Description = "Collection of machine learning solutions for various Kaggle competitions",
                    DetailedDescription = "Comprehensive repository containing solutions for 15+ Kaggle competitions across different domains including tabular data, computer vision, and NLP. Features ensemble methods, feature engineering techniques, model optimization, and detailed analysis notebooks. Achieved bronze medal in Titanic competition and top 20% finish in House Prices prediction.",
                    Technologies = "Python, Pandas, Scikit-learn, XGBoost, TensorFlow, Jupyter",
                    GitHubLink = "https://github.com/k-i-mahi/kaggle-solutions",
                    LiveDemoLink = "https://kaggle.com/mahirrahman",
                    ImageUrl = ""
                },
                new {
                    Title = "Smart Home Automation System",
                    Description = "IoT-based home automation system with mobile app control and voice commands",
                    DetailedDescription = "Developed a comprehensive smart home automation system using ESP32, sensors, and mobile application. Features include remote control of lights, fans, and appliances, voice command integration, temperature and humidity monitoring, security alerts, and energy consumption tracking. Implemented RESTful APIs for seamless communication between hardware and mobile app.",
                    Technologies = "ESP32, Arduino IDE, Firebase, Android Studio, Java, IoT Sensors",
                    GitHubLink = "https://github.com/k-i-mahi/smart-home-automation",
                    LiveDemoLink = "",
                    ImageUrl = ""
                },
                new {
                    Title = "Chess Game Analysis Tool",
                    Description = "Python-based chess game analyzer with position evaluation and move suggestions",
                    DetailedDescription = "Created an advanced chess analysis tool that can analyze games, evaluate positions, suggest optimal moves, and identify tactical patterns. Features include integration with chess engines, PGN file support, opening database, endgame tablebase integration, and visual board representation. Useful for improving chess skills and game analysis.",
                    Technologies = "Python, Stockfish Engine, Chess.py, Tkinter, PGN Parser",
                    GitHubLink = "https://github.com/k-i-mahi/chess-analyzer",
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
                    Description = "Currently pursuing B.Sc. in Computer Science and Engineering with specialization in algorithms, software engineering, and competitive programming. Active member of KUET Programming Club, SGIPC, and HACK club. Relevant coursework: Data Structures & Algorithms, Database Systems, Software Engineering, Computer Networks, Operating Systems, Artificial Intelligence, Machine Learning, and Digital Logic Design."
                },
                new {
                    Institution = "Bogura Cantonment Public School & College",
                    Degree = "Higher Secondary Certificate (HSC)",
                    Department = "Science Group",
                    CGPA = "5.00",
                    StartDate = new DateTime(2019, 6, 1),
                    EndDate = new DateTime(2021, 5, 31),
                    IsCurrent = false,
                    Description = "Completed HSC in Science group with perfect GPA 5.00. Concentrated on Mathematics, Physics, Chemistry, and ICT. Participated in various programming contests, mathematics olympiads, and science fairs. Awarded as the best student in ICT. Led the school programming team and organized coding workshops for junior students."
                },
                new {
                    Institution = "Bogura Cantonment Public School & College",
                    Degree = "Secondary School Certificate (SSC)",
                    Department = "Science Group",
                    CGPA = "5.00",
                    StartDate = new DateTime(2017, 1, 1),
                    EndDate = new DateTime(2019, 5, 31),
                    IsCurrent = false,
                    Description = "Completed SSC in Science group with perfect GPA 5.00. Strong foundation in Mathematics, Science, and ICT. Participated in district-level science olympiad and programming competitions. Started competitive programming journey during this period and built first programming projects."
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
                    Description = "Successfully qualified for ACM ICPC Asia Dhaka Regional Contest 2024 representing Khulna University of Engineering & Technology with team 'KUET_CodeCrafters'",
                    Ranking = "Regional Qualifier - Team Rank: 25th",
                    AchievedDate = new DateTime(2024, 10, 15),
                    CertificateUrl = ""
                },
                new {
                    Title = "Kaggle Competition Bronze Medal",
                    Platform = "Kaggle",
                    Description = "Achieved Bronze Medal in Kaggle's 'Spaceship Titanic' machine learning competition with top 15% finish among 2000+ participants",
                    Ranking = "Bronze Medal - Top 15%",
                    AchievedDate = new DateTime(2024, 9, 28),
                    CertificateUrl = ""
                },
                new {
                    Title = "HACK Club Best Hardware Project",
                    Platform = "HACK - KUET",
                    Description = "Won Best Hardware Project award for developing an advanced obstacle-avoiding robot with AI-based pathfinding at KUET Hardware Exhibition 2024",
                    Ranking = "1st Place - Best Project Award",
                    AchievedDate = new DateTime(2024, 9, 15),
                    CertificateUrl = ""
                },
                new {
                    Title = "CodeChef Long Challenge Winner",
                    Platform = "CodeChef",
                    Description = "Secured 1st position in CodeChef October Long Challenge 2024 with perfect score in all problems in Division 2 category",
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
                    Description = "Won 2nd place in KUET Intra-University Programming Contest 2024 among 150+ participants in individual category",
                    Ranking = "2nd Place - Individual Category",
                    AchievedDate = new DateTime(2024, 8, 15),
                    CertificateUrl = ""
                },
                new {
                    Title = "Chess Tournament Runner-up",
                    Platform = "KUET Chess Club",
                    Description = "Secured 2nd position in KUET Inter-Department Chess Championship 2024 representing CSE department",
                    Ranking = "2nd Place - Inter-Department",
                    AchievedDate = new DateTime(2024, 7, 22),
                    CertificateUrl = ""
                },
                new {
                    Title = "LeetCode Contest Global Ranking",
                    Platform = "LeetCode",
                    Description = "Achieved top 5% global ranking in LeetCode Weekly Contest 367 with all problems solved correctly within time limit",
                    Ranking = "Global Rank: 485/12,000+",
                    AchievedDate = new DateTime(2024, 7, 28),
                    CertificateUrl = ""
                },
                new {
                    Title = "HackerRank Problem Solving Gold Badge",
                    Platform = "HackerRank",
                    Description = "Earned Gold badge in Problem Solving domain with 5-star rating by solving 95+ algorithmic challenges across various difficulty levels",
                    Ranking = "5 Stars - Gold Badge",
                    AchievedDate = new DateTime(2024, 6, 10),
                    CertificateUrl = ""
                },
                new {
                    Title = "National High School Programming Contest",
                    Platform = "Bangladesh Olympiad on Informatics",
                    Description = "Secured 3rd position in National High School Programming Contest 2021 representing Bogura district with excellent performance in algorithms",
                    Ranking = "3rd Place - National Level",
                    AchievedDate = new DateTime(2021, 2, 15),
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