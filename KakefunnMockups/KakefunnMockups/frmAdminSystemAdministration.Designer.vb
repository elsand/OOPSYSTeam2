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
        Me.lblEditEmployee = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnSaveChanges = New System.Windows.Forms.Button()
        Me.btnNewUser = New System.Windows.Forms.Button()
        Me.lblRoles = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtRepeatPassword = New System.Windows.Forms.TextBox()
        Me.lblRepeatPassword = New System.Windows.Forms.Label()
        Me.btnEditEmployee = New System.Windows.Forms.Button()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblZip = New System.Windows.Forms.Label()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.cbAdmin = New System.Windows.Forms.CheckBox()
        Me.cbSale = New System.Windows.Forms.CheckBox()
        Me.cbLogistics = New System.Windows.Forms.CheckBox()
        Me.txtPhone = New Kakefunn.NumericTextbox()
        Me.txtZip = New Kakefunn.NumericTextbox()
        Me.grpSystemAdministration = New System.Windows.Forms.GroupBox()
        CType(Me.DBMBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSystemAdministration.SuspendLayout()
        Me.SuspendLayout()
        '
        'ddlEmployees
        '
        Me.ddlEmployees.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlEmployees.FormattingEnabled = True
        Me.ddlEmployees.Location = New System.Drawing.Point(152, 28)
        Me.ddlEmployees.Name = "ddlEmployees"
        Me.ddlEmployees.Size = New System.Drawing.Size(150, 21)
        Me.ddlEmployees.TabIndex = 8
        Me.ddlEmployees.Tag = "noDirty"
        '
        'DBMBindingSource
        '
        Me.DBMBindingSource.DataSource = GetType(Kakefunn.DBM)
        '
        'lblEditEmployee
        '
        Me.lblEditEmployee.AutoSize = True
        Me.lblEditEmployee.Location = New System.Drawing.Point(6, 31)
        Me.lblEditEmployee.Name = "lblEditEmployee"
        Me.lblEditEmployee.Size = New System.Drawing.Size(140, 13)
        Me.lblEditEmployee.TabIndex = 8
        Me.lblEditEmployee.Text = "Rediger eksisterende bruker"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(6, 87)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(33, 13)
        Me.lblName.TabIndex = 9
        Me.lblName.Text = "Navn"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(152, 84)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(150, 20)
        Me.txtName.TabIndex = 10
        '
        'btnSaveChanges
        '
        Me.btnSaveChanges.Location = New System.Drawing.Point(414, 292)
        Me.btnSaveChanges.Name = "btnSaveChanges"
        Me.btnSaveChanges.Size = New System.Drawing.Size(114, 23)
        Me.btnSaveChanges.TabIndex = 22
        Me.btnSaveChanges.Text = "Lagre ny bruker"
        Me.btnSaveChanges.UseVisualStyleBackColor = True
        '
        'btnNewUser
        '
        Me.btnNewUser.Location = New System.Drawing.Point(9, 292)
        Me.btnNewUser.Name = "btnNewUser"
        Me.btnNewUser.Size = New System.Drawing.Size(114, 23)
        Me.btnNewUser.TabIndex = 21
        Me.btnNewUser.Text = "Ny bruker"
        Me.btnNewUser.UseVisualStyleBackColor = True
        '
        'lblRoles
        '
        Me.lblRoles.AutoSize = True
        Me.lblRoles.Location = New System.Drawing.Point(6, 110)
        Me.lblRoles.Name = "lblRoles"
        Me.lblRoles.Size = New System.Drawing.Size(34, 13)
        Me.lblRoles.TabIndex = 14
        Me.lblRoles.Text = "Roller"
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(6, 168)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(43, 13)
        Me.lblPhone.TabIndex = 15
        Me.lblPhone.Text = "Telefon"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(152, 191)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(150, 20)
        Me.txtEmail.TabIndex = 15
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(6, 194)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(37, 13)
        Me.lblEmail.TabIndex = 17
        Me.lblEmail.Text = "E-post"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(152, 217)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(150, 20)
        Me.txtPassword.TabIndex = 16
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(6, 220)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(45, 13)
        Me.lblPassword.TabIndex = 19
        Me.lblPassword.Text = "Passord"
        '
        'txtRepeatPassword
        '
        Me.txtRepeatPassword.Location = New System.Drawing.Point(152, 243)
        Me.txtRepeatPassword.Name = "txtRepeatPassword"
        Me.txtRepeatPassword.Size = New System.Drawing.Size(150, 20)
        Me.txtRepeatPassword.TabIndex = 17
        Me.txtRepeatPassword.UseSystemPasswordChar = True
        '
        'lblRepeatPassword
        '
        Me.lblRepeatPassword.AutoSize = True
        Me.lblRepeatPassword.Location = New System.Drawing.Point(6, 246)
        Me.lblRepeatPassword.Name = "lblRepeatPassword"
        Me.lblRepeatPassword.Size = New System.Drawing.Size(78, 13)
        Me.lblRepeatPassword.TabIndex = 21
        Me.lblRepeatPassword.Text = "Gjenta passord"
        '
        'btnEditEmployee
        '
        Me.btnEditEmployee.Location = New System.Drawing.Point(308, 26)
        Me.btnEditEmployee.Name = "btnEditEmployee"
        Me.btnEditEmployee.Size = New System.Drawing.Size(75, 23)
        Me.btnEditEmployee.TabIndex = 9
        Me.btnEditEmployee.Text = "Rediger"
        Me.btnEditEmployee.UseVisualStyleBackColor = True
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(378, 168)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(150, 43)
        Me.txtAddress.TabIndex = 18
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(327, 171)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(45, 13)
        Me.lblAddress.TabIndex = 25
        Me.lblAddress.Text = "Adresse"
        '
        'lblZip
        '
        Me.lblZip.AutoSize = True
        Me.lblZip.Location = New System.Drawing.Point(335, 225)
        Me.lblZip.Name = "lblZip"
        Me.lblZip.Size = New System.Drawing.Size(37, 13)
        Me.lblZip.TabIndex = 27
        Me.lblZip.Text = "Postnr"
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Location = New System.Drawing.Point(431, 225)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(36, 13)
        Me.lblCity.TabIndex = 20
        Me.lblCity.Text = "STED"
        '
        'cbAdmin
        '
        Me.cbAdmin.AutoSize = True
        Me.cbAdmin.Location = New System.Drawing.Point(152, 111)
        Me.cbAdmin.Name = "cbAdmin"
        Me.cbAdmin.Size = New System.Drawing.Size(55, 17)
        Me.cbAdmin.TabIndex = 11
        Me.cbAdmin.Text = "Admin"
        Me.cbAdmin.UseVisualStyleBackColor = True
        '
        'cbSale
        '
        Me.cbSale.AutoSize = True
        Me.cbSale.Location = New System.Drawing.Point(152, 128)
        Me.cbSale.Name = "cbSale"
        Me.cbSale.Size = New System.Drawing.Size(47, 17)
        Me.cbSale.TabIndex = 12
        Me.cbSale.Text = "Salg"
        Me.cbSale.UseVisualStyleBackColor = True
        '
        'cbLogistics
        '
        Me.cbLogistics.AutoSize = True
        Me.cbLogistics.Location = New System.Drawing.Point(152, 145)
        Me.cbLogistics.Name = "cbLogistics"
        Me.cbLogistics.Size = New System.Drawing.Size(68, 17)
        Me.cbLogistics.TabIndex = 13
        Me.cbLogistics.Text = "Logistikk"
        Me.cbLogistics.UseVisualStyleBackColor = True
        '
        'txtPhone
        '
        Me.txtPhone.AllowDecimal = False
        Me.txtPhone.AllowNegative = False
        Me.txtPhone.AllowSpace = False
        Me.txtPhone.Location = New System.Drawing.Point(152, 166)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(150, 20)
        Me.txtPhone.TabIndex = 14
        '
        'txtZip
        '
        Me.txtZip.AllowDecimal = False
        Me.txtZip.AllowNegative = False
        Me.txtZip.AllowSpace = False
        Me.txtZip.Location = New System.Drawing.Point(379, 220)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(46, 20)
        Me.txtZip.TabIndex = 19
        '
        'grpSystemAdministration
        '
        Me.grpSystemAdministration.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpSystemAdministration.Controls.Add(Me.btnSaveChanges)
        Me.grpSystemAdministration.Controls.Add(Me.txtZip)
        Me.grpSystemAdministration.Controls.Add(Me.btnNewUser)
        Me.grpSystemAdministration.Controls.Add(Me.txtPhone)
        Me.grpSystemAdministration.Controls.Add(Me.lblEditEmployee)
        Me.grpSystemAdministration.Controls.Add(Me.cbLogistics)
        Me.grpSystemAdministration.Controls.Add(Me.ddlEmployees)
        Me.grpSystemAdministration.Controls.Add(Me.cbSale)
        Me.grpSystemAdministration.Controls.Add(Me.lblName)
        Me.grpSystemAdministration.Controls.Add(Me.cbAdmin)
        Me.grpSystemAdministration.Controls.Add(Me.txtName)
        Me.grpSystemAdministration.Controls.Add(Me.lblCity)
        Me.grpSystemAdministration.Controls.Add(Me.lblRoles)
        Me.grpSystemAdministration.Controls.Add(Me.lblZip)
        Me.grpSystemAdministration.Controls.Add(Me.lblPhone)
        Me.grpSystemAdministration.Controls.Add(Me.lblAddress)
        Me.grpSystemAdministration.Controls.Add(Me.lblEmail)
        Me.grpSystemAdministration.Controls.Add(Me.txtAddress)
        Me.grpSystemAdministration.Controls.Add(Me.txtEmail)
        Me.grpSystemAdministration.Controls.Add(Me.btnEditEmployee)
        Me.grpSystemAdministration.Controls.Add(Me.lblPassword)
        Me.grpSystemAdministration.Controls.Add(Me.txtRepeatPassword)
        Me.grpSystemAdministration.Controls.Add(Me.txtPassword)
        Me.grpSystemAdministration.Controls.Add(Me.lblRepeatPassword)
        Me.grpSystemAdministration.Location = New System.Drawing.Point(12, 12)
        Me.grpSystemAdministration.Name = "grpSystemAdministration"
        Me.grpSystemAdministration.Size = New System.Drawing.Size(543, 321)
        Me.grpSystemAdministration.TabIndex = 28
        Me.grpSystemAdministration.TabStop = False
        Me.grpSystemAdministration.Text = "Administrasjon av brukere"
        '
        'frmAdminSystemAdministration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(567, 350)
        Me.Controls.Add(Me.grpSystemAdministration)
        Me.MinimumSize = New System.Drawing.Size(583, 389)
        Me.Name = "frmAdminSystemAdministration"
        Me.Padding = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.Text = "Systemadministrasjon"
        CType(Me.DBMBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSystemAdministration.ResumeLayout(False)
        Me.grpSystemAdministration.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ddlEmployees As System.Windows.Forms.ComboBox
    Friend WithEvents lblEditEmployee As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents btnSaveChanges As System.Windows.Forms.Button
    Friend WithEvents btnNewUser As System.Windows.Forms.Button
    Friend WithEvents lblRoles As System.Windows.Forms.Label
    Friend WithEvents lblPhone As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents txtRepeatPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblRepeatPassword As System.Windows.Forms.Label
    Friend WithEvents DBMBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents btnEditEmployee As System.Windows.Forms.Button
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents lblZip As System.Windows.Forms.Label
    Friend WithEvents lblCity As System.Windows.Forms.Label
    Friend WithEvents cbAdmin As System.Windows.Forms.CheckBox
    Friend WithEvents cbSale As System.Windows.Forms.CheckBox
    Friend WithEvents cbLogistics As System.Windows.Forms.CheckBox
    Friend WithEvents txtPhone As Kakefunn.NumericTextbox
    Friend WithEvents txtZip As Kakefunn.NumericTextbox
    Friend WithEvents grpSystemAdministration As System.Windows.Forms.GroupBox

End Class
