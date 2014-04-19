﻿Public Class frmLogisticsPackingList

    Private deliveryDate As Date



    Private Sub frmLogisticsPackingList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

       



        start()



    End Sub

    Private Sub start()

        'sets the correct date  on label and datetime picker.. 
        Me.lblOrdersToEnvoyDate.Text = "Ordrer til utsending " & Format(DateTime.Now, "yyyy-MM-dd")
        If Me.deliveryDate = Nothing Then
            dtpPackingList.Value = Date.Now
            Me.deliveryDate = Date.Now
        End If



        'load the orders
        DBM.Instance.Orders.Load()




        'find the orders that is not sent and deliverydate is today.... . 
        OrderBindingSource.DataSource = DBM.Instance.Orders.Local.ToBindingList().Where(Function(o) o.deliveryDate.CompareTo(Me.deliveryDate) <= 0)


        System.Console.WriteLine("Antall rader: " & OrderBindingSource.Count)



        If OrderBindingSource.Count > 1 Then

            dtgPackingList.Enabled = True

            dtgPackingList.DataSource = OrderBindingSource


        End If

        dtgPackingList.Refresh()


    End Sub




    
    Private Sub dtgPackingList_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dtgPackingList.CellFormatting

        If e.Value IsNot Nothing Then
            Select Case dtgPackingList.Columns(e.ColumnIndex).Name
                Case "cnOrderId" 'add orderID to the dgv

                    e.Value = e.Value

                Case "cnDeliveryTo" 'add name to the dgv
                    Dim c = CType(e.Value, Customer)
                    e.Value = NameHelper.getFullName(c)


                Case "cnAddress" 'add address
                    Dim a = CType(e.Value, Address)
                    System.Console.WriteLine(a.ToString)

                    e.Value = a.address1



                Case "cnZip" 'add orderID to the dgv
                    e.Value = CType(e.Value, Address).Zip.zip1


                Case "cnStatus" 'add orderID to the dgv
                   
                        e.Value = "Sendt"
                   


            End Select
        End If

        If e.Value Is Nothing Then
            If e.ColumnIndex = 4 Then
                e.Value = "Ikke sendt"
            End If
        End If
        

    End Sub

    
    Private Sub btnMarkUnsent_Click(sender As Object, e As EventArgs) Handles btnMarkUnsent.Click

        For Each row As DataGridViewRow In dtgPackingList.Rows
            row.Selected = False

            Dim o As Order
            o = row.DataBoundItem
            If o.sent Is Nothing Then
                row.Selected = True
            End If
        Next

    End Sub

    Private Sub btnPrintPackingList_Click(sender As Object, e As EventArgs) Handles btnPrintPackingList.Click


        For Each r As DataGridViewRow In dtgPackingList.Rows
            If r.Selected Then
                PackingListHelper.CreatePackingList(r.DataBoundItem)

            End If

        Next



    End Sub

    Private Sub btnSetStatus_Click(sender As Object, e As EventArgs) Handles btnSetStatus.Click
        For Each r As DataGridViewRow In dtgPackingList.Rows

            If r.Selected Then
                Dim o As Order
                o = r.DataBoundItem
                If cboStatusSetOrder.SelectedIndex = 0 Then
                  
                    o.sent = DateTime.Now

                Else

                    o.sent = Nothing


                End If


            End If
        Next
        DBM.Instance.SaveChanges()
        start()


    End Sub

    Private Sub dtpPackingList_ValueChanged(sender As Object, e As EventArgs) Handles dtpPackingList.ValueChanged
        Me.deliveryDate = dtpPackingList.Value
        start()

    End Sub
End Class
