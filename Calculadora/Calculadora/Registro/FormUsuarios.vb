Public Class FormUsuarios
    Dim objConexion As New db_conexion
    Dim dataTable As New DataTable
    Dim Accion As String = "Nuevo"
    Dim Posicion As Integer = 0
    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        Dim form As New FormBusquedaUsuarios
        form.Show()
    End Sub

    Sub obtenerDatosUsuarios()
        DataTable = objConexion.obtenerDatosUsuarios().Tables("Usuarios")
        DataTable.PrimaryKey = New DataColumn() {DataTable.Columns("idUsuario")}

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
End Class