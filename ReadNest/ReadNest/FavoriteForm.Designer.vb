﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FavoriteForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FavoriteForm))
        lvFavoriteBookList = New ListView()
        Label2 = New Label()
        lblUsername = New Label()
        pbProfile = New PictureBox()
        btnSearchFavoriteBook = New Button()
        txtSearchFavoriteBook = New TextBox()
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
        CType(pbProfile, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbBB, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbStatistic, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbDiscover, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbFavorite, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbNotes, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbCategory, ComponentModel.ISupportInitialize).BeginInit()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel1.SuspendLayout()
        SplitContainer1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lvFavoriteBookList
        ' 
        lvFavoriteBookList.Location = New Point(206, 125)
        lvFavoriteBookList.Name = "lvFavoriteBookList"
        lvFavoriteBookList.Size = New Size(696, 339)
        lvFavoriteBookList.TabIndex = 57
        lvFavoriteBookList.UseCompatibleStateImageBehavior = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("UD Digi Kyokasho NP-B", 13.2F, FontStyle.Bold)
        Label2.ForeColor = SystemColors.ControlText
        Label2.ImageAlign = ContentAlignment.TopRight
        Label2.Location = New Point(206, 59)
        Label2.Name = "Label2"
        Label2.Size = New Size(232, 21)
        Label2.TabIndex = 46
        Label2.Text = "Your Favorite Book List"
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Font = New Font("UD Digi Kyokasho NK-B", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        lblUsername.Location = New Point(848, 26)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(61, 17)
        lblUsername.TabIndex = 45
        lblUsername.Text = "Profile"
        ' 
        ' pbProfile
        ' 
        pbProfile.BackgroundImage = CType(resources.GetObject("pbProfile.BackgroundImage"), Image)
        pbProfile.BackgroundImageLayout = ImageLayout.Stretch
        pbProfile.Location = New Point(814, 16)
        pbProfile.Name = "pbProfile"
        pbProfile.Size = New Size(28, 28)
        pbProfile.TabIndex = 44
        pbProfile.TabStop = False
        ' 
        ' btnSearchFavoriteBook
        ' 
        btnSearchFavoriteBook.AutoSize = True
        btnSearchFavoriteBook.Font = New Font("UD Digi Kyokasho NK-B", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        btnSearchFavoriteBook.Location = New Point(610, 90)
        btnSearchFavoriteBook.Name = "btnSearchFavoriteBook"
        btnSearchFavoriteBook.Size = New Size(75, 27)
        btnSearchFavoriteBook.TabIndex = 42
        btnSearchFavoriteBook.Text = "Search"
        btnSearchFavoriteBook.UseVisualStyleBackColor = True
        ' 
        ' txtSearchFavoriteBook
        ' 
        txtSearchFavoriteBook.Font = New Font("UD Digi Kyokasho NK-B", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        txtSearchFavoriteBook.Location = New Point(206, 92)
        txtSearchFavoriteBook.Name = "txtSearchFavoriteBook"
        txtSearchFavoriteBook.PlaceholderText = "Find your Favorite book here"
        txtSearchFavoriteBook.Size = New Size(398, 25)
        txtSearchFavoriteBook.TabIndex = 43
        ' 
        ' pbBB
        ' 
        pbBB.BackColor = SystemColors.Info
        pbBB.BackgroundImage = CType(resources.GetObject("pbBB.BackgroundImage"), Image)
        pbBB.BackgroundImageLayout = ImageLayout.Stretch
        pbBB.Location = New Point(12, 252)
        pbBB.Name = "pbBB"
        pbBB.Size = New Size(28, 28)
        pbBB.TabIndex = 71
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
        lblBB.TabIndex = 70
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
        lblstatistic.TabIndex = 69
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
        pbStatistic.TabIndex = 68
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
        lblDiscover.TabIndex = 67
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
        pbDiscover.TabIndex = 66
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
        lblMenu.TabIndex = 65
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
        lblFavorite.TabIndex = 64
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
        lblNotes.TabIndex = 63
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
        lblCategory.TabIndex = 62
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
        Label1.TabIndex = 61
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
        pbFavorite.TabIndex = 60
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
        pbNotes.TabIndex = 59
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
        pbCategory.TabIndex = 58
        pbCategory.TabStop = False
        ' 
        ' SplitContainer1
        ' 
        SplitContainer1.Dock = DockStyle.Fill
        SplitContainer1.FixedPanel = FixedPanel.Panel1
        SplitContainer1.Location = New Point(0, 0)
        SplitContainer1.Name = "SplitContainer1"
        ' 
        ' SplitContainer1.Panel1
        ' 
        SplitContainer1.Panel1.Controls.Add(PictureBox2)
        SplitContainer1.Panel1MinSize = 186
        SplitContainer1.Size = New Size(934, 486)
        SplitContainer1.SplitterDistance = 186
        SplitContainer1.TabIndex = 72
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
        ' FavoriteForm
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
        Controls.Add(lvFavoriteBookList)
        Controls.Add(Label2)
        Controls.Add(lblUsername)
        Controls.Add(pbProfile)
        Controls.Add(btnSearchFavoriteBook)
        Controls.Add(txtSearchFavoriteBook)
        Controls.Add(SplitContainer1)
        Name = "FavoriteForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form8"
        CType(pbProfile, ComponentModel.ISupportInitialize).EndInit()
        CType(pbBB, ComponentModel.ISupportInitialize).EndInit()
        CType(pbStatistic, ComponentModel.ISupportInitialize).EndInit()
        CType(pbDiscover, ComponentModel.ISupportInitialize).EndInit()
        CType(pbFavorite, ComponentModel.ISupportInitialize).EndInit()
        CType(pbNotes, ComponentModel.ISupportInitialize).EndInit()
        CType(pbCategory, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.Panel1.ResumeLayout(False)
        CType(SplitContainer1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lvFavoriteBookList As ListView
    Friend WithEvents Label2 As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents pbProfile As PictureBox
    Friend WithEvents btnSearchFavoriteBook As Button
    Friend WithEvents txtSearchFavoriteBook As TextBox
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
End Class
