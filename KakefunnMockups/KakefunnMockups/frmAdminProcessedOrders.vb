'Exports orders to external economy system.
'Writes XML-file to hdd, no further export atm.
'Last edited: 16.04.2014
'Issue: dgv is not able to get changes in db without reloading program.

Imports System.Xml
Imports System.IO
Public Class frmAdminProcessedOrders
    Private originalFileName As String = "KakeOrderExport_1_" & Date.Today & ".xml"
    Private newFileName As String = originalFileName

    Private Sub frmAdminProcessedOrders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadBindingSource()
    End Sub

    Private Sub loadBindingSource()
        ' Load data from orders and bind to datagridview
        DBM.Instance.Orders.Load()
        OrderBindingSource.DataSource = DBM.Instance.Orders.Local.ToBindingList().Where(Function(o) Not o.exported.HasValue)
    End Sub

    Private Sub dtgProcessedOrders_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dtgProcessedOrders.CellFormatting
        Select Case dtgProcessedOrders.Columns(e.ColumnIndex).Name
            Case "dcCustomerId" 'Adds customer number to dgv.
                e.Value = CType(e.Value, Customer).id
            Case "dcCustomerName" 'Adds customer name to datagridview.
                Dim c As Customer = CType(e.Value, Customer)
                e.Value = c.firstName & " " & c.lastName
            Case "dcOrderAddress" 'Adds customer address to datagridview.
                Dim a As Address = CType(e.Value, Address)
                e.Value = a.address1 & ", " & a.Zip.zip1 & " " & a.Zip.city
            Case "dcOrderTotalPrice" 'Adds order total price to datagridview.
                Dim row As DataGridViewRow = dtgProcessedOrders.Rows(e.RowIndex)
                Dim o As Order = CType(row.DataBoundItem, Order)
                e.Value = OrderManager.GetOrderPrice(o)
        End Select

        'Sets row as selected when row checkbox is ticked.
        'The graphics are a litt glitchy, but the ticked lines are selected.
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
        If dtgProcessedOrders.SelectedRows.Count > 0 Then
            checkFileName()
            Dim i, j As Integer
            'Create XmlWriterSettings
            Dim settings As XmlWriterSettings = New XmlWriterSettings()
            settings.Indent = True

            'Create XmlWriter
            Using writer As XmlWriter = XmlWriter.Create(newFileName)
                'Begin writing
                writer.WriteStartDocument()
                writer.WriteStartElement("Orders") 'XML Root
                'Loop over selected orders
                i = 0
                j = 0
                For Each row In dtgProcessedOrders.Rows
                    Dim orderID As Integer = dtgProcessedOrders.Rows(i).Cells(2).Value
                    If dtgProcessedOrders.Rows(i).Selected = True Then
                        'Getting som data
                        Dim selectedOrder = DBM.Instance.Orders.Find(orderID)
                        Dim ingredientsOnOrder = (From x In DBM.Instance.OrderLines Where x.Order.id = orderID _
                        Select x).ToList()
                        Dim totals As OrderTotals = OrderManager.CalculateTotals(selectedOrder)

                        'Writing elements to xml.
                        writer.WriteStartElement("order")
                        writer.WriteElementString("orderID", selectedOrder.id.ToString())
                        writer.WriteElementString("customerID", selectedOrder.Customer.id.ToString())
                        writer.WriteElementString("invoiceName", selectedOrder.Customer.fullName.ToString())
                        writer.WriteElementString("invoiceAddress", selectedOrder.Customer.Address.address1.ToString())
                        writer.WriteElementString("invoiceZip", selectedOrder.Customer.Address.Zip.zip1.ToString())
                        writer.WriteElementString("invoiceCity", selectedOrder.Customer.Address.Zip.city.ToString())
                        writer.WriteStartElement("articles")
                        For Each ingRow In ingredientsOnOrder
                            writer.WriteStartElement("article")
                            writer.WriteElementString("artNo", ingRow.Ingredient.id.ToString())
                            writer.WriteElementString("artName", ingRow.Ingredient.name.ToString())
                            writer.WriteElementString("artAmount", ingRow.amount.ToString())
                            writer.WriteElementString("artPrice", ingRow.totalPrice.ToString())
                            writer.WriteEndElement()
                        Next
                        writer.WriteEndElement()
                        writer.WriteStartElement("sums")
                        writer.WriteElementString("sumTotalExVat", totals.totalPriceExVat)
                        writer.WriteElementString("sumShipping", totals.shipping)
                        writer.WriteElementString("sumDiscount", totals.totalDiscount)
                        writer.WriteElementString("sumVat", totals.totalVat)
                        writer.WriteElementString("sumTotal", totals.totalToPay)
                        writer.WriteEndElement()
                        writer.WriteEndElement()

                        'Updates exported-column in db.
                        selectedOrder.exported = DateTime.Now
                        j += 1 'Counts orders exported.
                    End If
                    i += 1

                Next
                writer.WriteEndElement()
                writer.WriteEndDocument()
            End Using

            'Writes changes to db.
            Try
                DBM.Instance.SaveChanges()
            Catch ex As Entity.Validation.DbEntityValidationException
                MsgBox(ex)
            End Try
            MsgBox("Eksporterte " & j & " ordre.")
            loadBindingSource()
        Else
            MsgBox("Ingen ordre er valgt")
        End If
    End Sub

    Private Sub rdoCheckAll_CheckedChanged(sender As Object, e As EventArgs) Handles rdoCheckAll.CheckedChanged
        'Selects all order lines in dgv.
        Dim i As Integer
        For Each row In dtgProcessedOrders.Rows
            dtgProcessedOrders.Rows(i).Cells(0).Value = True
            i += 1
        Next
    End Sub

    Private Sub rdoCheckNone_CheckedChanged(sender As Object, e As EventArgs) Handles rdoCheckNone.CheckedChanged
        'Unselects alle order lines in dgv.
        Dim i As Integer
        For Each row In dtgProcessedOrders.Rows
            dtgProcessedOrders.Rows(i).Cells(0).Value = False
            i += 1
        Next
    End Sub

    Private Sub dtgProcessedOrders_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgProcessedOrders.CellClick
        'When clicking anywhere on a row in dgv, the order gets selected and the checkbox gets ticked.
        Dim checked As DataGridViewCheckBoxCell
        If e.RowIndex < 0 Then
            MsgBox(e.RowIndex)
        Else
            checked = CType(dtgProcessedOrders.Rows(e.RowIndex).Cells(0), DataGridViewCheckBoxCell)
            If CBool(checked.Value) = True Then
                dtgProcessedOrders.Rows(e.RowIndex).Cells(0).Value = False
            Else
                dtgProcessedOrders.Rows(e.RowIndex).Cells(0).Value = True
            End If
        End If
    End Sub


    Private Sub dtgProcessedOrders_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgProcessedOrders.CellDoubleClick
        'Opens order for editing on doubleclick in the dgv.
        Dim orderNr As Integer = CInt(dtgProcessedOrders.Rows(e.RowIndex).Cells(Me.IdDataGridViewTextBoxColumn.Index).Value)
        Dim order = DBM.Instance.Orders.Find(orderNr)
        OrderManager.EditOrder(order)
    End Sub

    Private Sub btnPrintProcessedOrders_Click(sender As Object, e As EventArgs) Handles btnPrintProcessedOrders.Click
        'Opens internal report for processed orders.
        frmDialogAdminNotExported.ShowDialog()
    End Sub

    Private Sub checkFileName()
        'Checks if filename exists before writing xml-file to hdd.
        Dim i As Integer = 0
        While File.Exists(newFileName)
            i += 1
            newFileName = "KakeOrderExport_" & i & "_" & Date.Today & ".xml"
            MsgBox(newFileName)
        End While
    End Sub

    Private Sub btnUpdateList_Click(sender As Object, e As EventArgs) Handles btnUpdateList.Click
        'Not working. Can't seem to get changes in db without restarting the program.
        loadBindingSource()
    End Sub
End Class
