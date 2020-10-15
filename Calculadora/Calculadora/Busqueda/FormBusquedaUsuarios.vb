Public Class FormBusquedaUsuarios
    Dim objConexion As New db_conexion
    Public idU As Integer
    Private Sub FormBusquedaUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grdBuscarUsuario.DataSource = objConexion.obtenerDatosUsuarios().Tables("Usuarios").DefaultView
    End Sub

    Private Sub btnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
        SeleccionUsuario()
    End Sub
    Private Sub SeleccionUsuario()
        idU = grdBuscarUsuario.CurrentRow.Cells("idUsuario").Value.ToString()
        Close()
    End Sub

    Private Sub FiltrarDatosUsuario(ByVal Valor As String)
        Dim bs As BindingSource
        bs.DataSource = grdBuscarUsuario.DataSource
        bs.Filter = "idUsuario like '%" & Valor & "%' or Nombre like '%" & Valor & "%'"
        grdBuscarUsuario.DataSource = bs
    End Sub

    Private Sub txtBuscar_KeyUp(sender As Object, e As KeyEventArgs) Handles txtBuscar.KeyUp
        FiltrarDatosUsuario(txtBuscar.Text)
        If e.KeyCode = 13 Then
            SeleccionUsuario()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        idU = 0
        Close()
    End Sub
End Class