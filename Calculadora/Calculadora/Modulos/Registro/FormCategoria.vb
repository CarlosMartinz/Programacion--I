Public Class FormCategoria
    Dim objConexion As New db_conexion
    Dim dataTable As New DataTable
    Dim Accion As String = "nuevo"
    Dim Posicion As Integer = 0

    Private Sub FormCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ObtenerDatos()
    End Sub

    Sub ObtenerDatos()
        dataTable = objConexion.obtenerDatosTablas().tables("Categoria")
        dataTable.PrimaryKey = New DataColumn() {dataTable.Columns("idCategoria")}

        MostrarDatos()
    End Sub

    Sub MostrarDatos()
        If DataTable.Rows.Count > 0 Then
            Me.Tag = DataTable.Rows(Posicion).ItemArray(0).ToString()
            txtCategoria.Text = dataTable.Rows(Posicion).ItemArray(1).ToString()

            lblPosicion.Text = Posicion + 1 & " de " & DataTable.Rows.Count
        Else
            txtCategoria.Text = ""
            MessageBox.Show("No hay registros que mostrar", "Registro Productos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class