' Class handling the intro screen
Friend Class frmIntro

    ' Keep the current title opacity while fading in
    Dim titleOpacity As Double = 0
    ' Keep a copy of the title image with full opacity
    Dim titleImageFullOpacity As Image
    ' How long we should delay before starting the fade in of the title
    Dim titleImageFadeInDelay As Integer = 1000 ' milliseconds

    Private Sub btnStartGame_Click(sender As Object, e As EventArgs) Handles btnStartGame.Click
        Me.Hide()
        frmGame.Show()
        frmGame.Focus()
    End Sub

    ' This is where it all begins
    Private Sub frmIntro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Save a copy of the full opacity image
        titleImageFullOpacity = picTitle.Image
        ' Set initial opacity to 0
        picTitle.Image = HMImageUtils.SetImgOpacity(titleImageFullOpacity, 0)
        ' Start the timer which fades in the title image (interval is 16 ms, which is ~60fps)
        timerTitleFader.Enabled = True
        ' Load the sfx and start the background music
        HMAudio.LoadSounds()
        HMAudio.StartBackgroundMusic()
        ' Load highscore data
        HMHighscore.Init()

    End Sub

    Private Sub timerTitleFader_Tick(sender As Object, e As EventArgs) Handles timerTitleFader.Tick
        ' First check if we've waited long enough
        If titleImageFadeInDelay > 0 Then
            titleImageFadeInDelay = titleImageFadeInDelay - timerTitleFader.Interval
            Return
        End If
        ' Every so slightly increase the opacity
        titleOpacity = titleOpacity + 0.01
        picTitle.Image = HMImageUtils.SetImgOpacity(titleImageFullOpacity, titleOpacity)
        ' Kill ourselves once we're done to avoid spinning the CPU needlessly
        If titleOpacity >= 1 OrElse Me.Visible = False Then
            picTitle.Image = HMImageUtils.SetImgOpacity(titleImageFullOpacity, 1)
            timerTitleFader.Enabled = False
        End If
    End Sub

    Private Sub btnHighScore_Click(sender As Object, e As EventArgs) Handles btnHighScore.Click
        Me.Hide()
        frmHighscore.Show()
        frmHighscore.Focus()
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        ShowHelp()
    End Sub
End Class
