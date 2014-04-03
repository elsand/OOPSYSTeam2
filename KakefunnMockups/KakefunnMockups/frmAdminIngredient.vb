Public Class frmAdminIngredient

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub frmAdminIngredient_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        'Opens frmDialogAdminIngredientDetails for adding new ingredients to the database.
        Dim frm As frmDialogAdminIngredientDetails
        frm = New frmDialogAdminIngredientDetails()
        frm.grpStock.Enabled = False
        frm.btnSave.Text = "Lagre"
        frm.Show()
    End Sub
End Class
