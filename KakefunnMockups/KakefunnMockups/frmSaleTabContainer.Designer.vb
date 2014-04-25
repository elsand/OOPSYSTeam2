<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSaleTabContainer
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
        Me.tabSale = New System.Windows.Forms.TabControl()
        Me.SuspendLayout()
        '
        'tabSale
        '
        Me.tabSale.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabSale.Location = New System.Drawing.Point(0, 24)
        Me.tabSale.Name = "tabSale"
        Me.tabSale.SelectedIndex = 0
        Me.tabSale.Size = New System.Drawing.Size(840, 512)
        Me.tabSale.TabIndex = 4
        '
        'frmSaleTabContainer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(840, 558)
        Me.Controls.Add(Me.tabSale)
        Me.Name = "frmSaleTabContainer"
        Me.Controls.SetChildIndex(Me.tabSale, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tabSale As System.Windows.Forms.TabControl

End Class
