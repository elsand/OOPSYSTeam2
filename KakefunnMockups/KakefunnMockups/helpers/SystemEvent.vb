Public Class SystemEvent

    Private logEventName As String
    Private logEmployeeId As Integer
    Private logEventData As String

    Public Shared Sub saveSystemEvent(ByVal logEventName As String, ByVal logEmployeeId As Integer, logEventData As String)

        DBM.Instance.GetDataSetFromQuery( _
         "INSERT INTO SystemEvent (eventName, eventTime, employeeId, eventData)" & _
         "VALUES ('" & logEventName & "', NOW(), '1', '" & logEventData & "')" _
         )

    End Sub

End Class
