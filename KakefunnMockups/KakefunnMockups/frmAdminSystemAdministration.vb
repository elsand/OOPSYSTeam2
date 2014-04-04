Public Class frmAdminSystemAdministration

    Private IsNewRecord As Boolean = True
    Private IsDirty As Boolean = False

    Protected Overrides Sub OnFormGetsForeground()

    End Sub

    Private Sub frmAdminSystemAdministration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With ddlEmployees
            .DataSource = DBM.Instance.employees.ToList()
            .DisplayMember = "name"
            .ValueMember = "id"
        End With

    End Sub

    Private Sub btnEditEmployee_Click(sender As Object, e As EventArgs) Handles btnEditEmployee.Click
        Dim em As employee = DirectCast(ddlEmployees.SelectedItem, employee)

        txtName.Text = em.name
        txtEmail.Text = em.email
        txtAddress.Text = em.address.address1
        txtZip.Text = em.address.zip1.zip1
        lblCity.Text = em.address.zip1.city

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

        IsNewRecord = False

    End Sub


    Private Sub btnSaveChanges_Click(sender As Object, e As EventArgs) Handles btnSaveChanges.Click

        If Not ValidSubmission() Then
            Exit Sub
        End If

        If IsNewRecord Then

            Dim em As employee = New employee()
            em.name = txtName.Text
            em.email = txtEmail.Text
            em.password = txtPassword.Text
            em.address = AddressHelper.GetAddress(txtZip.Text, txtAddress.Text)

            Dim pn As Integer
            Integer.TryParse(txtPhone.Text, pn)
            Dim p As phone = DBM.Instance.phones.Find(pn)
            If p Is Nothing Then
                p = New phone() With {.countryprefix = 47, .phonenumber = pn}
            End If

            em.phone = p

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
                DBM.Instance.employees.Add(em)
                DBM.Instance.SaveChanges()
            Catch ex As Entity.Validation.DbEntityValidationException
                ' TODO Vis feilmelding basert på feil som feilet
                Exit Sub
            Catch ex As Exception
                ' Todo Vis generell feilmelding
                Exit Sub
            End Try

            IsNewRecord = False

            MessageBox.Show("Oppføringen er lagret", "Suksess", MessageBoxButtons.OK, MessageBoxIcon.Information)



        End If
    End Sub

    Function ValidSubmission() As Boolean
        ' TODO: Implement checks
        Return True
    End Function
End Class
