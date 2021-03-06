﻿''' <summary>
''' This dialog is for registering and editing ingredients.
''' Last edited 22.04.14
''' </summary>
''' <remarks></remarks>
Public Class frmDialogAdminIngredientDetails
    Private pub As Boolean = False
    Public newIngr As Boolean
    Public varenr As Integer
    Private existingItem As Ingredient
    Private IsDirty As Boolean = False

    ''' <summary>
    ''' Populating combobox with unit types.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ddlUnitsLoad()
        Dim query = From x In DBM.Instance.Units Select x
        Dim unitType As Unit
        For Each unitType In query
            ddlUnitType.Items.Add(unitType.name)
        Next
    End Sub

    ''' <summary>
    ''' Filling form with information for the selected ingredient.
    ''' If the form is started to register a new ingredient, only the title is changed.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub dtgBatchLoad()
        Dim factorProfit As Double
        If Not newIngr Then 'Showing details for existing ingredient.
            Me.Text = "Redigerer detaljer for varenummer " & varenr
            existingItem = DBM.Instance.Ingredients.Find(varenr)
            txtName.Text = existingItem.name
            txtDescr.Text = existingItem.description
            ddlUnitType.Text = existingItem.Unit.name
            numCal.Text = existingItem.kilocaloriesPerUnit
            numVAT.Text = existingItem.vat
            Dim profit As IngredientPrice = (From x In DBM.Instance.IngredientPrices _
                                             Where x.id = varenr Order By x.date Descending _
                                             Select x).FirstOrDefault()
            If profit Is Nothing Then
                numProfit.Text = ""
                factorProfit = 1
            Else
                numProfit.Text = profit.markUpPercentage
                factorProfit = (profit.markUpPercentage / 100) + 1
            End If
            If existingItem.published Then
                chkPub.Checked = True
                pub = True
            Else
                chkPub.Checked = False
                pub = False
            End If

            Dim batchQuery = (From x In DBM.Instance.Batches _
                              Select x).ToList()

            lblNumInStockValue.Text = StockHelper.getInStock(varenr, batchQuery)

            Dim batches = From x In DBM.Instance.Batches Where x.Ingredient.id = varenr Select x
            dtgBatches.Rows.Clear()
            For Each row In batches
                dtgBatches.Rows.Add(row.id, row.expires, row.unitCount, row.unitPurchasingPrice, (row.unitPurchasingPrice * factorProfit))
            Next
        Else 'Creating new ingredient.
            Me.Text = "Oppretter ny vare"
        End If
    End Sub

    ''' <summary>
    ''' Saving details for new or existing ingredient.
    ''' See detailed comments in sub.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub saveIngredient()
        Dim ingredientIndex As Integer
        Dim i As Ingredient

        'Deklaring i as a new ingredient, or equal to a selected ingredient.
        If newIngr Then
            i = DBM.Instance.Ingredients.Create(Of Ingredient)()
        Else
            i = existingItem
        End If

        i.name = txtName.Text
        i.description = txtDescr.Text

        'Checking if unit type already exists in db and adds it if not.
        Dim u As Unit = (From data In DBM.Instance.Units Where data.name = ddlUnitType.Text Select data).FirstOrDefault()
        If u Is Nothing Then
            u = New Unit() With {.name = ddlUnitType.Text}
        End If

        i.Unit = u
        i.kilocaloriesPerUnit = numCal.Text
        i.vat = numVAT.Text
        i.published = pub

        'Adds ingredient if it's new, else saves changes to existing ingredient
        Try
            If newIngr Then
                DBM.Instance.Ingredients.Add(i)
            End If
            DBM.Instance.SaveChanges()
        Catch ex As Entity.Validation.DbEntityValidationException
            MsgBox(ex.ToString)
        End Try

        'Finds the ingredient index/varenr in the db.
        Dim iFind As Ingredient = (From data In DBM.Instance.Ingredients Where data.name = txtName.Text Select data).FirstOrDefault
        ingredientIndex = iFind.id

        'Creates a new entry for ingredient price, pk = id+date
        Dim ip As IngredientPrice
        ip = New IngredientPrice() With {.markUpPercentage = numProfit.Text, .date = Date.Today, .id = ingredientIndex}

        'Creates a new entry for price if the date is different from the previously entered price.
        'Updates the existing record if the dates match.
        Try
            If newIngr Then
                DBM.Instance.IngredientPrices.Add(ip)
            ElseIf Not newIngr Then
                Dim ipDB As IngredientPrice = (From x In DBM.Instance.IngredientPrices _
                                              Where x.id = ingredientIndex _
                                              Order By x.date Descending).FirstOrDefault()
                If ipDB Is Nothing Then
                    DBM.Instance.IngredientPrices.Add(ip)
                Else
                    If ipDB.date = Date.Today Then
                        ip = ipDB
                        ip.markUpPercentage = numProfit.Text
                    Else
                        DBM.Instance.IngredientPrices.Add(ip)
                    End If
                End If
            End If
            DBM.Instance.SaveChanges()
        Catch ex As Entity.Validation.DbEntityValidationException
            MsgBox("Saving ingredient to database failed: " & ex.ToString)
        End Try

        'Logging the event
        If newIngr Then
            KakefunnEvent.saveSystemEvent("Ingredienser", "Opprettet ny ingrediens: " & i.id & " " & i.name)
        Else
            KakefunnEvent.saveSystemEvent("Ingredienser", "Endret ingrediensen: " & i.id & " " & i.name)
        End If

        newIngr = False
        varenr = (From x In DBM.Instance.Ingredients _
                 Where x.name = txtName.Text _
                 Select x.id).FirstOrDefault()
        IsDirty = False
    End Sub

    ''' <summary>
    ''' Fill ddl for unit types, and if relevant an existing ingredient. Also loads tracking on some
    ''' controls to prevent the user from exiting without saving.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub frmDialogAdminIngredientDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ddlUnitsLoad()
        dtgBatchLoad()

        For Each c As Control In Me.grpIngredient.Controls
            If c.GetType().Name = "TextBox" Then
                AddHandler CType(c, TextBox).TextChanged, Sub(s, ev) Me.IsDirty = True
            ElseIf c.GetType().Name = "CheckBox" Then
                AddHandler CType(c, CheckBox).CheckedChanged, Sub(s, ev) Me.IsDirty = True
            ElseIf c.GetType().Name = "ComboBox" Then
                AddHandler CType(c, ComboBox).TextChanged, Sub(s, ev) Me.IsDirty = True
            ElseIf c.GetType().Name = "NumericTextbox" Then
                AddHandler CType(c, NumericTextbox).TextChanged, Sub(s, ev) Me.IsDirty = True
            End If
        Next
    End Sub

    ''' <summary>
    ''' Calls procedures to save new ingredient or update an existing one. btnSave_Click handles two buttons,
    ''' one saves to db and keeps the form open, while the other saves and returns to frmAdminIngredient.vb.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click, btnSaveClose.Click
        Dim btn As Button = CType(sender, Button)
        Dim saveType As Integer = btn.Tag
        If isValid() Then
            saveIngredient()
            If saveType = 1 Then
                dtgBatchLoad()
                ddlUnitsLoad()
                grpStock.Enabled = True
                IsDirty = False
            Else
                frmAdminIngredient.txtSearch.Text = txtName.Text
                frmAdminIngredient.btnSearch.PerformClick()
                frmAdminIngredient.txtSearch.Text = ""
                Me.Close()
            End If
        Else
            'Error message, content missing in form.
            MsgBox("Sjekk at alle felter er utfylt", MsgBoxStyle.Exclamation, "Advarsel")
        End If
    End Sub

    ''' <summary>
    ''' Catches changes for the published checkbox.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub chkPub_CheckedChanged(sender As Object, e As EventArgs) Handles chkPub.CheckedChanged
        If Not pub Then
            pub = True
        Else
            pub = False
        End If
    End Sub

    ''' <summary>
    ''' Close form.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub btnAbort_Click(sender As Object, e As EventArgs) Handles btnAbort.Click
        Me.Close()
    End Sub

    ''' <summary>
    ''' Triggers on exit if there are unsaved content in the form. The user can stop the form from closing 
    ''' if it was by mistake
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub frmDialogAdminIngredientDetails_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If IsDirty Then
            Dim response = MessageBox.Show("Du har ulagrede endringer. Vil du lukke redigeringsvinduet likevel?", _
                                           "Bekreft lukking", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If response = 7 Then
                e.Cancel = True
            End If
        End If
    End Sub

    ''' <summary>
    ''' Validates registration form content.
    ''' </summary>
    ''' <remarks></remarks>
    Private Function isValid() As Boolean
        If txtName.Text = "" Then
            Return False
        End If
        If txtDescr.Text = "" Then
            Return False
        End If
        If ddlUnitType.Text = "" Then
            Return False
        End If
        If numCal.Text = "" Then
            Return False
        End If
        If numProfit.Text = "" Then
            Return False
        End If
        If numVAT.Text = "" Then
            Return False
        End If
        Return True
    End Function

    ''' <summary>
    ''' Readies the form for registering a new ingredient.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub restartReg()
        newIngr = True
        txtName.Text = ""
        txtDescr.Text = ""
        ddlUnitType.Items.Clear()
        ddlUnitsLoad()
        numCal.Text = ""
        numProfit.Text = ""
        numVAT.Text = ""
        chkPub.Checked = False
        grpStock.Enabled = False
        dtgBatches.Rows.Clear()
        lblNumInStockText.Text = ""
        IsDirty = False
        Me.Text = "Oppretter ny vare"
    End Sub

    ''' <summary>
    ''' Warns user if there are unsaved changes, then calls procedure to reset form.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub btnNewIngredient_Click(sender As Object, e As EventArgs) Handles btnNewIngredient.Click
        If IsDirty Then
            Dim response = MessageBox.Show("Du har ulagrede endringer. Vil du forkaste disse og registrere ny ingrediens?", _
                                           "Bekreft", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If response = 6 Then
                restartReg()
            End If
        Else
            restartReg()
        End If
    End Sub
End Class
