Imports System.Globalization

Public Class FormatHelper
    Public Shared Function Currency(amount As Decimal) As String
        Return amount.ToString("c", New CultureInfo("nb-NO"))
    End Function
End Class
