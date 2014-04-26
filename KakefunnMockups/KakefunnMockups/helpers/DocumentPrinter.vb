Imports System.Drawing
Imports System.Drawing.Printing
Imports System.IO
''' <summary>
''' Prints a file... but it can ofcourse not render a html file so if you want to print looong strings of html be my guest.. 
''' </summary>
''' <remarks></remarks>
Public Class DocumentPrinter


    Private printFont As Font
    Private streamToPrint As StreamReader
    Public Sub printDocument(ByVal file As String)
        Try
            streamToPrint = New StreamReader(file)
            Try
                printFont = New Font("Arial", 10)
                Dim pd As New PrintDocument()
                AddHandler pd.PrintPage, AddressOf Me.pd_PrintPage
                pd.Print()
            Finally
                streamToPrint.Close()
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub pd_PrintPage(ByVal sender As Object, ByVal ev As PrintPageEventArgs)
        Dim linesPerPage As Single = 0
        Dim yPos As Single = 0
        Dim count As Integer = 0
        Dim leftMargin As Single = ev.MarginBounds.Left
        Dim topMargin As Single = ev.MarginBounds.Top
        Dim line As String = Nothing

        ' Calculate the number of lines per page.
        linesPerPage = ev.MarginBounds.Height / printFont.GetHeight(ev.Graphics)

        ' Print each line of the file. 
        While count < linesPerPage
            line = streamToPrint.ReadLine()
            If line Is Nothing Then
                Exit While
            End If
            yPos = topMargin + count * printFont.GetHeight(ev.Graphics)
            ev.Graphics.DrawString(line, printFont, Brushes.Black, leftMargin, yPos, New StringFormat())
            count += 1
        End While

        ' If more lines exist, print another page. 
        If (line IsNot Nothing) Then
            ev.HasMorePages = True
        Else
            ev.HasMorePages = False
        End If
    End Sub


End Class
