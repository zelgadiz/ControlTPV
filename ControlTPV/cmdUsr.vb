Imports System.Data.SQLite
Public Class cmdUsr
    Const sql As String = "Data Source=ControlTPV.sqlite;Version=3;"
    Dim conn As New SQLiteConnection(sql)
    Dim comm As New SQLiteCommand

    Sub pruebaDB()
        REM checamos conexion a sqlite
        Try
            REM Abrimos nuestro conexion con la propiedad Open
            conn.Open()
            MsgBox("Conexión realizada de manera exitosa", MsgBoxStyle.Information, "Mnesaje de texto en la barra del marco")
            REM Y cerramos la conexion
            conn.Close()
        Catch ex As Exception
            MsgBox("No se logro la conexión po: " & ex.Message, MsgBoxStyle.Critical, "Otro en el marco")
        End Try
    End Sub
    REM ESTE ES QUIEN ORDENA LOS DATOS EN EL GRID CON LA INFORMACION QUE RECIVE DEL FORM
    Sub usrBusqueda(ByVal Tabla As DataGridView, ByVal Sql As String) REM aqui recivo los parametros y los asigno
        Try
            Dim da As New SQLiteDataAdapter(Sql, conn)
            Dim dt As New DataTable
            da.Fill(dt)
            Tabla.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub
    REM TERMINA LA MUESTRA DEL GRID DE DATOS
    REM AHORA INICIAMOS CON LOS DE MODIFICACION, CREACION O ELIMINACION DE USUARIOS
    Sub usrModGuardar(ByRef Sql As String)
        Try
            conn.Open()
            comm = conn.CreateCommand()
            comm.CommandText = (Sql)
            comm.ExecuteNonQuery()
            MsgBox("Datos correctos")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try

    End Sub
End Class

