<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.optLogin = New System.Windows.Forms.ToolStripMenuItem()
        Me.optLogout = New System.Windows.Forms.ToolStripMenuItem()
        Me.optExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.optUser = New System.Windows.Forms.ToolStripMenuItem()
        Me.optNalozi = New System.Windows.Forms.ToolStripMenuItem()
        Me.optTools = New System.Windows.Forms.ToolStripMenuItem()
        Me.sstStatus = New System.Windows.Forms.StatusStrip()
        Me.SSLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1.SuspendLayout()
        Me.sstStatus.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.optUser, Me.optTools})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(884, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.optLogin, Me.optLogout, Me.optExit})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.FileToolStripMenuItem.Text = "Izbornik"
        '
        'optLogin
        '
        Me.optLogin.Name = "optLogin"
        Me.optLogin.Size = New System.Drawing.Size(111, 22)
        Me.optLogin.Text = "Prijava"
        '
        'optLogout
        '
        Me.optLogout.Name = "optLogout"
        Me.optLogout.Size = New System.Drawing.Size(111, 22)
        Me.optLogout.Text = "Odjava"
        '
        'optExit
        '
        Me.optExit.Name = "optExit"
        Me.optExit.Size = New System.Drawing.Size(111, 22)
        Me.optExit.Text = "Izlaz"
        '
        'optUser
        '
        Me.optUser.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.optNalozi})
        Me.optUser.Name = "optUser"
        Me.optUser.Size = New System.Drawing.Size(61, 20)
        Me.optUser.Text = "Korisnik"
        '
        'optNalozi
        '
        Me.optNalozi.Name = "optNalozi"
        Me.optNalozi.Size = New System.Drawing.Size(107, 22)
        Me.optNalozi.Text = "Nalozi"
        '
        'optTools
        '
        Me.optTools.Name = "optTools"
        Me.optTools.Size = New System.Drawing.Size(43, 20)
        Me.optTools.Text = "Alati"
        '
        'sstStatus
        '
        Me.sstStatus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SSLabel})
        Me.sstStatus.Location = New System.Drawing.Point(0, 490)
        Me.sstStatus.Name = "sstStatus"
        Me.sstStatus.Size = New System.Drawing.Size(884, 22)
        Me.sstStatus.TabIndex = 2
        Me.sstStatus.Text = "StatusStrip1"
        '
        'SSLabel
        '
        Me.SSLabel.Name = "SSLabel"
        Me.SSLabel.Size = New System.Drawing.Size(0, 17)
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 512)
        Me.Controls.Add(Me.sstStatus)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.Text = "PutniNalozi.NET - Uprava"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.sstStatus.ResumeLayout(False)
        Me.sstStatus.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents optLogin As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents optLogout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents optExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents optUser As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents optTools As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents sstStatus As System.Windows.Forms.StatusStrip
    Friend WithEvents SSLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents optNalozi As System.Windows.Forms.ToolStripMenuItem

End Class
