Public Class FormEdificio
    Dim objConexion As New db_conexion()
    Dim dataTable As New DataTable
    Dim posicion As Integer
    Dim accion As String = "nuevo"

    Private Sub FormEdificio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        obtenerDatosEdificio()
        HabControles(True)
    End Sub

    Sub obtenerDatosEdificio()
        dataTable = objConexion.obtenerDatosTablas().Tables("Edificio")
        dataTable.PrimaryKey = New DataColumn() {dataTable.Columns("Edificio")}

        MostrarDatosEdificio()
    End Sub

    Sub MostrarDatosEdificio()
        If dataTable.Rows.Count > 0 Then
            Me.Tag = dataTable.Rows(posicion).ItemArray(0).ToString() 'ID de tipo de habitacion
            txtEdificio.Text = dataTable.Rows(posicion).ItemArray(0).ToString()

            lblRegistroHabitaciones.Text = posicion + 1 & " de " & dataTable.Rows.Count
        Else
            MessageBox.Show("No hay registros que mostrar", "Registro de Productos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Sub HabControles(ByVal estado As Boolean)
        grbEdificio.Enabled = Not estado
        grbNavegacion.Enabled = estado
        btnEliminar.Enabled = estado
        btnBuscar.Enabled = estado
    End Sub

    Private Sub btnPrimero_Click(sender As Object, e As EventArgs) Handles btnPrimero.Click
        posicion = 0
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        If posicion > 0 Then
            posicion -= 1
            MostrarDatosEdificio()
        End If
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        If posicion < dataTable.Rows.Count - 1 Then
            posicion += 1
            MostrarDatosEdificio()
        End If
    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        posicion = dataTable.Rows.Count - 1
        MostrarDatosEdificio()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        If btnNuevo.Text = "Nuevo" Then 'Nuevo
            btnNuevo.Text = "Guardar"
            btnModificar.Text = "Cancelar"
            accion = "nuevo"

            HabControles(False)
            txtEdificio.Text = ""
        Else 'Guardar
            Dim msg = objConexion.mantenimientoDatosEdificio(New String() {Me.Tag, txtEdificio.Text}, accion)
            If msg = "error" Then
                MessageBox.Show("Error al intentar guardar el registro, por favor intente nuevamente.", "Registro de Categorias", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                obtenerDatosEdificio()
                HabControles(True)
                btnNuevo.Text = "Nuevo"
                btnModificar.Text = "Modificar"
            End If
        End If
    End Sub
End Class