Public Class FormUsuarios
    Dim objConexion As New db_conexion()
    Dim dataTable As New DataTable
    Dim posicion As Integer
    Dim accion As String = "nuevo"
    'carga de datos 
    Private Sub FormUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        posicion = 0
        obtenerDatos()
        HabDescontroles(True)
    End Sub
    'obtener datos 
    Sub obtenerDatos()
        dataTable = objConexion.obtenerDatosTablas().Tables("usuarios")
        dataTable.PrimaryKey = New DataColumn() {dataTable.Columns("idUsuario")}

        cboNivelAcceso.DataSource = objConexion.obtenerDatosTablas().Tables("nivelAcceso").DefaultView()
        cboNivelAcceso.DisplayMember = "acceso"
        cboNivelAcceso.ValueMember = "nivelAcceso.acceso"

        mostrarDatos()
    End Sub
    'mostrar datos
    Sub mostrarDatos()
        If dataTable.Rows.Count > 0 Then
            Me.Tag = dataTable.Rows(posicion).ItemArray(0).ToString() 'ID de Usuario
            txtNombre.Text = dataTable.Rows(posicion).ItemArray(1).ToString()
            txtDUI.Text = dataTable.Rows(posicion).ItemArray(2).ToString()
            txtTelefono.Text = dataTable.Rows(posicion).ItemArray(3).ToString()
            txtEmail.Text = dataTable.Rows(posicion).ItemArray(4).ToString()
            cboNivelAcceso.SelectedValue = dataTable.Rows(posicion).ItemArray(5).ToString()
            txtUsuario.Text = dataTable.Rows(posicion).ItemArray(6).ToString()
            txtContra.Text = dataTable.Rows(posicion).ItemArray(7).ToString()

            lblPosicion.Text = posicion + 1 & " de " & dataTable.Rows.Count
        Else
            limpiarDatosUsuarios()
            MessageBox.Show("No hay registros que mostrar", "Registro de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    'limpiar textbox
    Private Sub limpiarDatosUsuarios()
        txtNombre.Text = ""
        txtDUI.Text = ""
        txtTelefono.Text = ""
        txtEmail.Text = ""
        txtUsuario.Text = ""
        txtContra.Text = ""
    End Sub
    'navegacion
    Private Sub btnPrimero_Click(sender As Object, e As EventArgs) Handles btnPrimero.Click
        posicion = 0
        mostrarDatos()
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        If posicion > 0 Then
            posicion -= 1
            mostrarDatos()
        Else
            MessageBox.Show("Ya te encuentras en el primer registro.", "Registro de Productos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        If posicion < dataTable.Rows.Count - 1 Then
            posicion += 1
            mostrarDatos()
        Else
            MessageBox.Show("Ya te encuentras en el ultimo registro.", "Registro de Productos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        posicion = dataTable.Rows.Count - 1
        mostrarDatos()
    End Sub
    'desabilita opciones
    Private Sub HabDescontroles(ByVal estado As Boolean)
        grbDatos.Enabled = Not estado
        grbPosicion.Enabled = estado
        btnEliminar.Enabled = estado
        btnBuscar.Enabled = estado
    End Sub
    'CRUD manipulacionde datos
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If btnAgregar.Text = "Nuevo" Then 'Nuevo
            btnAgregar.Text = "Guardar"
            btnModificar.Text = "Cancelar"
            accion = "nuevo"

            HabDescontroles(False)
            limpiarDatosUsuarios()
        Else 'Guardar
            Dim msg = objConexion.mantenimientoDatosUsuarios(New String() {
                Me.Tag, txtNombre.Text, txtDUI.Text, txtTelefono.Text, txtEmail.Text, cboNivelAcceso.SelectedValue, txtUsuario.Text, txtContra.Text
            }, accion)
            If msg = "error" Then
                MessageBox.Show("Error al intentar guardar el registro, por favor intente nuevamente.", "Registro de Productos",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                obtenerDatos()
                HabDescontroles(True)
                btnAgregar.Text = "Nuevo"
                btnModificar.Text = "Modificar"
            End If
        End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If btnModificar.Text = "Modificar" Then 'Modificar
            btnAgregar.Text = "Guardar"
            btnModificar.Text = "Cancelar"
            accion = "modificar"
            HabDescontroles(False)
        Else 'Cancelar
            obtenerDatos()

            HabDescontroles(True)
            btnAgregar.Text = "Nuevo"
            btnModificar.Text = "Modificar"
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If (MessageBox.Show("Esta seguro de borrar a " + txtNombre.Text, "Registro de cliente",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
            objConexion.mantenimientoDatosUsuarios(New String() {Me.Tag}, "eliminar")
            If posicion > 0 Then
                posicion -= 1 'Hemos borrado un registro
            End If
            obtenerDatos()
        End If
    End Sub
    'seleccion de datos sin navegacion
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim objBuscarCliente As New FormBusquedaUsuarios
        objBuscarCliente.ShowDialog()
        If objBuscarCliente._idU > 0 Then
            posicion = dataTable.Rows.IndexOf(dataTable.Rows.Find(objBuscarCliente._idU))
            mostrarDatos()
        End If
    End Sub
End Class