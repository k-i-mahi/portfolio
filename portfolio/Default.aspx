<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Portfolio.Default" %>

<!DOCTYPE html>
<html lang="en">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>Your Name - Competitive Programmer & Software Developer</title>
    <link href="Styles/portfolio.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.0.0/css/all.min.css" />
</head>
<body>
    <form id="form1" runat="server">
        <!-- Header -->
        <header class="header">
            <div class="container">
                <nav class="nav">
                    <div class="logo">Your Portfolio</div>
                    <ul class="nav-links">
                        <li><a href="#home">Home</a></li>
                        <li><a href="#about">About</a></li>
                        <li><a href="#skills">Skills</a></li>
                        <li><a href="#projects">Projects</a></li>
                        <li><a href="#education">Education</a></li>
                        <li><a href="#achievements">Achievements</a></li>
                        <li><a href="#contact">Contact</a></li>
                    </ul>
                </nav>
            </div>
        </header>

        <!-- Hero Section -->
        <section id="home" class="hero">
            <div class="container">
                <h1>Your Name</h1>
                <h2>Competitive Programmer & Software Developer</h2>
                <p>CSE 3rd Year Student at KUET | Passionate about Problem Solving & Software Development</p>
                <a href="#contact" class="cta-button">Get In Touch</a>
            </div>
        </section>

        <!-- About Section -->
        <section id="about" class="section">
            <div class="container">
                <h2 class="section-title">About Me</h2>
                <div class="about-content">
                    <div>
                        <img src="Images/profile.jpg" alt="Profile Picture" class="profile-img" onerror="this.src='https://via.placeholder.com/300x300?text=Your+Photo'" />
                    </div>
                    <div class="about-text">
                        <p>
                            I am a passionate Computer Science and Engineering student at Khulna University of Engineering & Technology (KUET), 
                            currently in my 3rd year. My journey in competitive programming has shaped my problem-solving skills and algorithmic thinking.
                        </p>
                        <p>
                            I specialize in developing efficient solutions to complex problems and have experience in various programming languages 
                            and technologies. My goal is to leverage technology to create innovative solutions that make a positive impact.
                        </p>
                        <p>
                            When I'm not coding, I enjoy participating in programming contests, contributing to open-source projects, 
                            and continuously learning about emerging technologies in software development.
                        </p>
                        <div class="social-links">
                            <a href="#" target="_blank" title="LinkedIn"><i class="fab fa-linkedin-in"></i></a>
                            <a href="#" target="_blank" title="GitHub"><i class="fab fa-github"></i></a>
                            <a href="#" target="_blank" title="CodeChef"><i class="fas fa-code"></i></a>
                            <a href="#" target="_blank" title="Codeforces"><i class="fas fa-trophy"></i></a>
                            <a href="mailto:your-email@example.com" title="Email"><i class="fas fa-envelope"></i></a>
                        </div>
                    </div>
                </div>
            </div>
        </section>

        <!-- Skills Section -->
        <section id="skills" class="section">
            <div class="container">
                <h2 class="section-title">Technical Skills</h2>
                <div class="skills-grid">
                    <asp:Repeater ID="rptSkills" runat="server">
                        <HeaderTemplate>
                            <div class="skill-category">
                                <h3><%# Container.DataItem %></h3>
                        </HeaderTemplate>
                        <ItemTemplate>
                                <div class="skill-item">
                                    <div class="skill-name">
                                        <span><%# Eval("Name") %></span>
                                        <span><%# Eval("ProficiencyLevel") %>%</span>
                                    </div>
                                    <div class="skill-bar">
                                        <div class="skill-progress" data-width="<%# Eval("ProficiencyLevel") %>"></div>
                                    </div>
                                </div>
                        </ItemTemplate>
                        <FooterTemplate>
                            </div>
                        </FooterTemplate>
                    </asp:Repeater>
                </div>
            </div>
        </section>

        <!-- Projects Section -->
        <section id="projects" class="section">
            <div class="container">
                <h2 class="section-title">Featured Projects</h2>
                <div class="projects-grid">
                    <asp:Repeater ID="rptProjects" runat="server">
                        <ItemTemplate>
                            <div class="project-card">
                                <div class="project-img">
                                    <%# !string.IsNullOrEmpty(Eval("ImageUrl").ToString()) ? 
                                        $"<img src='{Eval("ImageUrl")}' alt='{Eval("Title")}' style='width:100%; height:100%; object-fit:cover;' />" : 
                                        $"<i class='fas fa-laptop-code fa-3x'></i>" %>
                                </div>
                                <div class="project-content">
                                    <h3 class="project-title"><%# Eval("Title") %></h3>
                                    <p><%# Eval("Description") %></p>
                                    <div class="project-tech">
                                        <strong>Technologies:</strong> <%# Eval("Technologies") %>
                                    </div>
                                    <div class="project-links">
                                        <%# !string.IsNullOrEmpty(Eval("GitHubLink").ToString()) ? 
                                            $"<a href='{Eval("GitHubLink")}' class='project-link' target='_blank'><i class='fab fa-github'></i> GitHub</a>" : "" %>
                                        <%# !string.IsNullOrEmpty(Eval("LiveDemoLink").ToString()) ? 
                                            $"<a href='{Eval("LiveDemoLink")}' class='project-link' target='_blank'><i class='fas fa-external-link-alt'></i> Live Demo</a>" : "" %>
                                    </div>
                                </div>
                            </div>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
            </div>
        </section>

        <!-- Education Section -->
        <section id="education" class="section">
            <div class="container">
                <h2 class="section-title">Education</h2>
                <div class="education-timeline">
                    <asp:Repeater ID="rptEducation" runat="server">
                        <ItemTemplate>
                            <div class="education-item">
                                <div class="education-header">
                                    <div>
                                        <h3><%# Eval("Degree") %></h3>
                                        <h4><%# Eval("Institution") %></h4>
                                        <%# !string.IsNullOrEmpty(Eval("Department").ToString()) ? $"<p><strong>Department:</strong> {Eval("Department")}</p>" : "" %>
                                        <%# !string.IsNullOrEmpty(Eval("CGPA").ToString()) ? $"<p><strong>CGPA:</strong> {Eval("CGPA")}</p>" : "" %>
                                    </div>
                                    <div class="education-date">
                                        <%# Eval("StartDate", "{0:yyyy}") %> - <%# Eval("IsCurrent").ToString() == "True" ? "Present" : Eval("EndDate", "{0:yyyy}") %>
                                    </div>
                                </div>
                                <%# !string.IsNullOrEmpty(Eval("Description").ToString()) ? $"<p>{Eval("Description")}</p>" : "" %>
                            </div>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
            </div>
        </section>

        <!-- Achievements Section -->
        <section id="achievements" class="section">
            <div class="container">
                <h2 class="section-title">Competitive Programming Achievements</h2>
                <div class="achievements-grid">
                    <asp:Repeater ID="rptAchievements" runat="server">
                        <ItemTemplate>
                            <div class="achievement-card">
                                <div class="achievement-platform"><%# Eval("Platform") %></div>
                                <h3 class="achievement-title"><%# Eval("Title") %></h3>
                                <p><%# Eval("Description") %></p>
                                <%# !string.IsNullOrEmpty(Eval("Ranking").ToString()) ? $"<div class='achievement-ranking'>{Eval("Ranking")}</div>" : "" %>
                                <small><%# Eval("AchievedDate", "{0:MMMM yyyy}") %></small>
                                <%# !string.IsNullOrEmpty(Eval("CertificateUrl").ToString()) ? 
                                    $"<br><a href='{Eval("CertificateUrl")}' target='_blank' class='project-link' style='margin-top: 1rem; display: inline-block;'>View Certificate</a>" : "" %>
                            </div>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
            </div>
        </section>

        <!-- Contact Section -->
        <section id="contact" class="section">
            <div class="container">
                <h2 class="section-title">Get In Touch</h2>
                <div class="contact-content">
                    <asp:Panel ID="pnlMessage" runat="server" Visible="false">
                        <asp:Literal ID="litMessage" runat="server"></asp:Literal>
                    </asp:Panel>
                    
                    <div class="contact-form">
                        <div class="form-group">
                            <label for="txtName">Full Name *</label>
                            <asp:TextBox ID="txtName" runat="server" CssClass="form-control" Required="true"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label for="txtEmail">Email Address *</label>
                            <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" TextMode="Email" Required="true"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label for="txtPhone">Phone Number</label>
                            <asp:TextBox ID="txtPhone" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label for="txtSubject">Subject</label>
                            <asp:TextBox ID="txtSubject" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label for="txtMessage">Message *</label>
                            <asp:TextBox ID="txtMessage" runat="server" CssClass="form-control" TextMode="MultiLine" Rows="5" Required="true"></asp:TextBox>
                        </div>
                        <asp:Button ID="btnSubmit" runat="server" Text="Send Message" CssClass="btn-submit" OnClick="btnSubmit_Click" />
                    </div>
                </div>
            </div>
        </section>

        <!-- Footer -->
        <footer class="footer">
            <div class="container">
                <p>&copy; <%= DateTime.Now.Year %> Your Name. All rights reserved. | Built with ASP.NET & ??</p>
            </div>
        </footer>
    </form>

    <script>
        // Animate skill bars when in view
        document.addEventListener('DOMContentLoaded', function() {
            const skillBars = document.querySelectorAll('.skill-progress');
            
            const animateSkills = () => {
                skillBars.forEach(bar => {
                    const rect = bar.getBoundingClientRect();
                    if (rect.top < window.innerHeight && rect.bottom > 0) {
                        const width = bar.getAttribute('data-width');
                        bar.style.width = width + '%';
                        bar.classList.add('animate');
                    }
                });
            };

            // Initial check
            animateSkills();
            
            // Check on scroll
            window.addEventListener('scroll', animateSkills);
            
            // Smooth scrolling for navigation links
            document.querySelectorAll('a[href^="#"]').forEach(anchor => {
                anchor.addEventListener('click', function (e) {
                    e.preventDefault();
                    const target = document.querySelector(this.getAttribute('href'));
                    if (target) {
                        target.scrollIntoView({
                            behavior: 'smooth',
                            block: 'start'
                        });
                    }
                });
            });
        });
    </script>
</body>
</html>