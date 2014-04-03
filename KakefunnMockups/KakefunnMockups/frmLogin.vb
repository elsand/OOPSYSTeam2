
Public Class frmLogin

    Private Sub btnDoLogin_Click(sender As Object, e As EventArgs) Handles btnDoLogin.Click
        If txtEmail.Text = "" OrElse txtPassword.Text = "" Then
            MsgBox("Du må oppgi e-post og passord")
            Exit Sub
        End If
        Try
            SessionManager.Instance.Login(txtEmail.Text, txtPassword.Text)
        Catch ex As Exception
            MsgBox("Du oppga en ugyldig e-post og/eller passord")
            Exit Sub
        End Try

        SessionManager.Instance.ShowDefaultFormForLoggedInUser()

    End Sub
End Class
