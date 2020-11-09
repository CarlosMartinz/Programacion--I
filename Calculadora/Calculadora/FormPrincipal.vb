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

    Private Sub FormPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Dim objReservacion As New FormReservaciones
        objReservacion.MdiParent = Me
        objReservacion.Show()
    End Sub

    Private Sub btnAgregarCliente_Click(sender As Object, e As EventArgs)
        Dim objReservacion As New FormClientes
        objReservacion.MdiParent = Me
        objReservacion.Show()
    End Sub
End Class