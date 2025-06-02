
Imports MySql.Data.MySqlClient
Public Class StatisticForm

    Private Sub StatisticForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadStatistics()
    End Sub

    Private Sub LoadStatistics()
        Try
            Dim db As New DBConnection()
            ' Pastikan CurrentUser tidak null
            If SessionHelper.CurrentUser Is Nothing Then
                MessageBox.Show("User tidak terautentikasi", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim userId As Integer = SessionHelper.CurrentUser.UserId

            Dim stats As Dictionary(Of String, Integer) = db.GetUserStatistics(userId)

            ' Debug: Tampilkan nilai stats di console/output
            Console.WriteLine($"Read: {stats("read")}, Reading: {stats("reading")}, etc...")

            ' Pastikan TextBox benar-benar ada di form dengan nama yang tepat
            txtTotalBooksRead.Text = stats("read").ToString()
            txtTotalReadingTime.Text = $"{stats("reading").ToString()} menit"
            txtTotalBooksBorrowed.Text = stats("borrowed").ToString()
            txtTotalFavoriteBooks.Text = stats("favorite").ToString()

            ' Format average reading time
            Dim avgMinutes = stats("avgReadingTime")
            If avgMinutes >= 60 Then
                Dim hours = avgMinutes \ 60
                Dim minutes = avgMinutes Mod 60
                txtAvReadingTime.Text = $"{hours} jam {minutes} menit"
            Else
                txtAvReadingTime.Text = $"{avgMinutes} menit"
            End If
        Catch ex As Exception
            MessageBox.Show("Gagal memuat statistik: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private isNavigating As Boolean = False


    '============ NAVIGASI MENU ============'
    Private Sub NavigateToForm(form As Form)
        SessionHelper.UpdateActivity()
        isNavigating = True
        form.Show()
        Me.Hide()
    End Sub

    Private Sub lblDiscover_Click(sender As Object, e As EventArgs) Handles lblDiscover.Click, pbDiscover.Click
        NavigateToForm(New MainForm())
    End Sub

    Private Sub lblCategory_Click(sender As Object, e As EventArgs) Handles lblCategory.Click, pbCategory.Click
        NavigateToForm(New CategoryForm())
    End Sub

    Private Sub lblNotes_Click(sender As Object, e As EventArgs) Handles lblNotes.Click, pbNotes.Click
        NavigateToForm(New Mynotes())
    End Sub

    Private Sub lblFavorite_Click(sender As Object, e As EventArgs) Handles lblFavorite.Click, pbFavorite.Click
        NavigateToForm(New FavoriteForm())
    End Sub

    Private Sub lblBB_Click(sender As Object, e As EventArgs) Handles lblBB.Click, pbBB.Click
        NavigateToForm(New BorrowForm())
    End Sub

    Private Sub lblstatistic_Click(sender As Object, e As EventArgs) Handles lblstatistic.Click, pbStatistic.Click
        NavigateToForm(New StatisticForm())
    End Sub

    Private Sub lblWishlist_Click(sender As Object, e As EventArgs) Handles lblWishlist.Click
        NavigateToForm(New WishlistForm())
    End Sub
    '============ PROFILE MENU ============'
    Private Sub cbProfile_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProfile.SelectedIndexChanged
        If cbProfile.SelectedIndex = -1 Then Exit Sub

        Select Case cbProfile.SelectedItem.ToString()
            Case "View Profile"
                NavigateToForm(New ProfileForm())

            Case "Logout"
                Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin logout?",
                                                       "Konfirmasi Logout",
                                                       MessageBoxButtons.YesNo,
                                                       MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    ' Hapus session
                    SessionHelper.EndSession()
                    SessionHelper.ClearSavedSession()

                    isNavigating = True
                    Dim loginForm As New LoginForm()
                    loginForm.Show()
                    Me.Close()
                Else
                    cbProfile.SelectedIndex = 0
                End If
        End Select

        cbProfile.SelectedIndex = 0 ' Reset ke default setelah aksi
    End Sub

End Class