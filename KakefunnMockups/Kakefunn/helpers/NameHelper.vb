''' <summary>
''' Utility class for dealing with names. Does not deal with middle names.
''' </summary>
''' <remarks></remarks>
Public Class NameHelper
    Property firstName As String
    Property lastName As String
    ''' <summary>
    ''' Getter/setter that deals with splitting into first and last name
    ''' There is always just one last name.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
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

    ''' <summary>
    ''' Constructor, requires the full name of the person
    ''' </summary>
    ''' <param name="full"></param>
    ''' <remarks></remarks>
    Public Sub New(full As String)
        fullName = full
    End Sub

    ''' <summary>
    ''' Alternative constructor, where one passes first and last name
    ''' </summary>
    ''' <param name="first"></param>
    ''' <param name="last"></param>
    ''' <remarks></remarks>
    Public Sub New(first As String, last As String)
        firstName = first
        lastName = last
    End Sub

    ''' <summary>
    ''' Returns the full name given first and last name
    ''' </summary>
    ''' <param name="firstName"></param>
    ''' <param name="lastName"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function getFullName(ByVal firstName As String, ByVal lastName As String) As String
        Return firstName & " " & lastName

    End Function

    ''' <summary>
    ''' Returns the full name of a given employee
    ''' </summary>
    ''' <param name="e"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function getFullName(ByVal e As Employee) As String
        Return getFullName(e.firstName, e.lastName)
    End Function

    ''' <summary>
    ''' Returns the fullname of a given customer
    ''' </summary>
    ''' <param name="c"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function getFullName(ByVal c As Customer) As String
        Return getFullName(c.firstName, c.lastName)
    End Function

End Class
