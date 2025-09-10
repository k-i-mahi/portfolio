-- Portfolio Database Setup Script for Competitive Programmer
-- Run this script in SQL Server Management Studio to create the database and tables

-- Create Database
IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'PortfolioDB')
BEGIN
    CREATE DATABASE PortfolioDB;
    PRINT 'Database PortfolioDB created successfully.';
END
ELSE
BEGIN
    PRINT 'Database PortfolioDB already exists.';
END
GO

USE PortfolioDB;
GO

-- Create Projects Table
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Projects' AND xtype='U')
BEGIN
    CREATE TABLE Projects (
        Id INT IDENTITY(1,1) PRIMARY KEY,
        Title NVARCHAR(100) NOT NULL,
        Description NVARCHAR(500) NOT NULL,
        DetailedDescription NVARCHAR(2000) NULL,
        Technologies NVARCHAR(200) NULL,
        GitHubLink NVARCHAR(500) NULL,
        LiveDemoLink NVARCHAR(500) NULL,
        ImageUrl NVARCHAR(500) NULL,
        CreatedDate DATETIME NOT NULL DEFAULT GETDATE(),
        IsActive BIT NOT NULL DEFAULT 1,
        DisplayOrder INT NOT NULL DEFAULT 0
    );
    PRINT 'Projects table created successfully.';
END
GO

-- Create Skills Table
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Skills' AND xtype='U')
BEGIN
    CREATE TABLE Skills (
        Id INT IDENTITY(1,1) PRIMARY KEY,
        Name NVARCHAR(50) NOT NULL,
        Category NVARCHAR(20) NULL,
        ProficiencyLevel INT NOT NULL CHECK (ProficiencyLevel BETWEEN 1 AND 100),
        IconClass NVARCHAR(500) NULL,
        IsActive BIT NOT NULL DEFAULT 1,
        DisplayOrder INT NOT NULL DEFAULT 0
    );
    PRINT 'Skills table created successfully.';
END
GO

-- Create Achievements Table
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Achievements' AND xtype='U')
BEGIN
    CREATE TABLE Achievements (
        Id INT IDENTITY(1,1) PRIMARY KEY,
        Title NVARCHAR(100) NOT NULL,
        Platform NVARCHAR(100) NULL,
        Description NVARCHAR(500) NULL,
        Ranking NVARCHAR(50) NULL,
        CertificateUrl NVARCHAR(500) NULL,
        AchievedDate DATETIME NOT NULL,
        IsActive BIT NOT NULL DEFAULT 1,
        DisplayOrder INT NOT NULL DEFAULT 0
    );
    PRINT 'Achievements table created successfully.';
END
GO

-- Create Education Table
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Education' AND xtype='U')
BEGIN
    CREATE TABLE Education (
        Id INT IDENTITY(1,1) PRIMARY KEY,
        Institution NVARCHAR(100) NOT NULL,
        Degree NVARCHAR(100) NOT NULL,
        Department NVARCHAR(100) NULL,
        CGPA NVARCHAR(20) NULL,
        StartDate DATETIME NOT NULL,
        EndDate DATETIME NULL,
        IsCurrent BIT NOT NULL DEFAULT 0,
        Description NVARCHAR(1000) NULL,
        IsActive BIT NOT NULL DEFAULT 1,
        DisplayOrder INT NOT NULL DEFAULT 0
    );
    PRINT 'Education table created successfully.';
END
GO

-- Create Contacts Table
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Contacts' AND xtype='U')
BEGIN
    CREATE TABLE Contacts (
        Id INT IDENTITY(1,1) PRIMARY KEY,
        Name NVARCHAR(100) NOT NULL,
        Email NVARCHAR(100) NOT NULL,
        Phone NVARCHAR(20) NULL,
        Subject NVARCHAR(100) NULL,
        Message NVARCHAR(2000) NOT NULL,
        CreatedDate DATETIME NOT NULL DEFAULT GETDATE(),
        IsRead BIT NOT NULL DEFAULT 0
    );
    PRINT 'Contacts table created successfully.';
