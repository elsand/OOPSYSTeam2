Public Class NameHelper
    Property firstName As String
    Property lastName As String
    Property fullName As String
        Get
            Return firstName & " " & lastName
        End Get
        Set(name As String)
            Dim parts As String() = name.Split(" ")
            Dim lastName As String = parts.Last()
            Dim firstName As String = String.Join(" ", parts.Reverse().Skip(1).Reverse())
            Me.firstName = firstName
            Me.lastName = lastName
        End Set
    End Property

    Public Sub New(full As String)
        fullName = full
    End Sub

    Public Sub New(first As String, last As String)
        firstName = first
        lastName = last
    End Sub
End Class
