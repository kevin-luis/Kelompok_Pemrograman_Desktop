Imports MySql.Data.MySqlClient

Public Class FavoriteForm

    Private Sub FavoriteForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadFavoriteBooks()
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
            Dim query As String = "SELECT BookId, Title, Author, PhotoPath FROM books WHERE IsFavorite = 1"

            If Not String.IsNullOrWhiteSpace(searchTerm) Then
                query &= " AND (Title LIKE @search OR Author LIKE @search)"
            End If

            Using cmd As New MySqlCommand(query, db.BukaKoneksi())
                If Not String.IsNullOrWhiteSpace(searchTerm) Then
                    cmd.Parameters.AddWithValue("@search", $"%{searchTerm}%")
                End If

                Using da As New MySqlDataAdapter(cmd)
                    Dim books As New DataTable()
                    da.Fill(books)

                    If books.Rows.Count > 0 Then
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
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal memuat buku favorit: " & ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            flowBookFavorite.ResumeLayout()
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

End Class