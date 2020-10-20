Public Class FormUsuarios
    Dim objConexion As New db_conexion
    Dim dataTable As New DataTable
    Dim Accion As String = "nuevo"
    Dim Posicion As Integer = 0
    Private Sub FormUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        obtenerDatosUsuarios()
    End Sub
    Sub obtenerDatosUsuarios()
        dataTable = objConexion.obtenerDatosUsuarios().Tables("Usuarios")
        dataTable.PrimaryKey = New DataColumn() {dataTable.Columns("idUsuario")}

        cboNivelAcceso.DataSource = objConexion.obtenerDatosUsuarios().Tables("NivelAcceso").DefaultView()
        cboNivelAcceso.DisplayMember = "Acceso"
        cboNivelAcceso.ValueMember = "NivelAcceso.Acceso"
        HabDescontroles(True)
        mostrarDatosUsuarios()
    End Sub
    Sub mostrarDatosUsuarios()
        If dataTable.Rows.Count > 0 Then
            Me.Tag = dataTable.Rows(Posicion).ItemArray(0).ToString()
            txtNombre.Text = dataTable.Rows(Posicion).ItemArray(1).ToString()
            txtDUI.Text = dataTable.Rows(Posicion).ItemArray(2).ToString()
            txtTelefono.Text = dataTable.Rows(Posicion).ItemArray(3).ToString()
            txtEmail.Text = dataTable.Rows(Posicion).ItemArray(4).ToString()
            cboNivelAcceso.SelectedValue = dataTable.Rows(Posicion).ItemArray(5).ToString()
            txtUsuario.Text = dataTable.Rows(Posicion).ItemArray(6).ToString()
            txtContra.Text = dataTable.Rows(Posicion).ItemArray(7).ToString()

            lblPosicion.Text = Posicion + 1 & " de " & dataTable.Rows.Count
        Else
            limpiarDatosUsuario()
            MessageBox.Show("No hay registros que mostrar", "Registro de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub HabDescontroles(ByVal estado As Boolean)
        grbDatos.Enabled = Not estado
        grbPosicion.Enabled = estado
        'btnEliminar.Enabled = estado
        'btnBuscar.Enabled = estado
    End Sub
    Private Sub limpiarDatosUsuario()
        txtNombre.Text = ""
        txtDUI.Text = ""
        txtEmail.Text = ""
        txtTelefono.Text = ""
        txtUsuario.Text = ""
        txtContra.Text = ""
    End Sub
    Private Sub btnPrimero_Click(sender As Object, e As EventArgs) Handles btnPrimero.Click
        Posicion = 0
        mostrarDatosUsuarios()
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        If Posicion > 0 Then
            Posicion -= 1
            mostrarDatosUsuarios()
        Else
            MessageBox.Show("Ya te encuentras en el primer registro.", "Registro de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        If Posicion < dataTable.Rows.Count - 1 Then
            Posicion += 1
            mostrarDatosUsuarios()
        Else
            MessageBox.Show("Ya te encuentras en el ultimo registro.", "Registro de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        Posicion = dataTable.Rows.Count - 1
        mostrarDatosUsuarios()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        If btnNuevo.Text = "Nuevo" Then 'Nuevo
            btnNuevo.Text = "Guardar"
            btnModificar.Text = "Cancelar"
            Accion = "nuevo"

            HabDescontroles(False)
            limpiarDatosUsuario()
        Else 'Guardar
            Dim msg = objConexion.mantenimientoDatosUsuarios(New String() {
                Me.Tag, txtNombre.Text, txtDUI.Text, txtTelefono.Text, txtEmail.Text, cboNivelAcceso.SelectedValue, txtUsuario.Text, txtContra.Text
            }, Accion)
            If msg = "error" Then
                MessageBox.Show("Error al intentar guardar el registro, por favor intente nuevamente.", "Registro de Usuario",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                obtenerDatosUsuarios()
                HabDescontroles(True)
                btnNuevo.Text = "Nuevo"
                btnModificar.Text = "Modificar"
            End If
        End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If btnNuevo.Text = "Nuevo" Then 'Actualizar
            btnNuevo.Text = "Guardar"
            btnModificar.Text = "Cancelar"
            Accion = "actualizar"

            HabDescontroles(False)
        Else 'Cancelar
            HabDescontroles(True)
            btnNuevo.Text = "Nuevo"
            btnModificar.Text = "Modificar"
            obtenerDatosUsuarios()
        End If

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If (MessageBox.Show("¿Estas seguro de borrar este registro?", "Registro Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
            objConexion.mantenimientoDatosUsuarios(New String() {Me.Tag}, "eliminar")
            If Posicion > 0 Then
                Posicion -= 1
            End If
            obtenerDatosUsuarios()
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim objBuscarUsuario As New FormBusquedaUsuarios
        objBuscarUsuario.Show()
        If objBuscarUsuario._idU > 0 Then
            Posicion = dataTable.Rows.IndexOf(dataTable.Rows.Find(objBuscarUsuario._idU))
            mostrarDatosUsuarios()
        End If
    End Sub

End Class