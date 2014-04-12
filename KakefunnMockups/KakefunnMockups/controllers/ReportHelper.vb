Public Class ReportHelper

    Public startDate As String
    Public stopDate As String
    Public id As Integer
    Public rdf As String





    Public Function getDataTable(ByVal type As String) As DataTable

        Select Case type
            Case "turnover"
                Me.rdf = "Kakefunn.Turnover.rdlc"

                Return Me._createTurnoverReport()
            Case "ingredientHistory"
                Me.rdf = "Kakefunn.IngredientHistory.rdlc"

                Return Me._createIngredientHistoryReport()


        End Select


    End Function


    Private Function _createTurnoverReport() As DataTable

        Return DBM.Instance.GetDataTableFromQuery( _
            "SELECT i.name AS name, SUM(ol.amount) AS totalAmount, " & _
            "SUM(ol.totalPrice) AS tPrice, SUM(ol.totalPrice) / SUM(ol.amount) AS pricePrUnit " & _
            "FROM `Order` o INNER JOIN OrderLine ol ON ol.orderId = o.id " & _
            "INNER JOIN Ingredient i ON ol.ingredientId = i.id WHERE(DateDiff(Now(), o.created) < 31) " & _
            "GROUP BY i.id" _
        )


    End Function

    Private Function _createIngredientHistoryReport() As DataTable
        Return DBM.Instance.GetDataTableFromQuery( _
                        "SELECT  i.name, MONTH(o.created) AS month, YEAR(o.created) AS year, SUM(ol.amount) AS amount, u.name AS uName " & _
                        "FROM `Order` o INNER JOIN " & _
                        "OrderLine ol ON ol.orderId = o.id INNER JOIN " & _
                        "Ingredient i ON ol.ingredientId = i.id INNER JOIN " & _
                        "Unit u ON u.id = i.unitId " & _
                        "WHERE (i.id = " & Me.id & ") AND (DATEDIFF(NOW(), o.created) < 365 + DAYOFMONTH(NOW())) " & _
                        "GROUP BY year, month " & _
                        "ORDER BY year, month" _
        )
    End Function



End Class
