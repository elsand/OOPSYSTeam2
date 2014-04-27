Imports System.Text.RegularExpressions
Public Class EmailTextBox
    Inherits TextBox

    Protected Overrides Sub OnLostFocus(e As EventArgs)

        MyBase.OnLostFocus(e)
        If Not String.IsNullOrEmpty(Me.Text) Then
            If Me.EmailAddressChecker(Me.Text) Then
                Me.BackColor = Color.FromArgb(200, 255, 200)
                frmLogin.btnDoLogin.Enabled = True
            Else

                Me.BackColor = Color.FromArgb(255, 200, 200)
                frmLogin.btnDoLogin.Enabled = False
                MsgBox("Skriv inn en gyldig epostadresse.")
            End If
        End If



    End Sub

    Function EmailAddressChecker(ByVal emailAddress As String) As Boolean
        Dim r As Regex = Nothing

        Dim regExPattern As String = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$"


        If Regex.IsMatch(emailAddress, regExPattern) Then
            Return True
        Else
            Return False
        End If

    End Function

End Class
