Public Class frmAdminTabContainer
    ''' <summary>
    ''' Displays forms for the administrator role in the tab container.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub frmAdminTabContainer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateTabs(GetFormsForAspect("ADMIN"), tabAdmin)
    End Sub
End Class
