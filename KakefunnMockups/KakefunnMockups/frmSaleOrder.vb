Imports System.Configuration

''' <summary>
''' Form handler for registering and editing of orders
''' </summary>
''' <remarks>
''' TODO
''' - Stock does not increase if order rows are deleted on exisiting orders
''' - Extra markup on cakes are not taken into account
''' </remarks>
Public Class frmSaleOrder

    ' Flag used to trigger logic specific to either saved or new orders
    Private isNewRecord = False
    ' Holds the order currently being edited, either new or existing
    Private currentRecord As New Order
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

        '  Set static fields
        cbCustomerName.Text = order.Customer.fullName.ToString()
        ddlDeliveryMethod.Text = order.DeliveryMethod.name.ToString()
        txtDeliveryName.Text = order.deliveryFirstName.ToString() & " " _
                                & order.deliveryLastName.ToString()
        txtAddress.Text = order.Address.address1.ToString()
        txtZip.Text = order.Address.Zip.zip1.ToString("D4")
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

        ' Handle subscriptions
        Dim subscription As Subscription = DBM.Instance.Subscriptions.Where(Function(s) s.Order.id = order.id).FirstOrDefault
        If subscription IsNot Nothing Then
            chkSubscriptionIsActivated.Checked = subscription.isActive
            ddlFrequencyType.SelectedItem = subscription.FrequencyType
            ddlFrequency.SelectedIndex = subscription.frequency - 1
            If subscription.stopDate Is Nothing Then
                cboHasEndDate.Checked = False
            Else
                cboHasEndDate.Checked = True
                dtpEndDate.Value = subscription.stopDate
            End If
        End If

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

        ' Now that the order is loaded fully, we check if it is already sent. If it is, we disable everything
        If currentRecord.sent IsNot Nothing Then
            FormHelper.DisableControls(Me)
            UpdateActionStatus("Denne ordren er sent og kan ikke redigeres.")
        Else
            UpdateActionStatus("Redigerer ordre #" & currentRecord.id)
        End If

        isLoadingOrder = False
        isDirty = False

    End Sub

    ''' <summary>
    ''' Clears the form and readies a new order
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub NewOrder()

        isNewRecord = True
        currentRecord = DBM.Instance.Orders.Create(Of Order)()
        currentRecord.deliveryDate = Date.Today
        grpOrderStatus.Hide()
        FormHelper.ResetControls(Me)
        OrderLinesBindingSource.DataSource = currentRecord.OrderLines.ToBindingList
        ToggleSubscriptionGroup()
        UpdateTotalPrice()
        UpdateActionStatus()
        isDirty = False

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

            Dim subscription As Subscription
            subscription = DBM.Instance.Subscriptions.Where(Function(s) s.Order.id = currentRecord.id).FirstOrDefault()

            If chkSubscriptionIsActivated.Checked Then
                ' Mark the order as a subscription ordre. This causes it to be treated only as a template
                ' for automatically generated orders, and not as an order in and of itself
                currentRecord.isSubscriptionOrder = True
                If isNewRecord Then
                    subscription = DBM.Instance.Subscriptions.Create(Of Subscription)()
                Else
                    ' Do we have one from before?
                    If subscription Is Nothing Then
                        ' Nope, create a new one
                        subscription = DBM.Instance.Subscriptions.Create(Of Subscription)()
                    End If
                End If

                ' Set subscription fields
                With subscription
                    .Order = currentRecord
                    .startDate = currentRecord.deliveryDate
                    If cboHasEndDate.Checked Then
                        .stopDate = dtpEndDate.Value
                    Else
                        .stopDate = Nothing
                    End If
                    .FrequencyType = ddlFrequencyType.SelectedItem
                    .frequency = ddlFrequency.SelectedIndex + 1
                    .isActive = True
                    .modified = Date.Now() ' Fixme: The subscription may not have changed (use EF changetracker?)
                End With
            Else
                ' The order will always be a subscription order, but we can deactivate the automatic order creation
                If subscription IsNot Nothing AndAlso subscription.isActive = True Then
                    subscription.isActive = False
                    subscription.modified = Date.Now()
                End If
            End If

            If isNewRecord Then
                currentRecord.Employee = SessionHelper.Instance.User
                currentRecord.created = Date.Now()
                DBM.Instance.Orders.Add(currentRecord)
            End If

            currentRecord.modified = Date.Now()
            DBM.Instance.SaveChanges()

            ' If the subscription is a new one, we must not add it until the order
            ' is saved in order to get the foreign id set
            If subscription.id = 0 Then
                DBM.Instance.Subscriptions.Add(subscription)
                subscription.created = Date.Now()
                DBM.Instance.SaveChanges()
            End If

            ' Update inventory, if this is a new order, we reduce inventories reflecting the orderlines
            ' If editing an old order, we must loop through all orderlines and handle any changes manually
            Dim ol As OrderLine
            Dim reduction As Integer
            For Each row As DataGridViewRow In dtgOrderLines.Rows
                ol = CType(row.DataBoundItem, OrderLine)
                If isNewRecord Then
                    StockHelper.ReduceInventory(ol.Ingredient, ol.amount, currentRecord.deliveryDate)
                Else
                    ' We saved the original count in the Tag-property of the datagridviewrow
                    If Not row.Tag Is Nothing Then
                        ' This means we've reduced the orderline by some amount, increase the stock
                        reduction = row.Tag - ol.amount
                        StockHelper.IncreaseInventory(ol.Ingredient, reduction, currentRecord.deliveryDate)
                    Else
                        ' New row, reduce by full amount
                        StockHelper.ReduceInventory(ol.Ingredient, ol.amount, currentRecord.deliveryDate)
                    End If
                End If
            Next

            ' TODO! Deal with deleted rows ...

        Catch ex As Exception
            MessageBox.Show("Det oppstod en feil under lagring av ordre. " & ex.Message, "Feil", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

        MsgBox("Ordren ble lagret", MsgBoxStyle.Information)

        If isNewRecord Then
            KakefunnEvent.saveSystemEvent("Ordrer", "Lagret ny ordre: " & currentRecord.id)
        Else
            KakefunnEvent.saveSystemEvent("Ordrer", "Oppdatert ordre: " & currentRecord.id)
        End If

        If cboPrintReceiptOnSave.Checked Then
            PrintReceipt()
        End If


        ' Re-load the order in order to trigger saved record logic
        LoadOrder(currentRecord)

    End Sub

    ''' <summary>
    ''' Creates a simple HTML receipt
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub PrintReceipt()

        Dim r As HtmlReport = New HtmlReport() With {.Title = "Kvittering ordre #" & currentRecord.id}
        r.Init()

        With currentRecord
            r.StartDefintionList()
            r.AddDefiniton("Kunde", .Customer.fullName)
            r.AddDefiniton("Leveres", .deliveryFirstName & " " & .deliveryLastName)
            r.AddDefiniton("Adresse", .Address.address1 & ", " & .Address.Zip.zip1.ToString("D4") & " " & .Address.Zip.city)
            r.AddDefiniton("E-post", .deliveryEmail)
            r.AddDefiniton("Telefon", .deliveryPhone)
            r.AddDefiniton("Leveringsdato", .deliveryDate)
            r.AddDefiniton("Leveringsmetode", .DeliveryMethod.name)
            r.EndDefinitionList()

            r.StartTable({"Ingrediens", "Antall", "Beløp"})
            For Each ol As OrderLine In .OrderLines
                r.AddRow({ol.Ingredient.name, ol.amount, FormatHelper.Currency(ol.totalPrice)})
            Next
            r.AddRow({""})

            Dim totals As OrderTotals = OrderHelper.CalculateTotals(currentRecord)
            r.AddRow({"Totalt eks.mva", "", FormatHelper.Currency(totals.totalPriceExVat)})
            r.AddRow({"Rabatt", "", FormatHelper.Currency(-totals.totalDiscount)})
            r.AddRow({"Frakt", "", FormatHelper.Currency(totals.shipping)})
            r.AddRow({"MVA", "", FormatHelper.Currency(totals.totalVat)})
            r.AddRow({""})
            r.AddRow({"Å betale", "", FormatHelper.Currency(totals.totalToPay)})

            r.OpenInBrowser()

        End With


    End Sub

    ''' <summary>
    ''' Validates that the supplied data is sane. Displays a message box for the first encountered invalid field and returns false.
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function ValidOrder() As Boolean
        Dim err As String = ""
        With currentRecord
            If .Customer Is Nothing Then
                err = "Du må velge en kunde som bestiller."
            ElseIf .deliveryFirstName Is Nothing Or .deliveryLastName Is Nothing Then
                err = "Du må oppgi leveringsnavn."
            ElseIf .Address Is Nothing Then
                err = "Du må oppgi en leveringsaddresse."
            ElseIf .deliveryEmail Is Nothing Then
                err = "Du må oppgi en e-post."
            ElseIf .deliveryPhone Is Nothing Then
                err = "Du må oppgi et telefonnummer"
            ElseIf .deliveryDate.Date < Date.Today Then
                err = "Du må oppgi en fremtidig leveringsdato."
            ElseIf .DeliveryMethod Is Nothing Then
                err = "Du må velge en leveringsmetode."
            ElseIf .deliveryDate.DayOfWeek = DayOfWeek.Sunday Then
                err = "Du har oppgitt levering på en søndag, dette kan ikke utføres."
            ElseIf dtgOrderLines.Rows.Count = 0 Then
                err = "Ordren inneholder ingen ingredienser."
            ElseIf chkSubscriptionIsActivated.Checked Then
                If ddlFrequencyType.SelectedIndex = -1 OrElse ddlFrequency.SelectedIndex = -1 Then
                    err = "Du må velge et intervall for abonnementet"
                End If
            Else
                For Each row As DataGridViewRow In dtgOrderLines.Rows
                    If Not row.ErrorText = "" Then
                        err = "Ordren har en eller flere varelinjer med feil."
                        Exit For
                    End If
                Next
            End If
        End With

        If Not err = "" Then
            MessageBox.Show(err, "Feil ved lagring av ordre", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        Return True
    End Function

    ''' <summary>
    ''' Show/hides the subscription controls based on the checkbox indicating that is is a subscription order or not
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ToggleSubscriptionGroup()
        For Each c As Control In grpSubscription.Controls
            If Not c Is chkSubscriptionIsActivated Then
                c.Enabled = chkSubscriptionIsActivated.Checked
            End If
        Next
        If chkSubscriptionIsActivated.Checked Then
            dtpEndDate.Enabled = cboHasEndDate.Checked
        End If
    End Sub

    ''' <summary>
    ''' Utility function to prefill the delivery fields to the same as the ordering customer
    ''' </summary>
    ''' <param name="customer"></param>
    ''' <remarks></remarks>
    Private Sub SetDeliveryToCustomer(customer As Customer)
        txtDeliveryName.Text = customer.fullName
        txtAddress.Text = customer.Address.address1
        txtZip.Text = customer.Address.Zip.zip1.ToString("D4")
        lblCity.Text = customer.Address.Zip.city.ToUpper()
        txtTelephone.Text = customer.phone
        txtEmail.Text = customer.email
        currentRecord.Address = customer.Address
    End Sub

    ''' <summary>
    ''' Populates the dropdown list for ingredients and cakes. This is done via a UNION select, where we prefix the primary ids. 
    ''' AttemptAddIngredientOrCakeToOrder() uses this index to determine if we're trying to add a single ingredient or a cake
    ''' Uses delivery date to determine whether or not the ingredient has expired (with a configurable grace period). Note that
    ''' we do not exclude ingredients not in stock at the selected delivery date point, these are shown with unitCount at 0. Upon adding, the
    ''' StockManager will inform the user if any stocks are expected in the future, and the order will not be able to save.
    ''' Note that ingredients going into cakes are not checked here, but are validated upon adding. Only cakes with all its ingredients available 
    ''' will be added.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    Private Sub SetupIngredientOrCakeSelection()

        Dim expiryGraceDays As String = ConfigurationManager.AppSettings.Get("sale.order.expiryGraceDays")
        Dim deliveryDate As String = dtpDeliveryDate.Value.ToString("yyyy-MM-dd")

        Dim dt As DataTable = DBM.Instance.GetDataTableFromQuery( _
            "SELECT 1 as isIngredient, CONCAT('i', i.id) as id, CONCAT(name, ' (x', IFNULL(SUM(b.unitCount), 0), ')') as name FROM Ingredient i " & _
            "LEFT JOIN Batch b ON (" & _
            "	b.ingredientId = i.id " & _
            "	AND b.deleted IS NULL " & _
            "   AND (b.registered IS NOT NULL OR b.expected <= '" & deliveryDate & "') " & _
            "	AND (b.expires IS NULL OR b.expires > DATE_ADD('" & deliveryDate & "', INTERVAL " & expiryGraceDays & " DAY)) " & _
            "	AND unitCount > 0 " & _
            ") " & _
            "WHERE i.deleted IS NULL and published = 1 " & _
            "GROUP BY name " & _
            "UNION " & _
            "SELECT 0 as isIngredient, CONCAT('c', id) as id, CONCAT(name, ' (Kake)') as name FROM Cake " & _
            "WHERE deleted IS NULL AND published = 1 " & _
            "ORDER BY isIngredient, name "
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

        If TypeOf cbIngredientOrCake.SelectedValue Is String Then
            prefixedId = cbIngredientOrCake.SelectedValue
        Else
            prefixedId = System.Text.Encoding.Default.GetString(cbIngredientOrCake.SelectedValue)
        End If
        Integer.TryParse(prefixedId.Substring(1), id)
        If id = Nothing Then
            Exit Sub ' Should not happen
        End If

        If prefixedId.Substring(0, 1) = "i" Then
            ' We have a single ingredient
            Try
                Dim ing As Ingredient = DBM.Instance.Ingredients.Find(id)
                Dim ol = GetOrderLineForIngredient(ing)
                Dim add As Boolean = True
                If ol.amount = 0 Then
                    add = True
                Else
                    add = False
                End If
                ol.Ingredient = ing
                ol.amount = ol.amount + 1
                ol.totalPrice = ol.amount * StockHelper.GetSellingPriceFor(ol.Ingredient, ol.amount, dtpDeliveryDate.Value)

                If add Then
                    OrderLinesBindingSource.Add(ol)
                Else
                    dtgOrderLines.Refresh()
                End If
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
                Dim add As Boolean = True
                For Each r As RecipeLine In cake.RecipeLines
                    ol = GetOrderLineForIngredient(r.Ingredient)
                    If ol.amount = 0 Then
                        add = True
                    Else
                        add = False
                    End If
                    ol.Ingredient = r.Ingredient
                    ol.amount = ol.amount + r.amount
                    ol.totalPrice = ol.amount * StockHelper.GetSellingPriceFor(ol.Ingredient, ol.amount, dtpDeliveryDate.Value)
                    ol.cakeId = cake.id
                    If add Then
                        ols.Add(ol)
                    End If
                Next
                dtgOrderLines.Refresh()

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
    ''' Checks if the ingredient is already present in a non-saved orderline. If so, return that instead
    ''' </summary>
    ''' <param name="ingredient"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function GetOrderLineForIngredient(ingredient As Ingredient) As OrderLine
        Dim ol As OrderLine
        For Each row As DataGridViewRow In dtgOrderLines.Rows
            ol = CType(row.DataBoundItem, OrderLine)
            If ol.Ingredient.id = ingredient.id AndAlso ol.id = 0 Then
                Return ol
            End If
        Next
        Return New OrderLine
    End Function

    ''' <summary>
    ''' Updates the labels on the bottom of the form with the totals
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub UpdateTotalPrice()

        Dim totals As OrderTotals
        totals = OrderHelper.CalculateTotals(currentRecord)

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

    ''' <summary>
    ''' Popluates the frequency type dropdown with available options
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub SetupFrequencyTypeDropDown()
        ddlFrequencyType.DisplayMember = "name"
        ddlFrequencyType.DataSource = DBM.Instance.FrequencyTypes.ToList()
    End Sub


    ''' <summary>
    ''' Validates a row in the ingredientlist, returns a empty string if no error or a string explaining the error
    ''' </summary>
    ''' <param name="row"></param>
    ''' <paran name="newCount"></paran>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function ValidateIngredientCount(row As DataGridViewRow, val As String) As String

        ' Simple sanity checks. We need a positive non-zero integer
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
                    ol.totalPrice = amount * StockHelper.GetSellingPriceFor(ol.Ingredient, amount, dtpDeliveryDate.Value)
                End If
            Catch ex As Exception
                err = ex.Message
            End Try
        End If

        Return err

    End Function

    ''' <summary>
    ''' Overload of above, re-validates existing value
    ''' </summary>
    ''' <param name="row"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function ValidateIngredientCount(row As DataGridViewRow) As String
        Dim value As String = row.Cells("dcAmount").FormattedValue
        Return ValidateIngredientCount(row, value)
    End Function

    ''' <summary>
    ''' Resets the action status if there is no other grid errors left, if there is, it sets to the last of them
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ResetActionStatusIfNoGridErrors()
        ' If no other rows have error texts, remove the action status
        Dim hasError As Boolean = False
        For Each row As DataGridViewRow In dtgOrderLines.Rows
            If Not row.ErrorText = "" Then
                hasError = True
                UpdateActionStatus(row.ErrorText)
            End If
        Next
        If Not hasError Then
            UpdateActionStatus()
        End If
    End Sub

    '''''''''''''''''''''''''''''''''''' BELOW THIS POINT ARE EVENT HANDLERS ''''''''''''''''''''''''''''''''''''''''''''''''''

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
        SetupIngredientOrCakeSelection()
        SetupDeliveryTypeDropdown()
        SetupFrequencyTypeDropDown()
        FormHelper.SetupDirtyTracking(Me)
        ' Start with a new order
        NewOrder()
    End Sub


    ''' <summary>
    ''' Handles when the user clicks new customer. Temporarily hides the order form (no saving is performed) and puts the customer screen
    ''' in the foreground. When completing the customer form, the user is returned to this form.
    ''' A callback is supplied which is run upon returning to the order form. This loads the recently
    ''' added customer (if it was saved)
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnNewCustomer_Click(sender As Object, e As EventArgs) Handles btnNewCustomer.Click
        CustomerHelper.NewCustomerAndReturnTo(Me,
            Function(customerForm, orderForm)
                Dim customer As Customer = CType(customerForm, frmSaleCustomer).currentCustomer
                ' Check if it got saved
                If customer.id > 0 Then
                    SetDeliveryToCustomer(customer)
                    currentRecord.Customer = customer
                    cbCustomerName.Text = customer.fullName
                End If
                Return True
            End Function
        )
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
                CustomerHelper.NewCustomerAndReturnTo(Me)
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
    Private Sub chkIsActivated_CheckedChanged(sender As Object, e As EventArgs) Handles chkSubscriptionIsActivated.CheckedChanged
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
        SessionHelper.Instance.ShowForm(returnToForm)
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

        dtgOrderLines.Rows(e.RowIndex).ErrorText = ""

        Dim err As String = ValidateIngredientCount(dtgOrderLines.Rows(e.RowIndex), e.FormattedValue)

        ' We cannot delivery this amount of this ingredient at the selected date
        ' As this error may happen if the delivery date is changed after lines are entered, we do not cancel the 
        ' event or hinder the edit. But the order cannot be saved with any rows having errortext.
        If Not err Is "" Then
            dtgOrderLines.Rows(e.RowIndex).ErrorText = err
            UpdateActionStatus(err)
        Else
            ResetActionStatusIfNoGridErrors()
        End If
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
    Private Sub Address_TextChanged(sender As Object, e As EventArgs) Handles txtAddress.Leave, txtZip.Leave
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
    ''' Handle delivery date being set. This triggers the ingredient list to be rebuilt, and will cause all all added ingredients to be re-validated.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub dtpDeliveryDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpDeliveryDate.ValueChanged
        currentRecord.deliveryDate = dtpDeliveryDate.Value
        SetupIngredientOrCakeSelection()
        Dim err = ""
        For Each row As DataGridViewRow In dtgOrderLines.Rows
            err = ValidateIngredientCount(row)
            If Not err = "" Then
                row.ErrorText = err
                UpdateActionStatus(err)
            Else
                row.ErrorText = ""
            End If
        Next
        ' Set minimum end date for subscriptions to that of delivery date
        dtpEndDate.MinDate = dtpDeliveryDate.Value

        ResetActionStatusIfNoGridErrors()
    End Sub

    ''' <summary>
    ''' Handle delivery email being set
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs)
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

    ''' <summary>
    ''' Handle show subscription orders for loaded order
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnShowOrderForSubscription_Click(sender As Object, e As EventArgs) Handles btnShowOrderForSubscription.Click
        If isNewRecord Then
            Exit Sub
        End If
        SearchHelper.SearchOrders(Function(o) o.subscriptionId = currentRecord.id)
    End Sub

    ''' <summary>
    ''' Sets whether or not the order has been paid (usually the case with over-the-counter orders)
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub cboIsPayed_CheckedChanged(sender As Object, e As EventArgs) Handles cboIsPayed.CheckedChanged
        currentRecord.isPaid = cboIsPayed.Checked
    End Sub

    ''' <summary>
    ''' Enables/disabled end-date
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub cboHasEndDate_CheckedChanged(sender As Object, e As EventArgs) Handles cboHasEndDate.CheckedChanged
        dtpEndDate.Enabled = cboHasEndDate.Checked
    End Sub
End Class
