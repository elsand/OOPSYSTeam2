Public Class frmAdminBase

    Private Sub btnProcessedOrders_Click(sender As Object, e As EventArgs) Handles btnProcessedOrders.Click
        SessionManager.Instance.ShowForm(frmAdminProcessedOrders)
    End Sub

    Private Sub btnCakes_Click(sender As Object, e As EventArgs) Handles btnCakes.Click
        SessionManager.Instance.ShowForm(frmAdminCakes)
    End Sub

    Private Sub btnIngredients_Click(sender As Object, e As EventArgs) Handles btnIngredients.Click
        SessionManager.Instance.ShowForm(frmAdminIngredient)
    End Sub

    Private Sub btnBatchOrder_Click(sender As Object, e As EventArgs) Handles btnBatchOrder.Click
        SessionManager.Instance.ShowForm(frmAdminBatch)
    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        SessionManager.Instance.ShowForm(frmAdminReports)
    End Sub

    Private Sub btnUsers_Click(sender As Object, e As EventArgs) Handles btnUsers.Click
        SessionManager.Instance.ShowForm(frmAdminSystemAdministration)
    End Sub
End Class
