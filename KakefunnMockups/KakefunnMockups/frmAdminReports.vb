Imports Microsoft.Reporting.WinForms
Public Class frmAdminReports
    Dim reportDataSource As ReportDataSource

    ''' <summary>
    ''' Initial settings for the report form.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub frmAdminReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.IngredientTableAdapter2.Fill(Me.IngredientCombo.Ingredient)
        Me.cboSelectIngredient.Visible = False
        Me.lblSelectIngredient.Visible = False

       
    End Sub

    ''' <summary>
    ''' Manipulates visible controls based on what report is selected in the ddl.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub cboSelectReportForm_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSelectReportForm.SelectedIndexChanged
        If cboSelectReportForm.SelectedIndex = 2 Then
            Me.dtpTimePeriodFrom.Visible = False
            Me.dtpTimePeriodTo.Visible = False
            Me.lblTimePeriod.Visible = False
            Me.lblDateTo.Visible = False
            Me.lblSelectIngredient.Visible = True
            Me.cboSelectIngredient.Visible = True
        ElseIf cboSelectReportForm.SelectedIndex = 1 Or cboSelectReportForm.SelectedIndex = 3 Then
            Me.dtpTimePeriodFrom.Visible = False
            Me.dtpTimePeriodTo.Visible = False
            Me.lblTimePeriod.Visible = False
            Me.lblDateTo.Visible = False
            Me.lblSelectIngredient.Visible = False
            Me.cboSelectIngredient.Visible = False
        Else

            Me.dtpTimePeriodFrom.Visible = True
            Me.dtpTimePeriodTo.Visible = True
            Me.lblTimePeriod.Visible = True
            Me.lblSelectIngredient.Visible = False
            Me.cboSelectIngredient.Visible = False
        End If
    End Sub

    ''' <summary>
    ''' Displays selected report in the reportwiever by calling ReportHelper
    ''' with relevant parameters.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnGetReport_Click(sender As Object, e As EventArgs) Handles btnGetReport.Click
        Dim rph = New ReportHelper()
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
            Case 4
                MsgBox("TODO: Not implemented yet, kommer ila dagen")
            Case 5
                rph.startDate = Format(dtpTimePeriodFrom.Value, "yyyy-MM-dd")
                rph.stopDate = Format(dtpTimePeriodTo.Value, "yyyy-MM-dd")
                reportDataSource = New ReportDataSource("SystemEvent", rph.getDataTable("SystemEvent"))
        End Select
        With Me.rptReports.LocalReport
            .DataSources.Clear()
            .DataSources.Add(reportDataSource)
            .ReportEmbeddedResource = rph.rdf
        End With
        Me.rptReports.RefreshReport()
    End Sub
End Class
