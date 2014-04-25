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
        Me.components = New System.ComponentModel.Container()
        Me.grpEditSelectedBatch = New System.Windows.Forms.GroupBox()
        Me.numShelf = New Kakefunn.NumericTextbox()
        Me.numRow = New Kakefunn.NumericTextbox()
        Me.dtpExpireDate = New System.Windows.Forms.DateTimePicker()
        Me.lblExpireDate = New System.Windows.Forms.Label()
        Me.btnSuggestLocation = New System.Windows.Forms.Button()
        Me.lblShelf = New System.Windows.Forms.Label()
        Me.lblRow = New System.Windows.Forms.Label()
        Me.btnRegisterBatchInStock = New System.Windows.Forms.Button()
        Me.btnSearchBatch = New System.Windows.Forms.Button()
        Me.lblSearchBatch = New System.Windows.Forms.Label()
        Me.dtgLogisticsRegisterCommodity = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ingrediens = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitCountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BatchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblShowBatchExpectedInStock = New System.Windows.Forms.Label()
        Me.dtpBatchExpectedInStock = New System.Windows.Forms.DateTimePicker()
        Me.numSearchBatch = New Kakefunn.NumericTextbox()
        Me.btnShowAll = New System.Windows.Forms.Button()
        Me.grpEditSelectedBatch.SuspendLayout()
        CType(Me.dtgLogisticsRegisterCommodity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BatchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpEditSelectedBatch
        '
        Me.grpEditSelectedBatch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpEditSelectedBatch.Controls.Add(Me.numShelf)
        Me.grpEditSelectedBatch.Controls.Add(Me.numRow)
        Me.grpEditSelectedBatch.Controls.Add(Me.dtpExpireDate)
        Me.grpEditSelectedBatch.Controls.Add(Me.lblExpireDate)
        Me.grpEditSelectedBatch.Controls.Add(Me.btnSuggestLocation)
        Me.grpEditSelectedBatch.Controls.Add(Me.lblShelf)
        Me.grpEditSelectedBatch.Controls.Add(Me.lblRow)
        Me.grpEditSelectedBatch.Controls.Add(Me.btnRegisterBatchInStock)
        Me.grpEditSelectedBatch.Location = New System.Drawing.Point(12, 402)
        Me.grpEditSelectedBatch.Name = "grpEditSelectedBatch"
        Me.grpEditSelectedBatch.Size = New System.Drawing.Size(686, 64)
        Me.grpEditSelectedBatch.TabIndex = 9
        Me.grpEditSelectedBatch.TabStop = False
        Me.grpEditSelectedBatch.Text = "Rediger valgt parti"
        '
        'numShelf
        '
        Me.numShelf.AllowDecimal = False
        Me.numShelf.AllowNegative = False
        Me.numShelf.AllowSpace = False
        Me.numShelf.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.numShelf.Location = New System.Drawing.Point(155, 20)
        Me.numShelf.Name = "numShelf"
        Me.numShelf.Size = New System.Drawing.Size(37, 20)
        Me.numShelf.TabIndex = 25
        '
        'numRow
        '
        Me.numRow.AllowDecimal = False
        Me.numRow.AllowNegative = False
        Me.numRow.AllowSpace = False
        Me.numRow.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.numRow.Location = New System.Drawing.Point(63, 20)
        Me.numRow.Name = "numRow"
        Me.numRow.Size = New System.Drawing.Size(37, 20)
        Me.numRow.TabIndex = 24
        '
        'dtpExpireDate
        '
        Me.dtpExpireDate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpExpireDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpExpireDate.Location = New System.Drawing.Point(410, 19)
        Me.dtpExpireDate.Name = "dtpExpireDate"
        Me.dtpExpireDate.Size = New System.Drawing.Size(100, 20)
        Me.dtpExpireDate.TabIndex = 3
        '
        'lblExpireDate
        '
        Me.lblExpireDate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblExpireDate.AutoSize = True
        Me.lblExpireDate.Location = New System.Drawing.Point(346, 23)
        Me.lblExpireDate.Name = "lblExpireDate"
        Me.lblExpireDate.Size = New System.Drawing.Size(58, 13)
        Me.lblExpireDate.TabIndex = 23
        Me.lblExpireDate.Text = "Utløpsdato"
        '
        'btnSuggestLocation
        '
        Me.btnSuggestLocation.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSuggestLocation.Location = New System.Drawing.Point(214, 18)
        Me.btnSuggestLocation.Name = "btnSuggestLocation"
        Me.btnSuggestLocation.Size = New System.Drawing.Size(99, 23)
        Me.btnSuggestLocation.TabIndex = 2
        Me.btnSuggestLocation.Text = "Foreslå plassering"
        Me.btnSuggestLocation.UseVisualStyleBackColor = True
        '
        'lblShelf
        '
        Me.lblShelf.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblShelf.AutoSize = True
        Me.lblShelf.Location = New System.Drawing.Point(119, 23)
        Me.lblShelf.Name = "lblShelf"
        Me.lblShelf.Size = New System.Drawing.Size(30, 13)
        Me.lblShelf.TabIndex = 12
        Me.lblShelf.Text = "Hylle"
        '
        'lblRow
        '
        Me.lblRow.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblRow.AutoSize = True
        Me.lblRow.Location = New System.Drawing.Point(30, 23)
        Me.lblRow.Name = "lblRow"
        Me.lblRow.Size = New System.Drawing.Size(27, 13)
        Me.lblRow.TabIndex = 11
        Me.lblRow.Text = "Rad"
        '
        'btnRegisterBatchInStock
        '
        Me.btnRegisterBatchInStock.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRegisterBatchInStock.Enabled = False
        Me.btnRegisterBatchInStock.Location = New System.Drawing.Point(554, 16)
        Me.btnRegisterBatchInStock.Name = "btnRegisterBatchInStock"
        Me.btnRegisterBatchInStock.Size = New System.Drawing.Size(126, 27)
        Me.btnRegisterBatchInStock.TabIndex = 4
        Me.btnRegisterBatchInStock.Text = "Registrer parti i lager"
        Me.btnRegisterBatchInStock.UseVisualStyleBackColor = True
        '
        'btnSearchBatch
        '
        Me.btnSearchBatch.Location = New System.Drawing.Point(216, 79)
        Me.btnSearchBatch.Name = "btnSearchBatch"
        Me.btnSearchBatch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearchBatch.TabIndex = 6
        Me.btnSearchBatch.Text = "Søk"
        Me.btnSearchBatch.UseVisualStyleBackColor = True
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
        Me.dtgLogisticsRegisterCommodity.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtgLogisticsRegisterCommodity.AutoGenerateColumns = False
        Me.dtgLogisticsRegisterCommodity.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgLogisticsRegisterCommodity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgLogisticsRegisterCommodity.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.Ingrediens, Me.UnitCountDataGridViewTextBoxColumn, Me.OrderedDataGridViewTextBoxColumn})
        Me.dtgLogisticsRegisterCommodity.DataSource = Me.BatchBindingSource
        Me.dtgLogisticsRegisterCommodity.Location = New System.Drawing.Point(15, 108)
        Me.dtgLogisticsRegisterCommodity.Name = "dtgLogisticsRegisterCommodity"
        Me.dtgLogisticsRegisterCommodity.ReadOnly = True
        Me.dtgLogisticsRegisterCommodity.RowHeadersVisible = False
        Me.dtgLogisticsRegisterCommodity.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgLogisticsRegisterCommodity.Size = New System.Drawing.Size(683, 288)
        Me.dtgLogisticsRegisterCommodity.TabIndex = 8
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Partinr"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Ingrediens
        '
        Me.Ingrediens.DataPropertyName = "Ingredient"
        Me.Ingrediens.HeaderText = "Ingrediens"
        Me.Ingrediens.Name = "Ingrediens"
        Me.Ingrediens.ReadOnly = True
        '
        'UnitCountDataGridViewTextBoxColumn
        '
        Me.UnitCountDataGridViewTextBoxColumn.DataPropertyName = "unitCount"
        Me.UnitCountDataGridViewTextBoxColumn.HeaderText = "Antall"
        Me.UnitCountDataGridViewTextBoxColumn.Name = "UnitCountDataGridViewTextBoxColumn"
        Me.UnitCountDataGridViewTextBoxColumn.ReadOnly = True
        '
        'OrderedDataGridViewTextBoxColumn
        '
        Me.OrderedDataGridViewTextBoxColumn.DataPropertyName = "ordered"
        Me.OrderedDataGridViewTextBoxColumn.HeaderText = "Bestilt dato"
        Me.OrderedDataGridViewTextBoxColumn.Name = "OrderedDataGridViewTextBoxColumn"
        Me.OrderedDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BatchBindingSource
        '
        Me.BatchBindingSource.DataSource = GetType(Kakefunn.Batch)
        '
        'lblShowBatchExpectedInStock
        '
        Me.lblShowBatchExpectedInStock.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblShowBatchExpectedInStock.AutoSize = True
        Me.lblShowBatchExpectedInStock.Location = New System.Drawing.Point(465, 84)
        Me.lblShowBatchExpectedInStock.Name = "lblShowBatchExpectedInStock"
        Me.lblShowBatchExpectedInStock.Size = New System.Drawing.Size(127, 13)
        Me.lblShowBatchExpectedInStock.TabIndex = 21
        Me.lblShowBatchExpectedInStock.Text = "Vis partier ventet på lager"
        '
        'dtpBatchExpectedInStock
        '
        Me.dtpBatchExpectedInStock.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpBatchExpectedInStock.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpBatchExpectedInStock.Location = New System.Drawing.Point(598, 81)
        Me.dtpBatchExpectedInStock.Name = "dtpBatchExpectedInStock"
        Me.dtpBatchExpectedInStock.Size = New System.Drawing.Size(100, 20)
        Me.dtpBatchExpectedInStock.TabIndex = 7
        '
        'numSearchBatch
        '
        Me.numSearchBatch.AllowDecimal = False
        Me.numSearchBatch.AllowNegative = False
        Me.numSearchBatch.AllowSpace = False
        Me.numSearchBatch.Location = New System.Drawing.Point(110, 81)
        Me.numSearchBatch.Name = "numSearchBatch"
        Me.numSearchBatch.Size = New System.Drawing.Size(100, 20)
        Me.numSearchBatch.TabIndex = 22
        '
        'btnShowAll
        '
        Me.btnShowAll.Location = New System.Drawing.Point(297, 79)
        Me.btnShowAll.Name = "btnShowAll"
        Me.btnShowAll.Size = New System.Drawing.Size(75, 23)
        Me.btnShowAll.TabIndex = 23
        Me.btnShowAll.Text = "Vis alle"
        Me.btnShowAll.UseVisualStyleBackColor = True
        '
        'frmLogisticsRegisterCommodity
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(713, 521)
        Me.Controls.Add(Me.btnShowAll)
        Me.Controls.Add(Me.numSearchBatch)
        Me.Controls.Add(Me.dtpBatchExpectedInStock)
        Me.Controls.Add(Me.lblShowBatchExpectedInStock)
        Me.Controls.Add(Me.dtgLogisticsRegisterCommodity)
        Me.Controls.Add(Me.lblSearchBatch)
        Me.Controls.Add(Me.btnSearchBatch)
        Me.Controls.Add(Me.grpEditSelectedBatch)
        Me.MinimumSize = New System.Drawing.Size(729, 560)
        Me.Name = "frmLogisticsRegisterCommodity"
        Me.Text = "Registrere varer"
        Me.Controls.SetChildIndex(Me.grpEditSelectedBatch, 0)
        Me.Controls.SetChildIndex(Me.btnSearchBatch, 0)
        Me.Controls.SetChildIndex(Me.lblSearchBatch, 0)
        Me.Controls.SetChildIndex(Me.dtgLogisticsRegisterCommodity, 0)
        Me.Controls.SetChildIndex(Me.lblShowBatchExpectedInStock, 0)
        Me.Controls.SetChildIndex(Me.dtpBatchExpectedInStock, 0)
        Me.Controls.SetChildIndex(Me.numSearchBatch, 0)
        Me.Controls.SetChildIndex(Me.btnShowAll, 0)
        Me.grpEditSelectedBatch.ResumeLayout(False)
        Me.grpEditSelectedBatch.PerformLayout()
        CType(Me.dtgLogisticsRegisterCommodity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BatchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpEditSelectedBatch As System.Windows.Forms.GroupBox
    Friend WithEvents btnSuggestLocation As System.Windows.Forms.Button
    Friend WithEvents lblShelf As System.Windows.Forms.Label
    Friend WithEvents lblRow As System.Windows.Forms.Label
    Friend WithEvents btnRegisterBatchInStock As System.Windows.Forms.Button
    Friend WithEvents btnSearchBatch As System.Windows.Forms.Button
    Friend WithEvents lblSearchBatch As System.Windows.Forms.Label
    Friend WithEvents dtgLogisticsRegisterCommodity As System.Windows.Forms.DataGridView
    Friend WithEvents dtpExpireDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblExpireDate As System.Windows.Forms.Label
    Friend WithEvents lblShowBatchExpectedInStock As System.Windows.Forms.Label
    Friend WithEvents dtpBatchExpectedInStock As System.Windows.Forms.DateTimePicker
    Friend WithEvents BatchBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IngredientDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents numSearchBatch As Kakefunn.NumericTextbox
    Friend WithEvents btnShowAll As System.Windows.Forms.Button
    Friend WithEvents numShelf As Kakefunn.NumericTextbox
    Friend WithEvents numRow As Kakefunn.NumericTextbox
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ingrediens As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UnitCountDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OrderedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
