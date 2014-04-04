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
        Dim unitType As unit
        Dim u = From data In DBM.Instance.units Where data.name = ddlUnitType.Text Select data

        If Not u.Any Then
            'legg inn ny enhetstype.

        End If


    End Sub
End Class
