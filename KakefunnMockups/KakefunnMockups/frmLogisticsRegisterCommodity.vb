﻿'Register received goods in warehouse. There has to be an order in the system.
'TODO:  - Comment code
'Last edited: 18.04.14

Imports System.Collections.Specialized
Imports System.Configuration
Public Class frmLogisticsRegisterCommodity
    'Defines warehouse size.
    Private rowMax, shelfMax As Integer

    Private Sub btnSearchBatch_Click(sender As Object, e As EventArgs) Handles btnSearchBatch.Click
        'Searches for a specific order number.
        If numSearchBatch.Text IsNot "" Then
            BatchBindingSource.DataSource = DBM.Instance.Batches.Local.ToBindingList().Where(Function(b) _
                                            b.id = numSearchBatch.Text)
        End If
    End Sub

    Private Sub frmLogisticsRegisterCommodity_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Gets records from the database and displays them in the dgv.
        DBM.Instance.Batches.Load()
        BatchBindingSource.DataSource = DBM.Instance.Batches.Local.ToBindingList().Where(Function(b) _
                                        Not b.registered.HasValue)

        'Presets expire days in fifteen days.
        dtpExpireDate.Text = DateTime.Today.AddDays(15)

        'Gets settings from config-file and sets number of inventory rows and shelves.
        'Settings can be changed in the Kakefunn.exe.config file in the program folder.
        Dim appSettings As NameValueCollection
        appSettings = ConfigurationManager.AppSettings
        rowMax = appSettings.Item("rowMax")
        shelfMax = appSettings.Item("shelfMax")
    End Sub

    Private Sub dtgLogisticsRegisterCommodity_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dtgLogisticsRegisterCommodity.CellFormatting
        'Adds ingredient name for all ingredients shown in dgv.
        If e.Value IsNot Nothing Then
            Select Case dtgLogisticsRegisterCommodity.Columns(e.ColumnIndex).Name
                Case "Ingrediens" 'Adds ingredient name to dgv.
                    e.Value = CType(e.Value, Ingredient).name
            End Select
        End If

    End Sub

    Private Sub btnShowAll_Click(sender As Object, e As EventArgs) Handles btnShowAll.Click
        'Resets the dgv to show all expected batches.
        BatchBindingSource.DataSource = DBM.Instance.Batches.Local.ToBindingList().Where(Function(b) _
                                        Not b.registered.HasValue)
    End Sub

    Private Sub dtpBatchExpectedInStock_ValueChanged(sender As Object, e As EventArgs) Handles dtpBatchExpectedInStock.ValueChanged
        'On change of selected date shows batches with ETA on selected date.
        BatchBindingSource.DataSource = DBM.Instance.Batches.Local.ToBindingList().Where(Function(b) _
                                        b.expected = dtpBatchExpectedInStock.Value.ToShortDateString _
                                        And Not b.registered.HasValue)
    End Sub

    Private Sub firstFreeLocation()
        'Checks rows and shelves for a free location to place a batch.
        'Suggests the first free location by entering row and shelf number in 
        'the numeric textboxes in the user interface.
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
        'Suggests a location to place a selected batch.
        'For ingredients already in stock, checks if neighbouring locations are free, 
        '   if not suggests first free location.
        'For ingredients located in the first shelf of a row, checks if the second shelf is free,
        '   if not suggests first free location.
        'For ingredients located in the last shelf of a row, checks if the penultimate shelf is free, 
        '   if not suggests first free location.
        'For ingredients not in stock, suggests first free location.
        Dim ingredientName As String = dtgLogisticsRegisterCommodity.SelectedRows(0).Cells(1).FormattedValue.ToString()
        Dim row, shelf As Integer
        Dim gotLocation As Boolean = False
        Dim ingLocInfo As String

        If ingredientName <> String.Empty Then
            Dim batchLoc = StockManager.getLocation(ingredientName)
            Select Case batchLoc.Count
                Case Is < 1
                    MsgBox("Ingrediensen ligger ikke på lager fra før. Foreslår første ledige lokasjon.")
                    firstFreeLocation()
                Case Is >= 1
                    ingLocInfo = ingredientName & " finnes på:" & vbCrLf
                    For Each Batch In batchLoc

                        ingLocInfo = ingLocInfo & "Rad: " & Batch.locationRow _
                            & ", Hylle: " & Batch.locationShelf
                        row = Batch.locationRow
                        shelf = Batch.locationShelf

                        Select Case shelf
                            Case shelfMax
                                If StockManager.checkFreeLocation(row, shelf - 1) Then
                                    numRow.Text = row
                                    numShelf.Text = shelf - 1
                                    gotLocation = True
                                End If
                            Case 1
                                If StockManager.checkFreeLocation(row, shelf + 1) Then
                                    numRow.Text = row
                                    numShelf.Text = shelf + 1
                                    gotLocation = True
                                End If
                            Case 2 To shelfMax - 1
                                Dim i As Integer
                                For i = shelf - 1 To shelf + 1
                                    If StockManager.checkFreeLocation(row, i) Then
                                        numRow.Text = row
                                        numShelf.Text = i
                                        gotLocation = True
                                        Exit For
                                    End If
                                Next i
                        End Select
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
            End Select
            btnRegisterBatchInStock.Enabled = True
        Else
            'If no batch is selected or the dgv is empty, informs user.
            MsgBox("Velg en vareforsendelse")
        End If
    End Sub

    Private Sub btnRegisterBatchInStock_Click(sender As Object, e As EventArgs) Handles btnRegisterBatchInStock.Click
        'Registers selected row and shelf, receive-date (registration) and expiry date.
        'Saves to database.
        If StockManager.checkFreeLocation(numRow.Text, numShelf.Text) Then
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
        Else
            MsgBox("Lokasjon er opptatt. Du kan velge lokasjon manuelt, eller be systemet " _
                   & "finne en automatisk.")
        End If
    End Sub

    Private Sub dtgLogisticsRegisterCommodity_SelectionChanged(sender As Object, e As EventArgs) Handles dtgLogisticsRegisterCommodity.SelectionChanged
        'When selecting a different batch from the dgv, user has to select row and shelf over again
        'to make the batch registration button active.
        numRow.Text = ""
        numShelf.Text = ""
        btnRegisterBatchInStock.Enabled = False
    End Sub

    Private Sub locInputCheck()
        'Activates registration button when valid values are entered for row and shelf.
        If numRow.Text <> "" And numShelf.Text <> "" Then
            If numRow.Text >= 1 And numRow.Text <= rowMax Then
                If numShelf.Text >= 1 And numShelf.Text <= shelfMax Then
                    btnRegisterBatchInStock.Enabled = True
                Else
                    btnRegisterBatchInStock.Enabled = False
                End If
            Else
                btnRegisterBatchInStock.Enabled = False
            End If
        Else
            btnRegisterBatchInStock.Enabled = False
        End If
    End Sub

    'These numeric textboxes only allow integers, so there is no need to check isnumeric in code.
    'The locInputCheck checks if entered values are valid before activating registration button.
    Private Sub numRow_TextChanged(sender As Object, e As EventArgs) Handles numRow.TextChanged
        locInputCheck()
    End Sub

    Private Sub numShelf_TextChanged(sender As Object, e As EventArgs) Handles numShelf.TextChanged
        locInputCheck()
    End Sub
End Class
