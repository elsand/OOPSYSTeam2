Imports System.Data.Objects
Imports System.Data.Objects.DataClasses
Imports System.Data.SqlClient
Imports System.Data.EntityClient
Imports MySql.Data.MySqlClient

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

#End Region

    '    Public Function FindByName(table As String, name As String)
    '        Return Database.SqlQuery(Of String)("SELET * FROM " & table & " WHERE name = '" & name & "'").ToList()
    '    End Function


    Public Function GetDataSetFromQuery(query As String) As DataSet
        Dim ds As DataSet = New DataSet()
        Dim sqlCmd As MySqlCommand = New MySqlCommand(query, Instance.Database.Connection)
        Dim da As MySqlDataAdapter = New MySqlDataAdapter(sqlCmd)
        da.Fill(ds)
        Return ds
    End Function

    Public Function GetDataTableFromQuery(query As String) As DataTable
        Dim ds As DataSet = GetDataSetFromQuery(query)
        Return ds.Tables.Item(0)
    End Function


End Class
