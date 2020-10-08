Public Class FormPrincipal
    Dim objConexion As New db_conexion
    Dim dataTable As New DataTable
    Private Sub RegistrarUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarUsuarioToolStripMenuItem.Click
        Dim form As New FormRegistroUsuario
        form.MdiParent = Me

        form.Show()
    End Sub

    Sub obtenerDatos()

        dataTable = objConexion.obtenerDatos().Tables("Usuarios")
        dataTable.PrimaryKey = New DataColumn() {dataTable.Columns("idUsuario")}
        'mostrarDatos()
    End Sub

    Sub mostrarDatos()
        MessageBox.Show("Nombre: " + dataTable.Rows(0).ItemArray(3).ToString())
    End Sub

    Private Sub FormPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        obtenerDatos()
    End Sub
End Class
