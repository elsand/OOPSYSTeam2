Public Class frmAdminCake
    Private ingQuery As List(Of Kakefunn.ingredient)
    Private priceQuery As List(Of Kakefunn.ingredientPrice)
    Private batchQuery As List(Of Kakefunn.batch)
    Private selList As DataTable
    Private factor As Double
    Private published As Boolean = False

    Private Sub frmAdminCake_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ingQuery = (From x In DBM.Instance.ingredients _
                    Select x).ToList()

        priceQuery = (From x In DBM.Instance.ingredientPrices _
                      Select x).ToList()

        batchQuery = (From x In DBM.Instance.batches _
                      Select x).ToList()

        selList = New DataTable()
        Dim idColumn As New DataColumn("ID", Type.GetType("System.Int32"))
        Dim nameColumn As New DataColumn("Name", Type.GetType("System.String"))
        Dim unitColumn As New DataColumn("Unit", Type.GetType("System.String"))
        Dim amountColumn As New DataColumn("Amount", Type.GetType("System.Double"))
        Dim combineColumn As New DataColumn("Combined", Type.GetType("System.String"))
        Dim priceColumn As New DataColumn("Price", Type.GetType("System.Double"))

        selList.Columns.Add(idColumn)
        selList.Columns.Add(nameColumn)
        selList.Columns.Add(unitColumn)
        selList.Columns.Add(amountColumn)
        selList.Columns.Add(combineColumn)
        selList.Columns.Add(priceColumn)
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

    Private Sub showPrices()
        If selList.Rows.Count <> 0 Then
            lblIngredientsPrice.Text = "Ingredienspris: " & selList.Compute("Sum(Price)", "")
            lblSalePrice.Text = "Salgspris: " & selList.Compute("Sum(Price)", "") * factor
        End If
    End Sub

    Private Sub btnAddIngredients_Click(sender As Object, e As EventArgs) Handles btnAddIngredients.Click
        'Adding ingredients to cake
        Dim selIndex As Integer = CInt(lstAvailableIngredients.SelectedValue.ToString())
        Dim selName As String = lstAvailableIngredients.Text
        Dim unitType As String = lblMeasureUnit.Text
        Dim unitAmount As Double = numAmount.Text
        Dim priceMarkup As Double = (From x In priceQuery Where x.id = selIndex _
                                     Order By x.date Descending Select x.markUpPercentage).FirstOrDefault()
        Dim ingPrice As Double = CDbl(StockManager.getPurchasingPrice(selIndex, "avg", batchQuery))

        Dim dr As DataRow
        dr = selList.NewRow()
        dr("ID") = selIndex
        dr("Name") = selName
        dr("Unit") = unitType
        dr("Amount") = unitAmount
        dr("Combined") = selName & " - " & unitAmount & " " & unitType
        dr("Price") = ingPrice * ((priceMarkup / 100) + 1) * unitAmount
        selList.Rows.Add(dr)

        showPrices()

        With lstSelectedIngredients
            .DataSource = selList
            .DisplayMember = ("Combined")
            .ValueMember = ("ID")
        End With

        numAmount.Text = ""
        numAmount.Enabled = False
        numAmount.BackColor = DefaultBackColor
        btnAddIngredients.Enabled = False
        btnAddIngredients.BackColor = DefaultBackColor
    End Sub

    Private Sub btnRemoveIngredients_Click(sender As Object, e As EventArgs) Handles btnRemoveIngredients.Click
        If lstSelectedIngredients.SelectedIndex <> -1 Then
            Dim selIndex As Integer = CInt(lstSelectedIngredients.SelectedValue.ToString())

            For Each row As DataRow In selList.Rows
                If row.Item("ID") = selIndex Then
                    selList.Rows(selList.Rows.IndexOf(row)).Delete()
                    Exit For
                End If
            Next
        End If
        showPrices()
    End Sub
    Private Function isValid() As Boolean
        If selList.Rows.Count = 0 Then
            Return False
        End If

        If txtNameCake.Text = "" Then
            Return False
        End If

        If txtProcedure.Text = "" Then
            Return False
        End If
        Return True
    End Function


    Private Sub txtNameCake_TextChanged(sender As Object, e As EventArgs) Handles txtNameCake.TextChanged
        'Enabling other controls when cake name is entered.
        grpIngredients.Enabled = True
        lblProcedure.Enabled = True
        txtProcedure.Enabled = True
        MarkUps.Enabled = True
        numMarkUps.Enabled = True
        lblIngredientsPrice.Enabled = True
        lblSalePrice.Enabled = True
        numAmount.Enabled = False
        btnAddIngredients.Enabled = False
        btnSave.Enabled = True
        numMarkUps.Text = 40
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If isValid() Then
            Dim newCake As cake = New cake()
            newCake.name = txtNameCake.Text
            newCake.markupPercentage = numMarkUps.Text
            newCake.recipe = txtProcedure.Text
            If published Then
                newCake.published = True
            End If
            Try
                DBM.Instance.cakes.Add(newCake)
                DBM.Instance.SaveChanges()
            Catch ex As Entity.Validation.DbEntityValidationException
                MsgBox(ex.ToString)
            End Try

            Dim cakeID As Integer = (From x In DBM.Instance.cakes _
                                     Where x.name = txtNameCake.Text _
                                     Select x.id).FirstOrDefault()

            For Each row As DataRow In selList.Rows
                MsgBox(row.Item("ID") & " " & row.Item("Amount"))

                Dim cakeIng As cake_has_ingredient = New cake_has_ingredient()
                cakeIng.cakeId = cakeID
                cakeIng.ingredientId = CInt(row.Item("ID"))
                cakeIng.amount = CDbl(row.Item("Amount"))
                Try
                    DBM.Instance.cake_has_ingredient.Add(cakeIng)
                    DBM.Instance.SaveChanges()
                Catch ex As Entity.Validation.DbEntityValidationException
                    MsgBox(ex.ToString)
                End Try
            Next
        End If
    End Sub

    Private Sub lstAvailableIngredients_MouseClick(sender As Object, e As MouseEventArgs) Handles lstAvailableIngredients.MouseClick
        'Shows unit type in label.
        If lstAvailableIngredients.SelectedIndex <> -1 Then
            lblMeasureUnit.Text = (From x In DBM.Instance.ingredients _
                                   Where x.id = CInt(lstAvailableIngredients.SelectedValue.ToString()) _
                                   Select x.unit.name).FirstOrDefault()
            numAmount.Enabled = True
            numAmount.BackColor = Color.Yellow
        End If
    End Sub

    Private Sub numAmount_TextChanged(sender As Object, e As EventArgs) Handles numAmount.TextChanged
        btnAddIngredients.Enabled = True
        btnAddIngredients.BackColor = Color.Yellow
    End Sub

    Private Sub numMarkUps_TextChanged(sender As Object, e As EventArgs) Handles numMarkUps.TextChanged
        If numMarkUps.Text = "" Then
            factor = 1
        ElseIf CInt(numMarkUps.Text) >= 0 And CInt(numMarkUps.Text) <= 100 Then
            factor = (CInt(numMarkUps.Text) / 100) + 1
        Else
            MsgBox("Oppgi avansen som et heltall mellom 0 og 100")
        End If

        showPrices()
    End Sub

    Private Sub chkPublished_CheckedChanged(sender As Object, e As EventArgs) Handles chkPublished.CheckedChanged
        If Not published Then
            published = True
        Else
            published = False
        End If
    End Sub

    Private Sub txtSearchCake_TextChanged(sender As Object, e As EventArgs) Handles txtSearchCake.TextChanged
        'Veldig ikke ferdig!
        Dim cakeQuery = (From x In DBM.Instance.cakes _
                         Where x.name.Contains(txtSearchCake.Text) _
                         Select Kakenr = x.id, Navn = x.name).ToList()

        For Each row In cakeQuery
        Next

        Dim cakeQuery2 = (From x In DBM.Instance.cakes _
                          Join y In DBM.Instance.cake_has_ingredient _
                          On x.id Equals y.cakeId _
                          Join z In DBM.Instance.ingredients _
                          On y.ingredientId Equals z.id _
                          Where x.name.Contains(txtSearchCake.Text) _
                          Select z.id, z.name, y.amount).ToList()

        For Each row In cakeQuery2
            MsgBox(row.id & ". " & row.name & ": Antall: " & row.amount)
        Next

        With dtgCake
            .DataSource = cakeQuery
        End With
    End Sub
End Class
