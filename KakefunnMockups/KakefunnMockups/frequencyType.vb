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

Partial Public Class frequencyType
    Public Property id As Integer
    Public Property name As String
    Public Property intervalDays As Nullable(Of Integer)
    Public Property intervalMonths As Nullable(Of Integer)

    Public Overridable Property subscriptions As ICollection(Of subscription) = New HashSet(Of subscription)

End Class