Public Class FormHelper
    Public Shared Sub SetupDirtyTracking(ctrl As Control)
        For Each c As Control In ctrl.Controls
            If c.Tag <> "noDirty" Then
                If c.HasChildren Then
                    SetupDirtyTracking(c)
                ElseIf TypeOf c Is TextBox Then
                    AddHandler CType(c, TextBox).TextChanged, Sub(s, ev) FormHelper.EnableDirtyTrackingOnContainingForm(ctrl)
                ElseIf TypeOf c Is CheckBox Then
                    AddHandler CType(c, CheckBox).CheckedChanged, Sub(s, ev) FormHelper.EnableDirtyTrackingOnContainingForm(ctrl)
                ElseIf TypeOf c Is ComboBox Then
                    AddHandler CType(c, ComboBox).SelectedIndexChanged, Sub(s, ev) FormHelper.EnableDirtyTrackingOnContainingForm(ctrl)
                ElseIf TypeOf c Is RadioButton Then
                    AddHandler CType(c, RadioButton).CheckedChanged, Sub(s, ev) FormHelper.EnableDirtyTrackingOnContainingForm(ctrl)
                ElseIf TypeOf c Is DataGridView Then
                    AddHandler CType(c, DataGridView).CellValueChanged, Sub(s, ev) FormHelper.EnableDirtyTrackingOnContainingForm(ctrl)
                End If
            End If
        Next
    End Sub

    Public Shared Sub ResetControls(frm As Control)
        For Each c As Control In frm.Controls
            If c.HasChildren Then
                ResetControls(c)
            ElseIf TypeOf c Is TextBox Then
                CType(c, TextBox).Text = ""
            ElseIf TypeOf c Is CheckBox Then
                CType(c, CheckBox).Checked = False
            ElseIf TypeOf c Is ComboBox Then
                CType(c, ComboBox).SelectedIndex = -1
            End If
        Next
    End Sub

    Public Shared Function ContinueIfDirty(frm As frmSuperBase) As Boolean
        If Not frm.isDirty Then
            Return True
        End If
        If MessageBox.Show("Du har ulagrede endringer. Fortsette?", "Ulagrede endringer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Return True
        End If
        Return False
    End Function

    Public Shared Sub EnableDirtyTrackingOnContainingForm(ctrl As Control)
        Dim p As Control = ctrl
        If Not p.GetType().IsSubclassOf(frmSuperBase.GetType()) Then
            Do
                p = p.Parent
            Loop Until p.GetType().IsSubclassOf(frmSuperBase.GetType())
        End If
        CType(p, frmSuperBase).isDirty = True
    End Sub
End Class
