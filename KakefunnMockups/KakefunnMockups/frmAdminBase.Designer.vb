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
        Me.btnProcessedOrders = New System.Windows.Forms.Button()
        Me.btnUsers = New System.Windows.Forms.Button()
        Me.btnIngredients = New System.Windows.Forms.Button()
        Me.btnCakes = New System.Windows.Forms.Button()
        Me.btnReports = New System.Windows.Forms.Button()
        Me.btnBatchOrder = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnProcessedOrders
        '
        Me.btnProcessedOrders.Location = New System.Drawing.Point(12, 27)
        Me.btnProcessedOrders.Name = "btnProcessedOrders"
        Me.btnProcessedOrders.Size = New System.Drawing.Size(106, 23)
        Me.btnProcessedOrders.TabIndex = 2
        Me.btnProcessedOrders.Text = "Effektuerte ordrer"
        Me.btnProcessedOrders.UseVisualStyleBackColor = True
        '
        'btnUsers
        '
        Me.btnUsers.Location = New System.Drawing.Point(540, 27)
        Me.btnUsers.Name = "btnUsers"
        Me.btnUsers.Size = New System.Drawing.Size(87, 23)
        Me.btnUsers.TabIndex = 7
        Me.btnUsers.Text = "Brukere"
        Me.btnUsers.UseVisualStyleBackColor = True
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
        Me.btnCakes.TabIndex = 3
        Me.btnCakes.Text = "Kaker"
        Me.btnCakes.UseVisualStyleBackColor = True
        '
        'btnReports
        '
        Me.btnReports.Location = New System.Drawing.Point(437, 27)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Size = New System.Drawing.Size(97, 23)
        Me.btnReports.TabIndex = 6
        Me.btnReports.Text = "Rapporter"
        Me.btnReports.UseVisualStyleBackColor = True
        '
        'btnBatchOrder
        '
        Me.btnBatchOrder.Location = New System.Drawing.Point(332, 27)
        Me.btnBatchOrder.Name = "btnBatchOrder"
        Me.btnBatchOrder.Size = New System.Drawing.Size(99, 23)
        Me.btnBatchOrder.TabIndex = 5
        Me.btnBatchOrder.Text = "Varebestilling"
        Me.btnBatchOrder.UseVisualStyleBackColor = True
        '
        'frmAdminBase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(707, 447)
        Me.Controls.Add(Me.btnBatchOrder)
        Me.Controls.Add(Me.btnReports)
        Me.Controls.Add(Me.btnCakes)
        Me.Controls.Add(Me.btnIngredients)
        Me.Controls.Add(Me.btnUsers)
        Me.Controls.Add(Me.btnProcessedOrders)
        Me.HelpButton = True
        Me.Name = "frmAdminBase"
        Me.Text = "Administrasjon"
        Me.Controls.SetChildIndex(Me.btnProcessedOrders, 0)
        Me.Controls.SetChildIndex(Me.btnUsers, 0)
        Me.Controls.SetChildIndex(Me.btnIngredients, 0)
        Me.Controls.SetChildIndex(Me.btnCakes, 0)
        Me.Controls.SetChildIndex(Me.btnReports, 0)
        Me.Controls.SetChildIndex(Me.btnBatchOrder, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnProcessedOrders As System.Windows.Forms.Button
    Friend WithEvents btnUsers As System.Windows.Forms.Button
    Friend WithEvents btnIngredients As System.Windows.Forms.Button
    Friend WithEvents btnCakes As System.Windows.Forms.Button
    Friend WithEvents btnReports As System.Windows.Forms.Button
    Friend WithEvents btnBatchOrder As System.Windows.Forms.Button

End Class
