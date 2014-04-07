﻿''' <summary>
''' Handles orders to the system
''' </summary>
''' <remarks>
''' TODO:
''' - Handle dirty forms
''' - Validation
''' - Handle deletion
''' - Only load some subset (no deleted batches, only non-delivered batches or recently received batches)
''' - Handle writing reports
''' </remarks>
''' 

Public Class frmAdminBatch

    Dim notInStorageText As String
    Dim IsNewRecord As Boolean = True
    Dim IsDirty As Boolean = False
    Dim currentRecord As Batch
    Dim batchBindingListView As BindingListView(Of Batch)

    Private Sub frmAdminBatch_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Set some defaults from design mode so that we can toggle corretly
        notInStorageText = lblStorageStatus.Text

        ' Load data from batches and bind to datagridview
        DBM.Instance.Batches.Load()

        ' Make binding list view from the bindinglist we get from EF
        batchBindingListView = New BindingListView(Of Batch)(DBM.Instance.Batches.Local.ToBindingList())
        ' Set it as the datasource, and presto, we have filtering et.al.
        BatchBindingSource.DataSource = batchBindingListView

        ' Set up autocomplete for ingredient name
        Dim ing = From x As Ingredient In DBM.Instance.Ingredients Select x.name Order By name
        Dim acSource As AutoCompleteStringCollection = New AutoCompleteStringCollection()
        acSource.AddRange(ing.ToArray())
        With txtIngredient
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = AutoCompleteSource.CustomSource
            .AutoCompleteCustomSource = acSource
        End With

        ' Handle display of correct unit type
        AddHandler txtIngredient.Leave, AddressOf ValidateAndUpdateUnitTypeLabel

        ' Handle swapping between price per unit and per batch
        AddHandler ddlPricePer.SelectedIndexChanged, AddressOf UpdateUnitPriceText

    End Sub

    Private Sub UpdateUnitPriceText()
        If txtPurchasingPrice.Text = "" OrElse txtNumUnits.Text = "" Then
            Exit Sub
        End If
        If ddlPricePer.SelectedIndex = 0 Then
            txtPurchasingPrice.Text = CType(txtPurchasingPrice.DecimalValue / txtNumUnits.IntValue, String)
        Else
            txtPurchasingPrice.Text = CType(txtPurchasingPrice.DecimalValue * txtNumUnits.IntValue, String)
        End If

    End Sub

    Private Sub ValidateAndUpdateUnitTypeLabel()
        If txtIngredient.Text = "" Then
            Exit Sub
        End If
        Dim ing As Ingredient = DBM.Instance.Ingredients.Where(Function(x) x.name = txtIngredient.Text).FirstOrDefault()
        If ing Is Nothing Then
            lblUnit.Text = ""
            MsgBox("Du må velge en ingrediens fra databasen.")
            txtIngredient.Focus()
        Else
            lblUnit.Text = ing.unit.name
        End If
    End Sub

    Private Sub BatchDataGridView_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dtgBatch.CellFormatting
        If dtgBatch.Columns(e.ColumnIndex).DataPropertyName.Equals("ingredient") Then
            e.Value = CType(e.Value, Ingredient).name
        End If
    End Sub

    Private Sub BatchDataGridView_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles dtgBatch.MouseDoubleClick

        If IsDirty AndAlso MsgBox("Du har ulagrede endringer. Vil du fortsette?", MsgBoxStyle.YesNo, "Ulagrede endringer") = MsgBoxResult.No Then
            Exit Sub
        End If

        ResetFields()

        Dim b As Batch = CType(dtgBatch.SelectedRows.Item(0).DataBoundItem, Batch)

        txtIngredient.Text = b.ingredient.name
        dtpExpected.Value = b.expected
        txtNumUnits.Text = b.unitCount
        lblUnit.Text = b.ingredient.unit.name

        If Not b.unitPurchasingPrice Is Nothing Then
            txtPurchasingPrice.Text = b.unitPurchasingPrice
        End If

        If b.registered Is Nothing Then
            lblStorageStatus.Text = notInStorageText
            dtpExpires.Enabled = False
        Else
            lblStorageStatus.Text = "Registrert på lager " & b.registered.ToString()
            dtpExpires.Enabled = True
            If Not b.expires Is Nothing Then
                dtpExpires.Value = b.expires
            End If
        End If

        UpdateActionStatus("Redigerer parti #" & b.id)
        IsNewRecord = False
        IsDirty = False
        currentRecord = b

    End Sub

    Private Sub ResetFields()
        txtIngredient.Text = ""
        dtpExpected.Value = Date.Today
        txtNumUnits.Text = ""
        lblUnit.Text = ""
        txtPurchasingPrice.Text = ""
        dtpExpires.Value = Date.Today
        dtpExpires.Enabled = False
        lblStorageStatus.Text = notInStorageText
        ddlPricePer.SelectedIndex = 0
        UpdateActionStatus()

        IsNewRecord = True
        IsDirty = False

    End Sub

    Private Sub btnNewBatch_Click(sender As Object, e As EventArgs) Handles btnNewBatch.Click
        If IsDirty AndAlso MsgBox("Du har ulagrede endringer. Vil du fortsette?", MsgBoxStyle.YesNo, "Ulagrede endringer") = MsgBoxResult.No Then
            Exit Sub
        End If

        ResetFields()
    End Sub

    Private Sub btnSaveBatch_Click(sender As Object, e As EventArgs) Handles btnSaveBatch.Click

        If Not ValidSubmission() Then
            Exit Sub
        End If

        Dim b As Batch
        If IsNewRecord Then
            b = New Batch()
            b.ordered = DateTime.Now
        Else
            b = currentRecord
        End If

        b.ingredient = DBM.Instance.Ingredients.Where(Function(x) x.name = txtIngredient.Text).FirstOrDefault()
        b.expected = dtpExpected.Value
        b.unitCount = txtNumUnits.IntValue
        If dtpExpires.Enabled Then
            b.expires = dtpExpires.Value
        Else
            b.expires = Nothing
        End If

        If Not txtPurchasingPrice.Text = "" Then
            If ddlPricePer.SelectedIndex = 0 Then
                b.unitPurchasingPrice = txtPurchasingPrice.DecimalValue
            Else
                b.unitPurchasingPrice = txtPurchasingPrice.DecimalValue / txtNumUnits.IntValue
            End If
        End If

        If IsNewRecord Then
            DBM.Instance.Batches.Add(b)
        End If

        UpdateActionStatus("Lagrer ...")

        DBM.Instance.SaveChanges()
        ' Dette under skal ikke være nødvendig!
        dtgBatch.Refresh()

        currentRecord = b
        IsNewRecord = False
        IsDirty = False

        UpdateActionStatus("Redigerer parti #" & b.id)

    End Sub

    Private Function ValidSubmission() As Boolean
        ' Implement
        Return True

    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Støtter ikke tekst-baserte filtre :(
        'BatchBindingSource.Filter = "unitCount > 400"


        batchBindingListView.ApplyFilter(Function(x) x.unitCount > 400)

        ' Kan alternativt gjøres som
        ' view.ApplyFilter(AddressOf BalanceFilter)
        '...
        ' Function UnitCountFilter(ByVal b as batch) as Boolean
        '   Return batch.unitCount > 1000
        'End Sub
        '

    End Sub
End Class
