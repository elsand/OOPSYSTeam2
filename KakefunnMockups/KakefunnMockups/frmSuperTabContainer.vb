Public Class frmSuperTabContainer

    Private Shared IsClosingEventHandled As Boolean = False
    Private Forms As New List(Of Form) From { _
        frmAdminProcessedOrders, _
        frmAdminCakes, _
        frmAdminIngredient, _
        frmAdminBatch, _
        frmAdminReports, _
        frmAdminSystemAdministration, _
 _
        frmSaleMain, _
        frmSaleOrder, _
        frmSaleCustomer, _
 _
        frmLogisticsPackingList, _
        frmLogisticsRegisterCommodity, _
        frmLogisticsReports _
    }
    Private Aspects As New Dictionary(Of String, String) From { _
        {"frmAdminProcessedOrders", "ADMIN"}, _
        {"frmAdminCakes", "ADMIN"}, _
        {"frmAdminIngredient", "ADMIN"}, _
        {"frmAdminBatch", "ADMIN"}, _
        {"frmAdminReports", "ADMIN"}, _
        {"frmAdminSystemAdministration", "ADMIN"}, _
 _
        {"frmSaleMain", "SALE"}, _
        {"frmSaleOrder", "SALE"}, _
        {"frmSaleCustomer", "SALE"}, _
 _
        {"frmLogisticsPackingList", "LOGISTICS"}, _
        {"frmLogisticsRegisterCommodity", "LOGISTICS"}, _
        {"frmLogisticsReports", "LOGISTICS"} _
    }
    Private Containers As New Dictionary(Of String, Form)

    Public Function GetFormsForAspect(aspect As String) As List(Of Form)
        Dim ret As New List(Of Form), pair As KeyValuePair(Of String, String)
        For Each pair In Aspects
            If pair.Value = aspect Then
                ret.Add(GetFormByName(pair.key))
            End If
        Next
        Return ret
    End Function

    Public Function GetFormByName(formName As String) As Form
        For Each f As Form In Forms
            If f.Name = formName Then
                Return f
            End If
        Next
        Return Nothing
    End Function

    Public Function GetAspectForForm(form As Form) As String
        If Aspects.ContainsKey(form.Name) Then
            Return Aspects.Item(form.Name)
        End If
        Return Nothing
    End Function


    Public Function GetContainerForAspect(aspect As String) As Form
        Select Case aspect
            Case "ADMIN"
                Return frmAdminTabContainer
            Case "SALE"
                Return frmSaleTabContainer
            Case "LOGISTICS"
                Return frmLogisticsTabContainer
        End Select
        Return Nothing
    End Function

    Public Sub UpdateAspectMenu()
        If Not SessionManager.Instance.IsLoggedIn Then
            AspectToolStripMenuItem.Enabled = False
            Exit Sub
        End If
        AspectToolStripMenuItem.Enabled = True

        AdminToolStripMenuItem.Enabled = SessionManager.Instance.HasRole("Admin")
        SaleToolStripMenuItem.Enabled = SessionManager.Instance.HasRole("Sale")
        LogisticsToolStripMenuItem.Enabled = SessionManager.Instance.HasRole("Logistics")

    End Sub

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

        Dim topLevelFormsOpen As Integer = 0
        For Each f As Form In Application.OpenForms
            If f.TopLevel Then
                topLevelFormsOpen = topLevelFormsOpen + 1
            End If
        Next

        If Not IsClosingEventHandled AndAlso topLevelFormsOpen = 1 Then
            Select Case MessageBox.Show("Er du sikker på du vil avslutte?", "Bekreft lukk program", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                Case Windows.Forms.DialogResult.Yes
                    IsClosingEventHandled = True
                    Application.Exit()
                Case Windows.Forms.DialogResult.No
                    e.Cancel = True
            End Select
        End If
    End Sub


    Protected Sub PopulateTabs(forms As List(Of Form), tabContainer As TabControl)

        For Each frm As Form In forms
            frm.TopLevel = False
            frm.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            frm.Dock = DockStyle.Fill

            Dim tabPage As New TabPage()
            tabPage.Text = frm.Text
            tabPage.Controls.Add(frm)
            frm.Show()

            tabContainer.TabPages.Add(tabPage)

            AddHandler frm.VisibleChanged, Function(s As Object, e As EventArgs)
                                               CType(s, Form).Parent.Parent.Parent.Text = s.Text
                                               Return Nothing
                                           End Function
        Next

        AddHandler tabContainer.SelectedIndexChanged, AddressOf OnTabChange
        AddHandler tabContainer.VisibleChanged, AddressOf OnTabChange

    End Sub

    Protected Sub OnTabChange(s As Object, e As EventArgs)
        SetParentFormMinimumsizeToSelectedTab(CType(s, TabControl))
    End Sub

    Protected Sub SetParentFormMinimumsizeToSelectedTab(tabControl As TabControl)
        Dim ms As Size = CType(tabControl.SelectedTab.Controls.Item(0), Form).MinimumSize
        ' Add some room for padding on the right side
        ms.Width = ms.Width + 15
        ' If the tabcontrol is offset from the top (as in sale), account for that here
        ms.Height = ms.Height + tabControl.Top
        Me.MinimumSize = ms
    End Sub

End Class