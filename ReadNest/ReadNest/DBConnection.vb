﻿Imports System.IO
Imports System.Data.SQLite
Imports System.Security.Cryptography
Imports System.Text

Public Class DBConnection
    Private ReadOnly strConn As String = "Data Source=readnest.db;Version=3;"
    Private ReadOnly connectionProvider As Func(Of SQLiteConnection) = Function() New SQLiteConnection(strConn)

    Private Function HandleError(ex As Exception, message As String) As Boolean
        MessageBox.Show($"{message}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return False
    End Function

    Private Function WithConnection(Of T)(action As Func(Of SQLiteConnection, T)) As T
        Using conn As New SQLiteConnection(strConn)
            Try
                conn.Open()
                Return action(conn)
            Catch ex As Exception
                HandleError(ex, "Database operation failed")
                Return Nothing
            End Try
        End Using
    End Function

    Public Function ExecuteNonQueryWithParams(query As String, parameters As Dictionary(Of String, Object)) As Integer
        Return WithConnection(Function(conn)
                                  Using cmd As New SQLiteCommand(query, conn)
                                      For Each param In parameters
                                          cmd.Parameters.AddWithValue(param.Key, If(param.Value Is Nothing, DBNull.Value, param.Value))
                                      Next
                                      Return cmd.ExecuteNonQuery()
                                  End Using
                              End Function)
    End Function

    Public Function ExecuteQueryWithParams(query As String, parameters As Dictionary(Of String, Object)) As DataTable
        Return WithConnection(Function(conn)
                                  Dim dt As New DataTable()
                                  Using cmd As New SQLiteCommand(query, conn)
                                      For Each param In parameters
                                          cmd.Parameters.AddWithValue(param.Key, If(param.Value Is Nothing, DBNull.Value, param.Value))
                                      Next
                                      Using da As New SQLiteDataAdapter(cmd)
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
                                  Using cmd As New SQLiteCommand(query, conn)
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
                                  Using cmd As New SQLiteCommand(query, conn)
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
              "@photoPath, @filePath, 'Available', datetime('now'), 0, 0, 0)"

        Dim parameters As New Dictionary(Of String, Object) From {
        {"@userId", userId},
        {"@title", title},
        {"@author", author},
        {"@categoryId", If(categoryId = 0, DBNull.Value, categoryId)},
        {"@pages", pages},
        {"@description", description},
        {"@photoPath", If(String.IsNullOrEmpty(photoPath), DBNull.Value, photoPath)},
        {"@filePath", If(String.IsNullOrEmpty(filePath), DBNull.Value, filePath)}
    }

        Dim result = ExecuteNonQueryWithParams(query, parameters)
        Return result > 0
    End Function

    ' Delete book
    Public Function HapusBuku(bookId As Integer) As Boolean
        Dim query As String = "DELETE FROM books WHERE BookId = @bookId"

        Dim parameters As New Dictionary(Of String, Object) From {
        {"@bookId", bookId}
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

    ' Fungsi ganti status buku
    Public Function UpdateBookStatus(bookId As Integer, status As String) As Boolean
        Dim query As String = "UPDATE books SET Status = @status WHERE BookId = @bookId"
        Dim parameters As New Dictionary(Of String, Object) From {
        {"@bookId", bookId},
        {"@status", status}
    }

        Dim result = ExecuteNonQueryWithParams(query, parameters)
        Return result > 0
    End Function
    Public Function BorrowBook(bookId As Integer) As Boolean
        Return UpdateBookStatus(bookId, "Borrowed")
    End Function

    Public Function ReturnBook(bookId As Integer) As Boolean
        Return UpdateBookStatus(bookId, "Available")
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
    Public Function UpdateReadingProgressAbsolute(userId As Integer, bookId As Integer, lastPage As Integer, readDurationSeconds As Integer, progressPercent As Double) As Boolean
        Dim query As String = "
INSERT INTO userbookprogress (UserId, BookId, LastPage, ReadDuration, ProgressPercent, LastOpened)
VALUES (@userId, @bookId, @lastPage, @duration, @progressPercent, datetime('now'))
ON CONFLICT(UserId, BookId) DO UPDATE SET
    LastPage = excluded.LastPage,
    ReadDuration = excluded.ReadDuration,
    ProgressPercent = excluded.ProgressPercent,
    LastOpened = datetime('now');"

        Dim parameters As New Dictionary(Of String, Object) From {
        {"@userId", userId},
        {"@bookId", bookId},
        {"@lastPage", lastPage},
        {"@duration", readDurationSeconds},
        {"@progressPercent", progressPercent}
    }

        Dim result = ExecuteNonQueryWithParams(query, parameters)
        Return result > 0
    End Function

    ' Get reading progress
    Public Function GetReadingProgress(userId As Integer, bookId As Integer) As DataRow
        Dim query As String = "SELECT LastPage, ReadDuration, ProgressPercent, LastOpened FROM userbookprogress 
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
        Dim currentTime As DateTime = DateTime.Now

        Dim query As String = "UPDATE usersessions SET LastActivity = @currentTime WHERE SessionId = @sessionId"

        Dim parameters As New Dictionary(Of String, Object) From {
        {"@sessionId", sessionId},
        {"@currentTime", currentTime}
    }

        Dim result = ExecuteNonQueryWithParams(query, parameters)
        Return result > 0
    End Function

    Public Function CreatePersistentSession(userId As Integer) As String
        Dim sessionId = Guid.NewGuid().ToString()
        Dim expiryDate = DateTime.Now.AddMonths(1) ' 1 bulan masa berlaku
        Dim loginTime = DateTime.Now
        Dim lastActivity = DateTime.Now

        Dim query As String = "INSERT INTO usersessions 
                        (SessionId, UserId, LoginTime, ExpiryTime, LastActivity, IsActive, IsPersistent) 
                        VALUES (@sessionId, @userId, @loginTime, @expiryDate, @lastActivity, 1, 1)"

        Dim parameters As New Dictionary(Of String, Object) From {
        {"@sessionId", sessionId},
        {"@userId", userId},
        {"@loginTime", loginTime},
        {"@expiryDate", expiryDate},
        {"@lastActivity", lastActivity}
    }

        Dim result = ExecuteNonQueryWithParams(query, parameters)
        If result > 0 Then
            Return sessionId
        Else
            Return Nothing
        End If
    End Function

    ' Validate persistent session
    Public Function ValidatePersistentSession(sessionId As String) As DataTable
        Dim currentTime As DateTime = DateTime.Now

        Dim query As String = "SELECT u.UserId, u.Username FROM usersessions s 
                           JOIN users u ON s.UserId = u.UserId
                           WHERE s.SessionId = @sessionId 
                           AND s.IsActive = 1 
                           AND s.IsPersistent = 1 
                           AND s.ExpiryTime > @currentTime"

        Dim parameters As New Dictionary(Of String, Object) From {
        {"@sessionId", sessionId},
        {"@currentTime", currentTime}
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

    Public Function GetActiveBorrowers(userId As Integer) As DataTable
        Dim query As String = "SELECT b.BookId, b.Title, b.Author, b.PhotoPath, 
                         br.BorrowerId, br.BorrowerName, br.BorrowDate, 
                         br.ReturnDate, br.IsReturned
                         FROM borrowers br
                         JOIN books b ON br.BookId = b.BookId
                         WHERE b.UserId = @userId AND br.IsReturned = 0
                         ORDER BY br.BorrowDate DESC"

        Dim parameters As New Dictionary(Of String, Object) From {
            {"@userId", userId}
        }

        Return ExecuteQueryWithParams(query, parameters)
    End Function

    Public Function MarkBookAsReturned(borrowerId As Integer) As Boolean
        Dim currentTime As DateTime = DateTime.Now
        Dim success As Boolean = True

        ' Query pertama: update status pengembalian
        Dim query1 As String = "UPDATE borrowers SET IsReturned = 1, ReturnDate = @returnDate WHERE BorrowerId = @borrowerId"
        Dim parameters1 As New Dictionary(Of String, Object) From {
        {"@borrowerId", borrowerId},
        {"@returnDate", currentTime}
    }
        Dim result1 = ExecuteNonQueryWithParams(query1, parameters1)
        If result1 <= 0 Then success = False

        ' Query kedua: update status buku jadi "Available"
        Dim query2 As String = "UPDATE books SET Status = 'Available' WHERE BookId = (SELECT BookId FROM borrowers WHERE BorrowerId = @borrowerId)"
        Dim parameters2 As New Dictionary(Of String, Object) From {
        {"@borrowerId", borrowerId}
    }
        Dim result2 = ExecuteNonQueryWithParams(query2, parameters2)
        If result2 <= 0 Then success = False

        Return success
    End Function

    ' Update user profile (username dan email saja)
    Public Function UpdateUserProfile(userId As Integer, username As String, email As String) As Boolean
        Dim query As String = "UPDATE users SET Username = @Username, Email = @Email WHERE UserID = @UserId"

        Dim parameters As New Dictionary(Of String, Object) From {
        {"@Username", username},
        {"@Email", email},
        {"@UserId", userId}
    }

        Dim rowsAffected As Integer = ExecuteNonQueryWithParams(query, parameters)
        Return rowsAffected > 0

        ' Tambahkan method-method ini ke dalam class DBConnection yang sudah ada
    End Function

    ' Get all notes
    Public Function GetNotes() As DataTable
        Dim query As String = "SELECT NoteId, Title, Content, BookId, CreatedDate, ModifiedDate FROM notes ORDER BY NoteId DESC"
        Return ExecuteQueryWithParams(query, New Dictionary(Of String, Object))
    End Function

    ' Get single note by ID
    Public Function GetNoteById(noteId As Integer) As DataRow
        Dim query As String = "SELECT NoteId, Title, Content, BookId, CreatedDate, ModifiedDate FROM notes WHERE NoteId = @NoteId"
        Dim parameters As New Dictionary(Of String, Object) From {
            {"@NoteId", noteId}
        }

        Dim dt = ExecuteQueryWithParams(query, parameters)
        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
            Return dt.Rows(0)
        End If

        Return Nothing
    End Function

    ' Add new note
    Public Function AddNote(title As String, content As String, Optional bookId As String = Nothing) As Boolean
        Dim query As String = "INSERT INTO notes (Title, Content, BookId, CreatedDate) VALUES (@Title, @Content, @BookId, @CreatedDate)"

        Dim parameters As New Dictionary(Of String, Object) From {
        {"@Title", title},
        {"@Content", content},
        {"@BookId", If(String.IsNullOrWhiteSpace(bookId), DBNull.Value, bookId)},
        {"@CreatedDate", DateTime.Now}
    }

        Dim result = ExecuteNonQueryWithParams(query, parameters)
        Return result > 0
    End Function

    ' Update existing note 
    Public Function UpdateNote(noteId As Integer, title As String, content As String, Optional bookId As String = Nothing) As Boolean
        Dim query As String = "UPDATE notes SET Title = @Title, Content = @Content, BookId = @BookId, ModifiedDate = datetime('now') WHERE NoteId = @NoteId"

        Dim parameters As New Dictionary(Of String, Object) From {
        {"@NoteId", noteId},
        {"@Title", title},
        {"@Content", content},
        {"@BookId", If(String.IsNullOrWhiteSpace(bookId), DBNull.Value, bookId)}
    }

        Dim result = ExecuteNonQueryWithParams(query, parameters)
        Return result > 0
    End Function

    ' Delete note
    Public Function DeleteNote(noteId As Integer) As Boolean
        Dim query As String = "DELETE FROM notes WHERE NoteId = @NoteId"

        Dim parameters As New Dictionary(Of String, Object) From {
            {"@NoteId", noteId}
        }

        Dim result = ExecuteNonQueryWithParams(query, parameters)
        Return result > 0
    End Function

    ' Get notes by BookId
    Public Function GetNotesByBookId(bookId As String) As DataTable
        Dim query As String = "SELECT NoteId, Title, Content, BookId, CreatedDate, ModifiedDate FROM notes WHERE BookId = @BookId ORDER BY CreatedDate DESC"

        Dim parameters As New Dictionary(Of String, Object) From {
            {"@BookId", bookId}
        }

        Return ExecuteQueryWithParams(query, parameters)
    End Function

    ' Search notes by title or content
    Public Function SearchNotes(searchTerm As String) As DataTable
        Dim query As String = "SELECT NoteId, Title, Content, BookId, CreatedDate, ModifiedDate FROM notes WHERE Title LIKE @SearchTerm OR Content LIKE @SearchTerm ORDER BY CreatedDate DESC"

        Dim parameters As New Dictionary(Of String, Object) From {
            {"@SearchTerm", "%" & searchTerm & "%"}
        }

        Return ExecuteQueryWithParams(query, parameters)
        Main()
    End Function

    Public Function GetUserStatistics(userId As Integer) As Dictionary(Of String, Integer)
        Dim stats As New Dictionary(Of String, Integer) From {
        {"read", 0},
        {"reading", 0},
        {"borrowed", 0},
        {"favorite", 0},
        {"avgReadingTime", 0}
    }

        Try
            ' Total buku dengan status 'reading' atau 'finished'
            Dim query1 As String = "
            SELECT 
                SUM(CASE WHEN Status IN ('reading', 'finished') THEN 1 ELSE 0 END) AS ReadCount,
                SUM(CASE WHEN IsFavorite = 1 THEN 1 ELSE 0 END) AS FavoriteCount
            FROM books
            WHERE UserId = @userId;"

            Dim parameters1 As New Dictionary(Of String, Object) From {
            {"@userId", userId}
        }

            Dim dt1 = ExecuteQueryWithParams(query1, parameters1)
            If dt1 IsNot Nothing AndAlso dt1.Rows.Count > 0 Then
                stats("read") = If(IsDBNull(dt1.Rows(0)("ReadCount")), 0, Convert.ToInt32(dt1.Rows(0)("ReadCount")))
                stats("favorite") = If(IsDBNull(dt1.Rows(0)("FavoriteCount")), 0, Convert.ToInt32(dt1.Rows(0)("FavoriteCount")))
            End If

            ' Total buku dipinjam oleh user (melalui relasi BookId)
            Dim query2 As String = "
            SELECT COUNT(*) AS BorrowedCount
            FROM borrowers br
            JOIN books b ON br.BookId = b.BookId
            WHERE b.UserId = @userId;"

            Dim dt2 = ExecuteQueryWithParams(query2, parameters1)
            If dt2 IsNot Nothing AndAlso dt2.Rows.Count > 0 Then
                stats("borrowed") = If(IsDBNull(dt2.Rows(0)("BorrowedCount")), 0, Convert.ToInt32(dt2.Rows(0)("BorrowedCount")))
            End If

            ' Total waktu membaca (dalam detik)
            Dim query3 As String = "
            SELECT 
                IFNULL(SUM(ReadDuration), 0) AS TotalReadDuration,
                IFNULL(AVG(ReadDuration), 0) AS AvgReadDuration
            FROM userbookprogress
            WHERE UserId = @userId;"

            Dim dt3 = ExecuteQueryWithParams(query3, parameters1)
            If dt3 IsNot Nothing AndAlso dt3.Rows.Count > 0 Then
                ' Total reading time (semua durasi dalam detik → konversi menit di VB)
                Dim totalSeconds = If(IsDBNull(dt3.Rows(0)("TotalReadDuration")), 0, Convert.ToInt32(dt3.Rows(0)("TotalReadDuration")))
                Dim avgSeconds = If(IsDBNull(dt3.Rows(0)("AvgReadDuration")), 0, Convert.ToInt32(dt3.Rows(0)("AvgReadDuration")))

                stats("reading") = totalSeconds \ 60 ' Konversi ke menit
                stats("avgReadingTime") = avgSeconds \ 60 ' Konversi ke menit
            End If

        Catch ex As Exception
            MessageBox.Show("Error getting statistics: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return stats
    End Function

    ' Get all books with category name
    Public Function GetAllBooksWithDetails() As DataTable
        Dim query As String = "SELECT b.BookId, b.Title, b.Author, c.CategoryName, b.PhotoPath, b.FilePath " &
                              "FROM books b " &
                              "LEFT JOIN categories c ON b.CategoryId = c.CategoryId " &
                              "ORDER BY b.Title"
        ' Tidak memerlukan parameter untuk query ini
        Return ExecuteQueryWithParams(query, New Dictionary(Of String, Object))
    End Function



    ' Get all users (UserId, Username, and Email)
    Public Function GetAllUsers() As DataTable
        ' Modifikasi query untuk menyertakan UserId
        Dim query As String = "SELECT UserId, Username, Email FROM users ORDER BY Username"
        Return ExecuteQueryWithParams(query, New Dictionary(Of String, Object))
    End Function

    ' Delete user by UserId
    Public Function HapusUser(userId As Integer) As Boolean
        ' PENTING: Pertimbangkan apa yang terjadi pada buku atau data lain
        ' yang terkait dengan pengguna ini. Apakah Anda ingin menghapusnya juga (cascade delete)
        ' atau mengatur UserId menjadi NULL, atau mencegah penghapusan jika ada data terkait?
        ' Untuk contoh ini, kita hanya menghapus dari tabel users.
        ' Anda mungkin perlu menghapus sesi pengguna juga jika ada.

        ' Contoh: Hapus sesi persisten pengguna terlebih dahulu jika ada
        Dim deleteSessionsQuery As String = "DELETE FROM usersessions WHERE UserId = @userId"
        Dim sessionParams As New Dictionary(Of String, Object) From {
            {"@userId", userId}
        }
        ExecuteNonQueryWithParams(deleteSessionsQuery, sessionParams) ' Tidak perlu cek hasil untuk ini, usahakan saja

        ' Hapus progres buku pengguna
        Dim deleteProgressQuery As String = "DELETE FROM userbookprogress WHERE UserId = @userId"
        ExecuteNonQueryWithParams(deleteProgressQuery, sessionParams)

        ' Hapus buku yang dimiliki pengguna (jika kebijakan Anda demikian)
        ' Dim deleteUserBooksQuery As String = "DELETE FROM books WHERE UserId = @userId"
        ' ExecuteNonQueryWithParams(deleteUserBooksQuery, sessionParams)
        ' ATAU, jika buku bisa ada tanpa pemilik atau dialihkan:
        ' Dim updateUserBooksQuery As String = "UPDATE books SET UserId = NULL WHERE UserId = @userId" ' Contoh jika UserId bisa NULL
        ' ExecuteNonQueryWithParams(updateUserBooksQuery, sessionParams)


        ' Hapus pengguna dari tabel users
        Dim query As String = "DELETE FROM users WHERE UserId = @userId"
        Dim parameters As New Dictionary(Of String, Object) From {
            {"@userId", userId}
        }
        Dim result = ExecuteNonQueryWithParams(query, parameters)
        Return result > 0
    End Function

End Class