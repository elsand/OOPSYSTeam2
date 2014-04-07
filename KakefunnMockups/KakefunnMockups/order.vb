'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class Order
    Public Property id As Integer
    Public Property customerId As Integer
    Public Property deliveryAddressId As Integer
    Public Property deliveryPhone As String
    Public Property deliveryEmail As String
    Public Property deliveryMethodId As Integer
    Public Property employeeId As Integer
    Public Property subscriptionId As Nullable(Of Integer)
    Public Property shippingPrice As String
    Public Property discountPercentage As Nullable(Of Decimal)
    Public Property discountAbsolute As Nullable(Of Decimal)
    Public Property note As String
    Public Property amountPayed As Decimal
    Public Property sent As Nullable(Of Date)
    Public Property settled As Nullable(Of Date)
    Public Property exported As Nullable(Of Date)
    Public Property created As Date
    Public Property modified As Date
    Public Property isSubscriptionOrder As Boolean

    Public Overridable Property Address As Address
    Public Overridable Property Customer As Customer
    Public Overridable Property DeliveryMethod As DeliveryMethod
    Public Overridable Property Employee As Employee
    Public Overridable Property OrderLines As ObservableListSource(Of OrderLine) = New ObservableListSource(Of OrderLine)
    Public Overridable Property Subscriptions As ObservableListSource(Of Subscription) = New ObservableListSource(Of Subscription)

End Class
