Public Class frmAdminSystemAdministration

    Private IsNewRecord As Boolean = True
    Private currentRecord As Employee

    Public Overrides Sub OnFormGetsForeground()
        If IsNewRecord Then
            UpdateActionStatus()
        Else
            UpdateActionStatus("Redigerer " & currentRecord.firstName & " " & currentRecord.lastName)
        End If
    End Sub

    Private Sub frmAdminSystemAdministration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateEmployeeDDL()
        FormHelper.SetupDirtyTracking(Me)
        AddressHelper.SetupAutoCityFill(txtZip, lblCity)
    End Sub

    Private Sub UpdateEmployeeDDL()

        Dim employees As DataTable = DBM.Instance.GetDataTableFromQuery("SELECT id, CONCAT(firstName, ' ', lastName) as fullName from Employee ORDER BY lastName")
        With ddlEmployees
            .DataSource = employees
            .DisplayMember = "fullName"
            .ValueMember = "id"
        End With
    End Sub

    Private Sub btnEditEmployee_Click(sender As Object, e As EventArgs) Handles btnEditEmployee.Click
        If isDirty AndAlso MsgBox("Du har ulagrede endringer. Vil du fortsette?", MsgBoxStyle.YesNo, "Ulagrede endringer") = MsgBoxResult.No Then
            Exit Sub
        End If

        UpdateActionStatus("Laster oppføring ...")

        Dim em As Employee = DBM.Instance.Employees.Find(ddlEmployees.SelectedValue)

        txtName.Text = em.firstName & " " & em.lastName
        txtEmail.Text = em.email
        txtPhone.Text = em.Phone.phonenumber
        txtAddress.Text = em.Address.address1
        txtZip.Text = em.Address.Zip.zip1.ToString("D4")
        lblCity.Text = em.Address.Zip.city
        txtPassword.Text = ""
        txtRepeatPassword.Text = ""

        cbAdmin.Checked = False
        cbSale.Checked = False
        cbLogistics.Checked = False

        For Each r As Role In em.Roles
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
            em = DBM.Instance.Employees.Create(Of Employee)()
        Else
            em = currentRecord
        End If

        Dim name As NameHelper = New NameHelper(txtName.Text)
        em.firstName = name.firstName
        em.lastName = name.lastName
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

        If IsNewRecord Then
            KakefunnEvent.saveSystemEvent("Systembrukere", "Opprettet ny systembruker: " & em.fullName)
        Else
            KakefunnEvent.saveSystemEvent("Systembrukere", "Oppdatert systembruker: " & em.fullName)
        End If

        IsNewRecord = False
        IsDirty = False
        currentRecord = em
        UpdateEmployeeDDL()

        UpdateActionStatus("Redigerer " & em.firstName & " " & em.lastName)
        MessageBox.Show("Oppføringen er lagret", "Suksess", MessageBoxButtons.OK, MessageBoxIcon.Information)
        resetForm()
        lblCity.Text = ""
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

    ''' <summary>
    ''' Resets form after editing existing or saving new users.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub resetForm()
        For Each c As Control In grpSystemAdministration.Controls
            Select Case c.GetType().Name
                Case "TextBox"
                    CType(c, TextBox).Text = ""
                Case "CheckBox"
                    CType(c, CheckBox).Checked = False
                Case "NumericTextbox"
                    CType(c, NumericTextbox).Text = ""
            End Select
        Next
    End Sub

    Private Sub btnNewUser_Click(sender As Object, e As EventArgs) Handles btnNewUser.Click
        MsgBox(isDirty)
        If isDirty AndAlso MsgBox("Du har ulagrede endringer. Vil du fortsette?", MsgBoxStyle.YesNo, "Ulagrede endringer") = MsgBoxResult.No Then
            Exit Sub
        End If

        resetForm()
        lblCity.Text = ""
        IsNewRecord = True
        currentRecord = Nothing
        lblPassword.Text = "Passord"
        btnSaveChanges.Text = "Lagre ny bruker"
        isDirty = False
        UpdateActionStatus()
    End Sub
End Class
