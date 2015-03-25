Public Class frmLogin

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        KorisniciTableAdapter1.FillBy(R04dbDataSet1.korisnici, txtKor.Text, txtLoz.Text)
        If R04dbDataSet1.korisnici.Count = 0 Then
            txtLoz.Text = ""
            txtLoz.Focus()
            frmMain.LoggedUser = Nothing
            frmMain.WriteToStatus("Neuspješno logiranje korisnika: " + txtKor.Text)
            frmMain.optUser.Text = ""
        Else
            frmMain.LoggedUser = R04dbDataSet1.korisnici(0)
            frmMain.WriteToStatus("Uspješno logiran korisnik: " + R04dbDataSet1.korisnici(0).kor_ime.ToString())
            frmMain.optUser.Text = frmMain.LoggedUser.kor_ime
            If (frmMain.optUser.Text = "dekan") Then
                frmMain.optNalozi.Text = "Nalozi"
            Else
                frmMain.optNalozi.Text = Nothing
            End If
            Me.Close()
            End If
    End Sub

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AcceptButton = btnLogin
    End Sub
End Class