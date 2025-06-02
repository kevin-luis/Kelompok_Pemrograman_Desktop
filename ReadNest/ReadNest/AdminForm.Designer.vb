<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminForm
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
        Label1 = New Label()
        ListViewUser = New ListView()
        Label2 = New Label()
        ListViewAllBooks = New ListView()
        Label3 = New Label()
        BtnDeleteUser = New Button()
        BtnDeleteBook = New Button()
        BtnLogout = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.White
        Label1.Font = New Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ControlText
        Label1.ImageAlign = ContentAlignment.TopRight
        Label1.Location = New Point(689, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(233, 31)
        Label1.TabIndex = 7
        Label1.Text = "Admin ReadNest"
        ' 
        ' ListViewUser
        ' 
        ListViewUser.Location = New Point(12, 100)
        ListViewUser.Name = "ListViewUser"
        ListViewUser.Size = New Size(379, 197)
        ListViewUser.TabIndex = 8
        ListViewUser.UseCompatibleStateImageBehavior = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.White
        Label2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold)
        Label2.ForeColor = SystemColors.ControlText
        Label2.ImageAlign = ContentAlignment.TopRight
        Label2.Location = New Point(12, 77)
        Label2.Name = "Label2"
        Label2.Size = New Size(90, 20)
        Label2.TabIndex = 9
        Label2.Text = "List Users"
        ' 
        ' ListViewAllBooks
        ' 
        ListViewAllBooks.Location = New Point(414, 100)
        ListViewAllBooks.Name = "ListViewAllBooks"
        ListViewAllBooks.Size = New Size(379, 197)
        ListViewAllBooks.TabIndex = 10
        ListViewAllBooks.UseCompatibleStateImageBehavior = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.White
        Label3.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold)
        Label3.ForeColor = SystemColors.ControlText
        Label3.ImageAlign = ContentAlignment.TopRight
        Label3.Location = New Point(414, 77)
        Label3.Name = "Label3"
        Label3.Size = New Size(93, 20)
        Label3.TabIndex = 11
        Label3.Text = "List Books"
        ' 
        ' BtnDeleteUser
        ' 
        BtnDeleteUser.Location = New Point(306, 303)
        BtnDeleteUser.Name = "BtnDeleteUser"
        BtnDeleteUser.Size = New Size(85, 23)
        BtnDeleteUser.TabIndex = 12
        BtnDeleteUser.Text = "Delete user"
        BtnDeleteUser.UseVisualStyleBackColor = True
        ' 
        ' BtnDeleteBook
        ' 
        BtnDeleteBook.Location = New Point(695, 303)
        BtnDeleteBook.Name = "BtnDeleteBook"
        BtnDeleteBook.Size = New Size(98, 23)
        BtnDeleteBook.TabIndex = 13
        BtnDeleteBook.Text = "Delete book"
        BtnDeleteBook.UseVisualStyleBackColor = True
        ' 
        ' BtnLogout
        ' 
        BtnLogout.Location = New Point(847, 451)
        BtnLogout.Name = "BtnLogout"
        BtnLogout.Size = New Size(75, 23)
        BtnLogout.TabIndex = 14
        BtnLogout.Text = "Logout"
        BtnLogout.UseVisualStyleBackColor = True
        ' 
        ' AdminForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(934, 486)
        Controls.Add(BtnLogout)
        Controls.Add(BtnDeleteBook)
        Controls.Add(BtnDeleteUser)
        Controls.Add(Label3)
        Controls.Add(ListViewAllBooks)
        Controls.Add(Label2)
        Controls.Add(ListViewUser)
        Controls.Add(Label1)
        Name = "AdminForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "AdminForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ListViewUser As ListView
    Friend WithEvents Label2 As Label
    Friend WithEvents ListViewAllBooks As ListView
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnDeleteUser As Button
    Friend WithEvents BtnDeleteBook As Button
    Friend WithEvents BtnLogout As Button
End Class
