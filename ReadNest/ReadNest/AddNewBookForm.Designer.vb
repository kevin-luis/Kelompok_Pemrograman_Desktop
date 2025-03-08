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
        FolderBrowserDialog1 = New FolderBrowserDialog()
        OpenFileDialog1 = New OpenFileDialog()
        SaveFileDialog1 = New SaveFileDialog()
        PictureBox9 = New PictureBox()
        Label5 = New Label()
        BtnAddNewBook = New Button()
        Label7 = New Label()
        cbAddCategory = New ComboBox()
        Label8 = New Label()
        txtAddPages = New TextBox()
        PictureBox7 = New PictureBox()
        btnUploadBook = New Button()
        PictureBox10 = New PictureBox()
        Label1 = New Label()
        Label3 = New Label()
        PictureBox8 = New PictureBox()
        lblDiscover = New Label()
        PictureBox1 = New PictureBox()
        lblMenu = New Label()
        lblLogout = New Label()
        lblFavorite = New Label()
        lblMyLibrary = New Label()
        lblCategory = New Label()
        Label6 = New Label()
        PictureBox6 = New PictureBox()
        PictureBox5 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox2 = New PictureBox()
        CType(pbProfile, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox9, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox10, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
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
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
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
        ' PictureBox10
        ' 
        PictureBox10.BackColor = SystemColors.Info
        PictureBox10.BackgroundImage = CType(resources.GetObject("PictureBox10.BackgroundImage"), Image)
        PictureBox10.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox10.Location = New Point(12, 251)
        PictureBox10.Name = "PictureBox10"
        PictureBox10.Size = New Size(28, 28)
        PictureBox10.TabIndex = 91
        PictureBox10.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.Info
        Label1.Font = New Font("UD Digi Kyokasho NP-B", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label1.ImageAlign = ContentAlignment.TopRight
        Label1.Location = New Point(46, 262)
        Label1.Name = "Label1"
        Label1.Size = New Size(125, 17)
        Label1.TabIndex = 90
        Label1.Text = "Borrowed Book"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.Info
        Label3.Font = New Font("UD Digi Kyokasho NP-B", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label3.ImageAlign = ContentAlignment.TopRight
        Label3.Location = New Point(46, 296)
        Label3.Name = "Label3"
        Label3.Size = New Size(103, 17)
        Label3.TabIndex = 89
        Label3.Text = "My Statistic"
        ' 
        ' PictureBox8
        ' 
        PictureBox8.BackColor = SystemColors.Info
        PictureBox8.BackgroundImage = CType(resources.GetObject("PictureBox8.BackgroundImage"), Image)
        PictureBox8.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox8.Location = New Point(12, 285)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(28, 28)
        PictureBox8.TabIndex = 88
        PictureBox8.TabStop = False
        ' 
        ' lblDiscover
        ' 
        lblDiscover.AutoSize = True
        lblDiscover.BackColor = SystemColors.Info
        lblDiscover.Font = New Font("UD Digi Kyokasho NP-B", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        lblDiscover.ImageAlign = ContentAlignment.TopRight
        lblDiscover.Location = New Point(46, 124)
        lblDiscover.Name = "lblDiscover"
        lblDiscover.Size = New Size(74, 17)
        lblDiscover.TabIndex = 86
        lblDiscover.Text = "Discover"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = SystemColors.Info
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(12, 113)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(28, 28)
        PictureBox1.TabIndex = 85
        PictureBox1.TabStop = False
        ' 
        ' lblMenu
        ' 
        lblMenu.AutoSize = True
        lblMenu.BackColor = SystemColors.Info
        lblMenu.Font = New Font("UD Digi Kyokasho NP-B", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        lblMenu.ImageAlign = ContentAlignment.TopRight
        lblMenu.Location = New Point(12, 82)
        lblMenu.Name = "lblMenu"
        lblMenu.Size = New Size(51, 17)
        lblMenu.TabIndex = 84
        lblMenu.Text = "Menu"
        ' 
        ' lblLogout
        ' 
        lblLogout.AutoSize = True
        lblLogout.BackColor = SystemColors.Info
        lblLogout.Font = New Font("UD Digi Kyokasho NP-B", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        lblLogout.ImageAlign = ContentAlignment.TopRight
        lblLogout.Location = New Point(46, 445)
        lblLogout.Name = "lblLogout"
        lblLogout.Size = New Size(63, 17)
        lblLogout.TabIndex = 83
        lblLogout.Text = "Logout"
        ' 
        ' lblFavorite
        ' 
        lblFavorite.AutoSize = True
        lblFavorite.BackColor = SystemColors.Info
        lblFavorite.Font = New Font("UD Digi Kyokasho NP-B", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        lblFavorite.ImageAlign = ContentAlignment.TopRight
        lblFavorite.Location = New Point(46, 228)
        lblFavorite.Name = "lblFavorite"
        lblFavorite.Size = New Size(73, 17)
        lblFavorite.TabIndex = 82
        lblFavorite.Text = "Favorite"
        ' 
        ' lblMyLibrary
        ' 
        lblMyLibrary.AutoSize = True
        lblMyLibrary.BackColor = SystemColors.Info
        lblMyLibrary.Font = New Font("UD Digi Kyokasho NP-B", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        lblMyLibrary.ImageAlign = ContentAlignment.TopRight
        lblMyLibrary.Location = New Point(46, 192)
        lblMyLibrary.Name = "lblMyLibrary"
        lblMyLibrary.Size = New Size(81, 17)
        lblMyLibrary.TabIndex = 81
        lblMyLibrary.Text = "My Notes"
        ' 
        ' lblCategory
        ' 
        lblCategory.AutoSize = True
        lblCategory.BackColor = SystemColors.Info
        lblCategory.Font = New Font("UD Digi Kyokasho NP-B", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        lblCategory.ImageAlign = ContentAlignment.TopRight
        lblCategory.Location = New Point(46, 158)
        lblCategory.Name = "lblCategory"
        lblCategory.Size = New Size(80, 17)
        lblCategory.TabIndex = 80
        lblCategory.Text = "Category"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = SystemColors.Info
        Label6.Font = New Font("UD Digi Kyokasho NP-B", 20.25F, FontStyle.Bold)
        Label6.ForeColor = SystemColors.ControlText
        Label6.ImageAlign = ContentAlignment.TopRight
        Label6.Location = New Point(12, 24)
        Label6.Name = "Label6"
        Label6.Size = New Size(148, 31)
        Label6.TabIndex = 79
        Label6.Text = "ReadNest"
        ' 
        ' PictureBox6
        ' 
        PictureBox6.BackColor = SystemColors.Info
        PictureBox6.BackgroundImage = CType(resources.GetObject("PictureBox6.BackgroundImage"), Image)
        PictureBox6.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox6.Location = New Point(12, 217)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(28, 28)
        PictureBox6.TabIndex = 78
        PictureBox6.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackColor = SystemColors.Info
        PictureBox5.BackgroundImage = CType(resources.GetObject("PictureBox5.BackgroundImage"), Image)
        PictureBox5.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox5.Location = New Point(12, 434)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(28, 28)
        PictureBox5.TabIndex = 77
        PictureBox5.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = SystemColors.Info
        PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), Image)
        PictureBox4.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox4.Location = New Point(12, 181)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(28, 28)
        PictureBox4.TabIndex = 76
        PictureBox4.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = SystemColors.Info
        PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), Image)
        PictureBox3.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox3.Location = New Point(12, 147)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(28, 28)
        PictureBox3.TabIndex = 75
        PictureBox3.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = SystemColors.Info
        PictureBox2.BorderStyle = BorderStyle.FixedSingle
        PictureBox2.Location = New Point(0, -10)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(180, 498)
        PictureBox2.TabIndex = 87
        PictureBox2.TabStop = False
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(934, 486)
        Controls.Add(PictureBox10)
        Controls.Add(Label1)
        Controls.Add(Label3)
        Controls.Add(PictureBox8)
        Controls.Add(lblDiscover)
        Controls.Add(PictureBox1)
        Controls.Add(lblMenu)
        Controls.Add(lblLogout)
        Controls.Add(lblFavorite)
        Controls.Add(lblMyLibrary)
        Controls.Add(lblCategory)
        Controls.Add(Label6)
        Controls.Add(PictureBox6)
        Controls.Add(PictureBox5)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
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
        Name = "Form4"
        Text = "Form4"
        CType(pbProfile, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox9, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox10, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnAddNewBook As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents cbAddCategory As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtAddPages As TextBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents btnUploadBook As Button
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents lblDiscover As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblMenu As Label
    Friend WithEvents lblLogout As Label
    Friend WithEvents lblFavorite As Label
    Friend WithEvents lblMyLibrary As Label
    Friend WithEvents lblCategory As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
