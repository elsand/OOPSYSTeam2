Imports System.IO

''' <summary>
''' Helper for making and showing simple reports in a local browser
''' </summary>
''' <remarks></remarks>
Public Class HtmlReport
    Property Title As String
    Property Css As String = _
        "body{border:1px solid #aaa; width:200mm; height:280mm; margin: 10mm auto; padding: 10mm}" & _
        "table{width: 100%; border-collapse:collapse} " & _
        "tr{} " & _
        "th{border-bottom: 1px solid #ccc} " & _
        "td{padding: 4mm 10mm 2mm 10mm}" & _
        "h1{ text-align: center }" & _
        ".numeric{text-align:right}" & _
        "footer{text-align:center; font-size: 85%; margin-top: 20mm}"

    Property Footer =
        "<footer>Copyright &copy; Kakefunn.no. Generert " & Date.Now & "</footer>" & _
        "</body></html>"

    Private Buf As String = ""
    Private TableOpened As Boolean = False
    Private FooterAdded As Boolean = False

    ''' <summary>
    ''' Inits the buffer with the header content and supplied title/css/etc
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Init()
        Buf =
            "<html >" & _
            "<head>" & _
            "<title>" & Title & "</title>" & _
            "<meta charset='UTF-8'>" & _
            "<style type='text/css'>" & Css & "</style>" & _
            "</head>" & _
            "<body onload='window.print()'><h1>" & Title & "</h1>"
    End Sub

    ''' <summary>
    ''' Starts a table with the supplied list of column headers
    ''' </summary>
    ''' <param name="ColumnHeaders"></param>
    ''' <remarks></remarks>
    Public Sub StartTable(ColumnHeaders As String())
        Add("<table><tr>")
        For Each ch As String In ColumnHeaders
            Add("<th>" & ch & "</th>")
        Next
        Add("</tr>")
        TableOpened = True
    End Sub

    ''' <summary>
    ''' Adds a row to a table
    ''' </summary>
    ''' <param name="Columns"></param>
    ''' <remarks></remarks>
    Public Sub AddRow(Columns As String())
        Add("<tr>")
        For Each c As String In Columns
            If IsNumeric(c) Then
                Add("<td class='numeric'>")
            Else
                Add("<td>")
            End If
            Add(c & "</td>")
        Next
        Add("</tr>")
    End Sub

    ''' <summary>
    ''' Closes the opened table. Is done automatically.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub EndTable()
        Add("</table>")
        TableOpened = False
    End Sub


    ''' <summary>
    ''' Returns the fully rendered HTML
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Render() As String
        If TableOpened Then
            EndTable()
        End If
        If Not FooterAdded Then
            Add(Footer)
        End If
        Return Buf
    End Function

    ''' <summary>
    ''' Writes the fully rendered HTML to a temp file and displays it in the default browser
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub OpenInBrowser()
        Try
            Dim path As String = GetTempFile()
            File.WriteAllText(path, Render())
            Process.Start(LocalSystemHelper.getDefaultBrowser(), path)
        Catch ex As Exception
            MessageBox.Show("Kunne ikke vise rapport. " & ex.Message, "Feil med visning av rapport", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
    End Sub

    ''' <summary>
    ''' Creates and returns the path to temporary HTML file
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function GetTempFile() As String
        Return Path.GetTempFileName() & ".html"
    End Function

    ''' <summary>
    ''' Convenience function for adding stuff to the HTML buffer
    ''' </summary>
    ''' <param name="s"></param>
    ''' <remarks></remarks>
    Private Sub Add(s As String)
        Buf = Buf & s
    End Sub
End Class
