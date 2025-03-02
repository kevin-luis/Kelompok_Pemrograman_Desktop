Imports MySql.Data.MySqlClient
Module DBConnection
    Public conn As MySqlConnection
    Public cmd As MySqlCommand
    Public rd As MySqlDataReader
    Public da As MySqlDataAdapter
    Public str As String

    Sub koneksi()
        Try
            Dim str As String = "Server=localhost;user id=root;password=;database=readnest"
            conn = New MySqlConnection(str)
            If conn.State = ConnectionState.Closed Then
                conn.Open()
                MessageBox.Show("Koneksi Sukses")
            Else
                MessageBox.Show("Koneksi Gagal")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Module
