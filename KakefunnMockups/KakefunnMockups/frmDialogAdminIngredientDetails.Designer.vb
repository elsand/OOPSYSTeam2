<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDialogAdminIngredientDetails
    Inherits KakefunnMockups.frmDialogBase

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
        Me.grpIngredient = New System.Windows.Forms.GroupBox()
        Me.chkPub = New System.Windows.Forms.CheckBox()
        Me.txtProfit = New System.Windows.Forms.TextBox()
        Me.lblProfit = New System.Windows.Forms.Label()
        Me.txtVAT = New System.Windows.Forms.TextBox()
        Me.lblVAT = New System.Windows.Forms.Label()
        Me.ddlUnitType = New System.Windows.Forms.ComboBox()
        Me.txtCal = New System.Windows.Forms.TextBox()
        Me.lblCal = New System.Windows.Forms.Label()
        Me.lblUnitType = New System.Windows.Forms.Label()
        Me.txtDescr = New System.Windows.Forms.TextBox()
        Me.lblDescr = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.grpStock = New System.Windows.Forms.GroupBox()
        Me.dtgBatches = New System.Windows.Forms.DataGridView()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Innkjsdf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblDtgDescr = New System.Windows.Forms.Label()
        Me.lblNumInStockValue = New System.Windows.Forms.Label()
        Me.lblNumInStockText = New System.Windows.Forms.Label()
        Me.btnAbort = New System.Windows.Forms.Button()
        Me.grpIngredient.SuspendLayout()
        Me.grpStock.SuspendLayout()
        CType(Me.dtgBatches, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpIngredient
        '
        Me.grpIngredient.Controls.Add(Me.chkPub)
        Me.grpIngredient.Controls.Add(Me.txtProfit)
        Me.grpIngredient.Controls.Add(Me.lblProfit)
        Me.grpIngredient.Controls.Add(Me.txtVAT)
        Me.grpIngredient.Controls.Add(Me.lblVAT)
        Me.grpIngredient.Controls.Add(Me.ddlUnitType)
        Me.grpIngredient.Controls.Add(Me.txtCal)
        Me.grpIngredient.Controls.Add(Me.lblCal)
        Me.grpIngredient.Controls.Add(Me.lblUnitType)
        Me.grpIngredient.Controls.Add(Me.txtDescr)
        Me.grpIngredient.Controls.Add(Me.lblDescr)
        Me.grpIngredient.Controls.Add(Me.lblName)
        Me.grpIngredient.Controls.Add(Me.txtName)
        Me.grpIngredient.Location = New System.Drawing.Point(12, 12)
        Me.grpIngredient.Name = "grpIngredient"
        Me.grpIngredient.Size = New System.Drawing.Size(275, 286)
        Me.grpIngredient.TabIndex = 0
        Me.grpIngredient.TabStop = False
        Me.grpIngredient.Text = "Ingrediens"
        '
        'chkPub
        '
        Me.chkPub.AutoSize = True
        Me.chkPub.Location = New System.Drawing.Point(198, 234)
        Me.chkPub.Name = "chkPub"
        Me.chkPub.Size = New System.Drawing.Size(66, 17)
        Me.chkPub.TabIndex = 6
        Me.chkPub.Text = "Publisert"
        Me.chkPub.UseVisualStyleBackColor = True
        '
        'txtProfit
        '
        Me.txtProfit.Location = New System.Drawing.Point(96, 206)
        Me.txtProfit.Name = "txtProfit"
        Me.txtProfit.Size = New System.Drawing.Size(36, 20)
        Me.txtProfit.TabIndex = 5
        '
        'lblProfit
        '
        Me.lblProfit.AutoSize = True
        Me.lblProfit.Location = New System.Drawing.Point(8, 209)
        Me.lblProfit.Name = "lblProfit"
        Me.lblProfit.Size = New System.Drawing.Size(54, 13)
        Me.lblProfit.TabIndex = 15
        Me.lblProfit.Text = "Avanse-%"
        '
        'txtVAT
        '
        Me.txtVAT.Location = New System.Drawing.Point(96, 180)
        Me.txtVAT.Name = "txtVAT"
        Me.txtVAT.Size = New System.Drawing.Size(36, 20)
        Me.txtVAT.TabIndex = 4
        '
        'lblVAT
        '
        Me.lblVAT.AutoSize = True
        Me.lblVAT.Location = New System.Drawing.Point(8, 183)
        Me.lblVAT.Name = "lblVAT"
        Me.lblVAT.Size = New System.Drawing.Size(54, 13)
        Me.lblVAT.TabIndex = 13
        Me.lblVAT.Text = "Momssats"
        '
        'ddlUnitType
        '
        Me.ddlUnitType.FormattingEnabled = True
        Me.ddlUnitType.Location = New System.Drawing.Point(96, 127)
        Me.ddlUnitType.Name = "ddlUnitType"
        Me.ddlUnitType.Size = New System.Drawing.Size(121, 21)
        Me.ddlUnitType.TabIndex = 2
        '
        'txtCal
        '
        Me.txtCal.Location = New System.Drawing.Point(96, 154)
        Me.txtCal.Name = "txtCal"
        Me.txtCal.Size = New System.Drawing.Size(69, 20)
        Me.txtCal.TabIndex = 3
        '
        'lblCal
        '
        Me.lblCal.AutoSize = True
        Me.lblCal.Location = New System.Drawing.Point(8, 157)
        Me.lblCal.Name = "lblCal"
        Me.lblCal.Size = New System.Drawing.Size(60, 13)
        Me.lblCal.TabIndex = 8
        Me.lblCal.Text = "Kcal/enhet"
        '
        'lblUnitType
        '
        Me.lblUnitType.AutoSize = True
        Me.lblUnitType.Location = New System.Drawing.Point(6, 130)
        Me.lblUnitType.Name = "lblUnitType"
        Me.lblUnitType.Size = New System.Drawing.Size(60, 13)
        Me.lblUnitType.TabIndex = 6
        Me.lblUnitType.Text = "Enhetstype"
        '
        'txtDescr
        '
        Me.txtDescr.Location = New System.Drawing.Point(96, 53)
        Me.txtDescr.Multiline = True
        Me.txtDescr.Name = "txtDescr"
        Me.txtDescr.Size = New System.Drawing.Size(168, 68)
        Me.txtDescr.TabIndex = 1
        '
        'lblDescr
        '
        Me.lblDescr.AutoSize = True
        Me.lblDescr.Location = New System.Drawing.Point(8, 53)
        Me.lblDescr.Name = "lblDescr"
        Me.lblDescr.Size = New System.Drawing.Size(61, 13)
        Me.lblDescr.TabIndex = 4
        Me.lblDescr.Text = "Beskrivelse"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(8, 30)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(33, 13)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Navn"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(96, 27)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(168, 20)
        Me.txtName.TabIndex = 0
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(571, 319)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(106, 34)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "Lagre endringer"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'grpStock
        '
        Me.grpStock.Controls.Add(Me.dtgBatches)
        Me.grpStock.Controls.Add(Me.lblDtgDescr)
        Me.grpStock.Controls.Add(Me.lblNumInStockValue)
        Me.grpStock.Controls.Add(Me.lblNumInStockText)
        Me.grpStock.Location = New System.Drawing.Point(294, 13)
        Me.grpStock.Name = "grpStock"
        Me.grpStock.Size = New System.Drawing.Size(383, 285)
        Me.grpStock.TabIndex = 1
        Me.grpStock.TabStop = False
        Me.grpStock.Text = "Lagerstatus"
        '
        'dtgBatches
        '
        Me.dtgBatches.AllowUserToAddRows = False
        Me.dtgBatches.AllowUserToDeleteRows = False
        Me.dtgBatches.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgBatches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgBatches.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column4, Me.Column2, Me.Column3, Me.Innkjsdf, Me.Column1})
        Me.dtgBatches.Location = New System.Drawing.Point(9, 76)
        Me.dtgBatches.Name = "dtgBatches"
        Me.dtgBatches.RowHeadersVisible = False
        Me.dtgBatches.Size = New System.Drawing.Size(368, 195)
        Me.dtgBatches.TabIndex = 5
        '
        'Column4
        '
        Me.Column4.HeaderText = "Partinr"
        Me.Column4.Name = "Column4"
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
        'Innkjsdf
        '
        Me.Innkjsdf.HeaderText = "Innkjøpspris"
        Me.Innkjsdf.Name = "Innkjsdf"
        '
        'Column1
        '
        Me.Column1.HeaderText = "Salgspris"
        Me.Column1.Name = "Column1"
        '
        'lblDtgDescr
        '
        Me.lblDtgDescr.AutoSize = True
        Me.lblDtgDescr.Location = New System.Drawing.Point(6, 60)
        Me.lblDtgDescr.Name = "lblDtgDescr"
        Me.lblDtgDescr.Size = New System.Drawing.Size(157, 13)
        Me.lblDtgDescr.TabIndex = 4
        Me.lblDtgDescr.Text = "Beholdning har opphav i partier:"
        '
        'lblNumInStockValue
        '
        Me.lblNumInStockValue.AutoSize = True
        Me.lblNumInStockValue.Location = New System.Drawing.Point(204, 29)
        Me.lblNumInStockValue.Name = "lblNumInStockValue"
        Me.lblNumInStockValue.Size = New System.Drawing.Size(19, 13)
        Me.lblNumInStockValue.TabIndex = 3
        Me.lblNumInStockValue.Text = "47"
        '
        'lblNumInStockText
        '
        Me.lblNumInStockText.AutoSize = True
        Me.lblNumInStockText.Location = New System.Drawing.Point(6, 29)
        Me.lblNumInStockText.Name = "lblNumInStockText"
        Me.lblNumInStockText.Size = New System.Drawing.Size(119, 13)
        Me.lblNumInStockText.TabIndex = 2
        Me.lblNumInStockText.Text = "Antall enheter på lager: "
        '
        'btnAbort
        '
        Me.btnAbort.Location = New System.Drawing.Point(459, 319)
        Me.btnAbort.Name = "btnAbort"
        Me.btnAbort.Size = New System.Drawing.Size(106, 34)
        Me.btnAbort.TabIndex = 7
        Me.btnAbort.Text = "Avbryt"
        Me.btnAbort.UseVisualStyleBackColor = True
        '
        'frmDialogAdminIngredientDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(689, 378)
        Me.Controls.Add(Me.btnAbort)
        Me.Controls.Add(Me.grpStock)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.grpIngredient)
        Me.Name = "frmDialogAdminIngredientDetails"
        Me.Text = "Rediger ingrediensdetaljer for varenr #1234"
        Me.grpIngredient.ResumeLayout(False)
        Me.grpIngredient.PerformLayout()
        Me.grpStock.ResumeLayout(False)
        Me.grpStock.PerformLayout()
        CType(Me.dtgBatches, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpIngredient As System.Windows.Forms.GroupBox
    Friend WithEvents lblUnitType As System.Windows.Forms.Label
    Friend WithEvents txtDescr As System.Windows.Forms.TextBox
    Friend WithEvents lblDescr As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents ddlUnitType As System.Windows.Forms.ComboBox
    Friend WithEvents txtCal As System.Windows.Forms.TextBox
    Friend WithEvents lblCal As System.Windows.Forms.Label
    Friend WithEvents grpStock As System.Windows.Forms.GroupBox
    Friend WithEvents dtgBatches As System.Windows.Forms.DataGridView
    Friend WithEvents lblDtgDescr As System.Windows.Forms.Label
    Friend WithEvents lblNumInStockValue As System.Windows.Forms.Label
    Friend WithEvents lblNumInStockText As System.Windows.Forms.Label
    Friend WithEvents txtProfit As System.Windows.Forms.TextBox
    Friend WithEvents lblProfit As System.Windows.Forms.Label
    Friend WithEvents txtVAT As System.Windows.Forms.TextBox
    Friend WithEvents lblVAT As System.Windows.Forms.Label
    Friend WithEvents btnAbort As System.Windows.Forms.Button
    Friend WithEvents chkPub As System.Windows.Forms.CheckBox
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Innkjsdf As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
