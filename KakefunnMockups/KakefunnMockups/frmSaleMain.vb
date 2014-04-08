Public Class frmSaleMain
    Inherits frmSaleBase

    Private Sub frmSaleMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DBM.Instance.Orders.OrderByDescending(Function(o) o.modified).Load()
        OrderBindingSource.DataSource = DBM.Instance.Orders.Local.Take(5).ToList()

        DBM.Instance.Customers.OrderByDescending(Function(c) c.modified).Load()
        CustomerBindingSource.DataSource = DBM.Instance.Customers.Local.Take(5).ToList()
    End Sub

    Private Sub dgvOrder_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvOrder.CellFormatting
        Select Case dgvOrder.Columns(e.ColumnIndex).Name
            Case "dcCustomerId"
                e.Value = CType(e.Value, Customer).id
            Case "dcCustomerName"
                e.Value = CType(e.Value, Customer).name
            Case "dcOrderAddress"
                Dim a As Address = CType(e.Value, Address)
                e.Value = a.address1 & ", " & a.Zip.zip1 & " " & a.Zip.city
            Case "dcOrderTotalPrice"
                Dim row As DataGridViewRow = dgvOrder.Rows(e.RowIndex)
                Dim o As Order = CType(row.DataBoundItem, Order)
                e.Value = OrderManager.GetOrderPrice(o)
        End Select
    End Sub

    Private Sub dgvCustomer_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvCustomer.CellFormatting
        Select Case dgvCustomer.Columns(e.ColumnIndex).Name
            Case "dcCustomerType"
                e.Value = CType(e.Value, CustomerType).name
        End Select
    End Sub

    Private Sub dgvCustomer_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCustomer.CellContentClick
        If dgvCustomer.Columns(e.ColumnIndex).Name = "dcCustomerEmail" Then
            Process.Start("mailto:" & dgvCustomer.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
        End If
    End Sub

    Private Sub btnNewOrder_Click(sender As Object, e As EventArgs) Handles btnNewOrder.Click
        OrderManager.NewOrder()
    End Sub

    Private Sub btnNewCustomer_Click(sender As Object, e As EventArgs) Handles btnNewCustomer.Click
        CustomerManager.NewCustomer()
    End Sub

    Private Sub dgvOrder_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOrder.CellDoubleClick
        Dim order As Order = CType(dgvOrder.Rows(e.RowIndex).DataBoundItem, Order)
        OrderManager.EditOrder(order)
    End Sub

    Private Sub dgvCustomer_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCustomer.CellDoubleClick
        Dim customer As Customer = CType(dgvCustomer.Rows(e.RowIndex).DataBoundItem, Customer)
        CustomerManager.EditCustomer(customer)
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

    End Sub
End Class
