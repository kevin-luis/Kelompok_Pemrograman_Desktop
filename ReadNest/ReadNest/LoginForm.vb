﻿Imports System.ComponentModel.DataAnnotations

Public Class LoginForm
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
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
                MainForm.Show()
            Else
                MessageBox.Show("Username atau Password salah", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If



    End Sub

    Private Sub linkCreateAccount_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkCreateAccount.LinkClicked
        Me.Hide()
        CreateAccountForm.Show()
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
            Environment.Exit(0)
        End If
    End Sub


End Class