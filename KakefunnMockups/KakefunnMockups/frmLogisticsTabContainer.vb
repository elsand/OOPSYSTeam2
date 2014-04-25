Public Class frmLogisticsTabContainer

    Private Sub frmLogisticsTabContainer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateTabs(GetFormsForAspect("LOGISTICS"), tabLogistics)
    End Sub
End Class
