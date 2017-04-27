<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDialogAdminNotExported
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.rptNotExportedOrders = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.OrderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.OrderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rptNotExportedOrders
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.OrderBindingSource
        Me.rptNotExportedOrders.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rptNotExportedOrders.LocalReport.ReportEmbeddedResource = "Kakefunn.notExportedOrders.rdlc"
        Me.rptNotExportedOrders.Location = New System.Drawing.Point(12, 12)
        Me.rptNotExportedOrders.Name = "rptNotExportedOrders"
        Me.rptNotExportedOrders.Size = New System.Drawing.Size(718, 415)
        Me.rptNotExportedOrders.TabIndex = 0
        '
        'OrderBindingSource
        '
        Me.OrderBindingSource.DataSource = GetType(Kakefunn.Order)
        '
        'frmDialogAdminNotExported
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(742, 439)
        Me.Controls.Add(Me.rptNotExportedOrders)
        Me.Name = "frmDialogAdminNotExported"
        CType(Me.OrderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rptNotExportedOrders As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents OrderBindingSource As System.Windows.Forms.BindingSource

End Class
