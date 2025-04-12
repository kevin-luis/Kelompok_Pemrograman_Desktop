Public Class CategoryForm
    'Untuk Tombol navigasi di menu'
    Private Sub lblDiscover_Click(sender As Object, e As EventArgs) Handles lblDiscover.Click
        Dim formBaru As New MainForm()
        formBaru.Show()
        Me.Hide()
    End Sub

    Private Sub pbDiscover_Click(sender As Object, e As EventArgs) Handles pbDiscover.Click
        Dim formBaru As New MainForm()
        formBaru.Show()
        Me.Hide()
    End Sub

    Private Sub lblCategory_Click(sender As Object, e As EventArgs) Handles lblCategory.Click
        Dim formBaru As New CategoryForm()
        formBaru.Show()
        Me.Hide()
    End Sub

    Private Sub pbCategory_Click(sender As Object, e As EventArgs) Handles pbCategory.Click
        Dim formBaru As New CategoryForm()
        formBaru.Show()
        Me.Hide()
    End Sub

    Private Sub lblNotes_Click(sender As Object, e As EventArgs) Handles lblNotes.Click
        Dim formBaru As New Mynotes()
        formBaru.Show()
        Me.Hide()
    End Sub

    Private Sub pbNotes_Click(sender As Object, e As EventArgs) Handles pbNotes.Click
        Dim formBaru As New Mynotes()
        formBaru.Show()
        Me.Hide()
    End Sub

    Private Sub lblFavorite_Click(sender As Object, e As EventArgs) Handles lblFavorite.Click
        Dim formBaru As New FavoriteForm()
        formBaru.Show()
        Me.Hide()
    End Sub

    Private Sub pbFavorite_Click(sender As Object, e As EventArgs) Handles pbFavorite.Click
        Dim formBaru As New FavoriteForm()
        formBaru.Show()
        Me.Hide()
    End Sub

    Private Sub lblBB_Click(sender As Object, e As EventArgs) Handles lblBB.Click
        Dim formBaru As New BorrowForm()
        formBaru.Show()
        Me.Hide()
    End Sub

    Private Sub pbBB_Click(sender As Object, e As EventArgs) Handles pbBB.Click
        Dim formBaru As New BorrowForm()
        formBaru.Show()
        Me.Hide()
    End Sub

    Private Sub lblstatistic_Click(sender As Object, e As EventArgs) Handles lblstatistic.Click
        Dim formBaru As New StatisticForm()
        formBaru.Show()
        Me.Hide()
    End Sub

    Private Sub pbStatistic_Click(sender As Object, e As EventArgs) Handles pbStatistic.Click
        Dim formBaru As New StatisticForm()
        formBaru.Show()
        Me.Hide()
    End Sub

    Private Sub cbProfile_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProfile.SelectedIndexChanged
        ' Pastikan ada item yang dipilih dan bukan pemilihan pertama kali saat load
        If cbProfile.SelectedIndex = -1 Then Exit Sub

        ' Cek pilihan user
        Select Case cbProfile.SelectedItem.ToString()
            Case "View Profile"
                ' Buka form ProfileForm
                Dim profileForm As New ProfileForm()
                profileForm.Show()
                Me.Hide() ' Sembunyikan form saat ini (opsional)

            Case "Logout"
                ' Tampilkan pop-up konfirmasi logout
                Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin keluar?", "Konfirmasi Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If result = DialogResult.Yes Then
                    ' Jika klik Yes, kembali ke LoginForm
                    Dim loginForm As New LoginForm()
                    loginForm.Show()
                    Me.Hide() ' Tutup form saat ini
                End If
        End Select
    End Sub

    Private Sub btnBiography_Click(sender As Object, e As EventArgs) Handles btnBiography.Click
        OpenBookByCategory("Biography")
    End Sub

    Private Sub btnAcademy_Click(sender As Object, e As EventArgs) Handles btnAcademy.Click
        OpenBookByCategory("Academy")
    End Sub

    Private Sub btnTechno_Click(sender As Object, e As EventArgs) Handles btnTechno.Click
        OpenBookByCategory("Technology")
    End Sub

    Private Sub BtnRomance_Click(sender As Object, e As EventArgs) Handles BtnRomance.Click
        OpenBookByCategory("Romance")
    End Sub

    Private Sub btnNovel_Click(sender As Object, e As EventArgs) Handles btnNovel.Click
        OpenBookByCategory("Novel")
    End Sub

    Private Sub btnHistory_Click(sender As Object, e As EventArgs) Handles btnHistory.Click
        OpenBookByCategory("History")
    End Sub

    Private Sub btnComic_Click(sender As Object, e As EventArgs) Handles btnComic.Click
        OpenBookByCategory("Comic")
    End Sub

    Private Sub btnHorror_Click(sender As Object, e As EventArgs) Handles btnHorror.Click
        OpenBookByCategory("Horror")
    End Sub

    Private Sub OpenBookByCategory(categoryName As String)
        Dim form As New BookByCategory()
        form.SelectedCategory = categoryName
        form.Show()
        Me.Hide()
    End Sub

End Class