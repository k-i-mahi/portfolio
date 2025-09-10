<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DefaultSimple.aspx.cs" Inherits="Portfolio.DefaultSimple" %>

<!DOCTYPE html>
<html lang="en">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <meta name="description" content="Professional portfolio of Mahir Rahman - competitive programmer and software developer from KUET" />
    <meta name="keywords" content="competitive programming, software developer, KUET, portfolio, web development, Codeforces, LeetCode, CodeChef" />
    <title>Mahir Rahman - Competitive Programmer & Software Developer | KUET CSE</title>
    <link href="Styles/portfolio.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.4.0/css/all.min.css" />
    <link rel="preconnect" href="https://fonts.googleapis.com">
    <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
    <link href="https://fonts.googleapis.com/css2?family=Inter:wght@300;400;500;600;700&display=swap" rel="stylesheet">
    
    <!-- Additional CSS for enhanced animations -->
    <style>
        /* Enhanced animations and styles */
        .stats-counter {
            font-size: 2.5rem;
            font-weight: 700;
            color: var(--secondary-color);
            display: block;
        }
        
        .stats-label {
            font-size: 0.9rem;
            color: var(--text-light);
            text-transform: uppercase;
            letter-spacing: 1px;
        }
        
        .programming-stats {
            display: grid;
            grid-template-columns: repeat(auto-fit, minmax(250px, 1fr));
            gap: 2rem;
            margin: 3rem 0;
        }
        
        .platform-card {
            background: var(--white);
            padding: 2rem;
            border-radius: var(--border-radius);
            box-shadow: var(--shadow);
            text-align: center;
            transition: var(--transition);
            position: relative;
            overflow: hidden;
        }
        
        .platform-card::before {
            content: '';
            position: absolute;
            top: 0;
            left: 0;
            right: 0;
            height: 4px;
            background: var(--gradient-primary);
        }
        
        .platform-card:hover {
            transform: translateY(-8px);
            box-shadow: var(--shadow-hover);
        }
        
        .platform-icon {
            font-size: 3rem;
            margin-bottom: 1rem;
            background: var(--gradient-primary);
            -webkit-background-clip: text;
            -webkit-text-fill-color: transparent;
            background-clip: text;
        }
        
        .platform-name {
            font-size: 1.3rem;
            font-weight: 600;
            margin-bottom: 0.5rem;
            color: var(--primary-color);
        }
        
        .platform-username {
            color: var(--text-light);
            margin-bottom: 1rem;
            font-style: italic;
        }
        
        .platform-stats {
            display: grid;
            grid-template-columns: 1fr 1fr;
            gap: 1rem;
            margin-top: 1rem;
        }
        
        .stat-item {
            padding: 1rem;
            background: var(--bg-color);
            border-radius: 8px;
        }
        
        .typing-cursor::after {
            content: '|';
            animation: blink 1s infinite;
        }
        
        @keyframes blink {
            0%, 50% { opacity: 1; }
            51%, 100% { opacity: 0; }
        }
        
        .floating-elements {
            position: absolute;
            top: 0;
            left: 0;
            width: 100%;
            height: 100%;
            overflow: hidden;
            pointer-events: none;
        }
        
        .floating-element {
            position: absolute;
            opacity: 0.1;
            animation: float 20s infinite linear;
        }
        
        @keyframes float {
            0% { transform: translateY(100vh) rotate(0deg); }
            100% { transform: translateY(-100px) rotate(360deg); }
        }
        
        .hero-particles {
            position: absolute;
            width: 100%;
            height: 100%;
            overflow: hidden;
        }
        
        .particle {
            position: absolute;
            width: 4px;
            height: 4px;
            background: rgba(255,255,255,0.5);
            border-radius: 50%;
            animation: particle-float 15s infinite linear;
        }
        
        @keyframes particle-float {
            0% { 
                transform: translateY(100vh) translateX(0px);
                opacity: 0;
            }
            10% { opacity: 1; }
            90% { opacity: 1; }
            100% { 
                transform: translateY(-100px) translateX(50px);
                opacity: 0;
            }
        }
        
        .progress-ring {
            transform: rotate(-90deg);
        }
        
        .progress-ring-circle {
            transition: stroke-dashoffset 0.5s ease-in-out;
        }
        
        /* Enhanced responsive design */
        @media (max-width: 768px) {
            .programming-stats {
                grid-template-columns: 1fr;
            }
            
            .platform-stats {
                grid-template-columns: 1fr;
            }
            
            .stats-counter {
                font-size: 2rem;
            }
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <!-- Header -->
        <header class="header" id="header">
            <div class="container">
                <nav class="nav">
                    <div class="logo">
                        <i class="fas fa-code"></i>
                        Mahir Rahman
                    </div>
                    <ul class="nav-links" id="navLinks">
                        <li><a href="#home">Home</a></li>
                        <li><a href="#about">About</a></li>
                        <li><a href="#skills">Skills</a></li>
                        <li><a href="#competitive">Competitive Programming</a></li>
                        <li><a href="#projects">Projects</a></li>
                        <li><a href="#achievements">Achievements</a></li>
                        <li><a href="#education">Education</a></li>
                        <li><a href="#contact">Contact</a></li>
                    </ul>
                    <div class="nav-toggle" id="navToggle">
                        <span></span>
                        <span></span>
                        <span></span>
                    </div>
                </nav>
            </div>
        </header>

        <!-- Hero Section -->
        <section id="home" class="hero">
            <div class="hero-particles" id="particles"></div>
            <div class="container">
                <div class="hero-content">
                    <h1 class="fade-in-up">Mahir Rahman</h1>
                    <h2 class="typing-cursor" id="heroTitle">Competitive Programmer & Software Developer</h2>
                    <p class="fade-in-up">CSE 3rd Year Student at KUET | Passionate about Problem Solving & Software Development | Building innovative solutions with cutting-edge technologies</p>
                    <div class="hero-stats fade-in-up">
                        <div class="stat-item">
                            <span class="stats-counter" data-target="500">0</span>
                            <span class="stats-label">Problems Solved</span>
                        </div>
                        <div class="stat-item">
                            <span class="stats-counter" data-target="25">0</span>
                            <span class="stats-label">Contests Participated</span>
                        </div>
                        <div class="stat-item">
                            <span class="stats-counter" data-target="1456">0</span>
                            <span class="stats-label">Max Rating</span>
                        </div>
                    </div>
                    <a href="#contact" class="cta-button fade-in-up">
                        <i class="fas fa-envelope"></i>
                        Get In Touch
                    </a>
                </div>
            </div>
        </section>

        <!-- About Section -->
        <section id="about" class="section fade-in">
            <div class="container">
                <h2 class="section-title">About Me</h2>
                <div class="about-content">
                    <div>
                        <img src="Images/profile.jpg" alt="Professional Profile Picture" class="profile-img" 
                             onerror="this.src='https://images.unsplash.com/photo-1507003211169-0a1dd7228f2d?w=400&h=400&fit=crop&crop=face&auto=format&q=80'" />
                    </div>
                    <div class="about-text">
                        <p>
                            I am a passionate Computer Science and Engineering student at Khulna University of Engineering & Technology (KUET), 
                            currently in my 3rd year. My journey in competitive programming has shaped my problem-solving skills and algorithmic thinking, 
                            preparing me for complex software development challenges.
                        </p>
                        <p>
                            With over <strong>500+ problems solved</strong> across various online judges and a peak rating of <strong>1456 on Codeforces</strong>, 
                            I have developed expertise in data structures, algorithms, and optimization techniques. My competitive programming journey 
                            has not only enhanced my coding skills but also taught me to think critically under pressure.
                        </p>
                        <p>
                            Beyond competitive programming, I'm passionate about full-stack web development, machine learning, and software engineering. 
                            I believe in continuous learning and love exploring new technologies. My goal is to leverage my problem-solving skills 
                            to create innovative solutions that make a positive impact on society.
                        </p>
                        <div class="social-links">
                            <a href="https://linkedin.com/in/mahir-rahman" target="_blank" title="LinkedIn" aria-label="LinkedIn Profile">
                                <i class="fab fa-linkedin-in"></i>
                            </a>
                            <a href="https://github.com/k-i-mahi" target="_blank" title="GitHub" aria-label="GitHub Profile">
                                <i class="fab fa-github"></i>
                            </a>
                            <a href="https://codeforces.com/profile/mahir_kuet" target="_blank" title="Codeforces" aria-label="Codeforces Profile">
                                <i class="fas fa-trophy"></i>
                            </a>
                            <a href="https://codechef.com/users/mahir_kuet" target="_blank" title="CodeChef" aria-label="CodeChef Profile">
                                <i class="fas fa-code"></i>
                            </a>
                            <a href="mailto:mahir.rahman@kuet.ac.bd" title="Email" aria-label="Send Email">
                                <i class="fas fa-envelope"></i>
                            </a>
                        </div>
                    </div>
                </div>
            </div>
        </section>

        <!-- Skills Section -->
        <section id="skills" class="section fade-in">
            <div class="container">
                <h2 class="section-title">Technical Skills</h2>
                <div class="skills-grid" id="skillsGrid" runat="server">
                    <!-- Skills will be loaded dynamically from code-behind -->
                </div>
            </div>
        </section>

        <!-- Competitive Programming Section -->
        <section id="competitive" class="section fade-in">
            <div class="container">
                <h2 class="section-title">Competitive Programming Profiles</h2>
                <p style="text-align: center; margin-bottom: 3rem; font-size: 1.1rem; color: var(--text-light);">
                    My journey across various competitive programming platforms
                </p>
                <div class="programming-stats" id="programmingStats" runat="server">
                    <!-- Programming platform stats will be loaded dynamically -->
                </div>
            </div>
        </section>

        <!-- Projects Section -->
        <section id="projects" class="section fade-in">
            <div class="container">
                <h2 class="section-title">Featured Projects</h2>
                <div class="projects-grid">
                    <asp:Repeater ID="rptProjects" runat="server">
                        <ItemTemplate>
                            <article class="project-card">
                                <div class="project-img">
                                    <%# !string.IsNullOrEmpty(Eval("ImageUrl").ToString()) ? 
                                        $"<img src='{Eval("ImageUrl")}' alt='{Eval("Title")}' loading='lazy' />" : 
                                        "<i class='fas fa-laptop-code fa-3x'></i>" %>
                                </div>
                                <div class="project-content">
                                    <h3 class="project-title"><%# Eval("Title") %></h3>
                                    <p class="project-description"><%# Eval("Description") %></p>
                                    <%# !string.IsNullOrEmpty(Eval("DetailedDescription").ToString()) ? 
                                        $"<p class='project-detailed'>{Eval("DetailedDescription")}</p>" : "" %>
                                    <div class="project-tech">
                                        <i class="fas fa-tools"></i>
                                        <%# Eval("Technologies") %>
                                    </div>
                                    <div class="project-links">
                                        <%# !string.IsNullOrEmpty(Eval("GitHubLink").ToString()) ? 
                                            $"<a href='{Eval("GitHubLink")}' class='project-link' target='_blank' rel='noopener'><i class='fab fa-github'></i> GitHub</a>" : "" %>
                                        <%# !string.IsNullOrEmpty(Eval("LiveDemoLink").ToString()) ? 
                                            $"<a href='{Eval("LiveDemoLink")}' class='project-link' target='_blank' rel='noopener'><i class='fas fa-external-link-alt'></i> Live Demo</a>" : "" %>
                                    </div>
                                </div>
                            </article>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
            </div>
        </section>

        <!-- Achievements Section -->
        <section id="achievements" class="section fade-in">
            <div class="container">
                <h2 class="section-title">Achievements & Recognition</h2>
                <div class="achievements-grid">
                    <asp:Repeater ID="rptAchievements" runat="server">
                        <ItemTemplate>
                            <article class="achievement-card">
                                <div class="achievement-platform">
                                    <i class="fas fa-medal"></i>
                                    <%# Eval("Platform") %>
                                </div>
                                <h3 class="achievement-title"><%# Eval("Title") %></h3>
                                <p class="achievement-description"><%# Eval("Description") %></p>
                                <%# !string.IsNullOrEmpty(Eval("Ranking").ToString()) ? 
                                    $"<div class='achievement-ranking'><i class='fas fa-trophy'></i> {Eval("Ranking")}</div>" : "" %>
                                <small class="achievement-date">
                                    <i class="fas fa-calendar"></i>
                                    <%# Eval("AchievedDate", "{0:MMMM yyyy}") %>
                                </small>
                                <%# !string.IsNullOrEmpty(Eval("CertificateUrl").ToString()) ? 
                                    $"<br><a href='{Eval("CertificateUrl")}' target='_blank' rel='noopener' class='project-link' style='margin-top: 1rem; display: inline-block;'><i class='fas fa-certificate'></i> View Certificate</a>" : "" %>
                            </article>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
            </div>
        </section>

        <!-- Education Section -->
        <section id="education" class="section fade-in">
            <div class="container">
                <h2 class="section-title">Education</h2>
                <div class="education-timeline">
                    <asp:Repeater ID="rptEducation" runat="server">
                        <ItemTemplate>
                            <article class="education-item">
                                <div class="education-header">
                                    <div class="education-info">
                                        <h3><%# Eval("Degree") %></h3>
                                        <h4><%# Eval("Institution") %></h4>
                                        <%# !string.IsNullOrEmpty(Eval("Department").ToString()) ? $"<p><strong>Department:</strong> {Eval("Department")}</p>" : "" %>
                                        <%# !string.IsNullOrEmpty(Eval("CGPA").ToString()) ? $"<p><strong>CGPA:</strong> {Eval("CGPA")}</p>" : "" %>
                                    </div>
                                    <div class="education-date">
                                        <i class="fas fa-calendar-alt"></i>
                                        <%# Eval("StartDate", "{0:yyyy}") %> - <%# Eval("IsCurrent").ToString() == "True" ? "Present" : Eval("EndDate", "{0:yyyy}") %>
                                    </div>
                                </div>
                                <%# !string.IsNullOrEmpty(Eval("Description").ToString()) ? $"<p class='education-description'>{Eval("Description")}</p>" : "" %>
                            </article>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
            </div>
        </section>

        <!-- Contact Section -->
        <section id="contact" class="section fade-in">
            <div class="container">
                <h2 class="section-title">Get In Touch</h2>
                <div class="contact-content">
                    <asp:Panel ID="pnlMessage" runat="server" Visible="false">
                        <asp:Literal ID="litMessage" runat="server"></asp:Literal>
                    </asp:Panel>
                    
                    <div class="contact-form">
                        <div class="form-row">
                            <div class="form-group">
                                <label for="txtName">
                                    <i class="fas fa-user"></i>
                                    Full Name *
                                </label>
                                <asp:TextBox ID="txtName" runat="server" CssClass="form-control" Required="true" placeholder="Enter your full name"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label for="txtEmail">
                                    <i class="fas fa-envelope"></i>
                                    Email Address *
                                </label>
                                <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" TextMode="Email" Required="true" placeholder="Enter your email address"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-row">
                            <div class="form-group">
                                <label for="txtPhone">
                                    <i class="fas fa-phone"></i>
                                    Phone Number
                                </label>
                                <asp:TextBox ID="txtPhone" runat="server" CssClass="form-control" placeholder="Enter your phone number"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label for="txtSubject">
                                    <i class="fas fa-tag"></i>
                                    Subject
                                </label>
                                <asp:TextBox ID="txtSubject" runat="server" CssClass="form-control" placeholder="Enter message subject"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label for="txtMessage">
                                <i class="fas fa-comment"></i>
                                Message *
                            </label>
                            <asp:TextBox ID="txtMessage" runat="server" CssClass="form-control" TextMode="MultiLine" Rows="6" Required="true" placeholder="Enter your message here..."></asp:TextBox>
                        </div>
                        <asp:Button ID="btnSubmit" runat="server" Text="Send Message" CssClass="btn-submit" OnClick="btnSubmit_Click" />
                    </div>
                </div>
            </div>
        </section>

        <!-- Footer -->
        <footer class="footer">
            <div class="container">
                <p>&copy; <%= DateTime.Now.Year %> Mahir Rahman. All rights reserved. | Built with ASP.NET & C# | 
                <a href="Admin.aspx" style="color: #fff; text-decoration: none; opacity: 0.7;">Admin</a></p>
            </div>
        </footer>
    </form>

    <script>
        // Enhanced JavaScript for better user experience
        document.addEventListener('DOMContentLoaded', function() {
            // Initialize particles
            createParticles();
            
            // Initialize counters
            initCounters();
            
            // Mobile Navigation Toggle
            const navToggle = document.getElementById('navToggle');
            const navLinks = document.getElementById('navLinks');
            
            if (navToggle && navLinks) {
                navToggle.addEventListener('click', function() {
                    navLinks.classList.toggle('active');
                    navToggle.classList.toggle('active');
                });

                navLinks.addEventListener('click', function() {
                    navLinks.classList.remove('active');
                    navToggle.classList.remove('active');
                });
            }

            // Header scroll effect
            const header = document.getElementById('header');
            if (header) {
                window.addEventListener('scroll', function() {
                    if (window.scrollY > 100) {
                        header.classList.add('scrolled');
                    } else {
                        header.classList.remove('scrolled');
                    }
                });
            }

            // Animate skill bars when in view
            const skillBars = document.querySelectorAll('.skill-progress');
            const animateSkills = () => {
                skillBars.forEach(bar => {
                    const rect = bar.getBoundingClientRect();
                    if (rect.top < window.innerHeight - 100 && rect.bottom > 0) {
                        const width = bar.getAttribute('data-width');
                        if (width && !bar.classList.contains('animate')) {
                            bar.style.width = width + '%';
                            bar.classList.add('animate');
                        }
                    }
                });
            };

            // Intersection Observer for fade-in animations
            const observerOptions = {
                threshold: 0.1,
                rootMargin: '0px 0px -50px 0px'
            };

            const observer = new IntersectionObserver(function(entries) {
                entries.forEach(entry => {
                    if (entry.isIntersecting) {
                        entry.target.classList.add('visible');
                        
                        // Trigger counter animation when section is visible
                        if (entry.target.id === 'home') {
                            animateCounters();
                        }
                    }
                });
            }, observerOptions);

            // Observe all fade-in elements
            document.querySelectorAll('.fade-in').forEach(el => {
                observer.observe(el);
            });

            // Initial checks
            animateSkills();
            
            // Check on scroll
            window.addEventListener('scroll', function() {
                animateSkills();
                updateActiveNavLink();
            });

            // Smooth scrolling for navigation links
            document.querySelectorAll('a[href^="#"]').forEach(anchor => {
                anchor.addEventListener('click', function (e) {
                    e.preventDefault();
                    const target = document.querySelector(this.getAttribute('href'));
                    if (target && header) {
                        const headerHeight = header.offsetHeight;
                        const targetPosition = target.offsetTop - headerHeight - 20;
                        
                        window.scrollTo({
                            top: targetPosition,
                            behavior: 'smooth'
                        });
                    }
                });
            });

            // Update active navigation link
            function updateActiveNavLink() {
                const sections = document.querySelectorAll('section[id]');
                const navLinks = document.querySelectorAll('.nav-links a');
                
                let current = '';
                sections.forEach(section => {
                    const headerHeight = header ? header.offsetHeight : 80;
                    const sectionTop = section.offsetTop - headerHeight - 50;
                    const sectionHeight = section.offsetHeight;
                    
                    if (window.scrollY >= sectionTop && window.scrollY < sectionTop + sectionHeight) {
                        current = section.getAttribute('id');
                    }
                });
                
                navLinks.forEach(link => {
                    link.classList.remove('active');
                    if (link.getAttribute('href') === '#' + current) {
                        link.classList.add('active');
                    }
                });
            }

            // Form validation enhancement
            const form = document.getElementById('form1');
            if (form) {
                const requiredFields = form.querySelectorAll('[required]');
                requiredFields.forEach(field => {
                    field.addEventListener('blur', function() {
                        if (this.value.trim() === '') {
                            this.style.borderColor = '#e74c3c';
                        } else {
                            this.style.borderColor = '#28a745';
                        }
                    });
                });
            }

            // Typing effect for hero section
            const heroTitle = document.querySelector('.hero h2');
            if (heroTitle && heroTitle.classList.contains('typing-cursor')) {
                const text = heroTitle.textContent;
                heroTitle.textContent = '';
                let i = 0;
                
                setTimeout(() => {
                    const typeWriter = () => {
                        if (i < text.length) {
                            heroTitle.textContent += text.charAt(i);
                            i++;
                            setTimeout(typeWriter, 100);
                        }
                    };
                    typeWriter();
                }, 1000);
            }
        });

        // Create floating particles
        function createParticles() {
            const particles = document.getElementById('particles');
            if (particles) {
                for (let i = 0; i < 50; i++) {
                    const particle = document.createElement('div');
                    particle.className = 'particle';
                    particle.style.left = Math.random() * 100 + '%';
                    particle.style.animationDelay = Math.random() * 15 + 's';
                    particle.style.animationDuration = (Math.random() * 10 + 10) + 's';
                    particles.appendChild(particle);
                }
            }
        }

        // Initialize counter animation
        function initCounters() {
            const counters = document.querySelectorAll('.stats-counter');
            counters.forEach(counter => {
                counter.innerText = '0';
            });
        }

        // Animate counters
        function animateCounters() {
            const counters = document.querySelectorAll('.stats-counter');
            counters.forEach(counter => {
                const target = parseInt(counter.getAttribute('data-target'));
                const count = +counter.innerText;
                const increment = target / 100;
                
                if (count < target) {
                    counter.innerText = Math.ceil(count + increment);
                    setTimeout(() => animateCounters(), 50);
                } else {
                    counter.innerText = target;
                }
            });
        }

        // Enhanced platform card interactions
        document.addEventListener('DOMContentLoaded', function() {
            const platformCards = document.querySelectorAll('.platform-card');
            platformCards.forEach(card => {
                card.addEventListener('mouseenter', function() {
                    this.style.transform = 'translateY(-10px) scale(1.02)';
                });
                
                card.addEventListener('mouseleave', function() {
                    this.style.transform = 'translateY(0) scale(1)';
                });
            });
        });
    </script>
</body>
</html>