﻿

Imports System.IO
Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text


Public Class DBConnection
    Private conn As MySqlConnection
    Private ReadOnly strConn As String = "server=localhost;userid=root;password=;database=readnest"

    Public Sub New()
        conn = New MySqlConnection(strConn)
    End Sub

    Public Function BukaKoneksi() As MySqlConnection
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            Return conn
        Catch ex As Exception
            MessageBox.Show("Koneksi Gagal: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function

    Public Sub TutupKoneksi()
        Try
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Gagal Menutup Koneksi: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

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
            MessageBox.Show("Error enkripsi: " & ex.Message, "Enkripsi Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function

    Public Function EksekusiQuery(query As String) As DataTable
        Try
            Dim dt As New DataTable()
            Using cmd As New MySqlCommand(query, BukaKoneksi())
                Using da As New MySqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using
            TutupKoneksi()
            Return dt
        Catch ex As Exception
            MessageBox.Show("Query Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function

    Public Function EksekusiNonQuery(query As String) As Integer
        Try
            Using cmd As New MySqlCommand(query, BukaKoneksi())
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                TutupKoneksi()
                Return rowsAffected
            End Using
        Catch ex As Exception
            MessageBox.Show("Query Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return -1
        End Try
    End Function

    Public Function CekLogin(username As String, password As String) As DataTable
        Try
            Dim encryptedPassword As String = EncryptPassword(password)

            Dim query As String = "SELECT UserId, Username FROM users WHERE username=@username AND password=@password"
            Dim dt As New DataTable()
            Using cmd As New MySqlCommand(query, BukaKoneksi())
                cmd.Parameters.AddWithValue("@username", username)
                cmd.Parameters.AddWithValue("@password", encryptedPassword)
                Using da As New MySqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using
            Return dt
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        Finally
            TutupKoneksi()
        End Try
    End Function

    Public Function TambahAkun(email As String, username As String, password As String) As Boolean
        Try
            Dim encryptedPassword As String = EncryptPassword(password)

            Dim query As String = "INSERT INTO users (email, username, password) VALUES (@email, @username, @password)"
            Using cmd As New MySqlCommand(query, BukaKoneksi())
                cmd.Parameters.AddWithValue("@email", email)
                cmd.Parameters.AddWithValue("@username", username)
                cmd.Parameters.AddWithValue("@password", encryptedPassword)
                Dim hasil As Integer = cmd.ExecuteNonQuery()
                Return hasil > 0
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Registrasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            TutupKoneksi()
        End Try
        Return False
    End Function

    Public Function CekEmailTerdaftar(email As String) As Boolean
        Try
            Dim query As String = "SELECT COUNT(*) FROM users WHERE email = @email"
            Using cmd As New MySqlCommand(query, BukaKoneksi())
                cmd.Parameters.AddWithValue("@email", email)
                Dim count = Convert.ToInt32(cmd.ExecuteScalar())
                Return count > 0
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            TutupKoneksi()
        End Try
    End Function

    Public Function CekUsernameTerdaftar(username As String) As Boolean
        Try
            Dim query As String = "SELECT COUNT(*) FROM users WHERE username = @username"
            Using cmd As New MySqlCommand(query, BukaKoneksi())
                cmd.Parameters.AddWithValue("@username", username)
                Dim count = Convert.ToInt32(cmd.ExecuteScalar())
                Return count > 0
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            TutupKoneksi()
        End Try
    End Function

    Public Function TambahBuku(title As String, author As String, categoryId As Integer,
                     pages As Integer, description As String, photoPath As String, filePath As String) As Boolean
        Try
            Dim query As String = "INSERT INTO books (Title, Author, CategoryId, Pages, Description, " &
                             "PhotoPath, FilePath, Status, CreatedAt, ReadDuration, IsFavorite, IsWishlist) " &
                             "VALUES (@title, @author, @categoryId, @pages, @description, " &
                             "@photoPath, @filePath, 'Available', NOW(), 0, 0, 0)"

            Using cmd As New MySqlCommand(query, BukaKoneksi())
                cmd.Parameters.AddWithValue("@title", title)
                cmd.Parameters.AddWithValue("@author", author)
                cmd.Parameters.AddWithValue("@categoryId", If(categoryId = 0, DBNull.Value, categoryId))
                cmd.Parameters.AddWithValue("@pages", pages)
                cmd.Parameters.AddWithValue("@description", description)
                cmd.Parameters.AddWithValue("@photoPath", If(String.IsNullOrEmpty(photoPath), DBNull.Value, photoPath))
                cmd.Parameters.AddWithValue("@filePath", If(String.IsNullOrEmpty(filePath), DBNull.Value, filePath))

                Dim hasil As Integer = cmd.ExecuteNonQuery()
                Return hasil > 0
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Gagal Menambahkan Buku", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            TutupKoneksi()
        End Try
        Return False
    End Function

    Public Function GetCategories() As DataTable
        Dim query As String = "SELECT CategoryId, CategoryName FROM categories ORDER BY CategoryName"
        Return EksekusiQuery(query)
    End Function

    Public Function GetBooks() As DataTable
        Dim query As String = "SELECT BookId, Title, Author, PhotoPath FROM books ORDER BY CreatedAt DESC"
        Return EksekusiQuery(query)
    End Function

    ' Mendapatkan detail buku berdasarkan ID
    Public Function GetBookDetail(bookId As Integer) As DataRow
        Try
            Dim query As String = "SELECT b.BookId, b.Title, b.Author, b.Description, b.Pages, b.PhotoPath, b.FilePath, " &
                                "c.CategoryName, b.Status, b.IsWishlist, b.IsFavorite " &
                                "FROM books b " &
                                "LEFT JOIN categories c ON b.CategoryId = c.CategoryId " &
                                "WHERE b.BookId = @bookId"

            Using cmd As New MySqlCommand(query, BukaKoneksi())
                cmd.Parameters.AddWithValue("@bookId", bookId)

                Using da As New MySqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    da.Fill(dt)

                    If dt.Rows.Count > 0 Then
                        Return dt.Rows(0)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error getting book details: " & ex.Message, "Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            TutupKoneksi()
        End Try

        Return Nothing
    End Function

    ' Update status wishlist buku
    Public Function UpdateBookWishlist(bookId As Integer) As Boolean
        Try
            Dim query As String = "UPDATE books SET IsWishlist = NOT IsWishlist WHERE BookId = @bookId"

            Using cmd As New MySqlCommand(query, BukaKoneksi())
                cmd.Parameters.AddWithValue("@bookId", bookId)
                Dim result As Integer = cmd.ExecuteNonQuery()
                Return result > 0
            End Using
        Catch ex As Exception
            MessageBox.Show("Error updating wishlist: " & ex.Message, "Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            TutupKoneksi()
        End Try
    End Function

    ' Update status favorite buku
    Public Function UpdateBookFavorite(bookId As Integer) As Boolean
        Try
            Dim query As String = "UPDATE books SET IsFavorite = NOT IsFavorite WHERE BookId = @bookId"

            Using cmd As New MySqlCommand(query, BukaKoneksi())
                cmd.Parameters.AddWithValue("@bookId", bookId)
                Dim result As Integer = cmd.ExecuteNonQuery()
                Return result > 0
            End Using
        Catch ex As Exception
            MessageBox.Show("Error updating favorite status: " & ex.Message, "Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            TutupKoneksi()
        End Try
    End Function

    ' Update status pinjam buku
    Public Function BorrowBook(bookId As Integer) As Boolean
        Try
            Dim query As String = "UPDATE books SET Status = 'Borrowed' WHERE BookId = @bookId"

            Using cmd As New MySqlCommand(query, BukaKoneksi())
                cmd.Parameters.AddWithValue("@bookId", bookId)
                Dim result As Integer = cmd.ExecuteNonQuery()
                Return result > 0
            End Using
        Catch ex As Exception
            MessageBox.Show("Error borrowing book: " & ex.Message, "Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            TutupKoneksi()
        End Try
    End Function

    ' Return buku yang dipinjam
    Public Function ReturnBook(bookId As Integer) As Boolean
        Try
            Dim query As String = "UPDATE books SET Status = 'Available' WHERE BookId = @bookId"

            Using cmd As New MySqlCommand(query, BukaKoneksi())
                cmd.Parameters.AddWithValue("@bookId", bookId)
                Dim result As Integer = cmd.ExecuteNonQuery()
                Return result > 0
            End Using
        Catch ex As Exception
            MessageBox.Show("Error returning book: " & ex.Message, "Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            TutupKoneksi()
        End Try
    End Function

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

        If File.Exists(coverPath) Then
            Using tempImage As Image = Image.FromFile(coverPath)
                Return New Bitmap(tempImage)
            End Using
        Else
            Debug.WriteLine($"File not found: {coverPath}")
            Return Nothing
        End If
    End Function

    Public Function UpdateReadingProgress(userId As Integer, bookId As Integer, lastPage As Integer, durationMinutes As Integer) As Boolean
        Try
            Dim query As String = "INSERT INTO userbookprogress (UserId, BookId, LastPage, ReadDuration, LastOpened)
                               VALUES (@userId, @bookId, @lastPage, @duration, NOW())
                               ON DUPLICATE KEY UPDATE
                               LastPage = @lastPage,
                               ReadDuration = ReadDuration + @duration,
                               LastOpened = NOW();"

            Using cmd As New MySqlCommand(query, BukaKoneksi())
                cmd.Parameters.AddWithValue("@userId", userId)
                cmd.Parameters.AddWithValue("@bookId", bookId)
                cmd.Parameters.AddWithValue("@lastPage", lastPage)
                cmd.Parameters.AddWithValue("@duration", durationMinutes)

                Dim result As Integer = cmd.ExecuteNonQuery()
                Return result > 0
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan progress baca: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            TutupKoneksi()
        End Try
    End Function

    Public Function GetReadingProgress(userId As Integer, bookId As Integer) As DataRow
        Try
            Dim query As String = "SELECT LastPage, ReadDuration, LastOpened FROM userbookprogress 
                               WHERE UserId = @userId AND BookId = @bookId"

            Using cmd As New MySqlCommand(query, BukaKoneksi())
                cmd.Parameters.AddWithValue("@userId", userId)
                cmd.Parameters.AddWithValue("@bookId", bookId)

                Using da As New MySqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    da.Fill(dt)

                    If dt.Rows.Count > 0 Then
                        Return dt.Rows(0)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengambil progress baca: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            TutupKoneksi()
        End Try

        Return Nothing
    End Function

    ' Tambahkan di bagian akhir class (sebelum End Class)
    Public Function CreateUserSession(userId As Integer) As String
        Try
            Dim sessionId = Guid.NewGuid().ToString()
            Dim query As String = "INSERT INTO usersessions (SessionId, UserId) VALUES (@sessionId, @userId)"

            Using cmd As New MySqlCommand(query, BukaKoneksi())
                cmd.Parameters.AddWithValue("@sessionId", sessionId)
                cmd.Parameters.AddWithValue("@userId", userId)
                cmd.ExecuteNonQuery()
            End Using

            Return sessionId
        Catch ex As Exception
            MessageBox.Show("Gagal membuat session: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        Finally
            TutupKoneksi()
        End Try
    End Function

    Public Function EndUserSession(sessionId As String) As Boolean
        Try
            Dim query As String = "UPDATE usersessions SET IsActive = 0 WHERE SessionId = @sessionId"

            Using cmd As New MySqlCommand(query, BukaKoneksi())
                cmd.Parameters.AddWithValue("@sessionId", sessionId)
                Dim result = cmd.ExecuteNonQuery()
                Return result > 0
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengakhiri session: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            TutupKoneksi()
        End Try
    End Function

    Public Function GetActiveSession(userId As Integer) As DataTable
        Try
            Dim query As String = "SELECT SessionId FROM usersessions 
                           WHERE UserId = @userId AND IsActive = 1 
                           ORDER BY LastActivity DESC LIMIT 1"

            Using cmd As New MySqlCommand(query, BukaKoneksi())
                cmd.Parameters.AddWithValue("@userId", userId)

                Dim dt As New DataTable()
                Using da As New MySqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
                Return dt
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal memeriksa session: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        Finally
            TutupKoneksi()
        End Try
    End Function

    Public Function UpdateSessionActivity(sessionId As String) As Boolean
        Try
            Dim query As String = "UPDATE usersessions SET LastActivity = NOW() WHERE SessionId = @sessionId"

            Using cmd As New MySqlCommand(query, BukaKoneksi())
                cmd.Parameters.AddWithValue("@sessionId", sessionId)
                Dim result = cmd.ExecuteNonQuery()
                Return result > 0
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal update aktivitas session: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            TutupKoneksi()
        End Try
    End Function

    Public Function CreatePersistentSession(userId As Integer) As String
        Try
            Dim sessionId = Guid.NewGuid().ToString()
            Dim expiryDate = DateTime.Now.AddMonths(1) ' 1 bulan masa berlaku

            Dim query As String = "INSERT INTO usersessions 
                            (SessionId, UserId, LoginTime, ExpiryTime, LastActivity, IsActive, IsPersistent) 
                            VALUES (@sessionId, @userId, NOW(), @expiryDate, NOW(), 1, 1)"

            Using cmd As New MySqlCommand(query, BukaKoneksi())
                cmd.Parameters.AddWithValue("@sessionId", sessionId)
                cmd.Parameters.AddWithValue("@userId", userId)
                cmd.Parameters.AddWithValue("@expiryDate", expiryDate)
                cmd.ExecuteNonQuery()
            End Using

            Return sessionId
        Catch ex As Exception
            MessageBox.Show("Gagal membuat session: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        Finally
            TutupKoneksi()
        End Try
    End Function
    Public Function ValidatePersistentSession(sessionId As String) As DataTable
        Try
            Dim query As String = "SELECT u.UserId, u.Username FROM usersessions s 
                       JOIN users u ON s.UserId = u.UserId
                       WHERE s.SessionId = @sessionId 
                       AND s.IsActive = 1 
                       AND s.IsPersistent = 1
                       AND s.ExpiryTime > NOW()"

            Using cmd As New MySqlCommand(query, BukaKoneksi())
                cmd.Parameters.AddWithValue("@sessionId", sessionId)

                Dim dt As New DataTable()
                Using da As New MySqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
                Return dt
            End Using
        Catch ex As Exception
            Return Nothing
        Finally
            TutupKoneksi()
        End Try
    End Function
End Class
