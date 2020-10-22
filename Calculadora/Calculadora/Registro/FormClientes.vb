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
            txtNombre.Text = dataTable.Rows(Posicion).ItemArray(1).ToString()
            txtNumDeDoc.Text = dataTable.Rows(Posicion).ItemArray(2).ToString()
            txtTelefono.Text = dataTable.Rows(Posicion).ItemArray(3).ToString()
            txtEmail.Text = dataTable.Rows(Posicion).ItemArray(4).ToString()

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
        txtNumDeDoc.Text = ""
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
        Else
            MessageBox.Show("Ya te encuentras en el ultimo registro.", "Registro de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class