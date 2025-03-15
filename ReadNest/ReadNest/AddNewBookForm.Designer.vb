<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddNewBookForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
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
        PictureBox2 = New PictureBox()
        Splitter1 = New Splitter()
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
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("UD Digi Kyokasho NP-B", 16.2F, FontStyle.Bold)
        Label2.ForeColor = SystemColors.ControlText
        Label2.ImageAlign = ContentAlignment.TopRight
        Label2.Location = New Point(239, 80)
        Label2.Name = "Label2"
        Label2.Size = New Size(172, 25)
        Label2.TabIndex = 42
        Label2.Text = "Add New Book"
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Font = New Font("UD Digi Kyokasho NK-B", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        lblUsername.Location = New Point(831, 23)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(61, 17)
        lblUsername.TabIndex = 44
        lblUsername.Text = "Profile"
        ' 
        ' pbProfile
        ' 
        pbProfile.BackgroundImage = CType(resources.GetObject("pbProfile.BackgroundImage"), Image)
        pbProfile.BackgroundImageLayout = ImageLayout.Stretch
        pbProfile.Location = New Point(797, 12)
        pbProfile.Name = "pbProfile"
        pbProfile.Size = New Size(28, 28)
        pbProfile.TabIndex = 43
        pbProfile.TabStop = False
        ' 
        ' txtAddBookWriter
        ' 
        txtAddBookWriter.Font = New Font("Segoe UI", 11F)
        txtAddBookWriter.Location = New Point(384, 163)
        txtAddBookWriter.Name = "txtAddBookWriter"
        txtAddBookWriter.PlaceholderText = "Enter Book Writer here"
        txtAddBookWriter.Size = New Size(190, 27)
        txtAddBookWriter.TabIndex = 45
        ' 
        ' txtAddBookTitle
        ' 
        txtAddBookTitle.Font = New Font("Segoe UI", 11F)
        txtAddBookTitle.Location = New Point(384, 130)
        txtAddBookTitle.Name = "txtAddBookTitle"
        txtAddBookTitle.PlaceholderText = "Enter Book Title here"
        txtAddBookTitle.Size = New Size(190, 27)
        txtAddBookTitle.TabIndex = 46
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Cornsilk
        Label4.Font = New Font("UD Digi Kyokasho NK-B", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label4.Location = New Point(278, 140)
        Label4.Name = "Label4"
        Label4.Size = New Size(87, 17)
        Label4.TabIndex = 47
        Label4.Text = "Book Title"
        ' 
        ' PictureBox9
        ' 
        PictureBox9.BackColor = Color.Cornsilk
        PictureBox9.BorderStyle = BorderStyle.FixedSingle
        PictureBox9.Location = New Point(239, 108)
        PictureBox9.Name = "PictureBox9"
        PictureBox9.Size = New Size(573, 279)
        PictureBox9.TabIndex = 48
        PictureBox9.TabStop = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Cornsilk
        Label5.Font = New Font("UD Digi Kyokasho NK-B", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label5.Location = New Point(278, 173)
        Label5.Name = "Label5"
        Label5.Size = New Size(100, 17)
        Label5.TabIndex = 49
        Label5.Text = "Book Writer"
        ' 
        ' BtnAddNewBook
        ' 
        BtnAddNewBook.AutoSize = True
        BtnAddNewBook.Font = New Font("UD Digi Kyokasho NK-B", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        BtnAddNewBook.Location = New Point(499, 263)
        BtnAddNewBook.Name = "BtnAddNewBook"
        BtnAddNewBook.Size = New Size(75, 27)
        BtnAddNewBook.TabIndex = 50
        BtnAddNewBook.Text = "Add"
        BtnAddNewBook.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Cornsilk
        Label7.Font = New Font("UD Digi Kyokasho NK-B", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label7.Location = New Point(278, 207)
        Label7.Name = "Label7"
        Label7.Size = New Size(80, 17)
        Label7.TabIndex = 68
        Label7.Text = "Category"
        ' 
        ' cbAddCategory
        ' 
        cbAddCategory.Font = New Font("Segoe UI", 11F)
        cbAddCategory.FormattingEnabled = True
        cbAddCategory.Location = New Point(384, 196)
        cbAddCategory.Name = "cbAddCategory"
        cbAddCategory.Size = New Size(190, 28)
        cbAddCategory.TabIndex = 69
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Cornsilk
        Label8.Font = New Font("UD Digi Kyokasho NK-B", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label8.Location = New Point(278, 240)
        Label8.Name = "Label8"
        Label8.Size = New Size(56, 17)
        Label8.TabIndex = 70
        Label8.Text = "Pages"
        ' 
        ' txtAddPages
        ' 
        txtAddPages.Font = New Font("Segoe UI", 11F)
        txtAddPages.Location = New Point(384, 230)
        txtAddPages.Name = "txtAddPages"
        txtAddPages.PlaceholderText = "Enter Number of pages"
        txtAddPages.Size = New Size(190, 27)
        txtAddPages.TabIndex = 71
        ' 
        ' PictureBox7
        ' 
        PictureBox7.Location = New Point(608, 120)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(166, 209)
        PictureBox7.TabIndex = 73
        PictureBox7.TabStop = False
        ' 
        ' btnUploadBook
        ' 
        btnUploadBook.AutoSize = True
        btnUploadBook.Font = New Font("UD Digi Kyokasho NK-B", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        btnUploadBook.Location = New Point(608, 335)
        btnUploadBook.Name = "btnUploadBook"
        btnUploadBook.Size = New Size(166, 27)
        btnUploadBook.TabIndex = 74
        btnUploadBook.Text = "Upload Book Cover"
        btnUploadBook.UseVisualStyleBackColor = True
        ' 
        ' pbBB
        ' 
        pbBB.BackColor = SystemColors.Info
        pbBB.BackgroundImage = CType(resources.GetObject("pbBB.BackgroundImage"), Image)
        pbBB.BackgroundImageLayout = ImageLayout.Stretch
        pbBB.Location = New Point(12, 252)
        pbBB.Name = "pbBB"
        pbBB.Size = New Size(28, 28)
        pbBB.TabIndex = 88
        pbBB.TabStop = False
        ' 
        ' lblBB
        ' 
        lblBB.AutoSize = True
        lblBB.BackColor = SystemColors.Info
        lblBB.Font = New Font("UD Digi Kyokasho NK-B", 11.25F, FontStyle.Bold)
        lblBB.ImageAlign = ContentAlignment.TopRight
        lblBB.Location = New Point(46, 260)
        lblBB.Name = "lblBB"
        lblBB.Size = New Size(131, 17)
        lblBB.TabIndex = 87
        lblBB.Text = "Book Borrowing"
        ' 
        ' lblstatistic
        ' 
        lblstatistic.AutoSize = True
        lblstatistic.BackColor = SystemColors.Info
        lblstatistic.Font = New Font("UD Digi Kyokasho NK-B", 11.25F, FontStyle.Bold)
        lblstatistic.ImageAlign = ContentAlignment.TopRight
        lblstatistic.Location = New Point(46, 294)
        lblstatistic.Name = "lblstatistic"
        lblstatistic.Size = New Size(103, 17)
        lblstatistic.TabIndex = 86
        lblstatistic.Text = "My Statistic"
        ' 
        ' pbStatistic
        ' 
        pbStatistic.BackColor = SystemColors.Info
        pbStatistic.BackgroundImage = CType(resources.GetObject("pbStatistic.BackgroundImage"), Image)
        pbStatistic.BackgroundImageLayout = ImageLayout.Stretch
        pbStatistic.Location = New Point(12, 286)
        pbStatistic.Name = "pbStatistic"
        pbStatistic.Size = New Size(28, 28)
        pbStatistic.TabIndex = 85
        pbStatistic.TabStop = False
        ' 
        ' lblDiscover
        ' 
        lblDiscover.AutoSize = True
        lblDiscover.BackColor = SystemColors.Info
        lblDiscover.Font = New Font("UD Digi Kyokasho NK-B", 11.25F, FontStyle.Bold)
        lblDiscover.ImageAlign = ContentAlignment.TopRight
        lblDiscover.Location = New Point(46, 122)
        lblDiscover.Name = "lblDiscover"
        lblDiscover.Size = New Size(74, 17)
        lblDiscover.TabIndex = 84
        lblDiscover.Text = "Discover"
        ' 
        ' pbDiscover
        ' 
        pbDiscover.BackColor = SystemColors.Info
        pbDiscover.BackgroundImage = CType(resources.GetObject("pbDiscover.BackgroundImage"), Image)
        pbDiscover.BackgroundImageLayout = ImageLayout.Stretch
        pbDiscover.Location = New Point(12, 114)
        pbDiscover.Name = "pbDiscover"
        pbDiscover.Size = New Size(28, 28)
        pbDiscover.TabIndex = 83
        pbDiscover.TabStop = False
        ' 
        ' lblMenu
        ' 
        lblMenu.AutoSize = True
        lblMenu.BackColor = SystemColors.Info
        lblMenu.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        lblMenu.ImageAlign = ContentAlignment.TopRight
        lblMenu.Location = New Point(12, 85)
        lblMenu.Name = "lblMenu"
        lblMenu.Size = New Size(49, 18)
        lblMenu.TabIndex = 82
        lblMenu.Text = "Menu"
        ' 
        ' lblFavorite
        ' 
        lblFavorite.AutoSize = True
        lblFavorite.BackColor = SystemColors.Info
        lblFavorite.Font = New Font("UD Digi Kyokasho NK-B", 11.25F, FontStyle.Bold)
        lblFavorite.ImageAlign = ContentAlignment.TopRight
        lblFavorite.Location = New Point(46, 227)
        lblFavorite.Name = "lblFavorite"
        lblFavorite.Size = New Size(73, 17)
        lblFavorite.TabIndex = 81
        lblFavorite.Text = "Favorite"
        ' 
        ' lblNotes
        ' 
        lblNotes.AutoSize = True
        lblNotes.BackColor = SystemColors.Info
        lblNotes.Font = New Font("UD Digi Kyokasho NK-B", 11.25F, FontStyle.Bold)
        lblNotes.ImageAlign = ContentAlignment.TopRight
        lblNotes.Location = New Point(46, 191)
        lblNotes.Name = "lblNotes"
        lblNotes.Size = New Size(81, 17)
        lblNotes.TabIndex = 80
        lblNotes.Text = "My Notes"
        ' 
        ' lblCategory
        ' 
        lblCategory.AutoSize = True
        lblCategory.BackColor = SystemColors.Info
        lblCategory.Font = New Font("UD Digi Kyokasho NK-B", 11.25F, FontStyle.Bold)
        lblCategory.ImageAlign = ContentAlignment.TopRight
        lblCategory.Location = New Point(46, 156)
        lblCategory.Name = "lblCategory"
        lblCategory.Size = New Size(80, 17)
        lblCategory.TabIndex = 79
        lblCategory.Text = "Category"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.Info
        Label1.Font = New Font("UD Digi Kyokasho NK-B", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label1.ForeColor = SystemColors.ControlText
        Label1.ImageAlign = ContentAlignment.TopRight
        Label1.Location = New Point(12, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(148, 31)
        Label1.TabIndex = 78
        Label1.Text = "ReadNest"
        ' 
        ' pbFavorite
        ' 
        pbFavorite.BackColor = SystemColors.Info
        pbFavorite.BackgroundImage = CType(resources.GetObject("pbFavorite.BackgroundImage"), Image)
        pbFavorite.BackgroundImageLayout = ImageLayout.Stretch
        pbFavorite.Location = New Point(12, 218)
        pbFavorite.Name = "pbFavorite"
        pbFavorite.Size = New Size(28, 28)
        pbFavorite.TabIndex = 77
        pbFavorite.TabStop = False
        ' 
        ' pbNotes
        ' 
        pbNotes.BackColor = SystemColors.Info
        pbNotes.BackgroundImage = CType(resources.GetObject("pbNotes.BackgroundImage"), Image)
        pbNotes.BackgroundImageLayout = ImageLayout.Stretch
        pbNotes.Location = New Point(12, 182)
        pbNotes.Name = "pbNotes"
        pbNotes.Size = New Size(28, 28)
        pbNotes.TabIndex = 76
        pbNotes.TabStop = False
        ' 
        ' pbCategory
        ' 
        pbCategory.BackColor = SystemColors.Info
        pbCategory.BackgroundImage = CType(resources.GetObject("pbCategory.BackgroundImage"), Image)
        pbCategory.BackgroundImageLayout = ImageLayout.Stretch
        pbCategory.Location = New Point(12, 148)
        pbCategory.Name = "pbCategory"
        pbCategory.Size = New Size(28, 28)
        pbCategory.TabIndex = 75
        pbCategory.TabStop = False
        ' 
        ' SplitContainer1
        ' 
        SplitContainer1.Dock = DockStyle.Fill
        SplitContainer1.Location = New Point(0, 0)
        SplitContainer1.Name = "SplitContainer1"
        ' 
        ' SplitContainer1.Panel1
        ' 
        SplitContainer1.Panel1.Controls.Add(PictureBox2)
        ' 
        ' SplitContainer1.Panel2
        ' 
        SplitContainer1.Panel2.Controls.Add(Splitter1)
        SplitContainer1.Size = New Size(934, 486)
        SplitContainer1.SplitterDistance = 186
        SplitContainer1.TabIndex = 89
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = SystemColors.Info
        PictureBox2.BorderStyle = BorderStyle.FixedSingle
        PictureBox2.Dock = DockStyle.Fill
        PictureBox2.Location = New Point(0, 0)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(186, 486)
        PictureBox2.TabIndex = 22
        PictureBox2.TabStop = False
        ' 
        ' Splitter1
        ' 
        Splitter1.Location = New Point(0, 0)
        Splitter1.Name = "Splitter1"
        Splitter1.Size = New Size(3, 486)
        Splitter1.TabIndex = 0
        Splitter1.TabStop = False
        ' 
        ' AddNewBookForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(934, 486)
        Controls.Add(pbBB)
        Controls.Add(lblBB)
        Controls.Add(lblstatistic)
        Controls.Add(pbStatistic)
        Controls.Add(lblDiscover)
        Controls.Add(pbDiscover)
        Controls.Add(lblMenu)
        Controls.Add(lblFavorite)
        Controls.Add(lblNotes)
        Controls.Add(lblCategory)
        Controls.Add(Label1)
        Controls.Add(pbFavorite)
        Controls.Add(pbNotes)
        Controls.Add(pbCategory)
        Controls.Add(btnUploadBook)
        Controls.Add(PictureBox7)
        Controls.Add(txtAddPages)
        Controls.Add(Label8)
        Controls.Add(cbAddCategory)
        Controls.Add(Label7)
        Controls.Add(BtnAddNewBook)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(txtAddBookTitle)
        Controls.Add(txtAddBookWriter)
        Controls.Add(lblUsername)
        Controls.Add(pbProfile)
        Controls.Add(Label2)
        Controls.Add(PictureBox9)
        Controls.Add(SplitContainer1)
        Name = "AddNewBookForm"
        Text = "Form4"
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
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
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
    Public WithEvents lblDiscover As Label
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
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Splitter1 As Splitter
End Class
