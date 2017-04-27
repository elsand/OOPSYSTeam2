Imports Microsoft.Reporting.WinForms

''' <summary>
''' Displays a list of expired batches in a reportviewer for print.
''' </summary>
''' <remarks></remarks>
Public Class frmDialogExpiredBatches
    Public reportDataSource As ReportDataSource

    ''' <summary>
    ''' Report is created on load. 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub frmDialogAdminNotExported_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim r = New ReportHelper()

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
            MsgBox("Noe gikk galt... " & ex.Message)
        End Try
    End Sub
End Class
