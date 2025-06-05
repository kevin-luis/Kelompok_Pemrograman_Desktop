<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BookNotesForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BookNotesForm))
        pnlHeader = New Panel()
        lblTitle = New Label()
        btnAddNote = New Button()
        pnlMain = New Panel()
        flNotes = New FlowLayoutPanel()
        lblEmptyMessage = New Label()
        pnlHeader.SuspendLayout()
        pnlMain.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = SystemColors.Info
        pnlHeader.Controls.Add(lblTitle)
        pnlHeader.Controls.Add(btnAddNote)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Margin = New Padding(5, 4, 5, 4)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(646, 92)
        pnlHeader.TabIndex = 0
        ' 
        ' lblTitle
        ' 
        lblTitle.Font = New Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = Color.Black
        lblTitle.Location = New Point(16, 31)
        lblTitle.Margin = New Padding(5, 0, 5, 0)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(400, 29)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Book Notes"
        lblTitle.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' btnAddNote
        ' 
        btnAddNote.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnAddNote.BackColor = Color.FromArgb(CByte(40), CByte(167), CByte(69))
        btnAddNote.FlatAppearance.BorderSize = 0
        btnAddNote.FlatStyle = FlatStyle.Flat
        btnAddNote.Font = New Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAddNote.ForeColor = Color.White
        btnAddNote.Location = New Point(521, 23)
        btnAddNote.Margin = New Padding(5, 4, 5, 4)
        btnAddNote.Name = "btnAddNote"
        btnAddNote.Size = New Size(106, 47)
        btnAddNote.TabIndex = 1
        btnAddNote.Text = "+ Add Note"
        btnAddNote.UseVisualStyleBackColor = False
        ' 
        ' pnlMain
        ' 
        pnlMain.BackColor = Color.White
        pnlMain.Controls.Add(flNotes)
        pnlMain.Controls.Add(lblEmptyMessage)
        pnlMain.Dock = DockStyle.Fill
        pnlMain.Location = New Point(0, 92)
        pnlMain.Margin = New Padding(5, 4, 5, 4)
        pnlMain.Name = "pnlMain"
        pnlMain.Size = New Size(646, 587)
        pnlMain.TabIndex = 1
        ' 
        ' flNotes
        ' 
        flNotes.AutoScroll = True
        flNotes.BackColor = Color.WhiteSmoke
        flNotes.Dock = DockStyle.Fill
        flNotes.Location = New Point(0, 0)
        flNotes.Margin = New Padding(5, 4, 5, 4)
        flNotes.Name = "flNotes"
        flNotes.Padding = New Padding(14, 16, 14, 16)
        flNotes.Size = New Size(646, 587)
        flNotes.TabIndex = 0
        ' 
        ' lblEmptyMessage
        ' 
        lblEmptyMessage.Anchor = AnchorStyles.None
        lblEmptyMessage.AutoSize = True
        lblEmptyMessage.Font = New Font("Arial", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblEmptyMessage.ForeColor = Color.Gray
        lblEmptyMessage.Location = New Point(202, 280)
        lblEmptyMessage.Margin = New Padding(5, 0, 5, 0)
        lblEmptyMessage.Name = "lblEmptyMessage"
        lblEmptyMessage.Size = New Size(267, 24)
        lblEmptyMessage.TabIndex = 1
        lblEmptyMessage.Text = "No notes found for this book."
        lblEmptyMessage.TextAlign = ContentAlignment.MiddleCenter
        lblEmptyMessage.Visible = False
        ' 
        ' BookNotesForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(646, 679)
        Controls.Add(pnlMain)
        Controls.Add(pnlHeader)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(5, 4, 5, 4)
        MaximizeBox = False
        MinimumSize = New Size(661, 715)
        Name = "BookNotesForm"
        StartPosition = FormStartPosition.CenterParent
        Text = "MyBookNote"
        pnlHeader.ResumeLayout(False)
        pnlMain.ResumeLayout(False)
        pnlMain.PerformLayout()
        ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnAddNote As Button
    Friend WithEvents pnlMain As Panel
    Friend WithEvents flNotes As FlowLayoutPanel
    Friend WithEvents lblEmptyMessage As Label
End Class