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

Partial Public Class Subscription
    Public Property id As Integer
    Public Property isActive As Nullable(Of Boolean)
    Public Property frequency As Nullable(Of Integer)
    Public Property startDate As Date
    Public Property stopDate As Nullable(Of Date)
    Public Property created As Nullable(Of Date)
    Public Property modified As Nullable(Of Date)

    Public Overridable Property FrequencyType As FrequencyType
    Public Overridable Property Order As Order

End Class
