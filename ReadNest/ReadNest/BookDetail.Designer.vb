<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BookDetail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BookDetail))
        LeftPanel = New Panel()
        backButton = New Button()
        bookCoverPictureBox = New PictureBox()
        RightPanel = New Panel()
        titleLabel = New Label()
        authorLabel = New Label()
        startReadingButton = New Button()
        bookmarkButton = New Button()
        borrowButton = New Button()
        downloadButton = New Button()
        separatorLine = New Panel()
        descriptionTitleLabel = New Label()
        descriptionContentLabel = New Label()
        categorylabel = New Label()
        languageContentLabel = New Label()
        pagenumberLabel = New Label()
        paperbackContentLabel = New Label()
        LeftPanel.SuspendLayout()
        CType(bookCoverPictureBox, ComponentModel.ISupportInitialize).BeginInit()
        RightPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' LeftPanel
        ' 
        LeftPanel.BackColor = Color.FromArgb(CByte(248), CByte(246), CByte(240))
        LeftPanel.Controls.Add(backButton)
        LeftPanel.Controls.Add(bookCoverPictureBox)
        LeftPanel.Dock = DockStyle.Left
        LeftPanel.Location = New Point(0, 0)
        LeftPanel.Margin = New Padding(3, 4, 3, 4)
        LeftPanel.Name = "LeftPanel"
        LeftPanel.Size = New Size(350, 648)
        LeftPanel.TabIndex = 0
        ' 
        ' backButton
        ' 
        backButton.BackColor = Color.FromArgb(CByte(245), CByte(245), CByte(245))
        backButton.FlatAppearance.BorderSize = 0
        backButton.FlatStyle = FlatStyle.Flat
        backButton.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        backButton.ForeColor = Color.Gray
        backButton.Location = New Point(50, 41)
        backButton.Margin = New Padding(3, 4, 3, 4)
        backButton.Name = "backButton"
        backButton.Size = New Size(40, 51)
        backButton.TabIndex = 0
        backButton.Text = "<"
        backButton.UseVisualStyleBackColor = False
        ' 
        ' bookCoverPictureBox
        ' 
        bookCoverPictureBox.BackColor = Color.FromArgb(CByte(0), CByte(70), CByte(30))
        bookCoverPictureBox.BorderStyle = BorderStyle.FixedSingle
        bookCoverPictureBox.Location = New Point(50, 100)
        bookCoverPictureBox.Margin = New Padding(3, 4, 3, 4)
        bookCoverPictureBox.Name = "bookCoverPictureBox"
        bookCoverPictureBox.Size = New Size(250, 400)
        bookCoverPictureBox.SizeMode = PictureBoxSizeMode.Zoom
        bookCoverPictureBox.TabIndex = 2
        bookCoverPictureBox.TabStop = False
        ' 
        ' RightPanel
        ' 
        RightPanel.BackColor = Color.FromArgb(CByte(248), CByte(246), CByte(240))
        RightPanel.Controls.Add(titleLabel)
        RightPanel.Controls.Add(authorLabel)
        RightPanel.Controls.Add(startReadingButton)
        RightPanel.Controls.Add(bookmarkButton)
        RightPanel.Controls.Add(borrowButton)
        RightPanel.Controls.Add(downloadButton)
        RightPanel.Controls.Add(separatorLine)
        RightPanel.Controls.Add(descriptionTitleLabel)
        RightPanel.Controls.Add(descriptionContentLabel)
        RightPanel.Controls.Add(categorylabel)
        RightPanel.Controls.Add(languageContentLabel)
        RightPanel.Controls.Add(pagenumberLabel)
        RightPanel.Controls.Add(paperbackContentLabel)
        RightPanel.Dock = DockStyle.Fill
        RightPanel.Location = New Point(350, 0)
        RightPanel.Margin = New Padding(3, 4, 3, 4)
        RightPanel.Name = "RightPanel"
        RightPanel.Padding = New Padding(20, 50, 20, 20)
        RightPanel.Size = New Size(717, 648)
        RightPanel.TabIndex = 1
        ' 
        ' titleLabel
        ' 
        titleLabel.Font = New Font("Segoe UI", 24F, FontStyle.Bold)
        titleLabel.ForeColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        titleLabel.Location = New Point(20, 50)
        titleLabel.Name = "titleLabel"
        titleLabel.Size = New Size(500, 80)
        titleLabel.TabIndex = 0
        titleLabel.Text = "Harry Potter: Half Blood Prince"
        ' 
        ' authorLabel
        ' 
        authorLabel.Font = New Font("Segoe UI", 14F)
        authorLabel.ForeColor = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        authorLabel.Location = New Point(20, 130)
        authorLabel.Name = "authorLabel"
        authorLabel.Size = New Size(500, 30)
        authorLabel.TabIndex = 1
        authorLabel.Text = "JK Rowling"
        ' 
        ' startReadingButton
        ' 
        startReadingButton.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(50))
        startReadingButton.Cursor = Cursors.Hand
        startReadingButton.FlatAppearance.BorderSize = 0
        startReadingButton.FlatStyle = FlatStyle.Flat
        startReadingButton.Font = New Font("Segoe UI", 10F)
        startReadingButton.ForeColor = Color.White
        startReadingButton.Location = New Point(20, 180)
        startReadingButton.Margin = New Padding(3, 4, 3, 4)
        startReadingButton.Name = "startReadingButton"
        startReadingButton.Size = New Size(150, 37)
        startReadingButton.TabIndex = 3
        startReadingButton.Text = "Start reading →"
        startReadingButton.UseVisualStyleBackColor = False
        ' 
        ' bookmarkButton
        ' 
        bookmarkButton.BackColor = Color.Transparent
        bookmarkButton.FlatAppearance.BorderSize = 0
        bookmarkButton.FlatStyle = FlatStyle.Flat
        bookmarkButton.Font = New Font("Segoe UI", 12F)
        bookmarkButton.Location = New Point(190, 180)
        bookmarkButton.Margin = New Padding(3, 4, 3, 4)
        bookmarkButton.Name = "bookmarkButton"
        bookmarkButton.Size = New Size(40, 37)
        bookmarkButton.TabIndex = 4
        bookmarkButton.Text = "🔖"
        bookmarkButton.UseVisualStyleBackColor = False
        ' 
        ' borrowButton
        ' 
        borrowButton.BackColor = Color.Transparent
        borrowButton.FlatAppearance.BorderSize = 0
        borrowButton.FlatStyle = FlatStyle.Flat
        borrowButton.Font = New Font("Segoe UI", 12F)
        borrowButton.Location = New Point(240, 180)
        borrowButton.Margin = New Padding(3, 4, 3, 4)
        borrowButton.Name = "borrowButton"
        borrowButton.Size = New Size(40, 37)
        borrowButton.TabIndex = 5
        borrowButton.Text = "📤"
        borrowButton.UseVisualStyleBackColor = False
        ' 
        ' downloadButton
        ' 
        downloadButton.BackColor = Color.Transparent
        downloadButton.FlatAppearance.BorderSize = 0
        downloadButton.FlatStyle = FlatStyle.Flat
        downloadButton.Font = New Font("Segoe UI", 12F)
        downloadButton.Location = New Point(290, 180)
        downloadButton.Margin = New Padding(3, 4, 3, 4)
        downloadButton.Name = "downloadButton"
        downloadButton.Size = New Size(40, 37)
        downloadButton.TabIndex = 6
        downloadButton.Text = "💾"
        downloadButton.UseVisualStyleBackColor = False
        ' 
        ' separatorLine
        ' 
        separatorLine.BackColor = Color.FromArgb(CByte(220), CByte(220), CByte(220))
        separatorLine.Location = New Point(20, 236)
        separatorLine.Margin = New Padding(3, 4, 3, 4)
        separatorLine.Name = "separatorLine"
        separatorLine.Size = New Size(500, 3)
        separatorLine.TabIndex = 7
        ' 
        ' descriptionTitleLabel
        ' 
        descriptionTitleLabel.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        descriptionTitleLabel.Location = New Point(20, 247)
        descriptionTitleLabel.Name = "descriptionTitleLabel"
        descriptionTitleLabel.Size = New Size(150, 25)
        descriptionTitleLabel.TabIndex = 8
        descriptionTitleLabel.Text = "Description"
        ' 
        ' descriptionContentLabel
        ' 
        descriptionContentLabel.Font = New Font("Segoe UI", 10F)
        descriptionContentLabel.ForeColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        descriptionContentLabel.Location = New Point(20, 277)
        descriptionContentLabel.Name = "descriptionContentLabel"
        descriptionContentLabel.Size = New Size(650, 183)
        descriptionContentLabel.TabIndex = 9
        descriptionContentLabel.Text = resources.GetString("descriptionContentLabel.Text")
        ' 
        ' categorylabel
        ' 
        categorylabel.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        categorylabel.Location = New Point(20, 460)
        categorylabel.Name = "categorylabel"
        categorylabel.Size = New Size(150, 25)
        categorylabel.TabIndex = 12
        categorylabel.Text = "Category"
        ' 
        ' languageContentLabel
        ' 
        languageContentLabel.Font = New Font("Segoe UI", 10F)
        languageContentLabel.ForeColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        languageContentLabel.Location = New Point(20, 490)
        languageContentLabel.Name = "languageContentLabel"
        languageContentLabel.Size = New Size(200, 25)
        languageContentLabel.TabIndex = 13
        languageContentLabel.Text = "Standard English (USA & UK)"
        ' 
        ' pagenumberLabel
        ' 
        pagenumberLabel.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        pagenumberLabel.Location = New Point(20, 520)
        pagenumberLabel.Name = "pagenumberLabel"
        pagenumberLabel.Size = New Size(150, 25)
        pagenumberLabel.TabIndex = 14
        pagenumberLabel.Text = "Page Number"
        ' 
        ' paperbackContentLabel
        ' 
        paperbackContentLabel.Font = New Font("Segoe UI", 10F)
        paperbackContentLabel.ForeColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        paperbackContentLabel.Location = New Point(20, 550)
        paperbackContentLabel.Name = "paperbackContentLabel"
        paperbackContentLabel.Size = New Size(250, 50)
        paperbackContentLabel.TabIndex = 15
        paperbackContentLabel.Text = "paper textured, full colour, 345 pages" & vbCrLf & "ISBN: 987 3 32564 455 B"
        ' 
        ' BookDetail
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackColor = Color.White
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1067, 648)
        Controls.Add(RightPanel)
        Controls.Add(LeftPanel)
        Margin = New Padding(3, 4, 3, 4)
        MinimumSize = New Size(912, 648)
        Name = "BookDetail"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ReadNest, Your Personal Library"
        LeftPanel.ResumeLayout(False)
        CType(bookCoverPictureBox, ComponentModel.ISupportInitialize).EndInit()
        RightPanel.ResumeLayout(False)
        ResumeLayout(False)

    End Sub

    Friend WithEvents LeftPanel As Panel
    Friend WithEvents backButton As Button
    Friend WithEvents bookCoverPictureBox As PictureBox
    Friend WithEvents RightPanel As Panel
    Friend WithEvents titleLabel As Label
    Friend WithEvents authorLabel As Label
    Friend WithEvents startReadingButton As Button
    Friend WithEvents bookmarkButton As Button
    Friend WithEvents borrowButton As Button
    Friend WithEvents downloadButton As Button
    Friend WithEvents separatorLine As Panel
    Friend WithEvents descriptionTitleLabel As Label
    Friend WithEvents descriptionContentLabel As Label
    Friend WithEvents categorylabel As Label
    Friend WithEvents languageContentLabel As Label
    Friend WithEvents pagenumberLabel As Label
    Friend WithEvents paperbackContentLabel As Label
End Class