<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookByCategory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BookByCategory))
        SplitContainer1 = New SplitContainer()
        pbWishlist = New PictureBox()
        lblWishlist = New Label()
        Label1 = New Label()
        lblMenu = New Label()
        pbDiscover = New PictureBox()
        lblDiscover = New Label()
        pbCategory = New PictureBox()
        lblCategory = New Label()
        pbNotes = New PictureBox()
        lblNotes = New Label()
        pbFavorite = New PictureBox()
        lblFavorite = New Label()
        pbBB = New PictureBox()
        lblBB = New Label()
        pbStatistic = New PictureBox()
        lblstatistic = New Label()
        PictureBox2 = New PictureBox()
        Panel1 = New Panel()
        btnBack = New Button()
        flowCategory = New FlowLayoutPanel()
        cbProfile1 = New ComboBox()
        PictureBox1 = New PictureBox()
        pbProfile = New PictureBox()
        lblByCategory = New Label()
        cbProfile = New ComboBox()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel1.SuspendLayout()
        SplitContainer1.Panel2.SuspendLayout()
        SplitContainer1.SuspendLayout()
        CType(pbWishlist, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbDiscover, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbCategory, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbNotes, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbFavorite, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbBB, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbStatistic, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbProfile, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
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
        SplitContainer1.Panel1.Controls.Add(pbWishlist)
        SplitContainer1.Panel1.Controls.Add(lblWishlist)
        SplitContainer1.Panel1.Controls.Add(Label1)
        SplitContainer1.Panel1.Controls.Add(lblMenu)
        SplitContainer1.Panel1.Controls.Add(pbDiscover)
        SplitContainer1.Panel1.Controls.Add(lblDiscover)
        SplitContainer1.Panel1.Controls.Add(pbCategory)
        SplitContainer1.Panel1.Controls.Add(lblCategory)
        SplitContainer1.Panel1.Controls.Add(pbNotes)
        SplitContainer1.Panel1.Controls.Add(lblNotes)
        SplitContainer1.Panel1.Controls.Add(pbFavorite)
        SplitContainer1.Panel1.Controls.Add(lblFavorite)
        SplitContainer1.Panel1.Controls.Add(pbBB)
        SplitContainer1.Panel1.Controls.Add(lblBB)
        SplitContainer1.Panel1.Controls.Add(pbStatistic)
        SplitContainer1.Panel1.Controls.Add(lblstatistic)
        SplitContainer1.Panel1.Controls.Add(PictureBox2)
        SplitContainer1.Panel1MinSize = 186
        ' 
        ' SplitContainer1.Panel2
        ' 
        SplitContainer1.Panel2.Controls.Add(Panel1)
        SplitContainer1.Size = New Size(1067, 648)
        SplitContainer1.SplitterDistance = 213
        SplitContainer1.SplitterWidth = 5
        SplitContainer1.TabIndex = 35
        ' 
        ' pbWishlist
        ' 
        pbWishlist.BackColor = SystemColors.Info
        pbWishlist.BackgroundImage = CType(resources.GetObject("pbWishlist.BackgroundImage"), Image)
        pbWishlist.BackgroundImageLayout = ImageLayout.Stretch
        pbWishlist.Location = New Point(14, 424)
        pbWishlist.Margin = New Padding(3, 4, 3, 4)
        pbWishlist.Name = "pbWishlist"
        pbWishlist.Size = New Size(32, 37)
        pbWishlist.TabIndex = 30
        pbWishlist.TabStop = False
        ' 
        ' lblWishlist
        ' 
        lblWishlist.AutoSize = True
        lblWishlist.BackColor = SystemColors.Info
        lblWishlist.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold)
        lblWishlist.ImageAlign = ContentAlignment.TopRight
        lblWishlist.Location = New Point(53, 435)
        lblWishlist.Name = "lblWishlist"
        lblWishlist.Size = New Size(81, 24)
        lblWishlist.TabIndex = 31
        lblWishlist.Text = "Wishlist"
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
        Label1.TabIndex = 6
        Label1.Text = "ReadNest"
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
        lblMenu.TabIndex = 13
        lblMenu.Text = "Menu"
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
        pbDiscover.TabIndex = 20
        pbDiscover.TabStop = False
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
        lblDiscover.TabIndex = 21
        lblDiscover.Text = "Discover"
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
        pbCategory.TabIndex = 2
        pbCategory.TabStop = False
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
        lblCategory.TabIndex = 7
        lblCategory.Text = "Category"
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
        pbNotes.TabIndex = 3
        pbNotes.TabStop = False
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
        lblNotes.TabIndex = 8
        lblNotes.Text = "My Notes"
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
        pbFavorite.TabIndex = 5
        pbFavorite.TabStop = False
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
        lblFavorite.TabIndex = 9
        lblFavorite.Text = "Favorite"
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
        pbBB.TabIndex = 29
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
        lblBB.TabIndex = 28
        lblBB.Text = "Book Borrowing"
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
        pbStatistic.TabIndex = 23
        pbStatistic.TabStop = False
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
        lblstatistic.TabIndex = 24
        lblstatistic.Text = "My Statistic"
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
        ' Panel1
        ' 
        Panel1.Controls.Add(btnBack)
        Panel1.Controls.Add(flowCategory)
        Panel1.Controls.Add(cbProfile1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(pbProfile)
        Panel1.Controls.Add(lblByCategory)
        Panel1.Controls.Add(cbProfile)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(849, 648)
        Panel1.TabIndex = 0
        ' 
        ' btnBack
        ' 
        btnBack.AutoSize = True
        btnBack.Font = New Font("Segoe UI", 10F)
        btnBack.Location = New Point(751, 596)
        btnBack.Margin = New Padding(3, 4, 3, 4)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(86, 44)
        btnBack.TabIndex = 55
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' flowCategory
        ' 
        flowCategory.Location = New Point(3, 95)
        flowCategory.Margin = New Padding(3, 4, 3, 4)
        flowCategory.Name = "flowCategory"
        flowCategory.Size = New Size(833, 493)
        flowCategory.TabIndex = 54
        ' 
        ' cbProfile1
        ' 
        cbProfile1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        cbProfile1.FlatStyle = FlatStyle.Flat
        cbProfile1.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold)
        cbProfile1.FormattingEnabled = True
        cbProfile1.Items.AddRange(New Object() {"View Profile", "Logout"})
        cbProfile1.Location = New Point(704, 28)
        cbProfile1.Margin = New Padding(3, 4, 3, 4)
        cbProfile1.Name = "cbProfile1"
        cbProfile1.Size = New Size(110, 32)
        cbProfile1.TabIndex = 53
        cbProfile1.Text = "Profile"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(665, 27)
        PictureBox1.Margin = New Padding(3, 4, 3, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(32, 37)
        PictureBox1.TabIndex = 52
        PictureBox1.TabStop = False
        ' 
        ' pbProfile
        ' 
        pbProfile.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        pbProfile.BackgroundImage = CType(resources.GetObject("pbProfile.BackgroundImage"), Image)
        pbProfile.BackgroundImageLayout = ImageLayout.Stretch
        pbProfile.Location = New Point(1287, 27)
        pbProfile.Margin = New Padding(3, 4, 3, 4)
        pbProfile.Name = "pbProfile"
        pbProfile.Size = New Size(32, 37)
        pbProfile.TabIndex = 37
        pbProfile.TabStop = False
        ' 
        ' lblByCategory
        ' 
        lblByCategory.AutoSize = True
        lblByCategory.BackColor = Color.Transparent
        lblByCategory.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold)
        lblByCategory.ForeColor = SystemColors.ControlText
        lblByCategory.ImageAlign = ContentAlignment.TopRight
        lblByCategory.Location = New Point(3, 56)
        lblByCategory.Name = "lblByCategory"
        lblByCategory.Size = New Size(162, 32)
        lblByCategory.TabIndex = 41
        lblByCategory.Text = "Category : "
        ' 
        ' cbProfile
        ' 
        cbProfile.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        cbProfile.FlatStyle = FlatStyle.Flat
        cbProfile.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold)
        cbProfile.FormattingEnabled = True
        cbProfile.Items.AddRange(New Object() {"View Profile", "Logout"})
        cbProfile.Location = New Point(1326, 28)
        cbProfile.Margin = New Padding(3, 4, 3, 4)
        cbProfile.Name = "cbProfile"
        cbProfile.Size = New Size(110, 32)
        cbProfile.TabIndex = 43
        cbProfile.Text = "Profile"
        ' 
        ' BookByCategory
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1067, 648)
        Controls.Add(SplitContainer1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "BookByCategory"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ReadNest, Your Personal Library"
        SplitContainer1.Panel1.ResumeLayout(False)
        SplitContainer1.Panel1.PerformLayout()
        SplitContainer1.Panel2.ResumeLayout(False)
        CType(SplitContainer1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
        CType(pbWishlist, ComponentModel.ISupportInitialize).EndInit()
        CType(pbDiscover, ComponentModel.ISupportInitialize).EndInit()
        CType(pbCategory, ComponentModel.ISupportInitialize).EndInit()
        CType(pbNotes, ComponentModel.ISupportInitialize).EndInit()
        CType(pbFavorite, ComponentModel.ISupportInitialize).EndInit()
        CType(pbBB, ComponentModel.ISupportInitialize).EndInit()
        CType(pbStatistic, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(pbProfile, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Label1 As Label
    Friend WithEvents lblMenu As Label
    Friend WithEvents pbDiscover As PictureBox
    Public WithEvents lblDiscover As Label
    Friend WithEvents pbCategory As PictureBox
    Friend WithEvents lblCategory As Label
    Friend WithEvents pbNotes As PictureBox
    Friend WithEvents lblNotes As Label
    Friend WithEvents pbFavorite As PictureBox
    Friend WithEvents lblFavorite As Label
    Friend WithEvents pbBB As PictureBox
    Friend WithEvents lblBB As Label
    Friend WithEvents pbStatistic As PictureBox
    Friend WithEvents lblstatistic As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pbProfile As PictureBox
    Friend WithEvents lblByCategory As Label
    Friend WithEvents cbProfile As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cbProfile1 As ComboBox
    Friend WithEvents flowCategory As FlowLayoutPanel
    Friend WithEvents btnBack As Button
    Friend WithEvents pbWishlist As PictureBox
    Friend WithEvents lblWishlist As Label
End Class
