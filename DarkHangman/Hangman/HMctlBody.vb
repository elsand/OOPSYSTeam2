' Since WinForms doesn't support true transparency making stacking transparent PictureBoxes impossible,
' we create our own control to handle this via a shared canvas. 
Public Class HMctlBody
    ' The canvas used in our shared PictureBox
    Private Canvas As Bitmap = New Bitmap(640, 480)
    ' Graphics class handling the actual merging of images
    Private g As Graphics
    ' List of body part images, added as precompiled images
    ' All images are 640x480 PNGs so that we don't have to worry
    ' about positioning (this is done directly in Photoshop).
    ' Parts are added to the gallow top to bottom
    Private BodyParts As Bitmap() = {
        Global.Hangman.My.Resources.Resources.Head,
        Global.Hangman.My.Resources.Resources.Neck,
        Global.Hangman.My.Resources.Resources.Torso,
        Global.Hangman.My.Resources.Resources.RightArm,
        Global.Hangman.My.Resources.Resources.LeftArm,
        Global.Hangman.My.Resources.Resources.RightLeg,
        Global.Hangman.My.Resources.Resources.LeftLeg
    }
    ' Keep track of what body part to add. When this overflows BodyParts, the game is over
    Private CurrentBodyPartIndex As Integer = 0

    Public Sub New()
        InitializeComponent()
        ' Set it to fill the entire window. Don't set any image yet.
        Me.Size = New Size(640, 480)
        Me.Location = New Point(0, 0)
        Me.BackColor = Color.Transparent
        ' Bind the canvas to the graphics object 
        g = Graphics.FromImage(Canvas)
    End Sub

    Public Sub AddNextBodyPartToGallow()
        ' Extra check to avoid overflow 
        If CurrentBodyPartIndex + 1 > BodyParts.Length Then
            Return
        End If
        ' Add the corresponding body part and update the picturebox
        g.DrawImage(BodyParts(CurrentBodyPartIndex), 0, 0)
        Me.Image = Canvas
        ' Bump the index so that the next body part gets added next
        CurrentBodyPartIndex = CurrentBodyPartIndex + 1
    End Sub

    ' Enables the game to check whether the player has lost
    Public Function HasBodyPartsLeft() As Boolean
        Return CurrentBodyPartIndex + 1 <= BodyParts.Length
    End Function

    ' Resets all state so that a new game can start
    Public Sub Reset()
        CurrentBodyPartIndex = 0
        g.Clear(Color.Transparent)
        Me.Image = Canvas
    End Sub

    ' Since we cover the entire form, we need to proxy mouseevents to the parent form so that it can be moved
    Private Sub Form_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        Dim parent = CType(Me.FindForm(), frmBase)
        parent.Form_MouseDown(sender, e)
    End Sub

    Private Sub Form_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        Dim parent = CType(Me.FindForm(), frmBase)
        parent.Form_MouseMove(sender, e)
    End Sub

    Private Sub Form_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        Dim parent = CType(Me.FindForm(), frmBase)
        parent.Form_MouseUp(sender, e)
    End Sub

End Class
