Public Class frmUsrMod
    Dim cmd As New cmdUsr

    '    Public Sub usrPonDts(ByVal id As Integer, ByVal usuario As String, ByVal password As String, ByVal nombre As String, ByVal correo As String)
    Public Sub usrPonDts(ByVal id As String, ByVal usuario As String, ByVal password As String, ByVal nombre As String, ByVal correo As String)

        lblUsrId.Text = id
        txtUsrUsr.Text = usuario
        txtUsrPass.Text = password
        txtUsrNom.Text = nombre
        txtUsrMail.Text = correo
        'chkUsrAct.Checked = activo
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Call usrModSalir()
    End Sub
    Sub usrModSalir()
        Close()
    End Sub
    REM PUDE HABER PUESTO TRUE O FALSE PARA EL CAMPO DE USUARIO ACTIVO O BAJA Y SERIA MAS FACIL DE GUARDAR
    Private Sub GuardarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem1.Click
        Dim sql As String = "INSERT INTO vendedor (usuario, password, nombre, correo, activo) values('" + txtUsrUsr.Text + "', '" + txtUsrPass.Text + "', '" + txtUsrNom.Text + "', '" + txtUsrPass.Text + "', 1);"
        Dim sql2 As String = "INSERT INTO vendedor (usuario, password, nombre, correo, activo) values('" + txtUsrUsr.Text + "', '" + txtUsrPass.Text + "', '" + txtUsrNom.Text + "', '" + txtUsrPass.Text + "', 0);"
        If chkUsrAct.Checked = True Then
            cmd.usrModGuardar(sql)
        Else
            cmd.usrModGuardar(sql2)
        End If
        cmd.Limpiar()
    End Sub

    Private Sub LimpiarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarToolStripMenuItem.Click
        Call cmd.Limpiar()
    End Sub
End Class