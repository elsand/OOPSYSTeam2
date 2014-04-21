''' <summary>
''' SystemEvent logging
''' </summary>
''' <remarks></remarks>
Public Class KakefunnEvent
    Private logEventName As String
    Private logEventData As String

    Public Shared Sub saveSystemEvent(ByVal logEventName As String, logEventData As String)

        DBM.Instance.GetDataSetFromQuery( _
         "INSERT INTO SystemEvent (eventName, eventTime, employeeId, eventData)" & _
         "VALUES ('" & logEventName & "', NOW(),'" & SessionManager.Instance.User.id & "', '" & logEventData & "')" _
         )

    End Sub

End Class
