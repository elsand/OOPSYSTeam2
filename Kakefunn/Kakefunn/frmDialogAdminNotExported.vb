﻿Imports Microsoft.Reporting.WinForms

''' <summary>
''' Displays all order not exported to invoice system in a report.
''' </summary>
''' <remarks></remarks>
Public Class frmDialogAdminNotExported
    Public reportDataSource As ReportDataSource

    ''' <summary>
    ''' Everything happes in loading the form. No interaction from user is needed.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub frmDialogAdminNotExported_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'Crate an orderList.. 
            Dim orders = DBM.Instance.Orders.Local.ToList().Where(Function(o) Not o.exported.HasValue And o.isSubscriptionOrder = False)

            'Create a datatable for the report, predefined in the report definition file. (The dataset connected to the report is just a dummy ... 
            Dim t As New DataTable

            'Add the fields
            t.Columns.Add("id")
            t.Columns.Add("customerId")
            t.Columns.Add("modified", Type.GetType("System.String"))
            t.Columns.Add("deliveryAdress", Type.GetType("System.String"))
            t.Columns.Add("name", Type.GetType("System.String"))
            t.Columns.Add("totalPrice", Type.GetType("System.Double"))

            'Run through the list of not exported orders and add them to the datatable
            For Each row In orders
                Dim r = t.NewRow()
                r("id") = row.id
                r("customerId") = row.Customer.id
                r("modified") = row.modified
                r("deliveryAdress") = row.Customer.Address.address1 & ", " & row.Customer.Address.Zip.zip1.ToString("D4") & " " & row.Customer.Address.Zip.city
                r("name") = row.Customer.firstName & " " & row.Customer.lastName
                r("totalPrice") = OrderHelper.CalculateTotals(row).totalToPay()
                t.Rows.Add(r)
            Next

            'Creating the the datasource
            reportDataSource = New ReportDataSource("NotExportedOrders", t)

            'manipulating the localreport. 
            With Me.rptNotExportedOrders.LocalReport
                .DataSources.Clear()
                .DataSources.Add(reportDataSource)
                .ReportEmbeddedResource = "Kakefunn.notExportedOrders.rdlc"
            End With

            'refreshing the report
            Me.rptNotExportedOrders.RefreshReport()
        Catch ex As Entity.Validation.DbEntityValidationException
            MsgBox("Noe gikk galt ved lagring til databasen: " & ex.Message)
        End Try
    End Sub
End Class
