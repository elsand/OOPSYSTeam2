
Public Class frmLogin

    Private Sub btnDoLogin_Click(sender As Object, e As EventArgs) Handles btnDoLogin.Click
        If txtEmail.Text = "" OrElse txtPassword.Text = "" Then
            MessageBox.Show("Du må oppgi e-post og passord", "Feil", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim origBtnText = btnDoLogin.Text
        btnDoLogin.Text = "Vennligst vent ..."
        btnDoLogin.Enabled = False
        txtEmail.Enabled = False
        txtPassword.Enabled = False

        Application.DoEvents() ' Needed for the above commands to be processed before MySQL/EF freezes our only thread :(

        Try
            SessionHelper.Instance.Login(txtEmail.Text, txtPassword.Text)
        Catch ex As Exception
            MessageBox.Show("Du oppga en ugyldig e-post og/eller passord", "Feil", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
        btnDoLogin.Text = origBtnText
        btnDoLogin.Enabled = True
        txtEmail.Enabled = True
        txtPassword.Enabled = True

        If SessionHelper.Instance.IsLoggedIn Then
            SessionHelper.Instance.ShowDefaultFormForLoggedInUser()
            Me.Hide()
        End If

    End Sub

    Private Sub loginForm_KeyPress(sender As Object, e As KeyEventArgs) Handles txtEmail.KeyDown, txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnDoLogin_Click(Me, New EventArgs())
        End If
    End Sub

    Protected Overrides Sub OnFormGetsForeground()
        txtEmail.Text = ""
        txtPassword.Text = ""
    End Sub

    Private Sub frmLogin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub
End Class
