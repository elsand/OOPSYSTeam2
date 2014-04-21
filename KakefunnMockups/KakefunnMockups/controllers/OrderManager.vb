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

    ' TODO Remove this wrapper
    Public Shared Function GetOrderPrice(order As Order) As Decimal
        Return CalculateTotals(order).totalToPay
    End Function

    Public Shared Function CalculateTotals(order As Order) As OrderTotals

        Dim remainingDiscount As Decimal = 0
        Dim orderLineDiscount As Decimal = 0
        Dim orderLinePrice As Decimal = 0
        Dim totals As OrderTotals = New OrderTotals()

        If order.shippingPrice Then
            ' Hardcode shipping VAT to 25% ...
            totals.totalVat = order.shippingPrice - order.shippingPrice / 1.25
            totals.shipping = order.shippingPrice - totals.totalVat
        End If

        If order.discountAbsolute > 0 Then
            remainingDiscount = order.discountAbsolute
            totals.totalDiscount = remainingDiscount
        End If

        For Each ol As OrderLine In order.OrderLines
            orderLinePrice = ol.totalPrice
            If order.discountPercentage > 0 Then
                orderLineDiscount = (orderLinePrice / 100 * order.discountPercentage)
                orderLinePrice = orderLinePrice - orderLineDiscount
                totals.totalDiscount = totals.totalDiscount + orderLineDiscount
            ElseIf order.discountAbsolute > 0 Then
                If remainingDiscount > orderLinePrice Then
                    remainingDiscount = remainingDiscount - orderLinePrice
                    Continue For
                End If
                orderLinePrice = orderLinePrice - remainingDiscount
            End If
            totals.totalPriceExVat = totals.totalPriceExVat + orderLinePrice
            totals.totalVat = totals.totalVat + (orderLinePrice / 100) * ol.Ingredient.vat
        Next

        Return totals
    End Function

    Shared Function FindOrdersForCustomer(customer As Customer) As List(Of Order)
        Return DBM.Instance.Orders.Where(Function(o) o.Customer.id = customer.id).ToList()
    End Function

End Class
