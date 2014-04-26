Imports System.Configuration

''' <summary>
''' Handles orders to external vendors which will eventually end up in storage
''' </summary>
''' <remarks>
''' </remarks>
''' 
Public Class frmAdminBatch

    Dim notInStorageText As String
    Dim IsNewRecord As Boolean = True
    Dim currentRecord As Batch
    Dim batchBindingListView As BindingListView(Of Batch)

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub frmAdminBatch_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Set some defaults from design mode so that we can toggle corretly
        notInStorageText = lblStorageStatus.Text

        ' Load data from batches and bind to datagridview
        DBM.Instance.Batches.Load()

        ' Make binding list view from the bindinglist we get from EF
        batchBindingListView = New BindingListView(Of Batch)(DBM.Instance.Batches.Local.ToBindingList())

        ' Get how many days we should show received batches in the list from app settings
        Dim showRegisteredBatchesForDays As Integer = CType(ConfigurationManager.AppSettings.Get("admin.batch.showRegisteredBatchesForDays"), Integer)
        Dim cutoffDate As Date = Date.Now().AddDays(-showRegisteredBatchesForDays)

        '  Only show a subset (no deleted batches, only non-delivered batches or recently received batches)
        batchBindingListView.ApplyFilter(Function(b) _
                                             b.deleted Is Nothing _
                                             And (b.registered Is Nothing OrElse b.registered > cutoffDate) _
                                        )

        ' Set it as the datasource, and presto, we have filtering et.al.
        BatchBindingSource.DataSource = batchBindingListView



        ' Set up autocomplete for ingredient name
        Dim ac As AutoCompleteHelper = New AutoCompleteHelper(DBM.Instance.GetNameColumn("Ingredient", "deleted IS NULL"))
        ac.UseOn(txtIngredient)

        ' Handle display of correct unit type
        AddHandler txtIngredient.Leave, AddressOf ValidateAndUpdateUnitTypeLabel

        ' Handle swapping between price per unit and per batch
        AddHandler ddlPricePer.SelectedIndexChanged, AddressOf UpdateUnitPriceText

        ' Enable tracking of fields being changed so that we can prompt to save changes
        FormHelper.SetupDirtyTracking(Me)

        NewBatch()

    End Sub

    ''' <summary>
    ''' Handles updating the unit price depending on whether per-unit or per-nbatch is selected
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub UpdateUnitPriceText()
        If txtPurchasingPrice.Text = "" OrElse txtNumUnits.Text = "" Then
            Exit Sub
        End If
        If ddlPricePer.SelectedIndex = 0 Then
            txtPurchasingPrice.Text = CType(Math.Max(0.01, Math.Round(txtPurchasingPrice.DecimalValue / txtNumUnits.IntValue, 2)), String)
        Else
            txtPurchasingPrice.Text = CType(Math.Round(txtPurchasingPrice.DecimalValue * txtNumUnits.IntValue, 2), String)
        End If

    End Sub

    ''' <summary>
    ''' Checks if the user has typed, or via autocomplete selected, an existing ingredient. Also sets the unit type label depending on the selected ingredient.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ValidateAndUpdateUnitTypeLabel()
        If txtIngredient.Text = "" Then
            Exit Sub
        End If
        Dim ing As Ingredient = DBM.Instance.Ingredients.Where(Function(x) x.name = txtIngredient.Text And x.deleted Is Nothing).FirstOrDefault()
        If ing Is Nothing Then
            lblUnit.Text = ""
            MsgBox("Du må velge en ingrediens fra databasen.")
            txtIngredient.Focus()
        Else
            lblUnit.Text = ing.Unit.name
        End If
    End Sub

    ''' <summary>
    ''' Formats the columns in the datagridview
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub BatchDataGridView_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dtgBatch.CellFormatting
        Select Case dtgBatch.Columns(e.ColumnIndex).Name
            Case "dcIngredient"
                e.Value = CType(e.Value, Ingredient).name
            Case "dcUnitPurchasingPrice"
                e.Value = FormatHelper.Currency(e.Value)
        End Select
    End Sub

    ''' <summary>
    ''' Handles doubleclick on an ingredient, which starts editing
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub BatchDataGridView_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles dtgBatch.MouseDoubleClick

        If isDirty AndAlso MsgBox("Du har ulagrede endringer. Vil du fortsette?", MsgBoxStyle.YesNo, "Ulagrede endringer") = MsgBoxResult.No Then
            Exit Sub
        End If

        ' Start with a clean slate
        NewBatch()

        Dim b As Batch = CType(dtgBatch.SelectedRows.Item(0).DataBoundItem.Object, Batch)

        ' Set static columns
        txtIngredient.Text = b.Ingredient.name
        dtpExpected.Value = b.expected
        txtNumUnits.Text = b.unitCount
        lblUnit.Text = b.Ingredient.Unit.name

        ' Handle nullable columns
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

        ' Update status and flags
        UpdateActionStatus("Redigerer parti #" & b.id)
        IsNewRecord = False
        isDirty = False
        currentRecord = b

    End Sub

    ''' <summary>
    ''' Resets everything and readies a new batch
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub NewBatch()
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
        isDirty = False

    End Sub

    ''' <summary>
    ''' Handling click of the new batch button with dirty check
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnNewBatch_Click(sender As Object, e As EventArgs) Handles btnNewBatch.Click
        If isDirty AndAlso MsgBox("Du har ulagrede endringer. Vil du fortsette?", MsgBoxStyle.YesNo, "Ulagrede endringer") = MsgBoxResult.No Then
            Exit Sub
        End If
        NewBatch()
    End Sub

    ''' <summary>
    ''' Handles saving of new and existing batches
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
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

        ' At this point, we should be valid and can make some assumptions
        b.Ingredient = DBM.Instance.Ingredients.Where(Function(x) x.name = txtIngredient.Text And x.deleted Is Nothing).FirstOrDefault()
        b.expected = dtpExpected.Value
        b.unitCount = txtNumUnits.IntValue
        ' If this batch has not been registered yet, we set the initial batch size (unitCount will decrease as the batch is being used)
        If IsNewRecord OrElse b.registered Is Nothing Then
            b.origUnitCount = b.unitCount
        End If
        If dtpExpires.Enabled Then
            b.expires = dtpExpires.Value
        Else
            b.expires = Nothing
        End If

        ' Handle purchasing price
        If Not txtPurchasingPrice.Text = "" Then
            If ddlPricePer.SelectedIndex = 0 Then
                b.unitPurchasingPrice = txtPurchasingPrice.DecimalValue
            Else
                b.unitPurchasingPrice = Math.Max(0.01, Math.Round(txtPurchasingPrice.DecimalValue / txtNumUnits.IntValue, 2))
            End If
        End If

        If IsNewRecord Then
            DBM.Instance.Batches.Add(b)
        End If

        UpdateActionStatus("Lagrer ...")

        DBM.Instance.SaveChanges()

        Me.clearForm()



        If IsNewRecord Then
            KakefunnEvent.saveSystemEvent("Batches", "Created new batch #" & b.id)
        Else
            KakefunnEvent.saveSystemEvent("Batches", "Saved changes to batch #" & b.id)
        End If

        dtgBatch.Refresh()

        ' Switch to edit mode if new batch
        currentRecord = b
        IsNewRecord = False
        isDirty = False

        UpdateActionStatus("Redigerer parti #" & b.id)

    End Sub

    ''' <summary>
    ''' Checks that the batch is valid. If txtIngredient has something, it is already validated as a ingredient
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function ValidSubmission() As Boolean
        Dim err As String = ""

        If txtIngredient.Text = "" Then
            err = "Du må oppgi en ingrediens"
        ElseIf txtNumUnits.Text = "" Then
            err = "Du må oppgi et antall"
        End If

        If Not err = "" Then
            MessageBox.Show(err, "Feil i skjema", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        Return True

    End Function

    ''' <summary>
    ''' Handle deletion of batches
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnDeleteBatch_Click(sender As Object, e As EventArgs) Handles btnDeleteBatch.Click

        Dim b As Batch = CType(dtgBatch.SelectedRows.Item(0).DataBoundItem.Object, Batch)

        If MessageBox.Show("Er du sikker på du vil slette parti #" & b.id & "?", "Bekreft sletting", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If

        ' We don 't actually delete anything, just mark it in the database as such
        ' That way we can maintain history for our statistics reports

        UpdateActionStatus("Sletter parti #" & b.id)
        DBM.Instance.Batches.Attach(b)
        b.deleted = Date.Now()
        DBM.Instance.SaveChanges()
        KakefunnEvent.saveSystemEvent("Batches", "Deleted batch #" & b.id)

        ' If the batch we deleted is the one we were editing, start a new one
        If currentRecord.id = b.id Then
            NewBatch()
        End If

        UpdateActionStatus()

    End Sub

    ''' <summary>
    ''' Handles pressing the print orderlist-button. Renders a HTML-report that is displayed.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnPrintOrderList_Click(sender As Object, e As EventArgs) Handles btnPrintOrderList.Click

        Dim batchesToOrder As List(Of Batch) = DBM.Instance.Batches.Where(Function(b) b.registered Is Nothing).ToList()

        Dim r As HtmlReport = New HtmlReport() With {.Title = "Bestillingsliste"}
        r.Init()
        r.StartTable({"Bestilt i KF", "Ingrediens", "Antall", "Innkjøpspris"})
        Try
            For Each b As Batch In batchesToOrder
                r.AddRow({b.ordered, b.Ingredient.name, b.unitCount, FormatHelper.Currency(b.unitPurchasingPrice)})
            Next
        Catch ex As Exception
            MsgBox("Ingenting å skrive ut")

            Exit Sub

        End Try
        

        r.OpenInBrowser()

    End Sub

    Private Sub clearForm()
        Me.txtIngredient.Text = ""
        Me.txtNumUnits.Text = ""
        Me.txtPurchasingPrice.Text = ""
        Me.dtpExpected.Value = Date.Now


    End Sub
End Class
