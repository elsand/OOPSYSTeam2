Public Class OrderManager

    ''' <summary>
    ''' Finds and returns an order based on orderId
    ''' </summary>
    ''' <param name="orderId">Integer</param>
    ''' <returns>order</returns>
    ''' <remarks></remarks>
    Public Shared Function FindOrder(ByVal orderId As Integer) As order
        Return DBM.Instance.Orders.Find(orderId)
    End Function

    ''' <summary>
    ''' Creates an order and saves it to the database
    ''' </summary>
    ''' <returns>the order</returns>
    ''' <remarks></remarks>
    Public Shared Function CreateOrder(ByVal ingedients As Ingredient(), ByVal deliveryMethod As deliveryMethod, ByVal customer As Customer)
        Dim o As New order
        o.customer = customer
        o.deliveryMethod = deliveryMethod
        Return o
    End Function

    Public Shared Sub NewOrder()
        SessionManager.Instance.ShowForm(frmSaleOrder)
        frmSaleOrder.NewOrder()
    End Sub

    Public Shared Sub EditOrder(id As Integer)
        EditOrder(DBM.Instance.Orders.Find(id))
    End Sub

    Public Shared Sub EditOrder(order As Order)
        SessionManager.Instance.ShowForm(frmSaleOrder)
        frmSaleOrder.LoadOrder(order)
    End Sub

    Public Shared Function GetOrderPrice(order As Order) As Decimal
        Dim total As Decimal
        For Each ol As OrderLine In order.OrderLines
            total = total + ol.totalPrice
        Next
        Return total + order.shippingPrice
    End Function


End Class
