Public Class frmSaleOrder

    Private isNewRecord = False
    Private currentRecord As Order

    Public Sub LoadOrder(order As Order)
        MsgBox("load order " & order.id)
    End Sub

    Public Sub NewOrder()

        isDirty = False
        isNewRecord = False
        currentRecord = Nothing
        grpOrderStatus.Hide()
        FormHelper.ResetControls(Controls)
        OrderLinesBindingSource.Clear()
        ToggleSubscriptionGroup()
        UpdateTotalPrice()

    End Sub

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

        UpdateTotalPrice()

    End Sub

    Private Sub UpdateTotalPrice()
        Dim totalPriceExVat As Decimal = 0
        Dim totalVat As Decimal = 0
        Dim remainingDiscount As Decimal = 0
        Dim totalDiscount As Decimal = 0
        Dim orderLineDiscount As Decimal = 0
        Dim orderLinePrice As Decimal = 0

        If rdoCurrencyValue.Checked Then
            remainingDiscount = txtDiscount.DecimalValue
            totalDiscount = remainingDiscount
        End If

        For Each ol As OrderLine In OrderLinesBindingSource.List

            orderLinePrice = ol.totalPrice
            If rdoPercent.Checked Then
                orderLineDiscount = (orderLinePrice / 100 * txtDiscount.DecimalValue)
                orderLinePrice = orderLinePrice - orderLineDiscount
                totalDiscount = totalDiscount + orderLineDiscount
            ElseIf rdoCurrencyValue.Checked Then
                If remainingDiscount > orderLinePrice Then
                    remainingDiscount = remainingDiscount - orderLinePrice
                    Continue For
                End If
                orderLinePrice = orderLinePrice - remainingDiscount
            End If

            totalPriceExVat = totalPriceExVat + orderLinePrice
            totalVat = totalVat + (orderLinePrice / 100) * ol.Ingredient.vat
        Next

        lblTotalAmountWithoutVatValue.Text = FormatHelper.Currency(totalPriceExVat)
        lblDiscountValue.Text = FormatHelper.Currency(totalDiscount)
        lblVatValue.Text = FormatHelper.Currency(totalVat)
        lblAmountToPayValue.Text = FormatHelper.Currency(totalPriceExVat - totalDiscount + totalVat)

    End Sub

    ''''''''''''''''''''''''''''''''''''

    Private Sub frmSaleOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DBM.Instance.Customers.Load()
        CustomerBindingSource.DataSource = DBM.Instance.Customers.Local.ToBindingList()
        AddressHelper.SetupAutoCityFill(txtZip, lblCity)
        FormHelper.SetupDirtyTracking(Me)
        SetupIngredientOrCakeSelection()
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

    Private Sub Discount_CheckedChanged(sender As Object, e As EventArgs) Handles rdoNone.CheckedChanged, rdoPercent.CheckedChanged, rdoCurrencyValue.CheckedChanged
        Select Case True
            Case rdoNone.Checked
                txtDiscount.Enabled = False
            Case rdoPercent.Checked
                txtDiscount.Enabled = True
                If txtDiscount.DecimalValue > 100 Then
                    txtDiscount.Text = "0"
                End If
            Case rdoCurrencyValue.Checked
                txtDiscount.Enabled = True
        End Select
        UpdateTotalPrice()
    End Sub

    Private Sub txtDiscount_TextChanged(sender As Object, e As EventArgs) Handles txtDiscount.TextChanged
        UpdateTotalPrice()
    End Sub
End Class
