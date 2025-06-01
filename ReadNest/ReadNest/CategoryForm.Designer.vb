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
        btnHorror = New Button()
        BtnRomance = New Button()
        btnComic = New Button()
        btnNovel = New Button()
        btnHistory = New Button()
        btnTechno = New Button()
        btnAcademy = New Button()
        btnBiography = New Button()
        pbProfile = New PictureBox()
        Label5 = New Label()
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
        SplitContainer1.TabIndex = 34
        ' 
        ' pbWishlist
        ' 
        pbWishlist.BackColor = SystemColors.Info
        pbWishlist.BackgroundImage = CType(resources.GetObject("pbWishlist.BackgroundImage"), Image)
        pbWishlist.BackgroundImageLayout = ImageLayout.Stretch
        pbWishlist.Location = New Point(14, 428)
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
        lblWishlist.Location = New Point(53, 439)
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
        Panel1.Controls.Add(btnHorror)
        Panel1.Controls.Add(BtnRomance)
        Panel1.Controls.Add(btnComic)
        Panel1.Controls.Add(btnNovel)
        Panel1.Controls.Add(btnHistory)
        Panel1.Controls.Add(btnTechno)
        Panel1.Controls.Add(btnAcademy)
        Panel1.Controls.Add(btnBiography)
        Panel1.Controls.Add(pbProfile)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(cbProfile)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(849, 648)
        Panel1.TabIndex = 0
        ' 
        ' btnHorror
        ' 
        btnHorror.BackColor = Color.White
        btnHorror.BackgroundImage = CType(resources.GetObject("btnHorror.BackgroundImage"), Image)
        btnHorror.BackgroundImageLayout = ImageLayout.Center
        btnHorror.Font = New Font("Segoe UI", 11F)
        btnHorror.Location = New Point(565, 368)
        btnHorror.Margin = New Padding(3, 4, 3, 4)
        btnHorror.Name = "btnHorror"
        btnHorror.Size = New Size(160, 228)
        btnHorror.TabIndex = 51
        btnHorror.Text = "Horror"
        btnHorror.TextAlign = ContentAlignment.BottomCenter
        btnHorror.UseVisualStyleBackColor = False
        ' 
        ' BtnRomance
        ' 
        BtnRomance.BackColor = Color.White
        BtnRomance.BackgroundImage = CType(resources.GetObject("BtnRomance.BackgroundImage"), Image)
        BtnRomance.BackgroundImageLayout = ImageLayout.Center
        BtnRomance.Font = New Font("Segoe UI", 11F)
        BtnRomance.Location = New Point(565, 113)
        BtnRomance.Margin = New Padding(3, 4, 3, 4)
        BtnRomance.Name = "BtnRomance"
        BtnRomance.Size = New Size(160, 228)
        BtnRomance.TabIndex = 50
        BtnRomance.Text = "Romance"
        BtnRomance.TextAlign = ContentAlignment.BottomCenter
        BtnRomance.UseVisualStyleBackColor = False
        ' 
        ' btnComic
        ' 
        btnComic.BackColor = Color.White
        btnComic.BackgroundImage = CType(resources.GetObject("btnComic.BackgroundImage"), Image)
        btnComic.BackgroundImageLayout = ImageLayout.Center
        btnComic.Font = New Font("Segoe UI", 11F)
        btnComic.Location = New Point(398, 368)
        btnComic.Margin = New Padding(3, 4, 3, 4)
        btnComic.Name = "btnComic"
        btnComic.Size = New Size(160, 228)
        btnComic.TabIndex = 49
        btnComic.Text = "Comic"
        btnComic.TextAlign = ContentAlignment.BottomCenter
        btnComic.UseVisualStyleBackColor = False
        ' 
        ' btnNovel
        ' 
        btnNovel.BackColor = Color.White
        btnNovel.BackgroundImage = CType(resources.GetObject("btnNovel.BackgroundImage"), Image)
        btnNovel.BackgroundImageLayout = ImageLayout.Center
        btnNovel.Font = New Font("Segoe UI", 11F)
        btnNovel.Location = New Point(59, 368)
        btnNovel.Margin = New Padding(3, 4, 3, 4)
        btnNovel.Name = "btnNovel"
        btnNovel.Size = New Size(160, 228)
        btnNovel.TabIndex = 48
        btnNovel.Text = "Novel"
        btnNovel.TextAlign = ContentAlignment.BottomCenter
        btnNovel.UseVisualStyleBackColor = False
        ' 
        ' btnHistory
        ' 
        btnHistory.BackColor = Color.White
        btnHistory.BackgroundImage = CType(resources.GetObject("btnHistory.BackgroundImage"), Image)
        btnHistory.BackgroundImageLayout = ImageLayout.Center
        btnHistory.Font = New Font("Segoe UI", 11F)
        btnHistory.Location = New Point(231, 368)
        btnHistory.Margin = New Padding(3, 4, 3, 4)
        btnHistory.Name = "btnHistory"
        btnHistory.Size = New Size(160, 228)
        btnHistory.TabIndex = 47
        btnHistory.Text = "History"
        btnHistory.TextAlign = ContentAlignment.BottomCenter
        btnHistory.UseVisualStyleBackColor = False
        ' 
        ' btnTechno
        ' 
        btnTechno.BackColor = Color.White
        btnTechno.BackgroundImage = CType(resources.GetObject("btnTechno.BackgroundImage"), Image)
        btnTechno.BackgroundImageLayout = ImageLayout.Center
        btnTechno.Font = New Font("Segoe UI", 11F)
        btnTechno.Location = New Point(398, 113)
        btnTechno.Margin = New Padding(3, 4, 3, 4)
        btnTechno.Name = "btnTechno"
        btnTechno.Size = New Size(160, 228)
        btnTechno.TabIndex = 46
        btnTechno.Text = "Techno"
        btnTechno.TextAlign = ContentAlignment.BottomCenter
        btnTechno.UseVisualStyleBackColor = False
        ' 
        ' btnAcademy
        ' 
        btnAcademy.BackColor = Color.White
        btnAcademy.BackgroundImage = CType(resources.GetObject("btnAcademy.BackgroundImage"), Image)
        btnAcademy.BackgroundImageLayout = ImageLayout.Center
        btnAcademy.Font = New Font("Segoe UI", 11F)
        btnAcademy.Location = New Point(231, 113)
        btnAcademy.Margin = New Padding(3, 4, 3, 4)
        btnAcademy.Name = "btnAcademy"
        btnAcademy.Size = New Size(160, 228)
        btnAcademy.TabIndex = 45
        btnAcademy.Text = "Academy"
        btnAcademy.TextAlign = ContentAlignment.BottomCenter
        btnAcademy.UseVisualStyleBackColor = False
        ' 
        ' btnBiography
        ' 
        btnBiography.BackColor = Color.White
        btnBiography.BackgroundImage = CType(resources.GetObject("btnBiography.BackgroundImage"), Image)
        btnBiography.BackgroundImageLayout = ImageLayout.Center
        btnBiography.Font = New Font("Segoe UI", 11F)
        btnBiography.Location = New Point(59, 113)
        btnBiography.Margin = New Padding(3, 4, 3, 4)
        btnBiography.Name = "btnBiography"
        btnBiography.Size = New Size(160, 228)
        btnBiography.TabIndex = 44
        btnBiography.Text = "Biography"
        btnBiography.TextAlign = ContentAlignment.BottomCenter
        btnBiography.UseVisualStyleBackColor = False
        ' 
        ' pbProfile
        ' 
        pbProfile.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        pbProfile.BackgroundImage = CType(resources.GetObject("pbProfile.BackgroundImage"), Image)
        pbProfile.BackgroundImageLayout = ImageLayout.Stretch
        pbProfile.Location = New Point(665, 27)
        pbProfile.Margin = New Padding(3, 4, 3, 4)
        pbProfile.Name = "pbProfile"
        pbProfile.Size = New Size(32, 37)
        pbProfile.TabIndex = 37
        pbProfile.TabStop = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold)
        Label5.ForeColor = SystemColors.ControlText
        Label5.ImageAlign = ContentAlignment.TopRight
        Label5.Location = New Point(59, 60)
        Label5.Name = "Label5"
        Label5.Size = New Size(266, 32)
        Label5.TabIndex = 41
        Label5.Text = "Your Category List"
        ' 
        ' cbProfile
        ' 
        cbProfile.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        cbProfile.FlatStyle = FlatStyle.Flat
        cbProfile.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold)
        cbProfile.FormattingEnabled = True
        cbProfile.Items.AddRange(New Object() {"View Profile", "Logout"})
        cbProfile.Location = New Point(704, 28)
        cbProfile.Margin = New Padding(3, 4, 3, 4)
        cbProfile.Name = "cbProfile"
        cbProfile.Size = New Size(110, 32)
        cbProfile.TabIndex = 43
        cbProfile.Text = "Profile"
        ' 
        ' CategoryForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1067, 648)
        Controls.Add(SplitContainer1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "CategoryForm"
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
        CType(pbProfile, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents lvCategoryBooks As ListView
    Friend WithEvents lblUsername As Label
    Friend WithEvents cbCategoryBooks As ComboBox
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
    Friend WithEvents pbProfile As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cbProfile As ComboBox
    Friend WithEvents btnBiography As Button
    Friend WithEvents btnAcademy As Button
    Friend WithEvents btnHistory As Button
    Friend WithEvents btnTechno As Button
    Friend WithEvents btnNovel As Button
    Friend WithEvents btnComic As Button
    Friend WithEvents btnHorror As Button
    Friend WithEvents BtnRomance As Button
    Friend WithEvents pbWishlist As PictureBox
    Friend WithEvents lblWishlist As Label
End Class
