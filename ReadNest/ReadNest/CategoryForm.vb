Imports System.IO
Imports MySql.Data.MySqlClient

Public Class CategoryForm

    Private Sub CategoryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StartPosition = FormStartPosition.CenterScreen
        LoadCategories()
        LoadBooksByCategory() ' Load semua buku pertama kali
    End Sub

    Public Function GetBooksByCategory(categoryId As Integer, searchTerm As String) As DataTable
        Dim dt As New DataTable()

        Dim query As String = "SELECT BookId, Title, Author, PhotoPath FROM books WHERE " &
                      "(@categoryId = 0 OR CategoryId = @categoryId) AND " &
                      "(Title LIKE @search OR Author LIKE @search)"

        Dim db As New DBConnection()
        Using conn As MySqlConnection = db.BukaKoneksi()
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@categoryId", categoryId)
                cmd.Parameters.AddWithValue("@search", $"%{searchTerm}%")

                Using adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dt)
                End Using
            End Using
        End Using

        Return dt
    End Function
    Private Sub LoadBooksByCategory()
        Try
            flowCategory.SuspendLayout()
            flowCategory.Controls.Clear()

            ' Ambil category ID yang dipilih dengan penanganan lebih robust
            Dim selectedCategoryId As Integer = 0
            If cbSelectCategory.SelectedValue IsNot Nothing Then
                If IsNumeric(cbSelectCategory.SelectedValue) Then
                    selectedCategoryId = Convert.ToInt32(cbSelectCategory.SelectedValue)
                ElseIf TypeOf cbSelectCategory.SelectedValue Is DataRowView Then
                    Dim drv As DataRowView = CType(cbSelectCategory.SelectedValue, DataRowView)
                    selectedCategoryId = Convert.ToInt32(drv("CategoryId"))
                End If
            End If

            Dim searchTerm As String = txtSearchBook.Text.Trim()
            Dim db As New DBConnection()
            Dim books As DataTable = db.GetBooksByCategory(selectedCategoryId, searchTerm)

            ' Debugging info
            Console.WriteLine($"Memuat buku untuk CategoryID: {selectedCategoryId}")
            Console.WriteLine($"Jumlah buku ditemukan: {books.Rows.Count}")

            If books?.Rows.Count > 0 Then
                For Each row As DataRow In books.Rows
                    Try
                        ' Validasi data sebelum membuat BookCard
                        Dim bookId As Integer = Convert.ToInt32(row("BookId"))
                        Dim title As String = If(IsDBNull(row("Title")), "No Title", row("Title").ToString())
                        Dim author As String = If(IsDBNull(row("Author")), "Unknown", row("Author").ToString())
                        Dim photoPath As String = If(IsDBNull(row("PhotoPath")), "", row("PhotoPath").ToString())

                        ' Bersihkan path dari karakter tidak standar
                        photoPath = CleanPath(photoPath)

                        Dim bookCard As New MainForm.BookCard(bookId, title, author, photoPath)
                        flowCategory.Controls.Add(bookCard)
                    Catch ex As Exception
                        Console.WriteLine($"Error membuat BookCard: {ex.Message}")
                    End Try
                Next
            Else
                flowCategory.Controls.Add(CreateNoBooksLabel())
            End If
        Catch ex As Exception
            MessageBox.Show($"Gagal memuat buku: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            flowCategory.ResumeLayout()
        End Try
    End Sub

    ' Fungsi untuk membersihkan path
    Private Function CleanPath(path As String) As String
        If String.IsNullOrEmpty(path) Then Return ""
        Return path.Replace(":", "_").Replace(" ", "_")
    End Function

    Private Function CreateNoBooksLabel() As Label
        Return New Label() With {
        .Text = "Tidak ada buku yang cocok",
        .AutoSize = True,
        .Font = New Font("Microsoft Sans Serif", 10.0F, FontStyle.Italic),
        .TextAlign = ContentAlignment.MiddleCenter,
        .Dock = DockStyle.Fill
    }
    End Function

    Private Sub cbSelectCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSelectCategory.SelectedIndexChanged
        LoadBooksByCategory()
    End Sub

    Private Sub txtSearchBook_TextChanged(sender As Object, e As EventArgs) Handles txtSearchBook.TextChanged
        LoadBooksByCategory()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        LoadBooksByCategory()
    End Sub

    Private Sub LoadCategories()
        Try
            Dim db As New DBConnection()
            Dim dt As DataTable = db.GetCategories()

            ' Tambahkan opsi default
            dt.Rows.InsertAt(dt.NewRow(), 0)
            dt.Rows(0)("CategoryId") = 0
            dt.Rows(0)("CategoryName") = "-- Semua Kategori --"

            cbSelectCategory.DataSource = dt
            cbSelectCategory.DisplayMember = "CategoryName"
            cbSelectCategory.ValueMember = "CategoryId"
            cbSelectCategory.SelectedIndex = 0
        Catch ex As Exception
            MessageBox.Show($"Gagal memuat kategori: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
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
        Dim formBaru As New StatisticForm()
        formBaru.Show()
        Me.Hide()
    End Sub

    Private Sub cbProfile_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProfile.SelectedIndexChanged
        ' Pastikan ada item yang dipilih dan bukan pemilihan pertama kali saat load
        If cbProfile.SelectedIndex = -1 Then Exit Sub

        ' Cek pilihan user
        Select Case cbProfile.SelectedItem.ToString()
            Case "View Profile"
                ' Buka form ProfileForm
                Dim profileForm As New ProfileForm()
                profileForm.Show()
                Me.Hide() ' Sembunyikan form saat ini (opsional)

            Case "Logout"
                ' Tampilkan pop-up konfirmasi logout
                Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin keluar?", "Konfirmasi Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If result = DialogResult.Yes Then
                    ' Jika klik Yes, kembali ke LoginForm
                    Dim loginForm As New LoginForm()
                    loginForm.Show()
                    Me.Hide() ' Tutup form saat ini
                End If
        End Select
    End Sub

End Class