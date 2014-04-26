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
        Me.grpAdminReports = New System.Windows.Forms.GroupBox()
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
        Me.grpAdminReports.SuspendLayout()
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
        Me.cboSelectReportForm.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboSelectReportForm.FormattingEnabled = True
        Me.cboSelectReportForm.Items.AddRange(New Object() {"Velg rapport", "Salgsrapport", "Ingrediens siste år", "Forventet salg neste mnd", "Hendelseslogg"})
        Me.cboSelectReportForm.Location = New System.Drawing.Point(102, 13)
        Me.cboSelectReportForm.Name = "cboSelectReportForm"
        Me.cboSelectReportForm.Size = New System.Drawing.Size(87, 21)
        Me.cboSelectReportForm.TabIndex = 8
        '
        'lblSelectReportForm
        '
        Me.lblSelectReportForm.AutoSize = True
        Me.lblSelectReportForm.Location = New System.Drawing.Point(6, 16)
        Me.lblSelectReportForm.Name = "lblSelectReportForm"
        Me.lblSelectReportForm.Size = New System.Drawing.Size(90, 13)
        Me.lblSelectReportForm.TabIndex = 8
        Me.lblSelectReportForm.Text = "Velg type rapport:"
        '
        'btnGetReport
        '
        Me.btnGetReport.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGetReport.Location = New System.Drawing.Point(517, 11)
        Me.btnGetReport.Name = "btnGetReport"
        Me.btnGetReport.Size = New System.Drawing.Size(157, 23)
        Me.btnGetReport.TabIndex = 11
        Me.btnGetReport.Text = "Hent rapport"
        Me.btnGetReport.UseVisualStyleBackColor = True
        '
        'rptReports
        '
        Me.rptReports.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "IngredientsPrMonth"
        ReportDataSource1.Value = Me.LastYearMonthSaleBindingSource
        ReportDataSource2.Name = "IngredientHistory"
        ReportDataSource2.Value = Me.IngredientHistoryBindingSource
        Me.rptReports.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rptReports.LocalReport.DataSources.Add(ReportDataSource2)
        Me.rptReports.LocalReport.ReportEmbeddedResource = "Kakefunn.IngredientMonth.rdlc"
        Me.rptReports.Location = New System.Drawing.Point(9, 40)
        Me.rptReports.MinimumSize = New System.Drawing.Size(665, 273)
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
        Me.rptReports.Size = New System.Drawing.Size(665, 294)
        Me.rptReports.TabIndex = 12
        '
        'dtpTimePeriodFrom
        '
        Me.dtpTimePeriodFrom.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpTimePeriodFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTimePeriodFrom.Location = New System.Drawing.Point(292, 14)
        Me.dtpTimePeriodFrom.Name = "dtpTimePeriodFrom"
        Me.dtpTimePeriodFrom.Size = New System.Drawing.Size(96, 20)
        Me.dtpTimePeriodFrom.TabIndex = 11
        '
        'dtpTimePeriodTo
        '
        Me.dtpTimePeriodTo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpTimePeriodTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTimePeriodTo.Location = New System.Drawing.Point(415, 14)
        Me.dtpTimePeriodTo.Name = "dtpTimePeriodTo"
        Me.dtpTimePeriodTo.Size = New System.Drawing.Size(96, 20)
        Me.dtpTimePeriodTo.TabIndex = 10
        '
        'lblTimePeriod
        '
        Me.lblTimePeriod.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTimePeriod.AutoSize = True
        Me.lblTimePeriod.Location = New System.Drawing.Point(207, 16)
        Me.lblTimePeriod.Name = "lblTimePeriod"
        Me.lblTimePeriod.Size = New System.Drawing.Size(72, 13)
        Me.lblTimePeriod.TabIndex = 13
        Me.lblTimePeriod.Text = "for tidsrommet"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(395, 16)
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
        Me.cboSelectIngredient.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboSelectIngredient.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboSelectIngredient.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboSelectIngredient.DataSource = Me.IngredientBindingSource1
        Me.cboSelectIngredient.DisplayMember = "name"
        Me.cboSelectIngredient.FormattingEnabled = True
        Me.cboSelectIngredient.Location = New System.Drawing.Point(292, 13)
        Me.cboSelectIngredient.Name = "cboSelectIngredient"
        Me.cboSelectIngredient.Size = New System.Drawing.Size(219, 21)
        Me.cboSelectIngredient.TabIndex = 9
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
        Me.lblSelectIngredient.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSelectIngredient.AutoSize = True
        Me.lblSelectIngredient.Location = New System.Drawing.Point(207, 16)
        Me.lblSelectIngredient.Name = "lblSelectIngredient"
        Me.lblSelectIngredient.Size = New System.Drawing.Size(79, 13)
        Me.lblSelectIngredient.TabIndex = 16
        Me.lblSelectIngredient.Text = "Velg ingrediens"
        '
        'grpAdminReports
        '
        Me.grpAdminReports.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpAdminReports.Controls.Add(Me.lblSelectReportForm)
        Me.grpAdminReports.Controls.Add(Me.cboSelectIngredient)
        Me.grpAdminReports.Controls.Add(Me.lblSelectIngredient)
        Me.grpAdminReports.Controls.Add(Me.cboSelectReportForm)
        Me.grpAdminReports.Controls.Add(Me.btnGetReport)
        Me.grpAdminReports.Controls.Add(Me.Label3)
        Me.grpAdminReports.Controls.Add(Me.rptReports)
        Me.grpAdminReports.Controls.Add(Me.lblTimePeriod)
        Me.grpAdminReports.Controls.Add(Me.dtpTimePeriodFrom)
        Me.grpAdminReports.Controls.Add(Me.dtpTimePeriodTo)
        Me.grpAdminReports.Location = New System.Drawing.Point(12, 12)
        Me.grpAdminReports.Name = "grpAdminReports"
        Me.grpAdminReports.Size = New System.Drawing.Size(687, 340)
        Me.grpAdminReports.TabIndex = 17
        Me.grpAdminReports.TabStop = False
        '
        'frmAdminReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(723, 405)
        Me.Controls.Add(Me.grpAdminReports)
        Me.MinimumSize = New System.Drawing.Size(739, 444)
        Me.Name = "frmAdminReports"
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
        Me.grpAdminReports.ResumeLayout(False)
        Me.grpAdminReports.PerformLayout()
        Me.ResumeLayout(False)

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
    Friend WithEvents grpAdminReports As System.Windows.Forms.GroupBox

End Class
