<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdminProcessedOrders
    Inherits Kakefunn.frmAdminBase

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
        Me.dtgProcessedOrders = New System.Windows.Forms.DataGridView()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnPrintProcessedOrders = New System.Windows.Forms.Button()
        Me.btnTransferToBillingSystem = New System.Windows.Forms.Button()
        CType(Me.dtgProcessedOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtgProcessedOrders
        '
        Me.dtgProcessedOrders.AllowUserToAddRows = False
        Me.dtgProcessedOrders.AllowUserToDeleteRows = False
        Me.dtgProcessedOrders.AllowUserToOrderColumns = True
        Me.dtgProcessedOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgProcessedOrders.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dtgProcessedOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgProcessedOrders.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column5, Me.Column1, Me.Column2, Me.Column3, Me.Column6, Me.Column4})
        Me.dtgProcessedOrders.Location = New System.Drawing.Point(12, 66)
        Me.dtgProcessedOrders.Name = "dtgProcessedOrders"
        Me.dtgProcessedOrders.Size = New System.Drawing.Size(696, 306)
        Me.dtgProcessedOrders.TabIndex = 5
        '
        'Column5
        '
        Me.Column5.HeaderText = "Sist redigert"
        Me.Column5.Name = "Column5"
        '
        'Column1
        '
        Me.Column1.HeaderText = "Ordrenr"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Kundenr"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Navn"
        Me.Column3.Name = "Column3"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Leveringsadresse"
        Me.Column6.Name = "Column6"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Beløp"
        Me.Column4.Name = "Column4"
        '
        'btnPrintProcessedOrders
        '
        Me.btnPrintProcessedOrders.Location = New System.Drawing.Point(12, 378)
        Me.btnPrintProcessedOrders.Name = "btnPrintProcessedOrders"
        Me.btnPrintProcessedOrders.Size = New System.Drawing.Size(132, 23)
        Me.btnPrintProcessedOrders.TabIndex = 6
        Me.btnPrintProcessedOrders.Text = "Skriv ut rapport"
        Me.btnPrintProcessedOrders.UseVisualStyleBackColor = True
        '
        'btnTransferToBillingSystem
        '
        Me.btnTransferToBillingSystem.Location = New System.Drawing.Point(576, 378)
        Me.btnTransferToBillingSystem.Name = "btnTransferToBillingSystem"
        Me.btnTransferToBillingSystem.Size = New System.Drawing.Size(132, 23)
        Me.btnTransferToBillingSystem.TabIndex = 7
        Me.btnTransferToBillingSystem.Text = "Overfør til fakturasystem"
        Me.btnTransferToBillingSystem.UseVisualStyleBackColor = True
        '
        'frmAdminProcessedOrders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(720, 441)
        Me.Controls.Add(Me.btnTransferToBillingSystem)
        Me.Controls.Add(Me.btnPrintProcessedOrders)
        Me.Controls.Add(Me.dtgProcessedOrders)
        Me.Name = "frmAdminProcessedOrders"
        Me.Text = "Effektuerte ordrer"
        Me.Controls.SetChildIndex(Me.dtgProcessedOrders, 0)
        Me.Controls.SetChildIndex(Me.btnPrintProcessedOrders, 0)
        Me.Controls.SetChildIndex(Me.btnTransferToBillingSystem, 0)
        CType(Me.dtgProcessedOrders, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtgProcessedOrders As System.Windows.Forms.DataGridView
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnPrintProcessedOrders As System.Windows.Forms.Button
    Friend WithEvents btnTransferToBillingSystem As System.Windows.Forms.Button

End Class
