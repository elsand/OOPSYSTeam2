'TODO
'Need to comment the code!!
'Implement function to set cake inactive.
'Last edited 14.04.14

Public Class frmAdminCakes
    Private ingQuery As List(Of Kakefunn.Ingredient)
    Private priceQuery As List(Of Kakefunn.ingredientPrice)
    Private batchQuery As List(Of Kakefunn.Batch)
    Private selList As DataTable
    Private factor As Double
    Private cakeArray() As Integer
    Private cakePriceArray() As Double
    Private arrayCounter As Integer
    Private cakeNew As Boolean
    Private existingCake As Cake

    Private Sub loadTables()
        'Fetches data from database. Local operations on the data are faster.
        ingQuery = (From x In DBM.Instance.Ingredients Select x).ToList()
        priceQuery = (From x In DBM.Instance.ingredientPrices Select x).ToList()
        batchQuery = (From x In DBM.Instance.Batches Select x).ToList()
    End Sub

    Private Sub bindCake()
        'Loading cakes in dtgCake
        Dim cakeQuery = (From x In DBM.Instance.Cakes Select x.id, x.name, x.published).ToList()
        CakeBindingSource.DataSource = cakeQuery
    End Sub

    Private Sub loadPrices()
        'Calculating prices for cakes in dtgCake
        Dim i As Integer
        ReDim cakeArray(-1)
        ReDim cakePriceArray(-1)

        For i = 0 To dtgCake.Rows.Count - 1
            Dim cakePrice As Double = 0
            Dim idx As Integer = CInt(dtgCake.Rows(i).Cells(0).Value)
            Dim cakeMarkUpFactor As Double = ((CDbl(dtgCake.Rows(i).Cells(3).Value)) / 100) + 1

            'For each cake in the list, get ingredient list.
            Dim ingList = (From x In DBM.Instance.RecipeLines _
                           Where x.Cake.id = idx _
                           Select IngredientId = x.Ingredient.id, x.amount).ToList()

            'Traverses ingredient list and sums ingredient prices.
            For Each row In ingList
                Dim purchasingPrice As Double = StockManager.getPurchasingPrice(row.IngredientId, "avg", batchQuery)
                Dim ingMarkUp As Double = (From x In priceQuery _
                                           Where x.id = row.IngredientId _
                                           Order By x.date Descending _
                                           Select x.markUpPercentage).FirstOrDefault()
                Dim ingMarkUpFactor As Double = (ingMarkUp / 100) + 1
                Dim amount As Double = row.amount
                Dim ingPrice As Double = purchasingPrice * ingMarkUpFactor * amount
                cakePrice += ingPrice
            Next

            'Saves the prices with cakeID in parallell arrays to avoid 
            'calculating prices every time dtgCake is updadet.
            ReDim Preserve cakeArray(i)
            ReDim Preserve cakePriceArray(i)
            cakeArray(i) = idx
            cakePriceArray(i) = cakePrice * cakeMarkUpFactor
            arrayCounter = i
        Next i
    End Sub

    Private Sub showPriceArrays()
        'Traverses dtgCake and adds prices to the price column.
        Dim i, j As Integer
        For i = 0 To dtgCake.Rows.Count - 1
            For j = 0 To arrayCounter
                If dtgCake.Rows(i).Cells(0).Value = cakeArray(j) Then
                    dtgCake.Rows(i).Cells(2).Value() = "kr. " & Format(cakePriceArray(j), "0.00")
                End If
            Next j
        Next i
    End Sub

    Private Sub frmAdminCake_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bindCake()
        loadTables()
        loadPrices()
        showPriceArrays()
    End Sub

    Private Sub structureSelList()
        'Creates structures i the datatable selList, used to add ingredients to cakes.
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
                       Where x.name.ToUpper().Contains(txtFilter.Text.ToUpper()) _
                       Select x).ToList()

        With lstAvailableIngredients
            .DataSource = ingList
            .DisplayMember = "name"
            .ValueMember = "id"
        End With

    End Sub

    Private Sub showPrices()
        If selList.Rows.Count <> 0 Then
            lblIngredientsPrice.Text = "Ingredienspris: kr. " & Format(selList.Compute("Sum(Price)", ""), "0.00")
            lblSalePrice.Text = "Salgspris: kr. " & Format(selList.Compute("Sum(Price)", "") * factor, "0.00")
        End If
    End Sub

    Private Function fillSelList(ByVal id As Integer, ByVal name As String, ByVal unit As String, _
                                 ByVal amount As Double, ByVal markup As Double, _
                                 ByVal price As Double) As Boolean
        Dim dr As DataRow
        dr = selList.NewRow()
        dr("ID") = id
        dr("Name") = name
        dr("Unit") = unit
        dr("Amount") = amount
        dr("Combined") = name & " - " & amount & " " & unit
        dr("Price") = price * ((markup / 100) + 1) * amount
        selList.Rows.Add(dr)

        With lstSelectedIngredients
            .DataSource = selList
            .DisplayMember = ("Combined")
            .ValueMember = ("ID")
        End With
        Return True
    End Function

    Private Sub btnAddIngredients_Click(sender As Object, e As EventArgs) Handles btnAddIngredients.Click
        'Adding ingredients to cake
        Dim selIndex As Integer = CInt(lstAvailableIngredients.SelectedValue.ToString())
        Dim selName As String = lstAvailableIngredients.Text
        Dim unitType As String = lblMeasureUnit.Text
        Dim unitAmount As Double = numAmount.Text
        Dim priceMarkup As Double = (From x In priceQuery Where x.id = selIndex _
                                     Order By x.date Descending Select x.markUpPercentage).FirstOrDefault()
        Dim ingPrice As Double = CDbl(StockManager.getPurchasingPrice(selIndex, "avg", batchQuery))
        fillSelList(selIndex, selName, unitType, unitAmount, priceMarkup, ingPrice)
        showPrices()

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
        If txtNameCake.Text = "" Then
            Return False
        End If
        Return True
    End Function

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If isValid() Then
            Dim cake As Cake
            If cakeNew Then
                cake = New Cake()
            Else
                cake = existingCake
                Dim removeList = (From x In DBM.Instance.RecipeLines _
                                  Where x.Cake.id = cake.id _
                                  Select x)
                For Each row In removeList
                    DBM.Instance.RecipeLines.Remove(row)
                Next
            End If

            cake.name = txtNameCake.Text
            cake.markupPercentage = numMarkUps.Text
            cake.recipe = txtProcedure.Text
            If chkPublished.Checked Then
                cake.published = True
            Else
                cake.published = False
            End If
            Try
                For Each row As DataRow In selList.Rows
                    Dim cakeIng As RecipeLine = New RecipeLine()
                    cakeIng.Ingredient = DBM.Instance.Ingredients.Find(CInt(row.Item("ID")))
                    cakeIng.amount = CDbl(row.Item("Amount"))
                    cake.RecipeLines.Add(cakeIng)
                Next

                If cakeNew Then
                    DBM.Instance.Cakes.Add(cake)
                End If
                DBM.Instance.SaveChanges()
            Catch ex As Entity.Validation.DbEntityValidationException
                MsgBox(ex.ToString)
            End Try
            bindCake()
            loadPrices()
            showPriceArrays()
        Else
            MsgBox("Kaken må ha et navn før den kan lagres.")
        End If
    End Sub

    Private Sub lstAvailableIngredients_MouseClick(sender As Object, e As MouseEventArgs) Handles lstAvailableIngredients.MouseClick
        'Shows unit type in label.
        If lstAvailableIngredients.SelectedIndex <> -1 Then
            lblMeasureUnit.Text = (From x In DBM.Instance.Ingredients _
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

    Private Sub txtFilterCake_TextChanged(sender As Object, e As EventArgs) Handles txtFilterCake.TextChanged
        Dim cakeQuery = (From x In DBM.Instance.Cakes Where x.name.Contains(txtFilterCake.Text) _
                         Select x.id, x.name, x.published).ToList()
        CakeBindingSource.DataSource = cakeQuery
        showPriceArrays()
    End Sub

    Private Sub btnNewCake_Click(sender As Object, e As EventArgs) Handles btnNewCake.Click, ToolStripButton2.Click
        grpCakeEdit.Enabled = True
        cakeNew = True
        structureSelList()
    End Sub

    Private Sub dtgCake_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles dtgCake.MouseDoubleClick
        grpCakeEdit.Enabled = True
        cakeNew = False
        structureSelList()

        Dim cakeID As Integer = dtgCake.SelectedRows(0).Cells(0).Value
        txtNameCake.Text = dtgCake.SelectedRows(0).Cells(1).Value
        Dim cakeQuery = (From x In DBM.Instance.Cakes _
                         Where x.id = cakeID _
                         Select x.markupPercentage, x.recipe, x.published).ToList()
        txtProcedure.Text = cakeQuery.Item(0).recipe.ToString()
        numMarkUps.Text = cakeQuery.Item(0).markupPercentage.Value()
        If cakeQuery.Item(0).published.HasValue Then
            If cakeQuery.Item(0).published.Value = True Then
                chkPublished.Checked = True
            Else
                chkPublished.Checked = False
            End If
        Else
            chkPublished.Checked = False
        End If

        existingCake = DBM.Instance.Cakes.Find(cakeID)

        Dim ingList = (From x In DBM.Instance.RecipeLines _
               Where x.Cake.id = cakeID _
               Select x.Ingredient.id, x.amount, x.Ingredient.name, UnitName = x.Ingredient.Unit.name).ToList()

        If ingList.Count = 0 Then
            With lstSelectedIngredients
                .DataSource = selList
                .DisplayMember = ""
                .ValueMember = ""
            End With
        Else
            For Each row In ingList
                Dim ingID As Integer = CInt(row.id.ToString())
                Dim ingName As String = row.name.ToString()
                Dim unitType As String = row.UnitName.ToString()
                Dim ingAmount As Double = CDbl(row.amount.ToString())
                Dim ingMarkup As Double = (From x In priceQuery Where x.id = ingID _
                                             Order By x.date Descending Select x.markUpPercentage).FirstOrDefault()
                Dim ingPrice As Double = CDbl(StockManager.getPurchasingPrice(ingID, "avg", batchQuery))

                fillSelList(ingID, ingName, unitType, ingAmount, ingMarkup, ingPrice)
            Next
        End If
        showPrices()
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteItem.Click
        MsgBox("slett")
        dtgCake.Refresh()
    End Sub
End Class
