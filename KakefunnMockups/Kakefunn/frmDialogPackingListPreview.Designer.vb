<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDialogPackingListPreview
    Inherits Kakefunn.frmDialogBase

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
        Me.components = New System.ComponentModel.Container()
        Me.OrderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.wbrPackingListView = New System.Windows.Forms.WebBrowser()
        CType(Me.OrderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OrderBindingSource
        '
        Me.OrderBindingSource.DataSource = GetType(Kakefunn.Order)
        '
        'wbrPackingListView
        '
        Me.wbrPackingListView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.wbrPackingListView.Location = New System.Drawing.Point(0, 0)
        Me.wbrPackingListView.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbrPackingListView.Name = "wbrPackingListView"
        Me.wbrPackingListView.Size = New System.Drawing.Size(951, 479)
        Me.wbrPackingListView.TabIndex = 0
        '
        'frmDialogExpiredBatches
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(951, 479)
        Me.Controls.Add(Me.wbrPackingListView)
        Me.Name = "frmDialogExpiredBatches"
        CType(Me.OrderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OrderBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents wbrPackingListView As System.Windows.Forms.WebBrowser

End Class
