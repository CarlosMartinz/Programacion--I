Public Class FormBusquedaUsuarios
    Dim objConexion As New db_conexion
    Public _idU As Integer
    Private Sub btnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
        SeleccionUsuario()
    End Sub
    Private Sub FormBusquedaUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grdBuscarUsuario.DataSource = objConexion.obtenerDatosUsuarios().Tables("Usuarios").DefaultView
    End Sub
    Private Sub txtBuscar_KeyUp(sender As Object, e As KeyEventArgs) Handles txtBuscar.KeyUp
        FiltrarDatosUsuario(txtBuscar.Text)
        If e.KeyCode = 13 Then
            SeleccionUsuario()
        End If
    End Sub
    Private Sub SeleccionUsuario()
        _idU = grdBuscarUsuario.CurrentRow.Cells("idUsuario").Value.ToString()
        Close()
    End Sub

    Private Sub FiltrarDatosUsuario(ByVal Valor As String)
        Dim bs As New BindingSource()
        bs.DataSource = grdBuscarUsuario.DataSource
        bs.Filter = "Nombre like '%" & Valor & "%' or DUI like '%" & Valor & "%' or Telefono like '%" & Valor & "%' or Email like'%" & Valor & "%' or Acceso like '%" & Valor & "%' or Usuario like '%" & Valor & "%' or Password like '%" & Valor & "%'"
        grdBuscarUsuario.DataSource = bs
    End Sub
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        _idU = 0
        Close()
    End Sub
End Class