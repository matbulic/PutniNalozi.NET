<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Me.lblKor = New System.Windows.Forms.Label()
        Me.lblLoz = New System.Windows.Forms.Label()
        Me.txtKor = New System.Windows.Forms.TextBox()
        Me.txtLoz = New System.Windows.Forms.TextBox()
        Me.btnIzg = New System.Windows.Forms.Button()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.KorisniciTableAdapter1 = New PutniNalozi.NET___Uprava.R04dbDataSetTableAdapters.korisniciTableAdapter()
        Me.R04dbDataSet1 = New PutniNalozi.NET___Uprava.R04dbDataSet()
        CType(Me.R04dbDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblKor
        '
        Me.lblKor.AutoSize = True
        Me.lblKor.Location = New System.Drawing.Point(26, 29)
        Me.lblKor.Name = "lblKor"
        Me.lblKor.Size = New System.Drawing.Size(75, 13)
        Me.lblKor.TabIndex = 0
        Me.lblKor.Text = "Korisničko ime"
        '
        'lblLoz
        '
        Me.lblLoz.AutoSize = True
        Me.lblLoz.Location = New System.Drawing.Point(25, 72)
        Me.lblLoz.Name = "lblLoz"
        Me.lblLoz.Size = New System.Drawing.Size(44, 13)
        Me.lblLoz.TabIndex = 1
        Me.lblLoz.Text = "Lozinka"
        '
        'txtKor
        '
        Me.txtKor.Location = New System.Drawing.Point(116, 21)
        Me.txtKor.Name = "txtKor"
        Me.txtKor.Size = New System.Drawing.Size(100, 20)
        Me.txtKor.TabIndex = 2
        '
        'txtLoz
        '
        Me.txtLoz.Location = New System.Drawing.Point(116, 72)
        Me.txtLoz.Name = "txtLoz"
        Me.txtLoz.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtLoz.Size = New System.Drawing.Size(100, 20)
        Me.txtLoz.TabIndex = 3
        '
        'btnIzg
        '
        Me.btnIzg.Location = New System.Drawing.Point(151, 158)
        Me.btnIzg.Name = "btnIzg"
        Me.btnIzg.Size = New System.Drawing.Size(102, 23)
        Me.btnIzg.TabIndex = 5
        Me.btnIzg.Text = "Izgubljena lozinka"
        Me.btnIzg.UseVisualStyleBackColor = True
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(151, 117)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(75, 23)
        Me.btnLogin.TabIndex = 6
        Me.btnLogin.Text = "Prijavi se"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'KorisniciTableAdapter1
        '
        Me.KorisniciTableAdapter1.ClearBeforeFill = True
        '
        'R04dbDataSet1
        '
        Me.R04dbDataSet1.DataSetName = "R04dbDataSet"
        Me.R04dbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(269, 193)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.btnIzg)
        Me.Controls.Add(Me.txtLoz)
        Me.Controls.Add(Me.txtKor)
        Me.Controls.Add(Me.lblLoz)
        Me.Controls.Add(Me.lblKor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.R04dbDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblKor As System.Windows.Forms.Label
    Friend WithEvents lblLoz As System.Windows.Forms.Label
    Friend WithEvents txtKor As System.Windows.Forms.TextBox
    Friend WithEvents txtLoz As System.Windows.Forms.TextBox
    Friend WithEvents btnIzg As System.Windows.Forms.Button
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents KorisniciTableAdapter1 As PutniNalozi.NET___Uprava.R04dbDataSetTableAdapters.korisniciTableAdapter
    Friend WithEvents R04dbDataSet1 As PutniNalozi.NET___Uprava.R04dbDataSet
End Class
