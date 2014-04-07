Public Class StockManager
    Public Shared Function getInStock(varenr As Integer, list As List(Of Kakefunn.Batch)) As Integer 'Finds amount of an ingredient in stock.
        Dim batches = From x In list Where x.ingredientId = varenr _
                      And x.registered IsNot Nothing Select x.unitCount
        If batches.Any Then
            Return batches.Sum()
        Else
            Return 0
        End If
    End Function

    Public Shared Function getPurchasingPrice(varenr As Integer, type As String, list As List(Of Kakefunn.Batch)) As Double
        Dim batches = From x In list _
                      Where x.ingredientId = varenr _
                      Select x.unitPurchasingPrice
        If batches.Any Then
            If type = "high" Then
                Return batches.Max()
            ElseIf type = "low" Then
                Return batches.Min()
            ElseIf type = "avg" Then
                Return batches.Average()
            End If
        End If
        Return 0
    End Function
End Class
