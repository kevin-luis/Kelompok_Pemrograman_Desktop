Imports System.ComponentModel.DataAnnotations
Imports Microsoft.VisualBasic.ApplicationServices

Public Class LoginForm
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
        ' Tidak perlu cek auto-login di sini lagi karena sudah dihandle di Program.vb
    End Sub

    Private Sub btnLoginaAccount_Click(sender As Object, e As EventArgs) Handles btnLoginaAccount.Click
        Dim username = txtloginusername.Text.Trim()
        Dim password = txtloginpassword.Text.Trim()

        ' Validasi input
        If String.IsNullOrEmpty(username) OrElse String.IsNullOrEmpty(password) Then
            MessageBox.Show("Silahkan masukkan username dan password!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim db As New DBConnection
        Dim userData = db.CekLogin(username, password)

        If userData IsNot Nothing AndAlso userData.Rows.Count > 0 Then
            Dim userId = Convert.ToInt32(userData.Rows(0)("UserId"))
            ' Ambil username asli dari database jika perlu untuk case-sensitive comparison,
            ' atau gunakan username input jika case-insensitivity sudah cukup.
            ' Untuk contoh ini, kita gunakan username input yang sudah di-trim.
            Dim actualUsername As String = userData.Rows(0)("Username").ToString() ' Asumsi ada kolom Username di userData

            Dim sessionId = db.CreatePersistentSession(userId)

            If Not String.IsNullOrEmpty(sessionId) Then
                SessionHelper.CurrentUser = New User With {
                    .UserId = userId,
                    .Username = actualUsername ' Simpan username asli dari DB
                }
                SessionHelper.SessionToken = sessionId

                My.Settings.UserId = userId
                My.Settings.SessionToken = sessionId
                My.Settings.Save()

                MessageBox.Show("Login berhasil! Session akan tetap aktif selama 1 bulan.", "Informasi",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' --- MODIFIKASI DIMULAI DI SINI ---
                ' Cek apakah username adalah "Admin" atau "admin"
                If actualUsername.Equals("Admin", StringComparison.OrdinalIgnoreCase) Then
                    ' Jika username adalah Admin (case-insensitive)
                    Dim adminForm As New AdminForm() ' Pastikan Anda sudah memiliki AdminForm
                    adminForm.Show()
                    Me.Hide()
                Else
                    ' Jika bukan Admin, buka MainForm seperti biasa
                    Dim mainForm As New MainForm()
                    mainForm.Show()
                    Me.Hide()
                End If
                ' --- MODIFIKASI SELESAI ---

            Else
                MessageBox.Show("Gagal membuat session", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Username atau password salah", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub linkCreateAccount_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkCreateAccount.LinkClicked
        Dim formBaru As New CreateAccountForm
        formBaru.Show()
        Hide()
    End Sub

    Private Sub chkPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkPassword.CheckedChanged
        If chkPassword.Checked Then
            txtloginpassword.UseSystemPasswordChar = False
        Else
            txtloginpassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub LoginForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin keluar?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.No Then
            e.Cancel = True
        Else
            Environment.Exit(1)
        End If
    End Sub
End Class