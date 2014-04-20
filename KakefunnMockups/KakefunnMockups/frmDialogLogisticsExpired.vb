Imports Microsoft.Reporting.WinForms


Public Class frmDialogExpiredBatches

    Public reportDataSource As ReportDataSource
    Private Sub frmDialogAdminNotExported_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Try


            Dim r = New ReportHelper()




            ' Prøve å laste fra databasen, men får da feil pris... .i forhold til ordrelilnjene.... NB NB NB
            'Dim query = "select o.id, o.deliveryFirstName, o.deliveryLastName , o.created from `Order` o where o.exported IS NULL ;"

            '
            'Dim t = Kakefunn.DBM.Instance.GetDataTableFromQuery(query)





            'Creating the the datasource

            reportDataSource = New ReportDataSource("ExpiredBatches", r.getDataTable("expiredBatches"))


            'manipulating the localreport. 
            With Me.rptExpiredBatches.LocalReport
                .DataSources.Clear()
                .DataSources.Add(reportDataSource)
                .ReportEmbeddedResource = r.rdf
            End With

            'refreshing the report
            Me.rptExpiredBatches.RefreshReport()


        Catch ex As Exception
            'if my code f.up the might show... but it hasn't so far... even if the report faild... WHY !!!!! 
            MsgBox("Noe gikk galt... " & ex.Message)


        End Try



    End Sub
End Class
