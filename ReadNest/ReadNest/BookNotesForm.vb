Public Class BookNotesForm
    Private _bookId As String
    Private _bookTitle As String
    Private db As New DBConnection()

    ' Constructor to receive bookId
    Public Sub New(bookId As String)
        InitializeComponent()
        _bookId = bookId
    End Sub

    ' Constructor to receive bookId and bookTitle
    Public Sub New(bookId As String, bookTitle As String)
        InitializeComponent()
        _bookId = bookId
        _bookTitle = bookTitle
    End Sub

    ' Default constructor (required for designer)
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub BookNotesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load book title if not provided
        If String.IsNullOrEmpty(_bookTitle) Then
            LoadBookTitle()
        End If

        ' Setup form title
        Me.Text = If(String.IsNullOrEmpty(_bookTitle), "Notes - Book ID: " & _bookId, _bookTitle & " - Notes")
        lblTitle.Text = If(String.IsNullOrEmpty(_bookTitle), "Notes for Book ID: " & _bookId, _bookTitle & " Notes")

        ' Setup FlowLayoutPanel
        SetupFlowLayoutPanel()

        ' Load notes for this book
        LoadBookNotes()
    End Sub

    Private Sub LoadBookTitle()
        Try
            Dim query As String = "SELECT Title FROM books WHERE BookId = @BookId"
            Dim parameters As New Dictionary(Of String, Object) From {
                {"@BookId", _bookId}
            }

            Dim dt As DataTable = db.ExecuteQueryWithParams(query, parameters)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
                _bookTitle = If(IsDBNull(dt.Rows(0)("Title")), "Unknown Book", dt.Rows(0)("Title").ToString())
            Else
                _bookTitle = "Unknown Book"
            End If
        Catch ex As Exception
            _bookTitle = "Unknown Book"
        End Try
    End Sub

    Private Sub SetupFlowLayoutPanel()
        With flNotes
            .AutoScroll = True
            .WrapContents = True
            .FlowDirection = FlowDirection.TopDown
            .Padding = New Padding(10)
            .BackColor = Color.WhiteSmoke
        End With
    End Sub

    Private Sub LoadBookNotes()
        Try
            flNotes.Controls.Clear()

            ' Query untuk notes berdasarkan BookId
            Dim query As String = "SELECT NoteId, Title, Content, BookId FROM notes WHERE BookId = @BookId ORDER BY NoteId DESC"
            Dim parameters As New Dictionary(Of String, Object) From {
                {"@BookId", _bookId}
            }

            Dim dt As DataTable = db.ExecuteQueryWithParams(query, parameters)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
                For Each row As DataRow In dt.Rows
                    Dim noteCard As Panel = CreateNoteCard(
                        row("NoteId").ToString(),
                        If(IsDBNull(row("Title")), "", row("Title").ToString()),
                        If(IsDBNull(row("Content")), "", row("Content").ToString())
                    )
                    flNotes.Controls.Add(noteCard)
                Next

                lblEmptyMessage.Visible = False
            Else
                ' Show empty message
                lblEmptyMessage.Visible = True
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading notes: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function CreateNoteCard(noteId As String, title As String, content As String) As Panel
        Dim card As New Panel()
        card.Size = New Size(520, 120)
        card.BorderStyle = BorderStyle.FixedSingle
        card.BackColor = Color.White
        card.Margin = New Padding(5)
        card.Cursor = Cursors.Hand
        card.Tag = noteId

        ' Title Label
        Dim lblTitle As New Label()
        lblTitle.Text = If(String.IsNullOrEmpty(title), "Untitled Note", title)
        lblTitle.Font = New Font("Arial", 11, FontStyle.Bold)
        lblTitle.Location = New Point(10, 10)
        lblTitle.Size = New Size(450, 25)
        lblTitle.ForeColor = Color.Black
        lblTitle.Tag = noteId
        lblTitle.Cursor = Cursors.Hand

        ' Content Preview Label
        Dim lblContent As New Label()
        Dim contentPreview As String = If(content.Length > 80, content.Substring(0, 80) & "...", content)
        lblContent.Text = contentPreview
        lblContent.Font = New Font("Arial", 9)
        lblContent.Location = New Point(10, 35)
        lblContent.Size = New Size(450, 50)
        lblContent.ForeColor = Color.Gray
        lblContent.Tag = noteId
        lblContent.Cursor = Cursors.Hand

        ' Created info label
        Dim lblInfo As New Label()
        lblInfo.Text = "Click to edit or view details"
        lblInfo.Font = New Font("Arial", 8, FontStyle.Italic)
        lblInfo.Location = New Point(10, 90)
        lblInfo.Size = New Size(180, 15)
        lblInfo.ForeColor = Color.DarkBlue
        lblInfo.Tag = noteId
        lblInfo.Cursor = Cursors.Hand

        ' Delete Button
        Dim btnDelete As New Button()
        btnDelete.Text = "×"
        btnDelete.Size = New Size(25, 25)
        btnDelete.Location = New Point(485, 10)
        btnDelete.BackColor = Color.Red
        btnDelete.ForeColor = Color.White
        btnDelete.Font = New Font("Arial", 12, FontStyle.Bold)
        btnDelete.FlatStyle = FlatStyle.Flat
        btnDelete.FlatAppearance.BorderSize = 0
        btnDelete.Tag = noteId
        btnDelete.Cursor = Cursors.Hand
        btnDelete.TabStop = False

        ' Event handlers - PERBAIKAN: Semua kontrol dalam card bisa diklik untuk edit
        AddHandler btnDelete.Click, AddressOf DeleteNote_Click
        AddHandler card.Click, AddressOf NoteCard_Click
        AddHandler lblTitle.Click, AddressOf NoteCard_Click
        AddHandler lblContent.Click, AddressOf NoteCard_Click
        AddHandler lblInfo.Click, AddressOf NoteCard_Click

        ' Hover effects untuk semua kontrol
        AddHandler card.MouseEnter, AddressOf NoteCard_MouseEnter
        AddHandler card.MouseLeave, AddressOf NoteCard_MouseLeave
        AddHandler lblTitle.MouseEnter, AddressOf NoteCard_MouseEnter
        AddHandler lblTitle.MouseLeave, AddressOf NoteCard_MouseLeave
        AddHandler lblContent.MouseEnter, AddressOf NoteCard_MouseEnter
        AddHandler lblContent.MouseLeave, AddressOf NoteCard_MouseLeave
        AddHandler lblInfo.MouseEnter, AddressOf NoteCard_MouseEnter
        AddHandler lblInfo.MouseLeave, AddressOf NoteCard_MouseLeave

        ' Add controls to card
        card.Controls.Add(lblTitle)
        card.Controls.Add(lblContent)
        card.Controls.Add(lblInfo)
        card.Controls.Add(btnDelete)

        Return card
    End Function

    ' Event handlers untuk hover effects
    Private Sub NoteCard_MouseEnter(sender As Object, e As EventArgs)
        Dim control As Control = DirectCast(sender, Control)
        Dim card As Panel

        If TypeOf control Is Panel Then
            card = DirectCast(control, Panel)
        Else
            card = DirectCast(control.Parent, Panel)
        End If

        card.BackColor = Color.LightGray
    End Sub

    Private Sub NoteCard_MouseLeave(sender As Object, e As EventArgs)
        Dim control As Control = DirectCast(sender, Control)
        Dim card As Panel

        If TypeOf control Is Panel Then
            card = DirectCast(control, Panel)
        Else
            card = DirectCast(control.Parent, Panel)
        End If

        card.BackColor = Color.White
    End Sub

    Private Sub NoteCard_Click(sender As Object, e As EventArgs)
        Dim noteId As String = ""

        ' Ambil noteId dari Tag, baik dari panel maupun control di dalamnya
        If TypeOf sender Is Panel Then
            Dim card As Panel = DirectCast(sender, Panel)
            noteId = card.Tag?.ToString()
        Else
            Dim control As Control = DirectCast(sender, Control)
            noteId = control.Tag?.ToString()
        End If

        Try
            ' Validasi noteId
            If String.IsNullOrEmpty(noteId) Then
                MessageBox.Show("Note ID not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Console.WriteLine($"Opening note for edit with ID: {noteId}")

            ' Open edit form - PERBAIKAN: Gunakan factory method yang jelas
            Dim editForm As AddEditNoteForm = AddEditNoteForm.CreateForEdit(noteId)
            editForm.cbBooks.Enabled = False
            editForm.Owner = Me

            If editForm.ShowDialog() = DialogResult.OK Then
                LoadBookNotes() ' Refresh the notes list
            End If

        Catch ex As Exception
            MessageBox.Show("Error opening note: " & ex.Message & vbCrLf & vbCrLf & "Stack Trace: " & ex.StackTrace,
                       "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DeleteNote_Click(sender As Object, e As EventArgs)
        Dim btnDelete As Button = DirectCast(sender, Button)
        Dim noteIdString As String = btnDelete.Tag?.ToString()

        If String.IsNullOrEmpty(noteIdString) Then
            MessageBox.Show("Note ID not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Convert to integer untuk database consistency
        Dim noteIdInt As Integer
        If Not Integer.TryParse(noteIdString, noteIdInt) Then
            MessageBox.Show($"Invalid Note ID format: '{noteIdString}'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this note?",
                                               "Confirm Delete",
                                               MessageBoxButtons.YesNo,
                                               MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Try
                Dim query As String = "DELETE FROM notes WHERE NoteId = @NoteId"
                Dim parameters As New Dictionary(Of String, Object) From {
                    {"@NoteId", noteIdInt}
                }

                Dim deleteResult As Integer = db.ExecuteNonQueryWithParams(query, parameters)

                If deleteResult > 0 Then
                    LoadBookNotes() ' Refresh the notes list
                    MessageBox.Show("Note deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Failed to delete note!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show("Error deleting note: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnAddNote_Click(sender As Object, e As EventArgs) Handles btnAddNote.Click
        Try
            ' PERBAIKAN: Gunakan factory method yang tepat untuk add mode dengan preselected book
            Dim addForm As AddEditNoteForm = AddEditNoteForm.CreateForAdd(_bookId)
            addForm.cbBooks.Enabled = False
            addForm.Owner = Me

            If addForm.ShowDialog() = DialogResult.OK Then
                LoadBookNotes() ' Refresh the notes list
            End If
        Catch ex As Exception
            MessageBox.Show("Error opening add note form: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class