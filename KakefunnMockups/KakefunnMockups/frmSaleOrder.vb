Public Class frmSaleOrder

    Public Sub LoadOrder(order As Order)
        MsgBox("load order " & order.id)
    End Sub

    Public Sub NewOrder()
        MsgBox("new order")
    End Sub

    Private Sub SetDeliveryToCustomer(customer As Customer)
        txtDeliveryName.Text = customer.fullName
        txtAddress.Text = customer.Address.address1
        txtZip.Text = customer.Address.Zip.zip1
        lblCity.Text = customer.Address.Zip.city
        txtTelephone.Text = customer.phone
        txtEmail.Text = customer.email
    End Sub

    Private Sub frmSaleOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DBM.Instance.Customers.Load()
        CustomerBindingSource.DataSource = DBM.Instance.Customers.Local.ToBindingList()
        AddressHelper.SetupAutoCityFill(txtZip, lblCity)
        FormHelper.SetupDirtyTracking(Me)

    End Sub

    Private Sub btnNewCustomer_Click(sender As Object, e As EventArgs) Handles btnNewCustomer.Click
        CustomerManager.NewCustomerAndReturnTo(Me)
    End Sub


    Private Sub cbCustomerName_Leave(sender As Object, e As EventArgs) Handles cbCustomerName.Leave
        If cbCustomerName.SelectedValue Is Nothing Then
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



End Class
