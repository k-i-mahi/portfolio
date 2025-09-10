using System;
using System.Web.UI;
using System.Web.UI.WebControls;
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
                // Load all data for admin review using FindControl
                var gvProjects = (GridView)FindControl("gvProjects");
                if (gvProjects != null)
                {
                    gvProjects.DataSource = dataAccess.GetAllProjects();
                    gvProjects.DataBind();
                }

                var gvSkills = (GridView)FindControl("gvSkills");
                if (gvSkills != null)
                {
                    gvSkills.DataSource = dataAccess.GetAllSkills();
                    gvSkills.DataBind();
                }

                var gvAchievements = (GridView)FindControl("gvAchievements");
                if (gvAchievements != null)
                {
                    gvAchievements.DataSource = dataAccess.GetAllAchievements();
                    gvAchievements.DataBind();
                }

                var gvContacts = (GridView)FindControl("gvContacts");
                if (gvContacts != null)
                {
                    gvContacts.DataSource = dataAccess.GetAllContacts();
                    gvContacts.DataBind();
                }
            }
            catch (Exception ex)
            {
                // Handle error
                Response.Write("<script>alert('Error loading admin data: " + ex.Message.Replace("'", "\\'") + "');</script>");
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