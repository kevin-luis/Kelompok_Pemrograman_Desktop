Public Class Mynotes
    Private isNavigating As Boolean = False
    Private db As New DBConnection()

    '============ NAVIGASI MENU ============'
    Private Sub NavigateToForm(form As Form)
        SessionHelper.UpdateActivity()
        isNavigating = True
        form.Show()
        Me.Hide()
    End Sub

    Private Sub SetupProfileComboBox()
        cbProfile.Items.Clear()
        cbProfile.Items.Add("Profile")
        cbProfile.Items.Add("View Profile")
        cbProfile.Items.Add("Logout")
        cbProfile.SelectedIndex = 0
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

    '============ FORM INITIALIZATION ============'
    Private Sub Mynotes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Setup FlowLayoutPanel untuk scroll
        SetupFlowLayoutPanel()
        LoadNotes()
        SetupProfileComboBox()
    End Sub

    Private Sub SetupFlowLayoutPanel()
        With flNotes
            .AutoScroll = True
            .WrapContents = True
            .FlowDirection = FlowDirection.LeftToRight
            .Padding = New Padding(10)
            .BackColor = Color.WhiteSmoke
        End With
    End Sub

    '============ NOTES FUNCTIONALITY ============'
    Private Sub LoadNotes()
        Try
            flNotes.Controls.Clear()

            ' Get current user ID
            Dim currentUserId As Integer = SessionHelper.CurrentUser.UserId
            If currentUserId <= 0 Then
                MessageBox.Show("User tidak teridentifikasi. Silakan login ulang.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Modified query to only load notes for current user and join with books table
            Dim query As String = "SELECT n.NoteId, n.Title, n.Content, n.BookId, b.Title as BookTitle " &
                                "FROM notes n " &
                                "LEFT JOIN books b ON n.BookId = b.BookId " &
                                "WHERE n.UserId = @UserId " &
                                "ORDER BY n.NoteId DESC"

            Dim parameters As New Dictionary(Of String, Object) From {
                {"@UserId", currentUserId}
            }

            Dim dt As DataTable = db.ExecuteQueryWithParams(query, parameters)

            If dt IsNot Nothing Then
                For Each row As DataRow In dt.Rows
                    Dim noteCard As Panel = CreateNoteCard(
                        row("NoteId").ToString(),
                        If(IsDBNull(row("Title")), "", row("Title").ToString()),
                        If(IsDBNull(row("Content")), "", row("Content").ToString()),
                        If(IsDBNull(row("BookId")), "", row("BookId").ToString()),
                        If(IsDBNull(row("BookTitle")), "", row("BookTitle").ToString())
                    )
                    flNotes.Controls.Add(noteCard)
                Next
            End If

            ' Show message if no notes found
            If flNotes.Controls.Count = 0 Then
                Dim lblNoNotes As New Label()
                lblNoNotes.Text = "Belum ada catatan. Klik tombol 'Tambah Note' untuk membuat catatan pertama Anda."
                lblNoNotes.Font = New Font("Arial", 12, FontStyle.Italic)
                lblNoNotes.ForeColor = Color.Gray
                lblNoNotes.TextAlign = ContentAlignment.MiddleCenter
                lblNoNotes.Dock = DockStyle.Fill
                flNotes.Controls.Add(lblNoNotes)
            End If

        Catch ex As Exception
            MessageBox.Show("Error loading notes: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function CreateNoteCard(noteId As String, title As String, content As String, bookId As String, bookTitle As String) As Panel
        Dim card As New Panel()
        card.Size = New Size(300, 150)
        card.BorderStyle = BorderStyle.FixedSingle
        card.BackColor = Color.White
        card.Margin = New Padding(10)
        card.Cursor = Cursors.Hand
        card.Tag = noteId

        ' Title Label
        Dim lblTitle As New Label()
        lblTitle.Text = If(String.IsNullOrEmpty(title), "Untitled Note", title)
        lblTitle.Font = New Font("Arial", 12, FontStyle.Bold)
        lblTitle.Location = New Point(10, 10)
        lblTitle.Size = New Size(240, 25)
        lblTitle.ForeColor = Color.Black
        lblTitle.Tag = noteId
        lblTitle.Cursor = Cursors.Hand

        ' Content Preview Label
        Dim lblContent As New Label()
        Dim contentPreview As String = If(content.Length > 100, content.Substring(0, 100) & "...", content)
        lblContent.Text = contentPreview
        lblContent.Font = New Font("Arial", 9)
        lblContent.Location = New Point(10, 40)
        lblContent.Size = New Size(280, 60)
        lblContent.ForeColor = Color.Gray
        lblContent.Tag = noteId
        lblContent.Cursor = Cursors.Hand

        ' Book Info Label (Enhanced to show title)
        Dim lblBookInfo As New Label()
        If Not String.IsNullOrEmpty(bookId) Then
            If Not String.IsNullOrEmpty(bookTitle) Then
                lblBookInfo.Text = $"📖 {bookTitle}"
            Else
                lblBookInfo.Text = $"📖 Book ID: {bookId}"
            End If
            lblBookInfo.Font = New Font("Arial", 8, FontStyle.Italic)
            lblBookInfo.Location = New Point(10, 105)
            lblBookInfo.Size = New Size(240, 15)
            lblBookInfo.ForeColor = Color.DarkGreen
            lblBookInfo.Tag = noteId
            lblBookInfo.Cursor = Cursors.Hand
        End If

        ' Delete Button
        Dim btnDelete As New Button()
        btnDelete.Text = "×"
        btnDelete.Size = New Size(30, 30)
        btnDelete.Location = New Point(260, 10)
        btnDelete.BackColor = Color.Red
        btnDelete.ForeColor = Color.White
        btnDelete.Font = New Font("Arial", 14, FontStyle.Bold)
        btnDelete.FlatStyle = FlatStyle.Flat
        btnDelete.FlatAppearance.BorderSize = 0
        btnDelete.Tag = noteId
        btnDelete.Cursor = Cursors.Hand

        ' Event handlers
        AddHandler card.Click, AddressOf NoteCard_Click
        AddHandler lblTitle.Click, AddressOf NoteCard_Click
        AddHandler lblContent.Click, AddressOf NoteCard_Click
        If Not String.IsNullOrEmpty(bookId) Then
            AddHandler lblBookInfo.Click, AddressOf NoteCard_Click
        End If
        AddHandler btnDelete.Click, AddressOf DeleteNote_Click

        ' Hover effects
        AddHandler card.MouseEnter, AddressOf NoteCard_MouseEnter
        AddHandler card.MouseLeave, AddressOf NoteCard_MouseLeave
        AddHandler lblTitle.MouseEnter, AddressOf NoteCard_MouseEnter
        AddHandler lblTitle.MouseLeave, AddressOf NoteCard_MouseLeave
        AddHandler lblContent.MouseEnter, AddressOf NoteCard_MouseEnter
        AddHandler lblContent.MouseLeave, AddressOf NoteCard_MouseLeave
        If Not String.IsNullOrEmpty(bookId) Then
            AddHandler lblBookInfo.MouseEnter, AddressOf NoteCard_MouseEnter
            AddHandler lblBookInfo.MouseLeave, AddressOf NoteCard_MouseLeave
        End If

        ' Add controls to card
        card.Controls.Add(lblTitle)
        card.Controls.Add(lblContent)
        If Not String.IsNullOrEmpty(bookId) Then
            card.Controls.Add(lblBookInfo)
        End If
        card.Controls.Add(btnDelete)

        Return card
    End Function

    ' Event handlers untuk hover effects
    Private Sub NoteCard_MouseEnter(sender As Object, e As EventArgs)
        Dim control As Control = DirectCast(sender, Control)
        Dim card As Panel

        ' Cari parent panel (card)
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

        ' Cari parent panel (card)
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
            noteId = card.Tag.ToString()
        Else
            Dim control As Control = DirectCast(sender, Control)
            noteId = control.Tag.ToString()
        End If

        ' Open edit form
        Dim editForm As New AddEditNoteForm(noteId)
        If editForm.ShowDialog() = DialogResult.OK Then
            LoadNotes() ' Refresh the notes list
        End If
    End Sub

    Private Sub DeleteNote_Click(sender As Object, e As EventArgs)
        ' Prevent the card click event from firing
        Dim btnDelete As Button = DirectCast(sender, Button)
        Dim noteId As String = btnDelete.Tag.ToString()

        Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin menghapus note ini?",
                                                   "Konfirmasi Hapus",
                                                   MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Try
                ' Get current user ID for security check
                Dim currentUserId As Integer = SessionHelper.CurrentUser.UserId
                If currentUserId <= 0 Then
                    MessageBox.Show("User tidak teridentifikasi. Silakan login ulang.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If

                ' Delete only if the note belongs to current user
                Dim query As String = "DELETE FROM notes WHERE NoteId = @NoteId AND UserId = @UserId"
                Dim parameters As New Dictionary(Of String, Object) From {
                    {"@NoteId", noteId},
                    {"@UserId", currentUserId}
                }

                Dim deleteResult As Integer = db.ExecuteNonQueryWithParams(query, parameters)

                If deleteResult > 0 Then
                    LoadNotes() ' Refresh the notes list
                    MessageBox.Show("Note berhasil dihapus!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Gagal menghapus note! Note mungkin tidak ditemukan atau bukan milik Anda.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show("Error deleting note: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnAddNote_Click(sender As Object, e As EventArgs) Handles btnAddNote.Click
        Dim addForm As New AddEditNoteForm()
        If addForm.ShowDialog() = DialogResult.OK Then
            LoadNotes() ' Refresh the notes list
        End If
    End Sub

    Private Sub MyNotes_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If isNavigating Then Return
        Application.Exit()
    End Sub
End Class