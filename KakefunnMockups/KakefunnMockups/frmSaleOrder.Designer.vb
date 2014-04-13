<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSaleOrder
    Inherits Kakefunn.frmSaleBase

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
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblCustomer = New System.Windows.Forms.Label()
        Me.btnNewCustomer = New System.Windows.Forms.Button()
        Me.grpDelivery = New System.Windows.Forms.GroupBox()
        Me.txtTelephone = New Kakefunn.NumericTextbox()
        Me.txtZip = New Kakefunn.NumericTextbox()
        Me.lblDeliveryMethod = New System.Windows.Forms.Label()
        Me.ddlDeliveryMethod = New System.Windows.Forms.ComboBox()
        Me.dtpDeliveryDate = New System.Windows.Forms.DateTimePicker()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.grpCommodity = New System.Windows.Forms.GroupBox()
        Me.btnAddIngredientOrCake = New System.Windows.Forms.Button()
        Me.lblChooseIngredientOrCake = New System.Windows.Forms.Label()
        Me.cbIngredientOrCake = New System.Windows.Forms.ComboBox()
        Me.dtgOrderLines = New System.Windows.Forms.DataGridView()
        Me.dcIngredient = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dcCake = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dcAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dcTotalPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderLinesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblTelephone = New System.Windows.Forms.Label()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.lblZip = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.txtDeliveryName = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.grpOrderingCustomer = New System.Windows.Forms.GroupBox()
        Me.cbCustomerName = New System.Windows.Forms.ComboBox()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.grpOrderStatus = New System.Windows.Forms.GroupBox()
        Me.lblPayedDate = New System.Windows.Forms.Label()
        Me.lblOrderSent = New System.Windows.Forms.Label()
        Me.lblOrderLastEdited = New System.Windows.Forms.Label()
        Me.lblOrderCreated = New System.Windows.Forms.Label()
        Me.lblOrderNumber = New System.Windows.Forms.Label()
        Me.grpDiscount = New System.Windows.Forms.GroupBox()
        Me.txtDiscount = New Kakefunn.NumericTextbox()
        Me.rdoPercent = New System.Windows.Forms.RadioButton()
        Me.rdoCurrencyValue = New System.Windows.Forms.RadioButton()
        Me.rdoNone = New System.Windows.Forms.RadioButton()
        Me.grpPayment = New System.Windows.Forms.GroupBox()
        Me.lblShippingValue = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblDiscountValue = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblAmountToPayValue = New System.Windows.Forms.Label()
        Me.lblVatValue = New System.Windows.Forms.Label()
        Me.lblTotalAmountWithoutVatValue = New System.Windows.Forms.Label()
        Me.lblAmountToPay = New System.Windows.Forms.Label()
        Me.lblVat = New System.Windows.Forms.Label()
        Me.lblTotalAmountWithoutVat = New System.Windows.Forms.Label()
        Me.cboIsPayed = New System.Windows.Forms.CheckBox()
        Me.btnSaveOrder = New System.Windows.Forms.Button()
        Me.cboPrintReceiptOnSave = New System.Windows.Forms.CheckBox()
        Me.txtInternalNote = New System.Windows.Forms.TextBox()
        Me.grpSubscription = New System.Windows.Forms.GroupBox()
        Me.btnShowOrderForSubscription = New System.Windows.Forms.Button()
        Me.lblNextShipments = New System.Windows.Forms.Label()
        Me.lstNextShipments = New System.Windows.Forms.ListBox()
        Me.lblEndDate = New System.Windows.Forms.Label()
        Me.dtpEndDate = New System.Windows.Forms.DateTimePicker()
        Me.cboHasEndDate = New System.Windows.Forms.CheckBox()
        Me.lblStartDate = New System.Windows.Forms.Label()
        Me.dtpStartDate = New System.Windows.Forms.DateTimePicker()
        Me.cboFrequency = New System.Windows.Forms.ComboBox()
        Me.lblFrequency = New System.Windows.Forms.Label()
        Me.cboTypeInterval = New System.Windows.Forms.ComboBox()
        Me.lblTypeInterval = New System.Windows.Forms.Label()
        Me.chkIsActivated = New System.Windows.Forms.CheckBox()
        Me.tlayRight = New System.Windows.Forms.TableLayoutPanel()
        Me.grpOrderNote = New System.Windows.Forms.GroupBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.grpDelivery.SuspendLayout()
        Me.grpCommodity.SuspendLayout()
        CType(Me.dtgOrderLines, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderLinesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpOrderingCustomer.SuspendLayout()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpOrderStatus.SuspendLayout()
        Me.grpDiscount.SuspendLayout()
        Me.grpPayment.SuspendLayout()
        Me.grpSubscription.SuspendLayout()
        Me.tlayRight.SuspendLayout()
        Me.grpOrderNote.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblCustomer
        '
        Me.lblCustomer.AutoSize = True
        Me.lblCustomer.Location = New System.Drawing.Point(13, 25)
        Me.lblCustomer.Name = "lblCustomer"
        Me.lblCustomer.Size = New System.Drawing.Size(41, 13)
        Me.lblCustomer.TabIndex = 2
        Me.lblCustomer.Text = "Kunde:"
        '
        'btnNewCustomer
        '
        Me.btnNewCustomer.Location = New System.Drawing.Point(414, 19)
        Me.btnNewCustomer.Name = "btnNewCustomer"
        Me.btnNewCustomer.Size = New System.Drawing.Size(75, 23)
        Me.btnNewCustomer.TabIndex = 4
        Me.btnNewCustomer.Text = "Ny kunde ..."
        Me.btnNewCustomer.UseVisualStyleBackColor = True
        '
        'grpDelivery
        '
        Me.grpDelivery.Controls.Add(Me.txtTelephone)
        Me.grpDelivery.Controls.Add(Me.txtZip)
        Me.grpDelivery.Controls.Add(Me.lblDeliveryMethod)
        Me.grpDelivery.Controls.Add(Me.ddlDeliveryMethod)
        Me.grpDelivery.Controls.Add(Me.dtpDeliveryDate)
        Me.grpDelivery.Controls.Add(Me.lblDate)
        Me.grpDelivery.Controls.Add(Me.txtEmail)
        Me.grpDelivery.Controls.Add(Me.lblEmail)
        Me.grpDelivery.Controls.Add(Me.grpCommodity)
        Me.grpDelivery.Controls.Add(Me.lblTelephone)
        Me.grpDelivery.Controls.Add(Me.lblCity)
        Me.grpDelivery.Controls.Add(Me.lblZip)
        Me.grpDelivery.Controls.Add(Me.txtAddress)
        Me.grpDelivery.Controls.Add(Me.lblAddress)
        Me.grpDelivery.Controls.Add(Me.txtDeliveryName)
        Me.grpDelivery.Controls.Add(Me.lblName)
        Me.grpDelivery.Location = New System.Drawing.Point(13, 89)
        Me.grpDelivery.Name = "grpDelivery"
        Me.grpDelivery.Size = New System.Drawing.Size(498, 398)
        Me.grpDelivery.TabIndex = 5
        Me.grpDelivery.TabStop = False
        Me.grpDelivery.Text = "Levering"
        '
        'txtTelephone
        '
        Me.txtTelephone.AllowDecimal = False
        Me.txtTelephone.AllowNegative = False
        Me.txtTelephone.AllowSpace = False
        Me.txtTelephone.Location = New System.Drawing.Point(61, 90)
        Me.txtTelephone.MaxLength = 8
        Me.txtTelephone.Name = "txtTelephone"
        Me.txtTelephone.Size = New System.Drawing.Size(208, 20)
        Me.txtTelephone.TabIndex = 3
        '
        'txtZip
        '
        Me.txtZip.AllowDecimal = False
        Me.txtZip.AllowNegative = False
        Me.txtZip.AllowSpace = False
        Me.txtZip.Location = New System.Drawing.Point(327, 46)
        Me.txtZip.MaxLength = 4
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(44, 20)
        Me.txtZip.TabIndex = 2
        '
        'lblDeliveryMethod
        '
        Me.lblDeliveryMethod.AutoSize = True
        Me.lblDeliveryMethod.Location = New System.Drawing.Point(275, 131)
        Me.lblDeliveryMethod.Name = "lblDeliveryMethod"
        Me.lblDeliveryMethod.Size = New System.Drawing.Size(51, 13)
        Me.lblDeliveryMethod.TabIndex = 17
        Me.lblDeliveryMethod.Text = "Lev.met.:"
        '
        'ddlDeliveryMethod
        '
        Me.ddlDeliveryMethod.FormattingEnabled = True
        Me.ddlDeliveryMethod.Location = New System.Drawing.Point(327, 127)
        Me.ddlDeliveryMethod.Name = "ddlDeliveryMethod"
        Me.ddlDeliveryMethod.Size = New System.Drawing.Size(145, 21)
        Me.ddlDeliveryMethod.TabIndex = 6
        '
        'dtpDeliveryDate
        '
        Me.dtpDeliveryDate.Location = New System.Drawing.Point(59, 126)
        Me.dtpDeliveryDate.Name = "dtpDeliveryDate"
        Me.dtpDeliveryDate.Size = New System.Drawing.Size(210, 20)
        Me.dtpDeliveryDate.TabIndex = 5
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(9, 130)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(33, 13)
        Me.lblDate.TabIndex = 14
        Me.lblDate.Text = "Dato:"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(327, 91)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(145, 20)
        Me.txtEmail.TabIndex = 4
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(276, 93)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(40, 13)
        Me.lblEmail.TabIndex = 12
        Me.lblEmail.Text = "E-post:"
        '
        'grpCommodity
        '
        Me.grpCommodity.Controls.Add(Me.btnAddIngredientOrCake)
        Me.grpCommodity.Controls.Add(Me.lblChooseIngredientOrCake)
        Me.grpCommodity.Controls.Add(Me.cbIngredientOrCake)
        Me.grpCommodity.Controls.Add(Me.dtgOrderLines)
        Me.grpCommodity.Location = New System.Drawing.Point(3, 161)
        Me.grpCommodity.Name = "grpCommodity"
        Me.grpCommodity.Size = New System.Drawing.Size(495, 214)
        Me.grpCommodity.TabIndex = 7
        Me.grpCommodity.TabStop = False
        Me.grpCommodity.Text = "Varer"
        '
        'btnAddIngredientOrCake
        '
        Me.btnAddIngredientOrCake.Location = New System.Drawing.Point(319, 182)
        Me.btnAddIngredientOrCake.Name = "btnAddIngredientOrCake"
        Me.btnAddIngredientOrCake.Size = New System.Drawing.Size(75, 23)
        Me.btnAddIngredientOrCake.TabIndex = 5
        Me.btnAddIngredientOrCake.Text = "Legg til"
        Me.btnAddIngredientOrCake.UseVisualStyleBackColor = True
        '
        'lblChooseIngredientOrCake
        '
        Me.lblChooseIngredientOrCake.AutoSize = True
        Me.lblChooseIngredientOrCake.Location = New System.Drawing.Point(8, 188)
        Me.lblChooseIngredientOrCake.Name = "lblChooseIngredientOrCake"
        Me.lblChooseIngredientOrCake.Size = New System.Drawing.Size(124, 13)
        Me.lblChooseIngredientOrCake.TabIndex = 6
        Me.lblChooseIngredientOrCake.Text = "Legg til ingrediens/kake:"
        '
        'cbIngredientOrCake
        '
        Me.cbIngredientOrCake.FormattingEnabled = True
        Me.cbIngredientOrCake.Location = New System.Drawing.Point(137, 184)
        Me.cbIngredientOrCake.Name = "cbIngredientOrCake"
        Me.cbIngredientOrCake.Size = New System.Drawing.Size(176, 21)
        Me.cbIngredientOrCake.TabIndex = 0
        '
        'dtgOrderLines
        '
        Me.dtgOrderLines.AllowUserToAddRows = False
        Me.dtgOrderLines.AllowUserToResizeRows = False
        Me.dtgOrderLines.AutoGenerateColumns = False
        Me.dtgOrderLines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgOrderLines.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dcIngredient, Me.dcCake, Me.dcAmount, Me.dcTotalPrice})
        Me.dtgOrderLines.DataSource = Me.OrderLinesBindingSource
        Me.dtgOrderLines.Location = New System.Drawing.Point(8, 19)
        Me.dtgOrderLines.Name = "dtgOrderLines"
        Me.dtgOrderLines.Size = New System.Drawing.Size(481, 150)
        Me.dtgOrderLines.TabIndex = 0
        '
        'dcIngredient
        '
        Me.dcIngredient.DataPropertyName = "Ingredient"
        Me.dcIngredient.HeaderText = "Ingrediens"
        Me.dcIngredient.Name = "dcIngredient"
        Me.dcIngredient.ReadOnly = True
        '
        'dcCake
        '
        Me.dcCake.DataPropertyName = "cakeId"
        Me.dcCake.HeaderText = "Tilhører kake"
        Me.dcCake.Name = "dcCake"
        Me.dcCake.ReadOnly = True
        '
        'dcAmount
        '
        Me.dcAmount.DataPropertyName = "amount"
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.dcAmount.DefaultCellStyle = DataGridViewCellStyle19
        Me.dcAmount.HeaderText = "Antall"
        Me.dcAmount.Name = "dcAmount"
        '
        'dcTotalPrice
        '
        Me.dcTotalPrice.DataPropertyName = "totalPrice"
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.dcTotalPrice.DefaultCellStyle = DataGridViewCellStyle20
        Me.dcTotalPrice.HeaderText = "Totalpris"
        Me.dcTotalPrice.Name = "dcTotalPrice"
        Me.dcTotalPrice.ReadOnly = True
        '
        'OrderLinesBindingSource
        '
        Me.OrderLinesBindingSource.DataSource = GetType(Kakefunn.ObservableListSource(Of Kakefunn.OrderLine))
        '
        'lblTelephone
        '
        Me.lblTelephone.AutoSize = True
        Me.lblTelephone.Location = New System.Drawing.Point(8, 93)
        Me.lblTelephone.Name = "lblTelephone"
        Me.lblTelephone.Size = New System.Drawing.Size(46, 13)
        Me.lblTelephone.TabIndex = 9
        Me.lblTelephone.Text = "Telefon:"
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Location = New System.Drawing.Point(377, 49)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(92, 13)
        Me.lblCity.TabIndex = 8
        Me.lblCity.Text = "BRØNNØYSUND"
        '
        'lblZip
        '
        Me.lblZip.AutoSize = True
        Me.lblZip.Location = New System.Drawing.Point(276, 49)
        Me.lblZip.Name = "lblZip"
        Me.lblZip.Size = New System.Drawing.Size(40, 13)
        Me.lblZip.TabIndex = 6
        Me.lblZip.Text = "Postnr:"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(60, 46)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(210, 20)
        Me.txtAddress.TabIndex = 1
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(6, 49)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(48, 13)
        Me.lblAddress.TabIndex = 2
        Me.lblAddress.Text = "Adresse:"
        '
        'txtDeliveryName
        '
        Me.txtDeliveryName.Location = New System.Drawing.Point(59, 17)
        Me.txtDeliveryName.Name = "txtDeliveryName"
        Me.txtDeliveryName.Size = New System.Drawing.Size(210, 20)
        Me.txtDeliveryName.TabIndex = 0
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(7, 20)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(36, 13)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Navn:"
        '
        'grpOrderingCustomer
        '
        Me.grpOrderingCustomer.Controls.Add(Me.cbCustomerName)
        Me.grpOrderingCustomer.Controls.Add(Me.lblCustomer)
        Me.grpOrderingCustomer.Controls.Add(Me.btnNewCustomer)
        Me.grpOrderingCustomer.Location = New System.Drawing.Point(13, 27)
        Me.grpOrderingCustomer.Name = "grpOrderingCustomer"
        Me.grpOrderingCustomer.Size = New System.Drawing.Size(495, 56)
        Me.grpOrderingCustomer.TabIndex = 6
        Me.grpOrderingCustomer.TabStop = False
        Me.grpOrderingCustomer.Text = "Bestiller"
        '
        'cbCustomerName
        '
        Me.cbCustomerName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbCustomerName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbCustomerName.DataSource = Me.CustomerBindingSource
        Me.cbCustomerName.DisplayMember = "fullName"
        Me.cbCustomerName.FormattingEnabled = True
        Me.cbCustomerName.Location = New System.Drawing.Point(60, 20)
        Me.cbCustomerName.Name = "cbCustomerName"
        Me.cbCustomerName.Size = New System.Drawing.Size(348, 21)
        Me.cbCustomerName.TabIndex = 0
        Me.cbCustomerName.ValueMember = "id"
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataSource = GetType(Kakefunn.Customer)
        '
        'grpOrderStatus
        '
        Me.grpOrderStatus.Controls.Add(Me.lblPayedDate)
        Me.grpOrderStatus.Controls.Add(Me.lblOrderSent)
        Me.grpOrderStatus.Controls.Add(Me.lblOrderLastEdited)
        Me.grpOrderStatus.Controls.Add(Me.lblOrderCreated)
        Me.grpOrderStatus.Controls.Add(Me.lblOrderNumber)
        Me.grpOrderStatus.Location = New System.Drawing.Point(3, 3)
        Me.grpOrderStatus.Name = "grpOrderStatus"
        Me.grpOrderStatus.Size = New System.Drawing.Size(292, 128)
        Me.grpOrderStatus.TabIndex = 8
        Me.grpOrderStatus.TabStop = False
        Me.grpOrderStatus.Text = "Status"
        '
        'lblPayedDate
        '
        Me.lblPayedDate.AutoSize = True
        Me.lblPayedDate.Location = New System.Drawing.Point(48, 98)
        Me.lblPayedDate.Name = "lblPayedDate"
        Me.lblPayedDate.Size = New System.Drawing.Size(107, 13)
        Me.lblPayedDate.TabIndex = 4
        Me.lblPayedDate.Text = "Oppgjort: 02.01.2017"
        '
        'lblOrderSent
        '
        Me.lblOrderSent.AutoSize = True
        Me.lblOrderSent.Location = New System.Drawing.Point(58, 82)
        Me.lblOrderSent.Name = "lblOrderSent"
        Me.lblOrderSent.Size = New System.Drawing.Size(136, 13)
        Me.lblOrderSent.TabIndex = 3
        Me.lblOrderSent.Text = "Sendt: 22.12.2016 kl 07:15"
        '
        'lblOrderLastEdited
        '
        Me.lblOrderLastEdited.AutoSize = True
        Me.lblOrderLastEdited.Location = New System.Drawing.Point(36, 65)
        Me.lblOrderLastEdited.Name = "lblOrderLastEdited"
        Me.lblOrderLastEdited.Size = New System.Drawing.Size(158, 13)
        Me.lblOrderLastEdited.TabIndex = 2
        Me.lblOrderLastEdited.Text = "Sist endret: 21.12.2016 kl 14:43"
        '
        'lblOrderCreated
        '
        Me.lblOrderCreated.AutoSize = True
        Me.lblOrderCreated.Location = New System.Drawing.Point(42, 49)
        Me.lblOrderCreated.Name = "lblOrderCreated"
        Me.lblOrderCreated.Size = New System.Drawing.Size(152, 13)
        Me.lblOrderCreated.TabIndex = 1
        Me.lblOrderCreated.Text = "Opprettet: 21.12.2016 kl 14:43"
        '
        'lblOrderNumber
        '
        Me.lblOrderNumber.AutoSize = True
        Me.lblOrderNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrderNumber.Location = New System.Drawing.Point(22, 23)
        Me.lblOrderNumber.Name = "lblOrderNumber"
        Me.lblOrderNumber.Size = New System.Drawing.Size(140, 20)
        Me.lblOrderNumber.TabIndex = 0
        Me.lblOrderNumber.Text = "Ordrenr: 123345"
        '
        'grpDiscount
        '
        Me.grpDiscount.Controls.Add(Me.txtDiscount)
        Me.grpDiscount.Controls.Add(Me.rdoPercent)
        Me.grpDiscount.Controls.Add(Me.rdoCurrencyValue)
        Me.grpDiscount.Controls.Add(Me.rdoNone)
        Me.grpDiscount.Location = New System.Drawing.Point(13, 468)
        Me.grpDiscount.Name = "grpDiscount"
        Me.grpDiscount.Size = New System.Drawing.Size(495, 50)
        Me.grpDiscount.TabIndex = 9
        Me.grpDiscount.TabStop = False
        Me.grpDiscount.Text = "Rabatt"
        '
        'txtDiscount
        '
        Me.txtDiscount.AllowDecimal = True
        Me.txtDiscount.AllowNegative = False
        Me.txtDiscount.AllowSpace = False
        Me.txtDiscount.Location = New System.Drawing.Point(389, 20)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.Size = New System.Drawing.Size(100, 20)
        Me.txtDiscount.TabIndex = 3
        Me.txtDiscount.Text = "0"
        Me.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'rdoPercent
        '
        Me.rdoPercent.AutoSize = True
        Me.rdoPercent.Location = New System.Drawing.Point(72, 20)
        Me.rdoPercent.Name = "rdoPercent"
        Me.rdoPercent.Size = New System.Drawing.Size(61, 17)
        Me.rdoPercent.TabIndex = 1
        Me.rdoPercent.Text = "Prosent"
        Me.rdoPercent.UseVisualStyleBackColor = True
        '
        'rdoCurrencyValue
        '
        Me.rdoCurrencyValue.AutoSize = True
        Me.rdoCurrencyValue.Location = New System.Drawing.Point(140, 20)
        Me.rdoCurrencyValue.Name = "rdoCurrencyValue"
        Me.rdoCurrencyValue.Size = New System.Drawing.Size(76, 17)
        Me.rdoCurrencyValue.TabIndex = 2
        Me.rdoCurrencyValue.Text = "Kroneverdi"
        Me.rdoCurrencyValue.UseVisualStyleBackColor = True
        '
        'rdoNone
        '
        Me.rdoNone.AutoSize = True
        Me.rdoNone.Checked = True
        Me.rdoNone.Location = New System.Drawing.Point(14, 20)
        Me.rdoNone.Name = "rdoNone"
        Me.rdoNone.Size = New System.Drawing.Size(52, 17)
        Me.rdoNone.TabIndex = 0
        Me.rdoNone.TabStop = True
        Me.rdoNone.Text = "Ingen"
        Me.rdoNone.UseVisualStyleBackColor = True
        '
        'grpPayment
        '
        Me.grpPayment.Controls.Add(Me.lblShippingValue)
        Me.grpPayment.Controls.Add(Me.Label2)
        Me.grpPayment.Controls.Add(Me.lblDiscountValue)
        Me.grpPayment.Controls.Add(Me.Label1)
        Me.grpPayment.Controls.Add(Me.lblAmountToPayValue)
        Me.grpPayment.Controls.Add(Me.lblVatValue)
        Me.grpPayment.Controls.Add(Me.lblTotalAmountWithoutVatValue)
        Me.grpPayment.Controls.Add(Me.lblAmountToPay)
        Me.grpPayment.Controls.Add(Me.lblVat)
        Me.grpPayment.Controls.Add(Me.lblTotalAmountWithoutVat)
        Me.grpPayment.Location = New System.Drawing.Point(13, 524)
        Me.grpPayment.Name = "grpPayment"
        Me.grpPayment.Size = New System.Drawing.Size(495, 97)
        Me.grpPayment.TabIndex = 10
        Me.grpPayment.TabStop = False
        Me.grpPayment.Text = "Betaling"
        '
        'lblShippingValue
        '
        Me.lblShippingValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShippingValue.Location = New System.Drawing.Point(327, 28)
        Me.lblShippingValue.Name = "lblShippingValue"
        Me.lblShippingValue.Size = New System.Drawing.Size(151, 16)
        Me.lblShippingValue.TabIndex = 10
        Me.lblShippingValue.Text = "0"
        Me.lblShippingValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Frakt:"
        '
        'lblDiscountValue
        '
        Me.lblDiscountValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscountValue.Location = New System.Drawing.Point(327, 43)
        Me.lblDiscountValue.Name = "lblDiscountValue"
        Me.lblDiscountValue.Size = New System.Drawing.Size(151, 16)
        Me.lblDiscountValue.TabIndex = 8
        Me.lblDiscountValue.Text = "0"
        Me.lblDiscountValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Rabatt:"
        '
        'lblAmountToPayValue
        '
        Me.lblAmountToPayValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmountToPayValue.ForeColor = System.Drawing.Color.Blue
        Me.lblAmountToPayValue.Location = New System.Drawing.Point(336, 76)
        Me.lblAmountToPayValue.Name = "lblAmountToPayValue"
        Me.lblAmountToPayValue.Size = New System.Drawing.Size(142, 16)
        Me.lblAmountToPayValue.TabIndex = 6
        Me.lblAmountToPayValue.Text = "1150,00"
        Me.lblAmountToPayValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblVatValue
        '
        Me.lblVatValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVatValue.Location = New System.Drawing.Point(333, 59)
        Me.lblVatValue.Name = "lblVatValue"
        Me.lblVatValue.Size = New System.Drawing.Size(145, 16)
        Me.lblVatValue.TabIndex = 5
        Me.lblVatValue.Text = "150,00"
        Me.lblVatValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotalAmountWithoutVatValue
        '
        Me.lblTotalAmountWithoutVatValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalAmountWithoutVatValue.Location = New System.Drawing.Point(330, 13)
        Me.lblTotalAmountWithoutVatValue.Name = "lblTotalAmountWithoutVatValue"
        Me.lblTotalAmountWithoutVatValue.Size = New System.Drawing.Size(148, 16)
        Me.lblTotalAmountWithoutVatValue.TabIndex = 4
        Me.lblTotalAmountWithoutVatValue.Text = "1000,00"
        Me.lblTotalAmountWithoutVatValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAmountToPay
        '
        Me.lblAmountToPay.AutoSize = True
        Me.lblAmountToPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmountToPay.ForeColor = System.Drawing.Color.Blue
        Me.lblAmountToPay.Location = New System.Drawing.Point(14, 80)
        Me.lblAmountToPay.Name = "lblAmountToPay"
        Me.lblAmountToPay.Size = New System.Drawing.Size(49, 13)
        Me.lblAmountToPay.TabIndex = 2
        Me.lblAmountToPay.Text = "Å betale:"
        '
        'lblVat
        '
        Me.lblVat.AutoSize = True
        Me.lblVat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVat.Location = New System.Drawing.Point(14, 63)
        Me.lblVat.Name = "lblVat"
        Me.lblVat.Size = New System.Drawing.Size(31, 13)
        Me.lblVat.TabIndex = 1
        Me.lblVat.Text = "Mva:"
        '
        'lblTotalAmountWithoutVat
        '
        Me.lblTotalAmountWithoutVat.AutoSize = True
        Me.lblTotalAmountWithoutVat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalAmountWithoutVat.Location = New System.Drawing.Point(14, 17)
        Me.lblTotalAmountWithoutVat.Name = "lblTotalAmountWithoutVat"
        Me.lblTotalAmountWithoutVat.Size = New System.Drawing.Size(128, 13)
        Me.lblTotalAmountWithoutVat.TabIndex = 0
        Me.lblTotalAmountWithoutVat.Text = "Total eks. mva uten frakt:"
        '
        'cboIsPayed
        '
        Me.cboIsPayed.AutoSize = True
        Me.cboIsPayed.Checked = True
        Me.cboIsPayed.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cboIsPayed.Location = New System.Drawing.Point(514, 541)
        Me.cboIsPayed.Name = "cboIsPayed"
        Me.cboIsPayed.Size = New System.Drawing.Size(77, 17)
        Me.cboIsPayed.TabIndex = 0
        Me.cboIsPayed.Text = "Er oppgjort"
        Me.cboIsPayed.UseVisualStyleBackColor = True
        '
        'btnSaveOrder
        '
        Me.btnSaveOrder.Location = New System.Drawing.Point(725, 587)
        Me.btnSaveOrder.Name = "btnSaveOrder"
        Me.btnSaveOrder.Size = New System.Drawing.Size(91, 34)
        Me.btnSaveOrder.TabIndex = 4
        Me.btnSaveOrder.Text = "Lagre ordre"
        Me.btnSaveOrder.UseVisualStyleBackColor = True
        '
        'cboPrintReceiptOnSave
        '
        Me.cboPrintReceiptOnSave.AutoSize = True
        Me.cboPrintReceiptOnSave.Checked = True
        Me.cboPrintReceiptOnSave.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cboPrintReceiptOnSave.Location = New System.Drawing.Point(601, 541)
        Me.cboPrintReceiptOnSave.Name = "cboPrintReceiptOnSave"
        Me.cboPrintReceiptOnSave.Size = New System.Drawing.Size(163, 17)
        Me.cboPrintReceiptOnSave.TabIndex = 1
        Me.cboPrintReceiptOnSave.Text = "Skriv ut kvittering ved lagring"
        Me.cboPrintReceiptOnSave.UseVisualStyleBackColor = True
        '
        'txtInternalNote
        '
        Me.txtInternalNote.Location = New System.Drawing.Point(6, 19)
        Me.txtInternalNote.Multiline = True
        Me.txtInternalNote.Name = "txtInternalNote"
        Me.txtInternalNote.Size = New System.Drawing.Size(280, 55)
        Me.txtInternalNote.TabIndex = 0
        '
        'grpSubscription
        '
        Me.grpSubscription.Controls.Add(Me.btnShowOrderForSubscription)
        Me.grpSubscription.Controls.Add(Me.lblNextShipments)
        Me.grpSubscription.Controls.Add(Me.lstNextShipments)
        Me.grpSubscription.Controls.Add(Me.lblEndDate)
        Me.grpSubscription.Controls.Add(Me.dtpEndDate)
        Me.grpSubscription.Controls.Add(Me.cboHasEndDate)
        Me.grpSubscription.Controls.Add(Me.lblStartDate)
        Me.grpSubscription.Controls.Add(Me.dtpStartDate)
        Me.grpSubscription.Controls.Add(Me.cboFrequency)
        Me.grpSubscription.Controls.Add(Me.lblFrequency)
        Me.grpSubscription.Controls.Add(Me.cboTypeInterval)
        Me.grpSubscription.Controls.Add(Me.lblTypeInterval)
        Me.grpSubscription.Controls.Add(Me.chkIsActivated)
        Me.grpSubscription.Location = New System.Drawing.Point(3, 223)
        Me.grpSubscription.Name = "grpSubscription"
        Me.grpSubscription.Size = New System.Drawing.Size(292, 276)
        Me.grpSubscription.TabIndex = 14
        Me.grpSubscription.TabStop = False
        Me.grpSubscription.Text = "Abonnement"
        '
        'btnShowOrderForSubscription
        '
        Me.btnShowOrderForSubscription.Location = New System.Drawing.Point(155, 15)
        Me.btnShowOrderForSubscription.Name = "btnShowOrderForSubscription"
        Me.btnShowOrderForSubscription.Size = New System.Drawing.Size(127, 23)
        Me.btnShowOrderForSubscription.TabIndex = 25
        Me.btnShowOrderForSubscription.Text = "Vis ordrer for dette abo."
        Me.btnShowOrderForSubscription.UseVisualStyleBackColor = True
        '
        'lblNextShipments
        '
        Me.lblNextShipments.AutoSize = True
        Me.lblNextShipments.Location = New System.Drawing.Point(13, 201)
        Me.lblNextShipments.Name = "lblNextShipments"
        Me.lblNextShipments.Size = New System.Drawing.Size(92, 13)
        Me.lblNextShipments.TabIndex = 6
        Me.lblNextShipments.Text = "Neste utsendelser"
        '
        'lstNextShipments
        '
        Me.lstNextShipments.BackColor = System.Drawing.SystemColors.Control
        Me.lstNextShipments.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstNextShipments.Enabled = False
        Me.lstNextShipments.FormattingEnabled = True
        Me.lstNextShipments.Items.AddRange(New Object() {"(liste over neste X leveringer utfra valgt intervall)"})
        Me.lstNextShipments.Location = New System.Drawing.Point(14, 217)
        Me.lstNextShipments.Name = "lstNextShipments"
        Me.lstNextShipments.Size = New System.Drawing.Size(270, 52)
        Me.lstNextShipments.TabIndex = 7
        '
        'lblEndDate
        '
        Me.lblEndDate.AutoSize = True
        Me.lblEndDate.Enabled = False
        Me.lblEndDate.Location = New System.Drawing.Point(13, 168)
        Me.lblEndDate.Name = "lblEndDate"
        Me.lblEndDate.Size = New System.Drawing.Size(52, 13)
        Me.lblEndDate.TabIndex = 23
        Me.lblEndDate.Text = "Slutt-dato"
        '
        'dtpEndDate
        '
        Me.dtpEndDate.Enabled = False
        Me.dtpEndDate.Location = New System.Drawing.Point(84, 165)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.Size = New System.Drawing.Size(200, 20)
        Me.dtpEndDate.TabIndex = 5
        '
        'cboHasEndDate
        '
        Me.cboHasEndDate.AutoSize = True
        Me.cboHasEndDate.Location = New System.Drawing.Point(10, 138)
        Me.cboHasEndDate.Name = "cboHasEndDate"
        Me.cboHasEndDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cboHasEndDate.Size = New System.Drawing.Size(86, 17)
        Me.cboHasEndDate.TabIndex = 4
        Me.cboHasEndDate.Text = "Har sluttdato"
        Me.cboHasEndDate.UseVisualStyleBackColor = True
        '
        'lblStartDate
        '
        Me.lblStartDate.AutoSize = True
        Me.lblStartDate.Location = New System.Drawing.Point(11, 109)
        Me.lblStartDate.Name = "lblStartDate"
        Me.lblStartDate.Size = New System.Drawing.Size(53, 13)
        Me.lblStartDate.TabIndex = 20
        Me.lblStartDate.Text = "Start-dato"
        '
        'dtpStartDate
        '
        Me.dtpStartDate.Location = New System.Drawing.Point(82, 107)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(200, 20)
        Me.dtpStartDate.TabIndex = 3
        '
        'cboFrequency
        '
        Me.cboFrequency.FormattingEnabled = True
        Me.cboFrequency.Items.AddRange(New Object() {"Ukentlig", "Daglig", "Månedlig"})
        Me.cboFrequency.Location = New System.Drawing.Point(84, 77)
        Me.cboFrequency.Name = "cboFrequency"
        Me.cboFrequency.Size = New System.Drawing.Size(52, 21)
        Me.cboFrequency.TabIndex = 2
        '
        'lblFrequency
        '
        Me.lblFrequency.AutoSize = True
        Me.lblFrequency.Location = New System.Drawing.Point(9, 80)
        Me.lblFrequency.Name = "lblFrequency"
        Me.lblFrequency.Size = New System.Drawing.Size(55, 13)
        Me.lblFrequency.TabIndex = 17
        Me.lblFrequency.Text = "Hyppighet"
        '
        'cboTypeInterval
        '
        Me.cboTypeInterval.FormattingEnabled = True
        Me.cboTypeInterval.Items.AddRange(New Object() {"Ukentlig", "Daglig", "Månedlig"})
        Me.cboTypeInterval.Location = New System.Drawing.Point(83, 47)
        Me.cboTypeInterval.Name = "cboTypeInterval"
        Me.cboTypeInterval.Size = New System.Drawing.Size(121, 21)
        Me.cboTypeInterval.TabIndex = 1
        '
        'lblTypeInterval
        '
        Me.lblTypeInterval.AutoSize = True
        Me.lblTypeInterval.Location = New System.Drawing.Point(9, 50)
        Me.lblTypeInterval.Name = "lblTypeInterval"
        Me.lblTypeInterval.Size = New System.Drawing.Size(70, 13)
        Me.lblTypeInterval.TabIndex = 14
        Me.lblTypeInterval.Text = "Type intervall"
        '
        'chkIsActivated
        '
        Me.chkIsActivated.AutoSize = True
        Me.chkIsActivated.Location = New System.Drawing.Point(10, 19)
        Me.chkIsActivated.Name = "chkIsActivated"
        Me.chkIsActivated.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkIsActivated.Size = New System.Drawing.Size(74, 17)
        Me.chkIsActivated.TabIndex = 0
        Me.chkIsActivated.Text = "Er aktivert"
        Me.chkIsActivated.UseVisualStyleBackColor = True
        '
        'tlayRight
        '
        Me.tlayRight.ColumnCount = 1
        Me.tlayRight.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlayRight.Controls.Add(Me.grpOrderStatus, 0, 0)
        Me.tlayRight.Controls.Add(Me.grpSubscription, 0, 2)
        Me.tlayRight.Controls.Add(Me.grpOrderNote, 0, 1)
        Me.tlayRight.Location = New System.Drawing.Point(514, 27)
        Me.tlayRight.Name = "tlayRight"
        Me.tlayRight.RowCount = 3
        Me.tlayRight.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlayRight.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlayRight.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlayRight.Size = New System.Drawing.Size(316, 508)
        Me.tlayRight.TabIndex = 15
        '
        'grpOrderNote
        '
        Me.grpOrderNote.Controls.Add(Me.txtInternalNote)
        Me.grpOrderNote.Location = New System.Drawing.Point(3, 137)
        Me.grpOrderNote.Name = "grpOrderNote"
        Me.grpOrderNote.Size = New System.Drawing.Size(292, 80)
        Me.grpOrderNote.TabIndex = 9
        Me.grpOrderNote.TabStop = False
        Me.grpOrderNote.Text = "Internt notat"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(517, 587)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(91, 34)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Avbryt"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(620, 587)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(91, 34)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "Tøm felter"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'frmSaleOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(830, 655)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.tlayRight)
        Me.Controls.Add(Me.cboIsPayed)
        Me.Controls.Add(Me.cboPrintReceiptOnSave)
        Me.Controls.Add(Me.btnSaveOrder)
        Me.Controls.Add(Me.grpPayment)
        Me.Controls.Add(Me.grpDiscount)
        Me.Controls.Add(Me.grpOrderingCustomer)
        Me.Controls.Add(Me.grpDelivery)
        Me.Name = "frmSaleOrder"
        Me.Text = "Ordre"
        Me.Controls.SetChildIndex(Me.grpDelivery, 0)
        Me.Controls.SetChildIndex(Me.grpOrderingCustomer, 0)
        Me.Controls.SetChildIndex(Me.grpDiscount, 0)
        Me.Controls.SetChildIndex(Me.grpPayment, 0)
        Me.Controls.SetChildIndex(Me.btnSaveOrder, 0)
        Me.Controls.SetChildIndex(Me.cboPrintReceiptOnSave, 0)
        Me.Controls.SetChildIndex(Me.cboIsPayed, 0)
        Me.Controls.SetChildIndex(Me.tlayRight, 0)
        Me.Controls.SetChildIndex(Me.btnCancel, 0)
        Me.Controls.SetChildIndex(Me.btnClear, 0)
        Me.grpDelivery.ResumeLayout(False)
        Me.grpDelivery.PerformLayout()
        Me.grpCommodity.ResumeLayout(False)
        Me.grpCommodity.PerformLayout()
        CType(Me.dtgOrderLines, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderLinesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpOrderingCustomer.ResumeLayout(False)
        Me.grpOrderingCustomer.PerformLayout()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpOrderStatus.ResumeLayout(False)
        Me.grpOrderStatus.PerformLayout()
        Me.grpDiscount.ResumeLayout(False)
        Me.grpDiscount.PerformLayout()
        Me.grpPayment.ResumeLayout(False)
        Me.grpPayment.PerformLayout()
        Me.grpSubscription.ResumeLayout(False)
        Me.grpSubscription.PerformLayout()
        Me.tlayRight.ResumeLayout(False)
        Me.grpOrderNote.ResumeLayout(False)
        Me.grpOrderNote.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCustomer As System.Windows.Forms.Label
    Friend WithEvents btnNewCustomer As System.Windows.Forms.Button
    Friend WithEvents grpDelivery As System.Windows.Forms.GroupBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents txtDeliveryName As System.Windows.Forms.TextBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblTelephone As System.Windows.Forms.Label
    Friend WithEvents lblCity As System.Windows.Forms.Label
    Friend WithEvents lblZip As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents grpOrderingCustomer As System.Windows.Forms.GroupBox
    Friend WithEvents grpCommodity As System.Windows.Forms.GroupBox
    Friend WithEvents grpOrderStatus As System.Windows.Forms.GroupBox
    Friend WithEvents lblOrderNumber As System.Windows.Forms.Label
    Friend WithEvents lblOrderCreated As System.Windows.Forms.Label
    Friend WithEvents lblPayedDate As System.Windows.Forms.Label
    Friend WithEvents lblOrderSent As System.Windows.Forms.Label
    Friend WithEvents lblOrderLastEdited As System.Windows.Forms.Label
    Friend WithEvents grpDiscount As System.Windows.Forms.GroupBox
    Friend WithEvents rdoPercent As System.Windows.Forms.RadioButton
    Friend WithEvents rdoCurrencyValue As System.Windows.Forms.RadioButton
    Friend WithEvents rdoNone As System.Windows.Forms.RadioButton
    Friend WithEvents lblDeliveryMethod As System.Windows.Forms.Label
    Friend WithEvents ddlDeliveryMethod As System.Windows.Forms.ComboBox
    Friend WithEvents dtpDeliveryDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents grpPayment As System.Windows.Forms.GroupBox
    Friend WithEvents cboIsPayed As System.Windows.Forms.CheckBox
    Friend WithEvents lblAmountToPayValue As System.Windows.Forms.Label
    Friend WithEvents lblVatValue As System.Windows.Forms.Label
    Friend WithEvents lblTotalAmountWithoutVatValue As System.Windows.Forms.Label
    Friend WithEvents lblAmountToPay As System.Windows.Forms.Label
    Friend WithEvents lblVat As System.Windows.Forms.Label
    Friend WithEvents lblTotalAmountWithoutVat As System.Windows.Forms.Label
    Friend WithEvents btnSaveOrder As System.Windows.Forms.Button
    Friend WithEvents cboPrintReceiptOnSave As System.Windows.Forms.CheckBox
    Friend WithEvents txtInternalNote As System.Windows.Forms.TextBox
    Friend WithEvents grpSubscription As System.Windows.Forms.GroupBox
    Friend WithEvents lblNextShipments As System.Windows.Forms.Label
    Friend WithEvents lstNextShipments As System.Windows.Forms.ListBox
    Friend WithEvents lblEndDate As System.Windows.Forms.Label
    Friend WithEvents dtpEndDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboHasEndDate As System.Windows.Forms.CheckBox
    Friend WithEvents lblStartDate As System.Windows.Forms.Label
    Friend WithEvents dtpStartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboFrequency As System.Windows.Forms.ComboBox
    Friend WithEvents lblFrequency As System.Windows.Forms.Label
    Friend WithEvents cboTypeInterval As System.Windows.Forms.ComboBox
    Friend WithEvents lblTypeInterval As System.Windows.Forms.Label
    Friend WithEvents chkIsActivated As System.Windows.Forms.CheckBox
    Friend WithEvents btnShowOrderForSubscription As System.Windows.Forms.Button
    Friend WithEvents cbCustomerName As System.Windows.Forms.ComboBox
    Friend WithEvents CustomerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents tlayRight As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents grpOrderNote As System.Windows.Forms.GroupBox
    Friend WithEvents txtZip As Kakefunn.NumericTextbox
    Friend WithEvents txtTelephone As Kakefunn.NumericTextbox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents lblChooseIngredientOrCake As System.Windows.Forms.Label
    Friend WithEvents cbIngredientOrCake As System.Windows.Forms.ComboBox
    Friend WithEvents dtgOrderLines As System.Windows.Forms.DataGridView
    Friend WithEvents OrderLinesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents btnAddIngredientOrCake As System.Windows.Forms.Button
    Friend WithEvents dcIngredient As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dcCake As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dcAmount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dcTotalPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtDiscount As Kakefunn.NumericTextbox
    Friend WithEvents lblDiscountValue As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblShippingValue As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
