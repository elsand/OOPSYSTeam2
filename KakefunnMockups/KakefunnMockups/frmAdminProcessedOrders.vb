Public Class frmAdminProcessedOrders
    Dim orderBindingListView As BindingListView(Of Order)
    Private Sub frmAdminProcessedOrders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load data from orders and bind to datagridview
        DBM.Instance.Orders.OrderByDescending(Function(o) o.modified).Load()
        OrderBindingSource.DataSource = DBM.Instance.Orders.Local.ToList()
    End Sub

    Private Sub dtgProcessedOrders_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dtgProcessedOrders.CellFormatting
           Select dtgProcessedOrders.Columns(e.ColumnIndex).Name
            Case "dcCustomerId"
                e.Value = CType(e.Value, Customer).id
            Case "dcCustomerName"
                Dim c As Customer = CType(e.Value, Customer)
                e.Value = c.firstName & " " & c.lastName
            Case "dcOrderAddress"
                Dim a As Address = CType(e.Value, Address)
                e.Value = a.address1 & ", " & a.Zip.zip1 & " " & a.Zip.city
            Case "dcOrderTotalPrice"
                Dim row As DataGridViewRow = dtgProcessedOrders.Rows(e.RowIndex)
                Dim o As Order = CType(row.DataBoundItem, Order)
                e.Value = OrderManager.GetOrderPrice(o)
        End Select
    End Sub
End Class
