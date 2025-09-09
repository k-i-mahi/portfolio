-- Portfolio Database Setup Script
-- Run this script in SQL Server Management Studio to create the database and tables

-- Create Database
IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'PortfolioDB')
BEGIN
    CREATE DATABASE PortfolioDB;
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
END
GO

-- Insert Sample Data

-- Sample Skills Data
INSERT INTO Skills (Name, Category, ProficiencyLevel, DisplayOrder) VALUES
('C++', 'Programming Languages', 90, 1),
('Java', 'Programming Languages', 85, 2),
('C#', 'Programming Languages', 80, 3),
('Python', 'Programming Languages', 75, 4),
('JavaScript', 'Programming Languages', 70, 5),
('Data Structures', 'Algorithms & DS', 90, 1),
('Algorithms', 'Algorithms & DS', 88, 2),
('Dynamic Programming', 'Algorithms & DS', 85, 3),
('Graph Theory', 'Algorithms & DS', 82, 4),
('ASP.NET', 'Frameworks', 80, 1),
('React', 'Frameworks', 70, 2),
('.NET Framework', 'Frameworks', 75, 3),
('SQL Server', 'Database', 80, 1),
('MySQL', 'Database', 75, 2),
('MongoDB', 'Database', 65, 3),
('Git', 'Tools', 85, 1),
('Visual Studio', 'Tools', 90, 2),
('VS Code', 'Tools', 85, 3);

-- Sample Projects Data
INSERT INTO Projects (Title, Description, DetailedDescription, Technologies, GitHubLink, LiveDemoLink, DisplayOrder) VALUES
('Online Judge System', 'A competitive programming platform similar to Codeforces', 'Built a comprehensive online judge system that allows users to submit solutions in multiple programming languages, automatic judging with test cases, real-time rankings, and contest management features.', 'C#, ASP.NET, SQL Server, JavaScript', 'https://github.com/yourusername/online-judge', 'https://yourproject.com/judge', 1),
('Algorithm Visualizer', 'Interactive visualization tool for sorting and graph algorithms', 'Created an educational tool that visualizes various algorithms including sorting algorithms (Quick Sort, Merge Sort, Heap Sort) and graph algorithms (BFS, DFS, Dijkstra). Helps students understand algorithm execution step by step.', 'JavaScript, HTML5 Canvas, CSS3', 'https://github.com/yourusername/algo-visualizer', 'https://yourproject.com/visualizer', 2),
('Student Management System', 'Complete web application for managing student records', 'Developed a full-stack web application for educational institutions to manage student information, course enrollment, grade tracking, and generate reports. Includes role-based access control for students, teachers, and administrators.', 'ASP.NET Web Forms, C#, SQL Server, Bootstrap', 'https://github.com/yourusername/student-management', '', 3),
('Competitive Programming Helper', 'Chrome extension for competitive programming contests', 'Built a browser extension that enhances the competitive programming experience by providing templates, time tracking, problem parsing, and automatic submission history tracking across multiple platforms.', 'JavaScript, Chrome Extension API, HTML, CSS', 'https://github.com/yourusername/cp-helper', '', 4);

-- Sample Education Data
INSERT INTO Education (Institution, Degree, Department, CGPA, StartDate, EndDate, IsCurrent, Description, DisplayOrder) VALUES
('Khulna University of Engineering & Technology (KUET)', 'Bachelor of Science', 'Computer Science and Engineering', '3.75', '2022-01-01', NULL, 1, 'Currently pursuing B.Sc. in Computer Science and Engineering with focus on software engineering, algorithms, and competitive programming. Active member of KUET Programming Club.', 1),
('Your College Name', 'Higher Secondary Certificate (HSC)', 'Science', '5.00', '2019-06-01', '2021-05-31', 0, 'Completed HSC in Science group with GPA 5.00. Participated in various programming contests and mathematics olympiads during college years.', 2);

-- Sample Achievements Data
INSERT INTO Achievements (Title, Platform, Description, Ranking, AchievedDate, DisplayOrder) VALUES
('Monthly Contest Winner', 'CodeChef', 'Won 1st place in CodeChef monthly contest', '1st Place', '2024-08-15', 1),
('Specialist Rating', 'Codeforces', 'Achieved Specialist rating (1400+) in Codeforces', 'Max Rating: 1456', '2024-07-20', 2),
('ACM ICPC Regional Qualifier', 'ACM ICPC', 'Qualified for ACM ICPC Asia Dhaka Regional Contest', 'Team Rank: 25th', '2024-06-10', 3),
('HackerRank Problem Solving Gold', 'HackerRank', 'Earned Gold badge in Problem Solving domain', 'Gold Badge', '2024-05-15', 4),
('Google Code Jam Qualifier', 'Google Code Jam', 'Successfully qualified for Round 1 of Google Code Jam', 'Qualified', '2024-04-01', 5);

PRINT 'Database setup completed successfully!';
PRINT 'Sample data has been inserted.';
PRINT 'You can now run your ASP.NET application.';

-- Query to verify data
SELECT 'Skills' as TableName, COUNT(*) as RecordCount FROM Skills
UNION ALL
SELECT 'Projects', COUNT(*) FROM Projects
UNION ALL
SELECT 'Education', COUNT(*) FROM Education
UNION ALL
SELECT 'Achievements', COUNT(*) FROM Achievements;