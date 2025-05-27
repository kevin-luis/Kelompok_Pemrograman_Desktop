Imports MySql.Data.MySqlClient

Public Class FavoriteForm

    Private isNavigating As Boolean = False

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
            Dim currentUserId As Integer = SessionHelper.CurrentUser.UserId
            Dim query As String = "SELECT BookId, Title, Author, PhotoPath FROM books WHERE IsFavorite = 1 AND UserId = @userId"

            Dim parameters As New Dictionary(Of String, Object)()
            parameters.Add("@userId", currentUserId)

            If Not String.IsNullOrWhiteSpace(searchTerm) Then
                query &= " AND (Title LIKE @search OR Author LIKE @search)"
                parameters.Add("@search", $"%{searchTerm}%")
            End If

            Dim books = db.ExecuteQueryWithParams(query, parameters)

            If books IsNot Nothing AndAlso books.Rows.Count > 0 Then
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
        Catch ex As Exception
            MessageBox.Show("Gagal memuat buku favorit: " & ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            flowBookFavorite.ResumeLayout()
        End Try
    End Sub

End Class