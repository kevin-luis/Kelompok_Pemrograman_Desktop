Imports System.IO
Imports MySql.Data.MySqlClient

Public Class MainForm
    Private isNavigating As Boolean = False
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
            Dim query As String = "SELECT BookId, Title, Author, PhotoPath FROM books " &
                                    "WHERE Title LIKE @search OR Author LIKE @search"

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

            ' Add controls
            Me.Controls.Add(pbCover)
            Me.Controls.Add(lblTitle)
            Me.Controls.Add(lblAuthor)

            ' Add click events
            AddHandler Me.Click, AddressOf BookCard_Click
            AddHandler pbCover.Click, AddressOf BookCard_Click
            AddHandler lblTitle.Click, AddressOf BookCard_Click
            AddHandler lblAuthor.Click, AddressOf BookCard_Click
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

End Class