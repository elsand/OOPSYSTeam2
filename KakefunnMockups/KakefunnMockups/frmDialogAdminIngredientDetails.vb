Public Class frmDialogAdminIngredientDetails
    Private Sub frmDialogAdminIngredientDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Populating combobox with unit types on form load.
        Dim query = From data In DBM.Instance.units Select data
        Dim unitType As unit
        For Each unitType In query
            ddlUnitType.Items.Add(unitType.name)
        Next

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
        i.kilocaloriesPerUnit = txtCal.Text
        i.vat = txtVAT.Text

        Try
            DBM.Instance.ingredients.Add(i)
            DBM.Instance.SaveChanges()
        Catch ex As Entity.Validation.DbEntityValidationException
            MsgBox(ex)
        End Try

        Dim iFind As ingredient = (From data In DBM.Instance.ingredients Where data.name = txtName.Text Select data).FirstOrDefault
        ingredientIndex = iFind.id

        MsgBox(ingredientIndex)

        Dim ip As New ingredientPrice()
        ip = New ingredientPrice() With {.markUpPercentage = txtProfit.Text, .date = Date.Today, .id = ingredientIndex}

        Try
            DBM.Instance.ingredientPrices.Add(ip)
            DBM.Instance.SaveChanges()
        Catch ex As Entity.Validation.DbEntityValidationException
            MsgBox(ex)
        End Try


    End Sub

End Class
