''' <summary>
''' Simple convenience class for handling autocomplete of an arbitrary array of strings to a text- or combo-box
''' </summary>
''' <remarks></remarks>
Public Class AutoCompleteHelper

    Private acSource As New AutoCompleteStringCollection()

    ''' <summary>
    ''' Constructor which takes an array of data to be used in the autocomplete
    ''' </summary>
    ''' <param name="data"></param>
    ''' <remarks></remarks>
    Public Sub New(data As Array)
        acSource.AddRange(data)
    End Sub

    ''' <summary>
    ''' Sets autocomplete on the supplied textbox with some reasonable standard settings
    ''' </summary>
    ''' <param name="control"></param>
    ''' <remarks></remarks>
    Public Sub UseOn(control As TextBox)
        With control
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = AutoCompleteSource.CustomSource
            .AutoCompleteCustomSource = acSource
        End With
    End Sub

    ''' <summary>
    ''' Sets autocomplete on the supplied combo with some reasonable standard settings
    ''' </summary>
    ''' <param name="control"></param>
    ''' <param name="data"></param>
    ''' <remarks></remarks>
    Public Sub UseOn(control As ComboBox, data As Array)
        With control
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = AutoCompleteSource.CustomSource
            .AutoCompleteCustomSource = acSource
        End With
    End Sub

End Class
