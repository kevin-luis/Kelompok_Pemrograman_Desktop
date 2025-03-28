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
        Label7 = New Label()
        PictureBox9 = New PictureBox()
        lblLogout = New Label()
        PictureBox5 = New PictureBox()
        Label2 = New Label()
        txtConfirmPassword = New TextBox()
        Label5 = New Label()
        txtCreateUsername = New TextBox()
        Label6 = New Label()
        Label8 = New Label()
        txtCreatePassword = New TextBox()
        txtCreateEmail = New TextBox()
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
        Splitter1 = New Splitter()
        CType(PictureBox9, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
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
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Cornsilk
        Label7.Font = New Font("UD Digi Kyokasho NK-B", 13.25F, FontStyle.Bold)
        Label7.Location = New Point(337, 81)
        Label7.Name = "Label7"
        Label7.Size = New Size(74, 21)
        Label7.TabIndex = 51
        Label7.Text = "Profile"
        ' 
        ' PictureBox9
        ' 
        PictureBox9.BackColor = Color.Cornsilk
        PictureBox9.BorderStyle = BorderStyle.FixedSingle
        PictureBox9.Location = New Point(297, 63)
        PictureBox9.Name = "PictureBox9"
        PictureBox9.Size = New Size(409, 378)
        PictureBox9.TabIndex = 80
        PictureBox9.TabStop = False
        ' 
        ' lblLogout
        ' 
        lblLogout.AutoSize = True
        lblLogout.BackColor = SystemColors.Info
        lblLogout.Font = New Font("UD Digi Kyokasho NP-B", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        lblLogout.ImageAlign = ContentAlignment.TopRight
        lblLogout.Location = New Point(607, 393)
        lblLogout.Name = "lblLogout"
        lblLogout.Size = New Size(63, 17)
        lblLogout.TabIndex = 82
        lblLogout.Text = "Logout"
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackColor = SystemColors.Info
        PictureBox5.BackgroundImage = CType(resources.GetObject("PictureBox5.BackgroundImage"), Image)
        PictureBox5.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox5.Location = New Point(573, 382)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(28, 28)
        PictureBox5.TabIndex = 81
        PictureBox5.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label2.Location = New Point(337, 309)
        Label2.Name = "Label2"
        Label2.Size = New Size(148, 18)
        Label2.TabIndex = 90
        Label2.Text = "Confirm Password"
        ' 
        ' txtConfirmPassword
        ' 
        txtConfirmPassword.Font = New Font("Segoe UI", 11F)
        txtConfirmPassword.Location = New Point(340, 330)
        txtConfirmPassword.Name = "txtConfirmPassword"
        txtConfirmPassword.PlaceholderText = "Enter your confirm password here"
        txtConfirmPassword.Size = New Size(262, 27)
        txtConfirmPassword.TabIndex = 86
        txtConfirmPassword.UseSystemPasswordChar = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label5.Location = New Point(340, 126)
        Label5.Name = "Label5"
        Label5.Size = New Size(50, 18)
        Label5.TabIndex = 89
        Label5.Text = "Email"
        ' 
        ' txtCreateUsername
        ' 
        txtCreateUsername.Font = New Font("Segoe UI", 11F)
        txtCreateUsername.Location = New Point(340, 209)
        txtCreateUsername.Name = "txtCreateUsername"
        txtCreateUsername.PlaceholderText = "Enter your email here"
        txtCreateUsername.Size = New Size(262, 27)
        txtCreateUsername.TabIndex = 84
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label6.Location = New Point(340, 251)
        Label6.Name = "Label6"
        Label6.Size = New Size(83, 18)
        Label6.TabIndex = 88
        Label6.Text = "Password"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label8.Location = New Point(337, 188)
        Label8.Name = "Label8"
        Label8.Size = New Size(85, 18)
        Label8.TabIndex = 87
        Label8.Text = "Username"
        ' 
        ' txtCreatePassword
        ' 
        txtCreatePassword.Font = New Font("Segoe UI", 11F)
        txtCreatePassword.Location = New Point(340, 272)
        txtCreatePassword.Name = "txtCreatePassword"
        txtCreatePassword.PlaceholderText = "Enter your password here"
        txtCreatePassword.Size = New Size(262, 27)
        txtCreatePassword.TabIndex = 85
        txtCreatePassword.UseSystemPasswordChar = True
        ' 
        ' txtCreateEmail
        ' 
        txtCreateEmail.Font = New Font("Segoe UI", 11F)
        txtCreateEmail.Location = New Point(340, 147)
        txtCreateEmail.Name = "txtCreateEmail"
        txtCreateEmail.PlaceholderText = "Enter your username here"
        txtCreateEmail.Size = New Size(262, 27)
        txtCreateEmail.TabIndex = 83
        ' 
        ' pbBB
        ' 
        pbBB.BackColor = SystemColors.Info
        pbBB.BackgroundImage = CType(resources.GetObject("pbBB.BackgroundImage"), Image)
        pbBB.BackgroundImageLayout = ImageLayout.Stretch
        pbBB.Location = New Point(12, 252)
        pbBB.Name = "pbBB"
        pbBB.Size = New Size(28, 28)
        pbBB.TabIndex = 104
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
        lblBB.TabIndex = 103
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
        lblstatistic.TabIndex = 102
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
        pbStatistic.TabIndex = 101
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
        lblDiscover.TabIndex = 100
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
        pbDiscover.TabIndex = 99
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
        lblMenu.TabIndex = 98
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
        lblFavorite.TabIndex = 97
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
        lblNotes.TabIndex = 96
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
        lblCategory.TabIndex = 95
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
        Label1.TabIndex = 94
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
        pbFavorite.TabIndex = 93
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
        pbNotes.TabIndex = 92
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
        pbCategory.TabIndex = 91
        pbCategory.TabStop = False
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
        SplitContainer1.TabIndex = 105
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
        ' Splitter1
        ' 
        Splitter1.Location = New Point(0, 0)
        Splitter1.Name = "Splitter1"
        Splitter1.Size = New Size(3, 486)
        Splitter1.TabIndex = 0
        Splitter1.TabStop = False
        ' 
        ' ProfileForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(934, 486)
        Controls.Add(lblLogout)
        Controls.Add(PictureBox5)
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
        Controls.Add(Label2)
        Controls.Add(txtConfirmPassword)
        Controls.Add(Label5)
        Controls.Add(txtCreateUsername)
        Controls.Add(Label6)
        Controls.Add(Label8)
        Controls.Add(txtCreatePassword)
        Controls.Add(txtCreateEmail)
        Controls.Add(Label7)
        Controls.Add(PictureBox9)
        Controls.Add(SplitContainer1)
        Name = "ProfileForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form10"
        CType(PictureBox9, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(pbBB, ComponentModel.ISupportInitialize).EndInit()
        CType(pbStatistic, ComponentModel.ISupportInitialize).EndInit()
        CType(pbDiscover, ComponentModel.ISupportInitialize).EndInit()
        CType(pbFavorite, ComponentModel.ISupportInitialize).EndInit()
        CType(pbNotes, ComponentModel.ISupportInitialize).EndInit()
        CType(pbCategory, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.Panel1.ResumeLayout(False)
        SplitContainer1.Panel2.ResumeLayout(False)
        CType(SplitContainer1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents lblLogout As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCreateUsername As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtCreatePassword As TextBox
    Friend WithEvents txtCreateEmail As TextBox
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
End Class
