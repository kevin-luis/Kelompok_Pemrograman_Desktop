Imports System.IO
Imports MySql.Data.MySqlClient

Public Class MainForm
    Private isNavigating As Boolean = False
    Private isDeleteMode As Boolean = False

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StartPosition = FormStartPosition.CenterScreen

        ' Cek session
        If SessionHelper.CurrentUser Is Nothing Then
            MessageBox.Show("Anda harus login terlebih dahulu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            Dim loginForm As New LoginForm()
            loginForm.Show()
            Return
        End If

        ' Setup timer untuk update session activity
        Dim activityTimer As New Timer With {.Interval = 300000} ' 5 menit
        AddHandler activityTimer.Tick, AddressOf UpdateSessionActivity
        activityTimer.Start()

        SetupProfileComboBox()
        LoadBooks()

        ' Contoh jika Anda mengisi ComboBox secara programatik
        If cbProfile.Items.Count = 0 Then
            cbProfile.Items.Add("Profile")      ' Item di Indeks 0
            cbProfile.Items.Add("View Profile") ' Item di Indeks 1
            cbProfile.Items.Add("Logout")       ' Item di Indeks 2
        End If

        ' Set "Profile" sebagai item yang tampil pertama kali
        cbProfile.SelectedIndex = 0
    End Sub

    Private Sub UpdateSessionActivity(sender As Object, e As EventArgs)
        SessionHelper.UpdateActivity()
    End Sub

    Private Sub SetupProfileComboBox()
        cbProfile.Items.Clear()
        cbProfile.Items.Add("Profile")
        cbProfile.Items.Add("View Profile")
        cbProfile.Items.Add("Logout")
        cbProfile.SelectedIndex = 0
    End Sub

    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If isNavigating Then Return
        Application.Exit()
    End Sub

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


    '============ BOOK MANAGEMENT ============'
    Private Sub btnAddNewBook_Click(sender As Object, e As EventArgs) Handles btnAddNewBook.Click
        Hide()

        Using addNewBookForm As New AddNewBookForm
            If addNewBookForm.ShowDialog = DialogResult.OK Then
                LoadBooks() ' Refresh daftar buku
            End If
        End Using
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        SearchBooks(txtSearchBook.Text.Trim())
    End Sub

    Private Sub LoadBooks()
        Try
            flowBooks.SuspendLayout()
            flowBooks.Controls.Clear()

            Dim db As New DBConnection()
            Dim currentUserId As Integer = SessionHelper.CurrentUser.UserId
            Dim books As DataTable = db.GetBooks(currentUserId)

            If books?.Rows.Count > 0 Then
                For Each row As DataRow In books.Rows
                    Dim bookCard As New BookCard(
                            Convert.ToInt32(row("BookId")),
                            row("Title").ToString(),
                            row("Author").ToString(),
                            If(IsDBNull(row("PhotoPath")), "", row("PhotoPath").ToString())
                        )
                    flowBooks.Controls.Add(bookCard)
                Next
            Else
                flowBooks.Controls.Add(CreateNoBooksLabel())
            End If
        Catch ex As Exception
            MessageBox.Show($"Gagal memuat buku: {ex.Message}", "Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            flowBooks.ResumeLayout()
        End Try
    End Sub

    Private Sub SearchBooks(searchTerm As String)
        If String.IsNullOrWhiteSpace(searchTerm) Then
            LoadBooks()
            Return
        End If

        Try
            flowBooks.SuspendLayout()
            flowBooks.Controls.Clear()

            Dim db As New DBConnection()
            Dim query As String = "
            SELECT b.BookId, b.Title, b.Author, b.PhotoPath
            FROM books b
            LEFT JOIN categories c ON b.CategoryId = c.CategoryId
            WHERE b.Title LIKE @search OR b.Author LIKE @search OR c.CategoryName LIKE @search
        "

            Dim parameters As New Dictionary(Of String, Object) From {
            {"@search", $"%{searchTerm}%"}
        }

            Dim books As DataTable = db.ExecuteQueryWithParams(query, parameters)

            If books IsNot Nothing AndAlso books.Rows.Count > 0 Then
                For Each row As DataRow In books.Rows
                    Dim bookCard As New BookCard(
                    Convert.ToInt32(row("BookId")),
                    row("Title").ToString(),
                    row("Author").ToString(),
                    If(IsDBNull(row("PhotoPath")), "", row("PhotoPath").ToString())
                )
                    flowBooks.Controls.Add(bookCard)
                Next
            Else
                flowBooks.Controls.Add(CreateNoResultsLabel(searchTerm))
            End If
        Catch ex As Exception
            MessageBox.Show($"Gagal mencari buku: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            flowBooks.ResumeLayout()
        End Try
    End Sub


    Private Function CreateNoBooksLabel() As Label
        Return New Label() With {
            .Text = "Tidak ada buku tersedia",
            .AutoSize = True,
            .Font = New Font("Microsoft Sans Serif", 10.0F, FontStyle.Italic),
            .TextAlign = ContentAlignment.MiddleCenter,
            .Dock = DockStyle.Fill
        }
    End Function

    Private Function CreateNoResultsLabel(searchTerm As String) As Label
        Return New Label() With {
            .Text = $"Tidak ditemukan hasil untuk '{searchTerm}'",
            .AutoSize = True,
            .Font = New Font("Microsoft Sans Serif", 10.0F, FontStyle.Italic),
            .TextAlign = ContentAlignment.MiddleCenter,
            .Dock = DockStyle.Fill
        }
    End Function

    '============ BOOK CARD CLASS ============'
    Public Class BookCard
        Inherits Panel

        Public Property BookId As Integer
        Public Property Title As String
        Public Property Author As String
        Public Property PhotoPath As String

        Private WithEvents pbCover As New PictureBox()
        Private WithEvents lblTitle As New Label()
        Private WithEvents lblAuthor As New Label()
        Private WithEvents btnDelete As New Button()  ' Tambahan untuk tombol delete

        Public Sub New(bookId As Integer, title As String, author As String, photoPath As String)
            Me.BookId = bookId
            Me.Title = title
            Me.Author = author
            Me.PhotoPath = photoPath

            InitializeCard()
            LoadCoverImage()
        End Sub

        Private Sub InitializeCard()
            ' Panel settings
            Me.Size = New Size(180, 300)
            Me.BackColor = Color.White
            Me.BorderStyle = BorderStyle.FixedSingle
            Me.Margin = New Padding(10)
            Me.Cursor = Cursors.Hand

            ' Cover image
            pbCover.Size = New Size(160, 200)
            pbCover.Location = New Point(10, 10)
            pbCover.SizeMode = PictureBoxSizeMode.StretchImage
            pbCover.BackColor = Color.LightGray
            pbCover.Cursor = Cursors.Hand

            ' Title label
            lblTitle.AutoSize = False
            lblTitle.Size = New Size(160, 40)
            lblTitle.Location = New Point(10, 215)
            lblTitle.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold)
            lblTitle.Text = Title
            lblTitle.Cursor = Cursors.Hand

            ' Author label
            lblAuthor.AutoSize = False
            lblAuthor.Size = New Size(160, 20)
            lblAuthor.Location = New Point(10, 255)
            lblAuthor.Font = New Font("Microsoft Sans Serif", 8.25F)
            lblAuthor.Text = Author
            lblAuthor.Cursor = Cursors.Hand

            ' Delete button (initially hidden)
            btnDelete.Size = New Size(30, 30)
            btnDelete.Location = New Point(145, 10)
            btnDelete.Text = "-"
            btnDelete.Font = New Font("Microsoft Sans Serif", 18.0F, FontStyle.Bold)
            btnDelete.BackColor = Color.Cyan
            btnDelete.ForeColor = Color.White
            btnDelete.FlatStyle = FlatStyle.Flat
            btnDelete.FlatAppearance.BorderSize = 0
            btnDelete.Cursor = Cursors.Hand
            btnDelete.Visible = False
            AddHandler btnDelete.Click, AddressOf DeleteButton_Click

            ' Add controls
            Me.Controls.Add(pbCover)
            Me.Controls.Add(lblTitle)
            Me.Controls.Add(lblAuthor)
            Me.Controls.Add(btnDelete)

            ' Pastikan tombol delete di atas semua kontrol
            btnDelete.BringToFront()

            ' Add click events
            AddHandler Me.Click, AddressOf BookCard_Click
            AddHandler pbCover.Click, AddressOf BookCard_Click
            AddHandler lblTitle.Click, AddressOf BookCard_Click
            AddHandler lblAuthor.Click, AddressOf BookCard_Click
        End Sub

        ' Method untuk mengatur mode delete
        Public Sub SetDeleteMode(deleteMode As Boolean)
            btnDelete.Visible = deleteMode

            ' Jika dalam mode delete, nonaktifkan click event untuk buka detail
            Me.Cursor = If(deleteMode, Cursors.Default, Cursors.Hand)
            pbCover.Cursor = If(deleteMode, Cursors.Default, Cursors.Hand)
            lblTitle.Cursor = If(deleteMode, Cursors.Default, Cursors.Hand)
            lblAuthor.Cursor = If(deleteMode, Cursors.Default, Cursors.Hand)
        End Sub

        ' Event handler untuk tombol delete
        Private Sub DeleteButton_Click(sender As Object, e As EventArgs)
            Dim result As DialogResult = MessageBox.Show(
            $"Apakah Anda yakin ingin menghapus buku '{Title}'?",
            "Konfirmasi Hapus Buku",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                Try
                    Dim db As New DBConnection()
                    ' Asumsi ada method DeleteBook di DBConnection
                    db.HapusBuku(BookId)

                    MessageBox.Show("Buku berhasil dihapus", "Sukses",
                               MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ' Refresh daftar buku di parent form
                    Dim parentForm As MainForm = DirectCast(Me.FindForm(), MainForm)
                    If parentForm IsNot Nothing Then
                        parentForm.LoadBooks()
                    End If

                Catch ex As Exception
                    MessageBox.Show($"Gagal menghapus buku: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End Sub

        Private Sub LoadCoverImage()
            ' Default placeholder
            pbCover.Image = Nothing
            pbCover.BackColor = Color.LightGray

            ' Gunakan fungsi dari DBConnection
            If Not String.IsNullOrEmpty(PhotoPath) Then
                Dim db As New DBConnection()
                Dim coverImage As Image = db.LoadBookCoverImage(PhotoPath)

                If coverImage IsNot Nothing Then
                    pbCover.Image = coverImage
                    pbCover.BackColor = Color.White
                End If
            End If
        End Sub

        Private Sub BookCard_Click(sender As Object, e As EventArgs)
            ' Jangan buka detail jika dalam mode delete
            If btnDelete.Visible Then Return

            SessionHelper.UpdateActivity()
            Dim bookDetailForm As New BookDetail(BookId)
            bookDetailForm.Show()

            ' Buat tutup mainformnya
            Dim parentForm = Me.FindForm()
            If parentForm IsNot Nothing Then
                parentForm.Hide()
            End If
        End Sub
    End Class

    Private Sub pbDeleteBook_Click(sender As Object, e As EventArgs) Handles pbDeleteBook.Click
        isDeleteMode = Not isDeleteMode

        ' Update tampilan semua book cards
        For Each control As Control In flowBooks.Controls
            If TypeOf control Is BookCard Then
                Dim bookCard As BookCard = DirectCast(control, BookCard)
                bookCard.SetDeleteMode(isDeleteMode)
            End If
        Next

        ' Update appearance tombol delete
        If isDeleteMode Then
            pbDeleteBook.BackColor = Color.Aquamarine
        Else
            pbDeleteBook.BackColor = SystemColors.Control
        End If
    End Sub

End Class