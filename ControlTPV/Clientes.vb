Public Class Clientes
    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TesToolStripMenuItem.Click
        Call Cerrar()
    End Sub
    Sub Cerrar()
        Close()
    End Sub
End Class