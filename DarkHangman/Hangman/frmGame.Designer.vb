<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGame
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
        Me.Answer = New Hangman.HMctlAnswer()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.lblTimeRemaining = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblRound = New System.Windows.Forms.Label()
        Me.timerGameTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Answer
        '
        Me.Answer.BackColor = System.Drawing.Color.Transparent
        Me.Answer.Location = New System.Drawing.Point(20, 418)
        Me.Answer.Name = "Answer"
        Me.Answer.Size = New System.Drawing.Size(602, 38)
        Me.Answer.TabIndex = 33
        Me.Answer.Text = Nothing
        '
        'lblScore
        '
        Me.lblScore.BackColor = System.Drawing.Color.Transparent
        Me.lblScore.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.ForeColor = System.Drawing.Color.White
        Me.lblScore.Location = New System.Drawing.Point(463, 121)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(169, 42)
        Me.lblScore.TabIndex = 34
        Me.lblScore.Text = "1332"
        Me.lblScore.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblTimeRemaining
        '
        Me.lblTimeRemaining.BackColor = System.Drawing.Color.Transparent
        Me.lblTimeRemaining.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeRemaining.ForeColor = System.Drawing.Color.White
        Me.lblTimeRemaining.Location = New System.Drawing.Point(506, 183)
        Me.lblTimeRemaining.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTimeRemaining.Name = "lblTimeRemaining"
        Me.lblTimeRemaining.Size = New System.Drawing.Size(124, 24)
        Me.lblTimeRemaining.TabIndex = 35
        Me.lblTimeRemaining.Text = "30.21"
        Me.lblTimeRemaining.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(516, 165)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 18)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Gjenstående tid"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(577, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 18)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Poeng"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(575, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 18)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Runde"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblRound
        '
        Me.lblRound.BackColor = System.Drawing.Color.Transparent
        Me.lblRound.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRound.ForeColor = System.Drawing.Color.White
        Me.lblRound.Location = New System.Drawing.Point(540, 75)
        Me.lblRound.Name = "lblRound"
        Me.lblRound.Size = New System.Drawing.Size(89, 30)
        Me.lblRound.TabIndex = 39
        Me.lblRound.Text = "1"
        Me.lblRound.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'timerGameTimer
        '
        Me.timerGameTimer.Interval = 10
        '
        'frmGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(640, 480)
        Me.Controls.Add(Me.lblRound)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTimeRemaining)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.Answer)
        Me.Name = "frmGame"
        Me.Controls.SetChildIndex(Me.Answer, 0)
        Me.Controls.SetChildIndex(Me.lblScore, 0)
        Me.Controls.SetChildIndex(Me.lblTimeRemaining, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.lblRound, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Answer As Hangman.HMctlAnswer
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents lblTimeRemaining As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblRound As System.Windows.Forms.Label
    Friend WithEvents timerGameTimer As System.Windows.Forms.Timer

End Class
