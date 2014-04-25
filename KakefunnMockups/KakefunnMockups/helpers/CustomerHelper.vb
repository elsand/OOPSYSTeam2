Public Class CustomerHelper
    ''' <summary>
    ''' finds and returns a customer 
    ''' </summary>
    ''' <param name="customerId">Integer</param>
    ''' <returns>customer</returns>
    ''' <remarks></remarks>
    Public Shared Function findCustomer(ByVal customerId As Integer) As Customer
        Return DBM.Instance.Customers.Find(customerId)
    End Function

    Public Shared Function findCustomer(ByVal customerName As String) As Customer
        Dim name As NameHelper = New NameHelper(customerName)
        Return DBM.Instance.Customers.Where(Function(c) c.firstName = name.firstName And c.lastName = name.lastName).FirstOrDefault()
    End Function

    Public Shared Sub NewCustomer()
        SessionHelper.Instance.ShowForm(frmSaleCustomer)
        frmSaleCustomer.NewCustomer()
    End Sub

    Public Shared Sub NewCustomerAndReturnTo(returnToForm As Form)
        NewCustomer()
        frmSaleCustomer.returnToForm = returnToForm
    End Sub

    Public Shared Sub NewCustomerAndReturnTo(returnToForm As Form, callback As System.Func(Of Form, Form, Boolean))
        NewCustomerAndReturnTo(returnToForm)
        SessionHelper.Instance.RegisterCallback(callback)
    End Sub

    Public Shared Sub EditCustomer(id As Integer)
        EditCustomer(DBM.Instance.Customers.Find(id))
    End Sub

    Public Shared Sub EditCustomer(customer As Customer)
        SessionHelper.Instance.ShowForm(frmSaleCustomer)
        frmSaleCustomer.LoadCustomer(customer)
    End Sub
End Class
