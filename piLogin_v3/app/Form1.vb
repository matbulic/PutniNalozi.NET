Imports foi.pi

Public Class piMainForm
    Public piLoginInstance As Login = New Login()

    Private Sub piMainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'piLoginInstance.Grant(piLoginInstance.GetUser("btomas", True)(0), piLoginInstance.GetRoles("Dekan", True)(0), eGrant.Add)
        'piLoginInstance.Grant(piLoginInstance.GetUser("btomas", True)(0), piLoginInstance.GetRoles("Dekan", True)(0), eGrant.Remove)
    End Sub


#Region "basic login"

    Private Sub piBtnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles piBtnLogin.Click
        piLBBasicRolesList.Items.Clear()
        Dim tmpUser As iUser = piLoginInstance.Authenticate(piTxtUserName.Text, piTxtPassword.Text)
        If tmpUser Is Nothing Then
            piLblResult.Text = "Fail"
        Else
            piLblResult.Text = "OK"
            piLBBasicRolesList.Items.Add("name = " & tmpUser.Name)
            piLBBasicRolesList.Items.Add("surname = " & tmpUser.Surname)
            piLBBasicRolesList.Items.Add("phone = " & tmpUser.Phone)
            piLBBasicRolesList.Items.Add("address = " & tmpUser.Address)
            piLBBasicRolesList.Items.Add("title = " & tmpUser.Title)
            piLBBasicRolesList.Items.Add("occupation = " & tmpUser.Occupation)
            piLBBasicRolesList.Items.Add("email = " & tmpUser.Email)
            piLBBasicRolesList.Items.Add("Roles (Actions):")
            For Each tmprole In tmpUser.AssignedRoles
                piLBBasicRolesList.Items.Add(tmprole.RoleName & " (" & tmprole.Actions.ToString() & ")")
            Next
        End If
    End Sub

    Private Sub piGBBasicLogin_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles piGBBasicLogin.Enter
        Me.AcceptButton = piBtnLogin
    End Sub

#End Region

#Region "list all users"
    Private Sub piGBListUsers_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles piGBListUsers.Enter
        Me.AcceptButton = piBtnListAllUsers
    End Sub

    Private Sub piBtnListAllUsers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles piBtnListAllUsers.Click
        piLBUsersList.Items.Clear()
        For Each tmpusr In piLoginInstance.GetUser()
            piLBUsersList.Items.Add(tmpusr.UserName)
        Next
    End Sub
#End Region

#Region "list all roles"
    Private Sub piGBRolesList_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles piGBListRoles.Enter
        Me.AcceptButton = piBtnListAllRoles

    End Sub

    Private Sub piBtnListAllRoles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles piBtnListAllRoles.Click
        piLBRolesList.Items.Clear()
        For Each tmprole In piLoginInstance.GetRoles()
            piLBRolesList.Items.Add(tmprole.RoleName)
        Next




        If piLBRolesList.Items.Count > 0 Then
            piLBRolesList.SetSelected(0, True)
        End If
    End Sub
#End Region

#Region "list all actions"
    Private Sub piGBListActions_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles piGBListActions.Enter
        Me.AcceptButton = piBtnListAllActions
    End Sub

    Private Sub piBtnListAllActions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles piBtnListAllActions.Click
        piLBActionsList.Items.Clear()
        For Each tmpAction In [Enum].GetNames(GetType(foi.pi.eActions))
            piLBActionsList.Items.Add(tmpAction)
        Next
    End Sub
#End Region

#Region "list all users by role"
    Private Sub piBtnListUsersByRole_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles piBtnListUsersByRole.Click
        piLBUsersListByRole.Items.Clear()
        If piLBRolesList.SelectedItems.Count <> 0 Then
            For Each tmpusr In piLoginInstance.GetUser(piLoginInstance.GetRoles(piLBRolesList.SelectedItem.ToString(), True)(0))
                piLBUsersListByRole.Items.Add(tmpusr.UserName)
            Next
        End If
    End Sub

    Private Sub piGBListSomeUsers_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles piGBListSomeUsers.Enter
        Me.AcceptButton = piBtnListUsersByRole
    End Sub
#End Region

#Region "list all users by search"
    Private Sub piGBListUsersBySearch_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles piGBListUsersBySearch.Enter
        Me.AcceptButton = piBtnListUsersBySearch
    End Sub

    Private Sub piBtnListUsersBySearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles piBtnListUsersBySearch.Click
        piLBUsersListBySearch.Items.Clear()
        For Each tmpusr In piLoginInstance.GetUser(piTxtSearchUsername.Text, piCBUserExactMatch.Checked)
            piLBUsersListBySearch.Items.Add(tmpusr.UserName)
        Next
    End Sub
#End Region

#Region "list all roles by search"
    Private Sub piBtnListRolesBySearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles piBtnListRolesBySearch.Click

        piLBRolesListBySearch.Items.Clear()
        For Each tmprole In piLoginInstance.GetRoles(piTxtSearchRolename.Text, piCBRoleExactMatch.Checked)
            piLBRolesListBySearch.Items.Add(tmprole.RoleName)
        Next
    End Sub

    Private Sub piGBlistRolesBySearch_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles piGBlistRolesBySearch.Enter
        Me.AcceptButton = piBtnListRolesBySearch
    End Sub


#End Region

#Region "list roles for user"

    Private Sub piGBListRolesFromUser_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles piGBListRolesFromUser.Enter
        Me.AcceptButton = piBtnListUsersRoles
    End Sub

    Private Sub piBtnUsersRoles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles piBtnListUsersRoles.Click
        piLBUsersRolesList.Items.Clear()
        If piLBUsersList.SelectedItems.Count = 1 Then
            For Each tmprole In piLoginInstance.GetUser(piLBUsersList.SelectedItem.ToString(), True)(0).AssignedRoles
                piLBUsersRolesList.Items.Add(tmprole.RoleName)
            Next
        End If
    End Sub
#End Region

#Region "list actions for role"

    Private Sub piGBListRolesActions_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles piGBListRolesActions.Enter
        Me.AcceptButton = piBtnListRolesActions
    End Sub

    Private Sub piBtnListRolesActions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles piBtnListRolesActions.Click
        piLBRolesActionList.Items.Clear()
        If piLBRolesList.SelectedItems.Count <> 0 Then
            Dim tmpAction As eActions = piLoginInstance.GetRoles(piLBRolesList.SelectedItem.ToString(), True)(0).Actions
            For Each tmpAllAct In [Enum].GetValues(GetType(foi.pi.eActions))
                If (tmpAction Or tmpAllAct) = tmpAction Then
                    piLBRolesActionList.Items.Add(tmpAllAct)
                End If
            Next
        End If
    End Sub
#End Region

    Private Sub piBtnResetAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles piBtnResetAll.Click
        piLblResult.Text = ""
        piTxtPassword.Text = ""
        piTxtUserName.Text = ""
        piLBUsersList.Items.Clear()
        piLBRolesList.Items.Clear()
        piLBActionsList.Items.Clear()
        piLBUsersListByRole.Items.Clear()
        piLBRolesListBySearch.Items.Clear()
        piLBUsersListBySearch.Items.Clear()
        piTxtSearchUsername.Text = ""
        piTxtSearchRolename.Text = ""
        piLBUsersListByRole.Items.Clear()
        piLBUsersRolesList.Items.Clear()
        piLBRolesActionList.Items.Clear()
        piLBBasicRolesList.Items.Clear()
    End Sub


End Class
