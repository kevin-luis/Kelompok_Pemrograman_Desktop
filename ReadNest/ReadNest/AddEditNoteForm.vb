Public Class AddEditNoteForm
    Private db As New DBConnection()
    Private noteId As String = ""
    Private isEditing As Boolean = False
    Private hasChanges As Boolean = False
    Private originalTitle As String = ""
    Private originalContent As String = ""
    Private originalBookId As String = ""

    ' Constructor untuk mode tambah
    Public Sub New()
        InitializeComponent()
        Me.Text = "Tambah Note Baru"
        isEditing = False
    End Sub

    ' Constructor untuk mode edit
    Public Sub New(editNoteId As String)
        InitializeComponent()
        Me.Text = "Edit Note"
        noteId = editNoteId
        isEditing = True
    End Sub

    Private Sub AddEditNoteForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If isEditing Then
            LoadNoteData()
        End If

        ' Track changes
        AddHandler txtTitle.TextChanged, AddressOf TextChanged_Handler
        AddHandler txtContent.TextChanged, AddressOf TextChanged_Handler
        AddHandler txtBookId.TextChanged, AddressOf TextChanged_Handler
    End Sub

    Private Sub LoadNoteData()
        Try
            Dim query As String = "SELECT Title, Content, BookId FROM notes WHERE NoteId = @NoteId"
            Dim parameters As New Dictionary(Of String, Object) From {
                {"@NoteId", noteId}
            }

            Dim dt As DataTable = db.ExecuteQueryWithParams(query, parameters)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
                Dim row As DataRow = dt.Rows(0)
                txtTitle.Text = If(IsDBNull(row("Title")), "", row("Title").ToString())
                txtContent.Text = If(IsDBNull(row("Content")), "", row("Content").ToString())
                txtBookId.Text = If(IsDBNull(row("BookId")), "", row("BookId").ToString())

                ' Store original values
                originalTitle = txtTitle.Text
                originalContent = txtContent.Text
                originalBookId = txtBookId.Text
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading note data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub TextChanged_Handler(sender As Object, e As EventArgs)
        ' Check if there are changes
        hasChanges = (txtTitle.Text <> originalTitle) OrElse
                    (txtContent.Text <> originalContent) OrElse
                    (txtBookId.Text <> originalBookId)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrWhiteSpace(txtTitle.Text) Then
            MessageBox.Show("Judul note tidak boleh kosong!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtTitle.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(txtContent.Text) Then
            MessageBox.Show("Isi note tidak boleh kosong!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtContent.Focus()
            Return
        End If

        Try
            If isEditing Then
                UpdateNote()
            Else
                InsertNote()
            End If

            hasChanges = False
            Me.DialogResult = DialogResult.OK
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Error saving note: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub InsertNote()
        Dim query As String = "INSERT INTO notes (Title, Content, BookId, CreatedDate) VALUES (@Title, @Content, @BookId, NOW())"

        Dim parameters As New Dictionary(Of String, Object) From {
            {"@Title", txtTitle.Text.Trim()},
            {"@Content", txtContent.Text.Trim()},
            {"@BookId", If(String.IsNullOrWhiteSpace(txtBookId.Text), Nothing, txtBookId.Text.Trim())}
        }

        Dim result As Integer = db.ExecuteNonQueryWithParams(query, parameters)

        If result > 0 Then
            MessageBox.Show("Note berhasil disimpan!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Throw New Exception("Gagal menyimpan note ke database.")
        End If
    End Sub

    Private Sub UpdateNote()
        Dim query As String = "UPDATE notes SET Title = @Title, Content = @Content, BookId = @BookId, ModifiedDate = NOW() WHERE NoteId = @NoteId"

        Dim parameters As New Dictionary(Of String, Object) From {
            {"@NoteId", noteId},
            {"@Title", txtTitle.Text.Trim()},
            {"@Content", txtContent.Text.Trim()},
            {"@BookId", If(String.IsNullOrWhiteSpace(txtBookId.Text), Nothing, txtBookId.Text.Trim())}
        }

        Dim result As Integer = db.ExecuteNonQueryWithParams(query, parameters)

        If result > 0 Then
            MessageBox.Show("Note berhasil diperbarui!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Throw New Exception("Gagal memperbarui note di database.")
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub AddEditNoteForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If hasChanges AndAlso Me.DialogResult <> DialogResult.OK Then
            Dim result As DialogResult = MessageBox.Show("Anda memiliki perubahan yang belum disimpan. Apakah Anda ingin menyimpan note ini?",
                                                       "Konfirmasi Simpan",
                                                       MessageBoxButtons.YesNoCancel,
                                                       MessageBoxIcon.Question)

            Select Case result
                Case DialogResult.Yes
                    ' Try to save
                    If String.IsNullOrWhiteSpace(txtTitle.Text) OrElse String.IsNullOrWhiteSpace(txtContent.Text) Then
                        MessageBox.Show("Judul dan isi note tidak boleh kosong!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        e.Cancel = True
                        Return
                    End If

                    Try
                        If isEditing Then
                            UpdateNote()
                        Else
                            InsertNote()
                        End If
                        Me.DialogResult = DialogResult.OK
                    Catch ex As Exception
                        MessageBox.Show("Error saving note: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        e.Cancel = True
                    End Try

                Case DialogResult.Cancel
                    e.Cancel = True

                Case DialogResult.No
                    ' Allow closing without saving
                    Me.DialogResult = DialogResult.Cancel
            End Select
        End If
    End Sub
End Class