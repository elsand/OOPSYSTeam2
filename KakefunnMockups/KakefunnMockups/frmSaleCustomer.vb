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

        isLoadingCustomer = False

    End Sub

    Public Sub NewCustomer()
        MsgBox("new customer")
    End Sub

    Private Sub frmSaleCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
