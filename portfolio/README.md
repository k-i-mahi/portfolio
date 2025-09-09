# Professional Portfolio Website

A professional single-page portfolio website built with ASP.NET Web Forms and MS SQL Server, specifically designed for competitive programmers and software developers.

## ?? Features

- **Responsive Single-Page Design**: Modern, professional layout that works on all devices
- **Dynamic Content Management**: All content is stored in SQL Server and can be easily updated
- **Competitive Programming Focus**: Special sections for achievements, contest results, and rankings
- **Contact Form**: Functional contact form with database storage
- **Admin Panel**: Simple admin interface to manage content
- **Professional Styling**: Clean, modern CSS with smooth animations and transitions

## ?? Sections Included

1. **Hero Section**: Eye-catching introduction with call-to-action
2. **About Me**: Personal introduction with social media links
3. **Technical Skills**: Interactive skill bars with proficiency levels
4. **Featured Projects**: Showcase of your best projects with links
5. **Education**: Timeline view of educational background
6. **Achievements**: Competitive programming accomplishments and rankings
7. **Contact**: Working contact form for potential employers/collaborators

## ??? Technologies Used

- **Backend**: ASP.NET Web Forms (.NET Framework 4.8)
- **Database**: Microsoft SQL Server
- **Frontend**: HTML5, CSS3, JavaScript
- **Icons**: Font Awesome
- **Styling**: Custom CSS with modern design principles

## ?? Project Structure

```
portfolio/
?
??? Default.aspx              # Main portfolio page
??? Default.aspx.cs           # Code-behind for main page
??? Admin.aspx                # Admin panel for content management
??? Admin.aspx.cs             # Code-behind for admin panel
??? Web.config                # Application configuration
?
??? Models/
?   ??? PortfolioModels.cs    # Data models (Project, Skill, Achievement, etc.)
?
??? Data/
?   ??? PortfolioDataAccess.cs # Database access layer
?
??? Styles/
?   ??? portfolio.css         # Main stylesheet
?
??? Images/
?   ??? README.txt            # Guidelines for images
?
??? Database/
    ??? setup.sql             # Database creation and sample data script
```

## ?? Setup Instructions

### 1. Database Setup

1. Open SQL Server Management Studio
2. Run the script in `Database/setup.sql`
3. This will create the `PortfolioDB` database with all necessary tables and sample data

### 2. Connection String Configuration

1. Open `Web.config`
2. Update the connection string to match your SQL Server instance:
   ```xml
   <connectionStrings>
     <add name="PortfolioConnection" 
          connectionString="Data Source=YOUR_SERVER;Initial Catalog=PortfolioDB;Integrated Security=True" 
          providerName="System.Data.SqlClient" />
   </connectionStrings>
   ```

### 3. Customize Your Information

1. **Update Web.config App Settings**:
   ```xml
   <appSettings>
     <add key="AdminEmail" value="your-email@example.com" />
     <add key="LinkedInProfile" value="https://www.linkedin.com/in/your-profile" />
     <add key="GitHubProfile" value="https://github.com/your-username" />
     <add key="CodeChefProfile" value="https://www.codechef.com/users/your-username" />
     <add key="CodeforcesProfile" value="https://codeforces.com/profile/your-username" />
   </appSettings>
   ```

2. **Update Default.aspx**:
   - Replace "Your Name" with your actual name
   - Update the hero section content
   - Update social media links in the about section

3. **Add Your Photos**:
   - Add your professional photo as `Images/profile.jpg` (300x300px recommended)
   - Add project screenshots to the `Images/` folder

### 4. Build and Run

1. Open the project in Visual Studio
2. Build the solution (Ctrl+Shift+B)
3. Run the project (F5)

## ?? Managing Your Content

### Using the Database Directly

You can add/edit your portfolio content by directly modifying the database tables:

- **Skills**: Add your technical skills with proficiency levels
- **Projects**: Showcase your best projects with descriptions and links
- **Education**: Add your educational background
- **Achievements**: List your competitive programming achievements
- **Contacts**: View messages from the contact form

### Using the Admin Panel

Visit `/Admin.aspx` to view and manage your portfolio content through a simple web interface.

## ?? Customization

### Colors and Styling

The main color scheme uses gradients from blue to purple. To customize:

1. Open `Styles/portfolio.css`
2. Look for gradient definitions like:
   ```css
   background: linear-gradient(135deg, #667eea 0%, #764ba2 100%);
   ```
3. Replace with your preferred colors

### Adding New Sections

To add new sections:

1. Create new model classes in `Models/PortfolioModels.cs`
2. Add corresponding database tables
3. Update `Data/PortfolioDataAccess.cs` with new methods
4. Add the section HTML to `Default.aspx`
5. Update the code-behind in `Default.aspx.cs`

## ?? Security Considerations

- Add input validation and sanitization
- Implement proper authentication for admin panel
- Use parameterized queries (already implemented)
- Add HTTPS in production
- Implement rate limiting for contact form

## ?? Responsive Design

The portfolio is fully responsive and works on:
- Desktop computers
- Tablets
- Mobile phones

## ?? Deployment

### IIS Deployment

1. Publish the project from Visual Studio
2. Copy files to IIS web directory
3. Configure IIS application pool for .NET Framework 4.8
4. Ensure SQL Server connection is accessible from web server

### Hosting Considerations

- Ensure hosting provider supports ASP.NET Web Forms and .NET Framework 4.8
- SQL Server database hosting required
- Configure connection strings for production environment

## ?? Future Enhancements

- Add authentication system for admin panel
- Implement blog functionality
- Add more interactive elements
- Integrate with competitive programming APIs for live stats
- Add email notifications for contact form submissions
- Implement SEO optimizations

## ?? Contributing

Feel free to fork this project and customize it for your own portfolio needs!

## ?? License

This project is open source and available under the MIT License.

---

**Built with ?? for competitive programmers and software developers**