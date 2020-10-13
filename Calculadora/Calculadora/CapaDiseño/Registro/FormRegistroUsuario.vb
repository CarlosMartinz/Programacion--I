Public Class FormRegistroUsuario
    Dim objConexion As New db_conexion
    Dim dataTable As New DataTable
    Dim Accion As String = "Nuevo"
    Dim Posicion As Integer = 0
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim form As New FormBusquedaUsuario
        form.Show()
    End Sub
    Private Sub FormRegistroUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        obtenerDatosUsuarios()
        btnNuevo.Image = System.Drawing.Image.FromFile(Application.StartupPath & "\recursos\imagenes\nuevo.png")
        btnModificar.Image = System.Drawing.Image.FromFile(Application.StartupPath & "\recursos\imagenes\actualizar.png")
        btnEliminar.Image = System.Drawing.Image.FromFile(Application.StartupPath & "\recursos\imagenes\eliminar.png")
        btnBuscar.Image = System.Drawing.Image.FromFile(Application.StartupPath & "\recursos\imagenes\buscar.png")

        btnPrimero.Image = System.Drawing.Image.FromFile(Application.StartupPath & "\recursos\imagenes\primero.png")
        btnAnterior.Image = System.Drawing.Image.FromFile(Application.StartupPath & "\recursos\imagenes\anterior.png")
        btnSiguiente.Image = System.Drawing.Image.FromFile(Application.StartupPath & "\recursos\imagenes\siguiente.png")
        btnUltimo.Image = System.Drawing.Image.FromFile(Application.StartupPath & "\recursos\imagenes\ultimo.png")

    End Sub

    Sub obtenerDatosUsuarios()
        dataTable = objConexion.obtenerDatosUsuarios().Tables("Usuarios")
        dataTable.PrimaryKey = New DataColumn() {dataTable.Columns("idUsuario")}

        cboNivelAcceso.DataSource = objConexion.obtenerDatosUsuarios().Tables("Usuarios").DefaultView()
        cboNivelAcceso.DisplayMember = "Acceso"
        cboNivelAcceso.ValueMember = "Usuarios.Acceso"

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

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        If btnNuevo.Text = "." Then
            btnNuevo.Image = System.Drawing.Image.FromFile(Application.StartupPath & "\recursos\imagenes\aceptar.png")
            btnModificar.Image = System.Drawing.Image.FromFile(Application.StartupPath & "\recursos\imagenes\cancelar.png")
            btnNuevo.Text = ","
            btnBuscar.Enabled = False
            btnEliminar.Enabled = False
            Accion = "Nuevo"

            LimpiarDatos()
            Controles(False)
        Else 'Guardar
            'Guardar
            Dim msg = objConexion.mantenimientoDatosUsuario(New String() {
                "", txtNombre.Text, txtDUI.Text, txtTelefono.Text, txtEmail.Text, txtUsuario.Text, txtContra.Text,
                cboNivelAcceso.SelectedValue}, Accion)
            If msg = "Error" Then
                MessageBox.Show("Error al intentar guardar el registro, por favor intente nuevamente.",
                                "Registro de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                btnNuevo.Text = "."
                btnNuevo.Image = System.Drawing.Image.FromFile(Application.StartupPath & "\recursos\imagenes\nuevo.png")
                btnModificar.Image = System.Drawing.Image.FromFile(Application.StartupPath & "\recursos\imagenes\actualizar.png")
                btnBuscar.Enabled = True
                btnEliminar.Enabled = True
            End If
        End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If btnNuevo.Text = "." Then 'Nuveo
            btnNuevo.Image = System.Drawing.Image.FromFile(Application.StartupPath & "\recursos\imagenes\aceptar.png")
            btnModificar.Image = System.Drawing.Image.FromFile(Application.StartupPath & "\recursos\imagenes\cancelar.png")
            btnNuevo.Text = ","
            Accion = "Actualizar"

        Else
            btnNuevo.Text = "."
            btnNuevo.Image = System.Drawing.Image.FromFile(Application.StartupPath & "\recursos\imagenes\nuevo.png")
            btnModificar.Image = System.Drawing.Image.FromFile(Application.StartupPath & "\recursos\imagenes\actualizar.png")
        End If
    End Sub

    Private Sub LimpiarDatos()
        txtContra.Text = ""
        txtDUI.Text = ""
        txtEmail.Text = ""
        txtNombre.Text = ""
        txtTelefono.Text = ""
        txtUsuario.Text = ""
    End Sub

    Private Sub Controles(ByVal Estado As Boolean)
        grbDatos.Enabled = Not Estado
        grbPosicion.Enabled = Estado
        btnEliminar.Enabled = Estado
        btnBuscar.Enabled = Estado
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        If Posicion > 0 Then
            Posicion -= 1
            mostrarDatosUsuarios()
        Else
            MessageBox.Show("Ya estas en el Primer registro.", "Registro de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        If Posicion < dataTable.Rows.Count - 1 Then
            Posicion += 1
            mostrarDatosUsuarios()
        Else
            MessageBox.Show("Ya estas en el ultimo registro", "Registro de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnPrimero_Click(sender As Object, e As EventArgs) Handles btnPrimero.Click
        Posicion = 0
        mostrarDatosUsuarios()
    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        Posicion = dataTable.Rows.Count - 1
        mostrarDatosUsuarios()
    End Sub
End Class