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
        SplitContainer1.Size = New Size(934, 486)
        SplitContainer1.SplitterDistance = 186
        SplitContainer1.TabIndex = 34
        ' 
        ' pbWishlist
        ' 
        pbWishlist.BackColor = SystemColors.Info
        pbWishlist.BackgroundImage = CType(resources.GetObject("pbWishlist.BackgroundImage"), Image)
        pbWishlist.BackgroundImageLayout = ImageLayout.Stretch
        pbWishlist.Location = New Point(12, 321)
        pbWishlist.Name = "pbWishlist"
        pbWishlist.Size = New Size(28, 28)
        pbWishlist.TabIndex = 30
        pbWishlist.TabStop = False
        ' 
        ' lblWishlist
        ' 
        lblWishlist.AutoSize = True
        lblWishlist.BackColor = SystemColors.Info
        lblWishlist.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold)
        lblWishlist.ImageAlign = ContentAlignment.TopRight
        lblWishlist.Location = New Point(46, 329)
        lblWishlist.Name = "lblWishlist"
        lblWishlist.Size = New Size(68, 18)
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
        Label1.Location = New Point(12, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(144, 31)
        Label1.TabIndex = 6
        Label1.Text = "ReadNest"
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
        lblDiscover.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold)
        lblDiscover.ImageAlign = ContentAlignment.TopRight
        lblDiscover.Location = New Point(46, 122)
        lblDiscover.Name = "lblDiscover"
        lblDiscover.Size = New Size(75, 18)
        lblDiscover.TabIndex = 21
        lblDiscover.Text = "Discover"
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
        ' lblCategory
        ' 
        lblCategory.AutoSize = True
        lblCategory.BackColor = SystemColors.Info
        lblCategory.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold)
        lblCategory.ImageAlign = ContentAlignment.TopRight
        lblCategory.Location = New Point(46, 156)
        lblCategory.Name = "lblCategory"
        lblCategory.Size = New Size(76, 18)
        lblCategory.TabIndex = 7
        lblCategory.Text = "Category"
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
        ' lblNotes
        ' 
        lblNotes.AutoSize = True
        lblNotes.BackColor = SystemColors.Info
        lblNotes.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold)
        lblNotes.ImageAlign = ContentAlignment.TopRight
        lblNotes.Location = New Point(46, 191)
        lblNotes.Name = "lblNotes"
        lblNotes.Size = New Size(80, 18)
        lblNotes.TabIndex = 8
        lblNotes.Text = "My Notes"
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
        ' lblFavorite
        ' 
        lblFavorite.AutoSize = True
        lblFavorite.BackColor = SystemColors.Info
        lblFavorite.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold)
        lblFavorite.ImageAlign = ContentAlignment.TopRight
        lblFavorite.Location = New Point(46, 227)
        lblFavorite.Name = "lblFavorite"
        lblFavorite.Size = New Size(69, 18)
        lblFavorite.TabIndex = 9
        lblFavorite.Text = "Favorite"
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
        ' lblBB
        ' 
        lblBB.AutoSize = True
        lblBB.BackColor = SystemColors.Info
        lblBB.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold)
        lblBB.ImageAlign = ContentAlignment.TopRight
        lblBB.Location = New Point(46, 260)
        lblBB.Name = "lblBB"
        lblBB.Size = New Size(130, 18)
        lblBB.TabIndex = 28
        lblBB.Text = "Book Borrowing"
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
        lblstatistic.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold)
        lblstatistic.ImageAlign = ContentAlignment.TopRight
        lblstatistic.Location = New Point(46, 294)
        lblstatistic.Name = "lblstatistic"
        lblstatistic.Size = New Size(96, 18)
        lblstatistic.TabIndex = 24
        lblstatistic.Text = "My Statistic"
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
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(744, 486)
        Panel1.TabIndex = 0
        ' 
        ' btnHorror
        ' 
        btnHorror.BackColor = Color.White
        btnHorror.BackgroundImage = CType(resources.GetObject("btnHorror.BackgroundImage"), Image)
        btnHorror.BackgroundImageLayout = ImageLayout.Center
        btnHorror.Font = New Font("Segoe UI", 11F)
        btnHorror.Location = New Point(494, 276)
        btnHorror.Name = "btnHorror"
        btnHorror.Size = New Size(140, 171)
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
        BtnRomance.Location = New Point(494, 85)
        BtnRomance.Name = "BtnRomance"
        BtnRomance.Size = New Size(140, 171)
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
        btnComic.Location = New Point(348, 276)
        btnComic.Name = "btnComic"
        btnComic.Size = New Size(140, 171)
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
        btnNovel.Location = New Point(52, 276)
        btnNovel.Name = "btnNovel"
        btnNovel.Size = New Size(140, 171)
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
        btnHistory.Location = New Point(202, 276)
        btnHistory.Name = "btnHistory"
        btnHistory.Size = New Size(140, 171)
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
        btnTechno.Location = New Point(348, 85)
        btnTechno.Name = "btnTechno"
        btnTechno.Size = New Size(140, 171)
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
        btnAcademy.Location = New Point(202, 85)
        btnAcademy.Name = "btnAcademy"
        btnAcademy.Size = New Size(140, 171)
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
        btnBiography.Location = New Point(52, 85)
        btnBiography.Name = "btnBiography"
        btnBiography.Size = New Size(140, 171)
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
        pbProfile.Location = New Point(583, 20)
        pbProfile.Name = "pbProfile"
        pbProfile.Size = New Size(28, 28)
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
        Label5.Location = New Point(52, 45)
        Label5.Name = "Label5"
        Label5.Size = New Size(211, 26)
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
        cbProfile.Location = New Point(617, 21)
        cbProfile.Name = "cbProfile"
        cbProfile.Size = New Size(97, 26)
        cbProfile.TabIndex = 43
        cbProfile.Text = "Profile"
        ' 
        ' CategoryForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(934, 486)
        Controls.Add(SplitContainer1)
        Name = "CategoryForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form6"
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
