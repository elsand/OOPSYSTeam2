''' <summary>
''' Utility class for dealing with forms
''' </summary>
''' <remarks></remarks>
Public Class FormHelper
    ''' <summary>
    ''' Enables dirty tracking on the supplied control (ie. form). Requires parent form to inherit frmSuperBase
    ''' Whenever a control is changed, a dirty flag is set which will cause a prompt if the user is about to lose those changes
    ''' </summary>
    ''' <param name="ctrl"></param>
    ''' <remarks></remarks>
    Public Shared Sub SetupDirtyTracking(ctrl As Control)
        For Each c As Control In ctrl.Controls
            If c.Tag <> "noDirty" Then
                If c.HasChildren Then
                    ' Container control, recurse
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

    ''' <summary>
    ''' Resets all fields on the supplied control (ie. form)
    ''' </summary>
    ''' <param name="frm"></param>
    ''' <remarks></remarks>
    Public Shared Sub ResetControls(frm As Control)
        For Each c As Control In frm.Controls
            If c.HasChildren Then
                ' Container control, recurse
                ResetControls(c)
            ElseIf TypeOf c Is TextBox Then
                CType(c, TextBox).Text = ""
            ElseIf TypeOf c Is CheckBox Then
                CType(c, CheckBox).Checked = False
            ElseIf TypeOf c Is ComboBox Then
                CType(c, ComboBox).SelectedIndex = -1
            End If
        Next
        EnableControls(frm)
    End Sub

    ''' <summary>
    ''' Disables all fields on the supplied control (ie. form), except those with tag "noDisable"
    ''' Special handling of DataGridViews as they need to be disabled as a whole even thought they're
    ''' containers
    ''' </summary>
    ''' <param name="frm"></param>
    ''' <remarks></remarks>
    Public Shared Sub DisableControls(frm As Control)
        For Each c As Control In frm.Controls
            If c.Tag <> "noDisable" Then
                If c.HasChildren AndAlso Not TypeOf c Is DataGridView Then
                    DisableControls(c)
                Else
                    c.Enabled = False
                End If
            End If
        Next
    End Sub

    ''' <summary>
    ''' Enable all fields on the supplied control (ie. form),
    ''' </summary>
    ''' <param name="frm"></param>
    ''' <remarks></remarks>
    Public Shared Sub EnableControls(frm As Control)
        For Each c As Control In frm.Controls
            If c.HasChildren AndAlso Not TypeOf c Is DataGridView Then
                EnableControls(c)
            Else
                c.Enabled = True
            End If
        Next
    End Sub

    ''' <summary>
    ''' Function which checks dirty flag and prompts the user for confirmation if unsaved changes are
    ''' about to be lost. Returns true if the form isn't dirty, or the user confirms, false otherwise
    ''' </summary>
    ''' <param name="frm"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function ContinueIfDirty(frm As frmSuperBase) As Boolean
        If Not frm.isDirty Then
            Return True
        End If
        If MessageBox.Show("Du har ulagrede endringer. Fortsette?", "Ulagrede endringer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Return True
        End If
        Return False
    End Function

    ''' <summary>
    ''' Handler called whenever a control changes valuye. Sets the dirty flag to true in the containing form
    ''' </summary>
    ''' <param name="ctrl"></param>
    ''' <remarks></remarks>
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
