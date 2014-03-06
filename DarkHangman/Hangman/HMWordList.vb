' Class for handling loading of word lists and supplying the game with random words
Public Class HMWordList
    Private wordlist As New List(Of String)
    ' Returns a random word from the active wordlist. Takes into consideration current difficulty setting
    Public Function GetRandomWord() As String
        Dim randomIndexNumber As System.Random = New System.Random
        Dim wordIndex As Integer = randomIndexNumber.Next(0, wordlist.Count())
        Return wordlist.Item(wordIndex).ToUpper()
    End Function

    ' Should load and sort a 
    Public Sub LoadWordListFromFile(ByVal wordListFileName As String)
        'Takes one filename argument as string 
        'reads file line by line until end of file and feeds list of strings
        Dim wordListFileReader As New System.IO.StreamReader(wordListFileName)
        ' Dim wordlist As New List(Of String)
        Do While wordListFileReader.Peek() >= 0
            wordlist.Add(wordListFileReader.ReadLine())
        Loop
        wordListFileReader.Close()
    End Sub
End Class