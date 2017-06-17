Imports System.Data.SQLite
Public Class cmdUsr
    Const sql As String = "Data Source=ControlTPV.sqlite;Version=3;cache=shared;"
    Dim conn As New SQLiteConnection(sql)
    Dim comm As New SQLiteCommand
    'Dim sal As New SQLiteConnection
    Sub pruebaDB()
        REM checamos conexion a sqlite
        Try
            REM Abrimos nuestro conexion con la propiedad Open
            conn.Open()
            MsgBox("Conexión realizada de manera exitosa", MsgBoxStyle.Information, "Mesaje de texto en la barra del marco")
            REM Y cerramos la conexion
            conn.Close()
        Catch ex As Exception
            MsgBox("No se logro la conexión po: " & ex.Message, MsgBoxStyle.Critical, "Otro en el marco")
        End Try
    End Sub
    REM ESTE ES QUIEN ORDENA LOS DATOS EN EL GRID CON LA INFORMACION QUE RECIVE DEL FORM
    Sub usrBusqueda(ByVal Tabla As DataGridView, ByVal Sql As String) REM aqui recivo los parametros y los asigno
        conn.Open()
        Try
        Dim da As New SQLiteDataAdapter(Sql, conn)
            Dim dt As New DataTable
            da.Fill(dt)
            Tabla.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
        conn.Close()
        conn.ClearCachedSettings()
        '        conn.Dispose()
        SQLiteConnection.ClearPool(conn)
    End Sub
    REM TERMINA LA MUESTRA DEL GRID DE DATOS
    REM AHORA INICIAMOS CON LOS DE MODIFICACION, CREACION O ELIMINACION DE USUARIOS
    Sub usrModGuardar(ByRef Sql As String)
        Try
            SQLiteConnection.ClearPool(conn)

            conn.Open()
            comm = conn.CreateCommand()
            comm.CommandText = (Sql)
            comm.ExecuteNonQuery()
            '            MsgBox("Datos ingresados correctamente", MsgBoxStyle.Information, "Estado de Creacion")
            conn.Close()

            conn.Dispose()
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
        '   Dim a As TextBox
    End Sub
    Sub usrClkMod(ByRef sql As String)
        Dim cmd As New frmUsrMod
        '        Dim envio As SQLiteCommand
        Try
            conn.Open()
            comm = conn.CreateCommand()
            comm.CommandText = (sql)
            comm.ExecuteNonQuery()
            Dim lec As SQLiteDataReader = comm.ExecuteReader()
            'cmd.usrPonDts(ByVal id As String, ByVal usuario As String, ByVal password As String, ByVal nombre As String, ByVal correo As String)
            'cmd.usrPonDts(id Is Integer, usuario Is String, password Is String, nombre Is String, correo Is String)
            '            cmd.usrPonDts(envio.("id"), envio.("usuario"), envio.("password"), envio.("nombre"), envio.("correo"), envio.("activo"))
            If lec.Read = True Then
                cmd.usrPonDts(CStr(lec("id").ToString), lec("usuario").ToString, lec("password").ToString, lec("nombre").ToString, lec("correo").ToString)
                SQLiteConnection.ClearPool(conn)

            End If
            conn.Close()
            SQLiteConnection.ClearPool(conn)
            '            conn.Dispose()
            '            cmd.usrPonDts("usuario")
            cmd.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub
    Sub Limpiar()   REM ESTE PARA LIMPIAR LOS CAMPOS
        frmUsrMod.txtUsrUsr.Clear()
        frmUsrMod.txtUsrMail.Clear()
        frmUsrMod.txtUsrNom.Clear()
        frmUsrMod.txtUsrPass.Clear()
        frmUsrMod.chkUsrAct.Checked = True
    End Sub
    REM https://stackoverflow.com/questions/6021779/how-do-you-completely-close-an-sqlconnection-string-in-vb-net
End Class

