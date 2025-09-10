-- Portfolio Database Creation Script
-- Run this script to create the portfolio database and tables

-- Create Database (uncomment if using SQL Server Express)
-- CREATE DATABASE PortfolioDB;
-- GO
-- USE PortfolioDB;
-- GO

-- Create Projects Table
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Projects]') AND type in (N'U'))
BEGIN
    CREATE TABLE [dbo].[Projects] (
        [Id] int IDENTITY(1,1) NOT NULL PRIMARY KEY,
        [Title] nvarchar(255) NOT NULL,
        [Description] nvarchar(500) NULL,
        [DetailedDescription] nvarchar(max) NULL,
        [Technologies] nvarchar(500) NULL,
        [GitHubLink] nvarchar(500) NULL,
        [LiveDemoLink] nvarchar(500) NULL,
        [ImageUrl] nvarchar(500) NULL,
        [IsActive] bit NOT NULL DEFAULT 1,
        [CreatedDate] datetime NOT NULL DEFAULT GETDATE(),
        [UpdatedDate] datetime NULL
    );
    
    PRINT 'Projects table created successfully.';
END

-- Create Skills Table
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Skills]') AND type in (N'U'))
BEGIN
    CREATE TABLE [dbo].[Skills] (
        [Id] int IDENTITY(1,1) NOT NULL PRIMARY KEY,
        [Name] nvarchar(255) NOT NULL,
        [Category] nvarchar(255) NOT NULL,
        [ProficiencyLevel] int NOT NULL CHECK ([ProficiencyLevel] >= 1 AND [ProficiencyLevel] <= 100),
        [IsActive] bit NOT NULL DEFAULT 1,
        [CreatedDate] datetime NOT NULL DEFAULT GETDATE(),
        [UpdatedDate] datetime NULL
    );
    
    PRINT 'Skills table created successfully.';
END

-- Create Achievements Table
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Achievements]') AND type in (N'U'))
BEGIN
    CREATE TABLE [dbo].[Achievements] (
        [Id] int IDENTITY(1,1) NOT NULL PRIMARY KEY,
        [Title] nvarchar(255) NOT NULL,
        [Platform] nvarchar(255) NOT NULL,
        [Description] nvarchar(max) NULL,
        [Ranking] nvarchar(255) NULL,
        [AchievedDate] datetime NOT NULL,
        [CertificateUrl] nvarchar(500) NULL,
        [IsActive] bit NOT NULL DEFAULT 1,
        [CreatedDate] datetime NOT NULL DEFAULT GETDATE()
    );
    
    PRINT 'Achievements table created successfully.';
END

-- Create Education Table (CGPA column removed)
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Education]') AND type in (N'U'))
BEGIN
    CREATE TABLE [dbo].[Education] (
        [Id] int IDENTITY(1,1) NOT NULL PRIMARY KEY,
        [Institution] nvarchar(255) NOT NULL,
        [Degree] nvarchar(255) NOT NULL,
        [Department] nvarchar(255) NULL,
        [StartDate] datetime NOT NULL,
        [EndDate] datetime NULL,
        [IsCurrent] bit NOT NULL DEFAULT 0,
        [Description] nvarchar(max) NULL,
        [IsActive] bit NOT NULL DEFAULT 1,
        [CreatedDate] datetime NOT NULL DEFAULT GETDATE()
    );
    
    PRINT 'Education table created successfully.';
END

-- Create Contact Messages Table
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ContactMessages]') AND type in (N'U'))
BEGIN
    CREATE TABLE [dbo].[ContactMessages] (
        [Id] int IDENTITY(1,1) NOT NULL PRIMARY KEY,
        [Name] nvarchar(255) NOT NULL,
        [Email] nvarchar(255) NOT NULL,
        [Phone] nvarchar(50) NULL,
        [Subject] nvarchar(255) NULL,
        [Message] nvarchar(max) NOT NULL,
        [CreatedDate] datetime NOT NULL DEFAULT GETDATE(),
        [IsRead] bit NOT NULL DEFAULT 0,
        [AdminNotes] nvarchar(max) NULL
    );
    
    PRINT 'ContactMessages table created successfully.';
END

