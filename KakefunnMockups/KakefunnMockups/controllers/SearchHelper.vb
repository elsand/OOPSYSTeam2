Public Class SearchHelper
    Public Shared Sub Search(query As String, searchOrders As Boolean, searchCustomers As Boolean)

        SessionManager.Instance.ShowDialog(frmDialogSearchResults)


        If Not searchOrders Then

        End If




    End Sub

    Public Shared Sub SearchCustomer(query As String)
        Search(query, False, True)
    End Sub

    Public Shared Sub SearchOrder(query As String)
        Search(query, True, False)
    End Sub
End Class
