Public Class FormRegistroUsuario
    Dim objConexion As New db_conexion
    Dim dataTable As New DataTable
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim form As New FormBusquedaUsuario
        form.Show()
    End Sub
    Private Sub FormRegistroUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'obtenerDatos()
    End Sub

    Sub obtenerDatos()
        dataTable = objConexion.obtenerDatos().Tables("Usuarios")
        dataTable.PrimaryKey = New DataColumn() {dataTable.Columns("idUsuario")}
        mostrarDatos()
    End Sub

    Sub mostrarDatos()
        MessageBox.Show("Nombre: " + dataTable.Rows(0).ItemArray(1).ToString())
    End Sub
End Class