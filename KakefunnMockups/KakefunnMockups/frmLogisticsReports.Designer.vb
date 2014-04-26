<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogisticsReports
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
        Me.dtgExpiredIngredients = New System.Windows.Forms.DataGridView()
        Me.cnIngredientId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cnName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cnRegisteredDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cnExpireDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cnAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cnLocation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RegisteredDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExpectedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExpiresDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitCountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrigUnitCountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitPurchasingPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LocationRowDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LocationShelfDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeletedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IngredientDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BatchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnPrintExpiredIngredients = New System.Windows.Forms.Button()
        Me.btnCheckAll = New System.Windows.Forms.Button()
        Me.btbDeleteCheckedIngredientsInStock = New System.Windows.Forms.Button()
        CType(Me.dtgExpiredIngredients, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BatchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtgExpiredIngredients
        '
        Me.dtgExpiredIngredients.AllowUserToAddRows = False
        Me.dtgExpiredIngredients.AllowUserToDeleteRows = False
        Me.dtgExpiredIngredients.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtgExpiredIngredients.AutoGenerateColumns = False
        Me.dtgExpiredIngredients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgExpiredIngredients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgExpiredIngredients.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cnIngredientId, Me.cnName, Me.cnRegisteredDate, Me.cnExpireDate, Me.cnAmount, Me.cnLocation, Me.IdDataGridViewTextBoxColumn, Me.OrderedDataGridViewTextBoxColumn, Me.RegisteredDataGridViewTextBoxColumn, Me.ExpectedDataGridViewTextBoxColumn, Me.ExpiresDataGridViewTextBoxColumn, Me.UnitCountDataGridViewTextBoxColumn, Me.OrigUnitCountDataGridViewTextBoxColumn, Me.UnitPurchasingPriceDataGridViewTextBoxColumn, Me.LocationRowDataGridViewTextBoxColumn, Me.LocationShelfDataGridViewTextBoxColumn, Me.DeletedDataGridViewTextBoxColumn, Me.IngredientDataGridViewTextBoxColumn})
        Me.dtgExpiredIngredients.DataSource = Me.BatchBindingSource
        Me.dtgExpiredIngredients.Location = New System.Drawing.Point(12, 12)
        Me.dtgExpiredIngredients.Name = "dtgExpiredIngredients"
        Me.dtgExpiredIngredients.RowHeadersVisible = False
        Me.dtgExpiredIngredients.Size = New System.Drawing.Size(682, 407)
        Me.dtgExpiredIngredients.TabIndex = 5
        '
        'cnIngredientId
        '
        Me.cnIngredientId.DataPropertyName = "Ingredient"
        Me.cnIngredientId.HeaderText = "Varenr"
        Me.cnIngredientId.Name = "cnIngredientId"
        '
        'cnName
        '
        Me.cnName.DataPropertyName = "Ingredient"
        Me.cnName.HeaderText = "Navn"
        Me.cnName.Name = "cnName"
        '
        'cnRegisteredDate
        '
        Me.cnRegisteredDate.DataPropertyName = "registered"
        Me.cnRegisteredDate.HeaderText = "Mottatt dato"
        Me.cnRegisteredDate.Name = "cnRegisteredDate"
        '
        'cnExpireDate
        '
        Me.cnExpireDate.DataPropertyName = "expires"
        Me.cnExpireDate.HeaderText = "Utløpsdato"
        Me.cnExpireDate.Name = "cnExpireDate"
        '
        'cnAmount
        '
        Me.cnAmount.HeaderText = "Antall"
        Me.cnAmount.Name = "cnAmount"
        '
        'cnLocation
        '
        Me.cnLocation.DataPropertyName = "locationRow"
        Me.cnLocation.HeaderText = "Reol/Hylle"
        Me.cnLocation.Name = "cnLocation"
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.Visible = False
        '
        'OrderedDataGridViewTextBoxColumn
        '
        Me.OrderedDataGridViewTextBoxColumn.DataPropertyName = "ordered"
        Me.OrderedDataGridViewTextBoxColumn.HeaderText = "ordered"
        Me.OrderedDataGridViewTextBoxColumn.Name = "OrderedDataGridViewTextBoxColumn"
        Me.OrderedDataGridViewTextBoxColumn.Visible = False
        '
        'RegisteredDataGridViewTextBoxColumn
        '
        Me.RegisteredDataGridViewTextBoxColumn.DataPropertyName = "registered"
        Me.RegisteredDataGridViewTextBoxColumn.HeaderText = "registered"
        Me.RegisteredDataGridViewTextBoxColumn.Name = "RegisteredDataGridViewTextBoxColumn"
        Me.RegisteredDataGridViewTextBoxColumn.Visible = False
        '
        'ExpectedDataGridViewTextBoxColumn
        '
        Me.ExpectedDataGridViewTextBoxColumn.DataPropertyName = "expected"
        Me.ExpectedDataGridViewTextBoxColumn.HeaderText = "expected"
        Me.ExpectedDataGridViewTextBoxColumn.Name = "ExpectedDataGridViewTextBoxColumn"
        Me.ExpectedDataGridViewTextBoxColumn.Visible = False
        '
        'ExpiresDataGridViewTextBoxColumn
        '
        Me.ExpiresDataGridViewTextBoxColumn.DataPropertyName = "expires"
        Me.ExpiresDataGridViewTextBoxColumn.HeaderText = "expires"
        Me.ExpiresDataGridViewTextBoxColumn.Name = "ExpiresDataGridViewTextBoxColumn"
        Me.ExpiresDataGridViewTextBoxColumn.Visible = False
        '
        'UnitCountDataGridViewTextBoxColumn
        '
        Me.UnitCountDataGridViewTextBoxColumn.DataPropertyName = "unitCount"
        Me.UnitCountDataGridViewTextBoxColumn.HeaderText = "unitCount"
        Me.UnitCountDataGridViewTextBoxColumn.Name = "UnitCountDataGridViewTextBoxColumn"
        Me.UnitCountDataGridViewTextBoxColumn.Visible = False
        '
        'OrigUnitCountDataGridViewTextBoxColumn
        '
        Me.OrigUnitCountDataGridViewTextBoxColumn.DataPropertyName = "origUnitCount"
        Me.OrigUnitCountDataGridViewTextBoxColumn.HeaderText = "origUnitCount"
        Me.OrigUnitCountDataGridViewTextBoxColumn.Name = "OrigUnitCountDataGridViewTextBoxColumn"
        Me.OrigUnitCountDataGridViewTextBoxColumn.Visible = False
        '
        'UnitPurchasingPriceDataGridViewTextBoxColumn
        '
        Me.UnitPurchasingPriceDataGridViewTextBoxColumn.DataPropertyName = "unitPurchasingPrice"
        Me.UnitPurchasingPriceDataGridViewTextBoxColumn.HeaderText = "unitPurchasingPrice"
        Me.UnitPurchasingPriceDataGridViewTextBoxColumn.Name = "UnitPurchasingPriceDataGridViewTextBoxColumn"
        Me.UnitPurchasingPriceDataGridViewTextBoxColumn.Visible = False
        '
        'LocationRowDataGridViewTextBoxColumn
        '
        Me.LocationRowDataGridViewTextBoxColumn.DataPropertyName = "locationRow"
        Me.LocationRowDataGridViewTextBoxColumn.HeaderText = "locationRow"
        Me.LocationRowDataGridViewTextBoxColumn.Name = "LocationRowDataGridViewTextBoxColumn"
        Me.LocationRowDataGridViewTextBoxColumn.Visible = False
        '
        'LocationShelfDataGridViewTextBoxColumn
        '
        Me.LocationShelfDataGridViewTextBoxColumn.DataPropertyName = "locationShelf"
        Me.LocationShelfDataGridViewTextBoxColumn.HeaderText = "locationShelf"
        Me.LocationShelfDataGridViewTextBoxColumn.Name = "LocationShelfDataGridViewTextBoxColumn"
        Me.LocationShelfDataGridViewTextBoxColumn.Visible = False
        '
        'DeletedDataGridViewTextBoxColumn
        '
        Me.DeletedDataGridViewTextBoxColumn.DataPropertyName = "deleted"
        Me.DeletedDataGridViewTextBoxColumn.HeaderText = "deleted"
        Me.DeletedDataGridViewTextBoxColumn.Name = "DeletedDataGridViewTextBoxColumn"
        Me.DeletedDataGridViewTextBoxColumn.Visible = False
        '
        'IngredientDataGridViewTextBoxColumn
        '
        Me.IngredientDataGridViewTextBoxColumn.DataPropertyName = "Ingredient"
        Me.IngredientDataGridViewTextBoxColumn.HeaderText = "Ingredient"
        Me.IngredientDataGridViewTextBoxColumn.Name = "IngredientDataGridViewTextBoxColumn"
        Me.IngredientDataGridViewTextBoxColumn.Visible = False
        '
        'BatchBindingSource
        '
        Me.BatchBindingSource.DataSource = GetType(Kakefunn.Batch)
        '
        'btnPrintExpiredIngredients
        '
        Me.btnPrintExpiredIngredients.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrintExpiredIngredients.Location = New System.Drawing.Point(619, 425)
        Me.btnPrintExpiredIngredients.Name = "btnPrintExpiredIngredients"
        Me.btnPrintExpiredIngredients.Size = New System.Drawing.Size(75, 23)
        Me.btnPrintExpiredIngredients.TabIndex = 8
        Me.btnPrintExpiredIngredients.Text = "Skriv ut"
        Me.btnPrintExpiredIngredients.UseVisualStyleBackColor = True
        '
        'btnCheckAll
        '
        Me.btnCheckAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCheckAll.Location = New System.Drawing.Point(12, 425)
        Me.btnCheckAll.Name = "btnCheckAll"
        Me.btnCheckAll.Size = New System.Drawing.Size(75, 23)
        Me.btnCheckAll.TabIndex = 6
        Me.btnCheckAll.Text = "Merk alle"
        Me.btnCheckAll.UseVisualStyleBackColor = True
        '
        'btbDeleteCheckedIngredientsInStock
        '
        Me.btbDeleteCheckedIngredientsInStock.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btbDeleteCheckedIngredientsInStock.Location = New System.Drawing.Point(93, 425)
        Me.btbDeleteCheckedIngredientsInStock.Name = "btbDeleteCheckedIngredientsInStock"
        Me.btbDeleteCheckedIngredientsInStock.Size = New System.Drawing.Size(175, 23)
        Me.btbDeleteCheckedIngredientsInStock.TabIndex = 7
        Me.btbDeleteCheckedIngredientsInStock.Text = "Slett merkede fra varelager"
        Me.btbDeleteCheckedIngredientsInStock.UseVisualStyleBackColor = True
        '
        'frmLogisticsReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(706, 511)
        Me.Controls.Add(Me.btbDeleteCheckedIngredientsInStock)
        Me.Controls.Add(Me.btnCheckAll)
        Me.Controls.Add(Me.btnPrintExpiredIngredients)
        Me.Controls.Add(Me.dtgExpiredIngredients)
        Me.MinimumSize = New System.Drawing.Size(720, 550)
        Me.Name = "frmLogisticsReports"
        Me.Text = "Utløpte varer"
        CType(Me.dtgExpiredIngredients, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BatchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dtgExpiredIngredients As System.Windows.Forms.DataGridView
    Friend WithEvents btnPrintExpiredIngredients As System.Windows.Forms.Button
    Friend WithEvents btnCheckAll As System.Windows.Forms.Button
    Friend WithEvents btbDeleteCheckedIngredientsInStock As System.Windows.Forms.Button
    Friend WithEvents BatchBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents cnIngredientId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cnName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cnRegisteredDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cnExpireDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cnAmount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cnLocation As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OrderedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RegisteredDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ExpectedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ExpiresDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UnitCountDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OrigUnitCountDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UnitPurchasingPriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LocationRowDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LocationShelfDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DeletedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IngredientDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
