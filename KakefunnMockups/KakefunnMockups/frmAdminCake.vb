Public Class frmAdminCake
    Private ingQuery As List(Of Kakefunn.ingredient)

    Private Sub frmAdminCake_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ingQuery = (From x In DBM.Instance.ingredients _
                    Select x).ToList()
    End Sub

    Private Sub txtFilter_TextChanged(sender As Object, e As EventArgs) Handles txtFilter.TextChanged
        'Filtering ingredient list.
        Dim ingList = (From x In ingQuery _
                       Where x.name.Contains(txtFilter.Text) _
                       Select x).ToList()

        With lstAvailableIngredients
            .DataSource = ingList
            .DisplayMember = "name"
            .ValueMember = "id"
        End With

    End Sub

    Private Sub btnAddIngredients_Click(sender As Object, e As EventArgs) Handles btnAddIngredients.Click
        'Adding cake information.
        If lstAvailableIngredients.SelectedValue > 0 Then
            Dim newCake As cake = New cake()
            newCake.name = txtNameCake.Text

            Try

                DBM.Instance.cakes.Add(newCake)
                DBM.Instance.SaveChanges()

            Catch ex As Exception

            End Try
            Dim cakeID As Integer = (From x In DBM.Instance.cakes _
                                     Where x.name = txtNameCake.Text _
                                     Select x.id).FirstOrDefault()
            MsgBox(cakeID)

        End If
    End Sub

    Private Sub txtNameCake_TextChanged(sender As Object, e As EventArgs) Handles txtNameCake.TextChanged
        'Enabling other controls when cake name is entered.
        grpIngredients.Enabled = True
        lblProcedure.Enabled = True
        txtProcedure.Enabled = True
        MarkUps.Enabled = True
        txtMarkUps.Enabled = True
        lblIngredientsPrice.Enabled = True
        lblSalePrice.Enabled = True
        btnSave.Enabled = True
    End Sub
End Class
