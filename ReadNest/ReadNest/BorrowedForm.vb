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

            Using cmd As New MySqlCommand(query, db.BukaKoneksi())
                cmd.Parameters.AddWithValue("@search", $"%{searchTerm}%")

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.HasRows Then
                        reader.Read()

                        ' Tampilkan detail buku
                        selectedBookId = Convert.ToInt32(reader("BookId"))
                        selectedBookPhotoPath = If(IsDBNull(reader("PhotoPath")), "", reader("PhotoPath").ToString())
                        txtBBTitle.Text = reader("Title").ToString()
                        txtBBWriter.Text = reader("Author").ToString()
                        txtBBPages.Text = reader("Pages").ToString()

                        ' Ambil nama kategori berdasarkan CategoryId
                        Dim categoryName = GetCategoryName(Convert.ToInt32(reader("CategoryId")))
                        txtBBCategory.Text = categoryName

                        ' Tampilkan cover buku
                        LoadBookCover(selectedBookPhotoPath)
                    Else
                        MessageBox.Show("Buku tidak ditemukan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        ClearBookDetails()
                    End If
                End Using
            End Using
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

            Using cmd As New MySqlCommand(query, db.BukaKoneksi())
                cmd.Parameters.AddWithValue("@categoryId", categoryId)

                Dim result = cmd.ExecuteScalar()
                If result IsNot Nothing Then
                    Return result.ToString()
                End If
            End Using
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

            Using cmd As New MySqlCommand(query, db.BukaKoneksi())
                cmd.Parameters.AddWithValue("@bookId", selectedBookId)
                cmd.Parameters.AddWithValue("@borrowerName", txtBorrowerName.Text.Trim())
                cmd.Parameters.AddWithValue("@borrowDate", borrowDate)
                cmd.Parameters.AddWithValue("@returnDate", returnDate)

                Dim rowsAffected = cmd.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    ' Update status buku menjadi "Borrowed"
                    UpdateBookStatus(selectedBookId, "Borrowed")

                    MessageBox.Show("Peminjaman berhasil dicatat", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ClearForm()
                Else
                    MessageBox.Show("Gagal mencatat peminjaman", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show($"Gagal mencatat peminjaman: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub UpdateBookStatus(bookId As Integer, status As String)
        Try
            Dim db As New DBConnection()
            Dim query As String = "UPDATE books SET Status = @status WHERE BookId = @bookId"

            Using cmd As New MySqlCommand(query, db.BukaKoneksi())
                cmd.Parameters.AddWithValue("@status", status)
                cmd.Parameters.AddWithValue("@bookId", bookId)
                cmd.ExecuteNonQuery()
            End Using
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