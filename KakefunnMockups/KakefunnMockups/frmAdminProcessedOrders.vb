Public Class frmAdminProcessedOrders
    Dim orderBindingListView As BindingListView(Of Order)
    Private Sub frmAdminProcessedOrders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load data from orders and bind to datagridview
        DBM.Instance.Orders.Load()
        ' Make binding list view from the bindinglist we get from EF
        orderBindingListView = New BindingListView(Of Order)(DBM.Instance.Orders.Local.ToBindingList())
        ' Set it as the datasource, and presto, we have filtering et.al.
        OrderBindingSource.DataSource = orderBindingListView
    End Sub

    Private Sub dtgProcessedOrders_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dtgProcessedOrders.CellFormatting
        Select Case dtgProcessedOrders.Columns(e.ColumnIndex).Name
            Case "custID"
                e.Value = CType(e.Value, Customer).id
            Case "custName"
                Dim c As Customer = CType(e.Value, Customer)
                e.Value = c.firstName & " " & c.lastName
            Case "deliveryAddress"
                Dim a As Address = CType(e.Value, Address)
                e.Value = a.address1 & ", " & a.Zip.zip1 & " " & a.Zip.city
            Case "orderPrice"
                Dim row As DataGridViewRow = dtgProcessedOrders.Rows(e.RowIndex)
                Dim o As Order = CType(row.DataBoundItem, Order)
                e.Value = OrderManager.GetOrderPrice(o)
        End Select
    End Sub
End Class