END
GO

-- Clear existing data for fresh setup
DELETE FROM Skills;
DELETE FROM Projects;  
DELETE FROM Education;
DELETE FROM Achievements;
PRINT 'Existing data cleared for fresh setup.';

-- Insert Comprehensive Skills Data for Competitive Programmer
PRINT 'Inserting Skills data...';

-- Programming Languages
INSERT INTO Skills (Name, Category, ProficiencyLevel, DisplayOrder) VALUES
('C++', 'Programming Languages', 95, 1),
('Java', 'Programming Languages', 85, 2),
('C', 'Programming Languages', 90, 3),
('Python', 'Programming Languages', 80, 4),
('C#', 'Programming Languages', 78, 5),
('JavaScript', 'Programming Languages', 75, 6),
('Go', 'Programming Languages', 65, 7);

-- Algorithms & Data Structures  
INSERT INTO Skills (Name, Category, ProficiencyLevel, DisplayOrder) VALUES
('Data Structures', 'Algorithms & DS', 92, 1),
('Graph Algorithms', 'Algorithms & DS', 88, 2),
('Dynamic Programming', 'Algorithms & DS', 90, 3),
('Greedy Algorithms', 'Algorithms & DS', 85, 4),
('Number Theory', 'Algorithms & DS', 82, 5),
('Geometry', 'Algorithms & DS', 78, 6),
('String Algorithms', 'Algorithms & DS', 80, 7),
('Tree Algorithms', 'Algorithms & DS', 87, 8);

-- Development Frameworks
INSERT INTO Skills (Name, Category, ProficiencyLevel, DisplayOrder) VALUES
('ASP.NET Web Forms', 'Frameworks', 80, 1),
('ASP.NET Core', 'Frameworks', 75, 2),
('React', 'Frameworks', 70, 3),
('Node.js', 'Frameworks', 68, 4),
('Express.js', 'Frameworks', 65, 5);

-- Databases
INSERT INTO Skills (Name, Category, ProficiencyLevel, DisplayOrder) VALUES
('SQL Server', 'Database', 85, 1),
('MySQL', 'Database', 80, 2),
('PostgreSQL', 'Database', 75, 3),
('MongoDB', 'Database', 70, 4);

-- Tools & Technologies
INSERT INTO Skills (Name, Category, ProficiencyLevel, DisplayOrder) VALUES
('Git', 'Tools', 90, 1),
('Visual Studio', 'Tools', 92, 2),
('VS Code', 'Tools', 88, 3),
('Docker', 'Tools', 65, 4),
('Linux', 'Tools', 75, 5),
('Postman', 'Tools', 80, 6);

-- Insert Comprehensive Projects Data
PRINT 'Inserting Projects data...';

INSERT INTO Projects (Title, Description, DetailedDescription, Technologies, GitHubLink, LiveDemoLink, DisplayOrder) VALUES
('Online Judge Platform', 
 'A comprehensive competitive programming platform similar to Codeforces with real-time judging and contest management', 
 'Built a full-featured online judge system that supports multiple programming languages (C++, Java, Python, C#). Features include: automated code compilation and execution, secure sandboxed environment, real-time verdict display, contest management system, user ranking and rating system, problem categorization with difficulty levels, submission history tracking, and admin dashboard for problem management. The system can handle concurrent submissions and provides detailed execution feedback including time and memory usage.',
 'C#, ASP.NET Web Forms, SQL Server, JavaScript, CSS3, IIS',
 'https://github.com/k-i-mahi/online-judge',
 'https://demo-judge.example.com',
 1),

