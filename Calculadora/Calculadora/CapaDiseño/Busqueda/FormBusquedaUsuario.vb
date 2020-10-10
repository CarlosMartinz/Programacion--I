Public Class FormBusquedaUsuario
    Dim objConexion As New db_conexion
    Public _idC As Integer
    Private Sub FormBusquedaUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grdBuscarUsuario.DataSource = objConexion.obtenerDatosUsuarios().Tables("Usuarios").DefaultView
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()
    End Sub
    'Private Sub seleccionarCliente()
    '    _idC = grdBuscarUsuario.CurrentRow.Cells("idUsuario").Value.ToString()
    '    Close()
    'End Sub
End Class