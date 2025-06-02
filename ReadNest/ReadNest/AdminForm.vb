Imports System.Windows.Forms ' Pastikan ini ada untuk ListViewItem, dll.

Public Class AdminForm

    Private Sub AdminForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
        LoadUsersToListView()
        LoadAllBooksToListView()
    End Sub

    Private Sub LoadUsersToListView()
        ListViewUser.View = View.Details
        ListViewUser.FullRowSelect = True
        ListViewUser.GridLines = True

        ListViewUser.Columns.Clear()
        ListViewUser.Items.Clear()

        ListViewUser.Columns.Add("Username", 150, HorizontalAlignment.Left)
        ListViewUser.Columns.Add("Email", 250, HorizontalAlignment.Left)
        ' Tambahkan kolom untuk UserId (opsional, bisa disembunyikan jika tidak ingin terlihat)
        ' ListViewUser.Columns.Add("User ID", 70, HorizontalAlignment.Left)


        Dim db As New DBConnection()
        Dim dtUsers As DataTable = db.GetAllUsers() ' Ini sekarang akan memiliki UserId

        If dtUsers IsNot Nothing AndAlso dtUsers.Rows.Count > 0 Then
            For Each row As DataRow In dtUsers.Rows
                Dim userIdValue As Integer = If(row.IsNull("UserId"), 0, Convert.ToInt32(row("UserId")))
                Dim username As String = If(row.IsNull("Username"), String.Empty, row("Username").ToString())
                Dim email As String = If(row.IsNull("Email"), String.Empty, row("Email").ToString())

                Dim listViewEntry As New ListViewItem(username)
                listViewEntry.SubItems.Add(email)
                ' listViewEntry.SubItems.Add(userIdValue.ToString()) ' Jika ingin menampilkan UserId

                ' Simpan UserId di Tag untuk identifikasi saat menghapus
                listViewEntry.Tag = userIdValue

                ListViewUser.Items.Add(listViewEntry)
            Next
        Else
            ListViewUser.Items.Add(New ListViewItem("Tidak ada data pengguna yang ditemukan."))
        End If
    End Sub


    Private Sub LoadAllBooksToListView()
        ListViewAllBooks.View = View.Details
        ListViewAllBooks.FullRowSelect = True
        ListViewAllBooks.GridLines = True

        ListViewAllBooks.Columns.Clear()
        ListViewAllBooks.Items.Clear()

        ListViewAllBooks.Columns.Add("Judul Buku", 250, HorizontalAlignment.Left)
        ListViewAllBooks.Columns.Add("Penulis", 150, HorizontalAlignment.Left)
        ListViewAllBooks.Columns.Add("Kategori", 120, HorizontalAlignment.Left)

        Dim db As New DBConnection()
        Dim dtBooks As DataTable = db.GetAllBooksWithDetails()

        If dtBooks IsNot Nothing AndAlso dtBooks.Rows.Count > 0 Then
            For Each row As DataRow In dtBooks.Rows
                Dim bookId As Integer = If(row.IsNull("BookId"), 0, Convert.ToInt32(row("BookId")))
                Dim title As String = If(row.IsNull("Title"), String.Empty, row("Title").ToString())
                Dim author As String = If(row.IsNull("Author"), String.Empty, row("Author").ToString())
                Dim categoryName As String = If(row.IsNull("CategoryName"), "N/A", row("CategoryName").ToString())

                Dim listViewEntry As New ListViewItem(title)
                listViewEntry.Tag = bookId
                listViewEntry.SubItems.Add(author)
                listViewEntry.SubItems.Add(categoryName)
                ListViewAllBooks.Items.Add(listViewEntry)
            Next
        Else
            ListViewAllBooks.Items.Add(New ListViewItem("Tidak ada data buku yang ditemukan."))
        End If
    End Sub

    Private Sub ListViewAllBooks_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListViewAllBooks.SelectedIndexChanged
        If ListViewAllBooks.SelectedItems.Count > 0 Then
            Dim selectedItem As ListViewItem = ListViewAllBooks.SelectedItems(0)
            If selectedItem.Tag IsNot Nothing AndAlso TypeOf selectedItem.Tag Is Integer Then
                Dim selectedBookId As Integer = Convert.ToInt32(selectedItem.Tag)
                Console.WriteLine("BookId yang dipilih: " & selectedBookId.ToString())
            End If
        End If
    End Sub

    Private Sub BtnDeleteUser_Click(sender As Object, e As EventArgs) Handles BtnDeleteUser.Click
        If ListViewUser.SelectedItems.Count > 0 Then
            Dim selectedItem As ListViewItem = ListViewUser.SelectedItems(0)
            If selectedItem.Tag IsNot Nothing AndAlso TypeOf selectedItem.Tag Is Integer Then
                Dim userIdToDelete As Integer = Convert.ToInt32(selectedItem.Tag)
                Dim userNameToDelete As String = selectedItem.Text ' Ambil username untuk pesan konfirmasi

                ' Jangan biarkan admin menghapus dirinya sendiri jika sedang login
                If SessionHelper.CurrentUser IsNot Nothing AndAlso SessionHelper.CurrentUser.UserId = userIdToDelete Then
                    MessageBox.Show("Anda tidak dapat menghapus akun Anda sendiri yang sedang aktif.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If

                Dim confirmResult As DialogResult = MessageBox.Show($"Apakah Anda yakin ingin menghapus pengguna '{userNameToDelete}' (ID: {userIdToDelete})? Tindakan ini tidak dapat diurungkan dan mungkin menghapus data terkait.",
                                                                 "Konfirmasi Hapus Pengguna",
                                                                 MessageBoxButtons.YesNo,
                                                                 MessageBoxIcon.Warning)
                If confirmResult = DialogResult.Yes Then
                    Dim db As New DBConnection()
                    If db.HapusUser(userIdToDelete) Then
                        MessageBox.Show($"Pengguna '{userNameToDelete}' berhasil dihapus.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        LoadUsersToListView() ' Refresh daftar pengguna
                    Else
                        MessageBox.Show($"Gagal menghapus pengguna '{userNameToDelete}'. Lihat log untuk detail.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
            Else
                MessageBox.Show("Tidak dapat mengidentifikasi pengguna yang dipilih.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Silakan pilih pengguna yang ingin dihapus dari daftar.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub BtnDeleteBook_Click(sender As Object, e As EventArgs) Handles BtnDeleteBook.Click
        If ListViewAllBooks.SelectedItems.Count > 0 Then
            Dim selectedItem As ListViewItem = ListViewAllBooks.SelectedItems(0)
            If selectedItem.Tag IsNot Nothing AndAlso TypeOf selectedItem.Tag Is Integer Then
                Dim bookIdToDelete As Integer = Convert.ToInt32(selectedItem.Tag)
                Dim bookTitleToDelete As String = selectedItem.Text ' Ambil judul untuk pesan konfirmasi

                Dim confirmResult As DialogResult = MessageBox.Show($"Apakah Anda yakin ingin menghapus buku '{bookTitleToDelete}' (ID: {bookIdToDelete})? Tindakan ini tidak dapat diurungkan.",
                                                                 "Konfirmasi Hapus Buku",
                                                                 MessageBoxButtons.YesNo,
                                                                 MessageBoxIcon.Warning)
                If confirmResult = DialogResult.Yes Then
                    Dim db As New DBConnection()
                    If db.HapusBuku(bookIdToDelete) Then ' Kita sudah punya fungsi HapusBuku
                        MessageBox.Show($"Buku '{bookTitleToDelete}' berhasil dihapus.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        LoadAllBooksToListView() ' Refresh daftar buku
                    Else
                        MessageBox.Show($"Gagal menghapus buku '{bookTitleToDelete}'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
            Else
                MessageBox.Show("Tidak dapat mengidentifikasi buku yang dipilih.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Silakan pilih buku yang ingin dihapus dari daftar.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        ' 1. Tampilkan dialog konfirmasi
        Dim confirmResult As DialogResult = MessageBox.Show("Apakah Anda yakin ingin logout?",
                                                             "Konfirmasi Logout",
                                                             MessageBoxButtons.YesNo,
                                                             MessageBoxIcon.Question)

        ' 2. Jika pengguna mengklik "Yes"
        If confirmResult = DialogResult.Yes Then
            ' 3. Hapus sesi saat ini menggunakan SessionHelper
            SessionHelper.EndSession()

            ' 4. Buat instance baru dari LoginForm
            Dim loginForm As New LoginForm()
            ' 5. Tampilkan LoginForm
            loginForm.Show()
            ' 6. Tutup form saat ini (misalnya AdminForm)
            Me.Close()
        End If
    End Sub

End Class