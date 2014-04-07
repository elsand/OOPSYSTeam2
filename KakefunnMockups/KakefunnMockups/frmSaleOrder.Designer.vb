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
        Me.lblCustomer = New System.Windows.Forms.Label()
        Me.txtCustomerNameAndOrderAutocomplete = New System.Windows.Forms.TextBox()
        Me.btnNewCustomer = New System.Windows.Forms.Button()
        Me.grpDelivery = New System.Windows.Forms.GroupBox()
        Me.lblDeliveryMethod = New System.Windows.Forms.Label()
        Me.cboDeliveryMethod = New System.Windows.Forms.ComboBox()
        Me.dtpDeliveryDate = New System.Windows.Forms.DateTimePicker()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.btnSearchTelephoneDirectory = New System.Windows.Forms.Button()
        Me.txtTelephone = New System.Windows.Forms.TextBox()
        Me.lblTelephone = New System.Windows.Forms.Label()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.txtZip = New System.Windows.Forms.TextBox()
        Me.lblZip = New System.Windows.Forms.Label()
        Me.txtCo = New System.Windows.Forms.TextBox()
        Me.lblCo = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.grpOrderingCustomer = New System.Windows.Forms.GroupBox()
        Me.grpCommodity = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dtgCommodity = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grpOrderStatus = New System.Windows.Forms.GroupBox()
        Me.lblPayedDate = New System.Windows.Forms.Label()
        Me.lblOrderSent = New System.Windows.Forms.Label()
        Me.lblOrderLastEdited = New System.Windows.Forms.Label()
        Me.lblOrderCreated = New System.Windows.Forms.Label()
        Me.lblOrderNumber = New System.Windows.Forms.Label()
        Me.grpDiscount = New System.Windows.Forms.GroupBox()
        Me.txtDiscount = New System.Windows.Forms.TextBox()
        Me.rdoPercent = New System.Windows.Forms.RadioButton()
        Me.rdoCurrencyValue = New System.Windows.Forms.RadioButton()
        Me.rdoNone = New System.Windows.Forms.RadioButton()
        Me.grpPayment = New System.Windows.Forms.GroupBox()
        Me.lblAmountToPayValue = New System.Windows.Forms.Label()
        Me.lblVatValue = New System.Windows.Forms.Label()
        Me.lblTotalAmountWithoutVatValue = New System.Windows.Forms.Label()
        Me.lblAmountToPay = New System.Windows.Forms.Label()
        Me.lblVat = New System.Windows.Forms.Label()
        Me.lblTotalAmountWithoutVat = New System.Windows.Forms.Label()
        Me.cboIsPayed = New System.Windows.Forms.CheckBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.btnSaveOrder = New System.Windows.Forms.Button()
        Me.cboPrintReceiptOnSave = New System.Windows.Forms.CheckBox()
        Me.txtInternalNote = New System.Windows.Forms.TextBox()
        Me.lblInternalNote = New System.Windows.Forms.Label()
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
        Me.grpDelivery.SuspendLayout()
        Me.grpOrderingCustomer.SuspendLayout()
        Me.grpCommodity.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dtgCommodity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpOrderStatus.SuspendLayout()
        Me.grpDiscount.SuspendLayout()
        Me.grpPayment.SuspendLayout()
        Me.grpSubscription.SuspendLayout()
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
        'txtCustomerNameAndOrderAutocomplete
        '
        Me.txtCustomerNameAndOrderAutocomplete.Location = New System.Drawing.Point(60, 22)
        Me.txtCustomerNameAndOrderAutocomplete.Name = "txtCustomerNameAndOrderAutocomplete"
        Me.txtCustomerNameAndOrderAutocomplete.Size = New System.Drawing.Size(338, 20)
        Me.txtCustomerNameAndOrderAutocomplete.TabIndex = 3
        Me.txtCustomerNameAndOrderAutocomplete.Text = "Autocomplete på kundenavn/nr her ..."
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
        Me.grpDelivery.Controls.Add(Me.lblDeliveryMethod)
        Me.grpDelivery.Controls.Add(Me.cboDeliveryMethod)
        Me.grpDelivery.Controls.Add(Me.dtpDeliveryDate)
        Me.grpDelivery.Controls.Add(Me.lblDate)
        Me.grpDelivery.Controls.Add(Me.txtEmail)
        Me.grpDelivery.Controls.Add(Me.lblEmail)
        Me.grpDelivery.Controls.Add(Me.btnSearchTelephoneDirectory)
        Me.grpDelivery.Controls.Add(Me.txtTelephone)
        Me.grpDelivery.Controls.Add(Me.lblTelephone)
        Me.grpDelivery.Controls.Add(Me.lblCity)
        Me.grpDelivery.Controls.Add(Me.txtZip)
        Me.grpDelivery.Controls.Add(Me.lblZip)
        Me.grpDelivery.Controls.Add(Me.txtCo)
        Me.grpDelivery.Controls.Add(Me.lblCo)
        Me.grpDelivery.Controls.Add(Me.txtAddress)
        Me.grpDelivery.Controls.Add(Me.lblAddress)
        Me.grpDelivery.Controls.Add(Me.txtName)
        Me.grpDelivery.Controls.Add(Me.lblName)
        Me.grpDelivery.Location = New System.Drawing.Point(13, 89)
        Me.grpDelivery.Name = "grpDelivery"
        Me.grpDelivery.Size = New System.Drawing.Size(495, 163)
        Me.grpDelivery.TabIndex = 5
        Me.grpDelivery.TabStop = False
        Me.grpDelivery.Text = "Levering"
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
        'cboDeliveryMethod
        '
        Me.cboDeliveryMethod.FormattingEnabled = True
        Me.cboDeliveryMethod.Location = New System.Drawing.Point(327, 127)
        Me.cboDeliveryMethod.Name = "cboDeliveryMethod"
        Me.cboDeliveryMethod.Size = New System.Drawing.Size(145, 21)
        Me.cboDeliveryMethod.TabIndex = 16
        '
        'dtpDeliveryDate
        '
        Me.dtpDeliveryDate.Location = New System.Drawing.Point(59, 126)
        Me.dtpDeliveryDate.Name = "dtpDeliveryDate"
        Me.dtpDeliveryDate.Size = New System.Drawing.Size(210, 20)
        Me.dtpDeliveryDate.TabIndex = 15
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
        Me.txtEmail.TabIndex = 13
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
        'btnSearchTelephoneDirectory
        '
        Me.btnSearchTelephoneDirectory.Location = New System.Drawing.Point(131, 90)
        Me.btnSearchTelephoneDirectory.Name = "btnSearchTelephoneDirectory"
        Me.btnSearchTelephoneDirectory.Size = New System.Drawing.Size(138, 20)
        Me.btnSearchTelephoneDirectory.TabIndex = 11
        Me.btnSearchTelephoneDirectory.Text = "Slå opp i telefonkatalogen"
        Me.btnSearchTelephoneDirectory.UseVisualStyleBackColor = True
        '
        'txtTelephone
        '
        Me.txtTelephone.Location = New System.Drawing.Point(59, 90)
        Me.txtTelephone.Name = "txtTelephone"
        Me.txtTelephone.Size = New System.Drawing.Size(66, 20)
        Me.txtTelephone.TabIndex = 10
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
        'txtZip
        '
        Me.txtZip.Location = New System.Drawing.Point(327, 46)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(44, 20)
        Me.txtZip.TabIndex = 7
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
        'txtCo
        '
        Me.txtCo.Location = New System.Drawing.Point(327, 17)
        Me.txtCo.Name = "txtCo"
        Me.txtCo.Size = New System.Drawing.Size(145, 20)
        Me.txtCo.TabIndex = 5
        '
        'lblCo
        '
        Me.lblCo.AutoSize = True
        Me.lblCo.Location = New System.Drawing.Point(276, 20)
        Me.lblCo.Name = "lblCo"
        Me.lblCo.Size = New System.Drawing.Size(30, 13)
        Me.lblCo.TabIndex = 4
        Me.lblCo.Text = "C/O:"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(59, 43)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(210, 41)
        Me.txtAddress.TabIndex = 3
        Me.txtAddress.Text = "Default kundenavn, ellers autocomplete mot address-tabell"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(5, 46)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(48, 13)
        Me.lblAddress.TabIndex = 2
        Me.lblAddress.Text = "Adresse:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(59, 17)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(210, 20)
        Me.txtName.TabIndex = 1
        Me.txtName.Text = "Default kundenavn"
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
        Me.grpOrderingCustomer.Controls.Add(Me.lblCustomer)
        Me.grpOrderingCustomer.Controls.Add(Me.txtCustomerNameAndOrderAutocomplete)
        Me.grpOrderingCustomer.Controls.Add(Me.btnNewCustomer)
        Me.grpOrderingCustomer.Location = New System.Drawing.Point(13, 27)
        Me.grpOrderingCustomer.Name = "grpOrderingCustomer"
        Me.grpOrderingCustomer.Size = New System.Drawing.Size(495, 56)
        Me.grpOrderingCustomer.TabIndex = 6
        Me.grpOrderingCustomer.TabStop = False
        Me.grpOrderingCustomer.Text = "Bestiller"
        '
        'grpCommodity
        '
        Me.grpCommodity.Controls.Add(Me.Panel1)
        Me.grpCommodity.Location = New System.Drawing.Point(13, 258)
        Me.grpCommodity.Name = "grpCommodity"
        Me.grpCommodity.Size = New System.Drawing.Size(495, 221)
        Me.grpCommodity.TabIndex = 7
        Me.grpCommodity.TabStop = False
        Me.grpCommodity.Text = "Varer"
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.dtgCommodity)
        Me.Panel1.Location = New System.Drawing.Point(6, 19)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(483, 195)
        Me.Panel1.TabIndex = 8
        '
        'dtgCommodity
        '
        Me.dtgCommodity.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgCommodity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgCommodity.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.dtgCommodity.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgCommodity.Location = New System.Drawing.Point(0, 0)
        Me.dtgCommodity.Name = "dtgCommodity"
        Me.dtgCommodity.Size = New System.Drawing.Size(483, 195)
        Me.dtgCommodity.TabIndex = 1
        '
        'Column1
        '
        Me.Column1.HeaderText = "Varenr"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Enkeltingrediens?"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Antall"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Pris eks.mva."
        Me.Column4.Name = "Column4"
        '
        'grpOrderStatus
        '
        Me.grpOrderStatus.Controls.Add(Me.lblPayedDate)
        Me.grpOrderStatus.Controls.Add(Me.lblOrderSent)
        Me.grpOrderStatus.Controls.Add(Me.lblOrderLastEdited)
        Me.grpOrderStatus.Controls.Add(Me.lblOrderCreated)
        Me.grpOrderStatus.Controls.Add(Me.lblOrderNumber)
        Me.grpOrderStatus.Location = New System.Drawing.Point(524, 27)
        Me.grpOrderStatus.Name = "grpOrderStatus"
        Me.grpOrderStatus.Size = New System.Drawing.Size(292, 128)
        Me.grpOrderStatus.TabIndex = 8
        Me.grpOrderStatus.TabStop = False
        Me.grpOrderStatus.Text = "Status (denne vises bare ved redigering)"
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
        Me.grpDiscount.Location = New System.Drawing.Point(13, 485)
        Me.grpDiscount.Name = "grpDiscount"
        Me.grpDiscount.Size = New System.Drawing.Size(495, 50)
        Me.grpDiscount.TabIndex = 9
        Me.grpDiscount.TabStop = False
        Me.grpDiscount.Text = "Rabatt"
        '
        'txtDiscount
        '
        Me.txtDiscount.Enabled = False
        Me.txtDiscount.Location = New System.Drawing.Point(388, 19)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.Size = New System.Drawing.Size(101, 20)
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
        Me.rdoPercent.TabIndex = 2
        Me.rdoPercent.Text = "Prosent"
        Me.rdoPercent.UseVisualStyleBackColor = True
        '
        'rdoCurrencyValue
        '
        Me.rdoCurrencyValue.AutoSize = True
        Me.rdoCurrencyValue.Location = New System.Drawing.Point(140, 20)
        Me.rdoCurrencyValue.Name = "rdoCurrencyValue"
        Me.rdoCurrencyValue.Size = New System.Drawing.Size(76, 17)
        Me.rdoCurrencyValue.TabIndex = 1
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
        Me.grpPayment.Controls.Add(Me.lblAmountToPayValue)
        Me.grpPayment.Controls.Add(Me.lblVatValue)
        Me.grpPayment.Controls.Add(Me.lblTotalAmountWithoutVatValue)
        Me.grpPayment.Controls.Add(Me.lblAmountToPay)
        Me.grpPayment.Controls.Add(Me.lblVat)
        Me.grpPayment.Controls.Add(Me.lblTotalAmountWithoutVat)
        Me.grpPayment.Location = New System.Drawing.Point(13, 541)
        Me.grpPayment.Name = "grpPayment"
        Me.grpPayment.Size = New System.Drawing.Size(495, 80)
        Me.grpPayment.TabIndex = 10
        Me.grpPayment.TabStop = False
        Me.grpPayment.Text = "Betaling"
        '
        'lblAmountToPayValue
        '
        Me.lblAmountToPayValue.AutoSize = True
        Me.lblAmountToPayValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmountToPayValue.Location = New System.Drawing.Point(418, 51)
        Me.lblAmountToPayValue.Name = "lblAmountToPayValue"
        Me.lblAmountToPayValue.Size = New System.Drawing.Size(60, 16)
        Me.lblAmountToPayValue.TabIndex = 6
        Me.lblAmountToPayValue.Text = "1150,00"
        '
        'lblVatValue
        '
        Me.lblVatValue.AutoSize = True
        Me.lblVatValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVatValue.Location = New System.Drawing.Point(432, 33)
        Me.lblVatValue.Name = "lblVatValue"
        Me.lblVatValue.Size = New System.Drawing.Size(46, 16)
        Me.lblVatValue.TabIndex = 5
        Me.lblVatValue.Text = "150,00"
        '
        'lblTotalAmountWithoutVatValue
        '
        Me.lblTotalAmountWithoutVatValue.AutoSize = True
        Me.lblTotalAmountWithoutVatValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalAmountWithoutVatValue.Location = New System.Drawing.Point(425, 16)
        Me.lblTotalAmountWithoutVatValue.Name = "lblTotalAmountWithoutVatValue"
        Me.lblTotalAmountWithoutVatValue.Size = New System.Drawing.Size(53, 16)
        Me.lblTotalAmountWithoutVatValue.TabIndex = 4
        Me.lblTotalAmountWithoutVatValue.Text = "1000,00"
        '
        'lblAmountToPay
        '
        Me.lblAmountToPay.AutoSize = True
        Me.lblAmountToPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmountToPay.Location = New System.Drawing.Point(14, 55)
        Me.lblAmountToPay.Name = "lblAmountToPay"
        Me.lblAmountToPay.Size = New System.Drawing.Size(70, 16)
        Me.lblAmountToPay.TabIndex = 2
        Me.lblAmountToPay.Text = "Å betale:"
        '
        'lblVat
        '
        Me.lblVat.AutoSize = True
        Me.lblVat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVat.Location = New System.Drawing.Point(14, 37)
        Me.lblVat.Name = "lblVat"
        Me.lblVat.Size = New System.Drawing.Size(37, 16)
        Me.lblVat.TabIndex = 1
        Me.lblVat.Text = "Mva:"
        '
        'lblTotalAmountWithoutVat
        '
        Me.lblTotalAmountWithoutVat.AutoSize = True
        Me.lblTotalAmountWithoutVat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalAmountWithoutVat.Location = New System.Drawing.Point(14, 20)
        Me.lblTotalAmountWithoutVat.Name = "lblTotalAmountWithoutVat"
        Me.lblTotalAmountWithoutVat.Size = New System.Drawing.Size(99, 16)
        Me.lblTotalAmountWithoutVat.TabIndex = 0
        Me.lblTotalAmountWithoutVat.Text = "Total eks. mva:"
        '
        'cboIsPayed
        '
        Me.cboIsPayed.AutoSize = True
        Me.cboIsPayed.Checked = True
        Me.cboIsPayed.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cboIsPayed.Location = New System.Drawing.Point(524, 577)
        Me.cboIsPayed.Name = "cboIsPayed"
        Me.cboIsPayed.Size = New System.Drawing.Size(77, 17)
        Me.cboIsPayed.TabIndex = 7
        Me.cboIsPayed.Text = "Er oppgjort"
        Me.cboIsPayed.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'btnSaveOrder
        '
        Me.btnSaveOrder.Location = New System.Drawing.Point(725, 587)
        Me.btnSaveOrder.Name = "btnSaveOrder"
        Me.btnSaveOrder.Size = New System.Drawing.Size(91, 34)
        Me.btnSaveOrder.TabIndex = 11
        Me.btnSaveOrder.Text = "Lagre ordre"
        Me.btnSaveOrder.UseVisualStyleBackColor = True
        '
        'cboPrintReceiptOnSave
        '
        Me.cboPrintReceiptOnSave.AutoSize = True
        Me.cboPrintReceiptOnSave.Checked = True
        Me.cboPrintReceiptOnSave.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cboPrintReceiptOnSave.Location = New System.Drawing.Point(524, 599)
        Me.cboPrintReceiptOnSave.Name = "cboPrintReceiptOnSave"
        Me.cboPrintReceiptOnSave.Size = New System.Drawing.Size(163, 17)
        Me.cboPrintReceiptOnSave.TabIndex = 12
        Me.cboPrintReceiptOnSave.Text = "Skriv ut kvittering ved lagring"
        Me.cboPrintReceiptOnSave.UseVisualStyleBackColor = True
        '
        'txtInternalNote
        '
        Me.txtInternalNote.Location = New System.Drawing.Point(524, 182)
        Me.txtInternalNote.Multiline = True
        Me.txtInternalNote.Name = "txtInternalNote"
        Me.txtInternalNote.Size = New System.Drawing.Size(292, 58)
        Me.txtInternalNote.TabIndex = 0
        '
        'lblInternalNote
        '
        Me.lblInternalNote.AutoSize = True
        Me.lblInternalNote.Location = New System.Drawing.Point(521, 166)
        Me.lblInternalNote.Name = "lblInternalNote"
        Me.lblInternalNote.Size = New System.Drawing.Size(193, 13)
        Me.lblInternalNote.TabIndex = 13
        Me.lblInternalNote.Text = "Internt notat (vises ikke på pakkseddel)"
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
        Me.grpSubscription.Location = New System.Drawing.Point(526, 258)
        Me.grpSubscription.Name = "grpSubscription"
        Me.grpSubscription.Size = New System.Drawing.Size(292, 286)
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
        Me.lblNextShipments.TabIndex = 24
        Me.lblNextShipments.Text = "Neste utsendelser"
        '
        'lstNextShipments
        '
        Me.lstNextShipments.Enabled = False
        Me.lstNextShipments.FormattingEnabled = True
        Me.lstNextShipments.Items.AddRange(New Object() {"(liste over neste X leveringer utfra valgt intervall)"})
        Me.lstNextShipments.Location = New System.Drawing.Point(14, 217)
        Me.lstNextShipments.Name = "lstNextShipments"
        Me.lstNextShipments.Size = New System.Drawing.Size(270, 56)
        Me.lstNextShipments.TabIndex = 13
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
        Me.dtpEndDate.TabIndex = 22
        '
        'cboHasEndDate
        '
        Me.cboHasEndDate.AutoSize = True
        Me.cboHasEndDate.Location = New System.Drawing.Point(10, 138)
        Me.cboHasEndDate.Name = "cboHasEndDate"
        Me.cboHasEndDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cboHasEndDate.Size = New System.Drawing.Size(86, 17)
        Me.cboHasEndDate.TabIndex = 21
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
        Me.dtpStartDate.TabIndex = 19
        '
        'cboFrequency
        '
        Me.cboFrequency.FormattingEnabled = True
        Me.cboFrequency.Items.AddRange(New Object() {"Ukentlig", "Daglig", "Månedlig"})
        Me.cboFrequency.Location = New System.Drawing.Point(84, 77)
        Me.cboFrequency.Name = "cboFrequency"
        Me.cboFrequency.Size = New System.Drawing.Size(52, 21)
        Me.cboFrequency.TabIndex = 18
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
        Me.cboTypeInterval.TabIndex = 15
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
        Me.chkIsActivated.TabIndex = 16
        Me.chkIsActivated.Text = "Er aktivert"
        Me.chkIsActivated.UseVisualStyleBackColor = True
        '
        'frmSaleOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(830, 655)
        Me.Controls.Add(Me.grpSubscription)
        Me.Controls.Add(Me.lblInternalNote)
        Me.Controls.Add(Me.txtInternalNote)
        Me.Controls.Add(Me.cboIsPayed)
        Me.Controls.Add(Me.cboPrintReceiptOnSave)
        Me.Controls.Add(Me.btnSaveOrder)
        Me.Controls.Add(Me.grpPayment)
        Me.Controls.Add(Me.grpDiscount)
        Me.Controls.Add(Me.grpOrderStatus)
        Me.Controls.Add(Me.grpCommodity)
        Me.Controls.Add(Me.grpOrderingCustomer)
        Me.Controls.Add(Me.grpDelivery)
        Me.Name = "frmSaleOrder"
        Me.Text = "Ordre"
        Me.Controls.SetChildIndex(Me.grpDelivery, 0)
        Me.Controls.SetChildIndex(Me.grpOrderingCustomer, 0)
        Me.Controls.SetChildIndex(Me.grpCommodity, 0)
        Me.Controls.SetChildIndex(Me.grpOrderStatus, 0)
        Me.Controls.SetChildIndex(Me.grpDiscount, 0)
        Me.Controls.SetChildIndex(Me.grpPayment, 0)
        Me.Controls.SetChildIndex(Me.btnSaveOrder, 0)
        Me.Controls.SetChildIndex(Me.cboPrintReceiptOnSave, 0)
        Me.Controls.SetChildIndex(Me.cboIsPayed, 0)
        Me.Controls.SetChildIndex(Me.txtInternalNote, 0)
        Me.Controls.SetChildIndex(Me.lblInternalNote, 0)
        Me.Controls.SetChildIndex(Me.grpSubscription, 0)
        Me.grpDelivery.ResumeLayout(False)
        Me.grpDelivery.PerformLayout()
        Me.grpOrderingCustomer.ResumeLayout(False)
        Me.grpOrderingCustomer.PerformLayout()
        Me.grpCommodity.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.dtgCommodity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpOrderStatus.ResumeLayout(False)
        Me.grpOrderStatus.PerformLayout()
        Me.grpDiscount.ResumeLayout(False)
        Me.grpDiscount.PerformLayout()
        Me.grpPayment.ResumeLayout(False)
        Me.grpPayment.PerformLayout()
        Me.grpSubscription.ResumeLayout(False)
        Me.grpSubscription.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCustomer As System.Windows.Forms.Label
    Friend WithEvents txtCustomerNameAndOrderAutocomplete As System.Windows.Forms.TextBox
    Friend WithEvents btnNewCustomer As System.Windows.Forms.Button
    Friend WithEvents grpDelivery As System.Windows.Forms.GroupBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtTelephone As System.Windows.Forms.TextBox
    Friend WithEvents lblTelephone As System.Windows.Forms.Label
    Friend WithEvents lblCity As System.Windows.Forms.Label
    Friend WithEvents txtZip As System.Windows.Forms.TextBox
    Friend WithEvents lblZip As System.Windows.Forms.Label
    Friend WithEvents txtCo As System.Windows.Forms.TextBox
    Friend WithEvents lblCo As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents btnSearchTelephoneDirectory As System.Windows.Forms.Button
    Friend WithEvents grpOrderingCustomer As System.Windows.Forms.GroupBox
    Friend WithEvents grpCommodity As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents dtgCommodity As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grpOrderStatus As System.Windows.Forms.GroupBox
    Friend WithEvents lblOrderNumber As System.Windows.Forms.Label
    Friend WithEvents lblOrderCreated As System.Windows.Forms.Label
    Friend WithEvents lblPayedDate As System.Windows.Forms.Label
    Friend WithEvents lblOrderSent As System.Windows.Forms.Label
    Friend WithEvents lblOrderLastEdited As System.Windows.Forms.Label
    Friend WithEvents grpDiscount As System.Windows.Forms.GroupBox
    Friend WithEvents txtDiscount As System.Windows.Forms.TextBox
    Friend WithEvents rdoPercent As System.Windows.Forms.RadioButton
    Friend WithEvents rdoCurrencyValue As System.Windows.Forms.RadioButton
    Friend WithEvents rdoNone As System.Windows.Forms.RadioButton
    Friend WithEvents lblDeliveryMethod As System.Windows.Forms.Label
    Friend WithEvents cboDeliveryMethod As System.Windows.Forms.ComboBox
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
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents btnSaveOrder As System.Windows.Forms.Button
    Friend WithEvents cboPrintReceiptOnSave As System.Windows.Forms.CheckBox
    Friend WithEvents txtInternalNote As System.Windows.Forms.TextBox
    Friend WithEvents lblInternalNote As System.Windows.Forms.Label
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

End Class
