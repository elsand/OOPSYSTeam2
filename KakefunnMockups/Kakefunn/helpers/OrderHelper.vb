''' <summary>
''' Helper class for orders
''' </summary>
''' <remarks></remarks>
Public Class OrderHelper

    ''' <summary>
    ''' Initiates editing of the supplied order
    ''' </summary>
    ''' <param name="order"></param>
    ''' <remarks></remarks>
    Public Shared Sub EditOrder(order As Order)
        SessionHelper.Instance.ShowForm(frmSaleOrder)
        frmSaleOrder.LoadOrder(order)
    End Sub

    ''' <summary>
    ''' Initiates editing of the supplied order and sets a callback which is called when the order form is submitted or canceled
    ''' </summary>
    ''' <param name="order"></param>
    ''' <remarks></remarks>
    Public Shared Sub EditOrder(order As Order, returnToForm As Form)
        EditOrder(order)
        frmSaleOrder.returnToForm = returnToForm
    End Sub

    ''' <summary>
    ''' Returns the full price of one order
    ''' </summary>
    ''' <param name="order"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetOrderPrice(order As Order) As Decimal
        Return CalculateTotals(order).totalToPay
    End Function

    ''' <summary>
    ''' Calculates the order price, vat, discounts, shipping for the supplied order
    ''' </summary>
    ''' <param name="order"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
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

        ' If we have a absolute discount, we distribute unevenly it over the orderlines
        If order.discountAbsolute > 0 Then
            remainingDiscount = order.discountAbsolute
            totals.totalDiscount = remainingDiscount
        End If

        ' Walk through orderlines and calculate vat and discounts
        For Each ol As OrderLine In order.OrderLines
            orderLinePrice = ol.totalPrice
            ' If we have a percentage discount, we calculate it here
            If order.discountPercentage > 0 Then
                orderLineDiscount = (orderLinePrice / 100 * order.discountPercentage)
                orderLinePrice = orderLinePrice - orderLineDiscount
                totals.totalDiscount = totals.totalDiscount + orderLineDiscount
            ElseIf order.discountAbsolute > 0 Then
                ' If there is a absolute discount, we can just substract it from the orderline price
                If remainingDiscount > orderLinePrice Then
                    ' The entire orderline has been "eaten" by the discount, try to "spend" the rest of 
                    ' the discount on the next orderline
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

    ''' <summary>
    ''' Utility function returning all orders for the given customer
    ''' </summary>
    ''' <param name="customer"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Shared Function FindOrdersForCustomer(customer As Customer) As List(Of Order)
        Return DBM.Instance.Orders.Where(Function(o) o.Customer.id = customer.id).ToList()
    End Function

End Class
