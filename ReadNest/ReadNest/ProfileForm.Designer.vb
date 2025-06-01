<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProfileForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProfileForm))
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
        pbWishlist = New PictureBox()
        lblWishlist = New Label()
        PictureBox2 = New PictureBox()
        Panel2 = New Panel()
        Panel1 = New Panel()
        PbEditProfile = New PictureBox()
        BtnEditProfile = New Label()
        ProfileEmail = New TextBox()
        ProfileUsername = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
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
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        CType(PbEditProfile, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
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
        pbBB.TabIndex = 87
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
        lblBB.TabIndex = 86
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
        lblstatistic.TabIndex = 85
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
        pbStatistic.TabIndex = 84
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
        lblDiscover.TabIndex = 83
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
        pbDiscover.TabIndex = 82
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
        lblMenu.TabIndex = 81
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
        lblFavorite.TabIndex = 80
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
        lblNotes.TabIndex = 79
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
        lblCategory.TabIndex = 78
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
        Label1.TabIndex = 77
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
        pbFavorite.TabIndex = 76
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
        pbNotes.TabIndex = 75
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
        pbCategory.TabIndex = 74
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
        SplitContainer1.Panel1.Controls.Add(pbWishlist)
        SplitContainer1.Panel1.Controls.Add(lblWishlist)
        SplitContainer1.Panel1.Controls.Add(PictureBox2)
        SplitContainer1.Panel1MinSize = 186
        ' 
        ' SplitContainer1.Panel2
        ' 
        SplitContainer1.Panel2.Controls.Add(Panel2)
        SplitContainer1.Size = New Size(1067, 648)
        SplitContainer1.SplitterDistance = 213
        SplitContainer1.SplitterWidth = 5
        SplitContainer1.TabIndex = 88
        ' 
        ' pbWishlist
        ' 
        pbWishlist.BackColor = SystemColors.Info
        pbWishlist.BackgroundImage = CType(resources.GetObject("pbWishlist.BackgroundImage"), Image)
        pbWishlist.BackgroundImageLayout = ImageLayout.Stretch
        pbWishlist.Location = New Point(14, 427)
        pbWishlist.Margin = New Padding(3, 4, 3, 4)
        pbWishlist.Name = "pbWishlist"
        pbWishlist.Size = New Size(32, 37)
        pbWishlist.TabIndex = 89
        pbWishlist.TabStop = False
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
        lblWishlist.TabIndex = 90
        lblWishlist.Text = "Wishlist"
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
        ' Panel2
        ' 
        Panel2.Controls.Add(Panel1)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(0, 0)
        Panel2.Margin = New Padding(3, 4, 3, 4)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(849, 648)
        Panel2.TabIndex = 2
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Panel1.AutoScroll = True
        Panel1.BackColor = Color.Cornsilk
        Panel1.Controls.Add(PbEditProfile)
        Panel1.Controls.Add(BtnEditProfile)
        Panel1.Controls.Add(ProfileEmail)
        Panel1.Controls.Add(ProfileUsername)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(149, 113)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(437, 416)
        Panel1.TabIndex = 1
        ' 
        ' PbEditProfile
        ' 
        PbEditProfile.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        PbEditProfile.BackgroundImage = CType(resources.GetObject("PbEditProfile.BackgroundImage"), Image)
        PbEditProfile.BackgroundImageLayout = ImageLayout.Stretch
        PbEditProfile.Location = New Point(380, 15)
        PbEditProfile.Margin = New Padding(3, 4, 3, 4)
        PbEditProfile.Name = "PbEditProfile"
        PbEditProfile.Size = New Size(32, 37)
        PbEditProfile.TabIndex = 59
        PbEditProfile.TabStop = False
        ' 
        ' BtnEditProfile
        ' 
        BtnEditProfile.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        BtnEditProfile.AutoSize = True
        BtnEditProfile.BackColor = Color.Transparent
        BtnEditProfile.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        BtnEditProfile.ForeColor = SystemColors.ControlText
        BtnEditProfile.ImageAlign = ContentAlignment.TopRight
        BtnEditProfile.Location = New Point(322, 21)
        BtnEditProfile.Name = "BtnEditProfile"
        BtnEditProfile.Size = New Size(55, 25)
        BtnEditProfile.TabIndex = 58
        BtnEditProfile.Text = "Edit "
        ' 
        ' ProfileEmail
        ' 
        ProfileEmail.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        ProfileEmail.Font = New Font("Segoe UI", 11F)
        ProfileEmail.Location = New Point(126, 189)
        ProfileEmail.Margin = New Padding(3, 4, 3, 4)
        ProfileEmail.Name = "ProfileEmail"
        ProfileEmail.ReadOnly = True
        ProfileEmail.Size = New Size(286, 32)
        ProfileEmail.TabIndex = 56
        ' 
        ' ProfileUsername
        ' 
        ProfileUsername.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        ProfileUsername.Font = New Font("Segoe UI", 11F)
        ProfileUsername.Location = New Point(126, 145)
        ProfileUsername.Margin = New Padding(3, 4, 3, 4)
        ProfileUsername.Name = "ProfileUsername"
        ProfileUsername.ReadOnly = True
        ProfileUsername.Size = New Size(286, 32)
        ProfileUsername.TabIndex = 55
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label4.ForeColor = SystemColors.ControlText
        Label4.ImageAlign = ContentAlignment.TopRight
        Label4.Location = New Point(58, 196)
        Label4.Name = "Label4"
        Label4.Size = New Size(65, 25)
        Label4.TabIndex = 52
        Label4.Text = "Email"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label3.ForeColor = SystemColors.ControlText
        Label3.ImageAlign = ContentAlignment.TopRight
        Label3.Location = New Point(16, 152)
        Label3.Name = "Label3"
        Label3.Size = New Size(110, 25)
        Label3.TabIndex = 51
        Label3.Text = "Username"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Microsoft Sans Serif", 13F, FontStyle.Bold)
        Label2.ForeColor = SystemColors.ControlText
        Label2.ImageAlign = ContentAlignment.TopRight
        Label2.Location = New Point(16, 15)
        Label2.Name = "Label2"
        Label2.Size = New Size(81, 26)
        Label2.TabIndex = 50
        Label2.Text = "Profile"
        ' 
        ' ProfileForm
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
        Name = "ProfileForm"
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
        Panel2.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PbEditProfile, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

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
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ProfileUsername As TextBox
    Friend WithEvents ProfileEmail As TextBox
    Friend WithEvents BtnEditProfile As Label
    Friend WithEvents PbEditProfile As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents pbWishlist As PictureBox
    Friend WithEvents lblWishlist As Label
End Class
