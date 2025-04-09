Imports Microsoft.VisualBasic.ApplicationServices

Module Program
    Sub Main()
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)

        ' Cek session sebelum menampilkan form manapun
        If SessionHelper.AutoLogin() Then
            ' Jika ada session valid, langsung ke MainForm
            Application.Run(New MainForm())
        Else
            ' Jika tidak ada session, tampilkan LoginForm
            Application.Run(New LoginForm())
        End If
    End Sub
End Module