Public Class FormBusquedaEdificio
    Dim objConexion As New db_conexion
    Public _idEdificio As String
    Private Sub FormBusquedaEdificio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grdBuscarEdificio.DataSource = objConexion.obtenerDatosTablas.Tables("Edificio").DefaultView
    End Sub

    Sub Seleccionar()
        _idEdificio = grdBuscarEdificio.CurrentRow.Cells("Edificio").Value.ToString()
        Close()
    End Sub

    Sub FiltrarDatosEdificio(ByVal valor As String)
        Dim bs As New BindingSource()
        bs.DataSource = grdBuscarEdificio.DataSource
        bs.Filter = "Edificio like '%" & valor & "%'"
        grdBuscarEdificio.DataSource = bs
    End Sub

    Private Sub txtBuscar_KeyUp(sender As Object, e As KeyEventArgs) Handles txtBuscar.KeyUp
        FiltrarDatosEdificio(txtBuscar.Text)
        If e.KeyCode = 13 Then
            Seleccionar()
        End If
    End Sub

    Private Sub btnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
        Seleccionar()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        _idEdificio = ""
        Close()
    End Sub
End Class