<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdminReports
    Inherits Kakefunn.frmAdminBase

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.LastYearMonthSaleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ingredien = New Kakefunn.Ingredien()
        Me.IngredientHistoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IngredientBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Turnover = New Kakefunn.Turnover()
        Me.EmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeeTest = New Kakefunn.EmployeeTest()
        Me.batchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cboSelectReportForm = New System.Windows.Forms.ComboBox()
        Me.lblSelectReportForm = New System.Windows.Forms.Label()
        Me.btnGetReport = New System.Windows.Forms.Button()
        Me.rptReports = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.dtpTimePeriodFrom = New System.Windows.Forms.DateTimePicker()
        Me.dtpTimePeriodTo = New System.Windows.Forms.DateTimePicker()
        Me.lblTimePeriod = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.EmployeeTableAdapter = New Kakefunn.EmployeeTestTableAdapters.EmployeeTableAdapter()
        Me.IngredientTableAdapter = New Kakefunn.TurnoverTableAdapters.IngredientTableAdapter()
        Me.fpdFindReportFolder = New System.Windows.Forms.FolderBrowserDialog()
        Me.LastYearMonthSaleTableAdapter = New Kakefunn.IngredienTableAdapters.LastYearMonthSaleTableAdapter()
        Me.IngredientHistoryTableAdapter = New Kakefunn.IngredienTableAdapters.IngredientHistoryTableAdapter()
        Me.cboSelectIngredient = New System.Windows.Forms.ComboBox()
        Me.IngredientBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me._14vfu_t02DataSet = New Kakefunn._14vfu_t02DataSet()
        Me.IngredientTableAdapter1 = New Kakefunn._14vfu_t02DataSetTableAdapters.IngredientTableAdapter()
        Me.lblSelectIngredient = New System.Windows.Forms.Label()
        CType(Me.LastYearMonthSaleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ingredien, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IngredientHistoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IngredientBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Turnover, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeTest, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.batchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IngredientBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._14vfu_t02DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LastYearMonthSaleBindingSource
        '
        Me.LastYearMonthSaleBindingSource.DataMember = "LastYearMonthSale"
        Me.LastYearMonthSaleBindingSource.DataSource = Me.Ingredien
        '
        'Ingredien
        '
        Me.Ingredien.DataSetName = "Ingredien"
        Me.Ingredien.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'IngredientHistoryBindingSource
        '
        Me.IngredientHistoryBindingSource.DataMember = "IngredientHistory"
        Me.IngredientHistoryBindingSource.DataSource = Me.Ingredien
        '
        'IngredientBindingSource
        '
        Me.IngredientBindingSource.DataMember = "Ingredient"
        Me.IngredientBindingSource.DataSource = Me.Turnover
        '
        'Turnover
        '
        Me.Turnover.DataSetName = "Turnover"
        Me.Turnover.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmployeeBindingSource
        '
        Me.EmployeeBindingSource.DataMember = "Employee"
        Me.EmployeeBindingSource.DataSource = Me.EmployeeTest
        '
        'EmployeeTest
        '
        Me.EmployeeTest.DataSetName = "EmployeeTest"
        Me.EmployeeTest.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'batchBindingSource
        '
        Me.batchBindingSource.DataSource = GetType(Kakefunn.Batch)
        '
        'cboSelectReportForm
        '
        Me.cboSelectReportForm.FormattingEnabled = True
        Me.cboSelectReportForm.Items.AddRange(New Object() {"Velg rapport", "Salgsrapport", "Ingrediens siste år"})
        Me.cboSelectReportForm.Location = New System.Drawing.Point(108, 69)
        Me.cboSelectReportForm.Name = "cboSelectReportForm"
        Me.cboSelectReportForm.Size = New System.Drawing.Size(121, 21)
        Me.cboSelectReportForm.TabIndex = 7
        '
        'lblSelectReportForm
        '
        Me.lblSelectReportForm.AutoSize = True
        Me.lblSelectReportForm.Location = New System.Drawing.Point(12, 72)
        Me.lblSelectReportForm.Name = "lblSelectReportForm"
        Me.lblSelectReportForm.Size = New System.Drawing.Size(90, 13)
        Me.lblSelectReportForm.TabIndex = 8
        Me.lblSelectReportForm.Text = "Velg type rapport:"
        '
        'btnGetReport
        '
        Me.btnGetReport.Location = New System.Drawing.Point(538, 67)
        Me.btnGetReport.Name = "btnGetReport"
        Me.btnGetReport.Size = New System.Drawing.Size(157, 23)
        Me.btnGetReport.TabIndex = 9
        Me.btnGetReport.Text = "Hent rapport"
        Me.btnGetReport.UseVisualStyleBackColor = True
        '
        'rptReports
        '
        ReportDataSource1.Name = "IngredientsPrMonth"
        ReportDataSource1.Value = Me.LastYearMonthSaleBindingSource
        ReportDataSource2.Name = "IngredientHistory"
        ReportDataSource2.Value = Me.IngredientHistoryBindingSource
        Me.rptReports.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rptReports.LocalReport.DataSources.Add(ReportDataSource2)
        Me.rptReports.LocalReport.ReportEmbeddedResource = "Kakefunn.IngredientMonth.rdlc"
        Me.rptReports.Location = New System.Drawing.Point(15, 96)
        Me.rptReports.Name = "rptReports"
        Me.rptReports.ShowBackButton = False
        Me.rptReports.ShowContextMenu = False
        Me.rptReports.ShowCredentialPrompts = False
        Me.rptReports.ShowPageNavigationControls = False
        Me.rptReports.ShowParameterPrompts = False
        Me.rptReports.ShowPromptAreaButton = False
        Me.rptReports.ShowRefreshButton = False
        Me.rptReports.ShowStopButton = False
        Me.rptReports.ShowZoomControl = False
        Me.rptReports.Size = New System.Drawing.Size(681, 326)
        Me.rptReports.TabIndex = 10
        '
        'dtpTimePeriodFrom
        '
        Me.dtpTimePeriodFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTimePeriodFrom.Location = New System.Drawing.Point(313, 70)
        Me.dtpTimePeriodFrom.Name = "dtpTimePeriodFrom"
        Me.dtpTimePeriodFrom.Size = New System.Drawing.Size(96, 20)
        Me.dtpTimePeriodFrom.TabIndex = 11
        '
        'dtpTimePeriodTo
        '
        Me.dtpTimePeriodTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTimePeriodTo.Location = New System.Drawing.Point(436, 70)
        Me.dtpTimePeriodTo.Name = "dtpTimePeriodTo"
        Me.dtpTimePeriodTo.Size = New System.Drawing.Size(96, 20)
        Me.dtpTimePeriodTo.TabIndex = 12
        '
        'lblTimePeriod
        '
        Me.lblTimePeriod.AutoSize = True
        Me.lblTimePeriod.Location = New System.Drawing.Point(235, 72)
        Me.lblTimePeriod.Name = "lblTimePeriod"
        Me.lblTimePeriod.Size = New System.Drawing.Size(72, 13)
        Me.lblTimePeriod.TabIndex = 13
        Me.lblTimePeriod.Text = "for tidsrommet"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(416, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(14, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "til"
        '
        'EmployeeTableAdapter
        '
        Me.EmployeeTableAdapter.ClearBeforeFill = True
        '
        'IngredientTableAdapter
        '
        Me.IngredientTableAdapter.ClearBeforeFill = True
        '
        'LastYearMonthSaleTableAdapter
        '
        Me.LastYearMonthSaleTableAdapter.ClearBeforeFill = True
        '
        'IngredientHistoryTableAdapter
        '
        Me.IngredientHistoryTableAdapter.ClearBeforeFill = True
        '
        'cboSelectIngredient
        '
        Me.cboSelectIngredient.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboSelectIngredient.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboSelectIngredient.DataSource = Me.IngredientBindingSource1
        Me.cboSelectIngredient.DisplayMember = "name"
        Me.cboSelectIngredient.FormattingEnabled = True
        Me.cboSelectIngredient.Location = New System.Drawing.Point(321, 70)
        Me.cboSelectIngredient.Name = "cboSelectIngredient"
        Me.cboSelectIngredient.Size = New System.Drawing.Size(211, 21)
        Me.cboSelectIngredient.TabIndex = 15
        Me.cboSelectIngredient.ValueMember = "id"
        '
        'IngredientBindingSource1
        '
        Me.IngredientBindingSource1.DataMember = "Ingredient"
        Me.IngredientBindingSource1.DataSource = Me._14vfu_t02DataSet
        '
        '_14vfu_t02DataSet
        '
        Me._14vfu_t02DataSet.DataSetName = "_14vfu_t02DataSet"
        Me._14vfu_t02DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'IngredientTableAdapter1
        '
        Me.IngredientTableAdapter1.ClearBeforeFill = True
        '
        'lblSelectIngredient
        '
        Me.lblSelectIngredient.AutoSize = True
        Me.lblSelectIngredient.Location = New System.Drawing.Point(236, 72)
        Me.lblSelectIngredient.Name = "lblSelectIngredient"
        Me.lblSelectIngredient.Size = New System.Drawing.Size(79, 13)
        Me.lblSelectIngredient.TabIndex = 16
        Me.lblSelectIngredient.Text = "Velg ingrediens"
        '
        'frmAdminReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(707, 458)
        Me.Controls.Add(Me.lblSelectIngredient)
        Me.Controls.Add(Me.cboSelectIngredient)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblTimePeriod)
        Me.Controls.Add(Me.dtpTimePeriodTo)
        Me.Controls.Add(Me.dtpTimePeriodFrom)
        Me.Controls.Add(Me.rptReports)
        Me.Controls.Add(Me.btnGetReport)
        Me.Controls.Add(Me.lblSelectReportForm)
        Me.Controls.Add(Me.cboSelectReportForm)
        Me.Name = "frmAdminReports"
        Me.Controls.SetChildIndex(Me.cboSelectReportForm, 0)
        Me.Controls.SetChildIndex(Me.lblSelectReportForm, 0)
        Me.Controls.SetChildIndex(Me.btnGetReport, 0)
        Me.Controls.SetChildIndex(Me.rptReports, 0)
        Me.Controls.SetChildIndex(Me.dtpTimePeriodFrom, 0)
        Me.Controls.SetChildIndex(Me.dtpTimePeriodTo, 0)
        Me.Controls.SetChildIndex(Me.lblTimePeriod, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.cboSelectIngredient, 0)
        Me.Controls.SetChildIndex(Me.lblSelectIngredient, 0)
        CType(Me.LastYearMonthSaleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ingredien, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IngredientHistoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IngredientBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Turnover, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeTest, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.batchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IngredientBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._14vfu_t02DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboSelectReportForm As System.Windows.Forms.ComboBox
    Friend WithEvents lblSelectReportForm As System.Windows.Forms.Label
    Friend WithEvents btnGetReport As System.Windows.Forms.Button
    Friend WithEvents rptReports As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents dtpTimePeriodFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpTimePeriodTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblTimePeriod As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents batchBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmployeeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmployeeTest As Kakefunn.EmployeeTest
    Friend WithEvents EmployeeTableAdapter As Kakefunn.EmployeeTestTableAdapters.EmployeeTableAdapter
    Friend WithEvents IngredientBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Turnover As Kakefunn.Turnover
    Friend WithEvents IngredientTableAdapter As Kakefunn.TurnoverTableAdapters.IngredientTableAdapter
    Friend WithEvents fpdFindReportFolder As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents LastYearMonthSaleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Ingredien As Kakefunn.Ingredien
    Friend WithEvents IngredientHistoryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LastYearMonthSaleTableAdapter As Kakefunn.IngredienTableAdapters.LastYearMonthSaleTableAdapter
    Friend WithEvents IngredientHistoryTableAdapter As Kakefunn.IngredienTableAdapters.IngredientHistoryTableAdapter
    Friend WithEvents cboSelectIngredient As System.Windows.Forms.ComboBox
    Friend WithEvents _14vfu_t02DataSet As Kakefunn._14vfu_t02DataSet
    Friend WithEvents IngredientBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents IngredientTableAdapter1 As Kakefunn._14vfu_t02DataSetTableAdapters.IngredientTableAdapter
    Friend WithEvents lblSelectIngredient As System.Windows.Forms.Label

End Class
