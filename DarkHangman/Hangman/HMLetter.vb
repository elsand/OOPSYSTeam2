' Custom control based on label used for the clickable letters on the game form
Public Class HMLetter
    Public Sub New()
        InitializeComponent()
        ' Indicate that the label is clickable
        Me.Cursor = System.Windows.Forms.Cursors.Hand        
        ' Set common properties
        Me.AutoSize = False
        Me.Size = New Size(35, 35)
        Me.TextAlign = ContentAlignment.MiddleCenter
        Me.Image = Global.Hangman.My.Resources.Resources.ButtonLetter
        Me.ForeColor = Color.White
        Me.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

    End Sub

    ' Each letter can only be clicked once each round, so this is called in the click event handler
    Public Sub Disable()
        Me.Enabled = False
    End Sub

    ' Resets the letter so that it is clickable again
    Public Sub Enable()
        Me.Enabled = True
    End Sub
End Class
