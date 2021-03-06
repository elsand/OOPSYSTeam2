﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdminBatch
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
        Me.lblEditExplanation = New System.Windows.Forms.Label()
        Me.dtgBatch = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dcIngredient = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.expected = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dcUnitPurchasingPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BatchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnPrintOrderList = New System.Windows.Forms.Button()
        Me.btnDeleteBatch = New System.Windows.Forms.Button()
        Me.btnNewBatch = New System.Windows.Forms.Button()
        Me.grpBatch = New System.Windows.Forms.GroupBox()
        Me.txtPurchasingPrice = New Kakefunn.NumericTextbox()
        Me.txtNumUnits = New Kakefunn.NumericTextbox()
        Me.lblStorageStatus = New System.Windows.Forms.Label()
        Me.ddlPricePer = New System.Windows.Forms.ComboBox()
        Me.dtpExpires = New System.Windows.Forms.DateTimePicker()
        Me.lblUnit = New System.Windows.Forms.Label()
        Me.dtpExpected = New System.Windows.Forms.DateTimePicker()
        Me.lblExpires = New System.Windows.Forms.Label()
        Me.lblExpected = New System.Windows.Forms.Label()
        Me.lblNumUnits = New System.Windows.Forms.Label()
        Me.lblNameIngredients = New System.Windows.Forms.Label()
        Me.txtIngredient = New System.Windows.Forms.TextBox()
        Me.btnSaveBatch = New System.Windows.Forms.Button()
        Me.lblPurchasingPrice = New System.Windows.Forms.Label()
        Me.btnChangeSelection = New System.Windows.Forms.Button()
        CType(Me.dtgBatch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BatchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpBatch.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblEditExplanation
        '
        Me.lblEditExplanation.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblEditExplanation.AutoSize = True
        Me.lblEditExplanation.Location = New System.Drawing.Point(7, 145)
        Me.lblEditExplanation.Name = "lblEditExplanation"
        Me.lblEditExplanation.Size = New System.Drawing.Size(193, 13)
        Me.lblEditExplanation.TabIndex = 15
        Me.lblEditExplanation.Text = "Dobbeltklikk for å redigere en oppføring"
        '
        'dtgBatch
        '
        Me.dtgBatch.AllowUserToAddRows = False
        Me.dtgBatch.AllowUserToDeleteRows = False
        Me.dtgBatch.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtgBatch.AutoGenerateColumns = False
        Me.dtgBatch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgBatch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgBatch.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.dcIngredient, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn2, Me.expected, Me.DataGridViewTextBoxColumn3, Me.dcUnitPurchasingPrice, Me.DataGridViewTextBoxColumn4})
        Me.dtgBatch.DataSource = Me.BatchBindingSource
        Me.dtgBatch.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtgBatch.Location = New System.Drawing.Point(10, 12)
        Me.dtgBatch.Name = "dtgBatch"
        Me.dtgBatch.RowHeadersVisible = False
        Me.dtgBatch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgBatch.Size = New System.Drawing.Size(654, 130)
        Me.dtgBatch.TabIndex = 8
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn1.FillWeight = 50.0!
        Me.DataGridViewTextBoxColumn1.HeaderText = "Partinr"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'dcIngredient
        '
        Me.dcIngredient.DataPropertyName = "Ingredient"
        Me.dcIngredient.FillWeight = 120.0!
        Me.dcIngredient.HeaderText = "Ingrediens"
        Me.dcIngredient.Name = "dcIngredient"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "unitCount"
        Me.DataGridViewTextBoxColumn5.FillWeight = 75.0!
        Me.DataGridViewTextBoxColumn5.HeaderText = "Antall"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ordered"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Bestilt"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'expected
        '
        Me.expected.DataPropertyName = "expected"
        Me.expected.HeaderText = "Ventet på lager"
        Me.expected.Name = "expected"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "registered"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Registrert"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'dcUnitPurchasingPrice
        '
        Me.dcUnitPurchasingPrice.DataPropertyName = "unitPurchasingPrice"
        Me.dcUnitPurchasingPrice.HeaderText = "Innkjøpspris"
        Me.dcUnitPurchasingPrice.Name = "dcUnitPurchasingPrice"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "expires"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Utløpsdato"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'BatchBindingSource
        '
        Me.BatchBindingSource.DataSource = GetType(Kakefunn.Batch)
        '
        'btnPrintOrderList
        '
        Me.btnPrintOrderList.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnPrintOrderList.Location = New System.Drawing.Point(322, 171)
        Me.btnPrintOrderList.Name = "btnPrintOrderList"
        Me.btnPrintOrderList.Size = New System.Drawing.Size(150, 23)
        Me.btnPrintOrderList.TabIndex = 11
        Me.btnPrintOrderList.Text = "Vis ikke mottatte bestillinger"
        Me.btnPrintOrderList.UseVisualStyleBackColor = True
        '
        'btnDeleteBatch
        '
        Me.btnDeleteBatch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnDeleteBatch.Location = New System.Drawing.Point(166, 171)
        Me.btnDeleteBatch.Name = "btnDeleteBatch"
        Me.btnDeleteBatch.Size = New System.Drawing.Size(150, 23)
        Me.btnDeleteBatch.TabIndex = 10
        Me.btnDeleteBatch.Text = "Slett parti/bestilling"
        Me.btnDeleteBatch.UseVisualStyleBackColor = True
        '
        'btnNewBatch
        '
        Me.btnNewBatch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnNewBatch.Location = New System.Drawing.Point(10, 171)
        Me.btnNewBatch.Name = "btnNewBatch"
        Me.btnNewBatch.Size = New System.Drawing.Size(150, 23)
        Me.btnNewBatch.TabIndex = 9
        Me.btnNewBatch.Text = "Ny bestilling"
        Me.btnNewBatch.UseVisualStyleBackColor = True
        '
        'grpBatch
        '
        Me.grpBatch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpBatch.Controls.Add(Me.txtPurchasingPrice)
        Me.grpBatch.Controls.Add(Me.txtNumUnits)
        Me.grpBatch.Controls.Add(Me.lblStorageStatus)
        Me.grpBatch.Controls.Add(Me.ddlPricePer)
        Me.grpBatch.Controls.Add(Me.dtpExpires)
        Me.grpBatch.Controls.Add(Me.lblUnit)
        Me.grpBatch.Controls.Add(Me.dtpExpected)
        Me.grpBatch.Controls.Add(Me.lblExpires)
        Me.grpBatch.Controls.Add(Me.lblExpected)
        Me.grpBatch.Controls.Add(Me.lblNumUnits)
        Me.grpBatch.Controls.Add(Me.lblNameIngredients)
        Me.grpBatch.Controls.Add(Me.txtIngredient)
        Me.grpBatch.Controls.Add(Me.btnSaveBatch)
        Me.grpBatch.Controls.Add(Me.lblPurchasingPrice)
        Me.grpBatch.Location = New System.Drawing.Point(10, 200)
        Me.grpBatch.Name = "grpBatch"
        Me.grpBatch.Size = New System.Drawing.Size(654, 154)
        Me.grpBatch.TabIndex = 12
        Me.grpBatch.TabStop = False
        Me.grpBatch.Text = "Vareparti/bestilling"
        '
        'txtPurchasingPrice
        '
        Me.txtPurchasingPrice.AllowDecimal = True
        Me.txtPurchasingPrice.AllowNegative = False
        Me.txtPurchasingPrice.AllowSpace = False
        Me.txtPurchasingPrice.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPurchasingPrice.Location = New System.Drawing.Point(444, 86)
        Me.txtPurchasingPrice.Name = "txtPurchasingPrice"
        Me.txtPurchasingPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtPurchasingPrice.TabIndex = 4
        '
        'txtNumUnits
        '
        Me.txtNumUnits.AllowDecimal = False
        Me.txtNumUnits.AllowNegative = False
        Me.txtNumUnits.AllowSpace = False
        Me.txtNumUnits.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtNumUnits.Location = New System.Drawing.Point(118, 53)
        Me.txtNumUnits.Name = "txtNumUnits"
        Me.txtNumUnits.Size = New System.Drawing.Size(100, 20)
        Me.txtNumUnits.TabIndex = 1
        '
        'lblStorageStatus
        '
        Me.lblStorageStatus.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStorageStatus.AutoSize = True
        Me.lblStorageStatus.Location = New System.Drawing.Point(342, 28)
        Me.lblStorageStatus.Name = "lblStorageStatus"
        Me.lblStorageStatus.Size = New System.Drawing.Size(191, 13)
        Me.lblStorageStatus.TabIndex = 17
        Me.lblStorageStatus.Text = "Partiet er ikke registrert mottatt på lager"
        '
        'ddlPricePer
        '
        Me.ddlPricePer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ddlPricePer.FormattingEnabled = True
        Me.ddlPricePer.Items.AddRange(New Object() {"per enhet", "per parti"})
        Me.ddlPricePer.Location = New System.Drawing.Point(557, 85)
        Me.ddlPricePer.Name = "ddlPricePer"
        Me.ddlPricePer.Size = New System.Drawing.Size(78, 21)
        Me.ddlPricePer.TabIndex = 5
        Me.ddlPricePer.Text = "per enhet"
        '
        'dtpExpires
        '
        Me.dtpExpires.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpExpires.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpExpires.Location = New System.Drawing.Point(444, 53)
        Me.dtpExpires.Name = "dtpExpires"
        Me.dtpExpires.Size = New System.Drawing.Size(102, 20)
        Me.dtpExpires.TabIndex = 3
        '
        'lblUnit
        '
        Me.lblUnit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblUnit.AutoSize = True
        Me.lblUnit.Location = New System.Drawing.Point(224, 57)
        Me.lblUnit.Name = "lblUnit"
        Me.lblUnit.Size = New System.Drawing.Size(30, 13)
        Me.lblUnit.TabIndex = 10
        Me.lblUnit.Text = "gram"
        '
        'dtpExpected
        '
        Me.dtpExpected.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dtpExpected.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpExpected.Location = New System.Drawing.Point(116, 83)
        Me.dtpExpected.Name = "dtpExpected"
        Me.dtpExpected.Size = New System.Drawing.Size(102, 20)
        Me.dtpExpected.TabIndex = 2
        '
        'lblExpires
        '
        Me.lblExpires.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblExpires.AutoSize = True
        Me.lblExpires.Location = New System.Drawing.Point(342, 57)
        Me.lblExpires.Name = "lblExpires"
        Me.lblExpires.Size = New System.Drawing.Size(58, 13)
        Me.lblExpires.TabIndex = 14
        Me.lblExpires.Text = "Utløpsdato"
        '
        'lblExpected
        '
        Me.lblExpected.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblExpected.AutoSize = True
        Me.lblExpected.Location = New System.Drawing.Point(14, 86)
        Me.lblExpected.Name = "lblExpected"
        Me.lblExpected.Size = New System.Drawing.Size(79, 13)
        Me.lblExpected.TabIndex = 4
        Me.lblExpected.Text = "Ventet på lager"
        '
        'lblNumUnits
        '
        Me.lblNumUnits.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblNumUnits.AutoSize = True
        Me.lblNumUnits.Location = New System.Drawing.Point(14, 57)
        Me.lblNumUnits.Name = "lblNumUnits"
        Me.lblNumUnits.Size = New System.Drawing.Size(98, 13)
        Me.lblNumUnits.TabIndex = 2
        Me.lblNumUnits.Text = "Antall enheter i kolli"
        '
        'lblNameIngredients
        '
        Me.lblNameIngredients.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblNameIngredients.AutoSize = True
        Me.lblNameIngredients.Location = New System.Drawing.Point(14, 28)
        Me.lblNameIngredients.Name = "lblNameIngredients"
        Me.lblNameIngredients.Size = New System.Drawing.Size(99, 13)
        Me.lblNameIngredients.TabIndex = 1
        Me.lblNameIngredients.Text = "Navn på ingrediens"
        '
        'txtIngredient
        '
        Me.txtIngredient.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtIngredient.Location = New System.Drawing.Point(118, 25)
        Me.txtIngredient.Name = "txtIngredient"
        Me.txtIngredient.Size = New System.Drawing.Size(198, 20)
        Me.txtIngredient.TabIndex = 0
        '
        'btnSaveBatch
        '
        Me.btnSaveBatch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSaveBatch.Location = New System.Drawing.Point(519, 115)
        Me.btnSaveBatch.Name = "btnSaveBatch"
        Me.btnSaveBatch.Size = New System.Drawing.Size(116, 23)
        Me.btnSaveBatch.TabIndex = 6
        Me.btnSaveBatch.Text = "Lagre parti/bestilling"
        Me.btnSaveBatch.UseVisualStyleBackColor = True
        '
        'lblPurchasingPrice
        '
        Me.lblPurchasingPrice.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPurchasingPrice.AutoSize = True
        Me.lblPurchasingPrice.Location = New System.Drawing.Point(342, 86)
        Me.lblPurchasingPrice.Name = "lblPurchasingPrice"
        Me.lblPurchasingPrice.Size = New System.Drawing.Size(63, 13)
        Me.lblPurchasingPrice.TabIndex = 7
        Me.lblPurchasingPrice.Text = "Innkjøpspris"
        '
        'btnChangeSelection
        '
        Me.btnChangeSelection.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnChangeSelection.Location = New System.Drawing.Point(478, 171)
        Me.btnChangeSelection.Name = "btnChangeSelection"
        Me.btnChangeSelection.Size = New System.Drawing.Size(150, 23)
        Me.btnChangeSelection.TabIndex = 16
        Me.btnChangeSelection.Tag = "0"
        Me.btnChangeSelection.Text = "Vis åpne bestillinger"
        Me.btnChangeSelection.UseVisualStyleBackColor = True
        '
        'frmAdminBatch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(683, 371)
        Me.Controls.Add(Me.btnChangeSelection)
        Me.Controls.Add(Me.lblEditExplanation)
        Me.Controls.Add(Me.dtgBatch)
        Me.Controls.Add(Me.btnPrintOrderList)
        Me.Controls.Add(Me.btnDeleteBatch)
        Me.Controls.Add(Me.btnNewBatch)
        Me.Controls.Add(Me.grpBatch)
        Me.MinimumSize = New System.Drawing.Size(685, 400)
        Me.Name = "frmAdminBatch"
        Me.Text = "Varebestilling og partier"
        CType(Me.dtgBatch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BatchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpBatch.ResumeLayout(False)
        Me.grpBatch.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpBatch As System.Windows.Forms.GroupBox
    Friend WithEvents dtpExpected As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblExpected As System.Windows.Forms.Label
    Friend WithEvents lblNumUnits As System.Windows.Forms.Label
    Friend WithEvents lblNameIngredients As System.Windows.Forms.Label
    Friend WithEvents txtIngredient As System.Windows.Forms.TextBox
    Friend WithEvents dtpExpires As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblExpires As System.Windows.Forms.Label
    Friend WithEvents btnSaveBatch As System.Windows.Forms.Button
    Friend WithEvents lblUnit As System.Windows.Forms.Label
    Friend WithEvents lblPurchasingPrice As System.Windows.Forms.Label
    Friend WithEvents ddlPricePer As System.Windows.Forms.ComboBox
    Friend WithEvents btnNewBatch As System.Windows.Forms.Button
    Friend WithEvents btnDeleteBatch As System.Windows.Forms.Button
    Friend WithEvents btnPrintOrderList As System.Windows.Forms.Button
    Friend WithEvents lblStorageStatus As System.Windows.Forms.Label
    Friend WithEvents txtNumUnits As Kakefunn.NumericTextbox
    Friend WithEvents txtPurchasingPrice As Kakefunn.NumericTextbox
    Friend WithEvents BatchBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dtgBatch As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumnIngredient As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblEditExplanation As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dcIngredient As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents expected As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dcUnitPurchasingPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnChangeSelection As System.Windows.Forms.Button

End Class
