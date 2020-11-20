Public Class FormReservaciones
    Dim objConexion As New db_conexion()
    Dim dataTable As New DataTable
    Dim posicion As Integer = 0
    Dim accion As String
    Private Sub FormReservaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dias()
        ObtenerDatos()
    End Sub

    Sub ObtenerDatos()
        dataTable = objConexion.obtenerDatosTablas.Tables("Reservaciones")
        dataTable.PrimaryKey = New DataColumn() {dataTable.Columns("idReservaciones")}

        MostrarDatos()
    End Sub

    Sub MostrarDatos()
        If dataTable.Rows.Count > 0 Then
            Me.Tag = dataTable.Rows(posicion).ItemArray(0).ToString()
            lblNumReservacion.Text = dataTable.Rows(posicion).ItemArray(0).ToString()
            txtCliente.Text = dataTable.Rows(posicion).ItemArray(1).ToString()
            txtEmpleado.Text = dataTable.Rows(posicion).ItemArray(2).ToString()
            txtHabitacion.Text = dataTable.Rows(posicion).ItemArray(3).ToString()
            DateEntrada.Value = dataTable.Rows(posicion).ItemArray(4).ToString()
            DateSalida.Value = dataTable.Rows(posicion).ItemArray(5).ToString()
            txtPrecioDia.Text = dataTable.Rows(posicion).ItemArray(6).ToString()
        Else
            LimpiarDatos()
            MessageBox.Show("No hay registros que mostrar", "Registro Reservaciones", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
        grbReservacion.Enabled = Not estado
        btnElimar.Enabled = estado
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
        txtTotal.Text = "$" + total
    End Sub
    Private Sub txtDias_Click(sender As Object, e As EventArgs) Handles txtDias.Click
        dias()
    End Sub
    Private Sub txtTotal_Click(sender As Object, e As EventArgs) Handles txtTotal.Click
        total()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs)
        If btnAgregar.Text = "Nuevo" Then 'Nuevo
            btnAgregar.Text = "Guardar"
            btnModificar.Text = "Cancelar"
            accion = "nuevo"

            LimpiarDatos()
            lblNumReservacion.Text = lblNumReservacion.Text + 1
        Else 'Guardar

        End If
    End Sub
End Class