-- Create Portfolio Settings Table
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PortfolioSettings]') AND type in (N'U'))
BEGIN
    CREATE TABLE [dbo].[PortfolioSettings] (
        [Id] int IDENTITY(1,1) NOT NULL PRIMARY KEY,
        [SettingKey] nvarchar(255) NOT NULL UNIQUE,
        [SettingValue] nvarchar(max) NULL,
        [Description] nvarchar(500) NULL,
        [LastUpdated] datetime NOT NULL DEFAULT GETDATE()
    );
    
    PRINT 'PortfolioSettings table created successfully.';
END

-- Insert Sample Data for Projects
IF NOT EXISTS (SELECT * FROM [Projects])
BEGIN
    INSERT INTO [Projects] ([Title], [Description], [DetailedDescription], [Technologies], [GitHubLink], [IsActive]) VALUES
    ('Smart Obstacle Avoiding Robot', 'AI-powered autonomous navigation system with advanced sensor integration', 'Developed an intelligent robotics system capable of real-time obstacle detection and avoidance using machine learning algorithms and Arduino-based control systems.', 'Arduino, C++, Machine Learning, Ultrasonic Sensors', 'https://github.com/k-i-mahi/smart-obstacle-robot', 1),
    ('Competitive Programming Judge System', 'Full-stack online judge platform for competitive programming', 'Built a comprehensive online judge system supporting multiple programming languages with real-time compilation, execution, and result evaluation capabilities.', 'ASP.NET Core, SQL Server, Docker, C#', 'https://github.com/k-i-mahi/cp-judge-system', 1),
    ('Kaggle ML Competition Suite', 'Machine learning solutions for various Kaggle competitions', 'Collection of high-performing ML models and data analysis pipelines developed for Kaggle competitions, featuring advanced feature engineering and ensemble methods.', 'Python, Pandas, Scikit-learn, XGBoost, TensorFlow', 'https://github.com/k-i-mahi/kaggle-ml-solutions', 1),
    ('Line Following Robot Championship', 'High-precision competitive robotics solution', 'Championship-level line following robot with PID control system, achieving sub-second lap times in competitive robotics tournaments.', 'Arduino, PID Control, Advanced Sensors, C++', 'https://github.com/k-i-mahi/championship-lfr', 1),
    ('IoT Smart Home Ecosystem', 'Complete home automation and monitoring system', 'Comprehensive IoT solution for smart home management including lighting, security, climate control, and energy monitoring with mobile app integration.', 'ESP32, Firebase, Android Studio, IoT Protocols', 'https://github.com/k-i-mahi/iot-smart-home', 1),
    ('Chess Engine & Analyzer', 'Advanced chess game analysis and engine integration', 'Sophisticated chess analysis tool with custom engine integration, position evaluation, and game analysis capabilities for competitive chess preparation.', 'Python, Stockfish Engine, Chess.py, PyQt', 'https://github.com/k-i-mahi/chess-engine-analyzer', 1);
    
    PRINT 'Sample projects inserted successfully.';
END

-- Insert Sample Data for Skills
IF NOT EXISTS (SELECT * FROM [Skills])
BEGIN
    INSERT INTO [Skills] ([Name], [Category], [ProficiencyLevel], [IsActive]) VALUES
    ('C++', 'Programming Languages', 95, 1),
    ('Python', 'Programming Languages', 90, 1),
    ('Java', 'Programming Languages', 85, 1),
    ('C#', 'Programming Languages', 82, 1),
    ('JavaScript', 'Programming Languages', 78, 1),
    ('ASP.NET', 'Web Development', 88, 1),
    ('React.js', 'Web Development', 78, 1),
    ('Node.js', 'Web Development', 72, 1),
    ('HTML5/CSS3', 'Web Development', 85, 1),
    ('SQL Server', 'Database', 80, 1),
    ('MySQL', 'Database', 75, 1),
    ('MongoDB', 'Database', 70, 1),
    ('Machine Learning', 'Data Science & AI', 82, 1),
    ('Data Analysis', 'Data Science & AI', 80, 1),
    ('Pandas/NumPy', 'Data Science & AI', 85, 1),
    ('Arduino Programming', 'Hardware & Robotics', 88, 1),
    ('ESP32/IoT', 'Hardware & Robotics', 82, 1),
    ('Circuit Design', 'Hardware & Robotics', 78, 1),
    ('Git/GitHub', 'Tools & Technologies', 85, 1),
    ('Docker', 'Tools & Technologies', 72, 1),
    ('Linux/Ubuntu', 'Tools & Technologies', 75, 1),
    ('Competitive Programming', 'Algorithms & DS', 90, 1),
    ('Data Structures', 'Algorithms & DS', 92, 1),
    ('Algorithm Design', 'Algorithms & DS', 88, 1),
    ('Problem Solving', 'Algorithms & DS', 95, 1);
    
    PRINT 'Sample skills inserted successfully.';
