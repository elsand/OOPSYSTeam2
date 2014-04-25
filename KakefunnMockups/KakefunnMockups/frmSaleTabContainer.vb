''' <summary>
''' Form containing the tabcontrol for the sale aspect
''' </summary>
''' <remarks></remarks>
Public Class frmSaleTabContainer

    ''' <summary>
    ''' Set up the tab container
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub frmSaleTabContainer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateTabs(GetFormsForAspect("SALE"), tabSale)
    End Sub

    ''' <summary>
    ''' Handle search
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If txtSearchInformation.Text = "" Then
            MsgBox("Du må oppgi et søkeord")
            Exit Sub
        End If
        frmSuperBase.UpdateActionStatus("Søker ...")
        SearchHelper.SearchFreeText(txtSearchInformation.Text, True, True)
        frmSuperBase.UpdateActionStatus()
    End Sub

    ''' <summary>
    ''' Select all text when entering the search box for easy replacement
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub txtSearchInformation_Enter(sender As Object, e As EventArgs) Handles txtSearchInformation.Enter
        txtSearchInformation.SelectAll()
    End Sub

    Private Sub txtSearchInformation_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearchInformation.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSearch_Click(txtSearchInformation, e)
        End If
    End Sub
End Class
