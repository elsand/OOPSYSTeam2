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
        Me.dtgExpiredIngredients = New System.Windows.Forms.DataGridView()
        Me.Varenr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dsfgsdf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnPrintExpiredIngredients = New System.Windows.Forms.Button()
        Me.btnCheckAll = New System.Windows.Forms.Button()
        Me.btbDeleteCheckedIngredientsInStock = New System.Windows.Forms.Button()
        CType(Me.dtgExpiredIngredients, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtgExpiredIngredients
        '
        Me.dtgExpiredIngredients.AllowUserToAddRows = False
        Me.dtgExpiredIngredients.AllowUserToDeleteRows = False
        Me.dtgExpiredIngredients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgExpiredIngredients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgExpiredIngredients.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Varenr, Me.Column4, Me.Column1, Me.Column2, Me.Column3, Me.dsfgsdf})
        Me.dtgExpiredIngredients.Location = New System.Drawing.Point(12, 79)
        Me.dtgExpiredIngredients.Name = "dtgExpiredIngredients"
        Me.dtgExpiredIngredients.RowHeadersVisible = False
        Me.dtgExpiredIngredients.Size = New System.Drawing.Size(682, 267)
        Me.dtgExpiredIngredients.TabIndex = 6
        '
        'Varenr
        '
        Me.Varenr.HeaderText = "Varenr"
        Me.Varenr.Name = "Varenr"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Navn"
        Me.Column4.Name = "Column4"
        '
        'Column1
        '
        Me.Column1.HeaderText = "Mottatt dato"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Utløpsdato"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Antall"
        Me.Column3.Name = "Column3"
        '
        'dsfgsdf
        '
        Me.dsfgsdf.HeaderText = "Reol/Hylle"
        Me.dsfgsdf.Name = "dsfgsdf"
        '
        'btnPrintExpiredIngredients
        '
        Me.btnPrintExpiredIngredients.Location = New System.Drawing.Point(619, 361)
        Me.btnPrintExpiredIngredients.Name = "btnPrintExpiredIngredients"
        Me.btnPrintExpiredIngredients.Size = New System.Drawing.Size(75, 23)
        Me.btnPrintExpiredIngredients.TabIndex = 7
        Me.btnPrintExpiredIngredients.Text = "Skriv ut"
        Me.btnPrintExpiredIngredients.UseVisualStyleBackColor = True
        '
        'btnCheckAll
        '
        Me.btnCheckAll.Location = New System.Drawing.Point(12, 361)
        Me.btnCheckAll.Name = "btnCheckAll"
        Me.btnCheckAll.Size = New System.Drawing.Size(75, 23)
        Me.btnCheckAll.TabIndex = 8
        Me.btnCheckAll.Text = "Merk alle"
        Me.btnCheckAll.UseVisualStyleBackColor = True
        '
        'btbDeleteCheckedIngredientsInStock
        '
        Me.btbDeleteCheckedIngredientsInStock.Location = New System.Drawing.Point(93, 361)
        Me.btbDeleteCheckedIngredientsInStock.Name = "btbDeleteCheckedIngredientsInStock"
        Me.btbDeleteCheckedIngredientsInStock.Size = New System.Drawing.Size(175, 23)
        Me.btbDeleteCheckedIngredientsInStock.TabIndex = 9
        Me.btbDeleteCheckedIngredientsInStock.Text = "Slett merkede fra varelager"
        Me.btbDeleteCheckedIngredientsInStock.UseVisualStyleBackColor = True
        '
        'frmLogisticsReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(706, 422)
        Me.Controls.Add(Me.btbDeleteCheckedIngredientsInStock)
        Me.Controls.Add(Me.btnCheckAll)
        Me.Controls.Add(Me.btnPrintExpiredIngredients)
        Me.Controls.Add(Me.dtgExpiredIngredients)
        Me.Name = "frmLogisticsReports"
        Me.Text = "Utløpte varer"
        Me.Controls.SetChildIndex(Me.dtgExpiredIngredients, 0)
        Me.Controls.SetChildIndex(Me.btnPrintExpiredIngredients, 0)
        Me.Controls.SetChildIndex(Me.btnCheckAll, 0)
        Me.Controls.SetChildIndex(Me.btbDeleteCheckedIngredientsInStock, 0)
        CType(Me.dtgExpiredIngredients, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtgExpiredIngredients As System.Windows.Forms.DataGridView
    Friend WithEvents Varenr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dsfgsdf As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnPrintExpiredIngredients As System.Windows.Forms.Button
    Friend WithEvents btnCheckAll As System.Windows.Forms.Button
    Friend WithEvents btbDeleteCheckedIngredientsInStock As System.Windows.Forms.Button

End Class
