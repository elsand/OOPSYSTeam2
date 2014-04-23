Public Class frmSuperTabContainer

    Private Shared IsClosingEventHandled As Boolean = False
    Private Forms As New Dictionary(Of Form, String)
    Private Containers As New Dictionary(Of String, Form)


    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Forms.Add(frmAdminProcessedOrders, "ADMIN")
        Forms.Add(frmAdminCakes, "ADMIN")
        Forms.Add(frmAdminIngredient, "ADMIN")
        Forms.Add(frmAdminBatch, "ADMIN")
        Forms.Add(frmAdminReports, "ADMIN")
        Forms.Add(frmAdminSystemAdministration, "ADMIN")

        Forms.Add(frmSaleMain, "SALE")
        Forms.Add(frmSaleOrder, "SALE")
        Forms.Add(frmSaleCustomer, "SALE")

        Forms.Add(frmLogisticsPackingList, "LOGISTICS")
        Forms.Add(frmLogisticsRegisterCommodity, "LOGISTICS")
        Forms.Add(frmLogisticsReports, "LOGISTICS")

    End Sub

    Public Function GetFormsForAspect(aspect As String) As List(Of Form)
        Dim ret As New List(Of Form), pair As KeyValuePair(Of Form, String)
        For Each pair In Forms
            If pair.Value = aspect Then
                ret.Add(pair.Key)
            End If
        Next
        Return ret
    End Function

    Public Function GetAspectForForm(form As Form) As String
        If Forms.ContainsKey(form) Then
            Return Forms.Item(form)
        Else
            Return Nothing
        End If
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
    End Sub


End Class