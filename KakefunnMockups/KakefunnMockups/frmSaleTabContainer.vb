Public Class frmSaleTabContainer

    Private Sub frmSaleTabContainer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateTabs(GetFormsForAspect("SALE"), tabSale)
    End Sub
End Class
