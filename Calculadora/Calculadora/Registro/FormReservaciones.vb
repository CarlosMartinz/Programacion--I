Public Class FormReservaciones
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs)
        Close()
    End Sub
    Sub desabilitar()
        btnBuscarCliente.Enabled = False
        'btnAgregarCliente.Visible = False
        'btnEditar.Enabled = True
        btnAgregar.Enabled = True
        btnCancelar.Enabled = True
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        btnBuscarCliente.Enabled = True
        'btnAgregarCliente.Visible = True
    End Sub
    Private Sub btnBuscarCliente_Click(sender As Object, e As EventArgs) Handles btnBuscarCliente.Click
        pnlBucar.Visible = True
    End Sub

    Private Sub FormReservaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlBucar.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        pnlBucar.Visible = False
    End Sub

    Private Sub btnAgregarCliente_Click(sender As Object, e As EventArgs)
        Dim objUsuario As New FormClientes
        objUsuario.MdiParent = Me
        objUsuario.Show()
    End Sub
End Class