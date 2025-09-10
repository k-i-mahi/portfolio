<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Error.aspx.cs" Inherits="Portfolio.Error" %>

<!DOCTYPE html>
<html lang="en">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>Error - Portfolio</title>
    <link href="Styles/portfolio.css" rel="stylesheet" />
    <style>
        .error-container {
            display: flex;
            flex-direction: column;
            align-items: center;
            justify-content: center;
            min-height: 100vh;
            text-align: center;
            padding: 2rem;
        }
        .error-code {
            font-size: 6rem;
            font-weight: 700;
            color: var(--primary-color);
            margin-bottom: 1rem;
        }
        .error-message {
            font-size: 1.5rem;
            color: var(--text-light);
            margin-bottom: 2rem;
        }
        .error-actions {
            display: flex;
            gap: 1rem;
            flex-wrap: wrap;
            justify-content: center;
        }
        .error-btn {
            padding: 12px 24px;
            background: var(--gradient-primary);
            color: white;
            text-decoration: none;
            border-radius: 25px;
            transition: var(--transition);
        }
        .error-btn:hover {
            transform: translateY(-2px);
            box-shadow: var(--shadow);
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="error-container">
            <div class="error-code">
                <asp:Literal ID="litErrorCode" runat="server" Text="404"></asp:Literal>
            </div>
            <div class="error-message">
                <asp:Literal ID="litErrorMessage" runat="server" Text="Oops! The page you're looking for doesn't exist."></asp:Literal>
            </div>
            <div class="error-actions">
                <a href="Default.aspx" class="error-btn">
                    <i class="fas fa-home"></i>
                    Go Home
                </a>
                <a href="javascript:history.back()" class="error-btn">
                    <i class="fas fa-arrow-left"></i>
                    Go Back
                </a>
            </div>
        </div>
    </form>
</body>
</html>