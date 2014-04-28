Imports System.Globalization

''' <summary>
''' Helps with formatting
''' </summary>
''' <remarks></remarks>
Public Class FormatHelper
    ''' <summary>
    ''' Returns formatting of currencies in nb-NO locale
    ''' </summary>
    ''' <param name="amount"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function Currency(amount As Decimal) As String
        Return amount.ToString("c", New CultureInfo("nb-NO"))
    End Function
End Class
