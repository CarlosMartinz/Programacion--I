Public Class FormTipoHabitaciones
    Dim objConexion As New db_conexion()
    Dim dataTable As New DataTable
    Dim posicion As Integer
    Dim accion As String = "nuevo"
    Private Sub FormTipoHabitaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub ObtenerDatos()
        dataTable = objConexion.obtenerDatosUsuarios().Tables("TipoHabit")
        dataTable.PrimaryKey = New DataColumn() {dataTable.Columns("idTipo")}
    End Sub
End Class