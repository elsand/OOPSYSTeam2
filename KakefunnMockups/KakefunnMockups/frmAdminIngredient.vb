Public Class frmAdminIngredient

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub frmAdminIngredient_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        'Opens frmDialogAdminIngredientDetails for adding new ingredients to the database.
        Dim frm As frmDialogAdminIngredientDetails
        frm = New frmDialogAdminIngredientDetails()
        frm.grpStock.Enabled = False
        frm.btnSave.Text = "Lagre"
        frm.newIngr = True
        frm.Show()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        'It's a start. Needs to do calculations for BDG-columns ++. Made this to get search-results for testing
        'editing ingredients in frmDialogAdminIngredientDetails.vb
        Dim query = (From x In DBM.Instance.ingredients _
                     Where x.name.Contains(txtSearch.Text) _
                     Select Varenr = x.id, Navn = x.name).ToList()
        'Dim query = (From x In DBM.Instance.ingredients _
        '            Join y In DBM.Instance.batches On x.id Equals y.ingredientId _
        '           Join z In DBM.Instance.ingredientPrices On x.id Equals z.id _
        '          Where x.name.Contains(txtSearch.Text) _
        '         Select Varenr = x.id, Navn = x.name).ToList()
        'dtgResults.DataSource = query
        dtgResults.Rows.Clear()
        For Each row In query
            dtgResults.Rows.Add(row.Varenr, row.Navn, StockManager.getInStock(row.Varenr))
        Next

    End Sub

    Private Sub dtgResults_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles dtgResults.MouseDoubleClick
        Dim varenr As Integer = dtgResults.SelectedRows(0).Cells(0).Value
        Dim frm As frmDialogAdminIngredientDetails
        frm = New frmDialogAdminIngredientDetails()
        frm.varenr = varenr
        frm.newIngr = False
        frm.Show()
    End Sub
End Class
