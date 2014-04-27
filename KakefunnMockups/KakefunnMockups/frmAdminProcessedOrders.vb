Imports System.Xml
Imports System.IO

''' <summary>
''' This module exports orders to external economy system by creating an xml-file that can be distributed.
''' Last edited: 22.04.2014
''' </summary>
''' <remarks>
''' There is an issue with binding EF6 entities directly to the datagridview(dgv). Any updates to the database
''' is not caught by simply refreshing the dgv. The chosen workaround is to load selected contents from the 
''' database to a generic list of orders, and then bind that to the dgv. The problem with this approach is 
''' that sorting on columns is lost.
'''</remarks>
Public Class frmAdminProcessedOrders
    Private fileName As String = "KakeOrderExport_1_" & Date.Today & ".xml"

    ''' <summary>
    ''' Loading the form with selected data from the database.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub frmAdminProcessedOrders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        startUp()
    End Sub

    ''' <summary>
    ''' Load data from orders and bind to datagridview.
    ''' Disables the datagridview if no orders av available to be exported, this
    ''' prevents the user from selecting the empty row.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub startUp()
        Dim orderQuery = (From x In DBM.Instance.Orders _
                         Where Not x.exported.HasValue _
                         And x.isSubscriptionOrder = False _
                        Select x).ToList()
        OrderBindingSource.DataSource = orderQuery

        If OrderBindingSource.Count > 1 Then
            dtgProcessedOrders.Enabled = True
            rdoCheckAll.Enabled = True
            rdoCheckNone.Enabled = True
        Else
            dtgProcessedOrders.Enabled = False
            rdoCheckAll.Enabled = False
            rdoCheckNone.Enabled = False
        End If
    End Sub

    ''' <summary>
    ''' Cellformatting adds information from other tables than the order-table to the datagridview.
    ''' Also sets rows as selected when the checbox is ticked. See detailed comments in the sub.
    ''' </summary>
    ''' <remarks>
    ''' There is a problem with the row not getting the correct color when the checkbox is
    ''' ticked. The row is however selected and will be exported when pushing the export button.
    ''' </remarks>
    Private Sub dtgProcessedOrders_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dtgProcessedOrders.CellFormatting
        If e.Value IsNot Nothing Then
            Select Case dtgProcessedOrders.Columns(e.ColumnIndex).Name
                Case "dcCustomerId" 'Adds customer number to dgv.
                    e.Value = CType(e.Value, Customer).id
                Case "dcCustomerName" 'Adds customer name to datagridview.
                    Dim c As Customer = CType(e.Value, Customer)
                    e.Value = c.firstName & " " & c.lastName
                Case "dcOrderAddress" 'Adds customer address to datagridview.
                    Dim a As Address = CType(e.Value, Address)
                    e.Value = a.address1 & ", " & a.Zip.zip1.ToString("D4") & " " & a.Zip.city
                Case "dcOrderTotalPrice" 'Adds order total price to datagridview.
                    Dim row As DataGridViewRow = dtgProcessedOrders.Rows(e.RowIndex)
                    Dim o As Order = CType(row.DataBoundItem, Order)
                    e.Value = "kr. " & Format(OrderHelper.GetOrderPrice(o), "0.00")
            End Select
        End If

        'Sets row as selected when row checkbox is ticked.
        If dtgProcessedOrders.Columns(e.ColumnIndex).Name = "exported" Then
            Dim checked As DataGridViewCheckBoxCell = CType(dtgProcessedOrders(e.ColumnIndex, e.RowIndex), DataGridViewCheckBoxCell)
            If CBool(checked.Value) = True Then
                dtgProcessedOrders.Rows(e.RowIndex).Selected = True
            Else
                dtgProcessedOrders.Rows(e.RowIndex).Selected = False
            End If
        End If
    End Sub

    ''' <summary>
    ''' Creates xml-files from the selected rows. See detailed comments in the sub.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub btnTransferToBillingSystem_Click(sender As Object, e As EventArgs) Handles btnTransferToBillingSystem.Click
        If dtgProcessedOrders.SelectedRows.Count > 0 Then
            checkFileName()
            Dim i, j As Integer
            Dim exportedOrders As String = ""
            'Create XmlWriterSettings
            Dim settings As XmlWriterSettings = New XmlWriterSettings()
            settings.Indent = True

            'Create XmlWriter
            'File gets saved in program catalog.
            Using writer As XmlWriter = XmlWriter.Create(fileName)
                'Begin writing
                writer.WriteStartDocument()
                writer.WriteStartElement("Orders") 'XML Root
                'Loop over selected orders
                i = 0
                j = 0
                For Each row In dtgProcessedOrders.Rows
                    Dim orderID As Integer = dtgProcessedOrders.Rows(i).Cells(IdDataGridViewTextBoxColumn.Index).Value
                    If dtgProcessedOrders.Rows(i).Selected = True Then
                        'Getting som data
                        Dim selectedOrder = DBM.Instance.Orders.Find(orderID)
                        Dim ingredientsOnOrder = (From x In DBM.Instance.OrderLines Where x.Order.id = orderID _
                        Select x).ToList()
                        Dim totals As OrderTotals = OrderHelper.CalculateTotals(selectedOrder)

                        'Writing elements to xml.
                        writer.WriteStartElement("order")
                        writer.WriteElementString("orderID", selectedOrder.id.ToString())
                        writer.WriteElementString("customerID", selectedOrder.Customer.id.ToString())
                        writer.WriteElementString("invoiceName", selectedOrder.Customer.fullName.ToString())
                        writer.WriteElementString("invoiceAddress", selectedOrder.Customer.Address.address1.ToString())
                        writer.WriteElementString("invoiceZip", selectedOrder.Customer.Address.Zip.zip1.ToString("D4"))
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

                        'Updates exported-column with date and time.
                        selectedOrder.exported = DateTime.Now
                        exportedOrders &= orderID & ", "
                        j += 1 'Counts orders exported.
                    End If
                    i += 1
                Next
                writer.WriteEndElement()
                writer.WriteEndDocument()

                'Shows xml in web-browser, basically to show that something is happening.
                Process.Start(LocalSystemHelper.getDefaultBrowser(), fileName)
            End Using

            'Writes changes to db.
            Try
                DBM.Instance.SaveChanges()
            Catch ex As Entity.Validation.DbEntityValidationException
                MsgBox("Feil under oppdatering av database - " & ex.ToString)
            End Try

            KakefunnEvent.saveSystemEvent("Ordre-eksporter", "Eksporterte følgende ordre: " & exportedOrders)
            MsgBox("Eksporterte " & j & " ordre.")
            startUp()
        Else
            MsgBox("Ingen ordre er valgt")
        End If
    End Sub

    ''' <summary>
    ''' Radiobutton to select all orders in datagridview.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub rdoCheckAll_CheckedChanged(sender As Object, e As EventArgs) Handles rdoCheckAll.CheckedChanged
        Dim i As Integer
        For Each row In dtgProcessedOrders.Rows
            dtgProcessedOrders.Rows(i).Cells(exported.Index).Value = True
            i += 1
        Next
    End Sub

    ''' <summary>
    ''' Radiobutton to unselect all orders in datagridview.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub rdoCheckNone_CheckedChanged(sender As Object, e As EventArgs) Handles rdoCheckNone.CheckedChanged
        Dim i As Integer
        For Each row In dtgProcessedOrders.Rows
            dtgProcessedOrders.Rows(i).Cells(exported.Index).Value = False
            i += 1
        Next
    End Sub

    ''' <summary>
    ''' When clicking anywhere on a row in dgv, the order gets selected and the checkbox gets ticked.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub dtgProcessedOrders_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgProcessedOrders.CellClick
        Dim checked As DataGridViewCheckBoxCell
        If e.RowIndex >= 0 Then
            checked = CType(dtgProcessedOrders.Rows(e.RowIndex).Cells(exported.Index), DataGridViewCheckBoxCell)
            If CBool(checked.Value) = True Then
                dtgProcessedOrders.Rows(e.RowIndex).Cells(exported.Index).Value = False
            Else
                dtgProcessedOrders.Rows(e.RowIndex).Cells(exported.Index).Value = True
            End If
        End If
    End Sub

    ''' <summary>
    ''' Opens order for editing on doubleclick in the dgv.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub dtgProcessedOrders_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgProcessedOrders.CellDoubleClick
        If e.RowIndex >= 0 Then
            If dtgProcessedOrders.Rows(e.RowIndex).Cells(sent.Index).Value IsNot Nothing Then
                MsgBox("Du kan ikke redigere en sendt ordre. Ordren åpnes skrivebeskyttet.", _
                       MsgBoxStyle.Information, "Informasjon")
            End If
            Dim orderNr As Integer = CInt(dtgProcessedOrders.Rows(e.RowIndex).Cells(IdDataGridViewTextBoxColumn.Index).Value)
            Dim order = DBM.Instance.Orders.Find(orderNr)
            OrderHelper.EditOrder(order, Me)
        End If
    End Sub

    ''' <summary>
    ''' Opens report viewer with a list of unexported orders.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub btnPrintProcessedOrders_Click(sender As Object, e As EventArgs) Handles btnPrintProcessedOrders.Click
        If OrderBindingSource.Count > 1 Then
            frmDialogAdminNotExported.ShowDialog()
        Else
            MsgBox("Det er ingen ordre å vise")
        End If

    End Sub

    ''' <summary>
    ''' Checks if filename exists before writing xml-file to hdd.
    ''' If the file exists, increments file number by one.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub checkFileName()
        Dim i As Integer = 0
        While File.Exists(fileName)
            i += 1
            fileName = "KakeOrderExport_" & i & "_" & Date.Today & ".xml"
        End While
    End Sub

    ''' <summary>
    ''' Runs startUp subroutine to check for changes to the database.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub btnUpdateList_Click(sender As Object, e As EventArgs) Handles btnUpdateList.Click
        startUp()
    End Sub
End Class
