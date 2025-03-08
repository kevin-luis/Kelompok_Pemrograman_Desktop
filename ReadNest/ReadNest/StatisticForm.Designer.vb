<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StatisticForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StatisticForm))
        Label2 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        txtTotalBooksRead = New TextBox()
        txtTotalReadingTime = New TextBox()
        txtTotalFavoriteBooks = New TextBox()
        PictureBox9 = New PictureBox()
        lblUsername = New Label()
        pbProfile = New PictureBox()
        PictureBox10 = New PictureBox()
        Label4 = New Label()
        Label3 = New Label()
        PictureBox8 = New PictureBox()
        lblDiscover = New Label()
        PictureBox1 = New PictureBox()
        lblMenu = New Label()
        lblFavorite = New Label()
        lblMyLibrary = New Label()
        lblCategory = New Label()
        Label1 = New Label()
        PictureBox6 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox2 = New PictureBox()
        CType(PictureBox9, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbProfile, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox10, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("UD Digi Kyokasho NP-B", 16.2F, FontStyle.Bold)
        Label2.ForeColor = SystemColors.ControlText
        Label2.ImageAlign = ContentAlignment.TopRight
        Label2.Location = New Point(258, 118)
        Label2.Name = "Label2"
        Label2.Size = New Size(171, 25)
        Label2.TabIndex = 49
        Label2.Text = "Book Statistic"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("UD Digi Kyokasho NP-B", 13.2F, FontStyle.Bold)
        Label5.ForeColor = SystemColors.ControlText
        Label5.ImageAlign = ContentAlignment.TopRight
        Label5.Location = New Point(289, 194)
        Label5.Name = "Label5"
        Label5.Size = New Size(175, 21)
        Label5.TabIndex = 50
        Label5.Text = "Total Books Read"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("UD Digi Kyokasho NP-B", 13.2F, FontStyle.Bold)
        Label6.ForeColor = SystemColors.ControlText
        Label6.ImageAlign = ContentAlignment.TopRight
        Label6.Location = New Point(289, 264)
        Label6.Name = "Label6"
        Label6.Size = New Size(206, 21)
        Label6.TabIndex = 51
        Label6.Text = "Total Favorite Books"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("UD Digi Kyokasho NP-B", 13.2F, FontStyle.Bold)
        Label7.ForeColor = SystemColors.ControlText
        Label7.ImageAlign = ContentAlignment.TopRight
        Label7.Location = New Point(289, 230)
        Label7.Name = "Label7"
        Label7.Size = New Size(194, 21)
        Label7.TabIndex = 52
        Label7.Text = "Total Reading Time"
        ' 
        ' txtTotalBooksRead
        ' 
        txtTotalBooksRead.Location = New Point(517, 192)
        txtTotalBooksRead.Name = "txtTotalBooksRead"
        txtTotalBooksRead.Size = New Size(100, 23)
        txtTotalBooksRead.TabIndex = 53
        ' 
        ' txtTotalReadingTime
        ' 
        txtTotalReadingTime.Location = New Point(517, 228)
        txtTotalReadingTime.Name = "txtTotalReadingTime"
        txtTotalReadingTime.Size = New Size(100, 23)
        txtTotalReadingTime.TabIndex = 54
        ' 
        ' txtTotalFavoriteBooks
        ' 
        txtTotalFavoriteBooks.Location = New Point(517, 262)
        txtTotalFavoriteBooks.Name = "txtTotalFavoriteBooks"
        txtTotalFavoriteBooks.Size = New Size(100, 23)
        txtTotalFavoriteBooks.TabIndex = 55
        ' 
        ' PictureBox9
        ' 
        PictureBox9.BackColor = Color.Cornsilk
        PictureBox9.BorderStyle = BorderStyle.FixedSingle
        PictureBox9.Location = New Point(258, 152)
        PictureBox9.Name = "PictureBox9"
        PictureBox9.Size = New Size(405, 172)
        PictureBox9.TabIndex = 56
        PictureBox9.TabStop = False
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Font = New Font("UD Digi Kyokasho NK-B", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        lblUsername.Location = New Point(831, 23)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(61, 17)
        lblUsername.TabIndex = 58
        lblUsername.Text = "Profile"
        ' 
        ' pbProfile
        ' 
        pbProfile.BackgroundImage = CType(resources.GetObject("pbProfile.BackgroundImage"), Image)
        pbProfile.BackgroundImageLayout = ImageLayout.Stretch
        pbProfile.Location = New Point(797, 12)
        pbProfile.Name = "pbProfile"
        pbProfile.Size = New Size(28, 28)
        pbProfile.TabIndex = 57
        pbProfile.TabStop = False
        ' 
        ' PictureBox10
        ' 
        PictureBox10.BackColor = SystemColors.Info
        PictureBox10.BackgroundImage = CType(resources.GetObject("PictureBox10.BackgroundImage"), Image)
        PictureBox10.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox10.Location = New Point(12, 254)
        PictureBox10.Name = "PictureBox10"
        PictureBox10.Size = New Size(28, 28)
        PictureBox10.TabIndex = 75
        PictureBox10.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = SystemColors.Info
        Label4.Font = New Font("UD Digi Kyokasho NP-B", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label4.ImageAlign = ContentAlignment.TopRight
        Label4.Location = New Point(46, 265)
        Label4.Name = "Label4"
        Label4.Size = New Size(125, 17)
        Label4.TabIndex = 74
        Label4.Text = "Borrowed Book"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.Info
        Label3.Font = New Font("UD Digi Kyokasho NP-B", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label3.ImageAlign = ContentAlignment.TopRight
        Label3.Location = New Point(46, 299)
        Label3.Name = "Label3"
        Label3.Size = New Size(103, 17)
        Label3.TabIndex = 73
        Label3.Text = "My Statistic"
        ' 
        ' PictureBox8
        ' 
        PictureBox8.BackColor = SystemColors.Info
        PictureBox8.BackgroundImage = CType(resources.GetObject("PictureBox8.BackgroundImage"), Image)
        PictureBox8.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox8.Location = New Point(12, 288)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(28, 28)
        PictureBox8.TabIndex = 72
        PictureBox8.TabStop = False
        ' 
        ' lblDiscover
        ' 
        lblDiscover.AutoSize = True
        lblDiscover.BackColor = SystemColors.Info
        lblDiscover.Font = New Font("UD Digi Kyokasho NP-B", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        lblDiscover.ImageAlign = ContentAlignment.TopRight
        lblDiscover.Location = New Point(46, 127)
        lblDiscover.Name = "lblDiscover"
        lblDiscover.Size = New Size(74, 17)
        lblDiscover.TabIndex = 70
        lblDiscover.Text = "Discover"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = SystemColors.Info
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(12, 116)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(28, 28)
        PictureBox1.TabIndex = 69
        PictureBox1.TabStop = False
        ' 
        ' lblMenu
        ' 
        lblMenu.AutoSize = True
        lblMenu.BackColor = SystemColors.Info
        lblMenu.Font = New Font("UD Digi Kyokasho NP-B", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        lblMenu.ImageAlign = ContentAlignment.TopRight
        lblMenu.Location = New Point(12, 85)
        lblMenu.Name = "lblMenu"
        lblMenu.Size = New Size(51, 17)
        lblMenu.TabIndex = 68
        lblMenu.Text = "Menu"
        ' 
        ' lblFavorite
        ' 
        lblFavorite.AutoSize = True
        lblFavorite.BackColor = SystemColors.Info
        lblFavorite.Font = New Font("UD Digi Kyokasho NP-B", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        lblFavorite.ImageAlign = ContentAlignment.TopRight
        lblFavorite.Location = New Point(46, 231)
        lblFavorite.Name = "lblFavorite"
        lblFavorite.Size = New Size(73, 17)
        lblFavorite.TabIndex = 66
        lblFavorite.Text = "Favorite"
        ' 
        ' lblMyLibrary
        ' 
        lblMyLibrary.AutoSize = True
        lblMyLibrary.BackColor = SystemColors.Info
        lblMyLibrary.Font = New Font("UD Digi Kyokasho NP-B", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        lblMyLibrary.ImageAlign = ContentAlignment.TopRight
        lblMyLibrary.Location = New Point(46, 195)
        lblMyLibrary.Name = "lblMyLibrary"
        lblMyLibrary.Size = New Size(81, 17)
        lblMyLibrary.TabIndex = 65
        lblMyLibrary.Text = "My Notes"
        ' 
        ' lblCategory
        ' 
        lblCategory.AutoSize = True
        lblCategory.BackColor = SystemColors.Info
        lblCategory.Font = New Font("UD Digi Kyokasho NP-B", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        lblCategory.ImageAlign = ContentAlignment.TopRight
        lblCategory.Location = New Point(46, 161)
        lblCategory.Name = "lblCategory"
        lblCategory.Size = New Size(80, 17)
        lblCategory.TabIndex = 64
        lblCategory.Text = "Category"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.Info
        Label1.Font = New Font("UD Digi Kyokasho NP-B", 20.25F, FontStyle.Bold)
        Label1.ForeColor = SystemColors.ControlText
        Label1.ImageAlign = ContentAlignment.TopRight
        Label1.Location = New Point(12, 27)
        Label1.Name = "Label1"
        Label1.Size = New Size(148, 31)
        Label1.TabIndex = 63
        Label1.Text = "ReadNest"
        ' 
        ' PictureBox6
        ' 
        PictureBox6.BackColor = SystemColors.Info
        PictureBox6.BackgroundImage = CType(resources.GetObject("PictureBox6.BackgroundImage"), Image)
        PictureBox6.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox6.Location = New Point(12, 220)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(28, 28)
        PictureBox6.TabIndex = 62
        PictureBox6.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = SystemColors.Info
        PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), Image)
        PictureBox4.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox4.Location = New Point(12, 184)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(28, 28)
        PictureBox4.TabIndex = 60
        PictureBox4.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = SystemColors.Info
        PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), Image)
        PictureBox3.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox3.Location = New Point(12, 150)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(28, 28)
        PictureBox3.TabIndex = 59
        PictureBox3.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = SystemColors.Info
        PictureBox2.BorderStyle = BorderStyle.FixedSingle
        PictureBox2.Location = New Point(0, -7)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(180, 498)
        PictureBox2.TabIndex = 71
        PictureBox2.TabStop = False
        ' 
        ' StatisticForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(934, 486)
        Controls.Add(PictureBox10)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(PictureBox8)
        Controls.Add(lblDiscover)
        Controls.Add(PictureBox1)
        Controls.Add(lblMenu)
        Controls.Add(lblFavorite)
        Controls.Add(lblMyLibrary)
        Controls.Add(lblCategory)
        Controls.Add(Label1)
        Controls.Add(PictureBox6)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(lblUsername)
        Controls.Add(pbProfile)
        Controls.Add(txtTotalFavoriteBooks)
        Controls.Add(txtTotalReadingTime)
        Controls.Add(txtTotalBooksRead)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label2)
        Controls.Add(PictureBox9)
        Name = "StatisticForm"
        Text = "Form5"
        CType(PictureBox9, ComponentModel.ISupportInitialize).EndInit()
        CType(pbProfile, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox10, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents lblUsername As Label
    Friend WithEvents pbProfile As PictureBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents lblDiscover As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblMenu As Label
    Friend WithEvents lblFavorite As Label
    Friend WithEvents lblMyLibrary As Label
    Friend WithEvents lblCategory As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
