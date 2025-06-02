<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BookReaderForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BookReaderForm))
        pnlMainContainer = New TableLayoutPanel()
        pnlSidebar = New Panel()
        lstNotes = New ListBox()
        pnlSidebarHeader = New Panel()
        lblSidebarTitle = New Label()
        btnCloseSidebar = New Button()
        pnlDocumentContainer = New Panel()
        pnlDocumentView = New Panel()
        lblNoDocument = New Label()
        pnlHeader = New Panel()
        tlsReaderTools = New ToolStrip()
        tsbOpenDocument = New ToolStripButton()
        tsbToggleSidebar = New ToolStripButton()
        toolStripSeparator4 = New ToolStripSeparator()
        tsbPrevPage = New ToolStripButton()
        tslPageInfo = New ToolStripLabel()
        tsbNextPage = New ToolStripButton()
        toolStripSeparator1 = New ToolStripSeparator()
        tsbZoomOut = New ToolStripButton()
        tscbZoom = New ToolStripTextBox()
        tsbZoomIn = New ToolStripButton()
        toolStripSeparator2 = New ToolStripSeparator()
        tsbNote = New ToolStripButton()
        toolStripSeparator3 = New ToolStripSeparator()
        tsbPrint = New ToolStripButton()
        menuSettings = New ToolStripDropDownButton()
        helpToolStripMenuItem1 = New ToolStripMenuItem()
        aboutToolStripMenuItem1 = New ToolStripMenuItem()
        cmsHighlighting = New ContextMenuStrip(components)
        yellowHighlightToolStripMenuItem = New ToolStripMenuItem()
        blueHighlightToolStripMenuItem = New ToolStripMenuItem()
        greenHighlightToolStripMenuItem = New ToolStripMenuItem()
        pinkHighlightToolStripMenuItem = New ToolStripMenuItem()
        removeHighlightToolStripMenuItem = New ToolStripMenuItem()
        pnlFooter = New Panel()
        statusPanel = New Panel()
        pnlProgressContainer = New Panel()
        progressBar = New ProgressBar()
        lblProgressPercentage = New Label()
        pnlReadingStats = New Panel()
        btnTimerControl = New Button()
        lblTimerDisplay = New Label()
        ReadingTimer = New Timer(components)
        OpenFileDialog1 = New OpenFileDialog()
        SearchDialog1 = New RichTextBox()
        BookmarkDialog1 = New TextBox()
        ToolTip1 = New ToolTip(components)
        pnlMainContainer.SuspendLayout()
        pnlSidebar.SuspendLayout()
        pnlSidebarHeader.SuspendLayout()
        pnlDocumentContainer.SuspendLayout()
        pnlDocumentView.SuspendLayout()
        pnlHeader.SuspendLayout()
        tlsReaderTools.SuspendLayout()
        cmsHighlighting.SuspendLayout()
        pnlFooter.SuspendLayout()
        statusPanel.SuspendLayout()
        pnlProgressContainer.SuspendLayout()
        pnlReadingStats.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlMainContainer
        ' 
        pnlMainContainer.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlMainContainer.BackColor = Color.White
        pnlMainContainer.ColumnCount = 2
        pnlMainContainer.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 299F))
        pnlMainContainer.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        pnlMainContainer.Controls.Add(pnlSidebar, 0, 0)
        pnlMainContainer.Controls.Add(pnlDocumentContainer, 1, 0)
        pnlMainContainer.Location = New Point(0, 60)
        pnlMainContainer.Margin = New Padding(0)
        pnlMainContainer.Name = "pnlMainContainer"
        pnlMainContainer.RowCount = 1
        pnlMainContainer.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        pnlMainContainer.Size = New Size(1200, 749)
        pnlMainContainer.TabIndex = 2
        ' 
        ' pnlSidebar
        ' 
        pnlSidebar.BackColor = Color.FromArgb(CByte(248), CByte(249), CByte(250))
        pnlSidebar.Controls.Add(lstNotes)
        pnlSidebar.Controls.Add(pnlSidebarHeader)
        pnlSidebar.Dock = DockStyle.Fill
        pnlSidebar.Location = New Point(0, 0)
        pnlSidebar.Margin = New Padding(0)
        pnlSidebar.Name = "pnlSidebar"
        pnlSidebar.Size = New Size(299, 749)
        pnlSidebar.TabIndex = 0
        pnlSidebar.Visible = False
        ' 
        ' lstNotes
        ' 
        lstNotes.Dock = DockStyle.Fill
        lstNotes.FormattingEnabled = True
        lstNotes.Location = New Point(0, 51)
        lstNotes.Name = "lstNotes"
        lstNotes.Size = New Size(299, 698)
        lstNotes.TabIndex = 3
        ' 
        ' pnlSidebarHeader
        ' 
        pnlSidebarHeader.BackColor = Color.FromArgb(CByte(248), CByte(249), CByte(250))
        pnlSidebarHeader.Controls.Add(lblSidebarTitle)
        pnlSidebarHeader.Controls.Add(btnCloseSidebar)
        pnlSidebarHeader.Dock = DockStyle.Top
        pnlSidebarHeader.Location = New Point(0, 0)
        pnlSidebarHeader.Margin = New Padding(0)
        pnlSidebarHeader.Name = "pnlSidebarHeader"
        pnlSidebarHeader.Size = New Size(299, 51)
        pnlSidebarHeader.TabIndex = 2
        ' 
        ' lblSidebarTitle
        ' 
        lblSidebarTitle.AutoSize = True
        lblSidebarTitle.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        lblSidebarTitle.ForeColor = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        lblSidebarTitle.Location = New Point(21, 12)
        lblSidebarTitle.Name = "lblSidebarTitle"
        lblSidebarTitle.Size = New Size(73, 28)
        lblSidebarTitle.TabIndex = 1
        lblSidebarTitle.Text = "Details"
        ' 
        ' btnCloseSidebar
        ' 
        btnCloseSidebar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnCloseSidebar.BackColor = Color.Transparent
        btnCloseSidebar.FlatAppearance.BorderSize = 0
        btnCloseSidebar.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        btnCloseSidebar.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(240), CByte(240), CByte(240))
        btnCloseSidebar.FlatStyle = FlatStyle.Flat
        btnCloseSidebar.Font = New Font("Segoe UI", 12F)
        btnCloseSidebar.ForeColor = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        btnCloseSidebar.Location = New Point(261, 5)
        btnCloseSidebar.Margin = New Padding(0)
        btnCloseSidebar.Name = "btnCloseSidebar"
        btnCloseSidebar.Size = New Size(40, 40)
        btnCloseSidebar.TabIndex = 0
        btnCloseSidebar.Text = "×"
        btnCloseSidebar.UseVisualStyleBackColor = False
        ' 
        ' pnlDocumentContainer
        ' 
        pnlDocumentContainer.Controls.Add(pnlDocumentView)
        pnlDocumentContainer.Dock = DockStyle.Fill
        pnlDocumentContainer.Location = New Point(299, 0)
        pnlDocumentContainer.Margin = New Padding(0)
        pnlDocumentContainer.Name = "pnlDocumentContainer"
        pnlDocumentContainer.Size = New Size(901, 749)
        pnlDocumentContainer.TabIndex = 1
        ' 
        ' pnlDocumentView
        ' 
        pnlDocumentView.BackColor = Color.White
        pnlDocumentView.Controls.Add(lblNoDocument)
        pnlDocumentView.Dock = DockStyle.Fill
        pnlDocumentView.Location = New Point(0, 0)
        pnlDocumentView.Margin = New Padding(0)
        pnlDocumentView.Name = "pnlDocumentView"
        pnlDocumentView.Size = New Size(901, 749)
        pnlDocumentView.TabIndex = 0
        ' 
        ' lblNoDocument
        ' 
        lblNoDocument.Anchor = AnchorStyles.None
        lblNoDocument.BackColor = Color.Transparent
        lblNoDocument.Font = New Font("Segoe UI Light", 14F)
        lblNoDocument.ForeColor = Color.FromArgb(CByte(150), CByte(150), CByte(150))
        lblNoDocument.Location = New Point(101, 225)
        lblNoDocument.Margin = New Padding(5, 0, 5, 0)
        lblNoDocument.Name = "lblNoDocument"
        lblNoDocument.Size = New Size(699, 300)
        lblNoDocument.TabIndex = 0
        lblNoDocument.Text = "Open a document to begin reading" & vbCrLf & vbCrLf & "Click the folder icon or press Ctrl+O"
        lblNoDocument.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.FromArgb(CByte(248), CByte(249), CByte(250))
        pnlHeader.Controls.Add(tlsReaderTools)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Margin = New Padding(0)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(1200, 60)
        pnlHeader.TabIndex = 4
        ' 
        ' tlsReaderTools
        ' 
        tlsReaderTools.AutoSize = False
        tlsReaderTools.BackColor = Color.FromArgb(CByte(248), CByte(249), CByte(250))
        tlsReaderTools.Dock = DockStyle.Fill
        tlsReaderTools.Font = New Font("Segoe UI", 10F)
        tlsReaderTools.GripStyle = ToolStripGripStyle.Hidden
        tlsReaderTools.ImageScalingSize = New Size(20, 20)
        tlsReaderTools.Items.AddRange(New ToolStripItem() {tsbOpenDocument, tsbToggleSidebar, toolStripSeparator4, tsbPrevPage, tslPageInfo, tsbNextPage, toolStripSeparator1, tsbZoomOut, tscbZoom, tsbZoomIn, toolStripSeparator2, tsbNote, toolStripSeparator3, tsbPrint, menuSettings})
        tlsReaderTools.Location = New Point(0, 0)
        tlsReaderTools.Name = "tlsReaderTools"
        tlsReaderTools.Padding = New Padding(5, 0, 5, 0)
        tlsReaderTools.RenderMode = ToolStripRenderMode.System
        tlsReaderTools.Size = New Size(1200, 60)
        tlsReaderTools.TabIndex = 0
        tlsReaderTools.Text = "toolStrip1"
        ' 
        ' tsbOpenDocument
        ' 
        tsbOpenDocument.AutoSize = False
        tsbOpenDocument.DisplayStyle = ToolStripItemDisplayStyle.Image
        tsbOpenDocument.Image = CType(resources.GetObject("tsbOpenDocument.Image"), Image)
        tsbOpenDocument.ImageTransparentColor = Color.Magenta
        tsbOpenDocument.Margin = New Padding(10, 0, 5, 0)
        tsbOpenDocument.Name = "tsbOpenDocument"
        tsbOpenDocument.Size = New Size(40, 40)
        tsbOpenDocument.Text = "Open Document"
        ' 
        ' tsbToggleSidebar
        ' 
        tsbToggleSidebar.AutoSize = False
        tsbToggleSidebar.DisplayStyle = ToolStripItemDisplayStyle.Image
        tsbToggleSidebar.Image = CType(resources.GetObject("tsbToggleSidebar.Image"), Image)
        tsbToggleSidebar.ImageTransparentColor = Color.Magenta
        tsbToggleSidebar.Margin = New Padding(5, 0, 5, 0)
        tsbToggleSidebar.Name = "tsbToggleSidebar"
        tsbToggleSidebar.Size = New Size(40, 40)
        tsbToggleSidebar.Text = "Note List"
        ' 
        ' toolStripSeparator4
        ' 
        toolStripSeparator4.Margin = New Padding(10, 0, 10, 0)
        toolStripSeparator4.Name = "toolStripSeparator4"
        toolStripSeparator4.Size = New Size(6, 60)
        ' 
        ' tsbPrevPage
        ' 
        tsbPrevPage.AutoSize = False
        tsbPrevPage.DisplayStyle = ToolStripItemDisplayStyle.Image
        tsbPrevPage.Enabled = False
        tsbPrevPage.Image = CType(resources.GetObject("tsbPrevPage.Image"), Image)
        tsbPrevPage.ImageTransparentColor = Color.Magenta
        tsbPrevPage.Margin = New Padding(5, 0, 5, 0)
        tsbPrevPage.Name = "tsbPrevPage"
        tsbPrevPage.Size = New Size(40, 40)
        tsbPrevPage.Text = "Previous Page"
        ' 
        ' tslPageInfo
        ' 
        tslPageInfo.AutoSize = False
        tslPageInfo.Font = New Font("Segoe UI", 10F)
        tslPageInfo.ForeColor = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        tslPageInfo.Margin = New Padding(2, 0, 2, 0)
        tslPageInfo.Name = "tslPageInfo"
        tslPageInfo.Size = New Size(90, 50)
        tslPageInfo.Text = "0 / 0"
        ' 
        ' tsbNextPage
        ' 
        tsbNextPage.AutoSize = False
        tsbNextPage.DisplayStyle = ToolStripItemDisplayStyle.Image
        tsbNextPage.Enabled = False
        tsbNextPage.Image = CType(resources.GetObject("tsbNextPage.Image"), Image)
        tsbNextPage.ImageTransparentColor = Color.Magenta
        tsbNextPage.Margin = New Padding(5, 0, 5, 0)
        tsbNextPage.Name = "tsbNextPage"
        tsbNextPage.Size = New Size(40, 40)
        tsbNextPage.Text = "Next Page"
        ' 
        ' toolStripSeparator1
        ' 
        toolStripSeparator1.Margin = New Padding(10, 0, 10, 0)
        toolStripSeparator1.Name = "toolStripSeparator1"
        toolStripSeparator1.Size = New Size(6, 60)
        ' 
        ' tsbZoomOut
        ' 
        tsbZoomOut.AutoSize = False
        tsbZoomOut.DisplayStyle = ToolStripItemDisplayStyle.Image
        tsbZoomOut.Enabled = False
        tsbZoomOut.Image = CType(resources.GetObject("tsbZoomOut.Image"), Image)
        tsbZoomOut.ImageTransparentColor = Color.Magenta
        tsbZoomOut.Margin = New Padding(5, 0, 5, 0)
        tsbZoomOut.Name = "tsbZoomOut"
        tsbZoomOut.Size = New Size(40, 40)
        tsbZoomOut.Text = "Zoom Out"
        ' 
        ' tscbZoom
        ' 
        tscbZoom.BackColor = SystemColors.MenuBar
        tscbZoom.Name = "tscbZoom"
        tscbZoom.ReadOnly = True
        tscbZoom.Size = New Size(60, 60)
        ' 
        ' tsbZoomIn
        ' 
        tsbZoomIn.AutoSize = False
        tsbZoomIn.DisplayStyle = ToolStripItemDisplayStyle.Image
        tsbZoomIn.Enabled = False
        tsbZoomIn.Image = CType(resources.GetObject("tsbZoomIn.Image"), Image)
        tsbZoomIn.ImageTransparentColor = Color.Magenta
        tsbZoomIn.Margin = New Padding(5, 0, 5, 0)
        tsbZoomIn.Name = "tsbZoomIn"
        tsbZoomIn.Size = New Size(40, 40)
        tsbZoomIn.Text = "Zoom In"
        ' 
        ' toolStripSeparator2
        ' 
        toolStripSeparator2.Margin = New Padding(10, 0, 10, 0)
        toolStripSeparator2.Name = "toolStripSeparator2"
        toolStripSeparator2.Size = New Size(6, 60)
        ' 
        ' tsbNote
        ' 
        tsbNote.AutoSize = False
        tsbNote.DisplayStyle = ToolStripItemDisplayStyle.Image
        tsbNote.Enabled = False
        tsbNote.Image = CType(resources.GetObject("tsbNote.Image"), Image)
        tsbNote.ImageTransparentColor = Color.Magenta
        tsbNote.Margin = New Padding(5, 0, 5, 0)
        tsbNote.Name = "tsbNote"
        tsbNote.Size = New Size(40, 40)
        tsbNote.Text = "Notes"
        ' 
        ' toolStripSeparator3
        ' 
        toolStripSeparator3.Margin = New Padding(10, 0, 10, 0)
        toolStripSeparator3.Name = "toolStripSeparator3"
        toolStripSeparator3.Size = New Size(6, 60)
        ' 
        ' tsbPrint
        ' 
        tsbPrint.AutoSize = False
        tsbPrint.DisplayStyle = ToolStripItemDisplayStyle.Image
        tsbPrint.Enabled = False
        tsbPrint.Image = CType(resources.GetObject("tsbPrint.Image"), Image)
        tsbPrint.ImageTransparentColor = Color.Magenta
        tsbPrint.Margin = New Padding(5, 0, 5, 0)
        tsbPrint.Name = "tsbPrint"
        tsbPrint.Size = New Size(40, 40)
        tsbPrint.Text = "Print"
        ' 
        ' menuSettings
        ' 
        menuSettings.Alignment = ToolStripItemAlignment.Right
        menuSettings.AutoSize = False
        menuSettings.DisplayStyle = ToolStripItemDisplayStyle.Image
        menuSettings.DropDownItems.AddRange(New ToolStripItem() {helpToolStripMenuItem1, aboutToolStripMenuItem1})
        menuSettings.Image = CType(resources.GetObject("menuSettings.Image"), Image)
        menuSettings.ImageTransparentColor = Color.Magenta
        menuSettings.Margin = New Padding(5, 0, 10, 0)
        menuSettings.Name = "menuSettings"
        menuSettings.Size = New Size(40, 40)
        menuSettings.Text = "Settings"
        ' 
        ' helpToolStripMenuItem1
        ' 
        helpToolStripMenuItem1.Name = "helpToolStripMenuItem1"
        helpToolStripMenuItem1.Size = New Size(141, 28)
        helpToolStripMenuItem1.Text = "Help"
        ' 
        ' aboutToolStripMenuItem1
        ' 
        aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1"
        aboutToolStripMenuItem1.Size = New Size(141, 28)
        aboutToolStripMenuItem1.Text = "About"
        ' 
        ' cmsHighlighting
        ' 
        cmsHighlighting.ImageScalingSize = New Size(20, 20)
        cmsHighlighting.Items.AddRange(New ToolStripItem() {yellowHighlightToolStripMenuItem, blueHighlightToolStripMenuItem, greenHighlightToolStripMenuItem, pinkHighlightToolStripMenuItem, removeHighlightToolStripMenuItem})
        cmsHighlighting.Name = "cmsHighlighting"
        cmsHighlighting.Size = New Size(199, 124)
        ' 
        ' yellowHighlightToolStripMenuItem
        ' 
        yellowHighlightToolStripMenuItem.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(230))
        yellowHighlightToolStripMenuItem.Name = "yellowHighlightToolStripMenuItem"
        yellowHighlightToolStripMenuItem.Size = New Size(198, 24)
        yellowHighlightToolStripMenuItem.Text = "Yellow Highlight"
        ' 
        ' blueHighlightToolStripMenuItem
        ' 
        blueHighlightToolStripMenuItem.BackColor = Color.FromArgb(CByte(230), CByte(240), CByte(255))
        blueHighlightToolStripMenuItem.Name = "blueHighlightToolStripMenuItem"
        blueHighlightToolStripMenuItem.Size = New Size(198, 24)
        blueHighlightToolStripMenuItem.Text = "Blue Highlight"
        ' 
        ' greenHighlightToolStripMenuItem
        ' 
        greenHighlightToolStripMenuItem.BackColor = Color.FromArgb(CByte(230), CByte(255), CByte(230))
        greenHighlightToolStripMenuItem.Name = "greenHighlightToolStripMenuItem"
        greenHighlightToolStripMenuItem.Size = New Size(198, 24)
        greenHighlightToolStripMenuItem.Text = "Green Highlight"
        ' 
        ' pinkHighlightToolStripMenuItem
        ' 
        pinkHighlightToolStripMenuItem.BackColor = Color.FromArgb(CByte(255), CByte(230), CByte(250))
        pinkHighlightToolStripMenuItem.Name = "pinkHighlightToolStripMenuItem"
        pinkHighlightToolStripMenuItem.Size = New Size(198, 24)
        pinkHighlightToolStripMenuItem.Text = "Pink Highlight"
        ' 
        ' removeHighlightToolStripMenuItem
        ' 
        removeHighlightToolStripMenuItem.Name = "removeHighlightToolStripMenuItem"
        removeHighlightToolStripMenuItem.Size = New Size(198, 24)
        removeHighlightToolStripMenuItem.Text = "Remove Highlight"
        ' 
        ' pnlFooter
        ' 
        pnlFooter.BackColor = Color.FromArgb(CByte(248), CByte(249), CByte(250))
        pnlFooter.Controls.Add(statusPanel)
        pnlFooter.Dock = DockStyle.Bottom
        pnlFooter.Location = New Point(0, 811)
        pnlFooter.Margin = New Padding(0)
        pnlFooter.Name = "pnlFooter"
        pnlFooter.Size = New Size(1200, 40)
        pnlFooter.TabIndex = 5
        ' 
        ' statusPanel
        ' 
        statusPanel.Controls.Add(pnlProgressContainer)
        statusPanel.Controls.Add(pnlReadingStats)
        statusPanel.Dock = DockStyle.Fill
        statusPanel.Location = New Point(0, 0)
        statusPanel.Margin = New Padding(5)
        statusPanel.Name = "statusPanel"
        statusPanel.Padding = New Padding(21, 5, 21, 5)
        statusPanel.Size = New Size(1200, 40)
        statusPanel.TabIndex = 0
        ' 
        ' pnlProgressContainer
        ' 
        pnlProgressContainer.Controls.Add(progressBar)
        pnlProgressContainer.Controls.Add(lblProgressPercentage)
        pnlProgressContainer.Dock = DockStyle.Left
        pnlProgressContainer.Location = New Point(21, 5)
        pnlProgressContainer.Margin = New Padding(5)
        pnlProgressContainer.Name = "pnlProgressContainer"
        pnlProgressContainer.Size = New Size(699, 30)
        pnlProgressContainer.TabIndex = 0
        ' 
        ' progressBar
        ' 
        progressBar.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        progressBar.BackColor = Color.White
        progressBar.ForeColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        progressBar.Location = New Point(0, 5)
        progressBar.Margin = New Padding(0, 5, 0, 0)
        progressBar.Name = "progressBar"
        progressBar.Size = New Size(650, 25)
        progressBar.Style = ProgressBarStyle.Continuous
        progressBar.TabIndex = 0
        ' 
        ' lblProgressPercentage
        ' 
        lblProgressPercentage.Dock = DockStyle.Right
        lblProgressPercentage.Font = New Font("Segoe UI", 9F)
        lblProgressPercentage.ForeColor = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        lblProgressPercentage.Location = New Point(649, 0)
        lblProgressPercentage.Margin = New Padding(0)
        lblProgressPercentage.Name = "lblProgressPercentage"
        lblProgressPercentage.Size = New Size(50, 30)
        lblProgressPercentage.TabIndex = 1
        lblProgressPercentage.Text = "0%"
        lblProgressPercentage.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' pnlReadingStats
        ' 
        pnlReadingStats.Controls.Add(btnTimerControl)
        pnlReadingStats.Controls.Add(lblTimerDisplay)
        pnlReadingStats.Dock = DockStyle.Right
        pnlReadingStats.Location = New Point(929, 5)
        pnlReadingStats.Margin = New Padding(5)
        pnlReadingStats.Name = "pnlReadingStats"
        pnlReadingStats.Size = New Size(250, 30)
        pnlReadingStats.TabIndex = 1
        ' 
        ' btnTimerControl
        ' 
        btnTimerControl.BackColor = Color.FromArgb(CByte(240), CByte(240), CByte(240))
        btnTimerControl.Dock = DockStyle.Right
        btnTimerControl.FlatAppearance.BorderColor = Color.FromArgb(CByte(200), CByte(200), CByte(200))
        btnTimerControl.FlatStyle = FlatStyle.Flat
        btnTimerControl.Font = New Font("Segoe UI", 9F)
        btnTimerControl.ForeColor = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        btnTimerControl.Location = New Point(191, 0)
        btnTimerControl.Margin = New Padding(5)
        btnTimerControl.Name = "btnTimerControl"
        btnTimerControl.Size = New Size(59, 30)
        btnTimerControl.TabIndex = 1
        btnTimerControl.Text = "▶"
        btnTimerControl.UseVisualStyleBackColor = False
        ' 
        ' lblTimerDisplay
        ' 
        lblTimerDisplay.Dock = DockStyle.Left
        lblTimerDisplay.Font = New Font("Segoe UI", 9F)
        lblTimerDisplay.ForeColor = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        lblTimerDisplay.Location = New Point(0, 0)
        lblTimerDisplay.Margin = New Padding(0)
        lblTimerDisplay.Name = "lblTimerDisplay"
        lblTimerDisplay.Size = New Size(181, 30)
        lblTimerDisplay.TabIndex = 0
        lblTimerDisplay.Text = "Reading Time: 00:00:00"
        lblTimerDisplay.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' ReadingTimer
        ' 
        ReadingTimer.Interval = 1000
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.Filter = "PDF Files|*.pdf|EPUB Files|*.epub|All Files|*.*"
        OpenFileDialog1.Title = "Open Document"
        ' 
        ' SearchDialog1
        ' 
        SearchDialog1.Location = New Point(1080, 12)
        SearchDialog1.Margin = New Padding(5)
        SearchDialog1.Name = "SearchDialog1"
        SearchDialog1.Size = New Size(53, 37)
        SearchDialog1.TabIndex = 0
        SearchDialog1.Text = ""
        SearchDialog1.Visible = False
        ' 
        ' BookmarkDialog1
        ' 
        BookmarkDialog1.Location = New Point(1155, 12)
        BookmarkDialog1.Margin = New Padding(5)
        BookmarkDialog1.Name = "BookmarkDialog1"
        BookmarkDialog1.Size = New Size(15, 27)
        BookmarkDialog1.TabIndex = 0
        BookmarkDialog1.Visible = False
        ' 
        ' BookReaderForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1200, 851)
        Controls.Add(pnlMainContainer)
        Controls.Add(pnlHeader)
        Controls.Add(pnlFooter)
        Controls.Add(SearchDialog1)
        Controls.Add(BookmarkDialog1)
        Margin = New Padding(5)
        MinimumSize = New Size(800, 598)
        Name = "BookReaderForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Book Reader"
        pnlMainContainer.ResumeLayout(False)
        pnlSidebar.ResumeLayout(False)
        pnlSidebarHeader.ResumeLayout(False)
        pnlSidebarHeader.PerformLayout()
        pnlDocumentContainer.ResumeLayout(False)
        pnlDocumentView.ResumeLayout(False)
        pnlHeader.ResumeLayout(False)
        tlsReaderTools.ResumeLayout(False)
        tlsReaderTools.PerformLayout()
        cmsHighlighting.ResumeLayout(False)
        pnlFooter.ResumeLayout(False)
        statusPanel.ResumeLayout(False)
        pnlProgressContainer.ResumeLayout(False)
        pnlReadingStats.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pnlMainContainer As TableLayoutPanel
    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents pnlSidebarHeader As Panel
    Friend WithEvents lblSidebarTitle As Label
    Friend WithEvents btnCloseSidebar As Button
    Friend WithEvents pnlDocumentContainer As Panel
    Friend WithEvents pnlDocumentView As Panel
    Friend WithEvents lblNoDocument As Label
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents tlsReaderTools As ToolStrip
    Friend WithEvents tsbOpenDocument As ToolStripButton
    Friend WithEvents tsbToggleSidebar As ToolStripButton
    Friend WithEvents toolStripSeparator4 As ToolStripSeparator
    Friend WithEvents tsbPrevPage As ToolStripButton
    Friend WithEvents tslPageInfo As ToolStripLabel
    Friend WithEvents tsbNextPage As ToolStripButton
    Friend WithEvents toolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsbZoomOut As ToolStripButton
    Friend WithEvents tsbZoomIn As ToolStripButton
    Friend WithEvents toolStripSeparator2 As ToolStripSeparator
    Friend WithEvents cmsHighlighting As ContextMenuStrip
    Friend WithEvents yellowHighlightToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents blueHighlightToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents greenHighlightToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents pinkHighlightToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents removeHighlightToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tsbNote As ToolStripButton
    Friend WithEvents toolStripSeparator3 As ToolStripSeparator
    Friend WithEvents tsbPrint As ToolStripButton
    Friend WithEvents menuSettings As ToolStripDropDownButton
    Friend WithEvents helpToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents aboutToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents pnlFooter As Panel
    Friend WithEvents statusPanel As Panel
    Friend WithEvents pnlProgressContainer As Panel
    Friend WithEvents progressBar As ProgressBar
    Friend WithEvents lblProgressPercentage As Label
    Friend WithEvents pnlReadingStats As Panel
    Friend WithEvents btnTimerControl As Button
    Friend WithEvents lblTimerDisplay As Label
    Friend WithEvents ReadingTimer As Timer
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SearchDialog1 As RichTextBox
    Friend WithEvents BookmarkDialog1 As TextBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents tscbZoom As ToolStripTextBox
    Friend WithEvents lstNotes As ListBox
End Class