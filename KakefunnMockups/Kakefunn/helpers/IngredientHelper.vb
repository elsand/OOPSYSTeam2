Public Class IngredientHelper
    ''' <summary>
    ''' Simple helper to get ingredient location if stock is sufficient to fill order.
    ''' </summary>
    ''' <param name="ol"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function getIngredientLocation(ByVal ol As OrderLine) As String
        Dim a = ol.amount
        Dim str As String
        ol.Ingredient.Batches.OrderBy(Function(b) b.expires)
        str = ""
        For Each b As Batch In ol.Ingredient.Batches
            If b.unitCount >= a Then
                str &= " Rad: " & b.locationRow & ", Hylle:" & b.locationShelf & vbCrLf
                Exit For
            Else
                str &= " Rad: " & b.locationRow & ", Hylle:" & b.locationShelf & vbCrLf
                a -= b.unitCount
            End If
        Next
        Return str
    End Function
End Class
