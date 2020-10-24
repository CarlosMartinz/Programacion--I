Public Class FormHabitaciones
    Dim objConexion As New db_conexion()
    Dim dataTable As New DataTable
    Dim posicion As Integer
    Dim accion As String = "nuevo"
    Sub obtenerDatosTipoHabitacion()
        dataTable = objConexion.obtenerDatosUsuarios().Tables("Habitaciones")
        dataTable.PrimaryKey = New DataColumn() {dataTable.Columns("idHabitaciones")}
        mostrarDatosHabit()

        cboTipo.DataSource = objConexion.obtenerDatosUsuarios().Tables("TipoHabit").DefaultView()
        cboTipo.DisplayMember = "idTipo"
        cboTipo.ValueMember = "TipoHabit.idTipo"

        cboTipo.DataSource = objConexion.obtenerDatosUsuarios().Tables("Edificio").DefaultView()
        cboTipo.DisplayMember = "Edificio"
        cboTipo.ValueMember = "Edificio"
    End Sub
    Sub mostrarDatosHabit()
        If dataTable.Rows.Count > 0 Then
            Me.Tag = dataTable.Rows(posicion).ItemArray(0).ToString() 'ID de tipo de habitacion 
            txtcodigohabitacion.Text = dataTable.Rows(posicion).ItemArray(1).ToString()
            cboEdificio.SelectedValue = dataTable.Rows(posicion).ItemArray(2).ToString()
            cboTipo.SelectedValue = dataTable.Rows(posicion).ItemArray(3).ToString()

            lblRegistroTipoHab.Text = posicion + 1 & " de " & dataTable.Rows.Count
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
                Me.Tag, txtcapacidad.Text
            }, accion)
            If msg = "error" Then
                MessageBox.Show("Error al intentar guardar el registro, por favor intente nuevamente.", "Registro de Categorias",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                obtenerDatosTipoHabitacion()
                'HabDescontroles(True)
                btnAgregarTipHabitacion.Text = "Nuevo"
                btnModificarTipHabitacion.Text = "Modificar"
            End If
        End If
    End Sub

    Private Sub ControlesTipoHab(ByVal Estado As Boolean)
        grbDatosTipoHab.Enabled = Not Estado
        grbNavegacionTipoHab.Enabled = Estado
        btnBuscarTipHabitacion.Enabled = Estado
        btnEliminarTipHabitacion.Enabled = Estado
    End Sub
    Private Sub btnPrimeroCategoria_Click(sender As Object, e As EventArgs) Handles btnPrimeroCategoria.Click
        posicion = 0
    End Sub

    Private Sub btnAnteriorCategoria_Click(sender As Object, e As EventArgs) Handles btnAnteriorCategoria.Click
        If posicion > 0 Then
            posicion -= 1
            mostrarDatosHabit()
        Else
            MessageBox.Show("Ya se encuentra en el primer registro", "Registro Habitacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnSiguienteCategoria_Click(sender As Object, e As EventArgs) Handles btnSiguienteCategoria.Click
        If posicion < dataTable.Rows.Count - 1 Then
            posicion += 1
            mostrarDatosHabit()
        Else
            MessageBox.Show("Ya se encuentra en el ultimo registro", "Registro Habitacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnUltimoCategoria_Click(sender As Object, e As EventArgs) Handles btnUltimoCategoria.Click
        posicion = dataTable.Rows.Count - 1
        mostrarDatosHabit()
    End Sub

    Private Sub btnAgregarTipHabitacion_Click(sender As Object, e As EventArgs) Handles btnAgregarTipHabitacion.Click
        If btnAgregarTipHabitacion.Text = "Nuevo" Then 'Nuevo
            btnAgregarTipHabitacion.Text = "Guardar"
            btnModificarTipHabitacion.Text = "Cancelar"
            accion = "nuevo"

            ControlesTipoHab(False)
            limpiarDatosHabitaciones()
        Else 'Guardar
            Dim msg = objConexion.mantenimientoDatosTipoHabitacion(New String() {
                Me.Tag, txtdescripcion.Text, txtcapacidad.Text, txtprecio.Text}, accion)
            If msg = "error" Then
                MessageBox.Show("Error al intentar guardar el registro, por favor intente nuevamente.", "Registro de Clientes",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                obtenerDatosTipoHabitacion()
                ControlesTipoHab(True)
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
            ControlesTipoHab(False)
        Else 'Cancelar
            obtenerDatosTipoHabitacion()

            ControlesTipoHab(True)
            btnAgregarTipHabitacion.Text = "Nuevo"
            btnModificarTipHabitacion.Text = "Modificar"
        End If
    End Sub

    Private Sub btnEliminarTipHabitacion_Click(sender As Object, e As EventArgs) Handles btnEliminarTipHabitacion.Click
        If (MessageBox.Show("Esta seguro de borrar Este REgistro", "Registro de Habitacion",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
            objConexion.mantenimientoDatosTipoHabitacion(New String() {Me.Tag}, "eliminar")
            If posicion > 0 Then
                posicion -= 1 'Hemos borrado un registro
            End If
            obtenerDatosTipoHabitacion()
        End If
    End Sub

    Private Sub FormHabitaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class