<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdminTabContainer
    Inherits Kakefunn.frmSuperTabContainer

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tabAdmin = New System.Windows.Forms.TabControl()
        Me.SuspendLayout()
        '
        'tabAdmin
        '
        Me.tabAdmin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabAdmin.Location = New System.Drawing.Point(0, 24)
        Me.tabAdmin.Name = "tabAdmin"
        Me.tabAdmin.SelectedIndex = 0
        Me.tabAdmin.Size = New System.Drawing.Size(850, 525)
        Me.tabAdmin.TabIndex = 11
        '
        'frmAdminTabContainer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(850, 571)
        Me.Controls.Add(Me.tabAdmin)
        Me.Name = "frmAdminTabContainer"
        Me.Text = "Administrasjon"
        Me.Controls.SetChildIndex(Me.tabAdmin, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents tabAdmin As System.Windows.Forms.TabControl

End Class
