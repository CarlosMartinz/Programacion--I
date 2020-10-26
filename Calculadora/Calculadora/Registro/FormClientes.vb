Public Class FormClientes
    Dim objConexion As New db_conexion
    Dim dataTable As New DataTable
    Dim Accion As String = "nuevo"
    Dim Posicion As Integer = 0
    Private Sub FormClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ObtenrDatosCliente()
    End Sub
    Sub ObtenrDatosCliente()
        dataTable = objConexion.obtenerDatosUsuarios.Tables("Clientes")
        dataTable.PrimaryKey = New DataColumn() {dataTable.Columns("idCliente")}

        HabDescontroles(True)
        MostrarDatosCliente()
    End Sub

    Sub MostrarDatosCliente()
        If dataTable.Rows.Count > 0 Then
            Me.Tag = dataTable.Rows(Posicion).ItemArray(0).ToString()
            txtcode.Text = dataTable.Rows(Posicion).ItemArray(1).ToString()
            txtNombre.Text = dataTable.Rows(Posicion).ItemArray(2).ToString()
            txtDUI.Text = dataTable.Rows(Posicion).ItemArray(3).ToString()
            txtTelefono.Text = dataTable.Rows(Posicion).ItemArray(4).ToString()
            txtEmail.Text = dataTable.Rows(Posicion).ItemArray(5).ToString()

            lblPosicion.Text = Posicion + 1 & " de " & dataTable.Rows.Count
        Else
            LimpiarDatosCliente()
            MessageBox.Show("No hay registros que mostrar", "Registro de Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub HabDescontroles(ByVal estado As Boolean)
        grbDatos.Enabled = Not estado
        grbPosicion.Enabled = estado
        btnEliminar.Enabled = estado
        btnBuscar.Enabled = estado
    End Sub

    Sub LimpiarDatosCliente()
        txtNombre.Text = ""
        txtDUI.Text = ""
        txtTelefono.Text = ""
        txtEmail.Text = ""
    End Sub

    Private Sub btnPrimero_Click(sender As Object, e As EventArgs) Handles btnPrimero.Click
        Posicion = 0
        MostrarDatosCliente()
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        If Posicion > 0 Then
            Posicion -= 1
            MostrarDatosCliente()
        Else
            MessageBox.Show("Ya te encuentras en el primer registro.", "Registro de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        If Posicion < dataTable.Rows.Count - 1 Then
            Posicion += 1
            MostrarDatosCliente()
        Else
            MessageBox.Show("Ya te encuentras en el ultimo registro.", "Registro de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        Posicion = dataTable.Rows.Count - 1
        MostrarDatosCliente()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        If btnNuevo.Text = "Nuevo" Then 'Nuevo
            btnNuevo.Text = "Guardar"
            btnModificar.Text = "Cancelar"
            Accion = "nuevo"

            HabDescontroles(False)
            LimpiarDatosCliente()
        Else 'Guardar
            Dim msg = objConexion.mantenimientoDatosClientes(New String() {Me.Tag, txtcode.Text, txtNombre.Text, txtDUI.Text, txtTelefono.Text, txtEmail.Text}, Accion)
            If msg = "error" Then
                MessageBox.Show("Error al intentar guardar el registro, por favor intente nuevamente.", "Registro de Usuario",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                ObtenrDatosCliente()
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
            ObtenrDatosCliente()
        End If

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If (MessageBox.Show("¿Estas seguro de borrar este registro?", "Registro Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
            objConexion.mantenimientoDatosClientes(New String() {Me.Tag}, "eliminar")
            If Posicion > 0 Then
                Posicion -= 1
            End If
            ObtenrDatosCliente()
        End If
    End Sub
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim objBuscarCliente As New FormBusquedaClientes
        objBuscarCliente.ShowDialog()
        If objBuscarCliente._idC > 0 Then
            Posicion = dataTable.Rows.IndexOf(dataTable.Rows.Find(objBuscarCliente._idC))
            MostrarDatosCliente()
        End If
    End Sub
End Class