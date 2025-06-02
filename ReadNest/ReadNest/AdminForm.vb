Imports System.Windows.Forms ' Pastikan ini ada untuk ListViewItem, dll.

Public Class AdminForm

    Private Sub AdminForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Panggil fungsi untuk memuat data pengguna ke ListView
        LoadUsersToListView()
    End Sub

    Private Sub LoadUsersToListView()
        ' Konfigurasi ListViewUser
        ListViewUser.View = View.Details
        ListViewUser.FullRowSelect = True ' Opsional, untuk memilih seluruh baris
        ListViewUser.GridLines = True     ' Opsional, untuk menampilkan garis grid

        ' Bersihkan kolom dan item yang mungkin sudah ada
        ListViewUser.Columns.Clear()
        ListViewUser.Items.Clear()

        ' Tambahkan Kolom ke ListViewUser
        ListViewUser.Columns.Add("Username", 150, HorizontalAlignment.Left) ' Nama Kolom, Lebar, Penjajaran
        ListViewUser.Columns.Add("Email", 250, HorizontalAlignment.Left)

        ' Buat instance DBConnection
        Dim db As New DBConnection()
        Dim dtUsers As DataTable = db.GetAllUsers()

        If dtUsers IsNot Nothing AndAlso dtUsers.Rows.Count > 0 Then
            ' Loop melalui setiap baris DataRow di DataTable
            For Each row As DataRow In dtUsers.Rows
                Dim username As String = If(row.IsNull("Username"), String.Empty, row("Username").ToString())
                Dim email As String = If(row.IsNull("Email"), String.Empty, row("Email").ToString())

                ' Buat ListViewItem baru dengan username sebagai item utama
                Dim listViewEntry As New ListViewItem(username)

                ' Tambahkan email sebagai SubItem
                listViewEntry.SubItems.Add(email)

                ' Tambahkan item yang sudah lengkap ke ListViewUser
                ListViewUser.Items.Add(listViewEntry)
            Next
        Else
            ' Tampilkan pesan jika tidak ada data pengguna atau terjadi error
            ' (Error spesifik sudah ditangani di DBConnection, ini untuk kasus data kosong)
            ListViewUser.Items.Add(New ListViewItem("Tidak ada data pengguna yang ditemukan."))
            ' Atau: MessageBox.Show("Tidak ada data pengguna yang ditemukan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    ' Tambahkan event handler lain atau fungsi yang Anda butuhkan untuk AdminForm di sini

End Class