Public Class frmAdminProcessedOrders
    Private Sub frmAdminProcessedOrders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load data from orders and bind to datagridview
        DBM.Instance.Orders.Where(Function(o) Not o.exported.HasValue).Load()
        OrderBindingSource.DataSource = DBM.Instance.Orders.Local.ToBindingList()
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

        If dtgProcessedOrders.Columns(e.ColumnIndex).Name = "exported" Then
            Dim checked As DataGridViewCheckBoxCell = CType(dtgProcessedOrders(e.ColumnIndex, e.RowIndex), DataGridViewCheckBoxCell)
            If CBool(checked.Value) = True Then
                dtgProcessedOrders.Rows(e.RowIndex).Selected = True
            Else
                dtgProcessedOrders.Rows(e.RowIndex).Selected = False
            End If
        End If
    End Sub

    Private Sub btnTransferToBillingSystem_Click(sender As Object, e As EventArgs) Handles btnTransferToBillingSystem.Click
        'Create simple xml-file.
    End Sub

    Private Sub rdoCheckAll_CheckedChanged(sender As Object, e As EventArgs) Handles rdoCheckAll.CheckedChanged
        Dim i As Integer
        For Each row In dtgProcessedOrders.Rows
            dtgProcessedOrders.Rows(i).Cells(0).Value = True
            i += 1
        Next
    End Sub

    Private Sub rdoCheckNone_CheckedChanged(sender As Object, e As EventArgs) Handles rdoCheckNone.CheckedChanged
        Dim i As Integer
        For Each row In dtgProcessedOrders.Rows
            dtgProcessedOrders.Rows(i).Cells(0).Value = False
            i += 1
        Next
    End Sub

    Private Sub dtgProcessedOrders_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgProcessedOrders.CellClick
        Dim checked As DataGridViewCheckBoxCell = CType(dtgProcessedOrders.Rows(e.RowIndex).Cells(0), DataGridViewCheckBoxCell)
        If CBool(checked.Value) = True Then
            dtgProcessedOrders.Rows(e.RowIndex).Cells(0).Value = False
        Else
            dtgProcessedOrders.Rows(e.RowIndex).Cells(0).Value = True
        End If
    End Sub


    Private Sub dtgProcessedOrders_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgProcessedOrders.CellDoubleClick
        'Opens order for editing on doubleclick in the dgv.
        Dim orderNr As Integer = CInt(dtgProcessedOrders.Rows(e.RowIndex).Cells(Me.IdDataGridViewTextBoxColumn.Index).Value)
        Dim order = DBM.Instance.Orders.Find(orderNr)
        OrderManager.EditOrder(order)
    End Sub

    Private Sub btnPrintProcessedOrders_Click(sender As Object, e As EventArgs) Handles btnPrintProcessedOrders.Click
        'Create report.
    End Sub
End Class
