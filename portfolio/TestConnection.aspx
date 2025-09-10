<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestConnection.aspx.cs" Inherits="Portfolio.TestConnection" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Database Connection Test</title>
    <style>
        body { font-family: Arial, sans-serif; margin: 40px; }
        .success { color: green; background: #d4edda; padding: 15px; border-radius: 5px; margin: 10px 0; }
        .error { color: red; background: #f8d7da; padding: 15px; border-radius: 5px; margin: 10px 0; }
        .info { color: blue; background: #d1ecf1; padding: 15px; border-radius: 5px; margin: 10px 0; }
        table { border-collapse: collapse; width: 100%; margin-top: 20px; }
        th, td { border: 1px solid #ddd; padding: 8px; text-align: left; }
        th { background-color: #f2f2f2; }
        .btn { background: #007bff; color: white; padding: 10px 20px; border: none; border-radius: 5px; cursor: pointer; margin: 5px; }
        .btn:hover { background: #0056b3; }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Portfolio Database Connection Test</h1>
        
        <div class="info">
            <h3>Instructions:</h3>
            <ol>
                <li>First, run the SQL script from <code>Database/setup.sql</code> in SQL Server Management Studio</li>
                <li>Update the connection string in <code>Web.config</code> if needed</li>
                <li>Click "Test Connection" to verify database connectivity</li>
                <li>Click "Test Data" to verify sample data is loaded</li>
            </ol>
        </div>

        <asp:Button ID="btnTestConnection" runat="server" Text="Test Connection" CssClass="btn" OnClick="btnTestConnection_Click" />
        <asp:Button ID="btnTestData" runat="server" Text="Test Data" CssClass="btn" OnClick="btnTestData_Click" />
        <asp:Button ID="btnGoToPortfolio" runat="server" Text="Go to Portfolio" CssClass="btn" OnClick="btnGoToPortfolio_Click" />

        <asp:Panel ID="pnlResults" runat="server">
            <asp:Literal ID="litResults" runat="server"></asp:Literal>
        </asp:Panel>
    </form>
</body>
</html>