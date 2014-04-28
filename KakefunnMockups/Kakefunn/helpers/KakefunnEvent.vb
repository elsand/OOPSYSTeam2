''' <summary>
''' SystemEvent logging. 
''' saveSystemEvent is called where there is a write operation to the database, 
''' as well as on attemptet logins.
''' </summary>
''' <remarks></remarks>
Public Class KakefunnEvent
    Private logEventName As String
    Private logEventData As String
    Public Shared Sub saveSystemEvent(ByVal logEventName As String, logEventData As String)

        ' Handle events from not logged in users
        Dim userId As Integer = 0
        If SessionHelper.Instance.User IsNot Nothing Then
            userId = SessionHelper.Instance.User.id
        End If

        DBM.Instance.GetDataSetFromQuery( _
         "INSERT INTO SystemEvent (eventName, eventTime, employeeId, eventData)" & _
         "VALUES ('" & logEventName & "', NOW(),'" & userId & "', '" & logEventData & "')" _
         )
    End Sub
End Class
