Imports System.Data.SQLite
Public Class Clientes
    Const cad_conn As String = "Data Source=ControlTPV.sqlite;Version=3;Compress=True;"

    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TesToolStripMenuItem.Click
        Call Cerrar()
    End Sub
    Sub Cerrar()
        Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call cteGuardar()
    End Sub
    Sub cteGuardar()
        '    Const cad_conn As String = "Data Source=ControlTPV.sqlite;Version=3;"
        Dim objCon As SQLiteConnection
        Dim objComm As SQLiteCommand
        Try
            objCon = New SQLiteConnection(cad_conn)
            objCon.Open()
            objComm = objCon.CreateCommand()
            objComm.CommandText = "INSERT INTO clientes (codigo, nombre, ap_pat, ap_mat, sexo, fec_nac, direc, tel, correo) values ('" + codCliente.Text + "','" + nomCliente.Text + "','" + patCliente.Text + "','" + matCliente.Text + "','" + sexCliente.Text + "','" + DateTimePicker1.Value.Date + "','" + dirCliente.Text + "','" + telCliente.Text + "','" + correoCliente.Text + "');"
            'objComm.CommandText = "CREATE TABLE IF NOT EXISTS prueba (id INTEGER PRIMARY KEY AUTOINCREMENT, nombre VARCHAR(20), apellido VARCHAR(20));"
            'objComm.ExecuteNonQuery()
            'objComm.CommandText = "INSERT INTO prueba (nombre, apellido) values('Rubén', 'Crisanto');"
            objComm.ExecuteNonQuery()
            MsgBox("Datos ingresados correctamente")
        Finally
            If Not IsNothing(objCon) Then
                '   MsgBox("No se pudo ingresar")
                objCon.Close()
            End If

        End Try
    End Sub
End Class