Public Class CustomerManager


    Public Shared Function GetFullName(name As String) As FullName
        Dim parts As String() = name.Split(" ")
        Dim lastName As String = parts.Last()
        Dim firstName As String = String.Join(" ", parts.Reverse().Skip(1).Reverse())
        Return New FullName() With {.firstName = firstName, .lastName = lastName}
    End Function

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
        Dim fn As FullName = GetFullName(customerName)
        Return DBM.Instance.Customers.Where(Function(c) c.firstName = fn.firstName And c.lastName = fn.lastName).FirstOrDefault()
    End Function

    Public Shared Sub NewCustomer()
        SessionManager.Instance.ShowForm(frmSaleCustomer)
        frmSaleCustomer.NewCustomer()
    End Sub

    Public Shared Sub NewCustomerAndReturnTo(returnToForm As Form)
        NewCustomer()
        frmSaleCustomer.returnToFormAfterSave = returnToForm
    End Sub

    Public Shared Sub EditCustomer(id As Integer)
        EditCustomer(DBM.Instance.Customers.Find(id))
    End Sub

    Public Shared Sub EditCustomer(customer As Customer)
        SessionManager.Instance.ShowForm(frmSaleCustomer)
        frmSaleCustomer.LoadCustomer(Customer)
    End Sub

End Class
