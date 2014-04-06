<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdminCake
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdminCake))
        Me.lstAvailableIngredients = New System.Windows.Forms.ListBox()
        Me.btnAddIngredients = New System.Windows.Forms.Button()
        Me.btnRemoveIngredients = New System.Windows.Forms.Button()
        Me.lstSelectedIngredients = New System.Windows.Forms.ListBox()
        Me.txtFilter = New System.Windows.Forms.TextBox()
        Me.lblFilter = New System.Windows.Forms.Label()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.lblGram = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.txtProcedure = New System.Windows.Forms.TextBox()
        Me.lblProcedure = New System.Windows.Forms.Label()
        Me.grpIngredients = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtNameCake = New System.Windows.Forms.TextBox()
        Me.lblNameCake = New System.Windows.Forms.Label()
        Me.MarkUps = New System.Windows.Forms.Label()
        Me.txtMarkUps = New System.Windows.Forms.TextBox()
        Me.lblIngredientsPrice = New System.Windows.Forms.Label()
        Me.lblSalePrice = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.dtgCake = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblSearchCake = New System.Windows.Forms.Label()
        Me.txtSearchCake = New System.Windows.Forms.TextBox()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.grpIngredients.SuspendLayout()
        CType(Me.dtgCake, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstAvailableIngredients
        '
        Me.lstAvailableIngredients.FormattingEnabled = True
        Me.lstAvailableIngredients.Location = New System.Drawing.Point(18, 60)
        Me.lstAvailableIngredients.Name = "lstAvailableIngredients"
        Me.lstAvailableIngredients.Size = New System.Drawing.Size(138, 134)
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
        Me.lstSelectedIngredients.Name = "lstSelectedIngredients"
        Me.lstSelectedIngredients.Size = New System.Drawing.Size(138, 134)
        Me.lstSelectedIngredients.TabIndex = 7
        '
        'txtFilter
        '
        Me.txtFilter.Location = New System.Drawing.Point(18, 38)
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Size = New System.Drawing.Size(138, 20)
        Me.txtFilter.TabIndex = 8
        '
        'lblFilter
        '
        Me.lblFilter.AutoSize = True
        Me.lblFilter.Location = New System.Drawing.Point(15, 22)
        Me.lblFilter.Name = "lblFilter"
        Me.lblFilter.Size = New System.Drawing.Size(29, 13)
        Me.lblFilter.TabIndex = 9
        Me.lblFilter.Text = "Filter"
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.Location = New System.Drawing.Point(197, 208)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(46, 13)
        Me.lblAmount.TabIndex = 10
        Me.lblAmount.Text = "Mengde"
        '
        'lblGram
        '
        Me.lblGram.AutoSize = True
        Me.lblGram.Location = New System.Drawing.Point(292, 228)
        Me.lblGram.Name = "lblGram"
        Me.lblGram.Size = New System.Drawing.Size(30, 13)
        Me.lblGram.TabIndex = 11
        Me.lblGram.Text = "gram"
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(200, 225)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(86, 20)
        Me.txtAmount.TabIndex = 12
        Me.txtAmount.Text = "100"
        '
        'txtProcedure
        '
        Me.txtProcedure.Enabled = False
        Me.txtProcedure.Location = New System.Drawing.Point(545, 367)
        Me.txtProcedure.Multiline = True
        Me.txtProcedure.Name = "txtProcedure"
        Me.txtProcedure.Size = New System.Drawing.Size(350, 94)
        Me.txtProcedure.TabIndex = 13
        '
        'lblProcedure
        '
        Me.lblProcedure.AutoSize = True
        Me.lblProcedure.Enabled = False
        Me.lblProcedure.Location = New System.Drawing.Point(542, 351)
        Me.lblProcedure.Name = "lblProcedure"
        Me.lblProcedure.Size = New System.Drawing.Size(82, 13)
        Me.lblProcedure.TabIndex = 14
        Me.lblProcedure.Text = "Fremgangsmåte"
        '
        'grpIngredients
        '
        Me.grpIngredients.Controls.Add(Me.Button1)
        Me.grpIngredients.Controls.Add(Me.lstAvailableIngredients)
        Me.grpIngredients.Controls.Add(Me.btnAddIngredients)
        Me.grpIngredients.Controls.Add(Me.btnRemoveIngredients)
        Me.grpIngredients.Controls.Add(Me.lstSelectedIngredients)
        Me.grpIngredients.Controls.Add(Me.txtFilter)
        Me.grpIngredients.Controls.Add(Me.lblFilter)
        Me.grpIngredients.Controls.Add(Me.lblAmount)
        Me.grpIngredients.Controls.Add(Me.txtAmount)
        Me.grpIngredients.Controls.Add(Me.lblGram)
        Me.grpIngredients.Enabled = False
        Me.grpIngredients.Location = New System.Drawing.Point(545, 91)
        Me.grpIngredients.Name = "grpIngredients"
        Me.grpIngredients.Size = New System.Drawing.Size(350, 257)
        Me.grpIngredients.TabIndex = 15
        Me.grpIngredients.TabStop = False
        Me.grpIngredients.Text = "Ingredienser"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(37, 217)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtNameCake
        '
        Me.txtNameCake.Location = New System.Drawing.Point(639, 65)
        Me.txtNameCake.Name = "txtNameCake"
        Me.txtNameCake.Size = New System.Drawing.Size(100, 20)
        Me.txtNameCake.TabIndex = 16
        '
        'lblNameCake
        '
        Me.lblNameCake.AutoSize = True
        Me.lblNameCake.Location = New System.Drawing.Point(549, 68)
        Me.lblNameCake.Name = "lblNameCake"
        Me.lblNameCake.Size = New System.Drawing.Size(75, 13)
        Me.lblNameCake.TabIndex = 17
        Me.lblNameCake.Text = "Navn på kake"
        '
        'MarkUps
        '
        Me.MarkUps.AutoSize = True
        Me.MarkUps.Enabled = False
        Me.MarkUps.Location = New System.Drawing.Point(626, 478)
        Me.MarkUps.Name = "MarkUps"
        Me.MarkUps.Size = New System.Drawing.Size(71, 13)
        Me.MarkUps.TabIndex = 19
        Me.MarkUps.Text = "Prispåslag i %"
        '
        'txtMarkUps
        '
        Me.txtMarkUps.Enabled = False
        Me.txtMarkUps.Location = New System.Drawing.Point(703, 475)
        Me.txtMarkUps.Name = "txtMarkUps"
        Me.txtMarkUps.Size = New System.Drawing.Size(41, 20)
        Me.txtMarkUps.TabIndex = 18
        '
        'lblIngredientsPrice
        '
        Me.lblIngredientsPrice.AutoSize = True
        Me.lblIngredientsPrice.Enabled = False
        Me.lblIngredientsPrice.Location = New System.Drawing.Point(778, 478)
        Me.lblIngredientsPrice.Name = "lblIngredientsPrice"
        Me.lblIngredientsPrice.Size = New System.Drawing.Size(117, 13)
        Me.lblIngredientsPrice.TabIndex = 20
        Me.lblIngredientsPrice.Text = "Ingredienspris: 1234,54"
        '
        'lblSalePrice
        '
        Me.lblSalePrice.AutoSize = True
        Me.lblSalePrice.Enabled = False
        Me.lblSalePrice.Location = New System.Drawing.Point(801, 500)
        Me.lblSalePrice.Name = "lblSalePrice"
        Me.lblSalePrice.Size = New System.Drawing.Size(94, 13)
        Me.lblSalePrice.TabIndex = 21
        Me.lblSalePrice.Text = "Salgspris: 1234,54"
        '
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.Location = New System.Drawing.Point(820, 525)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 22
        Me.btnSave.Text = "Lagre"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'dtgCake
        '
        Me.dtgCake.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgCake.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgCake.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.dtgCake.Location = New System.Drawing.Point(12, 91)
        Me.dtgCake.Name = "dtgCake"
        Me.dtgCake.RowHeadersVisible = False
        Me.dtgCake.Size = New System.Drawing.Size(511, 457)
        Me.dtgCake.TabIndex = 23
        '
        'Column1
        '
        Me.Column1.HeaderText = "Kakenr"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Navn"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Pris"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Sist endret"
        Me.Column4.Name = "Column4"
        '
        'lblSearchCake
        '
        Me.lblSearchCake.AutoSize = True
        Me.lblSearchCake.Location = New System.Drawing.Point(12, 68)
        Me.lblSearchCake.Name = "lblSearchCake"
        Me.lblSearchCake.Size = New System.Drawing.Size(77, 13)
        Me.lblSearchCake.TabIndex = 25
        Me.lblSearchCake.Text = "Søk etter kake"
        '
        'txtSearchCake
        '
        Me.txtSearchCake.Location = New System.Drawing.Point(102, 65)
        Me.txtSearchCake.Name = "txtSearchCake"
        Me.txtSearchCake.Size = New System.Drawing.Size(100, 20)
        Me.txtSearchCake.TabIndex = 24
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BindingNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 556)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(909, 25)
        Me.BindingNavigator1.TabIndex = 26
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
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
        'frmAdminCake
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(909, 603)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Controls.Add(Me.lblSearchCake)
        Me.Controls.Add(Me.txtSearchCake)
        Me.Controls.Add(Me.dtgCake)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblSalePrice)
        Me.Controls.Add(Me.lblIngredientsPrice)
        Me.Controls.Add(Me.MarkUps)
        Me.Controls.Add(Me.txtMarkUps)
        Me.Controls.Add(Me.lblNameCake)
        Me.Controls.Add(Me.txtNameCake)
        Me.Controls.Add(Me.grpIngredients)
        Me.Controls.Add(Me.lblProcedure)
        Me.Controls.Add(Me.txtProcedure)
        Me.Name = "frmAdminCake"
        Me.Text = "Kaker"
        Me.Controls.SetChildIndex(Me.txtProcedure, 0)
        Me.Controls.SetChildIndex(Me.lblProcedure, 0)
        Me.Controls.SetChildIndex(Me.grpIngredients, 0)
        Me.Controls.SetChildIndex(Me.txtNameCake, 0)
        Me.Controls.SetChildIndex(Me.lblNameCake, 0)
        Me.Controls.SetChildIndex(Me.txtMarkUps, 0)
        Me.Controls.SetChildIndex(Me.MarkUps, 0)
        Me.Controls.SetChildIndex(Me.lblIngredientsPrice, 0)
        Me.Controls.SetChildIndex(Me.lblSalePrice, 0)
        Me.Controls.SetChildIndex(Me.btnSave, 0)
        Me.Controls.SetChildIndex(Me.dtgCake, 0)
        Me.Controls.SetChildIndex(Me.txtSearchCake, 0)
        Me.Controls.SetChildIndex(Me.lblSearchCake, 0)
        Me.Controls.SetChildIndex(Me.BindingNavigator1, 0)
        Me.grpIngredients.ResumeLayout(False)
        Me.grpIngredients.PerformLayout()
        CType(Me.dtgCake, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
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
    Friend WithEvents lblGram As System.Windows.Forms.Label
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents txtProcedure As System.Windows.Forms.TextBox
    Friend WithEvents lblProcedure As System.Windows.Forms.Label
    Friend WithEvents grpIngredients As System.Windows.Forms.GroupBox
    Friend WithEvents txtNameCake As System.Windows.Forms.TextBox
    Friend WithEvents lblNameCake As System.Windows.Forms.Label
    Friend WithEvents MarkUps As System.Windows.Forms.Label
    Friend WithEvents txtMarkUps As System.Windows.Forms.TextBox
    Friend WithEvents lblIngredientsPrice As System.Windows.Forms.Label
    Friend WithEvents lblSalePrice As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents dtgCake As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblSearchCake As System.Windows.Forms.Label
    Friend WithEvents txtSearchCake As System.Windows.Forms.TextBox
    Friend WithEvents BindingNavigator1 As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
