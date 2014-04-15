''' <summary>
''' 
''' </summary>
''' <remarks></remarks>

Imports Microsoft.Reporting.WinForms


Public Class frmDialogAdminNotExported
    Public reportDataSource As ReportDataSource
    Private Sub frmDialogAdminNotExported_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim query = "SELECT id,deliveryFirstName,deliveryLastName, FROM `order` WHERE exported = NULL ;"


        Dim t = Kakefunn.DBM.Instance.GetDataTableFromQuery(query)







        reportDataSource = New ReportDataSource("DataSet1", t)
        With Me.rptNotExportedOrders.LocalReport
            .DataSources.Clear()
            .DataSources.Add(reportDataSource)
            .ReportEmbeddedResource = "notExportedOrders.rdlc"
        End With
        Me.rptNotExportedOrders.LocalReport.Refresh()


    End Sub
End Class
