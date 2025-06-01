<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListBorrowerForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListBorrowerForm))
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
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        Panel1 = New Panel()
        Label2 = New Label()
        cbProfile = New ComboBox()
        pbProfile = New PictureBox()
        flowBorrowers = New FlowLayoutPanel()
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
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(pbProfile, ComponentModel.ISupportInitialize).BeginInit()
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
        pbBB.TabIndex = 123
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
        lblBB.TabIndex = 122
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
        lblstatistic.TabIndex = 121
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
        pbStatistic.TabIndex = 120
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
        lblDiscover.TabIndex = 119
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
        pbDiscover.TabIndex = 118
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
        lblMenu.TabIndex = 117
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
        lblFavorite.TabIndex = 116
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
        lblNotes.TabIndex = 115
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
        lblCategory.TabIndex = 114
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
        Label1.TabIndex = 113
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
        pbFavorite.TabIndex = 112
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
        pbNotes.TabIndex = 111
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
        pbCategory.TabIndex = 110
        pbCategory.TabStop = False
        ' 
        ' SplitContainer1
        ' 
        SplitContainer1.Dock = DockStyle.Fill
        SplitContainer1.Location = New Point(0, 0)
        SplitContainer1.Margin = New Padding(3, 4, 3, 4)
        SplitContainer1.Name = "SplitContainer1"
        ' 
        ' SplitContainer1.Panel1
        ' 
        SplitContainer1.Panel1.Controls.Add(lblWishlist)
        SplitContainer1.Panel1.Controls.Add(PictureBox1)
        SplitContainer1.Panel1.Controls.Add(PictureBox2)
        ' 
        ' SplitContainer1.Panel2
        ' 
        SplitContainer1.Panel2.Controls.Add(Panel1)
        SplitContainer1.Size = New Size(1067, 648)
        SplitContainer1.SplitterDistance = 212
        SplitContainer1.SplitterWidth = 5
        SplitContainer1.TabIndex = 124
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
        lblWishlist.TabIndex = 111
        lblWishlist.Text = "Wishlist"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = SystemColors.Info
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(14, 428)
        PictureBox1.Margin = New Padding(3, 4, 3, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(32, 37)
        PictureBox1.TabIndex = 110
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = SystemColors.Info
        PictureBox2.BorderStyle = BorderStyle.FixedSingle
        PictureBox2.Dock = DockStyle.Fill
        PictureBox2.Location = New Point(0, 0)
        PictureBox2.Margin = New Padding(3, 4, 3, 4)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(212, 648)
        PictureBox2.TabIndex = 22
        PictureBox2.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(cbProfile)
        Panel1.Controls.Add(pbProfile)
        Panel1.Controls.Add(flowBorrowers)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(850, 648)
        Panel1.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold)
        Label2.ForeColor = SystemColors.ControlText
        Label2.ImageAlign = ContentAlignment.TopRight
        Label2.Location = New Point(15, 69)
        Label2.Name = "Label2"
        Label2.Size = New Size(313, 32)
        Label2.TabIndex = 125
        Label2.Text = "List of book borrowers"
        ' 
        ' cbProfile
        ' 
        cbProfile.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        cbProfile.DropDownStyle = ComboBoxStyle.DropDownList
        cbProfile.FlatStyle = FlatStyle.Flat
        cbProfile.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold)
        cbProfile.FormattingEnabled = True
        cbProfile.Items.AddRange(New Object() {"Profile", "View Profile", "Logout"})
        cbProfile.Location = New Point(697, 31)
        cbProfile.Margin = New Padding(3, 4, 3, 4)
        cbProfile.Name = "cbProfile"
        cbProfile.Size = New Size(110, 32)
        cbProfile.TabIndex = 111
        ' 
        ' pbProfile
        ' 
        pbProfile.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        pbProfile.BackgroundImage = CType(resources.GetObject("pbProfile.BackgroundImage"), Image)
        pbProfile.BackgroundImageLayout = ImageLayout.Stretch
        pbProfile.Location = New Point(658, 29)
        pbProfile.Margin = New Padding(3, 4, 3, 4)
        pbProfile.Name = "pbProfile"
        pbProfile.Size = New Size(32, 37)
        pbProfile.TabIndex = 93
        pbProfile.TabStop = False
        ' 
        ' flowBorrowers
        ' 
        flowBorrowers.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        flowBorrowers.AutoScroll = True
        flowBorrowers.BackColor = Color.White
        flowBorrowers.Location = New Point(15, 113)
        flowBorrowers.Margin = New Padding(3, 4, 3, 4)
        flowBorrowers.Name = "flowBorrowers"
        flowBorrowers.Padding = New Padding(10, 11, 10, 11)
        flowBorrowers.Size = New Size(822, 519)
        flowBorrowers.TabIndex = 34
        ' 
        ' ListBorrowerForm
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
        Name = "ListBorrowerForm"
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
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(pbProfile, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents lblWishlist As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents flowBorrowers As FlowLayoutPanel
    Friend WithEvents pbProfile As PictureBox
    Friend WithEvents cbProfile As ComboBox
    Friend WithEvents Label2 As Label
End Class
