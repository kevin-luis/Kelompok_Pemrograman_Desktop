<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CategoryForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CategoryForm))
        lvCategoryBooks = New ListView()
        Label5 = New Label()
        PictureBox10 = New PictureBox()
        Label4 = New Label()
        Label3 = New Label()
        PictureBox8 = New PictureBox()
        lblDiscover = New Label()
        PictureBox1 = New PictureBox()
        lblUsername = New Label()
        pbProfile = New PictureBox()
        btnSearch = New Button()
        lblMenu = New Label()
        lblFavorite = New Label()
        lblMyLibrary = New Label()
        lblCategory = New Label()
        Label1 = New Label()
        PictureBox6 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox3 = New PictureBox()
        txtSearchBook = New TextBox()
        PictureBox2 = New PictureBox()
        cbCategoryBooks = New ComboBox()
        CType(PictureBox10, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbProfile, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lvCategoryBooks
        ' 
        lvCategoryBooks.Location = New Point(208, 125)
        lvCategoryBooks.Name = "lvCategoryBooks"
        lvCategoryBooks.Size = New Size(696, 339)
        lvCategoryBooks.TabIndex = 57
        lvCategoryBooks.UseCompatibleStateImageBehavior = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("UD Digi Kyokasho NP-B", 13.2F, FontStyle.Bold)
        Label5.ForeColor = SystemColors.ControlText
        Label5.ImageAlign = ContentAlignment.TopRight
        Label5.Location = New Point(208, 63)
        Label5.Name = "Label5"
        Label5.Size = New Size(158, 21)
        Label5.TabIndex = 56
        Label5.Text = "Category Books"
        ' 
        ' PictureBox10
        ' 
        PictureBox10.BackColor = SystemColors.Info
        PictureBox10.BackgroundImage = CType(resources.GetObject("PictureBox10.BackgroundImage"), Image)
        PictureBox10.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox10.Location = New Point(12, 253)
        PictureBox10.Name = "PictureBox10"
        PictureBox10.Size = New Size(28, 28)
        PictureBox10.TabIndex = 55
        PictureBox10.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = SystemColors.Info
        Label4.Font = New Font("UD Digi Kyokasho NP-B", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label4.ImageAlign = ContentAlignment.TopRight
        Label4.Location = New Point(46, 264)
        Label4.Name = "Label4"
        Label4.Size = New Size(131, 17)
        Label4.TabIndex = 54
        Label4.Text = "Book Borrowing"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.Info
        Label3.Font = New Font("UD Digi Kyokasho NP-B", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label3.ImageAlign = ContentAlignment.TopRight
        Label3.Location = New Point(46, 298)
        Label3.Name = "Label3"
        Label3.Size = New Size(103, 17)
        Label3.TabIndex = 51
        Label3.Text = "My Statistic"
        ' 
        ' PictureBox8
        ' 
        PictureBox8.BackColor = SystemColors.Info
        PictureBox8.BackgroundImage = CType(resources.GetObject("PictureBox8.BackgroundImage"), Image)
        PictureBox8.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox8.Location = New Point(12, 287)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(28, 28)
        PictureBox8.TabIndex = 50
        PictureBox8.TabStop = False
        ' 
        ' lblDiscover
        ' 
        lblDiscover.AutoSize = True
        lblDiscover.BackColor = SystemColors.Info
        lblDiscover.Font = New Font("UD Digi Kyokasho NP-B", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        lblDiscover.ImageAlign = ContentAlignment.TopRight
        lblDiscover.Location = New Point(46, 126)
        lblDiscover.Name = "lblDiscover"
        lblDiscover.Size = New Size(74, 17)
        lblDiscover.TabIndex = 48
        lblDiscover.Text = "Discover"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = SystemColors.Info
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(12, 115)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(28, 28)
        PictureBox1.TabIndex = 47
        PictureBox1.TabStop = False
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Font = New Font("UD Digi Kyokasho NK-B", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        lblUsername.Location = New Point(850, 26)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(61, 17)
        lblUsername.TabIndex = 45
        lblUsername.Text = "Profile"
        ' 
        ' pbProfile
        ' 
        pbProfile.BackgroundImage = CType(resources.GetObject("pbProfile.BackgroundImage"), Image)
        pbProfile.BackgroundImageLayout = ImageLayout.Stretch
        pbProfile.Location = New Point(816, 16)
        pbProfile.Name = "pbProfile"
        pbProfile.Size = New Size(28, 28)
        pbProfile.TabIndex = 44
        pbProfile.TabStop = False
        ' 
        ' btnSearch
        ' 
        btnSearch.AutoSize = True
        btnSearch.Font = New Font("UD Digi Kyokasho NK-B", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        btnSearch.Location = New Point(612, 92)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(75, 27)
        btnSearch.TabIndex = 42
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' lblMenu
        ' 
        lblMenu.AutoSize = True
        lblMenu.BackColor = SystemColors.Info
        lblMenu.Font = New Font("UD Digi Kyokasho NP-B", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        lblMenu.ImageAlign = ContentAlignment.TopRight
        lblMenu.Location = New Point(12, 84)
        lblMenu.Name = "lblMenu"
        lblMenu.Size = New Size(51, 17)
        lblMenu.TabIndex = 41
        lblMenu.Text = "Menu"
        ' 
        ' lblFavorite
        ' 
        lblFavorite.AutoSize = True
        lblFavorite.BackColor = SystemColors.Info
        lblFavorite.Font = New Font("UD Digi Kyokasho NP-B", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        lblFavorite.ImageAlign = ContentAlignment.TopRight
        lblFavorite.Location = New Point(46, 230)
        lblFavorite.Name = "lblFavorite"
        lblFavorite.Size = New Size(73, 17)
        lblFavorite.TabIndex = 39
        lblFavorite.Text = "Favorite"
        ' 
        ' lblMyLibrary
        ' 
        lblMyLibrary.AutoSize = True
        lblMyLibrary.BackColor = SystemColors.Info
        lblMyLibrary.Font = New Font("UD Digi Kyokasho NP-B", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        lblMyLibrary.ImageAlign = ContentAlignment.TopRight
        lblMyLibrary.Location = New Point(46, 194)
        lblMyLibrary.Name = "lblMyLibrary"
        lblMyLibrary.Size = New Size(81, 17)
        lblMyLibrary.TabIndex = 38
        lblMyLibrary.Text = "My Notes"
        ' 
        ' lblCategory
        ' 
        lblCategory.AutoSize = True
        lblCategory.BackColor = SystemColors.Info
        lblCategory.Font = New Font("UD Digi Kyokasho NP-B", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        lblCategory.ImageAlign = ContentAlignment.TopRight
        lblCategory.Location = New Point(46, 160)
        lblCategory.Name = "lblCategory"
        lblCategory.Size = New Size(80, 17)
        lblCategory.TabIndex = 37
        lblCategory.Text = "Category"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.Info
        Label1.Font = New Font("UD Digi Kyokasho NP-B", 20.25F, FontStyle.Bold)
        Label1.ForeColor = SystemColors.ControlText
        Label1.ImageAlign = ContentAlignment.TopRight
        Label1.Location = New Point(12, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(148, 31)
        Label1.TabIndex = 36
        Label1.Text = "ReadNest"
        ' 
        ' PictureBox6
        ' 
        PictureBox6.BackColor = SystemColors.Info
        PictureBox6.BackgroundImage = CType(resources.GetObject("PictureBox6.BackgroundImage"), Image)
        PictureBox6.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox6.Location = New Point(12, 219)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(28, 28)
        PictureBox6.TabIndex = 35
        PictureBox6.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = SystemColors.Info
        PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), Image)
        PictureBox4.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox4.Location = New Point(12, 183)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(28, 28)
        PictureBox4.TabIndex = 33
        PictureBox4.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = SystemColors.Info
        PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), Image)
        PictureBox3.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox3.Location = New Point(12, 149)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(28, 28)
        PictureBox3.TabIndex = 32
        PictureBox3.TabStop = False
        ' 
        ' txtSearchBook
        ' 
        txtSearchBook.Font = New Font("UD Digi Kyokasho NK-B", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        txtSearchBook.Location = New Point(208, 92)
        txtSearchBook.Name = "txtSearchBook"
        txtSearchBook.PlaceholderText = "Find your book here"
        txtSearchBook.Size = New Size(398, 25)
        txtSearchBook.TabIndex = 43
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = SystemColors.Info
        PictureBox2.BorderStyle = BorderStyle.FixedSingle
        PictureBox2.Location = New Point(0, -8)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(180, 498)
        PictureBox2.TabIndex = 49
        PictureBox2.TabStop = False
        ' 
        ' cbCategoryBooks
        ' 
        cbCategoryBooks.FormattingEnabled = True
        cbCategoryBooks.Location = New Point(693, 93)
        cbCategoryBooks.Name = "cbCategoryBooks"
        cbCategoryBooks.Size = New Size(121, 23)
        cbCategoryBooks.TabIndex = 58
        ' 
        ' CategoryForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(934, 486)
        Controls.Add(cbCategoryBooks)
        Controls.Add(lvCategoryBooks)
        Controls.Add(Label5)
        Controls.Add(PictureBox10)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(PictureBox8)
        Controls.Add(lblDiscover)
        Controls.Add(PictureBox1)
        Controls.Add(lblUsername)
        Controls.Add(pbProfile)
        Controls.Add(btnSearch)
        Controls.Add(lblMenu)
        Controls.Add(lblFavorite)
        Controls.Add(lblMyLibrary)
        Controls.Add(lblCategory)
        Controls.Add(Label1)
        Controls.Add(PictureBox6)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox3)
        Controls.Add(txtSearchBook)
        Controls.Add(PictureBox2)
        Name = "CategoryForm"
        Text = "Form6"
        CType(PictureBox10, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(pbProfile, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lvCategoryBooks As ListView
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents lblDiscover As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblUsername As Label
    Friend WithEvents pbProfile As PictureBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents lblMenu As Label
    Friend WithEvents lblFavorite As Label
    Friend WithEvents lblMyLibrary As Label
    Friend WithEvents lblCategory As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents txtSearchBook As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents cbCategoryBooks As ComboBox
End Class
