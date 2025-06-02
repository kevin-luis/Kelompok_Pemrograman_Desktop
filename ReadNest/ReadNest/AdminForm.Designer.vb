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
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.White
        Label1.Font = New Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ControlText
        Label1.ImageAlign = ContentAlignment.TopRight
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(233, 31)
        Label1.TabIndex = 7
        Label1.Text = "Admin ReadNest"
        ' 
        ' ListViewUser
        ' 
        ListViewUser.Location = New Point(12, 80)
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
        Label2.Location = New Point(12, 57)
        Label2.Name = "Label2"
        Label2.Size = New Size(90, 20)
        Label2.TabIndex = 9
        Label2.Text = "List Users"
        ' 
        ' AdminForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(934, 486)
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
End Class
