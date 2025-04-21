Imports System.IO
Imports PdfiumViewer
Imports VersOne.Epub

Public Class BookReaderForm
    Private _bookId As Integer
    Private _filePath As String
    Private _totalSeconds As Integer = 0
    Private _isTimerRunning As Boolean = False
    Private _userId As Integer
    Private _currentPage As Integer = 1
    Private _lastSaveTime As DateTime
    Private _pdfDocument As PdfDocument
    Private _pdfViewer As PdfViewer
    Private _lastTrackedPage As Integer = -1
    Private _pageCheckTimer As New Timer()

    Public Sub New(bookId As Integer, userId As Integer)
        InitializeComponent()
        _bookId = bookId
        _userId = userId
    End Sub

    Private Sub BookReaderForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _lastSaveTime = DateTime.Now
        LoadBookFile()
        LoadReadingProgress()

        ' Initialize UI elements
        lblTimerDisplay.Text = "Reading Time: 00:00:00"
        btnTimerControl.Text = "⏸"

        ' Start timer
        ReadingTimer.Start()
        _isTimerRunning = True
    End Sub

    Private Sub LoadReadingProgress()
        Try
            Dim db As New DBConnection()
            Dim progressRow As DataRow = db.GetReadingProgress(_userId, _bookId)

            If progressRow IsNot Nothing Then
                ' If there's previous progress
                If Not IsDBNull(progressRow("ReadDuration")) Then
                    ' Convert minutes to seconds
                    _totalSeconds = Convert.ToInt32(progressRow("ReadDuration")) * 60
                    UpdateTimerDisplay()
                End If

                ' Set last page if available
                If Not IsDBNull(progressRow("LastPage")) Then
                    _currentPage = Convert.ToInt32(progressRow("LastPage"))
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Failed to load reading progress: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadBookFile()
        Dim db As New DBConnection()
        Dim bookRow As DataRow = db.GetBookDetail(_bookId)

        If bookRow Is Nothing Then
            MessageBox.Show("Book not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            Return
        End If

        If IsDBNull(bookRow("FilePath")) OrElse String.IsNullOrWhiteSpace(bookRow("FilePath").ToString()) Then
            MessageBox.Show("No file available for this book.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            Return
        End If

        _filePath = bookRow("FilePath").ToString()

        If Not File.Exists(_filePath) Then
            MessageBox.Show("File not found at specified path.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            Return
        End If

        Dim extension As String = Path.GetExtension(_filePath).ToLower()

        If extension = ".pdf" Then
            ShowPdf(_filePath)
        ElseIf extension = ".epub" Then
            ShowEpub(_filePath)
        Else
            MessageBox.Show("File format not supported. Only PDF and EPUB.", "Unsupported File", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub ShowPdf(filePath As String)
        lblNoDocument.Visible = False

        ' Load PDF document
        _pdfDocument = PdfDocument.Load(filePath)
        _pdfViewer = New PdfViewer()
        _pdfViewer.Dock = DockStyle.Fill
        _pdfViewer.Document = _pdfDocument
        _pdfViewer.Renderer.ZoomMode = PdfViewerZoomMode.FitWidth ' Use Renderer for zoom mode

        ' Disable the built-in toolbar
        _pdfViewer.ShowToolbar = False

        ' Enable PDF-related controls
        tsbPrevPage.Enabled = True
        tsbNextPage.Enabled = True
        tslPageInfo.Enabled = True
        tscbZoom.Enabled = True
        tsbZoomIn.Enabled = True
        tsbZoomOut.Enabled = True
        tsbHighlight.Enabled = True
        tsbNote.Enabled = True
        tsbSearch.Enabled = True
        tsbViewMode.Enabled = True
        cmbTheme.Enabled = True

        ' Update page info
        tslPageInfo.Text = $"1 / {_pdfDocument.PageCount}"

        pnlDocumentView.Controls.Clear()
        pnlDocumentView.Controls.Add(_pdfViewer)

        ' Go to last saved page if available
        If _currentPage > 0 AndAlso _currentPage <= _pdfDocument.PageCount Then
            _pdfViewer.Renderer.Page = _currentPage - 1 ' PdfiumViewer uses 0-based page numbers
            _lastTrackedPage = _currentPage ' Update the tracked page
        End If

        ' Set up page change tracking using a timer
        _pageCheckTimer.Interval = 250 ' Check every quarter second
        _pageCheckTimer.Enabled = True
        AddHandler _pageCheckTimer.Tick, AddressOf PageCheckTimer_Tick
    End Sub

    Private Sub PageCheckTimer_Tick(sender As Object, e As EventArgs)
        If _pdfViewer IsNot Nothing AndAlso _pdfDocument IsNot Nothing Then
            Dim currentPage As Integer = _pdfViewer.Renderer.Page + 1 ' Convert to 1-based

            ' Only update if the page actually changed
            If currentPage <> _lastTrackedPage Then
                _lastTrackedPage = currentPage
                _currentPage = currentPage

                ' Update UI
                tslPageInfo.Text = $"{_currentPage} / {_pdfDocument.PageCount}"

                ' Update progress
                Dim progress As Integer = CInt((_currentPage / _pdfDocument.PageCount) * 100)
                progressBar.Value = progress
                lblProgressPercentage.Text = $"{progress}%"
            End If
        End If
    End Sub

    Private Sub ShowEpub(filePath As String)
        Try
            ' Remove "No Document" label
            lblNoDocument.Visible = False

            Dim book As EpubBook = EpubReader.ReadBook(filePath)
            Dim content As New RichTextBox()
            content.Dock = DockStyle.Fill
            content.ReadOnly = True
            content.Font = New Font("Segoe UI", 10)

            Dim fullText As String = ""

            For Each chapter As EpubLocalTextContentFile In book.ReadingOrder
                ' Get HTML content
                Dim html As String = chapter.Content
                ' Convert HTML to plain text
                Dim plainText As String = StripHtmlTags(html)
                fullText += plainText & vbCrLf & vbCrLf
            Next

            content.Text = fullText
            pnlDocumentView.Controls.Clear()
            pnlDocumentView.Controls.Add(content)

            ' Disable PDF-specific controls for EPUB
            tsbPrevPage.Enabled = False
            tsbNextPage.Enabled = False
            tslPageInfo.Enabled = False
            tscbZoom.Enabled = False
            tsbZoomIn.Enabled = False
            tsbZoomOut.Enabled = False
            tsbHighlight.Enabled = True
            tsbNote.Enabled = True
            tsbSearch.Enabled = True
            tsbViewMode.Enabled = False
            cmbTheme.Enabled = True

            ' Update page info
            tslPageInfo.Text = "EPUB Content"

        Catch ex As Exception
            MessageBox.Show("Failed to load EPUB file: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function StripHtmlTags(html As String) As String
        ' Remove all HTML tags and return plain text
        Dim noHtml As String = System.Text.RegularExpressions.Regex.Replace(html, "<.*?>", String.Empty)
        Return System.Net.WebUtility.HtmlDecode(noHtml) ' Decode HTML entities like &nbsp;
    End Function

    Private Sub ReadingTimer_Tick(sender As Object, e As EventArgs) Handles ReadingTimer.Tick
        _totalSeconds += 1
        UpdateTimerDisplay()

        ' Save progress every 5 minutes (300 seconds)
        If (DateTime.Now - _lastSaveTime).TotalMinutes >= 5 Then
            SaveReadingProgress()
            _lastSaveTime = DateTime.Now
        End If
    End Sub

    Private Sub UpdateTimerDisplay()
        Dim hours As Integer = _totalSeconds \ 3600
        Dim minutes As Integer = (_totalSeconds Mod 3600) \ 60
        Dim seconds As Integer = _totalSeconds Mod 60

        lblTimerDisplay.Text = $"Reading Time: {hours:00}:{minutes:00}:{seconds:00}"
    End Sub

    Private Sub btnTimerControl_Click(sender As Object, e As EventArgs) Handles btnTimerControl.Click
        If _isTimerRunning Then
            ' If timer is running, stop it
            ReadingTimer.Stop()
            _isTimerRunning = False
            btnTimerControl.Text = "▶"
        Else
            ' If timer is stopped, start it
            ReadingTimer.Start()
            _isTimerRunning = True
            btnTimerControl.Text = "⏸"
        End If
    End Sub

    Private Sub SaveReadingProgress()
        Try
            ' Get current page if showing PDF
            If _pdfViewer IsNot Nothing AndAlso _pdfDocument IsNot Nothing Then
                _currentPage = _pdfViewer.Renderer.Page + 1 ' Convert to 1-based
            End If

            ' Convert seconds to minutes for database
            Dim durationMinutes As Integer = Math.Ceiling(_totalSeconds / 60.0)

            Dim db As New DBConnection()
            db.UpdateReadingProgress(_userId, _bookId, _currentPage, durationMinutes)
        Catch ex As Exception
            MessageBox.Show("Failed to save reading progress: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BookReaderForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Stop timer
        If ReadingTimer.Enabled Then
            ReadingTimer.Stop()
        End If

        ' Clean up page check timer
        If _pageCheckTimer IsNot Nothing Then
            _pageCheckTimer.Enabled = False
            RemoveHandler _pageCheckTimer.Tick, AddressOf PageCheckTimer_Tick
            _pageCheckTimer.Dispose()
        End If

        ' Save reading time to database
        SaveReadingProgress()

        ' Clean up PDF resources
        If _pdfDocument IsNot Nothing Then
            _pdfDocument.Dispose()
        End If
    End Sub

    ' Navigation button handlers
    Private Sub tsbPrevPage_Click(sender As Object, e As EventArgs) Handles tsbPrevPage.Click
        If _pdfViewer IsNot Nothing AndAlso _pdfViewer.Renderer.Page > 0 Then
            _pdfViewer.Renderer.Page -= 1
        End If
    End Sub

    Private Sub tsbNextPage_Click(sender As Object, e As EventArgs) Handles tsbNextPage.Click
        If _pdfViewer IsNot Nothing AndAlso _pdfViewer.Renderer.Page < _pdfDocument.PageCount - 1 Then
            _pdfViewer.Renderer.Page += 1
        End If
    End Sub

    ' Zoom controls - Use Renderer for zoom controls
    Private Sub tsbZoomIn_Click(sender As Object, e As EventArgs) Handles tsbZoomIn.Click
        If _pdfViewer IsNot Nothing Then
            ' Use the Renderer property to access zoom functionality
            Dim currentZoom As Double = _pdfViewer.Renderer.Zoom
            _pdfViewer.Renderer.Zoom = currentZoom * 1.25 ' Increase zoom by 25%
            UpdateZoomComboBox()
        End If
    End Sub

    Private Sub tsbZoomOut_Click(sender As Object, e As EventArgs) Handles tsbZoomOut.Click
        If _pdfViewer IsNot Nothing Then
            ' Use the Renderer property to access zoom functionality
            Dim currentZoom As Double = _pdfViewer.Renderer.Zoom
            _pdfViewer.Renderer.Zoom = currentZoom / 1.25 ' Decrease zoom by 25%
            UpdateZoomComboBox()
        End If
    End Sub

    Private Sub UpdateZoomComboBox()
        If _pdfViewer IsNot Nothing Then
            Dim zoomPercentage As Integer = CInt(_pdfViewer.Renderer.Zoom * 100) ' Use Renderer.Zoom
            tscbZoom.Text = $"{zoomPercentage}%"
        End If
    End Sub

    ' Sidebar toggle
    Private Sub tsbToggleSidebar_Click(sender As Object, e As EventArgs) Handles tsbToggleSidebar.Click
        pnlSidebar.Visible = Not pnlSidebar.Visible
    End Sub

    Private Sub btnCloseSidebar_Click(sender As Object, e As EventArgs) Handles btnCloseSidebar.Click
        pnlSidebar.Visible = False
    End Sub

    ' Search functionality
    Private Sub tsbSearch_Click(sender As Object, e As EventArgs) Handles tsbSearch.Click
        pnlSearch.Visible = Not pnlSearch.Visible
        If pnlSearch.Visible Then
            txtSearch.Focus()
        End If
    End Sub

    Private Sub btnCloseSearch_Click(sender As Object, e As EventArgs) Handles btnCloseSearch.Click
        pnlSearch.Visible = False
    End Sub

    Private Sub tsbOpenDocument_Click(sender As Object, e As EventArgs) Handles tsbOpenDocument.Click
        Dim home As New MainForm()
        home.Show()
        Me.Close()
    End Sub

End Class