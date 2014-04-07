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
End Class
