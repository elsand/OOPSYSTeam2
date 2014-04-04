Public Class frmSuperBase

    Private Shared IsClosingEventHandled As Boolean = False

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        If Not SessionManager.Instance.IsLoggedIn Then
            Exit Sub
        End If
        If MsgBox("Er du sikker på du vil logge ut?", MsgBoxStyle.YesNo, "Logg ut") = MsgBoxResult.Yes Then
            SessionManager.Instance.Logout()
        End If
    End Sub

    Private Sub frmSuperBase_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        If Me.Visible Then
            UpdateAspectMenu()
            UpdateLoginStatus()
            UpdateActionStatus()
            OnFormGetsForeground()
        End If
    End Sub

    Protected Overridable Sub OnFormGetsForeground()
        ' Implemented in subclasses
    End Sub

    Private Sub UpdateAspectMenu()
        If Not SessionManager.Instance.IsLoggedIn Then
            AspectToolStripMenuItem.Enabled = False
            Exit Sub
        End If
        AspectToolStripMenuItem.Enabled = True

        AdminToolStripMenuItem.Enabled = SessionManager.Instance.HasRole("Admin")
        SaleToolStripMenuItem.Enabled = SessionManager.Instance.HasRole("Sale")
        LogisticsToolStripMenuItem.Enabled = SessionManager.Instance.HasRole("Logistics")

    End Sub

    Private Sub UpdateLoginStatus()
        If Not SessionManager.Instance.IsLoggedIn Then
            statusLogin.Text = "Ikke innlogget"
            Exit Sub
        End If
        Dim roles As String = ""
        For Each r In SessionManager.Instance.User.roles
            roles = roles & r.name & ", "
        Next
        roles = roles.Substring(0, roles.Length - 2)
        statusLogin.Text = "Innlogget: " & SessionManager.Instance.User.name & " (" & roles & ")"
    End Sub

    Protected Sub UpdateActionStatus(status As String)
        statusAction.Text = status
        Application.DoEvents()
    End Sub

    Protected Sub UpdateActionStatus()
        UpdateActionStatus("")
    End Sub

    Private Sub SaleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaleToolStripMenuItem.Click
        SessionManager.Instance.ShowDefaultFormForRole("Sale")
    End Sub

    Private Sub AdminToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdminToolStripMenuItem.Click
        SessionManager.Instance.ShowDefaultFormForRole("Admin")
    End Sub

    Private Sub LogisticsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogisticsToolStripMenuItem.Click
        SessionManager.Instance.ShowDefaultFormForRole("Logistics")
    End Sub

    Private Sub frmSuperBase_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not IsClosingEventHandled Then
            Select Case MessageBox.Show("Er du sikker på du vil avslutte?", "Bekreft lukk program", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                Case Windows.Forms.DialogResult.Yes
                    IsClosingEventHandled = True
                    Application.Exit()
                Case Windows.Forms.DialogResult.No
                    e.Cancel = True
            End Select
        End If
    End Sub
End Class