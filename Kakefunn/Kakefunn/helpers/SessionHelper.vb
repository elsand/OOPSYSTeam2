﻿''' <summary>
''' Helper for the current session, implemented as a singleton
''' </summary>
''' <remarks></remarks>
Public Class SessionHelper

#Region "SingletonImplementation"

    ''' <summary>
    ''' Holds the instance of SessionManager. Uses Lazy() to defer initialization until requested.
    ''' </summary>
    ''' <remarks></remarks>
    Private Shared ReadOnly _instance As New Lazy(Of SessionHelper)(Function() New SessionHelper, System.Threading.LazyThreadSafetyMode.ExecutionAndPublication)

    ''' <summary>
    ''' Implement singleton pattern. Make constructor private and no-op
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub New()
    End Sub

    ''' <summary>
    ''' Returns the instance of SessionManager
    ''' </summary>
    ''' <value></value>
    ''' <returns>SessionManager</returns>
    ''' <remarks></remarks>
    Public Shared ReadOnly Property Instance() As SessionHelper
        Get
            Return _instance.Value
        End Get
    End Property

#End Region

    ''' <summary>
    ''' Returns the currently logged in user
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    ''' 
    Public ReadOnly Property User As Employee
        Get
            Return loggedInEmployee
        End Get
    End Property

    Private loggedInEmployee As Employee
    Private _currentForm As frmSuperBase
    Private _currentDialog As frmDialogBase
    Private callback As System.Func(Of Form, Form, Boolean)

    ''' <summary>
    ''' Returns the currently active form. If this is not set (ie. first form), it returns the first form it finds in Application.OpenForms
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Property currentForm As frmSuperBase
        Get
            If _currentForm Is Nothing Then
                For Each frm As Form In Application.OpenForms

                    ' Find first tabcontrol
                    For Each c As Control In frm.Controls
                        If TypeOf c Is TabControl Then
                            Return CType(c, TabControl).SelectedTab.Controls.Item(0)
                        End If
                    Next

                Next
            End If
            Return _currentForm
        End Get
        Set(value As frmSuperBase)
            _currentForm = value
        End Set
    End Property

    ''' <summary>
    ''' Same as _currentDialig, but checks for frmDialogBase instead
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Property currentDialog As frmDialogBase
        Get
            If _currentDialog Is Nothing Then
                For Each frm As Form In Application.OpenForms
                    If frm.GetType().IsInstanceOfType(frmDialogBase) Then
                        Return frm
                    End If
                Next
            End If
            Return Nothing
        End Get
        Set(value As frmDialogBase)
            _currentDialog = value
        End Set
    End Property


    Public Sub Init()
        ' Start up code goes here
        '#If DEBUG Then
        '        ' In debug-mode, we usually don't login before testing, so return the first employee
        '        If loggedInEmployee Is Nothing Then
        '            loggedInEmployee = DBM.Instance.Employees.First()
        '        End If
        '#End If
    End Sub



    ''' <summary>
    ''' Returns the employee and sets it as the currently logged in user
    ''' </summary>
    ''' <param name="email"></param>
    ''' <param name="password"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Login(email As String, password As String) As Employee
        Dim employee As Employee = DBM.Instance.Employees.Where(Function(x) x.email = email And x.password = password).FirstOrDefault()

        If employee Is Nothing Then
            Throw New DataException("User not found or invalid password")
        Else
            loggedInEmployee = employee
            Return loggedInEmployee
        End If
    End Function

    ''' <summary>
    ''' Handle logging out. We need to hide all windows, and show the frmLogin manually
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Logout()
        loggedInEmployee = Nothing
        HideDialog()
        For Each frm As Form In Application.OpenForms
            If frm.TopLevel = True Then
                frm.Hide()
            End If
        Next
        frmLogin.Show()
    End Sub

    ''' <summary>
    ''' Utility function to determine if a user is logged in or not
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function IsLoggedIn() As Boolean
        Return Not loggedInEmployee Is Nothing
    End Function

    ''' <summary>
    ''' Shows the default for the logged in user
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub ShowDefaultFormForLoggedInUser()
        If Not IsLoggedIn() Then
            Throw New UnauthorizedAccessException("User is not logged in")
        End If

        ShowDefaultFormForRole(User.Roles.First.name)
    End Sub

    ''' <summary>
    ''' Shows the default form for the supplied role
    ''' </summary>
    ''' <param name="role"></param>
    ''' <remarks></remarks>
    Public Sub ShowDefaultFormForRole(role As String)
        Select Case role
            Case "Admin"
                ShowForm(frmAdminReports)
            Case "Sale"
                ShowForm(frmSaleMain)
            Case "Logistics"
                ShowForm(frmLogisticsPackingList)
        End Select
    End Sub

    ''' <summary>
    ''' Shows the supplied form. If the form is on another aspect, it is opened
    ''' </summary>
    ''' <param name="frm"></param>
    ''' <remarks></remarks>
    Public Sub ShowForm(frm As Form)
        Dim aspect As String = frmSuperTabContainer.GetAspectForForm(frm)
        Dim f As Form = frmSuperTabContainer.GetContainerForAspect(aspect)
        f.Show()
        f.Focus()

        ' Walk through the tabcontrols and find the tabpage containing the supploed form,
        ' and set it active
        For Each c As Control In f.Controls
            If TypeOf c Is TabControl Then
                For Each t As TabPage In CType(c, TabControl).TabPages
                    If t.Controls.Item(0).Name = frm.Name Then
                        CType(c, TabControl).SelectedTab = t
                    End If
                Next
            End If
        Next

        ' If callback was registered, invoke it now with the previous and 
        ' current form as arguments
        If callback IsNot Nothing Then
            callback.Invoke(currentForm, frm)
            callback = Nothing
        End If

        currentForm = frm
    End Sub

    ''' <summary>
    ''' Sets a callback function that is invoked when we switch forms
    ''' </summary>
    ''' <param name="f"></param>
    ''' <remarks></remarks>
    Public Sub RegisterCallback(f As System.Func(Of Form, Form, Boolean))
        callback = f
    End Sub

    ''' <summary>
    ''' Opens the supplied dialog window. Only one dialog can be up at any given time.
    ''' </summary>
    ''' <param name="dialog"></param>
    ''' <remarks></remarks>
    Public Sub ShowDialog(dialog As frmDialogBase)
        If Not currentDialog Is Nothing Then
            If dialog.Name = currentDialog.Name Then
                dialog.Focus()
                Exit Sub
            End If
            currentDialog.Hide()
        End If
        dialog.Show()
        dialog.Focus()
        currentDialog = dialog
    End Sub

    ''' <summary>
    ''' Hides the currently open dialog, if any
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub HideDialog()
        If Not currentDialog Is Nothing Then
            currentDialog.Hide()
            currentDialog = Nothing
        End If
    End Sub

    ''' <summary>
    ''' Returns true if the currently logged in user has the supplied role
    ''' </summary>
    ''' <param name="role"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function HasRole(role As String) As Boolean
        If Not IsLoggedIn() Then
            Throw New UnauthorizedAccessException("User is not logged in")
        End If
        Return (From r In User.Roles Where r.name = role Select r).Count() > 0
    End Function
End Class
