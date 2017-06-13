Imports System.Data.SQLite

Public Class Control
    'Const conex As String = "Data source=ControlTPV.sqlite;Version=3;Compress=True;"
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Cerrar()
    End Sub
    Sub Cerrar()
        Close()
        '        Clientes.ShowDialog()
    End Sub
    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        abreCtl()
        'Me.Close()
        'Clientes.Show()
    End Sub
    Sub abreCtl()
        Dim client As New Clientes()
        client.MdiParent = Me
        client.Show()
        client.WindowState = FormWindowState.Maximized
    End Sub
End Class
