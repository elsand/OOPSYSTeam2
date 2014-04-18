'Register received goods in warehouse. There has to be an order in the system.
'TODO:  - Comment code
'Last edited: 18.04.14

Public Class frmLogisticsRegisterCommodity
    Private rowMax As Integer = 10
    Private shelfMax As Integer = 50
    Private Sub btnSearchBatch_Click(sender As Object, e As EventArgs) Handles btnSearchBatch.Click
        If numSearchBatch.Text IsNot "" Then
            BatchBindingSource.DataSource = DBM.Instance.Batches.Local.ToBindingList().Where(Function(b) _
                                            b.id = numSearchBatch.Text)
        End If
    End Sub

    Private Sub frmLogisticsRegisterCommodity_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DBM.Instance.Batches.Load()
        BatchBindingSource.DataSource = DBM.Instance.Batches.Local.ToBindingList().Where(Function(b) _
                                        Not b.registered.HasValue)

        dtpExpireDate.Text = DateTime.Today.AddDays(15)
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
        BatchBindingSource.DataSource = DBM.Instance.Batches.Local.ToBindingList().Where(Function(b) _
                                        Not b.registered.HasValue)
    End Sub

    Private Sub dtpBatchExpectedInStock_ValueChanged(sender As Object, e As EventArgs) Handles dtpBatchExpectedInStock.ValueChanged
        BatchBindingSource.DataSource = DBM.Instance.Batches.Local.ToBindingList().Where(Function(b) _
                                        b.expected = dtpBatchExpectedInStock.Value.ToShortDateString _
                                        And Not b.registered.HasValue)
    End Sub

    Private Sub firstFreeLocation()
        'The assumption is that Kakefunn has 10 rows with 50 shelves on each row.
        Dim gotLocation As Boolean = False
        Dim row, shelf As Integer
        While Not gotLocation
            For row = 1 To rowMax
                For shelf = 1 To shelfMax
                    gotLocation = StockManager.checkFreeLocation(row, shelf)
                    If gotLocation Then
                        numRow.Text = row
                        numShelf.Text = shelf
                        Exit For
                    End If
                Next shelf
                If gotLocation Then
                    Exit For
                End If
            Next row
        End While
    End Sub

    Private Sub btnSuggestLocation_Click(sender As Object, e As EventArgs) Handles btnSuggestLocation.Click
        Dim ingredientName As String = dtgLogisticsRegisterCommodity.SelectedRows(0).Cells(1).FormattedValue.ToString()
        Dim row, shelf As Integer
        Dim gotLocation As Boolean = False
        Dim ingLocInfo As String
        If ingredientName <> String.Empty Then
            Dim batchLoc = StockManager.getLocation(ingredientName)
            If batchLoc.Count < 1 Then
                MsgBox("Ingrediensen ligger ikke på lager fra før. Foreslår første ledige lokasjon.")
                firstFreeLocation()
            Else
                ingLocInfo = ingredientName & " finnes på:" & vbCrLf
                For Each Batch In batchLoc
                    ingLocInfo = ingLocInfo & "Rad: " & Batch.locationRow _
                        & ", Hylle: " & Batch.locationShelf
                    row = Batch.locationRow
                    shelf = Batch.locationShelf
                    If shelf = shelfMax Then
                        If StockManager.checkFreeLocation(row, shelf - 1) Then
                            numRow.Text = row
                            numShelf.Text = shelf - 1
                            gotLocation = True
                        End If
                    ElseIf shelf = 1 Then
                        If StockManager.checkFreeLocation(row, shelf + 1) Then
                            numRow.Text = row
                            numShelf.Text = shelf + 1
                            gotLocation = True
                        End If
                    Else
                        Dim i As Integer
                        For i = shelf - 1 To shelf + 1
                            If StockManager.checkFreeLocation(row, i) Then
                                numRow.Text = row
                                numShelf.Text = i
                                gotLocation = True
                                Exit For
                            End If
                        Next i
                    End If
                    If gotLocation Then
                        Exit For
                    End If
                Next
                If Not gotLocation Then
                    MsgBox(ingLocInfo & vbCrLf & vbCrLf & "Ingen tilstøtende lokasjoner er tilgjengelige. " _
                           & "Foreslår første ledige lokasjon.")
                    firstFreeLocation()
                Else
                    MsgBox(ingLocInfo)
                End If
            End If
            btnRegisterBatchInStock.Enabled = True
        Else
            MsgBox("Velg en vareforsendelse")
        End If
    End Sub

    Private Sub btnRegisterBatchInStock_Click(sender As Object, e As EventArgs) Handles btnRegisterBatchInStock.Click
        Dim batchToRegister = DBM.Instance.Batches.Find(dtgLogisticsRegisterCommodity.SelectedRows(0).Cells(0).Value)
        With batchToRegister
            .locationRow = numRow.Text
            .locationShelf = numShelf.Text
            .registered = Date.Now
            .expires = dtpExpireDate.Value.ToShortDateString
        End With

        Try
            DBM.Instance.SaveChanges()
        Catch ex As EntityException
            MsgBox("Noe gikk galt under registrering av batchen - " & ex.ToString)
        End Try
        BatchBindingSource.DataSource = DBM.Instance.Batches.Local.ToBindingList().Where(Function(b) _
                                        Not b.registered.HasValue)
    End Sub

    Private Sub dtgLogisticsRegisterCommodity_SelectionChanged(sender As Object, e As EventArgs) Handles dtgLogisticsRegisterCommodity.SelectionChanged
        numRow.Text = ""
        numShelf.Text = ""
        btnRegisterBatchInStock.Enabled = False
    End Sub
End Class
