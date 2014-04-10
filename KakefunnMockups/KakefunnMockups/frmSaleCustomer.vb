Public Class frmSaleCustomer

    Public returnToFormAfterSave As Form

    Public Sub LoadCustomer(customer As Customer)
        MsgBox("load customer " & customer.id)
    End Sub

    Public Sub NewCustomer()
        MsgBox("new customer")
    End Sub

End Class
