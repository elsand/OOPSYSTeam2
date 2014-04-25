''' <summary>
''' Base form from which all forms inside tabs inherit
''' </summary>
''' <remarks></remarks>
Public Class frmSuperBase

    ''' <summary>
    ''' Used for tracking dirty state in forms
    ''' </summary>
    ''' <remarks></remarks>
    Public isDirty As Boolean = False

    ''' <summary>
    ''' Used whenever a tab is changed, updates the menu and sets login status. Also clears action status and calls the OnFormGetsForeground() method
    ''' which may be overridden in inheriting forms
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub frmSuperBase_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        If Me.Visible Then
            ' All three windows may be open at the same time, so update them all
            frmSaleTabContainer.UpdateAspectMenu()
            frmAdminTabContainer.UpdateAspectMenu()
            frmLogisticsTabContainer.UpdateAspectMenu()
            UpdateLoginStatus()
            UpdateActionStatus()
            OnFormGetsForeground()
        End If
    End Sub

    ''' <summary>
    ''' Like a form_load, but called everytime the form gets loaded
    ''' </summary>
    ''' <remarks></remarks>
    Protected Overridable Sub OnFormGetsForeground()
        ' Implemented in subclasses
    End Sub

    ''' <summary>
    ''' Used by inheriting forms to set the action status for the form of which it is contained
    ''' </summary>
    ''' <param name="status"></param>
    ''' <remarks></remarks>
    Public Sub UpdateActionStatus(status As String)
        With frmSuperTabContainer
            CType(.GetContainerForAspect(.GetAspectForForm(Me)), frmSuperTabContainer).statusAction.Text = status
        End With
        Application.DoEvents()
    End Sub

    ''' <summary>
    ''' Overload that clears the action status
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub UpdateActionStatus()
        UpdateActionStatus("")
    End Sub

    ''' <summary>
    ''' Sets the login status for all open windows. Displays the full name of the logged in employee and his/her roles.
    ''' </summary>
    ''' <remarks></remarks>
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