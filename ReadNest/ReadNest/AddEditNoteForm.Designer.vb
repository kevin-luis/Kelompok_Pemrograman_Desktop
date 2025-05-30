<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddEditNoteForm
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
        lblTitle = New Label()
        txtTitle = New TextBox()
        lblContent = New Label()
        txtContent = New TextBox()
        lblBookId = New Label()
        txtBookId = New TextBox()
        btnSave = New Button()
        btnCancel = New Button()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Arial", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(14, 17)
        lblTitle.Margin = New Padding(4, 0, 4, 0)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(58, 19)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Judul:"
        ' 
        ' txtTitle
        ' 
        txtTitle.Font = New Font("Arial", 10.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtTitle.Location = New Point(19, 46)
        txtTitle.Margin = New Padding(4, 3, 4, 3)
        txtTitle.MaxLength = 255
        txtTitle.Name = "txtTitle"
        txtTitle.PlaceholderText = "Judul Tidak Boleh Kosong"
        txtTitle.Size = New Size(524, 23)
        txtTitle.TabIndex = 1
        txtTitle.Text = "Untitled Note"
        ' 
        ' lblContent
        ' 
        lblContent.AutoSize = True
        lblContent.Font = New Font("Arial", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblContent.Location = New Point(14, 92)
        lblContent.Margin = New Padding(4, 0, 4, 0)
        lblContent.Name = "lblContent"
        lblContent.Size = New Size(81, 19)
        lblContent.TabIndex = 2
        lblContent.Text = "Isi Notes:"
        ' 
        ' txtContent
        ' 
        txtContent.Font = New Font("Arial", 10.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtContent.Location = New Point(19, 121)
        txtContent.Margin = New Padding(4, 3, 4, 3)
        txtContent.Multiline = True
        txtContent.Name = "txtContent"
        txtContent.ScrollBars = ScrollBars.Vertical
        txtContent.Size = New Size(524, 230)
        txtContent.TabIndex = 3
        ' 
        ' lblBookId
        ' 
        lblBookId.AutoSize = True
        lblBookId.Font = New Font("Arial", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblBookId.Location = New Point(14, 369)
        lblBookId.Margin = New Padding(4, 0, 4, 0)
        lblBookId.Name = "lblBookId"
        lblBookId.Size = New Size(154, 19)
        lblBookId.TabIndex = 4
        lblBookId.Text = "Book ID (Optional):"
        ' 
        ' txtBookId
        ' 
        txtBookId.Font = New Font("Arial", 10.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtBookId.Location = New Point(19, 398)
        txtBookId.Margin = New Padding(4, 3, 4, 3)
        txtBookId.MaxLength = 50
        txtBookId.Name = "txtBookId"
        txtBookId.Size = New Size(233, 23)
        txtBookId.TabIndex = 5
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.DodgerBlue
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Font = New Font("Arial", 10.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSave.ForeColor = Color.White
        btnSave.Location = New Point(327, 450)
        btnSave.Margin = New Padding(4, 3, 4, 3)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(105, 40)
        btnSave.TabIndex = 6
        btnSave.Text = "Simpan"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.Gray
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.Font = New Font("Arial", 10.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCancel.ForeColor = Color.White
        btnCancel.Location = New Point(439, 450)
        btnCancel.Margin = New Padding(4, 3, 4, 3)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(105, 40)
        btnCancel.TabIndex = 7
        btnCancel.Text = "Batal"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' AddEditNoteForm
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(565, 509)
        Controls.Add(btnCancel)
        Controls.Add(btnSave)
        Controls.Add(txtBookId)
        Controls.Add(lblBookId)
        Controls.Add(txtContent)
        Controls.Add(lblContent)
        Controls.Add(txtTitle)
        Controls.Add(lblTitle)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Margin = New Padding(4, 3, 4, 3)
        MaximizeBox = False
        MinimizeBox = False
        Name = "AddEditNoteForm"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Note Form"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents lblContent As Label
    Friend WithEvents txtContent As TextBox
    Friend WithEvents lblBookId As Label
    Friend WithEvents txtBookId As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
End Class