Public Class FormCliente
    Dim objConexion As New db_conexion()
    Dim dataTable As New DataTable
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub
    'Private Sub grdHabitaciones_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdHabitaciones.CellDoubleClick, grdCliente.CellDoubleClick
    '    Dim frm As FormReservaciones = CType(Owner, FormReservaciones)
    '    frm.txtCliente.Text = grdCliente.CurrentRow.Cells(0).Value.ToString
    '    Me.Close()
    'End Sub
    Sub Cliente()
        'Mostrar Datos de tabla habitaciones libre
        dataTable = objConexion.obtenerDatos().Tables("clientes")
        dataTable.PrimaryKey = New DataColumn() {dataTable.Columns("idcliente")}

        grdCliente.DataSource = objConexion.obtenerDatos().Tables("clientes").DefaultView
    End Sub

    Private Sub FormCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cliente()
    End Sub

    Private Sub grdCliente_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdCliente.CellDoubleClick
        Dim frm As FormReservaciones = CType(Owner, FormReservaciones)
        frm.txtCliente.Text = grdCliente.CurrentRow.Cells(0).Value.ToString
        Me.Close()
    End Sub
End Class