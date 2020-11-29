Public Class FormCategoria
    Dim objConexion As New db_conexion
    Dim dataTable As New DataTable
    Dim Accion As String = "nuevo"
    Dim Posicion As Integer = 0

    Private Sub FormCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ObtenerDatos()
        HabDesctontroles(True)
    End Sub

    Sub ObtenerDatos()
        dataTable = objConexion.obtenerDatosTablas().tables("Categoria")
        dataTable.PrimaryKey = New DataColumn() {dataTable.Columns("idCategoria")}
        MostrarDatos()
    End Sub

    Sub HabDesctontroles(ByVal estado As Boolean)
        txtCategoria.Enabled = Not estado
        grbPosicion.Enabled = estado
        btnEliminar.Enabled = estado
        btnBuscar.Enabled = estado
    End Sub

    Sub MostrarDatos()
        If DataTable.Rows.Count > 0 Then
            Me.Tag = DataTable.Rows(Posicion).ItemArray(0).ToString()
            txtCategoria.Text = dataTable.Rows(Posicion).ItemArray(1).ToString()
            lblPosicion.Text = Posicion + 1 & " de " & dataTable.Rows.Count

        Else
            txtCategoria.Text = ""
            MessageBox.Show("No hay registros que mostrar", "Registro Categorias de Productos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnPrimero_Click(sender As Object, e As EventArgs) Handles btnPrimero.Click
        Posicion = 0
        MostrarDatos()
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        If Posicion > 0 Then
            Posicion -= 1
            MostrarDatos()
        Else
            MessageBox.Show("Ya te encuentras en el primer registro.", "Registro Categorias de Productos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        If Posicion < dataTable.Rows.Count - 1 Then
            Posicion += 1
            MostrarDatos()
        Else
            MessageBox.Show("Ya te encuentras en el ultimo.", "Registro Categorias de Productos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        Posicion = dataTable.Rows.Count - 1
        MostrarDatos()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        If btnNuevo.Text = "Nuevo" Then 'Nuevo
            btnNuevo.Text = "Guardar"
            btnModificar.Text = "Cancelar"
            Accion = "nuevo"

            HabDesctontroles(False)
            txtCategoria.Text = ""
        Else 'Guardar
            Dim msg = objConexion.mantenimientoDatosCategorias(New String() {Me.Tag, txtCategoria.Text}, Accion)
            If msg = "error" Then
                MessageBox.Show("Error al intentar guardar el registro, por favor intente nuevamente.", "Registro Categorias de Producto",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                ObtenerDatos()
                HabDesctontroles(True)
                btnNuevo.Text = "Nuevo"
                btnModificar.Text = "Modificar"
            End If
        End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If btnModificar.Text = "Modificar" Then 'Modificar
            btnNuevo.Text = "Guardar"
            btnModificar.Text = "Cancelar"
            Accion = "actualizar"
            HabDesctontroles(False)
        Else 'Cancelar
            ObtenerDatos()

            HabDesctontroles(True)
            btnNuevo.Text = "Nuevo"
            btnModificar.Text = "Modificar"
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If (MessageBox.Show("¿Estas seguro de borrar este registro?", "Registro Categorias de Producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
            objConexion.mantenimientoDatosCategorias(New String() {Me.Tag}, "eliminar")
            If Posicion > 0 Then
                Posicion -= 1
            End If
            ObtenerDatos()
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim objBuscarCaterigra As New FormBusquedaCategoria
        objBuscarCaterigra.ShowDialog()
        If objBuscarCaterigra._idCat > 0 Then
            Posicion = dataTable.Rows.IndexOf(dataTable.Rows.Find(objBuscarCaterigra._idCat))
            MostrarDatos()
        End If
    End Sub
End Class