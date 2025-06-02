Imports Microsoft.VisualBasic.ApplicationServices

Module Program
    Sub Main()
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)

        ' Cek session sebelum menampilkan form manapun
        ' Panggil SessionHelper.AutoLogin() yang sekarang mengembalikan AutoLoginStatus
        Dim loginStatus As AutoLoginStatus = SessionHelper.AutoLogin()

        Select Case loginStatus
            Case AutoLoginStatus.AdminLoggedIn
                ' Jika Admin yang auto-login, buka AdminForm
                Application.Run(New AdminForm())
            Case AutoLoginStatus.UserLoggedIn
                ' Jika pengguna biasa yang auto-login, buka MainForm
                Application.Run(New MainForm())
            Case AutoLoginStatus.NoLoginOrExpired
                ' Jika tidak ada sesi atau sesi expired, tampilkan LoginForm
                Application.Run(New LoginForm())
            Case Else ' Penanganan untuk kasus yang tidak diharapkan (seharusnya tidak terjadi)
                Application.Run(New LoginForm())
        End Select
    End Sub
End Module