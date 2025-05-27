Public Class StatisticForm
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
    Private Sub cbProfile_SelectedIndexChanged(sender As Object, e As EventArgs)
        If cbProfile.SelectedIndex = -1 Then Exit Sub

        Select Case cbProfile.SelectedItem.ToString()
            Case "View Profile"
                NavigateToForm(New ProfileForm)

            Case "Logout"
                Dim result = MessageBox.Show("Apakah Anda yakin ingin logout?",
                                                       "Konfirmasi Logout",
                                                       MessageBoxButtons.YesNo,
                                                       MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    ' Hapus session
                    SessionHelper.EndSession()
                    SessionHelper.ClearSavedSession()

                    isNavigating = True
                    Dim loginForm As New LoginForm
                    loginForm.Show()
                    Close()
                Else
                    cbProfile.SelectedIndex = 0
                End If
        End Select

        cbProfile.SelectedIndex = 0 ' Reset ke default setelah aksi
    End Sub
End Class