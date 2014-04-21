''' <summary>
''' Form handler for registering and editing of orders
''' </summary>
''' <remarks></remarks>
Public Class frmSaleOrder

    ' Flag used to trigger logic specific to either saved or new orders
    Private isNewRecord = False
    ' Holds the order currently being edited, either new or existing
    Private currentRecord As Order = New Order()
    ' Flag to tell event handlers if we're currently loading a record
    Private isLoadingOrder = False
    ' Holds which form we are to return to. Default to frmSaleMain
    Public returnToForm As Form

    ''' <summary>
    ''' Loads an exisiting order and populates all the fields
    ''' </summary>
    ''' <param name="order"></param>
    ''' <remarks></remarks>
    Public Sub LoadOrder(order As Order)

        isLoadingOrder = True
        ' Reset everything
        NewOrder()

        ' Set the loaded order as the current order and tell so to EF
        currentRecord = order
        DBM.Instance.Orders.Attach(currentRecord)

        isNewRecord = False
        isDirty = False

        '  Set static fields
        cbCustomerName.Text = order.Customer.fullName.ToString()
        ddlDeliveryMethod.Text = order.DeliveryMethod.name.ToString()
        txtDeliveryName.Text = order.deliveryFirstName.ToString() & " " _
                                & order.deliveryLastName.ToString()
        txtAddress.Text = order.Address.address1.ToString()
        txtZip.Text = order.Address.Zip.zip1.ToString()
        txtTelephone.Text = order.deliveryPhone.ToString()
        txtEmail.Text = order.deliveryEmail.ToString()

        If order.note Is Nothing Then
            txtInternalNote.Text = ""
        Else
            txtInternalNote.Text = order.note.ToString()
        End If
        If order.isPaid = True Then
            cboIsPayed.Checked = True
        Else
            cboIsPayed.Checked = False
        End If

        ' Do heuristic check for a valid date
        If order.deliveryDate.Date > CDate("1976-01-27") Then
            dtpDeliveryDate.Value = order.deliveryDate.Date()
        End If


        ' Handle discount
        If order.discountAbsolute.HasValue Then
            If order.discountAbsolute.Value > 0 Then
                rdoCurrencyValue.Checked = True
                txtDiscount.Text = order.discountAbsolute.Value()
            End If
        ElseIf order.discountPercentage.HasValue Then
            If order.discountPercentage.Value > 0 Then
                rdoPercent.Checked = True
                txtDiscount.Text = order.discountPercentage.Value()
            End If
        Else
            rdoNone.Checked = True
            txtDiscount.Text = ""
        End If

        ' Bind the orderlines in the order to the datasource
        OrderLinesBindingSource.DataSource = order.OrderLines.ToBindingList

        ' Show order status
        grpOrderStatus.Show()
        lblOrderNumberValue.Text = currentRecord.id
        lblOrderCreatedValue.Text = currentRecord.created
        lblOrderLastEditedValue.Text = currentRecord.modified
        If Not currentRecord.sent Is Nothing Then
            lblOrderSentValue.Text = currentRecord.sent
        Else
            lblOrderSentValue.Text = "(ikke sendt)"
        End If


        UpdateTotalPrice()

        isLoadingOrder = False

    End Sub

    ''' <summary>
    ''' Clears the form and readies a new order
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub NewOrder()

        isDirty = False
        isNewRecord = True
        currentRecord = New Order()
        grpOrderStatus.Hide()
        FormHelper.ResetControls(Controls)
        OrderLinesBindingSource.DataSource = currentRecord.OrderLines.ToBindingList
        ToggleSubscriptionGroup()
        UpdateTotalPrice()

    End Sub

    ''' <summary>
    ''' Saves a new or existing order to the database
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub SaveOrder()

        If Not ValidOrder() Then
            Exit Sub
        End If
        Try
            If isNewRecord Then
                currentRecord.Employee = SessionManager.Instance.User
                DBM.Instance.Orders.Add(currentRecord)
            End If
            currentRecord.modified = Date.Now()
            DBM.Instance.SaveChanges()
        Catch ex As Exception
            MessageBox.Show("Det oppstod en feil under lagring av ordre. " & ex.Message, "Feil", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

        MsgBox("Ordren ble lagret", MsgBoxStyle.Information)

        ' Re-load the order in order to trigger saved record logic
        LoadOrder(currentRecord)

    End Sub

    ''' <summary>
    ''' Validates that the supplied data is sane. Displays a message box for the first encountered invalid field and returns false.
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function ValidOrder() As Boolean
        ' TODO! Implement
        Return True
    End Function

    ''' <summary>
    ''' Show/hides the subscription controls based on the checkbox indicating that is is a subscription order or not
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ToggleSubscriptionGroup()
        For Each c As Control In grpSubscription.Controls
            If Not c Is chkIsActivated Then
                c.Enabled = chkIsActivated.Checked
            End If
        Next
    End Sub

    ''' <summary>
    ''' Utility function to prefill the delivery fields to the same as the ordering customer
    ''' </summary>
    ''' <param name="customer"></param>
    ''' <remarks></remarks>
    Private Sub SetDeliveryToCustomer(customer As Customer)
        txtDeliveryName.Text = customer.fullName
        txtAddress.Text = customer.Address.address1
        txtZip.Text = customer.Address.Zip.zip1
        lblCity.Text = customer.Address.Zip.city.ToUpper()
        txtTelephone.Text = customer.phone
        txtEmail.Text = customer.email
    End Sub

    ''' <summary>
    ''' Populates the dropdown list for ingredients and cakes. This is done via a UNION select, where we prefix the primary ids. 
    ''' AttemptAddIngredientOrCakeToOrder() uses this index to determine if we're trying to add a single ingredient or a cake
    ''' </summary>
    ''' <remarks>
    ''' TODO: Query should be expanded to not include ingredients not present (now or future) in the database, or unpublished ingredients
    ''' </remarks>
    Private Sub SetupIngredientOrCakeSelection()

        Dim dt As DataTable = DBM.Instance.GetDataTableFromQuery( _
            "SELECT CONCAT('i', id) as id, name FROM Ingredient " & _
            "UNION " & _
            "SELECT CONCAT('c', id) as id, CONCAT(name, ' (Kake)') as name FROM Cake " & _
            "ORDER BY name" _
        )

        With cbIngredientOrCake
            .DisplayMember = "name"
            .ValueMember = "id"
            .DataSource = dt
            .AutoCompleteMode = AutoCompleteMode.Suggest
            .AutoCompleteSource = AutoCompleteSource.ListItems
        End With

    End Sub

    ''' <summary>
    ''' Adds the selected ingredient or cake (ie. collection of ingredients) to the datagridview
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub AttemptAddIngredientOrCakeToOrder()
        If cbIngredientOrCake.SelectedValue Is Nothing Then
            Exit Sub
        End If

        ' Figure out if we have a ingredient or cake id
        Dim prefixedId As String
        Dim id As Integer
        prefixedId = System.Text.Encoding.Default.GetString(cbIngredientOrCake.SelectedValue)

        Integer.TryParse(prefixedId.Substring(1), id)
        If id = Nothing Then
            Exit Sub ' Should not happen
        End If

        ' TODO! If the ingredient is already present in other orderlines, they must be taken into account when determining if we have enough in stock
        If prefixedId.Substring(0, 1) = "i" Then
            ' We have a single ingredient
            Try
                Dim ol As OrderLine = New OrderLine
                ol.Ingredient = DBM.Instance.Ingredients.Find(id)
                ol.amount = 1
                ol.totalPrice = ol.amount * StockManager.GetSellingPriceFor(ol.Ingredient, ol.amount, dtpDeliveryDate.Value)
                OrderLinesBindingSource.Add(ol)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Feil")
            End Try
        Else
            ' We have a cake, ie. collection of ingredients
            ' Only add the ingredients to the order if we have all required ingredients in stock
            Try
                Dim cake As Cake = DBM.Instance.Cakes.Find(id)
                Dim ols As New List(Of OrderLine)
                Dim ol As OrderLine

                For Each r As RecipeLine In cake.RecipeLines
                    ol = New OrderLine
                    ol.Ingredient = r.Ingredient
                    ol.amount = r.amount
                    ol.totalPrice = r.amount * StockManager.GetSellingPriceFor(ol.Ingredient, ol.amount, dtpDeliveryDate.Value)
                    ol.cakeId = cake.id
                    ols.Add(ol)
                Next

                ' Sync with current order
                For Each ol In ols
                    OrderLinesBindingSource.Add(ol)
                Next
            Catch ex As Exception
                MessageBox.Show("Kan ikke legge til kake. En eller flere av ingrediensene har manglende dekning på lager." & _
                       vbCrLf & vbCrLf & ex.Message, "Feil", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

        UpdateTotalPrice()

    End Sub

    ''' <summary>
    ''' Updates the labels on the bottom of the form with the totals
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub UpdateTotalPrice()

        Dim totals As OrderTotals
        totals = OrderManager.CalculateTotals(currentRecord)

        lblTotalAmountWithoutVatValue.Text = FormatHelper.Currency(totals.totalPriceExVat)
        lblDiscountValue.Text = FormatHelper.Currency(totals.totalDiscount)
        lblShippingValue.Text = FormatHelper.Currency(totals.shipping)
        lblVatValue.Text = FormatHelper.Currency(totals.totalVat)
        lblAmountToPayValue.Text = FormatHelper.Currency(totals.totalToPay)

    End Sub

    ''' <summary>
    ''' Popluates the delivery method dropdown with available options
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub SetupDeliveryTypeDropdown()
        ddlDeliveryMethod.DisplayMember = "name"
        ddlDeliveryMethod.DataSource = DBM.Instance.DeliveryMethods.ToList()
    End Sub

    '''''''''''''''''''''''''''''''''''' BELOW THIS POINT IS EVENT HANDLERS ''''''''''''''''''''''''''''''''''''''''''''''''''

    ''' <summary>
    ''' Initialize the form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub frmSaleOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        returnToForm = frmSaleMain ' By default we return to frmSaleMain. This may be set to other forms (if eg. we're shown from a statistics report)
        DBM.Instance.Customers.Load()
        CustomerBindingSource.DataSource = DBM.Instance.Customers.Local.ToBindingList()
        AddressHelper.SetupAutoCityFill(txtZip, lblCity)
        FormHelper.SetupDirtyTracking(Me)
        SetupIngredientOrCakeSelection()
        SetupDeliveryTypeDropdown()
        ' Start with a new order
        NewOrder()
    End Sub


    ''' <summary>
    ''' Handles when the user clicks new customer. Temporarily hides the order form (no saving is performed) and puts the customer screen
    ''' in the foreground. When completing the customer form, the user is returned to this form.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnNewCustomer_Click(sender As Object, e As EventArgs) Handles btnNewCustomer.Click
        CustomerManager.NewCustomerAndReturnTo(Me)
    End Sub


    ''' <summary>
    ''' Run when the user has typed/selected a customer. If the customer does not exist, offer to create it, which will perform the same as btnNewCustomer_Click()
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub cbCustomerName_Leave(sender As Object, e As EventArgs) Handles cbCustomerName.Leave
        If cbCustomerName.SelectedValue Is Nothing AndAlso Not cbCustomerName.Text = "" Then
            If MessageBox.Show("Denne kunden finnes ikke. Opprette?", "Ukjent kunde", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                CustomerManager.NewCustomerAndReturnTo(Me)
            Else
                ' User selected no, re-set focus to the customer selection field so that the user can select another customer
                cbCustomerName.Focus()
            End If
        End If
    End Sub

    ''' <summary>
    ''' This is run after cbCustomerName_Leave(). If a customer is selected it will be associated with the currentOrder, and delivery customer will
    ''' be preset with this.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub cbCustomerName_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbCustomerName.SelectedValueChanged
        If Not isLoadingOrder AndAlso Not cbCustomerName.SelectedItem Is Nothing Then
            SetDeliveryToCustomer(cbCustomerName.SelectedItem)
            currentRecord.Customer = cbCustomerName.SelectedItem
        End If
    End Sub

    ''' <summary>
    ''' Handles toggling of the "is subscription" checkbox
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub chkIsActivated_CheckedChanged(sender As Object, e As EventArgs) Handles chkIsActivated.CheckedChanged
        ToggleSubscriptionGroup()
    End Sub

    ''' <summary>
    ''' Handles the cancelbutton. Prompt if the form has been edited.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If Not FormHelper.ContinueIfDirty(Me) Then
            Exit Sub
        End If
        SessionManager.Instance.ShowForm(returnToForm)
    End Sub

    ''' <summary>
    ''' Handles the clear button. Prompt if the form has been edited.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        If Not FormHelper.ContinueIfDirty(Me) Then
            Exit Sub
        End If
        NewOrder()
    End Sub

    ''' <summary>
    ''' Handle the using pressing enter in the ingredient list
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub cbIngredientOrCake_KeyDown(sender As Object, e As KeyEventArgs) Handles cbIngredientOrCake.KeyDown
        If e.KeyCode = Keys.Enter Then
            AttemptAddIngredientOrCakeToOrder()
        End If
    End Sub

    ''' <summary>
    ''' Handle mouseselection or pressing the add-button next to the ingredient list
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub cbIngredientOrCake_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbIngredientOrCake.SelectionChangeCommitted, btnAddIngredientOrCake.Click
        AttemptAddIngredientOrCakeToOrder()
    End Sub

    ''' <summary>
    ''' Handle formatting of the different columns in the datagridview
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub dtgOrderLines_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dtgOrderLines.CellFormatting
        If e.ColumnIndex < 0 Then
            Exit Sub
        End If
        Select Case dtgOrderLines.Columns(e.ColumnIndex).Name
            Case "dcIngredient"
                '  Show the ingredients name
                e.Value = CType(e.Value, Ingredient).name
            Case "dcCake"
                ' If this orderline was added as part of a cake, show the cakes name
                If Not e.Value Is Nothing Then
                    e.Value = DBM.Instance.Cakes.Find(e.Value).name
                Else
                    e.Value = "Ingen"
                End If
                ' Show total price for this order line
            Case "dcTotalPrice"
                e.Value = FormatHelper.Currency(e.Value)
        End Select
    End Sub

    ''' <summary>
    ''' Handle validating of the amount-column in the datagridview. This is the only column that is editable.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub dtgOrderLines_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles dtgOrderLines.CellValidating
        ' If not the amount column, we exit
        If Not dtgOrderLines.Columns(e.ColumnIndex).Name = "dcAmount" Then
            Exit Sub
        End If

        ' Simple sanity checks. We need a positive non-zero integer
        Dim val As String = e.FormattedValue.ToString()
        Dim amount As Integer = 0
        Dim err As String = ""
        If val.Trim() = "" Then
            err = "Du må oppgi et antall."
        ElseIf Integer.TryParse(val, amount) = False Then
            err = "Du må oppgi et tall"
        ElseIf amount < 1 Then
            err = "Du må oppgi minst 1"
        Else
            Try
                ' Init a orderline from the selected row
                Dim row As DataGridViewRow = dtgOrderLines.Rows(e.RowIndex)
                Dim ol = CType(row.DataBoundItem, OrderLine)

                ' If we're editing a record, we do not allow the user to increase the unitcount, as the price is fixed in time. Reduction/deletion is allowed.
                ' If the user wants to add more of the same ingredient, it must be done in a separate orderline where new price calcuation can take place
                If Not isNewRecord AndAlso ol.id > 0 Then
                    ' We save the original unit count in the generic "Tag" property, and check against it whenever the unit count is changed
                    If row.Tag Is Nothing Then
                        row.Tag = ol.amount
                    End If
                    ' Forbid increase of unitcount
                    If row.Tag < amount Then
                        err = "Ordrelinjer på eksisterende ordrer kan ikke økes, kun reduseres ellers slettes. Maks antall for denne varelinjen er " & row.Tag & ". For å legge til flere enheter av denne ingrediensen, legg til en ny varelinje."
                    Else
                        ' Do not calculate a new price (the stock situation might very well have changed since the order was originally placed)
                        Dim orderlineSellingPrice As Decimal = ol.totalPrice / ol.amount
                        ol.totalPrice = amount * orderlineSellingPrice
                    End If
                Else
                    ' New order line, attempt to calculate a new selling price. Throw an exception if the selected ingredient and/or amount/deliverydate cannot
                    ' be satisfied
                    ol.totalPrice = amount * StockManager.GetSellingPriceFor(ol.Ingredient, amount, dtpDeliveryDate.Value)
                End If
            Catch ex As Exception
                err = ex.Message
            End Try
        End If
        ' We cannot add this ingredient, show an error box explaining why and mark the row as invalid, cancelling the edit
        If Not err Is "" Then
            dtgOrderLines.Rows(e.RowIndex).ErrorText = err
            e.Cancel = True
            MessageBox.Show(err, "Feil", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ''' <summary>
    ''' Handles the user escaping the cell, reset the errortext 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub dtgOrderLines_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dtgOrderLines.CellEndEdit
        dtgOrderLines.Rows(e.RowIndex).ErrorText = ""
        UpdateTotalPrice()
    End Sub

    ''' <summary>
    ''' Handles change of discounts
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Discount_Changed(sender As Object, e As EventArgs) Handles rdoNone.CheckedChanged, rdoPercent.CheckedChanged, rdoCurrencyValue.CheckedChanged, txtDiscount.TextChanged
        Select Case True
            Case rdoNone.Checked
                ' No discount selected, remove from order
                txtDiscount.Enabled = False
                currentRecord.discountAbsolute = 0
                currentRecord.discountPercentage = 0
            Case rdoPercent.Checked
                ' Percent selected, check that discount doesn't exceed 100%
                txtDiscount.Enabled = True
                If txtDiscount.DecimalValue > 100 Then
                    txtDiscount.Text = "0"
                End If
                currentRecord.discountAbsolute = 0
                currentRecord.discountPercentage = txtDiscount.DecimalValue
            Case rdoCurrencyValue.Checked
                ' Absolute value selected
                txtDiscount.Enabled = True
                currentRecord.discountAbsolute = txtDiscount.DecimalValue
                currentRecord.discountPercentage = 0
        End Select
        ' This will update the order with the correct sums, and update the labels showing the totals
        UpdateTotalPrice()
    End Sub

    ''' <summary>
    ''' Handle the user deleting a row from the datagridview
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub dtgOrderLines_UserDeletingRow(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dtgOrderLines.RowsRemoved
        UpdateTotalPrice()
    End Sub

    ''' <summary>
    ''' Handle the user selecting different delivery methods.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ddlDeliveryMethod_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlDeliveryMethod.SelectedIndexChanged
        If Not ddlDeliveryMethod.SelectedItem Is Nothing Then
            Dim dm As DeliveryMethod = CType(ddlDeliveryMethod.SelectedItem, DeliveryMethod)
            currentRecord.DeliveryMethod = dm
            currentRecord.shippingPrice = dm.price
            UpdateTotalPrice()
        End If
    End Sub

    ''' <summary>
    ''' Handle the user pressing the save order button
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnSaveOrder_Click(sender As Object, e As EventArgs) Handles btnSaveOrder.Click
        SaveOrder()
    End Sub

    ''' <summary>
    '''  Handle the user entering the delivery name. Use the helper to split into first and last name.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub txtDeliveryName_TextChanged(sender As Object, e As EventArgs) Handles txtDeliveryName.TextChanged
        Dim name As NameHelper = New NameHelper(txtDeliveryName.Text)
        currentRecord.deliveryFirstName = name.firstName
        currentRecord.deliveryLastName = name.lastName
    End Sub

    ''' <summary>
    ''' Handle change of address. Use the helper to select an existing or create a new address record in the database
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Address_TextChanged(sender As Object, e As EventArgs) Handles txtAddress.TextChanged, txtZip.TextChanged
        If Not isLoadingOrder Then
            currentRecord.Address = AddressHelper.GetAddress(txtZip.IntValue, txtAddress.Text)
        End If
    End Sub

    ''' <summary>
    ''' Handle delivery telephone being set
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub txtTelephone_TextChanged(sender As Object, e As EventArgs) Handles txtTelephone.TextChanged
        currentRecord.deliveryPhone = txtTelephone.Text
    End Sub

    ''' <summary>
    ''' Handle delivery date being set
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub dtpDeliveryDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpDeliveryDate.ValueChanged
        currentRecord.deliveryDate = dtpDeliveryDate.Value
    End Sub

    ''' <summary>
    ''' Handle delivery email being set
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged
        currentRecord.deliveryEmail = txtEmail.Text
    End Sub

    ''' <summary>
    ''' Handle internal note being set
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub txtInternalNote_TextChanged(sender As Object, e As EventArgs) Handles txtInternalNote.TextChanged
        currentRecord.note = txtInternalNote.Text
    End Sub

End Class
