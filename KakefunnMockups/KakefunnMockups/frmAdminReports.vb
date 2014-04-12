Imports Microsoft.Reporting.WinForms

Public Class frmAdminReports


    Dim reportDataSource As ReportDataSource

    Private Sub frmAdminReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.cboSelectIngredient.Visible = False
        Me.lblSelectIngredient.Visible = False


        'TODO: This line of code loads data into the '_14vfu_t02DataSet.Ingredient' table. You can move, or remove it, as needed.
        Me.IngredientTableAdapter1.Fill(Me._14vfu_t02DataSet.Ingredient)
        'TODO: This line of code loads data into the 'Ingredien.LastYearMonthSale' table. You can move, or remove it, as needed.
        ' Me.LastYearMonthSaleTableAdapter.Fill(Me.Ingredien.LastYearMonthSale)
        'TODO: This line of code loads data into the 'Ingredien.IngredientHistory' table. You can move, or remove it, as needed.
        ' Me.IngredientHistoryTableAdapter.Fill(Me.Ingredien.IngredientHistory)

        ' Me.cboSelectReportForm.SelectedIndex = 0

        'TODO: This line of code loads data into the 'Turnover.Ingredient' table. You can move, or remove it, as needed.
        'Me.IngredientTableAdapter.Fill(Me.Turnover.Ingredient)
        'TODO: This line of code loads data into the 'EmployeeTest.Employee' table. You can move, or remove it, as needed.
        'Me.EmployeeTableAdapter.Fill(Me.EmployeeTest.Employee)

        'Me.rptReports.RefreshReport()

    End Sub

    Private Sub cboSelectReportForm_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSelectReportForm.SelectedIndexChanged
        If cboSelectReportForm.SelectedIndex = 2 Then
            ' MsgBox(cboSelectIngredient.SelectedValue)

            Me.dtpTimePeriodFrom.Visible = False
            Me.dtpTimePeriodTo.Visible = False
            Me.lblTimePeriod.Visible = False
            Me.lblSelectIngredient.Visible = True
            Me.cboSelectIngredient.Visible = True
        Else
            Me.dtpTimePeriodFrom.Visible = True
            Me.dtpTimePeriodTo.Visible = True
            Me.lblTimePeriod.Visible = True
            Me.lblSelectIngredient.Visible = False
            Me.cboSelectIngredient.Visible = False

        End If
    End Sub

    Private Sub btnGetReport_Click(sender As Object, e As EventArgs) Handles btnGetReport.Click

        Dim rph = New ReportHelper()

        ' MsgBox(cboSelectReportForm.SelectedIndex)

        Select Case cboSelectReportForm.SelectedIndex
            Case 0
                Return
            Case 1
                reportDataSource = New ReportDataSource("DataSet1", rph.getDataTable("turnover"))
            Case 2
                rph.id = cboSelectIngredient.SelectedValue

                reportDataSource = New ReportDataSource("IngredientHistory", rph.getDataTable("ingredientHistory"))
            Case 3
                reportDataSource = New ReportDataSource("LastYearNextMonth", rph.getDataTable("lastYearNextMonth"))



        End Select









        With Me.rptReports.LocalReport

            .DataSources.Clear()
            .DataSources.Add(reportDataSource)
            .ReportEmbeddedResource = rph.rdf

        End With

        Me.rptReports.RefreshReport()






    End Sub
End Class
