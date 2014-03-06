<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSuperBase
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
        Me.FilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedigerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HjelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ByttBrukerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoggUtToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.AvsluttToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalgToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdminstrasjonToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LagerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FilToolStripMenuItem, Me.RedigerToolStripMenuItem, Me.HjelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(462, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FilToolStripMenuItem
        '
        Me.FilToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ByttBrukerToolStripMenuItem, Me.LoggUtToolStripMenuItem, Me.ToolStripMenuItem1, Me.AvsluttToolStripMenuItem})
        Me.FilToolStripMenuItem.Name = "FilToolStripMenuItem"
        Me.FilToolStripMenuItem.Size = New System.Drawing.Size(31, 20)
        Me.FilToolStripMenuItem.Text = "&Fil"
        '
        'RedigerToolStripMenuItem
        '
        Me.RedigerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalgToolStripMenuItem, Me.AdminstrasjonToolStripMenuItem, Me.LagerToolStripMenuItem})
        Me.RedigerToolStripMenuItem.Name = "RedigerToolStripMenuItem"
        Me.RedigerToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.RedigerToolStripMenuItem.Text = "&Aspekt"
        '
        'HjelpToolStripMenuItem
        '
        Me.HjelpToolStripMenuItem.Name = "HjelpToolStripMenuItem"
        Me.HjelpToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.HjelpToolStripMenuItem.Text = "&Hjelp"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 425)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(462, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(175, 17)
        Me.ToolStripStatusLabel1.Text = "Innlogget: Ola Nordmann (salg)"
        '
        'ByttBrukerToolStripMenuItem
        '
        Me.ByttBrukerToolStripMenuItem.Name = "ByttBrukerToolStripMenuItem"
        Me.ByttBrukerToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ByttBrukerToolStripMenuItem.Text = "&Bytt bruker"
        '
        'LoggUtToolStripMenuItem
        '
        Me.LoggUtToolStripMenuItem.Name = "LoggUtToolStripMenuItem"
        Me.LoggUtToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LoggUtToolStripMenuItem.Text = "&Logg ut"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(149, 6)
        '
        'AvsluttToolStripMenuItem
        '
        Me.AvsluttToolStripMenuItem.Name = "AvsluttToolStripMenuItem"
        Me.AvsluttToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AvsluttToolStripMenuItem.Text = "&Avslutt"
        '
        'SalgToolStripMenuItem
        '
        Me.SalgToolStripMenuItem.Name = "SalgToolStripMenuItem"
        Me.SalgToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SalgToolStripMenuItem.Text = "&Salg"
        '
        'AdminstrasjonToolStripMenuItem
        '
        Me.AdminstrasjonToolStripMenuItem.Name = "AdminstrasjonToolStripMenuItem"
        Me.AdminstrasjonToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AdminstrasjonToolStripMenuItem.Text = "&Adminstrasjon"
        '
        'LagerToolStripMenuItem
        '
        Me.LagerToolStripMenuItem.Name = "LagerToolStripMenuItem"
        Me.LagerToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LagerToolStripMenuItem.Text = "&Lager"
        '
        'frmSuperBase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(462, 447)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frmSuperBase"
        Me.Text = "frmSuperBase"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FilToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RedigerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HjelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ByttBrukerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoggUtToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AvsluttToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalgToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdminstrasjonToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LagerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
