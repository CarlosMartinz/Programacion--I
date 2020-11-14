Public Class FormHabitacion
    Dim objConexion As New db_conexion()
    Dim dataTable As New DataTable
    Private Sub FormHabitacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HabitacionesLibre()
    End Sub
    Sub HabitacionesLibre()
        'Mostrar Datos de tabla habitaciones libre
        DataTable = objConexion.FiltroHabitacionLibre().Tables("Habitacion")
        DataTable.PrimaryKey = New DataColumn() {DataTable.Columns("idHabitacion")}

        grdHabitaciones.DataSource = objConexion.FiltroHabitacionLibre().Tables("Habitacion").DefaultView
    End Sub
    Private Sub TextBox1_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyUp
        FiltrarDatos(TextBox1.Text)
    End Sub
    Private Sub FiltrarDatos(ByVal Valor As String)
        Dim bs As New BindingSource()
        bs.DataSource = grdHabitaciones.DataSource
        bs.Filter = "TipoHabit like '%" & Valor & "%' or Capacidad like '%" & Valor & "%' or Estado = Libre like '%" & Valor & "%' or precio like '%" & Valor & "%' or Codigo like '%" & Valor & "%'"
        grdHabitaciones.DataSource = bs
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub grdHabitaciones_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdHabitaciones.CellDoubleClick
        Dim frm As FormReservaciones = CType(Owner, FormReservaciones)
        frm.txtHabitacion.Text = grdHabitaciones.CurrentRow.Cells(0).Value.ToString
        frm.txtPrecioDia.Text = grdHabitaciones.CurrentRow.Cells(4).Value.ToString
        Me.Close()
    End Sub
End Class