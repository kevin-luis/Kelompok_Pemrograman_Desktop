﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Panel1 = New Panel()
        btnCreateAccount = New Button()
        txtCreateEmail = New TextBox()
        Label7 = New Label()
        chkPassword = New CheckBox()
        Label1 = New Label()
        txtConfirmPassword = New TextBox()
        txtCreatePassword = New TextBox()
        Label5 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtCreateUsername = New TextBox()
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
        ' Panel1
        ' 
        Panel1.Controls.Add(btnCreateAccount)
        Panel1.Controls.Add(txtCreateEmail)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(chkPassword)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(txtConfirmPassword)
        Panel1.Controls.Add(txtCreatePassword)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(txtCreateUsername)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(470, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(461, 480)
        Panel1.TabIndex = 1
        ' 
        ' btnCreateAccount
        ' 
        btnCreateAccount.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnCreateAccount.AutoSize = True
        btnCreateAccount.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        btnCreateAccount.Location = New Point(377, 328)
        btnCreateAccount.Name = "btnCreateAccount"
        btnCreateAccount.Size = New Size(75, 30)
        btnCreateAccount.TabIndex = 0
        btnCreateAccount.Text = "Create"
        btnCreateAccount.UseVisualStyleBackColor = True
        ' 
        ' txtCreateEmail
        ' 
        txtCreateEmail.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtCreateEmail.Font = New Font("Segoe UI", 11F)
        txtCreateEmail.Location = New Point(160, 190)
        txtCreateEmail.Name = "txtCreateEmail"
        txtCreateEmail.PlaceholderText = "Enter your email here"
        txtCreateEmail.Size = New Size(292, 27)
        txtCreateEmail.TabIndex = 1
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft Sans Serif", 13.25F, FontStyle.Bold)
        Label7.Location = New Point(71, 117)
        Label7.Name = "Label7"
        Label7.Size = New Size(206, 22)
        Label7.TabIndex = 0
        Label7.Text = "Create Your Acccount"
        ' 
        ' chkPassword
        ' 
        chkPassword.AutoSize = True
        chkPassword.Location = New Point(160, 289)
        chkPassword.Name = "chkPassword"
        chkPassword.Size = New Size(108, 19)
        chkPassword.TabIndex = 0
        chkPassword.Text = "Show Password"
        chkPassword.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label1.Location = New Point(104, 194)
        Label1.Name = "Label1"
        Label1.Size = New Size(50, 18)
        Label1.TabIndex = 0
        Label1.Text = "Email"
        ' 
        ' txtConfirmPassword
        ' 
        txtConfirmPassword.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtConfirmPassword.Font = New Font("Segoe UI", 11F)
        txtConfirmPassword.Location = New Point(160, 256)
        txtConfirmPassword.Name = "txtConfirmPassword"
        txtConfirmPassword.PlaceholderText = "Enter your confirm password here"
        txtConfirmPassword.Size = New Size(292, 27)
        txtConfirmPassword.TabIndex = 1
        txtConfirmPassword.UseSystemPasswordChar = True
        ' 
        ' txtCreatePassword
        ' 
        txtCreatePassword.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtCreatePassword.Font = New Font("Segoe UI", 11F)
        txtCreatePassword.Location = New Point(160, 223)
        txtCreatePassword.Name = "txtCreatePassword"
        txtCreatePassword.PlaceholderText = "Enter your password here"
        txtCreatePassword.Size = New Size(292, 27)
        txtCreatePassword.TabIndex = 1
        txtCreatePassword.UseSystemPasswordChar = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label5.Location = New Point(71, 227)
        Label5.Name = "Label5"
        Label5.Size = New Size(83, 18)
        Label5.TabIndex = 0
        Label5.Text = "Password"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label3.Location = New Point(6, 261)
        Label3.Name = "Label3"
        Label3.Size = New Size(148, 18)
        Label3.TabIndex = 0
        Label3.Text = "Confirm Password"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label4.Location = New Point(69, 161)
        Label4.Name = "Label4"
        Label4.Size = New Size(85, 18)
        Label4.TabIndex = 0
        Label4.Text = "Username"
        ' 
        ' txtCreateUsername
        ' 
        txtCreateUsername.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtCreateUsername.Font = New Font("Segoe UI", 11F)
        txtCreateUsername.Location = New Point(160, 157)
        txtCreateUsername.Name = "txtCreateUsername"
        txtCreateUsername.PlaceholderText = "Enter your username here"
        txtCreateUsername.Size = New Size(292, 27)
        txtCreateUsername.TabIndex = 1
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
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents mainTableLayoutPanel As TableLayoutPanel
    Friend WithEvents leftPanel As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCreateAccount As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCreatePassword As TextBox
    Friend WithEvents txtCreateEmail As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCreateUsername As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents chkPassword As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel1 As Panel
End Class