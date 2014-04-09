Imports Microsoft.Reporting.WinForms

Public Class frmAdminReports


    Dim reportDataSource As ReportDataSource

    Private Sub frmAdminReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.cboSelectReportForm.SelectedIndex = 0

        'TODO: This line of code loads data into the 'Turnover.Ingredient' table. You can move, or remove it, as needed.
        'Me.IngredientTableAdapter.Fill(Me.Turnover.Ingredient)
        'TODO: This line of code loads data into the 'EmployeeTest.Employee' table. You can move, or remove it, as needed.
        'Me.EmployeeTableAdapter.Fill(Me.EmployeeTest.Employee)

        'Me.rptReports.RefreshReport()

    End Sub

    Private Sub cboSelectReportForm_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSelectReportForm.SelectedIndexChanged

    End Sub

    Private Sub btnGetReport_Click(sender As Object, e As EventArgs) Handles btnGetReport.Click

        Dim rph = New ReportHelper()

        ' MsgBox(cboSelectReportForm.SelectedIndex)

        Select Case cboSelectReportForm.SelectedIndex
            Case 0
                Return
            Case 1
                reportDataSource = New ReportDataSource("DataSet1", rph.getDataTable("turnover"))

        End Select









        With Me.rptReports.LocalReport

            .DataSources.Clear()
            .DataSources.Add(reportDataSource)
            .ReportEmbeddedResource = rph.rdf

        End With

        Me.rptReports.RefreshReport()






    End Sub
End Class
