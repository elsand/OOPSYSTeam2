Public Class frmDialogAdminIngredientDetails
    Private Sub frmDialogAdminIngredientDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Db As Db = New Db

        'Populating combobox with unit types on form load.
        Dim query = From data In Db.units Select data
        Dim unitType As unit
        For Each unitType In query
            ddlUnitType.Items.Add(unitType.name)
        Next

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'Dim unit As String
        Dim db As New Db()
        Dim query = From data In db.ingredients Select data
        Dim i As ingredient
        'Dim u As unit

        'i = New ingredient()
        'Checking for content in unit-ddl.
        If ddlUnitType.Text = "" Then
            MsgBox("Velg eksisterende eller skriv inn ny enhetstype.", MsgBoxStyle.Exclamation, "Stopp!")
        ElseIf ddlUnitType.SelectedIndex >= 0 Then
            'i.unit.name = ddlUnitType.Text
        Else
            db.units.Add(New unit With {.name = ddlUnitType.Text})
            'i.unit.name = ddlUnitType.Text
        End If

        db.ingredients.Add(i)
        db.SaveChanges()

        'For Each i In query
        'If i.name = txtName.Text Then
        'MsgBox("Ingrediensen finnes allerede", MsgBoxStyle.Exclamation, "Stopp!")
        'Else
        '   i.name = txtName.Text
        '      i.
        ' End If
        'Next

    End Sub
End Class
