''' <summary>
''' Shows an ingredient overview with id, name, number in stock, price info and profit.
''' Doubleclick opens an editing window. "Ny ingrediens..." opens the same window for registering a new ingredient.
''' Last edited 22.04.14.
''' </summary>
''' <remarks></remarks>
Public Class frmAdminIngredient
    Private delIdx As Integer
    Private delName As String

    ''' <summary>
    ''' Set up autocomplete for ingredient name.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub frmAdminIngredient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ac As AutoCompleteHelper = New AutoCompleteHelper(DBM.Instance.GetNameColumn("Ingredient"))
        ac.UseOn(txtSearch)
    End Sub

    ''' <summary>
    ''' Opens frmDialogAdminIngredientDetails for adding new ingredients to the database.
    ''' Disables the batch-overview in the dialog and sets newIngr true.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        frmDialogAdminIngredientDetails.grpStock.Enabled = False
        frmDialogAdminIngredientDetails.newIngr = True
        SessionManager.Instance.ShowDialog(frmDialogAdminIngredientDetails)

    End Sub

    ''' <summary>
    ''' Searches for ingredients. See detailed comments in sub.
    ''' </summary>
    ''' <remarks>
    ''' Fills datagridview manually using a for loop. May cause performance issues with many ingredients.
    '''</remarks>
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        UpdateActionStatus("Søker..")

        'Preloading information from tables in the database.
        Dim ingQuery = (From x In DBM.Instance.Ingredients _
                     Where x.name.Contains(txtSearch.Text) _
                     Select x.id, x.name, x.deleted).ToList()

        Dim profQuery = (From x In DBM.Instance.IngredientPrices _
                         Select x).ToList()

        Dim batchQuery = (From x In DBM.Instance.Batches _
                          Select x).ToList()

        'Filling dtgResults.
        UpdateActionStatus("Laster søkeresultat..")
        dtgResults.Rows.Clear()
        For Each row In ingQuery
            'Gets markupPercentage from preloaded db data.
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

        dtgResults.Focus()

        'Resets deletion variables.
        delIdx = 0
        delName = ""
        UpdateActionStatus("Klar")
    End Sub

    ''' <summary>
    ''' Opens dialog to change ingredient details on doubleclicking an ingredient in the list.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub dtgResults_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles dtgResults.MouseDoubleClick
        Dim varenr As Integer = dtgResults.SelectedRows(0).Cells(colID.Index).Value
        frmDialogAdminIngredientDetails.varenr = varenr
        frmDialogAdminIngredientDetails.newIngr = False
        SessionManager.Instance.ShowDialog(frmDialogAdminIngredientDetails)
    End Sub

    ''' <summary>
    ''' Marks ingredient as deleted on todays date, after user confirms deletion. 
    ''' For reporting purposes the deleted ingredient is kept in the database.
    ''' After deletion reloads the ingredient list.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        If dtgResults.Rows.Count() > 0 Then
            delIdx = dtgResults.SelectedRows(0).Cells(colID.Index).Value
            delName = dtgResults.SelectedRows(0).Cells(colName.Index).Value
        End If

        If delIdx > 0 Then
            Dim delOK As Integer = MessageBox.Show("Er du sikker på at du vil slette varen >>" & delName & _
                                                   "<< med varenummer >>" & delIdx & "<<?", "Bekreft sletting", _
                                                   MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If delOK = 6 Then
                Dim delIng = (From x In DBM.Instance.Ingredients _
                              Where x.id = delIdx _
                              Select x).FirstOrDefault()
                delIng.deleted = Date.Now

                Try
                    DBM.Instance.SaveChanges()
                Catch ex As Entity.Validation.DbEntityValidationException
                    MsgBox("Feilmelding ved lagring: " & ex.ToString)
                End Try

                KakefunnEvent.saveSystemEvent("Ingredienser", "Slettet ingrediensen: " & delIng.id & " " & delIng.name)
                btnSearch.PerformClick()
                txtSearch.Text = ""
            End If
        End If
    End Sub

    ''' <summary>
    ''' Checks date on the hidden deleted column in the datagridview and formats cells to show which ingredients are deleted.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub dtgResults_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dtgResults.CellFormatting
        If dtgResults.Rows(e.RowIndex).Cells(colDeleted.Index).Value <= Date.Now And _
            dtgResults.Rows(e.RowIndex).Cells(colDeleted.Index).Value > CDate("2000-01-01 00:00:00") Then
            dtgResults.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Red
            dtgResults.Rows(e.RowIndex).DefaultCellStyle.Font = New Font(Font, FontStyle.Strikeout)
        End If
    End Sub
End Class
