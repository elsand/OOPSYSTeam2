Public Class IngredientHelper

    Public Shared Function getIngredientLocation(ByVal ol As OrderLine) As String

        Dim a = ol.amount
        Dim str As String

        ol.Ingredient.Batches.OrderBy(Function(b) b.expires)
        str = ""
        For Each b As Batch In ol.Ingredient.Batches
            ' Dersom en har nok plasseringer til ordren.. 
            
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
