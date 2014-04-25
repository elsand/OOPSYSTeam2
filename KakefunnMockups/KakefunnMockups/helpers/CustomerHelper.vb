''' <summary>
''' Simple helper for dealing with adding and editing customers
''' </summary>
''' <remarks></remarks>
Public Class CustomerHelper
    ''' <summary>
    ''' Prepares the customer form for a new entry
    ''' </summary>
    ''' <remarks></remarks>
    Public Shared Sub NewCustomer()
        SessionHelper.Instance.ShowForm(frmSaleCustomer)
        frmSaleCustomer.NewCustomer()
    End Sub

    ''' <summary>
    ''' Prepares the customer form for a new entry, and sets a custom returnToForm-action when the operation is created/cancelled
    ''' </summary>
    ''' <param name="returnToForm"></param>
    ''' <remarks></remarks>
    Public Shared Sub NewCustomerAndReturnTo(returnToForm As Form)
        NewCustomer()
        frmSaleCustomer.returnToForm = returnToForm
    End Sub

    ''' <summary>
    ''' Prepares the customer form for a new entry, and sets a custom returnToForm-action when the operation is created/cancelled
    ''' with an additional callback which is then called when the returning form is being shown
    ''' </summary>
    ''' <param name="returnToForm"></param>
    ''' <param name="callback"></param>
    ''' <remarks></remarks>
    Public Shared Sub NewCustomerAndReturnTo(returnToForm As Form, callback As System.Func(Of Form, Form, Boolean))
        NewCustomerAndReturnTo(returnToForm)
        SessionHelper.Instance.RegisterCallback(callback)
    End Sub

    ''' <summary>
    ''' Prepares the customer with the supplied id to be edited
    ''' </summary>
    ''' <param name="id"></param>
    ''' <remarks></remarks>
    Public Shared Sub EditCustomer(id As Integer)
        EditCustomer(DBM.Instance.Customers.Find(id))
    End Sub

    ''' <summary>
    ''' Prepares the supplied customer for editing
    ''' </summary>
    ''' <param name="customer"></param>
    ''' <remarks></remarks>
    Public Shared Sub EditCustomer(customer As Customer)
        SessionHelper.Instance.ShowForm(frmSaleCustomer)
        frmSaleCustomer.LoadCustomer(customer)
    End Sub
End Class
