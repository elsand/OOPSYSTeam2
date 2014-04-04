<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdminBase
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
        Me.btnExecutedOrders = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnIngredients = New System.Windows.Forms.Button()
        Me.btnCakes = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnExecutedOrders
        '
        Me.btnExecutedOrders.Location = New System.Drawing.Point(12, 27)
        Me.btnExecutedOrders.Name = "btnExecutedOrders"
        Me.btnExecutedOrders.Size = New System.Drawing.Size(106, 23)
        Me.btnExecutedOrders.TabIndex = 2
        Me.btnExecutedOrders.Text = "Effektuerte ordrer"
        Me.btnExecutedOrders.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(540, 27)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(87, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Brukere"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnIngredients
        '
        Me.btnIngredients.Location = New System.Drawing.Point(227, 27)
        Me.btnIngredients.Name = "btnIngredients"
        Me.btnIngredients.Size = New System.Drawing.Size(99, 23)
        Me.btnIngredients.TabIndex = 4
        Me.btnIngredients.Text = "Ingredienser"
        Me.btnIngredients.UseVisualStyleBackColor = True
        '
        'btnCakes
        '
        Me.btnCakes.Location = New System.Drawing.Point(124, 27)
        Me.btnCakes.Name = "btnCakes"
        Me.btnCakes.Size = New System.Drawing.Size(97, 23)
        Me.btnCakes.TabIndex = 5
        Me.btnCakes.Text = "Kaker"
        Me.btnCakes.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(437, 27)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(97, 23)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "Rapporter"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(332, 27)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(99, 23)
        Me.Button6.TabIndex = 7
        Me.Button6.Text = "Varebestilling"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'frmAdminBase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(707, 447)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.btnCakes)
        Me.Controls.Add(Me.btnIngredients)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnExecutedOrders)
        Me.HelpButton = True
        Me.Name = "frmAdminBase"
        Me.Text = "Administrasjon"
        Me.Controls.SetChildIndex(Me.btnExecutedOrders, 0)
        Me.Controls.SetChildIndex(Me.Button2, 0)
        Me.Controls.SetChildIndex(Me.btnIngredients, 0)
        Me.Controls.SetChildIndex(Me.btnCakes, 0)
        Me.Controls.SetChildIndex(Me.Button5, 0)
        Me.Controls.SetChildIndex(Me.Button6, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnExecutedOrders As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnIngredients As System.Windows.Forms.Button
    Friend WithEvents btnCakes As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button

End Class
