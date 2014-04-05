Public Class frmDialogAdminIngredientDetails

    Private pub As Boolean = False
    Public newIngr As Boolean
    Public varenr As Integer
    Private existingItem As ingredient

    Private Sub ddlUnitsLoad()
        'Populating combobox with unit types.
        Dim query = From x In DBM.Instance.units Select x
        Dim unitType As unit
        For Each unitType In query
            ddlUnitType.Items.Add(unitType.name)
        Next
    End Sub

    Private Sub frmDialogAdminIngredientDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ddlUnitsLoad()
        Dim factorProfit As Double
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

            Dim batches = From x In DBM.Instance.batches Where x.ingredientId = varenr Select x

            Dim inStock = From x In batches Where x.registered IsNot Nothing Select x.unitCount

            If inStock.Any Then
                lblNumInStockValue.Text = inStock.Sum()
            Else
                lblNumInStockValue.Text = 0
            End If

            For Each row In batches
                dtgBatches.Rows.Add(row.id, row.expires, row.unitCount, row.unitPurchasingPrice, (row.unitPurchasingPrice * factorProfit))
            Next
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim ingredientIndex As Integer
        Dim i As ingredient
        If newIngr Then
            i = New ingredient()
        Else
            i = existingItem
        End If

        i.name = txtName.Text
        i.description = txtDescr.Text

        Dim u As unit = (From data In DBM.Instance.units Where data.name = ddlUnitType.Text Select data).FirstOrDefault()
        If u Is Nothing Then
            u = New unit() With {.name = ddlUnitType.Text}
        End If

        i.unit = u
        i.kilocaloriesPerUnit = numCal.Text
        i.vat = numVAT.Text
        i.published = pub

        Try
            If newIngr Then
                DBM.Instance.ingredients.Add(i)
            End If
            DBM.Instance.SaveChanges()
        Catch ex As Entity.Validation.DbEntityValidationException
            MsgBox(ex.ToString)
        End Try

        Dim iFind As ingredient = (From data In DBM.Instance.ingredients Where data.name = txtName.Text Select data).FirstOrDefault
        ingredientIndex = iFind.id

        Dim ip As ingredientPrice
        ip = New ingredientPrice() With {.markUpPercentage = numProfit.Text, .date = Date.Today, .id = ingredientIndex}

        Try
            If newIngr Then
                DBM.Instance.ingredientPrices.Add(ip)
            ElseIf Not newIngr Then
                Dim ipDB As ingredientPrice = (From x In DBM.Instance.ingredientPrices _
                                              Where x.id = ingredientIndex _
                                              Order By x.date Descending).FirstOrDefault()
                If ipDB.date = Date.Today Then
                    ip = ipDB
                    ip.markUpPercentage = numProfit.Text
                Else
                    DBM.Instance.ingredientPrices.Add(ip)
                End If
            End If
            DBM.Instance.SaveChanges()
        Catch ex As Entity.Validation.DbEntityValidationException
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub chkPub_CheckedChanged(sender As Object, e As EventArgs) Handles chkPub.CheckedChanged
        If Not pub Then
            pub = True
        Else
            pub = False
        End If
    End Sub
End Class
