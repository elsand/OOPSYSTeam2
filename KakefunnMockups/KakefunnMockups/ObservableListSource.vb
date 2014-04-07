' See http://msdn.microsoft.com/en-us/data/jj682076.aspx

Imports System.Collections
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports System.Diagnostics.CodeAnalysis
Imports System.Data.Entity

Public Class ObservableListSource(Of T As Class)
    Inherits ObservableCollection(Of T)
    Implements IListSource
    Private _bindingList As IBindingListView

    Private ReadOnly Property IListSource_ContainsListCollection() As Boolean Implements IListSource.ContainsListCollection
        Get
            Return False
        End Get
    End Property

    Private Function IListSource_GetList() As IList Implements IListSource.GetList
        If _bindingList Is Nothing Then
            Return Me.ToBindingList()
        Else
            Return _bindingList
        End If
    End Function
End Class