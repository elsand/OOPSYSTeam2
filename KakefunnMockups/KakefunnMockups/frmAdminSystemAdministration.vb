Public Class frmAdminSystemAdministration

    Private IsNewRecord As Boolean = True
    Private currentRecord As employee
    Private IsDirty As Boolean = False


    Private Sub frmAdminSystemAdministration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With ddlEmployees
            .DataSource = DBM.Instance.employees.ToList()
            .DisplayMember = "name"
            .ValueMember = "id"
        End With

        For Each c As Control In Me.Controls
            If c.GetType().Name = "TextBox" Then
                AddHandler CType(c, TextBox).TextChanged, Sub(s, ev) Me.IsDirty = True
            ElseIf c.GetType().Name = "CheckBox" Then
                AddHandler CType(c, CheckBox).CheckedChanged, Sub(s, ev) Me.IsDirty = True
            End If
        Next
    End Sub

    Private Sub btnEditEmployee_Click(sender As Object, e As EventArgs) Handles btnEditEmployee.Click

        If IsDirty AndAlso MsgBox("Du har ulagrede endringer. Vil du fortsette?", MsgBoxStyle.YesNo, "Ulagrede endringer") = MsgBoxResult.No Then
            Exit Sub
        End If

        Dim em As employee = DirectCast(ddlEmployees.SelectedItem, employee)

        txtName.Text = em.name
        txtEmail.Text = em.email
        txtPhone.Text = em.phone.phonenumber
        txtAddress.Text = em.address.address1
        txtZip.Text = em.address.zip1.zip1
        lblCity.Text = em.address.zip1.city
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

        Application.DoEvents()
        IsDirty = False

    End Sub


    Private Sub btnSaveChanges_Click(sender As Object, e As EventArgs) Handles btnSaveChanges.Click

        If Not ValidSubmission() Then
            Exit Sub
        End If

        Dim em As employee
        If IsNewRecord Then
            em = New employee()
        Else
            em = currentRecord
        End If

        em.name = txtName.Text
        em.email = txtEmail.Text

        If IsNewRecord OrElse txtPassword.Text <> "" Then
            em.password = txtPassword.Text
        End If

        em.address = AddressHelper.GetAddress(txtZip.Text, txtAddress.Text)
        em.phone = PhoneHelper.GetPhone(txtPhone.Text)

        If cbAdmin.Checked Then
            em.roles.Add(DBM.Instance.roles.Where(Function(x) x.name = "Admin").FirstOrDefault())
        End If

        If cbSale.Checked Then
            em.roles.Add(DBM.Instance.roles.Where(Function(x) x.name = "Sale").FirstOrDefault())
        End If

        If cbLogistics.Checked Then
            em.roles.Add(DBM.Instance.roles.Where(Function(x) x.name = "Logistics").FirstOrDefault())
        End If

        Try
            If IsNewRecord Then
                DBM.Instance.employees.Add(em)
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
        IsNewRecord = True
        IsDirty = False
        currentRecord = Nothing
        lblPassword.Text = "Passord"
    End Sub
End Class
