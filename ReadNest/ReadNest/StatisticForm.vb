
Imports MySql.Data.MySqlClient
Public Class StatisticForm

    Private Sub StatisticForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadStatistics()

        ' Contoh jika Anda mengisi ComboBox secara programatik
        If cbProfile.Items.Count = 0 Then
            cbProfile.Items.Add("Profile")      ' Item di Indeks 0
            cbProfile.Items.Add("View Profile") ' Item di Indeks 1
            cbProfile.Items.Add("Logout")       ' Item di Indeks 2
        End If

        ' Set "Profile" sebagai item yang tampil pertama kali
        cbProfile.SelectedIndex = 0
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

        ' Simpan teks item yang dipilih karena SelectedIndex bisa berubah atau form bisa tertutup.
        Dim currentSelectedItemText As String
        If cbProfile.SelectedItem IsNot Nothing Then
            currentSelectedItemText = cbProfile.SelectedItem.ToString()
        Else
            ' Ini seharusnya tidak terjadi jika SelectedIndex bukan -1,
            ' tapi sebagai tindakan pencegahan.
            Exit Sub
        End If

        Select Case currentSelectedItemText
            Case "View Profile"
                NavigateToForm(New ProfileForm())
            ' Reset ke default ("Profile") akan ditangani oleh baris terakhir dari event handler ini.

            Case "Logout"
                Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin logout?",
                                                        "Konfirmasi Logout",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    ' Hapus session
                    SessionHelper.EndSession()
                    SessionHelper.ClearSavedSession()

                    ' isNavigating = True ' Pastikan variabel ini (jika masih digunakan) di-handle dengan benar
                    Dim loginForm As New LoginForm()
                    loginForm.Show()
                    Me.Close()
                    Exit Sub ' PENTING: Keluar dari Sub setelah Me.Close() untuk menghindari error.
                Else
                    ' Jika pengguna memilih "No" untuk logout, ComboBox akan direset
                    ' ke "Profile" oleh baris terakhir dari event handler ini.
                End If
                ' Case "Profile" 
                ' Jika "Profile" (item di indeks 0) dipilih oleh pengguna, event ini akan aktif.
                ' Select Case ini tidak akan menemukan match untuk "Profile" (kecuali Anda menambahkannya).
                ' Kemudian, baris terakhir akan menjalankan cbProfile.SelectedIndex = 0.
                ' Jika sudah 0, tidak ada perubahan dan event tidak akan terpicu lagi. Ini adalah perilaku yang diharapkan.
        End Select

        ' Reset ComboBox ke item default (indeks 0, yang seharusnya "Profile")
        ' setelah sebuah aksi selesai dan form tidak ditutup.
        ' Jika Me.Close() dipanggil (misalnya saat Logout), Exit Sub di atas akan mencegah baris ini berjalan
        ' pada form yang sudah tertutup.
        If cbProfile.Items.Count > 0 Then
            cbProfile.SelectedIndex = 0
        Else
            ' Jika karena suatu alasan ComboBox tidak memiliki item,
            ' Anda mungkin ingin menampilkan teks "Profile" secara manual.
            ' cbProfile.Text = "Profile" 
            ' Namun, ini biasanya tidak diperlukan jika item sudah di-setup dengan benar.
        End If
    End Sub

End Class