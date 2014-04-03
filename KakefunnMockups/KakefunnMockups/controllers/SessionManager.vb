Public Class SessionManager


#Region "SingletonImplementation"

    ''' <summary>
    ''' Holds the instance of SessionManager. Uses Lazy() to defer initialization until requested.
    ''' </summary>
    ''' <remarks></remarks>
    Private Shared ReadOnly _instance As New Lazy(Of SessionManager)(Function() New SessionManager, System.Threading.LazyThreadSafetyMode.ExecutionAndPublication)

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
    Public Shared ReadOnly Property Instance() As SessionManager
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
    Public ReadOnly Property User As employee
        Get
            Return loggedInEmployee
        End Get
    End Property

    Private loggedInEmployee As employee
    Private _currentForm As frmSuperBase
    Private Property currentForm As frmSuperBase
        Get
            If _currentForm Is Nothing Then
                For Each frm As frmSuperBase In Application.OpenForms
                    Return frm
                Next
            End If
            Return _currentForm
        End Get
        Set(value As frmSuperBase)
            _currentForm = value
        End Set
    End Property


    Public Sub Init()
        ' Oppstartskode

    End Sub



    ''' <summary>
    ''' Returns the employee and sets it as the currently logged in user
    ''' </summary>
    ''' <param name="email"></param>
    ''' <param name="password"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Login(email As String, password As String) As employee
        Dim employee As employee = DBM.Instance.employees.Where(Function(x) x.email = email And x.password = password).FirstOrDefault()
        If employee Is Nothing Then
            Throw New DataException("User not found or invalid password")
        End If

        loggedInEmployee = employee

        Return loggedInEmployee
    End Function

    ''' <summary>
    ''' Utility function to determine if a user is logged in or not
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function IsLoggedIn() As Boolean
        Return Not loggedInEmployee Is Nothing
    End Function

    Public Sub ShowDefaultFormForLoggedInUser()
        If Not IsLoggedIn() Then
            Throw New UnauthorizedAccessException("User is not logged in")
        End If

        For Each r As role In User.roles
            Select Case r.name
                Case "Admin"
                    ShowForm(frmAdminReports)
                Case "Sale"
                    ShowForm(frmSaleMain)
                Case "Logistics"
                    ShowForm(frmLogisticsPackingList)
            End Select
        Next

    End Sub


    Public Sub ShowForm(frm As frmSuperBase)
        currentForm.Hide()
        frm.Show()
        currentForm = frm
    End Sub


End Class
