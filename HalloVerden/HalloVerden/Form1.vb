Imports MySql.Data.MySqlClient

Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Hallo, verden!")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("Hilsen fra Tromsø!")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dbconn As New MySqlConnection( _
            "Server=192.168.0.2;" _
            & "Database=mestergronn_no;" _
            & "Uid=root_remote" _
        )

        Try
            dbconn.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class