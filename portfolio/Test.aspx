<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Test.aspx.cs" Inherits="Portfolio.Test" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Basic Test Page</title>
    <style>
        body { font-family: Arial, sans-serif; margin: 40px; background: #f0f0f0; }
        .container { background: white; padding: 20px; border-radius: 5px; box-shadow: 0 2px 10px rgba(0,0,0,0.1); }
        h1 { color: #333; }
        .success { color: green; background: #d4edda; padding: 10px; border-radius: 5px; margin: 10px 0; }
        .error { color: red; background: #f8d7da; padding: 10px; border-radius: 5px; margin: 10px 0; }
        .info { color: blue; background: #d1ecf1; padding: 10px; border-radius: 5px; margin: 10px 0; }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h1>Portfolio Website - Basic Test</h1>
            
            <div class="success">
                <strong>? ASP.NET is Working!</strong><br/>
                Server Time: <%= DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") %><br/>
                .NET Framework Version: <%= System.Environment.Version %>
            </div>

            <div class="info">
                <strong>Testing Basic Functionality:</strong><br/>
                <asp:Label ID="lblTest" runat="server" Text="Server-side code is working!"></asp:Label>
            </div>

            <div class="info">
                <strong>Application Path:</strong> <%= Request.ApplicationPath %><br/>
                <strong>Physical Path:</strong> <%= Request.PhysicalApplicationPath %><br/>
                <strong>Server Name:</strong> <%= Request.ServerVariables["SERVER_NAME"] %><br/>
                <strong>Request URL:</strong> <%= Request.Url %>
            </div>

            <hr/>
            
            <h3>Quick Links:</h3>
            <ul>
                <li><a href="Default.aspx">Main Portfolio Page</a></li>
                <li><a href="TestConnection.aspx">Database Connection Test</a></li>
                <li><a href="Admin.aspx">Admin Panel</a></li>
            </ul>

            <h3>Troubleshooting Steps:</h3>
            <ol>
                <li>If you see this page, ASP.NET is working correctly</li>
                <li>Try the links above to test other pages</li>
                <li>Check browser developer tools (F12) for JavaScript errors</li>
                <li>Run the Database Connection Test if main page doesn't work</li>
            </ol>
        </div>
    </form>
</body>
</html>