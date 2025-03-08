<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        txtloginusername = New TextBox()
        txtloginpassword = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        linkCreateAccount = New LinkLabel()
        Label6 = New Label()
        Label7 = New Label()
        btnLoginaAccount = New Button()
        chkPassword = New CheckBox()
        Panel1 = New Panel()
        MySqlCommand1 = New MySql.Data.MySqlClient.MySqlCommand()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.Info
        Label1.Font = New Font("UD Digi Kyokasho NK-B", 30F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label1.ForeColor = SystemColors.ControlText
        Label1.ImageAlign = ContentAlignment.TopRight
        Label1.Location = New Point(224, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(221, 46)
        Label1.TabIndex = 7
        Label1.Text = "ReadNest"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(475, 490)
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.Info
        Label2.Font = New Font("UD Digi Kyokasho NK-B", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label2.ForeColor = SystemColors.ControlText
        Label2.ImageAlign = ContentAlignment.TopRight
        Label2.Location = New Point(12, 30)
        Label2.Name = "Label2"
        Label2.Size = New Size(223, 41)
        Label2.TabIndex = 9
        Label2.Text = "Welcome to"
        ' 
        ' txtloginusername
        ' 
        txtloginusername.Font = New Font("Segoe UI", 11F)
        txtloginusername.Location = New Point(613, 165)
        txtloginusername.Name = "txtloginusername"
        txtloginusername.PlaceholderText = "Enter your username here"
        txtloginusername.Size = New Size(190, 27)
        txtloginusername.TabIndex = 0
        ' 
        ' txtloginpassword
        ' 
        txtloginpassword.Font = New Font("Segoe UI", 11F)
        txtloginpassword.Location = New Point(613, 215)
        txtloginpassword.Name = "txtloginpassword"
        txtloginpassword.PlaceholderText = "Enter your password here"
        txtloginpassword.Size = New Size(190, 27)
        txtloginpassword.TabIndex = 1
        txtloginpassword.UseSystemPasswordChar = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label4.Location = New Point(521, 171)
        Label4.Name = "Label4"
        Label4.Size = New Size(85, 18)
        Label4.TabIndex = 13
        Label4.Text = "Username"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label5.Location = New Point(524, 220)
        Label5.Name = "Label5"
        Label5.Size = New Size(83, 18)
        Label5.TabIndex = 14
        Label5.Text = "Password"
        ' 
        ' linkCreateAccount
        ' 
        linkCreateAccount.AutoSize = True
        linkCreateAccount.Location = New Point(642, 347)
        linkCreateAccount.Name = "linkCreateAccount"
        linkCreateAccount.Size = New Size(59, 15)
        linkCreateAccount.TabIndex = 15
        linkCreateAccount.TabStop = True
        linkCreateAccount.Text = "Click here"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(524, 347)
        Label6.Name = "Label6"
        Label6.Size = New Size(112, 15)
        Label6.TabIndex = 16
        Label6.Text = "Dont have account?"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft Sans Serif", 13.25F, FontStyle.Bold)
        Label7.Location = New Point(521, 127)
        Label7.Name = "Label7"
        Label7.Size = New Size(195, 22)
        Label7.TabIndex = 17
        Label7.Text = "Login Your Acccount"
        ' 
        ' btnLoginaAccount
        ' 
        btnLoginaAccount.AutoSize = True
        btnLoginaAccount.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        btnLoginaAccount.Location = New Point(728, 279)
        btnLoginaAccount.Name = "btnLoginaAccount"
        btnLoginaAccount.Size = New Size(75, 30)
        btnLoginaAccount.TabIndex = 2
        btnLoginaAccount.Text = "Login"
        btnLoginaAccount.UseVisualStyleBackColor = True
        ' 
        ' chkPassword
        ' 
        chkPassword.AutoSize = True
        chkPassword.Location = New Point(613, 248)
        chkPassword.Name = "chkPassword"
        chkPassword.Size = New Size(108, 19)
        chkPassword.TabIndex = 18
        chkPassword.Text = "Show Password"
        chkPassword.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(934, 486)
        Panel1.TabIndex = 19
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
        AutoSize = True
        BackColor = Color.White
        ClientSize = New Size(934, 486)
        Controls.Add(chkPassword)
        Controls.Add(btnLoginaAccount)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(linkCreateAccount)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(txtloginpassword)
        Controls.Add(txtloginusername)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        Name = "LoginForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ReadNest, Your Personal Library "
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

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
    Friend WithEvents Panel1 As Panel
    Friend WithEvents MySqlCommand1 As MySql.Data.MySqlClient.MySqlCommand
End Class
