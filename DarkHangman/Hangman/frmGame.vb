' This class does the actual game logic
Friend Class frmGame

    Public Const DIFFICULTY_EASY As Integer = 1
    Public Const DIFFICULTY_MEDIUM As Integer = 2
    Public Const DIFFICULTY_HARD As Integer = 3

    ' Our custom control for adding body parts. This is a singleton
    Private Body As HMctlBody = New HMctlBody()
    ' Our class handling loading and picking of words
    Private WordList As HMWordList = New HMWordList()
    ' List of letter buttons
    Private Letters As List(Of HMLetter) = New List(Of HMLetter)

    ' This can be changed in the menu
    Public CurrentDifficulty As Integer = DIFFICULTY_EASY

    ' Total number of rounds in the game. This will be set according to chosen difficulty
    Private NumberOfRounds As Integer = 5
    ' Which round are we currently playing
    Private CurrentRound As Integer = 1
    ' The users score
    Private CurrentScore As Integer = 0
    ' Time remaining in round
    Private TimeRemaining As Double
    ' Whether or not the game has been temporarily pause
    Private _IsPaused As Boolean = False

    ' Init code goes into this method. This only runs once.
    Private Sub frmGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddLetters() ' Add alphabet letter buttons to the form
        AddLetterClickEventHandlers() ' Set a common event handler for all clickable letters
        Me.Controls.Add(Body) ' Add the body control (at this point empty) to the form
        WordList.LoadWordListFromFile("Resources\ordliste.dat") ' Initialize wordlist from external text file
    End Sub

    ' Init code to run whenever the form is (re)shown
    Private Sub frmGame_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        If Me.Visible = False Then
            StopGame()
        Else
            ResetGame() ' Set up counters, set random word
            Unpause()
        End If
    End Sub

    ' Adds letter buttons to the form in a nice grid
    Private Sub AddLetters()
        Dim PerRow As Integer = 4 ' How many letters per row
        Dim OffsetX = 12 ' Distance from left side
        Dim OffsetY = mnuMain.Height + 6 ' Distance from top of window
        Dim Spacing = 4 ' Distance between letters (right- and bottom margin)
        Dim ColCounter As Integer = 0 ' Counter to keep track of the current column
        Dim RowCounter As Integer = 0 ' Counter to keep track of the current row

        ' Iterate over all letters
        For Each c In "ABCDEFGHIJKLMNOPQRSTUVWXYZÆØÅ"
            If ColCounter = PerRow Then
                ' Start on new row
                RowCounter = RowCounter + 1
                ColCounter = 0
            End If
            ' Add new letter to list
            Letters.Add(
                New HMLetter() With {
                    .Text = c,
                    .Left = ColCounter * (.Width + Spacing) + OffsetX,
                    .Top = RowCounter * (.Height + Spacing) + OffsetY
                }
            )
            ColCounter = ColCounter + 1
        Next
        ' Add all letters to the form
        For Each Letter As HMLetter In Letters
            Me.Controls.Add(Letter)
        Next
    End Sub

    ' As a convenince, we here iterate through all the controls registered on the form
    ' and adds a common click event handler to all HMLetter controls
    Private Sub AddLetterClickEventHandlers()
        For Each ctlControl In Me.Controls
            If TypeOf ctlControl Is HMLetter Then
                Dim lblLetter As HMLetter
                lblLetter = CType(ctlControl, HMLetter)
                AddHandler lblLetter.Click, AddressOf LetterClickHandler
            End If
        Next
    End Sub

    ' Common handler for dealing with letter clicks
    Private Sub LetterClickHandler(lblLetter As Object, e As EventArgs)
        ' We need this extra check do deal with keyboard presses
        If DirectCast(lblLetter, HMLetter).Enabled = False Then
            Exit Sub
        End If
        ' Each letter can only be used once
        DirectCast(lblLetter, HMLetter).Disable()
        ' Check if this is a letter present in the current answer
        If Answer.HasLetter(DirectCast(lblLetter, HMLetter).Text) Then
            ' Yes, it is. Play a sound, reveal every occurence of it in the answer, bump our points and check if we've won this round
            HMAudio.PlayClickSound()
            Answer.RevealLetter(DirectCast(lblLetter, HMLetter).Text)
            AddLetterRevealToScore()
            CheckIfRoundIsWon()
        Else
            ' No, it is not. Play a different sound, and place a new body part on the gallow (if possible). Then check if we're dead already.
            HMAudio.PlayBodyPartSound()
            Body.AddNextBodyPartToGallow()
            CheckIfRoundIsLost()
        End If
    End Sub

    ' Called after each letter clicks. Checks to see if the game is over, and
    ' if it is, saves the score to the high score table and asks if the user 
    ' wants to try again. Also resets the game so that a new one may start.
    Private Sub CheckIfRoundIsLost()
        If Not Body.HasBodyPartsLeft() Then
            Pause()
            Answer.RevealAnswer()
            SaveToHighScore()
            ' TODO! We should here have a horribly graphic way of telling the user the game is lost before the prompt
            AskIfUserWantsAnotherGameAfterLosing()
            ResetGame()
        End If
    End Sub

    Private Sub CheckIfRoundIsWon()
        If Answer.IsFullyRevealed() Then
            Pause()
            ' TODO! Show some fancy graphic here
            MsgBox("Gratulerer! Du fant frem til ordet!", MsgBoxStyle.OkOnly Or MsgBoxStyle.Information, "Bra jobba!")
            ProceedToNextRound()
        End If
    End Sub

    ' Prompts the user for a new game after losing, and hides the game form showing the intro form if the user declines
    Private Sub AskIfUserWantsAnotherGameAfterLosing()
        If MsgBox("Beklager, men du ble hengt! Prøve igjen?", MsgBoxStyle.YesNo Or MsgBoxStyle.Exclamation) = MsgBoxResult.No Then
            StopGame()
            Me.Hide()
            frmIntro.Show()
            frmIntro.Focus() ' Explicitly focus the intro form
        Else
            Unpause()
        End If
    End Sub


    ' Prompts the user for a new game after winning, and hides the game form showing the intro form if the user declines
    Private Sub AskIfUserWantsAnotherGameAfterWinning()
        If MsgBox("Ønsker du å spille enda en gang?", MsgBoxStyle.YesNo Or MsgBoxStyle.Exclamation) = MsgBoxResult.No Then
            StopGame()
            Me.Hide()
            frmIntro.Show()
            frmIntro.Focus() ' Explicitly focus the intro form
        Else
            Unpause()
        End If
    End Sub

    ' Run when round is completed
    Private Sub ProceedToNextRound()
        ' Check if theres any rounds left
        If CurrentRound = NumberOfRounds Then
            ' Nope, that was the last round. The user has beat the game. Well done.
            MsgBox("Du vant med hele " & CurrentScore & " poeng!")
            AddGameCompletionToScore()
            SaveToHighScore()
            ResetGame()
            AskIfUserWantsAnotherGameAfterWinning()
        Else
            ' Still some rounds to go, add some points and set up a new round
            AddRoundCompletionToScore()
            CurrentRound = CurrentRound + 1
            ResetRound()
            Unpause()
        End If
    End Sub

    ' Upon discovering a letter in the answer, add to current score based on difficulty level
    Private Sub AddLetterRevealToScore()
        CurrentScore = CurrentScore + 100 * CurrentDifficulty
    End Sub

    ' Upon round completion, add a value to the current score based on time remaining and difficulty level
    Private Sub AddRoundCompletionToScore()
        CurrentScore = CurrentScore + CInt(100 * TimeRemaining * CurrentDifficulty * 1.5)
    End Sub

    ' Upon game completion, add a value to the current score based on time remaining and difficulty level
    Private Sub AddGameCompletionToScore()
        CurrentScore = CurrentScore + CInt(3000 * CurrentDifficulty)
    End Sub

    ' Called when game is over to check if the score is worthy for being on the highscore list, if the user wants to 
    Private Sub SaveToHighScore()
        If HMHighscore.IsScoreMakingHighscore(CurrentScore) Then
            HMHighscore.PromptUserForHighscore(CurrentScore)
        End If
    End Sub

    ' Resets game fully so that a new one may begin
    ' Public so that it may be called from the menu
    Public Sub ResetGame()
        CurrentScore = 0
        CurrentRound = 1
        ' Set number of rounds based on difficulty
        Select Case CurrentDifficulty
            Case DIFFICULTY_EASY
                NumberOfRounds = 5
            Case DIFFICULTY_MEDIUM
                NumberOfRounds = 8
            Case DIFFICULTY_HARD
                NumberOfRounds = 12
        End Select
        ResetRound()
    End Sub

    ' Resets all round state so that a new round may begin
    Private Sub ResetRound()
        Body.Reset() ' Pulls down the carcass from the gallow
        EnableAllLetters() ' Makes all letters clickable again
        Answer.Text = WordList.GetRandomWord() ' Pick a new word
        ' Set time remaining based on difficulty
        Select Case CurrentDifficulty
            Case DIFFICULTY_EASY
                TimeRemaining = 60
            Case DIFFICULTY_MEDIUM
                TimeRemaining = 40
            Case DIFFICULTY_HARD
                TimeRemaining = 20
        End Select
    End Sub

    ' Utility function calling Enable() on all HMLetter controls on the form
    Private Sub EnableAllLetters()
        For Each ctlControl In Me.Controls
            If TypeOf ctlControl Is HMLetter Then
                DirectCast(ctlControl, HMLetter).Enable()
            End If
        Next
    End Sub

    ' Keyboard handler dealing with selecting letters via the keyboard
    Private Sub frmGame_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        For Each Letter As HMLetter In Me.Letters
            If Letter.Text = CType(e.KeyChar, String).ToUpper() Then
                LetterClickHandler(Letter, New EventArgs)
            End If
        Next
    End Sub

    ' Game timer, constantly updating score board. If time runs out, you die.
    Private Sub timerGameTimer_Tick(sender As Object, e As EventArgs) Handles timerGameTimer.Tick
        TimeRemaining = TimeRemaining - timerGameTimer.Interval / 1000
        If TimeRemaining <= 0 Then
            ' Whoops, out of time :(
            lblTimeRemaining.Text = CStr(0)
            ' Add all remaining body parts to the gallow
            While Body.HasBodyPartsLeft()
                Body.AddNextBodyPartToGallow()
            End While
            ' ... and do the normal lost game routine
            CheckIfRoundIsLost()
            Exit Sub
        End If
        lblTimeRemaining.Text = FormatNumber(TimeRemaining, 2)
        lblScore.Text = CStr(CurrentScore)
        lblRound.Text = CurrentRound & "/" & NumberOfRounds
    End Sub

    ' Utility functions for handling game pausing used in various events and the menu
    Public Sub StopGame()
        timerGameTimer.Enabled = False
    End Sub

    Public Sub Pause()
        timerGameTimer.Enabled = False
        _IsPaused = True
    End Sub

    Public Sub Unpause()
        timerGameTimer.Enabled = True
        _IsPaused = False
    End Sub

    Public Function IsRunning() As Boolean
        Return timerGameTimer.Enabled = True
    End Function

    Public Function IsPaused() As Boolean
        Return _IsPaused
    End Function

    ' Pauses the game time whenever the game form is deactivated (this includes losing focus)
    Private Sub frmGame_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        If Me.IsPaused Then
            Me.Unpause()
        End If
    End Sub

    Private Sub frmGame_Deactivate(sender As Object, e As EventArgs) Handles MyBase.Deactivate
        If Me.IsRunning Then
            Me.Pause()
        End If
    End Sub
End Class
