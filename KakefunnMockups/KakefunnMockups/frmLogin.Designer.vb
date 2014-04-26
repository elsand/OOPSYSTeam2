<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
    Inherits Kakefunn.frmSuperBase

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
        Me.grpLogin = New System.Windows.Forms.GroupBox()
        Me.btnDoLogin = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.grpLogin.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpLogin
        '
        Me.grpLogin.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.grpLogin.Controls.Add(Me.btnDoLogin)
        Me.grpLogin.Controls.Add(Me.txtPassword)
        Me.grpLogin.Controls.Add(Me.txtEmail)
        Me.grpLogin.Controls.Add(Me.lblPassword)
        Me.grpLogin.Controls.Add(Me.lblEmail)
        Me.grpLogin.Location = New System.Drawing.Point(136, 96)
        Me.grpLogin.Name = "grpLogin"
        Me.grpLogin.Size = New System.Drawing.Size(266, 171)
        Me.grpLogin.TabIndex = 2
        Me.grpLogin.TabStop = False
        Me.grpLogin.Text = "Innlogging"
        '
        'btnDoLogin
        '
        Me.btnDoLogin.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDoLogin.Location = New System.Drawing.Point(97, 119)
        Me.btnDoLogin.Name = "btnDoLogin"
        Me.btnDoLogin.Size = New System.Drawing.Size(134, 23)
        Me.btnDoLogin.TabIndex = 2
        Me.btnDoLogin.Text = "Logg inn"
        Me.btnDoLogin.UseVisualStyleBackColor = True
        '
        'txtPassword
        '
        Me.txtPassword.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPassword.Location = New System.Drawing.Point(97, 80)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(134, 20)
        Me.txtPassword.TabIndex = 1
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'txtEmail
        '
        Me.txtEmail.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEmail.Location = New System.Drawing.Point(97, 41)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(137, 20)
        Me.txtEmail.TabIndex = 0
        '
        'lblPassword
        '
        Me.lblPassword.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(46, 83)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(45, 13)
        Me.lblPassword.TabIndex = 1
        Me.lblPassword.Text = "Passord"
        '
        'lblEmail
        '
        Me.lblEmail.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(53, 44)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(37, 13)
        Me.lblEmail.TabIndex = 0
        Me.lblEmail.Text = "E-post"
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(35, 37)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(492, 31)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Velkommen til AS Kakefunn InfoSystem"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(577, 341)
        Me.Controls.Add(Me.grpLogin)
        Me.Controls.Add(Me.Label11)
        Me.MinimumSize = New System.Drawing.Size(593, 380)
        Me.Name = "frmLogin"
        Me.Text = "Innlogging"
        Me.grpLogin.ResumeLayout(False)
        Me.grpLogin.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpLogin As System.Windows.Forms.GroupBox
    Friend WithEvents btnDoLogin As System.Windows.Forms.Button
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label

End Class
