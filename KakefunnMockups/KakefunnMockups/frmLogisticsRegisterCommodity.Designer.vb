<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogisticsRegisterCommodity
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
        Me.grpEditSelectedBatch = New System.Windows.Forms.GroupBox()
        Me.dtpExpireDate = New System.Windows.Forms.DateTimePicker()
        Me.lblExpireDate = New System.Windows.Forms.Label()
        Me.btnSuggestLocation = New System.Windows.Forms.Button()
        Me.txtShelf = New System.Windows.Forms.TextBox()
        Me.lblShelf = New System.Windows.Forms.Label()
        Me.lblRack = New System.Windows.Forms.Label()
        Me.txtRack = New System.Windows.Forms.TextBox()
        Me.btnRegisterBatchInStock = New System.Windows.Forms.Button()
        Me.btnSearchBatch = New System.Windows.Forms.Button()
        Me.txtSearchBatch = New System.Windows.Forms.TextBox()
        Me.lblSearchBatch = New System.Windows.Forms.Label()
        Me.dtgLogisticsRegisterCommodity = New System.Windows.Forms.DataGridView()
        Me.Partinr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblShowBatchExpectedInStock = New System.Windows.Forms.Label()
        Me.dtpBatchExpectedInStock = New System.Windows.Forms.DateTimePicker()
        Me.grpEditSelectedBatch.SuspendLayout()
        CType(Me.dtgLogisticsRegisterCommodity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpEditSelectedBatch
        '
        Me.grpEditSelectedBatch.Controls.Add(Me.dtpExpireDate)
        Me.grpEditSelectedBatch.Controls.Add(Me.lblExpireDate)
        Me.grpEditSelectedBatch.Controls.Add(Me.btnSuggestLocation)
        Me.grpEditSelectedBatch.Controls.Add(Me.txtShelf)
        Me.grpEditSelectedBatch.Controls.Add(Me.lblShelf)
        Me.grpEditSelectedBatch.Controls.Add(Me.lblRack)
        Me.grpEditSelectedBatch.Controls.Add(Me.txtRack)
        Me.grpEditSelectedBatch.Controls.Add(Me.btnRegisterBatchInStock)
        Me.grpEditSelectedBatch.Location = New System.Drawing.Point(12, 402)
        Me.grpEditSelectedBatch.Name = "grpEditSelectedBatch"
        Me.grpEditSelectedBatch.Size = New System.Drawing.Size(686, 64)
        Me.grpEditSelectedBatch.TabIndex = 6
        Me.grpEditSelectedBatch.TabStop = False
        Me.grpEditSelectedBatch.Text = "Rediger valgt parti"
        '
        'dtpExpireDate
        '
        Me.dtpExpireDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpExpireDate.Location = New System.Drawing.Point(410, 19)
        Me.dtpExpireDate.Name = "dtpExpireDate"
        Me.dtpExpireDate.Size = New System.Drawing.Size(100, 20)
        Me.dtpExpireDate.TabIndex = 24
        '
        'lblExpireDate
        '
        Me.lblExpireDate.AutoSize = True
        Me.lblExpireDate.Location = New System.Drawing.Point(346, 23)
        Me.lblExpireDate.Name = "lblExpireDate"
        Me.lblExpireDate.Size = New System.Drawing.Size(58, 13)
        Me.lblExpireDate.TabIndex = 23
        Me.lblExpireDate.Text = "Utløpsdato"
        '
        'btnSuggestLocation
        '
        Me.btnSuggestLocation.Location = New System.Drawing.Point(214, 18)
        Me.btnSuggestLocation.Name = "btnSuggestLocation"
        Me.btnSuggestLocation.Size = New System.Drawing.Size(99, 23)
        Me.btnSuggestLocation.TabIndex = 14
        Me.btnSuggestLocation.Text = "Foreslå plassering"
        Me.btnSuggestLocation.UseVisualStyleBackColor = True
        '
        'txtShelf
        '
        Me.txtShelf.Location = New System.Drawing.Point(161, 20)
        Me.txtShelf.Name = "txtShelf"
        Me.txtShelf.Size = New System.Drawing.Size(37, 20)
        Me.txtShelf.TabIndex = 13
        '
        'lblShelf
        '
        Me.lblShelf.AutoSize = True
        Me.lblShelf.Location = New System.Drawing.Point(119, 23)
        Me.lblShelf.Name = "lblShelf"
        Me.lblShelf.Size = New System.Drawing.Size(30, 13)
        Me.lblShelf.TabIndex = 12
        Me.lblShelf.Text = "Hylle"
        '
        'lblRack
        '
        Me.lblRack.AutoSize = True
        Me.lblRack.Location = New System.Drawing.Point(11, 23)
        Me.lblRack.Name = "lblRack"
        Me.lblRack.Size = New System.Drawing.Size(29, 13)
        Me.lblRack.TabIndex = 11
        Me.lblRack.Text = "Reol"
        '
        'txtRack
        '
        Me.txtRack.Location = New System.Drawing.Point(56, 20)
        Me.txtRack.Name = "txtRack"
        Me.txtRack.Size = New System.Drawing.Size(37, 20)
        Me.txtRack.TabIndex = 10
        '
        'btnRegisterBatchInStock
        '
        Me.btnRegisterBatchInStock.Location = New System.Drawing.Point(554, 16)
        Me.btnRegisterBatchInStock.Name = "btnRegisterBatchInStock"
        Me.btnRegisterBatchInStock.Size = New System.Drawing.Size(126, 27)
        Me.btnRegisterBatchInStock.TabIndex = 7
        Me.btnRegisterBatchInStock.Text = "Registrer parti i lager"
        Me.btnRegisterBatchInStock.UseVisualStyleBackColor = True
        '
        'btnSearchBatch
        '
        Me.btnSearchBatch.Location = New System.Drawing.Point(216, 79)
        Me.btnSearchBatch.Name = "btnSearchBatch"
        Me.btnSearchBatch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearchBatch.TabIndex = 17
        Me.btnSearchBatch.Text = "Søk"
        Me.btnSearchBatch.UseVisualStyleBackColor = True
        '
        'txtSearchBatch
        '
        Me.txtSearchBatch.Location = New System.Drawing.Point(100, 81)
        Me.txtSearchBatch.Name = "txtSearchBatch"
        Me.txtSearchBatch.Size = New System.Drawing.Size(106, 20)
        Me.txtSearchBatch.TabIndex = 18
        '
        'lblSearchBatch
        '
        Me.lblSearchBatch.AutoSize = True
        Me.lblSearchBatch.Location = New System.Drawing.Point(12, 84)
        Me.lblSearchBatch.Name = "lblSearchBatch"
        Me.lblSearchBatch.Size = New System.Drawing.Size(82, 13)
        Me.lblSearchBatch.TabIndex = 19
        Me.lblSearchBatch.Text = "Søk etter partinr"
        '
        'dtgLogisticsRegisterCommodity
        '
        Me.dtgLogisticsRegisterCommodity.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgLogisticsRegisterCommodity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgLogisticsRegisterCommodity.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Partinr, Me.Column1, Me.Column2, Me.Column5})
        Me.dtgLogisticsRegisterCommodity.Location = New System.Drawing.Point(15, 108)
        Me.dtgLogisticsRegisterCommodity.Name = "dtgLogisticsRegisterCommodity"
        Me.dtgLogisticsRegisterCommodity.RowHeadersVisible = False
        Me.dtgLogisticsRegisterCommodity.Size = New System.Drawing.Size(683, 288)
        Me.dtgLogisticsRegisterCommodity.TabIndex = 20
        '
        'Partinr
        '
        Me.Partinr.HeaderText = "Partinr"
        Me.Partinr.Name = "Partinr"
        '
        'Column1
        '
        Me.Column1.HeaderText = "Ingrediens"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Antall"
        Me.Column2.Name = "Column2"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Bestilt dato"
        Me.Column5.Name = "Column5"
        '
        'lblShowBatchExpectedInStock
        '
        Me.lblShowBatchExpectedInStock.AutoSize = True
        Me.lblShowBatchExpectedInStock.Location = New System.Drawing.Point(465, 84)
        Me.lblShowBatchExpectedInStock.Name = "lblShowBatchExpectedInStock"
        Me.lblShowBatchExpectedInStock.Size = New System.Drawing.Size(127, 13)
        Me.lblShowBatchExpectedInStock.TabIndex = 21
        Me.lblShowBatchExpectedInStock.Text = "Vis partier ventet på lager"
        '
        'dtpBatchExpectedInStock
        '
        Me.dtpBatchExpectedInStock.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpBatchExpectedInStock.Location = New System.Drawing.Point(598, 81)
        Me.dtpBatchExpectedInStock.Name = "dtpBatchExpectedInStock"
        Me.dtpBatchExpectedInStock.Size = New System.Drawing.Size(100, 20)
        Me.dtpBatchExpectedInStock.TabIndex = 22
        '
        'frmLogisticsRegisterCommodity
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(716, 505)
        Me.Controls.Add(Me.dtpBatchExpectedInStock)
        Me.Controls.Add(Me.lblShowBatchExpectedInStock)
        Me.Controls.Add(Me.dtgLogisticsRegisterCommodity)
        Me.Controls.Add(Me.lblSearchBatch)
        Me.Controls.Add(Me.txtSearchBatch)
        Me.Controls.Add(Me.btnSearchBatch)
        Me.Controls.Add(Me.grpEditSelectedBatch)
        Me.Name = "frmLogisticsRegisterCommodity"
        Me.Text = "Registrere varer"
        Me.Controls.SetChildIndex(Me.grpEditSelectedBatch, 0)
        Me.Controls.SetChildIndex(Me.btnSearchBatch, 0)
        Me.Controls.SetChildIndex(Me.txtSearchBatch, 0)
        Me.Controls.SetChildIndex(Me.lblSearchBatch, 0)
        Me.Controls.SetChildIndex(Me.dtgLogisticsRegisterCommodity, 0)
        Me.Controls.SetChildIndex(Me.lblShowBatchExpectedInStock, 0)
        Me.Controls.SetChildIndex(Me.dtpBatchExpectedInStock, 0)
        Me.grpEditSelectedBatch.ResumeLayout(False)
        Me.grpEditSelectedBatch.PerformLayout()
        CType(Me.dtgLogisticsRegisterCommodity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpEditSelectedBatch As System.Windows.Forms.GroupBox
    Friend WithEvents btnSuggestLocation As System.Windows.Forms.Button
    Friend WithEvents txtShelf As System.Windows.Forms.TextBox
    Friend WithEvents lblShelf As System.Windows.Forms.Label
    Friend WithEvents lblRack As System.Windows.Forms.Label
    Friend WithEvents txtRack As System.Windows.Forms.TextBox
    Friend WithEvents btnRegisterBatchInStock As System.Windows.Forms.Button
    Friend WithEvents btnSearchBatch As System.Windows.Forms.Button
    Friend WithEvents txtSearchBatch As System.Windows.Forms.TextBox
    Friend WithEvents lblSearchBatch As System.Windows.Forms.Label
    Friend WithEvents dtgLogisticsRegisterCommodity As System.Windows.Forms.DataGridView
    Friend WithEvents dtpExpireDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblExpireDate As System.Windows.Forms.Label
    Friend WithEvents Partinr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblShowBatchExpectedInStock As System.Windows.Forms.Label
    Friend WithEvents dtpBatchExpectedInStock As System.Windows.Forms.DateTimePicker

End Class
