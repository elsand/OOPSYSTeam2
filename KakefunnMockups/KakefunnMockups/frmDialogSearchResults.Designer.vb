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
        Me.dtgSearchResultsOrders = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtgSearchResultsCustomers = New System.Windows.Forms.DataGridView()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblHitsInOrders = New System.Windows.Forms.Label()
        Me.lblHitsInCustomers = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.grpSearchResults = New System.Windows.Forms.GroupBox()
        CType(Me.dtgSearchResultsOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgSearchResultsCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSearchResults.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtgSearchResultsOrders
        '
        Me.dtgSearchResultsOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgSearchResultsOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgSearchResultsOrders.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.dtgSearchResultsOrders.Location = New System.Drawing.Point(18, 42)
        Me.dtgSearchResultsOrders.Name = "dtgSearchResultsOrders"
        Me.dtgSearchResultsOrders.RowHeadersVisible = False
        Me.dtgSearchResultsOrders.Size = New System.Drawing.Size(504, 209)
        Me.dtgSearchResultsOrders.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "Ordrenr"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Ordredato"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Ordreverdi"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Bestiller"
        Me.Column4.Name = "Column4"
        '
        'dtgSearchResultsCustomers
        '
        Me.dtgSearchResultsCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgSearchResultsCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgSearchResultsCustomers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column5, Me.Column6, Me.Column7, Me.Column8})
        Me.dtgSearchResultsCustomers.Location = New System.Drawing.Point(18, 296)
        Me.dtgSearchResultsCustomers.Name = "dtgSearchResultsCustomers"
        Me.dtgSearchResultsCustomers.RowHeadersVisible = False
        Me.dtgSearchResultsCustomers.Size = New System.Drawing.Size(504, 209)
        Me.dtgSearchResultsCustomers.TabIndex = 1
        '
        'Column5
        '
        Me.Column5.HeaderText = "Kundenr"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Navn"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "E-post"
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.HeaderText = "Telefon"
        Me.Column8.Name = "Column8"
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
        Me.btnClose.Location = New System.Drawing.Point(236, 559)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "Lukk"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'grpSearchResults
        '
        Me.grpSearchResults.Controls.Add(Me.lblHitsInOrders)
        Me.grpSearchResults.Controls.Add(Me.dtgSearchResultsOrders)
        Me.grpSearchResults.Controls.Add(Me.lblHitsInCustomers)
        Me.grpSearchResults.Controls.Add(Me.dtgSearchResultsCustomers)
        Me.grpSearchResults.Location = New System.Drawing.Point(12, 12)
        Me.grpSearchResults.Name = "grpSearchResults"
        Me.grpSearchResults.Size = New System.Drawing.Size(542, 529)
        Me.grpSearchResults.TabIndex = 5
        Me.grpSearchResults.TabStop = False
        Me.grpSearchResults.Text = "Søkeresultater etter ""xxxx"""
        '
        'frmDialogSearchResults
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(566, 600)
        Me.Controls.Add(Me.grpSearchResults)
        Me.Controls.Add(Me.btnClose)
        Me.Name = "frmDialogSearchResults"
        Me.Text = "Søk etter ""xxxx"""
        CType(Me.dtgSearchResultsOrders, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgSearchResultsCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSearchResults.ResumeLayout(False)
        Me.grpSearchResults.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dtgSearchResultsOrders As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dtgSearchResultsCustomers As System.Windows.Forms.DataGridView
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblHitsInOrders As System.Windows.Forms.Label
    Friend WithEvents lblHitsInCustomers As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents grpSearchResults As System.Windows.Forms.GroupBox

End Class
