Imports System.ComponentModel
''' <summary>
''' Module to create cake-entries in the database.
''' A "cake" is the collection of specified amounts of ingredients, and
''' the recipe itself.
''' Last edited 22.04.14
''' </summary>
''' <remarks>
''' Sorting on price column is not working, mostly because of limitations with datagridview
''' bound to a datasource combined with manual columns.
''' </remarks>
Public Class frmAdminCakes
    'Variables for preloading some content from database to make things
    'run a little smoother.
    Private ingQuery As List(Of Kakefunn.Ingredient)
    Private priceQuery As List(Of Kakefunn.IngredientPrice)
    Private batchQuery As List(Of Kakefunn.Batch)

    'Datatable to keep track of selected ingredients before writing them to the db.
    Private selList As DataTable
    Private factor As Double 'Factor in price calculations.

    'Parallell arrays to keep price information.
    Private cakeArray() As Integer
    Private cakePriceArray() As Double
    Private arrayCounter As Integer

    'Boolean variable needed to run the appropriate commands for saving a new record, 
    'or updating an existing one in the db.
    Private cakeNew As Boolean

    'Fill with information about a cake that is selected to be edited.
    Private existingCake As Cake

    ''' <summary>
    ''' Loads cakes sorted on the deleted-column, as we want delted cakes at the bottom.
    ''' Displays the cake list in a datagridview.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub bindCake()
        DBM.Instance.Cakes.OrderBy(Function(c) c.deleted).Load()
        CakeBindingSource.DataSource = DBM.Instance.Cakes.Local.ToBindingList()
    End Sub

    ''' <summary>
    ''' Calculates prices for the cakes in the datagridview. See detailed comments within the sub.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub loadPrices()
        Dim i As Integer
        ReDim cakeArray(-1)
        ReDim cakePriceArray(-1)

        For i = 0 To dtgCake.Rows.Count - 1
            Dim cakePrice As Double = 0
            Dim idx As Integer = CInt(dtgCake.Rows(i).Cells(IdDataGridViewTextBoxColumn.Index).Value)
            Dim cakeMarkUpFactor As Double = ((CDbl(dtgCake.Rows(i).Cells(MarkupPercentageDataGridViewTextBoxColumn.Index).Value)) / 100) + 1
            'For each cake in the list, get ingredient list.
            Dim ingList = (From x In DBM.Instance.RecipeLines _
                           Where x.Cake.id = idx _
                           Select IngredientId = x.Ingredient.id, x.amount).ToList()

            'Traverses ingredient list and sums ingredient prices.
            For Each row In ingList
                Dim purchasingPrice As Double = StockHelper.getPurchasingPrice(row.IngredientId, "avg", batchQuery)
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

    ''' <summary>
    ''' Loads the module and displays data from the database. Also adds adds tracking to
    ''' controls for cake registration. These are used to issue a warning if the user
    ''' tries to close the form without saving.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub frmAdminCake_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        priceQuery = (From x In DBM.Instance.IngredientPrices Select x).ToList()
        batchQuery = (From x In DBM.Instance.Batches Select x).ToList()

        bindCake()
        loadPrices()

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

        'BindingNavigator1.BringToFront()
    End Sub

    ''' <summary>
    ''' Resets the cake registration form.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub clearRegForm()
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

    ''' <summary>
    ''' Creates structures i the datatable selList, used to add ingredients to cakes.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub structureSelList()
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

    ''' <summary>
    ''' Filtering ingredient list. See detailed comments in the sub.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub txtFilter_TextChanged(sender As Object, e As EventArgs) Handles txtFilter.TextChanged
        'Gets ingredients from preloaded list of ingredients. Only shows published ingredients.
        Dim ingList = (From x In ingQuery _
                       Where x.name.ToUpper().Contains(txtFilter.Text.ToUpper()) _
                       And x.published = True _
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

    ''' <summary>
    ''' Shows ingredient- and salesprice in cake registration form.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub showPrices()
        If selList.Rows.Count <> 0 Then
            lblIngredientsPrice.Text = "Ingredienspris: kr. " & Format(selList.Compute("Sum(Price)", ""), "0.00")
            lblSalePrice.Text = "Salgspris: kr. " & Format(selList.Compute("Sum(Price)", "") * factor, "0.00")
        End If
    End Sub

    ''' <summary>
    ''' Adds selected ingredients to a datatable.
    ''' When the cake is saved, ingredients are written to the database.
    ''' Shows selected ingredients in the list of selected ingredients.
    ''' </summary>
    ''' <remarks></remarks>
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

    ''' <summary>
    ''' Adding ingredients to cake. Se detailed comments in the sub.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnAddIngredients_Click(sender As Object, e As EventArgs) Handles btnAddIngredients.Click
        'Collects relevant info for a cakes ingredients, and saves it all to a number of variables.
        Dim selIndex As Integer = CInt(lstAvailableIngredients.SelectedValue.ToString())
        Dim selName As String = lstAvailableIngredients.Text
        Dim unitType As String = lblMeasureUnit.Text
        Dim unitAmount As Double = numAmount.Text
        Dim priceMarkup As Double = (From x In priceQuery Where x.id = selIndex _
                                     Order By x.date Descending Select x.markUpPercentage).FirstOrDefault()
        Dim ingPrice As Double = CDbl(StockHelper.getPurchasingPrice(selIndex, "avg", batchQuery))

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

    ''' <summary>
    ''' Removing selected ingredients. This will work both for a new cake, and one loaded for editing.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnRemoveIngredients_Click(sender As Object, e As EventArgs) Handles btnRemoveIngredients.Click
        If lstSelectedIngredients.SelectedIndex <> -1 Then
            'Gets index of selected ingredient.
            Dim selIndex As Integer = CInt(lstSelectedIngredients.SelectedValue.ToString())

            'Deletes ingredient from selList.
            For Each row As DataRow In selList.Rows
                If row.Item("ID") = selIndex Then
                    selList.Rows(selList.Rows.IndexOf(row)).Delete()
                    Exit For
                End If
            Next
        End If
        showPrices()
    End Sub

    ''' <summary>
    ''' This button saves the cake to the database. Se detailed comments in the sub.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'The cake must have a name. No further requirements before saving.
        If txtNameCake.Text <> "" Then
            UpdateActionStatus("Lagrer..")
            Dim cake As Cake

            'Checks if it's a new cake or one to be edited.
            If cakeNew Then
                cake = New Cake() 'New cake.
            Else
                cake = existingCake 'Loads existing data from db.

                'To prevent doubling up recipeLines in the database,
                'all lines are removed.
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
                MsgBox("Feilmelding: " & ex.ToString & " Noe gikk galt under lagring.")
            End Try

            'logs operation to event log.
            KakefunnEvent.saveSystemEvent("Kaker", "Lagret/oppdatert " & cake.name)

            bindCake()
            loadPrices()
            clearRegForm()

            'Disables the registration part of the form.
            grpCakeEdit.Enabled = False
            isDirty = False
        Else
            MsgBox("Kaken må ha et navn før den kan lagres.")
        End If
        UpdateActionStatus("Klar")
        dtgCake.Refresh()
    End Sub

    ''' <summary>
    ''' Mouseclick on an ingredient in the list of available ingredients loads the correct measure unit
    ''' in the registration form. It also activates the numeric textbox to enter the amount needed of the 
    ''' selected ingredient. The box i colored yellow to indicate that is has to be filled.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub lstAvailableIngredients_MouseClick(sender As Object, e As MouseEventArgs) Handles lstAvailableIngredients.MouseClick
        '
        If lstAvailableIngredients.SelectedIndex <> -1 Then
            lblMeasureUnit.Text = (From x In DBM.Instance.Ingredients _
                                   Where x.id = CInt(lstAvailableIngredients.SelectedValue.ToString()) _
                                   Select x.Unit.name).FirstOrDefault()

            numAmount.Enabled = True
            numAmount.BackColor = Color.Yellow
        End If
    End Sub

    ''' <summary>
    ''' Enables the button to add ingredient. The button is colored yellow to indicate that the ingredient can
    ''' be added.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub numAmount_TextChanged(sender As Object, e As EventArgs) Handles numAmount.TextChanged
        btnAddIngredients.Enabled = True
        btnAddIngredients.BackColor = Color.Yellow
    End Sub

    ''' <summary>
    ''' Calculates markup factor on text changed. Makes the salesprice change accordingly.
    ''' Presets the factor to 1 if the box is left empty.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
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

    ''' <summary>
    ''' Filters dtgCakes. Converts to uppercase to make filter case insensitive.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub filter()
        CakeBindingSource.DataSource = DBM.Instance.Cakes.Local.Where(Function(c) _
                c.name.ToUpper().Contains(txtFilterCake.Text.ToUpper())).ToList()
        If txtFilterCake.Text = "" Then
            bindCake()
        End If
    End Sub

    ''' <summary>
    ''' Calls the filter sub on textchanged.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub txtFilterCake_TextChanged(sender As Object, e As EventArgs) Handles txtFilterCake.TextChanged
        filter()
    End Sub

    ''' <summary>
    ''' Readies the registration form for a new cake.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnNewCake_Click(sender As Object, e As EventArgs) Handles btnNewCake.Click, btnToolStripCakeNew.Click
        ingQuery = (From x In DBM.Instance.Ingredients Select x).ToList()
        grpCakeEdit.Enabled = True
        btnAddIngredients.Enabled = False
        numAmount.Enabled = False
        cakeNew = True
        structureSelList()
        isDirty = False
    End Sub

    ''' <summary>
    ''' Collects data about a cake from db, and displays it in the registration form.
    ''' See detailed comments in the sub.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub dtgCake_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles dtgCake.MouseDoubleClick
        ingQuery = (From x In DBM.Instance.Ingredients Select x).ToList()
        grpCakeEdit.Enabled = True
        cakeNew = False
        structureSelList()

        'Displays data in the form.
        Dim cakeID As Integer = dtgCake.SelectedRows(0).Cells(IdDataGridViewTextBoxColumn.Index).Value
        Dim pub As Boolean = dtgCake.SelectedRows(0).Cells(PublishedDataGridViewTextBoxColumn.Index).Value
        txtNameCake.Text = dtgCake.SelectedRows(0).Cells(NameDataGridViewTextBoxColumn.Index).Value
        txtProcedure.Text = DBM.Instance.Cakes.Local.Where(Function(c) c.id = cakeID).Select(Function(c) c.recipe.ToString).FirstOrDefault()
        numMarkUps.Text = DBM.Instance.Cakes.Local.Where(Function(c) c.id = cakeID).Select(Function(c) c.markupPercentage.Value).FirstOrDefault()
        If pub = True Then
            chkPublished.Checked = True
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
                Dim ingPrice As Double = CDbl(StockHelper.getPurchasingPrice(ingID, "avg", batchQuery))

                fillSelList(ingID, ingName, unitType, ingAmount, ingMarkup, ingPrice)
            Next
        End If
        showPrices()
        isDirty = False
    End Sub

    ''' <summary>
    ''' Deletes a cake. For reporting purposes the record is not deleted in the db, but made inactive.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles btnToolStripCakeDelete.Click
        UpdateActionStatus("Venter på bekreftelse..")

        'Prompts user: are you sure?
        Dim result As Integer = MessageBox.Show("Er du sikker på at du vil slette kaken? Operasjonen kan ikke reverseres.", _
                                                "Bekreft sletting", MessageBoxButtons.YesNo)
        UpdateActionStatus("Sletter kake...")

        If result = 6 Then
            Dim delIdx As Integer = dtgCake.SelectedRows(0).Cells(IdDataGridViewTextBoxColumn.Index).Value
            Dim delCake = DBM.Instance.Cakes.Find(delIdx)
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

            MsgBox("Kaken er nå inaktiv i systemet")
            UpdateActionStatus()
            dtgCake.Refresh()
        End If
    End Sub

    ''' <summary>
    ''' Using Cell Formatting events on the datagridview to show the deleted cakes with a different color and
    ''' strikethrough, as well as showing prices from the cakePriceArray.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub dtgCake_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dtgCake.CellFormatting
        If dtgCake.Rows(e.RowIndex).Cells(DeletedDataGridViewTextBoxColumn.Index).Value <= Date.Today And _
            dtgCake.Rows(e.RowIndex).Cells(DeletedDataGridViewTextBoxColumn.Index).Value > CDate("2000-01-01") Then
            dtgCake.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Red
            dtgCake.Rows(e.RowIndex).DefaultCellStyle.Font = New Font(Font, FontStyle.Strikeout)
        End If

        If dtgCake.Columns(e.ColumnIndex).Name = "price" Then
            Dim i As Integer
            For i = 0 To cakeArray.Length - 1
                If dtgCake.Rows(e.RowIndex).Cells(IdDataGridViewTextBoxColumn.Index).Value = cakeArray(i) Then
                    e.Value = Format(cakePriceArray(i), "0.00")
                End If
            Next
        End If
    End Sub

    ''' <summary>
    ''' Cancels editing or adding a new cake. Alerts user about unsaved changes.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnAvbryt_Click(sender As Object, e As EventArgs) Handles btnAvbryt.Click
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

    ''' <summary>
    ''' Makes the delete button inactive when already deleted cakes are selected.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub dtgCake_MouseClick(sender As Object, e As MouseEventArgs) Handles dtgCake.MouseClick
        If dtgCake.SelectedRows(0).Cells(DeletedDataGridViewTextBoxColumn.Index).Value > CDate("2000-01-01") Then
            btnToolStripCakeDelete.Enabled = False
        Else
            btnToolStripCakeDelete.Enabled = True
        End If
    End Sub
End Class
