Imports System.IO

Public Class BookDetail
    Private _bookId As Integer
    Private _userId As Integer
    Private _isFavorite As Boolean = False

    Public Sub New(bookId As Integer)
        InitializeComponent()
        _bookId = bookId
        _userId = SessionHelper.CurrentUser.UserId ' Get user ID from session
    End Sub

    Private Sub BookDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadBookDetails()
    End Sub

    Private Sub LoadBookDetails()
        Try
            Dim db As New DBConnection()
            Dim bookRow As DataRow = db.GetBookDetail(_bookId)

            If bookRow IsNot Nothing Then
                ' Set judul dan penulis
                titleLabel.Text = bookRow("Title").ToString()
                authorLabel.Text = bookRow("Author").ToString()

                ' Set deskripsi
                If Not IsDBNull(bookRow("Description")) Then
                    descriptionContentLabel.Text = bookRow("Description").ToString()
                Else
                    descriptionContentLabel.Text = "No description available."
                End If

                ' Set kategori
                If Not IsDBNull(bookRow("CategoryName")) Then
                    languageContentLabel.Text = bookRow("CategoryName").ToString()
                Else
                    languageContentLabel.Text = "Uncategorized"
                End If

                ' Set jumlah halaman
                Dim pagesText As String = "Unknown"
                If Not IsDBNull(bookRow("Pages")) AndAlso Convert.ToInt32(bookRow("Pages")) > 0 Then
                    pagesText = $"{bookRow("Pages")} pages"
                    paperbackContentLabel.Text = pagesText
                End If

                ' Load cover image
                LoadCoverImage(If(IsDBNull(bookRow("PhotoPath")), "", bookRow("PhotoPath").ToString()))

                ' Set status buku untuk tombol pinjam
                If Not IsDBNull(bookRow("Status")) Then
                    Dim status As String = bookRow("Status").ToString()
                    borrowButton.Enabled = (status = "Available")
                    borrowButton.Text = If(status = "Available", "📤", "📚")
                End If

                ' Set status favorite
                If Not IsDBNull(bookRow("IsFavorite")) Then
                    _isFavorite = Convert.ToBoolean(bookRow("IsFavorite"))
                    UpdateFavoriteButtonIcon()
                End If
            Else
                MessageBox.Show("Buku tidak ditemukan.", "Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show($"Error memuat detail buku: {ex.Message}", "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadCoverImage(photoPath As String)
        ' Default placeholder
        bookCoverPictureBox.Image = Nothing
        bookCoverPictureBox.BackColor = Color.LightGray

        ' Gunakan fungsi dari DBConnection
        If Not String.IsNullOrEmpty(photoPath) Then
            Dim db As New DBConnection()
            Dim coverImage As Image = db.LoadBookCoverImage(photoPath)
            If coverImage IsNot Nothing Then
                bookCoverPictureBox.Image = coverImage
                bookCoverPictureBox.BackColor = Color.White
            End If
        End If
    End Sub

    Private Sub UpdateFavoriteButtonIcon()
        If _isFavorite Then
            favoriteButton.Text = "❤️"
        Else
            favoriteButton.Text = "🤍"
        End If
    End Sub

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Me.Close()
    End Sub

    Private Sub startReadingButton_Click(sender As Object, e As EventArgs) Handles startReadingButton.Click
        Dim readerForm As New BookReaderForm(_bookId, _userId)
        readerForm.Show()
    End Sub

    Private Sub bookmarkButton_Click(sender As Object, e As EventArgs) Handles bookmarkButton.Click
        ' Implementasi untuk menambahkan bookmark/wishlist
        Dim db As New DBConnection()

        If db.UpdateBookWishlist(_bookId) Then
            MessageBox.Show("Wishlist status changed successfully!", "Success",
                           MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub borrowButton_Click(sender As Object, e As EventArgs) Handles borrowButton.Click
        ' Implementasi untuk meminjam buku
        Dim db As New DBConnection()

        If db.BorrowBook(_bookId) Then
            MessageBox.Show("Book borrowed successfully!", "Success",
                           MessageBoxButtons.OK, MessageBoxIcon.Information)
            borrowButton.Enabled = False
            borrowButton.Text = "📚"
        End If
    End Sub

    Private Sub favoriteButton_Click(sender As Object, e As EventArgs) Handles favoriteButton.Click
        Dim db As New DBConnection()

        If db.UpdateBookFavorite(_bookId) Then
            _isFavorite = Not _isFavorite
            UpdateFavoriteButtonIcon()

            Dim message As String = If(_isFavorite,
                                  "The book was successfully added to your favorites!",
                                  "The book was removed from your favorites!")

            MessageBox.Show(message, "Success",
                           MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class