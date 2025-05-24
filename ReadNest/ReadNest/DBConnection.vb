Imports System.IO
Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class DBConnection
    Private ReadOnly strConn As String = "server=localhost;userid=root;password=;database=readnest"
    Private ReadOnly connectionProvider As Func(Of MySqlConnection) = Function() New MySqlConnection(strConn)

    ' Central error handler
    Private Function HandleError(ex As Exception, message As String) As Boolean
        MessageBox.Show($"{message}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return False
    End Function

    ' Helper method that creates a connection, performs an action, and disposes connection
    Private Function WithConnection(Of T)(action As Func(Of MySqlConnection, T)) As T
        Using conn As New MySqlConnection(strConn)
            Try
                conn.Open()
                Return action(conn)
            Catch ex As Exception
                HandleError(ex, "Database operation failed")
                Return Nothing
            End Try
        End Using
    End Function

    ' Helper method for non-query operations
    Public Function ExecuteNonQueryWithParams(query As String, parameters As Dictionary(Of String, Object)) As Integer
        Return WithConnection(Function(conn)
                                  Using cmd As New MySqlCommand(query, conn)
                                      For Each param In parameters
                                          cmd.Parameters.AddWithValue(param.Key, If(param.Value Is Nothing, DBNull.Value, param.Value))
                                      Next
                                      Return cmd.ExecuteNonQuery()
                                  End Using
                              End Function)
    End Function

    ' Helper method for query operations
    Public Function ExecuteQueryWithParams(query As String, parameters As Dictionary(Of String, Object)) As DataTable
        Return WithConnection(Function(conn)
                                  Dim dt As New DataTable()
                                  Using cmd As New MySqlCommand(query, conn)
                                      For Each param In parameters
                                          cmd.Parameters.AddWithValue(param.Key, If(param.Value Is Nothing, DBNull.Value, param.Value))
                                      Next
                                      Using da As New MySqlDataAdapter(cmd)
                                          da.Fill(dt)
                                      End Using
                                      Return dt
                                  End Using
                              End Function)
    End Function

    ' Password encryption
    Public Function EncryptPassword(password As String) As String
        Try
            Using sha256 As SHA256 = SHA256.Create()
                Dim bytes As Byte() = sha256.ComputeHash(Encoding.UTF8.GetBytes(password))

                Dim builder As New StringBuilder()
                For i As Integer = 0 To bytes.Length - 1
                    builder.Append(bytes(i).ToString("x2"))
                Next

                Return builder.ToString()
            End Using
        Catch ex As Exception
            HandleError(ex, "Error enkripsi")
            Return Nothing
        End Try
    End Function

    ' User authentication
    Public Function CekLogin(username As String, password As String) As DataTable
        Dim encryptedPassword As String = EncryptPassword(password)
        If encryptedPassword Is Nothing Then Return Nothing

        Dim query As String = "SELECT UserId, Username FROM users WHERE username=@username AND password=@password"
        Dim parameters As New Dictionary(Of String, Object) From {
            {"@username", username},
            {"@password", encryptedPassword}
        }

        Return ExecuteQueryWithParams(query, parameters)
    End Function

    ' User registration
    Public Function TambahAkun(email As String, username As String, password As String) As Boolean
        Dim encryptedPassword As String = EncryptPassword(password)
        If encryptedPassword Is Nothing Then Return False

        Dim query As String = "INSERT INTO users (email, username, password) VALUES (@email, @username, @password)"
        Dim parameters As New Dictionary(Of String, Object) From {
            {"@email", email},
            {"@username", username},
            {"@password", encryptedPassword}
        }

        Dim result = ExecuteNonQueryWithParams(query, parameters)
        Return result > 0
    End Function

    ' Check if email exists
    Public Function CekEmailTerdaftar(email As String) As Boolean
        Dim query As String = "SELECT COUNT(*) FROM users WHERE email = @email"
        Dim parameters As New Dictionary(Of String, Object) From {
            {"@email", email}
        }

        Return WithConnection(Function(conn)
                                  Using cmd As New MySqlCommand(query, conn)
                                      cmd.Parameters.AddWithValue("@email", email)
                                      Dim count = Convert.ToInt32(cmd.ExecuteScalar())
                                      Return count > 0
                                  End Using
                              End Function)
    End Function

    ' Check if username exists
    Public Function CekUsernameTerdaftar(username As String) As Boolean
        Dim query As String = "SELECT COUNT(*) FROM users WHERE username = @username"
        Dim parameters As New Dictionary(Of String, Object) From {
            {"@username", username}
        }

        Return WithConnection(Function(conn)
                                  Using cmd As New MySqlCommand(query, conn)
                                      cmd.Parameters.AddWithValue("@username", username)
                                      Dim count = Convert.ToInt32(cmd.ExecuteScalar())
                                      Return count > 0
                                  End Using
                              End Function)
    End Function

    ' Add book
    Public Function TambahBuku(userId As Integer, title As String, author As String, categoryId As Integer,
                     pages As Integer, description As String, photoPath As String, filePath As String) As Boolean
        Dim query As String = "INSERT INTO books (UserId, Title, Author, CategoryId, Pages, Description, " &
                  "PhotoPath, FilePath, Status, CreatedAt, ReadDuration, IsFavorite, IsWishlist) " &
                  "VALUES (@userId, @title, @author, @categoryId, @pages, @description, " &
                  "@photoPath, @filePath, 'Available', NOW(), 0, 0, 0)"

        Dim parameters As New Dictionary(Of String, Object) From {
            {"@userId", userId},
            {"@title", title},
            {"@author", author},
            {"@categoryId", If(categoryId = 0, Nothing, categoryId)},
            {"@pages", pages},
            {"@description", description},
            {"@photoPath", If(String.IsNullOrEmpty(photoPath), Nothing, photoPath)},
            {"@filePath", If(String.IsNullOrEmpty(filePath), Nothing, filePath)}
        }

        Dim result = ExecuteNonQueryWithParams(query, parameters)
        Return result > 0
    End Function

    ' Get categories
    Public Function GetCategories() As DataTable
        Dim query As String = "SELECT CategoryId, CategoryName FROM categories ORDER BY CategoryName"
        Return ExecuteQueryWithParams(query, New Dictionary(Of String, Object))
    End Function

    ' Get books
    Public Function GetBooks(userId As Integer) As DataTable
        Dim query As String = "SELECT BookId, UserId, Title, Author, PhotoPath FROM books WHERE UserId = @UserId ORDER BY CreatedAt DESC"
        Dim parameters As New Dictionary(Of String, Object) From {
            {"@UserId", userId}
        }

        Return ExecuteQueryWithParams(query, parameters)
    End Function

    ' Get book details
    Public Function GetBookDetail(bookId As Integer) As DataRow
        Dim query As String = "SELECT b.BookId, b.Title, b.Author, b.Description, b.Pages, b.PhotoPath, b.FilePath, " &
                            "c.CategoryName, b.Status, b.IsWishlist, b.IsFavorite " &
                            "FROM books b " &
                            "LEFT JOIN categories c ON b.CategoryId = c.CategoryId " &
                            "WHERE b.BookId = @bookId"

        Dim parameters As New Dictionary(Of String, Object) From {
            {"@bookId", bookId}
        }

        Dim dt = ExecuteQueryWithParams(query, parameters)
        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
            Return dt.Rows(0)
        End If

        Return Nothing
    End Function

    ' Toggle wishlist status
    Public Function UpdateBookWishlist(bookId As Integer) As Boolean
        Dim query As String = "UPDATE books SET IsWishlist = NOT IsWishlist WHERE BookId = @bookId"
        Dim parameters As New Dictionary(Of String, Object) From {
            {"@bookId", bookId}
        }

        Dim result = ExecuteNonQueryWithParams(query, parameters)
        Return result > 0
    End Function

    ' Toggle favorite status
    Public Function UpdateBookFavorite(bookId As Integer) As Boolean
        Dim query As String = "UPDATE books SET IsFavorite = NOT IsFavorite WHERE BookId = @bookId"
        Dim parameters As New Dictionary(Of String, Object) From {
            {"@bookId", bookId}
        }

        Dim result = ExecuteNonQueryWithParams(query, parameters)
        Return result > 0
    End Function

    ' Borrow book
    Public Function BorrowBook(bookId As Integer) As Boolean
        Dim query As String = "UPDATE books SET Status = 'Borrowed' WHERE BookId = @bookId"
        Dim parameters As New Dictionary(Of String, Object) From {
            {"@bookId", bookId}
        }

        Dim result = ExecuteNonQueryWithParams(query, parameters)
        Return result > 0
    End Function

    ' Return book
    Public Function ReturnBook(bookId As Integer) As Boolean
        Dim query As String = "UPDATE books SET Status = 'Available' WHERE BookId = @bookId"
        Dim parameters As New Dictionary(Of String, Object) From {
            {"@bookId", bookId}
        }

        Dim result = ExecuteNonQueryWithParams(query, parameters)
        Return result > 0
    End Function

    ' Load book cover image
    Public Function LoadBookCoverImage(photoPath As String) As Image
        ' Cek apakah path kosong
        If String.IsNullOrEmpty(photoPath) Then
            Return Nothing
        End If

        Dim coverPath As String

        ' Cek apakah ini path absolut atau relatif
        If Path.IsPathRooted(photoPath) Then
            coverPath = photoPath
        ElseIf photoPath.StartsWith("BookCovers\") Then
            coverPath = Path.Combine(Application.StartupPath, photoPath)
        Else
            coverPath = Path.Combine(Application.StartupPath, "BookCovers", photoPath)
        End If

        Debug.WriteLine($"Trying to load image from: {coverPath}")

        Try
            If File.Exists(coverPath) Then
                Using tempImage As Image = Image.FromFile(coverPath)
                    Return New Bitmap(tempImage)
                End Using
            Else
                Debug.WriteLine($"File not found: {coverPath}")
                Return Nothing
            End If
        Catch ex As Exception
            HandleError(ex, "Error loading image")
            Return Nothing
        End Try
    End Function

    ' Update reading progress
    Public Function UpdateReadingProgressAbsolute(userId As Integer, bookId As Integer, lastPage As Integer, totalDurationMinutes As Integer) As Boolean
        Dim query As String = "
    INSERT INTO userbookprogress (UserId, BookId, LastPage, ReadDuration, LastOpened)
    VALUES (@userId, @bookId, @lastPage, @duration, NOW())
    ON DUPLICATE KEY UPDATE
        LastPage = @lastPage,
        ReadDuration = @duration,
        LastOpened = NOW();"

        Dim parameters As New Dictionary(Of String, Object) From {
        {"@userId", userId},
        {"@bookId", bookId},
        {"@lastPage", lastPage},
        {"@duration", totalDurationMinutes}
    }

        Dim result = ExecuteNonQueryWithParams(query, parameters)
        Return result > 0
    End Function

    ' Get reading progress
    Public Function GetReadingProgress(userId As Integer, bookId As Integer) As DataRow
        Dim query As String = "SELECT LastPage, ReadDuration, LastOpened FROM userbookprogress 
                           WHERE UserId = @userId AND BookId = @bookId"

        Dim parameters As New Dictionary(Of String, Object) From {
            {"@userId", userId},
            {"@bookId", bookId}
        }

        Dim dt = ExecuteQueryWithParams(query, parameters)
        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
            Return dt.Rows(0)
        End If

        Return Nothing
    End Function

    ' Create user session
    Public Function CreateUserSession(userId As Integer) As String
        Dim sessionId = Guid.NewGuid().ToString()
        Dim query As String = "INSERT INTO usersessions (SessionId, UserId) VALUES (@sessionId, @userId)"

        Dim parameters As New Dictionary(Of String, Object) From {
            {"@sessionId", sessionId},
            {"@userId", userId}
        }

        Dim result = ExecuteNonQueryWithParams(query, parameters)
        If result > 0 Then
            Return sessionId
        End If

        Return Nothing
    End Function

    ' End user session
    Public Function EndUserSession(sessionId As String) As Boolean
        Dim query As String = "UPDATE usersessions SET IsActive = 0 WHERE SessionId = @sessionId"

        Dim parameters As New Dictionary(Of String, Object) From {
            {"@sessionId", sessionId}
        }

        Dim result = ExecuteNonQueryWithParams(query, parameters)
        Return result > 0
    End Function

    ' Get active session
    Public Function GetActiveSession(userId As Integer) As DataTable
        Dim query As String = "SELECT SessionId FROM usersessions 
                       WHERE UserId = @userId AND IsActive = 1 
                       ORDER BY LastActivity DESC LIMIT 1"

        Dim parameters As New Dictionary(Of String, Object) From {
            {"@userId", userId}
        }

        Return ExecuteQueryWithParams(query, parameters)
    End Function

    ' Update session activity
    Public Function UpdateSessionActivity(sessionId As String) As Boolean
        Dim query As String = "UPDATE usersessions SET LastActivity = NOW() WHERE SessionId = @sessionId"

        Dim parameters As New Dictionary(Of String, Object) From {
            {"@sessionId", sessionId}
        }

        Dim result = ExecuteNonQueryWithParams(query, parameters)
        Return result > 0
    End Function

    ' Create persistent session
    Public Function CreatePersistentSession(userId As Integer) As String
        Dim sessionId = Guid.NewGuid().ToString()
        Dim expiryDate = DateTime.Now.AddMonths(1) ' 1 bulan masa berlaku

        Dim query As String = "INSERT INTO usersessions 
                        (SessionId, UserId, LoginTime, ExpiryTime, LastActivity, IsActive, IsPersistent) 
                        VALUES (@sessionId, @userId, NOW(), @expiryDate, NOW(), 1, 1)"

        Dim parameters As New Dictionary(Of String, Object) From {
            {"@sessionId", sessionId},
            {"@userId", userId},
            {"@expiryDate", expiryDate}
        }

        Dim result = ExecuteNonQueryWithParams(query, parameters)
        If result > 0 Then
            Return sessionId
        End If

        Return Nothing
    End Function

    ' Validate persistent session
    Public Function ValidatePersistentSession(sessionId As String) As DataTable
        Dim query As String = "SELECT u.UserId, u.Username FROM usersessions s 
                   JOIN users u ON s.UserId = u.UserId
                   WHERE s.SessionId = @sessionId 
                   AND s.IsActive = 1 
                   AND s.IsPersistent = 1
                   AND s.ExpiryTime > NOW()"

        Dim parameters As New Dictionary(Of String, Object) From {
            {"@sessionId", sessionId}
        }

        Return ExecuteQueryWithParams(query, parameters)
    End Function

    ' Get user profile
    Public Function GetUserProfile(userId As Integer) As DataTable
        Dim query As String = "SELECT Username, Email, Password FROM users WHERE UserID = @UserId"

        Dim parameters As New Dictionary(Of String, Object) From {
            {"@UserId", userId}
        }

        Return ExecuteQueryWithParams(query, parameters)
    End Function
End Class