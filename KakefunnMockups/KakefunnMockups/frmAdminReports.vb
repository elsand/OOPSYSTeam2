Public Class frmAdminReports

    Private Sub frmAdminReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.rptReports.RefreshReport()
        Me.rptReports.RefreshReport()
    End Sub

    Private Sub cboSelectReportForm_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSelectReportForm.SelectedIndexChanged

    End Sub
End Class
