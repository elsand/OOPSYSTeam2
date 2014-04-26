<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdminIngredient
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
        Me.btnDel = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtgResults = New System.Windows.Forms.DataGridView()
        Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBDGIn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBDGOut = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colProfig = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDeleted = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dtgResults, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDel
        '
        Me.btnDel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDel.Location = New System.Drawing.Point(735, 10)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(75, 23)
        Me.btnDel.TabIndex = 11
        Me.btnDel.Text = "Slett"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNew.Location = New System.Drawing.Point(816, 10)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(99, 23)
        Me.btnNew.TabIndex = 12
        Me.btnNew.Text = "Ny ingrediens ..."
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(260, 10)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 9
        Me.btnSearch.Text = "Søk"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Location = New System.Drawing.Point(11, 16)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(101, 13)
        Me.lblSearch.TabIndex = 10
        Me.lblSearch.Text = "Søk etter ingrediens"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(118, 12)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(136, 20)
        Me.txtSearch.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 554)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "* Billigste / Dyreste / Gjennomsnitt"
        '
        'dtgResults
        '
        Me.dtgResults.AllowUserToAddRows = False
        Me.dtgResults.AllowUserToDeleteRows = False
        Me.dtgResults.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtgResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgResults.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colID, Me.colName, Me.colStock, Me.colBDGIn, Me.colBDGOut, Me.colProfig, Me.colDeleted})
        Me.dtgResults.Location = New System.Drawing.Point(11, 39)
        Me.dtgResults.Name = "dtgResults"
        Me.dtgResults.ReadOnly = True
        Me.dtgResults.RowHeadersVisible = False
        Me.dtgResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgResults.ShowEditingIcon = False
        Me.dtgResults.Size = New System.Drawing.Size(904, 512)
        Me.dtgResults.TabIndex = 10
        '
        'colID
        '
        Me.colID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.colID.HeaderText = "Varenr"
        Me.colID.Name = "colID"
        Me.colID.ReadOnly = True
        Me.colID.Width = 63
        '
        'colName
        '
        Me.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colName.HeaderText = "Navn"
        Me.colName.Name = "colName"
        Me.colName.ReadOnly = True
        '
        'colStock
        '
        Me.colStock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colStock.HeaderText = "Antall på lager"
        Me.colStock.Name = "colStock"
        Me.colStock.ReadOnly = True
        Me.colStock.Width = 99
        '
        'colBDGIn
        '
        Me.colBDGIn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colBDGIn.HeaderText = "B/D/G* innkjøp"
        Me.colBDGIn.Name = "colBDGIn"
        Me.colBDGIn.ReadOnly = True
        Me.colBDGIn.Width = 97
        '
        'colBDGOut
        '
        Me.colBDGOut.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colBDGOut.HeaderText = "B/D/G* utsalg"
        Me.colBDGOut.Name = "colBDGOut"
        Me.colBDGOut.ReadOnly = True
        Me.colBDGOut.Width = 92
        '
        'colProfig
        '
        Me.colProfig.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colProfig.HeaderText = "Avanse i %"
        Me.colProfig.Name = "colProfig"
        Me.colProfig.ReadOnly = True
        Me.colProfig.Width = 70
        '
        'colDeleted
        '
        Me.colDeleted.HeaderText = "Deleted"
        Me.colDeleted.Name = "colDeleted"
        Me.colDeleted.ReadOnly = True
        Me.colDeleted.Visible = False
        '
        'frmAdminIngredient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(929, 621)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.lblSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtgResults)
        Me.MinimumSize = New System.Drawing.Size(945, 660)
        Me.Name = "frmAdminIngredient"
        Me.Text = "Ingredienser"
        CType(Me.dtgResults, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtgResults As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents lblSearch As System.Windows.Forms.Label
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnDel As System.Windows.Forms.Button
    Friend WithEvents colID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colStock As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colBDGIn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colBDGOut As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colProfig As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDeleted As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
