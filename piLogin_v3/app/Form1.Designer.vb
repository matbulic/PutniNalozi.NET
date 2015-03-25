<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class piMainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.piGBBasicLogin = New System.Windows.Forms.GroupBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.piLBBasicRolesList = New System.Windows.Forms.ListBox
        Me.piLblResult = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.piBtnLogin = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.piTxtPassword = New System.Windows.Forms.TextBox
        Me.piTxtUserName = New System.Windows.Forms.TextBox
        Me.piBtnResetAll = New System.Windows.Forms.Button
        Me.piGBListUsers = New System.Windows.Forms.GroupBox
        Me.piLBUsersList = New System.Windows.Forms.ListBox
        Me.piBtnListAllUsers = New System.Windows.Forms.Button
        Me.piGBListRoles = New System.Windows.Forms.GroupBox
        Me.piLBRolesList = New System.Windows.Forms.ListBox
        Me.piBtnListAllRoles = New System.Windows.Forms.Button
        Me.piGBListActions = New System.Windows.Forms.GroupBox
        Me.piLBActionsList = New System.Windows.Forms.ListBox
        Me.piBtnListAllActions = New System.Windows.Forms.Button
        Me.piGBListSomeUsers = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.piLBUsersListByRole = New System.Windows.Forms.ListBox
        Me.piBtnListUsersByRole = New System.Windows.Forms.Button
        Me.piGBListUsersBySearch = New System.Windows.Forms.GroupBox
        Me.piCBUserExactMatch = New System.Windows.Forms.CheckBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.piTxtSearchUsername = New System.Windows.Forms.TextBox
        Me.piLBUsersListBySearch = New System.Windows.Forms.ListBox
        Me.piBtnListUsersBySearch = New System.Windows.Forms.Button
        Me.piGBlistRolesBySearch = New System.Windows.Forms.GroupBox
        Me.piCBRoleExactMatch = New System.Windows.Forms.CheckBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.piTxtSearchRolename = New System.Windows.Forms.TextBox
        Me.piLBRolesListBySearch = New System.Windows.Forms.ListBox
        Me.piBtnListRolesBySearch = New System.Windows.Forms.Button
        Me.piGBListRolesFromUser = New System.Windows.Forms.GroupBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.piLBUsersRolesList = New System.Windows.Forms.ListBox
        Me.piBtnListUsersRoles = New System.Windows.Forms.Button
        Me.piGBListRolesActions = New System.Windows.Forms.GroupBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.piLBRolesActionList = New System.Windows.Forms.ListBox
        Me.piBtnListRolesActions = New System.Windows.Forms.Button
        Me.piGBBasicLogin.SuspendLayout()
        Me.piGBListUsers.SuspendLayout()
        Me.piGBListRoles.SuspendLayout()
        Me.piGBListActions.SuspendLayout()
        Me.piGBListSomeUsers.SuspendLayout()
        Me.piGBListUsersBySearch.SuspendLayout()
        Me.piGBlistRolesBySearch.SuspendLayout()
        Me.piGBListRolesFromUser.SuspendLayout()
        Me.piGBListRolesActions.SuspendLayout()
        Me.SuspendLayout()
        '
        'piGBBasicLogin
        '
        Me.piGBBasicLogin.Controls.Add(Me.Label8)
        Me.piGBBasicLogin.Controls.Add(Me.piLBBasicRolesList)
        Me.piGBBasicLogin.Controls.Add(Me.piLblResult)
        Me.piGBBasicLogin.Controls.Add(Me.Label3)
        Me.piGBBasicLogin.Controls.Add(Me.piBtnLogin)
        Me.piGBBasicLogin.Controls.Add(Me.Label2)
        Me.piGBBasicLogin.Controls.Add(Me.Label1)
        Me.piGBBasicLogin.Controls.Add(Me.piTxtPassword)
        Me.piGBBasicLogin.Controls.Add(Me.piTxtUserName)
        Me.piGBBasicLogin.Location = New System.Drawing.Point(12, 12)
        Me.piGBBasicLogin.Name = "piGBBasicLogin"
        Me.piGBBasicLogin.Size = New System.Drawing.Size(486, 113)
        Me.piGBBasicLogin.TabIndex = 0
        Me.piGBBasicLogin.TabStop = False
        Me.piGBBasicLogin.Text = "Basic Login"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(176, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(185, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Login user's details, roles and actions:"
        '
        'piLBBasicRolesList
        '
        Me.piLBBasicRolesList.FormattingEnabled = True
        Me.piLBBasicRolesList.Location = New System.Drawing.Point(176, 38)
        Me.piLBBasicRolesList.Name = "piLBBasicRolesList"
        Me.piLBBasicRolesList.Size = New System.Drawing.Size(304, 69)
        Me.piLBBasicRolesList.TabIndex = 7
        '
        'piLblResult
        '
        Me.piLblResult.AutoSize = True
        Me.piLblResult.Location = New System.Drawing.Point(71, 94)
        Me.piLblResult.Name = "piLblResult"
        Me.piLblResult.Size = New System.Drawing.Size(0, 13)
        Me.piLblResult.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Result:"
        '
        'piBtnLogin
        '
        Me.piBtnLogin.Location = New System.Drawing.Point(94, 68)
        Me.piBtnLogin.Name = "piBtnLogin"
        Me.piBtnLogin.Size = New System.Drawing.Size(75, 23)
        Me.piBtnLogin.TabIndex = 4
        Me.piBtnLogin.Text = "Login"
        Me.piBtnLogin.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Username"
        '
        'piTxtPassword
        '
        Me.piTxtPassword.Location = New System.Drawing.Point(69, 42)
        Me.piTxtPassword.Name = "piTxtPassword"
        Me.piTxtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(176)
        Me.piTxtPassword.Size = New System.Drawing.Size(100, 20)
        Me.piTxtPassword.TabIndex = 1
        '
        'piTxtUserName
        '
        Me.piTxtUserName.Location = New System.Drawing.Point(69, 16)
        Me.piTxtUserName.Name = "piTxtUserName"
        Me.piTxtUserName.Size = New System.Drawing.Size(100, 20)
        Me.piTxtUserName.TabIndex = 0
        '
        'piBtnResetAll
        '
        Me.piBtnResetAll.Location = New System.Drawing.Point(589, 12)
        Me.piBtnResetAll.Name = "piBtnResetAll"
        Me.piBtnResetAll.Size = New System.Drawing.Size(75, 23)
        Me.piBtnResetAll.TabIndex = 1
        Me.piBtnResetAll.Text = "Reset"
        Me.piBtnResetAll.UseVisualStyleBackColor = True
        '
        'piGBListUsers
        '
        Me.piGBListUsers.Controls.Add(Me.piLBUsersList)
        Me.piGBListUsers.Controls.Add(Me.piBtnListAllUsers)
        Me.piGBListUsers.Location = New System.Drawing.Point(12, 140)
        Me.piGBListUsers.Name = "piGBListUsers"
        Me.piGBListUsers.Size = New System.Drawing.Size(158, 241)
        Me.piGBListUsers.TabIndex = 2
        Me.piGBListUsers.TabStop = False
        Me.piGBListUsers.Text = "All Users list"
        '
        'piLBUsersList
        '
        Me.piLBUsersList.FormattingEnabled = True
        Me.piLBUsersList.Location = New System.Drawing.Point(6, 28)
        Me.piLBUsersList.Name = "piLBUsersList"
        Me.piLBUsersList.Size = New System.Drawing.Size(146, 160)
        Me.piLBUsersList.TabIndex = 1
        '
        'piBtnListAllUsers
        '
        Me.piBtnListAllUsers.Location = New System.Drawing.Point(77, 194)
        Me.piBtnListAllUsers.Name = "piBtnListAllUsers"
        Me.piBtnListAllUsers.Size = New System.Drawing.Size(75, 23)
        Me.piBtnListAllUsers.TabIndex = 0
        Me.piBtnListAllUsers.Text = "List"
        Me.piBtnListAllUsers.UseVisualStyleBackColor = True
        '
        'piGBListRoles
        '
        Me.piGBListRoles.Controls.Add(Me.piLBRolesList)
        Me.piGBListRoles.Controls.Add(Me.piBtnListAllRoles)
        Me.piGBListRoles.Location = New System.Drawing.Point(176, 140)
        Me.piGBListRoles.Name = "piGBListRoles"
        Me.piGBListRoles.Size = New System.Drawing.Size(158, 241)
        Me.piGBListRoles.TabIndex = 3
        Me.piGBListRoles.TabStop = False
        Me.piGBListRoles.Text = "All Roles list"
        '
        'piLBRolesList
        '
        Me.piLBRolesList.FormattingEnabled = True
        Me.piLBRolesList.Location = New System.Drawing.Point(6, 28)
        Me.piLBRolesList.Name = "piLBRolesList"
        Me.piLBRolesList.Size = New System.Drawing.Size(146, 160)
        Me.piLBRolesList.TabIndex = 1
        '
        'piBtnListAllRoles
        '
        Me.piBtnListAllRoles.Location = New System.Drawing.Point(78, 194)
        Me.piBtnListAllRoles.Name = "piBtnListAllRoles"
        Me.piBtnListAllRoles.Size = New System.Drawing.Size(75, 23)
        Me.piBtnListAllRoles.TabIndex = 0
        Me.piBtnListAllRoles.Text = "List"
        Me.piBtnListAllRoles.UseVisualStyleBackColor = True
        '
        'piGBListActions
        '
        Me.piGBListActions.Controls.Add(Me.piLBActionsList)
        Me.piGBListActions.Controls.Add(Me.piBtnListAllActions)
        Me.piGBListActions.Location = New System.Drawing.Point(340, 140)
        Me.piGBListActions.Name = "piGBListActions"
        Me.piGBListActions.Size = New System.Drawing.Size(158, 241)
        Me.piGBListActions.TabIndex = 3
        Me.piGBListActions.TabStop = False
        Me.piGBListActions.Text = "Actions list"
        '
        'piLBActionsList
        '
        Me.piLBActionsList.FormattingEnabled = True
        Me.piLBActionsList.Location = New System.Drawing.Point(6, 28)
        Me.piLBActionsList.Name = "piLBActionsList"
        Me.piLBActionsList.Size = New System.Drawing.Size(146, 160)
        Me.piLBActionsList.TabIndex = 1
        '
        'piBtnListAllActions
        '
        Me.piBtnListAllActions.Location = New System.Drawing.Point(77, 194)
        Me.piBtnListAllActions.Name = "piBtnListAllActions"
        Me.piBtnListAllActions.Size = New System.Drawing.Size(75, 23)
        Me.piBtnListAllActions.TabIndex = 0
        Me.piBtnListAllActions.Text = "List"
        Me.piBtnListAllActions.UseVisualStyleBackColor = True
        '
        'piGBListSomeUsers
        '
        Me.piGBListSomeUsers.Controls.Add(Me.Label4)
        Me.piGBListSomeUsers.Controls.Add(Me.piLBUsersListByRole)
        Me.piGBListSomeUsers.Controls.Add(Me.piBtnListUsersByRole)
        Me.piGBListSomeUsers.Location = New System.Drawing.Point(176, 387)
        Me.piGBListSomeUsers.Name = "piGBListSomeUsers"
        Me.piGBListSomeUsers.Size = New System.Drawing.Size(158, 241)
        Me.piGBListSomeUsers.TabIndex = 2
        Me.piGBListSomeUsers.TabStop = False
        Me.piGBListSomeUsers.Text = "Users by role list"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 211)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 26)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "NOTE: Please select role" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "from ""All Roles list"""
        '
        'piLBUsersListByRole
        '
        Me.piLBUsersListByRole.FormattingEnabled = True
        Me.piLBUsersListByRole.Location = New System.Drawing.Point(6, 19)
        Me.piLBUsersListByRole.Name = "piLBUsersListByRole"
        Me.piLBUsersListByRole.Size = New System.Drawing.Size(146, 160)
        Me.piLBUsersListByRole.TabIndex = 1
        '
        'piBtnListUsersByRole
        '
        Me.piBtnListUsersByRole.Location = New System.Drawing.Point(74, 185)
        Me.piBtnListUsersByRole.Name = "piBtnListUsersByRole"
        Me.piBtnListUsersByRole.Size = New System.Drawing.Size(75, 23)
        Me.piBtnListUsersByRole.TabIndex = 0
        Me.piBtnListUsersByRole.Text = "List"
        Me.piBtnListUsersByRole.UseVisualStyleBackColor = True
        '
        'piGBListUsersBySearch
        '
        Me.piGBListUsersBySearch.Controls.Add(Me.piCBUserExactMatch)
        Me.piGBListUsersBySearch.Controls.Add(Me.Label6)
        Me.piGBListUsersBySearch.Controls.Add(Me.piTxtSearchUsername)
        Me.piGBListUsersBySearch.Controls.Add(Me.piLBUsersListBySearch)
        Me.piGBListUsersBySearch.Controls.Add(Me.piBtnListUsersBySearch)
        Me.piGBListUsersBySearch.Location = New System.Drawing.Point(504, 140)
        Me.piGBListUsersBySearch.Name = "piGBListUsersBySearch"
        Me.piGBListUsersBySearch.Size = New System.Drawing.Size(158, 241)
        Me.piGBListUsersBySearch.TabIndex = 2
        Me.piGBListUsersBySearch.TabStop = False
        Me.piGBListUsersBySearch.Text = "Users by search list"
        '
        'piCBUserExactMatch
        '
        Me.piCBUserExactMatch.AutoSize = True
        Me.piCBUserExactMatch.Location = New System.Drawing.Point(56, 19)
        Me.piCBUserExactMatch.Name = "piCBUserExactMatch"
        Me.piCBUserExactMatch.Size = New System.Drawing.Size(91, 17)
        Me.piCBUserExactMatch.TabIndex = 5
        Me.piCBUserExactMatch.Text = "Exact match?"
        Me.piCBUserExactMatch.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Search:"
        '
        'piTxtSearchUsername
        '
        Me.piTxtSearchUsername.Location = New System.Drawing.Point(6, 36)
        Me.piTxtSearchUsername.Name = "piTxtSearchUsername"
        Me.piTxtSearchUsername.Size = New System.Drawing.Size(146, 20)
        Me.piTxtSearchUsername.TabIndex = 3
        '
        'piLBUsersListBySearch
        '
        Me.piLBUsersListBySearch.FormattingEnabled = True
        Me.piLBUsersListBySearch.Location = New System.Drawing.Point(6, 67)
        Me.piLBUsersListBySearch.Name = "piLBUsersListBySearch"
        Me.piLBUsersListBySearch.Size = New System.Drawing.Size(146, 121)
        Me.piLBUsersListBySearch.TabIndex = 1
        '
        'piBtnListUsersBySearch
        '
        Me.piBtnListUsersBySearch.Location = New System.Drawing.Point(77, 194)
        Me.piBtnListUsersBySearch.Name = "piBtnListUsersBySearch"
        Me.piBtnListUsersBySearch.Size = New System.Drawing.Size(75, 23)
        Me.piBtnListUsersBySearch.TabIndex = 0
        Me.piBtnListUsersBySearch.Text = "List"
        Me.piBtnListUsersBySearch.UseVisualStyleBackColor = True
        '
        'piGBlistRolesBySearch
        '
        Me.piGBlistRolesBySearch.Controls.Add(Me.piCBRoleExactMatch)
        Me.piGBlistRolesBySearch.Controls.Add(Me.Label5)
        Me.piGBlistRolesBySearch.Controls.Add(Me.piTxtSearchRolename)
        Me.piGBlistRolesBySearch.Controls.Add(Me.piLBRolesListBySearch)
        Me.piGBlistRolesBySearch.Controls.Add(Me.piBtnListRolesBySearch)
        Me.piGBlistRolesBySearch.Location = New System.Drawing.Point(504, 387)
        Me.piGBlistRolesBySearch.Name = "piGBlistRolesBySearch"
        Me.piGBlistRolesBySearch.Size = New System.Drawing.Size(158, 241)
        Me.piGBlistRolesBySearch.TabIndex = 2
        Me.piGBlistRolesBySearch.TabStop = False
        Me.piGBlistRolesBySearch.Text = "Roles by search list"
        '
        'piCBRoleExactMatch
        '
        Me.piCBRoleExactMatch.AutoSize = True
        Me.piCBRoleExactMatch.Location = New System.Drawing.Point(56, 19)
        Me.piCBRoleExactMatch.Name = "piCBRoleExactMatch"
        Me.piCBRoleExactMatch.Size = New System.Drawing.Size(91, 17)
        Me.piCBRoleExactMatch.TabIndex = 5
        Me.piCBRoleExactMatch.Text = "Exact match?"
        Me.piCBRoleExactMatch.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Search:"
        '
        'piTxtSearchRolename
        '
        Me.piTxtSearchRolename.Location = New System.Drawing.Point(6, 36)
        Me.piTxtSearchRolename.Name = "piTxtSearchRolename"
        Me.piTxtSearchRolename.Size = New System.Drawing.Size(146, 20)
        Me.piTxtSearchRolename.TabIndex = 3
        '
        'piLBRolesListBySearch
        '
        Me.piLBRolesListBySearch.FormattingEnabled = True
        Me.piLBRolesListBySearch.Location = New System.Drawing.Point(6, 67)
        Me.piLBRolesListBySearch.Name = "piLBRolesListBySearch"
        Me.piLBRolesListBySearch.Size = New System.Drawing.Size(146, 121)
        Me.piLBRolesListBySearch.TabIndex = 1
        '
        'piBtnListRolesBySearch
        '
        Me.piBtnListRolesBySearch.Location = New System.Drawing.Point(77, 194)
        Me.piBtnListRolesBySearch.Name = "piBtnListRolesBySearch"
        Me.piBtnListRolesBySearch.Size = New System.Drawing.Size(75, 23)
        Me.piBtnListRolesBySearch.TabIndex = 0
        Me.piBtnListRolesBySearch.Text = "List"
        Me.piBtnListRolesBySearch.UseVisualStyleBackColor = True
        '
        'piGBListRolesFromUser
        '
        Me.piGBListRolesFromUser.Controls.Add(Me.Label7)
        Me.piGBListRolesFromUser.Controls.Add(Me.piLBUsersRolesList)
        Me.piGBListRolesFromUser.Controls.Add(Me.piBtnListUsersRoles)
        Me.piGBListRolesFromUser.Location = New System.Drawing.Point(12, 387)
        Me.piGBListRolesFromUser.Name = "piGBListRolesFromUser"
        Me.piGBListRolesFromUser.Size = New System.Drawing.Size(158, 241)
        Me.piGBListRolesFromUser.TabIndex = 2
        Me.piGBListRolesFromUser.TabStop = False
        Me.piGBListRolesFromUser.Text = "User's roles list"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 211)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(129, 26)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "NOTE: Please select user" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "from ""All Users list"""
        '
        'piLBUsersRolesList
        '
        Me.piLBUsersRolesList.FormattingEnabled = True
        Me.piLBUsersRolesList.Location = New System.Drawing.Point(6, 19)
        Me.piLBUsersRolesList.Name = "piLBUsersRolesList"
        Me.piLBUsersRolesList.Size = New System.Drawing.Size(146, 160)
        Me.piLBUsersRolesList.TabIndex = 1
        '
        'piBtnListUsersRoles
        '
        Me.piBtnListUsersRoles.Location = New System.Drawing.Point(74, 185)
        Me.piBtnListUsersRoles.Name = "piBtnListUsersRoles"
        Me.piBtnListUsersRoles.Size = New System.Drawing.Size(75, 23)
        Me.piBtnListUsersRoles.TabIndex = 0
        Me.piBtnListUsersRoles.Text = "List"
        Me.piBtnListUsersRoles.UseVisualStyleBackColor = True
        '
        'piGBListRolesActions
        '
        Me.piGBListRolesActions.Controls.Add(Me.Label9)
        Me.piGBListRolesActions.Controls.Add(Me.piLBRolesActionList)
        Me.piGBListRolesActions.Controls.Add(Me.piBtnListRolesActions)
        Me.piGBListRolesActions.Location = New System.Drawing.Point(340, 387)
        Me.piGBListRolesActions.Name = "piGBListRolesActions"
        Me.piGBListRolesActions.Size = New System.Drawing.Size(158, 241)
        Me.piGBListRolesActions.TabIndex = 2
        Me.piGBListRolesActions.TabStop = False
        Me.piGBListRolesActions.Text = "Role's actions"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 211)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(126, 26)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "NOTE: Please select role" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "from ""All Roles list"""
        '
        'piLBRolesActionList
        '
        Me.piLBRolesActionList.FormattingEnabled = True
        Me.piLBRolesActionList.Location = New System.Drawing.Point(6, 19)
        Me.piLBRolesActionList.Name = "piLBRolesActionList"
        Me.piLBRolesActionList.Size = New System.Drawing.Size(146, 160)
        Me.piLBRolesActionList.TabIndex = 1
        '
        'piBtnListRolesActions
        '
        Me.piBtnListRolesActions.Location = New System.Drawing.Point(74, 185)
        Me.piBtnListRolesActions.Name = "piBtnListRolesActions"
        Me.piBtnListRolesActions.Size = New System.Drawing.Size(75, 23)
        Me.piBtnListRolesActions.TabIndex = 0
        Me.piBtnListRolesActions.Text = "List"
        Me.piBtnListRolesActions.UseVisualStyleBackColor = True
        '
        'piMainForm
        '
        Me.AcceptButton = Me.piBtnLogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(676, 638)
        Me.Controls.Add(Me.piGBListActions)
        Me.Controls.Add(Me.piGBListRoles)
        Me.Controls.Add(Me.piGBlistRolesBySearch)
        Me.Controls.Add(Me.piGBListUsersBySearch)
        Me.Controls.Add(Me.piGBListRolesFromUser)
        Me.Controls.Add(Me.piGBListRolesActions)
        Me.Controls.Add(Me.piGBListSomeUsers)
        Me.Controls.Add(Me.piGBListUsers)
        Me.Controls.Add(Me.piBtnResetAll)
        Me.Controls.Add(Me.piGBBasicLogin)
        Me.Name = "piMainForm"
        Me.Text = "Main Form"
        Me.piGBBasicLogin.ResumeLayout(False)
        Me.piGBBasicLogin.PerformLayout()
        Me.piGBListUsers.ResumeLayout(False)
        Me.piGBListRoles.ResumeLayout(False)
        Me.piGBListActions.ResumeLayout(False)
        Me.piGBListSomeUsers.ResumeLayout(False)
        Me.piGBListSomeUsers.PerformLayout()
        Me.piGBListUsersBySearch.ResumeLayout(False)
        Me.piGBListUsersBySearch.PerformLayout()
        Me.piGBlistRolesBySearch.ResumeLayout(False)
        Me.piGBlistRolesBySearch.PerformLayout()
        Me.piGBListRolesFromUser.ResumeLayout(False)
        Me.piGBListRolesFromUser.PerformLayout()
        Me.piGBListRolesActions.ResumeLayout(False)
        Me.piGBListRolesActions.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents piGBBasicLogin As System.Windows.Forms.GroupBox
    Friend WithEvents piLblResult As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents piBtnLogin As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents piTxtPassword As System.Windows.Forms.TextBox
    Friend WithEvents piTxtUserName As System.Windows.Forms.TextBox
    Friend WithEvents piBtnResetAll As System.Windows.Forms.Button
    Friend WithEvents piGBListUsers As System.Windows.Forms.GroupBox
    Friend WithEvents piBtnListAllUsers As System.Windows.Forms.Button
    Friend WithEvents piLBUsersList As System.Windows.Forms.ListBox
    Friend WithEvents piGBListRoles As System.Windows.Forms.GroupBox
    Friend WithEvents piLBRolesList As System.Windows.Forms.ListBox
    Friend WithEvents piBtnListAllRoles As System.Windows.Forms.Button
    Friend WithEvents piGBListActions As System.Windows.Forms.GroupBox
    Friend WithEvents piLBActionsList As System.Windows.Forms.ListBox
    Friend WithEvents piBtnListAllActions As System.Windows.Forms.Button
    Friend WithEvents piGBListSomeUsers As System.Windows.Forms.GroupBox
    Friend WithEvents piLBUsersListByRole As System.Windows.Forms.ListBox
    Friend WithEvents piBtnListUsersByRole As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents piGBListUsersBySearch As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents piTxtSearchUsername As System.Windows.Forms.TextBox
    Friend WithEvents piLBUsersListBySearch As System.Windows.Forms.ListBox
    Friend WithEvents piBtnListUsersBySearch As System.Windows.Forms.Button
    Friend WithEvents piCBUserExactMatch As System.Windows.Forms.CheckBox
    Friend WithEvents piGBlistRolesBySearch As System.Windows.Forms.GroupBox
    Friend WithEvents piCBRoleExactMatch As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents piTxtSearchRolename As System.Windows.Forms.TextBox
    Friend WithEvents piLBRolesListBySearch As System.Windows.Forms.ListBox
    Friend WithEvents piBtnListRolesBySearch As System.Windows.Forms.Button
    Friend WithEvents piGBListRolesFromUser As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents piLBUsersRolesList As System.Windows.Forms.ListBox
    Friend WithEvents piBtnListUsersRoles As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents piLBBasicRolesList As System.Windows.Forms.ListBox
    Friend WithEvents piGBListRolesActions As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents piLBRolesActionList As System.Windows.Forms.ListBox
    Friend WithEvents piBtnListRolesActions As System.Windows.Forms.Button

End Class
