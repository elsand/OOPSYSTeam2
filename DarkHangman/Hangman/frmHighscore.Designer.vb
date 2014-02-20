<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHighscore
    Inherits Hangman.frmBase

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
        Me.panelBackground = New System.Windows.Forms.Panel()
        Me.lblTimestamp = New System.Windows.Forms.Label()
        Me.lblPosition = New System.Windows.Forms.Label()
        Me.lblNames = New System.Windows.Forms.Label()
        Me.lblScores = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnBack = New Hangman.HMctlButton()
        Me.panelBackground.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelBackground
        '
        Me.panelBackground.BackColor = System.Drawing.Color.Black
        Me.panelBackground.Controls.Add(Me.lblTimestamp)
        Me.panelBackground.Controls.Add(Me.lblPosition)
        Me.panelBackground.Controls.Add(Me.lblNames)
        Me.panelBackground.Controls.Add(Me.lblScores)
        Me.panelBackground.Controls.Add(Me.PictureBox1)
        Me.panelBackground.Location = New System.Drawing.Point(28, 56)
        Me.panelBackground.Name = "panelBackground"
        Me.panelBackground.Size = New System.Drawing.Size(588, 345)
        Me.panelBackground.TabIndex = 5
        '
        'lblTimestamp
        '
        Me.lblTimestamp.AutoEllipsis = True
        Me.lblTimestamp.BackColor = System.Drawing.Color.Transparent
        Me.lblTimestamp.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimestamp.ForeColor = System.Drawing.Color.Gray
        Me.lblTimestamp.Location = New System.Drawing.Point(388, 79)
        Me.lblTimestamp.Name = "lblTimestamp"
        Me.lblTimestamp.Size = New System.Drawing.Size(192, 247)
        Me.lblTimestamp.TabIndex = 4
        Me.lblTimestamp.Text = "31. nov 2013 12:00"
        Me.lblTimestamp.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblPosition
        '
        Me.lblPosition.BackColor = System.Drawing.Color.Transparent
        Me.lblPosition.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPosition.ForeColor = System.Drawing.Color.White
        Me.lblPosition.Location = New System.Drawing.Point(3, 79)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(53, 247)
        Me.lblPosition.TabIndex = 3
        Me.lblPosition.Text = "1."
        Me.lblPosition.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblNames
        '
        Me.lblNames.AutoEllipsis = True
        Me.lblNames.BackColor = System.Drawing.Color.Transparent
        Me.lblNames.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNames.ForeColor = System.Drawing.Color.White
        Me.lblNames.Location = New System.Drawing.Point(164, 79)
        Me.lblNames.Name = "lblNames"
        Me.lblNames.Size = New System.Drawing.Size(216, 247)
        Me.lblNames.TabIndex = 2
        Me.lblNames.Text = "MMMMMMMMMMMM"
        Me.lblNames.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblScores
        '
        Me.lblScores.BackColor = System.Drawing.Color.Transparent
        Me.lblScores.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScores.ForeColor = System.Drawing.Color.White
        Me.lblScores.Location = New System.Drawing.Point(55, 79)
        Me.lblScores.Name = "lblScores"
        Me.lblScores.Size = New System.Drawing.Size(103, 247)
        Me.lblScores.TabIndex = 1
        Me.lblScores.Text = "12345678"
        Me.lblScores.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Hangman.My.Resources.Resources.Highscore
        Me.PictureBox1.Location = New System.Drawing.Point(237, 18)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(103, 33)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Image = Global.Hangman.My.Resources.Resources.ButtonBack
        Me.btnBack.Location = New System.Drawing.Point(267, 416)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(0)
        Me.btnBack.MinimumSize = New System.Drawing.Size(32, 32)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(99, 48)
        Me.btnBack.TabIndex = 6
        Me.btnBack.TabStop = False
        '
        'frmHighscore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(640, 480)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.panelBackground)
        Me.Name = "frmHighscore"
        Me.Controls.SetChildIndex(Me.panelBackground, 0)
        Me.Controls.SetChildIndex(Me.btnBack, 0)
        Me.panelBackground.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents panelBackground As System.Windows.Forms.Panel
    Friend WithEvents btnBack As Hangman.HMctlButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblNames As System.Windows.Forms.Label
    Friend WithEvents lblScores As System.Windows.Forms.Label
    Friend WithEvents lblPosition As System.Windows.Forms.Label
    Friend WithEvents lblTimestamp As System.Windows.Forms.Label

End Class
