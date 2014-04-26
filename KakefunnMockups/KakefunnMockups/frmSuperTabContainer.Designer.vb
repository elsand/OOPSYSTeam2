<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSuperTabContainer
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
        Me.statusMain = New System.Windows.Forms.StatusStrip()
        Me.statusLogin = New System.Windows.Forms.ToolStripStatusLabel()
        Me.statusAction = New System.Windows.Forms.ToolStripStatusLabel()
        Me.mnuMain = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AspectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogisticsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.statusMain.SuspendLayout()
        Me.mnuMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'statusMain
        '
        Me.statusMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.statusLogin, Me.statusAction})
        Me.statusMain.Location = New System.Drawing.Point(0, 536)
        Me.statusMain.Name = "statusMain"
        Me.statusMain.Size = New System.Drawing.Size(840, 22)
        Me.statusMain.SizingGrip = False
        Me.statusMain.TabIndex = 3
        Me.statusMain.Text = "StatusStrip1"
        '
        'statusLogin
        '
        Me.statusLogin.Name = "statusLogin"
        Me.statusLogin.Size = New System.Drawing.Size(750, 17)
        Me.statusLogin.Spring = True
        Me.statusLogin.Text = "Innlogget: Ola Nordmann (salg)"
        Me.statusLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'statusAction
        '
        Me.statusAction.Name = "statusAction"
        Me.statusAction.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.statusAction.Size = New System.Drawing.Size(75, 17)
        Me.statusAction.Text = "Redigerer xxx"
        Me.statusAction.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'mnuMain
        '
        Me.mnuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.AspectToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.mnuMain.Location = New System.Drawing.Point(0, 0)
        Me.mnuMain.Name = "mnuMain"
        Me.mnuMain.Size = New System.Drawing.Size(840, 24)
        Me.mnuMain.TabIndex = 2
        Me.mnuMain.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogOutToolStripMenuItem, Me.ToolStripMenuItem1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(31, 20)
        Me.FileToolStripMenuItem.Text = "&Fil"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.LogOutToolStripMenuItem.Text = "&Logg ut"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(112, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.ExitToolStripMenuItem.Text = "&Avslutt"
        '
        'AspectToolStripMenuItem
        '
        Me.AspectToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaleToolStripMenuItem, Me.AdminToolStripMenuItem, Me.LogisticsToolStripMenuItem})
        Me.AspectToolStripMenuItem.Name = "AspectToolStripMenuItem"
        Me.AspectToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.AspectToolStripMenuItem.Text = "&Aspekt"
        '
        'SaleToolStripMenuItem
        '
        Me.SaleToolStripMenuItem.Name = "SaleToolStripMenuItem"
        Me.SaleToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.SaleToolStripMenuItem.Text = "&Salg"
        '
        'AdminToolStripMenuItem
        '
        Me.AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
        Me.AdminToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.AdminToolStripMenuItem.Text = "&Adminstrasjon"
        '
        'LogisticsToolStripMenuItem
        '
        Me.LogisticsToolStripMenuItem.Name = "LogisticsToolStripMenuItem"
        Me.LogisticsToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.LogisticsToolStripMenuItem.Text = "&Lager"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.HelpToolStripMenuItem.Text = "&Hjelp"
        '
        'frmSuperTabContainer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(840, 558)
        Me.Controls.Add(Me.statusMain)
        Me.Controls.Add(Me.mnuMain)
        Me.Name = "frmSuperTabContainer"
        Me.Text = "frmSuperTabContainer"
        Me.statusMain.ResumeLayout(False)
        Me.statusMain.PerformLayout()
        Me.mnuMain.ResumeLayout(False)
        Me.mnuMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents statusMain As System.Windows.Forms.StatusStrip
    Friend WithEvents statusLogin As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents statusAction As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents mnuMain As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AspectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdminToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogisticsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
