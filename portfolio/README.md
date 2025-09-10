# Khadimul Islam Mahi - Portfolio Website

## ?? ASP.NET Web Forms Portfolio

A modern, responsive portfolio website built with ASP.NET Web Forms (.NET Framework 4.8) showcasing competitive programming achievements, projects, and technical expertise.

## ? Features

- **Responsive Design**: Mobile-first approach with modern CSS Grid and Flexbox
- **Dark/Light Theme**: Toggle between themes with smooth transitions
- **Interactive Animations**: CSS animations and transitions for enhanced UX
- **Dynamic Content**: Server-side data loading with C# code-behind
- **Contact Form**: Functional contact form with validation
- **Performance Optimized**: Efficient loading and rendering

## ??? Technology Stack

- **Backend**: ASP.NET Web Forms, C# (.NET Framework 4.8)
- **Frontend**: HTML5, CSS3, JavaScript (ES6+)
- **Styling**: CSS Custom Properties, CSS Grid, Flexbox
- **Icons**: Font Awesome 6.4.0
- **Fonts**: Google Fonts (Poppins, JetBrains Mono)

## ?? Project Structure

```
portfolio/
??? DefaultSimple.aspx          # Main page markup
??? DefaultSimple.aspx.cs       # Code-behind with data loading
??? Web.config                  # Application configuration
??? Styles/
?   ??? portfolio.css          # Main stylesheet
?   ??? additional.css         # Additional styles and fixes
??? Images/                    # Image assets (add your photos here)
```

## ?? Getting Started

### Prerequisites
- Visual Studio 2019 or later
- .NET Framework 4.8
- IIS Express (comes with Visual Studio)

### Setup Instructions

1. **Clone or Download** the project to your local machine

2. **Open in Visual Studio**
   - Open `portfolio.csproj` or the solution file
   - Or use "Open Folder" in Visual Studio

3. **Add Your Images** (Optional)
   - Place your profile photo in `Images/profile.jpg`
   - Add project screenshots to the `Images/` folder
   - Update image paths in the code if needed

4. **Customize Content**
   - Edit `DefaultSimple.aspx.cs` to update:
     - Personal information
     - Skills and proficiency levels
     - Projects and descriptions
     - Achievements and dates
     - Social media links

5. **Run the Project**
   - Press `F5` or click "IIS Express" in Visual Studio
   - The website will open in your default browser

### Configuration

Update these key areas in `DefaultSimple.aspx.cs`:

- **Personal Info**: Name, university, contact details
- **Skills**: Programming languages, frameworks, tools
- **Projects**: GitHub links, live demos, descriptions
- **Achievements**: Competitions, awards, rankings
- **Social Links**: Update URLs to your profiles

## ?? Customization

### Themes and Colors
- Modify CSS custom properties in `portfolio.css`
- Color schemes defined in `:root` and `[data-theme="dark"]`

### Content Updates
- All content is dynamically loaded from C# code-behind
- No database required - uses in-memory data structures
- Easy to extend with database integration later

### Styling
- Responsive breakpoints: 1024px, 768px, 480px
- CSS Grid for layouts, Flexbox for components
- Smooth animations with CSS transitions

## ?? Features in Detail

### Interactive Elements
- **Theme Toggle**: Persistent theme selection
- **Smooth Scrolling**: Navigation with active section highlighting
- **Animated Counters**: Statistics with counting animation
- **Particle System**: Dynamic background particles
- **Typing Effect**: Animated text in hero section

### Contact Form
- **Validation**: Client and server-side validation
- **Responsive**: Mobile-friendly form layout
- **Feedback**: Success/error messages
- **Demo Mode**: Currently logs to debug console

### Performance
- **Optimized Images**: Lazy loading and fallbacks
- **Compressed CSS**: Efficient stylesheets
- **Minimal JavaScript**: Vanilla JS, no external libraries
- **Fast Loading**: Optimized for quick initial load

## ?? Deployment Options

### IIS Deployment
1. Publish from Visual Studio
2. Copy files to IIS web directory
3. Configure application pool for .NET 4.8

### Azure Deployment
1. Right-click project ? Publish
2. Select Azure App Service
3. Follow publishing wizard

### Local Testing
- Use IIS Express (default)
- Or configure local IIS with .NET Framework 4.8

## ?? Browser Support

- **Modern Browsers**: Chrome 90+, Firefox 88+, Safari 14+, Edge 90+
- **Mobile**: iOS Safari, Android Chrome
- **Features**: CSS Grid, Flexbox, Custom Properties
- **Fallbacks**: Graceful degradation for older browsers

## ?? Contributing

This is a personal portfolio template. Feel free to:
- Fork for your own portfolio
- Submit improvements via pull requests
- Report bugs or suggest features

## ?? License

This project is open source. Feel free to use as a template for your own portfolio.

## ?? Links

- **GitHub**: https://github.com/k-i-mahi/portfolio
- **LinkedIn**: https://linkedin.com/in/khadimul-islam-mahi
- **Email**: khadimul.mahi@kuet.ac.bd

## ? Quick Start Checklist

- [x] Open project in Visual Studio
- [x] Update personal information in `DefaultSimple.aspx.cs`
- [ ] Add your profile photo to `Images/profile.jpg`
- [x] Update social media links
- [ ] Customize colors/themes if desired
- [ ] Test all functionality locally
- [ ] Deploy to your hosting platform

---

**Built with ?? by Khadimul Islam Mahi using ASP.NET and modern web technologies****Built with ?? using ASP.NET and modern web technologies**