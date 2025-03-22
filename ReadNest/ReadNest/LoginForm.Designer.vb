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

        ' Create main layout panels
        mainTableLayoutPanel = New TableLayoutPanel()
        leftPanel = New Panel()
        rightPanel = New TableLayoutPanel()

        ' Left panel controls
        PictureBox1 = New PictureBox()
        brandingPanel = New Panel()
        Label2 = New Label()
        Label1 = New Label()

        ' Right panel controls
        headerPanel = New Panel()
        Label7 = New Label()

        usernamePanel = New Panel()
        Label4 = New Label()
        txtloginusername = New TextBox()

        passwordPanel = New Panel()
        Label5 = New Label()
        txtloginpassword = New TextBox()

        showPasswordPanel = New Panel()
        chkPassword = New CheckBox()

        loginButtonPanel = New Panel()
        btnLoginaAccount = New Button()

        createAccountPanel = New Panel()
        Label6 = New Label()
        linkCreateAccount = New LinkLabel()

        ' MySql Command
        MySqlCommand1 = New MySql.Data.MySqlClient.MySqlCommand()

        ' Initialize layout
        mainTableLayoutPanel.SuspendLayout()
        leftPanel.SuspendLayout()
        rightPanel.SuspendLayout()
        brandingPanel.SuspendLayout()
        headerPanel.SuspendLayout()
        usernamePanel.SuspendLayout()
        passwordPanel.SuspendLayout()
        showPasswordPanel.SuspendLayout()
        loginButtonPanel.SuspendLayout()
        createAccountPanel.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()

        ' mainTableLayoutPanel
        mainTableLayoutPanel.ColumnCount = 2
        mainTableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        mainTableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        mainTableLayoutPanel.Dock = DockStyle.Fill
        mainTableLayoutPanel.Location = New Point(0, 0)
        mainTableLayoutPanel.Name = "mainTableLayoutPanel"
        mainTableLayoutPanel.RowCount = 1
        mainTableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 100.0F))
        mainTableLayoutPanel.Size = New Size(934, 486)
        mainTableLayoutPanel.TabIndex = 0

        ' leftPanel
        leftPanel.BackColor = SystemColors.Info
        leftPanel.Dock = DockStyle.Fill
        leftPanel.Location = New Point(3, 3)
        leftPanel.Name = "leftPanel"
        leftPanel.Size = New Size(461, 480)
        leftPanel.TabIndex = 0

        ' PictureBox1
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(461, 480)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False

        ' brandingPanel
        brandingPanel.Anchor = AnchorStyles.None
        brandingPanel.BackColor = SystemColors.Info
        brandingPanel.Location = New Point(131, 30)
        brandingPanel.Name = "brandingPanel"
        brandingPanel.Size = New Size(450, 80)
        brandingPanel.TabIndex = 1

        ' Label2
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.Info
        Label2.Font = New Font("UD Digi Kyokasho NK-B", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 128)
        Label2.ForeColor = SystemColors.ControlText
        Label2.Location = New Point(12, 15)
        Label2.Name = "Label2"
        Label2.Size = New Size(223, 41)
        Label2.TabIndex = 0
        Label2.Text = "Welcome to"

        ' Label1
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.Info
        Label1.Font = New Font("UD Digi Kyokasho NK-B", 30.0F, FontStyle.Bold, GraphicsUnit.Point, 128)
        Label1.ForeColor = SystemColors.ControlText
        Label1.ImageAlign = ContentAlignment.TopRight
        Label1.Location = New Point(224, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(221, 46)
        Label1.TabIndex = 1
        Label1.Text = "ReadNest"

        ' rightPanel
        rightPanel.ColumnCount = 1
        rightPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100.0F))
        rightPanel.Dock = DockStyle.Fill
        rightPanel.Location = New Point(470, 3)
        rightPanel.Name = "rightPanel"
        rightPanel.RowCount = 6
        rightPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 20.0F))
        rightPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 15.0F))
        rightPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 15.0F))
        rightPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 10.0F))
        rightPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 20.0F))
        rightPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 20.0F))
        rightPanel.Size = New Size(461, 480)
        rightPanel.TabIndex = 1

        ' headerPanel
        headerPanel.Dock = DockStyle.Fill
        headerPanel.Location = New Point(3, 3)
        headerPanel.Name = "headerPanel"
        headerPanel.Size = New Size(455, 90)
        headerPanel.TabIndex = 0

        ' Label7
        Label7.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft Sans Serif", 13.25F, FontStyle.Bold)
        Label7.Location = New Point(20, 65)
        Label7.Name = "Label7"
        Label7.Size = New Size(195, 22)
        Label7.TabIndex = 0
        Label7.Text = "Login Your Acccount"

        ' usernamePanel
        usernamePanel.Dock = DockStyle.Fill
        usernamePanel.Location = New Point(3, 99)
        usernamePanel.Name = "usernamePanel"
        usernamePanel.Size = New Size(455, 66)
        usernamePanel.TabIndex = 1

        ' Label4
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 128)
        Label4.Location = New Point(20, 8)
        Label4.Name = "Label4"
        Label4.Size = New Size(85, 18)
        Label4.TabIndex = 0
        Label4.Text = "Username"

        ' txtloginusername
        txtloginusername.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        txtloginusername.Font = New Font("Segoe UI", 11.0F)
        txtloginusername.Location = New Point(120, 5)
        txtloginusername.Name = "txtloginusername"
        txtloginusername.PlaceholderText = "Enter your username here"
        txtloginusername.Size = New Size(315, 27)
        txtloginusername.TabIndex = 1

        ' passwordPanel
        passwordPanel.Dock = DockStyle.Fill
        passwordPanel.Location = New Point(3, 171)
        passwordPanel.Name = "passwordPanel"
        passwordPanel.Size = New Size(455, 66)
        passwordPanel.TabIndex = 2

        ' Label5
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 128)
        Label5.Location = New Point(20, 8)
        Label5.Name = "Label5"
        Label5.Size = New Size(83, 18)
        Label5.TabIndex = 0
        Label5.Text = "Password"

        ' txtloginpassword
        txtloginpassword.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        txtloginpassword.Font = New Font("Segoe UI", 11.0F)
        txtloginpassword.Location = New Point(120, 5)
        txtloginpassword.Name = "txtloginpassword"
        txtloginpassword.PlaceholderText = "Enter your password here"
        txtloginpassword.Size = New Size(315, 27)
        txtloginpassword.TabIndex = 1
        txtloginpassword.UseSystemPasswordChar = True

        ' showPasswordPanel
        showPasswordPanel.Dock = DockStyle.Fill
        showPasswordPanel.Location = New Point(3, 243)
        showPasswordPanel.Name = "showPasswordPanel"
        showPasswordPanel.Size = New Size(455, 42)
        showPasswordPanel.TabIndex = 3

        ' chkPassword
        chkPassword.AutoSize = True
        chkPassword.Location = New Point(120, 10)
        chkPassword.Name = "chkPassword"
        chkPassword.Size = New Size(108, 19)
        chkPassword.TabIndex = 0
        chkPassword.Text = "Show Password"
        chkPassword.UseVisualStyleBackColor = True

        ' loginButtonPanel
        loginButtonPanel.Dock = DockStyle.Fill
        loginButtonPanel.Location = New Point(3, 291)
        loginButtonPanel.Name = "loginButtonPanel"
        loginButtonPanel.Size = New Size(455, 90)
        loginButtonPanel.TabIndex = 4

        ' btnLoginaAccount
        btnLoginaAccount.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnLoginaAccount.AutoSize = True
        btnLoginaAccount.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 128)
        btnLoginaAccount.Location = New Point(360, 20)
        btnLoginaAccount.Name = "btnLoginaAccount"
        btnLoginaAccount.Size = New Size(75, 30)
        btnLoginaAccount.TabIndex = 0
        btnLoginaAccount.Text = "Login"
        btnLoginaAccount.UseVisualStyleBackColor = True

        ' createAccountPanel
        createAccountPanel.Dock = DockStyle.Fill
        createAccountPanel.Location = New Point(3, 387)
        createAccountPanel.Name = "createAccountPanel"
        createAccountPanel.Size = New Size(455, 90)
        createAccountPanel.TabIndex = 5

        ' Label6
        Label6.AutoSize = True
        Label6.Location = New Point(20, 30)
        Label6.Name = "Label6"
        Label6.Size = New Size(112, 15)
        Label6.TabIndex = 0
        Label6.Text = "Dont have account?"

        ' linkCreateAccount
        linkCreateAccount.AutoSize = True
        linkCreateAccount.Location = New Point(138, 30)
        linkCreateAccount.Name = "linkCreateAccount"
        linkCreateAccount.Size = New Size(59, 15)
        linkCreateAccount.TabIndex = 1
        linkCreateAccount.TabStop = True
        linkCreateAccount.Text = "Click here"

        ' MySqlCommand1
        MySqlCommand1.CacheAge = 0
        MySqlCommand1.Connection = Nothing
        MySqlCommand1.EnableCaching = False
        MySqlCommand1.Transaction = Nothing

        ' Add controls to containers
        leftPanel.Controls.Add(PictureBox1)
        leftPanel.Controls.Add(brandingPanel)
        brandingPanel.Controls.Add(Label2)
        brandingPanel.Controls.Add(Label1)

        headerPanel.Controls.Add(Label7)
        usernamePanel.Controls.Add(Label4)
        usernamePanel.Controls.Add(txtloginusername)
        passwordPanel.Controls.Add(Label5)
        passwordPanel.Controls.Add(txtloginpassword)
        showPasswordPanel.Controls.Add(chkPassword)
        loginButtonPanel.Controls.Add(btnLoginaAccount)
        createAccountPanel.Controls.Add(Label6)
        createAccountPanel.Controls.Add(linkCreateAccount)

        rightPanel.Controls.Add(headerPanel, 0, 0)
        rightPanel.Controls.Add(usernamePanel, 0, 1)
        rightPanel.Controls.Add(passwordPanel, 0, 2)
        rightPanel.Controls.Add(showPasswordPanel, 0, 3)
        rightPanel.Controls.Add(loginButtonPanel, 0, 4)
        rightPanel.Controls.Add(createAccountPanel, 0, 5)

        mainTableLayoutPanel.Controls.Add(leftPanel, 0, 0)
        mainTableLayoutPanel.Controls.Add(rightPanel, 1, 0)

        Controls.Add(mainTableLayoutPanel)

        ' LoginForm
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(934, 486)
        Name = "LoginForm"
        MinimumSize = New Size(800, 500)
        StartPosition = FormStartPosition.CenterScreen
        Text = "ReadNest, Your Personal Library "

        mainTableLayoutPanel.ResumeLayout(False)
        leftPanel.ResumeLayout(False)
        rightPanel.ResumeLayout(False)
        brandingPanel.ResumeLayout(False)
        brandingPanel.PerformLayout()
        headerPanel.ResumeLayout(False)
        headerPanel.PerformLayout()
        usernamePanel.ResumeLayout(False)
        usernamePanel.PerformLayout()
        passwordPanel.ResumeLayout(False)
        passwordPanel.PerformLayout()
        showPasswordPanel.ResumeLayout(False)
        showPasswordPanel.PerformLayout()
        loginButtonPanel.ResumeLayout(False)
        loginButtonPanel.PerformLayout()
        createAccountPanel.ResumeLayout(False)
        createAccountPanel.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents mainTableLayoutPanel As TableLayoutPanel
    Friend WithEvents leftPanel As Panel
    Friend WithEvents rightPanel As TableLayoutPanel
    Friend WithEvents headerPanel As Panel
    Friend WithEvents usernamePanel As Panel
    Friend WithEvents passwordPanel As Panel
    Friend WithEvents showPasswordPanel As Panel
    Friend WithEvents loginButtonPanel As Panel
    Friend WithEvents createAccountPanel As Panel
    Friend WithEvents brandingPanel As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtloginusername As TextBox
    Friend WithEvents txtloginpassword As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents linkCreateAccount As LinkLabel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnLoginaAccount As Button
    Friend WithEvents chkPassword As CheckBox
    Friend WithEvents MySqlCommand1 As MySql.Data.MySqlClient.MySqlCommand
End Class