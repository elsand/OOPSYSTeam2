Public Class frmLogisticsBase

    Private Sub btnPackingList_Click(sender As Object, e As EventArgs) Handles btnPackingList.Click
        'open selected form
        frmLogisticsPackingList.Show()

        'close the others if they are visible.
        frmLogisticsRegisterCommodity.Hide()
        frmLogisticsReports.Hide()


    End Sub

    Private Sub btnRegisterCommodity_Click(sender As Object, e As EventArgs) Handles btnRegisterCommodity.Click
        'open selected form
        frmLogisticsRegisterCommodity.Show()

        'close the others if they are visible.
        frmLogisticsPackingList.Hide()
        frmLogisticsReports.Hide()

    End Sub

    Private Sub btnExpiredCommodity_Click(sender As Object, e As EventArgs) Handles btnExpiredCommodity.Click
        'open selected form
        frmLogisticsReports.Show()

        'close the others if they are visible.
        frmLogisticsPackingList.Hide()
        frmLogisticsRegisterCommodity.Hide()
    End Sub
End Class
