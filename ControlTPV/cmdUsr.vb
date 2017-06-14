Imports System.Data.SQLite
Public Class cmdUsr
    Const sql As String = "Data Source=ControlTPV.sqlite;Version=3;"
    Dim conn As New SQLiteConnection(sql)

    Sub pruebaDB()
        ':::Instruccion Try para capturar errores
        Try
            ':::Abrimos nuestro conexion con la propiedad Open
            conn.Open()
            MsgBox("Conexión realizada de manera exitosa", MsgBoxStyle.Information, "Tutorial CRUD")
            ':::Y cerramos la conexion
            conn.Close()
        Catch ex As Exception
            MsgBox("No se logro realizar la conexión debido: " & ex.Message, MsgBoxStyle.Critical, "Tutorial CRUD")
        End Try
    End Sub
    Sub busqueda(ByVal Tabla As DataGridView, ByVal Sql As String) REM aqui recivo los parametros y los asigno
        Try
            Dim da As New SQLiteDataAdapter(Sql, conn)
            Dim dt As New DataTable
            da.Fill(dt)
            Tabla.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

End Class

