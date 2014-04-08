Public Class frmSaleOrder

    Public Sub LoadOrder(order As Order)
        MsgBox("load order " & order.id)
    End Sub

    Public Sub NewOrder()
        MsgBox("new order")
    End Sub
End Class
