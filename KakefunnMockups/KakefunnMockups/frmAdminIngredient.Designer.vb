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
        Me.dtgResults = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnDel = New System.Windows.Forms.Button()
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
        'dtgResults
        '
        Me.dtgResults.AllowUserToAddRows = False
        Me.dtgResults.AllowUserToDeleteRows = False
        Me.dtgResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgResults.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colID, Me.colName, Me.colStock, Me.colBDGIn, Me.colBDGOut, Me.colProfig, Me.colDeleted})
        Me.dtgResults.Location = New System.Drawing.Point(13, 90)
        Me.dtgResults.Name = "dtgResults"
        Me.dtgResults.ReadOnly = True
        Me.dtgResults.RowHeadersVisible = False
        Me.dtgResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgResults.ShowEditingIcon = False
        Me.dtgResults.Size = New System.Drawing.Size(643, 365)
        Me.dtgResults.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 467)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "* Billigste / Dyreste / Gjennomsnitt"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(120, 63)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(136, 20)
        Me.txtSearch.TabIndex = 8
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Location = New System.Drawing.Point(13, 67)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(101, 13)
        Me.lblSearch.TabIndex = 10
        Me.lblSearch.Text = "Søk etter ingrediens"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(262, 61)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 9
        Me.btnSearch.Text = "Søk"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(553, 61)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(99, 23)
        Me.btnNew.TabIndex = 12
        Me.btnNew.Text = "Ny ingrediens ..."
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(472, 61)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(75, 23)
        Me.btnDel.TabIndex = 11
        Me.btnDel.Text = "Slett"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'colID
        '
        Me.colID.HeaderText = "Varenr"
        Me.colID.Name = "colID"
        Me.colID.ReadOnly = True
        '
        'colName
        '
        Me.colName.HeaderText = "Navn"
        Me.colName.Name = "colName"
        Me.colName.ReadOnly = True
        '
        'colStock
        '
        Me.colStock.HeaderText = "Antall på lager"
        Me.colStock.Name = "colStock"
        Me.colStock.ReadOnly = True
        '
        'colBDGIn
        '
        Me.colBDGIn.HeaderText = "B/D/G* innkjøp"
        Me.colBDGIn.Name = "colBDGIn"
        Me.colBDGIn.ReadOnly = True
        '
        'colBDGOut
        '
        Me.colBDGOut.HeaderText = "B/D/G* utsalg"
        Me.colBDGOut.Name = "colBDGOut"
        Me.colBDGOut.ReadOnly = True
        '
        'colProfig
        '
        Me.colProfig.HeaderText = "Avanse i %"
        Me.colProfig.Name = "colProfig"
        Me.colProfig.ReadOnly = True
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
        Me.ClientSize = New System.Drawing.Size(664, 516)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.lblSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtgResults)
        Me.Name = "frmAdminIngredient"
        Me.Text = "Ingredienser"
        Me.Controls.SetChildIndex(Me.dtgResults, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.txtSearch, 0)
        Me.Controls.SetChildIndex(Me.lblSearch, 0)
        Me.Controls.SetChildIndex(Me.btnSearch, 0)
        Me.Controls.SetChildIndex(Me.btnNew, 0)
        Me.Controls.SetChildIndex(Me.btnDel, 0)
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
