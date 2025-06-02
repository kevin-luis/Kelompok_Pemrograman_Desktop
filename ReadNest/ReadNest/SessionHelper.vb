Imports System.Configuration
Imports ReadNest.My.MySettings

Public Enum AutoLoginStatus ' Anda bisa letakkan ini di sini atau di file terpisah
    NoLoginOrExpired
    UserLoggedIn
    AdminLoggedIn
End Enum

Public Class SessionHelper
    Public Shared Property CurrentUser As User
    Public Shared Property SessionToken As String

    Public Shared Sub CreatePersistentSession(userId As Integer, username As String)
        Dim db As New DBConnection
        SessionToken = db.CreatePersistentSession(userId) ' Ini memanggil fungsi di DBConnection

        If Not String.IsNullOrEmpty(SessionToken) Then
            CurrentUser = New User With {
                .userId = userId,
                .username = username
            }

            ' Simpan ke settings aplikasi
            My.Settings.UserId = userId
            My.Settings.SessionToken = SessionToken
            My.Settings.Save()
        End If
    End Sub

    ' MODIFIKASI FUNGSI AutoLogin
    Public Shared Function AutoLogin() As AutoLoginStatus ' Mengembalikan Enum baru
        If Not String.IsNullOrEmpty(My.Settings.SessionToken) AndAlso My.Settings.UserId > 0 Then
            Dim db As New DBConnection
            Dim dtUserData = db.ValidatePersistentSession(My.Settings.SessionToken)

            If dtUserData IsNot Nothing AndAlso dtUserData.Rows.Count > 0 Then
                CurrentUser = New User With {
                    .UserId = My.Settings.UserId,
                    .Username = dtUserData.Rows(0)("Username").ToString() ' Ambil username dari hasil validasi
                }
                SessionToken = My.Settings.SessionToken

                ' Cek apakah pengguna yang auto-login adalah Admin
                If CurrentUser.Username.Equals("Admin", StringComparison.OrdinalIgnoreCase) Then
                    Return AutoLoginStatus.AdminLoggedIn
                Else
                    Return AutoLoginStatus.UserLoggedIn
                End If
            Else
                ' Sesi tidak valid atau sudah expired
                ClearSavedSession()
                Return AutoLoginStatus.NoLoginOrExpired
            End If
        End If
        ' Tidak ada sesi yang tersimpan
        Return AutoLoginStatus.NoLoginOrExpired
    End Function

    Public Shared Sub EndSession()
        If Not String.IsNullOrEmpty(SessionToken) Then
            Dim db As New DBConnection
            db.EndUserSession(SessionToken) ' Memanggil fungsi di DBConnection
            SessionToken = Nothing
            CurrentUser = Nothing
            ClearSavedSession()
        End If
    End Sub

    Public Shared Sub UpdateActivity()
        If Not String.IsNullOrEmpty(SessionToken) Then
            Dim db As New DBConnection
            db.UpdateSessionActivity(SessionToken) ' Memanggil fungsi di DBConnection
        End If
    End Sub

    Public Shared Sub ClearSavedSession()
        My.Settings.UserId = 0
        My.Settings.SessionToken = ""
        My.Settings.Save()
    End Sub
End Class

' Kelas User tetap sama
Public Class User
    Public Property UserId As Integer
    Public Property Username As String
End Class