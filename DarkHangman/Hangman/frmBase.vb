Imports System.Runtime.InteropServices
' Base form class which all forms extend from. This contains the menu and defines a common set of window properties.
Public Class frmBase
    ' Flag which is toggled when the first Form.Closing event is fired. This allows us to only run the close handler once.
    Private Shared IsClosing As Boolean = False

    Private IsDragging As Boolean = False, IsClick As Boolean = False
    Private StartPoint, FirstPoint, LastPoint As Point

    ' Common close handler for all forms.
    Private Sub frmBase_Closing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        ' To avoid running this for each and every form
        If IsClosing Then
            Return
        End If

        ' Pause the game if it is running
        If frmGame.IsRunning() Then
            frmGame.Pause()
        End If

        If MsgBox("Er du sikker på du vil avslutte?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Avslutt Hangman?") = MsgBoxResult.No Then
            ' The user declined, cancel the close event
            e.Cancel = True
            ' Unpause game if we paused it
            If frmGame.IsPaused() Then
                frmGame.Unpause()
            End If
        Else
            ' Toggle the closing flag to keep us from showing the dialog again
            ' then explictly close all other (hidden) forms by calling Application.Exit()
            IsClosing = True
            ' Save in-memory highscore list to file for persistance
            HMHighscore.SaveHighscoreToFile()

            Application.Exit()
        End If
    End Sub


    ' Since we have no borders, implement window movement by click-dragging the form it self
    ' This only partially works, because any control infront of the form will eat the event
    Public Sub Form_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown
        StartPoint = Me.PointToScreen(New Point(e.X, e.Y))
        FirstPoint = StartPoint
        IsDragging = True
    End Sub

    Public Sub Form_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
        If IsDragging Then
            Dim EndPoint As Point = Me.PointToScreen(New Point(e.X, e.Y))
            IsClick = False
            Me.Left += (EndPoint.X - StartPoint.X)
            Me.Top += (EndPoint.Y - StartPoint.Y)
            StartPoint = EndPoint
            LastPoint = EndPoint
        End If
    End Sub

    Public Sub Form_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseUp
        IsDragging = False
        If LastPoint = StartPoint Then
            IsClick = True
        Else
            IsClick = False
        End If
    End Sub

    ' For the close button. Triggers the Closing event handler
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub

    ' Pause the game if the menu is activated
    Private Sub mnuMain_MenuActivate(sender As Object, e As EventArgs) Handles mnuMain.MenuActivate
        If frmGame.IsRunning() Then
            frmGame.Pause()
        End If
        ' Update the state of the difficulty button. There probably is a better way to do this
        UpdateSelectedDifficultyMenuItem()
    End Sub

    Private Sub mnuMain_MenuDeactivate(sender As Object, e As EventArgs) Handles mnuMain.MenuDeactivate
        If frmGame.IsPaused() Then
            frmGame.Unpause()
        End If
    End Sub

    Private Sub mnuNewGame_Click(sender As Object, e As EventArgs) Handles mnuNewGame.Click
        If Not ConfirmResetOfRunningGame() Then
            Exit Sub
        End If
        ' Make sure the game is actually loaded and active
        If Not frmGame.Visible Then
            Me.Hide()
            frmGame.Show()
            frmGame.Focus()
        End If
        frmGame.ResetGame()
    End Sub

    Private Sub mnuExitGame_Click(sender As Object, e As EventArgs) Handles mnuExitGame.Click
        Application.Exit()
    End Sub

    Private Sub mnuDifficulty_Click(sender As Object, e As EventArgs) Handles mnuDifficultyEasy.Click, mnuDifficultyMedium.Click, mnuDifficultyHard.Click
        If Not ConfirmResetOfRunningGame() Then
            Exit Sub
        End If

        ' Find out which menu item was clicked
        Select Case DirectCast(sender, ToolStripMenuItem).Name
            Case "mnuDifficultyEasy"
                frmGame.CurrentDifficulty = frmGame.DIFFICULTY_EASY
            Case "mnuDifficultyMedium"
                frmGame.CurrentDifficulty = frmGame.DIFFICULTY_MEDIUM
            Case "mnuDifficultyHard"
                frmGame.CurrentDifficulty = frmGame.DIFFICULTY_HARD
        End Select

        ' Set the right one as checked
        UpdateSelectedDifficultyMenuItem()

        If frmGame.Visible Then
            frmGame.ResetGame()
        End If
    End Sub


    Private Sub mnuHighscoreShow_Click(sender As Object, e As EventArgs) Handles mnuHighscoreShow.Click
        If Not ConfirmResetOfRunningGame() Then
            Exit Sub
        End If

        Me.Hide()
        frmHighscore.Show()
        frmHighscore.Focus()
    End Sub

    Private Sub mnuHighscoreClear_Click(sender As Object, e As EventArgs) Handles mnuHighscoreClear.Click
        If MsgBox("Dette vil tømme highscorelisten. Vil du fortsette?",
                      MsgBoxStyle.YesNo Or MsgBoxStyle.Question) = MsgBoxResult.Yes Then
            HMHighscore.ClearHighscore()
        End If
    End Sub

    Private Sub mnuHelpShow_Click(sender As Object, e As EventArgs) Handles mnuHelpShow.Click
        ShowHelp()
    End Sub

    ' Utility functions
    Private Sub UpdateSelectedDifficultyMenuItem()
        mnuDifficultyEasy.Checked = frmGame.CurrentDifficulty = frmGame.DIFFICULTY_EASY
        mnuDifficultyMedium.Checked = frmGame.CurrentDifficulty = frmGame.DIFFICULTY_MEDIUM
        mnuDifficultyHard.Checked = frmGame.CurrentDifficulty = frmGame.DIFFICULTY_HARD
    End Sub

    ' Prompt the user if a game is currently in progress
    Protected Function ConfirmResetOfRunningGame() As Boolean
        If frmGame.Visible AndAlso _
            MsgBox("Dette vil avslutte det påbegynte spillet uten å lagre highscore. Vil du avslutte spillet?",
                      MsgBoxStyle.YesNo Or MsgBoxStyle.Question) = MsgBoxResult.No Then
            Return False
        End If
        Return True
    End Function

    Protected Sub ShowHelp()
        Dim helpFile As String = Application.StartupPath & "\Brukerhjelp.html"
        If System.IO.File.Exists(helpFile) Then
            Process.Start(helpFile)
        Else
            MsgBox("Finner ikke hjelpefilen!", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub mnuHelpAbout_Click(sender As Object, e As EventArgs) Handles mnuHelpAbout.Click
        frmAbout.Show()
    End Sub

    Private Sub mnuAudioToggle_Click(sender As Object, e As EventArgs) Handles mnuAudioToggle.Click
        HMAudio.ToggleAudio()
        If HMAudio.IsMuted Then
            mnuAudioToggle.Text = "&Slå på lyd"
        Else
            mnuAudioToggle.Text = "&Slå av lyd"
        End If
    End Sub
End Class