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
                // Load Projects
                var projects = dataAccess.GetAllProjects();
                var rptProjects = (Repeater)FindControl("rptProjects");
                if (rptProjects != null)
                {
                    rptProjects.DataSource = projects;
                    rptProjects.DataBind();
                }

                // Load Education
                var education = dataAccess.GetAllEducation();
                var rptEducation = (Repeater)FindControl("rptEducation");
                if (rptEducation != null)
                {
                    rptEducation.DataSource = education;
                    rptEducation.DataBind();
                }

                // Load Achievements
                var achievements = dataAccess.GetAllAchievements();
                var rptAchievements = (Repeater)FindControl("rptAchievements");
                if (rptAchievements != null)
                {
                    rptAchievements.DataSource = achievements;
                    rptAchievements.DataBind();
                }

                // Load Skills - we'll create a custom implementation for skills
                LoadSkillsSection();
            }
            catch (Exception ex)
            {
                // Handle error - in production, log this properly
                ShowMessage("Error loading portfolio data. Please try again later.", "error");
            }
        }

        private void LoadSkillsSection()
        {
            try
            {
                var skills = dataAccess.GetAllSkills();
                var groupedSkills = skills.GroupBy(s => s.Category).ToList();

                // Create HTML for skills section
                string skillsHtml = "";
                
                foreach (var group in groupedSkills)
                {
                    skillsHtml += $"<div class='skill-category'><h3>{group.Key}</h3>";
                    foreach (var skill in group.OrderBy(s => s.DisplayOrder))
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

                // Add the HTML to the skills container
                var skillsGrid = FindControl("skills-grid");
                if (skillsGrid != null)
                {
                    var literal = new Literal { Text = skillsHtml };
                    skillsGrid.Controls.Add(literal);
                }
            }
            catch (Exception ex)
            {
                // If skills loading fails, add default message
                var skillsGrid = FindControl("skills-grid");
                if (skillsGrid != null)
                {
                    var literal = new Literal { Text = "<div class='skill-category'><h3>Loading Skills...</h3><p>Skills data will be available once the database is configured.</p></div>" };
                    skillsGrid.Controls.Add(literal);
                }
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                var txtName = (TextBox)FindControl("txtName");
                var txtEmail = (TextBox)FindControl("txtEmail");
                var txtPhone = (TextBox)FindControl("txtPhone");
                var txtSubject = (TextBox)FindControl("txtSubject");
                var txtMessage = (TextBox)FindControl("txtMessage");

                if (txtName != null && txtEmail != null && txtMessage != null)
                {
                    var contact = new Contact
                    {
                        Name = txtName.Text.Trim(),
                        Email = txtEmail.Text.Trim(),
                        Phone = txtPhone?.Text.Trim() ?? "",
                        Subject = txtSubject?.Text.Trim() ?? "",
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
            }
            catch (Exception ex)
            {
                ShowMessage("An error occurred while sending your message. Please try again later.", "error");
            }
        }

        private void ShowMessage(string message, string type)
        {
            var pnlMessage = (Panel)FindControl("pnlMessage");
            var litMessage = (Literal)FindControl("litMessage");
            
            if (pnlMessage != null && litMessage != null)
            {
                pnlMessage.Visible = true;
                litMessage.Text = $"<div class='alert alert-{type}'>{message}</div>";
            }
        }

        private void ClearContactForm()
        {
            var txtName = (TextBox)FindControl("txtName");
            var txtEmail = (TextBox)FindControl("txtEmail");
            var txtPhone = (TextBox)FindControl("txtPhone");
            var txtSubject = (TextBox)FindControl("txtSubject");
            var txtMessage = (TextBox)FindControl("txtMessage");

            if (txtName != null) txtName.Text = "";
            if (txtEmail != null) txtEmail.Text = "";
            if (txtPhone != null) txtPhone.Text = "";
            if (txtSubject != null) txtSubject.Text = "";
            if (txtMessage != null) txtMessage.Text = "";
        }
    }
}