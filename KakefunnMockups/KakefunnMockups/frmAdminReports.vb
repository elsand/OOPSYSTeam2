Public Class frmAdminReports

    Private Sub frmAdminReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Turnover.Ingredient' table. You can move, or remove it, as needed.
        Me.IngredientTableAdapter.Fill(Me.Turnover.Ingredient)
        'TODO: This line of code loads data into the 'EmployeeTest.Employee' table. You can move, or remove it, as needed.
        Me.EmployeeTableAdapter.Fill(Me.EmployeeTest.Employee)

        Me.rptReports.RefreshReport()
        Me.rptReports.RefreshReport()
    End Sub

    Private Sub cboSelectReportForm_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSelectReportForm.SelectedIndexChanged

    End Sub

    Private Sub btnGetReport_Click(sender As Object, e As EventArgs) Handles btnGetReport.Click

    End Sub
End Class