('Algorithm Visualizer Tool', 
 'Interactive web application for visualizing sorting algorithms, graph traversals, and pathfinding algorithms', 
 'Developed an educational tool that provides step-by-step visualization of popular algorithms. Includes sorting algorithms (Quick Sort, Merge Sort, Heap Sort, Bubble Sort), graph algorithms (BFS, DFS, Dijkstra, A*), and tree traversals (Inorder, Preorder, Postorder). Features adjustable animation speed, custom input support, complexity analysis display, and mobile-responsive design. Helps students and developers understand algorithm mechanics through visual representation.',
 'JavaScript, HTML5 Canvas, CSS3, Bootstrap',
 'https://github.com/k-i-mahi/algorithm-visualizer',
 'https://algo-viz.example.com',
 2),

('Student Management System', 
 'Complete academic management system for educational institutions with role-based access control', 
 'Comprehensive web application for managing academic operations including student enrollment, course management, grade tracking, attendance monitoring, and fee management. Features role-based dashboards for students, teachers, and administrators. Students can view grades and attendance, teachers can manage classes and assignments, administrators can generate reports and manage system users. Includes automated email notifications, academic calendar integration, and detailed analytics dashboard.',
 'ASP.NET Web Forms, C#, SQL Server, jQuery, Bootstrap, Chart.js',
 'https://github.com/k-i-mahi/student-management',
 '',
 3),

('Competitive Programming Helper', 
 'Browser extension and desktop application to enhance competitive programming workflow', 
 'Multi-platform tool designed to streamline competitive programming practice. Chrome extension features automatic problem parsing from popular platforms (Codeforces, CodeChef, AtCoder), template insertion, time tracking, and submission history. Desktop companion app provides contest reminders, rating tracker, problem recommendation system based on user skill level, and local testing environment. Supports multiple programming languages with customizable templates and snippets.',
 'JavaScript, Chrome Extension API, Electron, Node.js, HTML, CSS',
 'https://github.com/k-i-mahi/cp-helper',
 '',
 4),

('Real-time Chat Application', 
 'Multi-room chat application with file sharing and user authentication', 
 'Built a scalable real-time messaging platform using SignalR for instant communication. Features include multiple chat rooms, private messaging, file and image sharing, user authentication and authorization, online status indicators, message history persistence, emoji support, and mobile-responsive design. Implements proper security measures including message encryption and user verification.',
 'ASP.NET Core, SignalR, C#, SQL Server, JavaScript, Bootstrap',
 'https://github.com/k-i-mahi/realtime-chat',
 'https://chat-demo.example.com',
 5);

-- Insert Education Data
PRINT 'Inserting Education data...';

INSERT INTO Education (Institution, Degree, Department, CGPA, StartDate, EndDate, IsCurrent, Description, DisplayOrder) VALUES
('Khulna University of Engineering & Technology (KUET)', 
 'Bachelor of Science in Computer Science and Engineering', 
 'Computer Science and Engineering', 
 '3.78', 
 '2022-01-15', 
 NULL, 
 1, 
 'Currently pursuing B.Sc. in Computer Science and Engineering with focus on algorithms, software engineering, and competitive programming. Relevant coursework includes Data Structures and Algorithms, Database Management Systems, Software Engineering, Computer Networks, and Artificial Intelligence. Active member of KUET Programming Club and ACM Student Chapter. Participated in various national and international programming contests representing the university.',
 1),

('Kushtia Government College', 
 'Higher Secondary Certificate (HSC)', 
 'Science Group', 
 '5.00', 
 '2019-07-01', 
 '2021-06-30', 
 0, 
 'Completed Higher Secondary education in Science group with perfect GPA 5.00. Subjects included Physics, Chemistry, Mathematics, Biology, ICT, and English. Active participant in mathematics olympiad, physics olympiad, and programming contests. Served as the president of the college science club and organized various STEM workshops for junior students.',
 2),

