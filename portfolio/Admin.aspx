<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="Portfolio.Admin" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Portfolio Admin Panel</title>
    <link href="Styles/portfolio.css" rel="stylesheet" />
    <style>
        .admin-container {
            max-width: 1200px;
            margin: 20px auto;
            padding: 20px;
        }
        .admin-section {
            background: white;
            margin: 20px 0;
            padding: 20px;
            border-radius: 10px;
            box-shadow: 0 2px 10px rgba(0,0,0,0.1);
        }
        .admin-grid {
            width: 100%;
            border-collapse: collapse;
        }
        .admin-grid th, .admin-grid td {
            padding: 10px;
            text-align: left;
            border-bottom: 1px solid #ddd;
        }
        .admin-grid th {
            background-color: #f8f9fa;
        }
        .btn {
            padding: 8px 16px;
            margin: 2px;
            border: none;
            border-radius: 4px;
            cursor: pointer;
        }
        .btn-primary { background-color: #007bff; color: white; }
        .btn-danger { background-color: #dc3545; color: white; }
        .btn-success { background-color: #28a745; color: white; }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="admin-container">
            <h1>Portfolio Admin Panel</h1>
            
            <div class="admin-section">
                <h2>Quick Actions</h2>
                <asp:Button ID="btnViewSite" runat="server" Text="View Portfolio Site" CssClass="btn btn-primary" OnClick="btnViewSite_Click" />
                <asp:Button ID="btnRefreshData" runat="server" Text="Refresh Data" CssClass="btn btn-success" OnClick="btnRefreshData_Click" />
            </div>

            <div class="admin-section">
                <h2>Projects Management</h2>
                <asp:GridView ID="gvProjects" runat="server" CssClass="admin-grid" AutoGenerateColumns="false" 
                    EmptyDataText="No projects found. Add some projects to display here.">
                    <Columns>
                        <asp:BoundField DataField="Title" HeaderText="Title" />
                        <asp:BoundField DataField="Technologies" HeaderText="Technologies" />
                        <asp:BoundField DataField="CreatedDate" HeaderText="Created" DataFormatString="{0:MM/dd/yyyy}" />
                        <asp:CheckBoxField DataField="IsActive" HeaderText="Active" />
                    </Columns>
                </asp:GridView>
            </div>

            <div class="admin-section">
                <h2>Skills Management</h2>
                <asp:GridView ID="gvSkills" runat="server" CssClass="admin-grid" AutoGenerateColumns="false"
                    EmptyDataText="No skills found. Add some skills to display here.">
                    <Columns>
                        <asp:BoundField DataField="Name" HeaderText="Skill Name" />
                        <asp:BoundField DataField="Category" HeaderText="Category" />
                        <asp:BoundField DataField="ProficiencyLevel" HeaderText="Level %" />
                        <asp:CheckBoxField DataField="IsActive" HeaderText="Active" />
                    </Columns>
                </asp:GridView>
            </div>

            <div class="admin-section">
                <h2>Achievements Management</h2>
                <asp:GridView ID="gvAchievements" runat="server" CssClass="admin-grid" AutoGenerateColumns="false"
                    EmptyDataText="No achievements found. Add some achievements to display here.">
                    <Columns>
                        <asp:BoundField DataField="Title" HeaderText="Achievement" />
                        <asp:BoundField DataField="Platform" HeaderText="Platform" />
                        <asp:BoundField DataField="Ranking" HeaderText="Ranking" />
                        <asp:BoundField DataField="AchievedDate" HeaderText="Date" DataFormatString="{0:MM/dd/yyyy}" />
                        <asp:CheckBoxField DataField="IsActive" HeaderText="Active" />
                    </Columns>
                </asp:GridView>
            </div>

            <div class="admin-section">
                <h2>Contact Messages</h2>
                <asp:GridView ID="gvContacts" runat="server" CssClass="admin-grid" AutoGenerateColumns="false"
                    EmptyDataText="No contact messages yet.">
                    <Columns>
                        <asp:BoundField DataField="Name" HeaderText="Name" />
                        <asp:BoundField DataField="Email" HeaderText="Email" />
                        <asp:BoundField DataField="Subject" HeaderText="Subject" />
                        <asp:BoundField DataField="CreatedDate" HeaderText="Date" DataFormatString="{0:MM/dd/yyyy HH:mm}" />
                        <asp:CheckBoxField DataField="IsRead" HeaderText="Read" />
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </form>
</body>
</html>