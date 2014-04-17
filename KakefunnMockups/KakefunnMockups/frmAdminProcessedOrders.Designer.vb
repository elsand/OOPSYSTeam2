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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dtgProcessedOrders = New System.Windows.Forms.DataGridView()
        Me.exported = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ModifiedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dcCustomerId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dcCustomerName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dcOrderAddress = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dcOrderTotalPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnPrintProcessedOrders = New System.Windows.Forms.Button()
        Me.btnTransferToBillingSystem = New System.Windows.Forms.Button()
        Me.rdoCheckAll = New System.Windows.Forms.RadioButton()
        Me.rdoCheckNone = New System.Windows.Forms.RadioButton()
        Me.btnUpdateList = New System.Windows.Forms.Button()
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
        Me.dtgProcessedOrders.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.exported, Me.ModifiedDataGridViewTextBoxColumn, Me.IdDataGridViewTextBoxColumn, Me.dcCustomerId, Me.dcCustomerName, Me.dcOrderAddress, Me.dcOrderTotalPrice})
        Me.dtgProcessedOrders.DataSource = Me.OrderBindingSource
        Me.dtgProcessedOrders.Location = New System.Drawing.Point(12, 66)
        Me.dtgProcessedOrders.Name = "dtgProcessedOrders"
        Me.dtgProcessedOrders.RowHeadersVisible = False
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dtgProcessedOrders.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgProcessedOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgProcessedOrders.Size = New System.Drawing.Size(696, 306)
        Me.dtgProcessedOrders.TabIndex = 8
        '
        'exported
        '
        Me.exported.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.exported.HeaderText = "Eksporter"
        Me.exported.Name = "exported"
        Me.exported.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.exported.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.exported.Width = 60
        '
        'ModifiedDataGridViewTextBoxColumn
        '
        Me.ModifiedDataGridViewTextBoxColumn.DataPropertyName = "modified"
        Me.ModifiedDataGridViewTextBoxColumn.HeaderText = "Sist redigert"
        Me.ModifiedDataGridViewTextBoxColumn.Name = "ModifiedDataGridViewTextBoxColumn"
        Me.ModifiedDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Ordrenr"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'dcCustomerId
        '
        Me.dcCustomerId.DataPropertyName = "Customer"
        Me.dcCustomerId.HeaderText = "Kundenr"
        Me.dcCustomerId.Name = "dcCustomerId"
        Me.dcCustomerId.ReadOnly = True
        '
        'dcCustomerName
        '
        Me.dcCustomerName.DataPropertyName = "Customer"
        Me.dcCustomerName.HeaderText = "Navn"
        Me.dcCustomerName.Name = "dcCustomerName"
        Me.dcCustomerName.ReadOnly = True
        '
        'dcOrderAddress
        '
        Me.dcOrderAddress.DataPropertyName = "Address"
        Me.dcOrderAddress.HeaderText = "Leveringsadresse"
        Me.dcOrderAddress.Name = "dcOrderAddress"
        Me.dcOrderAddress.ReadOnly = True
        '
        'dcOrderTotalPrice
        '
        Me.dcOrderTotalPrice.DataPropertyName = "id"
        Me.dcOrderTotalPrice.HeaderText = "Beløp"
        Me.dcOrderTotalPrice.Name = "dcOrderTotalPrice"
        Me.dcOrderTotalPrice.ReadOnly = True
        '
        'OrderBindingSource
        '
        Me.OrderBindingSource.DataSource = GetType(Kakefunn.Order)
        '
        'btnPrintProcessedOrders
        '
        Me.btnPrintProcessedOrders.Location = New System.Drawing.Point(437, 378)
        Me.btnPrintProcessedOrders.Name = "btnPrintProcessedOrders"
        Me.btnPrintProcessedOrders.Size = New System.Drawing.Size(132, 38)
        Me.btnPrintProcessedOrders.TabIndex = 9
        Me.btnPrintProcessedOrders.Text = "Skriv ut rapport"
        Me.btnPrintProcessedOrders.UseVisualStyleBackColor = True
        '
        'btnTransferToBillingSystem
        '
        Me.btnTransferToBillingSystem.Location = New System.Drawing.Point(576, 378)
        Me.btnTransferToBillingSystem.Name = "btnTransferToBillingSystem"
        Me.btnTransferToBillingSystem.Size = New System.Drawing.Size(132, 38)
        Me.btnTransferToBillingSystem.TabIndex = 10
        Me.btnTransferToBillingSystem.Text = "Overfør til fakturasystem"
        Me.btnTransferToBillingSystem.UseVisualStyleBackColor = True
        '
        'rdoCheckAll
        '
        Me.rdoCheckAll.AutoSize = True
        Me.rdoCheckAll.Location = New System.Drawing.Point(13, 378)
        Me.rdoCheckAll.Name = "rdoCheckAll"
        Me.rdoCheckAll.Size = New System.Drawing.Size(68, 17)
        Me.rdoCheckAll.TabIndex = 11
        Me.rdoCheckAll.TabStop = True
        Me.rdoCheckAll.Text = "Merk alle"
        Me.rdoCheckAll.UseVisualStyleBackColor = True
        '
        'rdoCheckNone
        '
        Me.rdoCheckNone.AutoSize = True
        Me.rdoCheckNone.Location = New System.Drawing.Point(87, 378)
        Me.rdoCheckNone.Name = "rdoCheckNone"
        Me.rdoCheckNone.Size = New System.Drawing.Size(78, 17)
        Me.rdoCheckNone.TabIndex = 12
        Me.rdoCheckNone.TabStop = True
        Me.rdoCheckNone.Text = "Merk ingen"
        Me.rdoCheckNone.UseVisualStyleBackColor = True
        '
        'btnUpdateList
        '
        Me.btnUpdateList.Location = New System.Drawing.Point(299, 378)
        Me.btnUpdateList.Name = "btnUpdateList"
        Me.btnUpdateList.Size = New System.Drawing.Size(132, 38)
        Me.btnUpdateList.TabIndex = 13
        Me.btnUpdateList.Text = "Oppdater liste"
        Me.btnUpdateList.UseVisualStyleBackColor = True
        '
        'frmAdminProcessedOrders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(720, 441)
        Me.Controls.Add(Me.btnUpdateList)
        Me.Controls.Add(Me.rdoCheckNone)
        Me.Controls.Add(Me.rdoCheckAll)
        Me.Controls.Add(Me.btnTransferToBillingSystem)
        Me.Controls.Add(Me.btnPrintProcessedOrders)
        Me.Controls.Add(Me.dtgProcessedOrders)
        Me.Name = "frmAdminProcessedOrders"
        Me.Text = "Effektuerte ordrer"
        Me.Controls.SetChildIndex(Me.dtgProcessedOrders, 0)
        Me.Controls.SetChildIndex(Me.btnPrintProcessedOrders, 0)
        Me.Controls.SetChildIndex(Me.btnTransferToBillingSystem, 0)
        Me.Controls.SetChildIndex(Me.rdoCheckAll, 0)
        Me.Controls.SetChildIndex(Me.rdoCheckNone, 0)
        Me.Controls.SetChildIndex(Me.btnUpdateList, 0)
        CType(Me.dtgProcessedOrders, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtgProcessedOrders As System.Windows.Forms.DataGridView
    Friend WithEvents btnPrintProcessedOrders As System.Windows.Forms.Button
    Friend WithEvents btnTransferToBillingSystem As System.Windows.Forms.Button
    Friend WithEvents OrderBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents rdoCheckAll As System.Windows.Forms.RadioButton
    Friend WithEvents rdoCheckNone As System.Windows.Forms.RadioButton
    Friend WithEvents exported As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ModifiedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dcCustomerId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dcCustomerName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dcOrderAddress As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dcOrderTotalPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnUpdateList As System.Windows.Forms.Button

End Class
