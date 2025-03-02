Public Class CreateAccountForm
    Private Sub btnCreateAccount_Click(sender As Object, e As EventArgs) Handles btnCreateAccount.Click
        Dim email As String = txtCreateEmail.Text.Trim()
        Dim username As String = txtCreateUsername.Text.Trim()
        Dim password As String = txtCreatePassword.Text.Trim()
        Dim confirmPassword As String = txtConfirmPassword.Text.Trim()

        If email = "" Or username = "" Or password = "" Or confirmPassword = "" Then
            MessageBox.Show("Semua kolom harus diisi!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim emailRegex As New System.Text.RegularExpressions.Regex("^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$")
        If Not emailRegex.IsMatch(email) Then
            MessageBox.Show("Format email tidak valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If


        If password <> confirmPassword Then
            MessageBox.Show("Password dan Konfirmasi Password tidak cocok!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim db As New DBConnection()
        If db.TambahAkun(email, username, password) Then
            MessageBox.Show("Akun berhasil dibuat!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
            LoginForm.Show()
        Else
            MessageBox.Show("Gagal membuat akun. Mungkin email/username sudah terdaftar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub chkPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkPassword.CheckedChanged
        If chkPassword.Checked Then
            txtCreatePassword.UseSystemPasswordChar = False
            txtConfirmPassword.UseSystemPasswordChar = False
        Else
            txtCreatePassword.UseSystemPasswordChar = True
            txtConfirmPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub CreateAccountForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin keluar?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.No Then
            e.Cancel = True
        Else
            Environment.Exit(0)
        End If
    End Sub
End Class