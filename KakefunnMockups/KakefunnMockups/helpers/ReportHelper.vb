Public Class ReportHelper
    Public startDate As String
    Public stopDate As String
    Public id As Integer
    Public rdf As String

    ''' <summary>
    ''' Gets data for requested report.
    ''' </summary>
    ''' <param name="type"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function getDataTable(ByVal type As String) As DataTable
        Select Case type
            Case "turnover"
                Me.rdf = "Kakefunn.Turnover.rdlc"
                Return Me._createTurnoverReport()

            Case "ingredientHistory"
                Me.rdf = "Kakefunn.IngredientHistory.rdlc"
                Return Me._createIngredientHistoryReport()

            Case "lastYearNextMonth"
                Me.rdf = "Kakefunn.LastYearNextMonth.rdlc"
                Return Me._createLastYearNextMonthReport()

            Case "SystemEvent"
                Me.rdf = "Kakefunn.SystemEvent.rdlc"
                Return Me._createSystemEvent()
            Case "expiredBatches"
                Me.rdf = "Kakefunn.ExpiredBatches.rdlc"
                Return Me._createExpiredBatches()
        End Select
        Return Nothing
    End Function

    ''' <summary>
    ''' SQL-query for turnover report.
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function _createTurnoverReport() As DataTable
        Return DBM.Instance.GetDataTableFromQuery( _
            "SELECT i.name AS name, SUM(ol.amount) AS totalAmount, " & _
            "SUM(ol.totalPrice) AS tPrice, SUM(ol.totalPrice) / SUM(ol.amount) AS pricePrUnit " & _
            "FROM `Order` o INNER JOIN OrderLine ol ON ol.orderId = o.id " & _
            "INNER JOIN Ingredient i ON ol.ingredientId = i.id WHERE(DateDiff(Now(), o.created) < 31) " & _
            "GROUP BY i.id" _
        )
    End Function

    ''' <summary>
    ''' SQL-query for ingredient history report.
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
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

    ''' <summary>
    ''' SQL-query for report predicting next months ingredient usage.
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function _createLastYearNextMonthReport() As DataTable
        Return DBM.Instance.GetDataTableFromQuery( _
                        "SELECT i.name, MONTH(o.created) AS month, YEAR(o.created) AS year, SUM(ol.amount) AS totalAmount, u.name AS uName, SUM(b.unitCount) AS currAmount , ABS(LEAST(COALESCE(SUM(b.unitCount) - SUM(ol.amount),SUM(ol.amount)),0)) AS toOrder " & _
                        "FROM   `Order` o INNER JOIN " & _
                        "OrderLine ol ON ol.orderId = o.id INNER JOIN " & _
                        "Ingredient i ON ol.ingredientId = i.id INNER JOIN " & _
                        " Unit u ON u.id = i.unitId LEFT OUTER JOIN " & _
                        " Batch b ON b.ingredientId = i.id " & _
                        "WHERE        (MONTH(o.created) = MONTH(NOW()) + 1) AND (YEAR(o.created) = YEAR(NOW()) - 1) " & _
                        "GROUP BY i.id, MONTH(o.created) " & _
                        "ORDER BY toOrder DESC ; " _
        )
    End Function

    ''' <summary>
    ''' SQL-query for the system event report.
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function _createSystemEvent() As DataTable
        ' Since the timestamp also has its time, and not only the date, SQL-query has to contain an OR-statement with a wildcard (%)
        Return DBM.Instance.GetDataTableFromQuery(
        "SELECT * " & _
        "FROM  `SystemEvent`" & _
        "WHERE (eventTime BETWEEN '" & Me.startDate & "' AND '" & Me.stopDate & "')" & _
        "OR (eventTime LIKE '" & Me.stopDate & "%')"
        )
    End Function

    ''' <summary>
    ''' SQL-query for expired ingredient report.
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function _createExpiredBatches() As DataTable
        Return DBM.Instance.GetDataTableFromQuery( _
            "select i.id, b.registered, b.expires, b.unitCount, u.`name`, b.locationRow, b.locationShelf from Batch b " & _
            "inner join Ingredient i on i.id = b.ingredientId " & _
            "inner join Unit u on u.id = i.unitId " & _
            "where DATEDIFF(b.expires,now()) < 5 AND b.deleted IS NULL")
    End Function
End Class
