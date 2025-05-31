Public Class EditProfile

    Public Property UserId As Integer

    Private Sub EditProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Ambil data user berdasarkan UserId
        Dim db As New DBConnection()
        Dim dt As DataTable = db.GetUserProfile(UserId)

        If dt.Rows.Count > 0 Then
            EditProfileUsername.Text = dt.Rows(0)("Username").ToString()
            EditEmail.Text = dt.Rows(0)("Email").ToString()
        End If
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Dim username As String = EditProfileUsername.Text.Trim()
        Dim email As String = EditEmail.Text.Trim()

        ' Validasi input
        If username = "" OrElse email = "" Then
            MessageBox.Show("Username dan Email tidak boleh kosong.")
            Return
        End If

        ' Simpan ke database
        Dim db As New DBConnection()
        Dim success As Boolean = db.UpdateUserProfile(UserId, username, email)

        If success Then
            MessageBox.Show("Profil berhasil diperbarui.")
            ' Kembali ke ProfileForm
            Dim profileForm As New ProfileForm()
            profileForm.Show()
            Me.Close()
        Else
            MessageBox.Show("Gagal memperbarui profil.")
        End If
    End Sub


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

End Class