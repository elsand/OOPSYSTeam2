Imports System.Data.Objects
Imports System.Data.Objects.DataClasses
Imports System.Data.SqlClient
Imports System.Data.EntityClient
Imports MySql.Data.MySqlClient

''' <summary>
''' Wrapper around EFs database handler. Adds some convenience methods for accessing data
''' via the standard datatable approach as well.
''' Implemented as a singleton to avoid overhead of additional connections to the remote
''' mysql-server. This comes at the cost of additional memory usage.
''' </summary>
''' <remarks></remarks>
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

    ''' <summary>
    ''' Runs a SQL query (one column) are returns it an array of strings
    ''' </summary>
    ''' <param name="sql"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function SqlToArray(sql As String) As Array
        Return Database.SqlQuery(Of String)(sql).ToArray()
    End Function

    ''' <summary>
    ''' Gets the sorted "name" column of the supplied table 
    ''' </summary>
    ''' <param name="table"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetNameColumn(table As String) As Array
        Return SqlToArray("SELECT name FROM " & table & " ORDER BY name")
    End Function

    ''' <summary>
    ''' Get the sorted "name" column of the supplied table with a where clause
    ''' </summary>
    ''' <param name="table"></param>
    ''' <param name="where"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetNameColumn(table As String, where As String) As Array
        Return SqlToArray("SELECT name FROM " & table & " WHERE " & where & " ORDER BY name")
    End Function

    ''' <summary>
    ''' Returns the result of the given query as a dataset
    ''' </summary>
    ''' <param name="query"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetDataSetFromQuery(query As String) As DataSet
        Dim ds As DataSet = New DataSet()
        Dim sqlCmd As MySqlCommand = New MySqlCommand(query, Instance.Database.Connection)
        Dim da As MySqlDataAdapter = New MySqlDataAdapter(sqlCmd)
        da.Fill(ds)
        Return ds
    End Function

    ''' <summary>
    ''' Returns the first datatable for the given query
    ''' </summary>
    ''' <param name="query"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetDataTableFromQuery(query As String) As DataTable
        Dim ds As DataSet = GetDataSetFromQuery(query)
        Return ds.Tables.Item(0)
    End Function


End Class
