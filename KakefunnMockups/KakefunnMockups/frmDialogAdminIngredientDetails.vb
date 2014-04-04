Public Class frmDialogAdminIngredientDetails

    Private pub As Boolean = False
    Public newIngr As Boolean
    Public varenr As Integer

    Private Sub ddlUnitsLoad()
        'Populating combobox with unit types.
        Dim query = From x In DBM.Instance.units Select x
        Dim unitType As unit
        For Each unitType In query
            ddlUnitType.Items.Add(unitType.name)
        Next
    End Sub

    Private Sub frmDialogAdminIngredientDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not newIngr Then
            Me.Text = "Redigerer detaljer for varenummer " & varenr
            Dim existingItem As ingredient = DBM.Instance.ingredients.Find(varenr)
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
            Else
                numProfit.Text = profit.markUpPercentage
            End If
            'chkPub.Checked = existingItem.published
        End If
        ddlUnitsLoad()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim ingredientIndex As Integer

        Dim i As ingredient = New ingredient()
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
            DBM.Instance.ingredients.Add(i)
            DBM.Instance.SaveChanges()
        Catch ex As Entity.Validation.DbEntityValidationException
            MsgBox(ex.ToString)
        End Try

        Dim iFind As ingredient = (From data In DBM.Instance.ingredients Where data.name = txtName.Text Select data).FirstOrDefault
        ingredientIndex = iFind.id

        Dim ip As New ingredientPrice()
        ip = New ingredientPrice() With {.markUpPercentage = numProfit.Text, .date = Date.Today, .id = ingredientIndex}

        Try
            DBM.Instance.ingredientPrices.Add(ip)
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
