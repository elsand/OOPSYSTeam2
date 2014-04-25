''' <summary>
''' Handles creating and editing customers
''' </summary>
''' <remarks></remarks>
Public Class frmSaleCustomer

    ' Flag used to trigger logic specific to either saved or new customers
    Private isNewRecord = False
    ' Holds the customer currently being edited, either new or existing
    Private currentRecord As Customer = New Customer()
    ' Flag to tell event handlers if we're currently loading a record
    Private isLoadingCustomer = False
    ' Holds which form we are to return to. Default to frmSaleMain
    Public returnToForm As Form

    ' Used in callbacks when other forms wants to get the newly created/just edited customer
    Public ReadOnly Property currentCustomer
        Get
            Return currentRecord
        End Get
    End Property

    ''' <summary>
    ''' Loads the supplied customer for editing
    ''' </summary>
    ''' <param name="customer"></param>
    ''' <remarks></remarks>
    Public Sub LoadCustomer(customer As Customer)
        isLoadingCustomer = True

        ' Reset everything
        NewCustomer()

        ' Set the loaded order as the current order and tell so to EF
        currentRecord = customer
        DBM.Instance.Customers.Attach(currentRecord)

        isDirty = False
        isNewRecord = False

        ' Set static fields
        txtName.Text = currentRecord.fullName
        txtAddress.Text = currentRecord.Address.address1
        txtZip.Text = currentRecord.Address.Zip.zip1.ToString("D4")
        txtEmail.Text = currentRecord.email
        txtTelephone.Text = currentRecord.phone
        txtNote.Text = currentRecord.note

        ddlCustomerType.SelectedItem = currentRecord.CustomerType
        ddlDiscountPlan.SelectedItem = currentRecord.DiscountPlan

        ' Show status
        grpCustomerStatus.Show()
        lblCustomerNumberValue.Text = currentRecord.id
        lblCreatedDateAndTime.Text = currentRecord.created.Value
        lblLastEditedDateAndTimeValue.Text = currentRecord.modified.Value

        ' Find orders for this customer and display count and value
        Dim orders As List(Of Order) = OrderManager.FindOrdersForCustomer(currentRecord)
        lblNumberOfOrdersValue.Text = orders.Count

        Dim totalValue As Decimal = 0
        For Each o As Order In orders
            totalValue = totalValue + OrderManager.CalculateTotals(o).totalToPay
        Next
        lblTotalOrderValueValue.Text = FormatHelper.Currency(totalValue)

        isLoadingCustomer = False
    End Sub

    ''' <summary>
    ''' Create new customer
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub NewCustomer()
        isDirty = False
        isNewRecord = True
        currentRecord = New Customer()
        grpCustomerStatus.Hide()
        lblCity.Text = ""
        FormHelper.ResetControls(Me)
    End Sub

    ''' <summary>
    ''' Saves the new customer, or changes to an existing one
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub SaveCustomer()

        If Not ValidateCustomer() Then
            Exit Sub
        End If

        Try
            If isNewRecord Then
                currentRecord.created = Date.Now()
                DBM.Instance.Customers.Add(currentRecord)
            End If
            currentRecord.modified = Date.Now()
            DBM.Instance.SaveChanges()
            If isNewRecord Then
                KakefunnEvent.saveSystemEvent("Customers", "Created new customer #" & currentRecord.id)
            Else
                KakefunnEvent.saveSystemEvent("Customers", "Saved changes to customer #" & currentRecord.id)
            End If
        Catch ex As Exception
            MessageBox.Show("Det oppstod en feil under lagring av kunden. " & ex.Message, "Feil", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

        MessageBox.Show("Kunden ble lagret", "Lagret", MessageBoxButtons.OK, MessageBoxIcon.Information)
        SessionManager.Instance.ShowForm(returnToForm)

    End Sub

    ''' <summary>
    ''' Handles validation of the customer
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function ValidateCustomer() As Boolean
        Dim err As String = ""

        If txtName.Text = "" Then
            err = "Du må oppgi et navn."
        ElseIf txtAddress.Text = "" Then
            err = "Du må oppgi en addresse."
        ElseIf lblCity.Text = "UGYLDIG" Then
            err = "Du må oppgi et gyldig postnummer."
        ElseIf txtEmail.Text = "" Then
            err = "Du må oppgi en e-postadresse."
        ElseIf txtTelephone.Text = "" Then
            err = "Du må oppgi et telefonnummer."
        ElseIf ddlCustomerType.SelectedIndex = -1 Then
            err = "Du må oppgi en kundetype."
        ElseIf ddlDiscountPlan.SelectedIndex = -1 Then
            err = "Du må oppgi en rabattplan."
        End If

        If Not err = "" Then
            MessageBox.Show(err, "Feil i skjema", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        Return True
    End Function

    '''''''''''''''''''''''''''''''''''' BELOW THIS POINT ARE EVENT HANDLERS ''''''''''''''''''''''''''''''''''''''''''''''''''

    ''' <summary>
    ''' Handles initial load of the form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub frmSaleCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        returnToForm = frmSaleMain ' By default we return to frmSaleMain. This may be set to other forms (if eg. we're shown from a statistics report)

        ' Set up autocomplete of city for zip
        AddressHelper.SetupAutoCityFill(txtZip, lblCity)

        ' Prompt if the user is about to discard unsaved changes
        FormHelper.SetupDirtyTracking(Me)

        ' Set up dropdown lists
        ddlCustomerType.DisplayMember = "name"
        ddlCustomerType.DataSource = DBM.Instance.CustomerTypes.ToList()

        ddlDiscountPlan.DisplayMember = "name"
        ddlDiscountPlan.DataSource = DBM.Instance.DiscountPlans.ToList()

        ' Start with a new order
        NewCustomer()
    End Sub

    ''' <summary>
    ''' Handles cancel, returning the user to whatever form they came from
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
    ''' Handles save click
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        SaveCustomer()
    End Sub


    ''' <summary>
    ''' Handles updating the name fields in the current customer
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        Dim name As NameHelper = New NameHelper(txtName.Text)
        currentRecord.firstName = name.firstName
        currentRecord.lastName = name.lastName
    End Sub

    ''' <summary>
    ''' Handles setting address in the current customer. If we are in the process
    ''' of loading a customer, do not do anything as that will cause addresshelper to
    ''' return nothing (since either txtZip or txtAddress at this point is empty)
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Address_TextChanged(sender As Object, e As EventArgs) Handles txtAddress.Leave, txtZip.Leave
        If Not isLoadingCustomer Then
            currentRecord.Address = AddressHelper.GetAddress(txtZip.IntValue, txtAddress.Text)
        End If
    End Sub

    ''' <summary>
    ''' Handle setting e-mailaddress to the current customer
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged
        currentRecord.email = txtEmail.Text
    End Sub

    ''' <summary>
    ''' Handles setting phone number to the current customer
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub txtTelephone_TextChanged(sender As Object, e As EventArgs) Handles txtTelephone.TextChanged
        currentRecord.phone = txtTelephone.Text
    End Sub

    ''' <summary>
    ''' Handles setting discountplan to the current customer
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ddlDiscountPlan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlDiscountPlan.SelectedIndexChanged
        If Not ddlDiscountPlan.SelectedItem Is Nothing Then
            currentRecord.DiscountPlan = ddlDiscountPlan.SelectedItem
        End If
    End Sub

    ''' <summary>
    ''' Handles setting customer type to the current customer
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ddlCustomerType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlCustomerType.SelectedIndexChanged
        If Not ddlCustomerType.SelectedItem Is Nothing Then
            currentRecord.CustomerType = ddlCustomerType.SelectedItem
        End If
    End Sub

    ''' <summary>
    ''' Handles setting a internal note on the current customer
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub txtNote_TextChanged(sender As Object, e As EventArgs) Handles txtNote.TextChanged
        currentRecord.note = txtNote.Text
    End Sub

    ''' <summary>
    ''' Displays a search box for the orders for this customer
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnShowOrders_Click(sender As Object, e As EventArgs) Handles btnShowOrders.Click
        SearchHelper.SearchOrders(Function(o) o.Customer.id = currentRecord.id)
    End Sub

    ''' <summary>
    ''' Displays as search box for the subscriptions for this customer
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnShowSubscriptions_Click(sender As Object, e As EventArgs) Handles btnShowSubscriptions.Click
        SearchHelper.SearchOrders(Function(o) o.Customer.id = currentRecord.id And o.isSubscriptionOrder = True)
    End Sub

End Class
