Public Class CustomerManager
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
        Return DBM.Instance.Customers.Where(Function(c) c.name = customerName).FirstOrDefault()
    End Function

    Public Shared Sub NewCustomer()
        SessionManager.Instance.ShowForm(frmSaleCustomer)
        frmSaleCustomer.NewCustomer()
    End Sub

    Public Shared Sub EditCustomer(id As Integer)
        EditCustomer(DBM.Instance.Customers.Find(id))
    End Sub

    Public Shared Sub EditCustomer(customer As Customer)
        SessionManager.Instance.ShowForm(frmSaleCustomer)
        frmSaleCustomer.LoadCustomer(Customer)
    End Sub

End Class
