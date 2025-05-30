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
        pnlHeader.Margin = New Padding(4, 3, 4, 3)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(565, 69)
        pnlHeader.TabIndex = 0
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = False
        lblTitle.Font = New Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = Color.Black
        lblTitle.Location = New Point(14, 23)
        lblTitle.Margin = New Padding(4, 0, 4, 0)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(350, 22)
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
        btnAddNote.Location = New Point(456, 17)
        btnAddNote.Margin = New Padding(4, 3, 4, 3)
        btnAddNote.Name = "btnAddNote"
        btnAddNote.Size = New Size(93, 35)
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
        pnlMain.Location = New Point(0, 69)
        pnlMain.Margin = New Padding(4, 3, 4, 3)
        pnlMain.Name = "pnlMain"
        pnlMain.Size = New Size(565, 440)
        pnlMain.TabIndex = 1
        ' 
        ' flNotes
        ' 
        flNotes.AutoScroll = True
        flNotes.BackColor = Color.WhiteSmoke
        flNotes.Dock = DockStyle.Fill
        flNotes.Location = New Point(0, 0)
        flNotes.Margin = New Padding(4, 3, 4, 3)
        flNotes.Name = "flNotes"
        flNotes.Padding = New Padding(12, 12, 12, 12)
        flNotes.Size = New Size(565, 440)
        flNotes.TabIndex = 0
        ' 
        ' lblEmptyMessage
        ' 
        lblEmptyMessage.Anchor = AnchorStyles.None
        lblEmptyMessage.AutoSize = True
        lblEmptyMessage.Font = New Font("Arial", 12.0F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblEmptyMessage.ForeColor = Color.Gray
        lblEmptyMessage.Location = New Point(177, 210)
        lblEmptyMessage.Margin = New Padding(4, 0, 4, 0)
        lblEmptyMessage.Name = "lblEmptyMessage"
        lblEmptyMessage.Size = New Size(211, 19)
        lblEmptyMessage.TabIndex = 1
        lblEmptyMessage.Text = "No notes found for this book."
        lblEmptyMessage.TextAlign = ContentAlignment.MiddleCenter
        lblEmptyMessage.Visible = False
        ' 
        ' BookNotesForm
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(565, 509)
        Controls.Add(pnlMain)
        Controls.Add(pnlHeader)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Margin = New Padding(4, 3, 4, 3)
        MaximizeBox = False
        MinimumSize = New Size(581, 548)
        Name = "BookNotesForm"
        StartPosition = FormStartPosition.CenterParent
        Text = "Book Notes"
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