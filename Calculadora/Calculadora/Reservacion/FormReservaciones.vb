Public Class FormReservaciones
    Dim objConexion As New db_conexion()
    Dim dataTable As New DataTable
    Private Sub FormReservaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dias()
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
        txtTotal.Text = total
    End Sub
    Private Sub txtDias_Click(sender As Object, e As EventArgs) Handles txtDias.Click
        dias()
    End Sub
    Private Sub txtTotal_Click(sender As Object, e As EventArgs) Handles txtTotal.Click
        total()
    End Sub
End Class