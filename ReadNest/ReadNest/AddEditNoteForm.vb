Public Class AddEditNoteForm
    Private db As New DBConnection()
    Private noteId As String = ""
    Private isEditing As Boolean = False
    Private hasChanges As Boolean = False
    Private originalTitle As String = ""
    Private originalContent As String = ""
    Private originalBookId As String = ""
    Private preselectedBookId As String = ""

    ' Constructor untuk mode tambah (default)
    Public Sub New()
        InitializeComponent()
        Me.Text = "Tambah Note Baru"
        isEditing = False
    End Sub

    ' Constructor untuk mode tambah dengan buku yang sudah dipilih
    Public Sub New(preselectedBookId As String, addMode As Boolean)
        InitializeComponent()
        Me.Text = "Tambah Note Baru"
        isEditing = False
        Me.preselectedBookId = If(preselectedBookId, "")
        Console.WriteLine($"AddEditNoteForm initialized in ADD mode with preselectedBookId: '{Me.preselectedBookId}'")
    End Sub

    ' Constructor untuk mode EDIT
    Public Sub New(editNoteId As String)
        InitializeComponent()
        Me.Text = "Edit Note"
        noteId = If(editNoteId, "")
        isEditing = True
        Console.WriteLine($"AddEditNoteForm initialized in EDIT mode with noteId: '{noteId}'")
    End Sub

    ' Static factory methods untuk clarity
    Public Shared Function CreateForEdit(noteId As String) As AddEditNoteForm
        Return New AddEditNoteForm(noteId)
    End Function

    Public Shared Function CreateForAdd(Optional preselectedBookId As String = "") As AddEditNoteForm
        If String.IsNullOrEmpty(preselectedBookId) Then
            Return New AddEditNoteForm()
        Else
            Return New AddEditNoteForm(preselectedBookId, True)
        End If
    End Function

    Private Sub AddEditNoteForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Console.WriteLine($"Form Load - isEditing: {isEditing}, noteId: '{noteId}', preselectedBookId: '{preselectedBookId}'")

        ' Check if user is authenticated
        Dim currentUserId As Integer = SessionHelper.CurrentUser.UserId
        If currentUserId <= 0 Then
            MessageBox.Show("User tidak teridentifikasi. Silakan login ulang.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.DialogResult = DialogResult.Cancel
            Me.Close()
            Return
        End If

        ' Load books for dropdown (only books owned by current user)
        LoadBooksToComboBox()

        If isEditing AndAlso Not String.IsNullOrEmpty(noteId) Then
            Console.WriteLine("Loading note data for editing...")
            LoadNoteData()
        ElseIf Not String.IsNullOrEmpty(preselectedBookId) Then
            Console.WriteLine($"Selecting preselected book: '{preselectedBookId}'")
            SelectBookInComboBox(preselectedBookId)
        End If

        ' Track changes
        AddHandler txtTitle.TextChanged, AddressOf TextChanged_Handler
        AddHandler txtContent.TextChanged, AddressOf TextChanged_Handler
        AddHandler cbBooks.SelectedIndexChanged, AddressOf TextChanged_Handler
    End Sub

    Private Sub LoadBooksToComboBox()
        Try
            cbBooks.Items.Clear()
            cbBooks.Items.Add(New BookItem("", "-- Tidak Ada Buku --"))

            ' Get current user ID
            Dim currentUserId As Integer = SessionHelper.CurrentUser.UserId
            If currentUserId <= 0 Then
                Console.WriteLine("Cannot load books - user not authenticated")
                Return
            End If

            ' Only load books owned by current user
            Dim query As String = "SELECT BookId, Title FROM books WHERE UserId = @UserId ORDER BY Title"
            Dim parameters As New Dictionary(Of String, Object) From {
                {"@UserId", currentUserId}
            }

            Dim dt As DataTable = db.ExecuteQueryWithParams(query, parameters)

            If dt IsNot Nothing Then
                For Each row As DataRow In dt.Rows
                    Dim bookId As String = row("BookId").ToString()
                    Dim bookTitle As String = If(IsDBNull(row("Title")), "Unknown Title", row("Title").ToString())

                    Console.WriteLine($"Adding book to combo: ID='{bookId}', Title='{bookTitle}'")
                    cbBooks.Items.Add(New BookItem(bookId, bookTitle))
                Next
            End If

            cbBooks.SelectedIndex = 0
            Console.WriteLine($"Loaded {cbBooks.Items.Count} books to combobox")

        Catch ex As Exception
            MessageBox.Show("Error loading books: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadNoteData()
        Try
            Console.WriteLine($"LoadNoteData called with noteId: '{noteId}'")
            If String.IsNullOrEmpty(noteId) Then
                MessageBox.Show("Note ID is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Get current user ID for security check
            Dim currentUserId As Integer = SessionHelper.CurrentUser.UserId
            If currentUserId <= 0 Then
                MessageBox.Show("User tidak teridentifikasi. Silakan login ulang.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Convert string noteId to integer
            Dim noteIdInt As Integer
            If Not Integer.TryParse(noteId, noteIdInt) Then
                MessageBox.Show($"Invalid Note ID format: '{noteId}'. Expected integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Load note data only if it belongs to current user
            Dim query As String = "SELECT Title, Content, BookId FROM notes WHERE NoteId = @NoteId AND UserId = @UserId"
            Dim parameters As New Dictionary(Of String, Object) From {
                {"@NoteId", noteIdInt},
                {"@UserId", currentUserId}
            }

            Console.WriteLine($"Executing query with noteId as integer: {noteIdInt} and userId: {currentUserId}")

            Dim dt As DataTable = db.ExecuteQueryWithParams(query, parameters)
            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
                Dim row As DataRow = dt.Rows(0)
                Dim title As String = If(IsDBNull(row("Title")), "", row("Title").ToString())
                Dim content As String = If(IsDBNull(row("Content")), "", row("Content").ToString())
                ' Convert BookId to string for consistency
                Dim bookId As String = If(IsDBNull(row("BookId")), "", row("BookId").ToString())

                Console.WriteLine($"Loaded data - Title: '{title}', Content length: {content.Length}, BookId: '{bookId}'")

                txtTitle.Text = title
                txtContent.Text = content

                ' Set selected book in combobox
                SelectBookInComboBox(bookId)

                ' Store original values
                originalTitle = txtTitle.Text
                originalContent = txtContent.Text
                originalBookId = bookId

                Console.WriteLine("Note data loaded successfully")
            Else
                MessageBox.Show($"Note tidak ditemukan atau bukan milik Anda.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.DialogResult = DialogResult.Cancel
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading note data: " & ex.Message & vbCrLf & vbCrLf & "Stack Trace: " & ex.StackTrace,
                      "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SelectBookInComboBox(bookId As String)
        Try
            Console.WriteLine($"Attempting to select book with ID: '{bookId}'")

            For i As Integer = 0 To cbBooks.Items.Count - 1
                Dim item As BookItem = DirectCast(cbBooks.Items(i), BookItem)
                Console.WriteLine($"Checking item {i}: BookId='{item.BookId}', Title='{item.Title}'")

                If item.BookId = bookId Then
                    cbBooks.SelectedIndex = i
                    Console.WriteLine($"Selected book at index {i}: {item.Title}")
                    Return
                End If
            Next

            Console.WriteLine($"Book with ID '{bookId}' not found in combobox - may not belong to current user")
            ' If book not found (possibly doesn't belong to current user), select "no book"
            cbBooks.SelectedIndex = 0
        Catch ex As Exception
            Console.WriteLine($"Error selecting book: {ex.Message}")
        End Try
    End Sub

    Private Function GetSelectedBookId() As String
        If cbBooks.SelectedItem IsNot Nothing Then
            Dim selectedItem As BookItem = DirectCast(cbBooks.SelectedItem, BookItem)
            Return selectedItem.BookId
        End If
        Return ""
    End Function

    Private Sub TextChanged_Handler(sender As Object, e As EventArgs)
        Dim currentBookId As String = GetSelectedBookId()
        hasChanges = (txtTitle.Text <> originalTitle) OrElse
                    (txtContent.Text <> originalContent) OrElse
                    (currentBookId <> originalBookId)
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

        ' Check if user is authenticated
        Dim currentUserId As Integer = SessionHelper.CurrentUser.UserId
        If currentUserId <= 0 Then
            MessageBox.Show("User tidak teridentifikasi. Silakan login ulang.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        Dim selectedBookId As String = GetSelectedBookId()
        Dim currentUserId As Integer = SessionHelper.CurrentUser.UserId

        ' Insert note with current user's ID
        Dim query As String = "INSERT INTO notes (UserId, Title, Content, BookId, CreatedDate, ModifiedDate) VALUES (@UserId, @Title, @Content, @BookId, NOW(), NOW())"

        Dim parameters As New Dictionary(Of String, Object) From {
            {"@UserId", currentUserId},
            {"@Title", txtTitle.Text.Trim()},
            {"@Content", txtContent.Text.Trim()},
            {"@BookId", If(String.IsNullOrEmpty(selectedBookId), Nothing, selectedBookId)}
        }

        Console.WriteLine($"Inserting note with UserId: {currentUserId} and BookId: '{selectedBookId}'")

        Dim result As Integer = db.ExecuteNonQueryWithParams(query, parameters)

        If result > 0 Then
            MessageBox.Show("Note berhasil disimpan!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Throw New Exception("Gagal menyimpan note ke database.")
        End If
    End Sub

    Private Sub UpdateNote()
        Dim selectedBookId As String = GetSelectedBookId()
        Dim currentUserId As Integer = SessionHelper.CurrentUser.UserId

        Dim noteIdInt As Integer
        If Not Integer.TryParse(noteId, noteIdInt) Then
            Throw New Exception($"Invalid Note ID format: '{noteId}'. Expected integer.")
        End If

        ' Update note only if it belongs to current user
        Dim query As String = "UPDATE notes SET Title = @Title, Content = @Content, BookId = @BookId, ModifiedDate = NOW() WHERE NoteId = @NoteId AND UserId = @UserId"

        Dim parameters As New Dictionary(Of String, Object) From {
            {"@NoteId", noteIdInt},
            {"@UserId", currentUserId},
            {"@Title", txtTitle.Text.Trim()},
            {"@Content", txtContent.Text.Trim()},
            {"@BookId", If(String.IsNullOrEmpty(selectedBookId), Nothing, selectedBookId)}
        }

        Console.WriteLine($"Updating note {noteIdInt} with UserId: {currentUserId} and BookId: '{selectedBookId}'")

        Dim result As Integer = db.ExecuteNonQueryWithParams(query, parameters)

        If result > 0 Then
            MessageBox.Show("Note berhasil diperbarui!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Throw New Exception("Gagal memperbarui note di database atau note bukan milik Anda.")
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
                    If String.IsNullOrWhiteSpace(txtTitle.Text) OrElse String.IsNullOrWhiteSpace(txtContent.Text) Then
                        MessageBox.Show("Judul dan isi note tidak boleh kosong!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        e.Cancel = True
                        Return
                    End If

                    ' Check if user is authenticated
                    Dim currentUserId As Integer = SessionHelper.CurrentUser.UserId
                    If currentUserId <= 0 Then
                        MessageBox.Show("User tidak teridentifikasi. Silakan login ulang.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
                    Me.DialogResult = DialogResult.Cancel
            End Select
        End If
    End Sub
End Class

' Helper class untuk ComboBox items
Public Class BookItem
    Public Property BookId As String
    Public Property Title As String

    Public Sub New(bookId As String, title As String)
        Me.BookId = If(bookId, "")
        Me.Title = If(title, "")
    End Sub

    Public Overrides Function ToString() As String
        Return Title
    End Function
End Class