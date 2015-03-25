Public Class frmNalozi

    Private Sub frmNalozi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Putni_naloziTableAdapter1.Fill(Me.R04dbDataSet.putni_nalozi)
    End Sub

    Private Sub chkNalozi_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkNalozi.CheckedChanged
        Me.Statusi_nalogaTableAdapter1.Fill(Me.R04dbDataSet.statusi_naloga)
        Me.KorisniciTableAdapter1.Fill(Me.R04dbDataSet.korisnici)
        Me.Putni_naloziTableAdapter1.Fill(Me.R04dbDataSet.putni_nalozi)
        If chkNalozi.Checked Then
            lblNalozi.Enabled = False
            cmbNalozi.Enabled = False
            Me.Putni_naloziTableAdapter1.Fill(Me.R04dbDataSet.putni_nalozi)
        Else
            lblNalozi.Enabled = True
            cmbNalozi.Enabled = True
            Dim status As Double
            status = CInt(cmbNalozi.SelectedValue)
            Me.Putni_naloziTableAdapter1.FillByStatus(Me.R04dbDataSet.putni_nalozi, status)
        End If
    End Sub
End Class