Public Class frmLogisticsRegisterCommodity

    Private Sub btnSearchBatch_Click(sender As Object, e As EventArgs) Handles btnSearchBatch.Click
        If numSearchBatch.Text IsNot "" Then
            BatchBindingSource.DataSource = DBM.Instance.Batches.Local.ToBindingList().Where(Function(b) _
                                            b.id = numSearchBatch.Text)
        End If
    End Sub

    Private Sub frmLogisticsRegisterCommodity_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DBM.Instance.Batches.Load()
        BatchBindingSource.DataSource = DBM.Instance.Batches.Local.ToBindingList()
    End Sub

    Private Sub dtgLogisticsRegisterCommodity_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dtgLogisticsRegisterCommodity.CellFormatting
        If e.Value IsNot Nothing Then
            Select Case dtgLogisticsRegisterCommodity.Columns(e.ColumnIndex).Name
                Case "Ingrediens" 'Adds ingredient name to dgv.
                    e.Value = CType(e.Value, Ingredient).name
            End Select
        End If

    End Sub

    Private Sub btnShowAll_Click(sender As Object, e As EventArgs) Handles btnShowAll.Click
        BatchBindingSource.DataSource = DBM.Instance.Batches.Local.ToBindingList()
    End Sub

    Private Sub dtpBatchExpectedInStock_ValueChanged(sender As Object, e As EventArgs) Handles dtpBatchExpectedInStock.ValueChanged
        BatchBindingSource.DataSource = DBM.Instance.Batches.Local.ToBindingList().Where(Function(b) _
                                        b.expected = dtpBatchExpectedInStock.Value.ToShortDateString)
    End Sub
End Class
