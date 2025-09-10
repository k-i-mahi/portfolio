<%@ Application Language="C#" %>

<script runat="server">

    void Application_Start(object sender, EventArgs e) 
    {
        // Code that runs on application startup
    }
    
    void Application_End(object sender, EventArgs e) 
    {
        // Code that runs on application shutdown
    }
        
    void Application_Error(object sender, EventArgs e) 
    {
        // Code that runs when an unhandled error occurs
        Exception ex = Server.GetLastError();
        
        // Log error (in production, use proper logging framework)
        System.Diagnostics.Debug.WriteLine("Application Error: " + ex.Message);
        
        // Clear the error
        Server.ClearError();
        
        // Redirect to error page (optional)
        // Response.Redirect("~/Error.aspx");
    }

    void Session_Start(object sender, EventArgs e) 
    {
        // Code that runs when a new session is started
    }

    void Session_End(object sender, EventArgs e) 
    {
        // Code that runs when a session ends. 
        // Note: The Session_End event is raised only when the sessionstate mode
        // is set to InProc in the Web.config file. If session mode is set to StateServer 
        // or SQLServer, the event is not raised.
    }
       
</script>