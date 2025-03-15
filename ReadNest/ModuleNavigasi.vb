Imports Microsoft.VisualBasic
'Module ModuleNavigasi
'    Public Sub HandleTombolNavigasi(sender As Object, e As EventArgs)

'        Dim tombol As Control = TryCast(sender, Control)
'        If tombol Is Nothing Then Exit Sub
'        Dim formSaatIni As Form = tombol.FindForm()

'        Dim tombol As Button = DirectCast(sender, Button)

'        Select Case tombol.Name

'            Case "lblDiscover"
'                Dim formBaru As New MainForm()
'                formBaru.Show()
'                formSaatIni.Hide()

'            Case "lblCategory"
'                CategoryForm.Show()
'            Case "btnSettings"
'                FormSettings.Show()
'            Case Else
'                MessageBox.Show("Halaman belum tersedia!")
'        End Select

'        If formBaru IsNot Nothing Then
'            formAktif?.Close() ' Tutup form lama jika ada
'            formAktif = formBaru
'            formAktif.Show()
'            formSaatIni.Hide()
'        End If
'    End Sub
'End Module
