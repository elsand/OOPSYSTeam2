Public Class AddressHelper
    Public Shared Function GetAddress(zip As Integer, address As String) As address
        Return _GetAddress(zip, address, Nothing, Nothing, True)
    End Function

    Public Shared Function GetAddress(zip As Integer, address As String, name As String) As address
        Return _GetAddress(zip, address, name, Nothing, True)
    End Function

    Public Shared Function GetAddress(zip As Integer, address As String, name As String, careof As String) As address
        Return _GetAddress(zip, address, name, careof, True)
    End Function

    Public Shared Function GetAddress(zip As Integer, address As String, name As String, careof As String, isPrivate As Boolean) As address
        Return _GetAddress(zip, address, name, careof, isPrivate)
    End Function

    Private Shared Function _GetAddress(zip As Integer, address As String, name As String, careof As String, isPrivate As Boolean) As address

        Dim a As address = DBM.Instance.addresses.Where(Function(x) x.address1 = address And x.zip1.zip1 = zip And x.careOf = careof And x.isPrivate = isPrivate).FirstOrDefault()
        If a Is Nothing Then
            a = New address With {.name = "", .address1 = address, .zip1 = DBM.Instance.zips.Find(zip), .careOf = careof, .isPrivate = isPrivate}
            DBM.Instance.addresses.Add(a)
        End If

        Return a
    End Function
End Class
