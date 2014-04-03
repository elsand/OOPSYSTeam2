Public Class frmDialogAdminIngredientDetails
    Private Sub frmDialogAdminIngredientDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Db As Db = New Db

        'Populating combobox with unit types on form load.
        Dim query = From it In Db.units Select it
        Dim unitType As unit
        For Each unitType In query
            ComboBox1.Items.Add(unitType.name)
        Next

    End Sub
End Class
