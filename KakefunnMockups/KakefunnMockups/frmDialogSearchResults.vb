Public Class frmDialogSearchResults

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub dtgSearchResultsOrders_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgSearchResultsOrders.CellDoubleClick
        Dim order As Order = CType(dtgSearchResultsOrders.Rows(e.RowIndex).DataBoundItem, Order)
        OrderManager.EditOrder(order)
    End Sub

    Private Sub dtgSearchResultsCustomers_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgSearchResultsCustomers.CellDoubleClick
        Dim customer As Customer = CType(dtgSearchResultsCustomers.Rows(e.RowIndex).DataBoundItem, Customer)
        CustomerManager.EditCustomer(customer)
    End Sub

    Private Sub dtgSearchResultsCustomers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgSearchResultsCustomers.CellContentClick
        If dtgSearchResultsCustomers.Columns(e.ColumnIndex).Name = "dcCustomerEmail" Then
            Process.Start("mailto:" & dtgSearchResultsCustomers.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
        End If
    End Sub

    Private Sub dtgSearchResultsOrders_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dtgSearchResultsOrders.CellFormatting
        Select Case dtgSearchResultsOrders.Columns(e.ColumnIndex).Name
            Case "dcCustomer"
                Dim c As Customer = CType(e.Value, Customer)
                e.Value = c.firstName & " " & c.lastName
            Case "dcOrderPrice"
                Dim row As DataGridViewRow = dtgSearchResultsOrders.Rows(e.RowIndex)
                Dim o As Order = CType(row.DataBoundItem, Order)
                e.Value = OrderManager.GetOrderPrice(o)
        End Select
    End Sub
End Class
