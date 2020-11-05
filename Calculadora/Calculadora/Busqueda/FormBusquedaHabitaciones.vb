Public Class FormBusquedaHabitaciones
    Dim objConexion As New db_conexion
    Public _idHabit As String
    Private Sub FormBusquedaHabitaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grdBuscarHabit.DataSource = objConexion.obtenerDatosTablas.Tables("Habitaciones").DefaultView()
    End Sub

    Private Sub SeleccionTipoHabit()
        _idHabit = grdBuscarHabit.CurrentRow.Cells("idHabitaciones").Value.ToString()
        Close()
    End Sub

    Private Sub FiltrarDatosHabit(ByVal Valor As String)
        Dim bs As New BindingSource()
        bs.DataSource = grdBuscarHabit.DataSource
        bs.Filter = "Codigo like '%" & Valor & "%' or Edificio like '%" & Valor & "%' or idTipo like '%" & Valor & "%'"
        grdBuscarHabit.DataSource = bs
    End Sub

    Private Sub txtBuscar_KeyUp(sender As Object, e As KeyEventArgs) Handles txtBuscar.KeyUp
        FiltrarDatosHabit(txtBuscar.Text)
        If e.KeyCode = 13 Then
            SeleccionTipoHabit()
        End If
    End Sub

    Private Sub btnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
        SeleccionTipoHabit()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        _idHabit = 0
        Close()
    End Sub
End Class