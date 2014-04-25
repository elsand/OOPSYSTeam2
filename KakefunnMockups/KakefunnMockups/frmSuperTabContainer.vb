''' <summary>
''' Form from which all tabcontainers inherit. Defines methods for populating a tabcontainer with a defined set of forms,
''' and supplies methods for the sessionmanager to handle switching between them
''' </summary>
''' <remarks></remarks>
Public Class frmSuperTabContainer

    ''' <summary>
    '''  Flag that makes sure we only prompt for closing once
    ''' </summary>
    ''' <remarks></remarks>
    Private Shared IsClosingEventHandled As Boolean = False

    ''' <summary>
    ''' A list of all main forms that are in use in this program
    ''' </summary>
    ''' <remarks></remarks>
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

    ''' <summary>
    ''' Provides a mapping between forms and aspectes, ie. tab containers
    ''' </summary>
    ''' <remarks></remarks>
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

    ''' <summary>
    ''' Returns a list of forms belonging to the supplied aspect
    ''' </summary>
    ''' <param name="aspect"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetFormsForAspect(aspect As String) As List(Of Form)
        Dim ret As New List(Of Form), pair As KeyValuePair(Of String, String)
        For Each pair In Aspects
            If pair.Value = aspect Then
                ret.Add(GetFormByName(pair.Key))
            End If
        Next
        Return ret
    End Function

    ''' <summary>
    ''' Returns a form instance given its name
    ''' </summary>
    ''' <param name="formName"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetFormByName(formName As String) As Form
        For Each f As Form In Forms
            If f.Name = formName Then
                Return f
            End If
        Next
        Return Nothing
    End Function

    ''' <summary>
    ''' Get the aspect to which the given form belongs
    ''' </summary>
    ''' <param name="form"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetAspectForForm(form As Form) As String
        If Aspects.ContainsKey(form.Name) Then
            Return Aspects.Item(form.Name)
        End If
        Return Nothing
    End Function

    ''' <summary>
    ''' Returns the container form for the supplied aspect
    ''' </summary>
    ''' <param name="aspect"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
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

    ''' <summary>
    ''' Handles enabling/disabling the aspect menu items depending on the logged in users role
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub UpdateAspectMenu()
        If Not SessionHelper.Instance.IsLoggedIn Then
            AspectToolStripMenuItem.Enabled = False
            Exit Sub
        End If
        AspectToolStripMenuItem.Enabled = True

        AdminToolStripMenuItem.Enabled = SessionHelper.Instance.HasRole("Admin")
        SaleToolStripMenuItem.Enabled = SessionHelper.Instance.HasRole("Sale")
        LogisticsToolStripMenuItem.Enabled = SessionHelper.Instance.HasRole("Logistics")

    End Sub

    ''' <summary>
    ''' Handle the Exit menu item
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    ''' <summary>
    ''' Handle the logout menu item
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        If Not SessionHelper.Instance.IsLoggedIn Then
            Exit Sub
        End If
        If MsgBox("Er du sikker på du vil logge ut?", MsgBoxStyle.YesNo, "Logg ut") = MsgBoxResult.Yes Then
            SessionHelper.Instance.Logout()
        End If
    End Sub

    ''' <summary>
    ''' Handle opening the Sale aspect
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub SaleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaleToolStripMenuItem.Click
        SessionHelper.Instance.ShowDefaultFormForRole("Sale")
    End Sub

    ''' <summary>
    ''' Handle opening the Admin aspect
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub AdminToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdminToolStripMenuItem.Click
        SessionHelper.Instance.ShowDefaultFormForRole("Admin")
    End Sub

    ''' <summary>
    ''' Handle opening the logistics aspect
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub LogisticsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogisticsToolStripMenuItem.Click
        SessionHelper.Instance.ShowDefaultFormForRole("Logistics")
    End Sub

    ''' <summary>
    ''' Handle the user closing a form, which is only triggered on the container forms and frmLogin. If this is the
    ''' last remaining form, prompt for application exit
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
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

    ''' <summary>
    ''' Handles populating a tabcontrol with the supplied list of forms, which are given one tab page each
    ''' </summary>
    ''' <param name="forms"></param>
    ''' <param name="tabContainer"></param>
    ''' <remarks></remarks>
    Protected Sub PopulateTabs(forms As List(Of Form), tabContainer As TabControl)
        For Each frm As Form In forms
            ' Prepare the form for being embedded as a control into a tabpage
            frm.TopLevel = False
            frm.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            frm.Dock = DockStyle.Fill

            ' Create a new tabpage, and set it's title to that of the form, then load (show) the form
            Dim tabPage As New TabPage()
            tabPage.Text = frm.Text
            tabPage.Controls.Add(frm)
            frm.Show()

            tabContainer.TabPages.Add(tabPage)

            ' Whenever we change to a form, set the title of the aspect window to the same
            AddHandler frm.VisibleChanged, Function(s As Object, e As EventArgs)
                                               CType(s, Form).Parent.Parent.Parent.Text = s.Text
                                               Return Nothing
                                           End Function
        Next

        ' Add handlers for switching between tabs. We add the visisblechanged as well to handle opening a new aspect window (before
        ' any actual tab changes)
        AddHandler tabContainer.SelectedIndexChanged, AddressOf OnTabChange
        AddHandler tabContainer.VisibleChanged, AddressOf OnTabChange
    End Sub

    ''' <summary>
    ''' Handler of tabs getting focus
    ''' </summary>
    ''' <param name="s"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Protected Sub OnTabChange(s As Object, e As EventArgs)
        SetParentFormMinimumsizeToSelectedTab(CType(s, TabControl))
        statusMain.BringToFront()
    End Sub

    ''' <summary>
    ''' Set the minimum size of the parent window to that of the form in the active tab.
    ''' Add some padding, and account for offset from the top.
    ''' </summary>
    ''' <param name="tabControl"></param>
    ''' <remarks></remarks>
    Protected Sub SetParentFormMinimumsizeToSelectedTab(tabControl As TabControl)
        Dim padding As Integer = 15
        Dim ms As Size = CType(tabControl.SelectedTab.Controls.Item(0), Form).MinimumSize
        ' Add some room for padding on the right side
        ms.Width = ms.Width + padding
        ' If the tabcontrol is offset from the top (as in sale), account for that here
        ms.Height = ms.Height + tabControl.Top + padding
        Me.MinimumSize = ms
    End Sub

End Class