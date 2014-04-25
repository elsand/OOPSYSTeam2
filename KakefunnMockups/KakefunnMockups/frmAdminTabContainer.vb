Public Class frmAdminTabContainer

    Private Sub frmAdminTabContainer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateTabs(GetFormsForAspect("ADMIN"), tabAdmin)
    End Sub
End Class
