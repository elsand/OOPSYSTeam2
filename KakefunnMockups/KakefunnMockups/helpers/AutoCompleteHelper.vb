Public Class AutoCompleteHelper

    Private acSource As New AutoCompleteStringCollection()

    Public Sub New(data As Array)
        acSource.AddRange(data)
    End Sub

    Public Sub UseOn(control As TextBox)
        With control
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = AutoCompleteSource.CustomSource
            .AutoCompleteCustomSource = acSource
        End With
    End Sub

    Public Sub UseOn(control As ComboBox, data As Array)
        With control
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = AutoCompleteSource.CustomSource
            .AutoCompleteCustomSource = acSource
        End With
    End Sub

End Class
