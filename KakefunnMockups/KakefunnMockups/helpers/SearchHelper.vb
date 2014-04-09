Public Class SearchHelper
    Public Shared Sub Search(query As String, searchOrders As Boolean, searchCustomers As Boolean)

        SessionManager.Instance.ShowDialog(frmDialogSearchResults)
        Dim numericQuery As Integer

        With frmDialogSearchResults
            .Text = "Søk etter """ & query & """"
            .grpSearchResults.Text = "Søkeresultater etter """ & query & """"
            .OrderBindingSource.DataSource = Nothing
            .CustomerBindingSource.DataSource = Nothing
            .lblHitsInOrders.Text = "0 treff i ordrer"
            .lblHitsInCustomers.Text = "0 treff i kunder"
        End With

        If searchOrders Then
            Dim orderQueryResult As List(Of Order)
            If Integer.TryParse(query, numericQuery) Then
                orderQueryResult = DBM.Instance.Orders.Where(Function(o) _
                    o.id = numericQuery _
                    Or o.deliveryPhone = numericQuery
                ).ToList()
            Else
                orderQueryResult = DBM.Instance.Orders.Where(Function(o) _
                    o.Customer.firstName.Contains(query) _
                    Or o.Customer.lastName.Contains(query) _
                    Or o.deliveryFirstName.Contains(query) _
                    Or o.deliveryLastName.Contains(query) _
                    Or o.deliveryEmail.Contains(query) _
                ).ToList()
            End If
            frmDialogSearchResults.OrderBindingSource.DataSource = orderQueryResult
            frmDialogSearchResults.lblHitsInOrders.Text = orderQueryResult.Count & " treff i ordrer"
        End If

        If searchCustomers Then
            Dim customerQueryResult As List(Of Customer)
            If Integer.TryParse(query, numericQuery) Then
                customerQueryResult = DBM.Instance.Customers.Where(Function(c) _
                    c.id = numericQuery _
                    Or c.phone = numericQuery _
                ).ToList()
            Else
                customerQueryResult = DBM.Instance.Customers.Where(Function(c) _
                    c.firstName.Contains(query) _
                    Or c.lastName.Contains(query) _
                    Or c.email.Contains(query) _
                ).ToList()
            End If
            frmDialogSearchResults.CustomerBindingSource.DataSource = customerQueryResult
            frmDialogSearchResults.lblHitsInCustomers.Text = customerQueryResult.Count & " treff i kunder"
        End If

    End Sub

    Public Shared Sub SearchCustomer(query As String)
        Search(query, False, True)
    End Sub

    Public Shared Sub SearchOrder(query As String)
        Search(query, True, False)
    End Sub
End Class
