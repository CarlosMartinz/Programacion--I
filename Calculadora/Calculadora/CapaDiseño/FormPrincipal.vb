Public Class FormPrincipal
    Private Sub RegistrarUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarUsuarioToolStripMenuItem.Click
        Dim form As New FormRegistroUsuario
        form.MdiParent = Me

        form.Show()
    End Sub
End Class
