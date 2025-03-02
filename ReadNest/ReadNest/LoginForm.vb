Imports System.ComponentModel.DataAnnotations

Public Class LoginForm
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnLoginaAccount_Click(sender As Object, e As EventArgs) Handles btnLoginaAccount.Click
        Dim db As New DBConnection()
        Dim username As String = txtloginusername.Text.Trim()
        Dim password As String = txtloginpassword.Text.Trim()

        If username = "" Or password = "" Then
            MsgBox("Silahkan Masukkan Username atau Password!")
        Else
            If db.CekLogin(username, password) Then
                MessageBox.Show("Login Berhasil!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Hide()
                Form1.Show()
            Else
                MessageBox.Show("Username atau Password salah", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If



    End Sub
End Class