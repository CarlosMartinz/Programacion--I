Public Class FormProductos
    Dim objConexion As New db_conexion
    Dim dataTable As New DataTable
    Dim Accion As String = "nuevo"
    Dim Posicion As Integer = 0

    Private Sub FormProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub ObtenerDatos()
        dataTable = objConexion.obtenerDatosTablas().tables("Producto")
        dataTable.PrimaryKey = New DataColumn() {dataTable.Columns("idProducto")}

        cboCategoria.DataSource = objConexion.obtenerDatosTablas().Tables("Categoria").DefaultView()
        cboCategoria.DisplayMember = "Categoria"
        cboCategoria.ValueMember = "Categoria.idCategoria"

        MostrarDatos()
    End Sub

    Sub MostrarDatos()
        If dataTable.Rows.Count > 0 Then
            Me.Tag = dataTable.Rows(Posicion).ItemArray(0).ToString()
            cboCategoria.SelectedValue = dataTable.Rows(Posicion).ItemArray(1).ToString()
            txtCodigo.Text = dataTable.Rows(Posicion).ItemArray(2).ToString()
            txtDescripcion.Text = dataTable.Rows(Posicion).ItemArray(3).ToString()
            txtPrecio.Text = dataTable.Rows(Posicion).ItemArray(4).ToString()

            lblPosicion.Text = Posicion + 1 & " de " & dataTable.Rows.Count
        Else
            'limpiarDatosUsuarios()
            MessageBox.Show("No hay registros que mostrar", "Registro Productos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class