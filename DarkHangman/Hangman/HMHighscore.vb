' Get the imports needed for doing serialization and saving to disk
Imports System.Runtime.Serialization
Imports System.IO
Imports Hangman.HMHighscoreSerializable

' Singleton class for dealing with the highscore list
Public Class HMHighscore
    ' Hardcoded highscore-file to be located next to the executable
    Private Shared HighscoreFile As String = Application.StartupPath & "\highscore.dat"
    ' Binary format makes cheating a tiny bit harder :)
    Private Shared Serializer As New Formatters.Binary.BinaryFormatter
    ' File stream for the highscore file. Not initialized here to handle IO errors (eg. permissions)
    Private Shared FileHandle As FileStream
    ' Set to whatever was last supplied as name for the highscore. Makes adding several scores under same name easier.
    Private Shared LastName As String
    ' The structure containing our scores. This may be loaded from disk
    Public Shared Highscore As New HMHighscoreSerializable()
    ' How many entries to store 
    Const MAX_ENTRIES = 10
    ' How many chars each entry can consist of (we're not bothering with multibyte unicode; 
    ' this is merely the max number of "M"'s the label can contain before wrapping and messing up the layout
    Const MAX_NAME_LENGTH = 12

    ' Loaded upon program launch
    Public Shared Sub Init()
        LoadHighscoreFromFile()
    End Sub

    ' Loads highscore from file. Generic exception handler to deal with it being empty/non-existant or unreadable
    ' The latter case may warrant another handling (ie. show the user a message) as that usually means that 
    ' we won't be able to save the score either upon exit
    Private Shared Sub LoadHighscoreFromFile()
        Try
            FileHandle = New FileStream(HighscoreFile, FileMode.OpenOrCreate)
            Highscore = CType(Serializer.Deserialize(FileHandle), HMHighscoreSerializable)
            SortAndReduceEntries()
        Catch ex As Exception
            Console.WriteLine("Failed to read and/or deserialize. Reason: " & ex.Message)
            HMHighscore.AddDummyHighscoreEntries()
        End Try
    End Sub

    ' Creates a dummy list of entries if the list was empty
    Private Shared Sub AddDummyHighscoreEntries()
        Dim ts As DateTime = New DateTime(2013, 11, 1, 12, 0, 0)
        AddHighscore(10000, "Bjørn", ts)
        AddHighscore(8000, "Amela", ts)
        AddHighscore(5000, "Johan", ts)
        AddHighscore(4000, "Martin", ts)
        AddHighscore(3000, "Olav", ts)
        AddHighscore(2000, "Sigrid", ts)
        AddHighscore(1000, "Yoda", ts)
        SortAndReduceEntries()
    End Sub

    ' Truncates and saves the current highscore to file. This is called upon application exit.
    Public Shared Sub SaveHighscoreToFile()
        Try
            FileHandle.SetLength(0)
            Serializer.Serialize(FileHandle, Highscore)
        Catch ex As Exception
            Console.WriteLine("Failed to write and/or serialize. Reason: " & ex.Message)
        End Try
    End Sub

    ' Test to see if the supplied score is worthy of being on the highscore
    Public Shared Function IsScoreMakingHighscore(score As Long) As Boolean
        ' If the list is non-full, then any non-zero score will do
        If (score > 0 AndAlso (Highscore.Entries.Count = 0 OrElse Highscore.Entries.Count < MAX_ENTRIES)) Then
            Return True
        End If
        ' Use Linq to pull out the lowest score on the list and compare it. Supplied score needs to
        ' be greater in order to make the list
        If Highscore.Entries.OrderBy(Function(e) e.Score)(0).Score < score Then
            Return True
        End If
        ' Sorry bub, your score sucks, better luck next time
        Return False
    End Function

    ' Prompts the user for a name to show alongside the supplied score.
    Public Shared Sub PromptUserForHighscore(score As Long)
        ' Check if score is great enough
        If Not IsScoreMakingHighscore(score) Then
            Exit Sub
        End If

        Dim name As String = ""
        ' Prompt for name
        name = InputBox("Du klarte highscore listen med dine " & score & " poeng!" & _
                        vbCrLf & _
                        vbCrLf & _
                        "Oppgi navnet ditt til highscorelista:", "Gratulerer!", LastName
               )
        ' InputBox has no way of telling us if the user entered a empty string (which would indicate a slip-up) or just pressed cancel
        ' (which would indicate that he/she would prefer not to be saved to highscore). Possible workaround is populating LastName with
        ' something like "Enter your name" and test for that. For now, assume emtpy string mean skip storing score
        If name = "" Then
            Exit Sub
        End If
        ' Remove leading/trailing spaces, and reduce length to MAX_NAME_LENGTH chars
        name = Mid(Trim(name), 1, MAX_NAME_LENGTH)
        ' Save the supplied name for the next time
        LastName = name
        ' Add it to the list alongside the timestamp
        AddHighscore(score, name, DateTime.Now)
        ' Sort the list and remove off any entries no longer making top MAX_ENTRIES
        SortAndReduceEntries()
    End Sub

    Public Shared Sub ClearHighscore()
        Highscore.Entries.Clear()
        If frmHighscore.Visible = True Then
            frmHighscore.PopulateHighscoreList()
        End If
    End Sub

    ' Utility sub adding a highscore to the list along with name and timestamp.
    Private Shared Sub AddHighscore(score As Long, name As String, ts As DateTime)
        Highscore.Entries.Add(New HighscoreEntry With {.Score = score, .Name = name, .Timestamp = ts})
    End Sub

    '  Utility sub that sorts the highscore list and pops off any entries being pushed out of top MAX_ENTRIES
    Private Shared Sub SortAndReduceEntries()
        Highscore.Entries = Highscore.Entries.OrderByDescending(Function(e) e.Score).Take(MAX_ENTRIES).ToList()
    End Sub
End Class
