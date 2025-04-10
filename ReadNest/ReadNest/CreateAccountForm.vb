Imports MySql.Data.MySqlClient

Public Class CreateAccountForm
    Private Sub btnCreateAccount_Click(sender As Object, e As EventArgs) Handles btnCreateAccount.Click
        Dim email As String = txtCreateEmail.Text.Trim()
        Dim username As String = txtCreateUsername.Text.Trim()
        Dim password As String = txtCreatePassword.Text.Trim()
        Dim confirmPassword As String = txtConfirmPassword.Text.Trim()

        ' Validasi input kosong
        If String.IsNullOrEmpty(email) OrElse
           String.IsNullOrEmpty(username) OrElse
           String.IsNullOrEmpty(password) OrElse
           String.IsNullOrEmpty(confirmPassword) Then
            MessageBox.Show("Semua kolom harus diisi!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Validasi format email
        Dim emailRegex As New System.Text.RegularExpressions.Regex("^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$")
        If Not emailRegex.IsMatch(email) Then
            MessageBox.Show("Format email tidak valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Validasi kesesuaian password
        If password <> confirmPassword Then
            MessageBox.Show("Password dan Konfirmasi Password tidak cocok!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Pemeriksaan database
        Dim db As New DBConnection()
        Try
            ' Cek duplikasi email
            If db.CekEmailTerdaftar(email) Then
                MessageBox.Show("Email sudah terdaftar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Cek duplikasi username
            If db.CekUsernameTerdaftar(username) Then
                MessageBox.Show("Username sudah terdaftar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Proses registrasi
            If db.TambahAkun(email, username, password) Then
                MessageBox.Show("Akun berhasil dibuat!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Hide()
                LoginForm.Show()
            Else
                MessageBox.Show("Gagal membuat akun!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Pindahkan fungsi berikut ke kelas DBConnection
    Private Sub chkPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkPassword.CheckedChanged
        txtCreatePassword.UseSystemPasswordChar = Not chkPassword.Checked
        txtConfirmPassword.UseSystemPasswordChar = Not chkPassword.Checked
    End Sub

    Private Sub CreateAccountForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin keluar?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.No Then
            e.Cancel = True
        Else
            LoginForm.Show()
        End If
    End Sub

End Class