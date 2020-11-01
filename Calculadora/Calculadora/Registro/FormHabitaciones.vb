Public Class FormHabitaciones
    Dim objConexion As New db_conexion()
    Dim dataTable As New DataTable
    Dim posicion As Integer
    Dim accion As String = "nuevo"
    Private Sub FormHabitaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        obtenerDatosHabitaciones()
        ControlesHabitacion(True)
    End Sub
    Sub obtenerDatosHabitaciones()
        dataTable = objConexion.obtenerDatosTablas().Tables("Habitaciones")
        dataTable.PrimaryKey = New DataColumn() {dataTable.Columns("idHabitaciones")}

        cboTipo.DataSource = objConexion.obtenerDatosTablas().Tables("TipoHabit").DefaultView()
        cboTipo.DisplayMember = "idTipo"
        cboTipo.ValueMember = "TipoHabit.idTipo"

        cboEdificio.DataSource = objConexion.obtenerDatosTablas().Tables("Edificio").DefaultView()
        cboEdificio.DisplayMember = "Edificio"
        cboEdificio.ValueMember = "Edificio.Edificio"

        mostrarDatosHabit()
    End Sub

    Sub mostrarDatosHabit()
        If dataTable.Rows.Count > 0 Then
            Me.Tag = dataTable.Rows(posicion).ItemArray(0).ToString() 'ID de tipo de habitacion 
            txtcodigohabitacion.Text = dataTable.Rows(posicion).ItemArray(1).ToString()
            cboEdificio.SelectedValue = dataTable.Rows(posicion).ItemArray(2).ToString()
            cboTipo.SelectedValue = dataTable.Rows(posicion).ItemArray(3).ToString()

            lblRegistroHabitaciones.Text = posicion + 1 & " de " & dataTable.Rows.Count
        Else
            limpiarDatos()
            MessageBox.Show("No hay registros que mostrar", "Registro de Productos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub limpiarDatos()
        txtcodigohabitacion.Text = ""
    End Sub

    Private Sub ControlesHabitacion(ByVal Estado As Boolean)
        grbDatosHabitacion.Enabled = Not Estado
        grbNavegacion.Enabled = Estado
        btnBuscar.Enabled = Estado
        btnEliminar.Enabled = Estado
    End Sub

    Private Sub btnPrimero_Click_1(sender As Object, e As EventArgs) Handles btnPrimero.Click
        posicion = 0
        mostrarDatosHabit()
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        If posicion > 0 Then
            posicion -= 1
            mostrarDatosHabit()
        Else
            MessageBox.Show("Ya se encuentra en el primer registro", "Registro Habitacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        If posicion < dataTable.Rows.Count - 1 Then
            posicion += 1
            mostrarDatosHabit()
        Else
            MessageBox.Show("Ya se encuentra en el ultimo registro", "Registro Habitacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        posicion = dataTable.Rows.Count - 1
        mostrarDatosHabit()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        If btnNuevo.Text = "Nuevo" Then 'Nuevo
            btnNuevo.Text = "Guardar"
            btnModificar.Text = "Cancelar"
            accion = "nuevo"

            ControlesHabitacion(False)
            limpiarDatos()
        Else 'Guardar
            Dim msg = objConexion.mantenimientoDatosHabitaciones(New String() {
                Me.Tag, txtcodigohabitacion.Text, cboEdificio.SelectedValue, cboTipo.SelectedValue}, accion)
            If msg = "error" Then
                MessageBox.Show("Error al intentar guardar el registro, por favor intente nuevamente.", "Registro de Clientes",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                obtenerDatosHabitaciones()
                ControlesHabitacion(True)
                btnNuevo.Text = "Nuevo"
                btnModificar.Text = "Modificar"
            End If
        End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If btnModificar.Text = "Modificar" Then 'Modificar
            btnNuevo.Text = "Guardar"
            btnModificar.Text = "Cancelar"
            accion = "actualizar"
            ControlesHabitacion(False)
        Else 'Cancelar
            obtenerDatosHabitaciones()

            ControlesHabitacion(True)
            btnNuevo.Text = "Nuevo"
            btnModificar.Text = "Modificar"
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If (MessageBox.Show("Esta seguro de borrar Este Registro", "Registro de Habitacion",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
            objConexion.mantenimientoDatosHabitaciones(New String() {Me.Tag}, "eliminar")
            If posicion > 0 Then
                posicion -= 1 'Hemos borrado un registro
            End If
            obtenerDatosHabitaciones()
        End If
    End Sub
End Class