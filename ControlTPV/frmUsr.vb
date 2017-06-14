Imports System.Data.SQLite

Public Class frmUsr
    Dim obj As New cmdUsr

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Call usrCerrar()
    End Sub
    Sub usrCerrar()
        Close()
    End Sub
    Private Sub btnBuscarUsr_Click(sender As Object, e As EventArgs) Handles btnBuscarUsr.Click
        Dim Sql As String = "SELECT usuario as Usuario, nombre as Nombre, correo as Mail, activo as Activo FROM vendedor WHERE usuario = '" + txtUsrBuscar.Text + "';"
        obj.busqueda(DataGridView1, Sql)
    End Sub

    Private Sub btnBuscarNom_Click(sender As Object, e As EventArgs) Handles btnBuscarNom.Click
        Dim Sql As String = "SELECT usuario as Usuario, nombre as Nombre, correo as Mail, activo as Activo FROM vendedor WHERE nombre = '" + txtUsrBuscar.Text + "';"
        obj.busqueda(DataGridView1, Sql)
    End Sub

    Private Sub btnBuscarMail_Click(sender As Object, e As EventArgs) Handles btnBuscarMail.Click
        Dim Sql As String = "SELECT usuario as Usuario, nombre as Nombre, correo as Mail, activo as Activo FROM vendedor WHERE correo = '" + txtUsrBuscar.Text + "';"
        obj.busqueda(DataGridView1, Sql) REM aqui es donde pondre el if radiobotton checked para ver que consusta mandar
        ' https://bytes.com/topic/visual-basic-net/answers/359800-checking-if-any-radio-buttons-checked
    End Sub
End Class