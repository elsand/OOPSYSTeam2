Public Class frmLogisticsTabContainer
    ''' <summary>
    ''' Displays forms for the logistics role in the tab container.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub frmLogisticsTabContainer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateTabs(GetFormsForAspect("LOGISTICS"), tabLogistics)
    End Sub
End Class
