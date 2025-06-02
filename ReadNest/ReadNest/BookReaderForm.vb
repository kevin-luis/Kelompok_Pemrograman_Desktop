Imports System.Drawing.Printing
Imports System.IO
Imports System.Diagnostics
Imports PdfiumViewer
Imports VersOne.Epub

Public Class BookReaderForm
    Private _bookId As Integer
    Private _userId As Integer
    Private _filePath As String
    Private _currentPage As Integer = 1
    Private _totalSecondsFromDB As Integer = 0 ' Ganti dari _totalMinutesFromDB
    Private _sessionStartTime As DateTime
    Private _lastAutoSaveTime As DateTime = DateTime.MinValue
    Private _pdfDocument As PdfDocument
    Private _pdfViewer As PdfViewer
    Private _lastTrackedPage As Integer = -1
    Private _pageCheckTimer As New Timer()
    Private db As New DBConnection()

    Public Sub New(bookId As Integer, userId As Integer)
        InitializeComponent()
        _bookId = bookId
        _userId = userId
    End Sub

    Private Sub BookReaderForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadReadingProgress() ' Pindah ke atas sebelum LoadBookFile
        LoadBookFile()

        ' Mulai sesi baca baru
        _sessionStartTime = DateTime.Now
        _lastAutoSaveTime = DateTime.Now

        ' Initialize UI
        UpdateTimerDisplay()
        btnTimerControl.Text = "⏸" ' Timer otomatis berjalan
        ReadingTimer.Start()
    End Sub

    Private Sub LoadReadingProgress()
        Try
            Dim db As New DBConnection()
            Dim progressRow As DataRow = db.GetReadingProgress(_userId, _bookId)

            If progressRow IsNot Nothing Then
                If Not IsDBNull(progressRow("ReadDuration")) Then
                    _totalSecondsFromDB = Convert.ToInt32(progressRow("ReadDuration")) ' langsung detik
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
            ElseIf extension = ".epub" Then
                ShowEpub()
            Else
                MessageBox.Show("File format not supported. Only PDF and EPUB.", "Error")
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
                                              _pdfViewer.Renderer.Page = _currentPage - 1
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

    Private Sub ShowEpub()
        Try
            lblNoDocument.Visible = False

            Dim book As EpubBook = EpubReader.ReadBook(_filePath)
            Dim content As New RichTextBox() With {
                .Dock = DockStyle.Fill,
                .ReadOnly = True,
                .Font = New Font("Segoe UI", 10)
            }

            Dim fullText As String = ""
            For Each chapter As EpubLocalTextContentFile In book.ReadingOrder
                fullText += StripHtmlTags(chapter.Content) & vbCrLf & vbCrLf
            Next

            content.Text = fullText
            pnlDocumentView.Controls.Clear()
            pnlDocumentView.Controls.Add(content)

            SetControlsEnabled(False) ' Disable PDF controls for EPUB
            tslPageInfo.Text = "EPUB Content"
        Catch ex As Exception
            MessageBox.Show("Failed to load EPUB: " & ex.Message, "Error")
        End Try
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

    Private Function StripHtmlTags(html As String) As String
        Dim noHtml As String = System.Text.RegularExpressions.Regex.Replace(html, "<.*?>", String.Empty)
        Return System.Net.WebUtility.HtmlDecode(noHtml)
    End Function

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
        UpdateTimerDisplay()

        ' Auto save setiap 30 detik
        If DateTime.Now.Subtract(_lastAutoSaveTime).TotalSeconds >= 30 Then
            SaveReadingProgress()
            _lastAutoSaveTime = DateTime.Now
        End If
    End Sub

    Private Sub UpdateTimerDisplay()
        ' Tetap pakai totalSeconds dari cache dan waktu sesi
        Dim currentSessionSeconds As Integer = CInt(DateTime.Now.Subtract(_sessionStartTime).TotalSeconds)
        Dim totalSeconds As Integer = _totalSecondsFromDB + currentSessionSeconds

        ' Convert ke hours:minutes:seconds
        Dim hours As Integer = totalSeconds \ 3600
        Dim minutes As Integer = (totalSeconds Mod 3600) \ 60
        Dim seconds As Integer = totalSeconds Mod 60

        lblTimerDisplay.Text = $"Reading Time: {hours:00}:{minutes:00}:{seconds:00}"
    End Sub


    Private Sub btnTimerControl_Click(sender As Object, e As EventArgs) Handles btnTimerControl.Click
        If ReadingTimer.Enabled Then
            ' Pause - simpan progress dan hentikan timer
            SaveReadingProgress()

            ' Update _totalSecondsFromDB dengan waktu sesi saat ini
            Dim currentSessionSeconds As Integer = CInt(DateTime.Now.Subtract(_sessionStartTime).TotalSeconds)
            _totalSecondsFromDB += currentSessionSeconds

            ReadingTimer.Stop()
            btnTimerControl.Text = "▶"
        Else
            ' Resume - mulai sesi baru dari waktu sekarang
            _sessionStartTime = DateTime.Now
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
            Dim currentSessionSeconds As Integer = CInt(DateTime.Now.Subtract(_sessionStartTime).TotalSeconds)
            totalSecondsToSave += currentSessionSeconds

            ' Hitung progress persentase
            Dim progressPercent As Double = 0
            If _pdfDocument IsNot Nothing AndAlso _pdfDocument.PageCount > 0 Then
                progressPercent = (_currentPage / _pdfDocument.PageCount) * 100
            End If

            Dim db As New DBConnection()
            If db.UpdateReadingProgressAbsolute(_userId, _bookId, _currentPage, totalSecondsToSave, progressPercent) Then
                _totalSecondsFromDB = totalSecondsToSave
                _sessionStartTime = DateTime.Now
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
        ' Hentikan timer terlebih dahulu
        If ReadingTimer IsNot Nothing AndAlso ReadingTimer.Enabled Then
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

End Class