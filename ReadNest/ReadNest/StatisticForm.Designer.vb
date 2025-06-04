<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StatisticForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StatisticForm))
        Label2 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        txtTotalBooksRead = New TextBox()
        txtTotalReadingTime = New TextBox()
        txtTotalFavoriteBooks = New TextBox()
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
        lblWishlist = New Label()
        pbWishlist = New PictureBox()
        PictureBox2 = New PictureBox()
        cbProfile = New ComboBox()
        Panel1 = New Panel()
        Label4 = New Label()
        Label3 = New Label()
        txtTotalBooksBorrowed = New TextBox()
        txtAvReadingTime = New TextBox()
        pbProfile = New PictureBox()
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
        CType(pbWishlist, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(pbProfile, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Cornsilk
        Label2.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold)
        Label2.ForeColor = SystemColors.ControlText
        Label2.ImageAlign = ContentAlignment.TopRight
        Label2.Location = New Point(16, 28)
        Label2.Name = "Label2"
        Label2.Size = New Size(201, 32)
        Label2.TabIndex = 49
        Label2.Text = "Book Statistic"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Cornsilk
        Label5.Font = New Font("Microsoft Sans Serif", 13.2F, FontStyle.Bold)
        Label5.ForeColor = SystemColors.ControlText
        Label5.ImageAlign = ContentAlignment.TopRight
        Label5.Location = New Point(97, 117)
        Label5.Name = "Label5"
        Label5.Size = New Size(200, 26)
        Label5.TabIndex = 50
        Label5.Text = "Total Books Read"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Cornsilk
        Label6.Font = New Font("Microsoft Sans Serif", 13.2F, FontStyle.Bold)
        Label6.ForeColor = SystemColors.ControlText
        Label6.ImageAlign = ContentAlignment.TopRight
        Label6.Location = New Point(62, 200)
        Label6.Name = "Label6"
        Label6.Size = New Size(233, 26)
        Label6.TabIndex = 51
        Label6.Text = "Total Borrowed Book"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Cornsilk
        Label7.Font = New Font("Microsoft Sans Serif", 13.2F, FontStyle.Bold)
        Label7.ForeColor = SystemColors.ControlText
        Label7.ImageAlign = ContentAlignment.TopRight
        Label7.Location = New Point(75, 156)
        Label7.Name = "Label7"
        Label7.Size = New Size(218, 26)
        Label7.TabIndex = 52
        Label7.Text = "Total Reading Time"
        ' 
        ' txtTotalBooksRead
        ' 
        txtTotalBooksRead.Location = New Point(304, 115)
        txtTotalBooksRead.Margin = New Padding(3, 4, 3, 4)
        txtTotalBooksRead.Name = "txtTotalBooksRead"
        txtTotalBooksRead.ReadOnly = True
        txtTotalBooksRead.Size = New Size(114, 27)
        txtTotalBooksRead.TabIndex = 53
        ' 
        ' txtTotalReadingTime
        ' 
        txtTotalReadingTime.Location = New Point(304, 153)
        txtTotalReadingTime.Margin = New Padding(3, 4, 3, 4)
        txtTotalReadingTime.Name = "txtTotalReadingTime"
        txtTotalReadingTime.ReadOnly = True
        txtTotalReadingTime.Size = New Size(114, 27)
        txtTotalReadingTime.TabIndex = 54
        ' 
        ' txtTotalFavoriteBooks
        ' 
        txtTotalFavoriteBooks.Location = New Point(304, 243)
        txtTotalFavoriteBooks.Margin = New Padding(3, 4, 3, 4)
        txtTotalFavoriteBooks.Name = "txtTotalFavoriteBooks"
        txtTotalFavoriteBooks.ReadOnly = True
        txtTotalFavoriteBooks.Size = New Size(114, 27)
        txtTotalFavoriteBooks.TabIndex = 55
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
        pbBB.TabIndex = 72
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
        lblBB.TabIndex = 71
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
        lblstatistic.TabIndex = 70
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
        pbStatistic.TabIndex = 69
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
        lblDiscover.TabIndex = 68
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
        pbDiscover.TabIndex = 67
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
        lblMenu.TabIndex = 66
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
        lblFavorite.TabIndex = 65
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
        lblNotes.TabIndex = 64
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
        lblCategory.TabIndex = 63
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
        Label1.TabIndex = 62
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
        pbFavorite.TabIndex = 61
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
        pbNotes.TabIndex = 60
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
        pbCategory.TabIndex = 59
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
        SplitContainer1.Panel1.Controls.Add(lblWishlist)
        SplitContainer1.Panel1.Controls.Add(pbWishlist)
        SplitContainer1.Panel1.Controls.Add(PictureBox2)
        ' 
        ' SplitContainer1.Panel2
        ' 
        SplitContainer1.Panel2.Controls.Add(cbProfile)
        SplitContainer1.Panel2.Controls.Add(Panel1)
        SplitContainer1.Panel2.Controls.Add(pbProfile)
        SplitContainer1.Size = New Size(1067, 648)
        SplitContainer1.SplitterDistance = 213
        SplitContainer1.SplitterWidth = 5
        SplitContainer1.TabIndex = 73
        ' 
        ' lblWishlist
        ' 
        lblWishlist.AutoSize = True
        lblWishlist.BackColor = SystemColors.Info
        lblWishlist.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold)
        lblWishlist.ImageAlign = ContentAlignment.TopRight
        lblWishlist.Location = New Point(53, 440)
        lblWishlist.Name = "lblWishlist"
        lblWishlist.Size = New Size(81, 24)
        lblWishlist.TabIndex = 75
        lblWishlist.Text = "Wishlist"
        ' 
        ' pbWishlist
        ' 
        pbWishlist.BackColor = SystemColors.Info
        pbWishlist.BackgroundImage = CType(resources.GetObject("pbWishlist.BackgroundImage"), Image)
        pbWishlist.BackgroundImageLayout = ImageLayout.Stretch
        pbWishlist.Location = New Point(14, 429)
        pbWishlist.Margin = New Padding(3, 4, 3, 4)
        pbWishlist.Name = "pbWishlist"
        pbWishlist.Size = New Size(32, 37)
        pbWishlist.TabIndex = 74
        pbWishlist.TabStop = False
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
        ' cbProfile
        ' 
        cbProfile.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        cbProfile.DropDownStyle = ComboBoxStyle.DropDownList
        cbProfile.FlatStyle = FlatStyle.Flat
        cbProfile.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold)
        cbProfile.FormattingEnabled = True
        cbProfile.Items.AddRange(New Object() {"Profile", "View Profile", "Logout"})
        cbProfile.Location = New Point(696, 33)
        cbProfile.Margin = New Padding(3, 4, 3, 4)
        cbProfile.Name = "cbProfile"
        cbProfile.Size = New Size(110, 32)
        cbProfile.TabIndex = 74
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Cornsilk
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(txtTotalBooksBorrowed)
        Panel1.Controls.Add(txtAvReadingTime)
        Panel1.Controls.Add(txtTotalFavoriteBooks)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(txtTotalBooksRead)
        Panel1.Controls.Add(txtTotalReadingTime)
        Panel1.Location = New Point(86, 152)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(482, 389)
        Panel1.TabIndex = 0
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Cornsilk
        Label4.Font = New Font("Microsoft Sans Serif", 13.2F, FontStyle.Bold)
        Label4.ForeColor = SystemColors.ControlText
        Label4.ImageAlign = ContentAlignment.TopRight
        Label4.Location = New Point(43, 289)
        Label4.Name = "Label4"
        Label4.Size = New Size(254, 26)
        Label4.TabIndex = 60
        Label4.Text = "Average Reading Time"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Cornsilk
        Label3.Font = New Font("Microsoft Sans Serif", 13.2F, FontStyle.Bold)
        Label3.ForeColor = SystemColors.ControlText
        Label3.ImageAlign = ContentAlignment.TopRight
        Label3.Location = New Point(123, 244)
        Label3.Name = "Label3"
        Label3.Size = New Size(171, 26)
        Label3.TabIndex = 59
        Label3.Text = "Favorite Books"
        ' 
        ' txtTotalBooksBorrowed
        ' 
        txtTotalBooksBorrowed.Location = New Point(304, 199)
        txtTotalBooksBorrowed.Margin = New Padding(3, 4, 3, 4)
        txtTotalBooksBorrowed.Name = "txtTotalBooksBorrowed"
        txtTotalBooksBorrowed.ReadOnly = True
        txtTotalBooksBorrowed.Size = New Size(114, 27)
        txtTotalBooksBorrowed.TabIndex = 58
        ' 
        ' txtAvReadingTime
        ' 
        txtAvReadingTime.Location = New Point(304, 288)
        txtAvReadingTime.Margin = New Padding(3, 4, 3, 4)
        txtAvReadingTime.Name = "txtAvReadingTime"
        txtAvReadingTime.ReadOnly = True
        txtAvReadingTime.Size = New Size(114, 27)
        txtAvReadingTime.TabIndex = 56
        ' 
        ' pbProfile
        ' 
        pbProfile.BackgroundImage = CType(resources.GetObject("pbProfile.BackgroundImage"), Image)
        pbProfile.BackgroundImageLayout = ImageLayout.Stretch
        pbProfile.Location = New Point(658, 33)
        pbProfile.Margin = New Padding(3, 4, 3, 4)
        pbProfile.Name = "pbProfile"
        pbProfile.Size = New Size(32, 37)
        pbProfile.TabIndex = 57
        pbProfile.TabStop = False
        ' 
        ' StatisticForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1067, 648)
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
        Controls.Add(SplitContainer1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "StatisticForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ReadNest, Your Personal Library"
        CType(pbBB, ComponentModel.ISupportInitialize).EndInit()
        CType(pbStatistic, ComponentModel.ISupportInitialize).EndInit()
        CType(pbDiscover, ComponentModel.ISupportInitialize).EndInit()
        CType(pbFavorite, ComponentModel.ISupportInitialize).EndInit()
        CType(pbNotes, ComponentModel.ISupportInitialize).EndInit()
        CType(pbCategory, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.Panel1.ResumeLayout(False)
        SplitContainer1.Panel1.PerformLayout()
        SplitContainer1.Panel2.ResumeLayout(False)
        CType(SplitContainer1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
        CType(pbWishlist, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(pbProfile, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtTotalBooksRead As TextBox
    Friend WithEvents txtTotalReadingTime As TextBox
    Friend WithEvents txtTotalFavoriteBooks As TextBox
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
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pbProfile As PictureBox
    Friend WithEvents lblWishlist As Label
    Friend WithEvents pbWishlist As PictureBox
    Friend WithEvents txtAvReadingTime As TextBox
    Friend WithEvents txtTotalBooksBorrowed As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cbProfile As ComboBox
End Class