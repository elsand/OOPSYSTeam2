Public Class FormHelper
    Public Shared Sub SetupDirtyTracking(frm As frmSuperBase)
        For Each c As Control In frm.Controls
            If c.GetType().Name = "TextBox" Then
                AddHandler CType(c, TextBox).TextChanged, Sub(s, ev) frm.IsDirty = True
            ElseIf c.GetType().Name = "CheckBox" Then
                AddHandler CType(c, CheckBox).CheckedChanged, Sub(s, ev) frm.IsDirty = True
            End If
        Next
    End Sub
End Class
