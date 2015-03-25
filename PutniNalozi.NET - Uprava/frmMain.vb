Public Class frmMain
    Public LoggedUser As R04dbDataSet.korisniciRow = Nothing
    Private Sub frmMain_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("Da li ste sigurni da želite zatvoriti aplikaciju?", _
                         Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = _
                         Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If
    End Sub
    Private Sub optLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optLogin.Click, MyBase.Load, optLogin.Click
        frmLogin.MdiParent = Me
        frmLogin.Show()
    End Sub

    Public Sub WriteToStatus(ByVal message As String)
        SSLabel.Text = message
    End Sub

    Private Sub optLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optLogout.Click
        Me.WriteToStatus("Uspješno odlogiran korisnik: " + optUser.Text)
        Me.LoggedUser = Nothing
        Me.optUser.Text = "Korisnik"
        frmNalozi.Close()
        frmLogin.Show()
    End Sub

    Private Sub NaloziToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optNalozi.Click
        If (Me.optUser.Text = "dekan") Then
            frmNalozi.MdiParent = Me
            frmNalozi.Show()
        End If
    End Sub

    Private Sub optExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optExit.Click
        Me.Close()
    End Sub
End Class