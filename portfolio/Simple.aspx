<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Simple.aspx.cs" Inherits="Portfolio.Simple" %>

<!DOCTYPE html>
<html lang="en">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>Portfolio - Working Demo</title>
    <style>
        body { font-family: Arial, sans-serif; margin: 0; padding: 20px; background: #f5f5f5; }
        .container { max-width: 800px; margin: 0 auto; background: white; padding: 30px; border-radius: 10px; box-shadow: 0 0 20px rgba(0,0,0,0.1); }
        h1 { color: #333; text-align: center; margin-bottom: 30px; }
        .demo-links { text-align: center; margin: 20px 0; }
        .demo-links a { display: inline-block; margin: 10px; padding: 15px 30px; background: #007bff; color: white; text-decoration: none; border-radius: 5px; }
        .demo-links a:hover { background: #0056b3; }
        .features { margin: 30px 0; }
        .features h3 { color: #333; border-bottom: 2px solid #007bff; padding-bottom: 10px; }
        .features ul { line-height: 1.8; }
        .status { padding: 15px; margin: 20px 0; border-radius: 5px; }
        .success { background: #d4edda; color: #155724; border: 1px solid #c3e6cb; }
        .info { background: #d1ecf1; color: #0c5460; border: 1px solid #b8daff; }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h1>?? Competitive Programmer Portfolio</h1>
            
            <div class="status success">
                <strong>? Portfolio is Working!</strong> Your ASP.NET Web Forms portfolio is successfully set up and running.
            </div>

            <div class="demo-links">
                <a href="DefaultSimple.aspx">View Full Portfolio (No Database)</a>
                <a href="Default.aspx">View Full Portfolio (With Database)</a>
                <a href="Admin.aspx">Admin Panel</a>
            </div>

            <div class="features">
                <h3>?? Features Included</h3>
                <ul>
                    <li><strong>Professional Design:</strong> Modern, responsive portfolio layout</li>
                    <li><strong>Competitive Programming Focus:</strong> Sections for achievements, contests, and projects</li>
                    <li><strong>Skills Showcase:</strong> Animated skill bars with programming languages and algorithms</li>
                    <li><strong>Project Gallery:</strong> Featured projects with GitHub links and live demos</li>
                    <li><strong>Education Timeline:</strong> Academic background and achievements</li>
                    <li><strong>Contact Form:</strong> Functional contact form with validation</li>
                    <li><strong>Admin Panel:</strong> Content management system</li>
                    <li><strong>Database Integration:</strong> SQL Server backend for dynamic content</li>
                    <li><strong>Mobile Responsive:</strong> Optimized for all devices</li>
                </ul>
            </div>

            <div class="features">
                <h3>?? Sample Data Included</h3>
                <ul>
                    <li><strong>Programming Skills:</strong> C++, Java, C#, Python, JavaScript</li>
                    <li><strong>Algorithm Skills:</strong> Data Structures, Dynamic Programming, Graph Theory</li>
                    <li><strong>Sample Projects:</strong> Online Judge System, Algorithm Visualizer, Student Management</li>
                    <li><strong>Achievements:</strong> CodeChef winner, Codeforces Specialist, ACM ICPC qualifier</li>
                    <li><strong>Education:</strong> KUET CSE student profile</li>
                </ul>
            </div>

            <div class="status info">
                <strong>?? Next Steps:</strong><br/>
                1. Customize the content in DefaultSimple.aspx.cs<br/>
                2. Replace sample data with your actual information<br/>
                3. Add your profile picture to Images folder<br/>
                4. Set up the database using Database/setup.sql for full functionality<br/>
                5. Update social media links and contact information
            </div>

            <div class="features">
                <h3>??? Technical Stack</h3>
                <ul>
                    <li><strong>Backend:</strong> ASP.NET Web Forms (.NET Framework 4.8)</li>
                    <li><strong>Database:</strong> SQL Server (LocalDB/Express)</li>
                    <li><strong>Frontend:</strong> HTML5, CSS3, JavaScript</li>
                    <li><strong>Styling:</strong> Custom CSS with modern design patterns</li>
                    <li><strong>Icons:</strong> Font Awesome integration</li>
                    <li><strong>Fonts:</strong> Inter Google Font</li>
                </ul>
            </div>
        </div>
    </form>
</body>
</html>