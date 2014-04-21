Public Class frmSaleCustomer

    ' Flag used to trigger logic specific to either saved or new customers
    Private isNewRecord = False
    ' Holds the customer currently being edited, either new or existing
    Private currentRecord As Customer = New Customer()
    ' Flag to tell event handlers if we're currently loading a record
    Private isLoadingCustomer = False
    ' Holds which form we are to return to. Default to frmSaleMain
    Public returnToForm As Form

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
        txtZip.Text = currentRecord.Address.Zip.zip1
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

        Dim orders As List(Of Order) = OrderManager.FindOrdersForCustomer(currentRecord)
        lblNumberOfOrdersValue.Text = orders.Count

        Dim totalValue As Decimal = 0
        For Each o As Order In orders
            totalValue = totalValue + OrderManager.CalculateTotals(o).totalToPay
        Next
        lblTotalOrderValueValue.Text = FormatHelper.Currency(totalValue)

        isLoadingCustomer = False
    End Sub

    Public Sub NewCustomer()
        isDirty = False
        isNewRecord = True
        currentRecord = New Customer()
        grpCustomerStatus.Hide()
        FormHelper.ResetControls(Me)
    End Sub

    Private Sub SaveCustomer()
        Try
            If isNewRecord Then
                currentRecord.created = Date.Now()
                DBM.Instance.Customers.Add(currentRecord)
            End If
            currentRecord.modified = Date.Now()
            DBM.Instance.SaveChanges()
        Catch ex As Exception
            MessageBox.Show("Det oppstod en feil under lagring av kunden. " & ex.Message, "Feil", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

        MessageBox.Show("Kunden ble lagret", "Lagret", MessageBoxButtons.OK, MessageBoxIcon.Information)
        SessionManager.Instance.ShowForm(returnToForm)

    End Sub

    '''''''''''''''''''''''''''''''''''' BELOW THIS POINT ARE EVENT HANDLERS ''''''''''''''''''''''''''''''''''''''''''''''''''

    Private Sub frmSaleCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        returnToForm = frmSaleMain ' By default we return to frmSaleMain. This may be set to other forms (if eg. we're shown from a statistics report)

        AddressHelper.SetupAutoCityFill(txtZip, lblCity)
        FormHelper.SetupDirtyTracking(Me)

        ddlCustomerType.DisplayMember = "name"
        ddlCustomerType.DataSource = DBM.Instance.CustomerTypes.ToList()

        ddlDiscountPlan.DisplayMember = "name"
        ddlDiscountPlan.DataSource = DBM.Instance.DiscountPlans.ToList()

        ' Start with a new order
        NewCustomer()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If Not FormHelper.ContinueIfDirty(Me) Then
            Exit Sub
        End If
        SessionManager.Instance.ShowForm(returnToForm)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        SaveCustomer()
    End Sub


    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        Dim name As NameHelper = New NameHelper(txtName.Text)
        currentRecord.firstName = name.firstName
        currentRecord.lastName = name.lastName
    End Sub

    Private Sub Address_TextChanged(sender As Object, e As EventArgs) Handles txtAddress.TextChanged, txtZip.TextChanged
        If Not isLoadingCustomer Then
            currentRecord.Address = AddressHelper.GetAddress(txtZip.IntValue, txtAddress.Text)
        End If
    End Sub


    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged
        currentRecord.email = txtEmail.Text
    End Sub

    Private Sub txtTelephone_TextChanged(sender As Object, e As EventArgs) Handles txtTelephone.TextChanged
        currentRecord.phone = txtTelephone.Text
    End Sub


    Private Sub ddlDiscountPlan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlDiscountPlan.SelectedIndexChanged
        If Not ddlDiscountPlan.SelectedItem Is Nothing Then
            currentRecord.DiscountPlan = ddlDiscountPlan.SelectedItem
        End If
    End Sub

    Private Sub ddlCustomerType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlCustomerType.SelectedIndexChanged
        If Not ddlCustomerType.SelectedItem Is Nothing Then
            currentRecord.CustomerType = ddlCustomerType.SelectedItem
        End If
    End Sub

    Private Sub txtNote_TextChanged(sender As Object, e As EventArgs) Handles txtNote.TextChanged
        currentRecord.note = txtNote.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        NewCustomer()
    End Sub
End Class
