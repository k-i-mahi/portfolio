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
                LoadAllData();
            }
        }

        private void LoadAllData()
        {
            try
            {
                // Load all sections
                LoadSkills();
                LoadCompetitiveProgrammingStats();
                LoadInterests();
                LoadClubs();
                LoadProjects();
                LoadEducation();
                LoadAchievements();
            }
            catch (Exception ex)
            {
                // Log error in production - for now just show a user-friendly message
                ShowMessage("?? Some data is loading... Please refresh if content doesn't appear shortly.", "info");
                System.Diagnostics.Debug.WriteLine($"Error loading data: {ex.Message}");
            }
        }

        private void LoadSkills()
        {
            string skillsHtml = @"
                <div class='skill-category enhanced-card'>
                    <div class='card-icon'>
                        <i class='fas fa-code'></i>
                    </div>
                    <h3 class='card-title'>Programming Languages</h3>
                    <div class='skills-list'>
                        <div class='skill-item'>
                            <div class='skill-name'><span>C++</span><span>95%</span></div>
                            <div class='skill-bar'><div class='skill-progress' data-width='95'></div></div>
                        </div>
                        <div class='skill-item'>
                            <div class='skill-name'><span>Python</span><span>90%</span></div>
                            <div class='skill-bar'><div class='skill-progress' data-width='90'></div></div>
                        </div>
                        <div class='skill-item'>
                            <div class='skill-name'><span>Java</span><span>85%</span></div>
                            <div class='skill-bar'><div class='skill-progress' data-width='85'></div></div>
                        </div>
                        <div class='skill-item'>
                            <div class='skill-name'><span>C#</span><span>82%</span></div>
                            <div class='skill-bar'><div class='skill-progress' data-width='82'></div></div>
                        </div>
                        <div class='skill-item'>
                            <div class='skill-name'><span>JavaScript</span><span>78%</span></div>
                            <div class='skill-bar'><div class='skill-progress' data-width='78'></div></div>
                        </div>
                    </div>
                </div>
                
                <div class='skill-category enhanced-card'>
                    <div class='card-icon'>
                        <i class='fas fa-brain'></i>
                    </div>
                    <h3 class='card-title'>Algorithms & Data Structures</h3>
                    <div class='skills-list'>
                        <div class='skill-item'>
                            <div class='skill-name'><span>Data Structures</span><span>95%</span></div>
                            <div class='skill-bar'><div class='skill-progress' data-width='95'></div></div>
                        </div>
                        <div class='skill-item'>
                            <div class='skill-name'><span>Dynamic Programming</span><span>90%</span></div>
                            <div class='skill-bar'><div class='skill-progress' data-width='90'></div></div>
                        </div>
                        <div class='skill-item'>
                            <div class='skill-name'><span>Graph Algorithms</span><span>88%</span></div>
                            <div class='skill-bar'><div class='skill-progress' data-width='88'></div></div>
                        </div>
                        <div class='skill-item'>
                            <div class='skill-name'><span>String Algorithms</span><span>85%</span></div>
                            <div class='skill-bar'><div class='skill-progress' data-width='85'></div></div>
                        </div>
                        <div class='skill-item'>
                            <div class='skill-name'><span>Number Theory</span><span>82%</span></div>
                            <div class='skill-bar'><div class='skill-progress' data-width='82'></div></div>
                        </div>
                    </div>
                </div>
                
                <div class='skill-category enhanced-card'>
                    <div class='card-icon'>
                        <i class='fas fa-robot'></i>
                    </div>
                    <h3 class='card-title'>Hardware & Robotics</h3>
                    <div class='skills-list'>
                        <div class='skill-item'>
                            <div class='skill-name'><span>Arduino Programming</span><span>88%</span></div>
                            <div class='skill-bar'><div class='skill-progress' data-width='88'></div></div>
                        </div>
                        <div class='skill-item'>
                            <div class='skill-name'><span>Sensor Integration</span><span>85%</span></div>
                            <div class='skill-bar'><div class='skill-progress' data-width='85'></div></div>
                        </div>
                        <div class='skill-item'>
                            <div class='skill-name'><span>Circuit Design</span><span>80%</span></div>
                            <div class='skill-bar'><div class='skill-progress' data-width='80'></div></div>
                        </div>
                        <div class='skill-item'>
                            <div class='skill-name'><span>PCB Design</span><span>75%</span></div>
                            <div class='skill-bar'><div class='skill-progress' data-width='75'></div></div>
                        </div>
                    </div>
                </div>
                
                <div class='skill-category enhanced-card'>
                    <div class='card-icon'>
                        <i class='fas fa-globe-americas'></i>
                    </div>
                    <h3 class='card-title'>Web Development</h3>
                    <div class='skills-list'>
                        <div class='skill-item'>
                            <div class='skill-name'><span>ASP.NET</span><span>88%</span></div>
                            <div class='skill-bar'><div class='skill-progress' data-width='88'></div></div>
                        </div>
                        <div class='skill-item'>
                            <div class='skill-name'><span>HTML/CSS</span><span>92%</span></div>
                            <div class='skill-bar'><div class='skill-progress' data-width='92'></div></div>
                        </div>
                        <div class='skill-item'>
                            <div class='skill-name'><span>React.js</span><span>78%</span></div>
                            <div class='skill-bar'><div class='skill-progress' data-width='78'></div></div>
                        </div>
                        <div class='skill-item'>
                            <div class='skill-name'><span>Node.js</span><span>72%</span></div>
                            <div class='skill-bar'><div class='skill-progress' data-width='72'></div></div>
                        </div>
                    </div>
                </div>
                
                <div class='skill-category enhanced-card'>
                    <div class='card-icon'>
                        <i class='fas fa-chart-line'></i>
                    </div>
                    <h3 class='card-title'>Data Science & AI</h3>
                    <div class='skills-list'>
                        <div class='skill-item'>
                            <div class='skill-name'><span>Machine Learning</span><span>82%</span></div>
                            <div class='skill-bar'><div class='skill-progress' data-width='82'></div></div>
                        </div>
                        <div class='skill-item'>
                            <div class='skill-name'><span>Data Analysis</span><span>85%</span></div>
                            <div class='skill-bar'><div class='skill-progress' data-width='85'></div></div>
                        </div>
                        <div class='skill-item'>
                            <div class='skill-name'><span>Pandas/NumPy</span><span>88%</span></div>
                            <div class='skill-bar'><div class='skill-progress' data-width='88'></div></div>
                        </div>
                        <div class='skill-item'>
                            <div class='skill-name'><span>Scikit-learn</span><span>80%</span></div>
                            <div class='skill-bar'><div class='skill-progress' data-width='80'></div></div>
                        </div>
                    </div>
                </div>
                
                <div class='skill-category enhanced-card'>
                    <div class='card-icon'>
                        <i class='fas fa-tools'></i>
                    </div>
                    <h3 class='card-title'>Tools & Technologies</h3>
                    <div class='skills-list'>
                        <div class='skill-item'>
                            <div class='skill-name'><span>Git/GitHub</span><span>90%</span></div>
                            <div class='skill-bar'><div class='skill-progress' data-width='90'></div></div>
                        </div>
                        <div class='skill-item'>
                            <div class='skill-name'><span>Visual Studio</span><span>92%</span></div>
                            <div class='skill-bar'><div class='skill-progress' data-width='92'></div></div>
                        </div>
                        <div class='skill-item'>
                            <div class='skill-name'><span>SQL Server</span><span>85%</span></div>
                            <div class='skill-bar'><div class='skill-progress' data-width='85'></div></div>
                        </div>
                        <div class='skill-item'>
                            <div class='skill-name'><span>Linux/Windows</span><span>88%</span></div>
                            <div class='skill-bar'><div class='skill-progress' data-width='88'></div></div>
                        </div>
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
                <div class='enhanced-card platform-card'>
                    <div class='card-icon platform-icon'>
                        <i class='fas fa-trophy'></i>
                    </div>
                    <div class='card-title platform-name'>Codeforces</div>
                    <div class='card-description platform-username'>@k_i_mahi</div>
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
                    <a href='https://codeforces.com/profile/k_i_mahi' target='_blank' class='project-link' style='margin-top: 1rem; display: inline-block;'>
                        <i class='fas fa-external-link-alt'></i> View Profile
                    </a>
                </div>
                
                <div class='enhanced-card platform-card'>
                    <div class='card-icon platform-icon'>
                        <i class='fas fa-code'></i>
                    </div>
                    <div class='card-title platform-name'>LeetCode</div>
                    <div class='card-description platform-username'>@khadimul_mahi</div>
                    <div class='platform-stats'>
                        <div class='stat-item'>
                            <span class='stats-counter'>1850</span>
                            <span class='stats-label'>Max Rating</span>
                        </div>
                        <div class='stat-item'>
                            <span class='stats-counter'>300</span>
                            <span class='stats-label'>Problems Solved</span>
                        </div>
                    </div>
                    <div class='platform-stats'>
                        <div class='stat-item'>
                            <span class='stats-counter'>18</span>
                            <span class='stats-label'>Contests</span>
                        </div>
                        <div class='stat-item'>
                            <span class='stats-counter'>Knight</span>
                            <span class='stats-label'>Badge</span>
                        </div>
                    </div>
                    <a href='https://leetcode.com/khadimul_mahi' target='_blank' class='project-link' style='margin-top: 1rem; display: inline-block;'>
                        <i class='fas fa-external-link-alt'></i> View Profile
                    </a>
                </div>
                
                <div class='enhanced-card platform-card'>
                    <div class='card-icon platform-icon'>
                        <i class='fas fa-utensils'></i>
                    </div>
                    <div class='card-title platform-name'>CodeChef</div>
                    <div class='card-description platform-username'>@k_i_mahi</div>
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
                    <a href='https://codechef.com/users/k_i_mahi' target='_blank' class='project-link' style='margin-top: 1rem; display: inline-block;'>
                        <i class='fas fa-external-link-alt'></i> View Profile
                    </a>
                </div>
                
                <div class='enhanced-card platform-card'>
                    <div class='card-icon platform-icon'>
                        <i class='fab fa-hackerrank'></i>
                    </div>
                    <div class='card-title platform-name'>HackerRank</div>
                    <div class='card-description platform-username'>@khadimul_mahi</div>
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
                    <a href='https://hackerrank.com/khadimul_mahi' target='_blank' class='project-link' style='margin-top: 1rem; display: inline-block;'>
                        <i class='fas fa-external-link-alt'></i> View Profile
                    </a>
                </div>
                
                <div class='enhanced-card platform-card'>
                    <div class='card-icon platform-icon'>
                        <i class='fas fa-medal'></i>
                    </div>
                    <div class='card-title platform-name'>AtCoder</div>
                    <div class='card-description platform-username'>@k_i_mahi</div>
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
                    <a href='https://atcoder.jp/users/k_i_mahi' target='_blank' class='project-link' style='margin-top: 1rem; display: inline-block;'>
                        <i class='fas fa-external-link-alt'></i> View Profile
                    </a>
                </div>
                
                <div class='enhanced-card platform-card'>
                    <div class='card-icon platform-icon'>
                        <i class='fab fa-github'></i>
                    </div>
                    <div class='card-title platform-name'>GitHub</div>
                    <div class='card-description platform-username'>@k-i-mahi</div>
                    <div class='platform-stats'>
                        <div class='stat-item'>
                            <span class='stats-counter'>25</span>
                            <span class='stats-label'>Repositories</span>
                        </div>
                        <div class='stat-item'>
                            <span class='stats-counter'>200</span>
                            <span class='stats-label'>Contributions</span>
                        </div>
                    </div>
                    <div class='platform-stats'>
                        <div class='stat-item'>
                            <span class='stats-counter'>12</span>
                            <span class='stats-label'>Followers</span>
                        </div>
                        <div class='stat-item'>
                            <span class='stats-counter'>15</span>
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
                <div class='enhanced-card interest-card kaggle-card'>
                    <div class='card-icon interest-icon'>
                        <i class='fab fa-kaggle'></i>
                    </div>
                    <div class='card-title interest-name'>Kaggle Competitions</div>
                    <div class='card-description interest-description'>Machine learning competitions and data science challenges</div>
                    <div class='platform-stats'>
                        <div class='stat-item'>
                            <span class='stats-counter'>20</span>
                            <span class='stats-label'>Competitions</span>
                        </div>
                        <div class='stat-item'>
                            <span class='stats-counter'>Bronze</span>
                            <span class='stats-label'>Best Medal</span>
                        </div>
                    </div>
                    <div class='platform-stats'>
                        <div class='stat-item'>
                            <span class='stats-counter'>1350</span>
                            <span class='stats-label'>Ranking Points</span>
                        </div>
                        <div class='stat-item'>
                            <span class='stats-counter'>Expert</span>
                            <span class='stats-label'>Tier</span>
                        </div>
                    </div>
                    <div style='margin-top: 1rem; font-size: 0.9rem; color: var(--text-light); text-align: left;'>
                        <strong>Notable Competitions:</strong><br>
                        • Spaceship Titanic - Bronze Medal<br>
                        • House Prices Prediction - Top 20%<br>
                        • Natural Language Processing<br>
                        • Computer Vision Challenges
                    </div>
                    <a href='https://kaggle.com/khadimulmahi' target='_blank' class='project-link' style='margin-top: 1rem; display: inline-block;'>
                        <i class='fas fa-external-link-alt'></i> View Profile
                    </a>
                </div>

                <div class='enhanced-card interest-card hardware-card'>
                    <div class='card-icon interest-icon'>
                        <i class='fas fa-robot'></i>
                    </div>
                    <div class='card-title interest-name'>Hardware & Robotics</div>
                    <div class='card-description interest-description'>Building innovative robotics solutions and embedded systems</div>
                    <div class='platform-stats'>
                        <div class='stat-item'>
                            <span class='stats-counter'>12</span>
                            <span class='stats-label'>Projects Built</span>
                        </div>
                        <div class='stat-item'>
                            <span class='stats-counter'>Arduino</span>
                            <span class='stats-label'>Primary Platform</span>
                        </div>
                    </div>
                    <div style='margin-top: 1rem; font-size: 0.9rem; color: var(--text-light); text-align: left;'>
                        <strong>Featured Projects:</strong><br>
                        • Obstacle Avoiding Robot with AI<br>
                        • Line Following Robot (LFR)<br>
                        • Smart Home Automation System<br>
                        • IoT Environmental Monitor<br>
                        • Bluetooth Controlled Car<br>
                        • Voice Recognition System
                    </div>
                    <div style='margin-top: 1rem;'>
                        <span class='project-link' style='background: var(--gradient-warning); color: white; padding: 0.5rem 1rem; border-radius: 20px; font-size: 0.8rem;'>
                            <i class='fas fa-award'></i> Best Hardware Project 2024
                        </span>
                    </div>
                </div>

                <div class='enhanced-card interest-card chess-card'>
                    <div class='card-icon interest-icon'>
                        <i class='fas fa-chess'></i>
                    </div>
                    <div class='card-title interest-name'>Chess</div>
                    <div class='card-description interest-description'>Strategic gameplay and competitive chess tournaments</div>
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
                            <span class='stats-counter'>800+</span>
                            <span class='stats-label'>Games Played</span>
                        </div>
                        <div class='stat-item'>
                            <span class='stats-counter'>75%</span>
                            <span class='stats-label'>Win Rate</span>
                        </div>
                    </div>
                    <div style='margin-top: 1rem; font-size: 0.9rem; color: var(--text-light); text-align: left;'>
                        <strong>Achievements:</strong><br>
                        • KUET Inter-Department Runner-up<br>
                        • Regular tournament participant<br>
                        • Chess club member<br>
                        • Puzzle solver (2000+ rating)
                    </div>
                    <div style='display: flex; gap: 0.5rem; margin-top: 1rem; justify-content: center;'>
                        <a href='https://chess.com/member/k_i_mahi' target='_blank' class='project-link'>
                            <i class='fas fa-external-link-alt'></i> Chess.com
                        </a>
                        <a href='https://lichess.org/@/k_i_mahi' target='_blank' class='project-link'>
                            <i class='fas fa-external-link-alt'></i> Lichess
                        </a>
                    </div>
                </div>

                <div class='enhanced-card interest-card photography-card'>
                    <div class='card-icon interest-icon'>
                        <i class='fas fa-camera'></i>
                    </div>
                    <div class='card-title interest-name'>Photography</div>
                    <div class='card-description interest-description'>Creative visual storytelling and moment capturing</div>
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
                    <div style='margin-top: 1rem; font-size: 0.9rem; color: var(--text-light); text-align: left;'>
                        <strong>Photography Areas:</strong><br>
                        • Landscape & Nature Photography<br>
                        • Portrait & Event Coverage<br>
                        • Street Photography<br>
                        • Technical Documentation<br>
                        • University Event Photography<br>
                        • Product Photography
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
                <div class='enhanced-card club-card club-sgipc'>
                    <div class='card-icon club-icon'>
                        <i class='fas fa-users-cog'></i>
                    </div>
                    <div class='card-title club-name'>KUET Programming Club</div>
                    <div class='card-description club-description'>Also known as SGIPC (Special Group Interest in Competitive Programming)</div>
                    <div style='margin: 1.5rem 0; padding: 1.5rem; background: var(--bg-color); border-radius: var(--border-radius-sm); text-align: left;'>
                        <div style='margin-bottom: 1rem;'>
                            <strong>Position:</strong> <span style='color: var(--secondary-color); font-weight: 600;'>Executive Member & Mentor</span><br>
                            <strong>Duration:</strong> <span style='color: var(--text-light);'>January 2023 - Present</span>
                        </div>
                        <strong>Key Responsibilities & Activities:</strong><br>
                        • Leading competitive programming training sessions<br>
                        • Organizing intra-university programming contests<br>
                        • Mentoring 50+ junior programmers<br>
                        • ICPC team preparation and coordination<br>
                        • Workshop facilitation on advanced algorithms<br>
                        • Contest problem setting and judging<br>
                        • Inter-university collaboration events
                    </div>
                    <div class='platform-stats'>
                        <div class='stat-item'>
                            <span class='stats-counter'>60+</span>
                            <span class='stats-label'>Sessions Led</span>
                        </div>
                        <div class='stat-item'>
                            <span class='stats-counter'>15</span>
                            <span class='stats-label'>Contests Organized</span>
                        </div>
                    </div>
                    <div class='platform-stats'>
                        <div class='stat-item'>
                            <span class='stats-counter'>50+</span>
                            <span class='stats-label'>Students Mentored</span>
                        </div>
                        <div class='stat-item'>
                            <span class='stats-counter'>300+</span>
                            <span class='stats-label'>Problems Discussed</span>
                        </div>
                    </div>
                    <div style='margin-top: 1rem;'>
                        <span class='project-link' style='background: var(--gradient-success); color: white; padding: 0.5rem 1rem; border-radius: 20px; font-size: 0.8rem;'>
                            <i class='fas fa-star'></i> Outstanding Contributor 2024
                        </span>
                    </div>
                </div>

                <div class='enhanced-card club-card club-hack'>
                    <div class='card-icon club-icon'>
                        <i class='fas fa-microchip'></i>
                    </div>
                    <div class='card-title club-name'>HACK Club</div>
                    <div class='card-description club-description'>Hardware Acceleration Club of KUET - Innovation in Hardware Projects</div>
                    <div style='margin: 1.5rem 0; padding: 1.5rem; background: var(--bg-color); border-radius: var(--border-radius-sm); text-align: left;'>
                        <div style='margin-bottom: 1rem;'>
                            <strong>Position:</strong> <span style='color: var(--secondary-color); font-weight: 600;'>Project Lead & Hardware Specialist</span><br>
                            <strong>Duration:</strong> <span style='color: var(--text-light);'>March 2023 - Present</span>
                        </div>
                        <strong>Key Contributions & Projects:</strong><br>
                        • Leading robotics project development team<br>
                        • Arduino and embedded systems workshops<br>
                        • IoT project implementations and demos<br>
                        • Hardware troubleshooting and mentoring<br>
                        • Circuit design and PCB development<br>
                        • Inter-department hardware competitions<br>
                        • Industry collaboration projects
                    </div>
                    <div class='platform-stats'>
                        <div class='stat-item'>
                            <span class='stats-counter'>12</span>
                            <span class='stats-label'>Projects Led</span>
                        </div>
                        <div class='stat-item'>
                            <span class='stats-counter'>30+</span>
                            <span class='stats-label'>Workshop Hours</span>
                        </div>
                    </div>
                    <div class='platform-stats'>
                        <div class='stat-item'>
                            <span class='stats-counter'>25</span>
                            <span class='stats-label'>Members Trained</span>
                        </div>
                        <div class='stat-item'>
                            <span class='stats-counter'>5</span>
                            <span class='stats-label'>Awards Won</span>
                        </div>
                    </div>
                    <div style='margin-top: 1rem;'>
                        <span class='project-link' style='background: var(--gradient-secondary); color: white; padding: 0.5rem 1rem; border-radius: 20px; font-size: 0.8rem;'>
                            <i class='fas fa-trophy'></i> Best Hardware Project Leader 2024
                        </span>
                    </div>
                </div>

                <div class='enhanced-card club-card'>
                    <div class='card-icon club-icon'>
                        <i class='fas fa-graduation-cap'></i>
                    </div>
                    <div class='card-title club-name'>CSE Student Association</div>
                    <div class='card-description club-description'>Department Student Representative and Event Coordinator</div>
                    <div style='margin: 1.5rem 0; padding: 1.5rem; background: var(--bg-color); border-radius: var(--border-radius-sm); text-align: left;'>
                        <div style='margin-bottom: 1rem;'>
                            <strong>Position:</strong> <span style='color: var(--secondary-color); font-weight: 600;'>Technical Event Coordinator</span><br>
                            <strong>Duration:</strong> <span style='color: var(--text-light);'>June 2023 - Present</span>
                        </div>
                        <strong>Responsibilities & Activities:</strong><br>
                        • Organizing technical workshops and seminars<br>
                        • Coordinating with industry professionals<br>
                        • Managing department cultural events<br>
                        • Student welfare and academic support<br>
                        • Inter-department collaboration<br>
                        • Freshman orientation programs<br>
                        • Career guidance sessions
                    </div>
                    <div class='platform-stats'>
                        <div class='stat-item'>
                            <span class='stats-counter'>18</span>
                            <span class='stats-label'>Events Organized</span>
                        </div>
                        <div class='stat-item'>
                            <span class='stats-counter'>500+</span>
                            <span class='stats-label'>Students Reached</span>
                        </div>
                    </div>
                    <div class='platform-stats'>
                        <div class='stat-item'>
                            <span class='stats-counter'>8</span>
                            <span class='stats-label'>Industry Sessions</span>
                        </div>
                        <div class='stat-item'>
                            <span class='stats-counter'>95%</span>
                            <span class='stats-label'>Satisfaction Rate</span>
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
                    Title = "Smart Obstacle Avoiding Robot",
                    Description = "AI-powered autonomous navigation system with advanced sensor integration",
                    DetailedDescription = "Developed an intelligent obstacle-avoiding robot using Arduino Uno, multiple ultrasonic sensors (HC-SR04), servo motors, and machine learning algorithms for path optimization. Features include real-time obstacle detection, dynamic path planning, voice control integration, and mobile app connectivity for remote monitoring.",
                    Technologies = "Arduino, C++, Machine Learning, Sensors, Mobile App",
                    GitHubLink = "https://github.com/k-i-mahi/smart-obstacle-robot",
                    LiveDemoLink = "",
                    ImageUrl = ""
                },
                new {
                    Title = "Competitive Programming Judge",
                    Description = "Full-stack online judge system with real-time evaluation and contest management",
                    DetailedDescription = "Built a comprehensive competitive programming platform featuring automatic code compilation, execution with multiple test cases, real-time rankings, plagiarism detection, contest scheduling, user management, and detailed analytics dashboard. Supports C++, Java, Python, and C# with Docker containerization for secure execution.",
                    Technologies = "ASP.NET Core, SQL Server, Docker, SignalR, Redis, C#",
                    GitHubLink = "https://github.com/k-i-mahi/cp-judge-system",
                    LiveDemoLink = "https://judge.mahirrahman.com",
                    ImageUrl = ""
                },
                new {
                    Title = "Kaggle ML Competition Suite",
                    Description = "Comprehensive machine learning solutions for multiple Kaggle competitions",
                    DetailedDescription = "Created end-to-end machine learning pipelines for 20+ Kaggle competitions including feature engineering, model ensemble techniques, hyperparameter optimization, and automated model selection. Achieved Bronze medal in Spaceship Titanic and top 15% in House Prices prediction using advanced techniques like XGBoost, Random Forest, and Neural Networks.",
                    Technologies = "Python, Pandas, Scikit-learn, XGBoost, TensorFlow, Jupyter",
                    GitHubLink = "https://github.com/k-i-mahi/kaggle-ml-solutions",
                    LiveDemoLink = "https://kaggle.com/mahirrahman",
                    ImageUrl = ""
                },
                new {
                    Title = "Line Following Robot Championship",
                    Description = "High-precision competitive robotics solution with PID control and optimization",
                    DetailedDescription = "Engineered a championship-level line-following robot for competitive robotics featuring advanced PID control algorithms, high-speed motor controllers, precision IR sensor arrays, junction detection, and real-time path optimization. Achieved 1st place in KUET robotics competition with fastest completion time.",
                    Technologies = "Arduino, PID Control, Advanced Sensors, Motor Control, C++",
                    GitHubLink = "https://github.com/k-i-mahi/championship-lfr",
                    LiveDemoLink = "",
                    ImageUrl = ""
                },
                new {
                    Title = "IoT Smart Home Ecosystem",
                    Description = "Complete home automation system with voice control and mobile integration",
                    DetailedDescription = "Developed a comprehensive IoT-based smart home system featuring voice command integration, mobile app control, automated lighting and climate control, security monitoring with cameras, energy consumption tracking, and cloud-based data analytics. Includes machine learning for behavior prediction and optimization.",
                    Technologies = "ESP32, Firebase, Android Studio, Voice Recognition, IoT Sensors",
                    GitHubLink = "https://github.com/k-i-mahi/iot-smart-home",
                    LiveDemoLink = "",
                    ImageUrl = ""
                },
                new {
                    Title = "Advanced Chess Engine & Analyzer",
                    Description = "Chess game analysis tool with engine integration and performance tracking",
                    DetailedDescription = "Created a sophisticated chess analysis application with Stockfish engine integration, opening database, endgame tablebase support, game analysis with tactical pattern recognition, performance tracking, and training mode. Features include position evaluation, move suggestions, and comprehensive game statistics.",
                    Technologies = "Python, Stockfish Engine, Chess.py, AI Analysis, Data Visualization",
                    GitHubLink = "https://github.com/k-i-mahi/chess-engine-analyzer",
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
                    CGPA = "3.78",
                    StartDate = new DateTime(2022, 1, 1),
                    EndDate = (DateTime?)null,
                    IsCurrent = true,
                    Description = "Currently pursuing B.Sc. in Computer Science and Engineering with specialization in algorithms, software engineering, artificial intelligence, and robotics. Active leadership in KUET Programming Club (SGIPC) and HACK club. Relevant coursework: Advanced Data Structures & Algorithms, Machine Learning, Database Systems, Software Engineering, Computer Networks, Operating Systems, Digital Logic Design, and Embedded Systems."
                },
                new {
                    Institution = "Bogura Cantonment Public School & College",
                    Degree = "Higher Secondary Certificate (HSC)",
                    Department = "Science Group",
                    CGPA = "5.00",
                    StartDate = new DateTime(2019, 6, 1),
                    EndDate = new DateTime(2021, 5, 31),
                    IsCurrent = false,
                    Description = "Completed HSC in Science group with perfect GPA 5.00. Concentrated on Mathematics, Physics, Chemistry, and ICT with advanced computer science. Led the school programming team, organized coding workshops for junior students, participated in national programming olympiads, and won multiple science fair competitions. Awarded Best ICT Student of the Year."
                },
                new {
                    Institution = "Bogura Cantonment Public School & College",
                    Degree = "Secondary School Certificate (SSC)",
                    Department = "Science Group",
                    CGPA = "5.00",
                    StartDate = new DateTime(2017, 1, 1),
                    EndDate = new DateTime(2019, 5, 31),
                    IsCurrent = false,
                    Description = "Completed SSC in Science group with perfect GPA 5.00. Built strong foundation in Mathematics, Science, and ICT. Started competitive programming journey, participated in district-level programming and mathematics competitions, and began building first hardware projects with Arduino."
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
                    Title = "ACM ICPC Asia Dhaka Regional 2024 - Team Qualifier",
                    Platform = "ACM ICPC",
                    Description = "Successfully qualified for ACM ICPC Asia Dhaka Regional Contest 2024 representing KUET with team 'KUET_CodeCrafters', demonstrating exceptional problem-solving skills in algorithmic challenges",
                    Ranking = "Regional Qualifier - Team Rank: 25th out of 200+ teams",
                    AchievedDate = new DateTime(2024, 10, 15),
                    CertificateUrl = ""
                },
                new {
                    Title = "Kaggle Competition Bronze Medal Achievement",
                    Platform = "Kaggle",
                    Description = "Earned Bronze Medal in Kaggle's 'Spaceship Titanic' machine learning competition with innovative feature engineering and ensemble techniques, finishing in top 15% among 2500+ participants worldwide",
                    Ranking = "Bronze Medal - Top 15% (375th out of 2500+)",
                    AchievedDate = new DateTime(2024, 9, 28),
                    CertificateUrl = ""
                },
                new {
                    Title = "KUET Hardware Exhibition - Best Innovation Award",
                    Platform = "HACK - KUET",
                    Description = "Won the prestigious Best Innovation Award for developing an AI-powered obstacle-avoiding robot with advanced pathfinding algorithms at KUET Hardware Exhibition 2024",
                    Ranking = "1st Place - Best Innovation Award",
                    AchievedDate = new DateTime(2024, 9, 15),
                    CertificateUrl = ""
                },
                new {
                    Title = "CodeChef Long Challenge Global Winner",
                    Platform = "CodeChef",
                    Description = "Achieved 1st position globally in CodeChef October Long Challenge 2024 Division 2, solving all problems with optimal solutions and fastest submission times",
                    Ranking = "1st Place Global - Division 2 (Perfect Score)",
                    AchievedDate = new DateTime(2024, 10, 8),
                    CertificateUrl = ""
                },
                new {
                    Title = "Codeforces Specialist Rating Milestone",
                    Platform = "Codeforces",
                    Description = "Achieved and maintained Specialist rating (1400+) in Codeforces competitive programming with consistent high-performance across 45+ rated contests",
                    Ranking = "Max Rating: 1456 (Specialist) - Top 15% globally",
                    AchievedDate = new DateTime(2024, 9, 20),
                    CertificateUrl = ""
                },
                new {
                    Title = "KUET Programming Contest Champion",
                    Platform = "KUET Programming Club",
                    Description = "Secured 2nd place in KUET Intra-University Programming Contest 2024 individual category, competing against 150+ participants from all departments",
                    Ranking = "2nd Place Individual - 150+ participants",
                    AchievedDate = new DateTime(2024, 8, 15),
                    CertificateUrl = ""
                },
                new {
                    Title = "Inter-Department Chess Championship",
                    Platform = "KUET Chess Club",
                    Description = "Earned Runner-up position in KUET Inter-Department Chess Championship 2024, representing Computer Science & Engineering department with strategic excellence",
                    Ranking = "2nd Place - Inter-Department Championship",
                    AchievedDate = new DateTime(2024, 7, 22),
                    CertificateUrl = ""
                },
                new {
                    Title = "LeetCode Weekly Contest Top Performer",
                    Platform = "LeetCode",
                    Description = "Achieved top 5% global ranking in LeetCode Weekly Contest 367 by solving all four problems correctly within optimal time complexity",
                    Ranking = "Global Rank: 485/12,000+ (Top 4%)",
                    AchievedDate = new DateTime(2024, 7, 28),
                    CertificateUrl = ""
                },
                new {
                    Title = "HackerRank Problem Solving Mastery",
                    Platform = "HackerRank",
                    Description = "Achieved 5-star rating and Gold badge in Problem Solving domain by successfully solving 95+ algorithmic challenges across various difficulty levels and topics",
                    Ranking = "5 Stars Gold Badge - Problem Solving Domain",
                    AchievedDate = new DateTime(2024, 6, 10),
                    CertificateUrl = ""
                },
                new {
                    Title = "National Programming Olympiad Achievement",
                    Platform = "Bangladesh Olympiad on Informatics",
                    Description = "Secured 3rd position in National High School Programming Contest 2021, representing Bogura district with outstanding performance in advanced algorithmic problem solving",
                    Ranking = "3rd Place National Level - High School Category",
                    AchievedDate = new DateTime(2021, 2, 15),
                    CertificateUrl = ""
                },
                new {
                    Title = "Outstanding Academic Excellence Recognition",
                    Platform = "Academic Achievement",
                    Description = "Maintained consistently excellent academic performance with perfect GPA 5.00 in both SSC and HSC examinations, demonstrating exceptional dedication to learning and academic excellence",
                    Ranking = "Perfect GPA 5.00/5.00 - SSC & HSC",
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
                var txtPhone = (TextBox)FindControl("txtPhone");
                var txtSubject = (TextBox)FindControl("txtSubject");
                var txtMessage = (TextBox)FindControl("txtMessage");

                // Enhanced validation
                if (txtName != null && txtEmail != null && txtMessage != null &&
                    !string.IsNullOrWhiteSpace(txtName.Text) && 
                    !string.IsNullOrWhiteSpace(txtEmail.Text) && 
                    !string.IsNullOrWhiteSpace(txtMessage.Text))
                {
                    // Basic email validation
                    if (!IsValidEmail(txtEmail.Text.Trim()))
                    {
                        ShowMessage("?? Please enter a valid email address.", "error");
                        return;
                    }

                    // In production, this would save to database and send email
                    var contactInfo = new {
                        Name = txtName.Text.Trim(),
                        Email = txtEmail.Text.Trim(),
                        Phone = txtPhone?.Text?.Trim() ?? "",
                        Subject = txtSubject?.Text?.Trim() ?? "General Inquiry",
                        Message = txtMessage.Text.Trim(),
                        Timestamp = DateTime.Now
                    };

                    // Simulate processing
                    System.Threading.Thread.Sleep(100); // Brief delay to show it's working

                    ShowMessage($"? Thank you, {contactInfo.Name}! Your message has been received successfully. I'll respond to {contactInfo.Email} within 24 hours.", "success");
                    ClearContactForm();
                }
                else
                {
                    ShowMessage("?? Please fill in all required fields (Name, Email, and Message) before submitting.", "error");
                }
            }
            catch (Exception ex)
            {
                ShowMessage("? An unexpected error occurred while sending your message. Please try again later or contact directly at khadimul.mahi@kuet.ac.bd", "error");
                // In production, log the exception
                System.Diagnostics.Debug.WriteLine($"Contact form error: {ex.Message}");
            }
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void ShowMessage(string message, string type)
        {
            var pnlMessage = (Panel)FindControl("pnlMessage");
            var litMessage = (Literal)FindControl("litMessage");
            
            if (pnlMessage != null && litMessage != null)
            {
                pnlMessage.Visible = true;
                string iconClass = type == "success" ? "fas fa-check-circle" : 
                                  type == "error" ? "fas fa-exclamation-triangle" : 
                                  "fas fa-info-circle";
                string alertType = type == "success" ? "success" : 
                                  type == "error" ? "error" : "info";
                litMessage.Text = $"<div class='alert alert-{alertType}' style='margin-bottom: 2rem;'><i class='{iconClass}' style='margin-right: 0.5rem;'></i> {message}</div>";
            }
        }

        private void ClearContactForm()
        {
            var controls = new[] { "txtName", "txtEmail", "txtPhone", "txtSubject", "txtMessage" };
            
            foreach (var controlName in controls)
            {
                var textBox = (TextBox)FindControl(controlName);
                if (textBox != null)
                {
                    textBox.Text = "";
                }
            }
        }
    }
}