Imports System.Drawing.Printing
Imports System.IO
Imports System.Diagnostics
Imports PdfiumViewer

Public Class BookReaderForm
    Private _bookId As Integer
    Private _userId As Integer
    Private _filePath As String
    Private _currentPage As Integer = 1
    Private _totalSecondsFromDB As Integer = 0
    Private _sessionStartTime As DateTime
    Private _lastAutoSaveTime As DateTime = DateTime.MinValue
    Private _pdfDocument As PdfDocument
    Private _pdfViewer As PdfViewer
    Private _lastTrackedPage As Integer = 0
    Private _pageCheckTimer As New Timer()
    Private db As New DBConnection()
    Private _isTimerPaused As Boolean = False

    Public Sub New(bookId As Integer, userId As Integer)
        InitializeComponent()
        _bookId = bookId
        _userId = userId
    End Sub

    Private Sub BookReaderForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadReadingProgress()
        LoadBookFile()
        LoadNotesForBook()

        If Not _isTimerPaused Then
            _sessionStartTime = DateTime.Now
            _lastAutoSaveTime = DateTime.Now
            UpdateTimerDisplay()
            btnTimerControl.Text = "⏸"
            ReadingTimer.Start()
        Else
            ' Jika pause, hanya update display tanpa start timer
            UpdateTimerDisplay()
            btnTimerControl.Text = "▶"
        End If
    End Sub

    Private Sub LoadReadingProgress()
        Try
            Dim db As New DBConnection()
            Dim progressRow As DataRow = db.GetReadingProgress(_userId, _bookId)

            If progressRow IsNot Nothing Then
                If Not IsDBNull(progressRow("ReadDuration")) Then
                    _totalSecondsFromDB = Convert.ToInt32(progressRow("ReadDuration"))
                End If

                If Not IsDBNull(progressRow("LastPage")) Then
                    _currentPage = Convert.ToInt32(progressRow("LastPage"))
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Failed to load reading progress: " & ex.Message, "Error")
        End Try
    End Sub

    Private Sub LoadBookFile()
        Try
            Dim db As New DBConnection()
            Dim bookRow As DataRow = db.GetBookDetail(_bookId)

            If bookRow Is Nothing OrElse IsDBNull(bookRow("FilePath")) Then
                MessageBox.Show("Book file not found.", "Error")
                Me.Close()
                Return
            End If

            _filePath = bookRow("FilePath").ToString()

            If Not File.Exists(_filePath) Then
                MessageBox.Show("File not found at specified path.", "Error")
                Me.Close()
                Return
            End If

            Dim extension As String = Path.GetExtension(_filePath).ToLower()

            If extension = ".pdf" Then
                ShowPdf()
            Else
                MessageBox.Show("File format not supported. Only PDF.", "Error")
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading book: " & ex.Message, "Error")
            Me.Close()
        End Try
    End Sub

    Private Sub ShowPdf()
        lblNoDocument.Visible = False

        _pdfDocument = PdfDocument.Load(_filePath)
        _pdfViewer = New PdfViewer() With {
        .Dock = DockStyle.Fill,
        .Document = _pdfDocument,
        .ShowToolbar = False
    }
        _pdfViewer.Renderer.ZoomMode = PdfViewerZoomMode.FitWidth

        ' Enable controls
        SetControlsEnabled(True)

        pnlDocumentView.Controls.Clear()
        pnlDocumentView.Controls.Add(_pdfViewer)

        ' Gunakan Timer untuk delay sedikit agar viewer ter-render dengan benar
        Dim setPageTimer As New Timer()
        setPageTimer.Interval = 100 ' 100ms delay
        AddHandler setPageTimer.Tick, Sub()
                                          setPageTimer.Stop()
                                          setPageTimer.Dispose()

                                          ' Go to last saved page SETELAH viewer siap
                                          If _currentPage > 0 AndAlso _currentPage <= _pdfDocument.PageCount Then
                                              _pdfViewer.Renderer.Page = _currentPage
                                              _lastTrackedPage = _currentPage
                                              tslPageInfo.Text = $"{_currentPage} / {_pdfDocument.PageCount}"

                                              ' ✅ Tambahan: update progress bar saat buka awal
                                              Dim progress As Integer = CInt((_currentPage / _pdfDocument.PageCount) * 100)
                                              progressBar.Value = Math.Min(progress, 100)
                                              lblProgressPercentage.Text = $"{progress}%"
                                          Else
                                              ' Jika tidak ada halaman tersimpan, mulai dari halaman 1
                                              _currentPage = 1
                                              _lastTrackedPage = 1
                                              tslPageInfo.Text = $"1 / {_pdfDocument.PageCount}"
                                          End If
                                      End Sub
        setPageTimer.Start()

        ' Setup page tracking
        _pageCheckTimer.Interval = 250
        _pageCheckTimer.Enabled = True
        AddHandler _pageCheckTimer.Tick, AddressOf PageCheckTimer_Tick
    End Sub

    Private Sub SetControlsEnabled(isPdf As Boolean)
        tsbPrevPage.Enabled = isPdf
        tsbNextPage.Enabled = isPdf
        tslPageInfo.Enabled = isPdf
        tscbZoom.Enabled = isPdf
        tsbZoomIn.Enabled = isPdf
        tsbZoomOut.Enabled = isPdf

        ' Always enabled
        tsbNote.Enabled = True
        tsbPrint.Enabled = True
    End Sub

    Private Sub PageCheckTimer_Tick(sender As Object, e As EventArgs)
        If _pdfViewer IsNot Nothing AndAlso _pdfDocument IsNot Nothing Then
            Dim currentPage As Integer = _pdfViewer.Renderer.Page + 1

            If currentPage <> _lastTrackedPage Then
                _lastTrackedPage = currentPage
                _currentPage = currentPage

                tslPageInfo.Text = $"{_currentPage} / {_pdfDocument.PageCount}"

                Dim progress As Integer = CInt((_currentPage / _pdfDocument.PageCount) * 100)
                progressBar.Value = progress
                lblProgressPercentage.Text = $"{progress}%"
            End If
        End If
    End Sub

    Private Sub ReadingTimer_Tick(sender As Object, e As EventArgs) Handles ReadingTimer.Tick
        ' ✅ Perbaikan: Hanya update jika tidak pause
        If Not _isTimerPaused Then
            UpdateTimerDisplay()

            ' Auto save setiap 30 detik
            If DateTime.Now.Subtract(_lastAutoSaveTime).TotalSeconds >= 30 Then
                SaveReadingProgress()
                _lastAutoSaveTime = DateTime.Now
            End If
        End If
    End Sub

    Private Sub UpdateTimerDisplay()
        Dim totalSeconds As Integer = _totalSecondsFromDB

        ' ✅ Perbaikan: Hanya tambahkan session time jika timer TIDAK pause
        If Not _isTimerPaused AndAlso ReadingTimer.Enabled Then
            Dim currentSessionSeconds As Integer = CInt(DateTime.Now.Subtract(_sessionStartTime).TotalSeconds)
            totalSeconds += currentSessionSeconds
        End If

        ' Convert ke hours:minutes:seconds
        Dim hours As Integer = totalSeconds \ 3600
        Dim minutes As Integer = (totalSeconds Mod 3600) \ 60
        Dim seconds As Integer = totalSeconds Mod 60

        lblTimerDisplay.Text = $"Reading Time: {hours:00}:{minutes:00}:{seconds:00}"
    End Sub

    Private Sub btnTimerControl_Click(sender As Object, e As EventArgs) Handles btnTimerControl.Click
        If ReadingTimer.Enabled Then
            ' ✅ PAUSE - Simpan waktu sesi saat ini ke database
            Dim currentSessionSeconds As Integer = CInt(DateTime.Now.Subtract(_sessionStartTime).TotalSeconds)
            _totalSecondsFromDB += currentSessionSeconds

            ' Set flag pause
            _isTimerPaused = True

            ' Simpan progress dengan waktu yang sudah diakumulasi
            SaveReadingProgress()

            ' Stop timer
            ReadingTimer.Stop()
            btnTimerControl.Text = "▶"

        Else
            ' ✅ RESUME - Mulai sesi baru
            _isTimerPaused = False
            _sessionStartTime = DateTime.Now
            _lastAutoSaveTime = DateTime.Now
            ReadingTimer.Start()
            btnTimerControl.Text = "⏸"
        End If
    End Sub

    Private Sub SaveReadingProgress()
        Static isCurrentlySaving As Boolean = False
        If isCurrentlySaving Then Return
        isCurrentlySaving = True

        Try
            If _pdfViewer IsNot Nothing AndAlso _pdfDocument IsNot Nothing Then
                _currentPage = _pdfViewer.Renderer.Page + 1
            End If

            Dim totalSecondsToSave As Integer = _totalSecondsFromDB

            ' ✅ Perbaikan: Hanya tambahkan session time jika timer TIDAK pause
            If Not _isTimerPaused AndAlso ReadingTimer.Enabled Then
                Dim currentSessionSeconds As Integer = CInt(DateTime.Now.Subtract(_sessionStartTime).TotalSeconds)
                totalSecondsToSave += currentSessionSeconds
            End If

            ' Hitung progress persentase
            Dim progressPercent As Double = 0
            If _pdfDocument IsNot Nothing AndAlso _pdfDocument.PageCount > 0 Then
                progressPercent = (_currentPage / _pdfDocument.PageCount) * 100
            End If

            Dim db As New DBConnection()
            If db.UpdateReadingProgressAbsolute(_userId, _bookId, _currentPage, totalSecondsToSave, progressPercent) Then
                ' ✅ Perbaikan: Update _totalSecondsFromDB dan reset session time hanya jika tidak pause
                If Not _isTimerPaused Then
                    _totalSecondsFromDB = totalSecondsToSave
                    _sessionStartTime = DateTime.Now
                End If

                If progressPercent >= 100 Then
                    db.UpdateBookStatus(_bookId, "Finished")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Failed to save progress: " & ex.Message, "Error")
        Finally
            isCurrentlySaving = False
        End Try
    End Sub

    Private Sub BookReaderForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' ✅ Perbaikan: Jika timer sedang berjalan, akumulasi waktu sebelum save
        If ReadingTimer IsNot Nothing AndAlso ReadingTimer.Enabled AndAlso Not _isTimerPaused Then
            Dim currentSessionSeconds As Integer = CInt(DateTime.Now.Subtract(_sessionStartTime).TotalSeconds)
            _totalSecondsFromDB += currentSessionSeconds
            ReadingTimer.Stop()
        End If

        ' Simpan progress
        SaveReadingProgress()

        _pageCheckTimer?.Stop()

        If _pageCheckTimer IsNot Nothing Then
            RemoveHandler _pageCheckTimer.Tick, AddressOf PageCheckTimer_Tick
            _pageCheckTimer.Dispose()
        End If

        _pdfDocument?.Dispose()
    End Sub

    ' Navigation Events
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

    Private Sub tsbZoomIn_Click(sender As Object, e As EventArgs) Handles tsbZoomIn.Click
        If _pdfViewer IsNot Nothing Then
            _pdfViewer.Renderer.Zoom *= 1.25
            UpdateZoomDisplay()
        End If
    End Sub

    Private Sub tsbZoomOut_Click(sender As Object, e As EventArgs) Handles tsbZoomOut.Click
        If _pdfViewer IsNot Nothing Then
            _pdfViewer.Renderer.Zoom /= 1.25
            UpdateZoomDisplay()
        End If
    End Sub

    Private Sub UpdateZoomDisplay()
        If _pdfViewer IsNot Nothing Then
            tscbZoom.Text = $"{CInt(_pdfViewer.Renderer.Zoom * 100)}%"
        End If
    End Sub

    Private Sub tsbToggleSidebar_Click(sender As Object, e As EventArgs) Handles tsbToggleSidebar.Click
        pnlSidebar.Visible = Not pnlSidebar.Visible
    End Sub

    Private Sub btnCloseSidebar_Click(sender As Object, e As EventArgs) Handles btnCloseSidebar.Click
        pnlSidebar.Visible = False
    End Sub

    Private Sub tsbOpenDocument_Click(sender As Object, e As EventArgs) Handles tsbOpenDocument.Click
        Dim home As New MainForm()
        home.Show()
        Me.Close()
    End Sub

    Private Sub tsbNote_Click(sender As Object, e As EventArgs) Handles tsbNote.Click
        ' Buka form untuk menampilkan list notes terkait book ini
        Dim bookNotesForm As New BookNotesForm(_bookId)
        bookNotesForm.ShowDialog()
    End Sub

    Private Sub tsbPrint_Click(sender As Object, e As EventArgs) Handles tsbPrint.Click
        If _pdfDocument Is Nothing Then
            MessageBox.Show("No PDF document loaded to print.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Try
            ' Create print document
            Dim printDocument = _pdfDocument.CreatePrintDocument()

            ' Configure default print settings
            printDocument.PrinterSettings.FromPage = 1
            printDocument.PrinterSettings.ToPage = _pdfDocument.PageCount
            printDocument.PrinterSettings.MinimumPage = 1
            printDocument.PrinterSettings.MaximumPage = _pdfDocument.PageCount

            ' Show print preview
            Using printPreview As New PrintPreviewDialog()
                printPreview.Document = printDocument
                printPreview.WindowState = FormWindowState.Maximized
                printPreview.Text = "Print Preview - " & Me.Text

                ' Add custom print button
                Dim tsPrint As New ToolStripButton("Print...")
                AddHandler tsPrint.Click, Sub(s, ev)
                                              ShowPrintDialog(printDocument)
                                          End Sub

                ' Add to existing toolbar (requires accessing internal controls)
                Dim toolStrip As ToolStrip = Nothing
                For Each ctrl As Control In printPreview.Controls
                    If TypeOf ctrl Is ToolStrip Then
                        toolStrip = DirectCast(ctrl, ToolStrip)
                        Exit For
                    End If
                Next

                If toolStrip IsNot Nothing Then
                    toolStrip.Items.Add(New ToolStripSeparator())
                    toolStrip.Items.Add(tsPrint)
                End If

                printPreview.ShowDialog()
            End Using
        Catch ex As Exception
            MessageBox.Show($"Failed to print document: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ShowPrintDialog(printDocument As Printing.PrintDocument)
        Using printDialog As New PrintDialog()
            printDialog.Document = printDocument
            printDialog.AllowSomePages = True

            If printDialog.ShowDialog() = DialogResult.OK Then
                ' Handle page range using reflection
                If printDialog.PrinterSettings.PrintRange = PrintRange.SomePages Then
                    Try
                        Dim pageRangeType = printDocument.GetType().Assembly.GetType("PdfiumViewer.PdfPrintRange")
                        Dim pageRange = Activator.CreateInstance(pageRangeType,
                                                           printDialog.PrinterSettings.FromPage - 1,
                                                           printDialog.PrinterSettings.ToPage - 1)

                        Dim pageRangeProp = printDocument.GetType().GetProperty("PageRange")
                        pageRangeProp.SetValue(printDocument, pageRange)
                    Catch ex As Exception
                        MessageBox.Show("Could not set page range: " & ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End Try
                End If

                ' Print the document
                printDocument.Print()
            End If
        End Using
    End Sub

    Private Sub helpToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles helpToolStripMenuItem1.Click
        Dim message As String = "Silakan kunjungi repository GitHub berikut untuk bantuan atau informasi lebih lanjut:" & vbCrLf &
                            "https://github.com/kevin-luis/Kelompok_Pemrograman_Desktop" & vbCrLf & vbCrLf &
                            "Klik OK untuk membuka repository GitHub di browser."

        Dim result As DialogResult = MessageBox.Show(message, "Help & Support", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)

        If result = DialogResult.OK Then
            Try
                Process.Start(New ProcessStartInfo With {
                .FileName = "https://github.com/kevin-luis/Kelompok_Pemrograman_Desktop",
                .UseShellExecute = True
            })
            Catch ex As Exception
                MessageBox.Show("Gagal membuka browser: " & ex.Message)
            End Try
        End If
    End Sub


    Private Sub aboutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles aboutToolStripMenuItem1.Click
        Dim appName As String = "ReadNest - Ebook Reader"
        Dim version As String = "Versi 1.0.0"
        Dim author As String = "Dikembangkan oleh Andrea Marie Baikole, Caesar Tresna Andika, Kevin Luis Banamtuan"
        Dim message As String = $"{appName}{vbCrLf}{version}{vbCrLf}{vbCrLf}{author}{vbCrLf}{vbCrLf}Hak Cipta © 2025"

        MessageBox.Show(message, "Tentang Aplikasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub LoadNotesForBook()
        Try
            Dim dt As DataTable = db.GetNotesByBookId(_bookId)

            lstNotes.Items.Clear()
            If dt.Rows.Count > 0 Then
                For Each row As DataRow In dt.Rows
                    Dim title As String = row("Title").ToString()
                    Dim contentPreview As String = row("Content").ToString()

                    If contentPreview.Length > 50 Then
                        contentPreview = contentPreview.Substring(0, 50) & "..."
                    End If

                    lstNotes.Items.Add($"{title}: {contentPreview}")
                Next
            Else
                lstNotes.Items.Add("No notes for this book.")
            End If

        Catch ex As Exception
            MessageBox.Show("Failed to load notes: " & ex.Message)
        End Try
    End Sub

    Private Sub lstNotes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstNotes.SelectedIndexChanged
        Dim selectedIndex As Integer = lstNotes.SelectedIndex
        If selectedIndex >= 0 Then
            Dim dt As DataTable = db.GetNotesByBookId(_bookId)
            Dim content As String = dt.Rows(selectedIndex)("Content").ToString()
            MessageBox.Show(content, "Note Detail")
        End If
    End Sub
End Class