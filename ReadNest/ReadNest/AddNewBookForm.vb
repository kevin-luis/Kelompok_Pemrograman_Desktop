Imports System.IO

Public Class AddNewBookForm
    Private filepath As String = ""

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

    Private Sub BtnAddNewBook_Click(sender As Object, e As EventArgs) Handles BtnAddNewBook.Click
        ' Ambil data dari form
        Dim title As String = txtAddBookTitle.Text.Trim()
        Dim author As String = txtAddBookWriter.Text.Trim()
        Dim categoryId As Integer = 0
        Dim pages As Integer = 0
        Dim description As String = tbDesc.Text.Trim()
        Dim photoPath As String = ""

        ' Jika ada gambar yang diupload
        If PictureBox7.Tag IsNot Nothing Then
            photoPath = PictureBox7.Tag.ToString()
        End If

        ' Validasi input
        If String.IsNullOrEmpty(title) Then
            MessageBox.Show("Judul buku harus diisi!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If String.IsNullOrEmpty(author) Then
            MessageBox.Show("Penulis buku harus diisi!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Validasi kategori (opsional karena boleh NULL)
        If cbAddCategory.SelectedItem IsNot Nothing Then
            Integer.TryParse(cbAddCategory.SelectedValue.ToString(), categoryId)
        End If

        ' Validasi halaman
        If Not Integer.TryParse(txtAddPages.Text, pages) OrElse pages <= 0 Then
            MessageBox.Show("Jumlah halaman harus berupa angka positif!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Proses tambah buku ke database
        Dim db As New DBConnection()
        Try
            If db.TambahBuku(title, author, categoryId, pages, description, photoPath, filePath) Then
                MessageBox.Show("Buku berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ' Reset form setelah berhasil
                txtAddBookTitle.Clear()
                txtAddBookWriter.Clear()
                cbAddCategory.SelectedIndex = -1
                txtAddPages.Clear()
                tbDesc.Clear()
                PictureBox7.Image = Nothing
                PictureBox7.Tag = Nothing
                txtFilePath.Text = "Belum ada file yang diupload"
                filePath = ""
            Else
                MessageBox.Show("Gagal menambahkan buku!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadCategories()
        Dim db As New DBConnection()
        Dim dt As DataTable = db.GetCategories()

        ' Tambahkan opsi default
        dt.Rows.InsertAt(dt.NewRow(), 0)
        dt.Rows(0)("CategoryId") = 0
        dt.Rows(0)("CategoryName") = "-- Pilih Kategori --"

        cbAddCategory.DataSource = dt
        cbAddCategory.DisplayMember = "CategoryName"
        cbAddCategory.ValueMember = "CategoryId"
        cbAddCategory.SelectedIndex = 0
    End Sub

    Private Sub btnUploadBook_Click(sender As Object, e As EventArgs) Handles btnUploadBook.Click
        Using openFileDialog As New OpenFileDialog()
            openFileDialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg;*.png)|*.bmp;*.jpg;*.jpeg;*.png"
            openFileDialog.RestoreDirectory = True

            If openFileDialog.ShowDialog() = DialogResult.OK Then
                Try
                    ' Generate nama file unik
                    Dim fileExt As String = Path.GetExtension(openFileDialog.FileName)
                    Dim fileName As String = Guid.NewGuid().ToString() & fileExt
                    Dim destPath As String = Path.Combine(Application.StartupPath, "BookCovers", fileName)

                    ' Buat folder jika belum ada
                    Directory.CreateDirectory(Path.GetDirectoryName(destPath))

                    ' Copy file
                    File.Copy(openFileDialog.FileName, destPath, True)

                    ' Load gambar ke PictureBox
                    PictureBox7.Image = Image.FromFile(destPath)
                    PictureBox7.SizeMode = PictureBoxSizeMode.Zoom

                    ' Simpan path relatif ke Tag PictureBox
                    PictureBox7.Tag = Path.Combine("BookCovers", fileName)

                Catch ex As Exception
                    MessageBox.Show("Error: Could not process file. Original error: " & ex.Message,
                                  "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End Using
    End Sub

    Private Sub btnUploadFile_Click(sender As Object, e As EventArgs) Handles btnUploadFile.Click
        Using openFileDialog As New OpenFileDialog()
            openFileDialog.Filter = "Book Files (*.pdf;*.epub)|*.pdf;*.epub"
            openFileDialog.RestoreDirectory = True

            If openFileDialog.ShowDialog() = DialogResult.OK Then
                Try
                    ' Generate nama file unik
                    Dim fileExt As String = Path.GetExtension(openFileDialog.FileName)
                    Dim fileName As String = Guid.NewGuid().ToString() & fileExt
                    Dim destPath As String = Path.Combine(Application.StartupPath, "BookFiles", fileName)

                    ' Buat folder jika belum ada
                    Directory.CreateDirectory(Path.GetDirectoryName(destPath))

                    ' Copy file
                    File.Copy(openFileDialog.FileName, destPath, True)

                    ' Update label to show file has been uploaded
                    txtFilePath.Text = Path.GetFileName(openFileDialog.FileName)

                    ' Simpan path relatif
                    filepath = Path.Combine("BookFiles", fileName)

                Catch ex As Exception
                    MessageBox.Show("Error: Could not process file. Original error: " & ex.Message,
                                  "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End Using
    End Sub

    Private Sub AddNewBookForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCategories()
    End Sub
End Class