Public Class frmSaleMain
    Inherits frmSaleBase

    Private Sub frmSaleMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DBM.Instance.orders.Load()
        OrderBindingSource.DataSource = DBM.Instance.orders.Local.ToBindingList()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim l = DBM.Instance.Database.SqlQuery(Of DataRow)("SELECT * FROM ingredient, batches").ToList()



    End Sub
End Class
