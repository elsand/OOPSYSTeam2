<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.btnNewOrder = New System.Windows.Forms.Button()
        Me.btnNewCustomer = New System.Windows.Forms.Button()
        Me.grpRegistration = New System.Windows.Forms.GroupBox()
        Me.grpSearch = New System.Windows.Forms.GroupBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.lblSearchInformation = New System.Windows.Forms.Label()
        Me.txtSearchInformation = New System.Windows.Forms.TextBox()
        Me.lblLast5ProcessedOrder = New System.Windows.Forms.Label()
        Me.lblLast5ProcessedCustomers = New System.Windows.Forms.Label()
        Me.dtgLast5ProcessedCustomers = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtgLast5ProcessedOrder = New System.Windows.Forms.DataGridView()
        Me.grpRegistration.SuspendLayout()
        Me.grpSearch.SuspendLayout()
        CType(Me.dtgLast5ProcessedCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgLast5ProcessedOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnNewOrder
        '
        Me.btnNewOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewOrder.Location = New System.Drawing.Point(20, 27)
        Me.btnNewOrder.Name = "btnNewOrder"
        Me.btnNewOrder.Size = New System.Drawing.Size(105, 31)
        Me.btnNewOrder.TabIndex = 0
        Me.btnNewOrder.Text = "Ny ordre ..."
        Me.btnNewOrder.UseVisualStyleBackColor = True
        '
        'btnNewCustomer
        '
        Me.btnNewCustomer.Location = New System.Drawing.Point(144, 28)
        Me.btnNewCustomer.Name = "btnNewCustomer"
        Me.btnNewCustomer.Size = New System.Drawing.Size(105, 31)
        Me.btnNewCustomer.TabIndex = 1
        Me.btnNewCustomer.Text = "Ny kunde ..."
        Me.btnNewCustomer.UseVisualStyleBackColor = True
        '
        'grpRegistration
        '
        Me.grpRegistration.Controls.Add(Me.btnNewOrder)
        Me.grpRegistration.Controls.Add(Me.btnNewCustomer)
        Me.grpRegistration.Location = New System.Drawing.Point(11, 35)
        Me.grpRegistration.Name = "grpRegistration"
        Me.grpRegistration.Size = New System.Drawing.Size(272, 80)
        Me.grpRegistration.TabIndex = 2
        Me.grpRegistration.TabStop = False
        Me.grpRegistration.Text = "Registrering"
        '
        'grpSearch
        '
        Me.grpSearch.Controls.Add(Me.btnSearch)
        Me.grpSearch.Controls.Add(Me.lblSearchInformation)
        Me.grpSearch.Controls.Add(Me.txtSearchInformation)
        Me.grpSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.grpSearch.Location = New System.Drawing.Point(326, 35)
        Me.grpSearch.Name = "grpSearch"
        Me.grpSearch.Size = New System.Drawing.Size(272, 83)
        Me.grpSearch.TabIndex = 3
        Me.grpSearch.TabStop = False
        Me.grpSearch.Text = "Søk"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(188, 41)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(61, 23)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "Søk"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'lblSearchInformation
        '
        Me.lblSearchInformation.AutoSize = True
        Me.lblSearchInformation.Location = New System.Drawing.Point(15, 16)
        Me.lblSearchInformation.Name = "lblSearchInformation"
        Me.lblSearchInformation.Size = New System.Drawing.Size(215, 13)
        Me.lblSearchInformation.TabIndex = 1
        Me.lblSearchInformation.Text = "Oppgi kundenr/ordrenr/navn/epost/telefon:"
        '
        'txtSearchInformation
        '
        Me.txtSearchInformation.Location = New System.Drawing.Point(18, 43)
        Me.txtSearchInformation.Name = "txtSearchInformation"
        Me.txtSearchInformation.Size = New System.Drawing.Size(160, 20)
        Me.txtSearchInformation.TabIndex = 0
        '
        'lblLast5ProcessedOrder
        '
        Me.lblLast5ProcessedOrder.AutoSize = True
        Me.lblLast5ProcessedOrder.Location = New System.Drawing.Point(13, 141)
        Me.lblLast5ProcessedOrder.Name = "lblLast5ProcessedOrder"
        Me.lblLast5ProcessedOrder.Size = New System.Drawing.Size(128, 13)
        Me.lblLast5ProcessedOrder.TabIndex = 5
        Me.lblLast5ProcessedOrder.Text = "Siste 5 behandlede ordrer"
        '
        'lblLast5ProcessedCustomers
        '
        Me.lblLast5ProcessedCustomers.AutoSize = True
        Me.lblLast5ProcessedCustomers.Location = New System.Drawing.Point(12, 257)
        Me.lblLast5ProcessedCustomers.Name = "lblLast5ProcessedCustomers"
        Me.lblLast5ProcessedCustomers.Size = New System.Drawing.Size(134, 13)
        Me.lblLast5ProcessedCustomers.TabIndex = 7
        Me.lblLast5ProcessedCustomers.Text = "Siste 5 behandlede kunder"
        '
        'dtgLast5ProcessedCustomers
        '
        Me.dtgLast5ProcessedCustomers.AllowUserToAddRows = False
        Me.dtgLast5ProcessedCustomers.AllowUserToDeleteRows = False
        Me.dtgLast5ProcessedCustomers.AllowUserToOrderColumns = True
        Me.dtgLast5ProcessedCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgLast5ProcessedCustomers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dtgLast5ProcessedCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgLast5ProcessedCustomers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn3, Me.Column7, Me.DataGridViewTextBoxColumn4, Me.Column8, Me.Column9})
        Me.dtgLast5ProcessedCustomers.Location = New System.Drawing.Point(11, 276)
        Me.dtgLast5ProcessedCustomers.Name = "dtgLast5ProcessedCustomers"
        Me.dtgLast5ProcessedCustomers.Size = New System.Drawing.Size(586, 79)
        Me.dtgLast5ProcessedCustomers.TabIndex = 6
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Sist redigert"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Kundenr"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'Column7
        '
        Me.Column7.HeaderText = "Firmakunde"
        Me.Column7.Name = "Column7"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Navn"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'Column8
        '
        Me.Column8.HeaderText = "Telefon"
        Me.Column8.Name = "Column8"
        '
        'Column9
        '
        Me.Column9.HeaderText = "Epost"
        Me.Column9.Name = "Column9"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Beløp"
        Me.Column4.Name = "Column4"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Leveringsadresse"
        Me.Column6.Name = "Column6"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Navn"
        Me.Column3.Name = "Column3"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Kundenr"
        Me.Column2.Name = "Column2"
        '
        'Column1
        '
        Me.Column1.HeaderText = "Ordrenr"
        Me.Column1.Name = "Column1"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Sist redigert"
        Me.Column5.Name = "Column5"
        '
        'dtgLast5ProcessedOrder
        '
        Me.dtgLast5ProcessedOrder.AllowUserToAddRows = False
        Me.dtgLast5ProcessedOrder.AllowUserToDeleteRows = False
        Me.dtgLast5ProcessedOrder.AllowUserToOrderColumns = True
        Me.dtgLast5ProcessedOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgLast5ProcessedOrder.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dtgLast5ProcessedOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgLast5ProcessedOrder.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column5, Me.Column1, Me.Column2, Me.Column3, Me.Column6, Me.Column4})
        Me.dtgLast5ProcessedOrder.Location = New System.Drawing.Point(12, 160)
        Me.dtgLast5ProcessedOrder.Name = "dtgLast5ProcessedOrder"
        Me.dtgLast5ProcessedOrder.Size = New System.Drawing.Size(586, 79)
        Me.dtgLast5ProcessedOrder.TabIndex = 4
        '
        'frmSaleMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(618, 397)
        Me.Controls.Add(Me.lblLast5ProcessedCustomers)
        Me.Controls.Add(Me.dtgLast5ProcessedCustomers)
        Me.Controls.Add(Me.lblLast5ProcessedOrder)
        Me.Controls.Add(Me.dtgLast5ProcessedOrder)
        Me.Controls.Add(Me.grpSearch)
        Me.Controls.Add(Me.grpRegistration)
        Me.Name = "frmSaleMain"
        Me.Text = "Salg"
        Me.Controls.SetChildIndex(Me.grpRegistration, 0)
        Me.Controls.SetChildIndex(Me.grpSearch, 0)
        Me.Controls.SetChildIndex(Me.dtgLast5ProcessedOrder, 0)
        Me.Controls.SetChildIndex(Me.lblLast5ProcessedOrder, 0)
        Me.Controls.SetChildIndex(Me.dtgLast5ProcessedCustomers, 0)
        Me.Controls.SetChildIndex(Me.lblLast5ProcessedCustomers, 0)
        Me.grpRegistration.ResumeLayout(False)
        Me.grpSearch.ResumeLayout(False)
        Me.grpSearch.PerformLayout()
        CType(Me.dtgLast5ProcessedCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgLast5ProcessedOrder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnNewOrder As System.Windows.Forms.Button
    Friend WithEvents btnNewCustomer As System.Windows.Forms.Button
    Friend WithEvents grpRegistration As System.Windows.Forms.GroupBox
    Friend WithEvents grpSearch As System.Windows.Forms.GroupBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents lblSearchInformation As System.Windows.Forms.Label
    Friend WithEvents txtSearchInformation As System.Windows.Forms.TextBox
    Friend WithEvents lblLast5ProcessedOrder As System.Windows.Forms.Label
    Friend WithEvents lblLast5ProcessedCustomers As System.Windows.Forms.Label
    Friend WithEvents dtgLast5ProcessedCustomers As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dtgLast5ProcessedOrder As System.Windows.Forms.DataGridView

End Class
