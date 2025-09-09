using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;
using Portfolio.Data;
using Portfolio.Models;

namespace Portfolio
{
    public partial class Default : System.Web.UI.Page
    {
        private PortfolioDataAccess dataAccess = new PortfolioDataAccess();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadPortfolioData();
            }
        }

        private void LoadPortfolioData()
        {
            try
            {
                // Load Skills grouped by category
                LoadSkills();
                
                // Load Projects
                var projects = dataAccess.GetAllProjects();
                rptProjects.DataSource = projects;
                rptProjects.DataBind();

                // Load Education
                var education = dataAccess.GetAllEducation();
                rptEducation.DataSource = education;
                rptEducation.DataBind();

                // Load Achievements
                var achievements = dataAccess.GetAllAchievements();
                rptAchievements.DataSource = achievements;
                rptAchievements.DataBind();
            }
            catch (Exception ex)
            {
                // Handle error - in production, log this properly
                ShowMessage("Error loading portfolio data. Please try again later.", "error");
            }
        }

        private void LoadSkills()
        {
            var skills = dataAccess.GetAllSkills();
            var groupedSkills = skills.GroupBy(s => s.Category).ToList();

            // For this example, we'll create a simple structure
            // In a real application, you might want to use a more sophisticated approach
            var skillsHtml = "";
            
            foreach (var group in groupedSkills)
            {
                skillsHtml += $"<div class='skill-category'><h3>{group.Key}</h3>";
                foreach (var skill in group)
                {
                    skillsHtml += $@"
                        <div class='skill-item'>
                            <div class='skill-name'>
                                <span>{skill.Name}</span>
                                <span>{skill.ProficiencyLevel}%</span>
                            </div>
                            <div class='skill-bar'>
                                <div class='skill-progress' data-width='{skill.ProficiencyLevel}'></div>
                            </div>
                        </div>";
                }
                skillsHtml += "</div>";
            }

            // Find the skills section and inject HTML
            var skillsContainer = Page.FindControl("skills").FindControl("container");
            if (skillsContainer != null)
            {
                var literal = new Literal { Text = skillsHtml };
                skillsContainer.Controls.Add(literal);
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                var contact = new Contact
                {
                    Name = txtName.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    Phone = txtPhone.Text.Trim(),
                    Subject = txtSubject.Text.Trim(),
                    Message = txtMessage.Text.Trim(),
                    CreatedDate = DateTime.Now,
                    IsRead = false
                };

                if (dataAccess.SaveContact(contact))
                {
                    ShowMessage("Thank you for your message! I'll get back to you soon.", "success");
                    ClearContactForm();
                }
                else
                {
                    ShowMessage("Sorry, there was an error sending your message. Please try again.", "error");
                }
            }
            catch (Exception ex)
            {
                ShowMessage("An error occurred while sending your message. Please try again later.", "error");
            }
        }

        private void ShowMessage(string message, string type)
        {
            pnlMessage.Visible = true;
            litMessage.Text = $"<div class='alert alert-{type}'>{message}</div>";
        }

        private void ClearContactForm()
        {
            txtName.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
            txtSubject.Text = "";
            txtMessage.Text = "";
        }
    }
}