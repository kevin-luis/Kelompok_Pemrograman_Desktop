Imports System.Configuration
Imports ReadNest.My.MySettings

Public Class SessionHelper
    Public Shared Property CurrentUser As User
    Public Shared Property SessionToken As String

    Public Shared Sub CreatePersistentSession(userId As Integer, username As String)
        Dim db As New DBConnection
        SessionToken = db.CreatePersistentSession(userId)

        If Not String.IsNullOrEmpty(SessionToken) Then
            CurrentUser = New User With {
                .UserId = userId,
                .Username = username
            }

            ' Simpan ke settings aplikasi
            My.Settings.UserId = userId
            My.Settings.SessionToken = SessionToken
            My.Settings.Save()
        End If
    End Sub

    Public Shared Function AutoLogin() As Boolean
        If Not String.IsNullOrEmpty(My.Settings.SessionToken) AndAlso My.Settings.UserId > 0 Then
            Dim db As New DBConnection
            Dim dt = db.ValidatePersistentSession(My.Settings.SessionToken)

            If dt?.Rows.Count > 0 Then
                CurrentUser = New User With {
                .UserId = My.Settings.UserId,
                .Username = dt.Rows(0)("Username").ToString()
            }
                SessionToken = My.Settings.SessionToken
                Return True
            Else
                ClearSavedSession()
            End If
        End If
        Return False
    End Function

    Public Shared Sub EndSession()
        If Not String.IsNullOrEmpty(SessionToken) Then
            Dim db As New DBConnection
            db.EndUserSession(SessionToken)
            SessionToken = Nothing
            CurrentUser = Nothing
            ClearSavedSession()
        End If
    End Sub

    Public Shared Sub UpdateActivity()
        If Not String.IsNullOrEmpty(SessionToken) Then
            Dim db As New DBConnection
            db.UpdateSessionActivity(SessionToken)
        End If
    End Sub

    Public Shared Sub ClearSavedSession()
        My.Settings.UserId = 0
        My.Settings.SessionToken = ""
        My.Settings.Save()
    End Sub
End Class

Public Class User
    Public Property UserId As Integer
    Public Property Username As String
End Class