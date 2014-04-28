<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogisticsTabContainer
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
        Me.tabLogistics = New System.Windows.Forms.TabControl()
        Me.SuspendLayout()
        '
        'tabLogistics
        '
        Me.tabLogistics.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabLogistics.Location = New System.Drawing.Point(0, 24)
        Me.tabLogistics.Name = "tabLogistics"
        Me.tabLogistics.SelectedIndex = 0
        Me.tabLogistics.Size = New System.Drawing.Size(840, 512)
        Me.tabLogistics.TabIndex = 4
        '
        'frmLogisticsTabContainer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(840, 558)
        Me.Controls.Add(Me.tabLogistics)
        Me.Name = "frmLogisticsTabContainer"
        Me.Text = "Logistikk"
        Me.Controls.SetChildIndex(Me.tabLogistics, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tabLogistics As System.Windows.Forms.TabControl

End Class
