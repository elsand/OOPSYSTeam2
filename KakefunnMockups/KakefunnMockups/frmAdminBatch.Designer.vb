<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtPurchasingPrice = New Kakefunn.NumericTextbox()
        Me.txtNumUnits = New Kakefunn.NumericTextbox()
        Me.lblStorageStatus = New System.Windows.Forms.Label()
        Me.ddlPricePer = New System.Windows.Forms.ComboBox()
        Me.dtpExpires = New System.Windows.Forms.DateTimePicker()
        Me.lblUnit = New System.Windows.Forms.Label()
        Me.dtpExpected = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIngredient = New System.Windows.Forms.TextBox()
        Me.btnSaveBatch = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnNewBatch = New System.Windows.Forms.Button()
        Me.btnDeleteBatch = New System.Windows.Forms.Button()
        Me.btnPrintOrderList = New System.Windows.Forms.Button()
        Me.BatchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BatchDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumnIngredient = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.BatchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BatchDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtPurchasingPrice)
        Me.GroupBox1.Controls.Add(Me.txtNumUnits)
        Me.GroupBox1.Controls.Add(Me.lblStorageStatus)
        Me.GroupBox1.Controls.Add(Me.ddlPricePer)
        Me.GroupBox1.Controls.Add(Me.dtpExpires)
        Me.GroupBox1.Controls.Add(Me.lblUnit)
        Me.GroupBox1.Controls.Add(Me.dtpExpected)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtIngredient)
        Me.GroupBox1.Controls.Add(Me.btnSaveBatch)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 349)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(683, 154)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Vareparti/bestilling"
        '
        'txtPurchasingPrice
        '
        Me.txtPurchasingPrice.AllowDecimal = True
        Me.txtPurchasingPrice.AllowNegative = False
        Me.txtPurchasingPrice.AllowSpace = False
        Me.txtPurchasingPrice.Location = New System.Drawing.Point(473, 78)
        Me.txtPurchasingPrice.Name = "txtPurchasingPrice"
        Me.txtPurchasingPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtPurchasingPrice.TabIndex = 4
        '
        'txtNumUnits
        '
        Me.txtNumUnits.AllowDecimal = False
        Me.txtNumUnits.AllowNegative = False
        Me.txtNumUnits.AllowSpace = False
        Me.txtNumUnits.Location = New System.Drawing.Point(118, 53)
        Me.txtNumUnits.Name = "txtNumUnits"
        Me.txtNumUnits.Size = New System.Drawing.Size(100, 20)
        Me.txtNumUnits.TabIndex = 1
        '
        'lblStorageStatus
        '
        Me.lblStorageStatus.AutoSize = True
        Me.lblStorageStatus.Location = New System.Drawing.Point(371, 28)
        Me.lblStorageStatus.Name = "lblStorageStatus"
        Me.lblStorageStatus.Size = New System.Drawing.Size(191, 13)
        Me.lblStorageStatus.TabIndex = 17
        Me.lblStorageStatus.Text = "Partiet er ikke registrert mottatt på lager"
        '
        'ddlPricePer
        '
        Me.ddlPricePer.FormattingEnabled = True
        Me.ddlPricePer.Items.AddRange(New Object() {"per enhet", "per parti"})
        Me.ddlPricePer.Location = New System.Drawing.Point(586, 78)
        Me.ddlPricePer.Name = "ddlPricePer"
        Me.ddlPricePer.Size = New System.Drawing.Size(78, 21)
        Me.ddlPricePer.TabIndex = 5
        Me.ddlPricePer.Text = "per enhet"
        '
        'dtpExpires
        '
        Me.dtpExpires.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpExpires.Location = New System.Drawing.Point(473, 52)
        Me.dtpExpires.Name = "dtpExpires"
        Me.dtpExpires.Size = New System.Drawing.Size(102, 20)
        Me.dtpExpires.TabIndex = 3
        '
        'lblUnit
        '
        Me.lblUnit.AutoSize = True
        Me.lblUnit.Location = New System.Drawing.Point(222, 56)
        Me.lblUnit.Name = "lblUnit"
        Me.lblUnit.Size = New System.Drawing.Size(30, 13)
        Me.lblUnit.TabIndex = 10
        Me.lblUnit.Text = "gram"
        '
        'dtpExpected
        '
        Me.dtpExpected.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpExpected.Location = New System.Drawing.Point(116, 83)
        Me.dtpExpected.Name = "dtpExpected"
        Me.dtpExpected.Size = New System.Drawing.Size(102, 20)
        Me.dtpExpected.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(371, 55)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Utløpsdato"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Ventet på lager"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Antall enheter i kolli"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Navn på ingrediens"
        '
        'txtIngredient
        '
        Me.txtIngredient.Location = New System.Drawing.Point(118, 26)
        Me.txtIngredient.Name = "txtIngredient"
        Me.txtIngredient.Size = New System.Drawing.Size(198, 20)
        Me.txtIngredient.TabIndex = 0
        '
        'btnSaveBatch
        '
        Me.btnSaveBatch.Location = New System.Drawing.Point(548, 115)
        Me.btnSaveBatch.Name = "btnSaveBatch"
        Me.btnSaveBatch.Size = New System.Drawing.Size(116, 23)
        Me.btnSaveBatch.TabIndex = 6
        Me.btnSaveBatch.Text = "Lagre parti/bestilling"
        Me.btnSaveBatch.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(371, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Innkjøpspris"
        '
        'btnNewBatch
        '
        Me.btnNewBatch.Location = New System.Drawing.Point(13, 310)
        Me.btnNewBatch.Name = "btnNewBatch"
        Me.btnNewBatch.Size = New System.Drawing.Size(92, 23)
        Me.btnNewBatch.TabIndex = 9
        Me.btnNewBatch.Text = "Ny bestilling"
        Me.btnNewBatch.UseVisualStyleBackColor = True
        '
        'btnDeleteBatch
        '
        Me.btnDeleteBatch.Location = New System.Drawing.Point(124, 310)
        Me.btnDeleteBatch.Name = "btnDeleteBatch"
        Me.btnDeleteBatch.Size = New System.Drawing.Size(114, 23)
        Me.btnDeleteBatch.TabIndex = 10
        Me.btnDeleteBatch.Text = "Slett parti/bestilling"
        Me.btnDeleteBatch.UseVisualStyleBackColor = True
        '
        'btnPrintOrderList
        '
        Me.btnPrintOrderList.Location = New System.Drawing.Point(257, 310)
        Me.btnPrintOrderList.Name = "btnPrintOrderList"
        Me.btnPrintOrderList.Size = New System.Drawing.Size(133, 23)
        Me.btnPrintOrderList.TabIndex = 11
        Me.btnPrintOrderList.Text = "Skriv ut bestillingsliste"
        Me.btnPrintOrderList.UseVisualStyleBackColor = True
        '
        'BatchBindingSource
        '
        Me.BatchBindingSource.DataSource = GetType(Kakefunn.batch)
        '
        'BatchDataGridView
        '
        Me.BatchDataGridView.AllowUserToAddRows = False
        Me.BatchDataGridView.AllowUserToDeleteRows = False
        Me.BatchDataGridView.AutoGenerateColumns = False
        Me.BatchDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BatchDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumnIngredient, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn4})
        Me.BatchDataGridView.DataSource = Me.BatchBindingSource
        Me.BatchDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.BatchDataGridView.Location = New System.Drawing.Point(12, 56)
        Me.BatchDataGridView.Name = "BatchDataGridView"
        Me.BatchDataGridView.RowHeadersVisible = False
        Me.BatchDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.BatchDataGridView.Size = New System.Drawing.Size(683, 236)
        Me.BatchDataGridView.TabIndex = 14
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Partinr"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 50
        '
        'DataGridViewTextBoxColumnIngredient
        '
        Me.DataGridViewTextBoxColumnIngredient.DataPropertyName = "ingredient"
        Me.DataGridViewTextBoxColumnIngredient.HeaderText = "Ingrediens"
        Me.DataGridViewTextBoxColumnIngredient.Name = "DataGridViewTextBoxColumnIngredient"
        Me.DataGridViewTextBoxColumnIngredient.Width = 150
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "unitCount"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Antall"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 40
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ordered"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Bestilt"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 120
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "registered"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Registrert"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 120
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "unitPurchasingPrice"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Innkjøpspris"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 70
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "expires"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Utløpsdato"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(500, 296)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(193, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Dobbeltklikk for å redigere en oppføring"
        '
        'frmAdminBatch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(708, 555)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BatchDataGridView)
        Me.Controls.Add(Me.btnPrintOrderList)
        Me.Controls.Add(Me.btnDeleteBatch)
        Me.Controls.Add(Me.btnNewBatch)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmAdminBatch"
        Me.Text = "Varebestilling og partier"
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.btnNewBatch, 0)
        Me.Controls.SetChildIndex(Me.btnDeleteBatch, 0)
        Me.Controls.SetChildIndex(Me.btnPrintOrderList, 0)
        Me.Controls.SetChildIndex(Me.BatchDataGridView, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.BatchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BatchDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpExpected As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtIngredient As System.Windows.Forms.TextBox
    Friend WithEvents dtpExpires As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnSaveBatch As System.Windows.Forms.Button
    Friend WithEvents lblUnit As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ddlPricePer As System.Windows.Forms.ComboBox
    Friend WithEvents btnNewBatch As System.Windows.Forms.Button
    Friend WithEvents btnDeleteBatch As System.Windows.Forms.Button
    Friend WithEvents btnPrintOrderList As System.Windows.Forms.Button
    Friend WithEvents lblStorageStatus As System.Windows.Forms.Label
    Friend WithEvents txtNumUnits As Kakefunn.NumericTextbox
    Friend WithEvents txtPurchasingPrice As Kakefunn.NumericTextbox
    Friend WithEvents BatchBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BatchDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumnIngredient As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
