Public Class frmSaleOrder

    Private isNewRecord = False
    Private currentRecord As Order = New Order()

    Public Sub LoadOrder(order As Order)
        'Existing record. Preloads it from db.
        isNewRecord = False
        'Adds info to form.
        cbCustomerName.Text = order.Customer.fullName.ToString()
        ddlDeliveryMethod.Text = order.DeliveryMethod.name.ToString()
        txtDeliveryName.Text = order.deliveryFirstName.ToString() & " " _
                                & order.deliveryLastName.ToString()
        txtAddress.Text = order.Address.address1.ToString()
        txtZip.Text = order.Address.Zip.zip1.ToString()
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
        txtTelephone.Text = order.deliveryPhone.ToString()
        txtEmail.Text = order.deliveryEmail.ToString()
        If order.deliveryDate.Date > CDate("1976-01-27") Then
            dtpDeliveryDate.Value = order.deliveryDate.Date()
        End If
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

        Dim orderNr As Integer = order.id
        Dim orderLines = (From x In DBM.Instance.OrderLines Where x.Order.id = orderNr _
                         Select x).ToList()

        For Each row In orderLines
            Dim ol As OrderLine = New OrderLine
            ol.Ingredient = row.Ingredient
            ol.amount = row.amount
            'Throws exception from StockManager if ingredient isn't in stock.
            'Then we won't be able to load the order.
            ol.totalPrice = ol.amount * StockManager.GetSellingPriceFor(ol.Ingredient, ol.amount, dtpDeliveryDate.Value)
            OrderLinesBindingSource.Add(ol)
        Next

        SyncCurrentOrderWithBindingSource()
        UpdateTotalPrice()

    End Sub

    Public Sub NewOrder()

        isDirty = False
        isNewRecord = False
        currentRecord = New Order()
        grpOrderStatus.Hide()
        FormHelper.ResetControls(Controls)
        OrderLinesBindingSource.Clear()
        ToggleSubscriptionGroup()
        UpdateTotalPrice()

    End Sub

    Private Sub SaveOrder()
        If Not ValidOrder() Then
            Exit Sub
        End If

        Try
            If isNewRecord Then
                DBM.Instance.Orders.Add(currentRecord)
            End If

            DBM.Instance.SaveChanges()
        Catch ex As Exception
            MessageBox.Show("Det oppstod en feil under lagring av ordre. " & ex.Message, "Feil", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        

    End Sub

    Private Function ValidOrder() As Boolean
        ' TODO! Implement
        Return True
    End Function

    Private Sub ToggleSubscriptionGroup()
        For Each c As Control In grpSubscription.Controls
            If Not c Is chkIsActivated Then
                c.Enabled = chkIsActivated.Checked
            End If
        Next
    End Sub

    Private Sub SetDeliveryToCustomer(customer As Customer)
        txtDeliveryName.Text = customer.fullName
        txtAddress.Text = customer.Address.address1
        txtZip.Text = customer.Address.Zip.zip1
        lblCity.Text = customer.Address.Zip.city.ToUpper()
        txtTelephone.Text = customer.phone
        txtEmail.Text = customer.email
    End Sub

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

    Private Sub AttemptAddIngredientOrCakeToOrder()
        If cbIngredientOrCake.SelectedValue Is Nothing Then
            Exit Sub
        End If

        Dim prefixedId As String
        Dim id As Integer
        prefixedId = System.Text.Encoding.Default.GetString(cbIngredientOrCake.SelectedValue)

        Integer.TryParse(prefixedId.Substring(1), id)
        If id = Nothing Then
            Exit Sub ' Should not happen
        End If

        ' TODO! If the ingredient is already present in other orderlines, they must be taken into account
        If prefixedId.Substring(0, 1) = "i" Then
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

                For Each ol In ols
                    OrderLinesBindingSource.Add(ol)
                Next
            Catch ex As Exception
                MessageBox.Show("Kan ikke legge til kake. En eller flere av ingrediensene har manglende dekning på lager." & _
                       vbCrLf & vbCrLf & ex.Message, "Feil", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

        SyncCurrentOrderWithBindingSource()
        UpdateTotalPrice()

    End Sub

    Private Sub SyncCurrentOrderWithBindingSource()
        currentRecord.OrderLines.Clear()
        For Each ol As OrderLine In OrderLinesBindingSource.List
            currentRecord.OrderLines.Add(ol)
        Next
    End Sub


    Private Sub UpdateTotalPrice()

        Dim totals As OrderTotals
        totals = OrderManager.CalculateTotals(currentRecord)

        lblTotalAmountWithoutVatValue.Text = FormatHelper.Currency(totals.totalPriceExVat)
        lblDiscountValue.Text = FormatHelper.Currency(totals.totalDiscount)
        lblShippingValue.Text = FormatHelper.Currency(totals.shipping)
        lblVatValue.Text = FormatHelper.Currency(totals.totalVat)
        lblAmountToPayValue.Text = FormatHelper.Currency(totals.totalToPay)

    End Sub

    Private Sub SetupDeliveryTypeDropdown()
        ddlDeliveryMethod.DisplayMember = "name"
        ddlDeliveryMethod.DataSource = DBM.Instance.DeliveryMethods.ToList()
    End Sub

    ''''''''''''''''''''''''''''''''''''

    Private Sub frmSaleOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DBM.Instance.Customers.Load()
        CustomerBindingSource.DataSource = DBM.Instance.Customers.Local.ToBindingList()
        AddressHelper.SetupAutoCityFill(txtZip, lblCity)
        FormHelper.SetupDirtyTracking(Me)
        SetupIngredientOrCakeSelection()
        SetupDeliveryTypeDropdown()
        NewOrder()
    End Sub

    Private Sub btnNewCustomer_Click(sender As Object, e As EventArgs) Handles btnNewCustomer.Click
        CustomerManager.NewCustomerAndReturnTo(Me)
    End Sub


    Private Sub cbCustomerName_Leave(sender As Object, e As EventArgs) Handles cbCustomerName.Leave
        If cbCustomerName.SelectedValue Is Nothing AndAlso Not cbCustomerName.Text = "" Then
            If MessageBox.Show("Denne kunden finnes ikke. Opprette?", "Ukjent kunde", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                CustomerManager.NewCustomerAndReturnTo(Me)
            Else
                cbCustomerName.Focus()
            End If
        End If
    End Sub

    Private Sub cbCustomerName_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbCustomerName.SelectedValueChanged
        If Not cbCustomerName.SelectedItem Is Nothing Then
            SetDeliveryToCustomer(cbCustomerName.SelectedItem)
            currentRecord.Customer = cbCustomerName.SelectedItem
        End If
    End Sub


    Private Sub chkIsActivated_CheckedChanged(sender As Object, e As EventArgs) Handles chkIsActivated.CheckedChanged
        ToggleSubscriptionGroup()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If Not FormHelper.ContinueIfDirty(Me) Then
            Exit Sub
        End If
        SessionManager.Instance.ShowForm(frmSaleMain)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        If Not FormHelper.ContinueIfDirty(Me) Then
            Exit Sub
        End If
        NewOrder()
    End Sub

    Private Sub cbIngredientOrCake_KeyDown(sender As Object, e As KeyEventArgs) Handles cbIngredientOrCake.KeyDown
        If e.KeyCode = Keys.Enter Then
            AttemptAddIngredientOrCakeToOrder()
        End If
    End Sub

    Private Sub cbIngredientOrCake_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbIngredientOrCake.SelectionChangeCommitted, btnAddIngredientOrCake.Click
        AttemptAddIngredientOrCakeToOrder()
    End Sub

    Private Sub dtgOrderLines_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dtgOrderLines.CellFormatting
        If e.ColumnIndex < 0 Then
            Exit Sub
        End If
        Select Case dtgOrderLines.Columns(e.ColumnIndex).Name
            Case "dcIngredient"
                e.Value = CType(e.Value, Ingredient).name
            Case "dcCake"
                If Not e.Value Is Nothing Then
                    e.Value = DBM.Instance.Cakes.Find(e.Value).name
                Else
                    e.Value = "Ingen"
                End If
            Case "dcTotalPrice"
                e.Value = FormatHelper.Currency(e.Value)
        End Select
    End Sub

    Private Sub dtgOrderLines_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles dtgOrderLines.CellValidating

        If Not dtgOrderLines.Columns(e.ColumnIndex).Name = "dcAmount" Then
            Exit Sub
        End If

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
                Dim ol = CType(dtgOrderLines.Rows(e.RowIndex).DataBoundItem, OrderLine)
                ol.totalPrice = amount * StockManager.GetSellingPriceFor(ol.Ingredient, amount, dtpDeliveryDate.Value)
                SyncCurrentOrderWithBindingSource()
            Catch ex As Exception
                err = ex.Message
            End Try
        End If
        If Not err Is "" Then
            dtgOrderLines.Rows(e.RowIndex).ErrorText = err
            e.Cancel = True
            MessageBox.Show(err, "Feil", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub dtgOrderLines_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dtgOrderLines.CellEndEdit
        dtgOrderLines.Rows(e.RowIndex).ErrorText = ""
        UpdateTotalPrice()
    End Sub

    Private Sub Discount_Changed(sender As Object, e As EventArgs) Handles rdoNone.CheckedChanged, rdoPercent.CheckedChanged, rdoCurrencyValue.CheckedChanged, txtDiscount.TextChanged
        Select Case True

            Case rdoNone.Checked
                txtDiscount.Enabled = False
                currentRecord.discountAbsolute = 0
                currentRecord.discountPercentage = 0

            Case rdoPercent.Checked
                txtDiscount.Enabled = True
                If txtDiscount.DecimalValue > 100 Then
                    txtDiscount.Text = "0"
                End If
                currentRecord.discountAbsolute = 0
                currentRecord.discountPercentage = txtDiscount.DecimalValue

            Case rdoCurrencyValue.Checked
                txtDiscount.Enabled = True
                currentRecord.discountAbsolute = txtDiscount.DecimalValue
                currentRecord.discountPercentage = 0
        End Select
        UpdateTotalPrice()
    End Sub

    '  Private Sub txtDiscount_Leave(sender As Object, e As EventArgs) Handles txtDiscount.Leave
    'Check if total discount exceeds total order value
    '   End Sub

    Private Sub dtgOrderLines_UserDeletingRow(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dtgOrderLines.RowsRemoved
        SyncCurrentOrderWithBindingSource()
        UpdateTotalPrice()
    End Sub

    Private Sub ddlDeliveryMethod_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlDeliveryMethod.SelectedIndexChanged
        If Not ddlDeliveryMethod.SelectedItem Is Nothing Then
            Dim dm As DeliveryMethod = CType(ddlDeliveryMethod.SelectedItem, DeliveryMethod)
            currentRecord.DeliveryMethod = dm
            currentRecord.shippingPrice = dm.price
            UpdateTotalPrice()
        End If
    End Sub

    Private Sub btnSaveOrder_Click(sender As Object, e As EventArgs) Handles btnSaveOrder.Click
        SaveOrder()
    End Sub

    Private Sub txtDeliveryName_TextChanged(sender As Object, e As EventArgs) Handles txtDeliveryName.TextChanged
        Dim name As NameHelper = New NameHelper(txtDeliveryName.Text)
        currentRecord.deliveryFirstName = name.firstName
        currentRecord.deliveryLastName = name.lastName
    End Sub

    Private Sub Address_TextChanged(sender As Object, e As EventArgs) Handles txtAddress.TextChanged, txtZip.TextChanged
        currentRecord.Address = AddressHelper.GetAddress(txtZip.IntValue, txtAddress.Text)
    End Sub

    Private Sub txtTelephone_TextChanged(sender As Object, e As EventArgs) Handles txtTelephone.TextChanged
        currentRecord.deliveryPhone = txtTelephone.Text
    End Sub

    Private Sub dtpDeliveryDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpDeliveryDate.ValueChanged
        ' TODO! Missing from datamodel
    End Sub

    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged
        currentRecord.deliveryEmail = txtEmail.Text
    End Sub

    Private Sub txtInternalNote_TextChanged(sender As Object, e As EventArgs) Handles txtInternalNote.TextChanged
        currentRecord.note = txtInternalNote.Text
    End Sub
End Class
