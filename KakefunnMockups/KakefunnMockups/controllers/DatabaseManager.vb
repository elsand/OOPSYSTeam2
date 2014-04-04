Imports System.Data.Objects
Imports System.Data.Objects.DataClasses

Public Class DBM
    Inherits Db

#Region "SingletonImplementation"
    ''' <summary>
    ''' Holds the instance of DatabaseManager. Uses Lazy() to defer initialization until requested.
    ''' </summary>
    ''' <remarks></remarks>
    Private Shared ReadOnly _instance As New Lazy(Of DBM)(Function() New DBM, System.Threading.LazyThreadSafetyMode.ExecutionAndPublication)

    ''' <summary>
    ''' Implement singleton pattern. Make constructor private and no-op
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub New()
    End Sub

    ''' <summary>
    ''' Returns the instance of SessionManager
    ''' </summary>
    ''' <value></value>
    ''' <returns>SessionManager</returns>
    ''' <remarks></remarks>
    Public Shared ReadOnly Property Instance() As DBM
        Get
            Return _instance.Value
        End Get
    End Property


    Public Function FindByName(table As String, name As String)
        Return Database.SqlQuery(Of String)("SELET * FROM " & table & " WHERE name = '" & name & "'").ToList()
    End Function


#End Region

End Class
