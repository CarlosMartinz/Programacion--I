Public Class FormPrincipal
    Private Sub RegistroDeUsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistroDeUsuariosToolStripMenuItem.Click
        Dim objUsuario As New FormUsuarios
        objUsuario.MdiParent = Me
        objUsuario.Show()
    End Sub
    Private Sub RegistrosDeClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrosDeClientesToolStripMenuItem.Click
        Dim objUsuario As New FormClientes
        objUsuario.MdiParent = Me
        objUsuario.Show()
    End Sub
    Private Sub RegistroDeHabitacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistroDeHabitacionesToolStripMenuItem.Click
        Dim objHabit As New FormHabitaciones
        objHabit.MdiParent = Me
        objHabit.Show()
    End Sub
    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Dim objReservacion As New FormReservaciones
        objReservacion.MdiParent = Me
        objReservacion.Dock = DockStyle.Fill
        objReservacion.Show()
    End Sub
    Private Sub btnAgregarCliente_Click(sender As Object, e As EventArgs)
        Dim objCliente As New FormClientes
        objCliente.MdiParent = Me
        objCliente.Show()
    End Sub

    Private Sub ProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem.Click
        Dim objProductos As New FormProductos
        objProductos.MdiParent = Me
        objProductos.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub ListaHabitacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListaHabitacionesToolStripMenuItem.Click
        Dim objListaHabitaciones As New FormReporteListadoHabitacioens
        objListaHabitaciones.MdiParent = Me
        objListaHabitaciones.Show()
    End Sub

    Private Sub ListaDeClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListaDeClientesToolStripMenuItem.Click
        Dim objListaClientes As New FormListaClienntes
        objListaClientes.MdiParent = Me
        objListaClientes.Show()
    End Sub

    Private Sub ListaEmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListaEmpleadosToolStripMenuItem.Click
        Dim objListaEmpleados As New FormListaEmpleados
        objListaEmpleados.MdiParent = Me
        objListaEmpleados.Show()
    End Sub

    Private Sub ReservacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReservacionesToolStripMenuItem.Click
        Dim objListaReservaciones As New FormReportReservaciones
        objListaReservaciones.MdiParent = Me
        objListaReservaciones.Show()
    End Sub

    Private Sub VentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentasToolStripMenuItem.Click
        Dim objVentas As New FormReportVentas
        objVentas.MdiParent = Me
        objVentas.Show()
    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem.Click
        Dim objUsuarios As New FormReportUsuarios
        objUsuarios.MdiParent = Me
        objUsuarios.Show()
    End Sub

    Private Sub ListaDeProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListaDeProductosToolStripMenuItem.Click
        Dim objProductos As New FormReporProductos
        objProductos.MdiParent = Me
        objProductos.Show()
    End Sub

    Private Sub TiposDeFacturasPorClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TiposDeFacturasPorClientesToolStripMenuItem.Click
        Dim objFactura As New FormReporFacturaClientes
        objFactura.MdiParent = Me
        objFactura.Show()
    End Sub
End Class