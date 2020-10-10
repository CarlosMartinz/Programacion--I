Public Class FormPrincipal

    Private Sub RegistrarUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarUsuarioToolStripMenuItem.Click
        Dim form As New FormRegistroUsuario
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub RegistroDeReservacionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistroDeReservacionToolStripMenuItem.Click
        Dim objReservacion As New FormReservacion
        objReservacion.ShowDialog()
    End Sub

    Private Sub CerrarSesionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesionToolStripMenuItem.Click
        Close()
    End Sub
End Class