END

-- Insert Sample Data for Achievements
IF NOT EXISTS (SELECT * FROM [Achievements])
BEGIN
    INSERT INTO [Achievements] ([Title], [Platform], [Description], [Ranking], [AchievedDate], [IsActive]) VALUES
    ('CodeChef 5-Star Rating Achievement', 'CodeChef', 'Achieved prestigious 5-star rating on CodeChef as @k_i_mahi with maximum rating of 2019, demonstrating exceptional problem-solving skills', '5? Rating - Max Rating: 2019', '2024-11-15', 1),
    ('Codeforces Specialist Rating Achievement', 'Codeforces', 'Achieved Specialist rating (1400+) with consistent performance in competitive programming contests', 'Max Rating: 1456+ (Specialist)', '2024-11-01', 1),
    ('CSES Problem Set Excellence', 'CSES', 'Successfully solved 193 problems on CSES Problem Set, demonstrating strong algorithmic foundations', '193/300+ Problems Solved - 64% Completion', '2024-12-01', 1),
    ('ACM ICPC Asia Dhaka Regional 2024 - Team Qualifier', 'ACM ICPC', 'Successfully qualified for ACM ICPC Asia Dhaka Regional Contest 2024 as part of KUET programming team', 'Regional Qualifier - Team Rank: 25th out of 200+ teams', '2024-10-15', 1),
    ('Kaggle Competition Bronze Medal Achievement', 'Kaggle', 'Earned Bronze Medal in Kaggle''s ''Spaceship Titanic'' machine learning competition', 'Bronze Medal - Top 15% (375th out of 2500+)', '2024-09-28', 1),
    ('KUET Hardware Exhibition - Best Innovation Award', 'HACK - KUET', 'Won Best Innovation Award for AI-powered obstacle-avoiding robot at KUET Hardware Exhibition', '1st Place - Best Innovation Award', '2024-09-15', 1),
    ('AtCoder Consistent Performance', 'AtCoder', 'Maintained consistent performance in AtCoder contests with Brown color rating', 'Brown Color - 300+ Problems Solved', '2024-08-20', 1),
    ('Multi-Platform Programming Excellence', 'Overall Achievement', 'Demonstrated exceptional problem-solving skills across multiple competitive programming platforms', '2500+ Total Problems Solved Across Platforms', '2024-12-01', 1),
    ('National Programming Olympiad Achievement', 'Bangladesh Olympiad on Informatics', 'Secured 3rd position in National High School Programming Contest 2021', '3rd Place National Level - High School Category', '2021-02-15', 1),
    ('Outstanding Academic Excellence', 'Academic Achievement', 'Maintained excellent academic performance throughout SSC and HSC with strong results', 'Consistent High Performance - SSC & HSC', '2021-07-30', 1);
    
    PRINT 'Sample achievements inserted successfully.';
END

-- Insert Sample Data for Education (Updated with correct institutions, CGPA removed)
IF NOT EXISTS (SELECT * FROM [Education])
BEGIN
    INSERT INTO [Education] ([Institution], [Degree], [Department], [StartDate], [EndDate], [IsCurrent], [Description], [IsActive]) VALUES
    ('Khulna University of Engineering & Technology (KUET)', 'Bachelor of Science in Computer Science and Engineering', 'Computer Science and Engineering', '2022-01-01', NULL, 1, 'Currently pursuing B.Sc. in CSE with specialization in algorithms, artificial intelligence, and software engineering. Active member of programming club and robotics society. Engaged in competitive programming, hardware projects, and research activities.', 1),
    ('Government Michael Madhusudan College, Jashore', 'Higher Secondary Certificate (HSC)', 'Science Group', '2019-06-01', '2021-05-31', 0, 'Completed Higher Secondary Certificate in Science group with excellent results. Concentrated in Mathematics, Physics, Chemistry, and Information & Communication Technology. Started competitive programming journey and participated in various science olympiads.', 1),
    ('Daud Public School and College, Jashore', 'Secondary School Certificate (SSC)', 'Science Group', '2017-01-01', '2019-05-31', 0, 'Completed Secondary School Certificate in Science group with outstanding performance. Built strong foundation in mathematics and sciences with additional focus on computer studies. Began interest in programming and technology.', 1);
    
    PRINT 'Sample education records inserted successfully.';
