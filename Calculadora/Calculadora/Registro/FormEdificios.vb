Public Class FormEdificios
    Dim objConexion As New db_conexion()
    Dim dataTable As New DataTable
    Dim posicion As Integer
    Dim accion As String = "nuevo"

    Private Sub FormEdificios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        obtenerDatosEdificio()
        HabControles(True)
    End Sub
    Sub obtenerDatosEdificio()
        dataTable = objConexion.obtenerDatosTablas().Tables("Edificio")
        dataTable.PrimaryKey = New DataColumn() {dataTable.Columns("Edificio")}

        mostrarDatosEdificio()
    End Sub
    Sub mostrarDatosEdificio()
        If dataTable.Rows.Count > 0 Then
            Me.Tag = dataTable.Rows(posicion).ItemArray(0).ToString() 'ID de tipo de habitacion 
            txtNombreEdificio.Text = dataTable.Rows(posicion).ItemArray(0).ToString()

            lblRegistroEdificio.Text = posicion + 1 & " de " & dataTable.Rows.Count
        Else
            txtNombreEdificio.Text = ""
            MessageBox.Show("No hay registros que mostrar", "Registro de Productos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Sub HabControles(ByVal estado As Boolean)
        grbDatos.Enabled = Not estado
        grbNavegacion.Enabled = estado
        btnEliminar.Enabled = estado
        btnBuscar.Enabled = estado
    End Sub

    Private Sub btnPrimero_Click(sender As Object, e As EventArgs) Handles btnPrimero.Click
        posicion = 0
        mostrarDatosEdificio()
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        If posicion > 0 Then
            posicion -= 1
            mostrarDatosEdificio()
        Else
            MessageBox.Show("Ya se encuentra en el primer registro", "Registro Edificio", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        If posicion < dataTable.Rows.Count - 1 Then
            posicion += 1
            mostrarDatosEdificio()
        Else
            MessageBox.Show("Ya se encuentra en el ultimo registro", "Registro Edificio", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        posicion = dataTable.Rows.Count - 1
        mostrarDatosEdificio()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        If btnNuevo.Text = "Nuevo" Then 'Nuevo
            btnNuevo.Text = "Guardar"
            btnModificar.Text = "Cancelar"
            accion = "nuevo"

            HabControles(False)
            txtNombreEdificio.Text = ""
        Else 'Guardar
            Dim msg = objConexion.mantenimientoDatosEdificio(New String() {Me.Tag, txtNombreEdificio.Text}, accion)
            If msg = "error" Then
                MessageBox.Show("Error al intentar guardar el registro, por favor intente nuevamente.", "Registro de Edificio",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                obtenerDatosEdificio()
                HabControles(True)
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
            HabControles(False)
        Else 'Cancelar
            obtenerDatosEdificio()

            HabControles(True)
            btnNuevo.Text = "Nuevo"
            btnModificar.Text = "Modificar"
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If MessageBox.Show("Esta seguro de borrar Este Registro", "Registro de Edificio",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            objConexion.mantenimientoDatosEdificio(New String() {txtNombreEdificio.Text}, "eliminar")
            If posicion > 0 Then
                posicion -= 1 'Hemos borrado un registro
            End If
            obtenerDatosEdificio()
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim objFormBuscarEdificio As New FormBusquedaEdificio()
        objFormBuscarEdificio.ShowDialog()
        If objFormBuscarEdificio._idEdificio <> "" Then
            posicion = dataTable.Rows.IndexOf(dataTable.Rows.Find(objFormBuscarEdificio._idEdificio))
            mostrarDatosEdificio()
        End If
    End Sub
End Class