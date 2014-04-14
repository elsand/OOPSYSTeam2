Public Class frmLogisticsBase

    Private Sub btnPackingList_Click(sender As Object, e As EventArgs) Handles btnPackingList.Click
        SessionManager.Instance.ShowForm(frmLogisticsPackingList)

    End Sub

    Private Sub btnRegisterCommodity_Click(sender As Object, e As EventArgs) Handles btnRegisterCommodity.Click
        
        SessionManager.Instance.ShowForm(frmLogisticsRegisterCommodity)


    End Sub

    Private Sub btnExpiredCommodity_Click(sender As Object, e As EventArgs) Handles btnExpiredCommodity.Click
        SessionManager.Instance.ShowForm(frmLogisticsReports)

    End Sub
End Class
