Public Class frmSuperBase

    Public isDirty As Boolean = False

    Private Sub frmSuperBase_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        If Me.Visible Then
            frmSaleTabContainer.UpdateAspectMenu()
            frmAdminTabContainer.UpdateAspectMenu()
            frmLogisticsTabContainer.UpdateAspectMenu()
            UpdateLoginStatus()
            UpdateActionStatus()
            OnFormGetsForeground()
        End If
    End Sub

    Protected Overridable Sub OnFormGetsForeground()
        ' Implemented in subclasses
    End Sub


    Public Sub UpdateActionStatus(status As String)
        frmSaleTabContainer.statusAction.Text = status
        frmAdminTabContainer.statusAction.Text = status
        frmLogisticsTabContainer.statusAction.Text = status
        Application.DoEvents()
    End Sub

    Public Sub UpdateActionStatus()
        UpdateActionStatus("")
    End Sub

    Protected Sub UpdateLoginStatus()
        Dim statusText As String = ""
        If Not SessionHelper.Instance.IsLoggedIn Then
            statusText = "Ikke innlogget"
        Else

            Dim roles As String = ""
            For Each r In SessionHelper.Instance.User.Roles
                roles = roles & r.name & ", "
            Next
            roles = roles.Substring(0, roles.Length - 2)
            statusText = "Innlogget: " & SessionHelper.Instance.User.firstName & " " & SessionHelper.Instance.User.lastName & " (" & roles & ")"
        End If

        frmSaleTabContainer.statusLogin.Text = statusText
        frmAdminTabContainer.statusLogin.Text = statusText
        frmLogisticsTabContainer.statusLogin.Text = statusText
        Application.DoEvents()

    End Sub

End Class