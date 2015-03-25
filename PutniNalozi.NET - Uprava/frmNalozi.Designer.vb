<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNalozi
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
        Me.components = New System.ComponentModel.Container()
        Me.dgvNalozi = New System.Windows.Forms.DataGridView()
        Me.IdnalogaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusnalogaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatumkreiranjanalogaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KorisnikDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatumpolaskaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OdredisteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SvrhaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TrajanjeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DanipredujamDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrijevoznosredstvoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KatedraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OdobrionalogDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatumdolaskaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatumkreiranjaracunaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BrojdnevnicaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IznosdnevnicaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RazlikapredujmatroskovaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObracuntroskovaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PotpisaoracunDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IzvjestajDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KontoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PutninaloziBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.R04dbDataSet = New PutniNalozi.NET___Uprava.R04dbDataSet()
        Me.btnOdobri = New System.Windows.Forms.Button()
        Me.chkNalozi = New System.Windows.Forms.CheckBox()
        Me.cmbNalozi = New System.Windows.Forms.ComboBox()
        Me.PutninaloziBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblNalozi = New System.Windows.Forms.Label()
        Me.Putni_naloziTableAdapter1 = New PutniNalozi.NET___Uprava.R04dbDataSetTableAdapters.putni_naloziTableAdapter()
        Me.KorisniciTableAdapter1 = New PutniNalozi.NET___Uprava.R04dbDataSetTableAdapters.korisniciTableAdapter()
        Me.Statusi_nalogaTableAdapter1 = New PutniNalozi.NET___Uprava.R04dbDataSetTableAdapters.statusi_nalogaTableAdapter()
        CType(Me.dgvNalozi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PutninaloziBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.R04dbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PutninaloziBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvNalozi
        '
        Me.dgvNalozi.AllowUserToAddRows = False
        Me.dgvNalozi.AllowUserToDeleteRows = False
        Me.dgvNalozi.AutoGenerateColumns = False
        Me.dgvNalozi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvNalozi.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdnalogaDataGridViewTextBoxColumn, Me.StatusnalogaDataGridViewTextBoxColumn, Me.DatumkreiranjanalogaDataGridViewTextBoxColumn, Me.KorisnikDataGridViewTextBoxColumn, Me.DatumpolaskaDataGridViewTextBoxColumn, Me.OdredisteDataGridViewTextBoxColumn, Me.SvrhaDataGridViewTextBoxColumn, Me.TrajanjeDataGridViewTextBoxColumn, Me.DanipredujamDataGridViewTextBoxColumn, Me.PrijevoznosredstvoDataGridViewTextBoxColumn, Me.KatedraDataGridViewTextBoxColumn, Me.OdobrionalogDataGridViewTextBoxColumn, Me.DatumdolaskaDataGridViewTextBoxColumn, Me.DatumkreiranjaracunaDataGridViewTextBoxColumn, Me.BrojdnevnicaDataGridViewTextBoxColumn, Me.IznosdnevnicaDataGridViewTextBoxColumn, Me.RazlikapredujmatroskovaDataGridViewTextBoxColumn, Me.ObracuntroskovaDataGridViewTextBoxColumn, Me.PotpisaoracunDataGridViewTextBoxColumn, Me.IzvjestajDataGridViewTextBoxColumn, Me.KontoDataGridViewTextBoxColumn})
        Me.dgvNalozi.DataSource = Me.PutninaloziBindingSource
        Me.dgvNalozi.Location = New System.Drawing.Point(12, 65)
        Me.dgvNalozi.Name = "dgvNalozi"
        Me.dgvNalozi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvNalozi.Size = New System.Drawing.Size(760, 296)
        Me.dgvNalozi.TabIndex = 0
        '
        'IdnalogaDataGridViewTextBoxColumn
        '
        Me.IdnalogaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.IdnalogaDataGridViewTextBoxColumn.DataPropertyName = "id_naloga"
        Me.IdnalogaDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IdnalogaDataGridViewTextBoxColumn.Name = "IdnalogaDataGridViewTextBoxColumn"
        Me.IdnalogaDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdnalogaDataGridViewTextBoxColumn.Width = 43
        '
        'StatusnalogaDataGridViewTextBoxColumn
        '
        Me.StatusnalogaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.StatusnalogaDataGridViewTextBoxColumn.DataPropertyName = "status_naloga"
        Me.StatusnalogaDataGridViewTextBoxColumn.HeaderText = "Status naloga"
        Me.StatusnalogaDataGridViewTextBoxColumn.Name = "StatusnalogaDataGridViewTextBoxColumn"
        Me.StatusnalogaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.StatusnalogaDataGridViewTextBoxColumn.Width = 89
        '
        'DatumkreiranjanalogaDataGridViewTextBoxColumn
        '
        Me.DatumkreiranjanalogaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DatumkreiranjanalogaDataGridViewTextBoxColumn.DataPropertyName = "datum_kreiranja_naloga"
        Me.DatumkreiranjanalogaDataGridViewTextBoxColumn.HeaderText = "Datum kreiranja"
        Me.DatumkreiranjanalogaDataGridViewTextBoxColumn.Name = "DatumkreiranjanalogaDataGridViewTextBoxColumn"
        Me.DatumkreiranjanalogaDataGridViewTextBoxColumn.Width = 97
        '
        'KorisnikDataGridViewTextBoxColumn
        '
        Me.KorisnikDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.KorisnikDataGridViewTextBoxColumn.DataPropertyName = "korisnik"
        Me.KorisnikDataGridViewTextBoxColumn.HeaderText = "Nastavnik"
        Me.KorisnikDataGridViewTextBoxColumn.Name = "KorisnikDataGridViewTextBoxColumn"
        Me.KorisnikDataGridViewTextBoxColumn.Width = 80
        '
        'DatumpolaskaDataGridViewTextBoxColumn
        '
        Me.DatumpolaskaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DatumpolaskaDataGridViewTextBoxColumn.DataPropertyName = "datum_polaska"
        Me.DatumpolaskaDataGridViewTextBoxColumn.HeaderText = "datum_polaska"
        Me.DatumpolaskaDataGridViewTextBoxColumn.Name = "DatumpolaskaDataGridViewTextBoxColumn"
        Me.DatumpolaskaDataGridViewTextBoxColumn.Width = 104
        '
        'OdredisteDataGridViewTextBoxColumn
        '
        Me.OdredisteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.OdredisteDataGridViewTextBoxColumn.DataPropertyName = "odrediste"
        Me.OdredisteDataGridViewTextBoxColumn.HeaderText = "odrediste"
        Me.OdredisteDataGridViewTextBoxColumn.Name = "OdredisteDataGridViewTextBoxColumn"
        Me.OdredisteDataGridViewTextBoxColumn.Width = 75
        '
        'SvrhaDataGridViewTextBoxColumn
        '
        Me.SvrhaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SvrhaDataGridViewTextBoxColumn.DataPropertyName = "svrha"
        Me.SvrhaDataGridViewTextBoxColumn.HeaderText = "svrha"
        Me.SvrhaDataGridViewTextBoxColumn.Name = "SvrhaDataGridViewTextBoxColumn"
        Me.SvrhaDataGridViewTextBoxColumn.Width = 58
        '
        'TrajanjeDataGridViewTextBoxColumn
        '
        Me.TrajanjeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TrajanjeDataGridViewTextBoxColumn.DataPropertyName = "trajanje"
        Me.TrajanjeDataGridViewTextBoxColumn.HeaderText = "trajanje"
        Me.TrajanjeDataGridViewTextBoxColumn.Name = "TrajanjeDataGridViewTextBoxColumn"
        Me.TrajanjeDataGridViewTextBoxColumn.Width = 66
        '
        'DanipredujamDataGridViewTextBoxColumn
        '
        Me.DanipredujamDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DanipredujamDataGridViewTextBoxColumn.DataPropertyName = "dani_predujam"
        Me.DanipredujamDataGridViewTextBoxColumn.HeaderText = "dani_predujam"
        Me.DanipredujamDataGridViewTextBoxColumn.Name = "DanipredujamDataGridViewTextBoxColumn"
        Me.DanipredujamDataGridViewTextBoxColumn.Width = 101
        '
        'PrijevoznosredstvoDataGridViewTextBoxColumn
        '
        Me.PrijevoznosredstvoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PrijevoznosredstvoDataGridViewTextBoxColumn.DataPropertyName = "prijevozno_sredstvo"
        Me.PrijevoznosredstvoDataGridViewTextBoxColumn.HeaderText = "prijevozno_sredstvo"
        Me.PrijevoznosredstvoDataGridViewTextBoxColumn.Name = "PrijevoznosredstvoDataGridViewTextBoxColumn"
        Me.PrijevoznosredstvoDataGridViewTextBoxColumn.Width = 126
        '
        'KatedraDataGridViewTextBoxColumn
        '
        Me.KatedraDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.KatedraDataGridViewTextBoxColumn.DataPropertyName = "katedra"
        Me.KatedraDataGridViewTextBoxColumn.HeaderText = "katedra"
        Me.KatedraDataGridViewTextBoxColumn.Name = "KatedraDataGridViewTextBoxColumn"
        Me.KatedraDataGridViewTextBoxColumn.Width = 68
        '
        'OdobrionalogDataGridViewTextBoxColumn
        '
        Me.OdobrionalogDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.OdobrionalogDataGridViewTextBoxColumn.DataPropertyName = "odobrio_nalog"
        Me.OdobrionalogDataGridViewTextBoxColumn.HeaderText = "odobrio_nalog"
        Me.OdobrionalogDataGridViewTextBoxColumn.Name = "OdobrionalogDataGridViewTextBoxColumn"
        Me.OdobrionalogDataGridViewTextBoxColumn.Width = 99
        '
        'DatumdolaskaDataGridViewTextBoxColumn
        '
        Me.DatumdolaskaDataGridViewTextBoxColumn.DataPropertyName = "datum_dolaska"
        Me.DatumdolaskaDataGridViewTextBoxColumn.HeaderText = "datum_dolaska"
        Me.DatumdolaskaDataGridViewTextBoxColumn.Name = "DatumdolaskaDataGridViewTextBoxColumn"
        '
        'DatumkreiranjaracunaDataGridViewTextBoxColumn
        '
        Me.DatumkreiranjaracunaDataGridViewTextBoxColumn.DataPropertyName = "datum_kreiranja_racuna"
        Me.DatumkreiranjaracunaDataGridViewTextBoxColumn.HeaderText = "datum_kreiranja_racuna"
        Me.DatumkreiranjaracunaDataGridViewTextBoxColumn.Name = "DatumkreiranjaracunaDataGridViewTextBoxColumn"
        '
        'BrojdnevnicaDataGridViewTextBoxColumn
        '
        Me.BrojdnevnicaDataGridViewTextBoxColumn.DataPropertyName = "broj_dnevnica"
        Me.BrojdnevnicaDataGridViewTextBoxColumn.HeaderText = "broj_dnevnica"
        Me.BrojdnevnicaDataGridViewTextBoxColumn.Name = "BrojdnevnicaDataGridViewTextBoxColumn"
        '
        'IznosdnevnicaDataGridViewTextBoxColumn
        '
        Me.IznosdnevnicaDataGridViewTextBoxColumn.DataPropertyName = "iznos_dnevnica"
        Me.IznosdnevnicaDataGridViewTextBoxColumn.HeaderText = "iznos_dnevnica"
        Me.IznosdnevnicaDataGridViewTextBoxColumn.Name = "IznosdnevnicaDataGridViewTextBoxColumn"
        '
        'RazlikapredujmatroskovaDataGridViewTextBoxColumn
        '
        Me.RazlikapredujmatroskovaDataGridViewTextBoxColumn.DataPropertyName = "razlika_predujma_troskova"
        Me.RazlikapredujmatroskovaDataGridViewTextBoxColumn.HeaderText = "razlika_predujma_troskova"
        Me.RazlikapredujmatroskovaDataGridViewTextBoxColumn.Name = "RazlikapredujmatroskovaDataGridViewTextBoxColumn"
        '
        'ObracuntroskovaDataGridViewTextBoxColumn
        '
        Me.ObracuntroskovaDataGridViewTextBoxColumn.DataPropertyName = "obracun_troskova"
        Me.ObracuntroskovaDataGridViewTextBoxColumn.HeaderText = "obracun_troskova"
        Me.ObracuntroskovaDataGridViewTextBoxColumn.Name = "ObracuntroskovaDataGridViewTextBoxColumn"
        '
        'PotpisaoracunDataGridViewTextBoxColumn
        '
        Me.PotpisaoracunDataGridViewTextBoxColumn.DataPropertyName = "potpisao_racun"
        Me.PotpisaoracunDataGridViewTextBoxColumn.HeaderText = "potpisao_racun"
        Me.PotpisaoracunDataGridViewTextBoxColumn.Name = "PotpisaoracunDataGridViewTextBoxColumn"
        '
        'IzvjestajDataGridViewTextBoxColumn
        '
        Me.IzvjestajDataGridViewTextBoxColumn.DataPropertyName = "izvjestaj"
        Me.IzvjestajDataGridViewTextBoxColumn.HeaderText = "izvjestaj"
        Me.IzvjestajDataGridViewTextBoxColumn.Name = "IzvjestajDataGridViewTextBoxColumn"
        '
        'KontoDataGridViewTextBoxColumn
        '
        Me.KontoDataGridViewTextBoxColumn.DataPropertyName = "konto"
        Me.KontoDataGridViewTextBoxColumn.HeaderText = "konto"
        Me.KontoDataGridViewTextBoxColumn.Name = "KontoDataGridViewTextBoxColumn"
        '
        'PutninaloziBindingSource
        '
        Me.PutninaloziBindingSource.DataMember = "putni_nalozi"
        Me.PutninaloziBindingSource.DataSource = Me.R04dbDataSet
        '
        'R04dbDataSet
        '
        Me.R04dbDataSet.DataSetName = "R04dbDataSet"
        Me.R04dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnOdobri
        '
        Me.btnOdobri.Location = New System.Drawing.Point(1070, 514)
        Me.btnOdobri.Name = "btnOdobri"
        Me.btnOdobri.Size = New System.Drawing.Size(75, 23)
        Me.btnOdobri.TabIndex = 1
        Me.btnOdobri.Text = "Odobri"
        Me.btnOdobri.UseVisualStyleBackColor = True
        '
        'chkNalozi
        '
        Me.chkNalozi.AutoSize = True
        Me.chkNalozi.Checked = True
        Me.chkNalozi.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkNalozi.Location = New System.Drawing.Point(26, 21)
        Me.chkNalozi.Name = "chkNalozi"
        Me.chkNalozi.Size = New System.Drawing.Size(71, 17)
        Me.chkNalozi.TabIndex = 2
        Me.chkNalozi.Text = "Svi nalozi"
        Me.chkNalozi.UseVisualStyleBackColor = True
        '
        'cmbNalozi
        '
        Me.cmbNalozi.DataSource = Me.PutninaloziBindingSource1
        Me.cmbNalozi.DisplayMember = "status_naloga"
        Me.cmbNalozi.FormattingEnabled = True
        Me.cmbNalozi.Location = New System.Drawing.Point(204, 21)
        Me.cmbNalozi.Name = "cmbNalozi"
        Me.cmbNalozi.Size = New System.Drawing.Size(121, 21)
        Me.cmbNalozi.TabIndex = 3
        Me.cmbNalozi.ValueMember = "id_naloga"
        '
        'PutninaloziBindingSource1
        '
        Me.PutninaloziBindingSource1.DataMember = "putni_nalozi"
        Me.PutninaloziBindingSource1.DataSource = Me.R04dbDataSet
        '
        'lblNalozi
        '
        Me.lblNalozi.AutoSize = True
        Me.lblNalozi.Location = New System.Drawing.Point(146, 21)
        Me.lblNalozi.Name = "lblNalozi"
        Me.lblNalozi.Size = New System.Drawing.Size(36, 13)
        Me.lblNalozi.TabIndex = 4
        Me.lblNalozi.Text = "Nalozi"
        '
        'Putni_naloziTableAdapter1
        '
        Me.Putni_naloziTableAdapter1.ClearBeforeFill = True
        '
        'KorisniciTableAdapter1
        '
        Me.KorisniciTableAdapter1.ClearBeforeFill = True
        '
        'Statusi_nalogaTableAdapter1
        '
        Me.Statusi_nalogaTableAdapter1.ClearBeforeFill = True
        '
        'frmNalozi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 427)
        Me.Controls.Add(Me.lblNalozi)
        Me.Controls.Add(Me.cmbNalozi)
        Me.Controls.Add(Me.chkNalozi)
        Me.Controls.Add(Me.btnOdobri)
        Me.Controls.Add(Me.dgvNalozi)
        Me.Name = "frmNalozi"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Putni nalozi"
        CType(Me.dgvNalozi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PutninaloziBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.R04dbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PutninaloziBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvNalozi As System.Windows.Forms.DataGridView
    Friend WithEvents R04dbDataSet As PutniNalozi.NET___Uprava.R04dbDataSet
    Friend WithEvents btnOdobri As System.Windows.Forms.Button
    Friend WithEvents chkNalozi As System.Windows.Forms.CheckBox
    Friend WithEvents cmbNalozi As System.Windows.Forms.ComboBox
    Friend WithEvents lblNalozi As System.Windows.Forms.Label
    Friend WithEvents PutninaloziBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Putni_naloziTableAdapter1 As PutniNalozi.NET___Uprava.R04dbDataSetTableAdapters.putni_naloziTableAdapter
    Friend WithEvents KorisniciTableAdapter1 As PutniNalozi.NET___Uprava.R04dbDataSetTableAdapters.korisniciTableAdapter
    Friend WithEvents Statusi_nalogaTableAdapter1 As PutniNalozi.NET___Uprava.R04dbDataSetTableAdapters.statusi_nalogaTableAdapter
    Friend WithEvents PutninaloziBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents IdnalogaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusnalogaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DatumkreiranjanalogaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KorisnikDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DatumpolaskaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OdredisteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SvrhaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TrajanjeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DanipredujamDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrijevoznosredstvoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KatedraDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OdobrionalogDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DatumdolaskaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DatumkreiranjaracunaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BrojdnevnicaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IznosdnevnicaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RazlikapredujmatroskovaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ObracuntroskovaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PotpisaoracunDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IzvjestajDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KontoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
