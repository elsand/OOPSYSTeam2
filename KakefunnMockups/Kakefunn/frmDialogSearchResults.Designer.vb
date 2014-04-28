<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDialogSearchResults
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblHitsInOrders = New System.Windows.Forms.Label()
        Me.lblHitsInCustomers = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.grpSearchResults = New System.Windows.Forms.GroupBox()
        Me.dtgSearchResultsCustomers = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dcCustomerEmail = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dtgSearchResultsOrders = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dcOrderPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dcCustomer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.grpSearchResults.SuspendLayout()
        CType(Me.dtgSearchResultsCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgSearchResultsOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHitsInOrders
        '
        Me.lblHitsInOrders.AutoSize = True
        Me.lblHitsInOrders.Location = New System.Drawing.Point(15, 26)
        Me.lblHitsInOrders.Name = "lblHitsInOrders"
        Me.lblHitsInOrders.Size = New System.Drawing.Size(81, 13)
        Me.lblHitsInOrders.TabIndex = 2
        Me.lblHitsInOrders.Text = "123 treff i ordrer"
        '
        'lblHitsInCustomers
        '
        Me.lblHitsInCustomers.AutoSize = True
        Me.lblHitsInCustomers.Location = New System.Drawing.Point(15, 280)
        Me.lblHitsInCustomers.Name = "lblHitsInCustomers"
        Me.lblHitsInCustomers.Size = New System.Drawing.Size(75, 13)
        Me.lblHitsInCustomers.TabIndex = 3
        Me.lblHitsInCustomers.Text = "4 treff i kunder"
        '
        'btnClose
        '
        Me.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnClose.Location = New System.Drawing.Point(236, 559)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "Lukk"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'grpSearchResults
        '
        Me.grpSearchResults.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpSearchResults.Controls.Add(Me.dtgSearchResultsCustomers)
        Me.grpSearchResults.Controls.Add(Me.dtgSearchResultsOrders)
        Me.grpSearchResults.Controls.Add(Me.lblHitsInOrders)
        Me.grpSearchResults.Controls.Add(Me.lblHitsInCustomers)
        Me.grpSearchResults.Location = New System.Drawing.Point(12, 12)
        Me.grpSearchResults.Name = "grpSearchResults"
        Me.grpSearchResults.Size = New System.Drawing.Size(542, 530)
        Me.grpSearchResults.TabIndex = 0
        Me.grpSearchResults.TabStop = False
        Me.grpSearchResults.Text = "Søkeresultater etter ""xxxx"""
        '
        'dtgSearchResultsCustomers
        '
        Me.dtgSearchResultsCustomers.AllowUserToAddRows = False
        Me.dtgSearchResultsCustomers.AllowUserToDeleteRows = False
        Me.dtgSearchResultsCustomers.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtgSearchResultsCustomers.AutoGenerateColumns = False
        Me.dtgSearchResultsCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgSearchResultsCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgSearchResultsCustomers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.dcCustomerEmail, Me.DataGridViewTextBoxColumn4})
        Me.dtgSearchResultsCustomers.DataSource = Me.CustomerBindingSource
        Me.dtgSearchResultsCustomers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtgSearchResultsCustomers.Location = New System.Drawing.Point(18, 296)
        Me.dtgSearchResultsCustomers.Name = "dtgSearchResultsCustomers"
        Me.dtgSearchResultsCustomers.RowHeadersVisible = False
        Me.dtgSearchResultsCustomers.Size = New System.Drawing.Size(504, 220)
        Me.dtgSearchResultsCustomers.TabIndex = 1
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "id"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn2.FillWeight = 45.0!
        Me.DataGridViewTextBoxColumn2.HeaderText = "Kundenr"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'dcCustomerEmail
        '
        Me.dcCustomerEmail.DataPropertyName = "email"
        Me.dcCustomerEmail.HeaderText = "E-post"
        Me.dcCustomerEmail.Name = "dcCustomerEmail"
        Me.dcCustomerEmail.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dcCustomerEmail.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.dcCustomerEmail.TrackVisitedState = False
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "phone"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn4.HeaderText = "Telefon"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataSource = GetType(Kakefunn.Customer)
        '
        'dtgSearchResultsOrders
        '
        Me.dtgSearchResultsOrders.AllowUserToAddRows = False
        Me.dtgSearchResultsOrders.AllowUserToDeleteRows = False
        Me.dtgSearchResultsOrders.AllowUserToResizeRows = False
        Me.dtgSearchResultsOrders.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtgSearchResultsOrders.AutoGenerateColumns = False
        Me.dtgSearchResultsOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgSearchResultsOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgSearchResultsOrders.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn13, Me.dcOrderPrice, Me.dcCustomer})
        Me.dtgSearchResultsOrders.DataSource = Me.OrderBindingSource
        Me.dtgSearchResultsOrders.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtgSearchResultsOrders.Location = New System.Drawing.Point(18, 43)
        Me.dtgSearchResultsOrders.Name = "dtgSearchResultsOrders"
        Me.dtgSearchResultsOrders.RowHeadersVisible = False
        Me.dtgSearchResultsOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgSearchResultsOrders.Size = New System.Drawing.Size(504, 220)
        Me.dtgSearchResultsOrders.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn1.FillWeight = 45.0!
        Me.DataGridViewTextBoxColumn1.HeaderText = "Ordrenr"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "created"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Ordredato"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'dcOrderPrice
        '
        Me.dcOrderPrice.FillWeight = 80.0!
        Me.dcOrderPrice.HeaderText = "Ordreverdi"
        Me.dcOrderPrice.Name = "dcOrderPrice"
        '
        'dcCustomer
        '
        Me.dcCustomer.DataPropertyName = "Customer"
        Me.dcCustomer.FillWeight = 170.0!
        Me.dcCustomer.HeaderText = "Bestiller"
        Me.dcCustomer.Name = "dcCustomer"
        '
        'OrderBindingSource
        '
        Me.OrderBindingSource.DataSource = GetType(Kakefunn.Order)
        '
        'frmDialogSearchResults
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(566, 615)
        Me.Controls.Add(Me.grpSearchResults)
        Me.Controls.Add(Me.btnClose)
        Me.MinimumSize = New System.Drawing.Size(582, 654)
        Me.Name = "frmDialogSearchResults"
        Me.Text = "Søk etter ""xxxx"""
        Me.grpSearchResults.ResumeLayout(False)
        Me.grpSearchResults.PerformLayout()
        CType(Me.dtgSearchResultsCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgSearchResultsOrders, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblHitsInOrders As System.Windows.Forms.Label
    Friend WithEvents lblHitsInCustomers As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents grpSearchResults As System.Windows.Forms.GroupBox
    Friend WithEvents dtgSearchResultsOrders As System.Windows.Forms.DataGridView
    Friend WithEvents OrderBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dtgSearchResultsCustomers As System.Windows.Forms.DataGridView
    Friend WithEvents CustomerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dcCustomerEmail As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dcOrderPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dcCustomer As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
