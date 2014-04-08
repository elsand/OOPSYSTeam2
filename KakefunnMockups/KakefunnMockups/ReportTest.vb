Imports Microsoft.Reporting.WinForms

Public Class ReportTest

    Dim reportDataSource As ReportDataSource

    Private Sub ReportTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim reportDt As DataTable = DBM.Instance.GetDataTableFromQuery( _
            "SELECT CONCAT('aaa', i.name, 'bbb') AS name, SUM(ol.amount) AS totalAmount, " & _
            "SUM(ol.totalPrice) AS tPrice, SUM(ol.totalPrice) / SUM(ol.amount) AS pricePrUnit " & _
            "FROM `Order` o INNER JOIN OrderLine ol ON ol.orderId = o.id " & _
            "INNER JOIN Ingredient i ON ol.ingredientId = i.id WHERE(DateDiff(Now(), o.created) < 31) " & _
            "GROUP BY i.id" _
        )

        ' "DataSet1" er navnet på datasettet som Turnover.rdlc forventer
        reportDataSource = New ReportDataSource("DataSet1", reportDt)

        With rvTest.LocalReport
            .DataSources.Clear()
            .DataSources.Add(reportDataSource)
            .ReportEmbeddedResource = "Kakefunn.Turnover.rdlc"
        End With

        rvTest.RefreshReport()
    End Sub

End Class