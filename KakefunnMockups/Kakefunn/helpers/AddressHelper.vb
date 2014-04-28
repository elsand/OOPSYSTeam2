''' <summary>
''' Helper for geting and if needed creating address entries in the address table
''' </summary>
''' <remarks></remarks>
Public Class AddressHelper
    ''' <summary>
    ''' Returns an address object for the supplied zip and address. Both must be supplied, and zip must be present in the
    ''' zip-table. Will return the first existing, or create a new one if needed (which is not commited)
    ''' </summary>
    ''' <param name="zip"></param>
    ''' <param name="address"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetAddress(zip As Integer, address As String) As Address
        If zip = 0 OrElse address = "" Then
            Return Nothing
        End If
        Dim a As Address = DBM.Instance.Addresses.Where(Function(x) x.address1 = address And x.Zip.zip1 = zip).FirstOrDefault()
        Dim z As Zip = DBM.Instance.Zips.Find(zip)
        If z Is Nothing Then
            Return Nothing
        End If
        If a Is Nothing Then
            a = New Address With {.address1 = address, .Zip = z}
            DBM.Instance.Addresses.Add(a)
        End If

        Return a
    End Function

    ''' <summary>
    ''' Helper that takes a textbos and a label and sets up autofill of zip-codes. If a invalid zip-code is supplied,
    ''' the label will be set to "UGYLDIG"
    ''' </summary>
    ''' <param name="txtZip"></param>
    ''' <param name="lblCity"></param>
    ''' <remarks></remarks>
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
