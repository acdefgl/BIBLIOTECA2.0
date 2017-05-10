Imports MySql.Data.MySqlClient
Public Class Form1
    Dim da As MySqlDataAdapter
    Dim dt As DataTable
    Dim Datos As DataSet
    Dim sql As String
    Dim usuario, clave As String
    Dim Lista As Byte

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Login()

    End Sub
    Private Sub Login()
        usuario = TextBox1.Text
        clave = TextBox2.Text

        If usuario <> "" And clave <> "" Then
            sql = "select * from lector where Usuario='" & usuario & "' 'and Clave='" & clave & "'"
            da = New MySqlDataAdapter(sql, conexion)
            Datos = New DataSet
            da.Fill(Datos, "lector")
            Lista = Datos.Tables("lector").Rows.Count
        End If
        If Lista <> 0 Then
            Form2.Show()
            Me.Hide()
        Else
            MsgBox("Incorrecto")
        End If
    End Sub
    Private Sub login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

End Class


