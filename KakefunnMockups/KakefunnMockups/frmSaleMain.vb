Public Class frmSaleMain
    Inherits frmSaleBase

    Private Sub frmSaleMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DBM.Instance.Orders.Load()
        ' OrderBindingSource.DataSource = DBM.Instance.orders.Local.ToBindingList()
    End Sub

End Class
