Public Class FormPrincipal
    Private Sub RegistroDeUsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistroDeUsuariosToolStripMenuItem.Click
        Dim objReservacion As New FormUsuarios
        objReservacion.MdiParent = Me
        objReservacion.Show()
    End Sub

    Private Sub RegistrosDeClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrosDeClientesToolStripMenuItem.Click
        Dim objReservacion As New FormClientes
        objReservacion.MdiParent = Me
        objReservacion.Show()
    End Sub

    Private Sub RegistroDeHabitacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistroDeHabitacionesToolStripMenuItem.Click
        Dim objReservacion As New FormHabitaciones
        objReservacion.MdiParent = Me
        objReservacion.Show()
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        pnlReservacion.Visible = False
    End Sub

    Private Sub FormPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlReservacion.Visible = False
        desabilitar()
    End Sub

    Sub desabilitar()
        btnBuscarCliente.Enabled = False
        btnEditar.Enabled = True
        btnAgregar.Enabled = True
        btnCancelar.Enabled = True
    End Sub


    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        pnlReservacion.Visible = True
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        btnBuscarCliente.Enabled = True
    End Sub

End Class