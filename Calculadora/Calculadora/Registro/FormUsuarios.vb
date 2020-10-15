Public Class FormUsuarios
    Dim objConexion As New db_conexion
    Dim dataTable As New DataTable
    Dim Accion As String = "Nuevo"
    Dim Posicion As Integer = 0
    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click

    End Sub

    Sub obtenerDatosUsuarios()
        dataTable = objConexion.obtenerDatosUsuarios().Tables("Usuarios")
        dataTable.PrimaryKey = New DataColumn() {dataTable.Columns("idUsuario")}

        cboNivelAcceso.DataSource = objConexion.obtenerDatosUsuarios().Tables("NivelAcceso").DefaultView()
        cboNivelAcceso.DisplayMember = "Acceso"
        cboNivelAcceso.ValueMember = "NivelAcceso.Acceso"

        'cboNacionalidad.DataSource = objConexion.obtenerDatosUsuarios().Tables("Nacionalidad").DefaultView()
        'cboNacionalidad.DisplayMember = "Nacionalidad"
        'cboNacionalidad.ValueMember = "Nacionalidad.Nacionalidad"

        mostrarDatosUsuarios()
    End Sub
    Sub mostrarDatosUsuarios()
        If dataTable.Rows.Count > 0 Then
            Me.Tag = dataTable.Rows(Posicion).ItemArray(0).ToString()
            txtNombre.Text = dataTable.Rows(Posicion).ItemArray(1).ToString()
            txtDUI.Text = dataTable.Rows(Posicion).ItemArray(2).ToString()
            txtEmail.Text = dataTable.Rows(Posicion).ItemArray(3).ToString
            txtTelefono.Text = dataTable.Rows(Posicion).ItemArray(4).ToString
            txtUsuario.Text = dataTable.Rows(Posicion).ItemArray(5).ToString
            txtContra.Text = dataTable.Rows(Posicion).ItemArray(6).ToString
            cboNivelAcceso.SelectedValue = dataTable.Rows(Posicion).ItemArray(7).ToString

            lblPosicion.Text = Posicion + 1 & " de " & dataTable.Rows.Count
        End If
    End Sub

    Private Sub FormUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        obtenerDatosUsuarios()
    End Sub
    Private Sub HabDescontroles(ByVal estado As Boolean)
        grbDatos.Enabled = Not estado
        'grbNavegacion.Enabled = estado
        btnEliminar.Enabled = estado
        btnModificar.Enabled = estado
        btnBuscar.Enabled = estado
    End Sub
    Private Sub limpiarDatosCliente()
        txtNombre.Text = ""
        txtDUI.Text = ""
        txtEmail.Text = ""
        txtTelefono.Text = ""
        txtUsuario.Text = ""
        txtContra.Text = ""
    End Sub
    Sub obtenerDatos()
        dataTable = objConexion.obtenerDatosUsuarios().Tables("Usuarios")
        dataTable.PrimaryKey = New DataColumn() {dataTable.Columns("idUsuario")}
        mostrarDatosUsuarios()
    End Sub
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        If btnNuevo.Text = "Nuevo" Then 'Nuevo
            btnNuevo.Text = "Guardar"
            btnModificar.Text = "Cancelar"
            Accion = "nuevo"

            HabDescontroles(False)
            limpiarDatosCliente()
        Else 'Guardar
            Dim msg = objConexion.mantenimientoDatosUsuarios(New String() {
                Me.Tag, txtNombre.Text, txtDUI.Text, txtTelefono.Text, txtEmail.Text, cboNivelAcceso.SelectedValue, txtUsuario.Text, txtContra.Text
            }, Accion)
            If msg = "error" Then
                MessageBox.Show("Error al intentar guardar el registro, por favor intente nuevamente.", "Registro de Clientes",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                obtenerDatos()
                HabDescontroles(True)
                btnNuevo.Text = "Nuevo"
                btnModificar.Text = "Modificar"
            End If
        End If
    End Sub
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim form As New FormBusquedaUsuarios
        form.Show()
    End Sub
End Class