Imports System.Drawing.Printing.PrinterSettings
Imports System
Imports System.IO
Imports System.Drawing
Imports System.Drawing.Printing


Public Class PackingListHelper

    Private printFont As Font
    Private streamToPrint As StreamReader
    Private Buffer As String
    Private Head As String
    Private Body As String
    Private Footer As String



    Public Shared Sub CreatePackingList(ByVal o As Order)



        Dim css = "<style type='text/css'>.main{border:1px solid #aaa; width:200mm; height:280mm; margin-left:auto;margin-right:auto}.table{display: table; margin-bottom:10mm}.row{display: table-row}.cell{display: table-cell; padding: 4mm 10mm 2mm 10mm}</style>"
                  

        Dim html = "<html >" & _
                    "<head>" & _
                    "<title>Pakkseddel</title>" & _
                    "<meta charset='UTF-8'>" & css & _
                    "<meta name='viewport' content='width=device-width, initial-scale=1.0'>" & _
                    "</head>" & _
                    "<body onload='window.print()'>"

        'add the ordervalues 

        html = html & "<div class='main'><h2>Pakkseddel</h2>" & _
          "<div class='table'> " & _
          "<div style='display: table-row'>" & _
              "<div class='cell'> Ordre: " & o.id & _
              "</div>" & _
               "<div class='cell'> Ordredato: " & Format(o.created, "yyyy-MM-dd") & _
              "</div>" & _
              "<div class='cell'> " & _
              "</div>" & _
               "<div class='cell'> " & _
              "</div>" & _
               "<div class='cell'> Leveres til: <br>" & o.Customer.firstName & " " & o.Customer.lastName & "<br>" & o.Address.address1 & "<br>" & o.Address.Zip.zip1.ToString("D4") & " " & o.Address.Zip.city & _
              "</div>" & _
              "</div>" & _
               "<div style='display: table-row'>" & _
              "<div class='cell'>" & _
              "</div>" & _
               "<div class='cell'>" & _
              "</div>" & _
               "<div class='cell'>" & _
              "</div>" & _
               "<div class='cell'>" & _
              "</div>" & _
              "<div class='cell'>Selger: <br>" & NameHelper.getFullName(o.Employee) & _
              "</div>" & _
              "</div>" & _
              "</div><hr>"


        ' add the orderlines

        html = html & " <div class='table'>"

        For Each ol As OrderLine In o.OrderLines
            html = html & "<div style='display:table-row'>" & _
                          "<div class='cell'>" & ol.Ingredient.name & "</div> " & _
                          "<div class='cell'>" & ol.amount & "</div> " & _
                          "<div class='cell'>" & ol.Ingredient.Unit.name & "</div> " & _
                          "<div class='cell'>" & IngredientHelper.getIngredientLocation(ol) & "</div> " & _
                          "<div class='cell'><input type='checkbox'/></div> " & _
                          "</div>"



        Next
        html = html & "</div>" 'end of table... 

        html = html & _
            "</div><div style='text-align:center'>copyright&copy;Kakefunn.no</div></body>" & _
            "</html>"



        Dim mydocpath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)

        Dim filename = "pakkliste_" & o.id & ".html"

        Dim path = mydocpath & "\" & filename



        If File.Exists(path) = False Then
            File.WriteAllText(path, html)


        Else
            MsgBox("Pakkseddelen eksisterer")

        End If


        'This does not work.. using web prowser... 

        ''Process.Start(LocalSystemHelper.getDefaultBrowser(), path)

        Dim u = New Uri(path)


        frmDialogPackingListPreview.wbrPackingListView.Url = u


        frmDialogPackingListPreview.ShowDialog()





        'Dim d As New DocumentPrinter()

        ' d.printDocument(path)








    End Sub

    Public Function CreatePackingLists(ByVal orders As List(Of Order)) As Boolean
        Dim ret = False
        For Each o As Order In orders
            Me.createAPackingList(o)

        Next

        Dim html = Me.Head & Me.Body & Me.Footer

        Dim mydocpath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)

        Dim filename = "pakklister_" & Format(DateTime.Now, "yyyy_mm_dd_h_m_s") & ".html"

        Dim path = mydocpath & "\" & filename



        If File.Exists(path) = False Then
            File.WriteAllText(path, html)


        Else
            MsgBox("Pakkseddelen eksisterer")

        End If


        'This does not work.. using web prowser... 

        ''Process.Start(LocalSystemHelper.getDefaultBrowser(), path)

        Dim u = New Uri(path)


        frmDialogPackingListPreview.wbrPackingListView.Url = u


        frmDialogPackingListPreview.ShowDialog()


        Return ret


    End Function


    Public Sub init()
        Dim css = "<style type='text/css'>.main{border:1px solid #aaa; width:200mm; height:280mm; margin-left:auto;margin-right:auto; padding:10px} table{margin-bottom:10mm; border:collapse; width:100%}.row{display: table-row} td{padding: 4mm 10mm 2mm 10mm; vertical-align:top} footer{width:100%;text-align:center;page-break-after:always;}</style>"

        Me.Head = "<html >" & _
                    "<head>" & _
                    "<title>Pakkseddel</title>" & _
                    "<meta charset='UTF-8'>" & css & _
                    "<meta name='viewport' content='width=device-width, initial-scale=1.0'>" & _
                    "</head>" & _
                    "<body onload='window.print()'>"


    End Sub

    Public Sub createAPackingList(ByVal o As Order)


        Me.Buffer = "<div class='main'><h2>Pakkseddel</h2>" & _
          "<table> " & _
          "<tr>" & _
              "<td> Ordre: " & o.id & _
              "</td>" & _
               "<td> Ordredato:<br> " & Format(o.created, "yyyy-MM-dd") & _
              "</td>" & _
              "<td> Leveringsdato:<br> " & Format(o.deliveryDate, "yyyy-MM-dd") & _
              "</td>" & _
               "<td> Leveres til:<br>" & o.Customer.firstName & " " & o.Customer.lastName & "<br>" & o.Address.address1 & "<br>" & o.Address.Zip.zip1.ToString("D4") & " " & o.Address.Zip.city & _
              "</td>" & _
              "</tr>" & _
               "<tr>" & _
              "<td>Leveringsmetode:<br> " & o.DeliveryMethod.name & _
              "</td>" & _
               "<td>" & _
              "</td>" & _
               "<td>" & _
              "</td>" & _
              "<td>Selger: <br>" & NameHelper.getFullName(o.Employee) & _
              "</td>" & _
              "</tr>" & _
              "</table><hr>"


        ' add the orderlines

        Me.Buffer = Me.Buffer & " <table>"

        For Each ol As OrderLine In o.OrderLines
            Me.Buffer = Me.Buffer & "<tr>" & _
                          "<td>" & ol.Ingredient.name & "</td> " & _
                          "<td>" & ol.amount & "</td> " & _
                          "<td>" & ol.Ingredient.Unit.name & "</td> " & _
                          "<td>" & IngredientHelper.getIngredientLocation(ol) & "</td> " & _
                          "<td><input type='checkbox'/></td> " & _
                          "</tr>"



        Next
        Me.Buffer = Me.Buffer & "</table>" 'end of table... 

        Me.Buffer = Me.Buffer & _
            "</div><footer>copyright&copy;Kakefunn.no</footer>"


        Me.Body &= Me.Buffer

        Me.Buffer = ""

    End Sub

   









    Public Sub New()
        Me.init()


    End Sub



End Class
