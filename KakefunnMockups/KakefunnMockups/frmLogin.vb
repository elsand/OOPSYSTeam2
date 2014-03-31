﻿
Public Class frmLogin

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim db = New Db(), z As zip, a As address, c As customer

        ' gjør oppslag på postnr
        z = db.zips.Find(8904)

        ' Finnes?
        If z Is Nothing Then
            ' Nei, opprett
            z = New zip()
            z.zip1 = 8904
            z.city = "Brønnøysund"

            ' kan også skrives som 
            ' db.zips.Add(new zip With { .zip1 = 8904, .city = "Brønnøysund" })
            db.zips.Add(z)
        End If

        a = db.addresses.Where(Function(x) x.name = "Bjørn Langfors" And x.address1 = "Terneveien 27").FirstOrDefault()
        If a Is Nothing Then
            db.addresses.Add(New address With {.name = "Bjørn Langfors", .address1 = "Terneveien 27", .zip1 = z})
        End If

        c = New customer()
        c.isPrivate = False
        c.name = "Bjørn Langfors"
        c.phone = "9281113"
        c.email = "bjorn@langfors.no"
        c.address = a
        c.customerType = New customerType With {.name = "nok en type "}
        c.discountPlan = New discountPlan With {.name = "nok en rabattplan", .percentage = 0}
        c.note = "Merk at vi oppretter en ny customerType og discountPlan i databasen automatisk"
        ' Ikke funnet ut hvordan man setter denne best ... New Date(), New DateTime(),  New MySql.Data.Types.MySqlDateTime() funker ikke som ventet
        c.created = "2014-04-01 12:12:12"
        c.modfied = c.created
        db.customers.Add(c)
        db.SaveChanges()

    End Sub
End Class
