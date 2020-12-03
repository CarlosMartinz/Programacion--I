Public Class FormPago
    Dim objConexion As New db_conexion()
    Dim dataTable As New DataTable
    Dim posicion As Integer
    Dim accion As String = "nuevo"

    Private Sub FormPago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        obtenerDatos()
    End Sub

    Sub obtenerDatos()
        dataTable = objConexion.obtenerDatosTablas().Tables("usuarios")
        dataTable.PrimaryKey = New DataColumn() {dataTable.Columns("idUsuario")}

        cboFactu.DataSource = objConexion.obtenerDatosTablas().Tables("TipoFactu").DefaultView()
        cboFactu.DisplayMember = "TipoFactura"
        cboFactu.ValueMember = "TipoFactu.TipoFactura"

        'mostrarDatos()
    End Sub
End Class