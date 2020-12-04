Public Class FormBusquedaProductos
    Dim objConexion As New db_conexion
    Public _idP As String

    Private Sub FormBusquedaProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grdBuscarProducto.DataSource = objConexion.obtenerDatosTablas().Tables("Producto").DefaultView
        grdBuscarProducto.Columns("idCategoria").Visible = False
        grdBuscarProducto.Columns("idProducto").Visible = False
        grdBuscarProducto.Columns("Descripcion").HeaderText = "Nombre"
    End Sub

    Private Sub SeleccionProducto()
        _idP = grdBuscarProducto.CurrentRow.Cells("idProducto").Value.ToString()
        Close()
    End Sub

    Private Sub FiltrarDatosProducto(ByVal Valor As String)
        Dim bs As New BindingSource()
        bs.DataSource = grdBuscarProducto.DataSource
        bs.Filter = "Categoria like '%" + Valor +
            "%' or Codigo like '%" + Valor + "%' or Descripcion like '%" + Valor +
            "%' or Precio like '%" + Valor + "%'"
        grdBuscarProducto.DataSource = bs
    End Sub

    Private Sub btnSelecionarProducto_Click(sender As Object, e As EventArgs) Handles btnSelecionarProducto.Click
        SeleccionProducto()
    End Sub

    Private Sub txtBuscarProducto_KeyUp(sender As Object, e As KeyEventArgs) Handles txtBuscarProducto.KeyUp
        FiltrarDatosProducto(txtBuscarProducto.Text)
        If e.KeyCode = 13 Then
            SeleccionProducto()
        End If
    End Sub

    Private Sub btnCancelarProducto_Click(sender As Object, e As EventArgs) Handles btnCancelarProducto.Click
        _idP = 0
        Close()
    End Sub
End Class