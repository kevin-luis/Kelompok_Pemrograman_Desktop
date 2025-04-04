Imports System.IO

Public Class BookDetail
    Private _bookId As Integer

    ' Constructor untuk menerima BookId
    Public Sub New(bookId As Integer)
        ' This call is required by the designer.
        InitializeComponent()

        ' Simpan BookId
        _bookId = bookId
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
                End If
                paperbackContentLabel.Text = $"paper textured, full colour, {pagesText}"

                ' Load cover image
                LoadCoverImage(If(IsDBNull(bookRow("PhotoPath")), "", bookRow("PhotoPath").ToString()))

                ' Set status buku untuk tombol pinjam
                If Not IsDBNull(bookRow("Status")) Then
                    Dim status As String = bookRow("Status").ToString()
                    borrowButton.Enabled = (status = "Available")
                    borrowButton.Text = If(status = "Available", "📤", "📚")
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

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Me.Close()
    End Sub

    Private Sub startReadingButton_Click(sender As Object, e As EventArgs) Handles startReadingButton.Click
        ' Implementasi untuk membuka reader buku
        MessageBox.Show("Reading functionality not implemented yet.", "Information",
                       MessageBoxButtons.OK, MessageBoxIcon.Information)
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

    Private Sub downloadButton_Click(sender As Object, e As EventArgs) Handles downloadButton.Click
        ' Implementasi untuk mengunduh buku
        MessageBox.Show("Download functionality not implemented yet.", "Information",
                       MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class