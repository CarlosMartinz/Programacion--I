Public Class FormBusquedaCategoria
    Dim objConexion As New db_conexion
    Public _idCat As String
    Private Sub FormBusquedaCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grdBuscarCategoria.DataSource = objConexion.obtenerDatosTablas().Tables("Categoria").DefaultView()
    End Sub
End Class