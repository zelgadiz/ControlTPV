Imports System.Data.SQLite

Public Class frmUsr
    Dim obj As New cmdUsr

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Call usrCerrar()
    End Sub
    Sub usrCerrar()
        Close()
    End Sub
    Private Sub btnNuevoUsr_Click(sender As Object, e As EventArgs) Handles btnNuevoUsr.Click
        Call abreUsrMod()
    End Sub
    Sub abreUsrMod()
        frmUsrMod.ShowDialog()
    End Sub
    REM aqui inicio mis envios para busqueda por tipo de dato ingresado
    Private Sub btnBuscarUsr_Click(sender As Object, e As EventArgs) Handles btnBuscarUsr.Click
        Dim Sql As String = "SELECT usuario as Usuario, nombre as Nombre, correo as Mail, activo as Activo FROM vendedor WHERE usuario = '" + txtUsrBuscar.Text + "';"
        Dim Sql2 As String = "SELECT usuario as Usuario, nombre as Nombre, correo as Mail, activo as Activo FROM vendedor WHERE usuario = '" + txtUsrBuscar.Text + "' AND activo = 1 ;"
        If usrBaja.Checked = True Then
            obj.usrBusqueda(DataGridView1, Sql2)
        Else
            obj.usrBusqueda(DataGridView1, Sql)
        End If
    End Sub

    Private Sub btnBuscarNom_Click(sender As Object, e As EventArgs) Handles btnBuscarNom.Click
        Dim Sql As String = "SELECT usuario as Usuario, nombre as Nombre, correo as Mail, activo as Activo FROM vendedor WHERE nombre = '" + txtUsrBuscar.Text + "';"
        Dim Sql2 As String = "SELECT usuario as Usuario, nombre as Nombre, correo as Mail, activo as Activo FROM vendedor WHERE nombre = '" + txtUsrBuscar.Text + "' AND activo = 1 ;"
        If usrBaja.Checked = True Then
            obj.usrBusqueda(DataGridView1, Sql2)
        Else
            obj.usrBusqueda(DataGridView1, Sql)
        End If
    End Sub

    Private Sub btnBuscarMail_Click(sender As Object, e As EventArgs) Handles btnBuscarMail.Click
        Dim Sql As String = "SELECT usuario as Usuario, nombre as Nombre, correo as Mail, activo as Activo FROM vendedor WHERE correo = '" + txtUsrBuscar.Text + "';"
        Dim Sql2 As String = "SELECT usuario as Usuario, nombre as Nombre, correo as Mail, activo as Activo FROM vendedor WHERE correo = '" + txtUsrBuscar.Text + "' AND activo = 1 ;"
        If usrBaja.Checked = True Then
            obj.usrBusqueda(DataGridView1, Sql2) REM aqui es donde pondre el if radiobotton checked para ver que consusta mandar
        Else
            obj.usrBusqueda(DataGridView1, Sql) REM aqui es donde pondre el if radiobotton checked para ver que consusta mandar
            REM ' https://bytes.com/topic/visual-basic-net/answers/359800-checking-if-any-radio-buttons-checked
        End If
    End Sub
    REM SE TERMINAN YA LAS BUSQUEDAS POR TIPO DE DATO CON LA OPCION DE ACTIVO O NO EL USUARIO
    REM AHORA PROCEDO A INICIAR CON LOS DATOS PARA MODIFICAR, CREAR O ELIMINAR EN LOS USUARIOS
    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        '        Dim frmUsrMod As New frmUsrMod REM  CREO QUE ESTE DEBE IR EN CMD DONDE SE MANDA LOS COMANDOS
        Dim linea As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
        '      frmUsrMod.usrPonDts(cs)
        Dim lnl As String = CStr(linea.Cells(0).Value)
        Dim Sql As String = "SELECT * FROM vendedor WHERE usuario = '" + lnl + "';"
        '       frmUsrMod.ShowDialog()
        obj.usrClkMod(Sql)
    End Sub
End Class