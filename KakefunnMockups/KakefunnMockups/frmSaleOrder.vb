Public Class frmSaleOrder

    Public Sub LoadOrder(order As Order)
        MsgBox("load order " & order.id)
    End Sub

    Public Sub NewOrder()
        MsgBox("new order")
    End Sub

    Private Sub btnNewCustomer_Click(sender As Object, e As EventArgs) Handles btnNewCustomer.Click
        CustomerManager.NewCustomerAndReturnTo(Me)
    End Sub

    Private Sub frmSaleOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set up autocomplete
        ' Dim ac As AutoCompleteHelper = New AutoCompleteHelper(DBM.Instance.SqlToArray(")


    End Sub
End Class
