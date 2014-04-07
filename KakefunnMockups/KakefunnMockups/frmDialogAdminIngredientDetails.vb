Public Class frmDialogAdminIngredientDetails

    Private pub As Boolean = False
    Public newIngr As Boolean
    Public varenr As Integer
    Private existingItem As ingredient
    Private IsDirty As Boolean = False

    Private Sub ddlUnitsLoad()
        'Populating combobox with unit types.
        Dim query = From x In DBM.Instance.units Select x
        Dim unitType As unit
        For Each unitType In query
            ddlUnitType.Items.Add(unitType.name)
        Next
    End Sub

    Private Sub dtgBatchLoad()
        Dim factorProfit As Double

        'Filling form with information for the selected ingredient
        If Not newIngr Then
            Me.Text = "Redigerer detaljer for varenummer " & varenr
            existingItem = DBM.Instance.ingredients.Find(varenr)
            txtName.Text = existingItem.name
            txtDescr.Text = existingItem.description
            ddlUnitType.Text = existingItem.unit.name
            numCal.Text = existingItem.kilocaloriesPerUnit
            numVAT.Text = existingItem.vat
            Dim profit As ingredientPrice = (From x In DBM.Instance.ingredientPrices _
                                             Where x.id = varenr Order By x.date Descending _
                                             Select x).FirstOrDefault()
            If profit Is Nothing Then
                numProfit.Text = ""
                factorProfit = 0
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

            Dim batchQuery = (From x In DBM.Instance.batches _
                              Select x).ToList()

            lblNumInStockValue.Text = StockManager.getInStock(varenr, batchQuery)

            Dim batches = From x In DBM.Instance.batches Where x.ingredientId = varenr Select x
            dtgBatches.Rows.Clear()
            For Each row In batches
                dtgBatches.Rows.Add(row.id, row.expires, row.unitCount, row.unitPurchasingPrice, (row.unitPurchasingPrice * factorProfit))
            Next
        Else
            Me.Text = "Oppretter ny vare"
        End If
    End Sub

    Private Sub saveIngredient()
        Dim ingredientIndex As Integer
        Dim i As ingredient

        'Deklaring i as a new ingredient, or equal to a selected ingredient.
        If newIngr Then
            i = New ingredient()
        Else
            i = existingItem
        End If

        i.name = txtName.Text
        i.description = txtDescr.Text

        'Checking if unit already exists in db and adds it if not.
        'Skal vi velge ut noen måleenheter og ha en forhåndsdefinert liste her?
        Dim u As unit = (From data In DBM.Instance.units Where data.name = ddlUnitType.Text Select data).FirstOrDefault()
        If u Is Nothing Then
            u = New unit() With {.name = ddlUnitType.Text}
        End If

        i.unit = u
        i.kilocaloriesPerUnit = numCal.Text
        i.vat = numVAT.Text
        i.published = pub

        'Adds ingredient if it's new, saves changes to existing ingredient
        Try
            If newIngr Then
                DBM.Instance.ingredients.Add(i)
            End If
            DBM.Instance.SaveChanges()
        Catch ex As Entity.Validation.DbEntityValidationException
            MsgBox(ex.ToString)
        End Try

        'Finds the ingredient index/varenr in the db.
        Dim iFind As ingredient = (From data In DBM.Instance.ingredients Where data.name = txtName.Text Select data).FirstOrDefault
        ingredientIndex = iFind.id

        'Creates a new entry for ingredient prise, pk = id+date
        Dim ip As ingredientPrice
        ip = New ingredientPrice() With {.markUpPercentage = numProfit.Text, .date = Date.Today, .id = ingredientIndex}

        'Creates a new entry for price if the date is different from the previously entered price.
        'Updates the existing record if the dates match.
        Try
            If newIngr Then
                DBM.Instance.ingredientPrices.Add(ip)
            ElseIf Not newIngr Then
                Dim ipDB As ingredientPrice = (From x In DBM.Instance.ingredientPrices _
                                              Where x.id = ingredientIndex _
                                              Order By x.date Descending).FirstOrDefault()
                If ipDB Is Nothing Then
                    DBM.Instance.ingredientPrices.Add(ip)
                Else
                    If ipDB.date = Date.Today Then
                        ip = ipDB
                        ip.markUpPercentage = numProfit.Text
                    Else
                        DBM.Instance.ingredientPrices.Add(ip)
                    End If
                End If
            End If
            DBM.Instance.SaveChanges()
        Catch ex As Entity.Validation.DbEntityValidationException
            MsgBox(ex.ToString)
        End Try

        newIngr = False
        varenr = (From x In DBM.Instance.ingredients _
                 Where x.name = txtName.Text _
                 Select x.id).FirstOrDefault()
        IsDirty = False
    End Sub

    Private Sub frmDialogAdminIngredientDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ddlUnitsLoad()
        dtgBatchLoad()

        'Tracking changes in controls. Used to trigger dialog if user tries to exit form without saving changes.
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

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        saveIngredient()
        dtgBatchLoad()
        ddlUnitsLoad()
        grpStock.Enabled = True
    End Sub

    Private Sub chkPub_CheckedChanged(sender As Object, e As EventArgs) Handles chkPub.CheckedChanged
        If Not pub Then
            pub = True
        Else
            pub = False
        End If
    End Sub

    Private Sub btnSaveClose_Click(sender As Object, e As EventArgs) Handles btnSaveClose.Click
        saveIngredient()
        frmAdminIngredient.txtSearch.Text = txtName.Text
        frmAdminIngredient.btnSearch.PerformClick()
        Me.Close()
    End Sub

    Private Sub btnAbort_Click(sender As Object, e As EventArgs) Handles btnAbort.Click
        Me.Close()
    End Sub

    Private Sub frmDialogAdminIngredientDetails_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If IsDirty Then
            Dim response = MessageBox.Show("Du har ulagrede endringer. Vil du lukke redigeringsvinduet likevel?", _
                                           "Bekreft lukking", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If response = 7 Then
                e.Cancel = True
            End If
        End If
    End Sub
End Class
