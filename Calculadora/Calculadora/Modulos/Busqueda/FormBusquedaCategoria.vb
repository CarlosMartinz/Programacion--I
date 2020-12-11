Public Class FormBusquedaCategoria
    Dim objConexion As New db_conexion
    Public _idCat As Integer
    Private Sub FormBusquedaCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grdBuscarCategoria.DataSource = objConexion.insercionDatos().Tables("Categoria").DefaultView()
    End Sub

    Private Sub SeleccionCategoria()
        _idCat = grdBuscarCategoria.CurrentRow.Cells("idCategoria").Value.ToString()
        Close()
    End Sub

    Private Sub FiltrarDatosProducto(ByVal Valor As String)
        Dim bs As New BindingSource()
        bs.DataSource = grdBuscarCategoria.DataSource
        bs.Filter = "Categoria like '%" & Valor & "%'"
        grdBuscarCategoria.DataSource = bs
    End Sub

    Private Sub btnSelecionarCategoria_Click(sender As Object, e As EventArgs) Handles btnSelecionarCategoria.Click
        SeleccionCategoria()
    End Sub

    Private Sub txtBuscarCategoria_KeyUp(sender As Object, e As KeyEventArgs) Handles txtBuscarCategoria.KeyUp
        FiltrarDatosProducto(txtBuscarCategoria.Text)
        If e.KeyCode = 13 Then
            SeleccionCategoria()
        End If
    End Sub

    Private Sub btnCancelarCategoria_Click(sender As Object, e As EventArgs) Handles btnCancelarCategoria.Click
        _idCat = 0
        Close()
    End Sub
End Class