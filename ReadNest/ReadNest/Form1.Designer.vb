<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox5 = New PictureBox()
        PictureBox6 = New PictureBox()
        Label1 = New Label()
        lblCategory = New Label()
        lblMyLibrary = New Label()
        lblFavorite = New Label()
        lblLogout = New Label()
        lblMenu = New Label()
        Button1 = New Button()
        TextBox1 = New TextBox()
        pbProfile = New PictureBox()
        lblUsername = New Label()
        Label2 = New Label()
        PictureBox1 = New PictureBox()
        lblDiscover = New Label()
        PictureBox2 = New PictureBox()
        PictureBox8 = New PictureBox()
        Label3 = New Label()
        ListView1 = New ListView()
        Button2 = New Button()
        PictureBox9 = New PictureBox()
        Label4 = New Label()
        PictureBox10 = New PictureBox()
        Label5 = New Label()
        ListView2 = New ListView()
        Label6 = New Label()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbProfile, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox9, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox10, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), Image)
        PictureBox3.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox3.Location = New Point(12, 148)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(28, 28)
        PictureBox3.TabIndex = 2
        PictureBox3.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), Image)
        PictureBox4.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox4.Location = New Point(12, 182)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(28, 28)
        PictureBox4.TabIndex = 3
        PictureBox4.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackgroundImage = CType(resources.GetObject("PictureBox5.BackgroundImage"), Image)
        PictureBox5.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox5.Location = New Point(12, 435)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(28, 28)
        PictureBox5.TabIndex = 4
        PictureBox5.TabStop = False
        ' 
        ' PictureBox6
        ' 
        PictureBox6.BackgroundImage = CType(resources.GetObject("PictureBox6.BackgroundImage"), Image)
        PictureBox6.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox6.Location = New Point(12, 218)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(28, 28)
        PictureBox6.TabIndex = 5
        PictureBox6.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.Info
        Label1.Font = New Font("UD Digi Kyokasho NP-B", 20.25F, FontStyle.Bold)
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
        lblCategory.Font = New Font("UD Digi Kyokasho NP-B", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        lblCategory.ImageAlign = ContentAlignment.TopRight
        lblCategory.Location = New Point(46, 159)
        lblCategory.Name = "lblCategory"
        lblCategory.Size = New Size(80, 17)
        lblCategory.TabIndex = 7
        lblCategory.Text = "Category"
        ' 
        ' lblMyLibrary
        ' 
        lblMyLibrary.AutoSize = True
        lblMyLibrary.Font = New Font("UD Digi Kyokasho NP-B", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        lblMyLibrary.ImageAlign = ContentAlignment.TopRight
        lblMyLibrary.Location = New Point(46, 193)
        lblMyLibrary.Name = "lblMyLibrary"
        lblMyLibrary.Size = New Size(81, 17)
        lblMyLibrary.TabIndex = 8
        lblMyLibrary.Text = "My Notes"
        ' 
        ' lblFavorite
        ' 
        lblFavorite.AutoSize = True
        lblFavorite.Font = New Font("UD Digi Kyokasho NP-B", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        lblFavorite.ImageAlign = ContentAlignment.TopRight
        lblFavorite.Location = New Point(46, 229)
        lblFavorite.Name = "lblFavorite"
        lblFavorite.Size = New Size(73, 17)
        lblFavorite.TabIndex = 9
        lblFavorite.Text = "Favorite"
        ' 
        ' lblLogout
        ' 
        lblLogout.AutoSize = True
        lblLogout.Font = New Font("UD Digi Kyokasho NP-B", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        lblLogout.ImageAlign = ContentAlignment.TopRight
        lblLogout.Location = New Point(46, 446)
        lblLogout.Name = "lblLogout"
        lblLogout.Size = New Size(63, 17)
        lblLogout.TabIndex = 10
        lblLogout.Text = "Logout"
        ' 
        ' lblMenu
        ' 
        lblMenu.AutoSize = True
        lblMenu.Font = New Font("UD Digi Kyokasho NP-B", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        lblMenu.ImageAlign = ContentAlignment.TopRight
        lblMenu.Location = New Point(12, 83)
        lblMenu.Name = "lblMenu"
        lblMenu.Size = New Size(51, 17)
        lblMenu.TabIndex = 13
        lblMenu.Text = "Menu"
        ' 
        ' Button1
        ' 
        Button1.AutoSize = True
        Button1.Font = New Font("UD Digi Kyokasho NK-B", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Button1.Location = New Point(612, 55)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 27)
        Button1.TabIndex = 14
        Button1.Text = "Search"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("UD Digi Kyokasho NK-B", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        TextBox1.Location = New Point(208, 55)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "Find your book here"
        TextBox1.Size = New Size(398, 25)
        TextBox1.TabIndex = 15
        ' 
        ' pbProfile
        ' 
        pbProfile.BackgroundImage = CType(resources.GetObject("pbProfile.BackgroundImage"), Image)
        pbProfile.BackgroundImageLayout = ImageLayout.Stretch
        pbProfile.Location = New Point(816, 15)
        pbProfile.Name = "pbProfile"
        pbProfile.Size = New Size(28, 28)
        pbProfile.TabIndex = 17
        pbProfile.TabStop = False
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Font = New Font("UD Digi Kyokasho NK-B", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        lblUsername.Location = New Point(850, 25)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(61, 17)
        lblUsername.TabIndex = 18
        lblUsername.Text = "Profile"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("UD Digi Kyokasho NP-B", 16.2F, FontStyle.Bold)
        Label2.ForeColor = SystemColors.ControlText
        Label2.ImageAlign = ContentAlignment.TopRight
        Label2.Location = New Point(208, 25)
        Label2.Name = "Label2"
        Label2.Size = New Size(225, 25)
        Label2.TabIndex = 19
        Label2.Text = "Discover your book"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(12, 114)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(28, 28)
        PictureBox1.TabIndex = 20
        PictureBox1.TabStop = False
        ' 
        ' lblDiscover
        ' 
        lblDiscover.AutoSize = True
        lblDiscover.Font = New Font("UD Digi Kyokasho NP-B", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        lblDiscover.ImageAlign = ContentAlignment.TopRight
        lblDiscover.Location = New Point(46, 125)
        lblDiscover.Name = "lblDiscover"
        lblDiscover.Size = New Size(74, 17)
        lblDiscover.TabIndex = 21
        lblDiscover.Text = "Discover"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = SystemColors.Info
        PictureBox2.BorderStyle = BorderStyle.FixedSingle
        PictureBox2.Location = New Point(0, -9)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(180, 498)
        PictureBox2.TabIndex = 22
        PictureBox2.TabStop = False
        ' 
        ' PictureBox8
        ' 
        PictureBox8.BackgroundImage = CType(resources.GetObject("PictureBox8.BackgroundImage"), Image)
        PictureBox8.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox8.Location = New Point(12, 286)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(28, 28)
        PictureBox8.TabIndex = 23
        PictureBox8.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("UD Digi Kyokasho NP-B", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label3.ImageAlign = ContentAlignment.TopRight
        Label3.Location = New Point(46, 297)
        Label3.Name = "Label3"
        Label3.Size = New Size(103, 17)
        Label3.TabIndex = 24
        Label3.Text = "My Statistic"
        ' 
        ' ListView1
        ' 
        ListView1.Location = New Point(208, 124)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(703, 156)
        ListView1.TabIndex = 25
        ListView1.UseCompatibleStateImageBehavior = False
        ' 
        ' Button2
        ' 
        Button2.AutoSize = True
        Button2.Font = New Font("UD Digi Kyokasho NK-B", 11F, FontStyle.Bold)
        Button2.Location = New Point(734, 91)
        Button2.Name = "Button2"
        Button2.Size = New Size(145, 27)
        Button2.TabIndex = 26
        Button2.Text = "Add New Book"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' PictureBox9
        ' 
        PictureBox9.BackgroundImage = CType(resources.GetObject("PictureBox9.BackgroundImage"), Image)
        PictureBox9.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox9.Location = New Point(878, 92)
        PictureBox9.Name = "PictureBox9"
        PictureBox9.Size = New Size(26, 26)
        PictureBox9.TabIndex = 27
        PictureBox9.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("UD Digi Kyokasho NP-B", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label4.ImageAlign = ContentAlignment.TopRight
        Label4.Location = New Point(46, 263)
        Label4.Name = "Label4"
        Label4.Size = New Size(125, 17)
        Label4.TabIndex = 28
        Label4.Text = "Borrowed Book"
        ' 
        ' PictureBox10
        ' 
        PictureBox10.BackgroundImage = CType(resources.GetObject("PictureBox10.BackgroundImage"), Image)
        PictureBox10.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox10.Location = New Point(12, 252)
        PictureBox10.Name = "PictureBox10"
        PictureBox10.Size = New Size(28, 28)
        PictureBox10.TabIndex = 29
        PictureBox10.TabStop = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("UD Digi Kyokasho NP-B", 13.2F, FontStyle.Bold)
        Label5.ForeColor = SystemColors.ControlText
        Label5.ImageAlign = ContentAlignment.TopRight
        Label5.Location = New Point(208, 100)
        Label5.Name = "Label5"
        Label5.Size = New Size(157, 21)
        Label5.TabIndex = 30
        Label5.Text = "Your Books List"
        ' 
        ' ListView2
        ' 
        ListView2.Location = New Point(208, 307)
        ListView2.Name = "ListView2"
        ListView2.Size = New Size(703, 156)
        ListView2.TabIndex = 31
        ListView2.UseCompatibleStateImageBehavior = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("UD Digi Kyokasho NP-B", 13.2F, FontStyle.Bold)
        Label6.ForeColor = SystemColors.ControlText
        Label6.ImageAlign = ContentAlignment.TopRight
        Label6.Location = New Point(208, 283)
        Label6.Name = "Label6"
        Label6.Size = New Size(186, 21)
        Label6.TabIndex = 32
        Label6.Text = "Gtw mau di isi apa"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(934, 486)
        Controls.Add(Label6)
        Controls.Add(ListView2)
        Controls.Add(Label5)
        Controls.Add(PictureBox10)
        Controls.Add(Label4)
        Controls.Add(PictureBox9)
        Controls.Add(Button2)
        Controls.Add(ListView1)
        Controls.Add(Label3)
        Controls.Add(PictureBox8)
        Controls.Add(lblDiscover)
        Controls.Add(PictureBox1)
        Controls.Add(Label2)
        Controls.Add(lblUsername)
        Controls.Add(pbProfile)
        Controls.Add(Button1)
        Controls.Add(lblMenu)
        Controls.Add(lblLogout)
        Controls.Add(lblFavorite)
        Controls.Add(lblMyLibrary)
        Controls.Add(lblCategory)
        Controls.Add(Label1)
        Controls.Add(PictureBox6)
        Controls.Add(PictureBox5)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox3)
        Controls.Add(TextBox1)
        Controls.Add(PictureBox2)
        Name = "Form1"
        Text = "ReadNest, Your Personal Library "
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(pbProfile, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox9, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox10, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblCategory As Label
    Friend WithEvents lblMyLibrary As Label
    Friend WithEvents lblFavorite As Label
    Friend WithEvents lblLogout As Label
    Friend WithEvents lblMenu As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents pbProfile As PictureBox
    Friend WithEvents lblUsername As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblDiscover As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ListView2 As ListView
    Friend WithEvents Label6 As Label

End Class
