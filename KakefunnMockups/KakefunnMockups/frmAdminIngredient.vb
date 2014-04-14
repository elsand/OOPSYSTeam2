'Ingredient overview.
'Last edited 13.04.14.
'OK to finalize?
Public Class frmAdminIngredient
    Private delIdx As Integer
    Private delName As String

    Private Sub frmAdminIngredient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set up autocomplete for ingredient name
        Dim ac As AutoCompleteHelper = New AutoCompleteHelper(DBM.Instance.GetNameColumn("Ingredient"))
        ac.UseOn(txtSearch)

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        'Opens frmDialogAdminIngredientDetails for adding new ingredients to the database.
        '
        Dim frm As frmDialogAdminIngredientDetails
        frm = New frmDialogAdminIngredientDetails()
        'Disables the batch-overview in the dialog and sets newIngr true.
        frm.grpStock.Enabled = False
        frm.newIngr = True
        frm.Show()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        'Searches for ingredients.
        UpdateActionStatus("Søker..")

        'Preloading information from tables in the database.
        Dim ingQuery = (From x In DBM.Instance.Ingredients _
                     Where x.name.Contains(txtSearch.Text) _
                     Select x.id, x.name, x.deleted).ToList()

        Dim profQuery = (From x In DBM.Instance.IngredientPrices _
                         Select x).ToList()

        Dim batchQuery = (From x In DBM.Instance.Batches _
                          Select x).ToList()

        'Filling dtgResults the old fashioned way..
        UpdateActionStatus("Laster søkeresultat..")
        dtgResults.Rows.Clear()
        For Each row In ingQuery
            'Gets markupPercentage from db.
            Dim profit As Double = (From x In profQuery _
                                   Where x.id = row.id _
                                   Order By x.date Descending
                                   Select x.markUpPercentage).FirstOrDefault()

            'Calculates cheapest, most expensive and average price for purchase and sale.
            Dim bi As String = CStr(StockManager.getPurchasingPrice(row.id, "low", batchQuery))
            Dim di As String = CStr(StockManager.getPurchasingPrice(row.id, "high", batchQuery))
            Dim gi As String = CStr(StockManager.getPurchasingPrice(row.id, "avg", batchQuery))
            Dim bdgi As String = CStr(bi) & "/" & CStr(di) & "/" & CStr(gi)
            Dim bdgu As String = CStr(Format(bi * ((profit / 100) + 1), "0.00") & "/" & _
                                    CStr(Format(di * ((profit / 100) + 1), "0.00") & "/" & _
                                    CStr(Format(gi * ((profit / 100) + 1), "0.00"))))

            'Adds results to dtgResults.
            dtgResults.Rows.Add(row.id, row.name, StockManager.getInStock(row.id, batchQuery), _
                                bdgi, bdgu, profit, row.deleted)
        Next

        delIdx = 0
        delName = ""
        UpdateActionStatus()
    End Sub

    Private Sub dtgResults_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles dtgResults.MouseDoubleClick
        'Opens dialog to change ingredient details on doubleclicking an ingredient in the list.
        Dim varenr As Integer = dtgResults.SelectedRows(0).Cells(0).Value
        frmDialogAdminIngredientDetails.varenr = varenr
        frmDialogAdminIngredientDetails.newIngr = False
        SessionManager.Instance.ShowDialog(frmDialogAdminIngredientDetails)
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        'Deletes an ingredient

        'Gets ingredient id/varenr and ingredient name.
        If dtgResults.Rows.Count() > 0 Then
            delIdx = dtgResults.SelectedRows(0).Cells(0).Value
            delName = dtgResults.SelectedRows(0).Cells(1).Value
        End If

        'Marks ingredient as deleted on todays date. 
        'Does not delete the record from db. Prompts the user for confirmation.
        If delIdx > 0 Then
            Dim delOK As Integer = MessageBox.Show("Er du sikker på at du vil slette varen >>" & delName & _
                                                   "<< med varenummer >>" & delIdx & "<<?", "Bekreft sletting", _
                                                   MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If delOK = 6 Then
                Dim delIng = (From x In DBM.Instance.Ingredients _
                              Where x.id = delIdx _
                              Select x).FirstOrDefault()
                delIng.deleted = Date.Today

                DBM.Instance.SaveChanges()

                btnSearch.PerformClick()
                txtSearch.Text = ""
            End If
        End If
    End Sub

    Private Sub dtgResults_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dtgResults.CellFormatting
        'Indicates a deleted ingredient in the list.
        If dtgResults.Rows(e.RowIndex).Cells(6).Value <= Date.Today And _
            dtgResults.Rows(e.RowIndex).Cells(6).Value > CDate("2000-01-01") Then
            dtgResults.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Red
            dtgResults.Rows(e.RowIndex).DefaultCellStyle.Font = New Font(Font, FontStyle.Strikeout)
        End If

    End Sub
End Class
