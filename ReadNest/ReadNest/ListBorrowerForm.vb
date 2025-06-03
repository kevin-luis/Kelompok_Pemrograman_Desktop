Imports System.IO
Imports MySql.Data.MySqlClient

Public Class ListBorrowerForm
    Private isNavigating As Boolean = False

    Private Sub ListBorrowerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StartPosition = FormStartPosition.CenterScreen

        ' Cek session
        If SessionHelper.CurrentUser Is Nothing Then
            MessageBox.Show("Anda harus login terlebih dahulu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            Dim loginForm As New LoginForm()
            loginForm.Show()
            Return
        End If

        LoadBorrowers()

        ' Contoh jika Anda mengisi ComboBox secara programatik
        If cbProfile.Items.Count = 0 Then
            cbProfile.Items.Add("Profile")      ' Item di Indeks 0
            cbProfile.Items.Add("View Profile") ' Item di Indeks 1
            cbProfile.Items.Add("Logout")       ' Item di Indeks 2
        End If

        ' Set "Profile" sebagai item yang tampil pertama kali
        cbProfile.SelectedIndex = 0
    End Sub

    Private Sub LoadBorrowers()
        Try
            flowBorrowers.SuspendLayout()
            flowBorrowers.Controls.Clear()

            Dim db As New DBConnection()
            Dim currentUserId As Integer = SessionHelper.CurrentUser.UserId
            Dim borrowers As DataTable = db.GetActiveBorrowers(currentUserId) ' Ganti ke GetActiveBorrowers

            If borrowers?.Rows.Count > 0 Then
                For Each row As DataRow In borrowers.Rows
                    Dim borrowerCard As New BorrowerCard(
                    Convert.ToInt32(row("BookId")),
                    row("Title").ToString(),
                    row("Author").ToString(),
                    If(IsDBNull(row("PhotoPath")), "", row("PhotoPath").ToString()),
                    Convert.ToInt32(row("BorrowerId")),
                    row("BorrowerName").ToString(),
                    Convert.ToDateTime(row("BorrowDate")),
                    If(IsDBNull(row("ReturnDate")), Nothing, row("ReturnDate")),
                    Convert.ToBoolean(row("IsReturned"))
                )
                    flowBorrowers.Controls.Add(borrowerCard)
                Next
            Else
                flowBorrowers.Controls.Add(CreateNoBorrowersLabel())
            End If
        Catch ex As Exception
            MessageBox.Show($"Gagal memuat data peminjam: {ex.Message}", "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            flowBorrowers.ResumeLayout()
        End Try
    End Sub

    Private Function CreateNoBorrowersLabel() As Label
        Return New Label() With {
        .Text = "Tidak ada buku yang sedang dipinjam",
        .AutoSize = True,
        .Font = New Font("Microsoft Sans Serif", 10.0F, FontStyle.Italic),
        .TextAlign = ContentAlignment.MiddleCenter,
        .Dock = DockStyle.Fill
    }
    End Function

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

    '============ FORM CLOSING ============'
    Private Sub ListBorrowerForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If isNavigating Then Return
        Application.Exit()
    End Sub

    '============ BORROWER CARD CLASS ============'
    Public Class BorrowerCard
        Inherits Panel

        Public Property BookId As Integer
        Public Property Title As String
        Public Property Author As String
        Public Property PhotoPath As String
        Public Property BorrowerId As Integer
        Public Property BorrowerName As String
        Public Property BorrowDate As DateTime
        Public Property ReturnDate As DateTime?
        Public Property IsReturned As Boolean

        Private WithEvents pbCover As New PictureBox()
        Private WithEvents lblTitle As New Label()
        Private WithEvents lblAuthor As New Label()
        Private WithEvents lblBorrower As New Label()
        Private WithEvents lblBorrowDate As New Label()
        Private WithEvents lblReturnStatus As New Label()
        Private WithEvents btnReturn As New Button()

        Public Sub New(bookId As Integer, title As String, author As String, photoPath As String,
                      borrowerId As Integer, borrowerName As String, borrowDate As DateTime,
                      returnDate As DateTime?, isReturned As Boolean)
            Me.BookId = bookId
            Me.Title = title
            Me.Author = author
            Me.PhotoPath = photoPath
            Me.BorrowerId = borrowerId
            Me.BorrowerName = borrowerName
            Me.BorrowDate = borrowDate
            Me.ReturnDate = returnDate
            Me.IsReturned = isReturned

            InitializeCard()
            LoadCoverImage()
        End Sub

        Private Sub InitializeCard()
            ' Panel settings
            Me.Size = New Size(200, 380)
            Me.BackColor = Color.White
            Me.BorderStyle = BorderStyle.FixedSingle
            Me.Margin = New Padding(10)
            Me.Cursor = Cursors.Default

            ' Cover image
            pbCover.Size = New Size(180, 150)
            pbCover.Location = New Point(10, 10)
            pbCover.SizeMode = PictureBoxSizeMode.StretchImage
            pbCover.BackColor = Color.LightGray

            ' Title label
            lblTitle.AutoSize = False
            lblTitle.Size = New Size(180, 40)
            lblTitle.Location = New Point(10, 165)
            lblTitle.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold)
            lblTitle.Text = Title

            ' Author label
            lblAuthor.AutoSize = False
            lblAuthor.Size = New Size(180, 20)
            lblAuthor.Location = New Point(10, 205)
            lblAuthor.Font = New Font("Microsoft Sans Serif", 8.25F)
            lblAuthor.Text = Author

            ' Borrower info
            lblBorrower.AutoSize = False
            lblBorrower.Size = New Size(180, 30)
            lblBorrower.Location = New Point(10, 230)
            lblBorrower.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold)
            lblBorrower.Text = "Peminjam: " & BorrowerName

            ' Borrow date
            lblBorrowDate.AutoSize = False
            lblBorrowDate.Size = New Size(180, 20)
            lblBorrowDate.Location = New Point(10, 260)
            lblBorrowDate.Font = New Font("Microsoft Sans Serif", 8.25F)
            lblBorrowDate.Text = "Pinjam: " & BorrowDate.ToString("dd/MM/yyyy")

            ' Return status
            lblReturnStatus.AutoSize = False
            lblReturnStatus.Size = New Size(180, 20)
            lblReturnStatus.Location = New Point(10, 280)
            lblReturnStatus.Font = New Font("Microsoft Sans Serif", 8.25F)

            If IsReturned Then
                lblReturnStatus.Text = "Dikembalikan"
                lblReturnStatus.ForeColor = Color.Green
            ElseIf ReturnDate.HasValue Then
                lblReturnStatus.Text = "Harus kembali: " & ReturnDate.Value.ToString("dd/MM/yyyy")
                lblReturnStatus.ForeColor = Color.Orange
            Else
                lblReturnStatus.Text = "Belum dikembalikan"
                lblReturnStatus.ForeColor = Color.Red
            End If

            ' Return button (hanya tampil jika belum dikembalikan)
            If Not IsReturned Then
                btnReturn.Text = "Return"
                btnReturn.Size = New Size(180, 30)
                btnReturn.Location = New Point(10, 310)
                btnReturn.BackColor = Color.LightGreen
                AddHandler btnReturn.Click, AddressOf ReturnBook_Click
                Me.Controls.Add(btnReturn)
            End If

            ' Add controls
            Me.Controls.Add(pbCover)
            Me.Controls.Add(lblTitle)
            Me.Controls.Add(lblAuthor)
            Me.Controls.Add(lblBorrower)
            Me.Controls.Add(lblBorrowDate)
            Me.Controls.Add(lblReturnStatus)
        End Sub

        Private Sub LoadCoverImage()
            ' Default placeholder
            pbCover.Image = Nothing
            pbCover.BackColor = Color.LightGray

            If Not String.IsNullOrEmpty(PhotoPath) Then
                Dim db As New DBConnection()
                Dim coverImage As Image = db.LoadBookCoverImage(PhotoPath)

                If coverImage IsNot Nothing Then
                    pbCover.Image = coverImage
                    pbCover.BackColor = Color.White
                End If
            End If
        End Sub

        Private Sub ReturnBook_Click(sender As Object, e As EventArgs)
            Dim result As DialogResult = MessageBox.Show(
                $"Tandai buku '{Title}' sebagai dikembalikan?",
                "Konfirmasi Pengembalian",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                Dim db As New DBConnection()
                Dim success As Boolean = db.MarkBookAsReturned(BorrowerId)

                If success Then
                    ' Hapus card dari tampilan
                    Dim parentFlow = TryCast(Me.Parent, FlowLayoutPanel)
                    If parentFlow IsNot Nothing Then
                        parentFlow.Controls.Remove(Me)
                    End If

                    MessageBox.Show("Buku berhasil dikembalikan", "Sukses",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Gagal memperbarui status buku", "Error",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End Sub

    End Class

End Class