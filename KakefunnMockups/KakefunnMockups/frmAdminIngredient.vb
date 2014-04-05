Public Class frmAdminIngredient
    Private delIdx As Integer
    Private delName As String
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
        UpdateActionStatus("Søker..")
        Dim query = (From x In DBM.Instance.ingredients _
                     Where x.name.Contains(txtSearch.Text) _
                     Select x.id, x.name).ToList()
        'Dim query = (From x In DBM.Instance.ingredients _
        '            Join y In DBM.Instance.batches On x.id Equals y.ingredientId _
        '           Join z In DBM.Instance.ingredientPrices On x.id Equals z.id _
        '          Where x.name.Contains(txtSearch.Text) _
        '         Select Varenr = x.id, Navn = x.name).ToList()
        'dtgResults.DataSource = query

        'Filling dtgResults the old fashioned way..
        'Should be possible to structure the query so we only need to specify "dtgResults.DataSource = query",
        'and the content should show, but doing that only pushes the header line together and adds new columns to 
        'the right. Additionally the query gets very complex.
        UpdateActionStatus("Laster søkeresultat..")
        dtgResults.Rows.Clear()
        For Each row In query
            dtgResults.Rows.Add(row.id, row.name, StockManager.getInStock(row.id))
        Next

        delIdx = 0
        delName = ""
        UpdateActionStatus()
    End Sub

    Private Sub dtgResults_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles dtgResults.MouseDoubleClick
        Dim varenr As Integer = dtgResults.SelectedRows(0).Cells(0).Value
        Dim frm As frmDialogAdminIngredientDetails
        frm = New frmDialogAdminIngredientDetails()
        frm.varenr = varenr
        frm.newIngr = False
        frm.Show()
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        If dtgResults.Rows.Count() > 0 Then
            delIdx = dtgResults.SelectedRows(0).Cells(0).Value
            delName = dtgResults.SelectedRows(0).Cells(1).Value
        End If

        If delIdx > 0 Then
            Dim delOK As Integer = MessageBox.Show("Er du sikker på at du vil slette varen >>" & delName & _
                                                   "<< med varenummer >>" & delIdx & "<<?", "Bekreft sletting", _
                                                   MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If delOK = 6 Then
                'Getting pricing-data from ingredientPrices and deleting elements
                'relevant for the selected ingredient.
                Dim prices = From x In DBM.Instance.ingredientPrices _
                             Where x.id = delIdx _
                             Select x

                For Each x In prices
                    DBM.Instance.ingredientPrices.Remove(x)
                Next

                DBM.Instance.ingredients.Remove(DBM.Instance.ingredients.Find(delIdx))
                DBM.Instance.SaveChanges()
            End If
        End If
    End Sub
End Class
