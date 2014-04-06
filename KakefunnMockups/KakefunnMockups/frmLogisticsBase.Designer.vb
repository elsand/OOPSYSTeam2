<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogisticsBase
    Inherits Kakefunn.frmSuperBase

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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnRegisterCommodity = New System.Windows.Forms.Button()
        Me.btnExpiredCommodity = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 27)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(93, 32)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "btnPackingList"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnRegisterCommodity
        '
        Me.btnRegisterCommodity.Location = New System.Drawing.Point(111, 27)
        Me.btnRegisterCommodity.Name = "btnRegisterCommodity"
        Me.btnRegisterCommodity.Size = New System.Drawing.Size(99, 32)
        Me.btnRegisterCommodity.TabIndex = 3
        Me.btnRegisterCommodity.Text = "Registrere varer"
        Me.btnRegisterCommodity.UseVisualStyleBackColor = True
        '
        'btnExpiredCommodity
        '
        Me.btnExpiredCommodity.Location = New System.Drawing.Point(216, 27)
        Me.btnExpiredCommodity.Name = "btnExpiredCommodity"
        Me.btnExpiredCommodity.Size = New System.Drawing.Size(99, 32)
        Me.btnExpiredCommodity.TabIndex = 4
        Me.btnExpiredCommodity.Text = "Utløpte varer"
        Me.btnExpiredCommodity.UseVisualStyleBackColor = True
        '
        'frmLogisticsBase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(768, 509)
        Me.Controls.Add(Me.btnExpiredCommodity)
        Me.Controls.Add(Me.btnRegisterCommodity)
        Me.Controls.Add(Me.Button1)
        Me.Name = "frmLogisticsBase"
        Me.Text = "Logistikk"
        Me.Controls.SetChildIndex(Me.Button1, 0)
        Me.Controls.SetChildIndex(Me.btnRegisterCommodity, 0)
        Me.Controls.SetChildIndex(Me.btnExpiredCommodity, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnRegisterCommodity As System.Windows.Forms.Button
    Friend WithEvents btnExpiredCommodity As System.Windows.Forms.Button

End Class
