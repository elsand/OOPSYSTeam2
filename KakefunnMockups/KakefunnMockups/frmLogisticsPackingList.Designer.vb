<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogisticsPackingList
    Inherits Kakefunn.frmLogisticsBase

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
        Me.dtgPackingList = New System.Windows.Forms.DataGridView()
        Me.OrderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblOrdersToEnvoyDate = New System.Windows.Forms.Label()
        Me.dtpPackingList = New System.Windows.Forms.DateTimePicker()
        Me.lblPickDate = New System.Windows.Forms.Label()
        Me.btnMarkUnsent = New System.Windows.Forms.Button()
        Me.btnPrintPackingList = New System.Windows.Forms.Button()
        Me.grpPerformOnOrders = New System.Windows.Forms.GroupBox()
        Me.btnSetStatus = New System.Windows.Forms.Button()
        Me.cboStatusSetOrder = New System.Windows.Forms.ComboBox()
        Me.cnOrderId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cnDeliveryTo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cnAddress = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cnZip = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cnStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeliveryFirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeliveryLastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeliveryPhoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeliveryEmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeliveryDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubscriptionIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ShippingPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiscountPercentageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiscountAbsoluteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IsPaidDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.SentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExportedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreatedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ModifiedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IsSubscriptionOrderDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeliveryMethodDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dtgPackingList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPerformOnOrders.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtgPackingList
        '
        Me.dtgPackingList.AllowUserToAddRows = False
        Me.dtgPackingList.AllowUserToDeleteRows = False
        Me.dtgPackingList.AutoGenerateColumns = False
        Me.dtgPackingList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgPackingList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgPackingList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cnOrderId, Me.cnDeliveryTo, Me.cnAddress, Me.cnZip, Me.cnStatus, Me.IdDataGridViewTextBoxColumn, Me.DeliveryFirstNameDataGridViewTextBoxColumn, Me.DeliveryLastNameDataGridViewTextBoxColumn, Me.DeliveryPhoneDataGridViewTextBoxColumn, Me.DeliveryEmailDataGridViewTextBoxColumn, Me.DeliveryDateDataGridViewTextBoxColumn, Me.SubscriptionIdDataGridViewTextBoxColumn, Me.ShippingPriceDataGridViewTextBoxColumn, Me.DiscountPercentageDataGridViewTextBoxColumn, Me.DiscountAbsoluteDataGridViewTextBoxColumn, Me.NoteDataGridViewTextBoxColumn, Me.IsPaidDataGridViewCheckBoxColumn, Me.SentDataGridViewTextBoxColumn, Me.ExportedDataGridViewTextBoxColumn, Me.CreatedDataGridViewTextBoxColumn, Me.ModifiedDataGridViewTextBoxColumn, Me.IsSubscriptionOrderDataGridViewCheckBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.CustomerDataGridViewTextBoxColumn, Me.DeliveryMethodDataGridViewTextBoxColumn, Me.EmployeeDataGridViewTextBoxColumn})
        Me.dtgPackingList.DataSource = Me.OrderBindingSource
        Me.dtgPackingList.Location = New System.Drawing.Point(12, 90)
        Me.dtgPackingList.Name = "dtgPackingList"
        Me.dtgPackingList.ReadOnly = True
        Me.dtgPackingList.RowHeadersVisible = False
        Me.dtgPackingList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgPackingList.Size = New System.Drawing.Size(611, 348)
        Me.dtgPackingList.TabIndex = 6
        '
        'OrderBindingSource
        '
        Me.OrderBindingSource.DataSource = GetType(Kakefunn.Order)
        '
        'lblOrdersToEnvoyDate
        '
        Me.lblOrdersToEnvoyDate.AutoSize = True
        Me.lblOrdersToEnvoyDate.Location = New System.Drawing.Point(12, 71)
        Me.lblOrdersToEnvoyDate.Name = "lblOrdersToEnvoyDate"
        Me.lblOrdersToEnvoyDate.Size = New System.Drawing.Size(167, 13)
        Me.lblOrdersToEnvoyDate.TabIndex = 6
        Me.lblOrdersToEnvoyDate.Text = "Ordrer til utsending XX. mars 2014"
        '
        'dtpPackingList
        '
        Me.dtpPackingList.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpPackingList.Location = New System.Drawing.Point(525, 64)
        Me.dtpPackingList.Name = "dtpPackingList"
        Me.dtpPackingList.Size = New System.Drawing.Size(98, 20)
        Me.dtpPackingList.TabIndex = 5
        '
        'lblPickDate
        '
        Me.lblPickDate.AutoSize = True
        Me.lblPickDate.Location = New System.Drawing.Point(467, 67)
        Me.lblPickDate.Name = "lblPickDate"
        Me.lblPickDate.Size = New System.Drawing.Size(52, 13)
        Me.lblPickDate.TabIndex = 9
        Me.lblPickDate.Text = "Velg dato"
        '
        'btnMarkUnsent
        '
        Me.btnMarkUnsent.Location = New System.Drawing.Point(15, 463)
        Me.btnMarkUnsent.Name = "btnMarkUnsent"
        Me.btnMarkUnsent.Size = New System.Drawing.Size(104, 23)
        Me.btnMarkUnsent.TabIndex = 7
        Me.btnMarkUnsent.Text = "Merk usendte"
        Me.btnMarkUnsent.UseVisualStyleBackColor = True
        '
        'btnPrintPackingList
        '
        Me.btnPrintPackingList.Location = New System.Drawing.Point(6, 19)
        Me.btnPrintPackingList.Name = "btnPrintPackingList"
        Me.btnPrintPackingList.Size = New System.Drawing.Size(120, 23)
        Me.btnPrintPackingList.TabIndex = 0
        Me.btnPrintPackingList.Text = "Skriv ut pakkseddel"
        Me.btnPrintPackingList.UseVisualStyleBackColor = True
        '
        'grpPerformOnOrders
        '
        Me.grpPerformOnOrders.Controls.Add(Me.btnSetStatus)
        Me.grpPerformOnOrders.Controls.Add(Me.cboStatusSetOrder)
        Me.grpPerformOnOrders.Controls.Add(Me.btnPrintPackingList)
        Me.grpPerformOnOrders.Location = New System.Drawing.Point(304, 444)
        Me.grpPerformOnOrders.Name = "grpPerformOnOrders"
        Me.grpPerformOnOrders.Size = New System.Drawing.Size(319, 54)
        Me.grpPerformOnOrders.TabIndex = 8
        Me.grpPerformOnOrders.TabStop = False
        Me.grpPerformOnOrders.Text = "Utfør på merkede ordrer"
        '
        'btnSetStatus
        '
        Me.btnSetStatus.Location = New System.Drawing.Point(146, 19)
        Me.btnSetStatus.Name = "btnSetStatus"
        Me.btnSetStatus.Size = New System.Drawing.Size(91, 23)
        Me.btnSetStatus.TabIndex = 1
        Me.btnSetStatus.Text = "Sett status"
        Me.btnSetStatus.UseVisualStyleBackColor = True
        '
        'cboStatusSetOrder
        '
        Me.cboStatusSetOrder.FormattingEnabled = True
        Me.cboStatusSetOrder.Items.AddRange(New Object() {"Sendt", "Ikke sendt"})
        Me.cboStatusSetOrder.Location = New System.Drawing.Point(243, 20)
        Me.cboStatusSetOrder.Name = "cboStatusSetOrder"
        Me.cboStatusSetOrder.Size = New System.Drawing.Size(70, 21)
        Me.cboStatusSetOrder.TabIndex = 2
        Me.cboStatusSetOrder.Text = "Sendt"
        '
        'cnOrderId
        '
        Me.cnOrderId.DataPropertyName = "id"
        Me.cnOrderId.HeaderText = "Ordrenr"
        Me.cnOrderId.Name = "cnOrderId"
        Me.cnOrderId.ReadOnly = True
        '
        'cnDeliveryTo
        '
        Me.cnDeliveryTo.DataPropertyName = "Customer"
        Me.cnDeliveryTo.HeaderText = "Leveres til"
        Me.cnDeliveryTo.Name = "cnDeliveryTo"
        Me.cnDeliveryTo.ReadOnly = True
        '
        'cnAddress
        '
        Me.cnAddress.DataPropertyName = "Address"
        Me.cnAddress.HeaderText = "Adresse"
        Me.cnAddress.Name = "cnAddress"
        Me.cnAddress.ReadOnly = True
        '
        'cnZip
        '
        Me.cnZip.DataPropertyName = "Address"
        Me.cnZip.HeaderText = "Postnr/sted"
        Me.cnZip.Name = "cnZip"
        Me.cnZip.ReadOnly = True
        '
        'cnStatus
        '
        Me.cnStatus.DataPropertyName = "sent"
        Me.cnStatus.HeaderText = "Status"
        Me.cnStatus.Name = "cnStatus"
        Me.cnStatus.ReadOnly = True
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn.Visible = False
        '
        'DeliveryFirstNameDataGridViewTextBoxColumn
        '
        Me.DeliveryFirstNameDataGridViewTextBoxColumn.DataPropertyName = "deliveryFirstName"
        Me.DeliveryFirstNameDataGridViewTextBoxColumn.HeaderText = "deliveryFirstName"
        Me.DeliveryFirstNameDataGridViewTextBoxColumn.Name = "DeliveryFirstNameDataGridViewTextBoxColumn"
        Me.DeliveryFirstNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.DeliveryFirstNameDataGridViewTextBoxColumn.Visible = False
        '
        'DeliveryLastNameDataGridViewTextBoxColumn
        '
        Me.DeliveryLastNameDataGridViewTextBoxColumn.DataPropertyName = "deliveryLastName"
        Me.DeliveryLastNameDataGridViewTextBoxColumn.HeaderText = "deliveryLastName"
        Me.DeliveryLastNameDataGridViewTextBoxColumn.Name = "DeliveryLastNameDataGridViewTextBoxColumn"
        Me.DeliveryLastNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.DeliveryLastNameDataGridViewTextBoxColumn.Visible = False
        '
        'DeliveryPhoneDataGridViewTextBoxColumn
        '
        Me.DeliveryPhoneDataGridViewTextBoxColumn.DataPropertyName = "deliveryPhone"
        Me.DeliveryPhoneDataGridViewTextBoxColumn.HeaderText = "deliveryPhone"
        Me.DeliveryPhoneDataGridViewTextBoxColumn.Name = "DeliveryPhoneDataGridViewTextBoxColumn"
        Me.DeliveryPhoneDataGridViewTextBoxColumn.ReadOnly = True
        Me.DeliveryPhoneDataGridViewTextBoxColumn.Visible = False
        '
        'DeliveryEmailDataGridViewTextBoxColumn
        '
        Me.DeliveryEmailDataGridViewTextBoxColumn.DataPropertyName = "deliveryEmail"
        Me.DeliveryEmailDataGridViewTextBoxColumn.HeaderText = "deliveryEmail"
        Me.DeliveryEmailDataGridViewTextBoxColumn.Name = "DeliveryEmailDataGridViewTextBoxColumn"
        Me.DeliveryEmailDataGridViewTextBoxColumn.ReadOnly = True
        Me.DeliveryEmailDataGridViewTextBoxColumn.Visible = False
        '
        'DeliveryDateDataGridViewTextBoxColumn
        '
        Me.DeliveryDateDataGridViewTextBoxColumn.DataPropertyName = "deliveryDate"
        Me.DeliveryDateDataGridViewTextBoxColumn.HeaderText = "deliveryDate"
        Me.DeliveryDateDataGridViewTextBoxColumn.Name = "DeliveryDateDataGridViewTextBoxColumn"
        Me.DeliveryDateDataGridViewTextBoxColumn.ReadOnly = True
        Me.DeliveryDateDataGridViewTextBoxColumn.Visible = False
        '
        'SubscriptionIdDataGridViewTextBoxColumn
        '
        Me.SubscriptionIdDataGridViewTextBoxColumn.DataPropertyName = "subscriptionId"
        Me.SubscriptionIdDataGridViewTextBoxColumn.HeaderText = "subscriptionId"
        Me.SubscriptionIdDataGridViewTextBoxColumn.Name = "SubscriptionIdDataGridViewTextBoxColumn"
        Me.SubscriptionIdDataGridViewTextBoxColumn.ReadOnly = True
        Me.SubscriptionIdDataGridViewTextBoxColumn.Visible = False
        '
        'ShippingPriceDataGridViewTextBoxColumn
        '
        Me.ShippingPriceDataGridViewTextBoxColumn.DataPropertyName = "shippingPrice"
        Me.ShippingPriceDataGridViewTextBoxColumn.HeaderText = "shippingPrice"
        Me.ShippingPriceDataGridViewTextBoxColumn.Name = "ShippingPriceDataGridViewTextBoxColumn"
        Me.ShippingPriceDataGridViewTextBoxColumn.ReadOnly = True
        Me.ShippingPriceDataGridViewTextBoxColumn.Visible = False
        '
        'DiscountPercentageDataGridViewTextBoxColumn
        '
        Me.DiscountPercentageDataGridViewTextBoxColumn.DataPropertyName = "discountPercentage"
        Me.DiscountPercentageDataGridViewTextBoxColumn.HeaderText = "discountPercentage"
        Me.DiscountPercentageDataGridViewTextBoxColumn.Name = "DiscountPercentageDataGridViewTextBoxColumn"
        Me.DiscountPercentageDataGridViewTextBoxColumn.ReadOnly = True
        Me.DiscountPercentageDataGridViewTextBoxColumn.Visible = False
        '
        'DiscountAbsoluteDataGridViewTextBoxColumn
        '
        Me.DiscountAbsoluteDataGridViewTextBoxColumn.DataPropertyName = "discountAbsolute"
        Me.DiscountAbsoluteDataGridViewTextBoxColumn.HeaderText = "discountAbsolute"
        Me.DiscountAbsoluteDataGridViewTextBoxColumn.Name = "DiscountAbsoluteDataGridViewTextBoxColumn"
        Me.DiscountAbsoluteDataGridViewTextBoxColumn.ReadOnly = True
        Me.DiscountAbsoluteDataGridViewTextBoxColumn.Visible = False
        '
        'NoteDataGridViewTextBoxColumn
        '
        Me.NoteDataGridViewTextBoxColumn.DataPropertyName = "note"
        Me.NoteDataGridViewTextBoxColumn.HeaderText = "note"
        Me.NoteDataGridViewTextBoxColumn.Name = "NoteDataGridViewTextBoxColumn"
        Me.NoteDataGridViewTextBoxColumn.ReadOnly = True
        Me.NoteDataGridViewTextBoxColumn.Visible = False
        '
        'IsPaidDataGridViewCheckBoxColumn
        '
        Me.IsPaidDataGridViewCheckBoxColumn.DataPropertyName = "isPaid"
        Me.IsPaidDataGridViewCheckBoxColumn.HeaderText = "isPaid"
        Me.IsPaidDataGridViewCheckBoxColumn.Name = "IsPaidDataGridViewCheckBoxColumn"
        Me.IsPaidDataGridViewCheckBoxColumn.ReadOnly = True
        Me.IsPaidDataGridViewCheckBoxColumn.Visible = False
        '
        'SentDataGridViewTextBoxColumn
        '
        Me.SentDataGridViewTextBoxColumn.DataPropertyName = "sent"
        Me.SentDataGridViewTextBoxColumn.HeaderText = "sent"
        Me.SentDataGridViewTextBoxColumn.Name = "SentDataGridViewTextBoxColumn"
        Me.SentDataGridViewTextBoxColumn.ReadOnly = True
        Me.SentDataGridViewTextBoxColumn.Visible = False
        '
        'ExportedDataGridViewTextBoxColumn
        '
        Me.ExportedDataGridViewTextBoxColumn.DataPropertyName = "exported"
        Me.ExportedDataGridViewTextBoxColumn.HeaderText = "exported"
        Me.ExportedDataGridViewTextBoxColumn.Name = "ExportedDataGridViewTextBoxColumn"
        Me.ExportedDataGridViewTextBoxColumn.ReadOnly = True
        Me.ExportedDataGridViewTextBoxColumn.Visible = False
        '
        'CreatedDataGridViewTextBoxColumn
        '
        Me.CreatedDataGridViewTextBoxColumn.DataPropertyName = "created"
        Me.CreatedDataGridViewTextBoxColumn.HeaderText = "created"
        Me.CreatedDataGridViewTextBoxColumn.Name = "CreatedDataGridViewTextBoxColumn"
        Me.CreatedDataGridViewTextBoxColumn.ReadOnly = True
        Me.CreatedDataGridViewTextBoxColumn.Visible = False
        '
        'ModifiedDataGridViewTextBoxColumn
        '
        Me.ModifiedDataGridViewTextBoxColumn.DataPropertyName = "modified"
        Me.ModifiedDataGridViewTextBoxColumn.HeaderText = "modified"
        Me.ModifiedDataGridViewTextBoxColumn.Name = "ModifiedDataGridViewTextBoxColumn"
        Me.ModifiedDataGridViewTextBoxColumn.ReadOnly = True
        Me.ModifiedDataGridViewTextBoxColumn.Visible = False
        '
        'IsSubscriptionOrderDataGridViewCheckBoxColumn
        '
        Me.IsSubscriptionOrderDataGridViewCheckBoxColumn.DataPropertyName = "isSubscriptionOrder"
        Me.IsSubscriptionOrderDataGridViewCheckBoxColumn.HeaderText = "isSubscriptionOrder"
        Me.IsSubscriptionOrderDataGridViewCheckBoxColumn.Name = "IsSubscriptionOrderDataGridViewCheckBoxColumn"
        Me.IsSubscriptionOrderDataGridViewCheckBoxColumn.ReadOnly = True
        Me.IsSubscriptionOrderDataGridViewCheckBoxColumn.Visible = False
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        Me.AddressDataGridViewTextBoxColumn.ReadOnly = True
        Me.AddressDataGridViewTextBoxColumn.Visible = False
        '
        'CustomerDataGridViewTextBoxColumn
        '
        Me.CustomerDataGridViewTextBoxColumn.DataPropertyName = "Customer"
        Me.CustomerDataGridViewTextBoxColumn.HeaderText = "Customer"
        Me.CustomerDataGridViewTextBoxColumn.Name = "CustomerDataGridViewTextBoxColumn"
        Me.CustomerDataGridViewTextBoxColumn.ReadOnly = True
        Me.CustomerDataGridViewTextBoxColumn.Visible = False
        '
        'DeliveryMethodDataGridViewTextBoxColumn
        '
        Me.DeliveryMethodDataGridViewTextBoxColumn.DataPropertyName = "DeliveryMethod"
        Me.DeliveryMethodDataGridViewTextBoxColumn.HeaderText = "DeliveryMethod"
        Me.DeliveryMethodDataGridViewTextBoxColumn.Name = "DeliveryMethodDataGridViewTextBoxColumn"
        Me.DeliveryMethodDataGridViewTextBoxColumn.ReadOnly = True
        Me.DeliveryMethodDataGridViewTextBoxColumn.Visible = False
        '
        'EmployeeDataGridViewTextBoxColumn
        '
        Me.EmployeeDataGridViewTextBoxColumn.DataPropertyName = "Employee"
        Me.EmployeeDataGridViewTextBoxColumn.HeaderText = "Employee"
        Me.EmployeeDataGridViewTextBoxColumn.Name = "EmployeeDataGridViewTextBoxColumn"
        Me.EmployeeDataGridViewTextBoxColumn.ReadOnly = True
        Me.EmployeeDataGridViewTextBoxColumn.Visible = False
        '
        'frmLogisticsPackingList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(635, 532)
        Me.Controls.Add(Me.grpPerformOnOrders)
        Me.Controls.Add(Me.btnMarkUnsent)
        Me.Controls.Add(Me.lblPickDate)
        Me.Controls.Add(Me.dtpPackingList)
        Me.Controls.Add(Me.lblOrdersToEnvoyDate)
        Me.Controls.Add(Me.dtgPackingList)
        Me.Name = "frmLogisticsPackingList"
        Me.Text = "Pakkseddel"
        Me.Controls.SetChildIndex(Me.dtgPackingList, 0)
        Me.Controls.SetChildIndex(Me.lblOrdersToEnvoyDate, 0)
        Me.Controls.SetChildIndex(Me.dtpPackingList, 0)
        Me.Controls.SetChildIndex(Me.lblPickDate, 0)
        Me.Controls.SetChildIndex(Me.btnMarkUnsent, 0)
        Me.Controls.SetChildIndex(Me.grpPerformOnOrders, 0)
        CType(Me.dtgPackingList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPerformOnOrders.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtgPackingList As System.Windows.Forms.DataGridView
    Friend WithEvents lblOrdersToEnvoyDate As System.Windows.Forms.Label
    Friend WithEvents dtpPackingList As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblPickDate As System.Windows.Forms.Label
    Friend WithEvents btnMarkUnsent As System.Windows.Forms.Button
    Friend WithEvents btnPrintPackingList As System.Windows.Forms.Button
    Friend WithEvents grpPerformOnOrders As System.Windows.Forms.GroupBox
    Friend WithEvents btnSetStatus As System.Windows.Forms.Button
    Friend WithEvents cboStatusSetOrder As System.Windows.Forms.ComboBox
    Friend WithEvents OrderBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents cnOrderId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cnDeliveryTo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cnAddress As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cnZip As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cnStatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DeliveryFirstNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DeliveryLastNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DeliveryPhoneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DeliveryEmailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DeliveryDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubscriptionIdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ShippingPriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DiscountPercentageDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DiscountAbsoluteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NoteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IsPaidDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents SentDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ExportedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CreatedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ModifiedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IsSubscriptionOrderDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustomerDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DeliveryMethodDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmployeeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
