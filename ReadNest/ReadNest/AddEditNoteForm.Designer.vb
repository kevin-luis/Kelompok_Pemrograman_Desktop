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
        btnSave = New Button()
        btnCancel = New Button()
        cbBooks = New ComboBox()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(16, 23)
        lblTitle.Margin = New Padding(5, 0, 5, 0)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(69, 24)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Judul:"
        ' 
        ' txtTitle
        ' 
        txtTitle.Font = New Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtTitle.Location = New Point(22, 61)
        txtTitle.Margin = New Padding(5, 4, 5, 4)
        txtTitle.MaxLength = 255
        txtTitle.Name = "txtTitle"
        txtTitle.PlaceholderText = "Judul Tidak Boleh Kosong"
        txtTitle.Size = New Size(598, 27)
        txtTitle.TabIndex = 1
        txtTitle.Text = "Untitled Note"
        ' 
        ' lblContent
        ' 
        lblContent.AutoSize = True
        lblContent.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblContent.Location = New Point(16, 123)
        lblContent.Margin = New Padding(5, 0, 5, 0)
        lblContent.Name = "lblContent"
        lblContent.Size = New Size(99, 24)
        lblContent.TabIndex = 2
        lblContent.Text = "Isi Notes:"
        ' 
        ' txtContent
        ' 
        txtContent.Font = New Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtContent.Location = New Point(22, 161)
        txtContent.Margin = New Padding(5, 4, 5, 4)
        txtContent.Multiline = True
        txtContent.Name = "txtContent"
        txtContent.ScrollBars = ScrollBars.Vertical
        txtContent.Size = New Size(598, 305)
        txtContent.TabIndex = 3
        ' 
        ' lblBookId
        ' 
        lblBookId.AutoSize = True
        lblBookId.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblBookId.Location = New Point(16, 492)
        lblBookId.Margin = New Padding(5, 0, 5, 0)
        lblBookId.Name = "lblBookId"
        lblBookId.Size = New Size(212, 24)
        lblBookId.TabIndex = 4
        lblBookId.Text = "Pilih Buku (Optional):"
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.DodgerBlue
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Font = New Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSave.ForeColor = Color.White
        btnSave.Location = New Point(374, 600)
        btnSave.Margin = New Padding(5, 4, 5, 4)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(120, 53)
        btnSave.TabIndex = 6
        btnSave.Text = "Simpan"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.Gray
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.Font = New Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCancel.ForeColor = Color.White
        btnCancel.Location = New Point(502, 600)
        btnCancel.Margin = New Padding(5, 4, 5, 4)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(120, 53)
        btnCancel.TabIndex = 7
        btnCancel.Text = "Batal"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' cbBooks
        ' 
        cbBooks.DropDownStyle = ComboBoxStyle.DropDownList
        cbBooks.Font = New Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbBooks.Location = New Point(22, 531)
        cbBooks.Margin = New Padding(5, 4, 5, 4)
        cbBooks.Name = "cbBooks"
        cbBooks.Size = New Size(399, 27)
        cbBooks.TabIndex = 5
        ' 
        ' AddEditNoteForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(646, 679)
        Controls.Add(btnCancel)
        Controls.Add(btnSave)
        Controls.Add(cbBooks)
        Controls.Add(lblBookId)
        Controls.Add(txtContent)
        Controls.Add(lblContent)
        Controls.Add(txtTitle)
        Controls.Add(lblTitle)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Margin = New Padding(5, 4, 5, 4)
        MaximizeBox = False
        MinimizeBox = False
        Name = "AddEditNoteForm"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "MyNote"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents lblContent As Label
    Friend WithEvents txtContent As TextBox
    Friend WithEvents lblBookId As Label
    'Friend WithEvents txtBookId As TextBox
    Friend WithEvents cbBooks As ComboBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
End Class