Public Class FormHabitaciones
    Dim objConexion As New db_conexion()
    Dim dataTable As New DataTable
    Dim posicion As Integer
    Dim accion As String = "nuevo"
    Sub obtenerDatos()
        dataTable = objConexion.obtenerDatosUsuarios().Tables("categorias")
        dataTable.PrimaryKey = New DataColumn() {DataTable.Columns("idCategoria")}

        mostrarDatos()
    End Sub
    Sub mostrarDatos()
        If DataTable.Rows.Count > 0 Then
            Me.Tag = dataTable.Rows(posicion).ItemArray(0).ToString() 'ID de tipo de habitacion 
            txtdescripcion.Text = dataTable.Rows(posicion).ItemArray(1).ToString()
            txtcapacidad.Text = dataTable.Rows(posicion).ItemArray(2).ToString()
            txtprecio.Text = dataTable.Rows(posicion).ItemArray(3).ToString()

            lblRegistrosCategoria.Text = posicion + 1 & " de " & DataTable.Rows.Count
        Else
            limpiarDatosCategoria()
            MessageBox.Show("No hay registros que mostrar", "Registro de Productos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub limpiarDatosCategoria()
        txtcapacidad.Text = ""
        txtdescripcion.Text = ""
        txtprecio.Text = ""
    End Sub

    Private Sub btnPrimeroCategoria_Click(sender As Object, e As EventArgs) Handles btnPrimeroCategoria.Click
        posicion = 0
        mostrarDatos()
    End Sub

    Private Sub btnAnteriorCategoria_Click(sender As Object, e As EventArgs) Handles btnAnteriorCategoria.Click
        If posicion > 0 Then
            posicion -= 1
            mostrarDatos()
        Else
            MessageBox.Show("Ya te encuentras en el primer registro.", "Registro de Categorias", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnSiguienteCategoria_Click(sender As Object, e As EventArgs) Handles btnSiguienteCategoria.Click
        If posicion < dataTable.Rows.Count - 1 Then
            posicion += 1
            mostrarDatos()
        Else
            MessageBox.Show("Ya te encuentras en el ultimo registro.", "Registro de Productos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnUltimoCategoria_Click(sender As Object, e As EventArgs) Handles btnUltimoCategoria.Click
        posicion = dataTable.Rows.Count - 1
        mostrarDatos()
    End Sub
    Private Sub HabDescontroles(ByVal estado As Boolean)
        grbDatos.Enabled = Not estado
        grbNavegacion.Enabled = estado
        btnEliminarTipHabitacion.Enabled = estado
        btnBuscarTipHabitacion.Enabled = estado
    End Sub

    Private Sub btnAgregarCategoria_Click(sender As Object, e As EventArgs) Handles btnAgregarTipHabitacion.Click
        If btnAgregarTipHabitacion.Text = "Nuevo" Then 'Nuevo
            btnAgregarTipHabitacion.Text = "Guardar"
            btnModificarTipHabitacion.Text = "Cancelar"
            accion = "nuevo"

            HabDescontroles(False)
            limpiarDatosCategoria()
        Else 'Guardar
            Dim msg = objConexion.mantenimientoDatosTipoHabitacion(New String() {
                Me.Tag, txtdescripcion.Text, txtcapacidad.Text, txtprecio.Text
            }, accion)
            If msg = "error" Then
                MessageBox.Show("Error al intentar guardar el registro, por favor intente nuevamente.", "Registro de Categorias",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                obtenerDatos()
                HabDescontroles(True)
                btnAgregarTipHabitacion.Text = "Nuevo"
                btnModificarTipHabitacion.Text = "Modificar"
            End If
        End If
    End Sub

    Private Sub btnModificarTipHabitacion_Click(sender As Object, e As EventArgs) Handles btnModificarTipHabitacion.Click
        If btnModificarTipHabitacion.Text = "Modificar" Then 'Modificar
            btnAgregarTipHabitacion.Text = "Guardar"
            btnModificarTipHabitacion.Text = "Cancelar"
            accion = "modificar"
            HabDescontroles(False)
        Else 'Cancelar
            obtenerDatos()

            HabDescontroles(True)
            btnAgregarTipHabitacion.Text = "Nuevo"
            btnModificarTipHabitacion.Text = "Modificar"
        End If
    End Sub
End Class