''' <summary>
''' Start page for sales personell for easy access to recent orders/customers and a search interface
''' </summary>
''' <remarks></remarks>
Public Class frmSaleMain
    Inherits frmSaleBase

    ''' <summary>
    ''' Init the form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub frmSaleMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OnFormGetsForeground()
    End Sub

    ''' <summary>
    ''' We reload this every time this for gets re-focused since we're not able to get a binding list
    ''' </summary>
    ''' <remarks></remarks>
    Protected Overrides Sub OnFormGetsForeground()
        OrderBindingSource.DataSource = DBM.Instance.Orders.OrderByDescending(Function(o) o.modified).Take(5).ToList()
        CustomerBindingSource.DataSource = DBM.Instance.Customers.OrderByDescending(Function(c) c.modified).Take(5).ToList()
        txtSearchInformation.Focus()
    End Sub

    ''' <summary>
    ''' Handle formatting of columns in the order list
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub dgvOrder_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvOrder.CellFormatting
        Select Case dgvOrder.Columns(e.ColumnIndex).Name
            Case "dcCustomerId"
                ' Show customer id
                e.Value = CType(e.Value, Customer).id
            Case "dcCustomerName"
                ' Show full name
                Dim c As Customer = CType(e.Value, Customer)
                e.Value = c.firstName & " " & c.lastName
            Case "dcOrderAddress"
                ' Show address concated with zip and city
                Dim a As Address = CType(e.Value, Address)
                e.Value = a.address1 & ", " & a.Zip.zip1 & " " & a.Zip.city
            Case "dcOrderTotalPrice"
                ' Find total price for this order
                Dim row As DataGridViewRow = dgvOrder.Rows(e.RowIndex)
                Dim o As Order = CType(row.DataBoundItem, Order)
                e.Value = FormatHelper.Currency(OrderManager.GetOrderPrice(o))
        End Select
    End Sub

    ''' <summary>
    ''' Handle formatting of columns in the customer list
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub dgvCustomer_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvCustomer.CellFormatting
        Select Case dgvCustomer.Columns(e.ColumnIndex).Name
            Case "dcCustomerType"
                ' Show customer type name, usually "Privat" or "Firma"
                e.Value = CType(e.Value, CustomerType).name
        End Select
    End Sub

    ''' <summary>
    ''' Handle clicks on e-mail addresses, invokes default mailto: handler
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub dgvCustomer_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCustomer.CellContentClick
        If dgvCustomer.Columns(e.ColumnIndex).Name = "dcCustomerEmail" Then
            Process.Start("mailto:" & dgvCustomer.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
        End If
    End Sub

    ''' <summary>
    ''' Create a new order
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnNewOrder_Click(sender As Object, e As EventArgs) Handles btnNewOrder.Click
        OrderManager.NewOrder()
    End Sub

    ''' <summary>
    ''' Create a new customer
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnNewCustomer_Click(sender As Object, e As EventArgs) Handles btnNewCustomer.Click
        CustomerManager.NewCustomer()
    End Sub

    ''' <summary>
    ''' Edit an existing order
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub dgvOrder_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOrder.CellDoubleClick
        Dim order As Order = CType(dgvOrder.Rows(e.RowIndex).DataBoundItem, Order)
        OrderManager.EditOrder(order)
    End Sub

    ''' <summary>
    ''' Edit an existing customer
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub dgvCustomer_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCustomer.CellDoubleClick
        Dim customer As Customer = CType(dgvCustomer.Rows(e.RowIndex).DataBoundItem, Customer)
        CustomerManager.EditCustomer(customer)
    End Sub

    ''' <summary>
    ''' Handle search
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If txtSearchInformation.Text = "" Then
            MsgBox("Du må oppgi et søkeord")
            Exit Sub
        End If
        UpdateActionStatus("Søker ...")
        SearchHelper.SearchFreeText(txtSearchInformation.Text, True, True)
        UpdateActionStatus()
    End Sub

    ''' <summary>
    ''' Select all text when entering the search box for easy replacement
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub txtSearchInformation_Enter(sender As Object, e As EventArgs) Handles txtSearchInformation.Click
        txtSearchInformation.SelectAll()
    End Sub
End Class
