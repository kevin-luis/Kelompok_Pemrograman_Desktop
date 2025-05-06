Imports System.IO
Imports MySql.Data.MySqlClient

Public Class BorrowForm

    Private selectedBookId As Integer = -1
    Private selectedBookPhotoPath As String = ""

    Private Sub BorrowForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Kosongkan detail buku saat form pertama kali dimuat
        ClearBookDetails()
        ' Set default image untuk picturebox
    End Sub

    Private Sub ClearBookDetails()
        txtBBTitle.Text = ""
        txtBBWriter.Text = ""
        txtBBCategory.Text = ""
        txtBBPages.Text = ""
        selectedBookId = -1
        selectedBookPhotoPath = ""
    End Sub

    Private Sub SearchBook_Click(sender As Object, e As EventArgs) Handles SearchBook.Click
        Dim searchTerm = txtSearchBook.Text.Trim()

        If String.IsNullOrEmpty(searchTerm) Then
            MessageBox.Show("Masukkan kata kunci pencarian", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Dim db As New DBConnection()
            Dim query As String = "SELECT BookId, Title, Author, CategoryId, Pages, PhotoPath FROM books " &
                                  "WHERE Title LIKE @search OR Author LIKE @search LIMIT 1"

            Dim parameters As New Dictionary(Of String, Object) From {
                {"@search", $"%{searchTerm}%"}
            }

            Dim result = db.ExecuteQueryWithParams(query, parameters)

            If result IsNot Nothing AndAlso result.Rows.Count > 0 Then
                Dim row = result.Rows(0)

                ' Tampilkan detail buku
                selectedBookId = Convert.ToInt32(row("BookId"))
                selectedBookPhotoPath = If(IsDBNull(row("PhotoPath")), "", row("PhotoPath").ToString())
                txtBBTitle.Text = row("Title").ToString()
                txtBBWriter.Text = row("Author").ToString()
                txtBBPages.Text = row("Pages").ToString()

                ' Ambil nama kategori berdasarkan CategoryId
                Dim categoryName = GetCategoryName(Convert.ToInt32(row("CategoryId")))
                txtBBCategory.Text = categoryName

                ' Tampilkan cover buku
                LoadBookCover(selectedBookPhotoPath)
            Else
                MessageBox.Show("Buku tidak ditemukan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ClearBookDetails()
            End If
        Catch ex As Exception
            MessageBox.Show($"Gagal mencari buku: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadBookCover(photoPath As String)
        Try
            Dim db As New DBConnection()
            Dim coverImage As Image = db.LoadBookCoverImage(photoPath)

            If coverImage IsNot Nothing Then
                pictureboxborrower.Image = coverImage
                pictureboxborrower.SizeMode = PictureBoxSizeMode.Zoom
            End If
        Catch ex As Exception
            MessageBox.Show($"Gagal memuat cover buku: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function GetCategoryName(categoryId As Integer) As String
        Try
            Dim db As New DBConnection()
            Dim query As String = "SELECT CategoryName FROM categories WHERE CategoryId = @categoryId"
            Dim parameters As New Dictionary(Of String, Object) From {
                {"@categoryId", categoryId}
            }

            Dim result = db.ExecuteQueryWithParams(query, parameters)

            If result IsNot Nothing AndAlso result.Rows.Count > 0 Then
                Return result.Rows(0)("CategoryName").ToString()
            End If
        Catch ex As Exception
            MessageBox.Show($"Gagal mengambil kategori: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return "Unknown Category"
    End Function

    Private Sub BtnAddBorrowerBook_Click(sender As Object, e As EventArgs) Handles BtnAddBorrowerBook.Click
        ' Validasi input
        If selectedBookId = -1 Then
            MessageBox.Show("Pilih buku terlebih dahulu", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If String.IsNullOrEmpty(txtBorrowerName.Text.Trim()) Then
            MessageBox.Show("Masukkan nama peminjam", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Buat tanggal peminjaman (hari ini) dan pengembalian (2 hari dari sekarang)
        Dim borrowDate = DateTime.Now
        Dim returnDate = borrowDate.AddDays(2) ' Default 2 hari

        Try
            Dim db As New DBConnection()
            Dim query As String = "INSERT INTO borrowers (BookId, BorrowerName, BorrowDate, ReturnDate, IsReturned) " &
                                 "VALUES (@bookId, @borrowerName, @borrowDate, @returnDate, 0)"

            Dim parameters As New Dictionary(Of String, Object) From {
                {"@bookId", selectedBookId},
                {"@borrowerName", txtBorrowerName.Text.Trim()},
                {"@borrowDate", borrowDate},
                {"@returnDate", returnDate}
            }

            Dim rowsAffected = db.ExecuteNonQueryWithParams(query, parameters)

            If rowsAffected > 0 Then
                ' Update status buku menjadi "Borrowed"
                UpdateBookStatus(selectedBookId, "Borrowed")

                MessageBox.Show("Peminjaman berhasil dicatat", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ClearForm()
            Else
                MessageBox.Show("Gagal mencatat peminjaman", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show($"Gagal mencatat peminjaman: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub UpdateBookStatus(bookId As Integer, status As String)
        Try
            Dim db As New DBConnection()
            Dim query As String = "UPDATE books SET Status = @status WHERE BookId = @bookId"

            Dim parameters As New Dictionary(Of String, Object) From {
                {"@status", status},
                {"@bookId", bookId}
            }

            db.ExecuteNonQueryWithParams(query, parameters)
        Catch ex As Exception
            MessageBox.Show($"Gagal mengupdate status buku: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ClearForm()
        txtBorrowerName.Text = ""
        ClearBookDetails()
        txtSearchBook.Text = ""
    End Sub

    ' Event handler untuk menampilkan gambar cover buku ketika picturebox diklik
    Private Sub pictureboxborrower_Click(sender As Object, e As EventArgs) Handles pictureboxborrower.Click
        If Not String.IsNullOrEmpty(selectedBookPhotoPath) Then
            Try
                Dim db As New DBConnection()
                Dim coverImage As Image = db.LoadBookCoverImage(selectedBookPhotoPath)

                If coverImage IsNot Nothing Then
                    ' Buat form baru untuk menampilkan gambar dalam ukuran penuh
                    Dim imageViewer As New Form()
                    imageViewer.Text = "Cover Buku - " & txtBBTitle.Text
                    imageViewer.StartPosition = FormStartPosition.CenterScreen
                    imageViewer.WindowState = FormWindowState.Normal
                    imageViewer.FormBorderStyle = FormBorderStyle.FixedDialog
                    imageViewer.MaximizeBox = False

                    Dim fullSizePic As New PictureBox()
                    fullSizePic.Dock = DockStyle.Fill
                    fullSizePic.Image = coverImage
                    fullSizePic.SizeMode = PictureBoxSizeMode.Zoom

                    imageViewer.Controls.Add(fullSizePic)
                    imageViewer.Size = New Size(600, 800)
                    imageViewer.ShowDialog()
                End If
            Catch ex As Exception
                MessageBox.Show($"Gagal memuat gambar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
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
        Dim formBaru As New StatisticForm
        formBaru.Show()
        Hide()
    End Sub

    Private Sub lblWishlist_Click(sender As Object, e As EventArgs) Handles lblWishlist.Click
        Dim formBaru As New WishlistForm()
        formBaru.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim formBaru As New WishlistForm()
        formBaru.Show()
        Me.Hide()
    End Sub
End Class