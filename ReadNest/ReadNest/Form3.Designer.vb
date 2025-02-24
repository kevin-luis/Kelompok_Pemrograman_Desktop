<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        btnCreateAccount = New Button()
        Label7 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        txtCreatePassword = New TextBox()
        txtCreateUsername = New TextBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(-2, -2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(475, 490)
        PictureBox1.TabIndex = 9
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.Info
        Label2.Font = New Font("UD Digi Kyokasho NP-B", 20.25F, FontStyle.Bold)
        Label2.ForeColor = SystemColors.ControlText
        Label2.ImageAlign = ContentAlignment.TopRight
        Label2.Location = New Point(12, 34)
        Label2.Name = "Label2"
        Label2.Size = New Size(443, 31)
        Label2.TabIndex = 10
        Label2.Text = "Create Your ReadNest Account"
        ' 
        ' btnCreateAccount
        ' 
        btnCreateAccount.AutoSize = True
        btnCreateAccount.Font = New Font("UD Digi Kyokasho NK-B", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        btnCreateAccount.Location = New Point(728, 261)
        btnCreateAccount.Name = "btnCreateAccount"
        btnCreateAccount.Size = New Size(75, 30)
        btnCreateAccount.TabIndex = 24
        btnCreateAccount.Text = "Create"
        btnCreateAccount.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("UD Digi Kyokasho NK-B", 13.25F, FontStyle.Bold)
        Label7.Location = New Point(521, 127)
        Label7.Name = "Label7"
        Label7.Size = New Size(216, 21)
        Label7.TabIndex = 23
        Label7.Text = "Create Your Acccount"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("UD Digi Kyokasho NK-B", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label5.Location = New Point(524, 220)
        Label5.Name = "Label5"
        Label5.Size = New Size(83, 17)
        Label5.TabIndex = 22
        Label5.Text = "Password"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("UD Digi Kyokasho NK-B", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label4.Location = New Point(521, 171)
        Label4.Name = "Label4"
        Label4.Size = New Size(86, 17)
        Label4.TabIndex = 21
        Label4.Text = "Username"
        ' 
        ' txtCreatePassword
        ' 
        txtCreatePassword.Font = New Font("Segoe UI", 11F)
        txtCreatePassword.Location = New Point(613, 215)
        txtCreatePassword.Name = "txtCreatePassword"
        txtCreatePassword.PlaceholderText = "Enter your password here"
        txtCreatePassword.Size = New Size(190, 27)
        txtCreatePassword.TabIndex = 20
        ' 
        ' txtCreateUsername
        ' 
        txtCreateUsername.Font = New Font("Segoe UI", 11F)
        txtCreateUsername.Location = New Point(613, 165)
        txtCreateUsername.Name = "txtCreateUsername"
        txtCreateUsername.PlaceholderText = "Enter your username here"
        txtCreateUsername.Size = New Size(190, 27)
        txtCreateUsername.TabIndex = 19
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(934, 486)
        Controls.Add(btnCreateAccount)
        Controls.Add(Label7)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(txtCreatePassword)
        Controls.Add(txtCreateUsername)
        Controls.Add(Label2)
        Controls.Add(PictureBox1)
        Name = "Form3"
        Text = "s"
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
    Friend WithEvents txtCreateUsername As TextBox
End Class
