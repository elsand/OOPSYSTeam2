Public Class ReportHelper

    Public startDate As String
    Public stopDate As String

    Public rdf As String





    Public Function getDataTable(ByVal type As String) As DataTable

        Select Case type
            Case "turnover"
                Me.rdf = "Kakefunn.Turnover.rdlc"

                Return Me._createTurnoverReport()

        End Select


    End Function


    Private Function _createTurnoverReport() As DataTable

        Return DBM.Instance.GetDataTableFromQuery( _
            "SELECT CONCAT('aaa', i.name, 'bbb') AS name, SUM(ol.amount) AS totalAmount, " & _
            "SUM(ol.totalPrice) AS tPrice, SUM(ol.totalPrice) / SUM(ol.amount) AS pricePrUnit " & _
            "FROM `Order` o INNER JOIN OrderLine ol ON ol.orderId = o.id " & _
            "INNER JOIN Ingredient i ON ol.ingredientId = i.id WHERE(DateDiff(Now(), o.created) < 31) " & _
            "GROUP BY i.id" _
        )


    End Function


End Class
