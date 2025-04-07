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
        pnlMainContainer = New TableLayoutPanel()
        pnlSidebar = New Panel()
        tbcSidebar = New TabControl()
        tabBookmarks = New TabPage()
        trvBookmarks = New TreeView()
        tabOutline = New TabPage()
        trvOutline = New TreeView()
        tabAnnotations = New TabPage()
        lstAnnotations = New ListView()
        pnlSidebarHeader = New Panel()
        lblSidebarTitle = New Label()
        btnCloseSidebar = New Button()
        pnlDocumentContainer = New Panel()
        pnlDocumentView = New Panel()
        lblNoDocument = New Label()
        pnlSearch = New Panel()
        txtSearch = New TextBox()
        btnPrevSearch = New Button()
        btnNextSearch = New Button()
        btnCloseSearch = New Button()
        lblSearchResults = New Label()
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
        tscbZoom = New ToolStripComboBox()
        tsbZoomIn = New ToolStripButton()
        toolStripSeparator2 = New ToolStripSeparator()
        tsbHighlight = New ToolStripDropDownButton()
        cmsHighlighting = New ContextMenuStrip(components)
        yellowHighlightToolStripMenuItem = New ToolStripMenuItem()
        blueHighlightToolStripMenuItem = New ToolStripMenuItem()
        greenHighlightToolStripMenuItem = New ToolStripMenuItem()
        pinkHighlightToolStripMenuItem = New ToolStripMenuItem()
        removeHighlightToolStripMenuItem = New ToolStripMenuItem()
        toolStripMenuItem1 = New ToolStripSeparator()
        addNoteToolStripMenuItem = New ToolStripMenuItem()
        copyTextToolStripMenuItem = New ToolStripMenuItem()
        tsbNote = New ToolStripButton()
        tsbBookmark = New ToolStripButton()
        toolStripSeparator3 = New ToolStripSeparator()
        tsbSearch = New ToolStripButton()
        tsbViewMode = New ToolStripDropDownButton()
        singlePageToolStripMenuItem1 = New ToolStripMenuItem()
        twoPagesToolStripMenuItem1 = New ToolStripMenuItem()
        cmbTheme = New ToolStripDropDownButton()
        lightModeToolStripMenuItem = New ToolStripMenuItem()
        darkModeToolStripMenuItem = New ToolStripMenuItem()
        sepiaToolStripMenuItem = New ToolStripMenuItem()
        menuSettings = New ToolStripDropDownButton()
        preferencesToolStripMenuItem = New ToolStripMenuItem()
        helpToolStripMenuItem1 = New ToolStripMenuItem()
        aboutToolStripMenuItem1 = New ToolStripMenuItem()
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
        tbcSidebar.SuspendLayout()
        tabBookmarks.SuspendLayout()
        tabOutline.SuspendLayout()
        tabAnnotations.SuspendLayout()
        pnlSidebarHeader.SuspendLayout()
        pnlDocumentContainer.SuspendLayout()
        pnlDocumentView.SuspendLayout()
        pnlSearch.SuspendLayout()
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
        pnlMainContainer.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 300F))
        pnlMainContainer.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        pnlMainContainer.Controls.Add(pnlSidebar, 0, 0)
        pnlMainContainer.Controls.Add(pnlDocumentContainer, 1, 0)
        pnlMainContainer.Location = New Point(0, 60)
        pnlMainContainer.Margin = New Padding(0)
        pnlMainContainer.Name = "pnlMainContainer"
        pnlMainContainer.RowCount = 1
        pnlMainContainer.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        pnlMainContainer.Size = New Size(1200, 750)
        pnlMainContainer.TabIndex = 2
        ' 
        ' pnlSidebar
        ' 
        pnlSidebar.BackColor = Color.FromArgb(CByte(248), CByte(249), CByte(250))
        pnlSidebar.Controls.Add(tbcSidebar)
        pnlSidebar.Controls.Add(pnlSidebarHeader)
        pnlSidebar.Dock = DockStyle.Fill
        pnlSidebar.Location = New Point(0, 0)
        pnlSidebar.Margin = New Padding(0)
        pnlSidebar.Name = "pnlSidebar"
        pnlSidebar.Size = New Size(300, 750)
        pnlSidebar.TabIndex = 0
        pnlSidebar.Visible = False
        ' 
        ' tbcSidebar
        ' 
        tbcSidebar.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        tbcSidebar.Appearance = TabAppearance.FlatButtons
        tbcSidebar.Controls.Add(tabBookmarks)
        tbcSidebar.Controls.Add(tabOutline)
        tbcSidebar.Controls.Add(tabAnnotations)
        tbcSidebar.ItemSize = New Size(90, 35)
        tbcSidebar.Location = New Point(0, 50)
        tbcSidebar.Margin = New Padding(0)
        tbcSidebar.Name = "tbcSidebar"
        tbcSidebar.SelectedIndex = 0
        tbcSidebar.Size = New Size(300, 700)
        tbcSidebar.SizeMode = TabSizeMode.Fixed
        tbcSidebar.TabIndex = 1
        ' 
        ' tabBookmarks
        ' 
        tabBookmarks.BackColor = Color.FromArgb(CByte(248), CByte(249), CByte(250))
        tabBookmarks.Controls.Add(trvBookmarks)
        tabBookmarks.Location = New Point(4, 39)
        tabBookmarks.Margin = New Padding(0)
        tabBookmarks.Name = "tabBookmarks"
        tabBookmarks.Size = New Size(292, 657)
        tabBookmarks.TabIndex = 0
        tabBookmarks.Text = "Bookmarks"
        ' 
        ' trvBookmarks
        ' 
        trvBookmarks.BackColor = Color.FromArgb(CByte(248), CByte(249), CByte(250))
        trvBookmarks.BorderStyle = BorderStyle.None
        trvBookmarks.Dock = DockStyle.Fill
        trvBookmarks.Font = New Font("Segoe UI", 10F)
        trvBookmarks.ForeColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        trvBookmarks.FullRowSelect = True
        trvBookmarks.HideSelection = False
        trvBookmarks.Indent = 15
        trvBookmarks.ItemHeight = 30
        trvBookmarks.Location = New Point(0, 0)
        trvBookmarks.Margin = New Padding(15)
        trvBookmarks.Name = "trvBookmarks"
        trvBookmarks.ShowLines = False
        trvBookmarks.ShowPlusMinus = False
        trvBookmarks.Size = New Size(292, 657)
        trvBookmarks.TabIndex = 0
        ' 
        ' tabOutline
        ' 
        tabOutline.BackColor = Color.FromArgb(CByte(248), CByte(249), CByte(250))
        tabOutline.Controls.Add(trvOutline)
        tabOutline.Location = New Point(4, 39)
        tabOutline.Margin = New Padding(0)
        tabOutline.Name = "tabOutline"
        tabOutline.Size = New Size(292, 657)
        tabOutline.TabIndex = 1
        tabOutline.Text = "Outline"
        ' 
        ' trvOutline
        ' 
        trvOutline.BackColor = Color.FromArgb(CByte(248), CByte(249), CByte(250))
        trvOutline.BorderStyle = BorderStyle.None
        trvOutline.Dock = DockStyle.Fill
        trvOutline.Font = New Font("Segoe UI", 10F)
        trvOutline.ForeColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        trvOutline.FullRowSelect = True
        trvOutline.HideSelection = False
        trvOutline.Indent = 15
        trvOutline.ItemHeight = 30
        trvOutline.Location = New Point(0, 0)
        trvOutline.Margin = New Padding(15)
        trvOutline.Name = "trvOutline"
        trvOutline.ShowLines = False
        trvOutline.ShowPlusMinus = False
        trvOutline.Size = New Size(292, 657)
        trvOutline.TabIndex = 0
        ' 
        ' tabAnnotations
        ' 
        tabAnnotations.BackColor = Color.FromArgb(CByte(248), CByte(249), CByte(250))
        tabAnnotations.Controls.Add(lstAnnotations)
        tabAnnotations.Location = New Point(4, 39)
        tabAnnotations.Margin = New Padding(0)
        tabAnnotations.Name = "tabAnnotations"
        tabAnnotations.Size = New Size(292, 657)
        tabAnnotations.TabIndex = 2
        tabAnnotations.Text = "Annotations"
        ' 
        ' lstAnnotations
        ' 
        lstAnnotations.BackColor = Color.FromArgb(CByte(248), CByte(249), CByte(250))
        lstAnnotations.BorderStyle = BorderStyle.None
        lstAnnotations.Dock = DockStyle.Fill
        lstAnnotations.Font = New Font("Segoe UI", 10F)
        lstAnnotations.ForeColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        lstAnnotations.FullRowSelect = True
        lstAnnotations.Location = New Point(0, 0)
        lstAnnotations.Margin = New Padding(4, 5, 4, 5)
        lstAnnotations.Name = "lstAnnotations"
        lstAnnotations.Size = New Size(292, 657)
        lstAnnotations.TabIndex = 0
        lstAnnotations.UseCompatibleStateImageBehavior = False
        lstAnnotations.View = View.List
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
        pnlSidebarHeader.Size = New Size(300, 50)
        pnlSidebarHeader.TabIndex = 2
        ' 
        ' lblSidebarTitle
        ' 
        lblSidebarTitle.AutoSize = True
        lblSidebarTitle.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        lblSidebarTitle.ForeColor = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        lblSidebarTitle.Location = New Point(20, 12)
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
        btnCloseSidebar.Location = New Point(260, 5)
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
        pnlDocumentContainer.Controls.Add(pnlSearch)
        pnlDocumentContainer.Dock = DockStyle.Fill
        pnlDocumentContainer.Location = New Point(300, 0)
        pnlDocumentContainer.Margin = New Padding(0)
        pnlDocumentContainer.Name = "pnlDocumentContainer"
        pnlDocumentContainer.Size = New Size(900, 750)
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
        pnlDocumentView.Size = New Size(900, 700)
        pnlDocumentView.TabIndex = 0
        ' 
        ' lblNoDocument
        ' 
        lblNoDocument.Anchor = AnchorStyles.None
        lblNoDocument.BackColor = Color.Transparent
        lblNoDocument.Font = New Font("Segoe UI Light", 14F)
        lblNoDocument.ForeColor = Color.FromArgb(CByte(150), CByte(150), CByte(150))
        lblNoDocument.Location = New Point(100, 200)
        lblNoDocument.Margin = New Padding(4, 0, 4, 0)
        lblNoDocument.Name = "lblNoDocument"
        lblNoDocument.Size = New Size(700, 300)
        lblNoDocument.TabIndex = 0
        lblNoDocument.Text = "Open a document to begin reading" & vbCrLf & vbCrLf & "Click the folder icon or press Ctrl+O"
        lblNoDocument.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' pnlSearch
        ' 
        pnlSearch.BackColor = Color.FromArgb(CByte(248), CByte(249), CByte(250))
        pnlSearch.Controls.Add(txtSearch)
        pnlSearch.Controls.Add(btnPrevSearch)
        pnlSearch.Controls.Add(btnNextSearch)
        pnlSearch.Controls.Add(btnCloseSearch)
        pnlSearch.Controls.Add(lblSearchResults)
        pnlSearch.Dock = DockStyle.Bottom
        pnlSearch.Location = New Point(0, 700)
        pnlSearch.Margin = New Padding(0)
        pnlSearch.Name = "pnlSearch"
        pnlSearch.Size = New Size(900, 50)
        pnlSearch.TabIndex = 1
        pnlSearch.Visible = False
        ' 
        ' txtSearch
        ' 
        txtSearch.BorderStyle = BorderStyle.FixedSingle
        txtSearch.Font = New Font("Segoe UI", 10F)
        txtSearch.Location = New Point(15, 12)
        txtSearch.Margin = New Padding(15, 12, 4, 5)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(280, 30)
        txtSearch.TabIndex = 0
        ' 
        ' btnPrevSearch
        ' 
        btnPrevSearch.BackColor = Color.FromArgb(CByte(240), CByte(240), CByte(240))
        btnPrevSearch.Enabled = False
        btnPrevSearch.FlatAppearance.BorderColor = Color.FromArgb(CByte(200), CByte(200), CByte(200))
        btnPrevSearch.FlatStyle = FlatStyle.Flat
        btnPrevSearch.Font = New Font("Segoe UI", 9F)
        btnPrevSearch.ForeColor = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        btnPrevSearch.Location = New Point(305, 12)
        btnPrevSearch.Margin = New Padding(4, 5, 4, 5)
        btnPrevSearch.Name = "btnPrevSearch"
        btnPrevSearch.Size = New Size(60, 30)
        btnPrevSearch.TabIndex = 1
        btnPrevSearch.Text = "◀"
        btnPrevSearch.UseVisualStyleBackColor = False
        ' 
        ' btnNextSearch
        ' 
        btnNextSearch.BackColor = Color.FromArgb(CByte(240), CByte(240), CByte(240))
        btnNextSearch.Enabled = False
        btnNextSearch.FlatAppearance.BorderColor = Color.FromArgb(CByte(200), CByte(200), CByte(200))
        btnNextSearch.FlatStyle = FlatStyle.Flat
        btnNextSearch.Font = New Font("Segoe UI", 9F)
        btnNextSearch.ForeColor = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        btnNextSearch.Location = New Point(375, 12)
        btnNextSearch.Margin = New Padding(4, 5, 4, 5)
        btnNextSearch.Name = "btnNextSearch"
        btnNextSearch.Size = New Size(60, 30)
        btnNextSearch.TabIndex = 2
        btnNextSearch.Text = "▶"
        btnNextSearch.UseVisualStyleBackColor = False
        ' 
        ' btnCloseSearch
        ' 
        btnCloseSearch.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnCloseSearch.BackColor = Color.Transparent
        btnCloseSearch.FlatAppearance.BorderSize = 0
        btnCloseSearch.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        btnCloseSearch.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(240), CByte(240), CByte(240))
        btnCloseSearch.FlatStyle = FlatStyle.Flat
        btnCloseSearch.Font = New Font("Segoe UI", 12F)
        btnCloseSearch.ForeColor = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        btnCloseSearch.Location = New Point(860, 5)
        btnCloseSearch.Margin = New Padding(0)
        btnCloseSearch.Name = "btnCloseSearch"
        btnCloseSearch.Size = New Size(40, 40)
        btnCloseSearch.TabIndex = 4
        btnCloseSearch.Text = "×"
        btnCloseSearch.UseVisualStyleBackColor = False
        ' 
        ' lblSearchResults
        ' 
        lblSearchResults.AutoSize = True
        lblSearchResults.Font = New Font("Segoe UI", 10F)
        lblSearchResults.ForeColor = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        lblSearchResults.Location = New Point(445, 15)
        lblSearchResults.Margin = New Padding(4, 0, 4, 0)
        lblSearchResults.Name = "lblSearchResults"
        lblSearchResults.Size = New Size(137, 23)
        lblSearchResults.TabIndex = 3
        lblSearchResults.Text = "No results found"
        lblSearchResults.Visible = False
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
        tlsReaderTools.Items.AddRange(New ToolStripItem() {tsbOpenDocument, tsbToggleSidebar, toolStripSeparator4, tsbPrevPage, tslPageInfo, tsbNextPage, toolStripSeparator1, tsbZoomOut, tscbZoom, tsbZoomIn, toolStripSeparator2, tsbHighlight, tsbNote, tsbBookmark, toolStripSeparator3, tsbSearch, tsbViewMode, cmbTheme, menuSettings})
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
        tsbToggleSidebar.ImageTransparentColor = Color.Magenta
        tsbToggleSidebar.Margin = New Padding(5, 0, 5, 0)
        tsbToggleSidebar.Name = "tsbToggleSidebar"
        tsbToggleSidebar.Size = New Size(40, 40)
        tsbToggleSidebar.Text = "Toggle Sidebar"
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
        tsbZoomOut.ImageTransparentColor = Color.Magenta
        tsbZoomOut.Margin = New Padding(5, 0, 5, 0)
        tsbZoomOut.Name = "tsbZoomOut"
        tsbZoomOut.Size = New Size(40, 40)
        tsbZoomOut.Text = "Zoom Out"
        ' 
        ' tscbZoom
        ' 
        tscbZoom.AutoSize = False
        tscbZoom.DropDownStyle = ComboBoxStyle.DropDownList
        tscbZoom.Enabled = False
        tscbZoom.FlatStyle = FlatStyle.Standard
        tscbZoom.Items.AddRange(New Object() {"50%", "75%", "100%", "125%", "150%", "175%", "200%", "Fit Page", "Fit Width"})
        tscbZoom.Margin = New Padding(2, 0, 2, 0)
        tscbZoom.Name = "tscbZoom"
        tscbZoom.Size = New Size(90, 28)
        ' 
        ' tsbZoomIn
        ' 
        tsbZoomIn.AutoSize = False
        tsbZoomIn.DisplayStyle = ToolStripItemDisplayStyle.Image
        tsbZoomIn.Enabled = False
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
        ' tsbHighlight
        ' 
        tsbHighlight.AutoSize = False
        tsbHighlight.DisplayStyle = ToolStripItemDisplayStyle.Image
        tsbHighlight.DropDown = cmsHighlighting
        tsbHighlight.Enabled = False
        tsbHighlight.ImageTransparentColor = Color.Magenta
        tsbHighlight.Margin = New Padding(5, 0, 5, 0)
        tsbHighlight.Name = "tsbHighlight"
        tsbHighlight.Size = New Size(40, 40)
        tsbHighlight.Text = "Highlight"
        ' 
        ' cmsHighlighting
        ' 
        cmsHighlighting.ImageScalingSize = New Size(20, 20)
        cmsHighlighting.Items.AddRange(New ToolStripItem() {yellowHighlightToolStripMenuItem, blueHighlightToolStripMenuItem, greenHighlightToolStripMenuItem, pinkHighlightToolStripMenuItem, removeHighlightToolStripMenuItem, toolStripMenuItem1, addNoteToolStripMenuItem, copyTextToolStripMenuItem})
        cmsHighlighting.Name = "cmsHighlighting"
        cmsHighlighting.OwnerItem = tsbHighlight
        cmsHighlighting.Size = New Size(199, 178)
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
        ' toolStripMenuItem1
        ' 
        toolStripMenuItem1.Name = "toolStripMenuItem1"
        toolStripMenuItem1.Size = New Size(195, 6)
        ' 
        ' addNoteToolStripMenuItem
        ' 
        addNoteToolStripMenuItem.Name = "addNoteToolStripMenuItem"
        addNoteToolStripMenuItem.Size = New Size(198, 24)
        addNoteToolStripMenuItem.Text = "Add Note"
        ' 
        ' copyTextToolStripMenuItem
        ' 
        copyTextToolStripMenuItem.Name = "copyTextToolStripMenuItem"
        copyTextToolStripMenuItem.Size = New Size(198, 24)
        copyTextToolStripMenuItem.Text = "Copy Text"
        ' 
        ' tsbNote
        ' 
        tsbNote.AutoSize = False
        tsbNote.DisplayStyle = ToolStripItemDisplayStyle.Image
        tsbNote.Enabled = False
        tsbNote.ImageTransparentColor = Color.Magenta
        tsbNote.Margin = New Padding(5, 0, 5, 0)
        tsbNote.Name = "tsbNote"
        tsbNote.Size = New Size(40, 40)
        tsbNote.Text = "Add Note"
        ' 
        ' tsbBookmark
        ' 
        tsbBookmark.AutoSize = False
        tsbBookmark.DisplayStyle = ToolStripItemDisplayStyle.Image
        tsbBookmark.Enabled = False
        tsbBookmark.ImageTransparentColor = Color.Magenta
        tsbBookmark.Margin = New Padding(5, 0, 5, 0)
        tsbBookmark.Name = "tsbBookmark"
        tsbBookmark.Size = New Size(40, 40)
        tsbBookmark.Text = "Add Bookmark"
        ' 
        ' toolStripSeparator3
        ' 
        toolStripSeparator3.Margin = New Padding(10, 0, 10, 0)
        toolStripSeparator3.Name = "toolStripSeparator3"
        toolStripSeparator3.Size = New Size(6, 60)
        ' 
        ' tsbSearch
        ' 
        tsbSearch.AutoSize = False
        tsbSearch.DisplayStyle = ToolStripItemDisplayStyle.Image
        tsbSearch.Enabled = False
        tsbSearch.ImageTransparentColor = Color.Magenta
        tsbSearch.Margin = New Padding(5, 0, 5, 0)
        tsbSearch.Name = "tsbSearch"
        tsbSearch.Size = New Size(40, 40)
        tsbSearch.Text = "Search"
        ' 
        ' tsbViewMode
        ' 
        tsbViewMode.AutoSize = False
        tsbViewMode.DisplayStyle = ToolStripItemDisplayStyle.Image
        tsbViewMode.DropDownItems.AddRange(New ToolStripItem() {singlePageToolStripMenuItem1, twoPagesToolStripMenuItem1})
        tsbViewMode.Enabled = False
        tsbViewMode.ImageTransparentColor = Color.Magenta
        tsbViewMode.Margin = New Padding(5, 0, 5, 0)
        tsbViewMode.Name = "tsbViewMode"
        tsbViewMode.Size = New Size(40, 40)
        tsbViewMode.Text = "View Mode"
        ' 
        ' singlePageToolStripMenuItem1
        ' 
        singlePageToolStripMenuItem1.Checked = True
        singlePageToolStripMenuItem1.CheckState = CheckState.Checked
        singlePageToolStripMenuItem1.Name = "singlePageToolStripMenuItem1"
        singlePageToolStripMenuItem1.Size = New Size(182, 28)
        singlePageToolStripMenuItem1.Text = "Single Page"
        ' 
        ' twoPagesToolStripMenuItem1
        ' 
        twoPagesToolStripMenuItem1.Name = "twoPagesToolStripMenuItem1"
        twoPagesToolStripMenuItem1.Size = New Size(182, 28)
        twoPagesToolStripMenuItem1.Text = "Two Pages"
        ' 
        ' cmbTheme
        ' 
        cmbTheme.AutoSize = False
        cmbTheme.DisplayStyle = ToolStripItemDisplayStyle.Image
        cmbTheme.DropDownItems.AddRange(New ToolStripItem() {lightModeToolStripMenuItem, darkModeToolStripMenuItem, sepiaToolStripMenuItem})
        cmbTheme.Enabled = False
        cmbTheme.ImageTransparentColor = Color.Magenta
        cmbTheme.Margin = New Padding(5, 0, 5, 0)
        cmbTheme.Name = "cmbTheme"
        cmbTheme.Size = New Size(40, 40)
        cmbTheme.Text = "Theme"
        ' 
        ' lightModeToolStripMenuItem
        ' 
        lightModeToolStripMenuItem.Checked = True
        lightModeToolStripMenuItem.CheckState = CheckState.Checked
        lightModeToolStripMenuItem.Name = "lightModeToolStripMenuItem"
        lightModeToolStripMenuItem.Size = New Size(181, 28)
        lightModeToolStripMenuItem.Text = "Light Mode"
        ' 
        ' darkModeToolStripMenuItem
        ' 
        darkModeToolStripMenuItem.Name = "darkModeToolStripMenuItem"
        darkModeToolStripMenuItem.Size = New Size(181, 28)
        darkModeToolStripMenuItem.Text = "Dark Mode"
        ' 
        ' sepiaToolStripMenuItem
        ' 
        sepiaToolStripMenuItem.Name = "sepiaToolStripMenuItem"
        sepiaToolStripMenuItem.Size = New Size(181, 28)
        sepiaToolStripMenuItem.Text = "Sepia"
        ' 
        ' menuSettings
        ' 
        menuSettings.Alignment = ToolStripItemAlignment.Right
        menuSettings.AutoSize = False
        menuSettings.DisplayStyle = ToolStripItemDisplayStyle.Image
        menuSettings.DropDownItems.AddRange(New ToolStripItem() {preferencesToolStripMenuItem, helpToolStripMenuItem1, aboutToolStripMenuItem1})
        menuSettings.ImageTransparentColor = Color.Magenta
        menuSettings.Margin = New Padding(5, 0, 10, 0)
        menuSettings.Name = "menuSettings"
        menuSettings.Size = New Size(40, 40)
        menuSettings.Text = "Settings"
        ' 
        ' preferencesToolStripMenuItem
        ' 
        preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem"
        preferencesToolStripMenuItem.Size = New Size(182, 28)
        preferencesToolStripMenuItem.Text = "Preferences"
        ' 
        ' helpToolStripMenuItem1
        ' 
        helpToolStripMenuItem1.Name = "helpToolStripMenuItem1"
        helpToolStripMenuItem1.Size = New Size(182, 28)
        helpToolStripMenuItem1.Text = "Help"
        ' 
        ' aboutToolStripMenuItem1
        ' 
        aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1"
        aboutToolStripMenuItem1.Size = New Size(182, 28)
        aboutToolStripMenuItem1.Text = "About"
        ' 
        ' pnlFooter
        ' 
        pnlFooter.BackColor = Color.FromArgb(CByte(248), CByte(249), CByte(250))
        pnlFooter.Controls.Add(statusPanel)
        pnlFooter.Dock = DockStyle.Bottom
        pnlFooter.Location = New Point(0, 810)
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
        statusPanel.Margin = New Padding(4, 5, 4, 5)
        statusPanel.Name = "statusPanel"
        statusPanel.Padding = New Padding(20, 5, 20, 5)
        statusPanel.Size = New Size(1200, 40)
        statusPanel.TabIndex = 0
        ' 
        ' pnlProgressContainer
        ' 
        pnlProgressContainer.Controls.Add(progressBar)
        pnlProgressContainer.Controls.Add(lblProgressPercentage)
        pnlProgressContainer.Dock = DockStyle.Left
        pnlProgressContainer.Location = New Point(20, 5)
        pnlProgressContainer.Margin = New Padding(4, 5, 4, 5)
        pnlProgressContainer.Name = "pnlProgressContainer"
        pnlProgressContainer.Size = New Size(700, 30)
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
        lblProgressPercentage.Location = New Point(650, 0)
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
        pnlReadingStats.Location = New Point(930, 5)
        pnlReadingStats.Margin = New Padding(4, 5, 4, 5)
        pnlReadingStats.Name = "pnlReadingStats"
        pnlReadingStats.Size = New Size(250, 30)
        pnlReadingStats.TabIndex = 1
        ' 
        ' btnTimerControl
        ' 
        btnTimerControl.BackColor = Color.FromArgb(CByte(240), CByte(240), CByte(240))
        btnTimerControl.Dock = DockStyle.Right
        btnTimerControl.Enabled = False
        btnTimerControl.FlatAppearance.BorderColor = Color.FromArgb(CByte(200), CByte(200), CByte(200))
        btnTimerControl.FlatStyle = FlatStyle.Flat
        btnTimerControl.Font = New Font("Segoe UI", 9F)
        btnTimerControl.ForeColor = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        btnTimerControl.Location = New Point(190, 0)
        btnTimerControl.Margin = New Padding(4, 5, 4, 5)
        btnTimerControl.Name = "btnTimerControl"
        btnTimerControl.Size = New Size(60, 30)
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
        lblTimerDisplay.Size = New Size(180, 30)
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
        SearchDialog1.Margin = New Padding(4, 5, 4, 5)
        SearchDialog1.Name = "SearchDialog1"
        SearchDialog1.Size = New Size(53, 37)
        SearchDialog1.TabIndex = 0
        SearchDialog1.Text = ""
        SearchDialog1.Visible = False
        ' 
        ' BookmarkDialog1
        ' 
        BookmarkDialog1.Location = New Point(1155, 12)
        BookmarkDialog1.Margin = New Padding(4, 5, 4, 5)
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
        ClientSize = New Size(1200, 850)
        Controls.Add(pnlMainContainer)
        Controls.Add(pnlHeader)
        Controls.Add(pnlFooter)
        Controls.Add(SearchDialog1)
        Controls.Add(BookmarkDialog1)
        Margin = New Padding(4, 5, 4, 5)
        MinimumSize = New Size(800, 600)
        Name = "BookReaderForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Book Reader"
        pnlMainContainer.ResumeLayout(False)
        pnlSidebar.ResumeLayout(False)
        tbcSidebar.ResumeLayout(False)
        tabBookmarks.ResumeLayout(False)
        tabOutline.ResumeLayout(False)
        tabAnnotations.ResumeLayout(False)
        pnlSidebarHeader.ResumeLayout(False)
        pnlSidebarHeader.PerformLayout()
        pnlDocumentContainer.ResumeLayout(False)
        pnlDocumentView.ResumeLayout(False)
        pnlSearch.ResumeLayout(False)
        pnlSearch.PerformLayout()
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
    Friend WithEvents tbcSidebar As TabControl
    Friend WithEvents tabBookmarks As TabPage
    Friend WithEvents trvBookmarks As TreeView
    Friend WithEvents tabOutline As TabPage
    Friend WithEvents trvOutline As TreeView
    Friend WithEvents tabAnnotations As TabPage
    Friend WithEvents lstAnnotations As ListView
    Friend WithEvents pnlSidebarHeader As Panel
    Friend WithEvents lblSidebarTitle As Label
    Friend WithEvents btnCloseSidebar As Button
    Friend WithEvents pnlDocumentContainer As Panel
    Friend WithEvents pnlDocumentView As Panel
    Friend WithEvents lblNoDocument As Label
    Friend WithEvents pnlSearch As Panel
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnPrevSearch As Button
    Friend WithEvents btnNextSearch As Button
    Friend WithEvents btnCloseSearch As Button
    Friend WithEvents lblSearchResults As Label
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
    Friend WithEvents tscbZoom As ToolStripComboBox
    Friend WithEvents tsbZoomIn As ToolStripButton
    Friend WithEvents toolStripSeparator2 As ToolStripSeparator
    Friend WithEvents tsbHighlight As ToolStripDropDownButton
    Friend WithEvents cmsHighlighting As ContextMenuStrip
    Friend WithEvents yellowHighlightToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents blueHighlightToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents greenHighlightToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents pinkHighlightToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents removeHighlightToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents addNoteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents copyTextToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tsbNote As ToolStripButton
    Friend WithEvents tsbBookmark As ToolStripButton
    Friend WithEvents toolStripSeparator3 As ToolStripSeparator
    Friend WithEvents tsbSearch As ToolStripButton
    Friend WithEvents tsbViewMode As ToolStripDropDownButton
    Friend WithEvents singlePageToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents twoPagesToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents cmbTheme As ToolStripDropDownButton
    Friend WithEvents lightModeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents darkModeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents sepiaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents menuSettings As ToolStripDropDownButton
    Friend WithEvents preferencesToolStripMenuItem As ToolStripMenuItem
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
End Class