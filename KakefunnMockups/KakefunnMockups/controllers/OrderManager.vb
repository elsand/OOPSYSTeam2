Public Class OrderManager

    ''' <summary>
    ''' Finds and returns an order based on orderId
    ''' </summary>
    ''' <param name="orderId">Integer</param>
    ''' <returns>order</returns>
    ''' <remarks></remarks>
    Public Shared Function findOrder(ByVal orderId As Integer) As order
        Dim o As New order

        Return o
    End Function

    ''' <summary>
    ''' Creates an order and saves it to the database
    ''' </summary>
    ''' <returns>the order</returns>
    ''' <remarks></remarks>
    Public Shared Function createOrder(ByVal ingedients As Ingredient(), ByVal deliveryMethod As deliveryMethod, ByVal customer As Customer)
        Dim o As New order
        o.customer = customer
        o.deliveryMethod = deliveryMethod


        Return o

    End Function


End Class
