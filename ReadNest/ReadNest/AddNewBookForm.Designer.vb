<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddNewBookForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddNewBookForm))
        Label2 = New Label()
        lblUsername = New Label()
        pbProfile = New PictureBox()
        txtAddBookWriter = New TextBox()
        txtAddBookTitle = New TextBox()
        Label4 = New Label()
        PictureBox9 = New PictureBox()
        Label5 = New Label()
        BtnAddNewBook = New Button()
        Label7 = New Label()
        cbAddCategory = New ComboBox()
        Label8 = New Label()
        txtAddPages = New TextBox()
        PictureBox7 = New PictureBox()
        btnUploadBook = New Button()
        pbBB = New PictureBox()
        lblBB = New Label()
        lblstatistic = New Label()
        pbStatistic = New PictureBox()
        lblDiscover = New Label()
        pbDiscover = New PictureBox()
        lblMenu = New Label()
        lblFavorite = New Label()
        lblNotes = New Label()
        lblCategory = New Label()
        Label1 = New Label()
        pbFavorite = New PictureBox()
        pbNotes = New PictureBox()
        pbCategory = New PictureBox()
        SplitContainer1 = New SplitContainer()
        panelSidebar = New Panel()
        PictureBox2 = New PictureBox()
        panelContent = New Panel()
        panelForm = New Panel()
        Label3 = New Label()
        txtFilePath = New TextBox()
        btnUploadFile = New Button()
        tableLayoutPanel1 = New TableLayoutPanel()
        tbDesc = New TextBox()
        lblDesc = New Label()
        panelHeader = New Panel()
        OpenFileDialog1 = New OpenFileDialog()
        CType(pbProfile, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox9, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbBB, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbStatistic, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbDiscover, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbFavorite, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbNotes, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbCategory, ComponentModel.ISupportInitialize).BeginInit()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel1.SuspendLayout()
        SplitContainer1.Panel2.SuspendLayout()
        SplitContainer1.SuspendLayout()
        panelSidebar.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        panelContent.SuspendLayout()
        panelForm.SuspendLayout()
        tableLayoutPanel1.SuspendLayout()
        panelHeader.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold)
        Label2.ForeColor = SystemColors.ControlText
        Label2.ImageAlign = ContentAlignment.TopRight
        Label2.Location = New Point(23, 20)
        Label2.Name = "Label2"
        Label2.Size = New Size(212, 32)
        Label2.TabIndex = 42
        Label2.Text = "Add New Book"
        ' 
        ' lblUsername
        ' 
        lblUsername.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblUsername.AutoSize = True
        lblUsername.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        lblUsername.Location = New Point(755, 20)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(69, 24)
        lblUsername.TabIndex = 44
        lblUsername.Text = "Profile"
        ' 
        ' pbProfile
        ' 
        pbProfile.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        pbProfile.BackgroundImage = CType(resources.GetObject("pbProfile.BackgroundImage"), Image)
        pbProfile.BackgroundImageLayout = ImageLayout.Stretch
        pbProfile.Location = New Point(717, 13)
        pbProfile.Margin = New Padding(3, 4, 3, 4)
        pbProfile.Name = "pbProfile"
        pbProfile.Size = New Size(32, 37)
        pbProfile.TabIndex = 43
        pbProfile.TabStop = False
        ' 
        ' txtAddBookWriter
        ' 
        txtAddBookWriter.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        txtAddBookWriter.Font = New Font("Segoe UI", 11.0F)
        txtAddBookWriter.Location = New Point(135, 53)
        txtAddBookWriter.Margin = New Padding(3, 4, 3, 4)
        txtAddBookWriter.Name = "txtAddBookWriter"
        txtAddBookWriter.PlaceholderText = "Enter Book Writer here"
        txtAddBookWriter.Size = New Size(447, 32)
        txtAddBookWriter.TabIndex = 45
        ' 
        ' txtAddBookTitle
        ' 
        txtAddBookTitle.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        txtAddBookTitle.Font = New Font("Segoe UI", 11.0F)
        txtAddBookTitle.Location = New Point(135, 6)
        txtAddBookTitle.Margin = New Padding(3, 4, 3, 4)
        txtAddBookTitle.Name = "txtAddBookTitle"
        txtAddBookTitle.PlaceholderText = "Enter Book Title here"
        txtAddBookTitle.Size = New Size(447, 32)
        txtAddBookTitle.TabIndex = 46
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Left
        Label4.AutoSize = True
        Label4.BackColor = Color.Cornsilk
        Label4.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label4.Location = New Point(3, 10)
        Label4.Name = "Label4"
        Label4.Size = New Size(103, 24)
        Label4.TabIndex = 47
        Label4.Text = "Book Title"
        ' 
        ' PictureBox9
        ' 
        PictureBox9.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        PictureBox9.BackColor = Color.Cornsilk
        PictureBox9.BorderStyle = BorderStyle.FixedSingle
        PictureBox9.Location = New Point(11, 13)
        PictureBox9.Margin = New Padding(3, 4, 3, 4)
        PictureBox9.Name = "PictureBox9"
        PictureBox9.Size = New Size(799, 457)
        PictureBox9.TabIndex = 48
        PictureBox9.TabStop = False
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Left
        Label5.AutoSize = True
        Label5.BackColor = Color.Cornsilk
        Label5.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label5.Location = New Point(3, 57)
        Label5.Name = "Label5"
        Label5.Size = New Size(118, 24)
        Label5.TabIndex = 49
        Label5.Text = "Book Writer"
        ' 
        ' BtnAddNewBook
        ' 
        BtnAddNewBook.Anchor = AnchorStyles.Right
        BtnAddNewBook.AutoSize = True
        BtnAddNewBook.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        BtnAddNewBook.Location = New Point(496, 353)
        BtnAddNewBook.Margin = New Padding(3, 4, 3, 4)
        BtnAddNewBook.Name = "BtnAddNewBook"
        BtnAddNewBook.Size = New Size(86, 31)
        BtnAddNewBook.TabIndex = 50
        BtnAddNewBook.Text = "Add"
        BtnAddNewBook.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Left
        Label7.AutoSize = True
        Label7.BackColor = Color.Cornsilk
        Label7.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label7.Location = New Point(3, 104)
        Label7.Name = "Label7"
        Label7.Size = New Size(93, 24)
        Label7.TabIndex = 68
        Label7.Text = "Category"
        ' 
        ' cbAddCategory
        ' 
        cbAddCategory.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        cbAddCategory.Font = New Font("Segoe UI", 11.0F)
        cbAddCategory.FormattingEnabled = True
        cbAddCategory.Location = New Point(135, 99)
        cbAddCategory.Margin = New Padding(3, 4, 3, 4)
        cbAddCategory.Name = "cbAddCategory"
        cbAddCategory.Size = New Size(447, 33)
        cbAddCategory.TabIndex = 69
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Left
        Label8.AutoSize = True
        Label8.BackColor = Color.Cornsilk
        Label8.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label8.Location = New Point(3, 150)
        Label8.Name = "Label8"
        Label8.Size = New Size(68, 24)
        Label8.TabIndex = 70
        Label8.Text = "Pages"
        ' 
        ' txtAddPages
        ' 
        txtAddPages.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        txtAddPages.Font = New Font("Segoe UI", 11.0F)
        txtAddPages.Location = New Point(135, 146)
        txtAddPages.Margin = New Padding(3, 4, 3, 4)
        txtAddPages.Name = "txtAddPages"
        txtAddPages.PlaceholderText = "Enter Number of pages"
        txtAddPages.Size = New Size(447, 32)
        txtAddPages.TabIndex = 71
        ' 
        ' PictureBox7
        ' 
        PictureBox7.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        PictureBox7.BorderStyle = BorderStyle.FixedSingle
        PictureBox7.Location = New Point(640, 53)
        PictureBox7.Margin = New Padding(3, 4, 3, 4)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(150, 201)
        PictureBox7.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox7.TabIndex = 73
        PictureBox7.TabStop = False
        ' 
        ' btnUploadBook
        ' 
        btnUploadBook.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnUploadBook.AutoSize = True
        btnUploadBook.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        btnUploadBook.Location = New Point(640, 274)
        btnUploadBook.Margin = New Padding(3, 4, 3, 4)
        btnUploadBook.Name = "btnUploadBook"
        btnUploadBook.Size = New Size(150, 39)
        btnUploadBook.TabIndex = 74
        btnUploadBook.Text = "Upload Cover"
        btnUploadBook.UseVisualStyleBackColor = True
        ' 
        ' pbBB
        ' 
        pbBB.BackColor = SystemColors.Info
        pbBB.BackgroundImage = CType(resources.GetObject("pbBB.BackgroundImage"), Image)
        pbBB.BackgroundImageLayout = ImageLayout.Stretch
        pbBB.Location = New Point(14, 336)
        pbBB.Margin = New Padding(3, 4, 3, 4)
        pbBB.Name = "pbBB"
        pbBB.Size = New Size(32, 37)
        pbBB.TabIndex = 88
        pbBB.TabStop = False
        ' 
        ' lblBB
        ' 
        lblBB.AutoSize = True
        lblBB.BackColor = SystemColors.Info
        lblBB.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold)
        lblBB.ImageAlign = ContentAlignment.TopRight
        lblBB.Location = New Point(53, 347)
        lblBB.Name = "lblBB"
        lblBB.Size = New Size(158, 24)
        lblBB.TabIndex = 87
        lblBB.Text = "Book Borrowing"
        ' 
        ' lblstatistic
        ' 
        lblstatistic.AutoSize = True
        lblstatistic.BackColor = SystemColors.Info
        lblstatistic.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold)
        lblstatistic.ImageAlign = ContentAlignment.TopRight
        lblstatistic.Location = New Point(53, 392)
        lblstatistic.Name = "lblstatistic"
        lblstatistic.Size = New Size(113, 24)
        lblstatistic.TabIndex = 86
        lblstatistic.Text = "My Statistic"
        ' 
        ' pbStatistic
        ' 
        pbStatistic.BackColor = SystemColors.Info
        pbStatistic.BackgroundImage = CType(resources.GetObject("pbStatistic.BackgroundImage"), Image)
        pbStatistic.BackgroundImageLayout = ImageLayout.Stretch
        pbStatistic.Location = New Point(14, 381)
        pbStatistic.Margin = New Padding(3, 4, 3, 4)
        pbStatistic.Name = "pbStatistic"
        pbStatistic.Size = New Size(32, 37)
        pbStatistic.TabIndex = 85
        pbStatistic.TabStop = False
        ' 
        ' lblDiscover
        ' 
        lblDiscover.AutoSize = True
        lblDiscover.BackColor = SystemColors.Info
        lblDiscover.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold)
        lblDiscover.ImageAlign = ContentAlignment.TopRight
        lblDiscover.Location = New Point(53, 163)
        lblDiscover.Name = "lblDiscover"
        lblDiscover.Size = New Size(91, 24)
        lblDiscover.TabIndex = 84
        lblDiscover.Text = "Discover"
        ' 
        ' pbDiscover
        ' 
        pbDiscover.BackColor = SystemColors.Info
        pbDiscover.BackgroundImage = CType(resources.GetObject("pbDiscover.BackgroundImage"), Image)
        pbDiscover.BackgroundImageLayout = ImageLayout.Stretch
        pbDiscover.Location = New Point(14, 152)
        pbDiscover.Margin = New Padding(3, 4, 3, 4)
        pbDiscover.Name = "pbDiscover"
        pbDiscover.Size = New Size(32, 37)
        pbDiscover.TabIndex = 83
        pbDiscover.TabStop = False
        ' 
        ' lblMenu
        ' 
        lblMenu.AutoSize = True
        lblMenu.BackColor = SystemColors.Info
        lblMenu.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        lblMenu.ImageAlign = ContentAlignment.TopRight
        lblMenu.Location = New Point(14, 113)
        lblMenu.Name = "lblMenu"
        lblMenu.Size = New Size(63, 24)
        lblMenu.TabIndex = 82
        lblMenu.Text = "Menu"
        ' 
        ' lblFavorite
        ' 
        lblFavorite.AutoSize = True
        lblFavorite.BackColor = SystemColors.Info
        lblFavorite.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold)
        lblFavorite.ImageAlign = ContentAlignment.TopRight
        lblFavorite.Location = New Point(53, 303)
        lblFavorite.Name = "lblFavorite"
        lblFavorite.Size = New Size(85, 24)
        lblFavorite.TabIndex = 81
        lblFavorite.Text = "Favorite"
        ' 
        ' lblNotes
        ' 
        lblNotes.AutoSize = True
        lblNotes.BackColor = SystemColors.Info
        lblNotes.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold)
        lblNotes.ImageAlign = ContentAlignment.TopRight
        lblNotes.Location = New Point(53, 255)
        lblNotes.Name = "lblNotes"
        lblNotes.Size = New Size(97, 24)
        lblNotes.TabIndex = 80
        lblNotes.Text = "My Notes"
        ' 
        ' lblCategory
        ' 
        lblCategory.AutoSize = True
        lblCategory.BackColor = SystemColors.Info
        lblCategory.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold)
        lblCategory.ImageAlign = ContentAlignment.TopRight
        lblCategory.Location = New Point(53, 208)
        lblCategory.Name = "lblCategory"
        lblCategory.Size = New Size(93, 24)
        lblCategory.TabIndex = 79
        lblCategory.Text = "Category"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.Info
        Label1.Font = New Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label1.ForeColor = SystemColors.ControlText
        Label1.ImageAlign = ContentAlignment.TopRight
        Label1.Location = New Point(14, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(177, 39)
        Label1.TabIndex = 78
        Label1.Text = "ReadNest"
        ' 
        ' pbFavorite
        ' 
        pbFavorite.BackColor = SystemColors.Info
        pbFavorite.BackgroundImage = CType(resources.GetObject("pbFavorite.BackgroundImage"), Image)
        pbFavorite.BackgroundImageLayout = ImageLayout.Stretch
        pbFavorite.Location = New Point(14, 291)
        pbFavorite.Margin = New Padding(3, 4, 3, 4)
        pbFavorite.Name = "pbFavorite"
        pbFavorite.Size = New Size(32, 37)
        pbFavorite.TabIndex = 77
        pbFavorite.TabStop = False
        ' 
        ' pbNotes
        ' 
        pbNotes.BackColor = SystemColors.Info
        pbNotes.BackgroundImage = CType(resources.GetObject("pbNotes.BackgroundImage"), Image)
        pbNotes.BackgroundImageLayout = ImageLayout.Stretch
        pbNotes.Location = New Point(14, 243)
        pbNotes.Margin = New Padding(3, 4, 3, 4)
        pbNotes.Name = "pbNotes"
        pbNotes.Size = New Size(32, 37)
        pbNotes.TabIndex = 76
        pbNotes.TabStop = False
        ' 
        ' pbCategory
        ' 
        pbCategory.BackColor = SystemColors.Info
        pbCategory.BackgroundImage = CType(resources.GetObject("pbCategory.BackgroundImage"), Image)
        pbCategory.BackgroundImageLayout = ImageLayout.Stretch
        pbCategory.Location = New Point(14, 197)
        pbCategory.Margin = New Padding(3, 4, 3, 4)
        pbCategory.Name = "pbCategory"
        pbCategory.Size = New Size(32, 37)
        pbCategory.TabIndex = 75
        pbCategory.TabStop = False
        ' 
        ' SplitContainer1
        ' 
        SplitContainer1.Dock = DockStyle.Fill
        SplitContainer1.FixedPanel = FixedPanel.Panel1
        SplitContainer1.Location = New Point(0, 0)
        SplitContainer1.Margin = New Padding(3, 4, 3, 4)
        SplitContainer1.Name = "SplitContainer1"
        ' 
        ' SplitContainer1.Panel1
        ' 
        SplitContainer1.Panel1.Controls.Add(panelSidebar)
        SplitContainer1.Panel1MinSize = 186
        ' 
        ' SplitContainer1.Panel2
        ' 
        SplitContainer1.Panel2.Controls.Add(panelContent)
        SplitContainer1.Size = New Size(1067, 648)
        SplitContainer1.SplitterDistance = 213
        SplitContainer1.SplitterWidth = 5
        SplitContainer1.TabIndex = 89
        ' 
        ' panelSidebar
        ' 
        panelSidebar.Controls.Add(Label1)
        panelSidebar.Controls.Add(lblMenu)
        panelSidebar.Controls.Add(pbDiscover)
        panelSidebar.Controls.Add(lblDiscover)
        panelSidebar.Controls.Add(pbCategory)
        panelSidebar.Controls.Add(lblCategory)
        panelSidebar.Controls.Add(pbNotes)
        panelSidebar.Controls.Add(lblNotes)
        panelSidebar.Controls.Add(pbFavorite)
        panelSidebar.Controls.Add(lblFavorite)
        panelSidebar.Controls.Add(pbBB)
        panelSidebar.Controls.Add(lblBB)
        panelSidebar.Controls.Add(pbStatistic)
        panelSidebar.Controls.Add(lblstatistic)
        panelSidebar.Controls.Add(PictureBox2)
        panelSidebar.Dock = DockStyle.Fill
        panelSidebar.Location = New Point(0, 0)
        panelSidebar.Margin = New Padding(3, 4, 3, 4)
        panelSidebar.Name = "panelSidebar"
        panelSidebar.Size = New Size(213, 648)
        panelSidebar.TabIndex = 0
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = SystemColors.Info
        PictureBox2.BorderStyle = BorderStyle.FixedSingle
        PictureBox2.Dock = DockStyle.Fill
        PictureBox2.Location = New Point(0, 0)
        PictureBox2.Margin = New Padding(3, 4, 3, 4)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(213, 648)
        PictureBox2.TabIndex = 22
        PictureBox2.TabStop = False
        ' 
        ' panelContent
        ' 
        panelContent.Controls.Add(panelForm)
        panelContent.Controls.Add(panelHeader)
        panelContent.Dock = DockStyle.Fill
        panelContent.Location = New Point(0, 0)
        panelContent.Margin = New Padding(3, 4, 3, 4)
        panelContent.Name = "panelContent"
        panelContent.Padding = New Padding(11, 13, 11, 13)
        panelContent.Size = New Size(849, 648)
        panelContent.TabIndex = 0
        ' 
        ' panelForm
        ' 
        panelForm.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        panelForm.Controls.Add(Label3)
        panelForm.Controls.Add(txtFilePath)
        panelForm.Controls.Add(btnUploadFile)
        panelForm.Controls.Add(btnUploadBook)
        panelForm.Controls.Add(PictureBox7)
        panelForm.Controls.Add(tableLayoutPanel1)
        panelForm.Controls.Add(PictureBox9)
        panelForm.Location = New Point(11, 80)
        panelForm.Margin = New Padding(3, 4, 3, 4)
        panelForm.Name = "panelForm"
        panelForm.Size = New Size(827, 555)
        panelForm.TabIndex = 0
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.BackColor = Color.Cornsilk
        Label3.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label3.Location = New Point(640, 330)
        Label3.Name = "Label3"
        Label3.Size = New Size(92, 24)
        Label3.TabIndex = 77
        Label3.Text = "File Path"
        ' 
        ' txtFilePath
        ' 
        txtFilePath.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtFilePath.Font = New Font("Segoe UI", 11.0F)
        txtFilePath.Location = New Point(640, 358)
        txtFilePath.Margin = New Padding(3, 4, 3, 4)
        txtFilePath.Name = "txtFilePath"
        txtFilePath.ReadOnly = True
        txtFilePath.Size = New Size(150, 32)
        txtFilePath.TabIndex = 76
        ' 
        ' btnUploadFile
        ' 
        btnUploadFile.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnUploadFile.AutoSize = True
        btnUploadFile.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        btnUploadFile.Location = New Point(640, 398)
        btnUploadFile.Margin = New Padding(3, 4, 3, 4)
        btnUploadFile.Name = "btnUploadFile"
        btnUploadFile.Size = New Size(150, 39)
        btnUploadFile.TabIndex = 75
        btnUploadFile.Text = "Upload File"
        btnUploadFile.UseVisualStyleBackColor = True
        ' 
        ' tableLayoutPanel1
        ' 
        tableLayoutPanel1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        tableLayoutPanel1.BackColor = Color.Cornsilk
        tableLayoutPanel1.ColumnCount = 2
        tableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 22.5641022F))
        tableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 77.4359F))
        tableLayoutPanel1.Controls.Add(tbDesc, 1, 4)
        tableLayoutPanel1.Controls.Add(lblDesc, 0, 4)
        tableLayoutPanel1.Controls.Add(Label4, 0, 0)
        tableLayoutPanel1.Controls.Add(txtAddBookTitle, 1, 0)
        tableLayoutPanel1.Controls.Add(Label5, 0, 1)
        tableLayoutPanel1.Controls.Add(txtAddBookWriter, 1, 1)
        tableLayoutPanel1.Controls.Add(Label7, 0, 2)
        tableLayoutPanel1.Controls.Add(cbAddCategory, 1, 2)
        tableLayoutPanel1.Controls.Add(Label8, 0, 3)
        tableLayoutPanel1.Controls.Add(txtAddPages, 1, 3)
        tableLayoutPanel1.Controls.Add(BtnAddNewBook, 1, 5)
        tableLayoutPanel1.Location = New Point(34, 53)
        tableLayoutPanel1.Margin = New Padding(3, 4, 3, 4)
        tableLayoutPanel1.Name = "tableLayoutPanel1"
        tableLayoutPanel1.RowCount = 6
        tableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 12.8939829F))
        tableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 13.753582F))
        tableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 13.1805153F))
        tableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 13.4670486F))
        tableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 46.7048721F))
        tableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 38.0F))
        tableLayoutPanel1.Size = New Size(585, 388)
        tableLayoutPanel1.TabIndex = 49
        ' 
        ' tbDesc
        ' 
        tbDesc.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        tbDesc.Font = New Font("Segoe UI", 11.0F)
        tbDesc.Location = New Point(135, 195)
        tbDesc.Margin = New Padding(3, 4, 3, 4)
        tbDesc.Multiline = True
        tbDesc.Name = "tbDesc"
        tbDesc.PlaceholderText = "Enter Book Description here"
        tbDesc.Size = New Size(447, 144)
        tbDesc.TabIndex = 73
        ' 
        ' lblDesc
        ' 
        lblDesc.Anchor = AnchorStyles.Left
        lblDesc.AutoSize = True
        lblDesc.BackColor = Color.Cornsilk
        lblDesc.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        lblDesc.Location = New Point(3, 255)
        lblDesc.Name = "lblDesc"
        lblDesc.Size = New Size(115, 24)
        lblDesc.TabIndex = 72
        lblDesc.Text = "Description"
        ' 
        ' panelHeader
        ' 
        panelHeader.Controls.Add(Label2)
        panelHeader.Controls.Add(lblUsername)
        panelHeader.Controls.Add(pbProfile)
        panelHeader.Dock = DockStyle.Top
        panelHeader.Location = New Point(11, 13)
        panelHeader.Margin = New Padding(3, 4, 3, 4)
        panelHeader.Name = "panelHeader"
        panelHeader.Size = New Size(827, 67)
        panelHeader.TabIndex = 1
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        OpenFileDialog1.Filter = "PDF Files|*.pdf|EPUB Files|*.epub|All Files|*.*"
        ' 
        ' AddNewBookForm
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1067, 648)
        Controls.Add(SplitContainer1)
        Margin = New Padding(3, 4, 3, 4)
        MinimumSize = New Size(912, 684)
        Name = "AddNewBookForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ReadNest - Add New Book"
        CType(pbProfile, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox9, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(pbBB, ComponentModel.ISupportInitialize).EndInit()
        CType(pbStatistic, ComponentModel.ISupportInitialize).EndInit()
        CType(pbDiscover, ComponentModel.ISupportInitialize).EndInit()
        CType(pbFavorite, ComponentModel.ISupportInitialize).EndInit()
        CType(pbNotes, ComponentModel.ISupportInitialize).EndInit()
        CType(pbCategory, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.Panel1.ResumeLayout(False)
        SplitContainer1.Panel2.ResumeLayout(False)
        CType(SplitContainer1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
        panelSidebar.ResumeLayout(False)
        panelSidebar.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        panelContent.ResumeLayout(False)
        panelForm.ResumeLayout(False)
        panelForm.PerformLayout()
        tableLayoutPanel1.ResumeLayout(False)
        tableLayoutPanel1.PerformLayout()
        panelHeader.ResumeLayout(False)
        panelHeader.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents pbProfile As PictureBox
    Friend WithEvents txtAddBookWriter As TextBox
    Friend WithEvents txtAddBookTitle As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnAddNewBook As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents cbAddCategory As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtAddPages As TextBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents btnUploadBook As Button
    Friend WithEvents pbBB As PictureBox
    Friend WithEvents lblBB As Label
    Friend WithEvents lblstatistic As Label
    Friend WithEvents pbStatistic As PictureBox
    Friend WithEvents lblDiscover As Label
    Friend WithEvents pbDiscover As PictureBox
    Friend WithEvents lblMenu As Label
    Friend WithEvents lblFavorite As Label
    Friend WithEvents lblNotes As Label
    Friend WithEvents lblCategory As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents pbFavorite As PictureBox
    Friend WithEvents pbNotes As PictureBox
    Friend WithEvents pbCategory As PictureBox
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents panelSidebar As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents panelContent As Panel
    Friend WithEvents panelForm As Panel
    Friend WithEvents tableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents tbDesc As TextBox
    Friend WithEvents lblDesc As Label
    Friend WithEvents panelHeader As Panel
    Friend WithEvents btnUploadFile As Button
    Friend WithEvents txtFilePath As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class