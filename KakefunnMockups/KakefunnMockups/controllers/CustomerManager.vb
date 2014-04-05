Public Class CustomerManager
    ''' <summary>
    ''' finds and returns a customer 
    ''' </summary>
    ''' <param name="customerId">Integer</param>
    ''' <returns>customer</returns>
    ''' <remarks></remarks>


    Public Shared Function findCustomer(ByVal customerId As Integer) As customer
        Return DBM.Instance.customers.Find(customerId)
    End Function

    Public Shared Function findCustomer(ByVal customerName As String) As customer
        Return DBM.Instance.customers.Where(Function(c) c.name = customerName).FirstOrDefault()
    End Function
End Class