END

-- Insert Default Portfolio Settings
IF NOT EXISTS (SELECT * FROM [PortfolioSettings])
BEGIN
    INSERT INTO [PortfolioSettings] ([SettingKey], [SettingValue], [Description]) VALUES
    ('FullName', 'Khadimul Islam Mahi', 'Full name displayed on portfolio'),
    ('Email', 'mahi.jess9t@gmail.com', 'Primary contact email'),
    ('Phone', '+880 1X XX XX XX XX', 'Contact phone number'),
    ('LinkedInProfile', 'https://www.linkedin.com/in/k-i-mahi-29436a282/', 'LinkedIn profile URL'),
    ('GitHubProfile', 'https://github.com/k-i-mahi', 'GitHub profile URL'),
    ('FacebookProfile', 'https://www.facebook.com/k.i.mahi.600019', 'Facebook profile URL'),
    ('InstagramProfile', 'https://www.instagram.com/k.i.mahi/', 'Instagram profile URL'),
    ('CodeforcesHandle', 'being_mysterious', 'Codeforces username'),
    ('CodeChefHandle', 'k_i_mahi', 'CodeChef username'),
    ('CSESHandle', 'potassium_iodide', 'CSES username'),
    ('AtCoderHandle', 'potassium_iodide', 'AtCoder username'),
    ('ChessComProfile', 'https://www.chess.com/member/k_i_mahi', 'Chess.com profile URL'),
    ('LichessProfile', 'https://lichess.org/@/k_i_mahi', 'Lichess profile URL'),
    ('KaggleProfile', 'https://kaggle.com/khadimulmahi', 'Kaggle profile URL'),
    ('Bio', 'CSE 3rd Year Student at KUET | Passionate Problem Solver | Hardware Project Builder | Kaggle Competitor | Chess Enthusiast | Photography Lover', 'Short biography for hero section'),
    ('TotalProblems', '2500', 'Total problems solved across all platforms'),
    ('TotalCompetitions', '100', 'Total competitions participated'),
    ('CodeChefRating', '2019', 'Maximum CodeChef rating'),
    ('CodeChefStars', '5', 'CodeChef star rating'),
    ('ShowContactForm', 'true', 'Enable/disable contact form'),
    ('EnableAnimations', 'true', 'Enable/disable page animations'),
    ('DefaultTheme', 'light', 'Default theme (light/dark)');
    
    PRINT 'Default portfolio settings inserted successfully.';
END

-- Create Indexes for Performance
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name = 'IX_Projects_IsActive_CreatedDate')
BEGIN
    CREATE INDEX IX_Projects_IsActive_CreatedDate ON [Projects] ([IsActive], [CreatedDate] DESC);
    PRINT 'Index IX_Projects_IsActive_CreatedDate created successfully.';
END

IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name = 'IX_Skills_Category_IsActive')
BEGIN
    CREATE INDEX IX_Skills_Category_IsActive ON [Skills] ([Category], [IsActive]);
    PRINT 'Index IX_Skills_Category_IsActive created successfully.';
END

IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name = 'IX_Achievements_AchievedDate_IsActive')
BEGIN
    CREATE INDEX IX_Achievements_AchievedDate_IsActive ON [Achievements] ([AchievedDate] DESC, [IsActive]);
    PRINT 'Index IX_Achievements_AchievedDate_IsActive created successfully.';
END

IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name = 'IX_ContactMessages_CreatedDate')
BEGIN
    CREATE INDEX IX_ContactMessages_CreatedDate ON [ContactMessages] ([CreatedDate] DESC);
    PRINT 'Index IX_ContactMessages_CreatedDate_CreatedDate created successfully.';
END

-- Drop CGPA column if it exists (for existing databases)
IF EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID(N'[dbo].[Education]') AND name = 'CGPA')
BEGIN
    ALTER TABLE [Education] DROP COLUMN [CGPA];
    PRINT 'CGPA column removed from Education table.';
END

PRINT 'Portfolio Database setup completed successfully!';
PRINT 'Education table updated with correct institutions:';
PRINT '- University: Khulna University of Engineering & Technology (KUET)';
PRINT '- College: Government Michael Madhusudan College, Jashore';
PRINT '- School: Daud Public School and College, Jashore';
PRINT 'CGPA column removed from Education table.';
PRINT 'You can now run your portfolio application.';