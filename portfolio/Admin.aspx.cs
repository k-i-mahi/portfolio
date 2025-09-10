using System;
using System.Web.UI;
using Portfolio.Data;

namespace Portfolio
{
    public partial class Admin : System.Web.UI.Page
    {
        private PortfolioDataAccess dataAccess = new PortfolioDataAccess();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadAdminData();
            }
        }

        private void LoadAdminData()
        {
            try
            {
                // Load all data for admin review
                gvProjects.DataSource = dataAccess.GetAllProjects();
                gvProjects.DataBind();

                gvSkills.DataSource = dataAccess.GetAllSkills();
                gvSkills.DataBind();

                gvAchievements.DataSource = dataAccess.GetAllAchievements();
                gvAchievements.DataBind();

                // Load contacts
                gvContacts.DataSource = dataAccess.GetAllContacts();
                gvContacts.DataBind();
            }
            catch (Exception ex)
            {
                // Handle error
                Response.Write("<script>alert('Error loading admin data: " + ex.Message + "');</script>");
            }
        }

        protected void btnViewSite_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        protected void btnRefreshData_Click(object sender, EventArgs e)
        {
            LoadAdminData();
        }
    }
}