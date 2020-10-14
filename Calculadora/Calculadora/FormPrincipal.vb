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
End Class