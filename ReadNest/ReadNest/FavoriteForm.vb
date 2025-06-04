Imports MySql.Data.MySqlClient

Public Class FavoriteForm

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
    Private Sub FavoriteForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadFavoriteBooks()

        ' Contoh jika Anda mengisi ComboBox secara programatik
        If cbProfile.Items.Count = 0 Then
            cbProfile.Items.Add("Profile")      ' Item di Indeks 0
            cbProfile.Items.Add("View Profile") ' Item di Indeks 1
            cbProfile.Items.Add("Logout")       ' Item di Indeks 2
        End If

        ' Set "Profile" sebagai item yang tampil pertama kali
        cbProfile.SelectedIndex = 0
    End Sub
    Private Sub FavoriteForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If isNavigating Then Return
        Application.Exit()
    End Sub
    Private Sub btnSearchFavoriteBook_Click(sender As Object, e As EventArgs) Handles btnSearchFavoriteBook.Click
        LoadFavoriteBooks(txtSearchFavoriteBook.Text.Trim())
    End Sub

    Private Sub txtSearchFavoriteBook_TextChanged(sender As Object, e As EventArgs) Handles txtSearchFavoriteBook.TextChanged
        LoadFavoriteBooks(txtSearchFavoriteBook.Text.Trim())
    End Sub

    Private Sub LoadFavoriteBooks(Optional searchTerm As String = "")
        Try
            flowBookFavorite.SuspendLayout()
            flowBookFavorite.Controls.Clear()

            Dim db As New DBConnection()
            Dim currentUserId As Integer = SessionHelper.CurrentUser.UserId
            Dim query As String = "SELECT BookId, Title, Author, PhotoPath FROM books WHERE IsFavorite = 1 AND UserId = @userId"

            Dim parameters As New Dictionary(Of String, Object)()
            parameters.Add("@userId", currentUserId)

            If Not String.IsNullOrWhiteSpace(searchTerm) Then
                query &= " AND (Title LIKE @search OR Author LIKE @search)"
                parameters.Add("@search", $"%{searchTerm}%")
            End If

            Dim books = db.ExecuteQueryWithParams(query, parameters)

            If books IsNot Nothing AndAlso books.Rows.Count > 0 Then
                For Each row As DataRow In books.Rows
                    Dim bookCard As New MainForm.BookCard(
                    Convert.ToInt32(row("BookId")),
                    row("Title").ToString(),
                    row("Author").ToString(),
                    If(IsDBNull(row("PhotoPath")), "", row("PhotoPath").ToString())
                )
                    flowBookFavorite.Controls.Add(bookCard)
                Next
            Else
                flowBookFavorite.Controls.Add(New Label() With {
                .Text = "Tidak ada buku favorit ditemukan.",
                .AutoSize = True,
                .Font = New Font("Segoe UI", 10.0F, FontStyle.Italic),
                .Dock = DockStyle.Fill
            })
            End If
        Catch ex As Exception
            MessageBox.Show("Gagal memuat buku favorit: " & ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            flowBookFavorite.ResumeLayout()
        End Try
    End Sub

End Class