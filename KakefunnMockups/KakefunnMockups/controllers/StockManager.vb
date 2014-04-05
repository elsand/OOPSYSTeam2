Public Class StockManager
    Public Shared Function getInStock(varenr As Integer) As Integer 'Finds amount of an ingredient in stock.
        Dim batches = From x In DBM.Instance.batches Where x.ingredientId = varenr _
                      And x.registered IsNot Nothing Select x.unitCount
        If batches.Any Then
            Return batches.Sum()
        Else
            Return 0
        End If
    End Function
End Class
