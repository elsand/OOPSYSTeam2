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

Partial Public Class batch
    Public Property id As Integer
    Public Property ordered As Date
    Public Property registered As Nullable(Of Date)
    Public Property expected As Date
    Public Property expires As Nullable(Of Date)
    Public Property unitCount As Integer
    Public Property unitPurchasingPrice As Nullable(Of Decimal)
    Public Property ingredientId As Integer
    Public Property locationRow As Nullable(Of Integer)
    Public Property locationShelf As Nullable(Of Integer)
    Public Property deleted As Nullable(Of Date)

    Public Overridable Property ingredient As ingredient

End Class
