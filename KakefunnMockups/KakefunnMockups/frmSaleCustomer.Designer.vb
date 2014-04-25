<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSaleCustomer
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
        Me.grpCustomerInformation = New System.Windows.Forms.GroupBox()
        Me.ddlDiscountPlan = New System.Windows.Forms.ComboBox()
        Me.txtZip = New Kakefunn.NumericTextbox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ddlCustomerType = New System.Windows.Forms.ComboBox()
        Me.lblDiscount = New System.Windows.Forms.Label()
        Me.txtTelephone = New System.Windows.Forms.TextBox()
        Me.lblTelephone = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.lblZip = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.grpCustomerStatus = New System.Windows.Forms.GroupBox()
        Me.lblTotalOrderValueValue = New System.Windows.Forms.Label()
        Me.lblNumberOfOrdersValue = New System.Windows.Forms.Label()
        Me.lblLastEditedDateAndTimeValue = New System.Windows.Forms.Label()
        Me.lblCreatedDateAndTimeValue = New System.Windows.Forms.Label()
        Me.lblCustomerNumberValue = New System.Windows.Forms.Label()
        Me.btnShowSubscriptions = New System.Windows.Forms.Button()
        Me.btnShowOrders = New System.Windows.Forms.Button()
        Me.lblTotalOrderValue = New System.Windows.Forms.Label()
        Me.lblNumberOfOrders = New System.Windows.Forms.Label()
        Me.lblLastEditedDateAndTime = New System.Windows.Forms.Label()
        Me.lblCreatedDateAndTime = New System.Windows.Forms.Label()
        Me.lblCustomerNumber = New System.Windows.Forms.Label()
        Me.grpNote = New System.Windows.Forms.GroupBox()
        Me.txtNote = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.tlayCustomer = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.grpCustomerInformation.SuspendLayout()
        Me.grpCustomerStatus.SuspendLayout()
        Me.grpNote.SuspendLayout()
        Me.tlayCustomer.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpCustomerInformation
        '
        Me.grpCustomerInformation.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpCustomerInformation.Controls.Add(Me.ddlDiscountPlan)
        Me.grpCustomerInformation.Controls.Add(Me.txtZip)
        Me.grpCustomerInformation.Controls.Add(Me.Label1)
        Me.grpCustomerInformation.Controls.Add(Me.ddlCustomerType)
        Me.grpCustomerInformation.Controls.Add(Me.lblDiscount)
        Me.grpCustomerInformation.Controls.Add(Me.txtTelephone)
        Me.grpCustomerInformation.Controls.Add(Me.lblTelephone)
        Me.grpCustomerInformation.Controls.Add(Me.txtEmail)
        Me.grpCustomerInformation.Controls.Add(Me.lblEmail)
        Me.grpCustomerInformation.Controls.Add(Me.lblCity)
        Me.grpCustomerInformation.Controls.Add(Me.lblZip)
        Me.grpCustomerInformation.Controls.Add(Me.txtAddress)
        Me.grpCustomerInformation.Controls.Add(Me.lblAddress)
        Me.grpCustomerInformation.Controls.Add(Me.txtName)
        Me.grpCustomerInformation.Controls.Add(Me.lblName)
        Me.grpCustomerInformation.Location = New System.Drawing.Point(3, 105)
        Me.grpCustomerInformation.Name = "grpCustomerInformation"
        Me.grpCustomerInformation.Size = New System.Drawing.Size(677, 222)
        Me.grpCustomerInformation.TabIndex = 2
        Me.grpCustomerInformation.TabStop = False
        Me.grpCustomerInformation.Text = "Adresseinformasjon"
        '
        'ddlDiscountPlan
        '
        Me.ddlDiscountPlan.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ddlDiscountPlan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlDiscountPlan.FormattingEnabled = True
        Me.ddlDiscountPlan.Location = New System.Drawing.Point(83, 191)
        Me.ddlDiscountPlan.Name = "ddlDiscountPlan"
        Me.ddlDiscountPlan.Size = New System.Drawing.Size(583, 21)
        Me.ddlDiscountPlan.TabIndex = 6
        '
        'txtZip
        '
        Me.txtZip.AllowDecimal = False
        Me.txtZip.AllowNegative = False
        Me.txtZip.AllowSpace = False
        Me.txtZip.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtZip.Location = New System.Drawing.Point(83, 112)
        Me.txtZip.MaxLength = 4
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(485, 20)
        Me.txtZip.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Kundetype"
        '
        'ddlCustomerType
        '
        Me.ddlCustomerType.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ddlCustomerType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlCustomerType.FormattingEnabled = True
        Me.ddlCustomerType.Location = New System.Drawing.Point(83, 20)
        Me.ddlCustomerType.Name = "ddlCustomerType"
        Me.ddlCustomerType.Size = New System.Drawing.Size(583, 21)
        Me.ddlCustomerType.TabIndex = 0
        '
        'lblDiscount
        '
        Me.lblDiscount.AutoSize = True
        Me.lblDiscount.Location = New System.Drawing.Point(11, 194)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(59, 13)
        Me.lblDiscount.TabIndex = 12
        Me.lblDiscount.Text = "Rabattplan"
        '
        'txtTelephone
        '
        Me.txtTelephone.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTelephone.Location = New System.Drawing.Point(84, 165)
        Me.txtTelephone.Name = "txtTelephone"
        Me.txtTelephone.Size = New System.Drawing.Size(582, 20)
        Me.txtTelephone.TabIndex = 5
        '
        'lblTelephone
        '
        Me.lblTelephone.AutoSize = True
        Me.lblTelephone.Location = New System.Drawing.Point(10, 168)
        Me.lblTelephone.Name = "lblTelephone"
        Me.lblTelephone.Size = New System.Drawing.Size(43, 13)
        Me.lblTelephone.TabIndex = 10
        Me.lblTelephone.Text = "Telefon"
        '
        'txtEmail
        '
        Me.txtEmail.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEmail.Location = New System.Drawing.Point(84, 138)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(582, 20)
        Me.txtEmail.TabIndex = 4
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(11, 141)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(34, 13)
        Me.lblEmail.TabIndex = 8
        Me.lblEmail.Text = "Epost"
        '
        'lblCity
        '
        Me.lblCity.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCity.AutoSize = True
        Me.lblCity.Location = New System.Drawing.Point(574, 115)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(92, 13)
        Me.lblCity.TabIndex = 5
        Me.lblCity.Text = "BRØNNØYSUND"
        '
        'lblZip
        '
        Me.lblZip.AutoSize = True
        Me.lblZip.Location = New System.Drawing.Point(8, 116)
        Me.lblZip.Name = "lblZip"
        Me.lblZip.Size = New System.Drawing.Size(37, 13)
        Me.lblZip.TabIndex = 5
        Me.lblZip.Text = "Postnr"
        '
        'txtAddress
        '
        Me.txtAddress.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAddress.Location = New System.Drawing.Point(83, 74)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(583, 32)
        Me.txtAddress.TabIndex = 2
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(8, 74)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(45, 13)
        Me.lblAddress.TabIndex = 3
        Me.lblAddress.Text = "Adresse"
        '
        'txtName
        '
        Me.txtName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtName.Location = New System.Drawing.Point(83, 48)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(583, 20)
        Me.txtName.TabIndex = 1
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(8, 48)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(33, 13)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Navn"
        '
        'grpCustomerStatus
        '
        Me.grpCustomerStatus.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpCustomerStatus.Controls.Add(Me.lblTotalOrderValueValue)
        Me.grpCustomerStatus.Controls.Add(Me.lblNumberOfOrdersValue)
        Me.grpCustomerStatus.Controls.Add(Me.lblLastEditedDateAndTimeValue)
        Me.grpCustomerStatus.Controls.Add(Me.lblCreatedDateAndTimeValue)
        Me.grpCustomerStatus.Controls.Add(Me.lblCustomerNumberValue)
        Me.grpCustomerStatus.Controls.Add(Me.btnShowSubscriptions)
        Me.grpCustomerStatus.Controls.Add(Me.btnShowOrders)
        Me.grpCustomerStatus.Controls.Add(Me.lblTotalOrderValue)
        Me.grpCustomerStatus.Controls.Add(Me.lblNumberOfOrders)
        Me.grpCustomerStatus.Controls.Add(Me.lblLastEditedDateAndTime)
        Me.grpCustomerStatus.Controls.Add(Me.lblCreatedDateAndTime)
        Me.grpCustomerStatus.Controls.Add(Me.lblCustomerNumber)
        Me.grpCustomerStatus.Location = New System.Drawing.Point(3, 3)
        Me.grpCustomerStatus.Name = "grpCustomerStatus"
        Me.grpCustomerStatus.Size = New System.Drawing.Size(677, 96)
        Me.grpCustomerStatus.TabIndex = 1
        Me.grpCustomerStatus.TabStop = False
        Me.grpCustomerStatus.Text = "Status"
        '
        'lblTotalOrderValueValue
        '
        Me.lblTotalOrderValueValue.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotalOrderValueValue.AutoSize = True
        Me.lblTotalOrderValueValue.Location = New System.Drawing.Point(539, 39)
        Me.lblTotalOrderValueValue.Name = "lblTotalOrderValueValue"
        Me.lblTotalOrderValueValue.Size = New System.Drawing.Size(52, 13)
        Me.lblTotalOrderValueValue.TabIndex = 9
        Me.lblTotalOrderValueValue.Text = "19245,44"
        '
        'lblNumberOfOrdersValue
        '
        Me.lblNumberOfOrdersValue.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNumberOfOrdersValue.AutoSize = True
        Me.lblNumberOfOrdersValue.Location = New System.Drawing.Point(518, 23)
        Me.lblNumberOfOrdersValue.Name = "lblNumberOfOrdersValue"
        Me.lblNumberOfOrdersValue.Size = New System.Drawing.Size(19, 13)
        Me.lblNumberOfOrdersValue.TabIndex = 8
        Me.lblNumberOfOrdersValue.Text = "22"
        '
        'lblLastEditedDateAndTimeValue
        '
        Me.lblLastEditedDateAndTimeValue.AutoSize = True
        Me.lblLastEditedDateAndTimeValue.Location = New System.Drawing.Point(91, 65)
        Me.lblLastEditedDateAndTimeValue.Name = "lblLastEditedDateAndTimeValue"
        Me.lblLastEditedDateAndTimeValue.Size = New System.Drawing.Size(102, 13)
        Me.lblLastEditedDateAndTimeValue.TabIndex = 7
        Me.lblLastEditedDateAndTimeValue.Text = "21.12.2016 kl 14:43"
        '
        'lblCreatedDateAndTimeValue
        '
        Me.lblCreatedDateAndTimeValue.AutoSize = True
        Me.lblCreatedDateAndTimeValue.Location = New System.Drawing.Point(91, 49)
        Me.lblCreatedDateAndTimeValue.Name = "lblCreatedDateAndTimeValue"
        Me.lblCreatedDateAndTimeValue.Size = New System.Drawing.Size(102, 13)
        Me.lblCreatedDateAndTimeValue.TabIndex = 6
        Me.lblCreatedDateAndTimeValue.Text = "21.12.2016 kl 14:43"
        '
        'lblCustomerNumberValue
        '
        Me.lblCustomerNumberValue.AutoSize = True
        Me.lblCustomerNumberValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerNumberValue.Location = New System.Drawing.Point(102, 22)
        Me.lblCustomerNumberValue.Name = "lblCustomerNumberValue"
        Me.lblCustomerNumberValue.Size = New System.Drawing.Size(69, 20)
        Me.lblCustomerNumberValue.TabIndex = 5
        Me.lblCustomerNumberValue.Text = "123345"
        '
        'btnShowSubscriptions
        '
        Me.btnShowSubscriptions.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnShowSubscriptions.Location = New System.Drawing.Point(538, 60)
        Me.btnShowSubscriptions.Name = "btnShowSubscriptions"
        Me.btnShowSubscriptions.Size = New System.Drawing.Size(128, 23)
        Me.btnShowSubscriptions.TabIndex = 1
        Me.btnShowSubscriptions.Text = "Vis abonnementer ..."
        Me.btnShowSubscriptions.UseVisualStyleBackColor = True
        '
        'btnShowOrders
        '
        Me.btnShowOrders.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnShowOrders.Location = New System.Drawing.Point(457, 60)
        Me.btnShowOrders.Name = "btnShowOrders"
        Me.btnShowOrders.Size = New System.Drawing.Size(75, 23)
        Me.btnShowOrders.TabIndex = 0
        Me.btnShowOrders.Text = "Vis order ..."
        Me.btnShowOrders.UseVisualStyleBackColor = True
        '
        'lblTotalOrderValue
        '
        Me.lblTotalOrderValue.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotalOrderValue.AutoSize = True
        Me.lblTotalOrderValue.Location = New System.Drawing.Point(455, 39)
        Me.lblTotalOrderValue.Name = "lblTotalOrderValue"
        Me.lblTotalOrderValue.Size = New System.Drawing.Size(87, 13)
        Me.lblTotalOrderValue.TabIndex = 4
        Me.lblTotalOrderValue.Text = "Total ordreverdi: "
        '
        'lblNumberOfOrders
        '
        Me.lblNumberOfOrders.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNumberOfOrders.AutoSize = True
        Me.lblNumberOfOrders.Location = New System.Drawing.Point(455, 23)
        Me.lblNumberOfOrders.Name = "lblNumberOfOrders"
        Me.lblNumberOfOrders.Size = New System.Drawing.Size(66, 13)
        Me.lblNumberOfOrders.TabIndex = 3
        Me.lblNumberOfOrders.Text = "Antall ordrer:"
        '
        'lblLastEditedDateAndTime
        '
        Me.lblLastEditedDateAndTime.AutoSize = True
        Me.lblLastEditedDateAndTime.Location = New System.Drawing.Point(36, 65)
        Me.lblLastEditedDateAndTime.Name = "lblLastEditedDateAndTime"
        Me.lblLastEditedDateAndTime.Size = New System.Drawing.Size(63, 13)
        Me.lblLastEditedDateAndTime.TabIndex = 2
        Me.lblLastEditedDateAndTime.Text = "Sist endret: "
        '
        'lblCreatedDateAndTime
        '
        Me.lblCreatedDateAndTime.AutoSize = True
        Me.lblCreatedDateAndTime.Location = New System.Drawing.Point(42, 49)
        Me.lblCreatedDateAndTime.Name = "lblCreatedDateAndTime"
        Me.lblCreatedDateAndTime.Size = New System.Drawing.Size(57, 13)
        Me.lblCreatedDateAndTime.TabIndex = 1
        Me.lblCreatedDateAndTime.Text = "Opprettet: "
        '
        'lblCustomerNumber
        '
        Me.lblCustomerNumber.AutoSize = True
        Me.lblCustomerNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerNumber.Location = New System.Drawing.Point(22, 23)
        Me.lblCustomerNumber.Name = "lblCustomerNumber"
        Me.lblCustomerNumber.Size = New System.Drawing.Size(81, 20)
        Me.lblCustomerNumber.TabIndex = 0
        Me.lblCustomerNumber.Text = "Kundenr:"
        '
        'grpNote
        '
        Me.grpNote.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpNote.Controls.Add(Me.txtNote)
        Me.grpNote.Location = New System.Drawing.Point(3, 333)
        Me.grpNote.Name = "grpNote"
        Me.grpNote.Size = New System.Drawing.Size(677, 95)
        Me.grpNote.TabIndex = 3
        Me.grpNote.TabStop = False
        Me.grpNote.Text = "Notat"
        '
        'txtNote
        '
        Me.txtNote.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNote.Location = New System.Drawing.Point(10, 19)
        Me.txtNote.Multiline = True
        Me.txtNote.Name = "txtNote"
        Me.txtNote.Size = New System.Drawing.Size(656, 66)
        Me.txtNote.TabIndex = 0
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Location = New System.Drawing.Point(581, 5)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(94, 25)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "Lagre"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(0, 3)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(94, 27)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Avbryt"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'tlayCustomer
        '
        Me.tlayCustomer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tlayCustomer.ColumnCount = 1
        Me.tlayCustomer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlayCustomer.Controls.Add(Me.Panel1, 0, 3)
        Me.tlayCustomer.Controls.Add(Me.grpNote, 0, 2)
        Me.tlayCustomer.Controls.Add(Me.grpCustomerInformation, 0, 1)
        Me.tlayCustomer.Controls.Add(Me.grpCustomerStatus, 0, 0)
        Me.tlayCustomer.Location = New System.Drawing.Point(12, 10)
        Me.tlayCustomer.Name = "tlayCustomer"
        Me.tlayCustomer.RowCount = 4
        Me.tlayCustomer.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlayCustomer.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlayCustomer.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlayCustomer.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlayCustomer.Size = New System.Drawing.Size(683, 471)
        Me.tlayCustomer.TabIndex = 6
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Location = New System.Drawing.Point(3, 437)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(677, 31)
        Me.Panel1.TabIndex = 7
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(284, 5)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "Tøm felter"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'frmSaleCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(709, 648)
        Me.Controls.Add(Me.tlayCustomer)
        Me.MinimumSize = New System.Drawing.Size(491, 531)
        Me.Name = "frmSaleCustomer"
        Me.Text = "Kunde"
        Me.grpCustomerInformation.ResumeLayout(False)
        Me.grpCustomerInformation.PerformLayout()
        Me.grpCustomerStatus.ResumeLayout(False)
        Me.grpCustomerStatus.PerformLayout()
        Me.grpNote.ResumeLayout(False)
        Me.grpNote.PerformLayout()
        Me.tlayCustomer.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpCustomerInformation As System.Windows.Forms.GroupBox
    Friend WithEvents lblCity As System.Windows.Forms.Label
    Friend WithEvents lblZip As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtTelephone As System.Windows.Forms.TextBox
    Friend WithEvents lblTelephone As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents grpCustomerStatus As System.Windows.Forms.GroupBox
    Friend WithEvents lblTotalOrderValue As System.Windows.Forms.Label
    Friend WithEvents lblNumberOfOrders As System.Windows.Forms.Label
    Friend WithEvents lblLastEditedDateAndTime As System.Windows.Forms.Label
    Friend WithEvents lblCreatedDateAndTime As System.Windows.Forms.Label
    Friend WithEvents lblCustomerNumber As System.Windows.Forms.Label
    Friend WithEvents grpNote As System.Windows.Forms.GroupBox
    Friend WithEvents txtNote As System.Windows.Forms.TextBox
    Friend WithEvents btnShowOrders As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents lblDiscount As System.Windows.Forms.Label
    Friend WithEvents btnShowSubscriptions As System.Windows.Forms.Button
    Friend WithEvents tlayCustomer As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ddlCustomerType As System.Windows.Forms.ComboBox
    Friend WithEvents txtZip As Kakefunn.NumericTextbox
    Friend WithEvents ddlDiscountPlan As System.Windows.Forms.ComboBox
    Friend WithEvents lblCustomerNumberValue As System.Windows.Forms.Label
    Friend WithEvents lblTotalOrderValueValue As System.Windows.Forms.Label
    Friend WithEvents lblNumberOfOrdersValue As System.Windows.Forms.Label
    Friend WithEvents lblLastEditedDateAndTimeValue As System.Windows.Forms.Label
    Friend WithEvents lblCreatedDateAndTimeValue As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button

End Class
