' Custom control containing all the letters in the answer
Public Class HMctlAnswer

    ' The answer
    Private Answer As String
    ' List of individual letters
    Private Letters As New List(Of HMAnswerLetter)

    Public Sub New()
        InitializeComponent()
        Me.BackColor = Color.Transparent
    End Sub

    ' Allows for setting / getting the current answer via the Text property
    Overrides Property Text() As String
        Get
            Return Answer
        End Get
        Set(ByVal value As String)
            Answer = value
            If Not Answer = Nothing Then
                RemoveLabels()
                GenerateLabelsForString()
            End If
        End Set
    End Property

    ' Splits the answer string into individual letters and assigns each to a HMAnswerLetter control
    Private Sub GenerateLabelsForString()
        Dim i As Integer
        ' Add to letter list
        For i = 1 To Answer.Length
            Letters.Add(New HMAnswerLetter(Mid(Answer, i, 1), i))
        Next
        ' Add them all to the form
        For Each letter As HMAnswerLetter In Letters
            Me.Controls.Add(letter)
        Next
    End Sub

    ' Removes all letters pending new answer
    Private Sub RemoveLabels()
        For Each ctlControl In Letters
            If TypeOf ctlControl Is HMAnswerLetter Then
                Me.Controls.Remove(ctlControl)
            End If
        Next
        Letters.Clear()
    End Sub

    ' Returns true if the answer contains the supplied letter
    Public Function HasLetter(letter As String) As Boolean
        For Each AnswerLetter As HMAnswerLetter In Letters
            If AnswerLetter.Letter = letter Then
                Return True
            End If
        Next
        Return False
    End Function

    ' Returns true if the user has discovered all the letters in the answer
    Public Function IsFullyRevealed() As Boolean
        For Each AnswerLetter As HMAnswerLetter In Letters
            If AnswerLetter.Text = " " Then
                Return False
            End If
        Next
        Return True
    End Function

    ' Reveal any remaining letters (used when user was hanged)
    Public Sub RevealAnswer()
        For Each AnswerLetter As HMAnswerLetter In Letters
            AnswerLetter.Reveal()
        Next
    End Sub

    ' Reveals all instances of the supplied letter
    Public Sub RevealLetter(letter As String)
        For Each AnswerLetter As HMAnswerLetter In Letters
            If AnswerLetter.Letter = letter Then
                AnswerLetter.Reveal()
            End If
        Next
    End Sub

    ' Custom label for each individual letter
    Private Class HMAnswerLetter
        Inherits System.Windows.Forms.Label

        Private g As Graphics
        Public Letter As String

        ' Index is used for positioning
        Public Sub New(letter As String, index As Integer)
            Me.Letter = letter
            Me.AutoSize = False ' Fixed size
            Me.Size = New System.Drawing.Size(32, 32)
            Me.Margin = New Windows.Forms.Padding(8, 0, 8, 0)
            Me.Text = " " ' Start with blank
            Me.TextAlign = ContentAlignment.MiddleCenter
            Me.BackColor = Color.Transparent
            Me.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ForeColor = System.Drawing.Color.White
            Me.Left = Me.Width * (index - 1)
        End Sub

        ' Adds a three px wide line underneath each letter so that the player can see how many letters there are and their positions
        Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
            MyBase.OnPaint(e)
            e.Graphics.DrawLine(Pens.White, 3, Me.Height - 3, Me.Width - 3, Me.Height - 3)
            e.Graphics.DrawLine(Pens.White, 3, Me.Height - 2, Me.Width - 3, Me.Height - 2)
            e.Graphics.DrawLine(Pens.White, 3, Me.Height - 1, Me.Width - 3, Me.Height - 1)
        End Sub

        ' This is called when the user guesses this letter
        Public Sub Reveal()
            Me.Text = Letter
        End Sub
    End Class
End Class

