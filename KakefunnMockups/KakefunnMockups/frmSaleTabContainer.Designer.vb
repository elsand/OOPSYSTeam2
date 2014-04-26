<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSaleTabContainer
    Inherits Kakefunn.frmSuperTabContainer

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
        Me.tabSale = New System.Windows.Forms.TabControl()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.lblSearchInformation = New System.Windows.Forms.Label()
        Me.txtSearchInformation = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'tabSale
        '
        Me.tabSale.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabSale.Location = New System.Drawing.Point(0, 56)
        Me.tabSale.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.tabSale.Name = "tabSale"
        Me.tabSale.SelectedIndex = 0
        Me.tabSale.Size = New System.Drawing.Size(770, 512)
        Me.tabSale.TabIndex = 4
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(411, 30)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(61, 23)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "Søk"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'lblSearchInformation
        '
        Me.lblSearchInformation.AutoSize = True
        Me.lblSearchInformation.Location = New System.Drawing.Point(5, 35)
        Me.lblSearchInformation.Name = "lblSearchInformation"
        Me.lblSearchInformation.Size = New System.Drawing.Size(230, 13)
        Me.lblSearchInformation.TabIndex = 1
        Me.lblSearchInformation.Text = "Søk etter kundenr/ordrenr/navn/epost/telefon:"
        '
        'txtSearchInformation
        '
        Me.txtSearchInformation.Location = New System.Drawing.Point(241, 32)
        Me.txtSearchInformation.Name = "txtSearchInformation"
        Me.txtSearchInformation.Size = New System.Drawing.Size(160, 20)
        Me.txtSearchInformation.TabIndex = 0
        '
        'frmSaleTabContainer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(770, 558)
        Me.Controls.Add(Me.lblSearchInformation)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.tabSale)
        Me.Controls.Add(Me.txtSearchInformation)
        Me.Name = "frmSaleTabContainer"
        Me.Controls.SetChildIndex(Me.txtSearchInformation, 0)
        Me.Controls.SetChildIndex(Me.tabSale, 0)
        Me.Controls.SetChildIndex(Me.btnSearch, 0)
        Me.Controls.SetChildIndex(Me.lblSearchInformation, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tabSale As System.Windows.Forms.TabControl
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents lblSearchInformation As System.Windows.Forms.Label
    Friend WithEvents txtSearchInformation As System.Windows.Forms.TextBox

End Class
