Public Class FormBusquedaUsuarios
    Dim objConexion As New db_conexion

    Private Sub FormBusquedaUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grdBuscarUsuario.DataSource = objConexion.obtenerDatosUsuarios().Tables("Usuarios").DefaultView
    End Sub
End Class