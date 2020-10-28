Public Class FormTipoHabitaciones
    Dim objConexion As New db_conexion()
    Dim dataTable As New DataTable
    Dim posicion As Integer
    Dim accion As String = "nuevo"
    Private Sub FormTipoHabitaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        obtenerDatos()
    End Sub

    Sub obtenerDatos()
        dataTable = objConexion.obtenerDatosTablas().Tables("TipoHabit")
        dataTable.PrimaryKey = New DataColumn() {dataTable.Columns("idTipo")}

        mostrarDatos()
    End Sub
    Sub mostrarDatos()
        If dataTable.Rows.Count > 0 Then
            Me.Tag = dataTable.Rows(posicion).ItemArray(0).ToString() 'ID de tipo de habitacion 
            txtdescripcion.Text = dataTable.Rows(posicion).ItemArray(0).ToString()
            txtCapacidad.Text = dataTable.Rows(posicion).ItemArray(1).ToString()
            txtprecio.Text = dataTable.Rows(posicion).ItemArray(2).ToString()

            lblRegistroTipoHab.Text = posicion + 1 & " de " & dataTable.Rows.Count
        Else
            limpiarDatos()
            MessageBox.Show("No hay registros que mostrar", "Registro de Productos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Sub LimpiarDatos()
        txtCapacidad.Text = ""
        txtdescripcion.Text = ""
        txtprecio.Text = ""
    End Sub

    Sub HabDescontroles(ByVal estado As Boolean)
        grbDatosTipoHab.Enabled = Not estado
        grbNavegacionTipoHab.Enabled = estado
        btnBuscarTipHabitacion.Enabled = estado
        btnEliminarTipHabitacion.Enabled = estado
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
            MessageBox.Show("Ya se encuentra en el primer registro", "Registro Habitacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnSiguienteCategoria_Click(sender As Object, e As EventArgs) Handles btnSiguienteCategoria.Click
        If posicion < dataTable.Rows.Count - 1 Then
            posicion += 1
            mostrarDatos()
        Else
            MessageBox.Show("Ya se encuentra en el ultimo registro", "Registro Habitacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnUltimoCategoria_Click(sender As Object, e As EventArgs) Handles btnUltimoCategoria.Click
        posicion = dataTable.Rows.Count - 1
        mostrarDatos()
    End Sub

    Private Sub btnAgregarTipHabitacion_Click(sender As Object, e As EventArgs) Handles btnAgregarTipHabitacion.Click
        If btnAgregarTipHabitacion.Text = "Nuevo" Then 'Nuevo
            btnAgregarTipHabitacion.Text = "Guardar"
            btnModificarTipHabitacion.Text = "Cancelar"
            accion = "nuevo"

            HabDescontroles(False)
            LimpiarDatos()
        Else 'Guardar
            Dim msg = objConexion.mantenimientoDatosTipoHabitacion(New String() {
                Me.Tag, txtdescripcion.Text, txtCapacidad.Text, txtprecio.Text
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
            accion = "actualizar"
            HabDescontroles(False)
        Else 'Cancelar
            obtenerDatos()

            HabDescontroles(True)
            btnAgregarTipHabitacion.Text = "Nuevo"
            btnModificarTipHabitacion.Text = "Modificar"
        End If
    End Sub

    Private Sub btnEliminarTipHabitacion_Click(sender As Object, e As EventArgs) Handles btnEliminarTipHabitacion.Click
        'If (MessageBox.Show("Esta seguro de borrar Este REgistro", "Registro de Habitacion",
        '                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
        '    objConexion.mantenimientoDatosTipoHabitacion(New String() {Me.Tag}, "eliminar")
        '    If posicion > 0 Then
        '        posicion -= 1 'Hemos borrado un registro
        '    End If
        '    obtenerDatos()
        'End If
    End Sub


End Class