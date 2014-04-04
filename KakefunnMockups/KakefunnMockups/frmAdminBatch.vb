
Public Class frmAdminBatch

    Private Sub frmAdminBatch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DBM.Instance.batches.Load()
        BatchBindingSource.DataSource = DBM.Instance.batches.Local.ToBindingList()
    End Sub

    Private Sub BatchBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Validate()
        DBM.Instance.SaveChanges()
        BatchDataGridView.Refresh()
    End Sub
End Class
