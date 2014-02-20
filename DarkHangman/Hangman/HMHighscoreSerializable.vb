' Class with serializable attribute so that we can save it to disk
<Serializable()>
Public Class HMHighscoreSerializable
    Public Entries As New List(Of HighscoreEntry)
    <Serializable()> Public Structure HighscoreEntry
        Public Score As Long
        Public Name As String
        Public Timestamp As DateTime
    End Structure
End Class
