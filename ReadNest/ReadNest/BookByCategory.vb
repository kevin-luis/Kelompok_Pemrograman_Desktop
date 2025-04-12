Imports MySql.Data.MySqlClient

Public Class BookByCategory
    Public Property SelectedCategory As String

    Private Sub BookByCategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not String.IsNullOrEmpty(SelectedCategory) Then
            lblByCategory.Text = "Kategori: " & SelectedCategory ' ← tampilkan nama kategori di label
            LoadBooksByCategory(SelectedCategory)
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim formBaru As New CategoryForm()
        formBaru.Show()
        Me.Hide()
    End Sub

    Private Sub LoadBooksByCategory(categoryName As String)
        Try
            flowCategory.SuspendLayout()
            flowCategory.Controls.Clear()

            Dim db As New DBConnection()
            Dim query As String = "SELECT BookId, Title, Author, PhotoPath FROM books " &
                                  "WHERE CategoryId = (SELECT CategoryId FROM categories WHERE CategoryName = @categoryName)"

            Using cmd As New MySqlCommand(query, db.BukaKoneksi())
                cmd.Parameters.AddWithValue("@categoryName", categoryName)

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
                            flowCategory.Controls.Add(bookCard)
                        Next
                    Else
                        flowCategory.Controls.Add(New Label With {
                            .Text = "Tidak ada buku dalam kategori ini.",
                            .AutoSize = True,
                            .Font = New Font("Segoe UI", 10, FontStyle.Italic)
                        })
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Gagal memuat buku: {ex.Message}")
        Finally
            flowCategory.ResumeLayout()
        End Try
    End Sub

End Class
