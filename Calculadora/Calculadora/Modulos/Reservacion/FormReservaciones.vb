Public Class FormReservaciones
    Dim objConexion As New db_conexion()
    Dim dataTable As New DataTable
    Dim posicion As Integer
    Dim estadoReserva As String = "Reservado"
    Dim accion As String = "nuevo"
    Dim accionHabitacion As String = "actuliazar"
    Dim NumReservacion As Integer = 0
    Private Sub FormReservaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'dias()
        ObtenerDatos()
        btnAgregar.Visible = True
    End Sub

    Sub ObtenerDatos()
        dataTable = objConexion.obtenerDatosTablas.Tables("Reservaciones")
        dataTable.PrimaryKey = New DataColumn() {dataTable.Columns("idReservaciones")}

        grdHabitaciones.DataSource = objConexion.FiltroReservaciones.Tables("Reservaciones").DefaultView()

        MostrarDatos()
    End Sub

    Sub MostrarDatos()
        If dataTable.Rows.Count > 0 Then
            Me.Tag = dataTable.Rows(posicion).ItemArray(0).ToString()
            txtCliente.Text = dataTable.Rows(posicion).ItemArray(1).ToString()
            txtEmpleado.Text = dataTable.Rows(posicion).ItemArray(2).ToString()
            txtHabitacion.Text = dataTable.Rows(posicion).ItemArray(3).ToString()
            DateEntrada.Value = dataTable.Rows(posicion).ItemArray(4).ToString()
            DateSalida.Value = dataTable.Rows(posicion).ItemArray(5).ToString()
            txtDias.Text = dataTable.Rows(posicion).ItemArray(6).ToString()
            txtPrecioDia.Text = dataTable.Rows(posicion).ItemArray(7).ToString()
            txtTotal.Text = dataTable.Rows(posicion).ItemArray(8).ToString()
            estadoReserva = dataTable.Rows(posicion).ItemArray(9).ToString()

            lblPosicion.Text = posicion + 1 & " de " & dataTable.Rows.Count
        Else
            LimpiarDatos()
            'MessageBox.Show("No hay registros que mostrar", "Registro Reservaciones", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Sub LimpiarDatos()
        txtCliente.Text = ""
        txtHabitacion.Text = ""
        DateEntrada.Value = Today
        DateSalida.Value = Today
        txtPrecioDia.Text = ""
        txtTotal.Text = "$0.00"
    End Sub

    Sub HabDescontroles(ByVal estado As Boolean)
        txtCliente.Enabled = Not estado
        txtHabitacion.Enabled = Not estado
        txtPrecioDia.Enabled = Not estado
        txtTotal.Enabled = Not estado
        grbReservacion.Enabled = Not estado
        DateEntrada.Enabled = Not estado
        DateSalida.Enabled = Not estado
        txtDias.Enabled = Not estado
    End Sub
    Private Sub btnHabitaciones_Click(sender As Object, e As EventArgs) Handles btnHabitaciones.Click
        Dim frm As New FormHabitacion
        AddOwnedForm(frm)
        frm.ShowDialog()
    End Sub
    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        Dim frm As New FormCliente
        AddOwnedForm(frm)
        frm.ShowDialog()
    End Sub
    Sub dias()
        Dim dias As Integer
        Dim entrada As Date = DateEntrada.Value
        Dim salida As Date = DateSalida.Value

        dias = DateDiff("d", entrada, salida)
        txtDias.Text = dias
    End Sub
    Sub total()
        Dim total As Double
        Dim dia As Double = txtDias.Text
        Dim precioDia As Double = txtPrecioDia.Text
        total = (precioDia * dia)
        txtTotal.Text = "$ " & total
    End Sub

    Private Sub txtDias_Click(sender As Object, e As EventArgs) Handles txtDias.Click
        dias()
    End Sub

    Private Sub txtTotal_Click(sender As Object, e As EventArgs) Handles txtTotal.Click
        total()
    End Sub

    Private Sub btnPrimero_Click(sender As Object, e As EventArgs) Handles btnPrimero.Click
        posicion = 0
        MostrarDatos()
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        If posicion > 0 Then
            posicion -= 1
            MostrarDatos()
        Else
            MessageBox.Show("Ya te encuentras en el primer registro.", "Reservaciones", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        If posicion < dataTable.Rows.Count - 1 Then
            posicion += 1
            MostrarDatos()
        Else
            MessageBox.Show("Ya te encuentras en el Ultimo registro.", "Reservaciones", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        posicion = dataTable.Rows.Count - 1
        MostrarDatos()
    End Sub

    Private Sub btnAgregar_Click_1(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If btnAgregar.Text = "Nuevo" Then 'Nuevo
            btnAgregar.Text = "Guardar"
            btnModificar.Text = "Cancelar"
            accion = "nuevo"

            LimpiarDatos()
            HabDescontroles(False)
            'lblNumReservacion.Text = NumReservacion + 1
        Else 'Guardarsdvmidfj
            estadoReserva = "Reservado"
            Dim msg = objConexion.mantenimientoDatosReservaciones(New String() {
                Me.Tag,
                txtCliente.Text,
                txtEmpleado.Text,
                txtHabitacion.Text,
                DateEntrada.Value,
                DateSalida.Value,
                txtDias.Text,
                txtPrecioDia.Text,
                txtTotal.Text,
                estadoReserva
            }, accion)

            If msg = "error" Then
                MessageBox.Show("Debes completar todos los campos", "Registro reservaciones",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                ObtenerDatos()
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
            btnElimar.Enabled = False
            HabDescontroles(False)
        Else 'Cancelar
            accion = "modificar"
            ObtenerDatos()

            HabDescontroles(True)
            btnAgregar.Text = "Nuevo"
            btnModificar.Text = "Modificar"
        End If
    End Sub

    Private Sub btnElimar_Click(sender As Object, e As EventArgs) Handles btnElimar.Click
        If (MessageBox.Show("Esta seguro de borrar a " + txtDias.Text, "Registro de cliente",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
            objConexion.mantenimientoDatosUsuarios(New String() {Me.Tag}, "eliminar")
            If posicion > 0 Then
                posicion -= 1 'Hemos borrado un registro
            End If
            ObtenerDatos()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim objReservacion As New FormPago
        objReservacion.Show()
    End Sub
End Class