Public Class FormHabitaciones
    Dim objConexion As New db_conexion()
    Dim dataTable As New DataTable
    Dim posicion As Integer
    Dim accion As String = "nuevo"
    Sub obtenerDatos()
        'dataTable = objConexion.obtenerDatosUsuarios().Tables("Habitaciones")
        'dataTable.PrimaryKey = New DataColumn() {dataTable.Columns("idHabitaciones")}

        dataTable = objConexion.obtenerDatosUsuarios().Tables("TipoHabitacion")
        dataTable.PrimaryKey = New DataColumn() {dataTable.Columns("codigo")}

        mostrarDatos()
    End Sub
    Sub mostrarDatos()
        If dataTable.Rows.Count > 0 Then
            Me.Tag = dataTable.Rows(posicion).ItemArray(0).ToString() 'ID de tipo de habitacion 
            txtdescripcion.Text = dataTable.Rows(posicion).ItemArray(1).ToString()
            txtcapacidad.Text = dataTable.Rows(posicion).ItemArray(2).ToString()
            txtprecio.Text = dataTable.Rows(posicion).ItemArray(3).ToString()

            lblRegistroHabitaciones.Text = posicion + 1 & " de " & dataTable.Rows.Count
        Else
            limpiarDatosHabitaciones()
            MessageBox.Show("No hay registros que mostrar", "Registro de Productos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub limpiarDatosHabitaciones()
        txtcapacidad.Text = ""
        txtdescripcion.Text = ""
        txtprecio.Text = ""
    End Sub

    Private Sub btnAgregarEdificios_Click(sender As Object, e As EventArgs) Handles btnAgregarEdificios.Click
        If btnAgregarTipHabitacion.Text = "Nuevo" Then 'Nuevo
            btnAgregarTipHabitacion.Text = "Guardar"
            btnModificarTipHabitacion.Text = "Cancelar"
            accion = "nuevo"

            'HabDescontroles(False)
            'limpiarDatosCategoria()
        Else 'Guardar
            Dim msg = objConexion.mantenimientoDatosEdificio(New String() {
                Me.Tag, txtcodedificio.Text, txtedificio.Text
            }, accion)
            If msg = "error" Then
                MessageBox.Show("Error al intentar guardar el registro, por favor intente nuevamente.", "Registro de Categorias",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                obtenerDatos()
                'HabDescontroles(True)
                btnAgregarTipHabitacion.Text = "Nuevo"
                btnModificarTipHabitacion.Text = "Modificar"
            End If
        End If
    End Sub
End Class