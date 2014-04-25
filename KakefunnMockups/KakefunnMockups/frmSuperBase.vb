Public Class frmSuperBase

    Public isDirty As Boolean = False

    Private Sub frmSuperBase_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        If Me.Visible Then
            frmSuperTabContainer.UpdateAspectMenu()
            UpdateLoginStatus()
            UpdateActionStatus()
            OnFormGetsForeground()
        End If
    End Sub

    Protected Overridable Sub OnFormGetsForeground()
        ' Implemented in subclasses
    End Sub


    Public Sub UpdateActionStatus(status As String)
        frmSuperTabContainer.statusAction.Text = status
        Application.DoEvents()
    End Sub

    Public Sub UpdateActionStatus()
        UpdateActionStatus("")
    End Sub

    Protected Sub UpdateLoginStatus()
        If Not SessionHelper.Instance.IsLoggedIn Then
            frmSuperTabContainer.statusLogin.Text = "Ikke innlogget"
            Exit Sub
        End If
        Dim roles As String = ""
        For Each r In SessionHelper.Instance.User.Roles
            roles = roles & r.name & ", "
        Next
        roles = roles.Substring(0, roles.Length - 2)
        frmSuperTabContainer.statusLogin.Text = "Innlogget: " & SessionHelper.Instance.User.firstName & " " & SessionHelper.Instance.User.lastName & " (" & roles & ")"
    End Sub

End Class