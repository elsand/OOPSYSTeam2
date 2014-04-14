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
        Me.txtDiscount = New System.Windows.Forms.TextBox()
        Me.lblDiscount = New System.Windows.Forms.Label()
        Me.txtTelephone = New System.Windows.Forms.TextBox()
        Me.lblTelephone = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.txtZip = New System.Windows.Forms.TextBox()
        Me.lblZip = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.chkIsBusinessClient = New System.Windows.Forms.CheckBox()
        Me.grpCustomerStatus = New System.Windows.Forms.GroupBox()
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
        Me.grpCustomerInformation.SuspendLayout()
        Me.grpCustomerStatus.SuspendLayout()
        Me.grpNote.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpCustomerInformation
        '
        Me.grpCustomerInformation.Controls.Add(Me.txtDiscount)
        Me.grpCustomerInformation.Controls.Add(Me.lblDiscount)
        Me.grpCustomerInformation.Controls.Add(Me.txtTelephone)
        Me.grpCustomerInformation.Controls.Add(Me.lblTelephone)
        Me.grpCustomerInformation.Controls.Add(Me.txtEmail)
        Me.grpCustomerInformation.Controls.Add(Me.lblEmail)
        Me.grpCustomerInformation.Controls.Add(Me.lblCity)
        Me.grpCustomerInformation.Controls.Add(Me.txtZip)
        Me.grpCustomerInformation.Controls.Add(Me.lblZip)
        Me.grpCustomerInformation.Controls.Add(Me.txtAddress)
        Me.grpCustomerInformation.Controls.Add(Me.lblAddress)
        Me.grpCustomerInformation.Controls.Add(Me.txtName)
        Me.grpCustomerInformation.Controls.Add(Me.lblName)
        Me.grpCustomerInformation.Controls.Add(Me.chkIsBusinessClient)
        Me.grpCustomerInformation.Location = New System.Drawing.Point(12, 129)
        Me.grpCustomerInformation.Name = "grpCustomerInformation"
        Me.grpCustomerInformation.Size = New System.Drawing.Size(438, 147)
        Me.grpCustomerInformation.TabIndex = 2
        Me.grpCustomerInformation.TabStop = False
        Me.grpCustomerInformation.Text = "Adresseinformasjon"
        '
        'txtDiscount
        '
        Me.txtDiscount.Location = New System.Drawing.Point(290, 97)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.Size = New System.Drawing.Size(45, 20)
        Me.txtDiscount.TabIndex = 8
        '
        'lblDiscount
        '
        Me.lblDiscount.AutoSize = True
        Me.lblDiscount.Location = New System.Drawing.Point(239, 100)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(50, 13)
        Me.lblDiscount.TabIndex = 12
        Me.lblDiscount.Text = "Rabatt-%"
        '
        'txtTelephone
        '
        Me.txtTelephone.Location = New System.Drawing.Point(290, 71)
        Me.txtTelephone.Name = "txtTelephone"
        Me.txtTelephone.Size = New System.Drawing.Size(134, 20)
        Me.txtTelephone.TabIndex = 7
        '
        'lblTelephone
        '
        Me.lblTelephone.AutoSize = True
        Me.lblTelephone.Location = New System.Drawing.Point(238, 74)
        Me.lblTelephone.Name = "lblTelephone"
        Me.lblTelephone.Size = New System.Drawing.Size(43, 13)
        Me.lblTelephone.TabIndex = 10
        Me.lblTelephone.Text = "Telefon"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(290, 45)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(134, 20)
        Me.txtEmail.TabIndex = 6
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(239, 48)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(34, 13)
        Me.lblEmail.TabIndex = 8
        Me.lblEmail.Text = "Epost"
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Location = New System.Drawing.Point(135, 116)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(92, 13)
        Me.lblCity.TabIndex = 5
        Me.lblCity.Text = "BRØNNØYSUND"
        '
        'txtZip
        '
        Me.txtZip.Location = New System.Drawing.Point(83, 113)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(46, 20)
        Me.txtZip.TabIndex = 4
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
        Me.txtAddress.Location = New System.Drawing.Point(83, 74)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(134, 32)
        Me.txtAddress.TabIndex = 3
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
        Me.txtName.Location = New System.Drawing.Point(83, 48)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(134, 20)
        Me.txtName.TabIndex = 2
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
        'chkIsBusinessClient
        '
        Me.chkIsBusinessClient.AutoSize = True
        Me.chkIsBusinessClient.Location = New System.Drawing.Point(6, 23)
        Me.chkIsBusinessClient.Name = "chkIsBusinessClient"
        Me.chkIsBusinessClient.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkIsBusinessClient.Size = New System.Drawing.Size(91, 17)
        Me.chkIsBusinessClient.TabIndex = 1
        Me.chkIsBusinessClient.Text = "Er firmakunde"
        Me.chkIsBusinessClient.UseVisualStyleBackColor = True
        '
        'grpCustomerStatus
        '
        Me.grpCustomerStatus.Controls.Add(Me.btnShowSubscriptions)
        Me.grpCustomerStatus.Controls.Add(Me.btnShowOrders)
        Me.grpCustomerStatus.Controls.Add(Me.lblTotalOrderValue)
        Me.grpCustomerStatus.Controls.Add(Me.lblNumberOfOrders)
        Me.grpCustomerStatus.Controls.Add(Me.lblLastEditedDateAndTime)
        Me.grpCustomerStatus.Controls.Add(Me.lblCreatedDateAndTime)
        Me.grpCustomerStatus.Controls.Add(Me.lblCustomerNumber)
        Me.grpCustomerStatus.Location = New System.Drawing.Point(12, 27)
        Me.grpCustomerStatus.Name = "grpCustomerStatus"
        Me.grpCustomerStatus.Size = New System.Drawing.Size(438, 96)
        Me.grpCustomerStatus.TabIndex = 1
        Me.grpCustomerStatus.TabStop = False
        Me.grpCustomerStatus.Text = "Status (denne vises bare ved redigering)"
        '
        'btnShowSubscriptions
        '
        Me.btnShowSubscriptions.Location = New System.Drawing.Point(304, 60)
        Me.btnShowSubscriptions.Name = "btnShowSubscriptions"
        Me.btnShowSubscriptions.Size = New System.Drawing.Size(128, 23)
        Me.btnShowSubscriptions.TabIndex = 1
        Me.btnShowSubscriptions.Text = "Vis abonnementer ..."
        Me.btnShowSubscriptions.UseVisualStyleBackColor = True
        '
        'btnShowOrders
        '
        Me.btnShowOrders.Location = New System.Drawing.Point(223, 60)
        Me.btnShowOrders.Name = "btnShowOrders"
        Me.btnShowOrders.Size = New System.Drawing.Size(75, 23)
        Me.btnShowOrders.TabIndex = 0
        Me.btnShowOrders.Text = "Vis order ..."
        Me.btnShowOrders.UseVisualStyleBackColor = True
        '
        'lblTotalOrderValue
        '
        Me.lblTotalOrderValue.AutoSize = True
        Me.lblTotalOrderValue.Location = New System.Drawing.Point(221, 39)
        Me.lblTotalOrderValue.Name = "lblTotalOrderValue"
        Me.lblTotalOrderValue.Size = New System.Drawing.Size(132, 13)
        Me.lblTotalOrderValue.TabIndex = 4
        Me.lblTotalOrderValue.Text = "Total ordreverdi: 19245,44"
        '
        'lblNumberOfOrders
        '
        Me.lblNumberOfOrders.AutoSize = True
        Me.lblNumberOfOrders.Location = New System.Drawing.Point(221, 23)
        Me.lblNumberOfOrders.Name = "lblNumberOfOrders"
        Me.lblNumberOfOrders.Size = New System.Drawing.Size(81, 13)
        Me.lblNumberOfOrders.TabIndex = 3
        Me.lblNumberOfOrders.Text = "Antall ordrer: 22"
        '
        'lblLastEditedDateAndTime
        '
        Me.lblLastEditedDateAndTime.AutoSize = True
        Me.lblLastEditedDateAndTime.Location = New System.Drawing.Point(36, 65)
        Me.lblLastEditedDateAndTime.Name = "lblLastEditedDateAndTime"
        Me.lblLastEditedDateAndTime.Size = New System.Drawing.Size(158, 13)
        Me.lblLastEditedDateAndTime.TabIndex = 2
        Me.lblLastEditedDateAndTime.Text = "Sist endret: 21.12.2016 kl 14:43"
        '
        'lblCreatedDateAndTime
        '
        Me.lblCreatedDateAndTime.AutoSize = True
        Me.lblCreatedDateAndTime.Location = New System.Drawing.Point(42, 49)
        Me.lblCreatedDateAndTime.Name = "lblCreatedDateAndTime"
        Me.lblCreatedDateAndTime.Size = New System.Drawing.Size(152, 13)
        Me.lblCreatedDateAndTime.TabIndex = 1
        Me.lblCreatedDateAndTime.Text = "Opprettet: 21.12.2016 kl 14:43"
        '
        'lblCustomerNumber
        '
        Me.lblCustomerNumber.AutoSize = True
        Me.lblCustomerNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerNumber.Location = New System.Drawing.Point(22, 23)
        Me.lblCustomerNumber.Name = "lblCustomerNumber"
        Me.lblCustomerNumber.Size = New System.Drawing.Size(146, 20)
        Me.lblCustomerNumber.TabIndex = 0
        Me.lblCustomerNumber.Text = "Kundenr: 123345"
        '
        'grpNote
        '
        Me.grpNote.Controls.Add(Me.txtNote)
        Me.grpNote.Location = New System.Drawing.Point(13, 281)
        Me.grpNote.Name = "grpNote"
        Me.grpNote.Size = New System.Drawing.Size(437, 102)
        Me.grpNote.TabIndex = 3
        Me.grpNote.TabStop = False
        Me.grpNote.Text = "Notat"
        '
        'txtNote
        '
        Me.txtNote.Location = New System.Drawing.Point(10, 19)
        Me.txtNote.Multiline = True
        Me.txtNote.Name = "txtNote"
        Me.txtNote.Size = New System.Drawing.Size(413, 66)
        Me.txtNote.TabIndex = 0
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(356, 398)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(94, 28)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "Lagre"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(253, 398)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(94, 28)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Avbryt"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'frmSaleCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(462, 464)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.grpNote)
        Me.Controls.Add(Me.grpCustomerStatus)
        Me.Controls.Add(Me.grpCustomerInformation)
        Me.Name = "frmSaleCustomer"
        Me.Text = "Kunde"
        Me.Controls.SetChildIndex(Me.grpCustomerInformation, 0)
        Me.Controls.SetChildIndex(Me.grpCustomerStatus, 0)
        Me.Controls.SetChildIndex(Me.grpNote, 0)
        Me.Controls.SetChildIndex(Me.btnSave, 0)
        Me.Controls.SetChildIndex(Me.btnCancel, 0)
        Me.grpCustomerInformation.ResumeLayout(False)
        Me.grpCustomerInformation.PerformLayout()
        Me.grpCustomerStatus.ResumeLayout(False)
        Me.grpCustomerStatus.PerformLayout()
        Me.grpNote.ResumeLayout(False)
        Me.grpNote.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpCustomerInformation As System.Windows.Forms.GroupBox
    Friend WithEvents lblCity As System.Windows.Forms.Label
    Friend WithEvents txtZip As System.Windows.Forms.TextBox
    Friend WithEvents lblZip As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents chkIsBusinessClient As System.Windows.Forms.CheckBox
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
    Friend WithEvents txtDiscount As System.Windows.Forms.TextBox
    Friend WithEvents lblDiscount As System.Windows.Forms.Label
    Friend WithEvents btnShowSubscriptions As System.Windows.Forms.Button

End Class
