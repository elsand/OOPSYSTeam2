''' <summary>
''' Helper class for dealing with phone entries
''' </summary>
''' <remarks></remarks>
Public Class PhoneHelper
    ''' <summary>
    ''' Returns a entity for the given phone number
    ''' </summary>
    ''' <param name="pn"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetPhone(pn As Integer) As Phone
        Dim p As Phone = DBM.Instance.Phones.Find(pn)
        If p Is Nothing Then
            p = New Phone() With {.countryprefix = 47, .phonenumber = pn}
        End If
        Return p
    End Function
    ''' <summary>
    ''' Returns a entity for the given phone number as string
    ''' </summary>
    ''' <param name="p"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetPhone(p As String) As Phone
        Dim pn As Integer
        Integer.TryParse(p, pn)
        Return GetPhone(pn)
    End Function
End Class
