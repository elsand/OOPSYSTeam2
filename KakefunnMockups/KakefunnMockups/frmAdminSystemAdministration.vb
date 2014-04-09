Public Class frmAdminSystemAdministration

    Private IsNewRecord As Boolean = True
    Private currentRecord As Employee
    Private IsDirty As Boolean = False

    Protected Overrides Sub OnFormGetsForeground()
        If IsNewRecord Then
            UpdateActionStatus()
        Else
            UpdateActionStatus("Redigerer " & currentRecord.firstName & " " & currentRecord.lastName)
        End If
    End Sub

    Private Sub frmAdminSystemAdministration_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        UpdateEmployeeDDL()

        For Each c As Control In Me.Controls
            If c.GetType().Name = "TextBox" Then
                AddHandler CType(c, TextBox).TextChanged, Sub(s, ev) Me.IsDirty = True
            ElseIf c.GetType().Name = "CheckBox" Then
                AddHandler CType(c, CheckBox).CheckedChanged, Sub(s, ev) Me.IsDirty = True
            End If
        Next

        AddHandler txtZip.TextChanged, AddressOf Me.PopulateCityLabel
        lblCity.Text = ""

    End Sub

    Private Sub UpdateEmployeeDDL()

        Dim employees As DataTable = DBM.Instance.GetDataTableFromQuery("SELECT id, CONCAT(firstName, ' ', lastName) as fullName from Employee ORDER BY lastName")
        With ddlEmployees
            .DataSource = employees
            .DisplayMember = "fullName"
            .ValueMember = "id"
        End With
    End Sub

    Private Sub PopulateCityLabel()
        Dim z As Integer
        If txtZip.Text.Length <> 4 Then
            lblCity.Text = "UGYLDIG"
            Exit Sub
        End If

        Integer.TryParse(txtZip.Text, z)
        Dim theCity = (From x As Zip In DBM.Instance.Zips Where x.zip1 = z Select x.city).FirstOrDefault()
        If theCity Is Nothing Then
            theCity = "UGYLDIG"
        End If
        lblCity.Text = theCity.ToUpper()
    End Sub

    Private Sub btnEditEmployee_Click(sender As Object, e As EventArgs) Handles btnEditEmployee.Click

        If IsDirty AndAlso MsgBox("Du har ulagrede endringer. Vil du fortsette?", MsgBoxStyle.YesNo, "Ulagrede endringer") = MsgBoxResult.No Then
            Exit Sub
        End If

        UpdateActionStatus("Laster oppføring ...")

        Dim em As Employee = DBM.Instance.Employees.Find(ddlEmployees.SelectedValue)

        txtName.Text = em.firstName & " " & em.lastName
        txtEmail.Text = em.email
        txtPhone.Text = em.phone.phonenumber
        txtAddress.Text = em.address.address1
        txtZip.Text = em.Address.Zip.zip1
        lblCity.Text = em.Address.Zip.city
        txtPassword.Text = ""
        txtRepeatPassword.Text = ""

        cbAdmin.Checked = False
        cbSale.Checked = False
        cbLogistics.Checked = False

        For Each r As role In em.roles
            Select Case r.name
                Case "Admin"
                    cbAdmin.Checked = True
                Case "Sale"
                    cbSale.Checked = True
                Case "Logistics"
                    cbLogistics.Checked = True
            End Select
        Next

        currentRecord = em
        IsNewRecord = False

        lblPassword.Text = "Nytt passord"
        btnSaveChanges.Text = "Lagre endringer"

        Application.DoEvents()
        IsDirty = False

        UpdateActionStatus("Redigerer: " & em.firstName & " " & em.lastName)

    End Sub


    Private Sub btnSaveChanges_Click(sender As Object, e As EventArgs) Handles btnSaveChanges.Click

        If Not ValidSubmission() Then
            Exit Sub
        End If

        Dim em As Employee
        If IsNewRecord Then
            em = New Employee()
        Else
            em = currentRecord
        End If

        Dim fn As FullName = CustomerManager.GetFullName(txtName.Text)
        em.firstName = fn.firstName
        em.lastName = fn.lastName
        em.email = txtEmail.Text

        If IsNewRecord OrElse txtPassword.Text <> "" Then
            em.password = txtPassword.Text
        End If

        em.address = AddressHelper.GetAddress(txtZip.Text, txtAddress.Text)
        em.phone = PhoneHelper.GetPhone(txtPhone.Text)

        If cbAdmin.Checked Then
            em.roles.Add(DBM.Instance.Roles.Where(Function(x) x.name = "Admin").FirstOrDefault())
        End If

        If cbSale.Checked Then
            em.roles.Add(DBM.Instance.Roles.Where(Function(x) x.name = "Sale").FirstOrDefault())
        End If

        If cbLogistics.Checked Then
            em.roles.Add(DBM.Instance.Roles.Where(Function(x) x.name = "Logistics").FirstOrDefault())
        End If

        UpdateActionStatus("Lagrer ...")
        Try
            If IsNewRecord Then
                DBM.Instance.Employees.Add(em)
            End If
            DBM.Instance.SaveChanges()
        Catch ex As Entity.Validation.DbEntityValidationException
            ' This should not happen as ValidateSubmission() should cover all the bases
            MsgBox("Et eller flere feltene har mangler. Vennligst rett opp og prøv igjen")
            Exit Sub
        Catch ex As Exception
            ' If a database violation occured, or something else datbase-related (disconnected?) we end up here
            MsgBox("Det oppstod en feil i kommunikasjon med databasen. Vennligst prøv på nytt.")
            Exit Sub
        End Try

        IsNewRecord = False
        IsDirty = False
        currentRecord = em
        UpdateEmployeeDDL()

        UpdateActionStatus("Redigerer " & em.firstName & " " & em.lastName)
        MessageBox.Show("Oppføringen er lagret", "Suksess", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Function ValidSubmission() As Boolean
        If txtName.Text = "" Then
            MsgBox("Du må oppgi navn")
            Return False
        End If
        If cbAdmin.Checked = False AndAlso cbSale.Checked = False AndAlso cbLogistics.Checked = False Then
            MsgBox("Du må oppgi minst én rolle")
            Return False
        End If
        If txtPhone.Text = "" Then
            MsgBox("Du må oppgi et telefonnummer")
            Return False
        End If
        If txtEmail.Text = "" Then
            MsgBox("Du må oppgi en e-postadresse")
            Return False
        End If
        If txtAddress.Text = "" Then
            MsgBox("Du må oppgi en addresse")
            Return False
        End If
        If IsNewRecord AndAlso txtPassword.Text = "" Then
            MsgBox("Du må oppgi et passord")
            Return False
        End If
        If txtPassword.Text <> txtRepeatPassword.Text Then
            MsgBox("Du må oppgi det samme passordet på nytt")
            Return False
        End If
        If txtZip.Text = "" OrElse lblCity.Text = "UGYLDIG" OrElse lblCity.Text = "" Then
            MsgBox("Du må oppgi et gyldig postnummer")
            Return False
        End If
        Return True
    End Function

    Private Sub btnNewUser_Click(sender As Object, e As EventArgs) Handles btnNewUser.Click
        If IsDirty AndAlso MsgBox("Du har ulagrede endringer. Vil du fortsette?", MsgBoxStyle.YesNo, "Ulagrede endringer") = MsgBoxResult.No Then
            Exit Sub
        End If

        For Each c As Control In Me.Controls
            If c.GetType().Name = "TextBox" Then
                CType(c, TextBox).Text = ""
            ElseIf c.GetType().Name = "CheckBox" Then
                CType(c, CheckBox).Checked = False
            End If
        Next
        lblCity.Text = ""
        IsNewRecord = True
        IsDirty = False
        currentRecord = Nothing
        lblPassword.Text = "Passord"
        btnSaveChanges.Text = "Lagre ny bruker"

        UpdateActionStatus()
    End Sub
End Class
