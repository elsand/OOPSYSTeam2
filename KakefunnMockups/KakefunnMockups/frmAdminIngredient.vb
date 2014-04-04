﻿Public Class frmAdminIngredient

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub frmAdminIngredient_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        'Opens frmDialogAdminIngredientDetails for adding new ingredients to the database.
        Dim frm As frmDialogAdminIngredientDetails
        frm = New frmDialogAdminIngredientDetails()
        frm.grpStock.Enabled = False
        frm.btnSave.Text = "Lagre"
        frm.Show()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        'It's a start. Needs to do calculations for BDG-columns ++. Made this to get search-results for testing
        'editing ingredients in frmDialogAdminIngredientDetails.vb
        dtgResults.Columns.Clear()
        Dim query = (From x In DBM.Instance.ingredients _
                     Where x.name.Contains(txtSearch.Text) _
                     Select Varenr = x.id, Navn = x.name).ToList()
        'Dim query = (From x In DBM.Instance.ingredients _
        '            Join y In DBM.Instance.batches On x.id Equals y.ingredientId _
        '           Join z In DBM.Instance.ingredientPrices On x.id Equals z.id _
        '          Where x.name.Contains(txtSearch.Text) _
        '         Select Varenr = x.id, Navn = x.name).ToList()
        dtgResults.DataSource = query

    End Sub
End Class
