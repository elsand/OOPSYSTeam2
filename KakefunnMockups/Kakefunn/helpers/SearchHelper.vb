''' <summary>
''' Helper class for dealing with searches
''' </summary>
''' <remarks></remarks>
Public Class SearchHelper
    ''' <summary>
    ''' Free text search for orders and/or customers
    ''' </summary>
    ''' <param name="query"></param>
    ''' <param name="searchOrders"></param>
    ''' <param name="searchCustomers"></param>
    ''' <remarks></remarks>
    Public Shared Sub SearchFreeText(query As String, searchOrders As Boolean, searchCustomers As Boolean)

        ' Set up and show the search results dialog
        SessionHelper.Instance.ShowDialog(frmDialogSearchResults)
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
            ' If numeric query, assume either ID or phonenumner
            ' if alphanum, search for customer/delivery name and email
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
            ' If numeric query, assume either ID or phonenumner
            ' if alphanum, search for  name and email
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

    ''' <summary>
    ''' Search for orders given the supplied predicate (Linq)
    ''' </summary>
    ''' <param name="predicate"></param>
    ''' <remarks></remarks>
    Public Shared Sub SearchOrders(predicate As System.Func(Of Order, Boolean))

        SessionHelper.Instance.ShowDialog(frmDialogSearchResults)

        Dim orderQueryResult As List(Of Order)
        orderQueryResult = DBM.Instance.Orders.Where(predicate).ToList()
        With frmDialogSearchResults
            .Text = "Søk etter ordrer"
            .grpSearchResults.Text = "Søkeresultat"

            .dtgSearchResultsOrders.Enabled = True
            .OrderBindingSource.DataSource = orderQueryResult
            .lblHitsInOrders.Text = orderQueryResult.Count & " treff i ordrer"

            .CustomerBindingSource.DataSource = Nothing
            .lblHitsInCustomers.Text = ""
            .dtgSearchResultsCustomers.Enabled = False

        End With
    End Sub
End Class
