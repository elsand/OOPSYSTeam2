Public Class LocalSystemHelper
    Public Shared Function getDefaultBrowser() As String
        'Gets default web browser.
        Dim browser As String = String.Empty
        Dim key As Microsoft.Win32.RegistryKey = Nothing
        Try
            key = Microsoft.Win32.Registry.ClassesRoot.OpenSubKey("HTTP\shell\open\command", False)
            'trim off quotes
            browser = key.GetValue(Nothing).ToString().ToLower().Replace("""", "")
            If Not browser.EndsWith("exe") Then
                'get rid of everything after the ".exe"
                browser = browser.Substring(0, browser.LastIndexOf(".exe") + 4)
            End If
        Finally
            If key IsNot Nothing Then
                key.Close()
            End If
        End Try
        Return browser
    End Function

End Class
