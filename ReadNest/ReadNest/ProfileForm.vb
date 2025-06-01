Public Class ProfileForm

    Private Sub ProfileForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim db As New DBConnection()
        Dim dt As DataTable = db.GetUserProfile(SessionHelper.CurrentUser.UserId)

        If dt.Rows.Count > 0 Then
            ProfileUsername.Text = dt.Rows(0)("Username").ToString()
            ProfileEmail.Text = dt.Rows(0)("Email").ToString()
        Else
            MessageBox.Show("Data profil tidak ditemukan.")
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

    Private Sub BtnEditProfile_Click(sender As Object, e As EventArgs) Handles BtnEditProfile.Click
        Dim editForm As New EditProfile()
        editForm.UserId = SessionHelper.CurrentUser.UserId
        editForm.Show()
        Me.Close()
    End Sub

    Private Sub PbEditProfile_Click(sender As Object, e As EventArgs) Handles PbEditProfile.Click
        Dim editForm As New EditProfile()
        editForm.UserId = SessionHelper.CurrentUser.UserId
        editForm.Show()
        Me.Close()
    End Sub

    Private Sub lblWishlist_Click(sender As Object, e As EventArgs) Handles lblWishlist.Click
        Dim formBaru As New WishlistForm()
        formBaru.Show()
        Me.Hide()
    End Sub

    Private Sub pbWishlist_Click(sender As Object, e As EventArgs) Handles pbWishlist.Click
        Dim formBaru As New WishlistForm()
        formBaru.Show()
        Me.Hide()
    End Sub
End Class