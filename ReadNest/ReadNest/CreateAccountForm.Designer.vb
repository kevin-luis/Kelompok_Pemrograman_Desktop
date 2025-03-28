<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CreateAccountForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CreateAccountForm))
        mainTableLayoutPanel = New TableLayoutPanel()
        leftPanel = New Panel()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        rightPanel = New TableLayoutPanel()
        headerPanel = New Panel()
        Label7 = New Label()
        emailPanel = New Panel()
        Label1 = New Label()
        txtCreateEmail = New TextBox()
        usernamePanel = New Panel()
        Label4 = New Label()
        txtCreateUsername = New TextBox()
        passwordPanel = New Panel()
        Label5 = New Label()
        txtCreatePassword = New TextBox()
        confirmPasswordPanel = New Panel()
        Label3 = New Label()
        txtConfirmPassword = New TextBox()
        showPasswordPanel = New Panel()
        chkPassword = New CheckBox()
        createButtonPanel = New Panel()
        btnCreateAccount = New Button()
        mainTableLayoutPanel.SuspendLayout()
        leftPanel.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        rightPanel.SuspendLayout()
        headerPanel.SuspendLayout()
        emailPanel.SuspendLayout()
        usernamePanel.SuspendLayout()
        passwordPanel.SuspendLayout()
        confirmPasswordPanel.SuspendLayout()
        showPasswordPanel.SuspendLayout()
        createButtonPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' mainTableLayoutPanel
        ' 
        mainTableLayoutPanel.ColumnCount = 2
        mainTableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        mainTableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        mainTableLayoutPanel.Controls.Add(leftPanel, 0, 0)
        mainTableLayoutPanel.Controls.Add(rightPanel, 1, 0)
        mainTableLayoutPanel.Dock = DockStyle.Fill
        mainTableLayoutPanel.Location = New Point(0, 0)
        mainTableLayoutPanel.Margin = New Padding(3, 2, 3, 2)
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
        leftPanel.Controls.Add(Label2)
        leftPanel.Dock = DockStyle.Fill
        leftPanel.Location = New Point(3, 2)
        leftPanel.Margin = New Padding(3, 2, 3, 2)
        leftPanel.Name = "leftPanel"
        leftPanel.Size = New Size(461, 482)
        leftPanel.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(461, 482)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.Info
        Label2.Font = New Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold)
        Label2.ForeColor = SystemColors.ControlText
        Label2.Location = New Point(12, 34)
        Label2.Name = "Label2"
        Label2.Size = New Size(423, 31)
        Label2.TabIndex = 1
        Label2.Text = "Create Your ReadNest Account"
        ' 
        ' rightPanel
        ' 
        rightPanel.ColumnCount = 1
        rightPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        rightPanel.Controls.Add(headerPanel, 0, 0)
        rightPanel.Controls.Add(emailPanel, 0, 1)
        rightPanel.Controls.Add(usernamePanel, 0, 2)
        rightPanel.Controls.Add(passwordPanel, 0, 3)
        rightPanel.Controls.Add(confirmPasswordPanel, 0, 4)
        rightPanel.Controls.Add(showPasswordPanel, 0, 5)
        rightPanel.Controls.Add(createButtonPanel, 0, 6)
        rightPanel.Dock = DockStyle.Fill
        rightPanel.Location = New Point(470, 2)
        rightPanel.Margin = New Padding(3, 2, 3, 2)
        rightPanel.Name = "rightPanel"
        rightPanel.RowCount = 7
        rightPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 15F))
        rightPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 14F))
        rightPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 14F))
        rightPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 14F))
        rightPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 14F))
        rightPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 14F))
        rightPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 15F))
        rightPanel.Size = New Size(461, 482)
        rightPanel.TabIndex = 1
        ' 
        ' headerPanel
        ' 
        headerPanel.Controls.Add(Label7)
        headerPanel.Dock = DockStyle.Fill
        headerPanel.Location = New Point(3, 2)
        headerPanel.Margin = New Padding(3, 2, 3, 2)
        headerPanel.Name = "headerPanel"
        headerPanel.Size = New Size(455, 68)
        headerPanel.TabIndex = 0
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft Sans Serif", 13.25F, FontStyle.Bold)
        Label7.Location = New Point(18, 30)
        Label7.Name = "Label7"
        Label7.Size = New Size(206, 22)
        Label7.TabIndex = 0
        Label7.Text = "Create Your Acccount"
        ' 
        ' emailPanel
        ' 
        emailPanel.Controls.Add(Label1)
        emailPanel.Controls.Add(txtCreateEmail)
        emailPanel.Dock = DockStyle.Fill
        emailPanel.Location = New Point(3, 74)
        emailPanel.Margin = New Padding(3, 2, 3, 2)
        emailPanel.Name = "emailPanel"
        emailPanel.Size = New Size(455, 63)
        emailPanel.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label1.Location = New Point(18, 11)
        Label1.Name = "Label1"
        Label1.Size = New Size(50, 18)
        Label1.TabIndex = 0
        Label1.Text = "Email"
        ' 
        ' txtCreateEmail
        ' 
        txtCreateEmail.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        txtCreateEmail.Font = New Font("Segoe UI", 11F)
        txtCreateEmail.Location = New Point(18, 33)
        txtCreateEmail.Name = "txtCreateEmail"
        txtCreateEmail.PlaceholderText = "Enter your email here"
        txtCreateEmail.Size = New Size(418, 27)
        txtCreateEmail.TabIndex = 1
        ' 
        ' usernamePanel
        ' 
        usernamePanel.Controls.Add(Label4)
        usernamePanel.Controls.Add(txtCreateUsername)
        usernamePanel.Dock = DockStyle.Fill
        usernamePanel.Location = New Point(3, 141)
        usernamePanel.Margin = New Padding(3, 2, 3, 2)
        usernamePanel.Name = "usernamePanel"
        usernamePanel.Size = New Size(455, 63)
        usernamePanel.TabIndex = 2
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label4.Location = New Point(18, 11)
        Label4.Name = "Label4"
        Label4.Size = New Size(85, 18)
        Label4.TabIndex = 0
        Label4.Text = "Username"
        ' 
        ' txtCreateUsername
        ' 
        txtCreateUsername.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        txtCreateUsername.Font = New Font("Segoe UI", 11F)
        txtCreateUsername.Location = New Point(18, 33)
        txtCreateUsername.Name = "txtCreateUsername"
        txtCreateUsername.PlaceholderText = "Enter your username here"
        txtCreateUsername.Size = New Size(418, 27)
        txtCreateUsername.TabIndex = 1
        ' 
        ' passwordPanel
        ' 
        passwordPanel.Controls.Add(Label5)
        passwordPanel.Controls.Add(txtCreatePassword)
        passwordPanel.Dock = DockStyle.Fill
        passwordPanel.Location = New Point(3, 208)
        passwordPanel.Margin = New Padding(3, 2, 3, 2)
        passwordPanel.Name = "passwordPanel"
        passwordPanel.Size = New Size(455, 63)
        passwordPanel.TabIndex = 3
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label5.Location = New Point(18, 11)
        Label5.Name = "Label5"
        Label5.Size = New Size(83, 18)
        Label5.TabIndex = 0
        Label5.Text = "Password"
        ' 
        ' txtCreatePassword
        ' 
        txtCreatePassword.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        txtCreatePassword.Font = New Font("Segoe UI", 11F)
        txtCreatePassword.Location = New Point(18, 33)
        txtCreatePassword.Name = "txtCreatePassword"
        txtCreatePassword.PlaceholderText = "Enter your password here"
        txtCreatePassword.Size = New Size(418, 27)
        txtCreatePassword.TabIndex = 1
        txtCreatePassword.UseSystemPasswordChar = True
        ' 
        ' confirmPasswordPanel
        ' 
        confirmPasswordPanel.Controls.Add(Label3)
        confirmPasswordPanel.Controls.Add(txtConfirmPassword)
        confirmPasswordPanel.Dock = DockStyle.Fill
        confirmPasswordPanel.Location = New Point(3, 275)
        confirmPasswordPanel.Margin = New Padding(3, 2, 3, 2)
        confirmPasswordPanel.Name = "confirmPasswordPanel"
        confirmPasswordPanel.Size = New Size(455, 63)
        confirmPasswordPanel.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label3.Location = New Point(18, 11)
        Label3.Name = "Label3"
        Label3.Size = New Size(148, 18)
        Label3.TabIndex = 0
        Label3.Text = "Confirm Password"
        ' 
        ' txtConfirmPassword
        ' 
        txtConfirmPassword.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        txtConfirmPassword.Font = New Font("Segoe UI", 11F)
        txtConfirmPassword.Location = New Point(18, 33)
        txtConfirmPassword.Name = "txtConfirmPassword"
        txtConfirmPassword.PlaceholderText = "Enter your confirm password here"
        txtConfirmPassword.Size = New Size(418, 27)
        txtConfirmPassword.TabIndex = 1
        txtConfirmPassword.UseSystemPasswordChar = True
        ' 
        ' showPasswordPanel
        ' 
        showPasswordPanel.Controls.Add(chkPassword)
        showPasswordPanel.Dock = DockStyle.Fill
        showPasswordPanel.Location = New Point(3, 342)
        showPasswordPanel.Margin = New Padding(3, 2, 3, 2)
        showPasswordPanel.Name = "showPasswordPanel"
        showPasswordPanel.Size = New Size(455, 63)
        showPasswordPanel.TabIndex = 5
        ' 
        ' chkPassword
        ' 
        chkPassword.AutoSize = True
        chkPassword.Location = New Point(18, 19)
        chkPassword.Name = "chkPassword"
        chkPassword.Size = New Size(108, 19)
        chkPassword.TabIndex = 0
        chkPassword.Text = "Show Password"
        chkPassword.UseVisualStyleBackColor = True
        ' 
        ' createButtonPanel
        ' 
        createButtonPanel.Controls.Add(btnCreateAccount)
        createButtonPanel.Dock = DockStyle.Fill
        createButtonPanel.Location = New Point(3, 409)
        createButtonPanel.Margin = New Padding(3, 2, 3, 2)
        createButtonPanel.Name = "createButtonPanel"
        createButtonPanel.Size = New Size(455, 71)
        createButtonPanel.TabIndex = 6
        ' 
        ' btnCreateAccount
        ' 
        btnCreateAccount.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnCreateAccount.AutoSize = True
        btnCreateAccount.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        btnCreateAccount.Location = New Point(360, 15)
        btnCreateAccount.Name = "btnCreateAccount"
        btnCreateAccount.Size = New Size(75, 30)
        btnCreateAccount.TabIndex = 0
        btnCreateAccount.Text = "Create"
        btnCreateAccount.UseVisualStyleBackColor = True
        ' 
        ' CreateAccountForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(934, 486)
        Controls.Add(mainTableLayoutPanel)
        Margin = New Padding(3, 2, 3, 2)
        MinimumSize = New Size(702, 460)
        Name = "CreateAccountForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Create Account"
        mainTableLayoutPanel.ResumeLayout(False)
        leftPanel.ResumeLayout(False)
        leftPanel.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        rightPanel.ResumeLayout(False)
        headerPanel.ResumeLayout(False)
        headerPanel.PerformLayout()
        emailPanel.ResumeLayout(False)
        emailPanel.PerformLayout()
        usernamePanel.ResumeLayout(False)
        usernamePanel.PerformLayout()
        passwordPanel.ResumeLayout(False)
        passwordPanel.PerformLayout()
        confirmPasswordPanel.ResumeLayout(False)
        confirmPasswordPanel.PerformLayout()
        showPasswordPanel.ResumeLayout(False)
        showPasswordPanel.PerformLayout()
        createButtonPanel.ResumeLayout(False)
        createButtonPanel.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents mainTableLayoutPanel As TableLayoutPanel
    Friend WithEvents leftPanel As Panel
    Friend WithEvents rightPanel As TableLayoutPanel
    Friend WithEvents headerPanel As Panel
    Friend WithEvents emailPanel As Panel
    Friend WithEvents usernamePanel As Panel
    Friend WithEvents passwordPanel As Panel
    Friend WithEvents confirmPasswordPanel As Panel
    Friend WithEvents showPasswordPanel As Panel
    Friend WithEvents createButtonPanel As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCreateAccount As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCreatePassword As TextBox
    Friend WithEvents txtCreateEmail As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCreateUsername As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents chkPassword As CheckBox
End Class