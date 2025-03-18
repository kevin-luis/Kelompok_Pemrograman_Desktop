<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateAccountForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CreateAccountForm))
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        btnCreateAccount = New Button()
        Label7 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        txtCreatePassword = New TextBox()
        txtCreateEmail = New TextBox()
        Label1 = New Label()
        txtCreateUsername = New TextBox()
        Label3 = New Label()
        txtConfirmPassword = New TextBox()
        chkPassword = New CheckBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(-2, -3)
        PictureBox1.Margin = New Padding(3, 4, 3, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(543, 653)
        PictureBox1.TabIndex = 9
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.Info
        Label2.Font = New Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold)
        Label2.ForeColor = SystemColors.ControlText
        Label2.ImageAlign = ContentAlignment.TopRight
        Label2.Location = New Point(14, 45)
        Label2.Name = "Label2"
        Label2.Size = New Size(520, 39)
        Label2.TabIndex = 10
        Label2.Text = "Create Your ReadNest Account"
        ' 
        ' btnCreateAccount
        ' 
        btnCreateAccount.AutoSize = True
        btnCreateAccount.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        btnCreateAccount.Location = New Point(829, 523)
        btnCreateAccount.Margin = New Padding(3, 4, 3, 4)
        btnCreateAccount.Name = "btnCreateAccount"
        btnCreateAccount.Size = New Size(86, 40)
        btnCreateAccount.TabIndex = 4
        btnCreateAccount.Text = "Create"
        btnCreateAccount.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft Sans Serif", 13.25F, FontStyle.Bold)
        Label7.Location = New Point(593, 95)
        Label7.Name = "Label7"
        Label7.Size = New Size(265, 29)
        Label7.TabIndex = 0
        Label7.Text = "Create Your Acccount"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label5.Location = New Point(615, 323)
        Label5.Name = "Label5"
        Label5.Size = New Size(100, 24)
        Label5.TabIndex = 22
        Label5.Text = "Password"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label4.Location = New Point(611, 239)
        Label4.Name = "Label4"
        Label4.Size = New Size(105, 24)
        Label4.TabIndex = 21
        Label4.Text = "Username"
        ' 
        ' txtCreatePassword
        ' 
        txtCreatePassword.Font = New Font("Segoe UI", 11F)
        txtCreatePassword.Location = New Point(615, 351)
        txtCreatePassword.Margin = New Padding(3, 4, 3, 4)
        txtCreatePassword.Name = "txtCreatePassword"
        txtCreatePassword.PlaceholderText = "Enter your password here"
        txtCreatePassword.Size = New Size(299, 32)
        txtCreatePassword.TabIndex = 2
        txtCreatePassword.UseSystemPasswordChar = True
        ' 
        ' txtCreateEmail
        ' 
        txtCreateEmail.Font = New Font("Segoe UI", 11F)
        txtCreateEmail.Location = New Point(615, 184)
        txtCreateEmail.Margin = New Padding(3, 4, 3, 4)
        txtCreateEmail.Name = "txtCreateEmail"
        txtCreateEmail.PlaceholderText = "Enter your username here"
        txtCreateEmail.Size = New Size(299, 32)
        txtCreateEmail.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label1.Location = New Point(615, 156)
        Label1.Name = "Label1"
        Label1.Size = New Size(62, 24)
        Label1.TabIndex = 26
        Label1.Text = "Email"
        ' 
        ' txtCreateUsername
        ' 
        txtCreateUsername.Font = New Font("Segoe UI", 11F)
        txtCreateUsername.Location = New Point(615, 267)
        txtCreateUsername.Margin = New Padding(3, 4, 3, 4)
        txtCreateUsername.Name = "txtCreateUsername"
        txtCreateUsername.PlaceholderText = "Enter your email here"
        txtCreateUsername.Size = New Size(299, 32)
        txtCreateUsername.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label3.Location = New Point(611, 400)
        Label3.Name = "Label3"
        Label3.Size = New Size(178, 24)
        Label3.TabIndex = 28
        Label3.Text = "Confirm Password"
        ' 
        ' txtConfirmPassword
        ' 
        txtConfirmPassword.Font = New Font("Segoe UI", 11F)
        txtConfirmPassword.Location = New Point(615, 428)
        txtConfirmPassword.Margin = New Padding(3, 4, 3, 4)
        txtConfirmPassword.Name = "txtConfirmPassword"
        txtConfirmPassword.PlaceholderText = "Enter your confirm password here"
        txtConfirmPassword.Size = New Size(299, 32)
        txtConfirmPassword.TabIndex = 3
        txtConfirmPassword.UseSystemPasswordChar = True
        ' 
        ' chkPassword
        ' 
        chkPassword.AutoSize = True
        chkPassword.Location = New Point(615, 484)
        chkPassword.Margin = New Padding(3, 4, 3, 4)
        chkPassword.Name = "chkPassword"
        chkPassword.Size = New Size(132, 24)
        chkPassword.TabIndex = 29
        chkPassword.Text = "Show Password"
        chkPassword.UseVisualStyleBackColor = True
        ' 
        ' CreateAccountForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1067, 648)
        Controls.Add(chkPassword)
        Controls.Add(Label3)
        Controls.Add(txtConfirmPassword)
        Controls.Add(Label1)
        Controls.Add(txtCreateUsername)
        Controls.Add(btnCreateAccount)
        Controls.Add(Label7)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(txtCreatePassword)
        Controls.Add(txtCreateEmail)
        Controls.Add(Label2)
        Controls.Add(PictureBox1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "CreateAccountForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Create Account"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

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