('Kushtia Zilla School', 
 'Secondary School Certificate (SSC)', 
 'Science Group', 
 '5.00', 
 '2017-01-01', 
 '2019-05-31', 
 0, 
 'Completed Secondary education with perfect GPA 5.00 in Science group. Consistently ranked among top 3 students throughout secondary education. Participated in divisional mathematics olympiad and science fair competitions. Member of school debate team and computer club.',
 3);

-- Insert Comprehensive Achievements Data
PRINT 'Inserting Achievements data...';

INSERT INTO Achievements (Title, Platform, Description, Ranking, AchievedDate, DisplayOrder) VALUES
('ICPC World Finals Qualifier', 
 'ACM ICPC', 
 'Successfully qualified for ACM ICPC World Finals 2024 representing Bangladesh as part of Team KUET_Coders', 
 'Top 1% Globally', 
 '2024-11-15', 
 1),

('Codeforces Expert Rating', 
 'Codeforces', 
 'Achieved Expert rating (1600+) in Codeforces with consistent performance in rated contests', 
 'Max Rating: 1678', 
 '2024-10-20', 
 2),

('CodeChef 6-Star Rating', 
 'CodeChef', 
 'Attained 6-star rating in CodeChef Long Challenge with multiple contest wins', 
 'Max Rating: 2156', 
 '2024-09-25', 
 3),

('NCPC 2024 Champion', 
 'National Collegiate Programming Contest', 
 'Won 1st place in National Collegiate Programming Contest (NCPC) 2024 Bangladesh', 
 '1st Place Nationally', 
 '2024-08-10', 
 4),

('Google Code Jam Round 2 Qualifier', 
 'Google Code Jam', 
 'Advanced to Round 2 of Google Code Jam 2024, placing in top 4500 globally', 
 'Top 4500 Global', 
 '2024-05-15', 
 5),

('Facebook Hacker Cup Round 2', 
 'Meta Hacker Cup', 
 'Qualified for Round 2 of Facebook Hacker Cup 2024 among top performers', 
 'Round 2 Qualifier', 
 '2024-07-20', 
 6),

('AtCoder Algorithm Beginner Contest Winner', 
 'AtCoder', 
 'Won AtCoder Beginner Contest #325 with perfect score and fastest submission time', 
 '1st Place', 
 '2024-06-08', 
 7),

('HackerRank Algorithm Domain Gold', 
 'HackerRank', 
 'Earned Gold badge in Algorithms domain with 5-star rating by solving 200+ problems', 
 'Gold Badge - 5 Stars', 
 '2024-04-12', 
 8),

('TopCoder SRM Division I', 
 'TopCoder', 
 'Promoted to Division I in TopCoder Single Round Matches with consistent yellow rating', 
 'Division I - Yellow', 
 '2024-03-18', 
 9),

('BUET IUPC 2024 Runner-up', 
 'Inter University Programming Contest', 
 'Secured 2nd position in BUET Inter University Programming Contest 2024', 
 '2nd Place', 
 '2024-02-14', 
 10);

PRINT 'Sample data insertion completed successfully!';

-- Verify data insertion
PRINT 'Data verification:';
SELECT 'Skills' as TableName, COUNT(*) as RecordCount FROM Skills WHERE IsActive = 1
UNION ALL
SELECT 'Projects', COUNT(*) FROM Projects WHERE IsActive = 1
UNION ALL
SELECT 'Education', COUNT(*) FROM Education WHERE IsActive = 1
UNION ALL
SELECT 'Achievements', COUNT(*) FROM Achievements WHERE IsActive = 1;

PRINT '';
PRINT 'Database setup completed successfully!';
PRINT 'You can now run your ASP.NET application and view the portfolio with sample data.';
PRINT '';
PRINT 'Next steps:';
PRINT '1. Update Web.config connection string if needed';
PRINT '2. Run the application and navigate to Default.aspx';
PRINT '3. Access Admin.aspx to manage content';
PRINT '4. Test contact form functionality';
PRINT '5. Customize the sample data with your own information';