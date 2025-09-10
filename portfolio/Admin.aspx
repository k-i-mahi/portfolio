<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="Portfolio.Admin" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Portfolio Admin Panel - Khadimul Islam Mahi</title>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <link href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.4.0/css/all.min.css" rel="stylesheet" />
    <link href="https://fonts.googleapis.com/css2?family=Poppins:wght@300;400;500;600;700&display=swap" rel="stylesheet" />
    
    <style>
        * {
            margin: 0;
            padding: 0;
            box-sizing: border-box;
        }

        body {
            font-family: 'Poppins', sans-serif;
            background: linear-gradient(135deg, #f5f7fa 0%, #c3cfe2 100%);
            min-height: 100vh;
            color: #333;
        }

        .admin-container {
            max-width: 1400px;
            margin: 0 auto;
            padding: 20px;
        }

        .admin-header {
            background: linear-gradient(135deg, #667eea 0%, #764ba2 100%);
            color: white;
            padding: 30px;
            border-radius: 15px;
            margin-bottom: 30px;
            text-align: center;
            box-shadow: 0 10px 30px rgba(0,0,0,0.1);
        }

        .admin-header h1 {
            font-size: 2.5rem;
            margin-bottom: 10px;
            font-weight: 700;
        }

        .admin-header p {
            font-size: 1.1rem;
            opacity: 0.9;
        }

        .admin-tabs {
            display: flex;
            background: white;
            border-radius: 15px;
            padding: 10px;
            margin-bottom: 30px;
            box-shadow: 0 5px 20px rgba(0,0,0,0.1);
            flex-wrap: wrap;
            gap: 5px;
        }

        .tab-btn {
            flex: 1;
            padding: 15px 20px;
            border: none;
            background: transparent;
            border-radius: 10px;
            cursor: pointer;
            font-weight: 500;
            transition: all 0.3s ease;
            display: flex;
            align-items: center;
            justify-content: center;
            gap: 8px;
            min-width: 160px;
        }

        .tab-btn:hover {
            background: #f8f9fa;
            transform: translateY(-2px);
        }

        .tab-btn.active {
            background: linear-gradient(135deg, #667eea 0%, #764ba2 100%);
            color: white;
            box-shadow: 0 5px 15px rgba(102, 126, 234, 0.3);
        }

        .admin-section {
            background: white;
            border-radius: 15px;
            padding: 30px;
            margin-bottom: 30px;
            box-shadow: 0 5px 20px rgba(0,0,0,0.1);
            display: none;
        }

        .admin-section.active {
            display: block;
            animation: fadeIn 0.5s ease-in-out;
        }

        @keyframes fadeIn {
            from { opacity: 0; transform: translateY(20px); }
            to { opacity: 1; transform: translateY(0); }
        }

        .section-header {
            display: flex;
            justify-content: space-between;
            align-items: center;
            margin-bottom: 25px;
            padding-bottom: 15px;
            border-bottom: 2px solid #f1f3f4;
        }

        .section-title {
            font-size: 1.8rem;
            font-weight: 600;
            color: #333;
            display: flex;
            align-items: center;
            gap: 10px;
        }

        .btn {
            padding: 12px 24px;
            border: none;
            border-radius: 8px;
            cursor: pointer;
            font-weight: 500;
            font-size: 0.95rem;
            transition: all 0.3s ease;
            display: inline-flex;
            align-items: center;
            gap: 8px;
            text-decoration: none;
            color: white;
        }

        .btn:hover {
            transform: translateY(-2px);
            box-shadow: 0 5px 15px rgba(0,0,0,0.2);
        }

        .btn-primary { 
            background: linear-gradient(135deg, #667eea 0%, #764ba2 100%); 
        }
        
        .btn-success { 
            background: linear-gradient(135deg, #56ab2f 0%, #a8e6cf 100%); 
        }
        
        .btn-danger { 
            background: linear-gradient(135deg, #ff416c 0%, #ff4b2b 100%); 
        }
        
        .btn-warning { 
            background: linear-gradient(135deg, #f7971e 0%, #ffd200 100%); 
            color: #333;
        }
        
        .btn-info { 
            background: linear-gradient(135deg, #00c6ff 0%, #0072ff 100%); 
        }

        .btn-sm {
            padding: 8px 16px;
            font-size: 0.85rem;
        }

        .data-grid {
            width: 100%;
            border-collapse: collapse;
            margin-top: 20px;
            background: white;
            border-radius: 10px;
            overflow: hidden;
            box-shadow: 0 3px 15px rgba(0,0,0,0.1);
        }

        .data-grid th {
            background: linear-gradient(135deg, #667eea 0%, #764ba2 100%);
            color: white;
            padding: 15px;
            text-align: left;
            font-weight: 600;
            font-size: 0.95rem;
        }

        .data-grid td {
            padding: 15px;
            border-bottom: 1px solid #f1f3f4;
            vertical-align: top;
        }

        .data-grid tr:hover {
            background: #f8f9fa;
        }

        .form-container {
            background: #f8f9fa;
            padding: 25px;
            border-radius: 10px;
            margin: 20px 0;
            border: 2px dashed #dee2e6;
        }

        .form-row {
            display: grid;
            grid-template-columns: repeat(auto-fit, minmax(300px, 1fr));
            gap: 20px;
            margin-bottom: 20px;
        }

        .form-group {
            margin-bottom: 20px;
        }

        .form-label {
            display: block;
            margin-bottom: 8px;
            font-weight: 500;
            color: #555;
            font-size: 0.95rem;
        }

        .form-control {
            width: 100%;
            padding: 12px 15px;
            border: 2px solid #e1e5e9;
            border-radius: 8px;
            font-size: 0.95rem;
            transition: all 0.3s ease;
            background: white;
        }

        .form-control:focus {
            outline: none;
            border-color: #667eea;
            box-shadow: 0 0 0 3px rgba(102, 126, 234, 0.1);
        }

        textarea.form-control {
            resize: vertical;
            min-height: 100px;
        }

        .stats-cards {
            display: grid;
            grid-template-columns: repeat(auto-fit, minmax(250px, 1fr));
            gap: 20px;
            margin-bottom: 30px;
        }

        .stat-card {
            background: white;
            padding: 25px;
            border-radius: 15px;
            text-align: center;
            box-shadow: 0 5px 20px rgba(0,0,0,0.1);
            border-left: 5px solid #667eea;
            transition: transform 0.3s ease;
        }

        .stat-card:hover {
            transform: translateY(-5px);
        }

        .stat-number {
            font-size: 2.5rem;
            font-weight: 700;
            color: #667eea;
            margin-bottom: 10px;
        }

        .stat-label {
            font-size: 1.1rem;
            color: #666;
            font-weight: 500;
        }

        .alert {
            padding: 15px 20px;
            border-radius: 10px;
            margin: 20px 0;
            font-weight: 500;
            display: none;
        }

        .alert.show {
            display: block;
            animation: slideIn 0.3s ease-out;
        }

        @keyframes slideIn {
            from { transform: translateX(-100%); opacity: 0; }
            to { transform: translateX(0); opacity: 1; }
        }

        .alert-success {
            background: #d4edda;
            border: 1px solid #c3e6cb;
            color: #155724;
        }

        .alert-danger {
            background: #f8d7da;
            border: 1px solid #f5c6cb;
            color: #721c24;
        }

        .alert-info {
            background: #cce7ff;
            border: 1px solid #b3d9ff;
            color: #004085;
        }

        .quick-actions {
            display: grid;
            grid-template-columns: repeat(auto-fit, minmax(200px, 1fr));
            gap: 15px;
            margin-bottom: 30px;
        }

        .action-card {
            background: white;
            padding: 20px;
            border-radius: 10px;
            text-align: center;
            box-shadow: 0 3px 15px rgba(0,0,0,0.1);
            transition: all 0.3s ease;
            cursor: pointer;
            border: 2px solid transparent;
        }

        .action-card:hover {
            transform: translateY(-3px);
            border-color: #667eea;
        }

        .action-icon {
            font-size: 2rem;
            margin-bottom: 10px;
            color: #667eea;
        }

        .modal-overlay {
            display: none;
            position: fixed;
            top: 0;
            left: 0;
            width: 100%;
            height: 100%;
            background: rgba(0,0,0,0.5);
            z-index: 1000;
            backdrop-filter: blur(5px);
        }

        .modal {
            position: fixed;
            top: 50%;
            left: 50%;
            transform: translate(-50%, -50%);
            background: white;
            border-radius: 15px;
            padding: 30px;
            max-width: 600px;
            width: 90%;
            max-height: 80vh;
            overflow-y: auto;
            box-shadow: 0 20px 40px rgba(0,0,0,0.2);
        }

        .modal-header {
            display: flex;
            justify-content: space-between;
            align-items: center;
            margin-bottom: 20px;
            padding-bottom: 15px;
            border-bottom: 2px solid #f1f3f4;
        }

        .modal-title {
            font-size: 1.5rem;
            font-weight: 600;
            color: #333;
        }

        .close-btn {
            background: none;
            border: none;
            font-size: 1.5rem;
            cursor: pointer;
            color: #666;
            padding: 5px;
            border-radius: 5px;
            transition: background 0.3s ease;
        }

        .close-btn:hover {
            background: #f1f3f4;
        }

        .empty-state {
            text-align: center;
            padding: 60px 20px;
            color: #666;
        }

        .empty-state i {
            font-size: 4rem;
            margin-bottom: 20px;
            color: #ddd;
        }

        .empty-state h3 {
            font-size: 1.5rem;
            margin-bottom: 10px;
            color: #999;
        }

        .empty-state p {
            font-size: 1rem;
            margin-bottom: 20px;
        }

        @media (max-width: 768px) {
            .admin-container {
                padding: 10px;
            }
            
            .admin-header {
                padding: 20px;
            }
            
            .admin-header h1 {
                font-size: 1.8rem;
            }
            
            .admin-tabs {
                flex-direction: column;
            }
            
            .tab-btn {
                min-width: auto;
            }
            
            .form-row {
                grid-template-columns: 1fr;
            }
            
            .stats-cards {
                grid-template-columns: 1fr;
            }
            
            .quick-actions {
                grid-template-columns: 1fr;
            }
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="admin-container">
            <!-- Header Section -->
            <div class="admin-header">
                <h1><i class="fas fa-cog"></i> Portfolio Admin Panel</h1>
                <p>Manage your portfolio content, skills, achievements, and more</p>
            </div>

            <!-- Alert Messages -->
            <asp:Panel ID="pnlAlert" runat="server" Visible="false" CssClass="alert">
                <asp:Literal ID="litAlert" runat="server"></asp:Literal>
            </asp:Panel>

            <!-- Statistics Cards -->
            <div class="stats-cards">
                <div class="stat-card">
                    <div class="stat-number" id="totalProjects">0</div>
                    <div class="stat-label">Total Projects</div>
                </div>
                <div class="stat-card">
                    <div class="stat-number" id="totalSkills">0</div>
                    <div class="stat-label">Skills Listed</div>
                </div>
                <div class="stat-card">
                    <div class="stat-number" id="totalAchievements">0</div>
                    <div class="stat-label">Achievements</div>
                </div>
                <div class="stat-card">
                    <div class="stat-number" id="totalMessages">0</div>
                    <div class="stat-label">Contact Messages</div>
                </div>
            </div>

            <!-- Quick Actions -->
            <div class="quick-actions">
                <div class="action-card" onclick="window.open('DefaultSimple.aspx', '_blank')">
                    <div class="action-icon"><i class="fas fa-eye"></i></div>
                    <h4>View Portfolio</h4>
                    <p>See live portfolio site</p>
                </div>
                <div class="action-card" onclick="showAddModal('project')">
                    <div class="action-icon"><i class="fas fa-plus-circle"></i></div>
                    <h4>Add Project</h4>
                    <p>Create new project entry</p>
                </div>
                <div class="action-card" onclick="showAddModal('achievement')">
                    <div class="action-icon"><i class="fas fa-trophy"></i></div>
                    <h4>Add Achievement</h4>
                    <p>Record new achievement</p>
                </div>
                <div class="action-card" onclick="showAddModal('skill')">
                    <div class="action-icon"><i class="fas fa-code"></i></div>
                    <h4>Add Skill</h4>
                    <p>Add technical skill</p>
                </div>
            </div>

            <!-- Navigation Tabs -->
            <div class="admin-tabs">
                <button type="button" class="tab-btn active" onclick="showSection('projects')">
                    <i class="fas fa-laptop-code"></i> Projects
                </button>
                <button type="button" class="tab-btn" onclick="showSection('skills')">
                    <i class="fas fa-code"></i> Skills
                </button>
                <button type="button" class="tab-btn" onclick="showSection('achievements')">
                    <i class="fas fa-trophy"></i> Achievements
                </button>
                <button type="button" class="tab-btn" onclick="showSection('education')">
                    <i class="fas fa-graduation-cap"></i> Education
                </button>
                <button type="button" class="tab-btn" onclick="showSection('contacts')">
                    <i class="fas fa-envelope"></i> Messages
                </button>
                <button type="button" class="tab-btn" onclick="showSection('settings')">
                    <i class="fas fa-cog"></i> Settings
                </button>
            </div>

            <!-- Projects Section -->
            <div class="admin-section active" id="projects-section">
                <div class="section-header">
                    <h2 class="section-title">
                        <i class="fas fa-laptop-code"></i> Projects Management
                    </h2>
                    <button type="button" class="btn btn-primary" onclick="showAddModal('project')">
                        <i class="fas fa-plus"></i> Add New Project
                    </button>
                </div>
                
                <asp:GridView ID="gvProjects" runat="server" CssClass="data-grid" AutoGenerateColumns="false" 
                    EmptyDataText="No projects found." OnRowCommand="gvProjects_RowCommand" DataKeyNames="Id">
                    <EmptyDataTemplate>
                        <div class="empty-state">
                            <i class="fas fa-laptop-code"></i>
                            <h3>No Projects Yet</h3>
                            <p>Start building your portfolio by adding your first project</p>
                            <button type="button" class="btn btn-primary" onclick="showAddModal('project')">
                                <i class="fas fa-plus"></i> Add First Project
                            </button>
                        </div>
                    </EmptyDataTemplate>
                    <Columns>
                        <asp:BoundField DataField="Title" HeaderText="Project Title" />
                        <asp:BoundField DataField="Technologies" HeaderText="Technologies" />
                        <asp:BoundField DataField="Description" HeaderText="Description" />
                        <asp:CheckBoxField DataField="IsActive" HeaderText="Active" />
                        <asp:TemplateField HeaderText="Actions">
                            <ItemTemplate>
                                <asp:LinkButton ID="btnEdit" runat="server" CommandName="EditItem" CommandArgument='<%# Container.DataItemIndex %>' 
                                    CssClass="btn btn-warning btn-sm" ToolTip="Edit">
                                    <i class="fas fa-edit"></i>
                                </asp:LinkButton>
                                <asp:LinkButton ID="btnDelete" runat="server" CommandName="DeleteItem" CommandArgument='<%# Container.DataItemIndex %>' 
                                    CssClass="btn btn-danger btn-sm" ToolTip="Delete" OnClientClick="return confirm('Are you sure?');">
                                    <i class="fas fa-trash"></i>
                                </asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </div>

            <!-- Skills Section -->
            <div class="admin-section" id="skills-section">
                <div class="section-header">
                    <h2 class="section-title">
                        <i class="fas fa-code"></i> Skills Management
                    </h2>
                    <button type="button" class="btn btn-primary" onclick="showAddModal('skill')">
                        <i class="fas fa-plus"></i> Add New Skill
                    </button>
                </div>
                
                <asp:GridView ID="gvSkills" runat="server" CssClass="data-grid" AutoGenerateColumns="false" 
                    EmptyDataText="No skills found." OnRowCommand="gvSkills_RowCommand" DataKeyNames="Id">
                    <EmptyDataTemplate>
                        <div class="empty-state">
                            <i class="fas fa-code"></i>
                            <h3>No Skills Listed</h3>
                            <p>Showcase your technical expertise by adding your skills</p>
                            <button type="button" class="btn btn-primary" onclick="showAddModal('skill')">
                                <i class="fas fa-plus"></i> Add First Skill
                            </button>
                        </div>
                    </EmptyDataTemplate>
                    <Columns>
                        <asp:BoundField DataField="Name" HeaderText="Skill Name" />
                        <asp:BoundField DataField="Category" HeaderText="Category" />
                        <asp:BoundField DataField="ProficiencyLevel" HeaderText="Proficiency %" />
                        <asp:CheckBoxField DataField="IsActive" HeaderText="Active" />
                        <asp:TemplateField HeaderText="Actions">
                            <ItemTemplate>
                                <asp:LinkButton ID="btnEdit" runat="server" CommandName="EditItem" CommandArgument='<%# Container.DataItemIndex %>' 
                                    CssClass="btn btn-warning btn-sm" ToolTip="Edit">
                                    <i class="fas fa-edit"></i>
                                </asp:LinkButton>
                                <asp:LinkButton ID="btnDelete" runat="server" CommandName="DeleteItem" CommandArgument='<%# Container.DataItemIndex %>' 
                                    CssClass="btn btn-danger btn-sm" ToolTip="Delete" OnClientClick="return confirm('Are you sure?');">
                                    <i class="fas fa-trash"></i>
                                </asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </div>

            <!-- Achievements Section -->
            <div class="admin-section" id="achievements-section">
                <div class="section-header">
                    <h2 class="section-title">
                        <i class="fas fa-trophy"></i> Achievements Management
                    </h2>
                    <button type="button" class="btn btn-primary" onclick="showAddModal('achievement')">
                        <i class="fas fa-plus"></i> Add New Achievement
                    </button>
                </div>
                
                <asp:GridView ID="gvAchievements" runat="server" CssClass="data-grid" AutoGenerateColumns="false" 
                    EmptyDataText="No achievements found." OnRowCommand="gvAchievements_RowCommand" DataKeyNames="Id">
                    <EmptyDataTemplate>
                        <div class="empty-state">
                            <i class="fas fa-trophy"></i>
                            <h3>No Achievements Recorded</h3>
                            <p>Document your accomplishments and milestones</p>
                            <button type="button" class="btn btn-primary" onclick="showAddModal('achievement')">
                                <i class="fas fa-plus"></i> Add First Achievement
                            </button>
                        </div>
                    </EmptyDataTemplate>
                    <Columns>
                        <asp:BoundField DataField="Title" HeaderText="Achievement" />
                        <asp:BoundField DataField="Platform" HeaderText="Platform" />
                        <asp:BoundField DataField="Ranking" HeaderText="Ranking" />
                        <asp:BoundField DataField="AchievedDate" HeaderText="Date" DataFormatString="{0:MM/dd/yyyy}" />
                        <asp:CheckBoxField DataField="IsActive" HeaderText="Active" />
                        <asp:TemplateField HeaderText="Actions">
                            <ItemTemplate>
                                <asp:LinkButton ID="btnEdit" runat="server" CommandName="EditItem" CommandArgument='<%# Container.DataItemIndex %>' 
                                    CssClass="btn btn-warning btn-sm" ToolTip="Edit">
                                    <i class="fas fa-edit"></i>
                                </asp:LinkButton>
                                <asp:LinkButton ID="btnDelete" runat="server" CommandName="DeleteItem" CommandArgument='<%# Container.DataItemIndex %>' 
                                    CssClass="btn btn-danger btn-sm" ToolTip="Delete" OnClientClick="return confirm('Are you sure?');">
                                    <i class="fas fa-trash"></i>
                                </asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </div>

            <!-- Education Section -->
            <div class="admin-section" id="education-section">
                <div class="section-header">
                    <h2 class="section-title">
                        <i class="fas fa-graduation-cap"></i> Education Management
                    </h2>
                    <button type="button" class="btn btn-primary" onclick="showAddModal('education')">
                        <i class="fas fa-plus"></i> Add Education
                    </button>
                </div>
                
                <asp:GridView ID="gvEducation" runat="server" CssClass="data-grid" AutoGenerateColumns="false" 
                    EmptyDataText="No education records found." OnRowCommand="gvEducation_RowCommand" DataKeyNames="Id">
                    <EmptyDataTemplate>
                        <div class="empty-state">
                            <i class="fas fa-graduation-cap"></i>
                            <h3>No Education Records</h3>
                            <p>Add your educational background and qualifications</p>
                            <button type="button" class="btn btn-primary" onclick="showAddModal('education')">
                                <i class="fas fa-plus"></i> Add Education
                            </button>
                        </div>
                    </EmptyDataTemplate>
                    <Columns>
                        <asp:BoundField DataField="Degree" HeaderText="Degree" />
                        <asp:BoundField DataField="Institution" HeaderText="Institution" />
                        <asp:BoundField DataField="CGPA" HeaderText="CGPA" />
                        <asp:BoundField DataField="StartDate" HeaderText="Start Date" DataFormatString="{0:yyyy}" />
                        <asp:CheckBoxField DataField="IsCurrent" HeaderText="Current" />
                        <asp:TemplateField HeaderText="Actions">
                            <ItemTemplate>
                                <asp:LinkButton ID="btnEdit" runat="server" CommandName="EditItem" CommandArgument='<%# Container.DataItemIndex %>' 
                                    CssClass="btn btn-warning btn-sm" ToolTip="Edit">
                                    <i class="fas fa-edit"></i>
                                </asp:LinkButton>
                                <asp:LinkButton ID="btnDelete" runat="server" CommandName="DeleteItem" CommandArgument='<%# Container.DataItemIndex %>' 
                                    CssClass="btn btn-danger btn-sm" ToolTip="Delete" OnClientClick="return confirm('Are you sure?');">
                                    <i class="fas fa-trash"></i>
                                </asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </div>

            <!-- Contact Messages Section -->
            <div class="admin-section" id="contacts-section">
                <div class="section-header">
                    <h2 class="section-title">
                        <i class="fas fa-envelope"></i> Contact Messages
                    </h2>
                    <button type="button" class="btn btn-info" onclick="refreshMessages()">
                        <i class="fas fa-sync"></i> Refresh
                    </button>
                </div>
                
                <asp:GridView ID="gvContacts" runat="server" CssClass="data-grid" AutoGenerateColumns="false" 
                    EmptyDataText="No contact messages yet." OnRowCommand="gvContacts_RowCommand" DataKeyNames="Id">
                    <EmptyDataTemplate>
                        <div class="empty-state">
                            <i class="fas fa-envelope"></i>
                            <h3>No Messages Yet</h3>
                            <p>Contact messages from your portfolio will appear here</p>
                        </div>
                    </EmptyDataTemplate>
                    <Columns>
                        <asp:BoundField DataField="Name" HeaderText="Name" />
                        <asp:BoundField DataField="Email" HeaderText="Email" />
                        <asp:BoundField DataField="Subject" HeaderText="Subject" />
                        <asp:BoundField DataField="CreatedDate" HeaderText="Date" DataFormatString="{0:MM/dd/yyyy HH:mm}" />
                        <asp:CheckBoxField DataField="IsRead" HeaderText="Read" />
                        <asp:TemplateField HeaderText="Actions">
                            <ItemTemplate>
                                <asp:LinkButton ID="btnView" runat="server" CommandName="ViewMessage" CommandArgument='<%# Container.DataItemIndex %>' 
                                    CssClass="btn btn-info btn-sm" ToolTip="View">
                                    <i class="fas fa-eye"></i>
                                </asp:LinkButton>
                                <asp:LinkButton ID="btnReply" runat="server" CommandName="ReplyMessage" CommandArgument='<%# Container.DataItemIndex %>' 
                                    CssClass="btn btn-success btn-sm" ToolTip="Reply">
                                    <i class="fas fa-reply"></i>
                                </asp:LinkButton>
                                <asp:LinkButton ID="btnDelete" runat="server" CommandName="DeleteMessage" CommandArgument='<%# Container.DataItemIndex %>' 
                                    CssClass="btn btn-danger btn-sm" ToolTip="Delete" OnClientClick="return confirm('Are you sure?');">
                                    <i class="fas fa-trash"></i>
                                </asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </div>

            <!-- Settings Section -->
            <div class="admin-section" id="settings-section">
                <div class="section-header">
                    <h2 class="section-title">
                        <i class="fas fa-cog"></i> Portfolio Settings
                    </h2>
                </div>
                
                <div class="form-container">
                    <h3>Personal Information</h3>
                    <div class="form-row">
                        <div class="form-group">
                            <label class="form-label">Full Name</label>
                            <asp:TextBox ID="txtFullName" runat="server" CssClass="form-control" Text="Khadimul Islam Mahi" />
                        </div>
                        <div class="form-group">
                            <label class="form-label">Email</label>
                            <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" Text="khadimul.mahi@kuet.ac.bd" />
                        </div>
                    </div>
                    <div class="form-row">
                        <div class="form-group">
                            <label class="form-label">LinkedIn URL</label>
                            <asp:TextBox ID="txtLinkedIn" runat="server" CssClass="form-control" Text="https://linkedin.com/in/khadimul-islam-mahi" />
                        </div>
                        <div class="form-group">
                            <label class="form-label">GitHub URL</label>
                            <asp:TextBox ID="txtGitHub" runat="server" CssClass="form-control" Text="https://github.com/k-i-mahi" />
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="form-label">Bio/Description</label>
                        <asp:TextBox ID="txtBio" runat="server" CssClass="form-control" TextMode="MultiLine" 
                            Text="CSE 3rd Year Student at KUET | Passionate Problem Solver | Hardware Project Builder | Kaggle Competitor | Chess Enthusiast | Photography Lover" />
                    </div>
                    <asp:Button ID="btnSaveSettings" runat="server" Text="Save Settings" CssClass="btn btn-success" OnClick="btnSaveSettings_Click" />
                </div>

                <div class="form-container">
                    <h3>Competitive Programming Platforms</h3>
                    <div class="form-row">
                        <div class="form-group">
                            <label class="form-label">Codeforces Handle</label>
                            <asp:TextBox ID="txtCodeforces" runat="server" CssClass="form-control" Text="being_mysterious" />
                        </div>
                        <div class="form-group">
                            <label class="form-label">CodeChef Handle</label>
                            <asp:TextBox ID="txtCodeChef" runat="server" CssClass="form-control" Text="being_mysterious" />
                        </div>
                    </div>
                    <div class="form-row">
                        <div class="form-group">
                            <label class="form-label">LeetCode Handle</label>
                            <asp:TextBox ID="txtLeetCode" runat="server" CssClass="form-control" Text="khadimul_mahi" />
                        </div>
                        <div class="form-group">
                            <label class="form-label">HackerRank Handle</label>
                            <asp:TextBox ID="txtHackerRank" runat="server" CssClass="form-control" Text="khadimul_mahi" />
                        </div>
                    </div>
                    <asp:Button ID="btnSavePlatforms" runat="server" Text="Save Platform Settings" CssClass="btn btn-success" OnClick="btnSavePlatforms_Click" />
                </div>
            </div>
        </div>

        <!-- Modal for Add/Edit -->
        <div class="modal-overlay" id="modalOverlay">
            <div class="modal">
                <div class="modal-header">
                    <h3 class="modal-title" id="modalTitle">Add New Item</h3>
                    <button type="button" class="close-btn" onclick="closeModal()">&times;</button>
                </div>
                <div id="modalContent">
                    <!-- Dynamic content will be loaded here -->
                </div>
            </div>
        </div>
    </form>

    <script>
        // Tab Management
        function showSection(sectionName) {
            // Hide all sections
            document.querySelectorAll('.admin-section').forEach(section => {
                section.classList.remove('active');
            });
            
            // Remove active from all tabs
            document.querySelectorAll('.tab-btn').forEach(tab => {
                tab.classList.remove('active');
            });
            
            // Show selected section
            document.getElementById(sectionName + '-section').classList.add('active');
            
            // Add active to clicked tab
            event.target.classList.add('active');
        }

        // Modal Management
        function showAddModal(type) {
            const modal = document.getElementById('modalOverlay');
            const title = document.getElementById('modalTitle');
            const content = document.getElementById('modalContent');
            
            title.textContent = 'Add New ' + type.charAt(0).toUpperCase() + type.slice(1);
            
            let formHtml = '';
            
            switch(type) {
                case 'project':
                    formHtml = `
                        <div class="form-group">
                            <label class="form-label">Project Title</label>
                            <input type="text" class="form-control" id="projectTitle" placeholder="Enter project title">
                        </div>
                        <div class="form-group">
                            <label class="form-label">Description</label>
                            <textarea class="form-control" id="projectDesc" placeholder="Project description"></textarea>
                        </div>
                        <div class="form-group">
                            <label class="form-label">Technologies</label>
                            <input type="text" class="form-control" id="projectTech" placeholder="e.g., React, Node.js, MongoDB">
                        </div>
                        <div class="form-row">
                            <div class="form-group">
                                <label class="form-label">GitHub URL</label>
                                <input type="url" class="form-control" id="projectGithub" placeholder="https://github.com/...">
                            </div>
                            <div class="form-group">
                                <label class="form-label">Live Demo URL</label>
                                <input type="url" class="form-control" id="projectDemo" placeholder="https://...">
                            </div>
                        </div>
                        <div class="form-group">
                            <button type="button" class="btn btn-primary" onclick="saveProject()">Save Project</button>
                            <button type="button" class="btn btn-secondary" onclick="closeModal()">Cancel</button>
                        </div>
                    `;
                    break;
                    
                case 'skill':
                    formHtml = `
                        <div class="form-row">
                            <div class="form-group">
                                <label class="form-label">Skill Name</label>
                                <input type="text" class="form-control" id="skillName" placeholder="e.g., JavaScript, Python">
                            </div>
                            <div class="form-group">
                                <label class="form-label">Category</label>
                                <select class="form-control" id="skillCategory">
                                    <option value="Programming Languages">Programming Languages</option>
                                    <option value="Web Development">Web Development</option>
                                    <option value="Mobile Development">Mobile Development</option>
                                    <option value="Database">Database</option>
                                    <option value="DevOps">DevOps</option>
                                    <option value="Design">Design</option>
                                    <option value="Other">Other</option>
                                </select>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="form-label">Proficiency Level (%)</label>
                            <input type="range" class="form-control" id="skillLevel" min="1" max="100" value="50" oninput="updateSkillValue(this.value)">
                            <span id="skillValue">50%</span>
                        </div>
                        <div class="form-group">
                            <button type="button" class="btn btn-primary" onclick="saveSkill()">Save Skill</button>
                            <button type="button" class="btn btn-secondary" onclick="closeModal()">Cancel</button>
                        </div>
                    `;
                    break;
                    
                case 'achievement':
                    formHtml = `
                        <div class="form-group">
                            <label class="form-label">Achievement Title</label>
                            <input type="text" class="form-control" id="achievementTitle" placeholder="Achievement name">
                        </div>
                        <div class="form-row">
                            <div class="form-group">
                                <label class="form-label">Platform</label>
                                <input type="text" class="form-control" id="achievementPlatform" placeholder="e.g., Codeforces, Kaggle">
                            </div>
                            <div class="form-group">
                                <label class="form-label">Date Achieved</label>
                                <input type="date" class="form-control" id="achievementDate">
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="form-label">Ranking/Position</label>
                            <input type="text" class="form-control" id="achievementRank" placeholder="e.g., 1st Place, Top 10%">
                        </div>
                        <div class="form-group">
                            <label class="form-label">Description</label>
                            <textarea class="form-control" id="achievementDesc" placeholder="Describe the achievement"></textarea>
                        </div>
                        <div class="form-group">
                            <button type="button" class="btn btn-primary" onclick="saveAchievement()">Save Achievement</button>
                            <button type="button" class="btn btn-secondary" onclick="closeModal()">Cancel</button>
                        </div>
                    `;
                    break;
            }
            
            content.innerHTML = formHtml;
            modal.style.display = 'block';
        }

        function closeModal() {
            document.getElementById('modalOverlay').style.display = 'none';
        }

        function updateSkillValue(value) {
            document.getElementById('skillValue').textContent = value + '%';
        }

        // Save Functions (these would normally submit to server)
        function saveProject() {
            showAlert('Project saved successfully!', 'success');
            closeModal();
            // Here you would normally submit the form data to server
        }

        function saveSkill() {
            showAlert('Skill added successfully!', 'success');
            closeModal();
            // Here you would normally submit the form data to server
        }

        function saveAchievement() {
            showAlert('Achievement recorded successfully!', 'success');
            closeModal();
            // Here you would normally submit the form data to server
        }

        function showAlert(message, type) {
            const alert = document.querySelector('.alert');
            alert.className = 'alert alert-' + type + ' show';
            alert.querySelector('.literal').textContent = message;
            setTimeout(() => {
                alert.classList.remove('show');
            }, 5000);
        }

        function refreshMessages() {
            showAlert('Messages refreshed successfully!', 'info');
            // Reload the messages section
        }

        // Update statistics on page load
        document.addEventListener('DOMContentLoaded', function() {
            // These would normally be populated from server-side data
            document.getElementById('totalProjects').textContent = '6';
            document.getElementById('totalSkills').textContent = '25';
            document.getElementById('totalAchievements').textContent = '12';
            document.getElementById('totalMessages').textContent = '3';
        });

        // Close modal when clicking overlay
        document.getElementById('modalOverlay').addEventListener('click', function(e) {
            if (e.target === this) {
                closeModal();
            }
        });
    </script>
</body>
</html>