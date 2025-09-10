using System;
using System.Web.UI;

namespace Portfolio
{
    public partial class Error : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Get error information from query string or session
            string errorCode = Request.QueryString["code"] ?? "404";
            string errorMessage = GetErrorMessage(errorCode);
            
            var litErrorCode = (System.Web.UI.WebControls.Literal)FindControl("litErrorCode");
            var litErrorMessage = (System.Web.UI.WebControls.Literal)FindControl("litErrorMessage");
            
            if (litErrorCode != null)
                litErrorCode.Text = errorCode;
                
            if (litErrorMessage != null)
                litErrorMessage.Text = errorMessage;
        }
        
        private string GetErrorMessage(string errorCode)
        {
            switch (errorCode)
            {
                case "404":
                    return "Oops! The page you're looking for doesn't exist.";
                case "500":
                    return "Sorry, something went wrong on our end. Please try again later.";
                case "403":
                    return "You don't have permission to access this resource.";
                default:
                    return "An unexpected error occurred. Please try again.";
            }
        }
    }
}