Imports MySql.Data.MySqlClient



Public Class Db
    Private username As String
    Private password As String
    Private db As String
    Private url As String





    Public Sub New()
        Me.username = "root"
        Me.password = "w1nd5urf"
        Me.url = "localhost"
        Me.db = "L3"
    End Sub

    Public Function connect() As MySqlConnection
        Dim con As New MySqlConnection(Me.buildString())
        Return con
    End Function

    Private Function buildString() As String
        Dim Str = "Server=" & Me.url & ";Database=" & Me.db & ";Uid=" & Me.username & ";Pwd=" & Me.password & ";"

        Return Str
    End Function


End Class
