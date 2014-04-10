Public Class PhoneHelper
    Public Shared Function GetPhone(pn As Integer) As phone
        Dim p As phone = DBM.Instance.Phones.Find(pn)
        If p Is Nothing Then
            p = New phone() With {.countryprefix = 47, .phonenumber = pn}
        End If
        Return p
    End Function

    Public Shared Function GetPhone(p As String) As phone
        Dim pn As Integer
        Integer.TryParse(p, pn)
        Return GetPhone(pn)
    End Function
End Class
