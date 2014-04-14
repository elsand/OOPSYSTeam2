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
        Me.dtgPackingList = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblOrdersToEnvoyDate = New System.Windows.Forms.Label()
        Me.dtpPackingList = New System.Windows.Forms.DateTimePicker()
        Me.lblPickDate = New System.Windows.Forms.Label()
        Me.btnMarkUnsent = New System.Windows.Forms.Button()
        Me.btnPrintPackingList = New System.Windows.Forms.Button()
        Me.grpPerformOnOrders = New System.Windows.Forms.GroupBox()
        Me.btnSetStatus = New System.Windows.Forms.Button()
        Me.cboStatusSetOrder = New System.Windows.Forms.ComboBox()
        CType(Me.dtgPackingList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPerformOnOrders.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtgPackingList
        '
        Me.dtgPackingList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgPackingList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgPackingList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column5, Me.Column3, Me.Column6})
        Me.dtgPackingList.Location = New System.Drawing.Point(12, 90)
        Me.dtgPackingList.Name = "dtgPackingList"
        Me.dtgPackingList.RowHeadersVisible = False
        Me.dtgPackingList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgPackingList.Size = New System.Drawing.Size(611, 348)
        Me.dtgPackingList.TabIndex = 6
        '
        'Column1
        '
        Me.Column1.HeaderText = "Ordrenr"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Leveres til"
        Me.Column2.Name = "Column2"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Adresse"
        Me.Column5.Name = "Column5"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Postnr/sted"
        Me.Column3.Name = "Column3"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Status"
        Me.Column6.Name = "Column6"
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
        Me.cboStatusSetOrder.Items.AddRange(New Object() {"Sendt"})
        Me.cboStatusSetOrder.Location = New System.Drawing.Point(243, 20)
        Me.cboStatusSetOrder.Name = "cboStatusSetOrder"
        Me.cboStatusSetOrder.Size = New System.Drawing.Size(70, 21)
        Me.cboStatusSetOrder.TabIndex = 2
        Me.cboStatusSetOrder.Text = "Sendt"
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
        Me.grpPerformOnOrders.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtgPackingList As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblOrdersToEnvoyDate As System.Windows.Forms.Label
    Friend WithEvents dtpPackingList As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblPickDate As System.Windows.Forms.Label
    Friend WithEvents btnMarkUnsent As System.Windows.Forms.Button
    Friend WithEvents btnPrintPackingList As System.Windows.Forms.Button
    Friend WithEvents grpPerformOnOrders As System.Windows.Forms.GroupBox
    Friend WithEvents btnSetStatus As System.Windows.Forms.Button
    Friend WithEvents cboStatusSetOrder As System.Windows.Forms.ComboBox

End Class
