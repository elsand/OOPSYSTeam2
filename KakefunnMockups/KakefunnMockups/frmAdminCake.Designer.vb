<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdminCakes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdminCakes))
        Me.lstAvailableIngredients = New System.Windows.Forms.ListBox()
        Me.btnAddIngredients = New System.Windows.Forms.Button()
        Me.btnRemoveIngredients = New System.Windows.Forms.Button()
        Me.lstSelectedIngredients = New System.Windows.Forms.ListBox()
        Me.txtFilter = New System.Windows.Forms.TextBox()
        Me.lblFilter = New System.Windows.Forms.Label()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.lblMeasureUnit = New System.Windows.Forms.Label()
        Me.txtProcedure = New System.Windows.Forms.TextBox()
        Me.lblProcedure = New System.Windows.Forms.Label()
        Me.grpIngredients = New System.Windows.Forms.GroupBox()
        Me.numAmount = New Kakefunn.NumericTextbox()
        Me.txtNameCake = New System.Windows.Forms.TextBox()
        Me.lblNameCake = New System.Windows.Forms.Label()
        Me.MarkUps = New System.Windows.Forms.Label()
        Me.lblIngredientsPrice = New System.Windows.Forms.Label()
        Me.lblSalePrice = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.dtgCake = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarkupPercentageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PublishedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RecipeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeletedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CakeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblFilterCake = New System.Windows.Forms.Label()
        Me.txtFilterCake = New System.Windows.Forms.TextBox()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnToolStripCakeNew = New System.Windows.Forms.ToolStripButton()
        Me.btnToolStripCakeDelete = New System.Windows.Forms.ToolStripButton()
        Me.numMarkUps = New Kakefunn.NumericTextbox()
        Me.chkPublished = New System.Windows.Forms.CheckBox()
        Me.grpCakeEdit = New System.Windows.Forms.GroupBox()
        Me.btnAvbryt = New System.Windows.Forms.Button()
        Me.btnNewCake = New System.Windows.Forms.Button()
        Me.grpIngredients.SuspendLayout()
        CType(Me.dtgCake, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CakeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.grpCakeEdit.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstAvailableIngredients
        '
        Me.lstAvailableIngredients.FormattingEnabled = True
        Me.lstAvailableIngredients.Location = New System.Drawing.Point(6, 60)
        Me.lstAvailableIngredients.MinimumSize = New System.Drawing.Size(150, 134)
        Me.lstAvailableIngredients.Name = "lstAvailableIngredients"
        Me.lstAvailableIngredients.Size = New System.Drawing.Size(150, 134)
        Me.lstAvailableIngredients.TabIndex = 4
        '
        'btnAddIngredients
        '
        Me.btnAddIngredients.Location = New System.Drawing.Point(162, 105)
        Me.btnAddIngredients.Name = "btnAddIngredients"
        Me.btnAddIngredients.Size = New System.Drawing.Size(32, 23)
        Me.btnAddIngredients.TabIndex = 5
        Me.btnAddIngredients.Text = ">"
        Me.btnAddIngredients.UseVisualStyleBackColor = True
        '
        'btnRemoveIngredients
        '
        Me.btnRemoveIngredients.Location = New System.Drawing.Point(162, 134)
        Me.btnRemoveIngredients.Name = "btnRemoveIngredients"
        Me.btnRemoveIngredients.Size = New System.Drawing.Size(32, 23)
        Me.btnRemoveIngredients.TabIndex = 6
        Me.btnRemoveIngredients.Text = "<"
        Me.btnRemoveIngredients.UseVisualStyleBackColor = True
        '
        'lstSelectedIngredients
        '
        Me.lstSelectedIngredients.FormattingEnabled = True
        Me.lstSelectedIngredients.Location = New System.Drawing.Point(200, 60)
        Me.lstSelectedIngredients.MinimumSize = New System.Drawing.Size(150, 134)
        Me.lstSelectedIngredients.Name = "lstSelectedIngredients"
        Me.lstSelectedIngredients.Size = New System.Drawing.Size(150, 134)
        Me.lstSelectedIngredients.TabIndex = 7
        '
        'txtFilter
        '
        Me.txtFilter.Location = New System.Drawing.Point(7, 38)
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Size = New System.Drawing.Size(149, 20)
        Me.txtFilter.TabIndex = 8
        '
        'lblFilter
        '
        Me.lblFilter.AutoSize = True
        Me.lblFilter.Location = New System.Drawing.Point(6, 22)
        Me.lblFilter.Name = "lblFilter"
        Me.lblFilter.Size = New System.Drawing.Size(29, 13)
        Me.lblFilter.TabIndex = 9
        Me.lblFilter.Text = "Filter"
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.Location = New System.Drawing.Point(15, 208)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(46, 13)
        Me.lblAmount.TabIndex = 10
        Me.lblAmount.Text = "Mengde"
        '
        'lblMeasureUnit
        '
        Me.lblMeasureUnit.AutoSize = True
        Me.lblMeasureUnit.Location = New System.Drawing.Point(110, 228)
        Me.lblMeasureUnit.Name = "lblMeasureUnit"
        Me.lblMeasureUnit.Size = New System.Drawing.Size(10, 13)
        Me.lblMeasureUnit.TabIndex = 11
        Me.lblMeasureUnit.Text = "-"
        '
        'txtProcedure
        '
        Me.txtProcedure.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.txtProcedure.Location = New System.Drawing.Point(6, 321)
        Me.txtProcedure.MinimumSize = New System.Drawing.Size(357, 94)
        Me.txtProcedure.Multiline = True
        Me.txtProcedure.Name = "txtProcedure"
        Me.txtProcedure.Size = New System.Drawing.Size(357, 94)
        Me.txtProcedure.TabIndex = 13
        '
        'lblProcedure
        '
        Me.lblProcedure.AutoSize = True
        Me.lblProcedure.Location = New System.Drawing.Point(3, 306)
        Me.lblProcedure.Name = "lblProcedure"
        Me.lblProcedure.Size = New System.Drawing.Size(82, 13)
        Me.lblProcedure.TabIndex = 14
        Me.lblProcedure.Text = "Fremgangsmåte"
        '
        'grpIngredients
        '
        Me.grpIngredients.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpIngredients.Controls.Add(Me.numAmount)
        Me.grpIngredients.Controls.Add(Me.lstAvailableIngredients)
        Me.grpIngredients.Controls.Add(Me.btnAddIngredients)
        Me.grpIngredients.Controls.Add(Me.btnRemoveIngredients)
        Me.grpIngredients.Controls.Add(Me.lstSelectedIngredients)
        Me.grpIngredients.Controls.Add(Me.txtFilter)
        Me.grpIngredients.Controls.Add(Me.lblFilter)
        Me.grpIngredients.Controls.Add(Me.lblAmount)
        Me.grpIngredients.Controls.Add(Me.lblMeasureUnit)
        Me.grpIngredients.Location = New System.Drawing.Point(6, 46)
        Me.grpIngredients.Name = "grpIngredients"
        Me.grpIngredients.Size = New System.Drawing.Size(358, 257)
        Me.grpIngredients.TabIndex = 15
        Me.grpIngredients.TabStop = False
        Me.grpIngredients.Text = "Ingredienser"
        '
        'numAmount
        '
        Me.numAmount.AllowDecimal = True
        Me.numAmount.AllowNegative = False
        Me.numAmount.AllowSpace = False
        Me.numAmount.Location = New System.Drawing.Point(18, 225)
        Me.numAmount.Name = "numAmount"
        Me.numAmount.Size = New System.Drawing.Size(86, 20)
        Me.numAmount.TabIndex = 14
        '
        'txtNameCake
        '
        Me.txtNameCake.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNameCake.Location = New System.Drawing.Point(263, 20)
        Me.txtNameCake.Name = "txtNameCake"
        Me.txtNameCake.Size = New System.Drawing.Size(100, 20)
        Me.txtNameCake.TabIndex = 16
        '
        'lblNameCake
        '
        Me.lblNameCake.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNameCake.AutoSize = True
        Me.lblNameCake.Location = New System.Drawing.Point(173, 23)
        Me.lblNameCake.Name = "lblNameCake"
        Me.lblNameCake.Size = New System.Drawing.Size(75, 13)
        Me.lblNameCake.TabIndex = 17
        Me.lblNameCake.Text = "Navn på kake"
        '
        'MarkUps
        '
        Me.MarkUps.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MarkUps.AutoSize = True
        Me.MarkUps.Location = New System.Drawing.Point(10, 433)
        Me.MarkUps.Name = "MarkUps"
        Me.MarkUps.Size = New System.Drawing.Size(71, 13)
        Me.MarkUps.TabIndex = 19
        Me.MarkUps.Text = "Prispåslag i %"
        '
        'lblIngredientsPrice
        '
        Me.lblIngredientsPrice.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblIngredientsPrice.AutoSize = True
        Me.lblIngredientsPrice.Location = New System.Drawing.Point(225, 433)
        Me.lblIngredientsPrice.Name = "lblIngredientsPrice"
        Me.lblIngredientsPrice.Size = New System.Drawing.Size(84, 13)
        Me.lblIngredientsPrice.TabIndex = 20
        Me.lblIngredientsPrice.Text = "Ingredienspris: 0"
        '
        'lblSalePrice
        '
        Me.lblSalePrice.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSalePrice.AutoSize = True
        Me.lblSalePrice.Location = New System.Drawing.Point(248, 455)
        Me.lblSalePrice.Name = "lblSalePrice"
        Me.lblSalePrice.Size = New System.Drawing.Size(61, 13)
        Me.lblSalePrice.TabIndex = 21
        Me.lblSalePrice.Text = "Salgspris: 0"
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Location = New System.Drawing.Point(288, 480)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 22
        Me.btnSave.Text = "Lagre"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'dtgCake
        '
        Me.dtgCake.AllowUserToAddRows = False
        Me.dtgCake.AllowUserToDeleteRows = False
        Me.dtgCake.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtgCake.AutoGenerateColumns = False
        Me.dtgCake.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgCake.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgCake.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.price, Me.MarkupPercentageDataGridViewTextBoxColumn, Me.PublishedDataGridViewTextBoxColumn, Me.RecipeDataGridViewTextBoxColumn, Me.DeletedDataGridViewTextBoxColumn})
        Me.dtgCake.DataSource = Me.CakeBindingSource
        Me.dtgCake.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtgCake.Location = New System.Drawing.Point(12, 41)
        Me.dtgCake.MinimumSize = New System.Drawing.Size(522, 492)
        Me.dtgCake.Name = "dtgCake"
        Me.dtgCake.ReadOnly = True
        Me.dtgCake.RowHeadersVisible = False
        Me.dtgCake.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgCake.Size = New System.Drawing.Size(522, 492)
        Me.dtgCake.TabIndex = 23
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Kakenr"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Navn"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'price
        '
        Me.price.HeaderText = "Pris"
        Me.price.Name = "price"
        Me.price.ReadOnly = True
        Me.price.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        '
        'MarkupPercentageDataGridViewTextBoxColumn
        '
        Me.MarkupPercentageDataGridViewTextBoxColumn.DataPropertyName = "markupPercentage"
        Me.MarkupPercentageDataGridViewTextBoxColumn.HeaderText = "markupPercentage"
        Me.MarkupPercentageDataGridViewTextBoxColumn.Name = "MarkupPercentageDataGridViewTextBoxColumn"
        Me.MarkupPercentageDataGridViewTextBoxColumn.ReadOnly = True
        Me.MarkupPercentageDataGridViewTextBoxColumn.Visible = False
        '
        'PublishedDataGridViewTextBoxColumn
        '
        Me.PublishedDataGridViewTextBoxColumn.DataPropertyName = "published"
        Me.PublishedDataGridViewTextBoxColumn.HeaderText = "Publisert"
        Me.PublishedDataGridViewTextBoxColumn.Name = "PublishedDataGridViewTextBoxColumn"
        Me.PublishedDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RecipeDataGridViewTextBoxColumn
        '
        Me.RecipeDataGridViewTextBoxColumn.DataPropertyName = "recipe"
        Me.RecipeDataGridViewTextBoxColumn.HeaderText = "recipe"
        Me.RecipeDataGridViewTextBoxColumn.Name = "RecipeDataGridViewTextBoxColumn"
        Me.RecipeDataGridViewTextBoxColumn.ReadOnly = True
        Me.RecipeDataGridViewTextBoxColumn.Visible = False
        '
        'DeletedDataGridViewTextBoxColumn
        '
        Me.DeletedDataGridViewTextBoxColumn.DataPropertyName = "deleted"
        Me.DeletedDataGridViewTextBoxColumn.HeaderText = "Slettet"
        Me.DeletedDataGridViewTextBoxColumn.Name = "DeletedDataGridViewTextBoxColumn"
        Me.DeletedDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CakeBindingSource
        '
        Me.CakeBindingSource.DataSource = GetType(Kakefunn.Cake)
        '
        'lblFilterCake
        '
        Me.lblFilterCake.AutoSize = True
        Me.lblFilterCake.Location = New System.Drawing.Point(15, 18)
        Me.lblFilterCake.Name = "lblFilterCake"
        Me.lblFilterCake.Size = New System.Drawing.Size(53, 13)
        Me.lblFilterCake.TabIndex = 25
        Me.lblFilterCake.Text = "Filtrer liste"
        '
        'txtFilterCake
        '
        Me.txtFilterCake.Location = New System.Drawing.Point(74, 15)
        Me.txtFilterCake.Name = "txtFilterCake"
        Me.txtFilterCake.Size = New System.Drawing.Size(147, 20)
        Me.txtFilterCake.TabIndex = 24
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.BindingNavigator1.BindingSource = Me.CakeBindingSource
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.btnToolStripCakeNew, Me.btnToolStripCakeDelete})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 547)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(929, 25)
        Me.BindingNavigator1.TabIndex = 26
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'btnToolStripCakeNew
        '
        Me.btnToolStripCakeNew.Image = CType(resources.GetObject("btnToolStripCakeNew.Image"), System.Drawing.Image)
        Me.btnToolStripCakeNew.Name = "btnToolStripCakeNew"
        Me.btnToolStripCakeNew.RightToLeftAutoMirrorImage = True
        Me.btnToolStripCakeNew.Size = New System.Drawing.Size(69, 22)
        Me.btnToolStripCakeNew.Text = "Ny kake"
        '
        'btnToolStripCakeDelete
        '
        Me.btnToolStripCakeDelete.Image = CType(resources.GetObject("btnToolStripCakeDelete.Image"), System.Drawing.Image)
        Me.btnToolStripCakeDelete.Name = "btnToolStripCakeDelete"
        Me.btnToolStripCakeDelete.RightToLeftAutoMirrorImage = True
        Me.btnToolStripCakeDelete.Size = New System.Drawing.Size(77, 22)
        Me.btnToolStripCakeDelete.Text = "Slett kake"
        '
        'numMarkUps
        '
        Me.numMarkUps.AllowDecimal = False
        Me.numMarkUps.AllowNegative = False
        Me.numMarkUps.AllowSpace = False
        Me.numMarkUps.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.numMarkUps.Location = New System.Drawing.Point(87, 430)
        Me.numMarkUps.Name = "numMarkUps"
        Me.numMarkUps.Size = New System.Drawing.Size(35, 20)
        Me.numMarkUps.TabIndex = 27
        '
        'chkPublished
        '
        Me.chkPublished.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkPublished.AutoSize = True
        Me.chkPublished.Location = New System.Drawing.Point(13, 454)
        Me.chkPublished.Name = "chkPublished"
        Me.chkPublished.Size = New System.Drawing.Size(66, 17)
        Me.chkPublished.TabIndex = 28
        Me.chkPublished.Text = "Publisert"
        Me.chkPublished.UseVisualStyleBackColor = True
        '
        'grpCakeEdit
        '
        Me.grpCakeEdit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpCakeEdit.Controls.Add(Me.btnAvbryt)
        Me.grpCakeEdit.Controls.Add(Me.lblNameCake)
        Me.grpCakeEdit.Controls.Add(Me.txtProcedure)
        Me.grpCakeEdit.Controls.Add(Me.lblProcedure)
        Me.grpCakeEdit.Controls.Add(Me.grpIngredients)
        Me.grpCakeEdit.Controls.Add(Me.txtNameCake)
        Me.grpCakeEdit.Controls.Add(Me.MarkUps)
        Me.grpCakeEdit.Controls.Add(Me.lblIngredientsPrice)
        Me.grpCakeEdit.Controls.Add(Me.lblSalePrice)
        Me.grpCakeEdit.Controls.Add(Me.btnSave)
        Me.grpCakeEdit.Controls.Add(Me.chkPublished)
        Me.grpCakeEdit.Controls.Add(Me.numMarkUps)
        Me.grpCakeEdit.Enabled = False
        Me.grpCakeEdit.Location = New System.Drawing.Point(540, 12)
        Me.grpCakeEdit.Name = "grpCakeEdit"
        Me.grpCakeEdit.Size = New System.Drawing.Size(377, 521)
        Me.grpCakeEdit.TabIndex = 29
        Me.grpCakeEdit.TabStop = False
        Me.grpCakeEdit.Text = "Kakedetaljer"
        '
        'btnAvbryt
        '
        Me.btnAvbryt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAvbryt.Location = New System.Drawing.Point(207, 480)
        Me.btnAvbryt.Name = "btnAvbryt"
        Me.btnAvbryt.Size = New System.Drawing.Size(75, 23)
        Me.btnAvbryt.TabIndex = 29
        Me.btnAvbryt.Text = "Avbryt"
        Me.btnAvbryt.UseVisualStyleBackColor = True
        '
        'btnNewCake
        '
        Me.btnNewCake.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNewCake.Location = New System.Drawing.Point(459, 12)
        Me.btnNewCake.Name = "btnNewCake"
        Me.btnNewCake.Size = New System.Drawing.Size(75, 23)
        Me.btnNewCake.TabIndex = 30
        Me.btnNewCake.Text = "Ny kake >>"
        Me.btnNewCake.UseVisualStyleBackColor = True
        '
        'frmAdminCakes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(929, 572)
        Me.Controls.Add(Me.btnNewCake)
        Me.Controls.Add(Me.grpCakeEdit)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Controls.Add(Me.lblFilterCake)
        Me.Controls.Add(Me.txtFilterCake)
        Me.Controls.Add(Me.dtgCake)
        Me.MinimumSize = New System.Drawing.Size(945, 611)
        Me.Name = "frmAdminCakes"
        Me.Text = "Kaker"
        Me.grpIngredients.ResumeLayout(False)
        Me.grpIngredients.PerformLayout()
        CType(Me.dtgCake, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CakeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.grpCakeEdit.ResumeLayout(False)
        Me.grpCakeEdit.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstAvailableIngredients As System.Windows.Forms.ListBox
    Friend WithEvents btnAddIngredients As System.Windows.Forms.Button
    Friend WithEvents btnRemoveIngredients As System.Windows.Forms.Button
    Friend WithEvents lstSelectedIngredients As System.Windows.Forms.ListBox
    Friend WithEvents txtFilter As System.Windows.Forms.TextBox
    Friend WithEvents lblFilter As System.Windows.Forms.Label
    Friend WithEvents lblAmount As System.Windows.Forms.Label
    Friend WithEvents lblMeasureUnit As System.Windows.Forms.Label
    Friend WithEvents txtProcedure As System.Windows.Forms.TextBox
    Friend WithEvents lblProcedure As System.Windows.Forms.Label
    Friend WithEvents grpIngredients As System.Windows.Forms.GroupBox
    Friend WithEvents txtNameCake As System.Windows.Forms.TextBox
    Friend WithEvents lblNameCake As System.Windows.Forms.Label
    Friend WithEvents MarkUps As System.Windows.Forms.Label
    Friend WithEvents lblIngredientsPrice As System.Windows.Forms.Label
    Friend WithEvents lblSalePrice As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents dtgCake As System.Windows.Forms.DataGridView
    Friend WithEvents lblFilterCake As System.Windows.Forms.Label
    Friend WithEvents txtFilterCake As System.Windows.Forms.TextBox
    Friend WithEvents BindingNavigator1 As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents numAmount As Kakefunn.NumericTextbox
    Friend WithEvents numMarkUps As Kakefunn.NumericTextbox
    Friend WithEvents chkPublished As System.Windows.Forms.CheckBox
    Friend WithEvents CakeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents grpCakeEdit As System.Windows.Forms.GroupBox
    Friend WithEvents btnNewCake As System.Windows.Forms.Button
    Friend WithEvents btnToolStripCakeNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnToolStripCakeDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnAvbryt As System.Windows.Forms.Button
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents price As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MarkupPercentageDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PublishedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RecipeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DeletedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
