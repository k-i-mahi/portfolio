# ?? Professional Competitive Programmer Portfolio

A modern, responsive ASP.NET Web Forms portfolio website designed specifically for competitive programmers and computer science students. Features a clean, professional design with sections for skills, projects, achievements, education, and contact information.

## ? Features

### ?? Competitive Programming Focus
- **Achievements Section**: Showcase contest wins, ratings, and certifications
- **Skills Display**: Animated progress bars for programming languages and algorithms
- **Project Gallery**: Feature competitive programming projects and tools
- **Education Timeline**: Academic background with CGPA and current status

### ?? Technical Features
- **Responsive Design**: Optimized for desktop, tablet, and mobile devices
- **Database Integration**: SQL Server backend for dynamic content management
- **Admin Panel**: Easy content management system
- **Contact Form**: Functional contact form with validation
- **Modern UI**: Clean, professional design with smooth animations
- **SEO Optimized**: Proper meta tags and semantic HTML structure

### ?? Technology Stack
- **Backend**: ASP.NET Web Forms (.NET Framework 4.8)
- **Database**: SQL Server (LocalDB/Express/Full)
- **Frontend**: HTML5, CSS3, JavaScript
- **Styling**: Custom CSS with CSS Grid and Flexbox
- **Icons**: Font Awesome 6.4.0
- **Fonts**: Inter Google Font

## ??? Setup Instructions

### Prerequisites
- Visual Studio 2019/2022 or Visual Studio Code
- .NET Framework 4.8
- SQL Server (LocalDB, Express, or Full version)
- IIS or IIS Express for hosting

### Quick Start (No Database)
1. **Clone the Repository**
   ```bash
   git clone https://github.com/yourusername/portfolio
   cd portfolio
   ```

2. **Open in Visual Studio**
   - Open `portfolio.sln` in Visual Studio
   - Build the solution (Ctrl+Shift+B)

3. **Run the Application**
   - Press F5 or click "Start Debugging"
   - Navigate to `Simple.aspx` for the demo homepage
   - Navigate to `DefaultSimple.aspx` for the full portfolio without database

### Full Setup (With Database)

1. **Database Setup**
   ```sql
   -- Run the following script in SQL Server Management Studio
   -- File location: Database/setup.sql
   ```
   - Open SQL Server Management Studio
   - Connect to your SQL Server instance
   - Open and execute `Database/setup.sql`
   - This creates the database and inserts sample data

2. **Configure Connection String**
   - Open `Web.config`
   - Update the connection string:
   ```xml
   <connectionStrings>
     <add name="PortfolioConnection" 
          connectionString="Data Source=YOUR_SERVER;Initial Catalog=PortfolioDB;Integrated Security=True" 
          providerName="System.Data.SqlClient" />
   </connectionStrings>
   ```

3. **Test Database Connection**
   - Run the application
   - Navigate to `TestConnection.aspx`
   - Verify database connectivity

4. **Access Full Portfolio**
   - Navigate to `Default.aspx` for the complete experience
   - Access `Admin.aspx` for content management

## ?? Project Structure

```
portfolio/
??? Default.aspx                 # Main portfolio page (with database)
??? DefaultSimple.aspx          # Portfolio page (no database)
??? Simple.aspx                 # Demo homepage
??? Admin.aspx                  # Admin panel
??? TestConnection.aspx         # Database connection test
??? Models/
?   ??? PortfolioModels.cs      # Data models
??? Data/
?   ??? PortfolioDataAccess.cs  # Database access layer
??? Styles/
?   ??? portfolio.css           # Main stylesheet
??? Images/
?   ??? README.txt              # Image folder instructions
??? Database/
?   ??? setup.sql               # Database setup script
??? Web.config                  # Configuration file
```

## ?? Customization Guide

### 1. Personal Information
Update the following files with your information:
- `DefaultSimple.aspx.cs` - Edit the `LoadSampleData()` methods
- `Default.aspx` - Update hero section and about content
- `Styles/portfolio.css` - Customize colors in `:root` variables

### 2. Profile Picture
- Add your photo to the `Images/` folder as `profile.jpg`
- Or update the image path in the about section

### 3. Social Links
Update social media links in:
- About section of `Default.aspx` and `DefaultSimple.aspx`
- `Web.config` app settings for centralized management

### 4. Color Scheme
Modify CSS variables in `portfolio.css`:
```css
:root {
    --primary-color: #2c3e50;    /* Main brand color */
    --secondary-color: #3498db;   /* Accent color */
    --accent-color: #e74c3c;      /* Error/warning color */
    /* ... other colors ... */
}
```

### 5. Content Management
- **With Database**: Use the Admin panel at `Admin.aspx`
- **Without Database**: Edit the sample data in code-behind files

## ?? Sample Data Included

The portfolio comes with realistic sample data for a competitive programmer:

### Skills
- **Programming Languages**: C++, Java, C#, Python, JavaScript
- **Algorithms & DS**: Data Structures, Dynamic Programming, Graph Theory
- **Web Development**: ASP.NET, JavaScript, SQL Server

### Projects
- Online Judge System
- Algorithm Visualizer
- Student Management System

### Achievements
- CodeChef Monthly Contest Winner
- Codeforces Specialist Rating
- ACM ICPC Regional Qualifier
- HackerRank Gold Badge

### Education
- KUET Computer Science & Engineering (Current)
- Higher Secondary Certificate

## ?? Deployment

### IIS Deployment
1. Publish the application from Visual Studio
2. Copy published files to IIS wwwroot directory
3. Configure IIS application pool for .NET Framework 4.8
4. Update connection string for production database

### Hosting Providers
- Works with any ASP.NET hosting provider
- Ensure .NET Framework 4.8 support
- SQL Server database hosting required for full functionality

## ?? Troubleshooting

### Common Issues

1. **Database Connection Error**
   - Verify SQL Server is running
   - Check connection string in Web.config
   - Ensure database exists (run setup.sql)

2. **CSS/JavaScript Not Loading**
   - Check file paths in ASPX files
   - Verify files exist in Styles/ folder
   - Clear browser cache

3. **Build Errors**
   - Ensure .NET Framework 4.8 is installed
   - Check NuGet package references
   - Clean and rebuild solution

### Error Pages
- `Error.aspx` - Custom error page for production
- Enable custom errors in Web.config for production deployment

## ?? License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## ?? Contributing

1. Fork the project
2. Create your feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## ?? Support

If you encounter any issues or have questions:
1. Check the troubleshooting section above
2. Review the database setup script
3. Ensure all prerequisites are installed
4. Open an issue on GitHub

## ?? Demo

- **Live Demo**: [View Demo](https://your-demo-url.com)
- **Screenshots**: See `Images/` folder for sample screenshots
- **Video Tutorial**: [YouTube Tutorial](https://your-tutorial-url.com)

---

**Made with ?? for the competitive programming community**

*This portfolio template is designed to help competitive programmers showcase their skills and achievements in a professional manner. Perfect for job applications, internship submissions, and personal branding.*