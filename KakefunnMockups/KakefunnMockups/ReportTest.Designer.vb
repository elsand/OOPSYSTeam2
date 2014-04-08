<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportTest
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
        Me.rvTest = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SuspendLayout()
        '
        'rvTest
        '
        Me.rvTest.Location = New System.Drawing.Point(91, 74)
        Me.rvTest.Name = "rvTest"
        Me.rvTest.Size = New System.Drawing.Size(396, 246)
        Me.rvTest.TabIndex = 0
        '
        'ReportTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(778, 472)
        Me.Controls.Add(Me.rvTest)
        Me.Name = "ReportTest"
        Me.Text = "ReportTest"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rvTest As Microsoft.Reporting.WinForms.ReportViewer
End Class
