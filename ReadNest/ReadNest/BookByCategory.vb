﻿Imports MySql.Data.MySqlClient
Imports ReadNest.MainForm

Public Class BookByCategory

    Private isNavigating As Boolean = False
    Public Property SelectedCategory As String
    Private db As DBConnection

    Public Sub New()
        InitializeComponent()
        db = New DBConnection()
    End Sub

    Private Sub BookByCategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not String.IsNullOrEmpty(SelectedCategory) Then
            lblByCategory.Text = "Kategori: " & SelectedCategory
            Dim currentUserId As Integer = SessionHelper.CurrentUser.UserId
            LoadBooksByCategory(SelectedCategory, currentUserId)
        Else
            MessageBox.Show("Kategori tidak valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ReturnToCategoryForm()
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ReturnToCategoryForm()
    End Sub

    Private Sub ReturnToCategoryForm()
        Dim formBaru As New CategoryForm()
        formBaru.Show()
        Me.Close() ' Use Close instead of Hide to properly dispose the form
    End Sub

    Private Sub LoadBooksByCategory(categoryName As String, userId As Integer)
        Try
            flowCategory.SuspendLayout()
            flowCategory.Controls.Clear()

            Dim query As String = "SELECT b.BookId, b.Title, b.Author, b.PhotoPath " &
                              "FROM books b " &
                              "JOIN categories c ON b.CategoryId = c.CategoryId " &
                              "WHERE c.CategoryName = @categoryName AND b.UserId = @userId"

            Dim parameters As New Dictionary(Of String, Object) From {
            {"@categoryName", categoryName},
            {"@userId", userId}
        }

            Dim books = db.ExecuteQueryWithParams(query, parameters)

            If books IsNot Nothing AndAlso books.Rows.Count > 0 Then
                For Each row As DataRow In books.Rows
                    Dim bookId As Integer = Convert.ToInt32(row("BookId"))
                    Dim title As String = row("Title").ToString()
                    Dim author As String = row("Author").ToString()
                    Dim photoPath As String = If(IsDBNull(row("PhotoPath")), "", row("PhotoPath").ToString())

                    Dim bookCard As New BookCard(bookId, title, author, photoPath)
                    flowCategory.Controls.Add(bookCard)
                Next
            Else
                flowCategory.Controls.Add(New Label With {
                .Text = "Tidak ada buku dalam kategori ini.",
                .AutoSize = True,
                .Font = New Font("Segoe UI", 10, FontStyle.Italic)
            })
            End If
        Catch ex As Exception
            MessageBox.Show($"Gagal memuat buku: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            flowCategory.ResumeLayout()
        End Try
    End Sub

    Private Sub pbWishlist_Click(sender As Object, e As EventArgs) Handles pbWishlist.Click
        NavigateToWishlist()
    End Sub

    Private Sub NavigateToWishlist()
        Dim formBaru As New WishlistForm()
        formBaru.Show()
        Me.Close() ' Use Close instead of Hide
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
    Private Sub cbProfile1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProfile1.SelectedIndexChanged
        If cbProfile1.SelectedIndex = -1 Then Exit Sub

        Select Case cbProfile1.SelectedItem.ToString()
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
                    cbProfile1.SelectedIndex = 0
                End If
        End Select

        cbProfile1.SelectedIndex = 0 ' Reset ke default setelah aksi
    End Sub

End Class