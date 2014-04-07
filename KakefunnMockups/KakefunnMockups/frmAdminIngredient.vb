Public Class frmAdminIngredient
    Private delIdx As Integer
    Private delName As String


    Private Sub frmAdminIngredient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set up autocomplete for ingredient name
        Dim ing = From x As ingredient In DBM.Instance.ingredients Select x.name Order By name
        Dim acSource As AutoCompleteStringCollection = New AutoCompleteStringCollection()
        acSource.AddRange(ing.ToArray())
        With txtSearch
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = AutoCompleteSource.CustomSource
            .AutoCompleteCustomSource = acSource
        End With

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
        Dim ingQuery = (From x In DBM.Instance.ingredients _
                     Where x.name.Contains(txtSearch.Text) _
                     Select x.id, x.name).ToList()

        Dim profQuery = (From x In DBM.Instance.ingredientPrices _
                         Select x).ToList()

        Dim batchQuery = (From x In DBM.Instance.batches _
                          Select x).ToList()

        'Filling dtgResults the old fashioned way..
        'Should be possible to structure the query so we only need to specify "dtgResults.DataSource = query",
        'and the content should show, but doing that only pushes the header line together and adds new columns to 
        'the right. Additionally the query gets very complex.
        UpdateActionStatus("Laster søkeresultat..")
        dtgResults.Rows.Clear()
        For Each row In ingQuery
            Dim profit As Double = (From x In profQuery _
                                   Where x.id = row.id _
                                   Order By x.date Descending
                                   Select x.markUpPercentage).FirstOrDefault()

            Dim bi As String = CStr(StockManager.getPurchasingPrice(row.id, "low", batchQuery))
            Dim di As String = CStr(StockManager.getPurchasingPrice(row.id, "high", batchQuery))
            Dim gi As String = CStr(StockManager.getPurchasingPrice(row.id, "avg", batchQuery))
            Dim bdgi As String = CStr(bi) & "/" & CStr(di) & "/" & CStr(gi)
            Dim bdgu As String = CStr(Format(bi * ((profit / 100) + 1), "0.00") & "/" & _
                                    CStr(Format(di * ((profit / 100) + 1), "0.00") & "/" & _
                                    CStr(Format(gi * ((profit / 100) + 1), "0.00"))))

            dtgResults.Rows.Add(row.id, row.name, StockManager.getInStock(row.id, batchQuery), _
                                bdgi, bdgu, profit)
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
