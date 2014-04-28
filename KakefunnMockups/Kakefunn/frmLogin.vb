''' <summary>
''' Handles login of the users
''' </summary>
''' <remarks></remarks>
Public Class frmLogin

    ''' <summary>
    ''' Handles the button being clicked or enter being pressed in either forms
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnDoLogin_Click(sender As Object, e As EventArgs) Handles btnDoLogin.Click
        If txtEmail2.Text = "" OrElse txtPassword.Text = "" Then
            MessageBox.Show("Du må oppgi e-post og passord", "Feil", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        ' As the database roundtrip and opening of the next form might take some time, 
        ' disable the fields and show a please wait message
        Dim origBtnText = btnDoLogin.Text
        btnDoLogin.Text = "Vennligst vent ..."
        btnDoLogin.Enabled = False
        txtEmail2.Enabled = False
        txtPassword.Enabled = False

        Application.DoEvents() ' Needed for the above commands to be processed before MySQL/EF freezes our only thread :(

        Try
            SessionHelper.Instance.Login(txtEmail2.Text, txtPassword.Text)
        Catch ex As Exception
            MessageBox.Show("Du oppga en ugyldig e-post og/eller passord", "Feil", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            KakefunnEvent.saveSystemEvent("Innlogging", "Innlogging feilet for bruker: " & txtEmail2.Text)
        End Try

        ' Login successful, open the default form for this user and hide the login windows
        If SessionHelper.Instance.IsLoggedIn Then
            SessionHelper.Instance.ShowDefaultFormForLoggedInUser()
            Me.Hide()
            KakefunnEvent.saveSystemEvent("Innlogging", "Vellykket innlogging for bruker: " & txtEmail2.Text)
        End If

        btnDoLogin.Text = origBtnText
        btnDoLogin.Enabled = True
        txtEmail2.Enabled = True
        txtPassword.Enabled = True

    End Sub

    ''' <summary>
    ''' Handles enter being pressed in either email or password fields
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub loginForm_KeyPress(sender As Object, e As KeyEventArgs) Handles txtEmail2.KeyDown, txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnDoLogin_Click(Me, New EventArgs())
        End If
    End Sub

    ''' <summary>
    ''' If we logout and we get focus again, reset the fields and set focus to the email field
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub OnFormGetsForeground()
        txtEmail2.Text = ""
        txtPassword.Text = ""
        txtEmail2.Focus()
    End Sub

    ''' <summary>
    ''' Handle the login window being closed. No prompt, as this form is always on its own.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub frmLogin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    
    
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtEmail2.Focus()

    End Sub
End Class
