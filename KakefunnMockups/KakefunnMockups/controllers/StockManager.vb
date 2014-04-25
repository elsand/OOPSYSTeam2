Imports System.Configuration

Public Class StockManager
    Public Shared Function getInStock(varenr As Integer, list As List(Of Kakefunn.Batch)) As Integer 'Finds amount of an ingredient in stock.
        Dim batches = From x In list Where x.Ingredient.id = varenr _
                      And x.registered IsNot Nothing Select x.unitCount
        If batches.Any Then
            Return batches.Sum()
        Else
            Return 0
        End If
    End Function

    ''' <summary>
    ''' Gets lowest and highest purchasing price, and also calculates average purchasing price from batches.
    ''' </summary>
    ''' <remarks></remarks>
    Public Shared Function getPurchasingPrice(varenr As Integer, type As String, list As List(Of Kakefunn.Batch)) As Double
        Dim batches = (From x In list _
                      Where x.Ingredient.id = varenr _
                      And x.unitPurchasingPrice.HasValue _
                      Select x.unitPurchasingPrice).ToList()

        If batches.Any Then
            If type = "high" Then
                Return batches.Max()
            ElseIf type = "low" Then
                Return batches.Min()
            ElseIf type = "avg" Then
                Return batches.Average()
            End If
        End If
        Return 0
    End Function

    Public Shared Function GetSellingPriceFor(ingredient As Ingredient) As Decimal
        Return GetSellingPriceFor(ingredient, 1)
    End Function

    Public Shared Function GetSellingPriceFor(ingredient As Ingredient, requestedUnitCount As Integer) As Decimal
        Return GetSellingPriceFor(ingredient, 1, Date.Today)
    End Function

    Public Shared Function GetSellingPriceFor(ingredient As Ingredient, requestedUnitCount As Integer, deliveryDate As Date) As Decimal
        Dim batchUnits As New List(Of Integer)
        Dim batchPrices As New List(Of Decimal)
        Dim unitsFound As Integer
        Dim markupAtDeliveryDate As Decimal

        Dim expiryGraceDaysString As String = ConfigurationManager.AppSettings.Get("sale.order.expiryGraceDays")
        Dim expiryGraceDays As Integer
        If Not Integer.TryParse(expiryGraceDaysString, expiryGraceDays) Then
            expiryGraceDays = 0
        End If

        Dim deliveryDateWithGraceDays As Date = deliveryDate.AddDays(expiryGraceDays)

        Console.WriteLine("-----------------")
        Console.WriteLine("GetSellingPrice(" & ingredient.name & ", " & requestedUnitCount & ", " & deliveryDate & ")")

        Dim batches = From b In DBM.Instance.Batches _
                      Where b.Ingredient.id = ingredient.id _
                      And b.deleted Is Nothing _
                      And (b.registered IsNot Nothing OrElse b.expected < deliveryDate) _
                      And (b.expires Is Nothing OrElse b.expires > deliveryDateWithGraceDays) _
                      And b.unitCount > 0 _
                      Order By b.registered _
                      Select b

        Console.WriteLine("Batches: " & batches.ToString)

        If batches.Count = 0 Then
            Console.WriteLine("Batches = Nothing")
            ' Check if we're expectingit to store at a later date
            Dim batch = (From b In DBM.Instance.Batches _
                      Where b.Ingredient.id = ingredient.id _
                      And b.expected > deliveryDate _
                      And b.unitCount > 0 _
                      Order By b.expected _
                      Select b).FirstOrDefault()

            If batch Is Nothing Then
                Throw New Exception(ingredient.name & " finnes ikke på lager, og ingen bestillinger ventes inn.")
            Else
                Throw New Exception(ingredient.name & " finnes ikke på lager innen " & deliveryDate & ". " & "Bestilling på " & batch.unitCount & _
                                    " " & ingredient.Unit.name & " forventes på lager " & batch.expected)
            End If

        End If

        markupAtDeliveryDate = GetIngredientMarkupForDate(ingredient, deliveryDate)
        Console.WriteLine("Markup: " & markupAtDeliveryDate)


        For Each b As Batch In batches

            Console.WriteLine("Checking batch " & b.id & ", has " & b.unitCount & " units at pp " & b.unitPurchasingPrice)

            ' Get the price for this batch
            batchPrices.Add(b.unitPurchasingPrice * (markupAtDeliveryDate / 100 + 1))
            ' Does this batch have enough units?
            If requestedUnitCount > b.unitCount + unitsFound Then
                ' No, we need it all
                Console.WriteLine("Not enough with this batch (requested: " & requestedUnitCount & ", batch: " & b.unitCount & ", already found: " & unitsFound)
                batchUnits.Add(b.unitCount)
            Else
                ' Yes, we don't need to pick from any more batches
                Console.WriteLine("Found enough in this batch")
                batchUnits.Add(requestedUnitCount)
            End If
            unitsFound = unitsFound + b.unitCount
            If unitsFound >= requestedUnitCount Then
                Exit For
            End If
        Next

        ' Do we have enough in stock at the delivery time?
        If unitsFound < requestedUnitCount Then
            ' We do not have enough at stock at the request time, return nothing to indicate error
            Console.WriteLine("Not enough in stock, only has " & unitsFound & " units, " & requestedUnitCount & " requested")
            Throw New Exception("Vi har bare " & unitsFound & " " & ingredient.Unit.name & " av " & ingredient.name & " på lager " & _
                                deliveryDate & ", trenger " & requestedUnitCount & " " & ingredient.Unit.name)

        End If

        ' Find average price
        Dim sum As Decimal = 0
        Dim count As Integer = 0
        For i As Integer = 0 To batchUnits.Count - 1
            sum = batchUnits(i) * batchPrices(i) + sum
            count = batchUnits(i) + count
        Next

        Console.WriteLine("sum: " & sum & ", count: " & count)

        Return sum / count

    End Function

    Public Shared Function GetIngredientMarkupForDate(ingredient As Ingredient, atDate As Date) As Decimal
        Return (From p In DBM.Instance.IngredientPrices _
               Where p.id = ingredient.id _
               And p.date < atDate
               Order By p.date Descending
               Select p.markUpPercentage).FirstOrDefault()
    End Function

    Public Shared Function getLocation(ByVal ingredientName As String) As List(Of Batch)
        Dim batchLoc = (From x In DBM.Instance.Batches Where x.Ingredient.name = ingredientName _
                        And x.registered.HasValue Order By x.unitCount Descending).ToList()
        Return batchLoc
    End Function

    Public Shared Function checkFreeLocation(ByVal row As Integer, shelf As Integer) As Boolean
        Dim batchLoc = (From x In DBM.Instance.Batches Where x.locationShelf = shelf _
                        And x.locationRow = row Select x).FirstOrDefault()
        If batchLoc Is Nothing Then
            Return True
        Else
            Return False
        End If
    End Function

    ''' <summary>
    ''' Reduces the inventory of the supplied ingredient by amount. Deliverydate must be supplied, as that will determine what batches
    ''' to pick from (with regards to expected delivery and expiry date). 
    ''' </summary>
    ''' <param name="ingredient"></param>
    ''' <param name="amount"></param>
    ''' <param name="deliveryDate"></param>
    ''' <remarks></remarks>
    Shared Sub ReduceInventory(ingredient As Ingredient, ByVal amount As Integer, deliveryDate As Date)

         Dim deliveryDateWithGraceDays As Date = deliveryDate.AddDays(StockManager.GetExpiryGraceDays())

        Dim batches = From b In DBM.Instance.Batches _
              Where b.Ingredient.id = ingredient.id _
              And b.deleted Is Nothing _
              And (b.registered IsNot Nothing OrElse b.expected < deliveryDate) _
              And (b.expires Is Nothing OrElse b.expires > deliveryDateWithGraceDays) _
              And b.unitCount > 0 _
              Order By b.registered _
              Select b

        For Each b As Batch In batches
            ' Enough in this batch?
            If b.unitCount >= amount Then
                b.unitCount = b.unitCount - amount
                amount = 0
                Exit For
            End If
            ' No, empty this batch and try the next one
            amount = amount - b.unitCount
            b.unitCount = 0
        Next

        ' At this point we assert that amount = 0. There is a race condition where two orders are placed at nearly the same time, where
        ' both are assuming that all the stock is available to them

        DBM.Instance.SaveChanges()

    End Sub

    ''' <summary>
    ''' Increases the inventory of the supplied ingredient by amount. Deliverydate must be supplied, as that will determine what batches
    ''' to add to from (with regards to expected delivery date). 
    ''' </summary>
    ''' <param name="ingredient"></param>
    ''' <param name="amount"></param>
    ''' <param name="deliveryDate"></param>
    ''' <remarks></remarks>
    Public Shared Sub IncreaseInventory(ingredient As Ingredient, ByVal amount As Integer, deliveryDate As Date)

        Dim deliveryDateWithGraceDays As Date = deliveryDate.AddDays(StockManager.GetExpiryGraceDays())

        ' Note that we reverse the order this time, so that we fill back the newest ones first
        Dim batches = From b In DBM.Instance.Batches _
              Where b.Ingredient.id = ingredient.id _
              And b.deleted Is Nothing _
              And (b.registered IsNot Nothing OrElse b.expected < deliveryDate) _
              And (b.expires Is Nothing OrElse b.expires > deliveryDateWithGraceDays) _
              Order By b.registered Descending _
              Select b

        For Each b As Batch In batches
            ' Enough "room" in this batch?
            If b.unitCount + amount <= b.origUnitCount Then
                ' Yes, fill it with amount and call it a day
                b.unitCount = b.unitCount + amount
                amount = 0
                Exit For
            End If
            ' No, we need to fill this one to the top and put the rest in the next batch
            amount = amount - b.origUnitCount - b.unitCount
            b.unitCount = b.origUnitCount
        Next

        ' At this point we assert that amount = 0. There is a race condition where two orders are placed at nearly the same time, where
        ' both are assuming that all the stock is available to them

        DBM.Instance.SaveChanges()
    End Sub

    Public Shared Function GetExpiryGraceDays() As Integer
        Dim expiryGraceDaysString As String = ConfigurationManager.AppSettings.Get("sale.order.expiryGraceDays")
        Dim expiryGraceDays As Integer
        If Not Integer.TryParse(expiryGraceDaysString, expiryGraceDays) Then
            expiryGraceDays = 0
        End If
        Return expiryGraceDays
    End Function

End Class
