'TODO
'Implement option to edit cakes.
'Doubleclick on a cake in the list should load it in the form on the right.
'Need to comment the code!!

Public Class frmAdminCakes
    Private ingQuery As List(Of Kakefunn.Ingredient)
    Private priceQuery As List(Of Kakefunn.ingredientPrice)
    Private batchQuery As List(Of Kakefunn.Batch)
    Private selList As DataTable
    Private factor As Double
    Private published As Boolean = False
    Private cakeArray() As Integer
    Private cakePriceArray() As Double
    Private arrayCounter As Integer

    Private Sub loadTables()
        'Fetches data from database. Local operations on the data is faster.
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
            Dim ingList = (From x In DBM.Instance.RecipeLines _
                           Where x.Cake.id = idx _
                           Select IngredientId = x.Ingredient.id, x.amount).ToList()
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
        'Showing prices in dtgCake
        Dim i, j As Integer
        For i = 0 To dtgCake.Rows.Count - 1
            For j = 0 To arrayCounter
                If dtgCake.Rows(i).Cells(0).Value = cakeArray(j) Then
                    dtgCake.Rows(i).Cells(2).Value() = cakePriceArray(j)
                End If
            Next j
        Next i
    End Sub

    Private Sub frmAdminCake_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bindCake()
        loadTables()
        loadPrices()
        showPriceArrays()

        'Should be moved. Only needed when updating or creating cakes.
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
            Dim newCake As Cake = New Cake()
            newCake.name = txtNameCake.Text
            newCake.markupPercentage = numMarkUps.Text
            newCake.recipe = txtProcedure.Text
            If published Then
                newCake.published = True
            End If
            Try
                For Each row As DataRow In selList.Rows
                    Dim cakeIng As RecipeLine = New RecipeLine()
                    cakeIng.Ingredient = DBM.Instance.Ingredients.Find(CInt(row.Item("ID")))
                    cakeIng.amount = CDbl(row.Item("Amount"))
                    newCake.RecipeLines.Add(cakeIng)
                Next

                DBM.Instance.Cakes.Add(newCake)
                DBM.Instance.SaveChanges()
            Catch ex As Entity.Validation.DbEntityValidationException
                MsgBox(ex.ToString)
            End Try
            bindCake()
            loadPrices()
            showPriceArrays()
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

    Private Sub chkPublished_CheckedChanged(sender As Object, e As EventArgs) Handles chkPublished.CheckedChanged
        If Not published Then
            published = True
        Else
            published = False
        End If
    End Sub

    Private Sub txtFilterCake_TextChanged(sender As Object, e As EventArgs) Handles txtFilterCake.TextChanged
        Dim cakeQuery = (From x In DBM.Instance.Cakes Where x.name.Contains(txtFilterCake.Text) _
                         Select x.id, x.name, x.published).ToList()
        CakeBindingSource.DataSource = cakeQuery
        showPriceArrays()
    End Sub
End Class
