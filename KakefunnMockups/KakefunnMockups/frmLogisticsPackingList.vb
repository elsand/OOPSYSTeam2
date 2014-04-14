Public Class frmLogisticsPackingList

    Private Sub frmLogisticsPackingList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PackingList.Order' table. You can move, or remove it, as needed.
        Me.OrderTableAdapter.Fill(Me.PackingList.Order)

        Me.lblOrdersToEnvoyDate.Text = "Ordrer til utsending "



    End Sub
End Class
