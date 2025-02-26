<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox5 = New PictureBox()
        PictureBox6 = New PictureBox()
        Label1 = New Label()
        lblCategory = New Label()
        lblMyLibrary = New Label()
        lblFavorite = New Label()
        lblLogout = New Label()
        lblMenu = New Label()
        btnSearch = New Button()
        txtSearchBook = New TextBox()
        pbProfile = New PictureBox()
        lblUsername = New Label()
        Label2 = New Label()
        PictureBox1 = New PictureBox()
        lblDiscover = New Label()
        PictureBox2 = New PictureBox()
        PictureBox8 = New PictureBox()
        Label3 = New Label()
        btnAddNewBook = New Button()
        pbAddNewBook = New PictureBox()
        Label4 = New Label()
        PictureBox10 = New PictureBox()
        Label5 = New Label()
        lvBooklist = New ListView()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbProfile, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbAddNewBook, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox10, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = SystemColors.Info
        PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), Image)
        PictureBox3.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox3.Location = New Point(12, 148)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(28, 28)
        PictureBox3.TabIndex = 2
        PictureBox3.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = SystemColors.Info
        PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), Image)
        PictureBox4.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox4.Location = New Point(12, 182)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(28, 28)
        PictureBox4.TabIndex = 3
        PictureBox4.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackColor = SystemColors.Info
        PictureBox5.BackgroundImage = CType(resources.GetObject("PictureBox5.BackgroundImage"), Image)
        PictureBox5.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox5.Location = New Point(12, 435)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(28, 28)
        PictureBox5.TabIndex = 4
        PictureBox5.TabStop = False
        ' 
        ' PictureBox6
        ' 
        PictureBox6.BackColor = SystemColors.Info
        PictureBox6.BackgroundImage = CType(resources.GetObject("PictureBox6.BackgroundImage"), Image)
        PictureBox6.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox6.Location = New Point(12, 218)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(28, 28)
        PictureBox6.TabIndex = 5
        PictureBox6.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.Info
        Label1.Font = New Font("UD Digi Kyokasho NP-B", 20.25F, FontStyle.Bold)
        Label1.ForeColor = SystemColors.ControlText
        Label1.ImageAlign = ContentAlignment.TopRight
        Label1.Location = New Point(12, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(148, 31)
        Label1.TabIndex = 6
        Label1.Text = "ReadNest"
        ' 
        ' lblCategory
        ' 
        lblCategory.AutoSize = True
        lblCategory.BackColor = SystemColors.Info
        lblCategory.Font = New Font("UD Digi Kyokasho NP-B", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        lblCategory.ImageAlign = ContentAlignment.TopRight
        lblCategory.Location = New Point(46, 159)
        lblCategory.Name = "lblCategory"
        lblCategory.Size = New Size(80, 17)
        lblCategory.TabIndex = 7
        lblCategory.Text = "Category"
        ' 
        ' lblMyLibrary
        ' 
        lblMyLibrary.AutoSize = True
        lblMyLibrary.BackColor = SystemColors.Info
        lblMyLibrary.Font = New Font("UD Digi Kyokasho NP-B", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        lblMyLibrary.ImageAlign = ContentAlignment.TopRight
        lblMyLibrary.Location = New Point(46, 193)
        lblMyLibrary.Name = "lblMyLibrary"
        lblMyLibrary.Size = New Size(81, 17)
        lblMyLibrary.TabIndex = 8
        lblMyLibrary.Text = "My Notes"
        ' 
        ' lblFavorite
        ' 
        lblFavorite.AutoSize = True
        lblFavorite.BackColor = SystemColors.Info
        lblFavorite.Font = New Font("UD Digi Kyokasho NP-B", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        lblFavorite.ImageAlign = ContentAlignment.TopRight
        lblFavorite.Location = New Point(46, 229)
        lblFavorite.Name = "lblFavorite"
        lblFavorite.Size = New Size(73, 17)
        lblFavorite.TabIndex = 9
        lblFavorite.Text = "Favorite"
        ' 
        ' lblLogout
        ' 
        lblLogout.AutoSize = True
        lblLogout.BackColor = SystemColors.Info
        lblLogout.Font = New Font("UD Digi Kyokasho NP-B", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        lblLogout.ImageAlign = ContentAlignment.TopRight
        lblLogout.Location = New Point(46, 446)
        lblLogout.Name = "lblLogout"
        lblLogout.Size = New Size(63, 17)
        lblLogout.TabIndex = 10
        lblLogout.Text = "Logout"
        ' 
        ' lblMenu
        ' 
        lblMenu.AutoSize = True
        lblMenu.BackColor = SystemColors.Info
        lblMenu.Font = New Font("UD Digi Kyokasho NP-B", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        lblMenu.ImageAlign = ContentAlignment.TopRight
        lblMenu.Location = New Point(12, 83)
        lblMenu.Name = "lblMenu"
        lblMenu.Size = New Size(51, 17)
        lblMenu.TabIndex = 13
        lblMenu.Text = "Menu"
        ' 
        ' btnSearch
        ' 
        btnSearch.AutoSize = True
        btnSearch.Font = New Font("UD Digi Kyokasho NK-B", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        btnSearch.Location = New Point(612, 55)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(75, 27)
        btnSearch.TabIndex = 14
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' txtSearchBook
        ' 
        txtSearchBook.Font = New Font("UD Digi Kyokasho NK-B", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        txtSearchBook.Location = New Point(208, 57)
        txtSearchBook.Name = "txtSearchBook"
        txtSearchBook.PlaceholderText = "Find your book here"
        txtSearchBook.Size = New Size(398, 25)
        txtSearchBook.TabIndex = 15
        ' 
        ' pbProfile
        ' 
        pbProfile.BackgroundImage = CType(resources.GetObject("pbProfile.BackgroundImage"), Image)
        pbProfile.BackgroundImageLayout = ImageLayout.Stretch
        pbProfile.Location = New Point(816, 15)
        pbProfile.Name = "pbProfile"
        pbProfile.Size = New Size(28, 28)
        pbProfile.TabIndex = 17
        pbProfile.TabStop = False
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Font = New Font("UD Digi Kyokasho NK-B", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        lblUsername.Location = New Point(850, 25)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(61, 17)
        lblUsername.TabIndex = 18
        lblUsername.Text = "Profile"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("UD Digi Kyokasho NP-B", 16.2F, FontStyle.Bold)
        Label2.ForeColor = SystemColors.ControlText
        Label2.ImageAlign = ContentAlignment.TopRight
        Label2.Location = New Point(208, 25)
        Label2.Name = "Label2"
        Label2.Size = New Size(225, 25)
        Label2.TabIndex = 19
        Label2.Text = "Discover your book"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = SystemColors.Info
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(12, 114)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(28, 28)
        PictureBox1.TabIndex = 20
        PictureBox1.TabStop = False
        ' 
        ' lblDiscover
        ' 
        lblDiscover.AutoSize = True
        lblDiscover.BackColor = SystemColors.Info
        lblDiscover.Font = New Font("UD Digi Kyokasho NP-B", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        lblDiscover.ImageAlign = ContentAlignment.TopRight
        lblDiscover.Location = New Point(46, 125)
        lblDiscover.Name = "lblDiscover"
        lblDiscover.Size = New Size(74, 17)
        lblDiscover.TabIndex = 21
        lblDiscover.Text = "Discover"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = SystemColors.Info
        PictureBox2.BorderStyle = BorderStyle.FixedSingle
        PictureBox2.Location = New Point(0, -9)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(180, 498)
        PictureBox2.TabIndex = 22
        PictureBox2.TabStop = False
        ' 
        ' PictureBox8
        ' 
        PictureBox8.BackColor = SystemColors.Info
        PictureBox8.BackgroundImage = CType(resources.GetObject("PictureBox8.BackgroundImage"), Image)
        PictureBox8.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox8.Location = New Point(12, 286)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(28, 28)
        PictureBox8.TabIndex = 23
        PictureBox8.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.Info
        Label3.Font = New Font("UD Digi Kyokasho NP-B", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label3.ImageAlign = ContentAlignment.TopRight
        Label3.Location = New Point(46, 297)
        Label3.Name = "Label3"
        Label3.Size = New Size(103, 17)
        Label3.TabIndex = 24
        Label3.Text = "My Statistic"
        ' 
        ' btnAddNewBook
        ' 
        btnAddNewBook.AutoSize = True
        btnAddNewBook.Font = New Font("UD Digi Kyokasho NK-B", 11F, FontStyle.Bold)
        btnAddNewBook.Location = New Point(734, 91)
        btnAddNewBook.Name = "btnAddNewBook"
        btnAddNewBook.Size = New Size(145, 27)
        btnAddNewBook.TabIndex = 26
        btnAddNewBook.Text = "Add New Book"
        btnAddNewBook.UseVisualStyleBackColor = True
        ' 
        ' pbAddNewBook
        ' 
        pbAddNewBook.BackgroundImage = CType(resources.GetObject("pbAddNewBook.BackgroundImage"), Image)
        pbAddNewBook.BackgroundImageLayout = ImageLayout.Stretch
        pbAddNewBook.Location = New Point(878, 92)
        pbAddNewBook.Name = "pbAddNewBook"
        pbAddNewBook.Size = New Size(26, 26)
        pbAddNewBook.TabIndex = 27
        pbAddNewBook.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = SystemColors.Info
        Label4.Font = New Font("UD Digi Kyokasho NP-B", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label4.ImageAlign = ContentAlignment.TopRight
        Label4.Location = New Point(46, 263)
        Label4.Name = "Label4"
        Label4.Size = New Size(131, 17)
        Label4.TabIndex = 28
        Label4.Text = "Book Borrowing"
        ' 
        ' PictureBox10
        ' 
        PictureBox10.BackColor = SystemColors.Info
        PictureBox10.BackgroundImage = CType(resources.GetObject("PictureBox10.BackgroundImage"), Image)
        PictureBox10.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox10.Location = New Point(12, 252)
        PictureBox10.Name = "PictureBox10"
        PictureBox10.Size = New Size(28, 28)
        PictureBox10.TabIndex = 29
        PictureBox10.TabStop = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("UD Digi Kyokasho NP-B", 13.2F, FontStyle.Bold)
        Label5.ForeColor = SystemColors.ControlText
        Label5.ImageAlign = ContentAlignment.TopRight
        Label5.Location = New Point(208, 100)
        Label5.Name = "Label5"
        Label5.Size = New Size(157, 21)
        Label5.TabIndex = 30
        Label5.Text = "Your Books List"
        ' 
        ' lvBooklist
        ' 
        lvBooklist.Location = New Point(208, 124)
        lvBooklist.Name = "lvBooklist"
        lvBooklist.Size = New Size(696, 339)
        lvBooklist.TabIndex = 31
        lvBooklist.UseCompatibleStateImageBehavior = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(934, 486)
        Controls.Add(lvBooklist)
        Controls.Add(Label5)
        Controls.Add(PictureBox10)
        Controls.Add(Label4)
        Controls.Add(pbAddNewBook)
        Controls.Add(btnAddNewBook)
        Controls.Add(Label3)
        Controls.Add(PictureBox8)
        Controls.Add(lblDiscover)
        Controls.Add(PictureBox1)
        Controls.Add(Label2)
        Controls.Add(lblUsername)
        Controls.Add(pbProfile)
        Controls.Add(btnSearch)
        Controls.Add(lblMenu)
        Controls.Add(lblLogout)
        Controls.Add(lblFavorite)
        Controls.Add(lblMyLibrary)
        Controls.Add(lblCategory)
        Controls.Add(Label1)
        Controls.Add(PictureBox6)
        Controls.Add(PictureBox5)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox3)
        Controls.Add(txtSearchBook)
        Controls.Add(PictureBox2)
        Name = "Form1"
        Text = "ReadNest, Your Personal Library "
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(pbProfile, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        CType(pbAddNewBook, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox10, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblCategory As Label
    Friend WithEvents lblMyLibrary As Label
    Friend WithEvents lblFavorite As Label
    Friend WithEvents lblLogout As Label
    Friend WithEvents lblMenu As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearchBook As TextBox
    Friend WithEvents pbProfile As PictureBox
    Friend WithEvents lblUsername As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblDiscover As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnAddNewBook As Button
    Friend WithEvents pbAddNewBook As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lvBooklist As ListView

End Class
