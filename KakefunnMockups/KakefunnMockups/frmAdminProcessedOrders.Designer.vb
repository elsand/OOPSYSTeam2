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
        Me.components = New System.ComponentModel.Container()
        Me.dtgProcessedOrders = New System.Windows.Forms.DataGridView()
        Me.OrderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnPrintProcessedOrders = New System.Windows.Forms.Button()
        Me.btnTransferToBillingSystem = New System.Windows.Forms.Button()
        Me.ModifiedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dcCustomerId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dcCustomerName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dcOrderAddress = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dcOrderTotalPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dtgProcessedOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtgProcessedOrders
        '
        Me.dtgProcessedOrders.AllowUserToAddRows = False
        Me.dtgProcessedOrders.AllowUserToDeleteRows = False
        Me.dtgProcessedOrders.AllowUserToOrderColumns = True
        Me.dtgProcessedOrders.AutoGenerateColumns = False
        Me.dtgProcessedOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgProcessedOrders.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dtgProcessedOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgProcessedOrders.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ModifiedDataGridViewTextBoxColumn, Me.IdDataGridViewTextBoxColumn, Me.dcCustomerId, Me.dcCustomerName, Me.dcOrderAddress, Me.dcOrderTotalPrice})
        Me.dtgProcessedOrders.DataSource = Me.OrderBindingSource
        Me.dtgProcessedOrders.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtgProcessedOrders.Location = New System.Drawing.Point(12, 66)
        Me.dtgProcessedOrders.Name = "dtgProcessedOrders"
        Me.dtgProcessedOrders.RowHeadersVisible = False
        Me.dtgProcessedOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgProcessedOrders.Size = New System.Drawing.Size(696, 306)
        Me.dtgProcessedOrders.TabIndex = 8
        '
        'OrderBindingSource
        '
        Me.OrderBindingSource.DataSource = GetType(Kakefunn.Order)
        '
        'btnPrintProcessedOrders
        '
        Me.btnPrintProcessedOrders.Location = New System.Drawing.Point(12, 378)
        Me.btnPrintProcessedOrders.Name = "btnPrintProcessedOrders"
        Me.btnPrintProcessedOrders.Size = New System.Drawing.Size(132, 23)
        Me.btnPrintProcessedOrders.TabIndex = 9
        Me.btnPrintProcessedOrders.Text = "Skriv ut rapport"
        Me.btnPrintProcessedOrders.UseVisualStyleBackColor = True
        '
        'btnTransferToBillingSystem
        '
        Me.btnTransferToBillingSystem.Location = New System.Drawing.Point(576, 378)
        Me.btnTransferToBillingSystem.Name = "btnTransferToBillingSystem"
        Me.btnTransferToBillingSystem.Size = New System.Drawing.Size(132, 23)
        Me.btnTransferToBillingSystem.TabIndex = 10
        Me.btnTransferToBillingSystem.Text = "Overfør til fakturasystem"
        Me.btnTransferToBillingSystem.UseVisualStyleBackColor = True
        '
        'ModifiedDataGridViewTextBoxColumn
        '
        Me.ModifiedDataGridViewTextBoxColumn.DataPropertyName = "modified"
        Me.ModifiedDataGridViewTextBoxColumn.HeaderText = "Sist redigert"
        Me.ModifiedDataGridViewTextBoxColumn.Name = "ModifiedDataGridViewTextBoxColumn"
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Ordrenr"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        '
        'dcCustomerId
        '
        Me.dcCustomerId.DataPropertyName = "Customer"
        Me.dcCustomerId.HeaderText = "Kundenr"
        Me.dcCustomerId.Name = "dcCustomerId"
        '
        'dcCustomerName
        '
        Me.dcCustomerName.DataPropertyName = "Customer"
        Me.dcCustomerName.HeaderText = "Navn"
        Me.dcCustomerName.Name = "dcCustomerName"
        '
        'dcOrderAddress
        '
        Me.dcOrderAddress.DataPropertyName = "Address"
        Me.dcOrderAddress.HeaderText = "Leveringsadresse"
        Me.dcOrderAddress.Name = "dcOrderAddress"
        '
        'dcOrderTotalPrice
        '
        Me.dcOrderTotalPrice.DataPropertyName = "id"
        Me.dcOrderTotalPrice.HeaderText = "Beløp"
        Me.dcOrderTotalPrice.Name = "dcOrderTotalPrice"
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
        CType(Me.OrderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtgProcessedOrders As System.Windows.Forms.DataGridView
    Friend WithEvents btnPrintProcessedOrders As System.Windows.Forms.Button
    Friend WithEvents btnTransferToBillingSystem As System.Windows.Forms.Button
    Friend WithEvents OrderBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ModifiedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dcCustomerId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dcCustomerName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dcOrderAddress As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dcOrderTotalPrice As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
