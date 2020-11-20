Public Class FormBusquedaTipoHabitaciones
    Dim objConexion As New db_conexion
    Public _idTipoHabit As String

    Private Sub FormBusquedaTipoHabitaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grdBuscarTipoHabit.DataSource = objConexion.obtenerDatosTablas.Tables("TipoHabit").DefaultView()
    End Sub
    Private Sub SeleccionTipoHabit()
        _idTipoHabit = grdBuscarTipoHabit.CurrentRow.Cells("idTipo").Value.ToString()
        Close()
    End Sub
    Private Sub FiltrarDatosUsuario(ByVal Valor As String)
        Dim bs As New BindingSource()
        bs.DataSource = grdBuscarTipoHabit.DataSource
        bs.Filter = "idTipo like '%" & Valor & "%' or Capacidad like '%" & Valor & "%' or Precio like '%" & Valor & "%'"
        grdBuscarTipoHabit.DataSource = bs
    End Sub

    Private Sub txtBuscar_KeyUp(sender As Object, e As KeyEventArgs) Handles txtBuscar.KeyUp
        FiltrarDatosUsuario(txtBuscar.Text)
        If e.KeyCode = 13 Then
            SeleccionTipoHabit()
        End If
    End Sub

    Private Sub btnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
        SeleccionTipoHabit()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        _idTipoHabit = ""
        Close()
    End Sub
End Class