﻿Public Class FormHelper
    Public Shared Sub SetupDirtyTracking(frm As frmSuperBase)
        For Each c As Control In frm.Controls
            If c.Tag <> "noDirty" Then
                If TypeOf c Is TextBox Then
                    AddHandler CType(c, TextBox).TextChanged, Sub(s, ev) frm.isDirty = True
                ElseIf TypeOf c Is CheckBox Then
                    AddHandler CType(c, CheckBox).CheckedChanged, Sub(s, ev) frm.isDirty = True
                ElseIf TypeOf c Is ComboBox Then
                    AddHandler CType(c, ComboBox).SelectedIndexChanged, Sub(s, ev) frm.isDirty = True
                ElseIf TypeOf c Is RadioButton Then
                    AddHandler CType(c, RadioButton).CheckedChanged, Sub(s, ev) frm.isDirty = True
                ElseIf TypeOf c Is DataGridView Then
                    AddHandler CType(c, DataGridView).CellValueChanged, Sub(s, ev) frm.isDirty = True
                End If
            End If
        Next

        For Each gb As GroupBox In frm.Controls.OfType(Of GroupBox)()
            For Each c As Control In gb.Controls.OfType(Of Control)()
                If c.Tag <> "noDirty" Then
                    If TypeOf c Is TextBox Then
                        AddHandler CType(c, TextBox).TextChanged, Sub(s, ev) frm.isDirty = True
                    ElseIf TypeOf c Is CheckBox Then
                        AddHandler CType(c, CheckBox).CheckedChanged, Sub(s, ev) frm.isDirty = True
                    ElseIf TypeOf c Is ComboBox Then
                        AddHandler CType(c, ComboBox).SelectedIndexChanged, Sub(s, ev) frm.isDirty = True
                    ElseIf TypeOf c Is RadioButton Then
                        AddHandler CType(c, RadioButton).CheckedChanged, Sub(s, ev) frm.isDirty = True
                    ElseIf TypeOf c Is DataGridView Then
                        AddHandler CType(c, DataGridView).CellValueChanged, Sub(s, ev) frm.isDirty = True
                    End If
                End If
            Next
            For Each gb2 As GroupBox In gb.Controls.OfType(Of GroupBox)()
                For Each c As Control In gb2.Controls.OfType(Of Control)()
                    If c.Tag <> "noDirty" Then
                        If TypeOf c Is TextBox Then
                            AddHandler CType(c, TextBox).TextChanged, Sub(s, ev) frm.isDirty = True
                        ElseIf TypeOf c Is CheckBox Then
                            AddHandler CType(c, CheckBox).CheckedChanged, Sub(s, ev) frm.isDirty = True
                        ElseIf TypeOf c Is ComboBox Then
                            AddHandler CType(c, ComboBox).SelectedIndexChanged, Sub(s, ev) frm.isDirty = True
                        ElseIf TypeOf c Is RadioButton Then
                            AddHandler CType(c, RadioButton).CheckedChanged, Sub(s, ev) frm.isDirty = True
                        ElseIf TypeOf c Is DataGridView Then
                            AddHandler CType(c, DataGridView).CellValueChanged, Sub(s, ev) frm.isDirty = True
                        End If
                    End If
                Next
            Next
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
End Class
