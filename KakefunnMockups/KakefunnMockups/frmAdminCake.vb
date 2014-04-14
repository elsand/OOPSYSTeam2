'TODO
'Last edited 14.04.14
'OK?

Public Class frmAdminCakes
    'For preloading some content from database to make things
    'run a little smoother.
    Private ingQuery As List(Of Kakefunn.Ingredient)
    Private priceQuery As List(Of Kakefunn.IngredientPrice)
    Private batchQuery As List(Of Kakefunn.Batch)
    Private cakeQuery As List(Of Kakefunn.Cake)

    'Datatable to keep track of selected ingredients before writing them to the db.
    Private selList As DataTable
    Private factor As Double 'Factor in price calculations.

    'Parallell arrays to keep price information.
    Private cakeArray() As Integer
    Private cakePriceArray() As Double
    Private arrayCounter As Integer

    'Needed to run the appropriate commands for saving a new record, or updating an 
    'existing one in the db.
    Private cakeNew As Boolean

    'Fill with information about a cake that is selected to be edited.
    Private existingCake As Cake

    Private Sub bindCake()
        'Loading cakes in dtgCake
        cakeQuery = (From x In DBM.Instance.Cakes Select x Order By x.deleted Ascending).ToList()
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
                cakePrice += ingPrice 'Accumulates ingredient prices.
            Next

            'Saves the prices with cakeID in parallell arrays to avoid 
            'calculating prices every time dtgCake is updated.
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
        'Preloading data from IngredientPrices and Batches.
        priceQuery = (From x In DBM.Instance.IngredientPrices Select x).ToList()
        batchQuery = (From x In DBM.Instance.Batches Select x).ToList()

        'Binding cakes to dtgCakes, calculating and showing prices.
        bindCake()
        loadPrices()
        showPriceArrays()

        'Tracking changes in controls. Used to trigger dialog if user tries to exit form without saving changes.
        For Each c As Control In Me.grpCakeEdit.Controls
            If c.GetType().Name = "TextBox" Then
                AddHandler CType(c, TextBox).TextChanged, Sub(s, ev) Me.isDirty = True
            ElseIf c.GetType().Name = "CheckBox" Then
                AddHandler CType(c, CheckBox).CheckedChanged, Sub(s, ev) Me.isDirty = True
            ElseIf c.GetType().Name = "NumericTextbox" Then
                AddHandler CType(c, NumericTextbox).TextChanged, Sub(s, ev) Me.isDirty = True
            End If
        Next

        For Each c As Control In Me.grpIngredients.Controls
            If c.GetType().Name = "TextBox" Then
                AddHandler CType(c, TextBox).TextChanged, Sub(s, ev) Me.isDirty = True
            ElseIf c.GetType().Name = "NumericTextbox" Then
                AddHandler CType(c, NumericTextbox).TextChanged, Sub(s, ev) Me.isDirty = True
            End If
        Next

        isDirty = False
    End Sub

    Private Sub clearRegForm()
        'Sub to clear the registration form of data.
        For Each c As Control In Me.grpCakeEdit.Controls
            If c.GetType().Name = "TextBox" Then
                CType(c, TextBox).Text = ""
            End If
            If c.GetType().Name = "CheckBox" Then
                CType(c, CheckBox).Checked = False
            End If
            If c.GetType().Name = "NumericTextbox" Then
                CType(c, NumericTextbox).Text = ""
            End If
        Next

        For Each c As Control In Me.grpIngredients.Controls
            If c.GetType().Name = "TextBox" Then
                CType(c, TextBox).Text = ""
            End If
        Next
        selList.Clear()
        lblIngredientsPrice.Text = "Ingredienspris: 0"
        lblSalePrice.Text = "Salgspris: 0"
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

        'Gets ingredients from preloaded list of ingredients.
        Dim ingList = (From x In ingQuery _
                       Where x.name.ToUpper().Contains(txtFilter.Text.ToUpper()) _
                       Select x).ToList()

        'Clears ingredient list if filter-textbox is empty.
        If txtFilter.Text = "" Then
            ingList.Clear()
        End If

        'Binds ingredient list to listbox.
        With lstAvailableIngredients
            .DataSource = ingList
            .DisplayMember = "name"
            .ValueMember = "id"
        End With
    End Sub

    Private Sub showPrices()
        'Shows ingredient- and salesprice in cake registration form.
        If selList.Rows.Count <> 0 Then
            lblIngredientsPrice.Text = "Ingredienspris: kr. " & Format(selList.Compute("Sum(Price)", ""), "0.00")
            lblSalePrice.Text = "Salgspris: kr. " & Format(selList.Compute("Sum(Price)", "") * factor, "0.00")
        End If
    End Sub

    Private Function fillSelList(ByVal id As Integer, ByVal name As String, ByVal unit As String, _
                                 ByVal amount As Double, ByVal markup As Double, _
                                 ByVal price As Double) As Boolean
        'Adds selected ingredients to a datatable. When the cake is saved, ingredients are 
        'written to the database.
        Dim dr As DataRow
        dr = selList.NewRow()
        dr("ID") = id
        dr("Name") = name
        dr("Unit") = unit
        dr("Amount") = amount
        dr("Combined") = name & " - " & amount & " " & unit
        dr("Price") = price * ((markup / 100) + 1) * amount
        selList.Rows.Add(dr)

        'Shows selected ingredients in the list of selected ingredients.
        With lstSelectedIngredients
            .DataSource = selList
            .DisplayMember = ("Combined")
            .ValueMember = ("ID")
        End With
        Return True
    End Function

    Private Sub btnAddIngredients_Click(sender As Object, e As EventArgs) Handles btnAddIngredients.Click
        'Adding ingredients to cake

        'Collects relevant info for a cakes ingredients, and saves it all to a number of variables.
        Dim selIndex As Integer = CInt(lstAvailableIngredients.SelectedValue.ToString())
        Dim selName As String = lstAvailableIngredients.Text
        Dim unitType As String = lblMeasureUnit.Text
        Dim unitAmount As Double = numAmount.Text
        Dim priceMarkup As Double = (From x In priceQuery Where x.id = selIndex _
                                     Order By x.date Descending Select x.markUpPercentage).FirstOrDefault()
        Dim ingPrice As Double = CDbl(StockManager.getPurchasingPrice(selIndex, "avg", batchQuery))

        'Calls fillSelList with the variables to add to the selection list.
        fillSelList(selIndex, selName, unitType, unitAmount, priceMarkup, ingPrice)
        showPrices() 'Show temporary price in the reg. form.

        'Manipulates the add button and amount-textbox to make the process more intuitive.
        numAmount.Text = ""
        numAmount.Enabled = False
        numAmount.BackColor = DefaultBackColor
        btnAddIngredients.Enabled = False
        btnAddIngredients.BackColor = DefaultBackColor
    End Sub

    Private Sub btnRemoveIngredients_Click(sender As Object, e As EventArgs) Handles btnRemoveIngredients.Click
        'Removing selected ingredients. This will work both for a new cake, and one loaded for editing.
        If lstSelectedIngredients.SelectedIndex <> -1 Then
            'Gets list index of selected ingredient.
            Dim selIndex As Integer = CInt(lstSelectedIngredients.SelectedValue.ToString())

            'Deletes ingredient from selList.
            For Each row As DataRow In selList.Rows
                If row.Item("ID") = selIndex Then
                    selList.Rows(selList.Rows.IndexOf(row)).Delete()
                    Exit For
                End If
            Next
        End If
        'Recalculates prices.
        showPrices()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'This button saves the cake.

        'The cake must have a name. No further requirements before saving.
        If txtNameCake.Text = "" Then
            UpdateActionStatus("Lagrer..")
            Dim cake As Cake

            'Checks if it's a new cake or one to be edited.
            If cakeNew Then
                cake = New Cake() 'New cake.
            Else
                cake = existingCake 'Loads existing data from db.

                'Removes recipelines, these will be added again from selList
                'when changes are saved.
                Dim removeList = (From x In DBM.Instance.RecipeLines _
                                  Where x.Cake.id = cake.id _
                                  Select x)
                For Each row In removeList
                    DBM.Instance.RecipeLines.Remove(row)
                Next
            End If

            'Gets data from TextBoxes and NumericTextBoxes.
            cake.name = txtNameCake.Text
            cake.markupPercentage = numMarkUps.Text
            cake.recipe = txtProcedure.Text
            If chkPublished.Checked Then
                cake.published = True
            Else
                cake.published = False
            End If
            Try
                'Adding ingredients as recipeLines from selList
                For Each row As DataRow In selList.Rows
                    Dim cakeIng As RecipeLine = New RecipeLine()
                    cakeIng.Ingredient = DBM.Instance.Ingredients.Find(CInt(row.Item("ID")))
                    cakeIng.amount = CDbl(row.Item("Amount"))
                    cake.RecipeLines.Add(cakeIng)
                Next

                'Adds the cake to the db if it's new.
                If cakeNew Then
                    DBM.Instance.Cakes.Add(cake)
                End If

                'Saves changes.
                DBM.Instance.SaveChanges()
            Catch ex As Entity.Validation.DbEntityValidationException
                MsgBox(ex.ToString)
            End Try

            'Calls procedures to reload information to dtgCakes.
            bindCake()
            loadPrices()
            showPriceArrays()

            'Disables the registration part of the form.
            grpCakeEdit.Enabled = False
            isDirty = False
        Else
            MsgBox("Kaken må ha et navn før den kan lagres.")
        End If
        UpdateActionStatus("Klar")
    End Sub

    Private Sub lstAvailableIngredients_MouseClick(sender As Object, e As MouseEventArgs) Handles lstAvailableIngredients.MouseClick
        'Shows unit type in label.
        If lstAvailableIngredients.SelectedIndex <> -1 Then
            lblMeasureUnit.Text = (From x In DBM.Instance.Ingredients _
                                   Where x.id = CInt(lstAvailableIngredients.SelectedValue.ToString()) _
                                   Select x.Unit.name).FirstOrDefault()

            'Enables box to enter amount.
            numAmount.Enabled = True
            numAmount.BackColor = Color.Yellow
        End If
    End Sub

    Private Sub numAmount_TextChanged(sender As Object, e As EventArgs) Handles numAmount.TextChanged
        'Enables button to add ingredient.
        btnAddIngredients.Enabled = True
        btnAddIngredients.BackColor = Color.Yellow
    End Sub

    Private Sub numMarkUps_TextChanged(sender As Object, e As EventArgs) Handles numMarkUps.TextChanged
        'Calculates factor on text changed. Makes the salesprice change accordingly.
        If numMarkUps.Text = "" Then
            factor = 1
        ElseIf CInt(numMarkUps.Text) >= 0 And CInt(numMarkUps.Text) <= 100 Then
            factor = (CInt(numMarkUps.Text) / 100) + 1
        Else
            MsgBox("Oppgi avansen som et heltall mellom 0 og 100")
        End If

        showPrices()
    End Sub

    Private Sub filter()
        'Filters dtgCakes.
        cakeQuery = (From x In DBM.Instance.Cakes Where x.name.Contains(txtFilterCake.Text) _
                         Select x Order By x.deleted Ascending).ToList()
        CakeBindingSource.DataSource = cakeQuery
        showPriceArrays()
    End Sub

    Private Sub txtFilterCake_TextChanged(sender As Object, e As EventArgs) Handles txtFilterCake.TextChanged
        filter()
    End Sub

    Private Sub btnNewCake_Click(sender As Object, e As EventArgs) Handles btnNewCake.Click, btnToolStripCakeNew.Click
        'Readies the registration form for a new cake.
        ingQuery = (From x In DBM.Instance.Ingredients Select x).ToList()
        grpCakeEdit.Enabled = True
        btnAddIngredients.Enabled = False
        numAmount.Enabled = False
        cakeNew = True
        structureSelList()
        isDirty = False
    End Sub

    Private Sub dtgCake_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles dtgCake.MouseDoubleClick
        'Collects data about a cake from db, and displays it in the registration form.
        ingQuery = (From x In DBM.Instance.Ingredients Select x).ToList()
        grpCakeEdit.Enabled = True
        cakeNew = False
        structureSelList()

        'Displays data in the form.
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

        'Fills the existingCake object.
        existingCake = DBM.Instance.Cakes.Find(cakeID)

        'Fills selected ingredient list and displays it in the reg. form.
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
        isDirty = False
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles btnToolStripCakeDelete.Click
        'Deletes a cake. The record is not deleted in the db, but rather made inactive.
        UpdateActionStatus("Venter på bekreftelse..")

        'Prompts user: are you sure=
        Dim result As Integer = MessageBox.Show("Er du sikker på at du vil slette kaken? Operasjonen kan ikke reverseres.", _
                                                "Bekreft sletting", MessageBoxButtons.YesNo)
        UpdateActionStatus("Sletter kake...")

        If result = 6 Then
            Dim delIdx As Integer = dtgCake.SelectedRows(0).Cells(0).Value
            Dim delCake = (From x In DBM.Instance.Cakes Where x.id = delIdx _
                             Select x).FirstOrDefault()
            delCake.deleted = Date.Today
            delCake.published = False

            Try
                DBM.Instance.SaveChanges()
            Catch ex As Entity.Validation.DbEntityValidationException
                MsgBox(ex.ToString)
            End Try
            If txtFilterCake.Text = "" Then
                bindCake()
            Else
                filter()
            End If

            showPriceArrays()
            MsgBox("Kaken er nå inaktiv i systemet")
            UpdateActionStatus()
        End If
    End Sub

    Private Sub dtgCake_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dtgCake.CellFormatting
        'Different formatting for deleted cakes.
        If dtgCake.Rows(e.RowIndex).Cells(6).Value <= Date.Today And _
            dtgCake.Rows(e.RowIndex).Cells(6).Value > CDate("2000-01-01") Then
            dtgCake.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Red
            dtgCake.Rows(e.RowIndex).DefaultCellStyle.Font = New Font(Font, FontStyle.Strikeout)
        End If
    End Sub

    'Private Sub dtgCake_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dtgCake.ColumnHeaderMouseClick
    'Originally to load prices when sorting on column headers. Can't get sorting to work though..
    '   showPriceArrays()
    'End Sub

    Private Sub btnAvbryt_Click(sender As Object, e As EventArgs) Handles btnAvbryt.Click
        'Cancels editing or adding a new cake. Alerts user about unsaved changes.
        If isDirty Then
            Dim response = MessageBox.Show("Du har ulagrede endringer. Vil du avslutte kakeregistreringen likevel?", _
                                           "Bekreft lukking", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If response = 6 Then
                clearRegForm()
                grpCakeEdit.Enabled = False
            End If
        Else
            clearRegForm()
            grpCakeEdit.Enabled = False
        End If

    End Sub

    Private Sub dtgCake_MouseClick(sender As Object, e As MouseEventArgs) Handles dtgCake.MouseClick
        'Makes the delete button inactive when already deleted cakes are selected.
        If dtgCake.SelectedRows(0).Cells(6).Value > CDate("2000-01-01") Then
            btnToolStripCakeDelete.Enabled = False
        Else
            btnToolStripCakeDelete.Enabled = True
        End If

    End Sub
End Class
