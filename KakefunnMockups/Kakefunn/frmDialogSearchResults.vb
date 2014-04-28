''' <summary>
''' Dialog to display search results.
''' </summary>
''' <remarks></remarks>
Public Class frmDialogSearchResults

    ''' <summary>
    ''' Close search dialog.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    ''' <summary>
    ''' Opens order for editing on doubleclick.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub dtgSearchResultsOrders_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgSearchResultsOrders.CellDoubleClick
        Dim order As Order = CType(dtgSearchResultsOrders.Rows(e.RowIndex).DataBoundItem, Order)
        OrderHelper.EditOrder(order)
        Close()
    End Sub

    ''' <summary>
    ''' Opens customer object for editing on doubleclick.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub dtgSearchResultsCustomers_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgSearchResultsCustomers.CellDoubleClick
        Dim customer As Customer = CType(dtgSearchResultsCustomers.Rows(e.RowIndex).DataBoundItem, Customer)
        CustomerHelper.EditCustomer(customer)
        Close()
    End Sub

    ''' <summary>
    ''' Opens default email client on clicking an email address.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub dtgSearchResultsCustomers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgSearchResultsCustomers.CellContentClick
        If dtgSearchResultsCustomers.Columns(e.ColumnIndex).Name = "dcCustomerEmail" Then
            Process.Start("mailto:" & dtgSearchResultsCustomers.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
        End If
    End Sub

    ''' <summary>
    ''' Gets additional information from other tables thjan order in the db, 
    ''' and displays it in the order dgv.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub dtgSearchResultsOrders_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dtgSearchResultsOrders.CellFormatting
        Select Case dtgSearchResultsOrders.Columns(e.ColumnIndex).Name
            Case "dcCustomer"
                Dim c As Customer = CType(e.Value, Customer)
                e.Value = c.firstName & " " & c.lastName
            Case "dcOrderPrice"
                Dim row As DataGridViewRow = dtgSearchResultsOrders.Rows(e.RowIndex)
                Dim o As Order = CType(row.DataBoundItem, Order)
                e.Value = FormatHelper.Currency(OrderHelper.GetOrderPrice(o))
        End Select
    End Sub
End Class
