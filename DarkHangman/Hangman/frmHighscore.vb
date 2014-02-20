' Import to get the HighscoreEntry structure
Imports Hangman.HMHighscoreSerializable
' Class for dealing with the highscore form
Friend Class frmHighscore

    ' Set a semi-transparent background-color to ensure white text being readable
    Private Sub frmHighscore_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        panelBackground.BackColor = Color.FromArgb(200, Color.Black)
    End Sub

    ' Button returning us to the main page
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        frmIntro.Show()
        frmIntro.Focus()
    End Sub

    ' Whenever we get shown, set the labels again
    Private Sub frmHighscore_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        PopulateHighscoreList()
    End Sub

    ' We use multiline labels instead of the more obvious listbox-choice because the latter
    ' does not support a transparent background. This approach, while a bit cumbersome, 
    ' offers decent layout flexibility. Public so that it may be called from the menuhandler after clearing highscore
    Public Sub PopulateHighscoreList()
        Dim position As Integer

        ' Reset the list        
        lblScores.Text = ""
        lblNames.Text = ""
        lblPosition.Text = ""
        lblTimestamp.Text = ""
        position = 0
        ' Iterate the sorted highscore list and add each entry pair to the two labels
        For Each he As HighscoreEntry In HMHighscore.Highscore.Entries
            position = position + 1
            lblPosition.Text = lblPosition.Text & position & "." & vbCrLf
            lblScores.Text = lblScores.Text & he.Score & vbCrLf
            lblNames.Text = lblNames.Text & he.Name & vbCrLf
            ' Hardcoded date format, but using current culture. Will be a bit unusual on eg. US culture. We don't care about time zones.
            lblTimestamp.Text = lblTimestamp.Text & he.Timestamp.ToString("d. MMM yyyy HH:mm", System.Globalization.CultureInfo.CurrentCulture) & vbCrLf
        Next
    End Sub

End Class
