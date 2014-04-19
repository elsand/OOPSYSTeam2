Public Class SystemEvent

    Private logEventName As String
    Private logEmployeeId As Integer
    Private logEventData As String

    Public Sub saveSystemEvent(ByVal logEventName As String, ByVal logEmployeeId As Integer, logEventData As String)

        Me.logEventName = logEventName ' Prøve å få til navn på formen
        Me.logEmployeeId = logEmployeeId ' Må hardkodast fram til det finnes en kobling til tabellen systemEvent
        Me.logEventData = logEventData ' Prøve å få til et eller annet som logger det som skjer. Hva med teksten i knappen og noko anna informasjon?

        DBM.Instance.GetDataTableFromQuery( _
         "INSERT INTO SystemEvent (eventName, eventTime, employeeId, eventData)" & _
         "VALUES ('" & Me.logEventName & "', NOW(), '1', '" & Me.eventData & "')" _
         )

    End Sub

End Class
