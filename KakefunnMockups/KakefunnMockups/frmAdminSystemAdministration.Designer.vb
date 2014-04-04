<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdminSystemAdministration
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
        Me.ddlEmployees = New System.Windows.Forms.ComboBox()
        Me.DBMBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnSaveChanges = New System.Windows.Forms.Button()
        Me.btnNewUser = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtRepeatPassword = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnEditEmployee = New System.Windows.Forms.Button()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.cbAdmin = New System.Windows.Forms.CheckBox()
        Me.cbSale = New System.Windows.Forms.CheckBox()
        Me.cbLogistics = New System.Windows.Forms.CheckBox()
        Me.txtPhone = New Kakefunn.NumericTextbox()
        Me.txtZip = New Kakefunn.NumericTextbox()
        CType(Me.DBMBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ddlEmployees
        '
        Me.ddlEmployees.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlEmployees.FormattingEnabled = True
        Me.ddlEmployees.Location = New System.Drawing.Point(158, 70)
        Me.ddlEmployees.Name = "ddlEmployees"
        Me.ddlEmployees.Size = New System.Drawing.Size(150, 21)
        Me.ddlEmployees.TabIndex = 7
        '
        'DBMBindingSource
        '
        Me.DBMBindingSource.DataSource = GetType(Kakefunn.DBM)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Rediger eksisterende bruker"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Navn"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(158, 126)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(150, 20)
        Me.txtName.TabIndex = 10
        '
        'btnSaveChanges
        '
        Me.btnSaveChanges.Location = New System.Drawing.Point(420, 360)
        Me.btnSaveChanges.Name = "btnSaveChanges"
        Me.btnSaveChanges.Size = New System.Drawing.Size(114, 23)
        Me.btnSaveChanges.TabIndex = 11
        Me.btnSaveChanges.Text = "Lagre ny bruker"
        Me.btnSaveChanges.UseVisualStyleBackColor = True
        '
        'btnNewUser
        '
        Me.btnNewUser.Location = New System.Drawing.Point(15, 360)
        Me.btnNewUser.Name = "btnNewUser"
        Me.btnNewUser.Size = New System.Drawing.Size(75, 23)
        Me.btnNewUser.TabIndex = 12
        Me.btnNewUser.Text = "Ny bruker"
        Me.btnNewUser.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Roller"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 210)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Telefon"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(158, 233)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(150, 20)
        Me.txtEmail.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 236)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "E-post"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(158, 259)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(150, 20)
        Me.txtPassword.TabIndex = 20
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(12, 262)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(45, 13)
        Me.lblPassword.TabIndex = 19
        Me.lblPassword.Text = "Passord"
        '
        'txtRepeatPassword
        '
        Me.txtRepeatPassword.Location = New System.Drawing.Point(158, 285)
        Me.txtRepeatPassword.Name = "txtRepeatPassword"
        Me.txtRepeatPassword.Size = New System.Drawing.Size(150, 20)
        Me.txtRepeatPassword.TabIndex = 22
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 288)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 13)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Gjenta passord"
        '
        'btnEditEmployee
        '
        Me.btnEditEmployee.Location = New System.Drawing.Point(314, 68)
        Me.btnEditEmployee.Name = "btnEditEmployee"
        Me.btnEditEmployee.Size = New System.Drawing.Size(75, 23)
        Me.btnEditEmployee.TabIndex = 23
        Me.btnEditEmployee.Text = "Rediger"
        Me.btnEditEmployee.UseVisualStyleBackColor = True
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(384, 210)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(150, 43)
        Me.txtAddress.TabIndex = 24
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(333, 213)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 13)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Adresse"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(341, 267)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 13)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Postnr"
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Location = New System.Drawing.Point(437, 267)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(36, 13)
        Me.lblCity.TabIndex = 28
        Me.lblCity.Text = "STED"
        '
        'cbAdmin
        '
        Me.cbAdmin.AutoSize = True
        Me.cbAdmin.Location = New System.Drawing.Point(158, 153)
        Me.cbAdmin.Name = "cbAdmin"
        Me.cbAdmin.Size = New System.Drawing.Size(55, 17)
        Me.cbAdmin.TabIndex = 29
        Me.cbAdmin.Text = "Admin"
        Me.cbAdmin.UseVisualStyleBackColor = True
        '
        'cbSale
        '
        Me.cbSale.AutoSize = True
        Me.cbSale.Location = New System.Drawing.Point(158, 170)
        Me.cbSale.Name = "cbSale"
        Me.cbSale.Size = New System.Drawing.Size(47, 17)
        Me.cbSale.TabIndex = 30
        Me.cbSale.Text = "Salg"
        Me.cbSale.UseVisualStyleBackColor = True
        '
        'cbLogistics
        '
        Me.cbLogistics.AutoSize = True
        Me.cbLogistics.Location = New System.Drawing.Point(158, 187)
        Me.cbLogistics.Name = "cbLogistics"
        Me.cbLogistics.Size = New System.Drawing.Size(68, 17)
        Me.cbLogistics.TabIndex = 31
        Me.cbLogistics.Text = "Logistikk"
        Me.cbLogistics.UseVisualStyleBackColor = True
        '
        'txtPhone
        '
        Me.txtPhone.AllowDecimal = False
        Me.txtPhone.AllowNegative = False
        Me.txtPhone.AllowSpace = False
        Me.txtPhone.Location = New System.Drawing.Point(158, 208)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(150, 20)
        Me.txtPhone.TabIndex = 32
        '
        'txtZip
        '
        Me.txtZip.AllowDecimal = False
        Me.txtZip.AllowNegative = False
        Me.txtZip.AllowSpace = False
        Me.txtZip.Location = New System.Drawing.Point(385, 262)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(46, 20)
        Me.txtZip.TabIndex = 33
        '
        'frmAdminSystemAdministration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(549, 424)
        Me.Controls.Add(Me.txtZip)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.cbLogistics)
        Me.Controls.Add(Me.cbSale)
        Me.Controls.Add(Me.cbAdmin)
        Me.Controls.Add(Me.lblCity)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.btnEditEmployee)
        Me.Controls.Add(Me.txtRepeatPassword)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnNewUser)
        Me.Controls.Add(Me.btnSaveChanges)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ddlEmployees)
        Me.Name = "frmAdminSystemAdministration"
        Me.Text = "Systemadministrasjon"
        Me.Controls.SetChildIndex(Me.ddlEmployees, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.txtName, 0)
        Me.Controls.SetChildIndex(Me.btnSaveChanges, 0)
        Me.Controls.SetChildIndex(Me.btnNewUser, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.txtEmail, 0)
        Me.Controls.SetChildIndex(Me.lblPassword, 0)
        Me.Controls.SetChildIndex(Me.txtPassword, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.txtRepeatPassword, 0)
        Me.Controls.SetChildIndex(Me.btnEditEmployee, 0)
        Me.Controls.SetChildIndex(Me.txtAddress, 0)
        Me.Controls.SetChildIndex(Me.Label8, 0)
        Me.Controls.SetChildIndex(Me.Label9, 0)
        Me.Controls.SetChildIndex(Me.lblCity, 0)
        Me.Controls.SetChildIndex(Me.cbAdmin, 0)
        Me.Controls.SetChildIndex(Me.cbSale, 0)
        Me.Controls.SetChildIndex(Me.cbLogistics, 0)
        Me.Controls.SetChildIndex(Me.txtPhone, 0)
        Me.Controls.SetChildIndex(Me.txtZip, 0)
        CType(Me.DBMBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents ddlEmployees As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents btnSaveChanges As System.Windows.Forms.Button
    Friend WithEvents btnNewUser As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents txtRepeatPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DBMBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents btnEditEmployee As System.Windows.Forms.Button
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblCity As System.Windows.Forms.Label
    Friend WithEvents cbAdmin As System.Windows.Forms.CheckBox
    Friend WithEvents cbSale As System.Windows.Forms.CheckBox
    Friend WithEvents cbLogistics As System.Windows.Forms.CheckBox
    Friend WithEvents txtPhone As Kakefunn.NumericTextbox
    Friend WithEvents txtZip As Kakefunn.NumericTextbox

End Class
