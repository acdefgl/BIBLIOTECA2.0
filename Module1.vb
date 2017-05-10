
Imports MySql.Data
Imports MySql.Data.MySqlClient

Module Biblioteca
    Public conexion As New MySqlConnection

    Public Sub ConectarSql()
        Try
            conexion.ConnectionString = "server=localhost;user id=root; password=''; database = dbbiblioteca"
            conexion.Open()
            MessageBox.Show("conectado")
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub
End Module

