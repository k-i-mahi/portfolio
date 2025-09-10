using System;

namespace Portfolio
{
    public partial class Test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Simple test to verify server-side code is working
            if (!IsPostBack)
            {
                var lblTest = (System.Web.UI.WebControls.Label)FindControl("lblTest");
                if (lblTest != null)
                {
                    lblTest.Text = "? Server-side code is working! Page loaded successfully at " + DateTime.Now.ToString("HH:mm:ss");
                }
            }
        }
    }
}