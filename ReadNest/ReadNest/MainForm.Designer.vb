﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        pbCategory = New PictureBox()
        pbNotes = New PictureBox()
        pbFavorite = New PictureBox()
        Label1 = New Label()
        lblCategory = New Label()
        lblNotes = New Label()
        lblFavorite = New Label()
        lblMenu = New Label()
        btnSearch = New Button()
        txtSearchBook = New TextBox()
        pbProfile = New PictureBox()
        Label2 = New Label()
        pbDiscover = New PictureBox()
        lblDiscover = New Label()
        PictureBox2 = New PictureBox()
        pbStatistic = New PictureBox()
        lblstatistic = New Label()
        btnAddNewBook = New Button()
        pbAddNewBook = New PictureBox()
        lblBB = New Label()
        pbBB = New PictureBox()
        Label5 = New Label()
        lvBooklist = New ListView()
        cbProfile = New ComboBox()
        SplitContainer1 = New SplitContainer()
        Splitter1 = New Splitter()
        CType(pbCategory, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbNotes, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbFavorite, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbProfile, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbDiscover, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbStatistic, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbAddNewBook, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbBB, ComponentModel.ISupportInitialize).BeginInit()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel1.SuspendLayout()
        SplitContainer1.Panel2.SuspendLayout()
        SplitContainer1.SuspendLayout()
        SuspendLayout()
        ' 
        ' pbCategory
        ' 
        pbCategory.BackColor = SystemColors.Info
        pbCategory.BackgroundImage = CType(resources.GetObject("pbCategory.BackgroundImage"), Image)
        pbCategory.BackgroundImageLayout = ImageLayout.Stretch
        pbCategory.Location = New Point(12, 148)
        pbCategory.Name = "pbCategory"
        pbCategory.Size = New Size(28, 28)
        pbCategory.TabIndex = 2
        pbCategory.TabStop = False
        ' 
        ' pbNotes
        ' 
        pbNotes.BackColor = SystemColors.Info
        pbNotes.BackgroundImage = CType(resources.GetObject("pbNotes.BackgroundImage"), Image)
        pbNotes.BackgroundImageLayout = ImageLayout.Stretch
        pbNotes.Location = New Point(12, 182)
        pbNotes.Name = "pbNotes"
        pbNotes.Size = New Size(28, 28)
        pbNotes.TabIndex = 3
        pbNotes.TabStop = False
        ' 
        ' pbFavorite
        ' 
        pbFavorite.BackColor = SystemColors.Info
        pbFavorite.BackgroundImage = CType(resources.GetObject("pbFavorite.BackgroundImage"), Image)
        pbFavorite.BackgroundImageLayout = ImageLayout.Stretch
        pbFavorite.Location = New Point(12, 218)
        pbFavorite.Name = "pbFavorite"
        pbFavorite.Size = New Size(28, 28)
        pbFavorite.TabIndex = 5
        pbFavorite.TabStop = False
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
        Label1.TabIndex = 6
        Label1.Text = "ReadNest"
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
        lblCategory.TabIndex = 7
        lblCategory.Text = "Category"
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
        lblNotes.TabIndex = 8
        lblNotes.Text = "My Notes"
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
        lblFavorite.TabIndex = 9
        lblFavorite.Text = "Favorite"
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
        lblMenu.TabIndex = 13
        lblMenu.Text = "Menu"
        ' 
        ' btnSearch
        ' 
        btnSearch.AutoSize = True
        btnSearch.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        btnSearch.Location = New Point(612, 55)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(75, 28)
        btnSearch.TabIndex = 14
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' txtSearchBook
        ' 
        txtSearchBook.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        txtSearchBook.Location = New Point(208, 57)
        txtSearchBook.Name = "txtSearchBook"
        txtSearchBook.PlaceholderText = "Find your book here"
        txtSearchBook.Size = New Size(398, 24)
        txtSearchBook.TabIndex = 15
        ' 
        ' pbProfile
        ' 
        pbProfile.BackgroundImage = CType(resources.GetObject("pbProfile.BackgroundImage"), Image)
        pbProfile.BackgroundImageLayout = ImageLayout.Stretch
        pbProfile.Location = New Point(773, 22)
        pbProfile.Name = "pbProfile"
        pbProfile.Size = New Size(28, 28)
        pbProfile.TabIndex = 17
        pbProfile.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold)
        Label2.ForeColor = SystemColors.ControlText
        Label2.ImageAlign = ContentAlignment.TopRight
        Label2.Location = New Point(208, 25)
        Label2.Name = "Label2"
        Label2.Size = New Size(216, 26)
        Label2.TabIndex = 19
        Label2.Text = "Discover your book"
        ' 
        ' pbDiscover
        ' 
        pbDiscover.BackColor = SystemColors.Info
        pbDiscover.BackgroundImage = CType(resources.GetObject("pbDiscover.BackgroundImage"), Image)
        pbDiscover.BackgroundImageLayout = ImageLayout.Stretch
        pbDiscover.Location = New Point(12, 114)
        pbDiscover.Name = "pbDiscover"
        pbDiscover.Size = New Size(28, 28)
        pbDiscover.TabIndex = 20
        pbDiscover.TabStop = False
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
        lblDiscover.TabIndex = 21
        lblDiscover.Text = "Discover"
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
        ' pbStatistic
        ' 
        pbStatistic.BackColor = SystemColors.Info
        pbStatistic.BackgroundImage = CType(resources.GetObject("pbStatistic.BackgroundImage"), Image)
        pbStatistic.BackgroundImageLayout = ImageLayout.Stretch
        pbStatistic.Location = New Point(12, 286)
        pbStatistic.Name = "pbStatistic"
        pbStatistic.Size = New Size(28, 28)
        pbStatistic.TabIndex = 23
        pbStatistic.TabStop = False
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
        lblstatistic.TabIndex = 24
        lblstatistic.Text = "My Statistic"
        ' 
        ' btnAddNewBook
        ' 
        btnAddNewBook.AutoSize = True
        btnAddNewBook.Font = New Font("Microsoft Sans Serif", 11F, FontStyle.Bold)
        btnAddNewBook.Location = New Point(734, 91)
        btnAddNewBook.Name = "btnAddNewBook"
        btnAddNewBook.Size = New Size(145, 28)
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
        ' lblBB
        ' 
        lblBB.AutoSize = True
        lblBB.BackColor = SystemColors.Info
        lblBB.Font = New Font("UD Digi Kyokasho NK-B", 11.25F, FontStyle.Bold)
        lblBB.ImageAlign = ContentAlignment.TopRight
        lblBB.Location = New Point(46, 260)
        lblBB.Name = "lblBB"
        lblBB.Size = New Size(131, 17)
        lblBB.TabIndex = 28
        lblBB.Text = "Book Borrowing"
        ' 
        ' pbBB
        ' 
        pbBB.BackColor = SystemColors.Info
        pbBB.BackgroundImage = CType(resources.GetObject("pbBB.BackgroundImage"), Image)
        pbBB.BackgroundImageLayout = ImageLayout.Stretch
        pbBB.Location = New Point(12, 252)
        pbBB.Name = "pbBB"
        pbBB.Size = New Size(28, 28)
        pbBB.TabIndex = 29
        pbBB.TabStop = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Microsoft Sans Serif", 13.2F, FontStyle.Bold)
        Label5.ForeColor = SystemColors.ControlText
        Label5.ImageAlign = ContentAlignment.TopRight
        Label5.Location = New Point(208, 100)
        Label5.Name = "Label5"
        Label5.Size = New Size(151, 22)
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
        ' cbProfile
        ' 
        cbProfile.FlatStyle = FlatStyle.Flat
        cbProfile.Font = New Font("UD Digi Kyokasho NK-B", 11.25F, FontStyle.Bold)
        cbProfile.FormattingEnabled = True
        cbProfile.Items.AddRange(New Object() {"View Profile", "Logout"})
        cbProfile.Location = New Point(807, 23)
        cbProfile.Name = "cbProfile"
        cbProfile.Size = New Size(97, 25)
        cbProfile.TabIndex = 32
        cbProfile.Text = "Profile"
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
        SplitContainer1.TabIndex = 33
        ' 
        ' Splitter1
        ' 
        Splitter1.Location = New Point(0, 0)
        Splitter1.Name = "Splitter1"
        Splitter1.Size = New Size(3, 486)
        Splitter1.TabIndex = 0
        Splitter1.TabStop = False
        ' 
        ' MainForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackColor = Color.White
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(934, 486)
        Controls.Add(cbProfile)
        Controls.Add(lvBooklist)
        Controls.Add(Label5)
        Controls.Add(pbBB)
        Controls.Add(lblBB)
        Controls.Add(pbAddNewBook)
        Controls.Add(btnAddNewBook)
        Controls.Add(lblstatistic)
        Controls.Add(pbStatistic)
        Controls.Add(lblDiscover)
        Controls.Add(pbDiscover)
        Controls.Add(Label2)
        Controls.Add(pbProfile)
        Controls.Add(btnSearch)
        Controls.Add(lblMenu)
        Controls.Add(lblFavorite)
        Controls.Add(lblNotes)
        Controls.Add(lblCategory)
        Controls.Add(Label1)
        Controls.Add(pbFavorite)
        Controls.Add(pbNotes)
        Controls.Add(pbCategory)
        Controls.Add(txtSearchBook)
        Controls.Add(SplitContainer1)
        Name = "MainForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ReadNest, Your Personal Library "
        CType(pbCategory, ComponentModel.ISupportInitialize).EndInit()
        CType(pbNotes, ComponentModel.ISupportInitialize).EndInit()
        CType(pbFavorite, ComponentModel.ISupportInitialize).EndInit()
        CType(pbProfile, ComponentModel.ISupportInitialize).EndInit()
        CType(pbDiscover, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(pbStatistic, ComponentModel.ISupportInitialize).EndInit()
        CType(pbAddNewBook, ComponentModel.ISupportInitialize).EndInit()
        CType(pbBB, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.Panel1.ResumeLayout(False)
        SplitContainer1.Panel2.ResumeLayout(False)
        CType(SplitContainer1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents pbCategory As PictureBox
    Friend WithEvents pbNotes As PictureBox
    Friend WithEvents pbFavorite As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblCategory As Label
    Friend WithEvents lblNotes As Label
    Friend WithEvents lblFavorite As Label
    Friend WithEvents lblMenu As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearchBook As TextBox
    Friend WithEvents pbProfile As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents pbDiscover As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents pbStatistic As PictureBox
    Friend WithEvents lblstatistic As Label
    Friend WithEvents btnAddNewBook As Button
    Friend WithEvents pbAddNewBook As PictureBox
    Friend WithEvents lblBB As Label
    Friend WithEvents pbBB As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lvBooklist As ListView
    Friend WithEvents cbProfile As ComboBox
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Splitter1 As Splitter
    Public WithEvents lblDiscover As Label

End Class
