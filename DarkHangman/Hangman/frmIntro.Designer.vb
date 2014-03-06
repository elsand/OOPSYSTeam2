<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIntro
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
        Me.components = New System.ComponentModel.Container()
        Me.btnStartGame = New Hangman.HMctlButton()
        Me.btnHighScore = New Hangman.HMctlButton()
        Me.btnHelp = New Hangman.HMctlButton()
        Me.picTitle = New System.Windows.Forms.PictureBox()
        Me.timerTitleFader = New System.Windows.Forms.Timer(Me.components)
        CType(Me.btnStartGame, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnHighScore, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnHelp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnStartGame
        '
        Me.btnStartGame.BackColor = System.Drawing.Color.Transparent
        Me.btnStartGame.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStartGame.ForeColor = System.Drawing.Color.White
        Me.btnStartGame.Image = Global.Hangman.My.Resources.Resources.ButtonStart
        Me.btnStartGame.Location = New System.Drawing.Point(224, 251)
        Me.btnStartGame.Margin = New System.Windows.Forms.Padding(0)
        Me.btnStartGame.MinimumSize = New System.Drawing.Size(32, 32)
        Me.btnStartGame.Name = "btnStartGame"
        Me.btnStartGame.Size = New System.Drawing.Size(188, 92)
        Me.btnStartGame.TabIndex = 8
        Me.btnStartGame.TabStop = False
        Me.btnStartGame.Text = "&Start spill!"
        '
        'btnHighScore
        '
        Me.btnHighScore.BackColor = System.Drawing.Color.Transparent
        Me.btnHighScore.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHighScore.ForeColor = System.Drawing.Color.White
        Me.btnHighScore.Image = Global.Hangman.My.Resources.Resources.ButtonHighscore
        Me.btnHighScore.Location = New System.Drawing.Point(30, 408)
        Me.btnHighScore.Margin = New System.Windows.Forms.Padding(0)
        Me.btnHighScore.MinimumSize = New System.Drawing.Size(32, 32)
        Me.btnHighScore.Name = "btnHighScore"
        Me.btnHighScore.Size = New System.Drawing.Size(99, 48)
        Me.btnHighScore.TabIndex = 9
        Me.btnHighScore.TabStop = False
        Me.btnHighScore.Text = "H&ighscore"
        '
        'btnHelp
        '
        Me.btnHelp.BackColor = System.Drawing.Color.Transparent
        Me.btnHelp.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHelp.ForeColor = System.Drawing.Color.White
        Me.btnHelp.Image = Global.Hangman.My.Resources.Resources.ButtonHelp
        Me.btnHelp.Location = New System.Drawing.Point(519, 410)
        Me.btnHelp.Margin = New System.Windows.Forms.Padding(0)
        Me.btnHelp.MinimumSize = New System.Drawing.Size(32, 32)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(99, 48)
        Me.btnHelp.TabIndex = 10
        Me.btnHelp.TabStop = False
        Me.btnHelp.Text = "&Hjelp"
        '
        'picTitle
        '
        Me.picTitle.BackColor = System.Drawing.Color.Transparent
        Me.picTitle.Image = Global.Hangman.My.Resources.Resources.Title
        Me.picTitle.Location = New System.Drawing.Point(204, 136)
        Me.picTitle.Name = "picTitle"
        Me.picTitle.Size = New System.Drawing.Size(244, 97)
        Me.picTitle.TabIndex = 12
        Me.picTitle.TabStop = False
        '
        'timerTitleFader
        '
        Me.timerTitleFader.Interval = 16
        '
        'frmIntro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.BackgroundImage = Global.Hangman.My.Resources.Resources.Background
        Me.ClientSize = New System.Drawing.Size(640, 480)
        Me.Controls.Add(Me.picTitle)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.btnHighScore)
        Me.Controls.Add(Me.btnStartGame)
        Me.Name = "frmIntro"
        Me.Controls.SetChildIndex(Me.btnStartGame, 0)
        Me.Controls.SetChildIndex(Me.btnHighScore, 0)
        Me.Controls.SetChildIndex(Me.btnHelp, 0)
        Me.Controls.SetChildIndex(Me.picTitle, 0)
        CType(Me.btnStartGame, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnHighScore, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnHelp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTitle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnStartGame As Hangman.HMctlButton
    Friend WithEvents btnHighScore As Hangman.HMctlButton
    Friend WithEvents btnHelp As Hangman.HMctlButton
    Friend WithEvents picTitle As System.Windows.Forms.PictureBox
    Friend WithEvents timerTitleFader As System.Windows.Forms.Timer

End Class
