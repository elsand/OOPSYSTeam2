''' <summary>
''' 
''' </summary>
''' <remarks></remarks>

Imports Microsoft.Reporting.WinForms


Public Class frmDialogAdminNotExported
    Public reportDataSource As ReportDataSource
    Private Sub frmDialogAdminNotExported_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            Dim query = "select o.id, o.deliveryFirstName, o.deliveryLastName , o.created from `Order` o where o.exported IS NULL ;"


            Dim t = Kakefunn.DBM.Instance.GetDataTableFromQuery(query)







            reportDataSource = New ReportDataSource("DataSet1", t)
            With Me.rptNotExportedOrders.LocalReport
                .DataSources.Clear()
                .DataSources.Add(reportDataSource)
                .ReportEmbeddedResource = "Kakefunn.notExportedOrders.rdlc"
            End With
            Me.rptNotExportedOrders.RefreshReport()


        Catch ex As Exception
            MsgBox("Noe gikk galt... " & ex.Message)


        End Try
        


    End Sub
End Class
