Public Class FormReservaciones
    Dim objConexion As New db_conexion()
    Dim dataTable As New DataTable
    Dim posicion As Integer
    Dim accion As String = "nuevo"
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs)
        Close()

    End Sub
    Private Sub FormReservaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlBucar.Visible = False
        obtenerDatos()
    End Sub
    Sub desabilitar()
        btnBuscarCliente.Enabled = False
        'btnAgregarCliente.Visible = False
        'btnEditar.Enabled = True
        btnAgregar.Enabled = True
        btnCancelar.Enabled = True
    End Sub
    Sub obtenerDatos()
        dataTable = objConexion.obtenerDatosTablas().Tables("Habitacion")
        dataTable.PrimaryKey = New DataColumn() {dataTable.Columns("idHabitacion")}

        grdHabitaciones.DataSource = objConexion.obtenerDatosTablas().Tables("Habitacion").DefaultView

        grdCliente.DataSource = objConexion.obtenerDatosTablas().Tables("clientes").DefaultView
        'mostrarDatos()
    End Sub
    Sub mostrarDatos()
        If dataTable.Rows.Count > 0 Then
            Me.Tag = dataTable.Rows(posicion).ItemArray(0).ToString() 'ID de tipo de habitacion 
            txtCliente.Text = dataTable.Rows(posicion).ItemArray(0).ToString()
            txtEmpleado.Text = dataTable.Rows(posicion).ItemArray(1).ToString()
            DateEntrada.Text = dataTable.Rows(posicion).ItemArray(2).ToString()

        Else
            'limpiarDatos()
            MessageBox.Show("No hay registros que mostrar", "Registro de Productos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        btnBuscarCliente.Enabled = True
        'btnAgregarCliente.Visible = True
    End Sub
    Private Sub btnBuscarCliente_Click(sender As Object, e As EventArgs) Handles btnBuscarCliente.Click
        pnlBucar.Visible = True
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        pnlBucar.Visible = False
    End Sub

    Private Sub btnAgregarCliente_Click(sender As Object, e As EventArgs)
        Dim objUsuario As New FormClientes
        objUsuario.MdiParent = Me
        objUsuario.Show()
    End Sub
    Private Sub FiltrarDatosUsuario(ByVal Valor As String)
        Dim bs As New BindingSource()
        bs.DataSource = grdHabitaciones.DataSource
        bs.Filter = "TipoHabit like '%" & Valor & "%' or Capacidad like '%" & Valor & "%' or Estado = Libre like '%" & Valor & "%' or precio like '%" & Valor & "%' or Codigo like '%" & Valor & "%'"
        grdHabitaciones.DataSource = bs
    End Sub

    Private Sub txtBuscar_KeyUp(sender As Object, e As KeyEventArgs) Handles txtBuscar.KeyUp
        FiltrarDatosUsuario(txtBuscar.Text)
    End Sub
End Class