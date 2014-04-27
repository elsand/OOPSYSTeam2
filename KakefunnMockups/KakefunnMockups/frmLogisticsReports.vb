Public Class frmLogisticsReports
    Private expireDate As Date

    Private Sub frmLogisticsReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.expireDate = Date.Now
        'Add this to app.config?
        Me.expireDate = Me.expireDate.AddDays(5)
        start()
    End Sub


    ''' <summary>
    ''' Loads the batches and binds them to the dgv
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub start()

        'Loads the batches
        Try
            DBM.Instance.Batches.Load()
            BatchBindingSource.DataSource = DBM.Instance.Batches.Local.ToBindingList.Where(Function(b) b.expires.Value.CompareTo(Me.expireDate) <= 0 And b.deleted Is Nothing)

            If BatchBindingSource.Count > 1 Then
                dtgExpiredIngredients.Enabled = True
                dtgExpiredIngredients.DataSource = BatchBindingSource

            End If
            dtgExpiredIngredients.Refresh()

        Catch ex As Exception
            MsgBox("En eller flere datoer har blitt satt til null i tabellen:  Kakefunn.batch. Gi beskjed til administrator om dette. ")
            System.Console.WriteLine("##En operasjon mislyktes: Trolig er dette en dato i batch som er null.")
            System.Console.WriteLine("## Feilmelding:" & ex.ToString)
        End Try
    End Sub

    ''' <summary>
    ''' Selecting the right value for the cell when displaying the dgv
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub dtgExpiredIngredients_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dtgExpiredIngredients.CellFormatting
        If e.Value IsNot Nothing Then
            Select Case dtgExpiredIngredients.Columns(e.ColumnIndex).Name
                Case "cnIngredientId" 'add orderID to the dgv

                    e.Value = CType(e.Value, Ingredient).id

                Case "cnName" 'add name to the dgv

                    e.Value = CType(e.Value, Ingredient).name


                Case "cnRegisteredDate" 'add address

                    e.Value = e.Value


                Case "cnExpireDate" 'add orderID to the dgv
                    e.Value = e.Value


                Case "cnAmount" 'add orderID to the dgv

                    Dim b = CType(dtgExpiredIngredients.Rows(e.RowIndex).DataBoundItem, Batch)

                    e.Value = b.unitCount & " " & b.Ingredient.Unit.name

                Case "cnLocation"
                    Dim b = CType(dtgExpiredIngredients.Rows(e.RowIndex).DataBoundItem, Batch)
                    e.Value = "Rad: " & b.locationRow & ", Hylle: " & b.locationShelf


            End Select
        End If

        If dtgExpiredIngredients.Columns(e.ColumnIndex).Name = "cnAmount" Then

            Try

                Dim b = CType(dtgExpiredIngredients.Rows(e.RowIndex).DataBoundItem, Batch)

                e.Value = b.unitCount & " " & b.Ingredient.Unit.name
            Catch ex As Exception
                System.Console.WriteLine("Noe gikk galt " & ex.ToString)
            End Try
           
        End If

    End Sub

    ''' <summary>
    ''' Selects all rows int the dgv
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnCheckAll_Click(sender As Object, e As EventArgs) Handles btnCheckAll.Click

        For Each r As DataGridViewRow In dtgExpiredIngredients.Rows

            r.Selected = True

        Next



    End Sub

    ''' <summary>
    ''' Deletes the selected rows from available batches. 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btbDeleteCheckedIngredientsInStock_Click(sender As Object, e As EventArgs) Handles btbDeleteCheckedIngredientsInStock.Click
        Dim ingredientIDs As String = ""

        For Each r As DataGridViewRow In dtgExpiredIngredients.Rows

            If r.Selected Then

                Dim b = CType(r.DataBoundItem, Batch)
                b.deleted = DateTime.Now
                ingredientIDs &= b.id & ", "
            End If

        Next

        DBM.Instance.SaveChanges()
        KakefunnEvent.saveSystemEvent("Utgåtte varer", "Slettet utgått vare: " & ingredientIDs)
        start()


    End Sub

    ''' <summary>
    ''' Creates and displays a report of the checked ingredients
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnPrintExpiredIngredients_Click(sender As Object, e As EventArgs) Handles btnPrintExpiredIngredients.Click
        frmDialogExpiredBatches.ShowDialog()

    End Sub


    ''' <summary>
    ''' When clicking a cell the whole row gets selected. Ignores column select.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub dtgExpiredIngredients_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgExpiredIngredients.CellClick

        Try
            dtgExpiredIngredients.Rows(e.RowIndex).Selected = True
        Catch ex As Exception
            System.Console.WriteLine(e)
        End Try



    End Sub
End Class
