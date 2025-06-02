<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        mainTableLayoutPanel = New TableLayoutPanel()
        leftPanel = New Panel()
        PictureBox1 = New PictureBox()
        Panel1 = New Panel()
        linkCreateAccount = New LinkLabel()
        btnLoginaAccount = New Button()
        Label6 = New Label()
        Label7 = New Label()
        txtloginusername = New TextBox()
        txtloginpassword = New TextBox()
        chkPassword = New CheckBox()
        Label4 = New Label()
        Label5 = New Label()
        MySqlCommand1 = New MySql.Data.MySqlClient.MySqlCommand()
        mainTableLayoutPanel.SuspendLayout()
        leftPanel.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' mainTableLayoutPanel
        ' 
        mainTableLayoutPanel.ColumnCount = 2
        mainTableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        mainTableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        mainTableLayoutPanel.Controls.Add(leftPanel, 0, 0)
        mainTableLayoutPanel.Controls.Add(Panel1, 1, 0)
        mainTableLayoutPanel.Dock = DockStyle.Fill
        mainTableLayoutPanel.Location = New Point(0, 0)
        mainTableLayoutPanel.Name = "mainTableLayoutPanel"
        mainTableLayoutPanel.RowCount = 1
        mainTableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        mainTableLayoutPanel.Size = New Size(934, 486)
        mainTableLayoutPanel.TabIndex = 0
        ' 
        ' leftPanel
        ' 
        leftPanel.BackColor = SystemColors.Info
        leftPanel.Controls.Add(PictureBox1)
        leftPanel.Dock = DockStyle.Fill
        leftPanel.Location = New Point(3, 3)
        leftPanel.Name = "leftPanel"
        leftPanel.Size = New Size(461, 480)
        leftPanel.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(461, 480)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(linkCreateAccount)
        Panel1.Controls.Add(btnLoginaAccount)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(txtloginusername)
        Panel1.Controls.Add(txtloginpassword)
        Panel1.Controls.Add(chkPassword)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label5)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(470, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(461, 480)
        Panel1.TabIndex = 1
        ' 
        ' linkCreateAccount
        ' 
        linkCreateAccount.AutoSize = True
        linkCreateAccount.Location = New Point(195, 356)
        linkCreateAccount.Name = "linkCreateAccount"
        linkCreateAccount.Size = New Size(59, 15)
        linkCreateAccount.TabIndex = 1
        linkCreateAccount.TabStop = True
        linkCreateAccount.Text = "Click here"
        ' 
        ' btnLoginaAccount
        ' 
        btnLoginaAccount.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnLoginaAccount.AutoSize = True
        btnLoginaAccount.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        btnLoginaAccount.Location = New Point(287, 272)
        btnLoginaAccount.Name = "btnLoginaAccount"
        btnLoginaAccount.Size = New Size(75, 34)
        btnLoginaAccount.TabIndex = 0
        btnLoginaAccount.Text = "Login"
        btnLoginaAccount.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(77, 356)
        Label6.Name = "Label6"
        Label6.Size = New Size(112, 15)
        Label6.TabIndex = 0
        Label6.Text = "Dont have account?"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft Sans Serif", 13.25F, FontStyle.Bold)
        Label7.Location = New Point(75, 125)
        Label7.Name = "Label7"
        Label7.Size = New Size(195, 22)
        Label7.TabIndex = 0
        Label7.Text = "Login Your Acccount"
        ' 
        ' txtloginusername
        ' 
        txtloginusername.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtloginusername.Font = New Font("Segoe UI", 11F)
        txtloginusername.Location = New Point(166, 171)
        txtloginusername.Name = "txtloginusername"
        txtloginusername.PlaceholderText = "Enter your username here"
        txtloginusername.Size = New Size(195, 27)
        txtloginusername.TabIndex = 1
        ' 
        ' txtloginpassword
        ' 
        txtloginpassword.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtloginpassword.Font = New Font("Segoe UI", 11F)
        txtloginpassword.Location = New Point(166, 204)
        txtloginpassword.Name = "txtloginpassword"
        txtloginpassword.PlaceholderText = "Enter your password here"
        txtloginpassword.Size = New Size(195, 27)
        txtloginpassword.TabIndex = 1
        txtloginpassword.UseSystemPasswordChar = True
        ' 
        ' chkPassword
        ' 
        chkPassword.AutoSize = True
        chkPassword.Location = New Point(166, 237)
        chkPassword.Name = "chkPassword"
        chkPassword.Size = New Size(108, 19)
        chkPassword.TabIndex = 0
        chkPassword.Text = "Show Password"
        chkPassword.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label4.Location = New Point(75, 175)
        Label4.Name = "Label4"
        Label4.Size = New Size(85, 18)
        Label4.TabIndex = 0
        Label4.Text = "Username"
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label5.Location = New Point(77, 208)
        Label5.Name = "Label5"
        Label5.Size = New Size(83, 18)
        Label5.TabIndex = 0
        Label5.Text = "Password"
        ' 
        ' MySqlCommand1
        ' 
        MySqlCommand1.CacheAge = 0
        MySqlCommand1.Connection = Nothing
        MySqlCommand1.EnableCaching = False
        MySqlCommand1.Transaction = Nothing
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(934, 486)
        Controls.Add(mainTableLayoutPanel)
        MinimumSize = New Size(800, 496)
        Name = "LoginForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ReadNest, Your Personal Library "
        mainTableLayoutPanel.ResumeLayout(False)
        leftPanel.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents mainTableLayoutPanel As TableLayoutPanel
    Friend WithEvents leftPanel As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtloginusername As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnLoginaAccount As Button
    Friend WithEvents chkPassword As CheckBox
    Friend WithEvents MySqlCommand1 As MySql.Data.MySqlClient.MySqlCommand
    Friend WithEvents Label5 As Label
    Friend WithEvents txtloginpassword As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents linkCreateAccount As LinkLabel
    Friend WithEvents Panel1 As Panel
End Class