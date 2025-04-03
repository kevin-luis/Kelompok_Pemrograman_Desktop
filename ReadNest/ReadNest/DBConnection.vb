
Imports MySql.Data.MySqlClient

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

    Public Function CekLogin(username As String, password As String) As Boolean
        Try
            Dim query As String = "SELECT * FROM users WHERE username=@username AND password=@password"
            Using cmd As New MySqlCommand(query, BukaKoneksi())
                cmd.Parameters.AddWithValue("@username", username)
                cmd.Parameters.AddWithValue("@password", password)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.HasRows Then
                        Return True
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            TutupKoneksi()
        End Try
        Return False
    End Function

    Public Function TambahAkun(email As String, username As String, password As String) As Boolean
        Try
            Dim query As String = "INSERT INTO users (email, username, password) VALUES (@email, @username, @password)"
            Using cmd As New MySqlCommand(query, BukaKoneksi())
                cmd.Parameters.AddWithValue("@email", email)
                cmd.Parameters.AddWithValue("@username", username)
                cmd.Parameters.AddWithValue("@password", password)
                Dim hasil As Integer = cmd.ExecuteNonQuery()
                Return hasil > 0 ' True jika berhasil
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
                         pages As Integer, description As String, photoPath As String) As Boolean
        Try
            Dim query As String = "INSERT INTO books (Title, Author, CategoryId, Pages, Description, " &
                                 "PhotoPath, Status, CreatedAt, ReadDuration, IsFavorite, IsWishlist) " &
                                 "VALUES (@title, @author, @categoryId, @pages, @description, " &
                                 "@photoPath, 'Available', NOW(), 0, 0, 0)"

            Using cmd As New MySqlCommand(query, BukaKoneksi())
                cmd.Parameters.AddWithValue("@title", title)
                cmd.Parameters.AddWithValue("@author", author)
                cmd.Parameters.AddWithValue("@categoryId", If(categoryId = 0, DBNull.Value, categoryId))
                cmd.Parameters.AddWithValue("@pages", pages)
                cmd.Parameters.AddWithValue("@description", description)
                cmd.Parameters.AddWithValue("@photoPath", If(String.IsNullOrEmpty(photoPath), DBNull.Value, photoPath))

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

End Class
