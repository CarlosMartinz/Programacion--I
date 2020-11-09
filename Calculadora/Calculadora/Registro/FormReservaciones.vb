Public Class FormReservaciones
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs)
        Close()
    End Sub
    Sub desabilitar()
        btnBuscarCliente.Enabled = False
        btnAgregarCliente.Visible = False
        btnEditar.Enabled = True
        btnAgregar.Enabled = True
        btnCancelar.Enabled = True
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        btnBuscarCliente.Enabled = True
        btnAgregarCliente.Visible = True
    End Sub

    Private Sub btnAgregarCliente_Click(sender As Object, e As EventArgs) Handles btnAgregarCliente.Click
        Dim objReservacion As New FormClientes
        objReservacion.MdiParent = Me
        objReservacion.Show()
    End Sub
End Class