Public Class OrderTotals
    Property totalPriceExVat As Decimal = 0
    Property totalVat As Decimal = 0
    Property totalDiscount As Decimal = 0
    Property shipping As Decimal = 0
    ReadOnly Property totalToPay As Decimal
        Get
            Return totalPriceExVat + totalVat + shipping - totalDiscount
        End Get
    End Property

End Class
