﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSaleMain
    Inherits Kakefunn.frmSaleBase

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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblLast5ProcessedOrder = New System.Windows.Forms.Label()
        Me.lblLast5ProcessedCustomers = New System.Windows.Forms.Label()
        Me.OrderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dgvOrder = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dcCustomerId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dcCustomerName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dcOrderAddress = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dcOrderTotalPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dgvCustomer = New System.Windows.Forms.DataGridView()
        Me.modified = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dcCustomerType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fullName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dcCustomerEmail = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.OrderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblLast5ProcessedOrder
        '
        Me.lblLast5ProcessedOrder.AutoSize = True
        Me.lblLast5ProcessedOrder.Location = New System.Drawing.Point(14, 11)
        Me.lblLast5ProcessedOrder.Name = "lblLast5ProcessedOrder"
        Me.lblLast5ProcessedOrder.Size = New System.Drawing.Size(134, 13)
        Me.lblLast5ProcessedOrder.TabIndex = 5
        Me.lblLast5ProcessedOrder.Text = "Siste 10 behandlede ordrer"
        '
        'lblLast5ProcessedCustomers
        '
        Me.lblLast5ProcessedCustomers.AutoSize = True
        Me.lblLast5ProcessedCustomers.Location = New System.Drawing.Point(9, 234)
        Me.lblLast5ProcessedCustomers.Name = "lblLast5ProcessedCustomers"
        Me.lblLast5ProcessedCustomers.Size = New System.Drawing.Size(140, 13)
        Me.lblLast5ProcessedCustomers.TabIndex = 7
        Me.lblLast5ProcessedCustomers.Text = "Siste 10 behandlede kunder"
        '
        'OrderBindingSource
        '
        Me.OrderBindingSource.DataSource = GetType(Kakefunn.Order)
        '
        'dgvOrder
        '
        Me.dgvOrder.AllowUserToAddRows = False
        Me.dgvOrder.AllowUserToDeleteRows = False
        Me.dgvOrder.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvOrder.AutoGenerateColumns = False
        Me.dgvOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOrder.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn2, Me.dcCustomerId, Me.dcCustomerName, Me.dcOrderAddress, Me.dcOrderTotalPrice})
        Me.dgvOrder.DataSource = Me.OrderBindingSource
        Me.dgvOrder.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvOrder.Location = New System.Drawing.Point(12, 27)
        Me.dgvOrder.Name = "dgvOrder"
        Me.dgvOrder.RowHeadersVisible = False
        Me.dgvOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvOrder.Size = New System.Drawing.Size(557, 189)
        Me.dgvOrder.TabIndex = 9
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "modified"
        Me.DataGridViewTextBoxColumn17.FillWeight = 90.0!
        Me.DataGridViewTextBoxColumn17.HeaderText = "Sist redigert"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "id"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn2.FillWeight = 45.0!
        Me.DataGridViewTextBoxColumn2.HeaderText = "Ordrenr"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'dcCustomerId
        '
        Me.dcCustomerId.DataPropertyName = "Customer"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.dcCustomerId.DefaultCellStyle = DataGridViewCellStyle2
        Me.dcCustomerId.FillWeight = 45.0!
        Me.dcCustomerId.HeaderText = "Kundenr"
        Me.dcCustomerId.Name = "dcCustomerId"
        '
        'dcCustomerName
        '
        Me.dcCustomerName.DataPropertyName = "Customer"
        Me.dcCustomerName.FillWeight = 110.0!
        Me.dcCustomerName.HeaderText = "Navn"
        Me.dcCustomerName.Name = "dcCustomerName"
        '
        'dcOrderAddress
        '
        Me.dcOrderAddress.DataPropertyName = "Address"
        Me.dcOrderAddress.FillWeight = 160.0!
        Me.dcOrderAddress.HeaderText = "Leveringsadresse"
        Me.dcOrderAddress.Name = "dcOrderAddress"
        '
        'dcOrderTotalPrice
        '
        Me.dcOrderTotalPrice.DataPropertyName = "id"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.dcOrderTotalPrice.DefaultCellStyle = DataGridViewCellStyle3
        Me.dcOrderTotalPrice.FillWeight = 60.0!
        Me.dcOrderTotalPrice.HeaderText = "Beløp"
        Me.dcOrderTotalPrice.Name = "dcOrderTotalPrice"
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataSource = GetType(Kakefunn.Customer)
        '
        'dgvCustomer
        '
        Me.dgvCustomer.AllowUserToAddRows = False
        Me.dgvCustomer.AllowUserToDeleteRows = False
        Me.dgvCustomer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvCustomer.AutoGenerateColumns = False
        Me.dgvCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCustomer.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.modified, Me.DataGridViewTextBoxColumn5, Me.dcCustomerType, Me.fullName, Me.DataGridViewTextBoxColumn7, Me.dcCustomerEmail})
        Me.dgvCustomer.DataSource = Me.CustomerBindingSource
        Me.dgvCustomer.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvCustomer.Location = New System.Drawing.Point(12, 250)
        Me.dgvCustomer.Name = "dgvCustomer"
        Me.dgvCustomer.RowHeadersVisible = False
        Me.dgvCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCustomer.Size = New System.Drawing.Size(557, 189)
        Me.dgvCustomer.TabIndex = 9
        '
        'modified
        '
        Me.modified.DataPropertyName = "modified"
        Me.modified.HeaderText = "Sist redigert"
        Me.modified.Name = "modified"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "id"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn5.FillWeight = 50.0!
        Me.DataGridViewTextBoxColumn5.HeaderText = "Kundenr"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'dcCustomerType
        '
        Me.dcCustomerType.DataPropertyName = "CustomerType"
        Me.dcCustomerType.HeaderText = "Kundetype"
        Me.dcCustomerType.Name = "dcCustomerType"
        '
        'fullName
        '
        Me.fullName.DataPropertyName = "fullName"
        Me.fullName.HeaderText = "Navn"
        Me.fullName.Name = "fullName"
        Me.fullName.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "phone"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn7.FillWeight = 80.0!
        Me.DataGridViewTextBoxColumn7.HeaderText = "Telefon"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'dcCustomerEmail
        '
        Me.dcCustomerEmail.DataPropertyName = "email"
        Me.dcCustomerEmail.FillWeight = 120.0!
        Me.dcCustomerEmail.HeaderText = "E-post"
        Me.dcCustomerEmail.Name = "dcCustomerEmail"
        Me.dcCustomerEmail.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dcCustomerEmail.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.dcCustomerEmail.TrackVisitedState = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(438, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Dobbeltklikk for å redigere"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(441, 232)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Dobbeltklikk for å redigere"
        '
        'frmSaleMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 453)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvCustomer)
        Me.Controls.Add(Me.dgvOrder)
        Me.Controls.Add(Me.lblLast5ProcessedCustomers)
        Me.Controls.Add(Me.lblLast5ProcessedOrder)
        Me.MinimumSize = New System.Drawing.Size(602, 491)
        Me.Name = "frmSaleMain"
        Me.Text = "Siste 10"
        CType(Me.OrderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvOrder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblLast5ProcessedOrder As System.Windows.Forms.Label
    Friend WithEvents lblLast5ProcessedCustomers As System.Windows.Forms.Label
    Friend WithEvents OrderBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dgvOrder As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dcCustomerId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dcCustomerName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dcOrderAddress As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dcOrderTotalPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustomerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dgvCustomer As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents modified As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dcCustomerType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fullName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dcCustomerEmail As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
