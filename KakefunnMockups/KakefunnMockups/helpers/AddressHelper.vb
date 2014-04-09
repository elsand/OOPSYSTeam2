Public Class AddressHelper
    Public Shared Function GetAddress(zip As Integer, address As String) As Address
        Return _GetAddress(zip, address, Nothing, Nothing, True)
    End Function

    Public Shared Function GetAddress(zip As Integer, address As String, name As String) As Address
        Return _GetAddress(zip, address, name, Nothing, True)
    End Function

    Public Shared Function GetAddress(zip As Integer, address As String, name As String, careof As String) As Address
        Return _GetAddress(zip, address, name, careof, True)
    End Function

    Public Shared Function GetAddress(zip As Integer, address As String, name As String, careof As String, isPrivate As Boolean) As Address
        Return _GetAddress(zip, address, name, careof, isPrivate)
    End Function

    Private Shared Function _GetAddress(zip As Integer, address As String, name As String, careof As String, isPrivate As Boolean) As Address

        Dim a As Address = DBM.Instance.Addresses.Where(Function(x) x.address1 = address And x.Zip.zip1 = zip).FirstOrDefault()
        If a Is Nothing Then
            a = New Address With {.address1 = address, .Zip = DBM.Instance.Zips.Find(zip)}
            DBM.Instance.Addresses.Add(a)
        End If

        Return a
    End Function

    Public Shared Sub SetupAutoCityFill(txtZip As TextBox, lblCity As Label)

        AddHandler txtZip.TextChanged, Sub()
                                           Dim z As Integer
                                           If txtZip.Text.Length <> 4 Then
                                               lblCity.Text = "UGYLDIG"
                                               Exit Sub
                                           End If

                                           Integer.TryParse(txtZip.Text, z)
                                           Dim theCity = (From x As Zip In DBM.Instance.Zips Where x.zip1 = z Select x.city).FirstOrDefault()
                                           If theCity Is Nothing Then
                                               theCity = "UGYLDIG"
                                           End If
                                           lblCity.Text = theCity.ToUpper()

                                       End Sub
    End Sub

End Class
